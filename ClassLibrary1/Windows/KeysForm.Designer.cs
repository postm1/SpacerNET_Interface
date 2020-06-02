namespace SpacerUnion.Windows
{
    partial class KeysForm
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridKeys = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKeys)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(245, 520);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(101, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Применить";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridKeys
            // 
            this.dataGridKeys.AllowUserToAddRows = false;
            this.dataGridKeys.AllowUserToDeleteRows = false;
            this.dataGridKeys.AllowUserToResizeColumns = false;
            this.dataGridKeys.AllowUserToResizeRows = false;
            this.dataGridKeys.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridKeys.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridKeys.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridKeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKeys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.dataGridKeys.Location = new System.Drawing.Point(12, 12);
            this.dataGridKeys.Name = "dataGridKeys";
            this.dataGridKeys.ReadOnly = true;
            this.dataGridKeys.RowHeadersVisible = false;
            this.dataGridKeys.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridKeys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridKeys.Size = new System.Drawing.Size(580, 502);
            this.dataGridKeys.TabIndex = 5;
            this.dataGridKeys.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridKeys_KeyDown);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Описание";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 350;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Сочетание";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 190;
            // 
            // KeysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 555);
            this.Controls.Add(this.dataGridKeys);
            this.Controls.Add(this.buttonClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeysForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сочетания клавиш";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KeysForm_FormClosing);
            this.Shown += new System.EventHandler(this.KeysForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKeys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        public System.Windows.Forms.DataGridView dataGridKeys;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}