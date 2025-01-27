using SpacerUnion.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            textBoxCamYaw.AcceptsTab = true;
            textBoxCamPitch.AcceptsTab = true;
        }

        public void UpdateLang()
        {
            this.Text = Localizator.Get("WIN_CAM_TEXT");
            checkBoxCloseCamWin.Text = Localizator.Get("WIN_CAM_CLOSEWIN");
            buttonCameraGo.Text = Localizator.Get("WIN_CAM_GO");
            buttonGetFrom.Text = Localizator.Get("WIN_CAM_GETFROMBUFFER");

            labelPitch.Text = Localizator.Get("labelPitch");
            labelYaw.Text = Localizator.Get("labelYaw");
            buttonSetCurrentCoords.Text = Localizator.Get("camSetCurPos");


            labelCamRot.Text = Localizator.Get("UNION_CAM_ROT");
            labelCamPos.Text = Localizator.Get("UNION_CAM_POS");
        }


        private void CameraCoords_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void buttonCameraGo_Click(object sender, EventArgs e)
        {
            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            float v0 = Convert.ToSingle(textBoxCamVec0.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
            float v1 = Convert.ToSingle(textBoxCamVec1.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
            float v2 = Convert.ToSingle(textBoxCamVec2.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
			
            float yaw = Convert.ToSingle(textBoxCamYaw.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
            float pitch = Convert.ToSingle(textBoxCamPitch.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);

            Imports.Stack_PushFloat(pitch);
            Imports.Stack_PushFloat(yaw);
			
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
            
            
            if (!char.IsControl(e.KeyChar) && !Utils.IsNumberInput(e.KeyChar, true, true))
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

        private void textBoxCamVec0_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Utils.IsNumberInput(e.KeyChar, true, true))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CameraCoords_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void CameraCoords_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void buttonGetFrom_Click(object sender, EventArgs e)
        {
            string text = Clipboard.GetText().Trim();

            var matches = Regex.Matches(text, @"-?\d+(\.\d+)?");

            if (matches.Count < 3)
            {
                return;
            }

            float x = float.Parse(matches[0].Value, CultureInfo.InvariantCulture);
            float y = float.Parse(matches[1].Value, CultureInfo.InvariantCulture);
            float z = float.Parse(matches[2].Value, CultureInfo.InvariantCulture);

            textBoxCamVec0.Text = x.ToString();
            textBoxCamVec1.Text = y.ToString();
            textBoxCamVec2.Text = z.ToString();
        }

        private void buttonSetCurrentCoords_Click(object sender, EventArgs e)
        {
            float t1, t2, t3;

            Imports.Extern_GetCurrentCameraPos();

            t3 = Imports.Stack_PeekFloat();
            t2 = Imports.Stack_PeekFloat();
            t1 = Imports.Stack_PeekFloat();

            textBoxCamVec0.Text = Convert.ToString(t1);
            textBoxCamVec1.Text = Convert.ToString(t2);
            textBoxCamVec2.Text = Convert.ToString(t3);
        }
    }
}
