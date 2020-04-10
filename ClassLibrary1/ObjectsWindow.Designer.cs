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
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("zCWaypoint::zCVob:");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Узел4");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Internals", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("vobName");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Vob", new System.Windows.Forms.TreeNode[] {
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Узел6");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Узел5", new System.Windows.Forms.TreeNode[] {
            treeNode20});
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.classesTreeView = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(320, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.classesTreeView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(312, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(296, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modify";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 3);
            this.treeView1.Name = "treeView1";
            treeNode15.Name = "Узел0";
            treeNode15.Text = "zCWaypoint::zCVob:";
            treeNode16.Name = "Узел4";
            treeNode16.Text = "Узел4";
            treeNode17.Checked = true;
            treeNode17.Name = "Узел1";
            treeNode17.Text = "Internals";
            treeNode18.Name = "Узел3";
            treeNode18.Text = "vobName";
            treeNode19.Checked = true;
            treeNode19.Name = "Узел2";
            treeNode19.Text = "Vob";
            treeNode20.Name = "Узел6";
            treeNode20.Text = "Узел6";
            treeNode21.Name = "Узел5";
            treeNode21.Text = "Узел5";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode17,
            treeNode19,
            treeNode21});
            this.treeView1.Size = new System.Drawing.Size(284, 399);
            this.treeView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(296, 408);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "...";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // classesTreeView
            // 
            this.classesTreeView.Dock = System.Windows.Forms.DockStyle.Top;
            this.classesTreeView.Location = new System.Drawing.Point(3, 3);
            this.classesTreeView.Name = "classesTreeView";
            this.classesTreeView.Size = new System.Drawing.Size(306, 323);
            this.classesTreeView.TabIndex = 0;
            // 
            // ObjectsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 451);
            this.Controls.Add(this.tabControl1);
            this.Name = "ObjectsWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Objects";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TreeView classesTreeView;
    }
}