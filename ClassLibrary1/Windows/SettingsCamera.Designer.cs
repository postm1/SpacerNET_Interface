namespace SpacerUnion
{
    partial class SettingsCamera
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
            this.trackBarTransSpeed = new System.Windows.Forms.TrackBar();
            this.labelTrans = new System.Windows.Forms.Label();
            this.labelRot = new System.Windows.Forms.Label();
            this.trackBarRotSpeed = new System.Windows.Forms.TrackBar();
            this.labelWorld = new System.Windows.Forms.Label();
            this.trackBarVobs = new System.Windows.Forms.TrackBar();
            this.labelVobs = new System.Windows.Forms.Label();
            this.trackBarWorld = new System.Windows.Forms.TrackBar();
            this.groupBoxCam = new System.Windows.Forms.GroupBox();
            this.textBoxCamSlerp = new System.Windows.Forms.TextBox();
            this.labelCamSetSlerp = new System.Windows.Forms.Label();
            this.textBoxCamRot = new System.Windows.Forms.TextBox();
            this.trackBarCamSlerp = new System.Windows.Forms.TrackBar();
            this.textBoxCamTrans = new System.Windows.Forms.TextBox();
            this.groupBoxRange = new System.Windows.Forms.GroupBox();
            this.textBoxVobsRange = new System.Windows.Forms.TextBox();
            this.textBoxWorldRange = new System.Windows.Forms.TextBox();
            this.btnSetCamApply = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.checkBoxCamShowPortalsInfo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBarSpeedPreview = new System.Windows.Forms.TrackBar();
            this.labelSpeedPreview = new System.Windows.Forms.Label();
            this.labelLimitFPS = new System.Windows.Forms.Label();
            this.textBoxLimitFPS = new System.Windows.Forms.TextBox();
            this.checkBoxCameraHideWins = new System.Windows.Forms.CheckBox();
            this.checkBoxDistVob = new System.Windows.Forms.CheckBox();
            this.checkBoxWaypoints = new System.Windows.Forms.CheckBox();
            this.checkBoxVobs = new System.Windows.Forms.CheckBox();
            this.checkBoxCamCoord = new System.Windows.Forms.CheckBox();
            this.checkBoxTris = new System.Windows.Forms.CheckBox();
            this.checkBoxFPS = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWorld)).BeginInit();
            this.groupBoxCam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCamSlerp)).BeginInit();
            this.groupBoxRange.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeedPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarTransSpeed
            // 
            this.trackBarTransSpeed.Location = new System.Drawing.Point(1, 35);
            this.trackBarTransSpeed.Maximum = 100;
            this.trackBarTransSpeed.Minimum = 1;
            this.trackBarTransSpeed.Name = "trackBarTransSpeed";
            this.trackBarTransSpeed.Size = new System.Drawing.Size(237, 45);
            this.trackBarTransSpeed.TabIndex = 0;
            this.trackBarTransSpeed.Value = 1;
            this.trackBarTransSpeed.ValueChanged += new System.EventHandler(this.trackBarTransSpeed_ValueChanged);
            // 
            // labelTrans
            // 
            this.labelTrans.AutoSize = true;
            this.labelTrans.Location = new System.Drawing.Point(6, 19);
            this.labelTrans.Name = "labelTrans";
            this.labelTrans.Size = new System.Drawing.Size(93, 13);
            this.labelTrans.TabIndex = 1;
            this.labelTrans.Text = "Скорость полета";
            // 
            // labelRot
            // 
            this.labelRot.AutoSize = true;
            this.labelRot.Location = new System.Drawing.Point(6, 69);
            this.labelRot.Name = "labelRot";
            this.labelRot.Size = new System.Drawing.Size(105, 13);
            this.labelRot.TabIndex = 2;
            this.labelRot.Text = "Скорость поворота";
            // 
            // trackBarRotSpeed
            // 
            this.trackBarRotSpeed.Location = new System.Drawing.Point(2, 88);
            this.trackBarRotSpeed.Maximum = 100;
            this.trackBarRotSpeed.Minimum = 1;
            this.trackBarRotSpeed.Name = "trackBarRotSpeed";
            this.trackBarRotSpeed.Size = new System.Drawing.Size(236, 45);
            this.trackBarRotSpeed.TabIndex = 3;
            this.trackBarRotSpeed.Value = 1;
            this.trackBarRotSpeed.ValueChanged += new System.EventHandler(this.trackBarRotSpeed_ValueChanged);
            // 
            // labelWorld
            // 
            this.labelWorld.AutoSize = true;
            this.labelWorld.Location = new System.Drawing.Point(9, 19);
            this.labelWorld.Name = "labelWorld";
            this.labelWorld.Size = new System.Drawing.Size(28, 13);
            this.labelWorld.TabIndex = 4;
            this.labelWorld.Text = "Мир";
            // 
            // trackBarVobs
            // 
            this.trackBarVobs.Location = new System.Drawing.Point(9, 92);
            this.trackBarVobs.Maximum = 20000;
            this.trackBarVobs.Minimum = 100;
            this.trackBarVobs.Name = "trackBarVobs";
            this.trackBarVobs.Size = new System.Drawing.Size(229, 45);
            this.trackBarVobs.TabIndex = 5;
            this.trackBarVobs.TickFrequency = 10;
            this.trackBarVobs.Value = 1000;
            this.trackBarVobs.ValueChanged += new System.EventHandler(this.trackBarVobs_ValueChanged);
            // 
            // labelVobs
            // 
            this.labelVobs.AutoSize = true;
            this.labelVobs.Location = new System.Drawing.Point(9, 76);
            this.labelVobs.Name = "labelVobs";
            this.labelVobs.Size = new System.Drawing.Size(34, 13);
            this.labelVobs.TabIndex = 6;
            this.labelVobs.Text = "Вобы";
            // 
            // trackBarWorld
            // 
            this.trackBarWorld.Location = new System.Drawing.Point(9, 38);
            this.trackBarWorld.Maximum = 20000;
            this.trackBarWorld.Minimum = 100;
            this.trackBarWorld.Name = "trackBarWorld";
            this.trackBarWorld.Size = new System.Drawing.Size(229, 45);
            this.trackBarWorld.TabIndex = 7;
            this.trackBarWorld.TickFrequency = 10;
            this.trackBarWorld.Value = 1000;
            this.trackBarWorld.ValueChanged += new System.EventHandler(this.trackBarWorld_ValueChanged);
            // 
            // groupBoxCam
            // 
            this.groupBoxCam.Controls.Add(this.textBoxCamSlerp);
            this.groupBoxCam.Controls.Add(this.labelCamSetSlerp);
            this.groupBoxCam.Controls.Add(this.textBoxCamRot);
            this.groupBoxCam.Controls.Add(this.trackBarCamSlerp);
            this.groupBoxCam.Controls.Add(this.textBoxCamTrans);
            this.groupBoxCam.Controls.Add(this.labelTrans);
            this.groupBoxCam.Controls.Add(this.labelRot);
            this.groupBoxCam.Controls.Add(this.trackBarTransSpeed);
            this.groupBoxCam.Controls.Add(this.trackBarRotSpeed);
            this.groupBoxCam.Location = new System.Drawing.Point(15, 12);
            this.groupBoxCam.Name = "groupBoxCam";
            this.groupBoxCam.Size = new System.Drawing.Size(298, 213);
            this.groupBoxCam.TabIndex = 8;
            this.groupBoxCam.TabStop = false;
            this.groupBoxCam.Text = "Камера";
            // 
            // textBoxCamSlerp
            // 
            this.textBoxCamSlerp.Location = new System.Drawing.Point(244, 143);
            this.textBoxCamSlerp.Name = "textBoxCamSlerp";
            this.textBoxCamSlerp.Size = new System.Drawing.Size(48, 20);
            this.textBoxCamSlerp.TabIndex = 10;
            this.textBoxCamSlerp.TextChanged += new System.EventHandler(this.textBoxCamSlerp_TextChanged);
            // 
            // labelCamSetSlerp
            // 
            this.labelCamSetSlerp.AutoSize = true;
            this.labelCamSetSlerp.Location = new System.Drawing.Point(6, 124);
            this.labelCamSetSlerp.Name = "labelCamSetSlerp";
            this.labelCamSetSlerp.Size = new System.Drawing.Size(155, 13);
            this.labelCamSetSlerp.TabIndex = 9;
            this.labelCamSetSlerp.Text = "Плавность поворота камеры";
            // 
            // textBoxCamRot
            // 
            this.textBoxCamRot.Location = new System.Drawing.Point(244, 88);
            this.textBoxCamRot.Name = "textBoxCamRot";
            this.textBoxCamRot.Size = new System.Drawing.Size(48, 20);
            this.textBoxCamRot.TabIndex = 5;
            this.textBoxCamRot.TextChanged += new System.EventHandler(this.textBoxCamRot_TextChanged);
            this.textBoxCamRot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCamTrans_KeyPress);
            // 
            // trackBarCamSlerp
            // 
            this.trackBarCamSlerp.Location = new System.Drawing.Point(2, 143);
            this.trackBarCamSlerp.Maximum = 90;
            this.trackBarCamSlerp.Name = "trackBarCamSlerp";
            this.trackBarCamSlerp.Size = new System.Drawing.Size(229, 45);
            this.trackBarCamSlerp.TabIndex = 9;
            this.trackBarCamSlerp.TickFrequency = 10;
            this.trackBarCamSlerp.ValueChanged += new System.EventHandler(this.trackBarCamSlerp_ValueChanged);
            // 
            // textBoxCamTrans
            // 
            this.textBoxCamTrans.Location = new System.Drawing.Point(244, 35);
            this.textBoxCamTrans.Name = "textBoxCamTrans";
            this.textBoxCamTrans.Size = new System.Drawing.Size(48, 20);
            this.textBoxCamTrans.TabIndex = 4;
            this.textBoxCamTrans.TextChanged += new System.EventHandler(this.textBoxCamTrans_TextChanged);
            this.textBoxCamTrans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCamTrans_KeyPress);
            // 
            // groupBoxRange
            // 
            this.groupBoxRange.Controls.Add(this.textBoxVobsRange);
            this.groupBoxRange.Controls.Add(this.textBoxWorldRange);
            this.groupBoxRange.Controls.Add(this.labelVobs);
            this.groupBoxRange.Controls.Add(this.trackBarWorld);
            this.groupBoxRange.Controls.Add(this.labelWorld);
            this.groupBoxRange.Controls.Add(this.trackBarVobs);
            this.groupBoxRange.Location = new System.Drawing.Point(15, 231);
            this.groupBoxRange.Name = "groupBoxRange";
            this.groupBoxRange.Size = new System.Drawing.Size(298, 144);
            this.groupBoxRange.TabIndex = 9;
            this.groupBoxRange.TabStop = false;
            this.groupBoxRange.Text = "Прорисовка";
            // 
            // textBoxVobsRange
            // 
            this.textBoxVobsRange.Location = new System.Drawing.Point(244, 92);
            this.textBoxVobsRange.Name = "textBoxVobsRange";
            this.textBoxVobsRange.Size = new System.Drawing.Size(48, 20);
            this.textBoxVobsRange.TabIndex = 8;
            this.textBoxVobsRange.TextChanged += new System.EventHandler(this.textBoxVobsRange_TextChanged);
            this.textBoxVobsRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCamTrans_KeyPress);
            // 
            // textBoxWorldRange
            // 
            this.textBoxWorldRange.Location = new System.Drawing.Point(244, 38);
            this.textBoxWorldRange.Name = "textBoxWorldRange";
            this.textBoxWorldRange.Size = new System.Drawing.Size(48, 20);
            this.textBoxWorldRange.TabIndex = 6;
            this.textBoxWorldRange.TextChanged += new System.EventHandler(this.textBoxWorldRange_TextChanged);
            this.textBoxWorldRange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCamTrans_KeyPress);
            // 
            // btnSetCamApply
            // 
            this.btnSetCamApply.Location = new System.Drawing.Point(259, 392);
            this.btnSetCamApply.Name = "btnSetCamApply";
            this.btnSetCamApply.Size = new System.Drawing.Size(115, 23);
            this.btnSetCamApply.TabIndex = 10;
            this.btnSetCamApply.Text = "Применить";
            this.btnSetCamApply.UseVisualStyleBackColor = true;
            this.btnSetCamApply.Click += new System.EventHandler(this.Применить_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.checkBoxCamShowPortalsInfo);
            this.groupBoxInfo.Controls.Add(this.groupBox1);
            this.groupBoxInfo.Controls.Add(this.labelLimitFPS);
            this.groupBoxInfo.Controls.Add(this.textBoxLimitFPS);
            this.groupBoxInfo.Controls.Add(this.checkBoxCameraHideWins);
            this.groupBoxInfo.Controls.Add(this.checkBoxDistVob);
            this.groupBoxInfo.Controls.Add(this.checkBoxWaypoints);
            this.groupBoxInfo.Controls.Add(this.checkBoxVobs);
            this.groupBoxInfo.Controls.Add(this.checkBoxCamCoord);
            this.groupBoxInfo.Controls.Add(this.checkBoxTris);
            this.groupBoxInfo.Controls.Add(this.checkBoxFPS);
            this.groupBoxInfo.Location = new System.Drawing.Point(319, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(301, 363);
            this.groupBoxInfo.TabIndex = 10;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Информация";
            // 
            // checkBoxCamShowPortalsInfo
            // 
            this.checkBoxCamShowPortalsInfo.AutoSize = true;
            this.checkBoxCamShowPortalsInfo.Location = new System.Drawing.Point(9, 205);
            this.checkBoxCamShowPortalsInfo.Name = "checkBoxCamShowPortalsInfo";
            this.checkBoxCamShowPortalsInfo.Size = new System.Drawing.Size(216, 17);
            this.checkBoxCamShowPortalsInfo.TabIndex = 11;
            this.checkBoxCamShowPortalsInfo.Text = "Показывать информацию о порталах";
            this.checkBoxCamShowPortalsInfo.UseVisualStyleBackColor = true;
            this.checkBoxCamShowPortalsInfo.CheckedChanged += new System.EventHandler(this.checkBoxCamShowPortalsInfo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBarSpeedPreview);
            this.groupBox1.Controls.Add(this.labelSpeedPreview);
            this.groupBox1.Location = new System.Drawing.Point(10, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 138);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // trackBarSpeedPreview
            // 
            this.trackBarSpeedPreview.Location = new System.Drawing.Point(6, 38);
            this.trackBarSpeedPreview.Maximum = 100;
            this.trackBarSpeedPreview.Name = "trackBarSpeedPreview";
            this.trackBarSpeedPreview.Size = new System.Drawing.Size(261, 45);
            this.trackBarSpeedPreview.TabIndex = 7;
            this.trackBarSpeedPreview.TickFrequency = 10;
            this.trackBarSpeedPreview.Value = 10;
            this.trackBarSpeedPreview.ValueChanged += new System.EventHandler(this.trackBarSpeedPreview_ValueChanged);
            // 
            // labelSpeedPreview
            // 
            this.labelSpeedPreview.AutoSize = true;
            this.labelSpeedPreview.Location = new System.Drawing.Point(9, 19);
            this.labelSpeedPreview.Name = "labelSpeedPreview";
            this.labelSpeedPreview.Size = new System.Drawing.Size(191, 13);
            this.labelSpeedPreview.TabIndex = 4;
            this.labelSpeedPreview.Text = "Скорость вращение превью-модели";
            // 
            // labelLimitFPS
            // 
            this.labelLimitFPS.AutoSize = true;
            this.labelLimitFPS.Location = new System.Drawing.Point(7, 183);
            this.labelLimitFPS.Name = "labelLimitFPS";
            this.labelLimitFPS.Size = new System.Drawing.Size(89, 13);
            this.labelLimitFPS.TabIndex = 8;
            this.labelLimitFPS.Text = "Ограничить FPS";
            // 
            // textBoxLimitFPS
            // 
            this.textBoxLimitFPS.Location = new System.Drawing.Point(102, 180);
            this.textBoxLimitFPS.Name = "textBoxLimitFPS";
            this.textBoxLimitFPS.Size = new System.Drawing.Size(29, 20);
            this.textBoxLimitFPS.TabIndex = 7;
            this.textBoxLimitFPS.Text = "0";
            this.textBoxLimitFPS.TextChanged += new System.EventHandler(this.textBoxLimitFPS_TextChanged);
            // 
            // checkBoxCameraHideWins
            // 
            this.checkBoxCameraHideWins.AutoSize = true;
            this.checkBoxCameraHideWins.Location = new System.Drawing.Point(9, 157);
            this.checkBoxCameraHideWins.Name = "checkBoxCameraHideWins";
            this.checkBoxCameraHideWins.Size = new System.Drawing.Size(205, 17);
            this.checkBoxCameraHideWins.TabIndex = 6;
            this.checkBoxCameraHideWins.Text = "Скрывать окна при полете камеры";
            this.checkBoxCameraHideWins.UseVisualStyleBackColor = true;
            this.checkBoxCameraHideWins.CheckedChanged += new System.EventHandler(this.checkBoxCameraHideWins_CheckedChanged);
            // 
            // checkBoxDistVob
            // 
            this.checkBoxDistVob.AutoSize = true;
            this.checkBoxDistVob.Location = new System.Drawing.Point(9, 134);
            this.checkBoxDistVob.Name = "checkBoxDistVob";
            this.checkBoxDistVob.Size = new System.Drawing.Size(257, 17);
            this.checkBoxDistVob.TabIndex = 5;
            this.checkBoxDistVob.Text = "Показывать расстояние до выбранного воба";
            this.checkBoxDistVob.UseVisualStyleBackColor = true;
            this.checkBoxDistVob.CheckedChanged += new System.EventHandler(this.checkBoxDistVob_CheckedChanged);
            // 
            // checkBoxWaypoints
            // 
            this.checkBoxWaypoints.AutoSize = true;
            this.checkBoxWaypoints.Location = new System.Drawing.Point(9, 111);
            this.checkBoxWaypoints.Name = "checkBoxWaypoints";
            this.checkBoxWaypoints.Size = new System.Drawing.Size(187, 17);
            this.checkBoxWaypoints.TabIndex = 4;
            this.checkBoxWaypoints.Text = "Показывать кол-во вейпоинтов";
            this.checkBoxWaypoints.UseVisualStyleBackColor = true;
            this.checkBoxWaypoints.CheckedChanged += new System.EventHandler(this.checkBoxWaypoints_CheckedChanged);
            // 
            // checkBoxVobs
            // 
            this.checkBoxVobs.AutoSize = true;
            this.checkBoxVobs.Location = new System.Drawing.Point(9, 88);
            this.checkBoxVobs.Name = "checkBoxVobs";
            this.checkBoxVobs.Size = new System.Drawing.Size(158, 17);
            this.checkBoxVobs.TabIndex = 3;
            this.checkBoxVobs.Text = "Показывать кол-во вобов";
            this.checkBoxVobs.UseVisualStyleBackColor = true;
            this.checkBoxVobs.CheckedChanged += new System.EventHandler(this.checkBoxVobs_CheckedChanged);
            // 
            // checkBoxCamCoord
            // 
            this.checkBoxCamCoord.AutoSize = true;
            this.checkBoxCamCoord.Location = new System.Drawing.Point(9, 65);
            this.checkBoxCamCoord.Name = "checkBoxCamCoord";
            this.checkBoxCamCoord.Size = new System.Drawing.Size(232, 17);
            this.checkBoxCamCoord.TabIndex = 2;
            this.checkBoxCamCoord.Text = "Показывать координаты камеры и воба";
            this.checkBoxCamCoord.UseVisualStyleBackColor = true;
            this.checkBoxCamCoord.CheckedChanged += new System.EventHandler(this.checkBoxCamCoord_CheckedChanged);
            // 
            // checkBoxTris
            // 
            this.checkBoxTris.AutoSize = true;
            this.checkBoxTris.Location = new System.Drawing.Point(9, 42);
            this.checkBoxTris.Name = "checkBoxTris";
            this.checkBoxTris.Size = new System.Drawing.Size(256, 17);
            this.checkBoxTris.TabIndex = 1;
            this.checkBoxTris.Text = "Показывать кол-во рисуемых треугольников";
            this.checkBoxTris.UseVisualStyleBackColor = true;
            this.checkBoxTris.CheckedChanged += new System.EventHandler(this.checkBoxTris_CheckedChanged);
            // 
            // checkBoxFPS
            // 
            this.checkBoxFPS.AutoSize = true;
            this.checkBoxFPS.Location = new System.Drawing.Point(9, 19);
            this.checkBoxFPS.Name = "checkBoxFPS";
            this.checkBoxFPS.Size = new System.Drawing.Size(112, 17);
            this.checkBoxFPS.TabIndex = 0;
            this.checkBoxFPS.Text = "Показывать FPS";
            this.checkBoxFPS.UseVisualStyleBackColor = true;
            this.checkBoxFPS.CheckedChanged += new System.EventHandler(this.checkBoxFPS_CheckedChanged);
            // 
            // SettingsCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 427);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.btnSetCamApply);
            this.Controls.Add(this.groupBoxRange);
            this.Controls.Add(this.groupBoxCam);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsCamera";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки камеры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsCamera_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsCamera_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingsCamera_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWorld)).EndInit();
            this.groupBoxCam.ResumeLayout(false);
            this.groupBoxCam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCamSlerp)).EndInit();
            this.groupBoxRange.ResumeLayout(false);
            this.groupBoxRange.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeedPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTrans;
        private System.Windows.Forms.Label labelRot;
        private System.Windows.Forms.Label labelWorld;
        private System.Windows.Forms.Label labelVobs;
        private System.Windows.Forms.GroupBox groupBoxCam;
        private System.Windows.Forms.GroupBox groupBoxRange;
        public System.Windows.Forms.TrackBar trackBarTransSpeed;
        public System.Windows.Forms.TrackBar trackBarRotSpeed;
        public System.Windows.Forms.TrackBar trackBarVobs;
        public System.Windows.Forms.TrackBar trackBarWorld;
        private System.Windows.Forms.Button btnSetCamApply;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        public System.Windows.Forms.CheckBox checkBoxTris;
        public System.Windows.Forms.CheckBox checkBoxFPS;
        public System.Windows.Forms.CheckBox checkBoxVobs;
        public System.Windows.Forms.CheckBox checkBoxCamCoord;
        public System.Windows.Forms.CheckBox checkBoxDistVob;
        public System.Windows.Forms.CheckBox checkBoxWaypoints;
        public System.Windows.Forms.CheckBox checkBoxCameraHideWins;
        private System.Windows.Forms.Label labelLimitFPS;
        public System.Windows.Forms.TextBox textBoxLimitFPS;
        private System.Windows.Forms.TextBox textBoxCamRot;
        private System.Windows.Forms.TextBox textBoxCamTrans;
        private System.Windows.Forms.TextBox textBoxVobsRange;
        private System.Windows.Forms.TextBox textBoxWorldRange;
        private System.Windows.Forms.Label labelCamSetSlerp;
        public System.Windows.Forms.TrackBar trackBarCamSlerp;
        private System.Windows.Forms.TextBox textBoxCamSlerp;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TrackBar trackBarSpeedPreview;
        private System.Windows.Forms.Label labelSpeedPreview;
        public System.Windows.Forms.CheckBox checkBoxCamShowPortalsInfo;
    }
}