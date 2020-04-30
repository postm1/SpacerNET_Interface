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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBarRadius = new System.Windows.Forms.TrackBar();
            this.labelRadius = new System.Windows.Forms.Label();
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 48);
            // 
            // очиститьСписокToolStripMenuItem
            // 
            this.очиститьСписокToolStripMenuItem.Name = "очиститьСписокToolStripMenuItem";
            this.очиститьСписокToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.очиститьСписокToolStripMenuItem.Text = "Очистить список";
            this.очиститьСписокToolStripMenuItem.Click += new System.EventHandler(this.очиститьСписокToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Custom";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Actions >>";
            this.button2.UseVisualStyleBackColor = true;
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
            // VobListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 334);
            this.Controls.Add(this.labelRadius);
            this.Controls.Add(this.trackBarRadius);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ListBox listBoxVobs;
        private System.Windows.Forms.TrackBar trackBarRadius;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem очиститьСписокToolStripMenuItem;
    }
}