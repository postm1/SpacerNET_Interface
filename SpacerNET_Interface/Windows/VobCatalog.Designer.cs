
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
            this.components = new System.ComponentModel.Container();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.contextMenuStripElem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMove = new System.Windows.Forms.ToolStripMenuItem();
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
            this.buttonSaveCopy = new System.Windows.Forms.Button();
            this.checkBoxHideModel = new System.Windows.Forms.CheckBox();
            this.checkBoxDebugSearch = new System.Windows.Forms.CheckBox();
            this.buttonDebugRemove = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.groupBoxAdv = new System.Windows.Forms.GroupBox();
            this.buttonCompareColl = new System.Windows.Forms.Button();
            this.buttonNoModels = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonSortAlph = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonDownAbs = new System.Windows.Forms.Button();
            this.buttonUPAbs = new System.Windows.Forms.Button();
            this.buttonSortItems = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.contextMenuStripElem.SuspendLayout();
            this.groupBoxGroups.SuspendLayout();
            this.groupBoxItems.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.groupBoxAdv.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(47, 0);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(222, 265);
            this.listBoxGroups.TabIndex = 0;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // listBoxItems
            // 
            this.listBoxItems.ContextMenuStrip = this.contextMenuStripElem;
            this.listBoxItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(0, 0);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(541, 188);
            this.listBoxItems.TabIndex = 1;
            this.listBoxItems.SelectedIndexChanged += new System.EventHandler(this.listBoxItems_SelectedIndexChanged);
            this.listBoxItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxItems_MouseDoubleClick);
            this.listBoxItems.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxItems_MouseDown);
            this.listBoxItems.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBoxItems_MouseUp);
            // 
            // contextMenuStripElem
            // 
            this.contextMenuStripElem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCopy,
            this.toolStripMenuItemMove});
            this.contextMenuStripElem.Name = "contextMenuStripElem";
            this.contextMenuStripElem.Size = new System.Drawing.Size(231, 48);
            // 
            // toolStripMenuItemCopy
            // 
            this.toolStripMenuItemCopy.Name = "toolStripMenuItemCopy";
            this.toolStripMenuItemCopy.Size = new System.Drawing.Size(230, 22);
            this.toolStripMenuItemCopy.Text = "Copy visual to another group";
            this.toolStripMenuItemCopy.Click += new System.EventHandler(this.toolStripMenuItemCopy_Click);
            // 
            // toolStripMenuItemMove
            // 
            this.toolStripMenuItemMove.Name = "toolStripMenuItemMove";
            this.toolStripMenuItemMove.Size = new System.Drawing.Size(230, 22);
            this.toolStripMenuItemMove.Text = "Move visual to another group";
            this.toolStripMenuItemMove.Click += new System.EventHandler(this.toolStripMenuItemMove_Click);
            // 
            // buttonAddNewGroup
            // 
            this.buttonAddNewGroup.Location = new System.Drawing.Point(7, 19);
            this.buttonAddNewGroup.Name = "buttonAddNewGroup";
            this.buttonAddNewGroup.Size = new System.Drawing.Size(144, 23);
            this.buttonAddNewGroup.TabIndex = 2;
            this.buttonAddNewGroup.Text = "Add new group";
            this.buttonAddNewGroup.UseVisualStyleBackColor = true;
            this.buttonAddNewGroup.Click += new System.EventHandler(this.buttonAddNewGroup_Click);
            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.Location = new System.Drawing.Point(6, 77);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(144, 23);
            this.buttonRemoveSelected.TabIndex = 3;
            this.buttonRemoveSelected.Text = "Remove selected group";
            this.buttonRemoveSelected.UseVisualStyleBackColor = true;
            this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
            // 
            // buttonRenameSelected
            // 
            this.buttonRenameSelected.Location = new System.Drawing.Point(6, 48);
            this.buttonRenameSelected.Name = "buttonRenameSelected";
            this.buttonRenameSelected.Size = new System.Drawing.Size(144, 23);
            this.buttonRenameSelected.TabIndex = 5;
            this.buttonRenameSelected.Text = "Rename selected group";
            this.buttonRenameSelected.UseVisualStyleBackColor = true;
            this.buttonRenameSelected.Click += new System.EventHandler(this.buttonRenaneSelected_Click);
            // 
            // buttonUP
            // 
            this.buttonUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUP.Location = new System.Drawing.Point(12, 5);
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
            this.buttonDOWN.Location = new System.Drawing.Point(12, 41);
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
            this.groupBoxGroups.Location = new System.Drawing.Point(47, 4);
            this.groupBoxGroups.Name = "groupBoxGroups";
            this.groupBoxGroups.Size = new System.Drawing.Size(160, 103);
            this.groupBoxGroups.TabIndex = 8;
            this.groupBoxGroups.TabStop = false;
            this.groupBoxGroups.Text = "Groups";
            // 
            // groupBoxItems
            // 
            this.groupBoxItems.Controls.Add(this.buttonChangeProps);
            this.groupBoxItems.Controls.Add(this.buttonRemoveItem);
            this.groupBoxItems.Controls.Add(this.buttonAddElement);
            this.groupBoxItems.Location = new System.Drawing.Point(236, 4);
            this.groupBoxItems.Name = "groupBoxItems";
            this.groupBoxItems.Size = new System.Drawing.Size(176, 103);
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
            this.buttonUpRight.Location = new System.Drawing.Point(9, 5);
            this.buttonUpRight.Name = "buttonUpRight";
            this.buttonUpRight.Size = new System.Drawing.Size(24, 30);
            this.buttonUpRight.TabIndex = 10;
            this.buttonUpRight.Text = "↑";
            this.buttonUpRight.UseVisualStyleBackColor = true;
            this.buttonUpRight.Click += new System.EventHandler(this.buttonUpRight_Click);
            // 
            // buttonDownRight
            // 
            this.buttonDownRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDownRight.Location = new System.Drawing.Point(9, 41);
            this.buttonDownRight.Name = "buttonDownRight";
            this.buttonDownRight.Size = new System.Drawing.Size(24, 30);
            this.buttonDownRight.TabIndex = 11;
            this.buttonDownRight.Text = "↓";
            this.buttonDownRight.UseVisualStyleBackColor = true;
            this.buttonDownRight.Click += new System.EventHandler(this.buttonDownRight_Click);
            // 
            // buttonCreateVob
            // 
            this.buttonCreateVob.Location = new System.Drawing.Point(6, 19);
            this.buttonCreateVob.Name = "buttonCreateVob";
            this.buttonCreateVob.Size = new System.Drawing.Size(163, 23);
            this.buttonCreateVob.TabIndex = 13;
            this.buttonCreateVob.Text = "Create new zCVob";
            this.buttonCreateVob.UseVisualStyleBackColor = true;
            this.buttonCreateVob.Click += new System.EventHandler(this.buttonCreateVob_Click);
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.buttonSaveCopy);
            this.groupBoxActions.Controls.Add(this.buttonCreateVob);
            this.groupBoxActions.Location = new System.Drawing.Point(418, 4);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(177, 103);
            this.groupBoxActions.TabIndex = 10;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // buttonSaveCopy
            // 
            this.buttonSaveCopy.Location = new System.Drawing.Point(6, 48);
            this.buttonSaveCopy.Name = "buttonSaveCopy";
            this.buttonSaveCopy.Size = new System.Drawing.Size(163, 23);
            this.buttonSaveCopy.TabIndex = 16;
            this.buttonSaveCopy.Text = "Save a copy of catalog";
            this.buttonSaveCopy.UseVisualStyleBackColor = true;
            this.buttonSaveCopy.Click += new System.EventHandler(this.buttonSaveCopy_Click);
            // 
            // checkBoxHideModel
            // 
            this.checkBoxHideModel.AutoSize = true;
            this.checkBoxHideModel.Location = new System.Drawing.Point(6, 32);
            this.checkBoxHideModel.Name = "checkBoxHideModel";
            this.checkBoxHideModel.Size = new System.Drawing.Size(168, 17);
            this.checkBoxHideModel.TabIndex = 14;
            this.checkBoxHideModel.Text = "Hide 3D preview when closed";
            this.checkBoxHideModel.UseVisualStyleBackColor = true;
            this.checkBoxHideModel.CheckedChanged += new System.EventHandler(this.checkBoxHideModel_CheckedChanged);
            // 
            // checkBoxDebugSearch
            // 
            this.checkBoxDebugSearch.AutoSize = true;
            this.checkBoxDebugSearch.Location = new System.Drawing.Point(6, 55);
            this.checkBoxDebugSearch.Name = "checkBoxDebugSearch";
            this.checkBoxDebugSearch.Size = new System.Drawing.Size(189, 17);
            this.checkBoxDebugSearch.TabIndex = 15;
            this.checkBoxDebugSearch.Text = "Don\'t show catalog vobs in search";
            this.checkBoxDebugSearch.UseVisualStyleBackColor = true;
            // 
            // buttonDebugRemove
            // 
            this.buttonDebugRemove.Location = new System.Drawing.Point(6, 19);
            this.buttonDebugRemove.Name = "buttonDebugRemove";
            this.buttonDebugRemove.Size = new System.Drawing.Size(241, 23);
            this.buttonDebugRemove.TabIndex = 11;
            this.buttonDebugRemove.Text = "Remove all catalog vobs in location";
            this.buttonDebugRemove.UseVisualStyleBackColor = true;
            this.buttonDebugRemove.Click += new System.EventHandler(this.buttonDebug_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.groupBoxAdv);
            this.panelBottom.Controls.Add(this.groupBoxGroups);
            this.panelBottom.Controls.Add(this.groupBoxActions);
            this.panelBottom.Controls.Add(this.groupBoxItems);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 265);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(858, 113);
            this.panelBottom.TabIndex = 12;
            // 
            // groupBoxAdv
            // 
            this.groupBoxAdv.Controls.Add(this.buttonCompareColl);
            this.groupBoxAdv.Controls.Add(this.buttonNoModels);
            this.groupBoxAdv.Controls.Add(this.buttonDebugRemove);
            this.groupBoxAdv.Location = new System.Drawing.Point(601, 4);
            this.groupBoxAdv.Name = "groupBoxAdv";
            this.groupBoxAdv.Size = new System.Drawing.Size(252, 103);
            this.groupBoxAdv.TabIndex = 17;
            this.groupBoxAdv.TabStop = false;
            this.groupBoxAdv.Text = "Advanced / Debug";
            // 
            // buttonCompareColl
            // 
            this.buttonCompareColl.Location = new System.Drawing.Point(6, 74);
            this.buttonCompareColl.Name = "buttonCompareColl";
            this.buttonCompareColl.Size = new System.Drawing.Size(240, 23);
            this.buttonCompareColl.TabIndex = 18;
            this.buttonCompareColl.Text = "Compare DynColl for objects";
            this.buttonCompareColl.UseVisualStyleBackColor = true;
            this.buttonCompareColl.Click += new System.EventHandler(this.buttonCompareColl_Click);
            // 
            // buttonNoModels
            // 
            this.buttonNoModels.Location = new System.Drawing.Point(6, 46);
            this.buttonNoModels.Name = "buttonNoModels";
            this.buttonNoModels.Size = new System.Drawing.Size(240, 23);
            this.buttonNoModels.TabIndex = 17;
            this.buttonNoModels.Text = "Out models in console if no files";
            this.buttonNoModels.UseVisualStyleBackColor = true;
            this.buttonNoModels.Click += new System.EventHandler(this.buttonNoModels_Click);
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
            this.panelLeft.Size = new System.Drawing.Size(269, 265);
            this.panelLeft.TabIndex = 13;
            // 
            // buttonSortAlph
            // 
            this.buttonSortAlph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortAlph.Location = new System.Drawing.Point(4, 77);
            this.buttonSortAlph.Name = "buttonSortAlph";
            this.buttonSortAlph.Size = new System.Drawing.Size(38, 30);
            this.buttonSortAlph.TabIndex = 8;
            this.buttonSortAlph.Text = "A-Z";
            this.buttonSortAlph.UseVisualStyleBackColor = true;
            this.buttonSortAlph.Click += new System.EventHandler(this.buttonSortAlph_Click);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.listBoxItems);
            this.panelRight.Controls.Add(this.panelButtons);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(269, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(589, 188);
            this.panelRight.TabIndex = 14;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonDownAbs);
            this.panelButtons.Controls.Add(this.buttonUPAbs);
            this.panelButtons.Controls.Add(this.buttonSortItems);
            this.panelButtons.Controls.Add(this.buttonDownRight);
            this.panelButtons.Controls.Add(this.buttonUpRight);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(541, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(48, 188);
            this.panelButtons.TabIndex = 12;
            // 
            // buttonDownAbs
            // 
            this.buttonDownAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDownAbs.Location = new System.Drawing.Point(9, 149);
            this.buttonDownAbs.Name = "buttonDownAbs";
            this.buttonDownAbs.Size = new System.Drawing.Size(24, 30);
            this.buttonDownAbs.TabIndex = 13;
            this.buttonDownAbs.Text = "↧";
            this.buttonDownAbs.UseVisualStyleBackColor = true;
            this.buttonDownAbs.Click += new System.EventHandler(this.buttonDownAbs_Click);
            // 
            // buttonUPAbs
            // 
            this.buttonUPAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUPAbs.Location = new System.Drawing.Point(9, 113);
            this.buttonUPAbs.Name = "buttonUPAbs";
            this.buttonUPAbs.Size = new System.Drawing.Size(24, 30);
            this.buttonUPAbs.TabIndex = 12;
            this.buttonUPAbs.Text = "↥";
            this.buttonUPAbs.UseVisualStyleBackColor = true;
            this.buttonUPAbs.Click += new System.EventHandler(this.buttonUPAbs_Click);
            // 
            // buttonSortItems
            // 
            this.buttonSortItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortItems.Location = new System.Drawing.Point(3, 77);
            this.buttonSortItems.Name = "buttonSortItems";
            this.buttonSortItems.Size = new System.Drawing.Size(38, 30);
            this.buttonSortItems.TabIndex = 9;
            this.buttonSortItems.Text = "A-Z";
            this.buttonSortItems.UseVisualStyleBackColor = true;
            this.buttonSortItems.Click += new System.EventHandler(this.buttonSortItems_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(5, 8);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(47, 13);
            this.labelSearch.TabIndex = 12;
            this.labelSearch.Text = "Search: ";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(60, 6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(514, 20);
            this.textBoxSearch.TabIndex = 13;
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.checkBoxDebugSearch);
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Controls.Add(this.checkBoxHideModel);
            this.panelSearch.Controls.Add(this.labelSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSearch.Location = new System.Drawing.Point(269, 188);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(589, 77);
            this.panelSearch.TabIndex = 15;
            // 
            // VobCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 378);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelBottom);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(874, 417);
            this.Name = "VobCatalogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vob Catalog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VobCatalogForm_FormClosing);
            this.Load += new System.EventHandler(this.VobCatalogForm_Load);
            this.Shown += new System.EventHandler(this.VobCatalogForm_Shown);
            this.VisibleChanged += new System.EventHandler(this.VobCatalogForm_VisibleChanged);
            this.contextMenuStripElem.ResumeLayout(false);
            this.groupBoxGroups.ResumeLayout(false);
            this.groupBoxItems.ResumeLayout(false);
            this.groupBoxActions.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.groupBoxAdv.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listBoxGroups;
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
        private System.Windows.Forms.Button buttonSortItems;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button buttonDebugRemove;
        private System.Windows.Forms.Panel panelButtons;
        public System.Windows.Forms.CheckBox checkBoxDebugSearch;
        private System.Windows.Forms.Button buttonSaveCopy;
        private System.Windows.Forms.Button buttonDownAbs;
        private System.Windows.Forms.Button buttonUPAbs;
        private System.Windows.Forms.Button buttonNoModels;
        private System.Windows.Forms.GroupBox groupBoxAdv;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripElem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMove;
        private System.Windows.Forms.Button buttonCompareColl;
    }
}