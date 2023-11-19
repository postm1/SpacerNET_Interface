namespace SpacerUnion.Windows
{
    partial class MacrosForm
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
            this.richTextBoxMacros = new System.Windows.Forms.RichTextBox();
            this.buttonMacrosRun = new System.Windows.Forms.Button();
            this.groupBoxMacrosButtons = new System.Windows.Forms.GroupBox();
            this.buttonMacrosReloadFromFile = new System.Windows.Forms.Button();
            this.buttonCreateNewMacros = new System.Windows.Forms.Button();
            this.buttonMacrosRemoveCurrent = new System.Windows.Forms.Button();
            this.buttonMacrosRenameCurrent = new System.Windows.Forms.Button();
            this.buttonMacrosSaveAll = new System.Windows.Forms.Button();
            this.listBoxMacros = new System.Windows.Forms.ListBox();
            this.groupBoxMacrosButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxMacros
            // 
            this.richTextBoxMacros.Location = new System.Drawing.Point(3, 179);
            this.richTextBoxMacros.Name = "richTextBoxMacros";
            this.richTextBoxMacros.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxMacros.Size = new System.Drawing.Size(601, 215);
            this.richTextBoxMacros.TabIndex = 9;
            this.richTextBoxMacros.Text = "";
            this.richTextBoxMacros.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBoxMacros_KeyDown);
            this.richTextBoxMacros.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBoxMacros_KeyUp);
            // 
            // buttonMacrosRun
            // 
            this.buttonMacrosRun.Location = new System.Drawing.Point(3, 150);
            this.buttonMacrosRun.Name = "buttonMacrosRun";
            this.buttonMacrosRun.Size = new System.Drawing.Size(287, 23);
            this.buttonMacrosRun.TabIndex = 8;
            this.buttonMacrosRun.Text = "Run";
            this.buttonMacrosRun.UseVisualStyleBackColor = true;
            this.buttonMacrosRun.Click += new System.EventHandler(this.buttonMacrosRun_Click);
            // 
            // groupBoxMacrosButtons
            // 
            this.groupBoxMacrosButtons.Controls.Add(this.buttonMacrosReloadFromFile);
            this.groupBoxMacrosButtons.Controls.Add(this.buttonCreateNewMacros);
            this.groupBoxMacrosButtons.Controls.Add(this.buttonMacrosRemoveCurrent);
            this.groupBoxMacrosButtons.Controls.Add(this.buttonMacrosRenameCurrent);
            this.groupBoxMacrosButtons.Controls.Add(this.buttonMacrosSaveAll);
            this.groupBoxMacrosButtons.Location = new System.Drawing.Point(306, 4);
            this.groupBoxMacrosButtons.Name = "groupBoxMacrosButtons";
            this.groupBoxMacrosButtons.Size = new System.Drawing.Size(289, 169);
            this.groupBoxMacrosButtons.TabIndex = 7;
            this.groupBoxMacrosButtons.TabStop = false;
            this.groupBoxMacrosButtons.Text = "Actions";
            // 
            // buttonMacrosReloadFromFile
            // 
            this.buttonMacrosReloadFromFile.Location = new System.Drawing.Point(17, 107);
            this.buttonMacrosReloadFromFile.Name = "buttonMacrosReloadFromFile";
            this.buttonMacrosReloadFromFile.Size = new System.Drawing.Size(266, 23);
            this.buttonMacrosReloadFromFile.TabIndex = 4;
            this.buttonMacrosReloadFromFile.Text = "Reload all from the file";
            this.buttonMacrosReloadFromFile.UseVisualStyleBackColor = true;
            this.buttonMacrosReloadFromFile.Click += new System.EventHandler(this.buttonMacrosReloadFromFile_Click);
            // 
            // buttonCreateNewMacros
            // 
            this.buttonCreateNewMacros.Location = new System.Drawing.Point(17, 19);
            this.buttonCreateNewMacros.Name = "buttonCreateNewMacros";
            this.buttonCreateNewMacros.Size = new System.Drawing.Size(266, 23);
            this.buttonCreateNewMacros.TabIndex = 3;
            this.buttonCreateNewMacros.Text = "Create a new macros";
            this.buttonCreateNewMacros.UseVisualStyleBackColor = true;
            this.buttonCreateNewMacros.Click += new System.EventHandler(this.buttonCreateNewMacros_Click);
            // 
            // buttonMacrosRemoveCurrent
            // 
            this.buttonMacrosRemoveCurrent.Location = new System.Drawing.Point(17, 78);
            this.buttonMacrosRemoveCurrent.Name = "buttonMacrosRemoveCurrent";
            this.buttonMacrosRemoveCurrent.Size = new System.Drawing.Size(266, 23);
            this.buttonMacrosRemoveCurrent.TabIndex = 2;
            this.buttonMacrosRemoveCurrent.Text = "Delete";
            this.buttonMacrosRemoveCurrent.UseVisualStyleBackColor = true;
            this.buttonMacrosRemoveCurrent.Click += new System.EventHandler(this.buttonMacrosRemoveCurrent_Click);
            // 
            // buttonMacrosRenameCurrent
            // 
            this.buttonMacrosRenameCurrent.Location = new System.Drawing.Point(17, 49);
            this.buttonMacrosRenameCurrent.Name = "buttonMacrosRenameCurrent";
            this.buttonMacrosRenameCurrent.Size = new System.Drawing.Size(266, 23);
            this.buttonMacrosRenameCurrent.TabIndex = 1;
            this.buttonMacrosRenameCurrent.Text = "Rename";
            this.buttonMacrosRenameCurrent.UseVisualStyleBackColor = true;
            this.buttonMacrosRenameCurrent.Click += new System.EventHandler(this.buttonMacrosRenameCurrent_Click);
            // 
            // buttonMacrosSaveAll
            // 
            this.buttonMacrosSaveAll.Location = new System.Drawing.Point(16, 136);
            this.buttonMacrosSaveAll.Name = "buttonMacrosSaveAll";
            this.buttonMacrosSaveAll.Size = new System.Drawing.Size(267, 23);
            this.buttonMacrosSaveAll.TabIndex = 0;
            this.buttonMacrosSaveAll.Text = "Save all to the file";
            this.buttonMacrosSaveAll.UseVisualStyleBackColor = true;
            this.buttonMacrosSaveAll.Click += new System.EventHandler(this.buttonMacrosSaveAll_Click);
            // 
            // listBoxMacros
            // 
            this.listBoxMacros.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxMacros.FormattingEnabled = true;
            this.listBoxMacros.Location = new System.Drawing.Point(3, 5);
            this.listBoxMacros.Name = "listBoxMacros";
            this.listBoxMacros.Size = new System.Drawing.Size(287, 134);
            this.listBoxMacros.TabIndex = 6;
            this.listBoxMacros.SelectedIndexChanged += new System.EventHandler(this.listBoxMacros_SelectedIndexChanged);
            this.listBoxMacros.DoubleClick += new System.EventHandler(this.listBoxMacros_DoubleClick);
            // 
            // MacrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 395);
            this.Controls.Add(this.richTextBoxMacros);
            this.Controls.Add(this.buttonMacrosRun);
            this.Controls.Add(this.groupBoxMacrosButtons);
            this.Controls.Add(this.listBoxMacros);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MacrosForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Macros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MacrosForm_FormClosing);
            this.groupBoxMacrosButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBoxMacros;
        private System.Windows.Forms.Button buttonMacrosRun;
        private System.Windows.Forms.GroupBox groupBoxMacrosButtons;
        private System.Windows.Forms.Button buttonMacrosReloadFromFile;
        private System.Windows.Forms.Button buttonCreateNewMacros;
        private System.Windows.Forms.Button buttonMacrosRemoveCurrent;
        private System.Windows.Forms.Button buttonMacrosRenameCurrent;
        private System.Windows.Forms.Button buttonMacrosSaveAll;
        public System.Windows.Forms.ListBox listBoxMacros;
    }
}