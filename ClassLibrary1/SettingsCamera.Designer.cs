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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Применить = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxFPS = new System.Windows.Forms.CheckBox();
            this.checkBoxTris = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWorld)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.trackBarVobs.Maximum = 10000;
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
            this.trackBarWorld.Maximum = 10000;
            this.trackBarWorld.Minimum = 100;
            this.trackBarWorld.Name = "trackBarWorld";
            this.trackBarWorld.Size = new System.Drawing.Size(235, 45);
            this.trackBarWorld.TabIndex = 7;
            this.trackBarWorld.TickFrequency = 10;
            this.trackBarWorld.Value = 1000;
            this.trackBarWorld.ValueChanged += new System.EventHandler(this.trackBarWorld_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTrans);
            this.groupBox1.Controls.Add(this.labelRot);
            this.groupBox1.Controls.Add(this.trackBarTransSpeed);
            this.groupBox1.Controls.Add(this.trackBarRotSpeed);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 139);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Камера";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelVobs);
            this.groupBox2.Controls.Add(this.trackBarWorld);
            this.groupBox2.Controls.Add(this.labelWorld);
            this.groupBox2.Controls.Add(this.trackBarVobs);
            this.groupBox2.Location = new System.Drawing.Point(15, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 144);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Прорисовка";
            // 
            // Применить
            // 
            this.Применить.Location = new System.Drawing.Point(104, 378);
            this.Применить.Name = "Применить";
            this.Применить.Size = new System.Drawing.Size(115, 23);
            this.Применить.TabIndex = 10;
            this.Применить.Text = "Применить";
            this.Применить.UseVisualStyleBackColor = true;
            this.Применить.Click += new System.EventHandler(this.Применить_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxTris);
            this.groupBox3.Controls.Add(this.checkBoxFPS);
            this.groupBox3.Location = new System.Drawing.Point(15, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 65);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация";
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
            // SettingsCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 413);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Применить);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWorld)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTrans;
        private System.Windows.Forms.Label labelRot;
        private System.Windows.Forms.Label labelWorld;
        private System.Windows.Forms.Label labelVobs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TrackBar trackBarTransSpeed;
        public System.Windows.Forms.TrackBar trackBarRotSpeed;
        public System.Windows.Forms.TrackBar trackBarVobs;
        public System.Windows.Forms.TrackBar trackBarWorld;
        private System.Windows.Forms.Button Применить;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.CheckBox checkBoxTris;
        public System.Windows.Forms.CheckBox checkBoxFPS;
    }
}