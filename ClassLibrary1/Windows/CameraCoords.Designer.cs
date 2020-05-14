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
            this.buttonCameraGo = new System.Windows.Forms.Button();
            this.textBoxCamVec0 = new System.Windows.Forms.TextBox();
            this.textBoxCamVec1 = new System.Windows.Forms.TextBox();
            this.textBoxCamVec2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxCloseCamWin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonCameraGo
            // 
            this.buttonCameraGo.Location = new System.Drawing.Point(72, 100);
            this.buttonCameraGo.Name = "buttonCameraGo";
            this.buttonCameraGo.Size = new System.Drawing.Size(157, 23);
            this.buttonCameraGo.TabIndex = 3;
            this.buttonCameraGo.Text = "Перейти";
            this.buttonCameraGo.UseVisualStyleBackColor = true;
            this.buttonCameraGo.Click += new System.EventHandler(this.buttonCameraGo_Click);
            // 
            // textBoxCamVec0
            // 
            this.textBoxCamVec0.Location = new System.Drawing.Point(12, 44);
            this.textBoxCamVec0.Name = "textBoxCamVec0";
            this.textBoxCamVec0.Size = new System.Drawing.Size(87, 20);
            this.textBoxCamVec0.TabIndex = 4;
            this.textBoxCamVec0.Text = "100";
            this.textBoxCamVec0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCamVec0_KeyPress);
            // 
            // textBoxCamVec1
            // 
            this.textBoxCamVec1.Location = new System.Drawing.Point(105, 44);
            this.textBoxCamVec1.Name = "textBoxCamVec1";
            this.textBoxCamVec1.Size = new System.Drawing.Size(87, 20);
            this.textBoxCamVec1.TabIndex = 5;
            this.textBoxCamVec1.Text = "100";
            this.textBoxCamVec1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCamVec0_KeyPress);
            // 
            // textBoxCamVec2
            // 
            this.textBoxCamVec2.Location = new System.Drawing.Point(198, 44);
            this.textBoxCamVec2.Name = "textBoxCamVec2";
            this.textBoxCamVec2.Size = new System.Drawing.Size(87, 20);
            this.textBoxCamVec2.TabIndex = 6;
            this.textBoxCamVec2.Text = "100";
            this.textBoxCamVec2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCamVec0_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Z";
            // 
            // checkBoxCloseCamWin
            // 
            this.checkBoxCloseCamWin.AutoSize = true;
            this.checkBoxCloseCamWin.Checked = true;
            this.checkBoxCloseCamWin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCloseCamWin.Location = new System.Drawing.Point(72, 77);
            this.checkBoxCloseCamWin.Name = "checkBoxCloseCamWin";
            this.checkBoxCloseCamWin.Size = new System.Drawing.Size(180, 17);
            this.checkBoxCloseCamWin.TabIndex = 10;
            this.checkBoxCloseCamWin.Text = "Закрывать окно при переходе";
            this.checkBoxCloseCamWin.UseVisualStyleBackColor = true;
            // 
            // CameraCoords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 135);
            this.Controls.Add(this.checkBoxCloseCamWin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCamVec2);
            this.Controls.Add(this.textBoxCamVec1);
            this.Controls.Add(this.textBoxCamVec0);
            this.Controls.Add(this.buttonCameraGo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CameraCoords";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Камера";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CameraCoords_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCameraGo;
        private System.Windows.Forms.TextBox textBoxCamVec0;
        private System.Windows.Forms.TextBox textBoxCamVec1;
        private System.Windows.Forms.TextBox textBoxCamVec2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxCloseCamWin;
    }
}