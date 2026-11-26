namespace SpacerUnion.Windows
{
    partial class SettingsMain
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
            this.panelContent = new SpacerUnion.Common.Extended.DBufPanel();
            this.panelSearchHost = new System.Windows.Forms.Panel();
            this.tableSearchRow = new System.Windows.Forms.TableLayoutPanel();
            this.panelSearchButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearchPrev = new System.Windows.Forms.Button();
            this.buttonSearchNext = new System.Windows.Forms.Button();
            this.buttonClearSearch = new System.Windows.Forms.Button();
            this.labelSearchInfo = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.labelApplyHint = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.panelSearchHost.SuspendLayout();
            this.tableSearchRow.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelSearchButtons.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(220, 66);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.panelContent.Size = new System.Drawing.Size(780, 556);
            this.panelContent.TabIndex = 0;
            // 
            // panelSearchHost
            // 
            this.panelSearchHost.Controls.Add(this.tableSearchRow);
            this.panelSearchHost.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchHost.Location = new System.Drawing.Point(0, 0);
            this.panelSearchHost.Name = "panelSearchHost";
            this.panelSearchHost.Padding = new System.Windows.Forms.Padding(16, 10, 16, 6);
            this.panelSearchHost.Size = new System.Drawing.Size(1000, 46);
            this.panelSearchHost.TabIndex = 1;
            // 
            // tableSearchRow
            // 
            this.tableSearchRow.ColumnCount = 3;
            this.tableSearchRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSearchRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableSearchRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSearchRow.Controls.Add(this.panelSearch, 0, 0);
            this.tableSearchRow.Controls.Add(this.panelSearchButtons, 1, 0);
            this.tableSearchRow.Controls.Add(this.labelSearchInfo, 2, 0);
            this.tableSearchRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSearchRow.Location = new System.Drawing.Point(16, 10);
            this.tableSearchRow.Margin = new System.Windows.Forms.Padding(0);
            this.tableSearchRow.Name = "tableSearchRow";
            this.tableSearchRow.RowCount = 1;
            this.tableSearchRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableSearchRow.Size = new System.Drawing.Size(968, 30);
            this.tableSearchRow.TabIndex = 0;
            // 
            // panelSearch
            // 
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Padding = new System.Windows.Forms.Padding(8, 1, 4, 1);
            this.panelSearch.Size = new System.Drawing.Size(472, 26);
            this.panelSearch.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearch.Location = new System.Drawing.Point(8, 1);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(440, 20);
            this.textBoxSearch.TabIndex = 0;
            // 
            // panelSearchButtons
            // 
            this.panelSearchButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSearchButtons.AutoSize = true;
            this.panelSearchButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSearchButtons.Controls.Add(this.buttonSearchPrev);
            this.panelSearchButtons.Controls.Add(this.buttonSearchNext);
            this.panelSearchButtons.Controls.Add(this.buttonClearSearch);
            this.panelSearchButtons.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.panelSearchButtons.Location = new System.Drawing.Point(480, 1);
            this.panelSearchButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panelSearchButtons.Name = "panelSearchButtons";
            this.panelSearchButtons.Size = new System.Drawing.Size(100, 24);
            this.panelSearchButtons.TabIndex = 1;
            this.panelSearchButtons.WrapContents = false;
            // 
            // buttonSearchPrev
            // 
            this.buttonSearchPrev.Enabled = false;
            this.buttonSearchPrev.FlatAppearance.BorderSize = 0;
            this.buttonSearchPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchPrev.Location = new System.Drawing.Point(2, 2);
            this.buttonSearchPrev.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearchPrev.Name = "buttonSearchPrev";
            this.buttonSearchPrev.Size = new System.Drawing.Size(30, 24);
            this.buttonSearchPrev.TabIndex = 0;
            this.buttonSearchPrev.TabStop = false;
            this.buttonSearchPrev.Text = "←";
            this.buttonSearchPrev.UseVisualStyleBackColor = true;
            // 
            // buttonSearchNext
            // 
            this.buttonSearchNext.Enabled = false;
            this.buttonSearchNext.FlatAppearance.BorderSize = 0;
            this.buttonSearchNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchNext.Location = new System.Drawing.Point(36, 2);
            this.buttonSearchNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearchNext.Name = "buttonSearchNext";
            this.buttonSearchNext.Size = new System.Drawing.Size(30, 24);
            this.buttonSearchNext.TabIndex = 1;
            this.buttonSearchNext.TabStop = false;
            this.buttonSearchNext.Text = "→";
            this.buttonSearchNext.UseVisualStyleBackColor = true;
            // 
            // buttonClearSearch
            // 
            this.buttonClearSearch.FlatAppearance.BorderSize = 0;
            this.buttonClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearSearch.Location = new System.Drawing.Point(70, 2);
            this.buttonClearSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(30, 24);
            this.buttonClearSearch.TabIndex = 2;
            this.buttonClearSearch.TabStop = false;
            this.buttonClearSearch.Text = "×";
            this.buttonClearSearch.UseVisualStyleBackColor = true;
            // 
            // labelSearchInfo
            // 
            this.labelSearchInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSearchInfo.Location = new System.Drawing.Point(592, 3);
            this.labelSearchInfo.Name = "labelSearchInfo";
            this.labelSearchInfo.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.labelSearchInfo.Size = new System.Drawing.Size(376, 24);
            this.labelSearchInfo.TabIndex = 2;
            this.labelSearchInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSearchInfo.Text = "search info";
            // 
            // panelLeft
            // 
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 62);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(12, 8, 4, 8);
            this.panelLeft.Size = new System.Drawing.Size(220, 562);
            this.panelLeft.TabIndex = 2;
            // 
            // panelLeft holds the navigation list, it is created in SettingsMain.
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.labelApplyHint);
            this.panelBottom.Controls.Add(this.buttonApply);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(220, 626);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(16, 8, 16, 12);
            this.panelBottom.Size = new System.Drawing.Size(780, 62);
            this.panelBottom.TabIndex = 3;
            // 
            // labelApplyHint
            // 
            this.labelApplyHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelApplyHint.Location = new System.Drawing.Point(16, 8);
            this.labelApplyHint.Name = "labelApplyHint";
            this.labelApplyHint.Padding = new System.Windows.Forms.Padding(0, 9, 12, 0);
            this.labelApplyHint.Size = new System.Drawing.Size(608, 42);
            this.labelApplyHint.TabIndex = 0;
            this.labelApplyHint.Text = "apply hint";
            // 
            // buttonApply
            // 
            this.buttonApply.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonApply.Location = new System.Drawing.Point(624, 8);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(140, 42);
            this.buttonApply.TabIndex = 1;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // SettingsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 690);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelSearchHost);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(760, 420);
            this.Name = "SettingsMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsMain";
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelSearchButtons.ResumeLayout(false);
            this.panelSearchButtons.PerformLayout();
            this.tableSearchRow.ResumeLayout(false);
            this.tableSearchRow.PerformLayout();
            this.panelSearchHost.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SpacerUnion.Common.Extended.DBufPanel panelContent;
        private System.Windows.Forms.Panel panelSearchHost;
        private System.Windows.Forms.TableLayoutPanel tableSearchRow;
        private System.Windows.Forms.FlowLayoutPanel panelSearchButtons;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearchPrev;
        private System.Windows.Forms.Button buttonSearchNext;
        private System.Windows.Forms.Button buttonClearSearch;
        private System.Windows.Forms.Label labelSearchInfo;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label labelApplyHint;
        private System.Windows.Forms.Button buttonApply;
    }
}
