namespace SpacerUnion
{
    partial class SoundWin
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
            this.buttonPlaySound = new System.Windows.Forms.Button();
            this.listBoxSound = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonPlaySound
            // 
            this.buttonPlaySound.Location = new System.Drawing.Point(79, 251);
            this.buttonPlaySound.Name = "buttonPlaySound";
            this.buttonPlaySound.Size = new System.Drawing.Size(150, 32);
            this.buttonPlaySound.TabIndex = 0;
            this.buttonPlaySound.Text = "Воспроизвести";
            this.buttonPlaySound.UseVisualStyleBackColor = true;
            this.buttonPlaySound.Click += new System.EventHandler(this.buttonPlaySound_Click);
            // 
            // listBoxSound
            // 
            this.listBoxSound.FormattingEnabled = true;
            this.listBoxSound.Location = new System.Drawing.Point(12, 6);
            this.listBoxSound.Name = "listBoxSound";
            this.listBoxSound.Size = new System.Drawing.Size(289, 238);
            this.listBoxSound.TabIndex = 1;
            // 
            // SoundWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 291);
            this.Controls.Add(this.listBoxSound);
            this.Controls.Add(this.buttonPlaySound);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SoundWin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Игровые звуки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SoundWin_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlaySound;
        private System.Windows.Forms.ListBox listBoxSound;
    }
}