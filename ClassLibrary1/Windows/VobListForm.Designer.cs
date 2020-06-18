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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panelVobList = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).BeginInit();
            this.panelVobList.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxVobs
            // 
            this.listBoxVobs.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxVobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxVobs.FormattingEnabled = true;
            this.listBoxVobs.Location = new System.Drawing.Point(0, 66);
            this.listBoxVobs.Name = "listBoxVobs";
            this.listBoxVobs.ScrollAlwaysVisible = true;
            this.listBoxVobs.Size = new System.Drawing.Size(307, 268);
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
            this.labelRadius.Location = new System.Drawing.Point(3, 9);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(106, 13);
            this.labelRadius.TabIndex = 4;
            this.labelRadius.Text = "Радиус поиска: 200";
            // 
            // panelVobList
            // 
            this.panelVobList.Controls.Add(this.labelRadius);
            this.panelVobList.Controls.Add(this.trackBarRadius);
            this.panelVobList.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVobList.Location = new System.Drawing.Point(0, 0);
            this.panelVobList.Name = "panelVobList";
            this.panelVobList.Size = new System.Drawing.Size(307, 66);
            this.panelVobList.TabIndex = 7;
            // 
            // VobListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 334);
            this.Controls.Add(this.listBoxVobs);
            this.Controls.Add(this.panelVobList);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VobListForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Контейнер вобов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VobListForm_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).EndInit();
            this.panelVobList.ResumeLayout(false);
            this.panelVobList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ListBox listBoxVobs;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem очиститьСписокToolStripMenuItem;
        public System.Windows.Forms.TrackBar trackBarRadius;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panelVobList;
    }
}