namespace SpacerUnion
{
    partial class ObjectsWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.textBoxVec2 = new System.Windows.Forms.TextBox();
            this.textBoxVec1 = new System.Windows.Forms.TextBox();
            this.textBoxVec0 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.textBoxString = new System.Windows.Forms.TextBox();
            this.buttonBbox = new System.Windows.Forms.Button();
            this.Label_Backup = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.treeViewProp = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBbox2 = new System.Windows.Forms.TextBox();
            this.textBoxBbox1 = new System.Windows.Forms.TextBox();
            this.textBoxBbox0 = new System.Windows.Forms.TextBox();
            this.buttonApplyBbox = new System.Windows.Forms.Button();
            this.buttonResetBbox = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(313, 490);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeViewProp);
            this.tabPage1.Controls.Add(this.panelButtons);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(305, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Редактирование";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Controls.Add(this.textBoxVec2);
            this.panelButtons.Controls.Add(this.textBoxVec1);
            this.panelButtons.Controls.Add(this.textBoxVec0);
            this.panelButtons.Controls.Add(this.button1);
            this.panelButtons.Controls.Add(this.buttonRestore);
            this.panelButtons.Controls.Add(this.textBoxString);
            this.panelButtons.Controls.Add(this.buttonBbox);
            this.panelButtons.Controls.Add(this.Label_Backup);
            this.panelButtons.Controls.Add(this.buttonApply);
            this.panelButtons.Location = new System.Drawing.Point(9, 352);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(284, 106);
            this.panelButtons.TabIndex = 6;
            // 
            // textBoxVec2
            // 
            this.textBoxVec2.Location = new System.Drawing.Point(190, 20);
            this.textBoxVec2.Name = "textBoxVec2";
            this.textBoxVec2.Size = new System.Drawing.Size(75, 20);
            this.textBoxVec2.TabIndex = 10;
            this.textBoxVec2.Visible = false;
            this.textBoxVec2.TextChanged += new System.EventHandler(this.textBoxVec2_TextChanged);
            this.textBoxVec2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVec0_KeyPress);
            // 
            // textBoxVec1
            // 
            this.textBoxVec1.Location = new System.Drawing.Point(96, 20);
            this.textBoxVec1.Name = "textBoxVec1";
            this.textBoxVec1.Size = new System.Drawing.Size(75, 20);
            this.textBoxVec1.TabIndex = 9;
            this.textBoxVec1.Visible = false;
            this.textBoxVec1.TextChanged += new System.EventHandler(this.textBoxVec1_TextChanged);
            this.textBoxVec1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVec0_KeyPress);
            // 
            // textBoxVec0
            // 
            this.textBoxVec0.Location = new System.Drawing.Point(6, 20);
            this.textBoxVec0.Name = "textBoxVec0";
            this.textBoxVec0.Size = new System.Drawing.Size(75, 20);
            this.textBoxVec0.TabIndex = 8;
            this.textBoxVec0.Visible = false;
            this.textBoxVec0.TextChanged += new System.EventHandler(this.textBoxVec0_TextChanged);
            this.textBoxVec0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVec0_KeyPress);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(153, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "Файл";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonRestore
            // 
            this.buttonRestore.Enabled = false;
            this.buttonRestore.Location = new System.Drawing.Point(6, 75);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(139, 22);
            this.buttonRestore.TabIndex = 6;
            this.buttonRestore.Text = "Восстановить";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // textBoxString
            // 
            this.textBoxString.Location = new System.Drawing.Point(6, 20);
            this.textBoxString.Name = "textBoxString";
            this.textBoxString.Size = new System.Drawing.Size(75, 20);
            this.textBoxString.TabIndex = 0;
            this.textBoxString.Visible = false;
            this.textBoxString.TextChanged += new System.EventHandler(this.textBoxString_TextChanged);
            this.textBoxString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxString_KeyDown);
            this.textBoxString.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxString_KeyPress);
            // 
            // buttonBbox
            // 
            this.buttonBbox.Location = new System.Drawing.Point(151, 46);
            this.buttonBbox.Name = "buttonBbox";
            this.buttonBbox.Size = new System.Drawing.Size(114, 23);
            this.buttonBbox.TabIndex = 3;
            this.buttonBbox.Text = "BBox";
            this.buttonBbox.UseVisualStyleBackColor = true;
            this.buttonBbox.Click += new System.EventHandler(this.button2_Click);
            // 
            // Label_Backup
            // 
            this.Label_Backup.AutoSize = true;
            this.Label_Backup.ForeColor = System.Drawing.Color.DarkRed;
            this.Label_Backup.Location = new System.Drawing.Point(3, 4);
            this.Label_Backup.Name = "Label_Backup";
            this.Label_Backup.Size = new System.Drawing.Size(96, 13);
            this.Label_Backup.TabIndex = 5;
            this.Label_Backup.Text = "Старое значение:";
            this.Label_Backup.Visible = false;
            // 
            // buttonApply
            // 
            this.buttonApply.Enabled = false;
            this.buttonApply.Location = new System.Drawing.Point(6, 46);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(139, 23);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "Применить на вобе";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // treeViewProp
            // 
            this.treeViewProp.HideSelection = false;
            this.treeViewProp.Location = new System.Drawing.Point(9, 8);
            this.treeViewProp.Name = "treeViewProp";
            this.treeViewProp.Size = new System.Drawing.Size(284, 342);
            this.treeViewProp.TabIndex = 1;
            this.treeViewProp.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.treeViewProp_DrawNode);
            this.treeViewProp.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewProp_AfterSelect);
            this.treeViewProp.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewProp_NodeMouseDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBoxBbox2);
            this.tabPage2.Controls.Add(this.textBoxBbox1);
            this.tabPage2.Controls.Add(this.textBoxBbox0);
            this.tabPage2.Controls.Add(this.buttonApplyBbox);
            this.tabPage2.Controls.Add(this.buttonResetBbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(305, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BBox";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(102, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Размер bbox";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            // 
            // textBoxBbox2
            // 
            this.textBoxBbox2.Location = new System.Drawing.Point(42, 119);
            this.textBoxBbox2.Name = "textBoxBbox2";
            this.textBoxBbox2.Size = new System.Drawing.Size(212, 20);
            this.textBoxBbox2.TabIndex = 4;
            this.textBoxBbox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBoxBbox1
            // 
            this.textBoxBbox1.Location = new System.Drawing.Point(42, 79);
            this.textBoxBbox1.Name = "textBoxBbox1";
            this.textBoxBbox1.Size = new System.Drawing.Size(212, 20);
            this.textBoxBbox1.TabIndex = 3;
            this.textBoxBbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBoxBbox0
            // 
            this.textBoxBbox0.Location = new System.Drawing.Point(42, 40);
            this.textBoxBbox0.Name = "textBoxBbox0";
            this.textBoxBbox0.Size = new System.Drawing.Size(212, 20);
            this.textBoxBbox0.TabIndex = 2;
            this.textBoxBbox0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // buttonApplyBbox
            // 
            this.buttonApplyBbox.Location = new System.Drawing.Point(152, 154);
            this.buttonApplyBbox.Name = "buttonApplyBbox";
            this.buttonApplyBbox.Size = new System.Drawing.Size(102, 23);
            this.buttonApplyBbox.TabIndex = 1;
            this.buttonApplyBbox.Text = "Применить";
            this.buttonApplyBbox.UseVisualStyleBackColor = true;
            this.buttonApplyBbox.Click += new System.EventHandler(this.buttonApplyBbox_Click);
            // 
            // buttonResetBbox
            // 
            this.buttonResetBbox.Location = new System.Drawing.Point(42, 154);
            this.buttonResetBbox.Name = "buttonResetBbox";
            this.buttonResetBbox.Size = new System.Drawing.Size(104, 23);
            this.buttonResetBbox.TabIndex = 0;
            this.buttonResetBbox.Text = "Отмена";
            this.buttonResetBbox.UseVisualStyleBackColor = true;
            this.buttonResetBbox.Click += new System.EventHandler(this.buttonResetBbox_Click);
            // 
            // ObjectsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 490);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObjectsWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Свойства воба";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ObjectsWindow_FormClosing);
            this.Shown += new System.EventHandler(this.ObjectsWindow_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeViewProp;
        private System.Windows.Forms.Button buttonBbox;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxString;
        private System.Windows.Forms.Label Label_Backup;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.TextBox textBoxVec2;
        private System.Windows.Forms.TextBox textBoxVec1;
        private System.Windows.Forms.TextBox textBoxVec0;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxBbox2;
        private System.Windows.Forms.TextBox textBoxBbox1;
        private System.Windows.Forms.TextBox textBoxBbox0;
        private System.Windows.Forms.Button buttonApplyBbox;
        private System.Windows.Forms.Button buttonResetBbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}