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
            this.checkBoxSetNearestVobCam = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoRemoveAllVisuals = new System.Windows.Forms.CheckBox();
            this.showLightRadiusVob = new System.Windows.Forms.CheckBox();
            this.autoRemoveLevelCompo = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoCompileUncompiled = new System.Windows.Forms.CheckBox();
            this.checkBoxMiscAutoCompile = new System.Windows.Forms.CheckBox();
            this.checkBoxMiscFullPath = new System.Windows.Forms.CheckBox();
            this.checkBoxLastZenAuto = new System.Windows.Forms.CheckBox();
            this.checkBoxMiscExitAsk = new System.Windows.Forms.CheckBox();
            this.btnMiscSetApply = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxSetDatePrefix
            // 
            this.checkBoxSetDatePrefix.AutoSize = true;
            this.checkBoxSetDatePrefix.Location = new System.Drawing.Point(13, 19);
            this.checkBoxSetDatePrefix.Name = "checkBoxSetDatePrefix";
            this.checkBoxSetDatePrefix.Size = new System.Drawing.Size(267, 17);
            this.checkBoxSetDatePrefix.TabIndex = 0;
            this.checkBoxSetDatePrefix.Text = "Добавлять префикс даты при сохранении зена";
            this.checkBoxSetDatePrefix.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSetNearestVobCam);
            this.groupBox1.Controls.Add(this.checkBoxAutoRemoveAllVisuals);
            this.groupBox1.Controls.Add(this.showLightRadiusVob);
            this.groupBox1.Controls.Add(this.autoRemoveLevelCompo);
            this.groupBox1.Controls.Add(this.checkBoxAutoCompileUncompiled);
            this.groupBox1.Controls.Add(this.checkBoxMiscAutoCompile);
            this.groupBox1.Controls.Add(this.checkBoxMiscFullPath);
            this.groupBox1.Controls.Add(this.checkBoxLastZenAuto);
            this.groupBox1.Controls.Add(this.checkBoxMiscExitAsk);
            this.groupBox1.Controls.Add(this.checkBoxSetDatePrefix);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 263);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxSetNearestVobCam
            // 
            this.checkBoxSetNearestVobCam.AutoSize = true;
            this.checkBoxSetNearestVobCam.Location = new System.Drawing.Point(13, 91);
            this.checkBoxSetNearestVobCam.Name = "checkBoxSetNearestVobCam";
            this.checkBoxSetNearestVobCam.Size = new System.Drawing.Size(606, 17);
            this.checkBoxSetNearestVobCam.TabIndex = 9;
            this.checkBoxSetNearestVobCam.Text = "Устанавливать камеру на воб с именем VOB_SPACER_CAMERA_START или zCVobStartpoint " +
    "после загрузки ZEN";
            this.checkBoxSetNearestVobCam.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoRemoveAllVisuals
            // 
            this.checkBoxAutoRemoveAllVisuals.AutoSize = true;
            this.checkBoxAutoRemoveAllVisuals.Location = new System.Drawing.Point(13, 173);
            this.checkBoxAutoRemoveAllVisuals.Name = "checkBoxAutoRemoveAllVisuals";
            this.checkBoxAutoRemoveAllVisuals.Size = new System.Drawing.Size(428, 17);
            this.checkBoxAutoRemoveAllVisuals.TabIndex = 8;
            this.checkBoxAutoRemoveAllVisuals.Text = "Автоматически очищать visual для всех zCVobLevelCompo при сохранении ZEN";
            this.checkBoxAutoRemoveAllVisuals.UseVisualStyleBackColor = true;
            // 
            // showLightRadiusVob
            // 
            this.showLightRadiusVob.AutoSize = true;
            this.showLightRadiusVob.Location = new System.Drawing.Point(13, 196);
            this.showLightRadiusVob.Name = "showLightRadiusVob";
            this.showLightRadiusVob.Size = new System.Drawing.Size(234, 17);
            this.showLightRadiusVob.TabIndex = 7;
            this.showLightRadiusVob.Text = "Показывать радиус действия zCVobLight";
            this.showLightRadiusVob.UseVisualStyleBackColor = true;
            // 
            // autoRemoveLevelCompo
            // 
            this.autoRemoveLevelCompo.AutoSize = true;
            this.autoRemoveLevelCompo.Location = new System.Drawing.Point(370, 19);
            this.autoRemoveLevelCompo.Name = "autoRemoveLevelCompo";
            this.autoRemoveLevelCompo.Size = new System.Drawing.Size(468, 17);
            this.autoRemoveLevelCompo.TabIndex = 6;
            this.autoRemoveLevelCompo.Text = "Автоматически удалять лишний zCVobLevelCompo после объединения MESH с вобами";
            this.autoRemoveLevelCompo.UseVisualStyleBackColor = true;
            this.autoRemoveLevelCompo.Visible = false;
            // 
            // checkBoxAutoCompileUncompiled
            // 
            this.checkBoxAutoCompileUncompiled.AutoSize = true;
            this.checkBoxAutoCompileUncompiled.Location = new System.Drawing.Point(13, 150);
            this.checkBoxAutoCompileUncompiled.Name = "checkBoxAutoCompileUncompiled";
            this.checkBoxAutoCompileUncompiled.Size = new System.Drawing.Size(389, 17);
            this.checkBoxAutoCompileUncompiled.TabIndex = 5;
            this.checkBoxAutoCompileUncompiled.Text = "Автокомпиляция мира и света при загрузки некомпилированного ZEN";
            this.checkBoxAutoCompileUncompiled.UseVisualStyleBackColor = true;
            // 
            // checkBoxMiscAutoCompile
            // 
            this.checkBoxMiscAutoCompile.AutoSize = true;
            this.checkBoxMiscAutoCompile.Location = new System.Drawing.Point(13, 127);
            this.checkBoxMiscAutoCompile.Name = "checkBoxMiscAutoCompile";
            this.checkBoxMiscAutoCompile.Size = new System.Drawing.Size(366, 17);
            this.checkBoxMiscAutoCompile.TabIndex = 4;
            this.checkBoxMiscAutoCompile.Text = "Автокомпиляция мира и света после объединения меша с вобами";
            this.checkBoxMiscAutoCompile.UseVisualStyleBackColor = true;
            // 
            // checkBoxMiscFullPath
            // 
            this.checkBoxMiscFullPath.AutoSize = true;
            this.checkBoxMiscFullPath.Location = new System.Drawing.Point(13, 68);
            this.checkBoxMiscFullPath.Name = "checkBoxMiscFullPath";
            this.checkBoxMiscFullPath.Size = new System.Drawing.Size(205, 17);
            this.checkBoxMiscFullPath.TabIndex = 3;
            this.checkBoxMiscFullPath.Text = "Писать полный путь до ZEN в окне";
            this.checkBoxMiscFullPath.UseVisualStyleBackColor = true;
            this.checkBoxMiscFullPath.CheckedChanged += new System.EventHandler(this.checkBoxMiscFullPath_CheckedChanged);
            // 
            // checkBoxLastZenAuto
            // 
            this.checkBoxLastZenAuto.AutoSize = true;
            this.checkBoxLastZenAuto.Enabled = false;
            this.checkBoxLastZenAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxLastZenAuto.Location = new System.Drawing.Point(380, 42);
            this.checkBoxLastZenAuto.Name = "checkBoxLastZenAuto";
            this.checkBoxLastZenAuto.Size = new System.Drawing.Size(244, 17);
            this.checkBoxLastZenAuto.TabIndex = 2;
            this.checkBoxLastZenAuto.Text = "Открывать последний ZEN автоматически";
            this.checkBoxLastZenAuto.UseVisualStyleBackColor = true;
            this.checkBoxLastZenAuto.Visible = false;
            // 
            // checkBoxMiscExitAsk
            // 
            this.checkBoxMiscExitAsk.AutoSize = true;
            this.checkBoxMiscExitAsk.Location = new System.Drawing.Point(13, 42);
            this.checkBoxMiscExitAsk.Name = "checkBoxMiscExitAsk";
            this.checkBoxMiscExitAsk.Size = new System.Drawing.Size(221, 17);
            this.checkBoxMiscExitAsk.TabIndex = 1;
            this.checkBoxMiscExitAsk.Text = "Подтверждать выход если открыт зен";
            this.checkBoxMiscExitAsk.UseVisualStyleBackColor = true;
            // 
            // btnMiscSetApply
            // 
            this.btnMiscSetApply.Location = new System.Drawing.Point(277, 281);
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
            this.ClientSize = new System.Drawing.Size(648, 316);
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
        public System.Windows.Forms.CheckBox checkBoxMiscAutoCompile;
        public System.Windows.Forms.CheckBox checkBoxAutoCompileUncompiled;
        public System.Windows.Forms.CheckBox autoRemoveLevelCompo;
        public System.Windows.Forms.CheckBox showLightRadiusVob;
        public System.Windows.Forms.CheckBox checkBoxAutoRemoveAllVisuals;
        public System.Windows.Forms.CheckBox checkBoxSetNearestVobCam;
    }
}