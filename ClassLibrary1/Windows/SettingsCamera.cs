
using SpacerUnion.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion
{
    public partial class SettingsCamera : Form
    {
        public SettingsCamera()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }


        public void UpdateLang()
        {
            this.Text = Localizator.Get("WIN_CONTROLCAM_TEXT");
            btnSetCamApply.Text = Localizator.Get("BTN_APPLY");

            groupBoxCam.Text = Localizator.Get("groupBoxCam");
            labelTrans.Text = Localizator.Get("labelTrans");
            labelRot.Text = Localizator.Get("labelRot");
            groupBoxRange.Text = Localizator.Get("groupBoxRange");
            labelWorld.Text = Localizator.Get("labelWorld");
            labelVobs.Text = Localizator.Get("labelVobs");
            labelLimitFPS.Text = Localizator.Get("labelLimitFPS");
            groupBoxInfo.Text = Localizator.Get("groupBoxInfo");
            checkBoxFPS.Text = Localizator.Get("checkBoxFPS");
            checkBoxTris.Text = Localizator.Get("checkBoxTris");
            checkBoxCamCoord.Text = Localizator.Get("checkBoxCamCoord");
            checkBoxVobs.Text = Localizator.Get("checkBoxVobs");
            checkBoxWaypoints.Text = Localizator.Get("checkBoxWaypoints");
            checkBoxDistVob.Text = Localizator.Get("checkBoxDistVob");
            checkBoxCameraHideWins.Text = Localizator.Get("checkBoxCameraHideWins");
            labelCamSetSlerp.Text = Localizator.Get("labelCamSetSlerp");
            checkBoxCamShowPortalsInfo.Text = Localizator.Get("checkBoxCamShowPortalsInfo");
            labelSpeedPreview.Text = Localizator.Get("labelSpeedPreview") + ": " + trackBarSpeedPreview.Value;

        }


        private void SettingsCamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnApplySettings();
            Hide();
            e.Cancel = true;
            
        }
        
        private void OnApplySettings()
        {

            int value;

            int.TryParse(textBoxLimitFPS.Text.Trim(), out value);

            Imports.Stack_PushString("maxFPS");
            Imports.Extern_SetSetting(value);
            
        }
        
        public void UpdateAll()
        {

            Imports.Stack_PushString("rangeVobs");
            Imports.Stack_PushString("rangeWorld");
            Imports.Stack_PushString("camRotSpeed");
            Imports.Stack_PushString("camTransSpeed");
            Imports.Stack_PushString("slerpRot");
            Imports.Stack_PushString("previewSpeed");   


            int speedPreview = Imports.Extern_GetSetting();
            int slerpRot = Imports.Extern_GetSetting();
            int transSpeed = Imports.Extern_GetSetting();
            int rotSpeed = Imports.Extern_GetSetting();

            int world = Imports.Extern_GetSetting();
            int vob = Imports.Extern_GetSetting();



            trackBarCamSlerp.Value = slerpRot;
            trackBarTransSpeed.Value = transSpeed;
            trackBarRotSpeed.Value = rotSpeed;

            trackBarWorld.Value = world;
            trackBarVobs.Value = vob;
            trackBarSpeedPreview.Value = speedPreview;

            Imports.Stack_PushString("maxFPS");
            Imports.Stack_PushString("hideCamWindows");
            Imports.Stack_PushString("showVobDist");
            Imports.Stack_PushString("showWaypointsCount");
            Imports.Stack_PushString("showVobsCount");
            Imports.Stack_PushString("showCamCoords");
            Imports.Stack_PushString("showTris");
            Imports.Stack_PushString("showFps");

           checkBoxFPS.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());
           checkBoxTris.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());


           checkBoxCamCoord.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());
           checkBoxVobs.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());


           checkBoxWaypoints.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());
           checkBoxDistVob.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());


           checkBoxCameraHideWins.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());


           textBoxLimitFPS.Text = Imports.Extern_GetSetting().ToString();


            Imports.Stack_PushString("showPortalsInfo");
            checkBoxCamShowPortalsInfo.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());

            trackBarTransSpeed_ValueChanged(null, EventArgs.Empty);
            trackBarRotSpeed_ValueChanged(null, EventArgs.Empty);
            trackBarWorld_ValueChanged(null, EventArgs.Empty);
            trackBarVobs_ValueChanged(null, EventArgs.Empty);
            trackBarCamSlerp_ValueChanged(null, EventArgs.Empty);
            trackBarSpeedPreview_ValueChanged(null, EventArgs.Empty);
        }

        private void trackBarTransSpeed_ValueChanged(object sender, EventArgs e)
        {
            labelTrans.Text = Localizator.Get("labelTrans") + ": " + trackBarTransSpeed.Value;
            textBoxCamTrans.Text = trackBarTransSpeed.Value.ToString();
            Imports.Stack_PushString("camTransSpeed");
            Imports.Extern_SetSetting(trackBarTransSpeed.Value);
            
        }

        private void trackBarRotSpeed_ValueChanged(object sender, EventArgs e)
        {
            labelRot.Text = Localizator.Get("labelRot") + ": " + trackBarRotSpeed.Value;
            textBoxCamRot.Text = trackBarRotSpeed.Value.ToString();
            Imports.Stack_PushString("camRotSpeed");
            Imports.Extern_SetSetting(trackBarRotSpeed.Value);
            
        }

        private void trackBarWorld_ValueChanged(object sender, EventArgs e)
        {
            labelWorld.Text = Localizator.Get("labelWorld") + ": " + trackBarWorld.Value;
            textBoxWorldRange.Text = trackBarWorld.Value.ToString();
            Imports.Stack_PushString("rangeWorld");
            Imports.Extern_SetSetting(trackBarWorld.Value);
            
        }

        private void trackBarVobs_ValueChanged(object sender, EventArgs e)
        {
            labelVobs.Text = Localizator.Get("labelVobs") + ": " + trackBarVobs.Value;
            textBoxVobsRange.Text = trackBarVobs.Value.ToString();
            Imports.Stack_PushString("rangeVobs");
            Imports.Extern_SetSetting(trackBarVobs.Value);
            
        }

        private void Применить_Click(object sender, EventArgs e)
        {
            OnApplySettings();

            this.Hide();
        }

        private void checkBoxFPS_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            Imports.Stack_PushString("showFps");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
            
        }

        private void checkBoxTris_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            Imports.Stack_PushString("showTris");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
            
        }

        private void checkBoxCamCoord_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            Imports.Stack_PushString("showCamCoords");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
            
        }

        private void checkBoxVobs_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            Imports.Stack_PushString("showVobsCount");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
            
        }

        private void checkBoxWaypoints_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            Imports.Stack_PushString("showWaypointsCount");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
            
        }

        private void checkBoxDistVob_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            Imports.Stack_PushString("showVobDist");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
            
        }

        private void checkBoxCameraHideWins_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            Imports.Stack_PushString("hideCamWindows");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
            
        }

        private void textBoxLimitFPS_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SettingsCamera_KeyPress(object sender, KeyPressEventArgs e)
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

        private void SettingsCamera_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                SettingsCamera_FormClosing(null, new FormClosingEventArgs(CloseReason.UserClosing, true));
            }
        }

        private void textBoxCamTrans_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxCamTrans_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxCamTrans.Text.Trim();

            if (text.Length == 0)
            {
                return;
            }

            int value = Convert.ToInt32(text);

            if (value > trackBarTransSpeed.Maximum)
            {
                value = trackBarTransSpeed.Maximum;
            }
            if (value < trackBarTransSpeed.Minimum)
            {
                value = trackBarTransSpeed.Minimum;
            }

            trackBarTransSpeed.Value = value;


        }

        private void textBoxCamRot_TextChanged(object sender, EventArgs e)
        {

            string text = textBoxCamRot.Text.Trim();

            if (text.Length == 0)
            {
                return;
            }


            int value = Convert.ToInt32(text);

            if (value > trackBarRotSpeed.Maximum)
            {
                value = trackBarRotSpeed.Maximum;
            }
            if (value < trackBarRotSpeed.Minimum)
            {
                value = trackBarRotSpeed.Minimum;
            }

            trackBarRotSpeed.Value = value;
        }

        private void textBoxWorldRange_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxWorldRange.Text.Trim();

            if (text.Length == 0)
            {
                return;
            }

            int value = Convert.ToInt32(text);

            if (value > trackBarWorld.Maximum)
            {
                value = trackBarWorld.Maximum;
            }
            if (value < trackBarWorld.Minimum)
            {
                value = trackBarWorld.Minimum;
            }

            trackBarWorld.Value = value;
        }

        private void textBoxVobsRange_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxVobsRange.Text.Trim();

            if (text.Length == 0)
            {
                return;
            }


            int value = Convert.ToInt32(text);

            if (value > trackBarVobs.Maximum)
            {
                value = trackBarVobs.Maximum;
            }
            if (value < trackBarVobs.Minimum)
            {
                value = trackBarVobs.Minimum;
            }

            trackBarVobs.Value = value;
        }

        private void trackBarCamSlerp_ValueChanged(object sender, EventArgs e)
        {
            labelCamSetSlerp.Text = Localizator.Get("labelCamSetSlerp") + ": " + trackBarCamSlerp.Value;
            textBoxCamSlerp.Text = trackBarCamSlerp.Value.ToString();
            Imports.Stack_PushString("slerpRot");
            Imports.Extern_SetSetting(trackBarCamSlerp.Value);
        }

        private void textBoxCamSlerp_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxCamSlerp.Text.Trim();

            if (text.Length == 0)
            {
                return;
            }


            int value = Convert.ToInt32(text);

            if (value > trackBarCamSlerp.Maximum)
            {
                value = trackBarCamSlerp.Maximum;
            }
            if (value < trackBarCamSlerp.Minimum)
            {
                value = trackBarCamSlerp.Minimum;
            }

            trackBarCamSlerp.Value = value;
        }

        private void trackBarSpeedPreview_ValueChanged(object sender, EventArgs e)
        {
            labelSpeedPreview.Text = Localizator.Get("labelSpeedPreview") + ": " + trackBarSpeedPreview.Value;
            Imports.Stack_PushString("previewSpeed");
            Imports.Extern_SetSetting(trackBarSpeedPreview.Value);
        }

        private void checkBoxCamShowPortalsInfo_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            Imports.Stack_PushString("showPortalsInfo");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
        }
    }
}
