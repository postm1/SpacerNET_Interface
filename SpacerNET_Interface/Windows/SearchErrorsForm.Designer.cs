
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
            this.columnHeaderNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListErrorsType = new System.Windows.Forms.ImageList(this.components);
            this.buttonErrorsSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSaveReport = new System.Windows.Forms.Button();
            this.comboBoxErrFilter = new System.Windows.Forms.ComboBox();
            this.buttonAutoFix = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewErrors
            // 
            this.listViewErrors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNum,
            this.columnType,
            this.columnColor,
            this.columnDesc,
            this.columnVob});
            this.listViewErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewErrors.FullRowSelect = true;
            this.listViewErrors.HideSelection = false;
            this.listViewErrors.LabelWrap = false;
            this.listViewErrors.Location = new System.Drawing.Point(0, 0);
            this.listViewErrors.MultiSelect = false;
            this.listViewErrors.Name = "listViewErrors";
            this.listViewErrors.Size = new System.Drawing.Size(716, 212);
            this.listViewErrors.TabIndex = 0;
            this.listViewErrors.UseCompatibleStateImageBehavior = false;
            this.listViewErrors.View = System.Windows.Forms.View.Details;
            this.listViewErrors.DoubleClick += new System.EventHandler(this.listViewErrors_DoubleClick);
            this.listViewErrors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewErrors_MouseDown);
            // 
            // columnHeaderNum
            // 
            this.columnHeaderNum.Text = "№";
            this.columnHeaderNum.Width = 40;
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
            this.columnDesc.Width = 150;
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
            this.buttonErrorsSearch.Location = new System.Drawing.Point(12, 11);
            this.buttonErrorsSearch.Name = "buttonErrorsSearch";
            this.buttonErrorsSearch.Size = new System.Drawing.Size(159, 23);
            this.buttonErrorsSearch.TabIndex = 1;
            this.buttonErrorsSearch.Text = "Find ZEN problems";
            this.buttonErrorsSearch.UseVisualStyleBackColor = true;
            this.buttonErrorsSearch.Click += new System.EventHandler(this.buttonErrorsSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonAutoFix);
            this.panel1.Controls.Add(this.buttonSaveReport);
            this.panel1.Controls.Add(this.comboBoxErrFilter);
            this.panel1.Controls.Add(this.buttonErrorsSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 50);
            this.panel1.TabIndex = 2;
            // 
            // buttonSaveReport
            // 
            this.buttonSaveReport.Location = new System.Drawing.Point(375, 11);
            this.buttonSaveReport.Name = "buttonSaveReport";
            this.buttonSaveReport.Size = new System.Drawing.Size(159, 23);
            this.buttonSaveReport.TabIndex = 3;
            this.buttonSaveReport.Text = "Save report to txt";
            this.buttonSaveReport.UseVisualStyleBackColor = true;
            this.buttonSaveReport.Click += new System.EventHandler(this.buttonSaveReport_Click);
            // 
            // comboBoxErrFilter
            // 
            this.comboBoxErrFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxErrFilter.FormattingEnabled = true;
            this.comboBoxErrFilter.Items.AddRange(new object[] {
            "All",
            "Info",
            "Warning",
            "Critical"});
            this.comboBoxErrFilter.Location = new System.Drawing.Point(191, 12);
            this.comboBoxErrFilter.Name = "comboBoxErrFilter";
            this.comboBoxErrFilter.Size = new System.Drawing.Size(160, 21);
            this.comboBoxErrFilter.TabIndex = 2;
            this.comboBoxErrFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxErrFilter_SelectedIndexChanged);
            // 
            // buttonAutoFix
            // 
            this.buttonAutoFix.Location = new System.Drawing.Point(540, 11);
            this.buttonAutoFix.Name = "buttonAutoFix";
            this.buttonAutoFix.Size = new System.Drawing.Size(159, 23);
            this.buttonAutoFix.TabIndex = 4;
            this.buttonAutoFix.Text = "Auto fix problems";
            this.buttonAutoFix.UseVisualStyleBackColor = true;
            this.buttonAutoFix.Click += new System.EventHandler(this.buttonAutoFix_Click);
            // 
            // SearchErrorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 262);
            this.Controls.Add(this.listViewErrors);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(732, 301);
            this.Name = "SearchErrorsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchErrorsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchErrorsForm_FormClosing);
            this.Load += new System.EventHandler(this.SearchErrorsForm_Load);
            this.VisibleChanged += new System.EventHandler(this.SearchErrorsForm_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnDesc;
        private System.Windows.Forms.ColumnHeader columnVob;
        private System.Windows.Forms.Button buttonErrorsSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader columnColor;
        private System.Windows.Forms.ImageList imageListErrorsType;
        private System.Windows.Forms.ColumnHeader columnHeaderNum;
        public System.Windows.Forms.ListView listViewErrors;
        private System.Windows.Forms.ComboBox comboBoxErrFilter;
        private System.Windows.Forms.Button buttonSaveReport;
        private System.Windows.Forms.Button buttonAutoFix;
    }
}