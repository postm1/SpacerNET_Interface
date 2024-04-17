namespace SpacerUnion.Windows
{
    partial class SettingsVobs
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
            this.textBoxVobRot = new System.Windows.Forms.TextBox();
            this.textBoxVobTrans = new System.Windows.Forms.TextBox();
            this.labelVobTrans = new System.Windows.Forms.Label();
            this.labelVobRot = new System.Windows.Forms.Label();
            this.trackBarVobTransSpeed = new System.Windows.Forms.TrackBar();
            this.trackBarVobRotSpeed = new System.Windows.Forms.TrackBar();
            this.buttonVobControlApply = new System.Windows.Forms.Button();
            this.groupBoxSet = new System.Windows.Forms.GroupBox();
            this.checkBoxShowVobTraceFloor = new System.Windows.Forms.CheckBox();
            this.checkBoxSelectMoveInsert = new System.Windows.Forms.CheckBox();
            this.labelRotWpFP = new System.Windows.Forms.Label();
            this.radioButtonWPTurnNone = new System.Windows.Forms.RadioButton();
            this.radioButtonWPTurnAgainst = new System.Windows.Forms.RadioButton();
            this.radioButtonWPTurnOn = new System.Windows.Forms.RadioButton();
            this.checkBoxVobInsertHierarchy = new System.Windows.Forms.CheckBox();
            this.checkBoxVobRotRandAngle = new System.Windows.Forms.CheckBox();
            this.checkBoxInsertVob = new System.Windows.Forms.CheckBox();
            this.radioButtonWPTurnOnRandom = new System.Windows.Forms.RadioButton();
            this.groupBoxControlVob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVobTransSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVobRotSpeed)).BeginInit();
            this.groupBoxSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxControlVob
            // 
            this.groupBoxControlVob.Controls.Add(this.textBoxVobRot);
            this.groupBoxControlVob.Controls.Add(this.textBoxVobTrans);
            this.groupBoxControlVob.Controls.Add(this.labelVobTrans);
            this.groupBoxControlVob.Controls.Add(this.labelVobRot);
            this.groupBoxControlVob.Controls.Add(this.trackBarVobTransSpeed);
            this.groupBoxControlVob.Controls.Add(this.trackBarVobRotSpeed);
            this.groupBoxControlVob.Location = new System.Drawing.Point(12, 12);
            this.groupBoxControlVob.Name = "groupBoxControlVob";
            this.groupBoxControlVob.Size = new System.Drawing.Size(413, 139);
            this.groupBoxControlVob.TabIndex = 9;
            this.groupBoxControlVob.TabStop = false;
            this.groupBoxControlVob.Text = "Vob control";
            // 
            // textBoxVobRot
            // 
            this.textBoxVobRot.Location = new System.Drawing.Point(231, 88);
            this.textBoxVobRot.Name = "textBoxVobRot";
            this.textBoxVobRot.Size = new System.Drawing.Size(61, 20);
            this.textBoxVobRot.TabIndex = 5;
            this.textBoxVobRot.TextChanged += new System.EventHandler(this.textBoxVobRot_TextChanged);
            this.textBoxVobRot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVobTrans_KeyPress);
            // 
            // textBoxVobTrans
            // 
            this.textBoxVobTrans.Location = new System.Drawing.Point(231, 35);
            this.textBoxVobTrans.Name = "textBoxVobTrans";
            this.textBoxVobTrans.Size = new System.Drawing.Size(61, 20);
            this.textBoxVobTrans.TabIndex = 4;
            this.textBoxVobTrans.TextChanged += new System.EventHandler(this.textBoxVobTrans_TextChanged);
            this.textBoxVobTrans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVobTrans_KeyPress);
            // 
            // labelVobTrans
            // 
            this.labelVobTrans.AutoSize = true;
            this.labelVobTrans.Location = new System.Drawing.Point(6, 19);
            this.labelVobTrans.Name = "labelVobTrans";
            this.labelVobTrans.Size = new System.Drawing.Size(110, 13);
            this.labelVobTrans.TabIndex = 1;
            this.labelVobTrans.Text = "Moving speed: 10000";
            // 
            // labelVobRot
            // 
            this.labelVobRot.AutoSize = true;
            this.labelVobRot.Location = new System.Drawing.Point(6, 69);
            this.labelVobRot.Name = "labelVobRot";
            this.labelVobRot.Size = new System.Drawing.Size(97, 13);
            this.labelVobRot.TabIndex = 2;
            this.labelVobRot.Text = "Rotation speed: 32";
            // 
            // trackBarVobTransSpeed
            // 
            this.trackBarVobTransSpeed.Location = new System.Drawing.Point(1, 35);
            this.trackBarVobTransSpeed.Maximum = 50000;
            this.trackBarVobTransSpeed.Minimum = 1;
            this.trackBarVobTransSpeed.Name = "trackBarVobTransSpeed";
            this.trackBarVobTransSpeed.Size = new System.Drawing.Size(224, 45);
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
            this.trackBarVobRotSpeed.Size = new System.Drawing.Size(223, 45);
            this.trackBarVobRotSpeed.TabIndex = 3;
            this.trackBarVobRotSpeed.Value = 32;
            this.trackBarVobRotSpeed.ValueChanged += new System.EventHandler(this.trackBarVobRotSpeed_ValueChanged);
            // 
            // buttonVobControlApply
            // 
            this.buttonVobControlApply.Location = new System.Drawing.Point(168, 451);
            this.buttonVobControlApply.Name = "buttonVobControlApply";
            this.buttonVobControlApply.Size = new System.Drawing.Size(115, 23);
            this.buttonVobControlApply.TabIndex = 11;
            this.buttonVobControlApply.Text = "Apply";
            this.buttonVobControlApply.UseVisualStyleBackColor = true;
            this.buttonVobControlApply.Click += new System.EventHandler(this.buttonVobControlApply_Click);
            // 
            // groupBoxSet
            // 
            this.groupBoxSet.Controls.Add(this.radioButtonWPTurnOnRandom);
            this.groupBoxSet.Controls.Add(this.checkBoxShowVobTraceFloor);
            this.groupBoxSet.Controls.Add(this.checkBoxSelectMoveInsert);
            this.groupBoxSet.Controls.Add(this.labelRotWpFP);
            this.groupBoxSet.Controls.Add(this.radioButtonWPTurnNone);
            this.groupBoxSet.Controls.Add(this.radioButtonWPTurnAgainst);
            this.groupBoxSet.Controls.Add(this.radioButtonWPTurnOn);
            this.groupBoxSet.Controls.Add(this.checkBoxVobInsertHierarchy);
            this.groupBoxSet.Controls.Add(this.checkBoxVobRotRandAngle);
            this.groupBoxSet.Controls.Add(this.checkBoxInsertVob);
            this.groupBoxSet.Location = new System.Drawing.Point(13, 168);
            this.groupBoxSet.Name = "groupBoxSet";
            this.groupBoxSet.Size = new System.Drawing.Size(412, 277);
            this.groupBoxSet.TabIndex = 10;
            this.groupBoxSet.TabStop = false;
            this.groupBoxSet.Text = "Vob insertion";
            // 
            // checkBoxShowVobTraceFloor
            // 
            this.checkBoxShowVobTraceFloor.AutoSize = true;
            this.checkBoxShowVobTraceFloor.Location = new System.Drawing.Point(9, 115);
            this.checkBoxShowVobTraceFloor.Name = "checkBoxShowVobTraceFloor";
            this.checkBoxShowVobTraceFloor.Size = new System.Drawing.Size(224, 17);
            this.checkBoxShowVobTraceFloor.TabIndex = 8;
            this.checkBoxShowVobTraceFloor.Text = "Brighten selected vob position on the floor";
            this.checkBoxShowVobTraceFloor.UseVisualStyleBackColor = true;
            this.checkBoxShowVobTraceFloor.CheckedChanged += new System.EventHandler(this.checkBoxShowVobTraceFloor_CheckedChanged);
            // 
            // checkBoxSelectMoveInsert
            // 
            this.checkBoxSelectMoveInsert.AutoSize = true;
            this.checkBoxSelectMoveInsert.Location = new System.Drawing.Point(9, 92);
            this.checkBoxSelectMoveInsert.Name = "checkBoxSelectMoveInsert";
            this.checkBoxSelectMoveInsert.Size = new System.Drawing.Size(210, 17);
            this.checkBoxSelectMoveInsert.TabIndex = 7;
            this.checkBoxSelectMoveInsert.Text = "Select Moving tool after inserting a vob";
            this.checkBoxSelectMoveInsert.UseVisualStyleBackColor = true;
            this.checkBoxSelectMoveInsert.CheckedChanged += new System.EventHandler(this.checkBoxSelectMoveInsert_CheckedChanged);
            // 
            // labelRotWpFP
            // 
            this.labelRotWpFP.AutoSize = true;
            this.labelRotWpFP.Location = new System.Drawing.Point(6, 164);
            this.labelRotWpFP.Name = "labelRotWpFP";
            this.labelRotWpFP.Size = new System.Drawing.Size(139, 13);
            this.labelRotWpFP.TabIndex = 6;
            this.labelRotWpFP.Text = "Turn WP/FP when inserting";
            // 
            // radioButtonWPTurnNone
            // 
            this.radioButtonWPTurnNone.AutoSize = true;
            this.radioButtonWPTurnNone.Location = new System.Drawing.Point(9, 184);
            this.radioButtonWPTurnNone.Name = "radioButtonWPTurnNone";
            this.radioButtonWPTurnNone.Size = new System.Drawing.Size(51, 17);
            this.radioButtonWPTurnNone.TabIndex = 5;
            this.radioButtonWPTurnNone.TabStop = true;
            this.radioButtonWPTurnNone.Tag = "0";
            this.radioButtonWPTurnNone.Text = "None";
            this.radioButtonWPTurnNone.UseVisualStyleBackColor = true;
            this.radioButtonWPTurnNone.CheckedChanged += new System.EventHandler(this.radioButtonWPTurnNone_CheckedChanged);
            // 
            // radioButtonWPTurnAgainst
            // 
            this.radioButtonWPTurnAgainst.AutoSize = true;
            this.radioButtonWPTurnAgainst.Location = new System.Drawing.Point(9, 207);
            this.radioButtonWPTurnAgainst.Name = "radioButtonWPTurnAgainst";
            this.radioButtonWPTurnAgainst.Size = new System.Drawing.Size(104, 17);
            this.radioButtonWPTurnAgainst.TabIndex = 4;
            this.radioButtonWPTurnAgainst.TabStop = true;
            this.radioButtonWPTurnAgainst.Tag = "1";
            this.radioButtonWPTurnAgainst.Text = "From the camera";
            this.radioButtonWPTurnAgainst.UseVisualStyleBackColor = true;
            this.radioButtonWPTurnAgainst.CheckedChanged += new System.EventHandler(this.radioButtonWPTurnNone_CheckedChanged);
            // 
            // radioButtonWPTurnOn
            // 
            this.radioButtonWPTurnOn.AutoSize = true;
            this.radioButtonWPTurnOn.Location = new System.Drawing.Point(9, 230);
            this.radioButtonWPTurnOn.Name = "radioButtonWPTurnOn";
            this.radioButtonWPTurnOn.Size = new System.Drawing.Size(91, 17);
            this.radioButtonWPTurnOn.TabIndex = 3;
            this.radioButtonWPTurnOn.TabStop = true;
            this.radioButtonWPTurnOn.Tag = "2";
            this.radioButtonWPTurnOn.Text = "At the camera";
            this.radioButtonWPTurnOn.UseVisualStyleBackColor = true;
            this.radioButtonWPTurnOn.CheckedChanged += new System.EventHandler(this.radioButtonWPTurnNone_CheckedChanged);
            // 
            // checkBoxVobInsertHierarchy
            // 
            this.checkBoxVobInsertHierarchy.AutoSize = true;
            this.checkBoxVobInsertHierarchy.Location = new System.Drawing.Point(8, 69);
            this.checkBoxVobInsertHierarchy.Name = "checkBoxVobInsertHierarchy";
            this.checkBoxVobInsertHierarchy.Size = new System.Drawing.Size(160, 17);
            this.checkBoxVobInsertHierarchy.TabIndex = 2;
            this.checkBoxVobInsertHierarchy.Text = "Use hierarchy when copying";
            this.checkBoxVobInsertHierarchy.UseVisualStyleBackColor = true;
            this.checkBoxVobInsertHierarchy.CheckedChanged += new System.EventHandler(this.checkBoxVobInsertHierarchy_CheckedChanged);
            // 
            // checkBoxVobRotRandAngle
            // 
            this.checkBoxVobRotRandAngle.AutoSize = true;
            this.checkBoxVobRotRandAngle.Location = new System.Drawing.Point(8, 46);
            this.checkBoxVobRotRandAngle.Name = "checkBoxVobRotRandAngle";
            this.checkBoxVobRotRandAngle.Size = new System.Drawing.Size(160, 17);
            this.checkBoxVobRotRandAngle.TabIndex = 1;
            this.checkBoxVobRotRandAngle.Text = "Turn vob on a random angle";
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
            this.checkBoxInsertVob.Size = new System.Drawing.Size(173, 17);
            this.checkBoxInsertVob.TabIndex = 0;
            this.checkBoxInsertVob.Text = "Insert vob on the source height";
            this.checkBoxInsertVob.UseVisualStyleBackColor = true;
            this.checkBoxInsertVob.CheckedChanged += new System.EventHandler(this.checkBoxInsertVob_CheckedChanged);
            // 
            // radioButtonWPTurnOnRandom
            // 
            this.radioButtonWPTurnOnRandom.AutoSize = true;
            this.radioButtonWPTurnOnRandom.Location = new System.Drawing.Point(11, 253);
            this.radioButtonWPTurnOnRandom.Name = "radioButtonWPTurnOnRandom";
            this.radioButtonWPTurnOnRandom.Size = new System.Drawing.Size(65, 17);
            this.radioButtonWPTurnOnRandom.TabIndex = 9;
            this.radioButtonWPTurnOnRandom.TabStop = true;
            this.radioButtonWPTurnOnRandom.Tag = "3";
            this.radioButtonWPTurnOnRandom.Text = "Random";
            this.radioButtonWPTurnOnRandom.UseVisualStyleBackColor = true;
            this.radioButtonWPTurnOnRandom.CheckedChanged += new System.EventHandler(this.radioButtonWPTurnNone_CheckedChanged);
            // 
            // SettingsVobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 486);
            this.Controls.Add(this.groupBoxSet);
            this.Controls.Add(this.buttonVobControlApply);
            this.Controls.Add(this.groupBoxControlVob);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsVobs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vobs settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsControls_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsControls_KeyDown);
            this.groupBoxControlVob.ResumeLayout(false);
            this.groupBoxControlVob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVobTransSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVobRotSpeed)).EndInit();
            this.groupBoxSet.ResumeLayout(false);
            this.groupBoxSet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxControlVob;
        private System.Windows.Forms.Label labelVobTrans;
        private System.Windows.Forms.Label labelVobRot;
        public System.Windows.Forms.TrackBar trackBarVobTransSpeed;
        public System.Windows.Forms.TrackBar trackBarVobRotSpeed;
        private System.Windows.Forms.Button buttonVobControlApply;
        private System.Windows.Forms.GroupBox groupBoxSet;
        public System.Windows.Forms.CheckBox checkBoxInsertVob;
        public System.Windows.Forms.CheckBox checkBoxVobRotRandAngle;
        public System.Windows.Forms.CheckBox checkBoxVobInsertHierarchy;
        private System.Windows.Forms.Label labelRotWpFP;
        private System.Windows.Forms.RadioButton radioButtonWPTurnNone;
        private System.Windows.Forms.RadioButton radioButtonWPTurnAgainst;
        private System.Windows.Forms.RadioButton radioButtonWPTurnOn;
        private System.Windows.Forms.TextBox textBoxVobRot;
        private System.Windows.Forms.TextBox textBoxVobTrans;
        public System.Windows.Forms.CheckBox checkBoxSelectMoveInsert;
        public System.Windows.Forms.CheckBox checkBoxShowVobTraceFloor;
        private System.Windows.Forms.RadioButton radioButtonWPTurnOnRandom;
    }
}