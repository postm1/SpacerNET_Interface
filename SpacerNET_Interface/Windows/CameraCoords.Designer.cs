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
            this.buttonSetCurrentCoords = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCamPos = new System.Windows.Forms.Label();
            this.labelCamRot = new System.Windows.Forms.Label();
            this.labelPitch = new System.Windows.Forms.Label();
            this.labelYaw = new System.Windows.Forms.Label();
            this.textBoxCamPitch = new System.Windows.Forms.TextBox();
            this.textBoxCamYaw = new System.Windows.Forms.TextBox();
            this.buttonGetFrom = new System.Windows.Forms.Button();
            this.checkBoxCloseCamWin = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCamVec2 = new System.Windows.Forms.TextBox();
            this.textBoxCamVec1 = new System.Windows.Forms.TextBox();
            this.textBoxCamVec0 = new System.Windows.Forms.TextBox();
            this.buttonCameraGo = new System.Windows.Forms.Button();
            this.buttonSetClipboard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSetClipboard);
            this.panel1.Controls.Add(this.buttonSetCurrentCoords);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelCamPos);
            this.panel1.Controls.Add(this.labelCamRot);
            this.panel1.Controls.Add(this.labelPitch);
            this.panel1.Controls.Add(this.labelYaw);
            this.panel1.Controls.Add(this.textBoxCamPitch);
            this.panel1.Controls.Add(this.textBoxCamYaw);
            this.panel1.Controls.Add(this.buttonGetFrom);
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
            this.panel1.Size = new System.Drawing.Size(401, 242);
            this.panel1.TabIndex = 8;
            this.panel1.TabStop = true;
            // 
            // buttonSetCurrentCoords
            // 
            this.buttonSetCurrentCoords.Location = new System.Drawing.Point(103, 106);
            this.buttonSetCurrentCoords.Name = "buttonSetCurrentCoords";
            this.buttonSetCurrentCoords.Size = new System.Drawing.Size(273, 23);
            this.buttonSetCurrentCoords.TabIndex = 24;
            this.buttonSetCurrentCoords.Text = "Input current coordinates";
            this.buttonSetCurrentCoords.UseVisualStyleBackColor = true;
            this.buttonSetCurrentCoords.Click += new System.EventHandler(this.buttonSetCurrentCoords_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(96, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 160);
            this.panel2.TabIndex = 23;
            // 
            // labelCamPos
            // 
            this.labelCamPos.AutoSize = true;
            this.labelCamPos.Location = new System.Drawing.Point(194, 9);
            this.labelCamPos.Name = "labelCamPos";
            this.labelCamPos.Size = new System.Drawing.Size(85, 13);
            this.labelCamPos.TabIndex = 22;
            this.labelCamPos.Text = "Camera position:";
            // 
            // labelCamRot
            // 
            this.labelCamRot.AutoSize = true;
            this.labelCamRot.Location = new System.Drawing.Point(6, 9);
            this.labelCamRot.Name = "labelCamRot";
            this.labelCamRot.Size = new System.Drawing.Size(84, 13);
            this.labelCamRot.TabIndex = 21;
            this.labelCamRot.Text = "Camera rotation:";
            // 
            // labelPitch
            // 
            this.labelPitch.AutoSize = true;
            this.labelPitch.Location = new System.Drawing.Point(6, 79);
            this.labelPitch.Name = "labelPitch";
            this.labelPitch.Size = new System.Drawing.Size(31, 13);
            this.labelPitch.TabIndex = 20;
            this.labelPitch.Text = "Pitch";
            // 
            // labelYaw
            // 
            this.labelYaw.AutoSize = true;
            this.labelYaw.Location = new System.Drawing.Point(6, 35);
            this.labelYaw.Name = "labelYaw";
            this.labelYaw.Size = new System.Drawing.Size(28, 13);
            this.labelYaw.TabIndex = 19;
            this.labelYaw.Text = "Yaw";
            // 
            // textBoxCamPitch
            // 
            this.textBoxCamPitch.Location = new System.Drawing.Point(9, 95);
            this.textBoxCamPitch.Name = "textBoxCamPitch";
            this.textBoxCamPitch.Size = new System.Drawing.Size(50, 20);
            this.textBoxCamPitch.TabIndex = 18;
            this.textBoxCamPitch.Text = "0";
            // 
            // textBoxCamYaw
            // 
            this.textBoxCamYaw.Location = new System.Drawing.Point(9, 51);
            this.textBoxCamYaw.Name = "textBoxCamYaw";
            this.textBoxCamYaw.Size = new System.Drawing.Size(50, 20);
            this.textBoxCamYaw.TabIndex = 17;
            this.textBoxCamYaw.Text = "0";
            // 
            // buttonGetFrom
            // 
            this.buttonGetFrom.Location = new System.Drawing.Point(103, 77);
            this.buttonGetFrom.Name = "buttonGetFrom";
            this.buttonGetFrom.Size = new System.Drawing.Size(273, 23);
            this.buttonGetFrom.TabIndex = 16;
            this.buttonGetFrom.Text = "Get from clipboard";
            this.buttonGetFrom.UseVisualStyleBackColor = true;
            this.buttonGetFrom.Click += new System.EventHandler(this.buttonGetFrom_Click);
            // 
            // checkBoxCloseCamWin
            // 
            this.checkBoxCloseCamWin.AutoSize = true;
            this.checkBoxCloseCamWin.Checked = true;
            this.checkBoxCloseCamWin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCloseCamWin.Location = new System.Drawing.Point(141, 184);
            this.checkBoxCloseCamWin.Name = "checkBoxCloseCamWin";
            this.checkBoxCloseCamWin.Size = new System.Drawing.Size(176, 17);
            this.checkBoxCloseCamWin.TabIndex = 11;
            this.checkBoxCloseCamWin.Text = "Close the window after the jump";
            this.checkBoxCloseCamWin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "X";
            // 
            // textBoxCamVec2
            // 
            this.textBoxCamVec2.Location = new System.Drawing.Point(289, 51);
            this.textBoxCamVec2.Name = "textBoxCamVec2";
            this.textBoxCamVec2.Size = new System.Drawing.Size(87, 20);
            this.textBoxCamVec2.TabIndex = 10;
            this.textBoxCamVec2.Text = "100";
            this.textBoxCamVec2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCamVec0_KeyPress_1);
            // 
            // textBoxCamVec1
            // 
            this.textBoxCamVec1.Location = new System.Drawing.Point(196, 51);
            this.textBoxCamVec1.Name = "textBoxCamVec1";
            this.textBoxCamVec1.Size = new System.Drawing.Size(87, 20);
            this.textBoxCamVec1.TabIndex = 9;
            this.textBoxCamVec1.Text = "100";
            this.textBoxCamVec1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCamVec0_KeyPress_1);
            // 
            // textBoxCamVec0
            // 
            this.textBoxCamVec0.Location = new System.Drawing.Point(103, 51);
            this.textBoxCamVec0.Name = "textBoxCamVec0";
            this.textBoxCamVec0.Size = new System.Drawing.Size(87, 20);
            this.textBoxCamVec0.TabIndex = 8;
            this.textBoxCamVec0.Text = "100";
            this.textBoxCamVec0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCamVec0_KeyPress_1);
            // 
            // buttonCameraGo
            // 
            this.buttonCameraGo.Location = new System.Drawing.Point(141, 207);
            this.buttonCameraGo.Name = "buttonCameraGo";
            this.buttonCameraGo.Size = new System.Drawing.Size(157, 23);
            this.buttonCameraGo.TabIndex = 12;
            this.buttonCameraGo.Text = "Jump";
            this.buttonCameraGo.UseVisualStyleBackColor = true;
            this.buttonCameraGo.Click += new System.EventHandler(this.buttonCameraGo_Click);
            // 
            // buttonSetClipboard
            // 
            this.buttonSetClipboard.Location = new System.Drawing.Point(103, 135);
            this.buttonSetClipboard.Name = "buttonSetClipboard";
            this.buttonSetClipboard.Size = new System.Drawing.Size(273, 23);
            this.buttonSetClipboard.TabIndex = 25;
            this.buttonSetClipboard.Text = "Copy current coords into clipboard";
            this.buttonSetClipboard.UseVisualStyleBackColor = true;
            this.buttonSetClipboard.Click += new System.EventHandler(this.buttonSetClipboard_Click);
            // 
            // CameraCoords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 242);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CameraCoords";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CameraCoords_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CameraCoords_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CameraCoords_KeyPress);
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
        private System.Windows.Forms.Button buttonGetFrom;
        private System.Windows.Forms.Label labelPitch;
        private System.Windows.Forms.Label labelYaw;
        private System.Windows.Forms.TextBox textBoxCamPitch;
        private System.Windows.Forms.TextBox textBoxCamYaw;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCamPos;
        private System.Windows.Forms.Label labelCamRot;
        private System.Windows.Forms.Button buttonSetCurrentCoords;
        private System.Windows.Forms.Button buttonSetClipboard;
    }
}