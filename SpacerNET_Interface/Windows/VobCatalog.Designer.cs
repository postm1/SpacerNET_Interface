
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
            this.buttonRenameSelected = new System.Windows.Forms.Button();
            this.buttonUP = new System.Windows.Forms.Button();
            this.buttonDOWN = new System.Windows.Forms.Button();
            this.groupBoxGroups = new System.Windows.Forms.GroupBox();
            this.groupBoxItems = new System.Windows.Forms.GroupBox();
            this.buttonChangeProps = new System.Windows.Forms.Button();
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.buttonAddElement = new System.Windows.Forms.Button();
            this.buttonUpRight = new System.Windows.Forms.Button();
            this.buttonDownRight = new System.Windows.Forms.Button();
            this.buttonCreateVob = new System.Windows.Forms.Button();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.checkBoxHideModel = new System.Windows.Forms.CheckBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.buttonSortAlph = new System.Windows.Forms.Button();
            this.groupBoxGroups.SuspendLayout();
            this.groupBoxItems.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(47, 0);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(189, 203);
            this.listBoxGroups.TabIndex = 0;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // listBoxItems
            // 
            this.listBoxItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(0, 0);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(417, 203);
            this.listBoxItems.TabIndex = 1;
            this.listBoxItems.SelectedIndexChanged += new System.EventHandler(this.listBoxItems_SelectedIndexChanged);
            this.listBoxItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxItems_MouseDoubleClick);
            this.listBoxItems.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxItems_MouseDown);
            // 
            // buttonAddNewGroup
            // 
            this.buttonAddNewGroup.Location = new System.Drawing.Point(19, 16);
            this.buttonAddNewGroup.Name = "buttonAddNewGroup";
            this.buttonAddNewGroup.Size = new System.Drawing.Size(161, 23);
            this.buttonAddNewGroup.TabIndex = 2;
            this.buttonAddNewGroup.Text = "Add new group";
            this.buttonAddNewGroup.UseVisualStyleBackColor = true;
            this.buttonAddNewGroup.Click += new System.EventHandler(this.buttonAddNewGroup_Click);
            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.Location = new System.Drawing.Point(18, 74);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(161, 23);
            this.buttonRemoveSelected.TabIndex = 3;
            this.buttonRemoveSelected.Text = "Remove selected group";
            this.buttonRemoveSelected.UseVisualStyleBackColor = true;
            this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
            // 
            // buttonRenameSelected
            // 
            this.buttonRenameSelected.Location = new System.Drawing.Point(18, 45);
            this.buttonRenameSelected.Name = "buttonRenameSelected";
            this.buttonRenameSelected.Size = new System.Drawing.Size(161, 23);
            this.buttonRenameSelected.TabIndex = 5;
            this.buttonRenameSelected.Text = "Rename selected group";
            this.buttonRenameSelected.UseVisualStyleBackColor = true;
            this.buttonRenameSelected.Click += new System.EventHandler(this.buttonRenaneSelected_Click);
            // 
            // buttonUP
            // 
            this.buttonUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUP.Location = new System.Drawing.Point(3, 16);
            this.buttonUP.Name = "buttonUP";
            this.buttonUP.Size = new System.Drawing.Size(23, 30);
            this.buttonUP.TabIndex = 6;
            this.buttonUP.Text = "↑";
            this.buttonUP.UseVisualStyleBackColor = true;
            this.buttonUP.Click += new System.EventHandler(this.buttonUP_Click);
            // 
            // buttonDOWN
            // 
            this.buttonDOWN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDOWN.Location = new System.Drawing.Point(3, 52);
            this.buttonDOWN.Name = "buttonDOWN";
            this.buttonDOWN.Size = new System.Drawing.Size(23, 30);
            this.buttonDOWN.TabIndex = 7;
            this.buttonDOWN.Text = "↓";
            this.buttonDOWN.UseVisualStyleBackColor = true;
            this.buttonDOWN.Click += new System.EventHandler(this.buttonDOWN_Click);
            // 
            // groupBoxGroups
            // 
            this.groupBoxGroups.Controls.Add(this.buttonRenameSelected);
            this.groupBoxGroups.Controls.Add(this.buttonAddNewGroup);
            this.groupBoxGroups.Controls.Add(this.buttonRemoveSelected);
            this.groupBoxGroups.Location = new System.Drawing.Point(12, 10);
            this.groupBoxGroups.Name = "groupBoxGroups";
            this.groupBoxGroups.Size = new System.Drawing.Size(191, 103);
            this.groupBoxGroups.TabIndex = 8;
            this.groupBoxGroups.TabStop = false;
            this.groupBoxGroups.Text = "Groups";
            // 
            // groupBoxItems
            // 
            this.groupBoxItems.Controls.Add(this.buttonChangeProps);
            this.groupBoxItems.Controls.Add(this.buttonRemoveItem);
            this.groupBoxItems.Controls.Add(this.buttonAddElement);
            this.groupBoxItems.Location = new System.Drawing.Point(210, 10);
            this.groupBoxItems.Name = "groupBoxItems";
            this.groupBoxItems.Size = new System.Drawing.Size(188, 103);
            this.groupBoxItems.TabIndex = 9;
            this.groupBoxItems.TabStop = false;
            this.groupBoxItems.Text = "Elements";
            // 
            // buttonChangeProps
            // 
            this.buttonChangeProps.Location = new System.Drawing.Point(6, 45);
            this.buttonChangeProps.Name = "buttonChangeProps";
            this.buttonChangeProps.Size = new System.Drawing.Size(161, 23);
            this.buttonChangeProps.TabIndex = 8;
            this.buttonChangeProps.Text = "Change selected element";
            this.buttonChangeProps.UseVisualStyleBackColor = true;
            this.buttonChangeProps.Click += new System.EventHandler(this.buttonChangeProps_Click);
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.Location = new System.Drawing.Point(6, 74);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(161, 23);
            this.buttonRemoveItem.TabIndex = 7;
            this.buttonRemoveItem.Text = "Remove selected item";
            this.buttonRemoveItem.UseVisualStyleBackColor = true;
            this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // buttonAddElement
            // 
            this.buttonAddElement.Location = new System.Drawing.Point(6, 19);
            this.buttonAddElement.Name = "buttonAddElement";
            this.buttonAddElement.Size = new System.Drawing.Size(161, 23);
            this.buttonAddElement.TabIndex = 6;
            this.buttonAddElement.Text = "Add new";
            this.buttonAddElement.UseVisualStyleBackColor = true;
            this.buttonAddElement.Click += new System.EventHandler(this.buttonAddElement_Click);
            // 
            // buttonUpRight
            // 
            this.buttonUpRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpRight.Location = new System.Drawing.Point(423, 16);
            this.buttonUpRight.Name = "buttonUpRight";
            this.buttonUpRight.Size = new System.Drawing.Size(23, 30);
            this.buttonUpRight.TabIndex = 10;
            this.buttonUpRight.Text = "↑";
            this.buttonUpRight.UseVisualStyleBackColor = true;
            this.buttonUpRight.Click += new System.EventHandler(this.buttonUpRight_Click);
            // 
            // buttonDownRight
            // 
            this.buttonDownRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDownRight.Location = new System.Drawing.Point(423, 52);
            this.buttonDownRight.Name = "buttonDownRight";
            this.buttonDownRight.Size = new System.Drawing.Size(23, 30);
            this.buttonDownRight.TabIndex = 11;
            this.buttonDownRight.Text = "↓";
            this.buttonDownRight.UseVisualStyleBackColor = true;
            this.buttonDownRight.Click += new System.EventHandler(this.buttonDownRight_Click);
            // 
            // buttonCreateVob
            // 
            this.buttonCreateVob.Location = new System.Drawing.Point(6, 19);
            this.buttonCreateVob.Name = "buttonCreateVob";
            this.buttonCreateVob.Size = new System.Drawing.Size(170, 23);
            this.buttonCreateVob.TabIndex = 13;
            this.buttonCreateVob.Text = "Create new zCVob";
            this.buttonCreateVob.UseVisualStyleBackColor = true;
            this.buttonCreateVob.Click += new System.EventHandler(this.buttonCreateVob_Click);
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.checkBoxHideModel);
            this.groupBoxActions.Controls.Add(this.buttonCreateVob);
            this.groupBoxActions.Location = new System.Drawing.Point(404, 10);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(192, 103);
            this.groupBoxActions.TabIndex = 10;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // checkBoxHideModel
            // 
            this.checkBoxHideModel.AutoSize = true;
            this.checkBoxHideModel.Location = new System.Drawing.Point(8, 61);
            this.checkBoxHideModel.Name = "checkBoxHideModel";
            this.checkBoxHideModel.Size = new System.Drawing.Size(168, 17);
            this.checkBoxHideModel.TabIndex = 14;
            this.checkBoxHideModel.Text = "Hide 3D preview when closed";
            this.checkBoxHideModel.UseVisualStyleBackColor = true;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.groupBoxGroups);
            this.panelBottom.Controls.Add(this.groupBoxActions);
            this.panelBottom.Controls.Add(this.groupBoxItems);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 203);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(694, 125);
            this.panelBottom.TabIndex = 12;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.buttonSortAlph);
            this.panelLeft.Controls.Add(this.buttonUP);
            this.panelLeft.Controls.Add(this.buttonDOWN);
            this.panelLeft.Controls.Add(this.listBoxGroups);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(236, 203);
            this.panelLeft.TabIndex = 13;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.listBoxItems);
            this.panelRight.Controls.Add(this.buttonUpRight);
            this.panelRight.Controls.Add(this.buttonDownRight);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(236, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(458, 203);
            this.panelRight.TabIndex = 14;
            // 
            // buttonSortAlph
            // 
            this.buttonSortAlph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortAlph.Location = new System.Drawing.Point(3, 88);
            this.buttonSortAlph.Name = "buttonSortAlph";
            this.buttonSortAlph.Size = new System.Drawing.Size(38, 30);
            this.buttonSortAlph.TabIndex = 8;
            this.buttonSortAlph.Text = "A-Z";
            this.buttonSortAlph.UseVisualStyleBackColor = true;
            this.buttonSortAlph.Click += new System.EventHandler(this.buttonSortAlph_Click);
            // 
            // VobCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 328);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelBottom);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(710, 367);
            this.Name = "VobCatalogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vob Catalog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VobCatalogForm_FormClosing);
            this.Shown += new System.EventHandler(this.VobCatalogForm_Shown);
            this.VisibleChanged += new System.EventHandler(this.VobCatalogForm_VisibleChanged);
            this.groupBoxGroups.ResumeLayout(false);
            this.groupBoxItems.ResumeLayout(false);
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxActions.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Button buttonAddNewGroup;
        private System.Windows.Forms.Button buttonRemoveSelected;
        private System.Windows.Forms.Button buttonRenameSelected;
        private System.Windows.Forms.Button buttonUP;
        private System.Windows.Forms.Button buttonDOWN;
        private System.Windows.Forms.GroupBox groupBoxGroups;
        private System.Windows.Forms.GroupBox groupBoxItems;
        private System.Windows.Forms.Button buttonAddElement;
        private System.Windows.Forms.Button buttonRemoveItem;
        private System.Windows.Forms.Button buttonUpRight;
        private System.Windows.Forms.Button buttonDownRight;
        public System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.Button buttonChangeProps;
        private System.Windows.Forms.Button buttonCreateVob;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.CheckBox checkBoxHideModel;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button buttonSortAlph;
    }
}