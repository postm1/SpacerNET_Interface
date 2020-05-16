namespace SpacerUnion
{
    partial class LoadingForm
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
            this.labelLoading = new System.Windows.Forms.Label();
            this.panelLoadingFront = new System.Windows.Forms.Panel();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.buttonLoadingFormClose = new System.Windows.Forms.Button();
            this.panelLoadingFront.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLoading
            // 
            this.labelLoading.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoading.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelLoading.Location = new System.Drawing.Point(1, 23);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(454, 23);
            this.labelLoading.TabIndex = 0;
            this.labelLoading.Text = "Идет загрузка... Подождите...";
            this.labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLoadingFront
            // 
            this.panelLoadingFront.BackColor = System.Drawing.SystemColors.Window;
            this.panelLoadingFront.Controls.Add(this.buttonLoadingFormClose);
            this.panelLoadingFront.Controls.Add(this.pictureBoxLoading);
            this.panelLoadingFront.Controls.Add(this.labelLoading);
            this.panelLoadingFront.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoadingFront.Location = new System.Drawing.Point(0, 0);
            this.panelLoadingFront.Name = "panelLoadingFront";
            this.panelLoadingFront.Size = new System.Drawing.Size(457, 341);
            this.panelLoadingFront.TabIndex = 2;
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLoading.Image = global::SpacerUnion.Properties.Resources.jab;
            this.pictureBoxLoading.Location = new System.Drawing.Point(96, 49);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(260, 260);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLoading.TabIndex = 1;
            this.pictureBoxLoading.TabStop = false;
            // 
            // buttonLoadingFormClose
            // 
            this.buttonLoadingFormClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLoadingFormClose.Location = new System.Drawing.Point(191, 313);
            this.buttonLoadingFormClose.Name = "buttonLoadingFormClose";
            this.buttonLoadingFormClose.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadingFormClose.TabIndex = 2;
            this.buttonLoadingFormClose.Text = "Закрыть";
            this.buttonLoadingFormClose.UseVisualStyleBackColor = true;
            this.buttonLoadingFormClose.Visible = false;
            this.buttonLoadingFormClose.Click += new System.EventHandler(this.buttonLoadingFormClose_Click);
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(457, 341);
            this.Controls.Add(this.panelLoadingFront);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Загрузка...";
            this.panelLoadingFront.ResumeLayout(false);
            this.panelLoadingFront.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Panel panelLoadingFront;
        public System.Windows.Forms.PictureBox pictureBoxLoading;
        public System.Windows.Forms.Button buttonLoadingFormClose;
    }
}