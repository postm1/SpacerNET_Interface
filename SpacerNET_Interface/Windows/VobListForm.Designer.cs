namespace SpacerUnion
{
    partial class VobListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxVobs = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CleanListVobList = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBarRadius = new System.Windows.Forms.TrackBar();
            this.labelRadius = new System.Windows.Forms.Label();
            this.panelVobList = new System.Windows.Forms.Panel();
            this.labelFilterVobsPick = new System.Windows.Forms.Label();
            this.comboBoxFilterPick = new System.Windows.Forms.ComboBox();
            this.buttonVobListSearch = new System.Windows.Forms.Button();
            this.btnRemoveContainerVobs = new System.Windows.Forms.Button();
            this.comboBoxVobList = new System.Windows.Forms.ComboBox();
            this.panelVobListBottom = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).BeginInit();
            this.panelVobList.SuspendLayout();
            this.panelVobListBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxVobs
            // 
            this.listBoxVobs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxVobs.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxVobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxVobs.FormattingEnabled = true;
            this.listBoxVobs.Location = new System.Drawing.Point(0, 0);
            this.listBoxVobs.Name = "listBoxVobs";
            this.listBoxVobs.ScrollAlwaysVisible = true;
            this.listBoxVobs.Size = new System.Drawing.Size(301, 295);
            this.listBoxVobs.TabIndex = 0;
            this.listBoxVobs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxVobs_MouseClick);
            this.listBoxVobs.SelectedIndexChanged += new System.EventHandler(this.listBoxVobs_SelectedIndexChanged);
            this.listBoxVobs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxVobs_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CleanListVobList});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 26);
            // 
            // CleanListVobList
            // 
            this.CleanListVobList.Name = "CleanListVobList";
            this.CleanListVobList.Size = new System.Drawing.Size(168, 22);
            this.CleanListVobList.Text = "Очистить список";
            this.CleanListVobList.Click += new System.EventHandler(this.очиститьСписокToolStripMenuItem_Click);
            // 
            // trackBarRadius
            // 
            this.trackBarRadius.Location = new System.Drawing.Point(116, 3);
            this.trackBarRadius.Maximum = 5000;
            this.trackBarRadius.Minimum = 10;
            this.trackBarRadius.Name = "trackBarRadius";
            this.trackBarRadius.Size = new System.Drawing.Size(178, 45);
            this.trackBarRadius.TabIndex = 3;
            this.trackBarRadius.TickFrequency = 10;
            this.trackBarRadius.Value = 200;
            this.trackBarRadius.ValueChanged += new System.EventHandler(this.trackBarRadius_ValueChanged);
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Location = new System.Drawing.Point(3, 9);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(96, 13);
            this.labelRadius.TabIndex = 4;
            this.labelRadius.Text = "Search radius: 200";
            // 
            // panelVobList
            // 
            this.panelVobList.Controls.Add(this.labelFilterVobsPick);
            this.panelVobList.Controls.Add(this.comboBoxFilterPick);
            this.panelVobList.Controls.Add(this.buttonVobListSearch);
            this.panelVobList.Controls.Add(this.btnRemoveContainerVobs);
            this.panelVobList.Controls.Add(this.comboBoxVobList);
            this.panelVobList.Controls.Add(this.labelRadius);
            this.panelVobList.Controls.Add(this.trackBarRadius);
            this.panelVobList.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVobList.Location = new System.Drawing.Point(2, 2);
            this.panelVobList.Name = "panelVobList";
            this.panelVobList.Size = new System.Drawing.Size(303, 111);
            this.panelVobList.TabIndex = 7;
            // 
            // labelFilterVobsPick
            // 
            this.labelFilterVobsPick.AutoSize = true;
            this.labelFilterVobsPick.Location = new System.Drawing.Point(171, 75);
            this.labelFilterVobsPick.Name = "labelFilterVobsPick";
            this.labelFilterVobsPick.Size = new System.Drawing.Size(79, 13);
            this.labelFilterVobsPick.TabIndex = 9;
            this.labelFilterVobsPick.Text = "Vob select filter";
            // 
            // comboBoxFilterPick
            // 
            this.comboBoxFilterPick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterPick.FormattingEnabled = true;
            this.comboBoxFilterPick.Items.AddRange(new object[] {
            "NONE",
            "ITEM",
            "WP & FP",
            "WP",
            "FP",
            "oCMob",
            "Ignore NoDyn collision",
            "Trigger",
            "VobLight",
            "VobSound",
            "Ignore PFX",
            "Invisible only",
            "Ignore decals",
            "Ignore PFX & Decals"});
            this.comboBoxFilterPick.Location = new System.Drawing.Point(0, 72);
            this.comboBoxFilterPick.Name = "comboBoxFilterPick";
            this.comboBoxFilterPick.Size = new System.Drawing.Size(165, 21);
            this.comboBoxFilterPick.TabIndex = 8;
            this.comboBoxFilterPick.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterPick_SelectedIndexChanged);
            // 
            // buttonVobListSearch
            // 
            this.buttonVobListSearch.Location = new System.Drawing.Point(128, 38);
            this.buttonVobListSearch.Name = "buttonVobListSearch";
            this.buttonVobListSearch.Size = new System.Drawing.Size(80, 23);
            this.buttonVobListSearch.TabIndex = 7;
            this.buttonVobListSearch.Text = "Search";
            this.buttonVobListSearch.UseVisualStyleBackColor = true;
            this.buttonVobListSearch.Click += new System.EventHandler(this.buttonVobListSearch_Click);
            // 
            // btnRemoveContainerVobs
            // 
            this.btnRemoveContainerVobs.Location = new System.Drawing.Point(214, 38);
            this.btnRemoveContainerVobs.Name = "btnRemoveContainerVobs";
            this.btnRemoveContainerVobs.Size = new System.Drawing.Size(80, 23);
            this.btnRemoveContainerVobs.TabIndex = 6;
            this.btnRemoveContainerVobs.Text = "Clean";
            this.btnRemoveContainerVobs.UseVisualStyleBackColor = true;
            this.btnRemoveContainerVobs.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxVobList
            // 
            this.comboBoxVobList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVobList.FormattingEnabled = true;
            this.comboBoxVobList.Items.AddRange(new object[] {
            "Any",
            "zCVob",
            "oCItem",
            "zCVobSpot",
            "zCVobWaypoint",
            "zCVobSound",
            "zCDecal (.TGA)",
            "zCTrigger",
            "zCVobSpot",
            "oCMOB",
            "Invisible only",
            "zCVobLight",
            "PFX (Particles)"});
            this.comboBoxVobList.Location = new System.Drawing.Point(0, 39);
            this.comboBoxVobList.Name = "comboBoxVobList";
            this.comboBoxVobList.Size = new System.Drawing.Size(122, 21);
            this.comboBoxVobList.TabIndex = 5;
            // 
            // panelVobListBottom
            // 
            this.panelVobListBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVobListBottom.Controls.Add(this.listBoxVobs);
            this.panelVobListBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVobListBottom.Location = new System.Drawing.Point(2, 113);
            this.panelVobListBottom.Name = "panelVobListBottom";
            this.panelVobListBottom.Size = new System.Drawing.Size(303, 297);
            this.panelVobListBottom.TabIndex = 8;
            // 
            // VobListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 412);
            this.Controls.Add(this.panelVobListBottom);
            this.Controls.Add(this.panelVobList);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(323, 373);
            this.Name = "VobListForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "VobList window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VobListForm_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).EndInit();
            this.panelVobList.ResumeLayout(false);
            this.panelVobList.PerformLayout();
            this.panelVobListBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ListBox listBoxVobs;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CleanListVobList;
        public System.Windows.Forms.TrackBar trackBarRadius;
        private System.Windows.Forms.Panel panelVobList;
        private System.Windows.Forms.ComboBox comboBoxVobList;
        private System.Windows.Forms.Button btnRemoveContainerVobs;
        private System.Windows.Forms.Panel panelVobListBottom;
        private System.Windows.Forms.Button buttonVobListSearch;
        private System.Windows.Forms.Label labelFilterVobsPick;
        private System.Windows.Forms.ComboBox comboBoxFilterPick;
    }
}