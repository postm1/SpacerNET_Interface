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
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxInfo.Location = new System.Drawing.Point(4, 4);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.ReadOnly = true;
            this.richTextBoxInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxInfo.Size = new System.Drawing.Size(398, 297);
            this.richTextBoxInfo.TabIndex = 0;
            this.richTextBoxInfo.Text = "";
            this.richTextBoxInfo.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // buttonInfoClear
            // 
            this.buttonInfoClear.Location = new System.Drawing.Point(124, 315);
            this.buttonInfoClear.Name = "buttonInfoClear";
            this.buttonInfoClear.Size = new System.Drawing.Size(163, 23);
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
            this.panelMain.Location = new System.Drawing.Point(2, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(407, 306);
            this.panelMain.TabIndex = 2;
            // 
            // InfoWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 342);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.buttonInfoClear);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoWin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Информация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InfoWin_FormClosing);
            this.Move += new System.EventHandler(this.InfoWin_Move);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Button buttonInfoClear;
        private System.Windows.Forms.Panel panelMain;
    }
}