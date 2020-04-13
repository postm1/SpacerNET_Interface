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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonCollapse = new System.Windows.Forms.Button();
            this.buttonExpand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // globalTree
            // 
            this.globalTree.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.globalTree.HideSelection = false;
            this.globalTree.ImageIndex = 0;
            this.globalTree.ImageList = this.imageList1;
            this.globalTree.Location = new System.Drawing.Point(0, 44);
            this.globalTree.Name = "globalTree";
            this.globalTree.SelectedImageIndex = 0;
            this.globalTree.Size = new System.Drawing.Size(389, 431);
            this.globalTree.TabIndex = 0;
            this.globalTree.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.globalTree_DrawNode);
            this.globalTree.DoubleClick += new System.EventHandler(this.globalTree_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder-vertical-document-icon.png");
            this.imageList1.Images.SetKeyName(1, "pointred.jpg");
            this.imageList1.Images.SetKeyName(2, "pointvio.jpg");
            this.imageList1.Images.SetKeyName(3, "green.jpg");
            // 
            // buttonCollapse
            // 
            this.buttonCollapse.Location = new System.Drawing.Point(2, 12);
            this.buttonCollapse.Name = "buttonCollapse";
            this.buttonCollapse.Size = new System.Drawing.Size(110, 23);
            this.buttonCollapse.TabIndex = 1;
            this.buttonCollapse.Text = "Свернуть все";
            this.buttonCollapse.UseVisualStyleBackColor = true;
            this.buttonCollapse.Click += new System.EventHandler(this.buttonCollapse_Click);
            // 
            // buttonExpand
            // 
            this.buttonExpand.Location = new System.Drawing.Point(118, 12);
            this.buttonExpand.Name = "buttonExpand";
            this.buttonExpand.Size = new System.Drawing.Size(110, 23);
            this.buttonExpand.TabIndex = 2;
            this.buttonExpand.Text = "Развернуть все";
            this.buttonExpand.UseVisualStyleBackColor = true;
            this.buttonExpand.Click += new System.EventHandler(this.buttonExpand_Click);
            // 
            // ObjTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 475);
            this.Controls.Add(this.buttonExpand);
            this.Controls.Add(this.buttonCollapse);
            this.Controls.Add(this.globalTree);
            this.Name = "ObjTree";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Список объектов";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView globalTree;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonCollapse;
        private System.Windows.Forms.Button buttonExpand;
    }
}