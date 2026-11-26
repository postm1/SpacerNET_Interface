using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using SpacerUnion.Common;

namespace SpacerUnion.Windows
{
    // Unified settings window that replaces the old "Camera settings", "Vobs settings" and
    // "Misc settings" dialogs.
    //
    // The page is generated from the catalog (SettingsMain.Catalog.cs): every option becomes a row
    // and every row knows how to read and write its value through the C++ settings stack. The search
    // box filters options of ALL categories at once, the list on the left only scrolls the page.
    public partial class SettingsMain : Form
    {
        private const int NavAllIndex = -1;

        // Category ids MainForm opens the page at (Settings -> Camera / Vobs / Misc).
        public const string CategoryCamera = CAT_CAMERA;
        public const string CategoryVobs = CAT_VOBS;
        public const string CategoryMisc = CAT_MISC;

        private const int TrackRowHeight = 26;
        private const int NumberBoxWidth = 74;
        private const int FieldGap = 12;

        private readonly List<Setting> settings = new List<Setting>();
        private readonly Dictionary<string, Setting> byKey = new Dictionary<string, Setting>();
        private readonly List<CategoryInfo> categories = new List<CategoryInfo>();
        private readonly List<Section> sections = new List<Section>();

        // Search state: all options stay on the page, the search only marks what it found and lets
        // the user walk through the marks (like in a browser).
        private readonly List<Setting> matches = new List<Setting>();
        private int matchIndex = -1;

        // Green marker of a found option: a stripe at the left edge of its section box.
        private const int MatchStripe = 4;
        private Color matchStripeColor = Color.FromArgb(60, 150, 60);
        private SolidBrush matchBrush;

        private TableLayoutPanel tableSections;
        private NavListBox navList;

        // Height of the whole page, measured by us: the scroll range is taken from it (see SetScroll).
        private int contentHeight;

        // The page is scrolled by us: the bar next to it, the current offset and the wheel hook.
        private VScrollBar pageScrollBar;
        private int scrollOffset;
        private WheelHook wheel;

        // One notch of the mouse wheel walks three options of the page.
        private const int WheelStep = 24;
        private const int WheelLines = 3;

        // A blank line between unrelated options of one section.
        private const int SeparatorHeight = 16;

        private string searchPlaceholder = "";
        private bool placeholderShown;

        // Place of the search field inside its frame: measured once, -1 means "not measured yet".
        private int searchFieldTop = -1;

        // true while values are read from the core: value changed handlers must not write back.
        private bool loading;
        // true once LoadSettings() has run: without real values ApplyAll() would push stale defaults.
        private bool loaded;
        // true while the navigation selection is synced from the scroll position.
        private bool syncingNav;

        // Width and font the page was measured for: -1 means "measuring is needed again".
        private int measuredWidth = -1;
        private Font measuredFont;

        // true while a measuring pass runs or one is queued behind a burst of resize messages.
        private bool relayoutBusy;
        private bool relayoutQueued;

        //======================================== paint batching ============================================

        // Every property we set invalidates its control, so a batch of them makes the page paint itself
        // over and over while it is still incomplete. Redraw is switched off for the time of a batch -
        // SuspendLayout does not help here, it stops layout but not painting.

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprcUpdate, IntPtr hrgnUpdate, uint flags);

        private const int WmSetRedraw = 0x000B;

        // WM_SETREDRAW turns the children off together with the window, and an ordinary Invalidate() to
        // the parent does not reach them - the page would stay half empty. Only RedrawWindow with
        // RDW_ALLCHILDREN paints every control of the window. RDW_UPDATENOW is what makes the controls
        // paint themselves right away: RDW_ERASENOW only erases the places, and everything that draws
        // itself (the buttons of the search, the list on the left, the stripes of the matches) would
        // stand there empty until some other reason finally painted it.
        private const uint RedrawEverything = 0x0001 /* RDW_INVALIDATE */ | 0x0004 /* RDW_ERASE */
            | 0x0080 /* RDW_ALLCHILDREN */ | 0x0100 /* RDW_UPDATENOW */ | 0x0400 /* RDW_FRAME */;

        private int paintLock;
        private bool paintSuspended;

        // Batches may nest (opening the page reads values, which repaints rows), only the outermost one
        // touches the window.
        private void BeginPaintBatch()
        {
            paintLock++;

            if (paintLock != 1 || paintSuspended || !IsHandleCreated)
            {
                return;
            }

            paintSuspended = true;
            SendMessage(Handle, WmSetRedraw, IntPtr.Zero, IntPtr.Zero);
        }

        private void EndPaintBatch()
        {
            if (paintLock > 0)
            {
                paintLock--;
            }

            if (paintLock != 0 || !paintSuspended)
            {
                return;
            }

            paintSuspended = false;

            if (!IsHandleCreated)
            {
                return;
            }

            SendMessage(Handle, WmSetRedraw, new IntPtr(1), IntPtr.Zero);

            // Everything the batch invalidated is marked again, this time for the whole window with all
            // its controls: without RDW_ALLCHILDREN the left list, the buttons and the bottom bar stayed
            // unpainted.
            RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero, RedrawEverything);
        }

        // One measuring pass of the whole page instead of one per message of a resize drag.
        private void QueueRelayout()
        {
            measuredWidth = -1;

            if (relayoutQueued || !IsHandleCreated)
            {
                return;
            }

            relayoutQueued = true;

            BeginInvoke(new MethodInvoker(delegate
            {
                relayoutQueued = false;
                RelayoutPage();
            }));
        }

        public SettingsMain()
        {
            InitializeComponent();

            settings.AddRange(BuildCatalog());
            foreach (Setting setting in settings)
            {
                byKey[setting.Key] = setting;
            }

            CollectCategories();
            BuildPage();
            BuildScrollBar();
            BuildNavigation();
            UseCenteredSearchBox();
            SetupSearchBox();
            WireFormEvents();
            LayoutSearchRow();

            UpdateLang();
            ApplyCustomTheme();
            UpdateDependencies();
        }

        //=========================================== public API ===========================================

        // Opens the page. category may be null (whole page) or one of the CAT_... constants.
        public void ShowSettings(string category)
        {
            BeginPaintBatch();
            try
            {
                LoadSettings();

                Show();
                BringToFront();

                RelayoutPage();
                ScrollToCategory(category);
            }
            finally
            {
                EndPaintBatch();
            }
        }

        // Value of a boolean option, used by other classes (CProperty, MainForm).
        public bool GetFlag(string key)
        {
            Setting setting;
            if (byKey.TryGetValue(key, out setting))
            {
                return setting.Flag;
            }
            return false;
        }

        public int GetValue(string key)
        {
            Setting setting;
            if (byKey.TryGetValue(key, out setting))
            {
                return setting.Value;
            }
            return 0;
        }

        // Reads every option from the core and shows it on the page.
        public void LoadSettings()
        {
            loading = true;

            BeginPaintBatch();
            try
            {
                foreach (Setting setting in settings)
                {
                    ReadValue(setting);
                }

                foreach (Setting setting in settings)
                {
                    SyncCaption(setting);
                }
            }
            finally
            {
                EndPaintBatch();
                loading = false;
            }

            loaded = true;

            UpdateDependencies();

            // Interface reaction the old MiscSettingsWin.LoadSettings() showed on start up.
            if (SpacerNET.form != null)
            {
                SpacerNET.form.ApplyStatusBarVisibility(GetFlag("showStatusBar"));
            }

            UpdateSearch();
        }

        // Writes the changed options back to the core (Apply button and closing the window). An option
        // nobody touched is not written: the core has to hear only what really differs.
        public void ApplyAll()
        {
            foreach (Setting setting in settings)
            {
                if (!setting.Dirty)
                {
                    continue;
                }

                PushValue(setting, false);
                setting.Dirty = false;
            }
        }

        // Fills all captions of the page with the current language.
        public void UpdateLang()
        {
            BeginPaintBatch();
            try
            {
                UpdateLangCaptions();
            }
            finally
            {
                EndPaintBatch();
            }

            // Captions of another language are wider or shorter, so the docked panels moved their controls
            // about, and the places they left behind still show the picture of the previous language. The
            // window has to be laid out and painted over from head to toe.
            RefreshWholeWindow();
        }

        // Lays the window out again and paints every control of it.
        private void RefreshWholeWindow()
        {
            if (IsDisposed || !IsHandleCreated || !Visible)
            {
                return;
            }

            LayoutTree(this);

            Invalidate(true);

            RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero, RedrawEverything);
        }

        // Every container of the window lays out again, the deepest ones first, so that another language
        // never leaves a control on the place the previous language had given it.
        private static void LayoutTree(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control.HasChildren)
                {
                    LayoutTree(control);
                }
            }

            parent.PerformLayout();
        }

        private void UpdateLangCaptions()
        {
            Text = Localizator.Get("WIN_SETTINGS_MAIN");
            buttonApply.Text = Localizator.Get("BTN_APPLY");
            labelApplyHint.Text = Localizator.Get("SETTINGS_APPLY_HINT");
            buttonClearSearch.Text = ClearGlyph;

            searchPlaceholder = Localizator.Get("SETTINGS_SEARCH_HINT");
            if (placeholderShown)
            {
                textBoxSearch.Text = searchPlaceholder;
            }

            foreach (Section section in sections)
            {
                section.Box.Text = Localizator.Get(section.TitleKey);
            }

            foreach (Setting setting in settings)
            {
                // Hidden options and blank lines have no caption at all.
                if (!IsOption(setting))
                {
                    continue;
                }

                for (int i = 0; i < setting.Radios.Count; i++)
                {
                    setting.Radios[i].Text = Localizator.Get(setting.RadioKeys[i]);
                }

                if (setting.Hint != null)
                {
                    setting.Hint.Text = Localizator.Get(setting.HintLocKey);
                }

                SyncCaption(setting);
            }

            BuildSearchText();

            // The list on the left is only rebuilt here: the search never touches it.
            RefreshNavigation();
            UpdateSearch();

            // Another language means other captions, and the heights of the page are measured from them.
            measuredWidth = -1;
            RelayoutPage();
        }

        //============================================ build page ==========================================

        private void CollectCategories()
        {
            foreach (Setting setting in settings)
            {
                // A hidden option keeps its place in the catalog, but the page never hears of it: no box,
                // no row, no place in the height of the page.
                if (setting.Hidden)
                {
                    continue;
                }

                CategoryInfo category = FindCategory(setting.Category);
                Section section = FindSection(category, setting);
                section.Items.Add(setting);
            }

            // The first box of a category is its main one: "Camera", "Vobs settings", "Misc settings".
            for (int i = 0; i < categories.Count; i++)
            {
                if (categories[i].Sections.Count != 0)
                {
                    categories[i].Sections[0].MainTitle = true;
                }
            }
        }

        private CategoryInfo FindCategory(string id)
        {
            for (int i = 0; i < categories.Count; i++)
            {
                if (categories[i].Id == id)
                {
                    return categories[i];
                }
            }

            CategoryInfo category = new CategoryInfo();
            category.Id = id;
            category.TitleKey = CategoryTitleKey(id);
            categories.Add(category);
            return category;
        }

        private Section FindSection(CategoryInfo category, Setting setting)
        {
            string titleKey = SectionTitleKey(setting);

            for (int i = 0; i < category.Sections.Count; i++)
            {
                if (category.Sections[i].TitleKey == titleKey)
                {
                    return category.Sections[i];
                }
            }

            Section section = new Section();
            section.Category = category.Id;
            section.TitleKey = titleKey;
            category.Sections.Add(section);
            sections.Add(section);
            return section;
        }

        private static string CategoryTitleKey(string category)
        {
            switch (category)
            {
                case CAT_CAMERA: return "WIN_CONTROLCAM_TEXT";
                case CAT_VOBS: return "WIN_CONTROLSET_TEXT";
                default: return "WIN_MISC_SET";
            }
        }

        // A category without subgroups gets a single box titled with the category name.
        private static string SectionTitleKey(Setting setting)
        {
            if (setting.Group.Length == 0)
            {
                return CategoryTitleKey(setting.Category);
            }
            return setting.Group;
        }

        private void BuildPage()
        {
            tableSections = new TableLayoutPanel();

            // Not Dock.Top: a docked control pins the scroll position of the panel, and every place we
            // set through AutoScrollPosition is thrown away on the next layout pass. Plain children of
            // an auto scrolling panel are placed by hand, see UpdateScrollSize.
            tableSections.Dock = DockStyle.None;
            tableSections.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            tableSections.AutoSize = false;
            tableSections.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            tableSections.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            tableSections.Margin = new Padding(0);
            tableSections.Padding = new Padding(0);
            tableSections.ColumnCount = 1;
            tableSections.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tableSections.Location = new Point(panelContent.Padding.Left, panelContent.Padding.Top);

            foreach (Section section in sections)
            {
                SectionBox box = new SectionBox();
                box.BoldTitle = section.MainTitle;
                // Standard, not System: only then the .NET group box paints the caption itself and we
                // are able to redraw it bold on top of it.
                box.FlatStyle = FlatStyle.Standard;
                box.Dock = DockStyle.Fill;
                box.AutoSize = false;
                box.Height = 40;
                box.Margin = new Padding(0, 4, 0, 10);
                box.Padding = new Padding(12, 6, 12, 10);
                box.TabStop = false;

                TableLayoutPanel table = new TableLayoutPanel();
                table.Dock = DockStyle.Fill;
                table.AutoSize = false;
                table.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
                table.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                table.Margin = new Padding(0);
                table.Padding = new Padding(0);
                table.ColumnCount = 1;
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

                foreach (Setting setting in section.Items)
                {
                    Control row = BuildRow(setting);
                    row.Tag = setting;
                    table.Controls.Add(row);
                }

                box.Controls.Add(table);
                box.Tag = section;
                box.Paint += new PaintEventHandler(OnSectionPaint);
                section.Box = box;
                section.Table = table;

                tableSections.Controls.Add(box);
            }

            panelContent.Controls.Add(tableSections);
        }

        // Builds the row control of one option; this control is what the search hides.
        private Control BuildRow(Setting setting)
        {
            switch (setting.Kind)
            {
                case SettingKind.CheckBox:
                    return BuildCheckRow(setting);

                case SettingKind.Track:
                case SettingKind.TrackBox:
                    return BuildTrackRow(setting, setting.Kind == SettingKind.TrackBox);

                case SettingKind.CheckTrack:
                    return BuildCheckTrackRow(setting);

                case SettingKind.Number:
                    return BuildNumberRow(setting);

                case SettingKind.RadioGroup:
                    return BuildRadioRow(setting);

                case SettingKind.Separator:
                    return BuildSeparatorRow(setting);
            }

            return BuildCheckRow(setting);
        }

        // A blank line of a section: the row holds nothing but a fixed height, so the options around it
        // stay visible but apart from each other.
        private Control BuildSeparatorRow(Setting setting)
        {
            TableLayoutPanel row = NewRowTable(new ColumnStyle(SizeType.AutoSize));

            Label space = new Label();
            space.AutoSize = false;
            space.Height = SeparatorHeight;
            space.Margin = new Padding(0);
            row.Controls.Add(space, 0, 0);

            setting.Row = row;
            return row;
        }

        // A single check box is wrapped into a row table as well, so every row of the page reserves
        // the same space for the stripe of a search hit.
        private Control BuildCheckRow(Setting setting)
        {
            TableLayoutPanel row = NewRowTable(new ColumnStyle(SizeType.AutoSize));

            CheckBox box = NewCheckBox(setting);
            row.Controls.Add(box, 0, 0);

            setting.Box = box;
            setting.Main = box;
            setting.Row = row;
            return row;
        }

        private Control BuildTrackRow(Setting setting, bool withNumberBox)
        {
            TableLayoutPanel row = withNumberBox
                ? NewRowTable(new ColumnStyle(SizeType.AutoSize), new ColumnStyle(SizeType.Percent, 100), new ColumnStyle(SizeType.Absolute, NumberBoxWidth))
                : NewRowTable(new ColumnStyle(SizeType.AutoSize), new ColumnStyle(SizeType.Percent, 100));

            Label caption = NewCaption();
            row.Controls.Add(caption, 0, 0);

            TrackBar track = NewTrackBar(setting);
            row.Controls.Add(track, 1, 0);

            if (withNumberBox)
            {
                TextBox number = NewNumberBox(setting);
                row.Controls.Add(number, 2, 0);
                setting.Number = number;
            }
            else
            {
                row.SetColumnSpan(track, 2);
            }

            setting.Caption = caption;
            setting.Track = track;
            setting.Main = track;
            setting.Row = row;
            return row;
        }

        // Auto save and save reminder: the check box prints the minutes and owns the track bar.
        private Control BuildCheckTrackRow(Setting setting)
        {
            TableLayoutPanel row = NewRowTable(new ColumnStyle(SizeType.AutoSize), new ColumnStyle(SizeType.Percent, 100));

            CheckBox box = NewCheckBox(setting);
            row.Controls.Add(box, 0, 0);

            TrackBar track = NewTrackBar(setting);
            track.Enabled = false;
            row.Controls.Add(track, 1, 0);
            row.SetColumnSpan(track, 1);

            setting.Box = box;
            setting.Track = track;
            setting.Main = box;
            setting.Row = row;
            return row;
        }

        // Option with only a numeric box (Limit FPS) and a note like "*restart required".
        private Control BuildNumberRow(Setting setting)
        {
            TableLayoutPanel row = NewRowTable(new ColumnStyle(SizeType.AutoSize), new ColumnStyle(SizeType.AutoSize), new ColumnStyle(SizeType.AutoSize));

            Label caption = NewCaption();
            caption.Padding = new Padding(0, 5, 0, 0);
            row.Controls.Add(caption, 0, 0);

            TextBox number = NewNumberBox(setting);
            number.Dock = DockStyle.None;
            number.Width = NumberBoxWidth;
            number.Margin = new Padding(FieldGap, 4, 0, 4);
            row.Controls.Add(number, 1, 0);

            if (setting.HintLocKey != null)
            {
                Label hint = new Label();
                hint.AutoSize = true;
                hint.Text = Localizator.Get(setting.HintLocKey);
                hint.Margin = new Padding(FieldGap, 5, 0, 0);
                row.Controls.Add(hint, 2, 0);
                setting.Hint = hint;
            }

            setting.Caption = caption;
            setting.Number = number;
            setting.Main = number;
            setting.Row = row;
            return row;
        }

        // Option with a group of radio buttons (turn waypoints around when inserting).
        private Control BuildRadioRow(Setting setting)
        {
            TableLayoutPanel row = NewRowTable(new ColumnStyle(SizeType.AutoSize), new ColumnStyle(SizeType.AutoSize));

            Label caption = NewCaption();
            caption.Padding = new Padding(0, 3, 0, 0);
            row.Controls.Add(caption, 0, 0);

            FlowLayoutPanel options = new FlowLayoutPanel();
            options.AutoSize = true;
            options.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            options.FlowDirection = FlowDirection.TopDown;
            options.WrapContents = false;
            options.Margin = new Padding(FieldGap, 2, 0, 0);
            options.Padding = new Padding(0);
            row.Controls.Add(options, 1, 0);

            for (int i = 0; i < setting.RadioKeys.Length; i++)
            {
                RadioButton radio = new RadioButton();
                radio.AutoSize = true;
                radio.Margin = new Padding(0, 2, 24, 2);
                radio.Text = Localizator.Get(setting.RadioKeys[i]);
                radio.Tag = setting;
                radio.CheckedChanged += new EventHandler(OnRadioChanged);
                options.Controls.Add(radio);
                setting.Radios.Add(radio);
            }

            setting.Caption = caption;
            setting.Main = options;
            setting.Row = row;
            return row;
        }

        //========================================= row factories ==========================================

        private static TableLayoutPanel NewRowTable(params ColumnStyle[] columns)
        {
            TableLayoutPanel row = new TableLayoutPanel();
            row.Dock = DockStyle.Fill;
            row.AutoSize = true;
            row.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            row.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            row.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            row.Margin = new Padding(0, 3, 0, 3);
            row.Padding = new Padding(0);
            row.Padding = new Padding(0);
            row.ColumnCount = columns.Length;
            row.RowCount = 1;

            for (int i = 0; i < columns.Length; i++)
            {
                row.ColumnStyles.Add(columns[i]);
            }

            return row;
        }

        private CheckBox NewCheckBox(Setting setting)
        {
            CheckBox box = new CheckBox();
            box.AutoSize = true;
            box.Margin = new Padding(0, 4, 0, 4);
            box.Tag = setting;
            box.CheckedChanged += new EventHandler(OnCheckChanged);
            return box;
        }

        private static Label NewCaption()
        {
            Label caption = new Label();
            caption.AutoSize = true;
            caption.Margin = new Padding(0, 4, FieldGap, 4);
            return caption;
        }

        private TrackBar NewTrackBar(Setting setting)
        {
            PageTrackBar track = new PageTrackBar();
            track.Dock = DockStyle.Fill;
            track.Minimum = setting.Minimum;
            track.Maximum = setting.Maximum;
            track.TickStyle = TickStyle.None;
            track.AutoSize = false;
            track.Height = TrackRowHeight;
            track.Margin = new Padding(0, 3, 0, 3);
            track.Tag = setting;
            track.ValueChanged += new EventHandler(OnTrackChanged);
            return track;
        }

        private TextBox NewNumberBox(Setting setting)
        {
            TextBox number = new TextBox();
            number.Dock = DockStyle.Right;
            number.Width = NumberBoxWidth;
            number.TextAlign = HorizontalAlignment.Right;
            number.Margin = new Padding(0, 4, 0, 4);
            number.Tag = setting;
            number.TextChanged += new EventHandler(OnNumberChanged);
            number.KeyPress += new KeyPressEventHandler(OnNumberKeyPress);
            return number;
        }

        //============================================= search ==============================================

        // Height of the search row: the buttons next to the field follow the interface font, and the
        // host panel follows them. The field itself keeps the height of the font, see LayoutSearchField.
        private void LayoutSearchRow()
        {
            if (panelSearchHost == null || panelSearch == null || panelSearchButtons == null)
            {
                return;
            }

            // No vertical insets inside the frame: the field is centered by LayoutSearchField itself.
            panelSearch.Padding = new Padding(8, 0, 4, 0);

            int font = SearchFieldHeight;
            int height = Math.Max(panelSearchButtons.PreferredSize.Height, font + 6);

            // The frame of the field and the buttons next to it are the same height: the row of the
            // table above takes its own height from these controls, so it must not be bigger.
            panelSearch.Height = height;
            panelSearchHost.Height = height + panelSearchHost.Padding.Vertical;

            LayoutSearchField();
        }

        // Height of the search field: the height of the font plus a pixel above and below the line, so
        // that the bottom of letters with a descender always has place.
        private int SearchFieldHeight
        {
            get
            {
                return textBoxSearch.Font.Height + 2;
            }
        }

        // The field is as high as its font and sits in the middle of its frame. The frame never moves,
        // so that place is computed once and only reused; the width follows the window every time.
        private void LayoutSearchField()
        {
            if (textBoxSearch == null || panelSearch == null)
            {
                return;
            }

            if (searchFieldTop < 0)
            {
                searchFieldTop = (panelSearch.ClientSize.Height - SearchFieldHeight) / 2;

                if (searchFieldTop < 0)
                {
                    searchFieldTop = 0;
                }
            }

            int width = panelSearch.ClientSize.Width - panelSearch.Padding.Left - panelSearch.Padding.Right;

            if (width < 8)
            {
                width = 8;
            }

            textBoxSearch.SetBounds(panelSearch.Padding.Left, searchFieldTop, width, SearchFieldHeight);
        }

        // The designer creates an ordinary text box; the one that centers its text is a private helper,
        // so the control is swapped here. The field keeps its type: everything else works through it.
        private void UseCenteredSearchBox()
        {
            Control host = textBoxSearch.Parent;

            if (host == null)
            {
                return;
            }

            SearchTextBox field = new SearchTextBox();
            field.BorderStyle = textBoxSearch.BorderStyle;
            // Not Dock.Fill: the field keeps the height of its font and is placed by LayoutSearchField.
            field.Dock = DockStyle.None;
            field.Font = textBoxSearch.Font;
            field.TabIndex = textBoxSearch.TabIndex;

            host.Controls.Remove(textBoxSearch);
            textBoxSearch.Dispose();

            textBoxSearch = field;
            host.Controls.Add(field);
        }

        private void SetupSearchBox()
        {
            buttonClearSearch.Text = ClearGlyph;
            ShowPlaceholder();

            buttonClearSearch.Click += delegate { ClearSearch(); textBoxSearch.Focus(); };
            buttonSearchNext.Click += delegate { MoveMatch(1); textBoxSearch.Focus(); };
            buttonSearchPrev.Click += delegate { MoveMatch(-1); textBoxSearch.Focus(); };
            textBoxSearch.TextChanged += delegate { if (!placeholderShown) { UpdateSearch(); } };
            textBoxSearch.KeyDown += new KeyEventHandler(OnSearchKeyDown);
            textBoxSearch.GotFocus += delegate { HidePlaceholder(); };
            textBoxSearch.LostFocus += delegate { if (textBoxSearch.Text.Length == 0) { ShowPlaceholder(); } };
        }

        // The multiplication sign is available in every UI font, a "cross" glyph often is not.
        private static string ClearGlyph
        {
            get { return "\u00d7"; }
        }

        private void ShowPlaceholder()
        {
            placeholderShown = true;
            textBoxSearch.ForeColor = Theme.FgMuted;

            if (textBoxSearch.Text.Length == 0 || textBoxSearch.Text == searchPlaceholder)
            {
                textBoxSearch.Text = searchPlaceholder;
            }

            buttonClearSearch.Enabled = false;
        }

        private void HidePlaceholder()
        {
            if (!placeholderShown)
            {
                return;
            }

            placeholderShown = false;
            textBoxSearch.ForeColor = Theme.FgPrimary;

            if (textBoxSearch.Text == searchPlaceholder)
            {
                textBoxSearch.Text = "";
            }
        }

        private void ClearSearch()
        {
            placeholderShown = false;
            textBoxSearch.Text = "";
            ShowPlaceholder();
            UpdateSearch();
        }

        private string Query
        {
            get
            {
                if (placeholderShown)
                {
                    return "";
                }
                return textBoxSearch.Text.Trim();
            }
        }

        // The page is never rebuilt while searching: every option keeps its place, we only mark the
        // options that contain the query and remember them in page order.
        private void UpdateSearch()
        {
            string query = Query;
            bool searching = query.Length != 0;

            matches.Clear();
            matchIndex = -1;

            for (int i = 0; i < settings.Count; i++)
            {
                Setting setting = settings[i];

                // A hidden option and a blank line can never be a hit.
                if (!IsOption(setting))
                {
                    continue;
                }

                bool match = searching && setting.SearchText.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0;

                setting.IsMatch = match;

                if (match)
                {
                    matches.Add(setting);
                }

                // Every option starts without a mark: the one we are standing on gets it below.
                // Without this the row we visited before keeps its color for a query that no longer
                // matches it.
                SetRowBackground(setting, Theme.BgPanel);
            }

            for (int i = 0; i < sections.Count; i++)
            {
                sections[i].Box.Invalidate();
            }

            // Like a browser search: the first hit we are standing on right away.
            matchIndex = matches.Count != 0 ? 0 : -1;

            // The button is only dimmed while there is nothing to clear: hiding it would move the
            // buttons and the field of the search row around while typing.
            buttonClearSearch.Enabled = searching;
            buttonSearchPrev.Enabled = matches.Count != 0;
            buttonSearchNext.Enabled = matches.Count != 0;

            UpdateSearchInfo();

            if (matchIndex == 0)
            {
                ShowMatch();
            }
        }

        // "Found: 3 / 12" while walking through the hits, "Found: 12" before we jumped somewhere.
        private void UpdateSearchInfo()
        {
            if (matches.Count == 0)
            {
                labelSearchInfo.Text = Query.Length == 0
                    ? Localizator.Get("SETTINGS_ALL") + ": " + VisibleOptions()
                    : Localizator.Get("SETTINGS_NOTHING_FOUND");
                return;
            }

            string position = matchIndex < 0 ? "" : (matchIndex + 1) + " / ";

            labelSearchInfo.Text = Localizator.Get("SETTINGS_FOUND") + ": " + position + matches.Count;
        }

        // Walks through the found options: +1 forward, -1 backward, wrapping around at the edges.
        private void MoveMatch(int step)
        {
            if (matches.Count == 0)
            {
                return;
            }

            if (matchIndex < 0)
            {
                matchIndex = step > 0 ? 0 : matches.Count - 1;
            }
            else
            {
                matchIndex = (matchIndex + step) % matches.Count;
                if (matchIndex < 0)
                {
                    matchIndex += matches.Count;
                }
            }

            ShowMatch();
        }

        // Scrolls to the option we are standing on and paints the others without a highlight.
        private void ShowMatch()
        {
            for (int i = 0; i < matches.Count; i++)
            {
                SetRowBackground(matches[i], i == matchIndex ? MatchBackground : Theme.BgPanel);
            }

            Setting current = matches[matchIndex];

            if (current.Row != null)
            {
                ScrollToShow(current.Row);
            }

            UpdateSearchInfo();
        }

        // Fills the whole row of an option with a color: the row itself and every control that would
        // otherwise paint its own background over the highlight.
        private void SetRowBackground(Setting setting, Color color)
        {
            Control[] parts = new Control[]
            {
                setting.Row, setting.Box, setting.Caption, setting.Hint,
                setting.Track, setting.Number, setting.Main
            };

            foreach (Control part in parts)
            {
                if (part != null && !part.IsDisposed && part.BackColor != color)
                {
                    part.BackColor = color;
                }
            }

            for (int i = 0; i < setting.Radios.Count; i++)
            {
                RadioButton radio = setting.Radios[i];
                if (!radio.IsDisposed && radio.BackColor != color)
                {
                    radio.BackColor = color;
                }
            }
        }

        // Stripe on the left edge of every option the search has found. It is drawn on the section
        // box and not on the row itself: the controls of a row always stay to the right of it.
        private void OnSectionPaint(object sender, PaintEventArgs e)
        {
            if (matchBrush == null)
            {
                return;
            }

            Section section = ((Control)sender).Tag as Section;
            if (section == null)
            {
                return;
            }

            for (int i = 0; i < section.Items.Count; i++)
            {
                Setting setting = section.Items[i];

                if (!setting.IsMatch || setting.Row == null || !setting.Row.Visible)
                {
                    continue;
                }

                int top = 0;

                for (Control control = setting.Row; control != null && control != section.Box; control = control.Parent)
                {
                    top += control.Top;
                }

                e.Graphics.FillRectangle(matchBrush, 0, top + 1, MatchStripe, setting.Row.Height - 2);
            }
        }

        // Heights are measured once the window has its real width. Nothing but the width and the font
        // can change a height on this page - the search does not hide rows, and the options that depend
        // on each other only get enabled - so the measuring runs for those two cases only.
        private void RelayoutPage()
        {
            if (relayoutBusy)
            {
                return;
            }

            relayoutBusy = true;

            try
            {
                // Two passes: the bar of the scroll may appear with this height and take a few pixels of
                // the width, and the rows have to be measured for the width they really live in.
                for (int pass = 0; pass < 2; pass++)
                {
                    int width = PageWidth();

                    bool measured = contentHeight != 0 && width == measuredWidth && measuredFont == Font;

                    if (measured || (pass != 0 && width == measuredWidth))
                    {
                        break;
                    }

                    measuredWidth = width;
                    measuredFont = Font;

                    BeginPaintBatch();
                    try
                    {
                        for (int i = 0; i < sections.Count; i++)
                        {
                            UpdateSectionHeight(sections[i]);
                        }

                        UpdateScrollSize();
                    }
                    finally
                    {
                        EndPaintBatch();
                    }
                }
            }
            finally
            {
                relayoutBusy = false;
            }
        }

        // Width the page lives in: the panel without its padding and without the place of the bar. Both
        // the page and the measuring of the heights work from this value.
        private int PageWidth()
        {
            if (panelContent == null)
            {
                return 0;
            }

            int bar = pageScrollBar != null && pageScrollBar.Visible ? pageScrollBar.Width : 0;

            int width = panelContent.ClientSize.Width - panelContent.Padding.Horizontal - bar;

            return width < 100 ? 100 : width;
        }

        // The search matches the caption in every language, the keys of the core and the name of the
        // category, so "rangeVobs", the Russian caption and "vobs" all find the same option.
        private void BuildSearchText()
        {
            LangEnum[] langs = new LangEnum[] { LangEnum.RU, LangEnum.EN, LangEnum.DE, LangEnum.PL, LangEnum.CZ };

            foreach (Setting setting in settings)
            {
                // Hidden options and blank lines have nothing to search for.
                if (!IsOption(setting))
                {
                    continue;
                }

                StringBuilder text = new StringBuilder();

                AppendAllLanguages(text, setting.LocKey, langs);

                if (setting.RadioKeys != null)
                {
                    for (int i = 0; i < setting.RadioKeys.Length; i++)
                    {
                        AppendAllLanguages(text, setting.RadioKeys[i], langs);
                    }
                }

                AppendAllLanguages(text, CategoryTitleKey(setting.Category), langs);
                AppendAllLanguages(text, SectionTitleKey(setting), langs);

                text.Append(setting.Key);
                text.Append('|');
                text.Append(setting.SecondaryKey);

                setting.SearchText = text.ToString();
            }
        }

        // Rows have their own sizes, the boxes and the whole page are measured by hand: AutoSize of
        // nested docking chains is too unpredictable here. The table inside a box is stretched over
        // its box, so its PreferredSize would be circular: the height is summed from the rows.
        private void UpdateSectionHeight(Section section)
        {
            if (section.Table == null || section.Box == null)
            {
                return;
            }

            int height = 0;

            for (int i = 0; i < section.Table.Controls.Count; i++)
            {
                Control row = section.Table.Controls[i];

                if (!row.Visible)
                {
                    continue;
                }

                height += (row.AutoSize ? row.PreferredSize.Height : row.Height) + row.Margin.Vertical;
            }

            if (height < 12)
            {
                height = 12;
            }

            height += section.Box.Padding.Vertical + 8;

            if (section.Box.Height != height)
            {
                section.Box.Height = height;
            }
        }

        private static void AppendAllLanguages(StringBuilder builder, string locKey, LangEnum[] langs)
        {
            for (int i = 0; i < langs.Length; i++)
            {
                builder.Append(Localizator.Get(locKey, langs[i]));
                builder.Append('|');
            }
        }

        private void OnSearchKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (Query.Length != 0)
                {
                    ClearSearch();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                MoveMatch(e.Shift ? -1 : 1);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                MoveMatch(1);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                MoveMatch(-1);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F3)
            {
                MoveMatch(e.Shift ? -1 : 1);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        //========================================= navigation =============================================

        private void BuildNavigation()
        {
            navList = new NavListBox();
            navList.Dock = DockStyle.Fill;
            navList.DrawItem += new DrawItemEventHandler(OnDrawNavItem);
            navList.SelectedIndexChanged += new EventHandler(OnNavSelectionChanged);
            navList.MouseDown += new MouseEventHandler(OnNavMouseDown);
            panelLeft.Controls.Add(navList);
        }

        // The list is built once per language: searching never changes it.
        private void RefreshNavigation()
        {
            int selected = navList.SelectedIndex;

            syncingNav = true;
            navList.BeginUpdate();
            navList.Items.Clear();

            navList.Items.Add(NavCaption(NavAllIndex, VisibleOptions()));

            for (int i = 0; i < categories.Count; i++)
            {
                navList.Items.Add(NavCaption(i, categories[i].Total));
            }

            navList.EndUpdate();

            navList.SelectedIndex = (selected >= 0 && selected < navList.Items.Count) ? selected : 0;

            syncingNav = false;
            navList.Invalidate();
        }

        private string NavCaption(int categoryIndex, int count)
        {
            string title = categoryIndex == NavAllIndex
                ? Localizator.Get("SETTINGS_ALL")
                : Localizator.Get(categories[categoryIndex].TitleKey);

            return title + "\t(" + count + ")";
        }

        private void OnDrawNavItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= navList.Items.Count)
            {
                return;
            }

            Rectangle bounds = e.Bounds;
            bool selected = (e.State & DrawItemState.Selected) != 0;

            e.Graphics.FillRectangle(new SolidBrush(selected ? Theme.MenuHigh : navList.BackColor), bounds);

            if (selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Theme.Accent), bounds.Left, bounds.Top + 3, 2, bounds.Height - 7);
            }

            string caption = navList.Items[e.Index].ToString();
            int tab = caption.IndexOf('\t');

            string title = tab >= 0 ? caption.Substring(0, tab) : caption;
            string count = tab >= 0 ? caption.Substring(tab + 1) : "";

            Rectangle textRect = new Rectangle(bounds.Left + 14, bounds.Top, bounds.Width - 18, bounds.Height);
            TextRenderer.DrawText(e.Graphics, title, navList.Font, textRect, Theme.FgPrimary,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPadding);

            if (count.Length != 0)
            {
                Size size = TextRenderer.MeasureText(e.Graphics, count, navList.Font);
                Rectangle countRect = new Rectangle(bounds.Right - size.Width - 12, bounds.Top, size.Width, bounds.Height);
                TextRenderer.DrawText(e.Graphics, count, navList.Font, countRect, Theme.FgMuted,
                    TextFormatFlags.Right | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
            }
        }

        private void OnNavMouseDown(object sender, MouseEventArgs e)
        {
            int index = navList.IndexFromPoint(e.Location);
            if (index < 0)
            {
                return;
            }

            if (navList.SelectedIndex != index)
            {
                navList.SelectedIndex = index;
            }

            ScrollToSelection();
        }

        private void OnNavSelectionChanged(object sender, EventArgs e)
        {
            if (syncingNav)
            {
                return;
            }
            ScrollToSelection();
        }

        // The first entry is "All settings", the rest maps to categories[index - 1].
        private void ScrollToSelection()
        {
            int index = navList.SelectedIndex;

            if (index <= 0)
            {
                SetScroll(0);
                return;
            }

            if (index > categories.Count)
            {
                return;
            }

            CategoryInfo category = categories[index - 1];
            if (category.Sections.Count == 0)
            {
                return;
            }

            GroupBox target = category.Sections[0].Box;

            SetScroll(ContentOffset(target));
        }

        //==================================== the page and its scroll ====================================

        // The page is scrolled by hand: panelContent keeps AutoScroll off, the page is moved with its
        // Top and the vertical bar next to it is ours. AutoScroll of WinForms was of no use here: the
        // position it reports is updated, but every position we ask it for is thrown away.
        private void BuildScrollBar()
        {
            panelContent.AutoScroll = false;

            pageScrollBar = new VScrollBar();
            pageScrollBar.Dock = DockStyle.Right;
            pageScrollBar.Minimum = 0;
            pageScrollBar.SmallChange = WheelStep;
            pageScrollBar.Scroll += new ScrollEventHandler(OnPageScrollBar);

            panelContent.Controls.Add(pageScrollBar);

            // The page is a plain child and as wide as the panel, so without this it is painted over the
            // bar, and a control painted over a bar eats its mouse clicks as well.
            pageScrollBar.BringToFront();

            // The wheel of the mouse never reaches panelContent: the control under the cursor receives it
            // and keeps it, so the wheel has to be taken away before it is dispatched to any control.
            wheel = new WheelHook(this);
            wheel.Install();

            Disposed += delegate
            {
                if (wheel != null)
                {
                    wheel.Uninstall();
                }
            };
        }

        // The wheel above the page scrolls the page, one notch - three options.
        private void OnMouseWheelOverPage(int notch)
        {
            int lines = notch / 120;

            if (lines == 0)
            {
                lines = notch > 0 ? 1 : -1;
            }

            SetScroll(scrollOffset - lines * WheelStep * WheelLines);
        }

        private void OnPageScrollBar(object sender, ScrollEventArgs e)
        {
            // The bar has one page of place in its Maximum, so its last position means "the very end of
            // the page", and not "one page below the last option".
            SetScroll(e.NewValue);
        }

        // Height of the page together with the range of the scroll: both are ours.
        private void UpdateScrollSize()
        {
            if (tableSections == null)
            {
                return;
            }

            int height = 0;

            foreach (Control control in tableSections.Controls)
            {
                if (control.Visible)
                {
                    height += control.Height + control.Margin.Vertical;
                }
            }

            contentHeight = height;

            if (pageScrollBar != null)
            {
                pageScrollBar.Visible = height > panelContent.ClientSize.Height;
            }

            // The page takes the width of the panel without the place of the bar: the bar is docked to
            // the right inside the padding, and the page must not reach under it.
            int width = PageWidth();

            if (tableSections.Size != new Size(width, height))
            {
                tableSections.Size = new Size(width, height);
            }

            UpdateScrollBar();
            PlacePage();
        }

        private int MaxScroll()
        {
            int last = contentHeight + panelContent.Padding.Vertical - panelContent.ClientSize.Height;

            return last < 0 ? 0 : last;
        }

        private void UpdateScrollBar()
        {
            if (pageScrollBar == null)
            {
                return;
            }

            int last = MaxScroll();
            int view = Math.Max(1, panelContent.ClientSize.Height);

            pageScrollBar.LargeChange = view;
            pageScrollBar.Maximum = last + view - 1;

            if (scrollOffset > last)
            {
                scrollOffset = last;
            }

            if (pageScrollBar.Value != scrollOffset)
            {
                pageScrollBar.Value = scrollOffset;
            }
        }

        // The page sits above its place by the current scroll: that is the whole scrolling.
        private void PlacePage()
        {
            if (tableSections == null)
            {
                return;
            }

            int top = panelContent.DisplayRectangle.Top - scrollOffset;

            if (tableSections.Top != top)
            {
                tableSections.Top = top;
            }
        }

        // Scrolls to the given place of the page and keeps the list on the left in step with it.
        private void SetScroll(int offset)
        {
            int last = MaxScroll();

            if (offset > last)
            {
                offset = last;
            }

            if (offset < 0)
            {
                offset = 0;
            }

            if (scrollOffset == offset)
            {
                return;
            }

            scrollOffset = offset;

            PlacePage();
            SyncNavigation();

            if (pageScrollBar != null && pageScrollBar.Value != scrollOffset)
            {
                pageScrollBar.Value = scrollOffset;
            }
        }

        // Place of a control inside the visible part of the page: negative above its top, greater than
        // the page height below its bottom.
        private int VisibleTop(Control control)
        {
            return control.PointToScreen(Point.Empty).Y - panelContent.PointToScreen(Point.Empty).Y;
        }

        // Place of a control inside the whole page, not only in the part of it we see right now.
        // ScrollControlIntoView is unusable here: it does nothing when the target is taller than the
        // visible part of the page.
        private int ContentOffset(Control control)
        {
            return VisibleTop(control) + scrollOffset;
        }

        // Scrolls to the option we are standing on only when it is really outside of the page.
        private void ScrollToShow(Control control)
        {
            int top = ContentOffset(control);
            int bottom = top + control.Height;

            int first = scrollOffset;
            int last = first + panelContent.ClientSize.Height;

            if (top < first)
            {
                SetScroll(top);
            }
            else if (bottom > last)
            {
                SetScroll(bottom - panelContent.ClientSize.Height);
            }
        }

        private void ScrollToCategory(string category)
        {
            if (string.IsNullOrEmpty(category))
            {
                return;
            }

            // The navigation is normally built by UpdateLang; be ready for a call before that.
            if (navList.Items.Count != categories.Count + 1)
            {
                RefreshNavigation();
            }

            for (int i = 0; i < categories.Count; i++)
            {
                if (categories[i].Id == category)
                {
                    syncingNav = true;
                    navList.SelectedIndex = i + 1;
                    syncingNav = false;
                    ScrollToSelection();
                    return;
                }
            }
        }

        // Keeps the list on the left in sync with the section the user has scrolled to.
        private void SyncNavigation()
        {
            if (navList == null || syncingNav)
            {
                return;
            }

            int current = 0;

            for (int i = 0; i < categories.Count; i++)
            {
                if (categories[i].Sections.Count == 0)
                {
                    continue;
                }

                GroupBox box = categories[i].Sections[0].Box;

                // The coordinates of a child of the scrolling panel already carry the scroll shift.
                if (box.Visible && VisibleTop(box) <= 1)
                {
                    current = i + 1;
                }
            }

            if (navList.SelectedIndex != current)
            {
                syncingNav = true;
                navList.SelectedIndex = current;
                syncingNav = false;
            }
        }

        //======================================== value handling ==========================================

        private static void PushInt(string key, int value)
        {
            Imports.Stack_PushString(key);
            Imports.Extern_SetSetting(value);
        }

        private static int PullInt(string key)
        {
            Imports.Stack_PushString(key);
            return Imports.Extern_GetSetting();
        }

        private void ReadValue(Setting setting)
        {
            // A blank line has no value to read.
            if (IsSeparator(setting))
            {
                return;
            }

            if (setting.StoreLocally)
            {
                setting.Value = setting.LocalGetter != null ? setting.LocalGetter() : 0;
            }
            else
            {
                setting.Value = PullInt(setting.Key);
            }

            if (setting.Kind == SettingKind.CheckTrack)
            {
                setting.TrackValue = Utils.Clamp(PullInt(setting.SecondaryKey), setting.Minimum, setting.Maximum);
            }

            ApplyValueToControl(setting);

            // A freshly read value is the value the core already has.
            setting.Dirty = false;
        }

        private void ApplyValueToControl(Setting setting)
        {
            switch (setting.Kind)
            {
                case SettingKind.CheckBox:
                    if (setting.Box != null && setting.Box.Checked != setting.Flag)
                    {
                        setting.Box.Checked = setting.Flag;
                    }
                    break;

                case SettingKind.CheckTrack:
                    if (setting.Box != null && setting.Box.Checked != setting.Flag)
                    {
                        setting.Box.Checked = setting.Flag;
                    }
                    if (setting.Track != null)
                    {
                        int trackValue = Utils.Clamp(setting.TrackValue, setting.Track.Minimum, setting.Track.Maximum);

                        if (setting.Track.Value != trackValue)
                        {
                            setting.Track.Value = trackValue;
                        }

                        if (setting.Track.Enabled != setting.Flag)
                        {
                            setting.Track.Enabled = setting.Flag;
                        }
                    }
                    break;

                case SettingKind.Track:
                case SettingKind.TrackBox:
                    if (setting.Track != null)
                    {
                        int value = Utils.Clamp(setting.Value, setting.Track.Minimum, setting.Track.Maximum);

                        if (setting.Track.Value != value)
                        {
                            setting.Track.Value = value;
                        }
                    }
                    SyncNumberBox(setting);
                    break;

                case SettingKind.Number:
                    SyncNumberBox(setting);
                    break;

                case SettingKind.RadioGroup:
                    for (int i = 0; i < setting.Radios.Count; i++)
                    {
                        bool isChecked = setting.RadioValues[i] == setting.Value;

                        if (setting.Radios[i].Checked != isChecked)
                        {
                            setting.Radios[i].Checked = isChecked;
                        }
                    }
                    break;
            }
        }

        // Writes the value of an option to the core. react is true for a change made by the user: such
        // an option is remembered as changed, so ApplyAll() does not write the ones nobody touched.
        private void PushValue(Setting setting, bool react)
        {
            if (setting.StoreLocally)
            {
                if (setting.LocalSetter != null)
                {
                    setting.LocalSetter(setting.Value);
                }
            }
            else
            {
                PushInt(setting.Key, setting.Value);
            }

            if (setting.Kind == SettingKind.CheckTrack && setting.SecondaryKey.Length != 0)
            {
                PushInt(setting.SecondaryKey, setting.TrackValue);
            }

            if (react)
            {
                setting.Dirty = true;
            }

            if (react && setting.AfterChange != null)
            {
                setting.AfterChange(setting);
            }
        }

        //========================================== row handlers ==========================================

        private void WireFormEvents()
        {
            buttonApply.Click += delegate { CloseWindow(); };

            KeyDown += new KeyEventHandler(OnFormKeyDown);
            FormClosing += new FormClosingEventHandler(OnFormClosingWindow);

            Shown += delegate { RelayoutPage(); };

            // A drag of the window asks for a relayout on every pixel of it: the measuring of the page
            // runs once after the burst instead.
            Resize += delegate { QueueRelayout(); };

            // The editor pushes its own interface font into every window.
            FontChanged += delegate
            {
                // With the font the height of the field and its place in the frame change as well.
                searchFieldTop = -1;

                LayoutSearchRow();
                QueueRelayout();
            };

            panelSearch.Resize += delegate { LayoutSearchRow(); };

            // ThemeApplier colors the window after us, so our own colors are set once the window
            // is about to be seen.
            VisibleChanged += delegate
            {
                if (Visible && IsHandleCreated && !IsDisposed)
                {
                    BeginInvoke(new MethodInvoker(delegate
                    {
                        if (!IsDisposed)
                        {
                            ApplyCustomTheme();
                        }
                    }));
                }
            };

            Theme.ThemeChanged += delegate { ApplyCustomTheme(); };
        }

        private void OnCheckChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            Setting setting = box.Tag as Setting;

            if (setting == null)
            {
                return;
            }

            setting.Value = box.Checked ? 1 : 0;

            if (setting.Track != null)
            {
                setting.Track.Enabled = box.Checked;
            }

            if (loading)
            {
                return;
            }

            PushValue(setting, true);
            UpdateDependencies();
            SyncCaption(setting);

            // Checking an option may change what the current search shows.
            if (Query.Length != 0)
            {
                UpdateSearch();
            }
        }

        private void OnTrackChanged(object sender, EventArgs e)
        {
            TrackBar track = (TrackBar)sender;
            Setting setting = track.Tag as Setting;

            if (setting == null)
            {
                return;
            }

            if (setting.Kind == SettingKind.CheckTrack)
            {
                setting.TrackValue = track.Value;

                if (!loading)
                {
                    PushInt(setting.SecondaryKey, setting.TrackValue);
                    setting.Dirty = true;
                }
            }
            else
            {
                setting.Value = track.Value;

                if (!loading)
                {
                    PushValue(setting, true);
                }
            }

            SyncCaption(setting);
            SyncNumberBox(setting);
        }

        private void OnNumberChanged(object sender, EventArgs e)
        {
            TextBox number = (TextBox)sender;
            Setting setting = number.Tag as Setting;

            if (setting == null || loading)
            {
                return;
            }

            int value;
            if (!int.TryParse(number.Text.Trim(), out value))
            {
                return;
            }

            value = Utils.Clamp(value, setting.Minimum, setting.Maximum);

            if (setting.Track != null)
            {
                if (setting.Track.Value != value)
                {
                    setting.Track.Value = value;  // writes through OnTrackChanged
                }
                else
                {
                    setting.Value = value;
                    PushValue(setting, true);
                }
            }
            else
            {
                setting.Value = value;
                PushValue(setting, true);
            }

            SyncCaption(setting);
        }

        private static void OnNumberKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OnRadioChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;

            if (!radio.Checked)
            {
                return;
            }

            Setting setting = radio.Tag as Setting;
            if (setting == null || loading)
            {
                return;
            }

            int index = setting.Radios.IndexOf(radio);
            if (index < 0)
            {
                return;
            }

            setting.Value = setting.RadioValues[index];
            PushValue(setting, true);
        }

        private void OnFormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && !textBoxSearch.Focused)
            {
                CloseWindow();
            }
        }

        private void OnFormClosingWindow(object sender, FormClosingEventArgs e)
        {
            // Closing hides the page: the editor itself is closed through MainForm.
            CloseWindow();
            e.Cancel = true;
        }

        private void CloseWindow()
        {
            if (loaded)
            {
                ApplyAll();
            }
            else
            {
                LoadSettings();
            }

            // Next time the page opens it is shown without the marks of the previous search.
            if (Query.Length != 0)
            {
                ClearSearch();
            }

            Hide();
        }

        // "Make some vob's fields to upper case" is meaningless while converting is disabled.
        private void UpdateDependencies()
        {
            foreach (Setting setting in settings)
            {
                if (setting.DependsOnKey == null || setting.Row == null)
                {
                    continue;
                }

                Setting owner;
                if (!byKey.TryGetValue(setting.DependsOnKey, out owner))
                {
                    continue;
                }

                bool enabled = owner.Flag;
                if (setting.InvertDependency)
                {
                    enabled = !enabled;
                }

                // Assigning Enabled invalidates the whole row with all its controls: worth doing only
                // when the row really changes.
                if (setting.Row.Enabled != enabled)
                {
                    setting.Row.Enabled = enabled;
                }
            }
        }

        //=========================================== captions =============================================

        // "Moving speed" + ": 42" for track options, minutes for the auto save check boxes.
        private void SyncCaption(Setting setting)
        {
            // Hidden options and blank lines have no caption to sync.
            if (!IsOption(setting))
            {
                return;
            }

            string caption = setting.CaptionText;
            int value = setting.Kind == SettingKind.CheckTrack ? setting.TrackValue : setting.Value;

            string text = setting.ShowValueInCaption ? caption + setting.ValueSeparator + value : caption;

            // A caption with AutoSize re-measures its row on any assignment, even the same text.
            if (setting.Box != null && setting.Box.Text != text)
            {
                setting.Box.Text = text;
            }

            if (setting.Caption != null && setting.Caption.Text != text)
            {
                setting.Caption.Text = text;
            }
        }

        private void SyncNumberBox(Setting setting)
        {
            if (setting.Number == null)
            {
                return;
            }

            int value = setting.Kind == SettingKind.CheckTrack ? setting.TrackValue : setting.Value;
            string text = value.ToString();

            if (setting.Number.Text != text)
            {
                setting.Number.Text = text;
            }
        }

        //============================================== theme ==============================================

        // Colors of the parts ThemeApplier does not know about: the search field, the navigation list,
        // secondary labels. Called after ThemeApplier has done its work.
        private void ApplyCustomTheme()
        {
            BeginPaintBatch();
            try
            {
                ApplyCustomThemeColors();
            }
            finally
            {
                EndPaintBatch();
            }
        }

        private void ApplyCustomThemeColors()
        {
            BackColor = Theme.BgPanel;
            panelLeft.BackColor = Theme.BgPanel;
            panelBottom.BackColor = Theme.BgPanel;
            panelSearchHost.BackColor = Theme.BgPanel;
            panelContent.BackColor = Theme.BgPanel;

            panelSearch.BackColor = Theme.BgInput;
            textBoxSearch.BackColor = Theme.BgInput;
            textBoxSearch.ForeColor = placeholderShown ? Theme.FgMuted : Theme.FgPrimary;

            foreach (Button button in new Button[] { buttonClearSearch, buttonSearchPrev, buttonSearchNext })
            {
                button.BackColor = Theme.BgInput;
                button.FlatAppearance.MouseOverBackColor = Theme.MenuHigh;
                button.FlatAppearance.MouseDownBackColor = Theme.Accent;
            }

            matchStripeColor = Theme.IsDark ? Color.FromArgb(0x6F, 0xB8, 0x6F) : Color.FromArgb(0x2E, 0x7D, 0x32);

            if (matchBrush != null)
            {
                matchBrush.Dispose();
            }

            matchBrush = new SolidBrush(matchStripeColor);

            labelApplyHint.ForeColor = Theme.FgMuted;
            labelSearchInfo.ForeColor = Theme.FgMuted;

            tableSearchRow.BackColor = Theme.BgPanel;
            panelSearchButtons.BackColor = Theme.BgPanel;

            if (tableSections != null)
            {
                tableSections.BackColor = Theme.BgPanel;
            }

            if (navList != null)
            {
                navList.BackColor = Theme.BgPanel;
                navList.Invalidate();
            }

            foreach (Setting setting in settings)
            {
                SetBackground(setting.Row, Theme.BgPanel);
                SetBackground(setting.Box, Theme.BgPanel);
                SetBackground(setting.Caption, Theme.BgPanel);
                SetBackground(setting.Main, Theme.BgPanel);

                for (int i = 0; i < setting.Radios.Count; i++)
                {
                    SetBackground(setting.Radios[i], Theme.BgPanel);
                }

                if (setting.Hint != null && setting.Hint.ForeColor != Theme.FgMuted)
                {
                    setting.Hint.ForeColor = Theme.FgMuted;
                }
            }

            for (int i = 0; i < sections.Count; i++)
            {
                SetBackground(sections[i].Box, Theme.BgPanel);
            }

            // The option we are standing on keeps its background after a theme switch.
            if (matchIndex >= 0 && matchIndex < matches.Count)
            {
                SetRowBackground(matches[matchIndex], MatchBackground);
            }
        }

        // A color is assigned only when it differs from the one the control has: every assignment makes
        // the control and all its children paint again, and the page has a thousand of them.
        private static void SetBackground(Control control, Color color)
        {
            if (control != null && !control.IsDisposed && control.BackColor != color)
            {
                control.BackColor = color;
            }
        }

        // Background of the option we are currently standing on while walking through the hits.
        private Color MatchBackground
        {
            get
            {
                return Theme.IsDark ? Color.FromArgb(44, 62, 44) : Color.FromArgb(227, 241, 222);
            }
        }

        // Group box of one section of the page. The title of the main section of a category ("Camera",
        // "Vobs settings", "Misc settings") is printed bold: the native group box can only do that
        // over its whole text, so the title is painted by hand over the one the control drew.
        private class SectionBox : GroupBox
        {
            public bool BoldTitle;

            private Font titleFont;

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                if (!BoldTitle || Text.Length == 0)
                {
                    return;
                }

                const TextFormatFlags flags = TextFormatFlags.NoPadding | TextFormatFlags.Left | TextFormatFlags.SingleLine;

                Size normal = TextRenderer.MeasureText(e.Graphics, Text, Font, Size.Empty, flags);

                // Cover the title the control has drawn with its own background color.
                e.Graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(0, 0, normal.Width + 16, Font.Height + 6));

                if (titleFont == null)
                {
                    titleFont = new Font(Font, FontStyle.Bold);
                }

                TextRenderer.DrawText(e.Graphics, Text, titleFont, new Rectangle(8, 1, Width - 12, Font.Height + 6), ForeColor, flags);
            }

            protected override void OnFontChanged(EventArgs e)
            {
                base.OnFontChanged(e);

                if (titleFont != null)
                {
                    titleFont.Dispose();
                    titleFont = null;
                }
            }
        }

        // Track bars on the page ignore the mouse wheel: otherwise scrolling the page with the wheel
        // over a slider quietly changes that setting. The hook gives the wheel to the page, this is the
        // second line of defense in case a message reaches the bar itself.
        private class PageTrackBar : TrackBar
        {
            private const int WmMouseWheel = 0x020A;

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == WmMouseWheel)
                {
                    return;
                }

                base.WndProc(ref m);
            }
        }

        // The navigation list of the settings page: drawn by us, colored by us.
        private class NavListBox : ListBox
        {
            private bool keepingBackground;

            public NavListBox()
            {
                DrawMode = DrawMode.OwnerDrawFixed;
                BorderStyle = BorderStyle.None;
                IntegralHeight = false;
                ItemHeight = 30;
            }

            // ThemeApplier treats a list box like an input box, but the navigation is a panel.
            protected override void OnBackColorChanged(EventArgs e)
            {
                base.OnBackColorChanged(e);

                if (keepingBackground || BackColor == Theme.BgPanel)
                {
                    return;
                }

                keepingBackground = true;
                BackColor = Theme.BgPanel;
                keepingBackground = false;
            }
        }

        // The mouse wheel is not passed to the page under it: the control under the cursor receives the
        // message itself, and only that control decides what to do. Application.AddMessageFilter is of no
        // use here: its filters are asked by the message loop of Windows Forms (Application.Run), while
        // this window lives inside the native editor, which pumps its messages itself - and so a filter is
        // never called at all. A hook of our own thread runs in the pump of the editor, before the message
        // reaches the control, and there the wheel can be taken away for the page.
        private class WheelHook
        {
            private const int WhGetMessage = 3;
            private const int WmMouseWheel = 0x020A;
            private const int WmNull = 0;
            private const int PmRemove = 1;
            private const uint GaRoot = 2;

            // The delegate lives in a field: the unmanaged code holds a pointer to it, so the garbage
            // collector must not move it away.
            private delegate IntPtr GetMsgProc(int code, IntPtr wParam, IntPtr lParam);

            [DllImport("user32.dll")]
            private static extern IntPtr SetWindowsHookEx(int idHook, GetMsgProc lpfn, IntPtr hInstance, uint threadId);

            [DllImport("user32.dll")]
            private static extern bool UnhookWindowsHookEx(IntPtr hhk);

            [DllImport("user32.dll")]
            private static extern IntPtr CallNextHookEx(IntPtr hhk, int code, IntPtr wParam, IntPtr lParam);

            [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
            private static extern IntPtr GetModuleHandle(string name);

            [DllImport("kernel32.dll", SetLastError = true)]
            private static extern uint GetCurrentThreadId();

            // Control.FromPoint is not in this .NET, so the window under the cursor is asked of Windows.
            [DllImport("user32.dll")]
            private static extern IntPtr WindowFromPoint(Point point);

            // Control.FromHandle walks every control of the application to find the window behind a
            // handle - far too slow for every notch of the wheel. The root window of the window under the
            // cursor says the same: the wheel is ours or it is not.
            [DllImport("user32.dll")]
            private static extern IntPtr GetAncestor(IntPtr hwnd, uint flags);

            // The message Windows has just taken out of the queue: the first four fields are exactly where
            // Win32 puts them, and the editor is x86, the platform these fields are read on. The fields are
            // filled by the marshaller, not by us, hence the warning of the compiler is not of use here.
#pragma warning disable 649
            private struct Msg
            {
                public IntPtr hwnd;
                public uint message;
                public IntPtr wParam;
                public IntPtr lParam;
            }
#pragma warning restore 649

            private readonly SettingsMain page;
            private readonly GetMsgProc procedure;
            private IntPtr hook;

            public WheelHook(SettingsMain page)
            {
                this.page = page;
                procedure = new GetMsgProc(Run);
            }

            public void Install()
            {
                if (hook != IntPtr.Zero)
                {
                    return;
                }

                // A hook of our own thread: it is called by the pump of that very thread, the editor's
                // one, and it needs no native dll of its own.
                hook = SetWindowsHookEx(WhGetMessage, procedure, GetModuleHandle(null), GetCurrentThreadId());
            }

            public void Uninstall()
            {
                if (hook == IntPtr.Zero)
                {
                    return;
                }

                UnhookWindowsHookEx(hook);
                hook = IntPtr.Zero;
            }

            private IntPtr Run(int code, IntPtr wParam, IntPtr lParam)
            {
                // A negative code means "pass the message to the next hook as it is".
                if (code >= 0 && (int)wParam == PmRemove && !page.IsDisposed)
                {
                    Msg msg = (Msg)Marshal.PtrToStructure(lParam, typeof(Msg));

                    if (msg.message == WmMouseWheel)
                    {
                        int notch = unchecked((short)((long)msg.wParam >> 16));

                        if (Take(notch))
                        {
                            // The wheel is ours: the message is emptied, so that no control sees it and a
                            // slider under the cursor does not change its setting behind the user's back.
                            Marshal.WriteInt32(lParam, Marshal.OffsetOf(typeof(Msg), "message").ToInt32(), WmNull);
                        }
                    }
                }

                return CallNextHookEx(hook, code, wParam, lParam);
            }

            // true when the wheel belongs to the page: the cursor stands over it.
            private bool Take(int notch)
            {
                if (!page.Visible)
                {
                    return false;
                }

                Point where = Cursor.Position;
                IntPtr under = WindowFromPoint(where);
                IntPtr root = under == IntPtr.Zero ? IntPtr.Zero : GetAncestor(under, GaRoot);

                if (under == IntPtr.Zero || root != page.Handle)
                {
                    return false;
                }

                // The bar scrolls the page like any ordinary bar: its own wheel is left to it.
                if (page.pageScrollBar != null && under == page.pageScrollBar.Handle)
                {
                    return false;
                }

                Rectangle area = page.panelContent.RectangleToScreen(page.panelContent.ClientRectangle);

                if (!area.Contains(where))
                {
                    return false;
                }

                page.OnMouseWheelOverPage(notch);
                return true;
            }
        }

        // The one line search field. An ordinary text box is always exactly as high as its font and
        // clips the bottom of letters with a descender, and it cannot be made a pixel or two higher. This one is
        // a multiline box (only those accept any height), one line high plus a pixel above and below, so
        // the whole line of the font always fits.
        private class SearchTextBox : TextBox
        {
            public SearchTextBox()
            {
                Multiline = true;
                WordWrap = false;
                AutoSize = false;
            }

            // A multiline box would add a new line on Enter; here Enter walks through the search hits.
            protected override void OnKeyPress(KeyPressEventArgs e)
            {
                if (e.KeyChar == '\r' || e.KeyChar == '\n')
                {
                    e.Handled = true;
                    return;
                }

                base.OnKeyPress(e);
            }
        }
    }
}
