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
            this.comboBoxVobListType = new System.Windows.Forms.ComboBox();
            this.labelVobType = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxVobs
            // 
            this.listBoxVobs.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxVobs.FormattingEnabled = true;
            this.listBoxVobs.Location = new System.Drawing.Point(6, 85);
            this.listBoxVobs.Name = "listBoxVobs";
            this.listBoxVobs.ScrollAlwaysVisible = true;
            this.listBoxVobs.Size = new System.Drawing.Size(291, 238);
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
            this.trackBarRadius.Location = new System.Drawing.Point(116, 34);
            this.trackBarRadius.Maximum = 800;
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
            this.labelRadius.Location = new System.Drawing.Point(3, 34);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(106, 13);
            this.labelRadius.TabIndex = 4;
            this.labelRadius.Text = "Радиус поиска: 200";
            // 
            // comboBoxVobListType
            // 
            this.comboBoxVobListType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVobListType.FormattingEnabled = true;
            this.comboBoxVobListType.Items.AddRange(new object[] {
            "Все вобы",
            "Итемы",
            "Только zCVob"});
            this.comboBoxVobListType.Location = new System.Drawing.Point(116, 7);
            this.comboBoxVobListType.Name = "comboBoxVobListType";
            this.comboBoxVobListType.Size = new System.Drawing.Size(179, 21);
            this.comboBoxVobListType.TabIndex = 5;
            // 
            // labelVobType
            // 
            this.labelVobType.AutoSize = true;
            this.labelVobType.Location = new System.Drawing.Point(53, 10);
            this.labelVobType.Name = "labelVobType";
            this.labelVobType.Size = new System.Drawing.Size(56, 13);
            this.labelVobType.TabIndex = 6;
            this.labelVobType.Text = "Тип воба:";
            // 
            // VobListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 334);
            this.Controls.Add(this.labelVobType);
            this.Controls.Add(this.comboBoxVobListType);
            this.Controls.Add(this.labelRadius);
            this.Controls.Add(this.trackBarRadius);
            this.Controls.Add(this.listBoxVobs);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VobListForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Контейнер вобов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VobListForm_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListBox listBoxVobs;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem очиститьСписокToolStripMenuItem;
        private System.Windows.Forms.Label labelVobType;
        public System.Windows.Forms.TrackBar trackBarRadius;
        public System.Windows.Forms.ComboBox comboBoxVobListType;
    }
}