namespace SpacerUnion.Windows
{
    partial class MiscSettingsWin
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
            this.checkBoxSetDatePrefix = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMiscSetApply = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxSetDatePrefix
            // 
            this.checkBoxSetDatePrefix.AutoSize = true;
            this.checkBoxSetDatePrefix.Location = new System.Drawing.Point(21, 19);
            this.checkBoxSetDatePrefix.Name = "checkBoxSetDatePrefix";
            this.checkBoxSetDatePrefix.Size = new System.Drawing.Size(267, 17);
            this.checkBoxSetDatePrefix.TabIndex = 0;
            this.checkBoxSetDatePrefix.Text = "Добавлять префикс даты при сохранении зена";
            this.checkBoxSetDatePrefix.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSetDatePrefix);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnMiscSetApply
            // 
            this.btnMiscSetApply.Location = new System.Drawing.Point(104, 131);
            this.btnMiscSetApply.Name = "btnMiscSetApply";
            this.btnMiscSetApply.Size = new System.Drawing.Size(115, 23);
            this.btnMiscSetApply.TabIndex = 11;
            this.btnMiscSetApply.Text = "Применить";
            this.btnMiscSetApply.UseVisualStyleBackColor = true;
            this.btnMiscSetApply.Click += new System.EventHandler(this.btnMiscSetApply_Click);
            // 
            // MiscSettingsWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 166);
            this.Controls.Add(this.btnMiscSetApply);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiscSettingsWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прочие настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MiscSettingsWin_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MiscSettingsWin_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox checkBoxSetDatePrefix;
        private System.Windows.Forms.Button btnMiscSetApply;
    }
}