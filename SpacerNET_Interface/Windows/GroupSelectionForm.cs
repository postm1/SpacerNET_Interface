using System;
using System.Drawing;
using System.Windows.Forms;
using SpacerUnion.Common;

namespace SpacerUnion
{
    // Modeless owner window; does not resize or cover the render viewport.
    public sealed class GroupSelectionForm : Form
    {
        private readonly MainForm host;
        private readonly ComboBox filter;
        private readonly ComboBox mode;
        private readonly CheckBox through;
        private readonly NumericUpDown[] deltas;
        private readonly Label[] axisLabels;
        private readonly Label filterLabel, modeLabel, selectedCount, pivotHelp, keyboardHelp, result;
        private readonly GroupBox controlsGroup;
        private readonly Label mouseHelp, cameraHelp, bindingsHelp;
        private readonly Button apply, undo, clear;
        private bool updating;
        private int displayedMode = -1;

        public GroupSelectionForm(MainForm owner)
        {
            host = owner;
            Owner = owner;
            Name = "groupSelectionWindow";
            ShowInTaskbar = false;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(520, 600);
            MinimumSize = new Size(500, 520);
            AutoScroll = true;

            var layout = new TableLayoutPanel {
                Dock = DockStyle.Top, AutoSize = true, Padding = new Padding(12),
                ColumnCount = 1, RowCount = 9
            };
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            for(int row=0;row<layout.RowCount;++row)layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            Controls.Add(layout);
            selectedCount = new Label { AutoSize = true, Margin = new Padding(0,0,0,10) };
            layout.Controls.Add(selectedCount);
            filterLabel = new Label { AutoSize = true };
            filter = new ComboBox { Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDownList };
            var filterRow = new TableLayoutPanel { Dock=DockStyle.Top, AutoSize=true, ColumnCount=2 };
            filterRow.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            filterRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,100));
            filterRow.Controls.Add(filterLabel); filterRow.Controls.Add(filter);
            layout.Controls.Add(filterRow);
            through = new CheckBox { AutoSize=true, Margin=new Padding(0,5,0,5) };
            layout.Controls.Add(through);
            modeLabel = new Label { AutoSize=true };
            mode = new ComboBox { Dock=DockStyle.Fill, DropDownStyle=ComboBoxStyle.DropDownList };
            var modeRow = new TableLayoutPanel { Dock=DockStyle.Top, AutoSize=true, ColumnCount=2 };
            modeRow.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            modeRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,100));
            modeRow.Controls.Add(modeLabel); modeRow.Controls.Add(mode);
            layout.Controls.Add(modeRow);
            pivotHelp = new Label { AutoSize=true, MaximumSize=new Size(440,0), Margin=new Padding(0,8,0,8) };
            layout.Controls.Add(pivotHelp);
            var axes = new TableLayoutPanel { Dock=DockStyle.Top, AutoSize=true, ColumnCount=3, RowCount=2 };
            deltas = new NumericUpDown[3]; axisLabels = new Label[3];
            for(int i=0;i<3;++i) {
                axes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,100f/3));
                axisLabels[i]=new Label { AutoSize=true };
                deltas[i]=new NumericUpDown {
                    DecimalPlaces=3, Minimum=-1000000, Maximum=1000000, Increment=10,
                    Dock=DockStyle.Fill, TextAlign=HorizontalAlignment.Right
                };
                axes.Controls.Add(axisLabels[i],i,0); axes.Controls.Add(deltas[i],i,1);
            }
            layout.Controls.Add(axes);
            var actions = new FlowLayoutPanel { Dock=DockStyle.Top, AutoSize=true, Margin=new Padding(0,10,0,5) };
            apply=new Button {AutoSize=true}; undo=new Button {AutoSize=true}; clear=new Button {AutoSize=true};
            actions.Controls.Add(apply);actions.Controls.Add(undo);actions.Controls.Add(clear);
            layout.Controls.Add(actions);
            result=new Label {AutoSize=true, MaximumSize=new Size(440,0),ForeColor=Color.Firebrick};
            layout.Controls.Add(result);
            controlsGroup=new GroupBox {Dock=DockStyle.Top,AutoSize=true,Padding=new Padding(10)};
            var controlsLayout=new TableLayoutPanel {
                Dock=DockStyle.Top,AutoSize=true,ColumnCount=1,RowCount=4
            };
            controlsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,100));
            for(int row=0;row<4;++row)controlsLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            mouseHelp=new Label {AutoSize=true,MaximumSize=new Size(440,0),Margin=new Padding(0,4,0,8)};
            keyboardHelp=new Label {AutoSize=true,MaximumSize=new Size(440,0),Margin=new Padding(0,0,0,8)};
            cameraHelp=new Label {AutoSize=true,MaximumSize=new Size(440,0),Margin=new Padding(0,0,0,8)};
            bindingsHelp=new Label {AutoSize=true,MaximumSize=new Size(440,0),Margin=new Padding(0)};
            controlsLayout.Controls.Add(mouseHelp);
            controlsLayout.Controls.Add(keyboardHelp);
            controlsLayout.Controls.Add(cameraHelp);
            controlsLayout.Controls.Add(bindingsHelp);
            controlsGroup.Controls.Add(controlsLayout);
            layout.Controls.Add(controlsGroup);

            filter.SelectedIndexChanged+=(s,e)=> {
                if(updating || filter.SelectedIndex<0)return;
                Imports.Extern_SetMultiSelectionFilter(filter.SelectedIndex);
                result.Text=""; RefreshState();
            };
            through.CheckedChanged+=(s,e)=> {
                if(!updating)Imports.Extern_SetMultiSelectionThroughWalls(through.Checked?1:0);
            };
            mode.SelectedIndexChanged+=(s,e)=> {
                if(updating || mode.SelectedIndex<0)return;
                Imports.Extern_SetMultiSelectionTransformMode(mode.SelectedIndex);
                SetDisplayedMode(mode.SelectedIndex);
                result.Text=""; RefreshState();
            };
            apply.Click+=(s,e)=> {
                if(!ValidateChildren())return;
                float x=(float)deltas[0].Value,y=(float)deltas[1].Value,z=(float)deltas[2].Value;
                ShowResult(mode.SelectedIndex==1
                    ? Imports.Extern_RotateSelectedVobs(x,y,z) : Imports.Extern_MoveSelectedVobs(x,y,z));
                RefreshState();
            };
            undo.Click+=(s,e)=> {ShowResult(Imports.Extern_UndoSelectionMove());RefreshState();};
            clear.Click+=(s,e)=> {Imports.Extern_ClearMultiSelection();result.Text="";RefreshState();};
            FormClosing+=(s,e)=> {
                if(e.CloseReason==CloseReason.UserClosing && !host.IsDisposed && !host.Disposing) {
                    e.Cancel=true; host.LeaveGroupSelection(); Hide();
                }
            };
            UpdateLanguage();
        }

        protected override bool ShowWithoutActivation { get { return true; } }

        private static string[] FilterLabels()
        {
            // Initial IDs remain stable. The rest cover both legacy VOB filter lists.
            return new[] {
                Localizator.Get("MULTI_ALL"), Localizator.Get("MULTI_NO_MOVERS"),
                Localizator.Get("MULTI_NO_POINTS"), Localizator.Get("MULTI_ITEMS"), Localizator.Get("MULTI_VOBS"),
                "WP + Freepoint", "WP (zCVobWaypoint)", "Freepoint (zCVobSpot)", "oCMOB",
                Localizator.Get("MULTI_DYNAMIC_COLLISION"), "oCMobInter",
                "zCVobLight", "zCVobSound", Localizator.Get("VOB_FILTER_IGNORE_PFX"),
                Localizator.Get("VOB_FILTER_SHOW_ONLY_INVISIBLE"), Localizator.Get("VOB_FILTER_IGNORE_DECALS"),
                Localizator.Get("VOB_FILTER_IGNORE_DECALS_PFX"), "zCDecal", "PFX (zCParticleFX)",
                "zCTrigger", "zCZone", "oCZoneMusic"
            };
        }

        /// <summary>Relabel controls without changing filter, transform mode or numeric input.</summary>
        public void UpdateLanguage()
        {
            updating=true;
            try {
                int oldFilter=filter.SelectedIndex, oldMode=mode.SelectedIndex;
                filter.Items.Clear();filter.Items.AddRange(FilterLabels());
                filter.SelectedIndex=oldFilter>=0&&oldFilter<filter.Items.Count?oldFilter:0;
                mode.Items.Clear();mode.Items.AddRange(new[] {
                    Localizator.Get("MULTI_TRANSLATION_MODE"),Localizator.Get("MULTI_ROTATION_MODE")});
                mode.SelectedIndex=oldMode==1?1:0;
                Text=Localizator.Get("MULTI_BAR");
                filterLabel.Text=Localizator.Get("MULTI_FILTER_LABEL");
                modeLabel.Text=Localizator.Get("MULTI_MODE_LABEL");
                through.Text=Localizator.Get("MULTI_THROUGH_WALLS");
                undo.Text=Localizator.Get("MULTI_UNDO");
                clear.Text=Localizator.Get("MULTI_CLEAR");
                controlsGroup.Text=Localizator.Get("MULTI_CONTROLS_TITLE");
                mouseHelp.Text=Localizator.Get("MULTI_SCENE_CONTROLS")+Environment.NewLine
                    +Localizator.Get("WIN_TREE_TITLE")+": "+Localizator.Get("MULTI_LIST_HELP");
                cameraHelp.Text=Localizator.Get("MULTI_CAMERA_CONTROLS");
                bindingsHelp.Text=Localizator.Get("MULTI_DEFAULT_BINDINGS");
                SetDisplayedMode(mode.SelectedIndex);
                result.Text="";
            } finally {updating=false;}
        }

        private void SetDisplayedMode(int value)
        {
            bool rotation=value==1;
            if(displayedMode!=value) {
                foreach(var number in deltas) {
                    number.Value=0;
                    number.Minimum=rotation?-3600:-1000000;
                    number.Maximum=rotation?3600:1000000;
                    number.Increment=rotation?5:10;
                }
                displayedMode=value;
            }
            string[] axes={"X","Y","Z"};
            for(int i=0;i<3;++i)axisLabels[i].Text="\u0394"+axes[i]+(rotation?" (\u00b0)":"");
            apply.Text=Localizator.Get(rotation?"MULTI_ROTATE":"MULTI_MOVE");
            pivotHelp.Text=Localizator.Get(rotation?"MULTI_PIVOT_HELP":"MULTI_TRANSLATION_HELP");
            keyboardHelp.Text=Localizator.Get(rotation?"MULTI_ROTATION_KEYS":"MULTI_TRANSLATION_KEYS");
            if(rotation)keyboardHelp.Text+=Environment.NewLine+Localizator.Get("MULTI_SPEED_KEYS");
        }

        private void ShowResult(int value)
        {
            result.Text=value==-2?Localizator.Get("MULTI_COMPOUND_BLOCKED")
                :value==-3?Localizator.Get("MULTI_TRANSFORM_INVALID")
                :value<0?Localizator.Get("MULTI_MOVE_INVALID"):"";
        }

        /// <summary>Read backend settings/count/undo state and disable editing during play mode.</summary>
        public void RefreshState()
        {
            if(IsDisposed)return;
            updating=true;
            try {
                Imports.Stack_PushString("multiSelectionFilter");
                int selectedFilter=Imports.Extern_GetSetting();
                filter.SelectedIndex=selectedFilter>=0&&selectedFilter<filter.Items.Count?selectedFilter:0;
                Imports.Stack_PushString("multiSelectionTransformMode");
                int selectedMode=Imports.Extern_GetSetting()==1?1:0;
                mode.SelectedIndex=selectedMode;SetDisplayedMode(selectedMode);
                Imports.Stack_PushString("multiSelectionThroughWalls");
                through.Checked=Imports.Extern_GetSetting()!=0;
                int count=Imports.Extern_GetMultiSelectionCount();
                selectedCount.Text=Localizator.Get("MULTI_SELECTED")+": "+count;
                bool editing=Imports.Extern_IsGameModActive()==0;
                apply.Enabled=editing&&count>0;
                undo.Enabled=editing&&Imports.Extern_CanUndoSelectionMove()!=0;
                clear.Enabled=editing&&count>0;
                filter.Enabled=mode.Enabled=through.Enabled=editing;
                foreach(var number in deltas)number.Enabled=editing;
            } finally {updating=false;}
        }
    }
}
