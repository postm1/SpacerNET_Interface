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
            this.очиститьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBarRadius = new System.Windows.Forms.TrackBar();
            this.labelRadius = new System.Windows.Forms.Label();
            this.panelVobList = new System.Windows.Forms.Panel();
            this.btnRemoveContainerVobs = new System.Windows.Forms.Button();
            this.comboBoxVobList = new System.Windows.Forms.ComboBox();
            this.panelVobListBottom = new System.Windows.Forms.Panel();
            this.buttonVobListSearch = new System.Windows.Forms.Button();
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
            this.listBoxVobs.Size = new System.Drawing.Size(301, 256);
            this.listBoxVobs.TabIndex = 0;
            this.listBoxVobs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxVobs_MouseClick);
            this.listBoxVobs.SelectedIndexChanged += new System.EventHandler(this.listBoxVobs_SelectedIndexChanged);
            this.listBoxVobs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxVobs_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьСписокToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 26);
            // 
            // очиститьСписокToolStripMenuItem
            // 
            this.очиститьСписокToolStripMenuItem.Name = "очиститьСписокToolStripMenuItem";
            this.очиститьСписокToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.очиститьСписокToolStripMenuItem.Text = "Очистить список";
            this.очиститьСписокToolStripMenuItem.Click += new System.EventHandler(this.очиститьСписокToolStripMenuItem_Click);
            // 
            // trackBarRadius
            // 
            this.trackBarRadius.Location = new System.Drawing.Point(114, 8);
            this.trackBarRadius.Maximum = 3500;
            this.trackBarRadius.Minimum = 10;
            this.trackBarRadius.Name = "trackBarRadius";
            this.trackBarRadius.Size = new System.Drawing.Size(181, 45);
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
            this.labelRadius.Size = new System.Drawing.Size(106, 13);
            this.labelRadius.TabIndex = 4;
            this.labelRadius.Text = "Радиус поиска: 200";
            // 
            // panelVobList
            // 
            this.panelVobList.Controls.Add(this.buttonVobListSearch);
            this.panelVobList.Controls.Add(this.btnRemoveContainerVobs);
            this.panelVobList.Controls.Add(this.comboBoxVobList);
            this.panelVobList.Controls.Add(this.labelRadius);
            this.panelVobList.Controls.Add(this.trackBarRadius);
            this.panelVobList.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVobList.Location = new System.Drawing.Point(2, 2);
            this.panelVobList.Name = "panelVobList";
            this.panelVobList.Size = new System.Drawing.Size(303, 72);
            this.panelVobList.TabIndex = 7;
            // 
            // btnRemoveContainerVobs
            // 
            this.btnRemoveContainerVobs.Location = new System.Drawing.Point(214, 38);
            this.btnRemoveContainerVobs.Name = "btnRemoveContainerVobs";
            this.btnRemoveContainerVobs.Size = new System.Drawing.Size(80, 23);
            this.btnRemoveContainerVobs.TabIndex = 6;
            this.btnRemoveContainerVobs.Text = "Удалить";
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
            "oCMOB"});
            this.comboBoxVobList.Location = new System.Drawing.Point(0, 39);
            this.comboBoxVobList.Name = "comboBoxVobList";
            this.comboBoxVobList.Size = new System.Drawing.Size(122, 21);
            this.comboBoxVobList.TabIndex = 5;
            this.comboBoxVobList.SelectedIndexChanged += new System.EventHandler(this.comboBoxVobList_SelectedIndexChanged);
            // 
            // panelVobListBottom
            // 
            this.panelVobListBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVobListBottom.Controls.Add(this.listBoxVobs);
            this.panelVobListBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVobListBottom.Location = new System.Drawing.Point(2, 74);
            this.panelVobListBottom.Name = "panelVobListBottom";
            this.panelVobListBottom.Size = new System.Drawing.Size(303, 258);
            this.panelVobListBottom.TabIndex = 8;
            // 
            // buttonVobListSearch
            // 
            this.buttonVobListSearch.Location = new System.Drawing.Point(128, 38);
            this.buttonVobListSearch.Name = "buttonVobListSearch";
            this.buttonVobListSearch.Size = new System.Drawing.Size(80, 23);
            this.buttonVobListSearch.TabIndex = 7;
            this.buttonVobListSearch.Text = "Найти";
            this.buttonVobListSearch.UseVisualStyleBackColor = true;
            this.buttonVobListSearch.Click += new System.EventHandler(this.buttonVobListSearch_Click);
            // 
            // VobListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 334);
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
            this.Text = "Контейнер вобов";
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
        private System.Windows.Forms.ToolStripMenuItem очиститьСписокToolStripMenuItem;
        public System.Windows.Forms.TrackBar trackBarRadius;
        private System.Windows.Forms.Panel panelVobList;
        private System.Windows.Forms.ComboBox comboBoxVobList;
        private System.Windows.Forms.Button btnRemoveContainerVobs;
        private System.Windows.Forms.Panel panelVobListBottom;
        private System.Windows.Forms.Button buttonVobListSearch;
    }
}