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
            this.propertyGridPfx = new System.Windows.Forms.PropertyGrid();
            this.savePFXButton = new System.Windows.Forms.Button();
            this.treeViewPFX = new System.Windows.Forms.TreeView();
            this.buttonPfxEditorApply = new System.Windows.Forms.Button();
            this.panelPFXButtons = new System.Windows.Forms.Panel();
            this.panelPFXTop = new System.Windows.Forms.Panel();
            this.panelPFXButtons.SuspendLayout();
            this.panelPFXTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPfxInst
            // 
            this.comboBoxPfxInst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPfxInst.FormattingEnabled = true;
            this.comboBoxPfxInst.Location = new System.Drawing.Point(104, 13);
            this.comboBoxPfxInst.Name = "comboBoxPfxInst";
            this.comboBoxPfxInst.Size = new System.Drawing.Size(280, 21);
            this.comboBoxPfxInst.TabIndex = 0;
            this.comboBoxPfxInst.SelectedIndexChanged += new System.EventHandler(this.comboBoxPfxInst_SelectedIndexChanged);
            // 
            // labelPFXName
            // 
            this.labelPFXName.AutoSize = true;
            this.labelPFXName.Location = new System.Drawing.Point(13, 13);
            this.labelPFXName.Name = "labelPFXName";
            this.labelPFXName.Size = new System.Drawing.Size(85, 13);
            this.labelPFXName.TabIndex = 1;
            this.labelPFXName.Text = "Инстанция PFX";
            // 
            // propertyGridPfx
            // 
            this.propertyGridPfx.Location = new System.Drawing.Point(431, 3);
            this.propertyGridPfx.Name = "propertyGridPfx";
            this.propertyGridPfx.Size = new System.Drawing.Size(36, 77);
            this.propertyGridPfx.TabIndex = 2;
            this.propertyGridPfx.SelectedGridItemChanged += new System.Windows.Forms.SelectedGridItemChangedEventHandler(this.propertyGridPfx_SelectedGridItemChanged);
            this.propertyGridPfx.Click += new System.EventHandler(this.propertyGridPfx_Click);
            // 
            // savePFXButton
            // 
            this.savePFXButton.Location = new System.Drawing.Point(47, 57);
            this.savePFXButton.Name = "savePFXButton";
            this.savePFXButton.Size = new System.Drawing.Size(119, 23);
            this.savePFXButton.TabIndex = 3;
            this.savePFXButton.Text = "Сохранить";
            this.savePFXButton.UseVisualStyleBackColor = true;
            this.savePFXButton.Click += new System.EventHandler(this.savePFXButton_Click);
            // 
            // treeViewPFX
            // 
            this.treeViewPFX.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treeViewPFX.Location = new System.Drawing.Point(0, 99);
            this.treeViewPFX.Name = "treeViewPFX";
            this.treeViewPFX.Size = new System.Drawing.Size(467, 532);
            this.treeViewPFX.TabIndex = 4;
            // 
            // buttonPfxEditorApply
            // 
            this.buttonPfxEditorApply.Location = new System.Drawing.Point(15, 20);
            this.buttonPfxEditorApply.Name = "buttonPfxEditorApply";
            this.buttonPfxEditorApply.Size = new System.Drawing.Size(119, 23);
            this.buttonPfxEditorApply.TabIndex = 5;
            this.buttonPfxEditorApply.Text = "Apply";
            this.buttonPfxEditorApply.UseVisualStyleBackColor = true;
            // 
            // panelPFXButtons
            // 
            this.panelPFXButtons.Controls.Add(this.buttonPfxEditorApply);
            this.panelPFXButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPFXButtons.Location = new System.Drawing.Point(0, 631);
            this.panelPFXButtons.Name = "panelPFXButtons";
            this.panelPFXButtons.Size = new System.Drawing.Size(467, 100);
            this.panelPFXButtons.TabIndex = 6;
            // 
            // panelPFXTop
            // 
            this.panelPFXTop.Controls.Add(this.labelPFXName);
            this.panelPFXTop.Controls.Add(this.comboBoxPfxInst);
            this.panelPFXTop.Controls.Add(this.savePFXButton);
            this.panelPFXTop.Controls.Add(this.propertyGridPfx);
            this.panelPFXTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPFXTop.Location = new System.Drawing.Point(0, 0);
            this.panelPFXTop.Name = "panelPFXTop";
            this.panelPFXTop.Size = new System.Drawing.Size(467, 100);
            this.panelPFXTop.TabIndex = 7;
            // 
            // PFXEditorWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 731);
            this.Controls.Add(this.panelPFXTop);
            this.Controls.Add(this.treeViewPFX);
            this.Controls.Add(this.panelPFXButtons);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PFXEditorWin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PFXEditorWin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PFXEditorWin_FormClosing);
            this.panelPFXButtons.ResumeLayout(false);
            this.panelPFXTop.ResumeLayout(false);
            this.panelPFXTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPfxInst;
        private System.Windows.Forms.Label labelPFXName;
        private System.Windows.Forms.PropertyGrid propertyGridPfx;
        private System.Windows.Forms.Button savePFXButton;
        private System.Windows.Forms.TreeView treeViewPFX;
        private System.Windows.Forms.Button buttonPfxEditorApply;
        private System.Windows.Forms.Panel panelPFXButtons;
        private System.Windows.Forms.Panel panelPFXTop;
    }
}