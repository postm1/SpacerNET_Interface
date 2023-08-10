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
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWinGrassMinRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGrassWinVertical)).BeginInit();
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
            this.textBoxGrassWinModel.Location = new System.Drawing.Point(12, 30);
            this.textBoxGrassWinModel.Name = "textBoxGrassWinModel";
            this.textBoxGrassWinModel.Size = new System.Drawing.Size(409, 20);
            this.textBoxGrassWinModel.TabIndex = 1;
            this.textBoxGrassWinModel.Text = "NW_NATURE_GRASSGROUP_01.3DS";
            this.textBoxGrassWinModel.TextChanged += new System.EventHandler(this.textBoxGrassWinModel_TextChanged);
            // 
            // trackBarWinGrassMinRadius
            // 
            this.trackBarWinGrassMinRadius.Location = new System.Drawing.Point(12, 87);
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
            this.labelWinGrassMinRadius.Location = new System.Drawing.Point(12, 71);
            this.labelWinGrassMinRadius.Name = "labelWinGrassMinRadius";
            this.labelWinGrassMinRadius.Size = new System.Drawing.Size(179, 13);
            this.labelWinGrassMinRadius.TabIndex = 3;
            this.labelWinGrassMinRadius.Text = "Minimal distance between vobs: 200";
            // 
            // buttonGrassWinApply
            // 
            this.buttonGrassWinApply.Location = new System.Drawing.Point(163, 376);
            this.buttonGrassWinApply.Name = "buttonGrassWinApply";
            this.buttonGrassWinApply.Size = new System.Drawing.Size(107, 23);
            this.buttonGrassWinApply.TabIndex = 4;
            this.buttonGrassWinApply.Text = "Apply";
            this.buttonGrassWinApply.UseVisualStyleBackColor = true;
            this.buttonGrassWinApply.Click += new System.EventHandler(this.buttonGrassWinApply_Click);
            // 
            // trackBarGrassWinVertical
            // 
            this.trackBarGrassWinVertical.Location = new System.Drawing.Point(12, 160);
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
            this.labelWinGrassVertOffset.Location = new System.Drawing.Point(12, 144);
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
            this.checkBoxGrassWinCopyName.Location = new System.Drawing.Point(15, 203);
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
            this.checkBoxGrassWinRemove.Location = new System.Drawing.Point(15, 226);
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
            this.checkBoxGrassWinIsItem.Location = new System.Drawing.Point(15, 249);
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
            this.checkBoxGrassWinClickOnce.Location = new System.Drawing.Point(15, 272);
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
            this.checkBoxGrassWinDynColl.Location = new System.Drawing.Point(15, 295);
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
            this.checkBoxGrassWinRotRand.Location = new System.Drawing.Point(15, 318);
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
            this.checkBoxGrassWinSetNormal.Location = new System.Drawing.Point(15, 341);
            this.checkBoxGrassWinSetNormal.Name = "checkBoxGrassWinSetNormal";
            this.checkBoxGrassWinSetNormal.Size = new System.Drawing.Size(200, 17);
            this.checkBoxGrassWinSetNormal.TabIndex = 13;
            this.checkBoxGrassWinSetNormal.Text = "Set vob perpendicular to the polygon";
            this.checkBoxGrassWinSetNormal.UseVisualStyleBackColor = true;
            this.checkBoxGrassWinSetNormal.CheckedChanged += new System.EventHandler(this.checkBoxGrassWinSetNormal_CheckedChanged);
            // 
            // GrassWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 411);
            this.Controls.Add(this.checkBoxGrassWinSetNormal);
            this.Controls.Add(this.checkBoxGrassWinRotRand);
            this.Controls.Add(this.checkBoxGrassWinDynColl);
            this.Controls.Add(this.checkBoxGrassWinClickOnce);
            this.Controls.Add(this.checkBoxGrassWinIsItem);
            this.Controls.Add(this.checkBoxGrassWinRemove);
            this.Controls.Add(this.checkBoxGrassWinCopyName);
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
            this.Text = "Objects sewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GrassWin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWinGrassMinRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGrassWinVertical)).EndInit();
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
    }
}