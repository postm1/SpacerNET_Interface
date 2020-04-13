namespace SpacerUnion
{
    partial class ParticleWin
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
            this.listBoxParticles = new System.Windows.Forms.ListBox();
            this.buttonParticles = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.buttonItems = new System.Windows.Forms.Button();
            this.textBoxItems = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxParticles);
            this.groupBox1.Controls.Add(this.buttonParticles);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Эффекты частиц";
            // 
            // listBoxParticles
            // 
            this.listBoxParticles.FormattingEnabled = true;
            this.listBoxParticles.Location = new System.Drawing.Point(8, 55);
            this.listBoxParticles.Name = "listBoxParticles";
            this.listBoxParticles.Size = new System.Drawing.Size(217, 251);
            this.listBoxParticles.TabIndex = 1;
            // 
            // buttonParticles
            // 
            this.buttonParticles.Location = new System.Drawing.Point(8, 19);
            this.buttonParticles.Name = "buttonParticles";
            this.buttonParticles.Size = new System.Drawing.Size(217, 30);
            this.buttonParticles.TabIndex = 0;
            this.buttonParticles.Text = "Создать PFX";
            this.buttonParticles.UseVisualStyleBackColor = true;
            this.buttonParticles.Click += new System.EventHandler(this.buttonParticles_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxItems);
            this.groupBox2.Controls.Add(this.listBoxItems);
            this.groupBox2.Controls.Add(this.buttonItems);
            this.groupBox2.Location = new System.Drawing.Point(265, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 313);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Предметы";
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(8, 81);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(217, 225);
            this.listBoxItems.TabIndex = 1;
            // 
            // buttonItems
            // 
            this.buttonItems.Location = new System.Drawing.Point(8, 19);
            this.buttonItems.Name = "buttonItems";
            this.buttonItems.Size = new System.Drawing.Size(217, 30);
            this.buttonItems.TabIndex = 0;
            this.buttonItems.Text = "Создать Item";
            this.buttonItems.UseVisualStyleBackColor = true;
            this.buttonItems.Click += new System.EventHandler(this.buttonItems_Click);
            // 
            // textBoxItems
            // 
            this.textBoxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxItems.Location = new System.Drawing.Point(8, 56);
            this.textBoxItems.Name = "textBoxItems";
            this.textBoxItems.Size = new System.Drawing.Size(217, 22);
            this.textBoxItems.TabIndex = 2;
            this.textBoxItems.TextChanged += new System.EventHandler(this.textBoxItems_TextChanged);
            this.textBoxItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxItems_KeyDown);
            this.textBoxItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxItems_KeyPress);
            // 
            // ParticleWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 337);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParticleWin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Objectpages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParticleWin_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonParticles;
        public System.Windows.Forms.ListBox listBoxParticles;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.Button buttonItems;
        private System.Windows.Forms.TextBox textBoxItems;
    }
}