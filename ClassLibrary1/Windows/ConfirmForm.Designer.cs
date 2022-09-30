namespace SpacerUnion.Windows
{
    partial class ConfirmForm
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
            this.textBoxValueEnter = new System.Windows.Forms.TextBox();
            this.labelTextShow = new System.Windows.Forms.Label();
            this.buttonConfirmYes = new System.Windows.Forms.Button();
            this.buttonConfirmNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxValueEnter
            // 
            this.textBoxValueEnter.Location = new System.Drawing.Point(15, 42);
            this.textBoxValueEnter.Name = "textBoxValueEnter";
            this.textBoxValueEnter.Size = new System.Drawing.Size(361, 20);
            this.textBoxValueEnter.TabIndex = 0;
            // 
            // labelTextShow
            // 
            this.labelTextShow.AutoSize = true;
            this.labelTextShow.Location = new System.Drawing.Point(12, 26);
            this.labelTextShow.Name = "labelTextShow";
            this.labelTextShow.Size = new System.Drawing.Size(75, 13);
            this.labelTextShow.TabIndex = 1;
            this.labelTextShow.Text = "Введите имя:";
            // 
            // buttonConfirmYes
            // 
            this.buttonConfirmYes.Location = new System.Drawing.Point(85, 84);
            this.buttonConfirmYes.Name = "buttonConfirmYes";
            this.buttonConfirmYes.Size = new System.Drawing.Size(94, 23);
            this.buttonConfirmYes.TabIndex = 2;
            this.buttonConfirmYes.Text = "Подтвердить";
            this.buttonConfirmYes.UseVisualStyleBackColor = true;
            this.buttonConfirmYes.Click += new System.EventHandler(this.buttonConfirmYes_Click);
            // 
            // buttonConfirmNo
            // 
            this.buttonConfirmNo.Location = new System.Drawing.Point(208, 84);
            this.buttonConfirmNo.Name = "buttonConfirmNo";
            this.buttonConfirmNo.Size = new System.Drawing.Size(95, 23);
            this.buttonConfirmNo.TabIndex = 3;
            this.buttonConfirmNo.Text = "Закрыть";
            this.buttonConfirmNo.UseVisualStyleBackColor = true;
            this.buttonConfirmNo.Click += new System.EventHandler(this.buttonConfirmNo_Click);
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 117);
            this.Controls.Add(this.buttonConfirmNo);
            this.Controls.Add(this.buttonConfirmYes);
            this.Controls.Add(this.labelTextShow);
            this.Controls.Add(this.textBoxValueEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfirmForm_FormClosing);
            this.Shown += new System.EventHandler(this.ConfirmForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxValueEnter;
        public System.Windows.Forms.Label labelTextShow;
        public System.Windows.Forms.Button buttonConfirmYes;
        public System.Windows.Forms.Button buttonConfirmNo;
    }
}