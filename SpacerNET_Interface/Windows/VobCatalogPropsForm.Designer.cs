﻿
namespace SpacerUnion.Windows
{
    partial class VobCatalogPropsForm
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
            this.buttonConfirmNo = new System.Windows.Forms.Button();
            this.buttonConfirmYes = new System.Windows.Forms.Button();
            this.labelTextShow = new System.Windows.Forms.Label();
            this.textBoxValueEnter = new System.Windows.Forms.TextBox();
            this.checkBoxDynColl = new System.Windows.Forms.CheckBox();
            this.checkBoxStatic = new System.Windows.Forms.CheckBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.checkBoxIsStaticVob = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonConfirmNo
            // 
            this.buttonConfirmNo.Location = new System.Drawing.Point(204, 141);
            this.buttonConfirmNo.Name = "buttonConfirmNo";
            this.buttonConfirmNo.Size = new System.Drawing.Size(124, 23);
            this.buttonConfirmNo.TabIndex = 7;
            this.buttonConfirmNo.Text = "Close";
            this.buttonConfirmNo.UseVisualStyleBackColor = true;
            this.buttonConfirmNo.Click += new System.EventHandler(this.buttonConfirmNo_Click);
            // 
            // buttonConfirmYes
            // 
            this.buttonConfirmYes.Location = new System.Drawing.Point(86, 141);
            this.buttonConfirmYes.Name = "buttonConfirmYes";
            this.buttonConfirmYes.Size = new System.Drawing.Size(112, 23);
            this.buttonConfirmYes.TabIndex = 6;
            this.buttonConfirmYes.Text = "Confirm";
            this.buttonConfirmYes.UseVisualStyleBackColor = true;
            this.buttonConfirmYes.Click += new System.EventHandler(this.buttonConfirmYes_Click);
            // 
            // labelTextShow
            // 
            this.labelTextShow.AutoSize = true;
            this.labelTextShow.Location = new System.Drawing.Point(24, 17);
            this.labelTextShow.Name = "labelTextShow";
            this.labelTextShow.Size = new System.Drawing.Size(65, 13);
            this.labelTextShow.TabIndex = 5;
            this.labelTextShow.Text = "Enter visual:";
            // 
            // textBoxValueEnter
            // 
            this.textBoxValueEnter.Location = new System.Drawing.Point(27, 33);
            this.textBoxValueEnter.Name = "textBoxValueEnter";
            this.textBoxValueEnter.Size = new System.Drawing.Size(348, 20);
            this.textBoxValueEnter.TabIndex = 4;
            // 
            // checkBoxDynColl
            // 
            this.checkBoxDynColl.AutoSize = true;
            this.checkBoxDynColl.Location = new System.Drawing.Point(27, 59);
            this.checkBoxDynColl.Name = "checkBoxDynColl";
            this.checkBoxDynColl.Size = new System.Drawing.Size(107, 17);
            this.checkBoxDynColl.TabIndex = 8;
            this.checkBoxDynColl.Text = "Dynamic collision";
            this.checkBoxDynColl.UseVisualStyleBackColor = true;
            // 
            // checkBoxStatic
            // 
            this.checkBoxStatic.AutoSize = true;
            this.checkBoxStatic.Location = new System.Drawing.Point(27, 82);
            this.checkBoxStatic.Name = "checkBoxStatic";
            this.checkBoxStatic.Size = new System.Drawing.Size(93, 17);
            this.checkBoxStatic.TabIndex = 9;
            this.checkBoxStatic.Text = "Static collision";
            this.checkBoxStatic.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(381, 31);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(42, 23);
            this.buttonOpenFile.TabIndex = 10;
            this.buttonOpenFile.Text = "...";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // checkBoxIsStaticVob
            // 
            this.checkBoxIsStaticVob.AutoSize = true;
            this.checkBoxIsStaticVob.Location = new System.Drawing.Point(27, 105);
            this.checkBoxIsStaticVob.Name = "checkBoxIsStaticVob";
            this.checkBoxIsStaticVob.Size = new System.Drawing.Size(70, 17);
            this.checkBoxIsStaticVob.TabIndex = 11;
            this.checkBoxIsStaticVob.Text = "staticVob";
            this.checkBoxIsStaticVob.UseVisualStyleBackColor = true;
            // 
            // VobCatalogPropsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 176);
            this.Controls.Add(this.checkBoxIsStaticVob);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.checkBoxStatic);
            this.Controls.Add(this.checkBoxDynColl);
            this.Controls.Add(this.buttonConfirmNo);
            this.Controls.Add(this.buttonConfirmYes);
            this.Controls.Add(this.labelTextShow);
            this.Controls.Add(this.textBoxValueEnter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VobCatalogPropsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VobCatalogPropsForm_FormClosing);
            this.Shown += new System.EventHandler(this.VobCatalogPropsForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonConfirmNo;
        public System.Windows.Forms.Button buttonConfirmYes;
        public System.Windows.Forms.Label labelTextShow;
        public System.Windows.Forms.TextBox textBoxValueEnter;
        public System.Windows.Forms.CheckBox checkBoxDynColl;
        public System.Windows.Forms.CheckBox checkBoxStatic;
        private System.Windows.Forms.Button buttonOpenFile;
        public System.Windows.Forms.CheckBox checkBoxIsStaticVob;
    }
}