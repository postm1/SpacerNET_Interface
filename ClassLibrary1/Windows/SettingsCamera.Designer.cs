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
            this.groupBoxRange = new System.Windows.Forms.GroupBox();
            this.Применить = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
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
            this.groupBoxRange.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarTransSpeed
            // 
            this.trackBarTransSpeed.Location = new System.Drawing.Point(1, 35);
            this.trackBarTransSpeed.Maximum = 100;
            this.trackBarTransSpeed.Minimum = 1;
            this.trackBarTransSpeed.Name = "trackBarTransSpeed";
            this.trackBarTransSpeed.Size = new System.Drawing.Size(235, 45);
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
            this.trackBarRotSpeed.Size = new System.Drawing.Size(235, 45);
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
            this.trackBarVobs.Size = new System.Drawing.Size(235, 45);
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
            this.trackBarWorld.Size = new System.Drawing.Size(235, 45);
            this.trackBarWorld.TabIndex = 7;
            this.trackBarWorld.TickFrequency = 10;
            this.trackBarWorld.Value = 1000;
            this.trackBarWorld.ValueChanged += new System.EventHandler(this.trackBarWorld_ValueChanged);
            // 
            // groupBoxCam
            // 
            this.groupBoxCam.Controls.Add(this.labelTrans);
            this.groupBoxCam.Controls.Add(this.labelRot);
            this.groupBoxCam.Controls.Add(this.trackBarTransSpeed);
            this.groupBoxCam.Controls.Add(this.trackBarRotSpeed);
            this.groupBoxCam.Location = new System.Drawing.Point(15, 12);
            this.groupBoxCam.Name = "groupBoxCam";
            this.groupBoxCam.Size = new System.Drawing.Size(298, 139);
            this.groupBoxCam.TabIndex = 8;
            this.groupBoxCam.TabStop = false;
            this.groupBoxCam.Text = "Камера";
            // 
            // groupBoxRange
            // 
            this.groupBoxRange.Controls.Add(this.labelVobs);
            this.groupBoxRange.Controls.Add(this.trackBarWorld);
            this.groupBoxRange.Controls.Add(this.labelWorld);
            this.groupBoxRange.Controls.Add(this.trackBarVobs);
            this.groupBoxRange.Location = new System.Drawing.Point(15, 157);
            this.groupBoxRange.Name = "groupBoxRange";
            this.groupBoxRange.Size = new System.Drawing.Size(301, 144);
            this.groupBoxRange.TabIndex = 9;
            this.groupBoxRange.TabStop = false;
            this.groupBoxRange.Text = "Прорисовка";
            // 
            // Применить
            // 
            this.Применить.Location = new System.Drawing.Point(259, 317);
            this.Применить.Name = "Применить";
            this.Применить.Size = new System.Drawing.Size(115, 23);
            this.Применить.TabIndex = 10;
            this.Применить.Text = "Применить";
            this.Применить.UseVisualStyleBackColor = true;
            this.Применить.Click += new System.EventHandler(this.Применить_Click);
            // 
            // groupBoxInfo
            // 
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
            this.groupBoxInfo.Size = new System.Drawing.Size(301, 289);
            this.groupBoxInfo.TabIndex = 10;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Информация";
            // 
            // labelLimitFPS
            // 
            this.labelLimitFPS.AutoSize = true;
            this.labelLimitFPS.Location = new System.Drawing.Point(6, 199);
            this.labelLimitFPS.Name = "labelLimitFPS";
            this.labelLimitFPS.Size = new System.Drawing.Size(89, 13);
            this.labelLimitFPS.TabIndex = 8;
            this.labelLimitFPS.Text = "Ограничить FPS";
            // 
            // textBoxLimitFPS
            // 
            this.textBoxLimitFPS.Location = new System.Drawing.Point(101, 196);
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
            this.checkBoxCamCoord.Size = new System.Drawing.Size(196, 17);
            this.checkBoxCamCoord.TabIndex = 2;
            this.checkBoxCamCoord.Text = "Показывать координаты камеры";
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
            this.ClientSize = new System.Drawing.Size(625, 353);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.Применить);
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
            this.groupBoxRange.ResumeLayout(false);
            this.groupBoxRange.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
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
        private System.Windows.Forms.Button Применить;
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
    }
}