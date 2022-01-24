namespace SpacerUnion
{
    partial class ObjTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjTree));
            this.globalTree = new System.Windows.Forms.TreeView();
            this.contextMenuStripTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьVobTreeГлобальноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВобToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.сделатьРодителемДляНовыхВобовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьРодителяДляВобовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddQuickVobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonCollapse = new System.Windows.Forms.Button();
            this.buttonExpand = new System.Windows.Forms.Button();
            this.openFileDialogVobTree = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogVobTree = new System.Windows.Forms.SaveFileDialog();
            this.buttonTreeSort = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.quickTree = new System.Windows.Forms.TreeView();
            this.contextMenuQuick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripClearGlobalPar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuRemoveQuickVob = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripTree.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuQuick.SuspendLayout();
            this.SuspendLayout();
            // 
            // globalTree
            // 
            this.globalTree.ContextMenuStrip = this.contextMenuStripTree;
            this.globalTree.HideSelection = false;
            this.globalTree.HotTracking = true;
            this.globalTree.ImageIndex = 0;
            this.globalTree.ImageList = this.imageList1;
            this.globalTree.Location = new System.Drawing.Point(3, 47);
            this.globalTree.Name = "globalTree";
            this.globalTree.SelectedImageIndex = 0;
            this.globalTree.Size = new System.Drawing.Size(372, 375);
            this.globalTree.TabIndex = 0;
            this.globalTree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.globalTree_BeforeSelect);
            this.globalTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.globalTree_AfterSelect);
            this.globalTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.globalTree_NodeMouseClick_1);
            this.globalTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.globalTree_NodeMouseDoubleClick);
            this.globalTree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.globalTree_KeyDown);
            this.globalTree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.globalTree_KeyPress);
            // 
            // contextMenuStripTree
            // 
            this.contextMenuStripTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.вставитьVobTreeГлобальноToolStripMenuItem,
            this.toolStripMenuItem1,
            this.удалитьВобToolStripMenuItem,
            this.toolStripSeparator1,
            this.сделатьРодителемДляНовыхВобовToolStripMenuItem,
            this.очиститьРодителяДляВобовToolStripMenuItem,
            this.AddQuickVobToolStripMenuItem});
            this.contextMenuStripTree.Name = "contextMenuStrip1";
            this.contextMenuStripTree.Size = new System.Drawing.Size(283, 164);
            this.contextMenuStripTree.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripTree_Opening);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(282, 22);
            this.toolStripMenuItem2.Text = "Вставить VobTree в выделенный воб";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // вставитьVobTreeГлобальноToolStripMenuItem
            // 
            this.вставитьVobTreeГлобальноToolStripMenuItem.Name = "вставитьVobTreeГлобальноToolStripMenuItem";
            this.вставитьVobTreeГлобальноToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.вставитьVobTreeГлобальноToolStripMenuItem.Text = "Вставить VobTree глобально";
            this.вставитьVobTreeГлобальноToolStripMenuItem.Click += new System.EventHandler(this.вставитьVobTreeГлобальноToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(282, 22);
            this.toolStripMenuItem1.Text = "Сохранить выделенный воб в VobTree";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // удалитьВобToolStripMenuItem
            // 
            this.удалитьВобToolStripMenuItem.Name = "удалитьВобToolStripMenuItem";
            this.удалитьВобToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.удалитьВобToolStripMenuItem.Text = "Удалить воб";
            this.удалитьВобToolStripMenuItem.Click += new System.EventHandler(this.удалитьВобToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(279, 6);
            // 
            // сделатьРодителемДляНовыхВобовToolStripMenuItem
            // 
            this.сделатьРодителемДляНовыхВобовToolStripMenuItem.Image = global::SpacerUnion.Properties.Resources.vob_parent_fav;
            this.сделатьРодителемДляНовыхВобовToolStripMenuItem.Name = "сделатьРодителемДляНовыхВобовToolStripMenuItem";
            this.сделатьРодителемДляНовыхВобовToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.сделатьРодителемДляНовыхВобовToolStripMenuItem.Text = "Сделать родителем для новых вобов";
            this.сделатьРодителемДляНовыхВобовToolStripMenuItem.Click += new System.EventHandler(this.сделатьРодителемДляНовыхВобовToolStripMenuItem_Click);
            // 
            // очиститьРодителяДляВобовToolStripMenuItem
            // 
            this.очиститьРодителяДляВобовToolStripMenuItem.Name = "очиститьРодителяДляВобовToolStripMenuItem";
            this.очиститьРодителяДляВобовToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.очиститьРодителяДляВобовToolStripMenuItem.Text = "Очистить родителя для вобов";
            this.очиститьРодителяДляВобовToolStripMenuItem.Click += new System.EventHandler(this.очиститьРодителяДляВобовToolStripMenuItem_Click);
            // 
            // AddQuickVobToolStripMenuItem
            // 
            this.AddQuickVobToolStripMenuItem.Image = global::SpacerUnion.Properties.Resources.vob_start_fav;
            this.AddQuickVobToolStripMenuItem.Name = "AddQuickVobToolStripMenuItem";
            this.AddQuickVobToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.AddQuickVobToolStripMenuItem.Text = "Добавить воб в быстрый доступ";
            this.AddQuickVobToolStripMenuItem.Click += new System.EventHandler(this.AddQuickVobToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "256-256-722452f33cc453c66fdb23d8c3b4c820-folder.png");
            this.imageList1.Images.SetKeyName(1, "p3.png");
            this.imageList1.Images.SetKeyName(2, "selWP.png");
            this.imageList1.Images.SetKeyName(3, "selnew.png");
            this.imageList1.Images.SetKeyName(4, "256-256-722452f33cc453c66fdb23d8c3b4c820-folder.png");
            // 
            // buttonCollapse
            // 
            this.buttonCollapse.Location = new System.Drawing.Point(14, 10);
            this.buttonCollapse.Name = "buttonCollapse";
            this.buttonCollapse.Size = new System.Drawing.Size(96, 23);
            this.buttonCollapse.TabIndex = 1;
            this.buttonCollapse.Text = "Свернуть все";
            this.buttonCollapse.UseVisualStyleBackColor = true;
            this.buttonCollapse.Click += new System.EventHandler(this.buttonCollapse_Click);
            // 
            // buttonExpand
            // 
            this.buttonExpand.Location = new System.Drawing.Point(116, 10);
            this.buttonExpand.Name = "buttonExpand";
            this.buttonExpand.Size = new System.Drawing.Size(97, 23);
            this.buttonExpand.TabIndex = 2;
            this.buttonExpand.Text = "Развернуть все";
            this.buttonExpand.UseVisualStyleBackColor = true;
            this.buttonExpand.Click += new System.EventHandler(this.buttonExpand_Click);
            // 
            // openFileDialogVobTree
            // 
            this.openFileDialogVobTree.FileName = "openFileDialog1";
            // 
            // buttonTreeSort
            // 
            this.buttonTreeSort.Location = new System.Drawing.Point(219, 10);
            this.buttonTreeSort.Name = "buttonTreeSort";
            this.buttonTreeSort.Size = new System.Drawing.Size(97, 23);
            this.buttonTreeSort.TabIndex = 3;
            this.buttonTreeSort.Text = "Сортировать";
            this.buttonTreeSort.UseVisualStyleBackColor = true;
            this.buttonTreeSort.Click += new System.EventHandler(this.buttonTreeSort_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonCollapse);
            this.panelButtons.Controls.Add(this.buttonExpand);
            this.panelButtons.Controls.Add(this.buttonTreeSort);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(3, 3);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(372, 43);
            this.panelButtons.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(386, 451);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelButtons);
            this.tabPage1.Controls.Add(this.globalTree);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(378, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Объекты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.quickTree);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(378, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Быстрый доступ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // quickTree
            // 
            this.quickTree.ContextMenuStrip = this.contextMenuQuick;
            this.quickTree.HideSelection = false;
            this.quickTree.HotTracking = true;
            this.quickTree.ImageIndex = 0;
            this.quickTree.ImageList = this.imageList1;
            this.quickTree.Location = new System.Drawing.Point(0, 6);
            this.quickTree.Name = "quickTree";
            this.quickTree.SelectedImageIndex = 0;
            this.quickTree.Size = new System.Drawing.Size(372, 416);
            this.quickTree.TabIndex = 1;
            this.quickTree.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.quickTree_BeforeCollapse);
            this.quickTree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.quickTree_MouseClick);
            this.quickTree.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.quickTree_MouseDoubleClick);
            this.quickTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.quickTree_MouseDown);
            // 
            // contextMenuQuick
            // 
            this.contextMenuQuick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripClearGlobalPar,
            this.toolStripMenuRemoveQuickVob});
            this.contextMenuQuick.Name = "contextMenuQuick";
            this.contextMenuQuick.Size = new System.Drawing.Size(259, 48);
            // 
            // toolStripClearGlobalPar
            // 
            this.toolStripClearGlobalPar.Name = "toolStripClearGlobalPar";
            this.toolStripClearGlobalPar.Size = new System.Drawing.Size(258, 22);
            this.toolStripClearGlobalPar.Text = "Очистить глобального родителя";
            this.toolStripClearGlobalPar.Click += new System.EventHandler(this.toolStripClearGlobalPar_Click);
            // 
            // toolStripMenuRemoveQuickVob
            // 
            this.toolStripMenuRemoveQuickVob.Name = "toolStripMenuRemoveQuickVob";
            this.toolStripMenuRemoveQuickVob.Size = new System.Drawing.Size(258, 22);
            this.toolStripMenuRemoveQuickVob.Text = "Удалить воб из быстрого доступа";
            this.toolStripMenuRemoveQuickVob.Click += new System.EventHandler(this.toolStripMenuRemoveQuickVob_Click);
            // 
            // ObjTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 453);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObjTree";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список объектов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ObjTree_FormClosing);
            this.Load += new System.EventHandler(this.ObjTree_Load);
            this.Shown += new System.EventHandler(this.ObjTree_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ObjTree_KeyPress);
            this.contextMenuStripTree.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.contextMenuQuick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView globalTree;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonCollapse;
        private System.Windows.Forms.Button buttonExpand;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTree;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialogVobTree;
        private System.Windows.Forms.SaveFileDialog saveFileDialogVobTree;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem вставитьVobTreeГлобальноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВобToolStripMenuItem;
        private System.Windows.Forms.Button buttonTreeSort;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.ToolStripMenuItem сделатьРодителемДляНовыхВобовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьРодителяДляВобовToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TreeView quickTree;
        private System.Windows.Forms.ToolStripMenuItem AddQuickVobToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuQuick;
        private System.Windows.Forms.ToolStripMenuItem toolStripClearGlobalPar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRemoveQuickVob;
    }
}