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
            this.textBoxSnd = new System.Windows.Forms.TextBox();
            this.labelSndList = new System.Windows.Forms.Label();
            this.labelAllSounds = new System.Windows.Forms.Label();
            this.groupBoxSound = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxShutSounds = new System.Windows.Forms.CheckBox();
            this.checkBoxConstSound = new System.Windows.Forms.CheckBox();
            this.listBoxSndResult = new System.Windows.Forms.ListBox();
            this.buttonStopAllSounds = new System.Windows.Forms.Button();
            this.groupBoxMusic = new System.Windows.Forms.GroupBox();
            this.listBoxMusic = new System.Windows.Forms.ListBox();
            this.checkBoxShutMusic = new System.Windows.Forms.CheckBox();
            this.buttonMusicOn = new System.Windows.Forms.Button();
            this.labelMusicVolume = new System.Windows.Forms.Label();
            this.trackBarMusicVolume = new System.Windows.Forms.TrackBar();
            this.buttonOffMusic = new System.Windows.Forms.Button();
            this.groupBoxSound.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusicVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlaySound
            // 
            this.buttonPlaySound.Location = new System.Drawing.Point(6, 19);
            this.buttonPlaySound.Name = "buttonPlaySound";
            this.buttonPlaySound.Size = new System.Drawing.Size(206, 32);
            this.buttonPlaySound.TabIndex = 0;
            this.buttonPlaySound.Text = "Play";
            this.buttonPlaySound.UseVisualStyleBackColor = true;
            this.buttonPlaySound.Click += new System.EventHandler(this.buttonPlaySound_Click);
            // 
            // listBoxSound
            // 
            this.listBoxSound.FormattingEnabled = true;
            this.listBoxSound.HorizontalScrollbar = true;
            this.listBoxSound.Location = new System.Drawing.Point(9, 77);
            this.listBoxSound.Name = "listBoxSound";
            this.listBoxSound.ScrollAlwaysVisible = true;
            this.listBoxSound.Size = new System.Drawing.Size(223, 238);
            this.listBoxSound.TabIndex = 1;
            this.listBoxSound.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxSound_MouseDoubleClick);
            this.listBoxSound.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxSound_MouseDown);
            // 
            // textBoxSnd
            // 
            this.textBoxSnd.Location = new System.Drawing.Point(238, 142);
            this.textBoxSnd.Name = "textBoxSnd";
            this.textBoxSnd.Size = new System.Drawing.Size(215, 20);
            this.textBoxSnd.TabIndex = 5;
            this.textBoxSnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSnd_KeyPress);
            // 
            // labelSndList
            // 
            this.labelSndList.AutoSize = true;
            this.labelSndList.Location = new System.Drawing.Point(233, 126);
            this.labelSndList.Name = "labelSndList";
            this.labelSndList.Size = new System.Drawing.Size(98, 13);
            this.labelSndList.TabIndex = 6;
            this.labelSndList.Text = "Search using regex";
            // 
            // labelAllSounds
            // 
            this.labelAllSounds.AutoSize = true;
            this.labelAllSounds.Location = new System.Drawing.Point(9, 61);
            this.labelAllSounds.Name = "labelAllSounds";
            this.labelAllSounds.Size = new System.Drawing.Size(96, 13);
            this.labelAllSounds.TabIndex = 7;
            this.labelAllSounds.Text = "All sound. Count: 0";
            // 
            // groupBoxSound
            // 
            this.groupBoxSound.Controls.Add(this.panel1);
            this.groupBoxSound.Controls.Add(this.listBoxSndResult);
            this.groupBoxSound.Controls.Add(this.buttonPlaySound);
            this.groupBoxSound.Controls.Add(this.buttonStopAllSounds);
            this.groupBoxSound.Controls.Add(this.labelAllSounds);
            this.groupBoxSound.Controls.Add(this.labelSndList);
            this.groupBoxSound.Controls.Add(this.listBoxSound);
            this.groupBoxSound.Controls.Add(this.textBoxSnd);
            this.groupBoxSound.Location = new System.Drawing.Point(3, 2);
            this.groupBoxSound.Name = "groupBoxSound";
            this.groupBoxSound.Size = new System.Drawing.Size(460, 324);
            this.groupBoxSound.TabIndex = 8;
            this.groupBoxSound.TabStop = false;
            this.groupBoxSound.Text = "Sounds";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxShutSounds);
            this.panel1.Controls.Add(this.checkBoxConstSound);
            this.panel1.Location = new System.Drawing.Point(238, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 53);
            this.panel1.TabIndex = 16;
            // 
            // checkBoxShutSounds
            // 
            this.checkBoxShutSounds.AutoSize = true;
            this.checkBoxShutSounds.Location = new System.Drawing.Point(3, 4);
            this.checkBoxShutSounds.Name = "checkBoxShutSounds";
            this.checkBoxShutSounds.Size = new System.Drawing.Size(172, 17);
            this.checkBoxShutSounds.TabIndex = 13;
            this.checkBoxShutSounds.Text = "Shut sounds after world loaded";
            this.checkBoxShutSounds.UseVisualStyleBackColor = true;
            this.checkBoxShutSounds.CheckedChanged += new System.EventHandler(this.checkBoxShutSounds_CheckedChanged);
            // 
            // checkBoxConstSound
            // 
            this.checkBoxConstSound.AutoSize = true;
            this.checkBoxConstSound.Location = new System.Drawing.Point(3, 28);
            this.checkBoxConstSound.Name = "checkBoxConstSound";
            this.checkBoxConstSound.Size = new System.Drawing.Size(132, 17);
            this.checkBoxConstSound.TabIndex = 14;
            this.checkBoxConstSound.Text = "Always shut all sounds";
            this.checkBoxConstSound.UseVisualStyleBackColor = true;
            this.checkBoxConstSound.CheckedChanged += new System.EventHandler(this.checkBoxConstSound_CheckedChanged);
            // 
            // listBoxSndResult
            // 
            this.listBoxSndResult.FormattingEnabled = true;
            this.listBoxSndResult.Location = new System.Drawing.Point(238, 168);
            this.listBoxSndResult.Name = "listBoxSndResult";
            this.listBoxSndResult.Size = new System.Drawing.Size(215, 147);
            this.listBoxSndResult.TabIndex = 15;
            this.listBoxSndResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBoxSndResult_KeyPress_1);
            this.listBoxSndResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxSndResult_MouseDoubleClick);
            this.listBoxSndResult.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxSndResult_MouseDown);
            // 
            // buttonStopAllSounds
            // 
            this.buttonStopAllSounds.Location = new System.Drawing.Point(238, 19);
            this.buttonStopAllSounds.Name = "buttonStopAllSounds";
            this.buttonStopAllSounds.Size = new System.Drawing.Size(215, 32);
            this.buttonStopAllSounds.TabIndex = 2;
            this.buttonStopAllSounds.Text = "Turn off all sounds";
            this.buttonStopAllSounds.UseVisualStyleBackColor = true;
            this.buttonStopAllSounds.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxMusic
            // 
            this.groupBoxMusic.Controls.Add(this.listBoxMusic);
            this.groupBoxMusic.Controls.Add(this.checkBoxShutMusic);
            this.groupBoxMusic.Controls.Add(this.buttonMusicOn);
            this.groupBoxMusic.Controls.Add(this.labelMusicVolume);
            this.groupBoxMusic.Controls.Add(this.trackBarMusicVolume);
            this.groupBoxMusic.Controls.Add(this.buttonOffMusic);
            this.groupBoxMusic.Location = new System.Drawing.Point(469, 2);
            this.groupBoxMusic.Name = "groupBoxMusic";
            this.groupBoxMusic.Size = new System.Drawing.Size(205, 324);
            this.groupBoxMusic.TabIndex = 9;
            this.groupBoxMusic.TabStop = false;
            this.groupBoxMusic.Text = "Music";
            // 
            // listBoxMusic
            // 
            this.listBoxMusic.FormattingEnabled = true;
            this.listBoxMusic.Location = new System.Drawing.Point(10, 168);
            this.listBoxMusic.Name = "listBoxMusic";
            this.listBoxMusic.Size = new System.Drawing.Size(188, 147);
            this.listBoxMusic.TabIndex = 8;
            this.listBoxMusic.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxMusic_MouseDoubleClick);
            this.listBoxMusic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxMusic_MouseDown);
            // 
            // checkBoxShutMusic
            // 
            this.checkBoxShutMusic.AutoSize = true;
            this.checkBoxShutMusic.Location = new System.Drawing.Point(10, 99);
            this.checkBoxShutMusic.Name = "checkBoxShutMusic";
            this.checkBoxShutMusic.Size = new System.Drawing.Size(165, 17);
            this.checkBoxShutMusic.TabIndex = 12;
            this.checkBoxShutMusic.Text = "Shut music after world loaded";
            this.checkBoxShutMusic.UseVisualStyleBackColor = true;
            // 
            // buttonMusicOn
            // 
            this.buttonMusicOn.Location = new System.Drawing.Point(10, 61);
            this.buttonMusicOn.Name = "buttonMusicOn";
            this.buttonMusicOn.Size = new System.Drawing.Size(188, 32);
            this.buttonMusicOn.TabIndex = 11;
            this.buttonMusicOn.Text = "Turn on music";
            this.buttonMusicOn.UseVisualStyleBackColor = true;
            this.buttonMusicOn.Click += new System.EventHandler(this.buttonMusicOn_Click);
            // 
            // labelMusicVolume
            // 
            this.labelMusicVolume.AutoSize = true;
            this.labelMusicVolume.Location = new System.Drawing.Point(7, 131);
            this.labelMusicVolume.Name = "labelMusicVolume";
            this.labelMusicVolume.Size = new System.Drawing.Size(59, 13);
            this.labelMusicVolume.TabIndex = 10;
            this.labelMusicVolume.Text = "Volume 0%";
            // 
            // trackBarMusicVolume
            // 
            this.trackBarMusicVolume.Location = new System.Drawing.Point(84, 130);
            this.trackBarMusicVolume.Maximum = 100;
            this.trackBarMusicVolume.Name = "trackBarMusicVolume";
            this.trackBarMusicVolume.Size = new System.Drawing.Size(111, 45);
            this.trackBarMusicVolume.TabIndex = 9;
            this.trackBarMusicVolume.ValueChanged += new System.EventHandler(this.trackBarMusicVoluem_ValueChanged);
            // 
            // buttonOffMusic
            // 
            this.buttonOffMusic.Location = new System.Drawing.Point(10, 19);
            this.buttonOffMusic.Name = "buttonOffMusic";
            this.buttonOffMusic.Size = new System.Drawing.Size(188, 32);
            this.buttonOffMusic.TabIndex = 8;
            this.buttonOffMusic.Text = "Turn off music";
            this.buttonOffMusic.UseVisualStyleBackColor = true;
            this.buttonOffMusic.Click += new System.EventHandler(this.buttonOffMusic_Click);
            // 
            // SoundWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 329);
            this.Controls.Add(this.groupBoxMusic);
            this.Controls.Add(this.groupBoxSound);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SoundWin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sounds and music window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SoundWin_FormClosing);
            this.Shown += new System.EventHandler(this.SoundWin_Shown);
            this.groupBoxSound.ResumeLayout(false);
            this.groupBoxSound.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxMusic.ResumeLayout(false);
            this.groupBoxMusic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusicVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlaySound;
        private System.Windows.Forms.TextBox textBoxSnd;
        private System.Windows.Forms.Label labelSndList;
        private System.Windows.Forms.Label labelAllSounds;
        private System.Windows.Forms.GroupBox groupBoxSound;
        public System.Windows.Forms.ListBox listBoxSound;
        private System.Windows.Forms.GroupBox groupBoxMusic;
        private System.Windows.Forms.Button buttonOffMusic;
        private System.Windows.Forms.Label labelMusicVolume;
        public System.Windows.Forms.TrackBar trackBarMusicVolume;
        private System.Windows.Forms.Button buttonMusicOn;
        public System.Windows.Forms.CheckBox checkBoxShutMusic;
        public System.Windows.Forms.ListBox listBoxMusic;
        public System.Windows.Forms.CheckBox checkBoxConstSound;
        public System.Windows.Forms.CheckBox checkBoxShutSounds;
        private System.Windows.Forms.Button buttonStopAllSounds;
        public System.Windows.Forms.ListBox listBoxSndResult;
        private System.Windows.Forms.Panel panel1;
    }
}