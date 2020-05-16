namespace SpacerUnion.Windows
{
    partial class CameraCoords
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxCloseCamWin = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCamVec2 = new System.Windows.Forms.TextBox();
            this.textBoxCamVec1 = new System.Windows.Forms.TextBox();
            this.textBoxCamVec0 = new System.Windows.Forms.TextBox();
            this.buttonCameraGo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxCloseCamWin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxCamVec2);
            this.panel1.Controls.Add(this.textBoxCamVec1);
            this.panel1.Controls.Add(this.textBoxCamVec0);
            this.panel1.Controls.Add(this.buttonCameraGo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 135);
            this.panel1.TabIndex = 8;
            this.panel1.TabStop = true;
            // 
            // checkBoxCloseCamWin
            // 
            this.checkBoxCloseCamWin.AutoSize = true;
            this.checkBoxCloseCamWin.Checked = true;
            this.checkBoxCloseCamWin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCloseCamWin.Location = new System.Drawing.Point(72, 70);
            this.checkBoxCloseCamWin.Name = "checkBoxCloseCamWin";
            this.checkBoxCloseCamWin.Size = new System.Drawing.Size(180, 17);
            this.checkBoxCloseCamWin.TabIndex = 11;
            this.checkBoxCloseCamWin.Text = "Закрывать окно при переходе";
            this.checkBoxCloseCamWin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "X";
            // 
            // textBoxCamVec2
            // 
            this.textBoxCamVec2.Location = new System.Drawing.Point(198, 37);
            this.textBoxCamVec2.Name = "textBoxCamVec2";
            this.textBoxCamVec2.Size = new System.Drawing.Size(87, 20);
            this.textBoxCamVec2.TabIndex = 10;
            this.textBoxCamVec2.Text = "100";
            // 
            // textBoxCamVec1
            // 
            this.textBoxCamVec1.Location = new System.Drawing.Point(105, 37);
            this.textBoxCamVec1.Name = "textBoxCamVec1";
            this.textBoxCamVec1.Size = new System.Drawing.Size(87, 20);
            this.textBoxCamVec1.TabIndex = 9;
            this.textBoxCamVec1.Text = "100";
            // 
            // textBoxCamVec0
            // 
            this.textBoxCamVec0.Location = new System.Drawing.Point(12, 37);
            this.textBoxCamVec0.Name = "textBoxCamVec0";
            this.textBoxCamVec0.Size = new System.Drawing.Size(87, 20);
            this.textBoxCamVec0.TabIndex = 8;
            this.textBoxCamVec0.Text = "100";
            // 
            // buttonCameraGo
            // 
            this.buttonCameraGo.Location = new System.Drawing.Point(72, 93);
            this.buttonCameraGo.Name = "buttonCameraGo";
            this.buttonCameraGo.Size = new System.Drawing.Size(157, 23);
            this.buttonCameraGo.TabIndex = 12;
            this.buttonCameraGo.Text = "Перейти";
            this.buttonCameraGo.UseVisualStyleBackColor = true;
            // 
            // CameraCoords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 135);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CameraCoords";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Камера";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CameraCoords_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxCloseCamWin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCamVec2;
        private System.Windows.Forms.TextBox textBoxCamVec1;
        private System.Windows.Forms.TextBox textBoxCamVec0;
        private System.Windows.Forms.Button buttonCameraGo;
    }
}