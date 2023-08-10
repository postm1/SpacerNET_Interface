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
            this.labelTexInfo = new System.Windows.Forms.Label();
            this.labelLoadingMiddle = new System.Windows.Forms.Label();
            this.buttonLoadingFormClose = new System.Windows.Forms.Button();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
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
            this.labelLoading.Text = "ZEN is loading...";
            this.labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLoadingFront
            // 
            this.panelLoadingFront.BackColor = System.Drawing.SystemColors.Window;
            this.panelLoadingFront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLoadingFront.Controls.Add(this.labelTexInfo);
            this.panelLoadingFront.Controls.Add(this.labelLoadingMiddle);
            this.panelLoadingFront.Controls.Add(this.buttonLoadingFormClose);
            this.panelLoadingFront.Controls.Add(this.pictureBoxLoading);
            this.panelLoadingFront.Controls.Add(this.labelLoading);
            this.panelLoadingFront.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoadingFront.Location = new System.Drawing.Point(0, 0);
            this.panelLoadingFront.Name = "panelLoadingFront";
            this.panelLoadingFront.Size = new System.Drawing.Size(457, 341);
            this.panelLoadingFront.TabIndex = 2;
            // 
            // labelTexInfo
            // 
            this.labelTexInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTexInfo.ForeColor = System.Drawing.Color.Black;
            this.labelTexInfo.Location = new System.Drawing.Point(26, 122);
            this.labelTexInfo.Margin = new System.Windows.Forms.Padding(5);
            this.labelTexInfo.Name = "labelTexInfo";
            this.labelTexInfo.Size = new System.Drawing.Size(409, 123);
            this.labelTexInfo.TabIndex = 5;
            this.labelTexInfo.Text = "Some of your materials don\'t have a compiled \'-C.TEX\' version of texture.\r\nTo sav" +
    "e the filter such textures must be compiled from TGA textures.\r\nConverting...";
            // 
            // labelLoadingMiddle
            // 
            this.labelLoadingMiddle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoadingMiddle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelLoadingMiddle.Location = new System.Drawing.Point(0, 59);
            this.labelLoadingMiddle.Name = "labelLoadingMiddle";
            this.labelLoadingMiddle.Size = new System.Drawing.Size(454, 23);
            this.labelLoadingMiddle.TabIndex = 3;
            this.labelLoadingMiddle.Text = "Don\'t shut down SpacerNET!";
            this.labelLoadingMiddle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
        public System.Windows.Forms.Label labelLoadingMiddle;
        private System.Windows.Forms.Label labelTexInfo;
    }
}