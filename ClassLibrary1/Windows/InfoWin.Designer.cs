namespace SpacerUnion
{
    partial class InfoWin
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
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.buttonInfoClear = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.checkBoxInfoUseZSpy = new System.Windows.Forms.CheckBox();
            this.trackBarSpy = new System.Windows.Forms.TrackBar();
            this.labelLevelzSPY = new System.Windows.Forms.Label();
            this.panelInfoBottom = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpy)).BeginInit();
            this.panelInfoBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxInfo.Location = new System.Drawing.Point(4, 4);
            this.richTextBoxInfo.MaxLength = 0;
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.ReadOnly = true;
            this.richTextBoxInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxInfo.Size = new System.Drawing.Size(335, 313);
            this.richTextBoxInfo.TabIndex = 0;
            this.richTextBoxInfo.Text = "";
            this.richTextBoxInfo.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // buttonInfoClear
            // 
            this.buttonInfoClear.Location = new System.Drawing.Point(12, 13);
            this.buttonInfoClear.Name = "buttonInfoClear";
            this.buttonInfoClear.Size = new System.Drawing.Size(130, 23);
            this.buttonInfoClear.TabIndex = 1;
            this.buttonInfoClear.Text = "Очистить";
            this.buttonInfoClear.UseVisualStyleBackColor = true;
            this.buttonInfoClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Window;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.richTextBoxInfo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(2, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(4);
            this.panelMain.Size = new System.Drawing.Size(345, 323);
            this.panelMain.TabIndex = 2;
            // 
            // checkBoxInfoUseZSpy
            // 
            this.checkBoxInfoUseZSpy.AutoSize = true;
            this.checkBoxInfoUseZSpy.Location = new System.Drawing.Point(167, 44);
            this.checkBoxInfoUseZSpy.Name = "checkBoxInfoUseZSpy";
            this.checkBoxInfoUseZSpy.Size = new System.Drawing.Size(174, 17);
            this.checkBoxInfoUseZSpy.TabIndex = 3;
            this.checkBoxInfoUseZSpy.Text = "Отладочные сообщения zSpy";
            this.checkBoxInfoUseZSpy.UseVisualStyleBackColor = true;
            this.checkBoxInfoUseZSpy.CheckedChanged += new System.EventHandler(this.checkBoxInfoUseZSpy_CheckedChanged);
            // 
            // trackBarSpy
            // 
            this.trackBarSpy.Location = new System.Drawing.Point(160, 3);
            this.trackBarSpy.Minimum = 1;
            this.trackBarSpy.Name = "trackBarSpy";
            this.trackBarSpy.Size = new System.Drawing.Size(139, 45);
            this.trackBarSpy.TabIndex = 4;
            this.trackBarSpy.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarSpy.Value = 1;
            this.trackBarSpy.ValueChanged += new System.EventHandler(this.trackBarSpy_ValueChanged);
            // 
            // labelLevelzSPY
            // 
            this.labelLevelzSPY.AutoSize = true;
            this.labelLevelzSPY.Location = new System.Drawing.Point(301, 18);
            this.labelLevelzSPY.Name = "labelLevelzSPY";
            this.labelLevelzSPY.Size = new System.Drawing.Size(19, 13);
            this.labelLevelzSPY.TabIndex = 5;
            this.labelLevelzSPY.Text = "10";
            this.labelLevelzSPY.Click += new System.EventHandler(this.labelLevelzSPY_Click);
            // 
            // panelInfoBottom
            // 
            this.panelInfoBottom.Controls.Add(this.buttonInfoClear);
            this.panelInfoBottom.Controls.Add(this.labelLevelzSPY);
            this.panelInfoBottom.Controls.Add(this.checkBoxInfoUseZSpy);
            this.panelInfoBottom.Controls.Add(this.trackBarSpy);
            this.panelInfoBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfoBottom.Location = new System.Drawing.Point(2, 325);
            this.panelInfoBottom.Name = "panelInfoBottom";
            this.panelInfoBottom.Size = new System.Drawing.Size(345, 64);
            this.panelInfoBottom.TabIndex = 6;
            // 
            // InfoWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 391);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelInfoBottom);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(365, 430);
            this.Name = "InfoWin";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Информация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InfoWin_FormClosing);
            this.Move += new System.EventHandler(this.InfoWin_Move);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpy)).EndInit();
            this.panelInfoBottom.ResumeLayout(false);
            this.panelInfoBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Button buttonInfoClear;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.CheckBox checkBoxInfoUseZSpy;
        private System.Windows.Forms.TrackBar trackBarSpy;
        private System.Windows.Forms.Label labelLevelzSPY;
        private System.Windows.Forms.Panel panelInfoBottom;
    }
}