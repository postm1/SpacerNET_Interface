namespace SpacerUnion
{
    partial class CompileWorldWin
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
            this.radioButtonOutdoor = new System.Windows.Forms.RadioButton();
            this.radioButtonIndoor = new System.Windows.Forms.RadioButton();
            this.buttonCompileCancel = new System.Windows.Forms.Button();
            this.buttonCompileWorld = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonOutdoor);
            this.groupBox1.Controls.Add(this.radioButtonIndoor);
            this.groupBox1.Location = new System.Drawing.Point(174, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип локации";
            // 
            // radioButtonOutdoor
            // 
            this.radioButtonOutdoor.AutoSize = true;
            this.radioButtonOutdoor.Location = new System.Drawing.Point(21, 42);
            this.radioButtonOutdoor.Name = "radioButtonOutdoor";
            this.radioButtonOutdoor.Size = new System.Drawing.Size(63, 17);
            this.radioButtonOutdoor.TabIndex = 1;
            this.radioButtonOutdoor.Text = "Outdoor";
            this.radioButtonOutdoor.UseVisualStyleBackColor = true;
            this.radioButtonOutdoor.CheckedChanged += new System.EventHandler(this.radioButtonOutdoor_CheckedChanged);
            // 
            // radioButtonIndoor
            // 
            this.radioButtonIndoor.AutoSize = true;
            this.radioButtonIndoor.Checked = true;
            this.radioButtonIndoor.Location = new System.Drawing.Point(21, 19);
            this.radioButtonIndoor.Name = "radioButtonIndoor";
            this.radioButtonIndoor.Size = new System.Drawing.Size(55, 17);
            this.radioButtonIndoor.TabIndex = 0;
            this.radioButtonIndoor.TabStop = true;
            this.radioButtonIndoor.Text = "Indoor";
            this.radioButtonIndoor.UseVisualStyleBackColor = true;
            this.radioButtonIndoor.CheckedChanged += new System.EventHandler(this.radioButtonIndoor_CheckedChanged);
            // 
            // buttonCompileCancel
            // 
            this.buttonCompileCancel.Location = new System.Drawing.Point(12, 103);
            this.buttonCompileCancel.Name = "buttonCompileCancel";
            this.buttonCompileCancel.Size = new System.Drawing.Size(157, 23);
            this.buttonCompileCancel.TabIndex = 1;
            this.buttonCompileCancel.Text = "Отмена";
            this.buttonCompileCancel.UseVisualStyleBackColor = true;
            this.buttonCompileCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCompileWorld
            // 
            this.buttonCompileWorld.Location = new System.Drawing.Point(175, 103);
            this.buttonCompileWorld.Name = "buttonCompileWorld";
            this.buttonCompileWorld.Size = new System.Drawing.Size(157, 23);
            this.buttonCompileWorld.TabIndex = 2;
            this.buttonCompileWorld.Text = "Компилировать";
            this.buttonCompileWorld.UseVisualStyleBackColor = true;
            this.buttonCompileWorld.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(10, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 67);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // CompileWorldWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 138);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonCompileWorld);
            this.Controls.Add(this.buttonCompileCancel);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompileWorldWin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Компиляция мира";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CompileWorldWin_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompileWorldWin_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonOutdoor;
        private System.Windows.Forms.RadioButton radioButtonIndoor;
        private System.Windows.Forms.Button buttonCompileCancel;
        private System.Windows.Forms.Button buttonCompileWorld;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}