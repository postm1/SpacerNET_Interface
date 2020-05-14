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
    public partial class CameraCoords : Form
    {
        public CameraCoords()
        {
            InitializeComponent();
        }

        private void CameraCoords_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void buttonCameraGo_Click(object sender, EventArgs e)
        {
            float v0 = Convert.ToSingle(textBoxCamVec0.Text.Trim());
            float v1 = Convert.ToSingle(textBoxCamVec1.Text.Trim());
            float v2 = Convert.ToSingle(textBoxCamVec2.Text.Trim());

            Imports.Extern_SetCameraPos(v0, v1, v2);

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
        }
    }
}
