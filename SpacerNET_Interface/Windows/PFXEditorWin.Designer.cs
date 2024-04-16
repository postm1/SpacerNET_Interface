namespace SpacerUnion.Windows
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
            this.comboBoxPfxInst = new System.Windows.Forms.ComboBox();
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonPFXPlayAgain = new System.Windows.Forms.Button();
            this.checkBoxPfxSaveAllFields = new System.Windows.Forms.CheckBox();
            this.checkBoxPlayAuto = new System.Windows.Forms.CheckBox();
            this.panelPFXButtons.SuspendLayout();
            this.panelPFXTop.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPfxInst
            // 
            this.comboBoxPfxInst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPfxInst.FormattingEnabled = true;
            this.comboBoxPfxInst.Location = new System.Drawing.Point(104, 10);
            this.comboBoxPfxInst.Name = "comboBoxPfxInst";
            this.comboBoxPfxInst.Size = new System.Drawing.Size(280, 21);
            this.comboBoxPfxInst.TabIndex = 0;
            this.comboBoxPfxInst.SelectedIndexChanged += new System.EventHandler(this.comboBoxPfxInst_SelectedIndexChanged);
            // 
            // labelPFXName
            // 
            this.labelPFXName.AutoSize = true;
            this.labelPFXName.Location = new System.Drawing.Point(12, 13);
            this.labelPFXName.Name = "labelPFXName";
            this.labelPFXName.Size = new System.Drawing.Size(70, 13);
            this.labelPFXName.TabIndex = 1;
            this.labelPFXName.Text = "PFX instance";
            this.labelPFXName.Click += new System.EventHandler(this.labelPFXName_Click);
            // 
            // savePFXButton
            // 
            this.savePFXButton.Location = new System.Drawing.Point(12, 66);
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
            this.treeViewPFX.Location = new System.Drawing.Point(0, 108);
            this.treeViewPFX.Name = "treeViewPFX";
            this.treeViewPFX.Size = new System.Drawing.Size(404, 548);
            this.treeViewPFX.TabIndex = 4;
            this.treeViewPFX.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPFX_AfterSelect);
            this.treeViewPFX.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewPFX_NodeMouseDoubleClick);
            this.treeViewPFX.DoubleClick += new System.EventHandler(this.treeViewPFX_DoubleClick);
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
            this.panelPFXButtons.Location = new System.Drawing.Point(0, 656);
            this.panelPFXButtons.Name = "panelPFXButtons";
            this.panelPFXButtons.Size = new System.Drawing.Size(404, 76);
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
            this.panelPFXTop.Controls.Add(this.panelTop);
            this.panelPFXTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPFXTop.Location = new System.Drawing.Point(0, 0);
            this.panelPFXTop.Name = "panelPFXTop";
            this.panelPFXTop.Size = new System.Drawing.Size(404, 108);
            this.panelPFXTop.TabIndex = 7;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.checkBoxPlayAuto);
            this.panelTop.Controls.Add(this.buttonPFXPlayAgain);
            this.panelTop.Controls.Add(this.labelPFXName);
            this.panelTop.Controls.Add(this.checkBoxPfxSaveAllFields);
            this.panelTop.Controls.Add(this.comboBoxPfxInst);
            this.panelTop.Controls.Add(this.savePFXButton);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(404, 105);
            this.panelTop.TabIndex = 7;
            // 
            // buttonPFXPlayAgain
            // 
            this.buttonPFXPlayAgain.Location = new System.Drawing.Point(12, 37);
            this.buttonPFXPlayAgain.Name = "buttonPFXPlayAgain";
            this.buttonPFXPlayAgain.Size = new System.Drawing.Size(132, 23);
            this.buttonPFXPlayAgain.TabIndex = 5;
            this.buttonPFXPlayAgain.Text = "Play again";
            this.buttonPFXPlayAgain.UseVisualStyleBackColor = true;
            this.buttonPFXPlayAgain.Click += new System.EventHandler(this.buttonPFXPlayAgain_Click);
            // 
            // checkBoxPfxSaveAllFields
            // 
            this.checkBoxPfxSaveAllFields.AutoSize = true;
            this.checkBoxPfxSaveAllFields.Checked = true;
            this.checkBoxPfxSaveAllFields.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPfxSaveAllFields.Location = new System.Drawing.Point(153, 70);
            this.checkBoxPfxSaveAllFields.Name = "checkBoxPfxSaveAllFields";
            this.checkBoxPfxSaveAllFields.Size = new System.Drawing.Size(91, 17);
            this.checkBoxPfxSaveAllFields.TabIndex = 6;
            this.checkBoxPfxSaveAllFields.Text = "Save all fields";
            this.checkBoxPfxSaveAllFields.UseVisualStyleBackColor = true;
            this.checkBoxPfxSaveAllFields.CheckedChanged += new System.EventHandler(this.checkBoxPfxSaveAllFields_CheckedChanged);
            // 
            // checkBoxPlayAuto
            // 
            this.checkBoxPlayAuto.AutoSize = true;
            this.checkBoxPlayAuto.Checked = true;
            this.checkBoxPlayAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPlayAuto.Location = new System.Drawing.Point(153, 41);
            this.checkBoxPlayAuto.Name = "checkBoxPlayAuto";
            this.checkBoxPlayAuto.Size = new System.Drawing.Size(160, 17);
            this.checkBoxPlayAuto.TabIndex = 7;
            this.checkBoxPlayAuto.Text = "Repeat effect after it is done";
            this.checkBoxPlayAuto.UseVisualStyleBackColor = true;
            this.checkBoxPlayAuto.CheckedChanged += new System.EventHandler(this.checkBoxPlayAuto_CheckedChanged);
            // 
            // PFXEditorWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 732);
            this.Controls.Add(this.treeViewPFX);
            this.Controls.Add(this.panelPFXTop);
            this.Controls.Add(this.panelPFXButtons);
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
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPfxInst;
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
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.CheckBox checkBoxPlayAuto;
    }
}