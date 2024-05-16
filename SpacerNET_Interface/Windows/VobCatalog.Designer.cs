
namespace SpacerUnion.Windows
{
    partial class VobCatalogForm
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
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.buttonAddNewGroup = new System.Windows.Forms.Button();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRenameSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(12, 12);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(162, 173);
            this.listBoxGroups.TabIndex = 0;
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(180, 12);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(344, 173);
            this.listBoxItems.TabIndex = 1;
            // 
            // buttonAddNewGroup
            // 
            this.buttonAddNewGroup.Location = new System.Drawing.Point(13, 203);
            this.buttonAddNewGroup.Name = "buttonAddNewGroup";
            this.buttonAddNewGroup.Size = new System.Drawing.Size(161, 23);
            this.buttonAddNewGroup.TabIndex = 2;
            this.buttonAddNewGroup.Text = "Add new group";
            this.buttonAddNewGroup.UseVisualStyleBackColor = true;
            this.buttonAddNewGroup.Click += new System.EventHandler(this.buttonAddNewGroup_Click);
            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.Location = new System.Drawing.Point(12, 232);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(161, 23);
            this.buttonRemoveSelected.TabIndex = 3;
            this.buttonRemoveSelected.Text = "Remove selected group";
            this.buttonRemoveSelected.UseVisualStyleBackColor = true;
            this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonRenameSelected
            // 
            this.buttonRenameSelected.Location = new System.Drawing.Point(13, 263);
            this.buttonRenameSelected.Name = "buttonRenameSelected";
            this.buttonRenameSelected.Size = new System.Drawing.Size(161, 23);
            this.buttonRenameSelected.TabIndex = 5;
            this.buttonRenameSelected.Text = "Rename selected group";
            this.buttonRenameSelected.UseVisualStyleBackColor = true;
            this.buttonRenameSelected.Click += new System.EventHandler(this.buttonRenaneSelected_Click);
            // 
            // VobCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 298);
            this.Controls.Add(this.buttonRenameSelected);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRemoveSelected);
            this.Controls.Add(this.buttonAddNewGroup);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.listBoxGroups);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VobCatalogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VobCatalog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.Button buttonAddNewGroup;
        private System.Windows.Forms.Button buttonRemoveSelected;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRenameSelected;
    }
}