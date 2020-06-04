﻿namespace SpacerUnion.Windows
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
            this.checkBoxLastZenAuto = new System.Windows.Forms.CheckBox();
            this.checkBoxMiscExitAsk = new System.Windows.Forms.CheckBox();
            this.btnMiscSetApply = new System.Windows.Forms.Button();
            this.checkBoxMiscFullPath = new System.Windows.Forms.CheckBox();
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
            this.groupBox1.Controls.Add(this.checkBoxMiscFullPath);
            this.groupBox1.Controls.Add(this.checkBoxLastZenAuto);
            this.groupBox1.Controls.Add(this.checkBoxMiscExitAsk);
            this.groupBox1.Controls.Add(this.checkBoxSetDatePrefix);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 193);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxLastZenAuto
            // 
            this.checkBoxLastZenAuto.AutoSize = true;
            this.checkBoxLastZenAuto.Location = new System.Drawing.Point(21, 65);
            this.checkBoxLastZenAuto.Name = "checkBoxLastZenAuto";
            this.checkBoxLastZenAuto.Size = new System.Drawing.Size(244, 17);
            this.checkBoxLastZenAuto.TabIndex = 2;
            this.checkBoxLastZenAuto.Text = "Открывать последний ZEN автоматически";
            this.checkBoxLastZenAuto.UseVisualStyleBackColor = true;
            // 
            // checkBoxMiscExitAsk
            // 
            this.checkBoxMiscExitAsk.AutoSize = true;
            this.checkBoxMiscExitAsk.Location = new System.Drawing.Point(21, 42);
            this.checkBoxMiscExitAsk.Name = "checkBoxMiscExitAsk";
            this.checkBoxMiscExitAsk.Size = new System.Drawing.Size(221, 17);
            this.checkBoxMiscExitAsk.TabIndex = 1;
            this.checkBoxMiscExitAsk.Text = "Подтверждать выход если открыт зен";
            this.checkBoxMiscExitAsk.UseVisualStyleBackColor = true;
            // 
            // btnMiscSetApply
            // 
            this.btnMiscSetApply.Location = new System.Drawing.Point(104, 211);
            this.btnMiscSetApply.Name = "btnMiscSetApply";
            this.btnMiscSetApply.Size = new System.Drawing.Size(115, 23);
            this.btnMiscSetApply.TabIndex = 11;
            this.btnMiscSetApply.Text = "Применить";
            this.btnMiscSetApply.UseVisualStyleBackColor = true;
            this.btnMiscSetApply.Click += new System.EventHandler(this.btnMiscSetApply_Click);
            // 
            // checkBoxMiscFullPath
            // 
            this.checkBoxMiscFullPath.AutoSize = true;
            this.checkBoxMiscFullPath.Location = new System.Drawing.Point(21, 88);
            this.checkBoxMiscFullPath.Name = "checkBoxMiscFullPath";
            this.checkBoxMiscFullPath.Size = new System.Drawing.Size(205, 17);
            this.checkBoxMiscFullPath.TabIndex = 3;
            this.checkBoxMiscFullPath.Text = "Писать полный путь до ZEN в окне";
            this.checkBoxMiscFullPath.UseVisualStyleBackColor = true;
            this.checkBoxMiscFullPath.CheckedChanged += new System.EventHandler(this.checkBoxMiscFullPath_CheckedChanged);
            // 
            // MiscSettingsWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 246);
            this.Controls.Add(this.btnMiscSetApply);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiscSettingsWin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
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
        public System.Windows.Forms.CheckBox checkBoxMiscExitAsk;
        public System.Windows.Forms.CheckBox checkBoxLastZenAuto;
        public System.Windows.Forms.CheckBox checkBoxMiscFullPath;
    }
}