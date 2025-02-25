
namespace SpacerUnion.Windows
{
    partial class UVReporterForm
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
            this.listUVErrors = new System.Windows.Forms.ListView();
            this.columnHeaderNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelDescTop = new System.Windows.Forms.Panel();
            this.labelDescr2 = new System.Windows.Forms.Label();
            this.labelDescr1 = new System.Windows.Forms.Label();
            this.panelBottomControls = new System.Windows.Forms.Panel();
            this.checkBoxUVNoColl = new System.Windows.Forms.CheckBox();
            this.buttonFindBadUV = new System.Windows.Forms.Button();
            this.labelDistAngle = new System.Windows.Forms.Label();
            this.textBoxAngleDist = new System.Windows.Forms.TextBox();
            this.labelMaxUVArea = new System.Windows.Forms.Label();
            this.textBoxAreaMax = new System.Windows.Forms.TextBox();
            this.labelMinUVArea = new System.Windows.Forms.Label();
            this.textBoxAreaMin = new System.Windows.Forms.TextBox();
            this.labelDescr3 = new System.Windows.Forms.Label();
            this.panelDescTop.SuspendLayout();
            this.panelBottomControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // listUVErrors
            // 
            this.listUVErrors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNum,
            this.columnType});
            this.listUVErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUVErrors.FullRowSelect = true;
            this.listUVErrors.HideSelection = false;
            this.listUVErrors.LabelWrap = false;
            this.listUVErrors.Location = new System.Drawing.Point(0, 86);
            this.listUVErrors.MultiSelect = false;
            this.listUVErrors.Name = "listUVErrors";
            this.listUVErrors.Size = new System.Drawing.Size(664, 318);
            this.listUVErrors.TabIndex = 1;
            this.listUVErrors.UseCompatibleStateImageBehavior = false;
            this.listUVErrors.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNum
            // 
            this.columnHeaderNum.Text = "№";
            // 
            // columnType
            // 
            this.columnType.Text = "Polygon";
            this.columnType.Width = 600;
            // 
            // panelDescTop
            // 
            this.panelDescTop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDescTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDescTop.Controls.Add(this.labelDescr3);
            this.panelDescTop.Controls.Add(this.labelDescr2);
            this.panelDescTop.Controls.Add(this.labelDescr1);
            this.panelDescTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDescTop.Location = new System.Drawing.Point(0, 0);
            this.panelDescTop.Name = "panelDescTop";
            this.panelDescTop.Size = new System.Drawing.Size(664, 86);
            this.panelDescTop.TabIndex = 2;
            // 
            // labelDescr2
            // 
            this.labelDescr2.AutoSize = true;
            this.labelDescr2.Location = new System.Drawing.Point(3, 26);
            this.labelDescr2.Name = "labelDescr2";
            this.labelDescr2.Size = new System.Drawing.Size(41, 13);
            this.labelDescr2.TabIndex = 1;
            this.labelDescr2.Text = "Descr2";
            // 
            // labelDescr1
            // 
            this.labelDescr1.AutoSize = true;
            this.labelDescr1.Location = new System.Drawing.Point(3, 8);
            this.labelDescr1.Name = "labelDescr1";
            this.labelDescr1.Size = new System.Drawing.Size(219, 13);
            this.labelDescr1.TabIndex = 0;
            this.labelDescr1.Text = "This window can find polygons with bad UV. \r\n";
            // 
            // panelBottomControls
            // 
            this.panelBottomControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottomControls.Controls.Add(this.checkBoxUVNoColl);
            this.panelBottomControls.Controls.Add(this.buttonFindBadUV);
            this.panelBottomControls.Controls.Add(this.labelDistAngle);
            this.panelBottomControls.Controls.Add(this.textBoxAngleDist);
            this.panelBottomControls.Controls.Add(this.labelMaxUVArea);
            this.panelBottomControls.Controls.Add(this.textBoxAreaMax);
            this.panelBottomControls.Controls.Add(this.labelMinUVArea);
            this.panelBottomControls.Controls.Add(this.textBoxAreaMin);
            this.panelBottomControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomControls.Location = new System.Drawing.Point(0, 404);
            this.panelBottomControls.Name = "panelBottomControls";
            this.panelBottomControls.Size = new System.Drawing.Size(664, 142);
            this.panelBottomControls.TabIndex = 3;
            // 
            // checkBoxUVNoColl
            // 
            this.checkBoxUVNoColl.AutoSize = true;
            this.checkBoxUVNoColl.Checked = true;
            this.checkBoxUVNoColl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUVNoColl.Location = new System.Drawing.Point(12, 84);
            this.checkBoxUVNoColl.Name = "checkBoxUVNoColl";
            this.checkBoxUVNoColl.Size = new System.Drawing.Size(182, 17);
            this.checkBoxUVNoColl.TabIndex = 7;
            this.checkBoxUVNoColl.Text = "Ignore materials with no collisions";
            this.checkBoxUVNoColl.UseVisualStyleBackColor = true;
            // 
            // buttonFindBadUV
            // 
            this.buttonFindBadUV.Location = new System.Drawing.Point(237, 106);
            this.buttonFindBadUV.Name = "buttonFindBadUV";
            this.buttonFindBadUV.Size = new System.Drawing.Size(214, 23);
            this.buttonFindBadUV.TabIndex = 6;
            this.buttonFindBadUV.Text = "Find bad UV\'s";
            this.buttonFindBadUV.UseVisualStyleBackColor = true;
            this.buttonFindBadUV.Click += new System.EventHandler(this.buttonFindBadUV_Click);
            // 
            // labelDistAngle
            // 
            this.labelDistAngle.AutoSize = true;
            this.labelDistAngle.Location = new System.Drawing.Point(68, 60);
            this.labelDistAngle.Name = "labelDistAngle";
            this.labelDistAngle.Size = new System.Drawing.Size(256, 13);
            this.labelDistAngle.TabIndex = 5;
            this.labelDistAngle.Text = "Distortion angle. Bad UV\'s can have this angle >= 10";
            // 
            // textBoxAngleDist
            // 
            this.textBoxAngleDist.Location = new System.Drawing.Point(11, 57);
            this.textBoxAngleDist.Name = "textBoxAngleDist";
            this.textBoxAngleDist.Size = new System.Drawing.Size(51, 20);
            this.textBoxAngleDist.TabIndex = 4;
            this.textBoxAngleDist.Text = "15";
            this.textBoxAngleDist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAngleDist_KeyPress);
            // 
            // labelMaxUVArea
            // 
            this.labelMaxUVArea.AutoSize = true;
            this.labelMaxUVArea.Location = new System.Drawing.Point(68, 34);
            this.labelMaxUVArea.Name = "labelMaxUVArea";
            this.labelMaxUVArea.Size = new System.Drawing.Size(191, 13);
            this.labelMaxUVArea.TabIndex = 3;
            this.labelMaxUVArea.Text = "Max UV area. Bad UV\'s can have >= 5";
            // 
            // textBoxAreaMax
            // 
            this.textBoxAreaMax.Location = new System.Drawing.Point(11, 31);
            this.textBoxAreaMax.Name = "textBoxAreaMax";
            this.textBoxAreaMax.Size = new System.Drawing.Size(51, 20);
            this.textBoxAreaMax.TabIndex = 2;
            this.textBoxAreaMax.Text = "5";
            this.textBoxAreaMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAreaMax_KeyPress);
            // 
            // labelMinUVArea
            // 
            this.labelMinUVArea.AutoSize = true;
            this.labelMinUVArea.Location = new System.Drawing.Point(68, 8);
            this.labelMinUVArea.Name = "labelMinUVArea";
            this.labelMinUVArea.Size = new System.Drawing.Size(206, 13);
            this.labelMinUVArea.TabIndex = 1;
            this.labelMinUVArea.Text = "Minimal UV area. Bad UV\'s have <= 0.001";
            // 
            // textBoxAreaMin
            // 
            this.textBoxAreaMin.Location = new System.Drawing.Point(11, 5);
            this.textBoxAreaMin.Name = "textBoxAreaMin";
            this.textBoxAreaMin.Size = new System.Drawing.Size(51, 20);
            this.textBoxAreaMin.TabIndex = 0;
            this.textBoxAreaMin.Text = "0.001";
            this.textBoxAreaMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAreaMin_KeyPress);
            // 
            // labelDescr3
            // 
            this.labelDescr3.AutoSize = true;
            this.labelDescr3.Location = new System.Drawing.Point(3, 44);
            this.labelDescr3.Name = "labelDescr3";
            this.labelDescr3.Size = new System.Drawing.Size(41, 13);
            this.labelDescr3.TabIndex = 2;
            this.labelDescr3.Text = "Descr3";
            // 
            // UVReporterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 546);
            this.Controls.Add(this.listUVErrors);
            this.Controls.Add(this.panelBottomControls);
            this.Controls.Add(this.panelDescTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(483, 400);
            this.Name = "UVReporterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Find bad UV\'s on location mesh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UVReporterForm_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.UVReporterForm_VisibleChanged);
            this.panelDescTop.ResumeLayout(false);
            this.panelDescTop.PerformLayout();
            this.panelBottomControls.ResumeLayout(false);
            this.panelBottomControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listUVErrors;
        private System.Windows.Forms.ColumnHeader columnHeaderNum;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.Panel panelDescTop;
        private System.Windows.Forms.Panel panelBottomControls;
        private System.Windows.Forms.Label labelDescr1;
        private System.Windows.Forms.Label labelMinUVArea;
        private System.Windows.Forms.TextBox textBoxAreaMin;
        private System.Windows.Forms.Label labelMaxUVArea;
        private System.Windows.Forms.TextBox textBoxAreaMax;
        private System.Windows.Forms.Label labelDistAngle;
        private System.Windows.Forms.TextBox textBoxAngleDist;
        private System.Windows.Forms.Button buttonFindBadUV;
        private System.Windows.Forms.Label labelDescr2;
        private System.Windows.Forms.CheckBox checkBoxUVNoColl;
        private System.Windows.Forms.Label labelDescr3;
    }
}