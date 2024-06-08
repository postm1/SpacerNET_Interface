
namespace SpacerUnion.Windows
{
    partial class VobCatalogMoveForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.labelVisual = new System.Windows.Forms.Label();
            this.labelMode = new System.Windows.Forms.Label();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.labelGroups = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(336, 327);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(210, 327);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(120, 23);
            this.buttonApply.TabIndex = 1;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // labelVisual
            // 
            this.labelVisual.AutoSize = true;
            this.labelVisual.Location = new System.Drawing.Point(12, 29);
            this.labelVisual.Name = "labelVisual";
            this.labelVisual.Size = new System.Drawing.Size(140, 13);
            this.labelVisual.TabIndex = 2;
            this.labelVisual.Text = "Visual: SOME_VISUAL.3DS";
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Location = new System.Drawing.Point(12, 9);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(77, 13);
            this.labelMode.TabIndex = 3;
            this.labelMode.Text = "Mode: copying";
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(15, 97);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(637, 212);
            this.listBoxGroups.TabIndex = 4;
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.Location = new System.Drawing.Point(12, 72);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(44, 13);
            this.labelGroups.TabIndex = 5;
            this.labelGroups.Text = "Groups:";
            // 
            // VobCatalogMoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 362);
            this.Controls.Add(this.labelGroups);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.labelVisual);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VobCatalogMoveForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VobCatalogMoveForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VobCatalogMoveForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label labelVisual;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Label labelGroups;
    }
}