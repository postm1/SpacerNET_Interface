
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


            Imports.Extern_SetSetting(SpacerNET.AddString("maxFPS"), value);
            SpacerNET.FreeStrings();
        }
        
        public void UpdateAll()
        {
            trackBarTransSpeed_ValueChanged(null, EventArgs.Empty);
            trackBarRotSpeed_ValueChanged(null, EventArgs.Empty);
            trackBarWorld_ValueChanged(null, EventArgs.Empty);
            trackBarVobs_ValueChanged(null, EventArgs.Empty);

        }

        private void trackBarTransSpeed_ValueChanged(object sender, EventArgs e)
        {
            labelTrans.Text = "Скорость полета: " + trackBarTransSpeed.Value;
            Imports.Extern_SetSetting(SpacerNET.AddString("camTransSpeed"), trackBarTransSpeed.Value);
            SpacerNET.FreeStrings();
        }

        private void trackBarRotSpeed_ValueChanged(object sender, EventArgs e)
        {
            labelRot.Text = "Скорость поворота: " + trackBarRotSpeed.Value;
            Imports.Extern_SetSetting(SpacerNET.AddString("camRotSpeed"), trackBarRotSpeed.Value);
            SpacerNET.FreeStrings();
        }

        private void trackBarWorld_ValueChanged(object sender, EventArgs e)
        {
            labelWorld.Text = "Мир: " + trackBarWorld.Value;
            Imports.Extern_SetSetting(SpacerNET.AddString("rangeWorld"), trackBarWorld.Value);
            SpacerNET.FreeStrings();
        }

        private void trackBarVobs_ValueChanged(object sender, EventArgs e)
        {
            labelVobs.Text = "Вобы: " + trackBarVobs.Value;
            Imports.Extern_SetSetting(SpacerNET.AddString("rangeVobs"), trackBarVobs.Value);
            SpacerNET.FreeStrings();
        }

        private void Применить_Click(object sender, EventArgs e)
        {
            OnApplySettings();

            this.Hide();
        }

        private void checkBoxFPS_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            Imports.Extern_SetSetting(SpacerNET.AddString("showFps"), Convert.ToInt32(cb.Checked));
            SpacerNET.FreeStrings();
        }

        private void checkBoxTris_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            Imports.Extern_SetSetting(SpacerNET.AddString("showTris"), Convert.ToInt32(cb.Checked));
            SpacerNET.FreeStrings();
        }

        private void checkBoxCamCoord_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            Imports.Extern_SetSetting(SpacerNET.AddString("showCamCoords"), Convert.ToInt32(cb.Checked));
            SpacerNET.FreeStrings();
        }

        private void checkBoxVobs_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            Imports.Extern_SetSetting(SpacerNET.AddString("showVobsCount"), Convert.ToInt32(cb.Checked));
            SpacerNET.FreeStrings();
        }

        private void checkBoxWaypoints_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            Imports.Extern_SetSetting(SpacerNET.AddString("showWaypointsCount"), Convert.ToInt32(cb.Checked));
            SpacerNET.FreeStrings();
        }

        private void checkBoxDistVob_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            Imports.Extern_SetSetting(SpacerNET.AddString("showVobDist"), Convert.ToInt32(cb.Checked));
            SpacerNET.FreeStrings();
        }

        private void checkBoxCameraHideWins_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            Imports.Extern_SetSetting(SpacerNET.AddString("hideCamWindows"), Convert.ToInt32(cb.Checked));
            SpacerNET.FreeStrings();
        }

        private void textBoxLimitFPS_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SettingsCamera_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void SettingsCamera_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                SettingsCamera_FormClosing(null, new FormClosingEventArgs(CloseReason.UserClosing, true));
            }
        }
    }
}
