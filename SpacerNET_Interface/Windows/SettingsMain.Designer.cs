namespace SpacerUnion.Windows
{
    partial class SettingsMain
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
            this.panelMainSettings = new System.Windows.Forms.Panel();
            this.listBoxSettingsLeft = new System.Windows.Forms.ListBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelSettingsCamera = new System.Windows.Forms.Panel();
            this.panelMainSettings.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainSettings
            // 
            this.panelMainSettings.Controls.Add(this.panelRight);
            this.panelMainSettings.Controls.Add(this.listBoxSettingsLeft);
            this.panelMainSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainSettings.Location = new System.Drawing.Point(0, 0);
            this.panelMainSettings.Name = "panelMainSettings";
            this.panelMainSettings.Size = new System.Drawing.Size(795, 463);
            this.panelMainSettings.TabIndex = 0;
            // 
            // listBoxSettingsLeft
            // 
            this.listBoxSettingsLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxSettingsLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxSettingsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxSettingsLeft.FormattingEnabled = true;
            this.listBoxSettingsLeft.ItemHeight = 16;
            this.listBoxSettingsLeft.Items.AddRange(new object[] {
            "Вобы",
            "Камера",
            "Прочее"});
            this.listBoxSettingsLeft.Location = new System.Drawing.Point(0, 0);
            this.listBoxSettingsLeft.Name = "listBoxSettingsLeft";
            this.listBoxSettingsLeft.Size = new System.Drawing.Size(115, 463);
            this.listBoxSettingsLeft.TabIndex = 0;
            this.listBoxSettingsLeft.SelectedIndexChanged += new System.EventHandler(this.listBoxSettingsLeft_SelectedIndexChanged);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.panelSettingsCamera);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(115, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(680, 463);
            this.panelRight.TabIndex = 1;
            // 
            // panelSettingsCamera
            // 
            this.panelSettingsCamera.Location = new System.Drawing.Point(6, 12);
            this.panelSettingsCamera.Name = "panelSettingsCamera";
            this.panelSettingsCamera.Size = new System.Drawing.Size(662, 439);
            this.panelSettingsCamera.TabIndex = 0;
            // 
            // SettingsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 463);
            this.Controls.Add(this.panelMainSettings);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SettingsMain";
            this.panelMainSettings.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainSettings;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.ListBox listBoxSettingsLeft;
        private System.Windows.Forms.Panel panelSettingsCamera;
    }
}