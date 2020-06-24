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
            this.tabControlProps = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.comboBoxPropsEnum = new System.Windows.Forms.ComboBox();
            this.textBoxVec3 = new System.Windows.Forms.TextBox();
            this.buttonFileOpen = new System.Windows.Forms.Button();
            this.textBoxVec2 = new System.Windows.Forms.TextBox();
            this.textBoxVec1 = new System.Windows.Forms.TextBox();
            this.textBoxVec0 = new System.Windows.Forms.TextBox();
            this.buttonOpenContainer = new System.Windows.Forms.Button();
            this.buttonRestoreVobProp = new System.Windows.Forms.Button();
            this.textBoxString = new System.Windows.Forms.TextBox();
            this.buttonBbox = new System.Windows.Forms.Button();
            this.Label_Backup = new System.Windows.Forms.Label();
            this.buttonApplyOnVob = new System.Windows.Forms.Button();
            this.treeViewProp = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxEditBbox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBbox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonResetBbox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBbox1 = new System.Windows.Forms.TextBox();
            this.buttonApplyBbox = new System.Windows.Forms.Button();
            this.textBoxBbox0 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxContainer = new System.Windows.Forms.GroupBox();
            this.buttonRowDelete = new System.Windows.Forms.Button();
            this.buttonClearItems = new System.Windows.Forms.Button();
            this.buttonContainerCancel = new System.Windows.Forms.Button();
            this.buttonContainerApply = new System.Windows.Forms.Button();
            this.contextMenuStripContainer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogFileName = new System.Windows.Forms.OpenFileDialog();
            this.tabControlProps.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxEditBbox.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.groupBoxContainer.SuspendLayout();
            this.contextMenuStripContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlProps
            // 
            this.tabControlProps.Controls.Add(this.tabPage1);
            this.tabControlProps.Controls.Add(this.tabPage2);
            this.tabControlProps.Controls.Add(this.tabPage3);
            this.tabControlProps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlProps.Location = new System.Drawing.Point(0, 0);
            this.tabControlProps.Name = "tabControlProps";
            this.tabControlProps.SelectedIndex = 0;
            this.tabControlProps.Size = new System.Drawing.Size(330, 490);
            this.tabControlProps.TabIndex = 0;
            this.tabControlProps.SelectedIndexChanged += new System.EventHandler(this.tabControlProps_SelectedIndexChanged);
            this.tabControlProps.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
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
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Controls.Add(this.comboBoxPropsEnum);
            this.panelButtons.Controls.Add(this.textBoxVec3);
            this.panelButtons.Controls.Add(this.buttonFileOpen);
            this.panelButtons.Controls.Add(this.textBoxVec2);
            this.panelButtons.Controls.Add(this.textBoxVec1);
            this.panelButtons.Controls.Add(this.textBoxVec0);
            this.panelButtons.Controls.Add(this.buttonOpenContainer);
            this.panelButtons.Controls.Add(this.buttonRestoreVobProp);
            this.panelButtons.Controls.Add(this.textBoxString);
            this.panelButtons.Controls.Add(this.buttonBbox);
            this.panelButtons.Controls.Add(this.Label_Backup);
            this.panelButtons.Controls.Add(this.buttonApplyOnVob);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(3, 355);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(316, 106);
            this.panelButtons.TabIndex = 6;
            // 
            // comboBoxPropsEnum
            // 
            this.comboBoxPropsEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPropsEnum.FormattingEnabled = true;
            this.comboBoxPropsEnum.Location = new System.Drawing.Point(6, 20);
            this.comboBoxPropsEnum.Name = "comboBoxPropsEnum";
            this.comboBoxPropsEnum.Size = new System.Drawing.Size(120, 21);
            this.comboBoxPropsEnum.TabIndex = 13;
            this.comboBoxPropsEnum.Visible = false;
            this.comboBoxPropsEnum.SelectedIndexChanged += new System.EventHandler(this.comboBoxPropsEnum_SelectedIndexChanged);
            // 
            // textBoxVec3
            // 
            this.textBoxVec3.Location = new System.Drawing.Point(234, 20);
            this.textBoxVec3.Name = "textBoxVec3";
            this.textBoxVec3.Size = new System.Drawing.Size(70, 20);
            this.textBoxVec3.TabIndex = 12;
            this.textBoxVec3.Visible = false;
            this.textBoxVec3.TextChanged += new System.EventHandler(this.textBoxVec3_TextChanged);
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
            this.textBoxVec2.Location = new System.Drawing.Point(158, 20);
            this.textBoxVec2.Name = "textBoxVec2";
            this.textBoxVec2.Size = new System.Drawing.Size(70, 20);
            this.textBoxVec2.TabIndex = 10;
            this.textBoxVec2.Visible = false;
            this.textBoxVec2.TextChanged += new System.EventHandler(this.textBoxVec2_TextChanged);
            this.textBoxVec2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVec0_KeyPress);
            // 
            // textBoxVec1
            // 
            this.textBoxVec1.Location = new System.Drawing.Point(82, 20);
            this.textBoxVec1.Name = "textBoxVec1";
            this.textBoxVec1.Size = new System.Drawing.Size(70, 20);
            this.textBoxVec1.TabIndex = 9;
            this.textBoxVec1.Visible = false;
            this.textBoxVec1.TextChanged += new System.EventHandler(this.textBoxVec1_TextChanged);
            this.textBoxVec1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVec0_KeyPress);
            // 
            // textBoxVec0
            // 
            this.textBoxVec0.Location = new System.Drawing.Point(6, 20);
            this.textBoxVec0.Name = "textBoxVec0";
            this.textBoxVec0.Size = new System.Drawing.Size(70, 20);
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
            // buttonRestoreVobProp
            // 
            this.buttonRestoreVobProp.Enabled = false;
            this.buttonRestoreVobProp.Location = new System.Drawing.Point(6, 75);
            this.buttonRestoreVobProp.Name = "buttonRestoreVobProp";
            this.buttonRestoreVobProp.Size = new System.Drawing.Size(120, 23);
            this.buttonRestoreVobProp.TabIndex = 6;
            this.buttonRestoreVobProp.Text = "Восстановить";
            this.buttonRestoreVobProp.UseVisualStyleBackColor = true;
            this.buttonRestoreVobProp.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // textBoxString
            // 
            this.textBoxString.Location = new System.Drawing.Point(6, 20);
            this.textBoxString.Name = "textBoxString";
            this.textBoxString.Size = new System.Drawing.Size(298, 20);
            this.textBoxString.TabIndex = 0;
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
            // buttonApplyOnVob
            // 
            this.buttonApplyOnVob.Enabled = false;
            this.buttonApplyOnVob.Location = new System.Drawing.Point(6, 46);
            this.buttonApplyOnVob.Name = "buttonApplyOnVob";
            this.buttonApplyOnVob.Size = new System.Drawing.Size(120, 23);
            this.buttonApplyOnVob.TabIndex = 2;
            this.buttonApplyOnVob.Text = "Применить на вобе";
            this.buttonApplyOnVob.UseVisualStyleBackColor = true;
            this.buttonApplyOnVob.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // treeViewProp
            // 
            this.treeViewProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewProp.HideSelection = false;
            this.treeViewProp.Location = new System.Drawing.Point(3, 3);
            this.treeViewProp.Name = "treeViewProp";
            this.treeViewProp.Size = new System.Drawing.Size(316, 352);
            this.treeViewProp.TabIndex = 1;
            this.treeViewProp.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.treeViewProp_DrawNode);
            this.treeViewProp.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewProp_AfterSelect);
            this.treeViewProp.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewProp_NodeMouseDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxEditBbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(322, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BBox";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxEditBbox
            // 
            this.groupBoxEditBbox.Controls.Add(this.label3);
            this.groupBoxEditBbox.Controls.Add(this.textBoxBbox2);
            this.groupBoxEditBbox.Controls.Add(this.label2);
            this.groupBoxEditBbox.Controls.Add(this.buttonResetBbox);
            this.groupBoxEditBbox.Controls.Add(this.label1);
            this.groupBoxEditBbox.Controls.Add(this.textBoxBbox1);
            this.groupBoxEditBbox.Controls.Add(this.buttonApplyBbox);
            this.groupBoxEditBbox.Controls.Add(this.textBoxBbox0);
            this.groupBoxEditBbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEditBbox.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEditBbox.Name = "groupBoxEditBbox";
            this.groupBoxEditBbox.Size = new System.Drawing.Size(322, 464);
            this.groupBoxEditBbox.TabIndex = 9;
            this.groupBoxEditBbox.TabStop = false;
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
            this.tabPage3.Controls.Add(this.dataGridViewItems);
            this.tabPage3.Controls.Add(this.groupBoxContainer);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(322, 464);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Контейнер";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToResizeColumns = false;
            this.dataGridViewItems.AllowUserToResizeRows = false;
            this.dataGridViewItems.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewItems.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowHeadersVisible = false;
            this.dataGridViewItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(322, 388);
            this.dataGridViewItems.TabIndex = 4;
            this.dataGridViewItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
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
            // groupBoxContainer
            // 
            this.groupBoxContainer.Controls.Add(this.buttonRowDelete);
            this.groupBoxContainer.Controls.Add(this.buttonClearItems);
            this.groupBoxContainer.Controls.Add(this.buttonContainerCancel);
            this.groupBoxContainer.Controls.Add(this.buttonContainerApply);
            this.groupBoxContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxContainer.Location = new System.Drawing.Point(0, 388);
            this.groupBoxContainer.Name = "groupBoxContainer";
            this.groupBoxContainer.Size = new System.Drawing.Size(322, 76);
            this.groupBoxContainer.TabIndex = 6;
            this.groupBoxContainer.TabStop = false;
            this.groupBoxContainer.Text = "Управление";
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
            // contextMenuStripContainer
            // 
            this.contextMenuStripContainer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьСтрокуToolStripMenuItem});
            this.contextMenuStripContainer.Name = "contextMenuStripContainer";
            this.contextMenuStripContainer.Size = new System.Drawing.Size(159, 26);
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
            this.Controls.Add(this.tabControlProps);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObjectsWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Окно свойств";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ObjectsWindow_FormClosing);
            this.Shown += new System.EventHandler(this.ObjectsWindow_Shown);
            this.tabControlProps.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBoxEditBbox.ResumeLayout(false);
            this.groupBoxEditBbox.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.groupBoxContainer.ResumeLayout(false);
            this.contextMenuStripContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeViewProp;
        private System.Windows.Forms.Button buttonBbox;
        private System.Windows.Forms.Button buttonApplyOnVob;
        private System.Windows.Forms.TextBox textBoxString;
        private System.Windows.Forms.Label Label_Backup;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonOpenContainer;
        private System.Windows.Forms.Button buttonRestoreVobProp;
        private System.Windows.Forms.TextBox textBoxVec2;
        private System.Windows.Forms.TextBox textBoxVec1;
        private System.Windows.Forms.TextBox textBoxVec0;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonContainerCancel;
        private System.Windows.Forms.Button buttonClearItems;
        private System.Windows.Forms.GroupBox groupBoxContainer;
        public System.Windows.Forms.TabControl tabControlProps;
        public System.Windows.Forms.DataGridView dataGridViewItems;
        public System.Windows.Forms.Button buttonContainerApply;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripContainer;
        private System.Windows.Forms.ToolStripMenuItem удалитьСтрокуToolStripMenuItem;
        private System.Windows.Forms.Button buttonRowDelete;
        private System.Windows.Forms.GroupBox groupBoxEditBbox;
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
        private System.Windows.Forms.TextBox textBoxVec3;
        private System.Windows.Forms.ComboBox comboBoxPropsEnum;
    }
}