﻿namespace SpacerUnion.Windows
{
    partial class PFXEditorWin
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
            this.labelPFXName = new System.Windows.Forms.Label();
            this.savePFXButton = new System.Windows.Forms.Button();
            this.treeViewPFX = new System.Windows.Forms.TreeView();
            this.buttonPfxEditorApply = new System.Windows.Forms.Button();
            this.panelPFXButtons = new System.Windows.Forms.Panel();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonPfxRestore = new System.Windows.Forms.Button();
            this.textBoxPfxInput = new System.Windows.Forms.TextBox();
            this.comboBoxPfxField = new System.Windows.Forms.ComboBox();
            this.panelPFXTop = new System.Windows.Forms.Panel();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelShowEffect = new System.Windows.Forms.Label();
            this.comboBoxShowEffectMotion = new System.Windows.Forms.ComboBox();
            this.checkBoxShowHints = new System.Windows.Forms.CheckBox();
            this.buttonApplyOnMesh = new System.Windows.Forms.Button();
            this.buttonRemovePFX = new System.Windows.Forms.Button();
            this.buttonPFXPlaceNearCam = new System.Windows.Forms.Button();
            this.buttonPFXPlayAgain = new System.Windows.Forms.Button();
            this.checkBoxPlayAuto = new System.Windows.Forms.CheckBox();
            this.checkBoxPfxSaveAllFields = new System.Windows.Forms.CheckBox();
            this.labelHint = new System.Windows.Forms.Label();
            this.comboBoxFieldsStyle = new System.Windows.Forms.ComboBox();
            this.labelStyleFields = new System.Windows.Forms.Label();
            this.tabControlPFX = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonPfxCreateClean = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPFXButtons.SuspendLayout();
            this.panelPFXTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.tabControlPFX.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPFXName
            // 
            this.labelPFXName.AutoSize = true;
            this.labelPFXName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPFXName.ForeColor = System.Drawing.Color.IndianRed;
            this.labelPFXName.Location = new System.Drawing.Point(3, 9);
            this.labelPFXName.Name = "labelPFXName";
            this.labelPFXName.Size = new System.Drawing.Size(86, 13);
            this.labelPFXName.TabIndex = 1;
            this.labelPFXName.Text = "PFX instance:";
            this.labelPFXName.Click += new System.EventHandler(this.labelPFXName_Click);
            // 
            // savePFXButton
            // 
            this.savePFXButton.Location = new System.Drawing.Point(3, 58);
            this.savePFXButton.Name = "savePFXButton";
            this.savePFXButton.Size = new System.Drawing.Size(132, 23);
            this.savePFXButton.TabIndex = 3;
            this.savePFXButton.Text = "Save to file";
            this.savePFXButton.UseVisualStyleBackColor = true;
            this.savePFXButton.Click += new System.EventHandler(this.savePFXButton_Click);
            // 
            // treeViewPFX
            // 
            this.treeViewPFX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewPFX.HideSelection = false;
            this.treeViewPFX.Location = new System.Drawing.Point(3, 140);
            this.treeViewPFX.Name = "treeViewPFX";
            this.treeViewPFX.Size = new System.Drawing.Size(390, 216);
            this.treeViewPFX.TabIndex = 4;
            this.treeViewPFX.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPFX_AfterSelect);
            this.treeViewPFX.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewPFX_NodeMouseDoubleClick);
            this.treeViewPFX.DoubleClick += new System.EventHandler(this.treeViewPFX_DoubleClick);
            this.treeViewPFX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewPFX_MouseDown);
            this.treeViewPFX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeViewPFX_MouseUp);
            // 
            // buttonPfxEditorApply
            // 
            this.buttonPfxEditorApply.Location = new System.Drawing.Point(12, 41);
            this.buttonPfxEditorApply.Name = "buttonPfxEditorApply";
            this.buttonPfxEditorApply.Size = new System.Drawing.Size(119, 23);
            this.buttonPfxEditorApply.TabIndex = 5;
            this.buttonPfxEditorApply.Text = "Apply";
            this.buttonPfxEditorApply.UseVisualStyleBackColor = true;
            this.buttonPfxEditorApply.Click += new System.EventHandler(this.buttonPfxEditorApply_Click);
            // 
            // panelPFXButtons
            // 
            this.panelPFXButtons.Controls.Add(this.buttonColor);
            this.panelPFXButtons.Controls.Add(this.buttonFile);
            this.panelPFXButtons.Controls.Add(this.buttonPfxRestore);
            this.panelPFXButtons.Controls.Add(this.textBoxPfxInput);
            this.panelPFXButtons.Controls.Add(this.comboBoxPfxField);
            this.panelPFXButtons.Controls.Add(this.buttonPfxEditorApply);
            this.panelPFXButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPFXButtons.Location = new System.Drawing.Point(3, 356);
            this.panelPFXButtons.Name = "panelPFXButtons";
            this.panelPFXButtons.Size = new System.Drawing.Size(390, 76);
            this.panelPFXButtons.TabIndex = 6;
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(288, 41);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(96, 23);
            this.buttonColor.TabIndex = 10;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(288, 5);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(96, 23);
            this.buttonFile.TabIndex = 9;
            this.buttonFile.Text = "File";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonPfxRestore
            // 
            this.buttonPfxRestore.Location = new System.Drawing.Point(153, 41);
            this.buttonPfxRestore.Name = "buttonPfxRestore";
            this.buttonPfxRestore.Size = new System.Drawing.Size(119, 23);
            this.buttonPfxRestore.TabIndex = 8;
            this.buttonPfxRestore.Text = "Restore ";
            this.buttonPfxRestore.UseVisualStyleBackColor = true;
            this.buttonPfxRestore.Click += new System.EventHandler(this.buttonPfxRestore_Click);
            // 
            // textBoxPfxInput
            // 
            this.textBoxPfxInput.Location = new System.Drawing.Point(12, 7);
            this.textBoxPfxInput.Name = "textBoxPfxInput";
            this.textBoxPfxInput.Size = new System.Drawing.Size(260, 20);
            this.textBoxPfxInput.TabIndex = 7;
            this.textBoxPfxInput.Visible = false;
            this.textBoxPfxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPfxInput_KeyPress);
            // 
            // comboBoxPfxField
            // 
            this.comboBoxPfxField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPfxField.FormattingEnabled = true;
            this.comboBoxPfxField.Location = new System.Drawing.Point(12, 6);
            this.comboBoxPfxField.Name = "comboBoxPfxField";
            this.comboBoxPfxField.Size = new System.Drawing.Size(141, 21);
            this.comboBoxPfxField.TabIndex = 6;
            this.comboBoxPfxField.Visible = false;
            this.comboBoxPfxField.SelectedIndexChanged += new System.EventHandler(this.comboBoxPfxField_SelectedIndexChanged);
            // 
            // panelPFXTop
            // 
            this.panelPFXTop.Controls.Add(this.trackBarSpeed);
            this.panelPFXTop.Controls.Add(this.labelSpeed);
            this.panelPFXTop.Controls.Add(this.labelShowEffect);
            this.panelPFXTop.Controls.Add(this.comboBoxShowEffectMotion);
            this.panelPFXTop.Controls.Add(this.checkBoxShowHints);
            this.panelPFXTop.Controls.Add(this.buttonApplyOnMesh);
            this.panelPFXTop.Controls.Add(this.buttonRemovePFX);
            this.panelPFXTop.Controls.Add(this.buttonPFXPlaceNearCam);
            this.panelPFXTop.Controls.Add(this.savePFXButton);
            this.panelPFXTop.Controls.Add(this.buttonPFXPlayAgain);
            this.panelPFXTop.Controls.Add(this.labelPFXName);
            this.panelPFXTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPFXTop.Location = new System.Drawing.Point(3, 3);
            this.panelPFXTop.Name = "panelPFXTop";
            this.panelPFXTop.Size = new System.Drawing.Size(390, 137);
            this.panelPFXTop.TabIndex = 7;
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.LargeChange = 30;
            this.trackBarSpeed.Location = new System.Drawing.Point(141, 115);
            this.trackBarSpeed.Maximum = 500;
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(218, 45);
            this.trackBarSpeed.SmallChange = 10;
            this.trackBarSpeed.TabIndex = 15;
            this.trackBarSpeed.Value = 100;
            this.trackBarSpeed.ValueChanged += new System.EventHandler(this.trackBarSpeed_ValueChanged);
            // 
            // labelSpeed
            // 
            this.labelSpeed.Location = new System.Drawing.Point(9, 115);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelSpeed.Size = new System.Drawing.Size(126, 14);
            this.labelSpeed.TabIndex = 14;
            this.labelSpeed.Text = "Speed motion";
            // 
            // labelShowEffect
            // 
            this.labelShowEffect.Location = new System.Drawing.Point(9, 91);
            this.labelShowEffect.Name = "labelShowEffect";
            this.labelShowEffect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelShowEffect.Size = new System.Drawing.Size(126, 14);
            this.labelShowEffect.TabIndex = 13;
            this.labelShowEffect.Text = "ShowEffect";
            // 
            // comboBoxShowEffectMotion
            // 
            this.comboBoxShowEffectMotion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowEffectMotion.FormattingEnabled = true;
            this.comboBoxShowEffectMotion.Items.AddRange(new object[] {
            "STATIC",
            "CIRCLE",
            "MOVE_FORW_BACK",
            "ROTATE_LOCAL_Y",
            "FORW_ONLY"});
            this.comboBoxShowEffectMotion.Location = new System.Drawing.Point(141, 88);
            this.comboBoxShowEffectMotion.Name = "comboBoxShowEffectMotion";
            this.comboBoxShowEffectMotion.Size = new System.Drawing.Size(218, 21);
            this.comboBoxShowEffectMotion.TabIndex = 12;
            this.comboBoxShowEffectMotion.SelectedIndexChanged += new System.EventHandler(this.comboBoxShowEffectMotion_SelectedIndexChanged);
            // 
            // checkBoxShowHints
            // 
            this.checkBoxShowHints.AutoSize = true;
            this.checkBoxShowHints.Checked = true;
            this.checkBoxShowHints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowHints.Location = new System.Drawing.Point(260, 5);
            this.checkBoxShowHints.Name = "checkBoxShowHints";
            this.checkBoxShowHints.Size = new System.Drawing.Size(78, 17);
            this.checkBoxShowHints.TabIndex = 11;
            this.checkBoxShowHints.Text = "Show hints";
            this.checkBoxShowHints.UseVisualStyleBackColor = true;
            this.checkBoxShowHints.Visible = false;
            this.checkBoxShowHints.CheckedChanged += new System.EventHandler(this.checkBoxShowHints_CheckedChanged);
            // 
            // buttonApplyOnMesh
            // 
            this.buttonApplyOnMesh.Location = new System.Drawing.Point(140, -1);
            this.buttonApplyOnMesh.Name = "buttonApplyOnMesh";
            this.buttonApplyOnMesh.Size = new System.Drawing.Size(114, 23);
            this.buttonApplyOnMesh.TabIndex = 10;
            this.buttonApplyOnMesh.Text = "Apply on mesh";
            this.buttonApplyOnMesh.UseVisualStyleBackColor = true;
            this.buttonApplyOnMesh.Visible = false;
            this.buttonApplyOnMesh.Click += new System.EventHandler(this.buttonApplyOnMesh_Click);
            // 
            // buttonRemovePFX
            // 
            this.buttonRemovePFX.Location = new System.Drawing.Point(141, 29);
            this.buttonRemovePFX.Name = "buttonRemovePFX";
            this.buttonRemovePFX.Size = new System.Drawing.Size(218, 23);
            this.buttonRemovePFX.TabIndex = 9;
            this.buttonRemovePFX.Text = "Remove effect";
            this.buttonRemovePFX.UseVisualStyleBackColor = true;
            this.buttonRemovePFX.Click += new System.EventHandler(this.buttonRemovePFX_Click);
            // 
            // buttonPFXPlaceNearCam
            // 
            this.buttonPFXPlaceNearCam.Location = new System.Drawing.Point(141, 58);
            this.buttonPFXPlaceNearCam.Name = "buttonPFXPlaceNearCam";
            this.buttonPFXPlaceNearCam.Size = new System.Drawing.Size(218, 23);
            this.buttonPFXPlaceNearCam.TabIndex = 8;
            this.buttonPFXPlaceNearCam.Text = "Place effect near camera";
            this.buttonPFXPlaceNearCam.UseVisualStyleBackColor = true;
            this.buttonPFXPlaceNearCam.Click += new System.EventHandler(this.buttonPFXPlaceNearCam_Click);
            // 
            // buttonPFXPlayAgain
            // 
            this.buttonPFXPlayAgain.Location = new System.Drawing.Point(3, 29);
            this.buttonPFXPlayAgain.Name = "buttonPFXPlayAgain";
            this.buttonPFXPlayAgain.Size = new System.Drawing.Size(132, 23);
            this.buttonPFXPlayAgain.TabIndex = 5;
            this.buttonPFXPlayAgain.Text = "Play again";
            this.buttonPFXPlayAgain.UseVisualStyleBackColor = true;
            this.buttonPFXPlayAgain.Click += new System.EventHandler(this.buttonPFXPlayAgain_Click);
            // 
            // checkBoxPlayAuto
            // 
            this.checkBoxPlayAuto.AutoSize = true;
            this.checkBoxPlayAuto.BackColor = System.Drawing.Color.White;
            this.checkBoxPlayAuto.Checked = true;
            this.checkBoxPlayAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPlayAuto.Location = new System.Drawing.Point(4, 5);
            this.checkBoxPlayAuto.Name = "checkBoxPlayAuto";
            this.checkBoxPlayAuto.Size = new System.Drawing.Size(160, 17);
            this.checkBoxPlayAuto.TabIndex = 7;
            this.checkBoxPlayAuto.Text = "Repeat effect after it is done";
            this.checkBoxPlayAuto.UseVisualStyleBackColor = false;
            this.checkBoxPlayAuto.CheckedChanged += new System.EventHandler(this.checkBoxPlayAuto_CheckedChanged);
            // 
            // checkBoxPfxSaveAllFields
            // 
            this.checkBoxPfxSaveAllFields.AutoSize = true;
            this.checkBoxPfxSaveAllFields.BackColor = System.Drawing.Color.White;
            this.checkBoxPfxSaveAllFields.Checked = true;
            this.checkBoxPfxSaveAllFields.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPfxSaveAllFields.Location = new System.Drawing.Point(4, 28);
            this.checkBoxPfxSaveAllFields.Name = "checkBoxPfxSaveAllFields";
            this.checkBoxPfxSaveAllFields.Size = new System.Drawing.Size(91, 17);
            this.checkBoxPfxSaveAllFields.TabIndex = 6;
            this.checkBoxPfxSaveAllFields.Text = "Save all fields";
            this.checkBoxPfxSaveAllFields.UseVisualStyleBackColor = false;
            this.checkBoxPfxSaveAllFields.CheckedChanged += new System.EventHandler(this.checkBoxPfxSaveAllFields_CheckedChanged);
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.Location = new System.Drawing.Point(257, 203);
            this.labelHint.Name = "labelHint";
            this.labelHint.Padding = new System.Windows.Forms.Padding(2);
            this.labelHint.Size = new System.Drawing.Size(56, 17);
            this.labelHint.TabIndex = 8;
            this.labelHint.Text = "HintLabel";
            this.labelHint.Visible = false;
            // 
            // comboBoxFieldsStyle
            // 
            this.comboBoxFieldsStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFieldsStyle.FormattingEnabled = true;
            this.comboBoxFieldsStyle.Items.AddRange(new object[] {
            "NONE",
            "STROKE",
            "BOLD",
            "ITALIC"});
            this.comboBoxFieldsStyle.Location = new System.Drawing.Point(4, 51);
            this.comboBoxFieldsStyle.Name = "comboBoxFieldsStyle";
            this.comboBoxFieldsStyle.Size = new System.Drawing.Size(130, 21);
            this.comboBoxFieldsStyle.TabIndex = 13;
            this.comboBoxFieldsStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxFieldsStyle_SelectedIndexChanged);
            // 
            // labelStyleFields
            // 
            this.labelStyleFields.AutoSize = true;
            this.labelStyleFields.BackColor = System.Drawing.Color.White;
            this.labelStyleFields.Location = new System.Drawing.Point(139, 54);
            this.labelStyleFields.Name = "labelStyleFields";
            this.labelStyleFields.Size = new System.Drawing.Size(94, 13);
            this.labelStyleFields.TabIndex = 14;
            this.labelStyleFields.Text = "Style of main fields";
            // 
            // tabControlPFX
            // 
            this.tabControlPFX.Controls.Add(this.tabPage1);
            this.tabControlPFX.Controls.Add(this.tabPage3);
            this.tabControlPFX.Controls.Add(this.tabPage2);
            this.tabControlPFX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPFX.Location = new System.Drawing.Point(0, 0);
            this.tabControlPFX.Name = "tabControlPFX";
            this.tabControlPFX.SelectedIndex = 0;
            this.tabControlPFX.Size = new System.Drawing.Size(404, 461);
            this.tabControlPFX.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeViewPFX);
            this.tabPage1.Controls.Add(this.panelPFXTop);
            this.tabPage1.Controls.Add(this.panelPFXButtons);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(396, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Editing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelSettings);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(396, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.White;
            this.panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSettings.Controls.Add(this.checkBoxPfxSaveAllFields);
            this.panelSettings.Controls.Add(this.checkBoxPlayAuto);
            this.panelSettings.Controls.Add(this.labelStyleFields);
            this.panelSettings.Controls.Add(this.comboBoxFieldsStyle);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSettings.Location = new System.Drawing.Point(3, 3);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(390, 84);
            this.panelSettings.TabIndex = 15;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.buttonPfxCreateClean);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(396, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Create";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonPfxCreateClean
            // 
            this.buttonPfxCreateClean.Enabled = false;
            this.buttonPfxCreateClean.Location = new System.Drawing.Point(37, 27);
            this.buttonPfxCreateClean.Name = "buttonPfxCreateClean";
            this.buttonPfxCreateClean.Size = new System.Drawing.Size(315, 23);
            this.buttonPfxCreateClean.TabIndex = 0;
            this.buttonPfxCreateClean.Text = "Create new clean effect";
            this.buttonPfxCreateClean.UseVisualStyleBackColor = true;
            this.buttonPfxCreateClean.Click += new System.EventHandler(this.buttonPfxCreateClean_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(37, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create new from current effect";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(93, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOT WORKING NOW";
            // 
            // PFXEditorWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 461);
            this.Controls.Add(this.tabControlPFX);
            this.Controls.Add(this.labelHint);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 500);
            this.Name = "PFXEditorWin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PFXEditorWin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PFXEditorWin_FormClosing);
            this.Load += new System.EventHandler(this.PFXEditorWin_Load);
            this.Shown += new System.EventHandler(this.PFXEditorWin_Shown);
            this.VisibleChanged += new System.EventHandler(this.PFXEditorWin_VisibleChanged);
            this.panelPFXButtons.ResumeLayout(false);
            this.panelPFXButtons.PerformLayout();
            this.panelPFXTop.ResumeLayout(false);
            this.panelPFXTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.tabControlPFX.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPFXName;
        private System.Windows.Forms.Button savePFXButton;
        private System.Windows.Forms.TreeView treeViewPFX;
        private System.Windows.Forms.Button buttonPfxEditorApply;
        private System.Windows.Forms.Panel panelPFXButtons;
        private System.Windows.Forms.Panel panelPFXTop;
        private System.Windows.Forms.ComboBox comboBoxPfxField;
        private System.Windows.Forms.TextBox textBoxPfxInput;
        private System.Windows.Forms.Button buttonPfxRestore;
        private System.Windows.Forms.Button buttonPFXPlayAgain;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.CheckBox checkBoxPfxSaveAllFields;
        private System.Windows.Forms.CheckBox checkBoxPlayAuto;
        private System.Windows.Forms.Button buttonPFXPlaceNearCam;
        private System.Windows.Forms.Button buttonRemovePFX;
        private System.Windows.Forms.Button buttonApplyOnMesh;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.CheckBox checkBoxShowHints;
        private System.Windows.Forms.Label labelStyleFields;
        private System.Windows.Forms.ComboBox comboBoxFieldsStyle;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Label labelShowEffect;
        private System.Windows.Forms.ComboBox comboBoxShowEffectMotion;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonPfxCreateClean;
        public System.Windows.Forms.TabControl tabControlPFX;
        private System.Windows.Forms.Label label1;
    }
}