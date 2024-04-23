namespace SpacerUnion.Windows
{
    partial class GrassWin
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
            this.labelGrassWinVobName = new System.Windows.Forms.Label();
            this.textBoxGrassWinModel = new System.Windows.Forms.TextBox();
            this.trackBarWinGrassMinRadius = new System.Windows.Forms.TrackBar();
            this.labelWinGrassMinRadius = new System.Windows.Forms.Label();
            this.buttonGrassWinApply = new System.Windows.Forms.Button();
            this.trackBarGrassWinVertical = new System.Windows.Forms.TrackBar();
            this.labelWinGrassVertOffset = new System.Windows.Forms.Label();
            this.checkBoxGrassWinCopyName = new System.Windows.Forms.CheckBox();
            this.checkBoxGrassWinRemove = new System.Windows.Forms.CheckBox();
            this.checkBoxGrassWinIsItem = new System.Windows.Forms.CheckBox();
            this.checkBoxGrassWinClickOnce = new System.Windows.Forms.CheckBox();
            this.checkBoxGrassWinDynColl = new System.Windows.Forms.CheckBox();
            this.checkBoxGrassWinRotRand = new System.Windows.Forms.CheckBox();
            this.checkBoxGrassWinSetNormal = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxstaticVob = new System.Windows.Forms.CheckBox();
            this.checkBoxcdStatic = new System.Windows.Forms.CheckBox();
            this.textBoxVobFarClipZScale = new System.Windows.Forms.TextBox();
            this.labelvobFarClipZScale = new System.Windows.Forms.Label();
            this.textBoxVisualAniModeStrength = new System.Windows.Forms.TextBox();
            this.labelVisualAniModeStrength = new System.Windows.Forms.Label();
            this.comboBoxVisualAniMode = new System.Windows.Forms.ComboBox();
            this.visualAniMode = new System.Windows.Forms.Label();
            this.labelVisualCamAlign = new System.Windows.Forms.Label();
            this.comboBoxVisualCamAlign = new System.Windows.Forms.ComboBox();
            this.buttonSetDefaultValue = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.checkBoxInsertGlobalParent = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWinGrassMinRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGrassWinVertical)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGrassWinVobName
            // 
            this.labelGrassWinVobName.AutoSize = true;
            this.labelGrassWinVobName.Location = new System.Drawing.Point(12, 14);
            this.labelGrassWinVobName.Name = "labelGrassWinVobName";
            this.labelGrassWinVobName.Size = new System.Drawing.Size(67, 13);
            this.labelGrassWinVobName.TabIndex = 0;
            this.labelGrassWinVobName.Text = "Vob\'s model:";
            // 
            // textBoxGrassWinModel
            // 
            this.textBoxGrassWinModel.Location = new System.Drawing.Point(15, 31);
            this.textBoxGrassWinModel.Name = "textBoxGrassWinModel";
            this.textBoxGrassWinModel.Size = new System.Drawing.Size(402, 20);
            this.textBoxGrassWinModel.TabIndex = 1;
            this.textBoxGrassWinModel.Text = "NW_NATURE_GRASSGROUP_01.3DS";
            this.textBoxGrassWinModel.TextChanged += new System.EventHandler(this.textBoxGrassWinModel_TextChanged);
            // 
            // trackBarWinGrassMinRadius
            // 
            this.trackBarWinGrassMinRadius.Location = new System.Drawing.Point(12, 117);
            this.trackBarWinGrassMinRadius.Maximum = 3000;
            this.trackBarWinGrassMinRadius.Name = "trackBarWinGrassMinRadius";
            this.trackBarWinGrassMinRadius.Size = new System.Drawing.Size(409, 45);
            this.trackBarWinGrassMinRadius.SmallChange = 5;
            this.trackBarWinGrassMinRadius.TabIndex = 2;
            this.trackBarWinGrassMinRadius.ValueChanged += new System.EventHandler(this.trackBarWinGrassMinRadius_ValueChanged);
            // 
            // labelWinGrassMinRadius
            // 
            this.labelWinGrassMinRadius.AutoSize = true;
            this.labelWinGrassMinRadius.Location = new System.Drawing.Point(12, 101);
            this.labelWinGrassMinRadius.Name = "labelWinGrassMinRadius";
            this.labelWinGrassMinRadius.Size = new System.Drawing.Size(179, 13);
            this.labelWinGrassMinRadius.TabIndex = 3;
            this.labelWinGrassMinRadius.Text = "Minimal distance between vobs: 200";
            // 
            // buttonGrassWinApply
            // 
            this.buttonGrassWinApply.Location = new System.Drawing.Point(280, 568);
            this.buttonGrassWinApply.Name = "buttonGrassWinApply";
            this.buttonGrassWinApply.Size = new System.Drawing.Size(137, 23);
            this.buttonGrassWinApply.TabIndex = 4;
            this.buttonGrassWinApply.Text = "Apply";
            this.buttonGrassWinApply.UseVisualStyleBackColor = true;
            this.buttonGrassWinApply.Click += new System.EventHandler(this.buttonGrassWinApply_Click);
            // 
            // trackBarGrassWinVertical
            // 
            this.trackBarGrassWinVertical.Location = new System.Drawing.Point(12, 187);
            this.trackBarGrassWinVertical.Maximum = 300;
            this.trackBarGrassWinVertical.Minimum = -300;
            this.trackBarGrassWinVertical.Name = "trackBarGrassWinVertical";
            this.trackBarGrassWinVertical.Size = new System.Drawing.Size(409, 45);
            this.trackBarGrassWinVertical.TabIndex = 5;
            this.trackBarGrassWinVertical.Value = -250;
            this.trackBarGrassWinVertical.ValueChanged += new System.EventHandler(this.trackBarGrassWinVertical_ValueChanged);
            // 
            // labelWinGrassVertOffset
            // 
            this.labelWinGrassVertOffset.AutoSize = true;
            this.labelWinGrassVertOffset.Location = new System.Drawing.Point(12, 170);
            this.labelWinGrassVertOffset.Name = "labelWinGrassVertOffset";
            this.labelWinGrassVertOffset.Size = new System.Drawing.Size(111, 13);
            this.labelWinGrassVertOffset.TabIndex = 6;
            this.labelWinGrassVertOffset.Text = "Vob\'s vertical offset: 0";
            // 
            // checkBoxGrassWinCopyName
            // 
            this.checkBoxGrassWinCopyName.AutoSize = true;
            this.checkBoxGrassWinCopyName.Checked = true;
            this.checkBoxGrassWinCopyName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGrassWinCopyName.Location = new System.Drawing.Point(3, 4);
            this.checkBoxGrassWinCopyName.Name = "checkBoxGrassWinCopyName";
            this.checkBoxGrassWinCopyName.Size = new System.Drawing.Size(211, 17);
            this.checkBoxGrassWinCopyName.TabIndex = 7;
            this.checkBoxGrassWinCopyName.Text = "Copy model name from another window";
            this.checkBoxGrassWinCopyName.UseVisualStyleBackColor = true;
            // 
            // checkBoxGrassWinRemove
            // 
            this.checkBoxGrassWinRemove.AutoSize = true;
            this.checkBoxGrassWinRemove.Checked = true;
            this.checkBoxGrassWinRemove.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGrassWinRemove.Location = new System.Drawing.Point(3, 27);
            this.checkBoxGrassWinRemove.Name = "checkBoxGrassWinRemove";
            this.checkBoxGrassWinRemove.Size = new System.Drawing.Size(118, 17);
            this.checkBoxGrassWinRemove.TabIndex = 8;
            this.checkBoxGrassWinRemove.Text = "Removing vob mod";
            this.checkBoxGrassWinRemove.UseVisualStyleBackColor = true;
            this.checkBoxGrassWinRemove.CheckedChanged += new System.EventHandler(this.checkBoxGrassWinRemove_CheckedChanged);
            // 
            // checkBoxGrassWinIsItem
            // 
            this.checkBoxGrassWinIsItem.AutoSize = true;
            this.checkBoxGrassWinIsItem.Checked = true;
            this.checkBoxGrassWinIsItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGrassWinIsItem.Location = new System.Drawing.Point(3, 50);
            this.checkBoxGrassWinIsItem.Name = "checkBoxGrassWinIsItem";
            this.checkBoxGrassWinIsItem.Size = new System.Drawing.Size(131, 17);
            this.checkBoxGrassWinIsItem.TabIndex = 9;
            this.checkBoxGrassWinIsItem.Text = "Inserted vob is oCItem";
            this.checkBoxGrassWinIsItem.UseVisualStyleBackColor = true;
            this.checkBoxGrassWinIsItem.CheckedChanged += new System.EventHandler(this.checkBoxGrassWinIsItem_CheckedChanged);
            // 
            // checkBoxGrassWinClickOnce
            // 
            this.checkBoxGrassWinClickOnce.AutoSize = true;
            this.checkBoxGrassWinClickOnce.Checked = true;
            this.checkBoxGrassWinClickOnce.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGrassWinClickOnce.Location = new System.Drawing.Point(3, 73);
            this.checkBoxGrassWinClickOnce.Name = "checkBoxGrassWinClickOnce";
            this.checkBoxGrassWinClickOnce.Size = new System.Drawing.Size(207, 17);
            this.checkBoxGrassWinClickOnce.TabIndex = 10;
            this.checkBoxGrassWinClickOnce.Text = "Protect from left mouse button pushing";
            this.checkBoxGrassWinClickOnce.UseVisualStyleBackColor = true;
            this.checkBoxGrassWinClickOnce.CheckedChanged += new System.EventHandler(this.checkBoxGrassWinClickOnce_CheckedChanged);
            // 
            // checkBoxGrassWinDynColl
            // 
            this.checkBoxGrassWinDynColl.AutoSize = true;
            this.checkBoxGrassWinDynColl.Checked = true;
            this.checkBoxGrassWinDynColl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGrassWinDynColl.Location = new System.Drawing.Point(3, 96);
            this.checkBoxGrassWinDynColl.Name = "checkBoxGrassWinDynColl";
            this.checkBoxGrassWinDynColl.Size = new System.Drawing.Size(160, 17);
            this.checkBoxGrassWinDynColl.TabIndex = 11;
            this.checkBoxGrassWinDynColl.Text = "Set dynamic collision for vob";
            this.checkBoxGrassWinDynColl.UseVisualStyleBackColor = true;
            this.checkBoxGrassWinDynColl.CheckedChanged += new System.EventHandler(this.checkBoxGrassWinDynColl_CheckedChanged);
            // 
            // checkBoxGrassWinRotRand
            // 
            this.checkBoxGrassWinRotRand.AutoSize = true;
            this.checkBoxGrassWinRotRand.Checked = true;
            this.checkBoxGrassWinRotRand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGrassWinRotRand.Location = new System.Drawing.Point(3, 119);
            this.checkBoxGrassWinRotRand.Name = "checkBoxGrassWinRotRand";
            this.checkBoxGrassWinRotRand.Size = new System.Drawing.Size(252, 17);
            this.checkBoxGrassWinRotRand.TabIndex = 12;
            this.checkBoxGrassWinRotRand.Text = "Rotate vob on random angle above vertical axis";
            this.checkBoxGrassWinRotRand.UseVisualStyleBackColor = true;
            this.checkBoxGrassWinRotRand.CheckedChanged += new System.EventHandler(this.checkBoxGrassWinRotRand_CheckedChanged);
            // 
            // checkBoxGrassWinSetNormal
            // 
            this.checkBoxGrassWinSetNormal.AutoSize = true;
            this.checkBoxGrassWinSetNormal.Checked = true;
            this.checkBoxGrassWinSetNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGrassWinSetNormal.Location = new System.Drawing.Point(3, 142);
            this.checkBoxGrassWinSetNormal.Name = "checkBoxGrassWinSetNormal";
            this.checkBoxGrassWinSetNormal.Size = new System.Drawing.Size(200, 17);
            this.checkBoxGrassWinSetNormal.TabIndex = 13;
            this.checkBoxGrassWinSetNormal.Text = "Set vob perpendicular to the polygon";
            this.checkBoxGrassWinSetNormal.UseVisualStyleBackColor = true;
            this.checkBoxGrassWinSetNormal.CheckedChanged += new System.EventHandler(this.checkBoxGrassWinSetNormal_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.checkBoxInsertGlobalParent);
            this.panel1.Controls.Add(this.checkBoxGrassWinRemove);
            this.panel1.Controls.Add(this.checkBoxGrassWinSetNormal);
            this.panel1.Controls.Add(this.checkBoxGrassWinCopyName);
            this.panel1.Controls.Add(this.checkBoxGrassWinRotRand);
            this.panel1.Controls.Add(this.checkBoxGrassWinIsItem);
            this.panel1.Controls.Add(this.checkBoxGrassWinDynColl);
            this.panel1.Controls.Add(this.checkBoxGrassWinClickOnce);
            this.panel1.Location = new System.Drawing.Point(12, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 182);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBoxstaticVob);
            this.panel2.Controls.Add(this.checkBoxcdStatic);
            this.panel2.Controls.Add(this.textBoxVobFarClipZScale);
            this.panel2.Controls.Add(this.labelvobFarClipZScale);
            this.panel2.Controls.Add(this.textBoxVisualAniModeStrength);
            this.panel2.Controls.Add(this.labelVisualAniModeStrength);
            this.panel2.Controls.Add(this.comboBoxVisualAniMode);
            this.panel2.Controls.Add(this.visualAniMode);
            this.panel2.Controls.Add(this.labelVisualCamAlign);
            this.panel2.Controls.Add(this.comboBoxVisualCamAlign);
            this.panel2.Location = new System.Drawing.Point(12, 428);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 163);
            this.panel2.TabIndex = 15;
            // 
            // checkBoxstaticVob
            // 
            this.checkBoxstaticVob.AutoSize = true;
            this.checkBoxstaticVob.Location = new System.Drawing.Point(12, 133);
            this.checkBoxstaticVob.Name = "checkBoxstaticVob";
            this.checkBoxstaticVob.Size = new System.Drawing.Size(70, 17);
            this.checkBoxstaticVob.TabIndex = 15;
            this.checkBoxstaticVob.Text = "staticVob";
            this.checkBoxstaticVob.UseVisualStyleBackColor = true;
            this.checkBoxstaticVob.CheckedChanged += new System.EventHandler(this.checkBoxstaticVob_CheckedChanged);
            this.checkBoxstaticVob.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.checkBoxstaticVob_ChangeUICues);
            // 
            // checkBoxcdStatic
            // 
            this.checkBoxcdStatic.AutoSize = true;
            this.checkBoxcdStatic.Location = new System.Drawing.Point(12, 112);
            this.checkBoxcdStatic.Name = "checkBoxcdStatic";
            this.checkBoxcdStatic.Size = new System.Drawing.Size(65, 17);
            this.checkBoxcdStatic.TabIndex = 14;
            this.checkBoxcdStatic.Text = "cdStatic";
            this.checkBoxcdStatic.UseVisualStyleBackColor = true;
            this.checkBoxcdStatic.CheckedChanged += new System.EventHandler(this.checkBoxcdStatic_CheckedChanged);
            // 
            // textBoxVobFarClipZScale
            // 
            this.textBoxVobFarClipZScale.Location = new System.Drawing.Point(131, 89);
            this.textBoxVobFarClipZScale.Name = "textBoxVobFarClipZScale";
            this.textBoxVobFarClipZScale.Size = new System.Drawing.Size(55, 20);
            this.textBoxVobFarClipZScale.TabIndex = 7;
            this.textBoxVobFarClipZScale.Text = "1";
            this.textBoxVobFarClipZScale.TextChanged += new System.EventHandler(this.textBoxVobFarClipZScale_TextChanged);
            this.textBoxVobFarClipZScale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVobFarClipZScale_KeyPress);
            // 
            // labelvobFarClipZScale
            // 
            this.labelvobFarClipZScale.AutoSize = true;
            this.labelvobFarClipZScale.Location = new System.Drawing.Point(8, 92);
            this.labelvobFarClipZScale.Name = "labelvobFarClipZScale";
            this.labelvobFarClipZScale.Size = new System.Drawing.Size(91, 13);
            this.labelvobFarClipZScale.TabIndex = 6;
            this.labelvobFarClipZScale.Text = "vobFarClipZScale";
            // 
            // textBoxVisualAniModeStrength
            // 
            this.textBoxVisualAniModeStrength.Location = new System.Drawing.Point(131, 66);
            this.textBoxVisualAniModeStrength.Name = "textBoxVisualAniModeStrength";
            this.textBoxVisualAniModeStrength.Size = new System.Drawing.Size(55, 20);
            this.textBoxVisualAniModeStrength.TabIndex = 5;
            this.textBoxVisualAniModeStrength.Text = "0";
            this.textBoxVisualAniModeStrength.TextChanged += new System.EventHandler(this.textBoxVisualAniModeStrength_TextChanged);
            this.textBoxVisualAniModeStrength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVisualAniModeStrength_KeyPress);
            // 
            // labelVisualAniModeStrength
            // 
            this.labelVisualAniModeStrength.AutoSize = true;
            this.labelVisualAniModeStrength.Location = new System.Drawing.Point(9, 66);
            this.labelVisualAniModeStrength.Name = "labelVisualAniModeStrength";
            this.labelVisualAniModeStrength.Size = new System.Drawing.Size(116, 13);
            this.labelVisualAniModeStrength.TabIndex = 4;
            this.labelVisualAniModeStrength.Text = "visualAniModeStrength";
            // 
            // comboBoxVisualAniMode
            // 
            this.comboBoxVisualAniMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVisualAniMode.FormattingEnabled = true;
            this.comboBoxVisualAniMode.Items.AddRange(new object[] {
            "NONE",
            "WIND",
            "WIND2"});
            this.comboBoxVisualAniMode.Location = new System.Drawing.Point(131, 37);
            this.comboBoxVisualAniMode.Name = "comboBoxVisualAniMode";
            this.comboBoxVisualAniMode.Size = new System.Drawing.Size(102, 21);
            this.comboBoxVisualAniMode.TabIndex = 3;
            this.comboBoxVisualAniMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxVisualAniMode_SelectedIndexChanged);
            // 
            // visualAniMode
            // 
            this.visualAniMode.AutoSize = true;
            this.visualAniMode.Location = new System.Drawing.Point(9, 40);
            this.visualAniMode.Name = "visualAniMode";
            this.visualAniMode.Size = new System.Drawing.Size(76, 13);
            this.visualAniMode.TabIndex = 2;
            this.visualAniMode.Text = "visualAniMode";
            // 
            // labelVisualCamAlign
            // 
            this.labelVisualCamAlign.AutoSize = true;
            this.labelVisualCamAlign.Location = new System.Drawing.Point(8, 14);
            this.labelVisualCamAlign.Name = "labelVisualCamAlign";
            this.labelVisualCamAlign.Size = new System.Drawing.Size(78, 13);
            this.labelVisualCamAlign.TabIndex = 1;
            this.labelVisualCamAlign.Text = "visualCamAlign";
            // 
            // comboBoxVisualCamAlign
            // 
            this.comboBoxVisualCamAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVisualCamAlign.FormattingEnabled = true;
            this.comboBoxVisualCamAlign.Items.AddRange(new object[] {
            "NONE",
            "YAW",
            "FULL"});
            this.comboBoxVisualCamAlign.Location = new System.Drawing.Point(131, 10);
            this.comboBoxVisualCamAlign.Name = "comboBoxVisualCamAlign";
            this.comboBoxVisualCamAlign.Size = new System.Drawing.Size(102, 21);
            this.comboBoxVisualCamAlign.TabIndex = 0;
            this.comboBoxVisualCamAlign.SelectedIndexChanged += new System.EventHandler(this.comboBoxVisualCamAlign_SelectedIndexChanged);
            // 
            // buttonSetDefaultValue
            // 
            this.buttonSetDefaultValue.Location = new System.Drawing.Point(280, 428);
            this.buttonSetDefaultValue.Name = "buttonSetDefaultValue";
            this.buttonSetDefaultValue.Size = new System.Drawing.Size(137, 23);
            this.buttonSetDefaultValue.TabIndex = 16;
            this.buttonSetDefaultValue.Text = "Set default settings";
            this.buttonSetDefaultValue.UseVisualStyleBackColor = true;
            this.buttonSetDefaultValue.Click += new System.EventHandler(this.buttonSetDefaultValue_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(15, 58);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(137, 23);
            this.buttonOpenFile.TabIndex = 17;
            this.buttonOpenFile.Text = "Open file";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // checkBoxInsertGlobalParent
            // 
            this.checkBoxInsertGlobalParent.AutoSize = true;
            this.checkBoxInsertGlobalParent.Checked = true;
            this.checkBoxInsertGlobalParent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInsertGlobalParent.Location = new System.Drawing.Point(3, 162);
            this.checkBoxInsertGlobalParent.Name = "checkBoxInsertGlobalParent";
            this.checkBoxInsertGlobalParent.Size = new System.Drawing.Size(154, 17);
            this.checkBoxInsertGlobalParent.TabIndex = 14;
            this.checkBoxInsertGlobalParent.Text = "Insert into the global parent";
            this.checkBoxInsertGlobalParent.UseVisualStyleBackColor = true;
            this.checkBoxInsertGlobalParent.CheckedChanged += new System.EventHandler(this.checkBoxInsertGlobalParent_CheckedChanged);
            // 
            // GrassWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 603);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.buttonSetDefaultValue);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelWinGrassVertOffset);
            this.Controls.Add(this.trackBarGrassWinVertical);
            this.Controls.Add(this.buttonGrassWinApply);
            this.Controls.Add(this.labelWinGrassMinRadius);
            this.Controls.Add(this.trackBarWinGrassMinRadius);
            this.Controls.Add(this.textBoxGrassWinModel);
            this.Controls.Add(this.labelGrassWinVobName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GrassWin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Objects sower";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GrassWin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWinGrassMinRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGrassWinVertical)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGrassWinVobName;
        private System.Windows.Forms.Label labelWinGrassMinRadius;
        public System.Windows.Forms.TrackBar trackBarWinGrassMinRadius;
        private System.Windows.Forms.Button buttonGrassWinApply;
        public System.Windows.Forms.TextBox textBoxGrassWinModel;
        public System.Windows.Forms.TrackBar trackBarGrassWinVertical;
        public System.Windows.Forms.Label labelWinGrassVertOffset;
        public System.Windows.Forms.CheckBox checkBoxGrassWinCopyName;
        public System.Windows.Forms.CheckBox checkBoxGrassWinRemove;
        public System.Windows.Forms.CheckBox checkBoxGrassWinIsItem;
        public System.Windows.Forms.CheckBox checkBoxGrassWinClickOnce;
        public System.Windows.Forms.CheckBox checkBoxGrassWinDynColl;
        public System.Windows.Forms.CheckBox checkBoxGrassWinRotRand;
        public System.Windows.Forms.CheckBox checkBoxGrassWinSetNormal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.CheckBox checkBoxstaticVob;
        public System.Windows.Forms.CheckBox checkBoxcdStatic;
        private System.Windows.Forms.Label labelvobFarClipZScale;
        private System.Windows.Forms.Label labelVisualAniModeStrength;
        private System.Windows.Forms.Label visualAniMode;
        private System.Windows.Forms.Label labelVisualCamAlign;
        public System.Windows.Forms.TextBox textBoxVobFarClipZScale;
        public System.Windows.Forms.TextBox textBoxVisualAniModeStrength;
        public System.Windows.Forms.ComboBox comboBoxVisualAniMode;
        public System.Windows.Forms.ComboBox comboBoxVisualCamAlign;
        private System.Windows.Forms.Button buttonSetDefaultValue;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.CheckBox checkBoxInsertGlobalParent;
    }
}