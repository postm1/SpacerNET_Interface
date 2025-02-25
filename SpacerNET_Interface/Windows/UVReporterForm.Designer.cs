
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
            this.labelDescr = new System.Windows.Forms.Label();
            this.panelBottomControls = new System.Windows.Forms.Panel();
            this.checkBoxUVNoColl = new System.Windows.Forms.CheckBox();
            this.buttonFindBadUV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelMinUVArea = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.listUVErrors.Size = new System.Drawing.Size(686, 330);
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
            this.panelDescTop.Controls.Add(this.labelDescr2);
            this.panelDescTop.Controls.Add(this.labelDescr);
            this.panelDescTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDescTop.Location = new System.Drawing.Point(0, 0);
            this.panelDescTop.Name = "panelDescTop";
            this.panelDescTop.Size = new System.Drawing.Size(686, 86);
            this.panelDescTop.TabIndex = 2;
            // 
            // labelDescr2
            // 
            this.labelDescr2.AutoSize = true;
            this.labelDescr2.Location = new System.Drawing.Point(4, 52);
            this.labelDescr2.Name = "labelDescr2";
            this.labelDescr2.Size = new System.Drawing.Size(335, 13);
            this.labelDescr2.TabIndex = 1;
            this.labelDescr2.Text = "This tool ignores: water, ghost occluders, sun blockers, alpha textures";
            // 
            // labelDescr
            // 
            this.labelDescr.AutoSize = true;
            this.labelDescr.Location = new System.Drawing.Point(3, 8);
            this.labelDescr.Name = "labelDescr";
            this.labelDescr.Size = new System.Drawing.Size(483, 39);
            this.labelDescr.TabIndex = 0;
            this.labelDescr.Text = "This window can find polygons with bad UV. \r\nWarning! \r\nThis instrument shows onl" +
    "y POSSIBLE UV problems, if your polygon is shown as bad, it still can be ok";
            // 
            // panelBottomControls
            // 
            this.panelBottomControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottomControls.Controls.Add(this.checkBoxUVNoColl);
            this.panelBottomControls.Controls.Add(this.buttonFindBadUV);
            this.panelBottomControls.Controls.Add(this.label2);
            this.panelBottomControls.Controls.Add(this.textBox3);
            this.panelBottomControls.Controls.Add(this.label1);
            this.panelBottomControls.Controls.Add(this.textBox2);
            this.panelBottomControls.Controls.Add(this.labelMinUVArea);
            this.panelBottomControls.Controls.Add(this.textBox1);
            this.panelBottomControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomControls.Location = new System.Drawing.Point(0, 416);
            this.panelBottomControls.Name = "panelBottomControls";
            this.panelBottomControls.Size = new System.Drawing.Size(686, 142);
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Distortion angle. Bad UV\'s can have this angle >= 10";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(11, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(51, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max UV area. Bad UV\'s can have >= 5";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "5";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0.001";
            // 
            // UVReporterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 558);
            this.Controls.Add(this.listUVErrors);
            this.Controls.Add(this.panelBottomControls);
            this.Controls.Add(this.panelDescTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.Label labelDescr;
        private System.Windows.Forms.Label labelMinUVArea;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonFindBadUV;
        private System.Windows.Forms.Label labelDescr2;
        private System.Windows.Forms.CheckBox checkBoxUVNoColl;
    }
}