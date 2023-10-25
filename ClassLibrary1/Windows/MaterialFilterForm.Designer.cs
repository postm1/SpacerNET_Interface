namespace SpacerUnion.Windows
{
    partial class MaterialFilterForm
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
            this.tabControlMatFilter = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMatFilter_NewMat = new System.Windows.Forms.Button();
            this.groupBoxTexInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxFilterTexShowSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxFilterTexAutoScale = new System.Windows.Forms.CheckBox();
            this.checkBoxTexImageAlwaysCenter = new System.Windows.Forms.CheckBox();
            this.checkBoxTexImageUseAlpha = new System.Windows.Forms.CheckBox();
            this.pictureBoxTexture = new System.Windows.Forms.PictureBox();
            this.textBoxTexName = new System.Windows.Forms.TextBox();
            this.labelTexAlpha = new System.Windows.Forms.Label();
            this.labelTexSize = new System.Windows.Forms.Label();
            this.textBoxFilterSearch = new System.Windows.Forms.TextBox();
            this.labelMatFilterSeachInMats = new System.Windows.Forms.Label();
            this.listBoxMatFilSearch = new System.Windows.Forms.ListBox();
            this.buttonFilterNew = new System.Windows.Forms.Button();
            this.buttonFltRename = new System.Windows.Forms.Button();
            this.buttonMatFilterSaveFilters = new System.Windows.Forms.Button();
            this.groupBoxMatSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxMatFilter_ForceFilter = new System.Windows.Forms.CheckBox();
            this.checkBoxMatFilterGoApply = new System.Windows.Forms.CheckBox();
            this.buttonApplyMatSettings = new System.Windows.Forms.Button();
            this.labelApplyFilter = new System.Windows.Forms.Label();
            this.labelFilterApplyGroup = new System.Windows.Forms.Label();
            this.comboBoxApplyFilter = new System.Windows.Forms.ComboBox();
            this.comboBoxApplyGroup = new System.Windows.Forms.ComboBox();
            this.buttonSavePML_File = new System.Windows.Forms.Button();
            this.labelMatCountCurrentFilter = new System.Windows.Forms.Label();
            this.listBoxMatList = new System.Windows.Forms.ListBox();
            this.listBoxFilter = new System.Windows.Forms.ListBox();
            this.labelFilterListFiles = new System.Windows.Forms.Label();
            this.panelMatFilterMain = new System.Windows.Forms.Panel();
            this.groupBoxMatFilterMisc = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusFilterMat = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxFilterMenu = new System.Windows.Forms.GroupBox();
            this.buttonMatFilter_RemoveFilter = new System.Windows.Forms.Button();
            this.tabControlMatFilter.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxTexInfo.SuspendLayout();
            this.groupBoxFilterTexShowSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTexture)).BeginInit();
            this.groupBoxMatSettings.SuspendLayout();
            this.panelMatFilterMain.SuspendLayout();
            this.groupBoxMatFilterMisc.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBoxFilterMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMatFilter
            // 
            this.tabControlMatFilter.Controls.Add(this.tabPage1);
            this.tabControlMatFilter.Controls.Add(this.tabPage2);
            this.tabControlMatFilter.Location = new System.Drawing.Point(969, 147);
            this.tabControlMatFilter.Name = "tabControlMatFilter";
            this.tabControlMatFilter.SelectedIndex = 0;
            this.tabControlMatFilter.Size = new System.Drawing.Size(120, 75);
            this.tabControlMatFilter.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(112, 49);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Меш";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(112, 49);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вобы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(289, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Еще не готово / Not ready yet";
            this.label1.Visible = false;
            // 
            // buttonMatFilter_NewMat
            // 
            this.buttonMatFilter_NewMat.AutoSize = true;
            this.buttonMatFilter_NewMat.Location = new System.Drawing.Point(5, 34);
            this.buttonMatFilter_NewMat.Name = "buttonMatFilter_NewMat";
            this.buttonMatFilter_NewMat.Size = new System.Drawing.Size(141, 23);
            this.buttonMatFilter_NewMat.TabIndex = 13;
            this.buttonMatFilter_NewMat.Text = "New material";
            this.buttonMatFilter_NewMat.UseVisualStyleBackColor = true;
            this.buttonMatFilter_NewMat.Click += new System.EventHandler(this.buttonMatFilter_NewMat_Click);
            // 
            // groupBoxTexInfo
            // 
            this.groupBoxTexInfo.Controls.Add(this.groupBoxFilterTexShowSettings);
            this.groupBoxTexInfo.Controls.Add(this.pictureBoxTexture);
            this.groupBoxTexInfo.Controls.Add(this.textBoxTexName);
            this.groupBoxTexInfo.Controls.Add(this.labelTexAlpha);
            this.groupBoxTexInfo.Controls.Add(this.labelTexSize);
            this.groupBoxTexInfo.Location = new System.Drawing.Point(524, 200);
            this.groupBoxTexInfo.Name = "groupBoxTexInfo";
            this.groupBoxTexInfo.Size = new System.Drawing.Size(412, 179);
            this.groupBoxTexInfo.TabIndex = 21;
            this.groupBoxTexInfo.TabStop = false;
            this.groupBoxTexInfo.Text = "Texture";
            // 
            // groupBoxFilterTexShowSettings
            // 
            this.groupBoxFilterTexShowSettings.Controls.Add(this.checkBoxFilterTexAutoScale);
            this.groupBoxFilterTexShowSettings.Controls.Add(this.checkBoxTexImageAlwaysCenter);
            this.groupBoxFilterTexShowSettings.Controls.Add(this.checkBoxTexImageUseAlpha);
            this.groupBoxFilterTexShowSettings.Enabled = false;
            this.groupBoxFilterTexShowSettings.Location = new System.Drawing.Point(150, 81);
            this.groupBoxFilterTexShowSettings.Name = "groupBoxFilterTexShowSettings";
            this.groupBoxFilterTexShowSettings.Size = new System.Drawing.Size(237, 90);
            this.groupBoxFilterTexShowSettings.TabIndex = 21;
            this.groupBoxFilterTexShowSettings.TabStop = false;
            this.groupBoxFilterTexShowSettings.Text = "Preview settings";
            // 
            // checkBoxFilterTexAutoScale
            // 
            this.checkBoxFilterTexAutoScale.AutoSize = true;
            this.checkBoxFilterTexAutoScale.Location = new System.Drawing.Point(7, 61);
            this.checkBoxFilterTexAutoScale.Name = "checkBoxFilterTexAutoScale";
            this.checkBoxFilterTexAutoScale.Size = new System.Drawing.Size(139, 17);
            this.checkBoxFilterTexAutoScale.TabIndex = 2;
            this.checkBoxFilterTexAutoScale.Text = "Autoscale small textures";
            this.checkBoxFilterTexAutoScale.UseVisualStyleBackColor = true;
            this.checkBoxFilterTexAutoScale.CheckStateChanged += new System.EventHandler(this.checkBoxFilterTexAutoScale_CheckStateChanged);
            // 
            // checkBoxTexImageAlwaysCenter
            // 
            this.checkBoxTexImageAlwaysCenter.AutoSize = true;
            this.checkBoxTexImageAlwaysCenter.Checked = true;
            this.checkBoxTexImageAlwaysCenter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTexImageAlwaysCenter.Location = new System.Drawing.Point(7, 40);
            this.checkBoxTexImageAlwaysCenter.Name = "checkBoxTexImageAlwaysCenter";
            this.checkBoxTexImageAlwaysCenter.Size = new System.Drawing.Size(103, 17);
            this.checkBoxTexImageAlwaysCenter.TabIndex = 1;
            this.checkBoxTexImageAlwaysCenter.Text = "Always in center";
            this.checkBoxTexImageAlwaysCenter.UseVisualStyleBackColor = true;
            this.checkBoxTexImageAlwaysCenter.CheckedChanged += new System.EventHandler(this.checkBoxTexImageAlwaysCenter_CheckedChanged);
            // 
            // checkBoxTexImageUseAlpha
            // 
            this.checkBoxTexImageUseAlpha.AutoSize = true;
            this.checkBoxTexImageUseAlpha.Checked = true;
            this.checkBoxTexImageUseAlpha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTexImageUseAlpha.Location = new System.Drawing.Point(7, 20);
            this.checkBoxTexImageUseAlpha.Name = "checkBoxTexImageUseAlpha";
            this.checkBoxTexImageUseAlpha.Size = new System.Drawing.Size(91, 17);
            this.checkBoxTexImageUseAlpha.TabIndex = 0;
            this.checkBoxTexImageUseAlpha.Text = "Transparency";
            this.checkBoxTexImageUseAlpha.UseVisualStyleBackColor = true;
            this.checkBoxTexImageUseAlpha.CheckedChanged += new System.EventHandler(this.checkBoxTexImageUseAlpha_CheckedChanged);
            // 
            // pictureBoxTexture
            // 
            this.pictureBoxTexture.BackColor = System.Drawing.Color.White;
            this.pictureBoxTexture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTexture.Location = new System.Drawing.Point(11, 41);
            this.pictureBoxTexture.Name = "pictureBoxTexture";
            this.pictureBoxTexture.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxTexture.TabIndex = 15;
            this.pictureBoxTexture.TabStop = false;
            // 
            // textBoxTexName
            // 
            this.textBoxTexName.Location = new System.Drawing.Point(11, 16);
            this.textBoxTexName.Name = "textBoxTexName";
            this.textBoxTexName.ReadOnly = true;
            this.textBoxTexName.Size = new System.Drawing.Size(376, 20);
            this.textBoxTexName.TabIndex = 20;
            // 
            // labelTexAlpha
            // 
            this.labelTexAlpha.AutoSize = true;
            this.labelTexAlpha.Location = new System.Drawing.Point(147, 63);
            this.labelTexAlpha.Name = "labelTexAlpha";
            this.labelTexAlpha.Size = new System.Drawing.Size(78, 13);
            this.labelTexAlpha.TabIndex = 19;
            this.labelTexAlpha.Text = "Alpha channel:";
            // 
            // labelTexSize
            // 
            this.labelTexSize.AutoSize = true;
            this.labelTexSize.Location = new System.Drawing.Point(147, 44);
            this.labelTexSize.Name = "labelTexSize";
            this.labelTexSize.Size = new System.Drawing.Size(30, 13);
            this.labelTexSize.TabIndex = 16;
            this.labelTexSize.Text = "Size:";
            // 
            // textBoxFilterSearch
            // 
            this.textBoxFilterSearch.Location = new System.Drawing.Point(183, 229);
            this.textBoxFilterSearch.Name = "textBoxFilterSearch";
            this.textBoxFilterSearch.Size = new System.Drawing.Size(336, 20);
            this.textBoxFilterSearch.TabIndex = 17;
            this.textBoxFilterSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFilterSearch_KeyDown);
            this.textBoxFilterSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFilterSearch_KeyPress);
            // 
            // labelMatFilterSeachInMats
            // 
            this.labelMatFilterSeachInMats.AutoSize = true;
            this.labelMatFilterSeachInMats.Location = new System.Drawing.Point(181, 211);
            this.labelMatFilterSeachInMats.Name = "labelMatFilterSeachInMats";
            this.labelMatFilterSeachInMats.Size = new System.Drawing.Size(83, 13);
            this.labelMatFilterSeachInMats.TabIndex = 16;
            this.labelMatFilterSeachInMats.Text = "Search material:";
            // 
            // listBoxMatFilSearch
            // 
            this.listBoxMatFilSearch.FormattingEnabled = true;
            this.listBoxMatFilSearch.Location = new System.Drawing.Point(183, 257);
            this.listBoxMatFilSearch.Name = "listBoxMatFilSearch";
            this.listBoxMatFilSearch.Size = new System.Drawing.Size(336, 121);
            this.listBoxMatFilSearch.TabIndex = 15;
            this.listBoxMatFilSearch.SelectedIndexChanged += new System.EventHandler(this.listBoxMatFilSearch_SelectedIndexChanged);
            this.listBoxMatFilSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxMatList_MouseDown);
            // 
            // buttonFilterNew
            // 
            this.buttonFilterNew.AutoSize = true;
            this.buttonFilterNew.Location = new System.Drawing.Point(6, 13);
            this.buttonFilterNew.Name = "buttonFilterNew";
            this.buttonFilterNew.Size = new System.Drawing.Size(158, 23);
            this.buttonFilterNew.TabIndex = 11;
            this.buttonFilterNew.Text = "New filter";
            this.buttonFilterNew.UseVisualStyleBackColor = true;
            this.buttonFilterNew.Click += new System.EventHandler(this.buttonFilterNew_Click);
            // 
            // buttonFltRename
            // 
            this.buttonFltRename.AutoSize = true;
            this.buttonFltRename.Enabled = false;
            this.buttonFltRename.Location = new System.Drawing.Point(6, 41);
            this.buttonFltRename.Name = "buttonFltRename";
            this.buttonFltRename.Size = new System.Drawing.Size(159, 23);
            this.buttonFltRename.TabIndex = 12;
            this.buttonFltRename.Text = "Rename selected";
            this.buttonFltRename.UseVisualStyleBackColor = true;
            this.buttonFltRename.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMatFilterSaveFilters
            // 
            this.buttonMatFilterSaveFilters.AutoSize = true;
            this.buttonMatFilterSaveFilters.Location = new System.Drawing.Point(6, 96);
            this.buttonMatFilterSaveFilters.Name = "buttonMatFilterSaveFilters";
            this.buttonMatFilterSaveFilters.Size = new System.Drawing.Size(159, 23);
            this.buttonMatFilterSaveFilters.TabIndex = 10;
            this.buttonMatFilterSaveFilters.Text = "Save filters file";
            this.buttonMatFilterSaveFilters.UseVisualStyleBackColor = true;
            this.buttonMatFilterSaveFilters.Click += new System.EventHandler(this.buttonMatFilterSaveAll_Click);
            // 
            // groupBoxMatSettings
            // 
            this.groupBoxMatSettings.Controls.Add(this.checkBoxMatFilter_ForceFilter);
            this.groupBoxMatSettings.Controls.Add(this.checkBoxMatFilterGoApply);
            this.groupBoxMatSettings.Controls.Add(this.buttonApplyMatSettings);
            this.groupBoxMatSettings.Controls.Add(this.labelApplyFilter);
            this.groupBoxMatSettings.Controls.Add(this.labelFilterApplyGroup);
            this.groupBoxMatSettings.Controls.Add(this.comboBoxApplyFilter);
            this.groupBoxMatSettings.Controls.Add(this.comboBoxApplyGroup);
            this.groupBoxMatSettings.Enabled = false;
            this.groupBoxMatSettings.Location = new System.Drawing.Point(524, 18);
            this.groupBoxMatSettings.Name = "groupBoxMatSettings";
            this.groupBoxMatSettings.Size = new System.Drawing.Size(260, 176);
            this.groupBoxMatSettings.TabIndex = 10;
            this.groupBoxMatSettings.TabStop = false;
            this.groupBoxMatSettings.Text = "Properties of selected material";
            // 
            // checkBoxMatFilter_ForceFilter
            // 
            this.checkBoxMatFilter_ForceFilter.AutoSize = true;
            this.checkBoxMatFilter_ForceFilter.Location = new System.Drawing.Point(10, 124);
            this.checkBoxMatFilter_ForceFilter.Name = "checkBoxMatFilter_ForceFilter";
            this.checkBoxMatFilter_ForceFilter.Size = new System.Drawing.Size(124, 17);
            this.checkBoxMatFilter_ForceFilter.TabIndex = 11;
            this.checkBoxMatFilter_ForceFilter.Text = "Forcedly set last filter";
            this.checkBoxMatFilter_ForceFilter.UseVisualStyleBackColor = true;
            this.checkBoxMatFilter_ForceFilter.CheckedChanged += new System.EventHandler(this.checkBoxMatFilter_ForceFilter_CheckedChanged);
            // 
            // checkBoxMatFilterGoApply
            // 
            this.checkBoxMatFilterGoApply.AutoSize = true;
            this.checkBoxMatFilterGoApply.Checked = true;
            this.checkBoxMatFilterGoApply.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMatFilterGoApply.Location = new System.Drawing.Point(10, 106);
            this.checkBoxMatFilterGoApply.Name = "checkBoxMatFilterGoApply";
            this.checkBoxMatFilterGoApply.Size = new System.Drawing.Size(161, 17);
            this.checkBoxMatFilterGoApply.TabIndex = 10;
            this.checkBoxMatFilterGoApply.Text = "Follow material after applying";
            this.checkBoxMatFilterGoApply.UseVisualStyleBackColor = true;
            // 
            // buttonApplyMatSettings
            // 
            this.buttonApplyMatSettings.Location = new System.Drawing.Point(7, 144);
            this.buttonApplyMatSettings.Name = "buttonApplyMatSettings";
            this.buttonApplyMatSettings.Size = new System.Drawing.Size(247, 23);
            this.buttonApplyMatSettings.TabIndex = 5;
            this.buttonApplyMatSettings.Text = "Apply";
            this.buttonApplyMatSettings.UseVisualStyleBackColor = true;
            this.buttonApplyMatSettings.Click += new System.EventHandler(this.buttonApplyMatSettings_Click);
            // 
            // labelApplyFilter
            // 
            this.labelApplyFilter.AutoSize = true;
            this.labelApplyFilter.Location = new System.Drawing.Point(6, 20);
            this.labelApplyFilter.Name = "labelApplyFilter";
            this.labelApplyFilter.Size = new System.Drawing.Size(48, 13);
            this.labelApplyFilter.TabIndex = 9;
            this.labelApplyFilter.Text = "Set filter:";
            // 
            // labelFilterApplyGroup
            // 
            this.labelFilterApplyGroup.AutoSize = true;
            this.labelFilterApplyGroup.Location = new System.Drawing.Point(6, 62);
            this.labelFilterApplyGroup.Name = "labelFilterApplyGroup";
            this.labelFilterApplyGroup.Size = new System.Drawing.Size(56, 13);
            this.labelFilterApplyGroup.TabIndex = 8;
            this.labelFilterApplyGroup.Text = "Set group:";
            // 
            // comboBoxApplyFilter
            // 
            this.comboBoxApplyFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxApplyFilter.FormattingEnabled = true;
            this.comboBoxApplyFilter.Location = new System.Drawing.Point(7, 36);
            this.comboBoxApplyFilter.Name = "comboBoxApplyFilter";
            this.comboBoxApplyFilter.Size = new System.Drawing.Size(174, 21);
            this.comboBoxApplyFilter.TabIndex = 6;
            this.comboBoxApplyFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxApplyFilter_SelectedIndexChanged);
            // 
            // comboBoxApplyGroup
            // 
            this.comboBoxApplyGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxApplyGroup.FormattingEnabled = true;
            this.comboBoxApplyGroup.Items.AddRange(new object[] {
            "UNDEF",
            "METAL",
            "STONE",
            "WOOD",
            "EARTH",
            "WATER",
            "SNOW"});
            this.comboBoxApplyGroup.Location = new System.Drawing.Point(7, 79);
            this.comboBoxApplyGroup.Name = "comboBoxApplyGroup";
            this.comboBoxApplyGroup.Size = new System.Drawing.Size(174, 21);
            this.comboBoxApplyGroup.TabIndex = 7;
            this.comboBoxApplyGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxApplyGroup_SelectedIndexChanged);
            // 
            // buttonSavePML_File
            // 
            this.buttonSavePML_File.AutoSize = true;
            this.buttonSavePML_File.Enabled = false;
            this.buttonSavePML_File.ForeColor = System.Drawing.Color.Green;
            this.buttonSavePML_File.Location = new System.Drawing.Point(5, 63);
            this.buttonSavePML_File.Name = "buttonSavePML_File";
            this.buttonSavePML_File.Size = new System.Drawing.Size(141, 23);
            this.buttonSavePML_File.TabIndex = 12;
            this.buttonSavePML_File.Text = "Save changes";
            this.buttonSavePML_File.UseVisualStyleBackColor = true;
            this.buttonSavePML_File.Click += new System.EventHandler(this.buttonSavePML_File_Click);
            // 
            // labelMatCountCurrentFilter
            // 
            this.labelMatCountCurrentFilter.AutoSize = true;
            this.labelMatCountCurrentFilter.Location = new System.Drawing.Point(180, 8);
            this.labelMatCountCurrentFilter.Name = "labelMatCountCurrentFilter";
            this.labelMatCountCurrentFilter.Size = new System.Drawing.Size(119, 13);
            this.labelMatCountCurrentFilter.TabIndex = 4;
            this.labelMatCountCurrentFilter.Text = "Materials of the filter: (0)";
            // 
            // listBoxMatList
            // 
            this.listBoxMatList.FormattingEnabled = true;
            this.listBoxMatList.Location = new System.Drawing.Point(183, 24);
            this.listBoxMatList.Name = "listBoxMatList";
            this.listBoxMatList.Size = new System.Drawing.Size(336, 173);
            this.listBoxMatList.TabIndex = 3;
            this.listBoxMatList.SelectedIndexChanged += new System.EventHandler(this.listBoxMatList_SelectedIndexChanged);
            this.listBoxMatList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxMatList_MouseDown);
            // 
            // listBoxFilter
            // 
            this.listBoxFilter.FormattingEnabled = true;
            this.listBoxFilter.Location = new System.Drawing.Point(6, 24);
            this.listBoxFilter.Name = "listBoxFilter";
            this.listBoxFilter.Size = new System.Drawing.Size(170, 225);
            this.listBoxFilter.TabIndex = 2;
            this.listBoxFilter.SelectedIndexChanged += new System.EventHandler(this.listBoxFilter_SelectedIndexChanged);
            // 
            // labelFilterListFiles
            // 
            this.labelFilterListFiles.AutoSize = true;
            this.labelFilterListFiles.Location = new System.Drawing.Point(3, 8);
            this.labelFilterListFiles.Name = "labelFilterListFiles";
            this.labelFilterListFiles.Size = new System.Drawing.Size(64, 13);
            this.labelFilterListFiles.TabIndex = 1;
            this.labelFilterListFiles.Text = "Filters library";
            // 
            // panelMatFilterMain
            // 
            this.panelMatFilterMain.BackColor = System.Drawing.SystemColors.Window;
            this.panelMatFilterMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMatFilterMain.Controls.Add(this.groupBoxMatFilterMisc);
            this.panelMatFilterMain.Controls.Add(this.statusStrip1);
            this.panelMatFilterMain.Controls.Add(this.groupBoxFilterMenu);
            this.panelMatFilterMain.Controls.Add(this.listBoxFilter);
            this.panelMatFilterMain.Controls.Add(this.groupBoxTexInfo);
            this.panelMatFilterMain.Controls.Add(this.textBoxFilterSearch);
            this.panelMatFilterMain.Controls.Add(this.labelFilterListFiles);
            this.panelMatFilterMain.Controls.Add(this.labelMatFilterSeachInMats);
            this.panelMatFilterMain.Controls.Add(this.listBoxMatFilSearch);
            this.panelMatFilterMain.Controls.Add(this.labelMatCountCurrentFilter);
            this.panelMatFilterMain.Controls.Add(this.groupBoxMatSettings);
            this.panelMatFilterMain.Controls.Add(this.listBoxMatList);
            this.panelMatFilterMain.Location = new System.Drawing.Point(1, 1);
            this.panelMatFilterMain.Name = "panelMatFilterMain";
            this.panelMatFilterMain.Size = new System.Drawing.Size(941, 410);
            this.panelMatFilterMain.TabIndex = 22;
            // 
            // groupBoxMatFilterMisc
            // 
            this.groupBoxMatFilterMisc.Controls.Add(this.buttonSavePML_File);
            this.groupBoxMatFilterMisc.Controls.Add(this.buttonMatFilter_NewMat);
            this.groupBoxMatFilterMisc.Enabled = false;
            this.groupBoxMatFilterMisc.Location = new System.Drawing.Point(787, 18);
            this.groupBoxMatFilterMisc.Name = "groupBoxMatFilterMisc";
            this.groupBoxMatFilterMisc.Size = new System.Drawing.Size(149, 111);
            this.groupBoxMatFilterMisc.TabIndex = 11;
            this.groupBoxMatFilterMisc.TabStop = false;
            this.groupBoxMatFilterMisc.Text = "Misc";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusFilterMat});
            this.statusStrip1.Location = new System.Drawing.Point(0, 386);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(939, 22);
            this.statusStrip1.TabIndex = 23;
            // 
            // toolStripStatusFilterMat
            // 
            this.toolStripStatusFilterMat.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusFilterMat.Name = "toolStripStatusFilterMat";
            this.toolStripStatusFilterMat.Size = new System.Drawing.Size(255, 17);
            this.toolStripStatusFilterMat.Text = "Load any ZEN or 3DS to activate Materials Filter";
            // 
            // groupBoxFilterMenu
            // 
            this.groupBoxFilterMenu.Controls.Add(this.buttonMatFilter_RemoveFilter);
            this.groupBoxFilterMenu.Controls.Add(this.buttonMatFilterSaveFilters);
            this.groupBoxFilterMenu.Controls.Add(this.buttonFltRename);
            this.groupBoxFilterMenu.Controls.Add(this.buttonFilterNew);
            this.groupBoxFilterMenu.Enabled = false;
            this.groupBoxFilterMenu.Location = new System.Drawing.Point(6, 255);
            this.groupBoxFilterMenu.Name = "groupBoxFilterMenu";
            this.groupBoxFilterMenu.Size = new System.Drawing.Size(170, 124);
            this.groupBoxFilterMenu.TabIndex = 22;
            this.groupBoxFilterMenu.TabStop = false;
            // 
            // buttonMatFilter_RemoveFilter
            // 
            this.buttonMatFilter_RemoveFilter.AutoSize = true;
            this.buttonMatFilter_RemoveFilter.Enabled = false;
            this.buttonMatFilter_RemoveFilter.Location = new System.Drawing.Point(6, 68);
            this.buttonMatFilter_RemoveFilter.Name = "buttonMatFilter_RemoveFilter";
            this.buttonMatFilter_RemoveFilter.Size = new System.Drawing.Size(159, 23);
            this.buttonMatFilter_RemoveFilter.TabIndex = 13;
            this.buttonMatFilter_RemoveFilter.Text = "Remove filter";
            this.buttonMatFilter_RemoveFilter.UseVisualStyleBackColor = true;
            this.buttonMatFilter_RemoveFilter.Click += new System.EventHandler(this.buttonMatFilter_RemoveFilter_Click);
            // 
            // MaterialFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 412);
            this.Controls.Add(this.panelMatFilterMain);
            this.Controls.Add(this.tabControlMatFilter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaterialFilterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Materials filter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaterialFilterForm_FormClosing);
            this.tabControlMatFilter.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxTexInfo.ResumeLayout(false);
            this.groupBoxTexInfo.PerformLayout();
            this.groupBoxFilterTexShowSettings.ResumeLayout(false);
            this.groupBoxFilterTexShowSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTexture)).EndInit();
            this.groupBoxMatSettings.ResumeLayout(false);
            this.groupBoxMatSettings.PerformLayout();
            this.panelMatFilterMain.ResumeLayout(false);
            this.panelMatFilterMain.PerformLayout();
            this.groupBoxMatFilterMisc.ResumeLayout(false);
            this.groupBoxMatFilterMisc.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxFilterMenu.ResumeLayout(false);
            this.groupBoxFilterMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelFilterListFiles;
        public System.Windows.Forms.ListBox listBoxFilter;
        public System.Windows.Forms.ListBox listBoxMatList;
        private System.Windows.Forms.Label labelApplyFilter;
        private System.Windows.Forms.Label labelFilterApplyGroup;
        private System.Windows.Forms.ComboBox comboBoxApplyGroup;
        private System.Windows.Forms.ComboBox comboBoxApplyFilter;
        private System.Windows.Forms.Button buttonApplyMatSettings;
        private System.Windows.Forms.Button buttonMatFilterSaveFilters;
        private System.Windows.Forms.Button buttonFilterNew;
        private System.Windows.Forms.Button buttonFltRename;
        public System.Windows.Forms.TabControl tabControlMatFilter;
        public System.Windows.Forms.GroupBox groupBoxMatSettings;
        public System.Windows.Forms.PictureBox pictureBoxTexture;
        private System.Windows.Forms.Label labelMatFilterSeachInMats;
        public System.Windows.Forms.ListBox listBoxMatFilSearch;
        public System.Windows.Forms.Label labelTexSize;
        public System.Windows.Forms.TextBox textBoxFilterSearch;
        public System.Windows.Forms.Label labelTexAlpha;
        public System.Windows.Forms.TextBox textBoxTexName;
        private System.Windows.Forms.GroupBox groupBoxTexInfo;
        private System.Windows.Forms.CheckBox checkBoxFilterTexAutoScale;
        private System.Windows.Forms.CheckBox checkBoxTexImageAlwaysCenter;
        public System.Windows.Forms.GroupBox groupBoxFilterTexShowSettings;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMatFilter_NewMat;
        public System.Windows.Forms.CheckBox checkBoxTexImageUseAlpha;
        private System.Windows.Forms.Panel panelMatFilterMain;
        public System.Windows.Forms.GroupBox groupBoxFilterMenu;
        public System.Windows.Forms.Label labelMatCountCurrentFilter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusFilterMat;
        private System.Windows.Forms.Button buttonMatFilter_RemoveFilter;
        public System.Windows.Forms.GroupBox groupBoxMatFilterMisc;
        public System.Windows.Forms.Button buttonSavePML_File;
        private System.Windows.Forms.CheckBox checkBoxMatFilterGoApply;
        private System.Windows.Forms.CheckBox checkBoxMatFilter_ForceFilter;
    }
}