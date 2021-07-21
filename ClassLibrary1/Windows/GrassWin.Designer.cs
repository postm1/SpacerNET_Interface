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
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWinGrassMinRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGrassWinVertical)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGrassWinVobName
            // 
            this.labelGrassWinVobName.AutoSize = true;
            this.labelGrassWinVobName.Location = new System.Drawing.Point(12, 14);
            this.labelGrassWinVobName.Name = "labelGrassWinVobName";
            this.labelGrassWinVobName.Size = new System.Drawing.Size(110, 13);
            this.labelGrassWinVobName.TabIndex = 0;
            this.labelGrassWinVobName.Text = "Модель воба травы:";
            // 
            // textBoxGrassWinModel
            // 
            this.textBoxGrassWinModel.Location = new System.Drawing.Point(12, 30);
            this.textBoxGrassWinModel.Name = "textBoxGrassWinModel";
            this.textBoxGrassWinModel.Size = new System.Drawing.Size(295, 20);
            this.textBoxGrassWinModel.TabIndex = 1;
            this.textBoxGrassWinModel.Text = "NW_NATURE_GRASSGROUP_01.3DS";
            this.textBoxGrassWinModel.TextChanged += new System.EventHandler(this.textBoxGrassWinModel_TextChanged);
            // 
            // trackBarWinGrassMinRadius
            // 
            this.trackBarWinGrassMinRadius.Location = new System.Drawing.Point(12, 87);
            this.trackBarWinGrassMinRadius.Maximum = 3000;
            this.trackBarWinGrassMinRadius.Name = "trackBarWinGrassMinRadius";
            this.trackBarWinGrassMinRadius.Size = new System.Drawing.Size(295, 45);
            this.trackBarWinGrassMinRadius.SmallChange = 5;
            this.trackBarWinGrassMinRadius.TabIndex = 2;
            this.trackBarWinGrassMinRadius.ValueChanged += new System.EventHandler(this.trackBarWinGrassMinRadius_ValueChanged);
            // 
            // labelWinGrassMinRadius
            // 
            this.labelWinGrassMinRadius.AutoSize = true;
            this.labelWinGrassMinRadius.Location = new System.Drawing.Point(12, 71);
            this.labelWinGrassMinRadius.Name = "labelWinGrassMinRadius";
            this.labelWinGrassMinRadius.Size = new System.Drawing.Size(168, 13);
            this.labelWinGrassMinRadius.TabIndex = 3;
            this.labelWinGrassMinRadius.Text = "Мин. радиус вежду вобами: 200";
            // 
            // buttonGrassWinApply
            // 
            this.buttonGrassWinApply.Location = new System.Drawing.Point(120, 243);
            this.buttonGrassWinApply.Name = "buttonGrassWinApply";
            this.buttonGrassWinApply.Size = new System.Drawing.Size(107, 23);
            this.buttonGrassWinApply.TabIndex = 4;
            this.buttonGrassWinApply.Text = "Применить";
            this.buttonGrassWinApply.UseVisualStyleBackColor = true;
            this.buttonGrassWinApply.Click += new System.EventHandler(this.buttonGrassWinApply_Click);
            // 
            // trackBarGrassWinVertical
            // 
            this.trackBarGrassWinVertical.Location = new System.Drawing.Point(12, 160);
            this.trackBarGrassWinVertical.Maximum = 300;
            this.trackBarGrassWinVertical.Minimum = -300;
            this.trackBarGrassWinVertical.Name = "trackBarGrassWinVertical";
            this.trackBarGrassWinVertical.Size = new System.Drawing.Size(295, 45);
            this.trackBarGrassWinVertical.TabIndex = 5;
            this.trackBarGrassWinVertical.Value = -250;
            this.trackBarGrassWinVertical.ValueChanged += new System.EventHandler(this.trackBarGrassWinVertical_ValueChanged);
            // 
            // labelWinGrassVertOffset
            // 
            this.labelWinGrassVertOffset.AutoSize = true;
            this.labelWinGrassVertOffset.Location = new System.Drawing.Point(12, 144);
            this.labelWinGrassVertOffset.Name = "labelWinGrassVertOffset";
            this.labelWinGrassVertOffset.Size = new System.Drawing.Size(61, 13);
            this.labelWinGrassVertOffset.TabIndex = 6;
            this.labelWinGrassVertOffset.Text = "Смещение";
            // 
            // checkBoxGrassWinCopyName
            // 
            this.checkBoxGrassWinCopyName.AutoSize = true;
            this.checkBoxGrassWinCopyName.Checked = true;
            this.checkBoxGrassWinCopyName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGrassWinCopyName.Location = new System.Drawing.Point(15, 203);
            this.checkBoxGrassWinCopyName.Name = "checkBoxGrassWinCopyName";
            this.checkBoxGrassWinCopyName.Size = new System.Drawing.Size(297, 17);
            this.checkBoxGrassWinCopyName.TabIndex = 7;
            this.checkBoxGrassWinCopyName.Text = "При выделении модели в поиске копироваю ее сюда";
            this.checkBoxGrassWinCopyName.UseVisualStyleBackColor = true;
            // 
            // GrassWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 278);
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
            this.Text = "Сеятель травы";
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
    }
}