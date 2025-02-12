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
            this.checkBoxFast3ds = new System.Windows.Forms.CheckBox();
            this.checkBoxUpperCase = new System.Windows.Forms.CheckBox();
            this.checkBoxMiscRemoveAllLevelCompos = new System.Windows.Forms.CheckBox();
            this.checkBoxOnlyLatinInInput = new System.Windows.Forms.CheckBox();
            this.checkBoxShowPolysSort = new System.Windows.Forms.CheckBox();
            this.checkBoxSetNearestVobCam = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoRemoveAllVisuals = new System.Windows.Forms.CheckBox();
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
            this.checkBoxSetDatePrefix.Size = new System.Drawing.Size(221, 17);
            this.checkBoxSetDatePrefix.TabIndex = 0;
            this.checkBoxSetDatePrefix.Text = "Add DATE prefix to file when saving ZEN";
            this.checkBoxSetDatePrefix.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxFast3ds);
            this.groupBox1.Controls.Add(this.checkBoxUpperCase);
            this.groupBox1.Controls.Add(this.checkBoxMiscRemoveAllLevelCompos);
            this.groupBox1.Controls.Add(this.checkBoxOnlyLatinInInput);
            this.groupBox1.Controls.Add(this.checkBoxShowPolysSort);
            this.groupBox1.Controls.Add(this.checkBoxSetNearestVobCam);
            this.groupBox1.Controls.Add(this.checkBoxAutoRemoveAllVisuals);
            this.groupBox1.Controls.Add(this.checkBoxAutoCompileUncompiled);
            this.groupBox1.Controls.Add(this.checkBoxMiscAutoCompile);
            this.groupBox1.Controls.Add(this.checkBoxMiscFullPath);
            this.groupBox1.Controls.Add(this.checkBoxLastZenAuto);
            this.groupBox1.Controls.Add(this.checkBoxMiscExitAsk);
            this.groupBox1.Controls.Add(this.checkBoxSetDatePrefix);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 409);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxFast3ds
            // 
            this.checkBoxFast3ds.AutoSize = true;
            this.checkBoxFast3ds.Checked = true;
            this.checkBoxFast3ds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFast3ds.Location = new System.Drawing.Point(13, 325);
            this.checkBoxFast3ds.Name = "checkBoxFast3ds";
            this.checkBoxFast3ds.Size = new System.Drawing.Size(575, 17);
            this.checkBoxFast3ds.TabIndex = 14;
            this.checkBoxFast3ds.Text = "Skip creating OBBox for location 3ds (gives 30% speed bonus of 3DS file loading)." +
    " Work version only! Not for release";
            this.checkBoxFast3ds.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpperCase
            // 
            this.checkBoxUpperCase.AutoSize = true;
            this.checkBoxUpperCase.Checked = true;
            this.checkBoxUpperCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUpperCase.Location = new System.Drawing.Point(13, 302);
            this.checkBoxUpperCase.Name = "checkBoxUpperCase";
            this.checkBoxUpperCase.Size = new System.Drawing.Size(174, 17);
            this.checkBoxUpperCase.TabIndex = 13;
            this.checkBoxUpperCase.Text = "Make vobs fields to upper case";
            this.checkBoxUpperCase.UseVisualStyleBackColor = true;
            // 
            // checkBoxMiscRemoveAllLevelCompos
            // 
            this.checkBoxMiscRemoveAllLevelCompos.AutoSize = true;
            this.checkBoxMiscRemoveAllLevelCompos.Location = new System.Drawing.Point(13, 214);
            this.checkBoxMiscRemoveAllLevelCompos.Name = "checkBoxMiscRemoveAllLevelCompos";
            this.checkBoxMiscRemoveAllLevelCompos.Size = new System.Drawing.Size(261, 17);
            this.checkBoxMiscRemoveAllLevelCompos.TabIndex = 12;
            this.checkBoxMiscRemoveAllLevelCompos.Text = "Remove all zCVobLevelCompo while loading ZEN";
            this.checkBoxMiscRemoveAllLevelCompos.UseVisualStyleBackColor = true;
            // 
            // checkBoxOnlyLatinInInput
            // 
            this.checkBoxOnlyLatinInInput.AutoSize = true;
            this.checkBoxOnlyLatinInInput.Checked = true;
            this.checkBoxOnlyLatinInInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOnlyLatinInInput.Location = new System.Drawing.Point(13, 279);
            this.checkBoxOnlyLatinInInput.Name = "checkBoxOnlyLatinInInput";
            this.checkBoxOnlyLatinInInput.Size = new System.Drawing.Size(213, 17);
            this.checkBoxOnlyLatinInInput.TabIndex = 11;
            this.checkBoxOnlyLatinInInput.Text = "Allow only Latin symbols as input values";
            this.checkBoxOnlyLatinInInput.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowPolysSort
            // 
            this.checkBoxShowPolysSort.AutoSize = true;
            this.checkBoxShowPolysSort.Checked = true;
            this.checkBoxShowPolysSort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowPolysSort.Location = new System.Drawing.Point(13, 237);
            this.checkBoxShowPolysSort.Name = "checkBoxShowPolysSort";
            this.checkBoxShowPolysSort.Size = new System.Drawing.Size(389, 17);
            this.checkBoxShowPolysSort.TabIndex = 10;
            this.checkBoxShowPolysSort.Text = "Ask for sorting polygons while saving big locations (more than 200k polygons)";
            this.checkBoxShowPolysSort.UseVisualStyleBackColor = true;
            // 
            // checkBoxSetNearestVobCam
            // 
            this.checkBoxSetNearestVobCam.AutoSize = true;
            this.checkBoxSetNearestVobCam.Checked = true;
            this.checkBoxSetNearestVobCam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSetNearestVobCam.Location = new System.Drawing.Point(13, 91);
            this.checkBoxSetNearestVobCam.Name = "checkBoxSetNearestVobCam";
            this.checkBoxSetNearestVobCam.Size = new System.Drawing.Size(556, 17);
            this.checkBoxSetNearestVobCam.TabIndex = 9;
            this.checkBoxSetNearestVobCam.Text = "Set the camera near the vob with name VOB_SPACER_CAMERA_START or zCVobStartpoint " +
    "after loading ZEN";
            this.checkBoxSetNearestVobCam.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoRemoveAllVisuals
            // 
            this.checkBoxAutoRemoveAllVisuals.AutoSize = true;
            this.checkBoxAutoRemoveAllVisuals.Location = new System.Drawing.Point(13, 191);
            this.checkBoxAutoRemoveAllVisuals.Name = "checkBoxAutoRemoveAllVisuals";
            this.checkBoxAutoRemoveAllVisuals.Size = new System.Drawing.Size(334, 17);
            this.checkBoxAutoRemoveAllVisuals.TabIndex = 8;
            this.checkBoxAutoRemoveAllVisuals.Text = "Auto cleaning visual for all zCVobLevelCompo before saving ZEN";
            this.checkBoxAutoRemoveAllVisuals.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoCompileUncompiled
            // 
            this.checkBoxAutoCompileUncompiled.AutoSize = true;
            this.checkBoxAutoCompileUncompiled.Location = new System.Drawing.Point(13, 168);
            this.checkBoxAutoCompileUncompiled.Name = "checkBoxAutoCompileUncompiled";
            this.checkBoxAutoCompileUncompiled.Size = new System.Drawing.Size(298, 17);
            this.checkBoxAutoCompileUncompiled.TabIndex = 5;
            this.checkBoxAutoCompileUncompiled.Text = "Autocompile world and light after loading uncompiled ZEN";
            this.checkBoxAutoCompileUncompiled.UseVisualStyleBackColor = true;
            // 
            // checkBoxMiscAutoCompile
            // 
            this.checkBoxMiscAutoCompile.AutoSize = true;
            this.checkBoxMiscAutoCompile.Location = new System.Drawing.Point(13, 145);
            this.checkBoxMiscAutoCompile.Name = "checkBoxMiscAutoCompile";
            this.checkBoxMiscAutoCompile.Size = new System.Drawing.Size(295, 17);
            this.checkBoxMiscAutoCompile.TabIndex = 4;
            this.checkBoxMiscAutoCompile.Text = "Autocompile world and light after merging mesh with vobs";
            this.checkBoxMiscAutoCompile.UseVisualStyleBackColor = true;
            // 
            // checkBoxMiscFullPath
            // 
            this.checkBoxMiscFullPath.AutoSize = true;
            this.checkBoxMiscFullPath.Location = new System.Drawing.Point(13, 68);
            this.checkBoxMiscFullPath.Name = "checkBoxMiscFullPath";
            this.checkBoxMiscFullPath.Size = new System.Drawing.Size(221, 17);
            this.checkBoxMiscFullPath.TabIndex = 3;
            this.checkBoxMiscFullPath.Text = "Show full path to ZEN file in main window";
            this.checkBoxMiscFullPath.UseVisualStyleBackColor = true;
            this.checkBoxMiscFullPath.CheckedChanged += new System.EventHandler(this.checkBoxMiscFullPath_CheckedChanged);
            // 
            // checkBoxLastZenAuto
            // 
            this.checkBoxLastZenAuto.AutoSize = true;
            this.checkBoxLastZenAuto.Enabled = false;
            this.checkBoxLastZenAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxLastZenAuto.Location = new System.Drawing.Point(376, 10);
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
            this.checkBoxMiscExitAsk.Size = new System.Drawing.Size(162, 17);
            this.checkBoxMiscExitAsk.TabIndex = 1;
            this.checkBoxMiscExitAsk.Text = "Confirm exit if ZEN is opened";
            this.checkBoxMiscExitAsk.UseVisualStyleBackColor = true;
            this.checkBoxMiscExitAsk.CheckedChanged += new System.EventHandler(this.checkBoxMiscExitAsk_CheckedChanged);
            // 
            // btnMiscSetApply
            // 
            this.btnMiscSetApply.Location = new System.Drawing.Point(276, 427);
            this.btnMiscSetApply.Name = "btnMiscSetApply";
            this.btnMiscSetApply.Size = new System.Drawing.Size(115, 23);
            this.btnMiscSetApply.TabIndex = 11;
            this.btnMiscSetApply.Text = "Apply";
            this.btnMiscSetApply.UseVisualStyleBackColor = true;
            this.btnMiscSetApply.Click += new System.EventHandler(this.btnMiscSetApply_Click);
            // 
            // MiscSettingsWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 462);
            this.Controls.Add(this.btnMiscSetApply);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiscSettingsWin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Misc settings";
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
        public System.Windows.Forms.CheckBox checkBoxAutoRemoveAllVisuals;
        public System.Windows.Forms.CheckBox checkBoxSetNearestVobCam;
        public System.Windows.Forms.CheckBox checkBoxShowPolysSort;
        public System.Windows.Forms.CheckBox checkBoxOnlyLatinInInput;
        public System.Windows.Forms.CheckBox checkBoxMiscRemoveAllLevelCompos;
        public System.Windows.Forms.CheckBox checkBoxUpperCase;
        public System.Windows.Forms.CheckBox checkBoxFast3ds;
    }
}