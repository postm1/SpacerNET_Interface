using SpacerUnion.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion.Windows
{
    public partial class UVReporterForm : Form
    {
        public UVReporterForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void UVReporterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.FormOwnerClosing)
            {
                e.Cancel = true;
                return;
            }

            this.Hide();
            e.Cancel = true;
        }

        public void ToggleInterface(bool toggle)
        {

            if (!toggle)
            {
                listUVErrors.Items.Clear();
            }

            panelBottomControls.Enabled = toggle;

        }

        public void UpdateLang()
        {
            this.Text = Localizator.Get("UV_WIN_TITLE");
            labelDescr1.Text = Localizator.Get("UV_WIN_DESCR_1");
            labelDescr2.Text = Localizator.Get("UV_WIN_DESCR_2");
            labelDescr3.Text = Localizator.Get("UV_WIN_DESCR_3");
            buttonFindBadUV.Text = Localizator.Get("UV_WIN_BUTTON_FIND_UV");


            labelMinUVArea.Text = Localizator.Get("UV_WIN_MIN_AREA");
            labelMaxUVArea.Text = Localizator.Get("UV_WIN_MAX_AREA");
            labelDistAngle.Text = Localizator.Get("UV_WIN_MAX_ANGLE_DIST");
            checkBoxUVNoColl.Text = Localizator.Get("UV_WIN_IGNORE_NOCOLL");

            
        }

        private void UVReporterForm_VisibleChanged(object sender, EventArgs e)
        {
            SpacerNET.form.toolStripButtonUV.Checked = this.Visible;
        }

        private void buttonFindBadUV_Click(object sender, EventArgs e)
        {

        }
    }

    
}
