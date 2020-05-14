namespace SpacerUnion.Windows
{
    partial class SettingsControls
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
            this.groupBoxControlVob = new System.Windows.Forms.GroupBox();
            this.labelVobTrans = new System.Windows.Forms.Label();
            this.labelVobRot = new System.Windows.Forms.Label();
            this.trackBarVobTransSpeed = new System.Windows.Forms.TrackBar();
            this.trackBarVobRotSpeed = new System.Windows.Forms.TrackBar();
            this.buttonVobControlApply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonWPTurnNone = new System.Windows.Forms.RadioButton();
            this.radioButtonWPTurnAgainst = new System.Windows.Forms.RadioButton();
            this.radioButtonWPTurnOn = new System.Windows.Forms.RadioButton();
            this.checkBoxVobInsertHierarchy = new System.Windows.Forms.CheckBox();
            this.checkBoxVobRotRandAngle = new System.Windows.Forms.CheckBox();
            this.checkBoxInsertVob = new System.Windows.Forms.CheckBox();
            this.groupBoxControlVob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVobTransSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVobRotSpeed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxControlVob
            // 
            this.groupBoxControlVob.Controls.Add(this.labelVobTrans);
            this.groupBoxControlVob.Controls.Add(this.labelVobRot);
            this.groupBoxControlVob.Controls.Add(this.trackBarVobTransSpeed);
            this.groupBoxControlVob.Controls.Add(this.trackBarVobRotSpeed);
            this.groupBoxControlVob.Location = new System.Drawing.Point(12, 12);
            this.groupBoxControlVob.Name = "groupBoxControlVob";
            this.groupBoxControlVob.Size = new System.Drawing.Size(298, 139);
            this.groupBoxControlVob.TabIndex = 9;
            this.groupBoxControlVob.TabStop = false;
            this.groupBoxControlVob.Text = "Управление вобом";
            // 
            // labelVobTrans
            // 
            this.labelVobTrans.AutoSize = true;
            this.labelVobTrans.Location = new System.Drawing.Point(6, 19);
            this.labelVobTrans.Name = "labelVobTrans";
            this.labelVobTrans.Size = new System.Drawing.Size(129, 13);
            this.labelVobTrans.TabIndex = 1;
            this.labelVobTrans.Text = "Скорость перемещения";
            // 
            // labelVobRot
            // 
            this.labelVobRot.AutoSize = true;
            this.labelVobRot.Location = new System.Drawing.Point(6, 69);
            this.labelVobRot.Name = "labelVobRot";
            this.labelVobRot.Size = new System.Drawing.Size(109, 13);
            this.labelVobRot.TabIndex = 2;
            this.labelVobRot.Text = "Скорость вращения";
            // 
            // trackBarVobTransSpeed
            // 
            this.trackBarVobTransSpeed.Location = new System.Drawing.Point(1, 35);
            this.trackBarVobTransSpeed.Maximum = 50000;
            this.trackBarVobTransSpeed.Minimum = 1;
            this.trackBarVobTransSpeed.Name = "trackBarVobTransSpeed";
            this.trackBarVobTransSpeed.Size = new System.Drawing.Size(235, 45);
            this.trackBarVobTransSpeed.TabIndex = 0;
            this.trackBarVobTransSpeed.TickFrequency = 500;
            this.trackBarVobTransSpeed.Value = 10000;
            this.trackBarVobTransSpeed.ValueChanged += new System.EventHandler(this.trackBarVobTransSpeed_ValueChanged);
            // 
            // trackBarVobRotSpeed
            // 
            this.trackBarVobRotSpeed.Location = new System.Drawing.Point(2, 88);
            this.trackBarVobRotSpeed.Maximum = 200;
            this.trackBarVobRotSpeed.Minimum = 1;
            this.trackBarVobRotSpeed.Name = "trackBarVobRotSpeed";
            this.trackBarVobRotSpeed.Size = new System.Drawing.Size(234, 45);
            this.trackBarVobRotSpeed.TabIndex = 3;
            this.trackBarVobRotSpeed.Value = 32;
            this.trackBarVobRotSpeed.ValueChanged += new System.EventHandler(this.trackBarVobRotSpeed_ValueChanged);
            // 
            // buttonVobControlApply
            // 
            this.buttonVobControlApply.Location = new System.Drawing.Point(98, 469);
            this.buttonVobControlApply.Name = "buttonVobControlApply";
            this.buttonVobControlApply.Size = new System.Drawing.Size(115, 23);
            this.buttonVobControlApply.TabIndex = 11;
            this.buttonVobControlApply.Text = "Применить";
            this.buttonVobControlApply.UseVisualStyleBackColor = true;
            this.buttonVobControlApply.Click += new System.EventHandler(this.buttonVobControlApply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButtonWPTurnNone);
            this.groupBox1.Controls.Add(this.radioButtonWPTurnAgainst);
            this.groupBox1.Controls.Add(this.radioButtonWPTurnOn);
            this.groupBox1.Controls.Add(this.checkBoxVobInsertHierarchy);
            this.groupBox1.Controls.Add(this.checkBoxVobRotRandAngle);
            this.groupBox1.Controls.Add(this.checkBoxInsertVob);
            this.groupBox1.Location = new System.Drawing.Point(13, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 253);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вставка воба";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Разворачивать WP/FP при вставке";
            // 
            // radioButtonWPTurnNone
            // 
            this.radioButtonWPTurnNone.AutoSize = true;
            this.radioButtonWPTurnNone.Location = new System.Drawing.Point(9, 133);
            this.radioButtonWPTurnNone.Name = "radioButtonWPTurnNone";
            this.radioButtonWPTurnNone.Size = new System.Drawing.Size(44, 17);
            this.radioButtonWPTurnNone.TabIndex = 5;
            this.radioButtonWPTurnNone.TabStop = true;
            this.radioButtonWPTurnNone.Tag = "0";
            this.radioButtonWPTurnNone.Text = "Нет";
            this.radioButtonWPTurnNone.UseVisualStyleBackColor = true;
            this.radioButtonWPTurnNone.CheckedChanged += new System.EventHandler(this.radioButtonWPTurnNone_CheckedChanged);
            // 
            // radioButtonWPTurnAgainst
            // 
            this.radioButtonWPTurnAgainst.AutoSize = true;
            this.radioButtonWPTurnAgainst.Location = new System.Drawing.Point(9, 156);
            this.radioButtonWPTurnAgainst.Name = "radioButtonWPTurnAgainst";
            this.radioButtonWPTurnAgainst.Size = new System.Drawing.Size(81, 17);
            this.radioButtonWPTurnAgainst.TabIndex = 4;
            this.radioButtonWPTurnAgainst.TabStop = true;
            this.radioButtonWPTurnAgainst.Tag = "1";
            this.radioButtonWPTurnAgainst.Text = "От камеры";
            this.radioButtonWPTurnAgainst.UseVisualStyleBackColor = true;
            this.radioButtonWPTurnAgainst.CheckedChanged += new System.EventHandler(this.radioButtonWPTurnNone_CheckedChanged);
            // 
            // radioButtonWPTurnOn
            // 
            this.radioButtonWPTurnOn.AutoSize = true;
            this.radioButtonWPTurnOn.Location = new System.Drawing.Point(9, 179);
            this.radioButtonWPTurnOn.Name = "radioButtonWPTurnOn";
            this.radioButtonWPTurnOn.Size = new System.Drawing.Size(79, 17);
            this.radioButtonWPTurnOn.TabIndex = 3;
            this.radioButtonWPTurnOn.TabStop = true;
            this.radioButtonWPTurnOn.Tag = "2";
            this.radioButtonWPTurnOn.Text = "На камеру";
            this.radioButtonWPTurnOn.UseVisualStyleBackColor = true;
            this.radioButtonWPTurnOn.CheckedChanged += new System.EventHandler(this.radioButtonWPTurnNone_CheckedChanged);
            // 
            // checkBoxVobInsertHierarchy
            // 
            this.checkBoxVobInsertHierarchy.AutoSize = true;
            this.checkBoxVobInsertHierarchy.Location = new System.Drawing.Point(8, 69);
            this.checkBoxVobInsertHierarchy.Name = "checkBoxVobInsertHierarchy";
            this.checkBoxVobInsertHierarchy.Size = new System.Drawing.Size(223, 17);
            this.checkBoxVobInsertHierarchy.TabIndex = 2;
            this.checkBoxVobInsertHierarchy.Text = "Учитывать иерархию при копировании";
            this.checkBoxVobInsertHierarchy.UseVisualStyleBackColor = true;
            this.checkBoxVobInsertHierarchy.CheckedChanged += new System.EventHandler(this.checkBoxVobInsertHierarchy_CheckedChanged);
            // 
            // checkBoxVobRotRandAngle
            // 
            this.checkBoxVobRotRandAngle.AutoSize = true;
            this.checkBoxVobRotRandAngle.Location = new System.Drawing.Point(8, 46);
            this.checkBoxVobRotRandAngle.Name = "checkBoxVobRotRandAngle";
            this.checkBoxVobRotRandAngle.Size = new System.Drawing.Size(216, 17);
            this.checkBoxVobRotRandAngle.TabIndex = 1;
            this.checkBoxVobRotRandAngle.Text = "Поворачивать воб на случайный угол";
            this.checkBoxVobRotRandAngle.UseVisualStyleBackColor = true;
            this.checkBoxVobRotRandAngle.CheckedChanged += new System.EventHandler(this.checkBoxVobRotRandAngle_CheckedChanged);
            // 
            // checkBoxInsertVob
            // 
            this.checkBoxInsertVob.AutoSize = true;
            this.checkBoxInsertVob.Checked = true;
            this.checkBoxInsertVob.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInsertVob.Location = new System.Drawing.Point(8, 23);
            this.checkBoxInsertVob.Name = "checkBoxInsertVob";
            this.checkBoxInsertVob.Size = new System.Drawing.Size(192, 17);
            this.checkBoxInsertVob.TabIndex = 0;
            this.checkBoxInsertVob.Text = "Вставлять воб на той же высоте";
            this.checkBoxInsertVob.UseVisualStyleBackColor = true;
            this.checkBoxInsertVob.CheckedChanged += new System.EventHandler(this.checkBoxInsertVob_CheckedChanged);
            // 
            // SettingsControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 526);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonVobControlApply);
            this.Controls.Add(this.groupBoxControlVob);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsControls";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки управления";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsControls_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsControls_KeyDown);
            this.groupBoxControlVob.ResumeLayout(false);
            this.groupBoxControlVob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVobTransSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVobRotSpeed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxControlVob;
        private System.Windows.Forms.Label labelVobTrans;
        private System.Windows.Forms.Label labelVobRot;
        public System.Windows.Forms.TrackBar trackBarVobTransSpeed;
        public System.Windows.Forms.TrackBar trackBarVobRotSpeed;
        private System.Windows.Forms.Button buttonVobControlApply;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox checkBoxInsertVob;
        public System.Windows.Forms.CheckBox checkBoxVobRotRandAngle;
        public System.Windows.Forms.CheckBox checkBoxVobInsertHierarchy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonWPTurnNone;
        private System.Windows.Forms.RadioButton radioButtonWPTurnAgainst;
        private System.Windows.Forms.RadioButton radioButtonWPTurnOn;
    }
}