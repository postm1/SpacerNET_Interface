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
            this.button2 = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.treeViewProp = new System.Windows.Forms.TreeView();
            this.textBoxString = new System.Windows.Forms.TextBox();
            this.Label_Backup = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(313, 490);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelButtons);
            this.tabPage1.Controls.Add(this.treeViewProp);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(305, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Редактирование";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "BBox";
            this.button2.UseVisualStyleBackColor = true;
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
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Controls.Add(this.button1);
            this.panelButtons.Controls.Add(this.buttonRestore);
            this.panelButtons.Controls.Add(this.textBoxString);
            this.panelButtons.Controls.Add(this.button2);
            this.panelButtons.Controls.Add(this.Label_Backup);
            this.panelButtons.Controls.Add(this.buttonApply);
            this.panelButtons.Location = new System.Drawing.Point(9, 352);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(284, 106);
            this.panelButtons.TabIndex = 6;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeViewProp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxString;
        private System.Windows.Forms.Label Label_Backup;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRestore;
    }
}