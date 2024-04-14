
namespace SpacerUnion.Windows
{
    partial class RenameForm
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
            this.buttonRenameWin_Apply = new System.Windows.Forms.Button();
            this.radioButtonRenameEmpty = new System.Windows.Forms.RadioButton();
            this.radioButtonNameForAll = new System.Windows.Forms.RadioButton();
            this.radioButtonNameOneNumberPostfix = new System.Windows.Forms.RadioButton();
            this.textBoxRenamesStarNumber = new System.Windows.Forms.TextBox();
            this.textBoxRenameForAllVobs = new System.Windows.Forms.TextBox();
            this.textBoxRenameWithPrefix = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonRenameWin_Apply
            // 
            this.buttonRenameWin_Apply.Location = new System.Drawing.Point(204, 118);
            this.buttonRenameWin_Apply.Name = "buttonRenameWin_Apply";
            this.buttonRenameWin_Apply.Size = new System.Drawing.Size(128, 23);
            this.buttonRenameWin_Apply.TabIndex = 0;
            this.buttonRenameWin_Apply.Text = "Apply";
            this.buttonRenameWin_Apply.UseVisualStyleBackColor = true;
            this.buttonRenameWin_Apply.Click += new System.EventHandler(this.buttonRenameWin_Apply_Click);
            // 
            // radioButtonRenameEmpty
            // 
            this.radioButtonRenameEmpty.AutoSize = true;
            this.radioButtonRenameEmpty.Checked = true;
            this.radioButtonRenameEmpty.Location = new System.Drawing.Point(12, 14);
            this.radioButtonRenameEmpty.Name = "radioButtonRenameEmpty";
            this.radioButtonRenameEmpty.Size = new System.Drawing.Size(160, 17);
            this.radioButtonRenameEmpty.TabIndex = 1;
            this.radioButtonRenameEmpty.TabStop = true;
            this.radioButtonRenameEmpty.Tag = "1";
            this.radioButtonRenameEmpty.Text = "Set empty names for all vobs";
            this.radioButtonRenameEmpty.UseVisualStyleBackColor = true;
            // 
            // radioButtonNameForAll
            // 
            this.radioButtonNameForAll.AutoSize = true;
            this.radioButtonNameForAll.Location = new System.Drawing.Point(12, 46);
            this.radioButtonNameForAll.Name = "radioButtonNameForAll";
            this.radioButtonNameForAll.Size = new System.Drawing.Size(145, 17);
            this.radioButtonNameForAll.TabIndex = 2;
            this.radioButtonNameForAll.Tag = "2";
            this.radioButtonNameForAll.Text = "Set one name for all vobs";
            this.radioButtonNameForAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonNameOneNumberPostfix
            // 
            this.radioButtonNameOneNumberPostfix.AutoSize = true;
            this.radioButtonNameOneNumberPostfix.Location = new System.Drawing.Point(12, 78);
            this.radioButtonNameOneNumberPostfix.Name = "radioButtonNameOneNumberPostfix";
            this.radioButtonNameOneNumberPostfix.Size = new System.Drawing.Size(218, 17);
            this.radioButtonNameOneNumberPostfix.TabIndex = 3;
            this.radioButtonNameOneNumberPostfix.Tag = "3";
            this.radioButtonNameOneNumberPostfix.Text = "Set one name with number started from...";
            this.radioButtonNameOneNumberPostfix.UseVisualStyleBackColor = true;
            // 
            // textBoxRenamesStarNumber
            // 
            this.textBoxRenamesStarNumber.Location = new System.Drawing.Point(462, 75);
            this.textBoxRenamesStarNumber.Name = "textBoxRenamesStarNumber";
            this.textBoxRenamesStarNumber.Size = new System.Drawing.Size(53, 20);
            this.textBoxRenamesStarNumber.TabIndex = 4;
            this.textBoxRenamesStarNumber.Text = "1";
            this.textBoxRenamesStarNumber.TextChanged += new System.EventHandler(this.textBoxRenamesStarNumber_TextChanged);
            // 
            // textBoxRenameForAllVobs
            // 
            this.textBoxRenameForAllVobs.Location = new System.Drawing.Point(301, 43);
            this.textBoxRenameForAllVobs.Name = "textBoxRenameForAllVobs";
            this.textBoxRenameForAllVobs.Size = new System.Drawing.Size(155, 20);
            this.textBoxRenameForAllVobs.TabIndex = 5;
            this.textBoxRenameForAllVobs.TextChanged += new System.EventHandler(this.textBoxRenameForAllVobs_TextChanged);
            // 
            // textBoxRenameWithPrefix
            // 
            this.textBoxRenameWithPrefix.Location = new System.Drawing.Point(301, 75);
            this.textBoxRenameWithPrefix.Name = "textBoxRenameWithPrefix";
            this.textBoxRenameWithPrefix.Size = new System.Drawing.Size(155, 20);
            this.textBoxRenameWithPrefix.TabIndex = 6;
            this.textBoxRenameWithPrefix.TextChanged += new System.EventHandler(this.textBoxRenameWithPrefix_TextChanged);
            // 
            // RenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 153);
            this.Controls.Add(this.textBoxRenameWithPrefix);
            this.Controls.Add(this.textBoxRenameForAllVobs);
            this.Controls.Add(this.textBoxRenamesStarNumber);
            this.Controls.Add(this.radioButtonNameOneNumberPostfix);
            this.Controls.Add(this.radioButtonNameForAll);
            this.Controls.Add(this.radioButtonRenameEmpty);
            this.Controls.Add(this.buttonRenameWin_Apply);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RenameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rename options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RenameForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RenameForm_FormClosed);
            this.Load += new System.EventHandler(this.RenameForm_Load);
            this.VisibleChanged += new System.EventHandler(this.RenameForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRenameWin_Apply;
        private System.Windows.Forms.RadioButton radioButtonRenameEmpty;
        private System.Windows.Forms.RadioButton radioButtonNameForAll;
        private System.Windows.Forms.RadioButton radioButtonNameOneNumberPostfix;
        private System.Windows.Forms.TextBox textBoxRenamesStarNumber;
        private System.Windows.Forms.TextBox textBoxRenameForAllVobs;
        private System.Windows.Forms.TextBox textBoxRenameWithPrefix;
    }
}