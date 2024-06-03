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
            this.tabControlInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelSeparate = new System.Windows.Forms.Panel();
            this.richTextBoxSpy = new System.Windows.Forms.RichTextBox();
            this.panelInfoBottom = new System.Windows.Forms.Panel();
            this.labelLevelzSPY = new System.Windows.Forms.Label();
            this.checkBoxInfoUseZSpy = new System.Windows.Forms.CheckBox();
            this.trackBarSpy = new System.Windows.Forms.TrackBar();
            this.panelMain.SuspendLayout();
            this.tabControlInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelInfoBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpy)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxInfo.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxInfo.MaxLength = 0;
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.ReadOnly = true;
            this.richTextBoxInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxInfo.Size = new System.Drawing.Size(330, 272);
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
            this.buttonInfoClear.Text = "Clear";
            this.buttonInfoClear.UseVisualStyleBackColor = true;
            this.buttonInfoClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Window;
            this.panelMain.Controls.Add(this.tabControlInfo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(346, 306);
            this.panelMain.TabIndex = 2;
            // 
            // tabControlInfo
            // 
            this.tabControlInfo.Controls.Add(this.tabPage1);
            this.tabControlInfo.Controls.Add(this.tabPage2);
            this.tabControlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlInfo.Location = new System.Drawing.Point(0, 0);
            this.tabControlInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlInfo.Name = "tabControlInfo";
            this.tabControlInfo.SelectedIndex = 0;
            this.tabControlInfo.Size = new System.Drawing.Size(346, 306);
            this.tabControlInfo.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.richTextBoxInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(338, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Common";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.panelSeparate);
            this.tabPage2.Controls.Add(this.richTextBoxSpy);
            this.tabPage2.Controls.Add(this.panelInfoBottom);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(341, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "zSpy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelSeparate
            // 
            this.panelSeparate.BackColor = System.Drawing.Color.LightGray;
            this.panelSeparate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSeparate.Location = new System.Drawing.Point(3, 265);
            this.panelSeparate.Name = "panelSeparate";
            this.panelSeparate.Size = new System.Drawing.Size(333, 1);
            this.panelSeparate.TabIndex = 8;
            // 
            // richTextBoxSpy
            // 
            this.richTextBoxSpy.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxSpy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxSpy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxSpy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxSpy.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxSpy.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBoxSpy.MaxLength = 0;
            this.richTextBoxSpy.Name = "richTextBoxSpy";
            this.richTextBoxSpy.ReadOnly = true;
            this.richTextBoxSpy.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxSpy.Size = new System.Drawing.Size(333, 263);
            this.richTextBoxSpy.TabIndex = 7;
            this.richTextBoxSpy.Text = "";
            this.richTextBoxSpy.TextChanged += new System.EventHandler(this.richTextBoxSpy_TextChanged);
            // 
            // panelInfoBottom
            // 
            this.panelInfoBottom.BackColor = System.Drawing.Color.Transparent;
            this.panelInfoBottom.Controls.Add(this.buttonInfoClear);
            this.panelInfoBottom.Controls.Add(this.labelLevelzSPY);
            this.panelInfoBottom.Controls.Add(this.checkBoxInfoUseZSpy);
            this.panelInfoBottom.Controls.Add(this.trackBarSpy);
            this.panelInfoBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfoBottom.Location = new System.Drawing.Point(3, 266);
            this.panelInfoBottom.Margin = new System.Windows.Forms.Padding(0);
            this.panelInfoBottom.Name = "panelInfoBottom";
            this.panelInfoBottom.Size = new System.Drawing.Size(333, 64);
            this.panelInfoBottom.TabIndex = 6;
            // 
            // labelLevelzSPY
            // 
            this.labelLevelzSPY.AutoSize = true;
            this.labelLevelzSPY.Location = new System.Drawing.Point(289, 18);
            this.labelLevelzSPY.Name = "labelLevelzSPY";
            this.labelLevelzSPY.Size = new System.Drawing.Size(19, 13);
            this.labelLevelzSPY.TabIndex = 5;
            this.labelLevelzSPY.Text = "10";
            this.labelLevelzSPY.Click += new System.EventHandler(this.labelLevelzSPY_Click);
            // 
            // checkBoxInfoUseZSpy
            // 
            this.checkBoxInfoUseZSpy.AutoSize = true;
            this.checkBoxInfoUseZSpy.Location = new System.Drawing.Point(146, 44);
            this.checkBoxInfoUseZSpy.Name = "checkBoxInfoUseZSpy";
            this.checkBoxInfoUseZSpy.Size = new System.Drawing.Size(132, 17);
            this.checkBoxInfoUseZSpy.TabIndex = 3;
            this.checkBoxInfoUseZSpy.Text = "zSpy debug messages";
            this.checkBoxInfoUseZSpy.UseVisualStyleBackColor = true;
            this.checkBoxInfoUseZSpy.CheckedChanged += new System.EventHandler(this.checkBoxInfoUseZSpy_CheckedChanged);
            // 
            // trackBarSpy
            // 
            this.trackBarSpy.BackColor = System.Drawing.SystemColors.Window;
            this.trackBarSpy.Location = new System.Drawing.Point(144, 3);
            this.trackBarSpy.Minimum = 1;
            this.trackBarSpy.Name = "trackBarSpy";
            this.trackBarSpy.Size = new System.Drawing.Size(139, 45);
            this.trackBarSpy.TabIndex = 4;
            this.trackBarSpy.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarSpy.Value = 1;
            this.trackBarSpy.ValueChanged += new System.EventHandler(this.trackBarSpy_ValueChanged);
            // 
            // InfoWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 306);
            this.Controls.Add(this.panelMain);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 100);
            this.Name = "InfoWin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InfoWin_FormClosing);
            this.Move += new System.EventHandler(this.InfoWin_Move);
            this.panelMain.ResumeLayout(false);
            this.tabControlInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelInfoBottom.ResumeLayout(false);
            this.panelInfoBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.CheckBox checkBoxInfoUseZSpy;
        private System.Windows.Forms.TrackBar trackBarSpy;
        private System.Windows.Forms.Label labelLevelzSPY;
        private System.Windows.Forms.Panel panelInfoBottom;
        private System.Windows.Forms.TabControl tabControlInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxSpy;
        private System.Windows.Forms.Panel panelSeparate;
        private System.Windows.Forms.Button buttonInfoClear;
    }
}