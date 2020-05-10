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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonHigh = new System.Windows.Forms.RadioButton();
            this.radioButtonMiddle = new System.Windows.Forms.RadioButton();
            this.radioButtonLow = new System.Windows.Forms.RadioButton();
            this.radioButtonVertex = new System.Windows.Forms.RadioButton();
            this.buttonCompileLight = new System.Windows.Forms.Button();
            this.buttonCompileLightClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxCompileRegion = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonHigh);
            this.groupBox1.Controls.Add(this.radioButtonMiddle);
            this.groupBox1.Controls.Add(this.radioButtonLow);
            this.groupBox1.Controls.Add(this.radioButtonVertex);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Качество";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxRadius);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkBoxCompileRegion);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 109);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Регион";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "метров";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "вокруг камеры";
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
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonCompileLightClose);
            this.Controls.Add(this.buttonCompileLight);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompileLightWin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Компиляция света";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonHigh;
        private System.Windows.Forms.RadioButton radioButtonMiddle;
        private System.Windows.Forms.RadioButton radioButtonLow;
        private System.Windows.Forms.RadioButton radioButtonVertex;
        private System.Windows.Forms.Button buttonCompileLight;
        private System.Windows.Forms.Button buttonCompileLightClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxCompileRegion;
    }
}