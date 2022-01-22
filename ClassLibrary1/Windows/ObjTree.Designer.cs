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
            this.сделатьРодителемДляНовыхВобовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьРодителяДляВобовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonCollapse = new System.Windows.Forms.Button();
            this.buttonExpand = new System.Windows.Forms.Button();
            this.openFileDialogVobTree = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogVobTree = new System.Windows.Forms.SaveFileDialog();
            this.buttonTreeSort = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStripTree.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // globalTree
            // 
            this.globalTree.ContextMenuStrip = this.contextMenuStripTree;
            this.globalTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.globalTree.HideSelection = false;
            this.globalTree.HotTracking = true;
            this.globalTree.ImageIndex = 0;
            this.globalTree.ImageList = this.imageList1;
            this.globalTree.Location = new System.Drawing.Point(0, 43);
            this.globalTree.Name = "globalTree";
            this.globalTree.SelectedImageIndex = 0;
            this.globalTree.Size = new System.Drawing.Size(389, 410);
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
            this.очиститьРодителяДляВобовToolStripMenuItem});
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
            // сделатьРодителемДляНовыхВобовToolStripMenuItem
            // 
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
            this.buttonCollapse.Location = new System.Drawing.Point(12, 10);
            this.buttonCollapse.Name = "buttonCollapse";
            this.buttonCollapse.Size = new System.Drawing.Size(96, 23);
            this.buttonCollapse.TabIndex = 1;
            this.buttonCollapse.Text = "Свернуть все";
            this.buttonCollapse.UseVisualStyleBackColor = true;
            this.buttonCollapse.Click += new System.EventHandler(this.buttonCollapse_Click);
            // 
            // buttonExpand
            // 
            this.buttonExpand.Location = new System.Drawing.Point(114, 10);
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
            this.buttonTreeSort.Location = new System.Drawing.Point(217, 10);
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
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(389, 43);
            this.panelButtons.TabIndex = 4;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(279, 6);
            // 
            // ObjTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 453);
            this.Controls.Add(this.globalTree);
            this.Controls.Add(this.panelButtons);
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
    }
}