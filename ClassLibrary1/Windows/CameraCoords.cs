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
    public partial class CameraCoords : Form
    {
        public CameraCoords()
        {
            InitializeComponent();
            textBoxCamVec0.AcceptsTab = true;
            textBoxCamVec1.AcceptsTab = true;
            textBoxCamVec2.AcceptsTab = true;
        }

        private void CameraCoords_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void buttonCameraGo_Click(object sender, EventArgs e)
        {
            float v0 = Convert.ToSingle(textBoxCamVec0.Text.Trim().Replace(',', '.'), new CultureInfo("en-US"));
            float v1 = Convert.ToSingle(textBoxCamVec1.Text.Trim().Replace(',', '.'), new CultureInfo("en-US"));
            float v2 = Convert.ToSingle(textBoxCamVec2.Text.Trim().Replace(',', '.'), new CultureInfo("en-US"));

            Imports.Stack_PushFloat(v2);
            Imports.Stack_PushFloat(v1);
            Imports.Stack_PushFloat(v0);
            Imports.Extern_SetCameraPos();

            if (checkBoxCloseCamWin.Checked)
            {
                this.Hide();
            }
            
        }

        private void textBoxCamVec0_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
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
    }
}
