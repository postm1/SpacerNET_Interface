using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SpacerUnion.Common
{
    public static class ThemeApplier
    {
        private static readonly HashSet<GroupBox> _gbHandlers = new HashSet<GroupBox>();
        private static readonly HashSet<TabControl> _tabHandlers = new HashSet<TabControl>();
        private static readonly HashSet<Form> _shownHooks = new HashSet<Form>();
        private static readonly HashSet<Button> _btnPaintHooks = new HashSet<Button>();
        private static readonly HashSet<CheckBox> _chkPaintHooks = new HashSet<CheckBox>();
        private static readonly HashSet<RadioButton> _radioPaintHooks = new HashSet<RadioButton>();
        private static readonly HashSet<ListView> _lvHandlers = new HashSet<ListView>();
        private static readonly HashSet<ComboBox> _cbHandlers = new HashSet<ComboBox>();
        private static readonly HashSet<Label> _lblPaintHooks = new HashSet<Label>();
        private static readonly HashSet<TreeView> _tvHandlers = new HashSet<TreeView>();
        private static readonly HashSet<ImageList> _ilDarkApplied = new HashSet<ImageList>();
        private static readonly List<Form> _registeredDialogs = new List<Form>();

        // Disabled-state in dark mode — system default is unreadable (grey-on-grey).
        // 165/165/165 gives clear contrast against BgPanel (45/45/48) without looking enabled.
        private static readonly Color _dDisabledFg = Color.FromArgb(165, 165, 165);

        [DllImport("dwmapi.dll", PreserveSig = true)]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode, PreserveSig = true)]
        private static extern int SetWindowTheme(IntPtr hwnd, string subAppName, string subIdList);
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_LEGACY = 19;

        private static void TryDarkenNative(Control c)
        {
            if (!c.IsHandleCreated) return;
            try { SetWindowTheme(c.Handle, Theme.IsDark ? "DarkMode_Explorer" : null, null); }
            catch { }
        }

        public static void Apply(Form form)
        {
            if (form == null) return;
            ApplyToControl(form);
            ApplyRecursive(form);
            form.Invalidate(true);
            TryApplyTitleBar(form);
            HookShownReapply(form);
        }

        private static void TryApplyTitleBar(Form form)
        {
            if (form.IsHandleCreated && form.Visible)
            {
                SetTitleBarDark(form);
                return;
            }
            // Shown hook handles this too via HookShownReapply
        }

        private static void HookShownReapply(Form form)
        {
            if (_shownHooks.Contains(form)) return;
            _shownHooks.Add(form);
            form.Shown += (s, e) =>
            {
                try
                {
                    var f = (Form)s;
                    SetTitleBarDark(f);
                    // Re-apply controls — some forms reset BackColor or only realize handles in their own Show flow
                    ApplyToControl(f);
                    ApplyRecursive(f);
                    f.Invalidate(true);
                }
                catch { }
            };
        }

        private static void SetTitleBarDark(Form form)
        {
            int dark = Theme.IsDark ? 1 : 0;
            try
            {
                if (DwmSetWindowAttribute(form.Handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref dark, sizeof(int)) != 0)
                    DwmSetWindowAttribute(form.Handle, DWMWA_USE_IMMERSIVE_DARK_MODE_LEGACY, ref dark, sizeof(int));
            }
            catch
            {
                // Pre-Win10-1809 or DWM disabled — caption stays light, no harm
            }
        }

        // Modal dialogs constructed by parent forms (e.g. ConfirmForm, VobCatalog Add/Edit) aren't in
        // SpacerNET.windowsList, so the global ApplyAll pass skips them. Parents call RegisterDialog
        // once at construction time; ReapplyRegisteredDialogs runs on theme switch.
        public static void RegisterDialog(Form dialog)
        {
            if (dialog == null) return;
            if (!_registeredDialogs.Contains(dialog)) _registeredDialogs.Add(dialog);
            Apply(dialog);
        }

        public static void ReapplyRegisteredDialogs()
        {
            foreach (var d in _registeredDialogs)
            {
                if (d != null && !d.IsDisposed) Apply(d);
            }
        }

        public static void ApplyAll(IEnumerable<Form> forms)
        {
            if (forms == null) return;
            foreach (var f in forms)
            {
                if (f != null) Apply(f);
            }
        }

        private static void ApplyRecursive(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                ApplyToControl(c);
                if (c.HasChildren) ApplyRecursive(c);
            }
        }

        private static void ApplyToControl(Control c)
        {
            if (c == null) return;

            if (c is TextBox)
            {
                var t = (TextBox)c;
                t.BackColor = Theme.BgInput;
                t.ForeColor = Theme.FgPrimary;
                t.BorderStyle = Theme.IsDark ? BorderStyle.FixedSingle : BorderStyle.Fixed3D;
                TryDarkenNative(t);
                return;
            }

            if (c is RichTextBox)
            {
                var rt = (RichTextBox)c;
                rt.BackColor = Theme.BgInput;
                rt.ForeColor = Theme.FgPrimary;
                rt.BorderStyle = Theme.IsDark ? BorderStyle.FixedSingle : BorderStyle.Fixed3D;
                TryDarkenNative(rt);
                return;
            }

            if (c is ListBox)
            {
                var lb = (ListBox)c;
                lb.BackColor = Theme.BgInput;
                lb.ForeColor = Theme.FgPrimary;
                lb.BorderStyle = Theme.IsDark ? BorderStyle.FixedSingle : BorderStyle.Fixed3D;
                TryDarkenNative(lb);
                return;
            }

            if (c is TreeView)
            {
                ApplyTreeView((TreeView)c);
                return;
            }

            if (c is ListView)
            {
                ApplyListView((ListView)c);
                return;
            }

            if (c is ComboBox)
            {
                ApplyComboBox((ComboBox)c);
                return;
            }

            if (c is DataGridView)
            {
                ApplyDataGridView((DataGridView)c);
                return;
            }

            if (c is NumericUpDown)
            {
                c.BackColor = Theme.BgInput;
                c.ForeColor = Theme.FgPrimary;
                TryDarkenNative(c);
                return;
            }

            if (c is Button)
            {
                var b = (Button)c;
                // UseVisualStyleBackColor MUST be cleared before setting BackColor — otherwise
                // WinForms silently discards the BackColor in favor of the system visual style.
                b.UseVisualStyleBackColor = !Theme.IsDark;
                b.BackColor = Theme.BgPanel;
                b.ForeColor = Theme.FgPrimary;
                if (Theme.IsDark)
                {
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderColor = Theme.Border;
                    if (!_btnPaintHooks.Contains(b))
                    {
                        b.Paint += Button_PaintDisabledOverlay;
                        b.EnabledChanged += Button_EnabledChanged;
                        _btnPaintHooks.Add(b);
                    }
                }
                else
                {
                    b.FlatStyle = FlatStyle.Standard;
                }
                return;
            }

            if (c is CheckBox)
            {
                var cb = (CheckBox)c;
                cb.BackColor = Theme.BgPanel;
                cb.ForeColor = Theme.FgPrimary;
                if (Theme.IsDark && !_chkPaintHooks.Contains(cb))
                {
                    cb.Paint += CheckBox_PaintDisabledOverlay;
                    cb.EnabledChanged += CheckBox_EnabledChanged;
                    _chkPaintHooks.Add(cb);
                }
                return;
            }

            if (c is RadioButton)
            {
                var rb = (RadioButton)c;
                rb.BackColor = Theme.BgPanel;
                rb.ForeColor = Theme.FgPrimary;
                if (Theme.IsDark && !_radioPaintHooks.Contains(rb))
                {
                    rb.Paint += RadioButton_PaintDisabledOverlay;
                    rb.EnabledChanged += RadioButton_EnabledChanged;
                    _radioPaintHooks.Add(rb);
                }
                return;
            }

            if (c is MenuStrip || c is ToolStrip || c is StatusStrip)
            {
                var ts = (ToolStrip)c;
                ts.BackColor = Theme.BgPanel;
                ts.ForeColor = Theme.FgPrimary;
                ts.Renderer = Theme.IsDark
                    ? (ToolStripRenderer)new DarkToolStripRenderer()
                    : new ToolStripProfessionalRenderer();
                return;
            }

            if (c is GroupBox)
            {
                var gb = (GroupBox)c;
                gb.BackColor = Theme.BgPanel;
                gb.ForeColor = Theme.FgPrimary;
                if (!_gbHandlers.Contains(gb))
                {
                    gb.Paint += GroupBox_Paint;
                    _gbHandlers.Add(gb);
                }
                gb.Invalidate();
                return;
            }

            if (c is TabControl)
            {
                var tc = (TabControl)c;
                tc.BackColor = Theme.BgPanel;
                tc.ForeColor = Theme.FgPrimary;
                if (!_tabHandlers.Contains(tc))
                {
                    tc.DrawMode = TabDrawMode.Normal;
                    tc.Paint += TabControl_Paint;
                    _tabHandlers.Add(tc);
                }
                tc.Invalidate();
                return;
            }

            if (c is TabPage)
            {
                // TabPage defaults to UseVisualStyleBackColor=true, which silently discards BackColor
                // in favor of the system visual style. Disable it before setting BackColor so the
                // dark panel fill actually takes effect.
                var tp = (TabPage)c;
                tp.UseVisualStyleBackColor = !Theme.IsDark;
                tp.BackColor = Theme.BgPanel;
                tp.ForeColor = Theme.FgPrimary;
                return;
            }

            if (c is Label)
            {
                var lbl = (Label)c;
                lbl.ForeColor = Theme.FgPrimary;
                if (Theme.IsDark && !_lblPaintHooks.Contains(lbl))
                {
                    lbl.Paint += Label_PaintDisabledOverlay;
                    lbl.EnabledChanged += Label_EnabledChanged;
                    _lblPaintHooks.Add(lbl);
                }
                return;
            }

            // Forms, panels — generic
            c.BackColor = Theme.BgPanel;
            c.ForeColor = Theme.FgPrimary;
        }

        // ---- ComboBox (DropDownList variant ignores BackColor without OwnerDraw) ---

        private static void ApplyComboBox(ComboBox cb)
        {
            cb.BackColor = Theme.BgInput;
            cb.ForeColor = Theme.FgPrimary;
            cb.FlatStyle = Theme.IsDark ? FlatStyle.Flat : FlatStyle.Standard;
            if (Theme.IsDark)
            {
                if (cb.DrawMode == DrawMode.Normal)
                    cb.DrawMode = DrawMode.OwnerDrawFixed;
                if (!_cbHandlers.Contains(cb))
                {
                    cb.DrawItem += ComboBox_DrawItem;
                    _cbHandlers.Add(cb);
                }
            }
            TryDarkenCombo(cb);
        }

        private static void TryDarkenCombo(Control c)
        {
            if (!c.IsHandleCreated) return;
            try { SetWindowTheme(c.Handle, Theme.IsDark ? "DarkMode_CFD" : null, null); }
            catch { }
        }

        private static void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (!Theme.IsDark) { e.DrawBackground(); return; }
            var cb = (ComboBox)sender;
            bool selected = (e.State & DrawItemState.Selected) != 0;
            Color bgColor = selected ? Theme.Accent : Theme.BgInput;
            using (var bg = new SolidBrush(bgColor))
                e.Graphics.FillRectangle(bg, e.Bounds);
            string text = (e.Index >= 0 && e.Index < cb.Items.Count)
                ? cb.GetItemText(cb.Items[e.Index])
                : string.Empty;
            var pad = new Rectangle(e.Bounds.X + 2, e.Bounds.Y, Math.Max(0, e.Bounds.Width - 4), e.Bounds.Height);
            TextRenderer.DrawText(e.Graphics, text, e.Font, pad, Theme.FgPrimary,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding | TextFormatFlags.EndEllipsis);
        }

        // ---- DataGridView ----------------------------------------------------------

        private static void ApplyDataGridView(DataGridView dgv)
        {
            if (Theme.IsDark)
            {
                dgv.BackgroundColor = Theme.BgInput;
                dgv.GridColor = Theme.Border;
                dgv.BorderStyle = BorderStyle.FixedSingle;
                dgv.EnableHeadersVisualStyles = false;

                dgv.DefaultCellStyle.BackColor = Theme.BgInput;
                dgv.DefaultCellStyle.ForeColor = Theme.FgPrimary;
                dgv.DefaultCellStyle.SelectionBackColor = Theme.Accent;
                dgv.DefaultCellStyle.SelectionForeColor = Theme.FgPrimary;

                dgv.ColumnHeadersDefaultCellStyle.BackColor = Theme.BgPanel;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Theme.FgPrimary;
                dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Theme.BgPanel;
                dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Theme.FgPrimary;

                dgv.RowHeadersDefaultCellStyle.BackColor = Theme.BgPanel;
                dgv.RowHeadersDefaultCellStyle.ForeColor = Theme.FgPrimary;
                dgv.RowHeadersDefaultCellStyle.SelectionBackColor = Theme.BgPanel;
                dgv.RowHeadersDefaultCellStyle.SelectionForeColor = Theme.FgPrimary;
            }
            else
            {
                dgv.BackgroundColor = SystemColors.ButtonHighlight;
                dgv.EnableHeadersVisualStyles = true;
            }
        }

        // ---- TreeView (selection-highlight readable in dark mode) ------------------

        private static void ApplyTreeView(TreeView tv)
        {
            tv.BackColor = Theme.BgInput;
            tv.ForeColor = Theme.FgPrimary;
            tv.BorderStyle = Theme.IsDark ? BorderStyle.FixedSingle : BorderStyle.Fixed3D;
            ApplyImageListToDark(tv.ImageList);
            if (Theme.IsDark)
            {
                // OwnerDrawText: handler paints text area only; OS keeps drawing indent + ImageList icons.
                // This means existing designer-time DrawNode handlers (e.g. classesTreeView_DrawNode) fire
                // too — they paint with SystemBrushes.Highlight on (selected && unfocused), but our handler
                // runs after them and overpaints with Theme.Accent. Harmless.
                tv.DrawMode = TreeViewDrawMode.OwnerDrawText;
                if (!_tvHandlers.Contains(tv))
                {
                    tv.DrawNode += TreeView_DrawNode;
                    _tvHandlers.Add(tv);
                }
            }
            else
            {
                // Light mode: OS handles everything. Designer handlers become dormant at Normal.
                tv.DrawMode = TreeViewDrawMode.Normal;
            }
            TryDarkenNative(tv);
        }

        // ImageList icons (especially the property-tree's imgClass16x16.png / selWP.png / folder.png)
        // were embedded in the resx as 8bit/24bit bitmaps with a literal white backdrop. The designer
        // set TransparentColor=Transparent, which means "no transparency" for these formats. Result:
        // a white square framed each icon in dark mode.
        //
        // Critical: ImageList.TransparentColor only affects images added AFTER the setter is called.
        // Existing entries keep their original transparency. Workaround: snapshot images, clear the
        // list, set TransparentColor=White, then re-add — the white backdrop becomes transparent.
        // Idempotent via _ilDarkApplied.
        private static void ApplyImageListToDark(ImageList il)
        {
            if (il == null) return;
            if (Theme.IsDark && !_ilDarkApplied.Contains(il))
            {
                try
                {
                    int count = il.Images.Count;
                    if (count == 0)
                    {
                        il.TransparentColor = Color.White;
                        _ilDarkApplied.Add(il);
                        return;
                    }
                    var images = new Bitmap[count];
                    var keys = new string[count];
                    for (int i = 0; i < count; i++)
                    {
                        // Force RGB clone — keeps weiß-as-white so the transparency map matches at re-add time.
                        images[i] = new Bitmap(il.Images[i]);
                        keys[i] = il.Images.Keys[i];
                    }
                    il.Images.Clear();
                    il.TransparentColor = Color.White;
                    for (int i = 0; i < count; i++)
                    {
                        if (!string.IsNullOrEmpty(keys[i]))
                            il.Images.Add(keys[i], images[i]);
                        else
                            il.Images.Add(images[i]);
                    }
                    _ilDarkApplied.Add(il);
                }
                catch
                {
                    // If anything fails (e.g. another thread holding the list), leave it as-is rather
                    // than risk a half-rebuilt ImageList that breaks ImageIndex references.
                }
            }
            // Note: we never undo the dark-mode rebuild on theme-switch back to light — that would
            // require keeping pristine originals around. Acceptable: light-mode white-icons-on-white
            // are visually OK with TransparentColor=White (no white-frame artifact).
        }

        private static void TreeView_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (!Theme.IsDark || e.Node == null) { e.DrawDefault = true; return; }
            bool selected = (e.State & TreeNodeStates.Selected) == TreeNodeStates.Selected;
            if (!selected) { e.DrawDefault = true; return; }
            var tv = (TreeView)sender;
            var font = e.Node.NodeFont ?? tv.Font;
            using (var bg = new SolidBrush(Theme.Accent))
                e.Graphics.FillRectangle(bg, e.Bounds);
            TextRenderer.DrawText(e.Graphics, e.Node.Text, font, e.Bounds, Theme.FgPrimary,
                TextFormatFlags.GlyphOverhangPadding | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
            // We painted everything in e.Bounds — override DrawDefault that the prior designer-time
            // handler may have set, so the OS doesn't draw on top of us.
            e.DrawDefault = false;
        }

        // ---- ListView (Details view: header + zebra/severity backgrounds) ----------

        private static void ApplyListView(ListView lv)
        {
            lv.BackColor = Theme.BgInput;
            lv.ForeColor = Theme.FgPrimary;
            if (Theme.IsDark)
            {
                lv.BorderStyle = BorderStyle.FixedSingle;
                if (!_lvHandlers.Contains(lv))
                {
                    lv.OwnerDraw = true;
                    lv.DrawColumnHeader += ListView_DrawColumnHeader;
                    lv.DrawItem += ListView_DrawItem;
                    lv.DrawSubItem += ListView_DrawSubItem;
                    _lvHandlers.Add(lv);
                }
            }
            else
            {
                lv.BorderStyle = BorderStyle.Fixed3D;
                // OwnerDraw handlers are stable across theme switches — keep them attached;
                // they early-out when !Theme.IsDark via DrawDefault.
            }
            TryDarkenNative(lv);
        }

        private static void ListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            if (!Theme.IsDark) { e.DrawDefault = true; return; }
            using (var bg = new SolidBrush(Theme.BgPanel))
                e.Graphics.FillRectangle(bg, e.Bounds);
            using (var pen = new Pen(Theme.Border))
                e.Graphics.DrawRectangle(pen, e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1);
            var textRect = new Rectangle(e.Bounds.X + 4, e.Bounds.Y, e.Bounds.Width - 8, e.Bounds.Height);
            TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, textRect, Theme.FgPrimary,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding | TextFormatFlags.EndEllipsis);
        }

        private static void ListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            if (!Theme.IsDark) { e.DrawDefault = true; return; }
            var lv = (ListView)sender;
            // In Details view, DrawSubItem renders each cell. Only handle non-Details here.
            if (lv.View == View.Details)
            {
                return;
            }
            bool selected = (e.State & ListViewItemStates.Selected) != 0;
            var bgColor = selected ? Theme.Accent : Theme.BgInput;
            using (var bg = new SolidBrush(bgColor))
                e.Graphics.FillRectangle(bg, e.Bounds);
            TextRenderer.DrawText(e.Graphics, e.Item.Text, e.Item.Font, e.Bounds, Theme.FgPrimary,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
        }

        // Find a severity color in the item's subitems (e.g. INFO-blue / WARN-orange / CRIT-red
        // set as SubItem.BackColor in SearchErrorsForm). Returns Color.Empty if none.
        private static Color FindSeverityColor(ListViewItem item)
        {
            if (item == null) return Color.Empty;
            for (int i = 0; i < item.SubItems.Count; i++)
            {
                var sub = item.SubItems[i];
                var bg = sub.BackColor;
                if (bg.A == 0) continue;
                // Light-mode defaults (white / zebra-light grey) are not severity markers.
                bool isLight = bg == Color.White || (bg.R >= 220 && bg.G >= 220 && bg.B >= 220);
                if (isLight) continue;
                return bg;
            }
            return Color.Empty;
        }

        private static void ListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (!Theme.IsDark) { e.DrawDefault = true; return; }
            // Use the framework's authoritative Selected property — e.ItemState is unreliable on
            // ListViews with FullRowSelect=true + HideSelection=false; it can report Selected for
            // unselected rows, which made every row paint as if selected.
            bool selected = e.Item != null && e.Item.Selected;

            // All cells get the same uniform background — no per-column severity fill.
            Color bgColor = selected ? Theme.Accent : Theme.BgInput;
            using (var bg = new SolidBrush(bgColor))
                e.Graphics.FillRectangle(bg, e.Bounds);

            int textIndent = 4;
            if (e.ColumnIndex == 0)
            {
                // Severity stripe: drawn always on column 0, regardless of selection. For selected
                // rows we still want the severity visible (the accent bg is behind, stripe overlays).
                var severity = FindSeverityColor(e.Item);
                if (!severity.IsEmpty)
                {
                    using (var stripe = new SolidBrush(severity))
                        e.Graphics.FillRectangle(stripe, e.Bounds.X, e.Bounds.Y, 4, e.Bounds.Height);
                    textIndent = 8;
                }
            }

            // SubItem.ForeColor is often Color.Black (caller never sets it), unreadable on dark.
            var pad = new Rectangle(e.Bounds.X + textIndent, e.Bounds.Y,
                Math.Max(0, e.Bounds.Width - textIndent - 4), e.Bounds.Height);
            TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.SubItem.Font ?? e.Item.Font, pad, Theme.FgPrimary,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }

        // ---- Disabled-state overlays (Button / CheckBox / RadioButton) -------------

        private static void Button_EnabledChanged(object sender, EventArgs e) { ((Control)sender).Invalidate(); }
        private static void CheckBox_EnabledChanged(object sender, EventArgs e) { ((Control)sender).Invalidate(); }
        private static void RadioButton_EnabledChanged(object sender, EventArgs e) { ((Control)sender).Invalidate(); }
        private static void Label_EnabledChanged(object sender, EventArgs e) { ((Control)sender).Invalidate(); }

        private static TextFormatFlags AlignToFlags(ContentAlignment a)
        {
            TextFormatFlags f = TextFormatFlags.NoPadding;
            switch (a)
            {
                case ContentAlignment.TopLeft:      f |= TextFormatFlags.Top    | TextFormatFlags.Left; break;
                case ContentAlignment.TopCenter:    f |= TextFormatFlags.Top    | TextFormatFlags.HorizontalCenter; break;
                case ContentAlignment.TopRight:     f |= TextFormatFlags.Top    | TextFormatFlags.Right; break;
                case ContentAlignment.MiddleLeft:   f |= TextFormatFlags.VerticalCenter | TextFormatFlags.Left; break;
                case ContentAlignment.MiddleCenter: f |= TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter; break;
                case ContentAlignment.MiddleRight:  f |= TextFormatFlags.VerticalCenter | TextFormatFlags.Right; break;
                case ContentAlignment.BottomLeft:   f |= TextFormatFlags.Bottom | TextFormatFlags.Left; break;
                case ContentAlignment.BottomCenter: f |= TextFormatFlags.Bottom | TextFormatFlags.HorizontalCenter; break;
                case ContentAlignment.BottomRight:  f |= TextFormatFlags.Bottom | TextFormatFlags.Right; break;
            }
            return f;
        }

        private static void Label_PaintDisabledOverlay(object sender, PaintEventArgs e)
        {
            if (!Theme.IsDark) return;
            var lbl = (Label)sender;
            if (lbl.Enabled) return;

            Color bgColor = lbl.BackColor;
            if (bgColor == Color.Transparent || bgColor.A == 0)
                bgColor = lbl.Parent != null ? lbl.Parent.BackColor : Theme.BgPanel;

            using (var bg = new SolidBrush(bgColor))
                e.Graphics.FillRectangle(bg, lbl.ClientRectangle);

            TextRenderer.DrawText(e.Graphics, lbl.Text, lbl.Font, lbl.ClientRectangle,
                _dDisabledFg, AlignToFlags(lbl.TextAlign));
        }

        private static void Button_PaintDisabledOverlay(object sender, PaintEventArgs e)
        {
            if (!Theme.IsDark) return;
            var b = (Button)sender;
            if (b.Enabled) return;
            var g = e.Graphics;
            using (var bg = new SolidBrush(Theme.BgPanel))
                g.FillRectangle(bg, 0, 0, b.Width, b.Height);
            using (var pen = new Pen(Theme.Border))
                g.DrawRectangle(pen, 0, 0, b.Width - 1, b.Height - 1);
            TextRenderer.DrawText(g, b.Text, b.Font, b.ClientRectangle, _dDisabledFg,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private static void CheckBox_PaintDisabledOverlay(object sender, PaintEventArgs e)
        {
            if (!Theme.IsDark) return;
            var cb = (CheckBox)sender;
            if (cb.Enabled) return;
            // Glyph occupies roughly the first 14-16px; overdraw only the text area to keep glyph intact.
            int glyphArea = 16;
            int textX = glyphArea;
            int textW = Math.Max(0, cb.Width - textX);
            var textRect = new Rectangle(textX, 0, textW, cb.Height);
            using (var bg = new SolidBrush(cb.BackColor))
                e.Graphics.FillRectangle(bg, textRect);
            TextRenderer.DrawText(e.Graphics, cb.Text, cb.Font, textRect, _dDisabledFg,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding | TextFormatFlags.WordBreak);
        }

        private static void RadioButton_PaintDisabledOverlay(object sender, PaintEventArgs e)
        {
            if (!Theme.IsDark) return;
            var rb = (RadioButton)sender;
            if (rb.Enabled) return;
            int glyphArea = 16;
            int textX = glyphArea;
            int textW = Math.Max(0, rb.Width - textX);
            var textRect = new Rectangle(textX, 0, textW, rb.Height);
            using (var bg = new SolidBrush(rb.BackColor))
                e.Graphics.FillRectangle(bg, textRect);
            TextRenderer.DrawText(e.Graphics, rb.Text, rb.Font, textRect, _dDisabledFg,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding | TextFormatFlags.WordBreak);
        }

        private static void GroupBox_Paint(object sender, PaintEventArgs e)
        {
            if (!Theme.IsDark) return;

            var gb = (GroupBox)sender;
            var g = e.Graphics;

            using (var bg = new SolidBrush(gb.BackColor))
            {
                g.FillRectangle(bg, gb.ClientRectangle);
            }

            var textSize = string.IsNullOrEmpty(gb.Text)
                ? Size.Empty
                : g.MeasureString(gb.Text, gb.Font).ToSize();
            int top = textSize.Height / 2;

            var border = new Rectangle(0, top, gb.Width - 1, gb.Height - top - 1);
            using (var pen = new Pen(Theme.Border))
            {
                g.DrawRectangle(pen, border);
            }

            if (!string.IsNullOrEmpty(gb.Text))
            {
                var textRect = new Rectangle(8, 0, textSize.Width, textSize.Height);
                using (var bg = new SolidBrush(gb.BackColor))
                {
                    g.FillRectangle(bg, textRect);
                }
                Color titleColor = gb.Enabled ? gb.ForeColor : _dDisabledFg;
                using (var fg = new SolidBrush(titleColor))
                {
                    g.DrawString(gb.Text, gb.Font, fg, 8, 0);
                }
            }
        }

        private static void TabControl_Paint(object sender, PaintEventArgs e)
        {
            if (!Theme.IsDark) return;  // light mode: let WinForms draw with visual styles

            var tc = (TabControl)sender;
            var g = e.Graphics;

            // 1. Fill the FULL control rectangle, NOT tc.ClientRectangle — for TabControl, ClientRectangle
            //    excludes the tab strip and a sliver of border around the TabPage area on most Windows
            //    versions, leaving white slivers behind the headers and around the page perimeter.
            //    TabPages overdraw their own area afterwards (see TabPage branch in ApplyToControl), so
            //    over-fill here is harmless.
            using (var bg = new SolidBrush(Theme.BgPanel))
            {
                g.FillRectangle(bg, 0, 0, tc.Width, tc.Height);
            }

            // 2. Draw each tab header on top
            for (int i = 0; i < tc.TabCount; i++)
            {
                var rect = tc.GetTabRect(i);
                var page = tc.TabPages[i];
                var headerBg = i == tc.SelectedIndex ? Theme.MenuHigh : Theme.BgPanel;

                using (var bg = new SolidBrush(headerBg))
                    g.FillRectangle(bg, rect);
                using (var pen = new Pen(Theme.Border))
                    g.DrawRectangle(pen, rect.X, rect.Y, rect.Width - 1, rect.Height - 1);
                using (var fg = new SolidBrush(Theme.FgPrimary))
                {
                    var size = g.MeasureString(page.Text, tc.Font);
                    g.DrawString(page.Text, tc.Font, fg,
                        rect.Left + (rect.Width - size.Width) / 2,
                        rect.Top + (rect.Height - size.Height) / 2);
                }
            }

            // 3. Border around the displayed TabPage area
            if (tc.TabCount > 0 && tc.SelectedIndex >= 0)
            {
                var pageRect = tc.GetTabRect(tc.SelectedIndex);
                var contentTop = pageRect.Bottom;
                var contentRect = new Rectangle(0, contentTop, tc.Width - 1, tc.Height - contentTop - 1);
                using (var pen = new Pen(Theme.Border))
                    g.DrawRectangle(pen, contentRect);
            }
        }
    }
}
