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
            this.groupBoxMusic = new System.Windows.Forms.GroupBox();
            this.listBoxMusic = new System.Windows.Forms.ListBox();
            this.checkBoxShutMusic = new System.Windows.Forms.CheckBox();
            this.buttonMusicOn = new System.Windows.Forms.Button();
            this.labelMusicVolume = new System.Windows.Forms.Label();
            this.trackBarMusicVolume = new System.Windows.Forms.TrackBar();
            this.buttonOffMusic = new System.Windows.Forms.Button();
            this.buttonStopAllSounds = new System.Windows.Forms.Button();
            this.checkBoxShutSounds = new System.Windows.Forms.CheckBox();
            this.checkBoxConstSound = new System.Windows.Forms.CheckBox();
            this.groupBoxSound.SuspendLayout();
            this.groupBoxMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusicVolume)).BeginInit();
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
            this.listBoxSound.Location = new System.Drawing.Point(9, 86);
            this.listBoxSound.Name = "listBoxSound";
            this.listBoxSound.Size = new System.Drawing.Size(171, 225);
            this.listBoxSound.TabIndex = 1;
            this.listBoxSound.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxSound_MouseDoubleClick);
            // 
            // textBoxSnd
            // 
            this.textBoxSnd.Location = new System.Drawing.Point(9, 99);
            this.textBoxSnd.Name = "textBoxSnd";
            this.textBoxSnd.Size = new System.Drawing.Size(171, 20);
            this.textBoxSnd.TabIndex = 5;
            this.textBoxSnd.Visible = false;
            // 
            // labelSndList
            // 
            this.labelSndList.AutoSize = true;
            this.labelSndList.Location = new System.Drawing.Point(9, 83);
            this.labelSndList.Name = "labelSndList";
            this.labelSndList.Size = new System.Drawing.Size(140, 13);
            this.labelSndList.TabIndex = 6;
            this.labelSndList.Text = "Поиск по рег. выражению";
            this.labelSndList.Visible = false;
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
            // groupBoxSound
            // 
            this.groupBoxSound.Controls.Add(this.checkBoxConstSound);
            this.groupBoxSound.Controls.Add(this.checkBoxShutSounds);
            this.groupBoxSound.Controls.Add(this.buttonPlaySound);
            this.groupBoxSound.Controls.Add(this.buttonStopAllSounds);
            this.groupBoxSound.Controls.Add(this.labelAllSounds);
            this.groupBoxSound.Controls.Add(this.labelSndList);
            this.groupBoxSound.Controls.Add(this.listBoxSound);
            this.groupBoxSound.Controls.Add(this.textBoxSnd);
            this.groupBoxSound.Location = new System.Drawing.Point(3, 2);
            this.groupBoxSound.Name = "groupBoxSound";
            this.groupBoxSound.Size = new System.Drawing.Size(383, 317);
            this.groupBoxSound.TabIndex = 8;
            this.groupBoxSound.TabStop = false;
            this.groupBoxSound.Text = "Звуки";
            // 
            // groupBoxMusic
            // 
            this.groupBoxMusic.Controls.Add(this.listBoxMusic);
            this.groupBoxMusic.Controls.Add(this.checkBoxShutMusic);
            this.groupBoxMusic.Controls.Add(this.buttonMusicOn);
            this.groupBoxMusic.Controls.Add(this.labelMusicVolume);
            this.groupBoxMusic.Controls.Add(this.trackBarMusicVolume);
            this.groupBoxMusic.Controls.Add(this.buttonOffMusic);
            this.groupBoxMusic.Location = new System.Drawing.Point(392, 2);
            this.groupBoxMusic.Name = "groupBoxMusic";
            this.groupBoxMusic.Size = new System.Drawing.Size(228, 317);
            this.groupBoxMusic.TabIndex = 9;
            this.groupBoxMusic.TabStop = false;
            this.groupBoxMusic.Text = "Музыка";
            // 
            // listBoxMusic
            // 
            this.listBoxMusic.FormattingEnabled = true;
            this.listBoxMusic.Location = new System.Drawing.Point(10, 171);
            this.listBoxMusic.Name = "listBoxMusic";
            this.listBoxMusic.Size = new System.Drawing.Size(195, 134);
            this.listBoxMusic.TabIndex = 8;
            this.listBoxMusic.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxMusic_MouseDoubleClick);
            // 
            // checkBoxShutMusic
            // 
            this.checkBoxShutMusic.AutoSize = true;
            this.checkBoxShutMusic.Location = new System.Drawing.Point(10, 99);
            this.checkBoxShutMusic.Name = "checkBoxShutMusic";
            this.checkBoxShutMusic.Size = new System.Drawing.Size(195, 17);
            this.checkBoxShutMusic.TabIndex = 12;
            this.checkBoxShutMusic.Text = "Отключать музыку при загрузке ";
            this.checkBoxShutMusic.UseVisualStyleBackColor = true;
            this.checkBoxShutMusic.CheckedChanged += new System.EventHandler(this.checkBoxShutMusic_CheckedChanged);
            this.checkBoxShutMusic.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.checkBoxShutMusic_ChangeUICues);
            // 
            // buttonMusicOn
            // 
            this.buttonMusicOn.Location = new System.Drawing.Point(10, 61);
            this.buttonMusicOn.Name = "buttonMusicOn";
            this.buttonMusicOn.Size = new System.Drawing.Size(195, 32);
            this.buttonMusicOn.TabIndex = 11;
            this.buttonMusicOn.Text = "Включить музыку";
            this.buttonMusicOn.UseVisualStyleBackColor = true;
            this.buttonMusicOn.Click += new System.EventHandler(this.buttonMusicOn_Click);
            // 
            // labelMusicVolume
            // 
            this.labelMusicVolume.AutoSize = true;
            this.labelMusicVolume.Location = new System.Drawing.Point(7, 131);
            this.labelMusicVolume.Name = "labelMusicVolume";
            this.labelMusicVolume.Size = new System.Drawing.Size(62, 13);
            this.labelMusicVolume.TabIndex = 10;
            this.labelMusicVolume.Text = "Громкость";
            // 
            // trackBarMusicVolume
            // 
            this.trackBarMusicVolume.Location = new System.Drawing.Point(87, 131);
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
            this.buttonOffMusic.Size = new System.Drawing.Size(195, 32);
            this.buttonOffMusic.TabIndex = 8;
            this.buttonOffMusic.Text = "Отключить музыку";
            this.buttonOffMusic.UseVisualStyleBackColor = true;
            this.buttonOffMusic.Click += new System.EventHandler(this.buttonOffMusic_Click);
            // 
            // buttonStopAllSounds
            // 
            this.buttonStopAllSounds.Location = new System.Drawing.Point(196, 19);
            this.buttonStopAllSounds.Name = "buttonStopAllSounds";
            this.buttonStopAllSounds.Size = new System.Drawing.Size(181, 32);
            this.buttonStopAllSounds.TabIndex = 2;
            this.buttonStopAllSounds.Text = "Заглушить все звуки";
            this.buttonStopAllSounds.UseVisualStyleBackColor = true;
            this.buttonStopAllSounds.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxShutSounds
            // 
            this.checkBoxShutSounds.AutoSize = true;
            this.checkBoxShutSounds.Location = new System.Drawing.Point(196, 61);
            this.checkBoxShutSounds.Name = "checkBoxShutSounds";
            this.checkBoxShutSounds.Size = new System.Drawing.Size(170, 17);
            this.checkBoxShutSounds.TabIndex = 13;
            this.checkBoxShutSounds.Text = "Глушить звуки при загрузке";
            this.checkBoxShutSounds.UseVisualStyleBackColor = true;
            this.checkBoxShutSounds.CheckedChanged += new System.EventHandler(this.checkBoxShutSounds_CheckedChanged);
            // 
            // checkBoxConstSound
            // 
            this.checkBoxConstSound.AutoSize = true;
            this.checkBoxConstSound.Location = new System.Drawing.Point(196, 83);
            this.checkBoxConstSound.Name = "checkBoxConstSound";
            this.checkBoxConstSound.Size = new System.Drawing.Size(157, 17);
            this.checkBoxConstSound.TabIndex = 14;
            this.checkBoxConstSound.Text = "Постоянно глушить звуки";
            this.checkBoxConstSound.UseVisualStyleBackColor = true;
            this.checkBoxConstSound.CheckedChanged += new System.EventHandler(this.checkBoxConstSound_CheckedChanged);
            // 
            // SoundWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 331);
            this.Controls.Add(this.groupBoxMusic);
            this.Controls.Add(this.groupBoxSound);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SoundWin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Звуки и музыка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SoundWin_FormClosing);
            this.Shown += new System.EventHandler(this.SoundWin_Shown);
            this.groupBoxSound.ResumeLayout(false);
            this.groupBoxSound.PerformLayout();
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
    }
}