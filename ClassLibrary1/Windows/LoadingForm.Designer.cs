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
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.panelLoadingFront = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.panelLoadingFront.SuspendLayout();
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
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLoading.Image = global::SpacerUnion.Properties.Resources.x317623_775512241;
            this.pictureBoxLoading.Location = new System.Drawing.Point(93, 54);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(258, 258);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLoading.TabIndex = 1;
            this.pictureBoxLoading.TabStop = false;
            // 
            // panelLoadingFront
            // 
            this.panelLoadingFront.BackColor = System.Drawing.SystemColors.Window;
            this.panelLoadingFront.Controls.Add(this.pictureBoxLoading);
            this.panelLoadingFront.Controls.Add(this.labelLoading);
            this.panelLoadingFront.Location = new System.Drawing.Point(1, 1);
            this.panelLoadingFront.Name = "panelLoadingFront";
            this.panelLoadingFront.Size = new System.Drawing.Size(455, 339);
            this.panelLoadingFront.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.panelLoadingFront.ResumeLayout(false);
            this.panelLoadingFront.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.Panel panelLoadingFront;
    }
}