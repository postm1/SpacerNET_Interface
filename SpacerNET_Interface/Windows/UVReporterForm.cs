using SpacerUnion.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

            labelRadius.Text = Localizator.Get("UV_WIN_SLIDER_DIST") + trackBarRadiusShow.Value;


        }

        private void UVReporterForm_VisibleChanged(object sender, EventArgs e)
        {
            SpacerNET.form.toolStripButtonUV.Checked = this.Visible;
        }

        private void buttonFindBadUV_Click(object sender, EventArgs e)
        {
            if (!SpacerNET.form.toolStripButtonMaterial.Checked)
            {
                MessageBox.Show(Localizator.Get("UV_WIN_POLY_SELECT_MUST_BE_ON"));
                return;
            }

            float minArea = Convert.ToSingle(textBoxAreaMin.Text, CultureInfo.InvariantCulture);
            float maxArea = Convert.ToSingle(textBoxAreaMax.Text, CultureInfo.InvariantCulture);
            float angleDist = Convert.ToSingle(textBoxAngleDist.Text, CultureInfo.InvariantCulture);
            int ignoreNoColl = Convert.ToInt32(checkBoxUVNoColl.Checked);

            if (angleDist < 1 || angleDist > 179)
            {
                angleDist = 35;
                textBoxAngleDist.Text = "35";
            }

            Imports.Extern_SetUV_Settings(minArea, maxArea, angleDist, ignoreNoColl);
            Imports.Extern_UV_SetPolyRadius(trackBarRadiusShow.Value);

            Imports.Extern_UV_FindErrors();
        }

        private void textBoxAreaMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Utils.IsNumberInput(e.KeyChar, true, false))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)0x09)
            {
                e.Handled = false;
            }
        }

        private void textBoxAreaMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Utils.IsNumberInput(e.KeyChar, true, false))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)0x09)
            {
                e.Handled = false;
            }
        }

        private void textBoxAngleDist_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Utils.IsNumberInput(e.KeyChar, true, false))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)0x09)
            {
                e.Handled = false;
            }
        }

        private void trackBarRadiusShow_ValueChanged(object sender, EventArgs e)
        {
            labelRadius.Text = Localizator.Get("UV_WIN_SLIDER_DIST") + trackBarRadiusShow.Value;

            Imports.Extern_UV_SetPolyRadius(trackBarRadiusShow.Value);
        }
    }

    
}
