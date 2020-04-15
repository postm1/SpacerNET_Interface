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
            this.textBoxItems = new System.Windows.Forms.TextBox();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.buttonItems = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVobName = new System.Windows.Forms.TextBox();
            this.classesTreeView = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFP = new System.Windows.Forms.TextBox();
            this.buttonFP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWP = new System.Windows.Forms.TextBox();
            this.buttonWP = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxParticles);
            this.groupBox1.Controls.Add(this.buttonParticles);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Эффекты частиц";
            // 
            // listBoxParticles
            // 
            this.listBoxParticles.FormattingEnabled = true;
            this.listBoxParticles.Location = new System.Drawing.Point(8, 55);
            this.listBoxParticles.Name = "listBoxParticles";
            this.listBoxParticles.Size = new System.Drawing.Size(344, 251);
            this.listBoxParticles.TabIndex = 1;
            // 
            // buttonParticles
            // 
            this.buttonParticles.Location = new System.Drawing.Point(8, 19);
            this.buttonParticles.Name = "buttonParticles";
            this.buttonParticles.Size = new System.Drawing.Size(344, 30);
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
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 313);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Предметы";
            // 
            // textBoxItems
            // 
            this.textBoxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxItems.Location = new System.Drawing.Point(8, 56);
            this.textBoxItems.Name = "textBoxItems";
            this.textBoxItems.Size = new System.Drawing.Size(344, 22);
            this.textBoxItems.TabIndex = 2;
            this.textBoxItems.TextChanged += new System.EventHandler(this.textBoxItems_TextChanged);
            this.textBoxItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxItems_KeyDown);
            this.textBoxItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxItems_KeyPress);
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(8, 81);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(344, 225);
            this.listBoxItems.TabIndex = 1;
            // 
            // buttonItems
            // 
            this.buttonItems.Location = new System.Drawing.Point(8, 19);
            this.buttonItems.Name = "buttonItems";
            this.buttonItems.Size = new System.Drawing.Size(344, 30);
            this.buttonItems.TabIndex = 0;
            this.buttonItems.Text = "Создать Item";
            this.buttonItems.UseVisualStyleBackColor = true;
            this.buttonItems.Click += new System.EventHandler(this.buttonItems_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxVobName);
            this.groupBox3.Controls.Add(this.classesTreeView);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 313);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Все классы вобов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя воба";
            // 
            // textBoxVobName
            // 
            this.textBoxVobName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVobName.Location = new System.Drawing.Point(65, 56);
            this.textBoxVobName.Name = "textBoxVobName";
            this.textBoxVobName.Size = new System.Drawing.Size(287, 22);
            this.textBoxVobName.TabIndex = 3;
            // 
            // classesTreeView
            // 
            this.classesTreeView.HideSelection = false;
            this.classesTreeView.Location = new System.Drawing.Point(8, 81);
            this.classesTreeView.Name = "classesTreeView";
            this.classesTreeView.Size = new System.Drawing.Size(344, 225);
            this.classesTreeView.TabIndex = 1;
            this.classesTreeView.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.classesTreeView_DrawNode);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Создать Vob";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(374, 358);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(366, 332);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Все классы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(366, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вещи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(366, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Эффекты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(366, 332);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Триггеры";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(366, 332);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "WP/FP";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBoxFP);
            this.groupBox4.Controls.Add(this.buttonFP);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBoxWP);
            this.groupBox4.Controls.Add(this.buttonWP);
            this.groupBox4.Location = new System.Drawing.Point(5, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(357, 313);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ключевые точки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя (обязательно)";
            // 
            // textBoxFP
            // 
            this.textBoxFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFP.Location = new System.Drawing.Point(7, 242);
            this.textBoxFP.Name = "textBoxFP";
            this.textBoxFP.Size = new System.Drawing.Size(344, 22);
            this.textBoxFP.TabIndex = 8;
            // 
            // buttonFP
            // 
            this.buttonFP.Location = new System.Drawing.Point(7, 270);
            this.buttonFP.Name = "buttonFP";
            this.buttonFP.Size = new System.Drawing.Size(344, 30);
            this.buttonFP.TabIndex = 7;
            this.buttonFP.Text = "Создать Freepoint";
            this.buttonFP.UseVisualStyleBackColor = true;
            this.buttonFP.Click += new System.EventHandler(this.buttonFP_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя (обязательно)";
            // 
            // textBoxWP
            // 
            this.textBoxWP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWP.Location = new System.Drawing.Point(7, 45);
            this.textBoxWP.Name = "textBoxWP";
            this.textBoxWP.Size = new System.Drawing.Size(344, 22);
            this.textBoxWP.TabIndex = 5;
            // 
            // buttonWP
            // 
            this.buttonWP.Location = new System.Drawing.Point(7, 73);
            this.buttonWP.Name = "buttonWP";
            this.buttonWP.Size = new System.Drawing.Size(344, 30);
            this.buttonWP.TabIndex = 3;
            this.buttonWP.Text = "Создать Waypoint";
            this.buttonWP.UseVisualStyleBackColor = true;
            this.buttonWP.Click += new System.EventHandler(this.buttonWP_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(344, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Соединить WP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(344, 30);
            this.button3.TabIndex = 11;
            this.button3.Text = "Разъединить WP";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ParticleWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 364);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParticleWin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Окно объектов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParticleWin_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TreeView classesTreeView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVobName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonWP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFP;
        private System.Windows.Forms.Button buttonFP;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}