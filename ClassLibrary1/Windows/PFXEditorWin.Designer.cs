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
            this.SuspendLayout();
            // 
            // comboBoxPfxInst
            // 
            this.comboBoxPfxInst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPfxInst.FormattingEnabled = true;
            this.comboBoxPfxInst.Location = new System.Drawing.Point(140, 9);
            this.comboBoxPfxInst.Name = "comboBoxPfxInst";
            this.comboBoxPfxInst.Size = new System.Drawing.Size(280, 21);
            this.comboBoxPfxInst.TabIndex = 0;
            this.comboBoxPfxInst.SelectedIndexChanged += new System.EventHandler(this.comboBoxPfxInst_SelectedIndexChanged);
            // 
            // labelPFXName
            // 
            this.labelPFXName.AutoSize = true;
            this.labelPFXName.Location = new System.Drawing.Point(12, 12);
            this.labelPFXName.Name = "labelPFXName";
            this.labelPFXName.Size = new System.Drawing.Size(85, 13);
            this.labelPFXName.TabIndex = 1;
            this.labelPFXName.Text = "Инстанция PFX";
            // 
            // propertyGridPfx
            // 
            this.propertyGridPfx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.propertyGridPfx.Location = new System.Drawing.Point(0, 71);
            this.propertyGridPfx.Name = "propertyGridPfx";
            this.propertyGridPfx.Size = new System.Drawing.Size(432, 424);
            this.propertyGridPfx.TabIndex = 2;
            this.propertyGridPfx.SelectedGridItemChanged += new System.Windows.Forms.SelectedGridItemChangedEventHandler(this.propertyGridPfx_SelectedGridItemChanged);
            // 
            // savePFXButton
            // 
            this.savePFXButton.Location = new System.Drawing.Point(140, 36);
            this.savePFXButton.Name = "savePFXButton";
            this.savePFXButton.Size = new System.Drawing.Size(119, 23);
            this.savePFXButton.TabIndex = 3;
            this.savePFXButton.Text = "Сохранить";
            this.savePFXButton.UseVisualStyleBackColor = true;
            this.savePFXButton.Click += new System.EventHandler(this.savePFXButton_Click);
            // 
            // PFXEditorWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 495);
            this.Controls.Add(this.savePFXButton);
            this.Controls.Add(this.propertyGridPfx);
            this.Controls.Add(this.labelPFXName);
            this.Controls.Add(this.comboBoxPfxInst);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PFXEditorWin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "PFXEditorWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPfxInst;
        private System.Windows.Forms.Label labelPFXName;
        private System.Windows.Forms.PropertyGrid propertyGridPfx;
        private System.Windows.Forms.Button savePFXButton;
    }
}