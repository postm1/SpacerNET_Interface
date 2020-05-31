namespace SpacerUnion
{
    partial class CompileLightWin
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
            this.groupBoxQuality = new System.Windows.Forms.GroupBox();
            this.radioButtonHigh = new System.Windows.Forms.RadioButton();
            this.radioButtonMiddle = new System.Windows.Forms.RadioButton();
            this.radioButtonLow = new System.Windows.Forms.RadioButton();
            this.radioButtonVertex = new System.Windows.Forms.RadioButton();
            this.buttonCompileLight = new System.Windows.Forms.Button();
            this.buttonCompileLightClose = new System.Windows.Forms.Button();
            this.groupBoxRegion = new System.Windows.Forms.GroupBox();
            this.labelMeters = new System.Windows.Forms.Label();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.labelAroundCamera = new System.Windows.Forms.Label();
            this.checkBoxCompileRegion = new System.Windows.Forms.CheckBox();
            this.groupBoxQuality.SuspendLayout();
            this.groupBoxRegion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxQuality
            // 
            this.groupBoxQuality.Controls.Add(this.radioButtonHigh);
            this.groupBoxQuality.Controls.Add(this.radioButtonMiddle);
            this.groupBoxQuality.Controls.Add(this.radioButtonLow);
            this.groupBoxQuality.Controls.Add(this.radioButtonVertex);
            this.groupBoxQuality.Location = new System.Drawing.Point(12, 12);
            this.groupBoxQuality.Name = "groupBoxQuality";
            this.groupBoxQuality.Size = new System.Drawing.Size(177, 200);
            this.groupBoxQuality.TabIndex = 0;
            this.groupBoxQuality.TabStop = false;
            this.groupBoxQuality.Text = "Качество";
            // 
            // radioButtonHigh
            // 
            this.radioButtonHigh.AutoSize = true;
            this.radioButtonHigh.Location = new System.Drawing.Point(18, 138);
            this.radioButtonHigh.Name = "radioButtonHigh";
            this.radioButtonHigh.Size = new System.Drawing.Size(126, 17);
            this.radioButtonHigh.TabIndex = 3;
            this.radioButtonHigh.TabStop = true;
            this.radioButtonHigh.Text = "Lightmaps (высокое)";
            this.radioButtonHigh.UseVisualStyleBackColor = true;
            // 
            // radioButtonMiddle
            // 
            this.radioButtonMiddle.AutoSize = true;
            this.radioButtonMiddle.Location = new System.Drawing.Point(18, 115);
            this.radioButtonMiddle.Name = "radioButtonMiddle";
            this.radioButtonMiddle.Size = new System.Drawing.Size(124, 17);
            this.radioButtonMiddle.TabIndex = 2;
            this.radioButtonMiddle.TabStop = true;
            this.radioButtonMiddle.Text = "Lightmaps (среднее)";
            this.radioButtonMiddle.UseVisualStyleBackColor = true;
            // 
            // radioButtonLow
            // 
            this.radioButtonLow.AutoSize = true;
            this.radioButtonLow.Location = new System.Drawing.Point(18, 92);
            this.radioButtonLow.Name = "radioButtonLow";
            this.radioButtonLow.Size = new System.Drawing.Size(118, 17);
            this.radioButtonLow.TabIndex = 1;
            this.radioButtonLow.TabStop = true;
            this.radioButtonLow.Text = "Lightmaps (низкое)";
            this.radioButtonLow.UseVisualStyleBackColor = true;
            // 
            // radioButtonVertex
            // 
            this.radioButtonVertex.AutoSize = true;
            this.radioButtonVertex.Checked = true;
            this.radioButtonVertex.Location = new System.Drawing.Point(18, 37);
            this.radioButtonVertex.Name = "radioButtonVertex";
            this.radioButtonVertex.Size = new System.Drawing.Size(111, 17);
            this.radioButtonVertex.TabIndex = 0;
            this.radioButtonVertex.TabStop = true;
            this.radioButtonVertex.Text = "Только вершины";
            this.radioButtonVertex.UseVisualStyleBackColor = true;
            // 
            // buttonCompileLight
            // 
            this.buttonCompileLight.Location = new System.Drawing.Point(218, 150);
            this.buttonCompileLight.Name = "buttonCompileLight";
            this.buttonCompileLight.Size = new System.Drawing.Size(194, 27);
            this.buttonCompileLight.TabIndex = 1;
            this.buttonCompileLight.Text = "Компилировать";
            this.buttonCompileLight.UseVisualStyleBackColor = true;
            this.buttonCompileLight.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCompileLightClose
            // 
            this.buttonCompileLightClose.Location = new System.Drawing.Point(218, 186);
            this.buttonCompileLightClose.Name = "buttonCompileLightClose";
            this.buttonCompileLightClose.Size = new System.Drawing.Size(194, 26);
            this.buttonCompileLightClose.TabIndex = 2;
            this.buttonCompileLightClose.Text = "Закрыть окно";
            this.buttonCompileLightClose.UseVisualStyleBackColor = true;
            this.buttonCompileLightClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxRegion
            // 
            this.groupBoxRegion.Controls.Add(this.labelMeters);
            this.groupBoxRegion.Controls.Add(this.textBoxRadius);
            this.groupBoxRegion.Controls.Add(this.labelAroundCamera);
            this.groupBoxRegion.Controls.Add(this.checkBoxCompileRegion);
            this.groupBoxRegion.Location = new System.Drawing.Point(218, 12);
            this.groupBoxRegion.Name = "groupBoxRegion";
            this.groupBoxRegion.Size = new System.Drawing.Size(194, 109);
            this.groupBoxRegion.TabIndex = 3;
            this.groupBoxRegion.TabStop = false;
            this.groupBoxRegion.Text = "Регион";
            // 
            // labelMeters
            // 
            this.labelMeters.AutoSize = true;
            this.labelMeters.Location = new System.Drawing.Point(91, 48);
            this.labelMeters.Name = "labelMeters";
            this.labelMeters.Size = new System.Drawing.Size(44, 13);
            this.labelMeters.TabIndex = 3;
            this.labelMeters.Text = "метров";
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Enabled = false;
            this.textBoxRadius.Location = new System.Drawing.Point(18, 45);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(67, 20);
            this.textBoxRadius.TabIndex = 2;
            this.textBoxRadius.Text = "2000";
            this.textBoxRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // labelAroundCamera
            // 
            this.labelAroundCamera.AutoSize = true;
            this.labelAroundCamera.Location = new System.Drawing.Point(15, 74);
            this.labelAroundCamera.Name = "labelAroundCamera";
            this.labelAroundCamera.Size = new System.Drawing.Size(84, 13);
            this.labelAroundCamera.TabIndex = 1;
            this.labelAroundCamera.Text = "вокруг камеры";
            // 
            // checkBoxCompileRegion
            // 
            this.checkBoxCompileRegion.AutoSize = true;
            this.checkBoxCompileRegion.Location = new System.Drawing.Point(18, 22);
            this.checkBoxCompileRegion.Name = "checkBoxCompileRegion";
            this.checkBoxCompileRegion.Size = new System.Drawing.Size(144, 17);
            this.checkBoxCompileRegion.TabIndex = 0;
            this.checkBoxCompileRegion.Text = "Компилировать регион";
            this.checkBoxCompileRegion.UseVisualStyleBackColor = true;
            this.checkBoxCompileRegion.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CompileLightWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 223);
            this.Controls.Add(this.groupBoxRegion);
            this.Controls.Add(this.buttonCompileLightClose);
            this.Controls.Add(this.buttonCompileLight);
            this.Controls.Add(this.groupBoxQuality);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompileLightWin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Компиляция света";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CompileLightWin_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompileLightWin_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CompileLightWin_KeyPress);
            this.groupBoxQuality.ResumeLayout(false);
            this.groupBoxQuality.PerformLayout();
            this.groupBoxRegion.ResumeLayout(false);
            this.groupBoxRegion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxQuality;
        private System.Windows.Forms.RadioButton radioButtonHigh;
        private System.Windows.Forms.RadioButton radioButtonMiddle;
        private System.Windows.Forms.RadioButton radioButtonLow;
        private System.Windows.Forms.RadioButton radioButtonVertex;
        private System.Windows.Forms.Button buttonCompileLight;
        private System.Windows.Forms.Button buttonCompileLightClose;
        private System.Windows.Forms.GroupBox groupBoxRegion;
        private System.Windows.Forms.Label labelMeters;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Label labelAroundCamera;
        private System.Windows.Forms.CheckBox checkBoxCompileRegion;
    }
}