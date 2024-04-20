
namespace SpacerUnion.Windows
{
    partial class SearchErrorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchErrorsForm));
            this.listViewErrors = new System.Windows.Forms.ListView();
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListErrorsType = new System.Windows.Forms.ImageList(this.components);
            this.buttonErrorsSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewErrors
            // 
            this.listViewErrors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnType,
            this.columnColor,
            this.columnDesc,
            this.columnVob});
            this.listViewErrors.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewErrors.FullRowSelect = true;
            this.listViewErrors.HideSelection = false;
            this.listViewErrors.LabelWrap = false;
            this.listViewErrors.Location = new System.Drawing.Point(0, 0);
            this.listViewErrors.Name = "listViewErrors";
            this.listViewErrors.Size = new System.Drawing.Size(1027, 554);
            this.listViewErrors.TabIndex = 0;
            this.listViewErrors.UseCompatibleStateImageBehavior = false;
            this.listViewErrors.View = System.Windows.Forms.View.Details;
            this.listViewErrors.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewErrors_ColumnClick);
            this.listViewErrors.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewErrors_MouseClick);
            // 
            // columnType
            // 
            this.columnType.Text = "Problem type";
            this.columnType.Width = 200;
            // 
            // columnColor
            // 
            this.columnColor.Text = "Type";
            this.columnColor.Width = 120;
            // 
            // columnDesc
            // 
            this.columnDesc.Text = "Description";
            this.columnDesc.Width = 450;
            // 
            // columnVob
            // 
            this.columnVob.Text = "Vob/Material";
            this.columnVob.Width = 150;
            // 
            // imageListErrorsType
            // 
            this.imageListErrorsType.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListErrorsType.ImageStream")));
            this.imageListErrorsType.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListErrorsType.Images.SetKeyName(0, "err_red.png");
            this.imageListErrorsType.Images.SetKeyName(1, "err_yellow.png");
            this.imageListErrorsType.Images.SetKeyName(2, "err_green.png");
            // 
            // buttonErrorsSearch
            // 
            this.buttonErrorsSearch.Location = new System.Drawing.Point(12, 27);
            this.buttonErrorsSearch.Name = "buttonErrorsSearch";
            this.buttonErrorsSearch.Size = new System.Drawing.Size(137, 23);
            this.buttonErrorsSearch.TabIndex = 1;
            this.buttonErrorsSearch.Text = "Find ZEN problems";
            this.buttonErrorsSearch.UseVisualStyleBackColor = true;
            this.buttonErrorsSearch.Click += new System.EventHandler(this.buttonErrorsSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonErrorsSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 560);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 89);
            this.panel1.TabIndex = 2;
            // 
            // SearchErrorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 649);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewErrors);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchErrorsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchErrorsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchErrorsForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewErrors;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnDesc;
        private System.Windows.Forms.ColumnHeader columnVob;
        private System.Windows.Forms.Button buttonErrorsSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader columnColor;
        private System.Windows.Forms.ImageList imageListErrorsType;
    }
}