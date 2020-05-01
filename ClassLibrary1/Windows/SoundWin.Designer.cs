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
            this.buttonStopAllSounds = new System.Windows.Forms.Button();
            this.buttonPlaySoundRegex = new System.Windows.Forms.Button();
            this.listBoxSndResult = new System.Windows.Forms.ListBox();
            this.textBoxSnd = new System.Windows.Forms.TextBox();
            this.labelSndList = new System.Windows.Forms.Label();
            this.labelAllSounds = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlaySound
            // 
            this.buttonPlaySound.Location = new System.Drawing.Point(6, 19);
            this.buttonPlaySound.Name = "buttonPlaySound";
            this.buttonPlaySound.Size = new System.Drawing.Size(174, 32);
            this.buttonPlaySound.TabIndex = 0;
            this.buttonPlaySound.Text = "Воспроизвести";
            this.buttonPlaySound.UseVisualStyleBackColor = true;
            this.buttonPlaySound.Click += new System.EventHandler(this.buttonPlaySound_Click);
            // 
            // listBoxSound
            // 
            this.listBoxSound.FormattingEnabled = true;
            this.listBoxSound.Location = new System.Drawing.Point(6, 82);
            this.listBoxSound.Name = "listBoxSound";
            this.listBoxSound.Size = new System.Drawing.Size(174, 199);
            this.listBoxSound.TabIndex = 1;
            // 
            // buttonStopAllSounds
            // 
            this.buttonStopAllSounds.Location = new System.Drawing.Point(119, 296);
            this.buttonStopAllSounds.Name = "buttonStopAllSounds";
            this.buttonStopAllSounds.Size = new System.Drawing.Size(150, 32);
            this.buttonStopAllSounds.TabIndex = 2;
            this.buttonStopAllSounds.Text = "Заглушить все звуки";
            this.buttonStopAllSounds.UseVisualStyleBackColor = true;
            this.buttonStopAllSounds.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPlaySoundRegex
            // 
            this.buttonPlaySoundRegex.Location = new System.Drawing.Point(211, 19);
            this.buttonPlaySoundRegex.Name = "buttonPlaySoundRegex";
            this.buttonPlaySoundRegex.Size = new System.Drawing.Size(188, 32);
            this.buttonPlaySoundRegex.TabIndex = 3;
            this.buttonPlaySoundRegex.Text = "Воспроизвести";
            this.buttonPlaySoundRegex.UseVisualStyleBackColor = true;
            this.buttonPlaySoundRegex.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxSndResult
            // 
            this.listBoxSndResult.FormattingEnabled = true;
            this.listBoxSndResult.Location = new System.Drawing.Point(211, 108);
            this.listBoxSndResult.Name = "listBoxSndResult";
            this.listBoxSndResult.Size = new System.Drawing.Size(188, 173);
            this.listBoxSndResult.TabIndex = 4;
            // 
            // textBoxSnd
            // 
            this.textBoxSnd.Location = new System.Drawing.Point(211, 82);
            this.textBoxSnd.Name = "textBoxSnd";
            this.textBoxSnd.Size = new System.Drawing.Size(188, 20);
            this.textBoxSnd.TabIndex = 5;
            this.textBoxSnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSnd_KeyPress);
            // 
            // labelSndList
            // 
            this.labelSndList.AutoSize = true;
            this.labelSndList.Location = new System.Drawing.Point(208, 61);
            this.labelSndList.Name = "labelSndList";
            this.labelSndList.Size = new System.Drawing.Size(140, 13);
            this.labelSndList.TabIndex = 6;
            this.labelSndList.Text = "Поиск по рег. выражению";
            // 
            // labelAllSounds
            // 
            this.labelAllSounds.AutoSize = true;
            this.labelAllSounds.Location = new System.Drawing.Point(6, 61);
            this.labelAllSounds.Name = "labelAllSounds";
            this.labelAllSounds.Size = new System.Drawing.Size(86, 13);
            this.labelAllSounds.TabIndex = 7;
            this.labelAllSounds.Text = "Все звуки игры";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPlaySound);
            this.groupBox1.Controls.Add(this.labelAllSounds);
            this.groupBox1.Controls.Add(this.buttonPlaySoundRegex);
            this.groupBox1.Controls.Add(this.labelSndList);
            this.groupBox1.Controls.Add(this.listBoxSound);
            this.groupBox1.Controls.Add(this.textBoxSnd);
            this.groupBox1.Controls.Add(this.buttonStopAllSounds);
            this.groupBox1.Controls.Add(this.listBoxSndResult);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 342);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Звуки";
            // 
            // SoundWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 366);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SoundWin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Игровые звуки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SoundWin_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlaySound;
        private System.Windows.Forms.Button buttonStopAllSounds;
        private System.Windows.Forms.Button buttonPlaySoundRegex;
        private System.Windows.Forms.ListBox listBoxSndResult;
        private System.Windows.Forms.TextBox textBoxSnd;
        private System.Windows.Forms.Label labelSndList;
        private System.Windows.Forms.Label labelAllSounds;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListBox listBoxSound;
    }
}