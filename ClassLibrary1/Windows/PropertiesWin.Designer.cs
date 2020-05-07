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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeViewProp = new System.Windows.Forms.TreeView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonFileOpen = new System.Windows.Forms.Button();
            this.textBoxVec2 = new System.Windows.Forms.TextBox();
            this.textBoxVec1 = new System.Windows.Forms.TextBox();
            this.textBoxVec0 = new System.Windows.Forms.TextBox();
            this.buttonOpenContainer = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.textBoxString = new System.Windows.Forms.TextBox();
            this.buttonBbox = new System.Windows.Forms.Button();
            this.Label_Backup = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBbox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonResetBbox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBbox1 = new System.Windows.Forms.TextBox();
            this.buttonApplyBbox = new System.Windows.Forms.Button();
            this.textBoxBbox0 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRowDelete = new System.Windows.Forms.Button();
            this.buttonClearItems = new System.Windows.Forms.Button();
            this.buttonContainerCancel = new System.Windows.Forms.Button();
            this.buttonContainerApply = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripContainer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogFileName = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStripContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(330, 490);
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
            this.tabPage1.Size = new System.Drawing.Size(322, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Редактирование";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // treeViewProp
            // 
            this.treeViewProp.HideSelection = false;
            this.treeViewProp.Location = new System.Drawing.Point(9, 8);
            this.treeViewProp.Name = "treeViewProp";
            this.treeViewProp.Size = new System.Drawing.Size(310, 342);
            this.treeViewProp.TabIndex = 1;
            this.treeViewProp.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.treeViewProp_DrawNode);
            this.treeViewProp.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewProp_AfterSelect);
            this.treeViewProp.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewProp_NodeMouseClick);
            this.treeViewProp.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewProp_NodeMouseDoubleClick);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Controls.Add(this.buttonFileOpen);
            this.panelButtons.Controls.Add(this.textBoxVec2);
            this.panelButtons.Controls.Add(this.textBoxVec1);
            this.panelButtons.Controls.Add(this.textBoxVec0);
            this.panelButtons.Controls.Add(this.buttonOpenContainer);
            this.panelButtons.Controls.Add(this.buttonRestore);
            this.panelButtons.Controls.Add(this.textBoxString);
            this.panelButtons.Controls.Add(this.buttonBbox);
            this.panelButtons.Controls.Add(this.Label_Backup);
            this.panelButtons.Controls.Add(this.buttonApply);
            this.panelButtons.Location = new System.Drawing.Point(9, 352);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(310, 106);
            this.panelButtons.TabIndex = 6;
            // 
            // buttonFileOpen
            // 
            this.buttonFileOpen.Location = new System.Drawing.Point(256, 46);
            this.buttonFileOpen.Name = "buttonFileOpen";
            this.buttonFileOpen.Size = new System.Drawing.Size(48, 23);
            this.buttonFileOpen.TabIndex = 11;
            this.buttonFileOpen.Text = "Файл";
            this.buttonFileOpen.UseVisualStyleBackColor = true;
            this.buttonFileOpen.Click += new System.EventHandler(this.buttonFileOpen_Click);
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
            // buttonOpenContainer
            // 
            this.buttonOpenContainer.Enabled = false;
            this.buttonOpenContainer.Location = new System.Drawing.Point(132, 75);
            this.buttonOpenContainer.Name = "buttonOpenContainer";
            this.buttonOpenContainer.Size = new System.Drawing.Size(120, 23);
            this.buttonOpenContainer.TabIndex = 7;
            this.buttonOpenContainer.Text = "Контейнер";
            this.buttonOpenContainer.UseVisualStyleBackColor = true;
            this.buttonOpenContainer.Click += new System.EventHandler(this.buttonOpenContainer_Click);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Enabled = false;
            this.buttonRestore.Location = new System.Drawing.Point(6, 75);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(120, 23);
            this.buttonRestore.TabIndex = 6;
            this.buttonRestore.Text = "Восстановить";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // textBoxString
            // 
            this.textBoxString.Location = new System.Drawing.Point(6, 20);
            this.textBoxString.Name = "textBoxString";
            this.textBoxString.Size = new System.Drawing.Size(298, 20);
            this.textBoxString.TabIndex = 0;
            this.textBoxString.Visible = false;
            this.textBoxString.TextChanged += new System.EventHandler(this.textBoxString_TextChanged);
            this.textBoxString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxString_KeyDown);
            this.textBoxString.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxString_KeyPress);
            // 
            // buttonBbox
            // 
            this.buttonBbox.Location = new System.Drawing.Point(132, 46);
            this.buttonBbox.Name = "buttonBbox";
            this.buttonBbox.Size = new System.Drawing.Size(120, 23);
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
            this.buttonApply.Size = new System.Drawing.Size(120, 23);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "Применить на вобе";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(322, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BBox";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxBbox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonResetBbox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxBbox1);
            this.groupBox2.Controls.Add(this.buttonApplyBbox);
            this.groupBox2.Controls.Add(this.textBoxBbox0);
            this.groupBox2.Location = new System.Drawing.Point(8, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 208);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактирование BBox";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Z";
            // 
            // textBoxBbox2
            // 
            this.textBoxBbox2.Location = new System.Drawing.Point(33, 125);
            this.textBoxBbox2.Name = "textBoxBbox2";
            this.textBoxBbox2.Size = new System.Drawing.Size(212, 20);
            this.textBoxBbox2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Y";
            // 
            // buttonResetBbox
            // 
            this.buttonResetBbox.Location = new System.Drawing.Point(33, 160);
            this.buttonResetBbox.Name = "buttonResetBbox";
            this.buttonResetBbox.Size = new System.Drawing.Size(104, 23);
            this.buttonResetBbox.TabIndex = 10;
            this.buttonResetBbox.Text = "Отмена";
            this.buttonResetBbox.UseVisualStyleBackColor = true;
            this.buttonResetBbox.Click += new System.EventHandler(this.buttonResetBbox_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "X";
            // 
            // textBoxBbox1
            // 
            this.textBoxBbox1.Location = new System.Drawing.Point(33, 85);
            this.textBoxBbox1.Name = "textBoxBbox1";
            this.textBoxBbox1.Size = new System.Drawing.Size(212, 20);
            this.textBoxBbox1.TabIndex = 13;
            // 
            // buttonApplyBbox
            // 
            this.buttonApplyBbox.Location = new System.Drawing.Point(143, 160);
            this.buttonApplyBbox.Name = "buttonApplyBbox";
            this.buttonApplyBbox.Size = new System.Drawing.Size(102, 23);
            this.buttonApplyBbox.TabIndex = 11;
            this.buttonApplyBbox.Text = "Применить";
            this.buttonApplyBbox.UseVisualStyleBackColor = true;
            this.buttonApplyBbox.Click += new System.EventHandler(this.buttonApplyBbox_Click_1);
            // 
            // textBoxBbox0
            // 
            this.textBoxBbox0.Location = new System.Drawing.Point(33, 46);
            this.textBoxBbox0.Name = "textBoxBbox0";
            this.textBoxBbox0.Size = new System.Drawing.Size(212, 20);
            this.textBoxBbox0.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(322, 464);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Контейнер";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRowDelete);
            this.groupBox1.Controls.Add(this.buttonClearItems);
            this.groupBox1.Controls.Add(this.buttonContainerCancel);
            this.groupBox1.Controls.Add(this.buttonContainerApply);
            this.groupBox1.Location = new System.Drawing.Point(8, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 82);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // buttonRowDelete
            // 
            this.buttonRowDelete.Location = new System.Drawing.Point(157, 19);
            this.buttonRowDelete.Name = "buttonRowDelete";
            this.buttonRowDelete.Size = new System.Drawing.Size(111, 23);
            this.buttonRowDelete.TabIndex = 6;
            this.buttonRowDelete.Text = "Удалить текущую";
            this.buttonRowDelete.UseVisualStyleBackColor = true;
            this.buttonRowDelete.Click += new System.EventHandler(this.buttonRowDelete_Click);
            // 
            // buttonClearItems
            // 
            this.buttonClearItems.Location = new System.Drawing.Point(31, 19);
            this.buttonClearItems.Name = "buttonClearItems";
            this.buttonClearItems.Size = new System.Drawing.Size(111, 23);
            this.buttonClearItems.TabIndex = 5;
            this.buttonClearItems.Text = "Очистить все";
            this.buttonClearItems.UseVisualStyleBackColor = true;
            this.buttonClearItems.Click += new System.EventHandler(this.buttonClearItems_Click);
            // 
            // buttonContainerCancel
            // 
            this.buttonContainerCancel.Location = new System.Drawing.Point(31, 48);
            this.buttonContainerCancel.Name = "buttonContainerCancel";
            this.buttonContainerCancel.Size = new System.Drawing.Size(111, 23);
            this.buttonContainerCancel.TabIndex = 2;
            this.buttonContainerCancel.Text = "Отмена";
            this.buttonContainerCancel.UseVisualStyleBackColor = true;
            this.buttonContainerCancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonContainerApply
            // 
            this.buttonContainerApply.Location = new System.Drawing.Point(157, 48);
            this.buttonContainerApply.Name = "buttonContainerApply";
            this.buttonContainerApply.Size = new System.Drawing.Size(111, 23);
            this.buttonContainerApply.TabIndex = 3;
            this.buttonContainerApply.Text = "Применить";
            this.buttonContainerApply.UseVisualStyleBackColor = true;
            this.buttonContainerApply.Click += new System.EventHandler(this.buttonContainerApply_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(8, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(306, 350);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dataGridView1_RowContextMenuStripNeeded);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Инстанция";
            this.Column1.Name = "Column1";
            this.Column1.Width = 236;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Кол-во";
            this.Column2.Name = "Column2";
            this.Column2.Width = 66;
            // 
            // contextMenuStripContainer
            // 
            this.contextMenuStripContainer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьСтрокуToolStripMenuItem});
            this.contextMenuStripContainer.Name = "contextMenuStripContainer";
            this.contextMenuStripContainer.Size = new System.Drawing.Size(159, 26);
            this.contextMenuStripContainer.Click += new System.EventHandler(this.contextMenuStripContainer_Click);
            // 
            // удалитьСтрокуToolStripMenuItem
            // 
            this.удалитьСтрокуToolStripMenuItem.Name = "удалитьСтрокуToolStripMenuItem";
            this.удалитьСтрокуToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.удалитьСтрокуToolStripMenuItem.Text = "Удалить строку";
            this.удалитьСтрокуToolStripMenuItem.Click += new System.EventHandler(this.удалитьСтрокуToolStripMenuItem_Click);
            // 
            // ObjectsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 490);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObjectsWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ObjectsWindow_FormClosing);
            this.Shown += new System.EventHandler(this.ObjectsWindow_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStripContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeViewProp;
        private System.Windows.Forms.Button buttonBbox;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxString;
        private System.Windows.Forms.Label Label_Backup;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonOpenContainer;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.TextBox textBoxVec2;
        private System.Windows.Forms.TextBox textBoxVec1;
        private System.Windows.Forms.TextBox textBoxVec0;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonContainerCancel;
        private System.Windows.Forms.Button buttonClearItems;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button buttonContainerApply;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripContainer;
        private System.Windows.Forms.ToolStripMenuItem удалитьСтрокуToolStripMenuItem;
        private System.Windows.Forms.Button buttonRowDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBbox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonResetBbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBbox1;
        private System.Windows.Forms.Button buttonApplyBbox;
        private System.Windows.Forms.TextBox textBoxBbox0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button buttonFileOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialogFileName;
    }
}