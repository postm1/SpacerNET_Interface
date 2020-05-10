
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


            Imports.Extern_SetSetting(Marshal.StringToHGlobalAnsi("maxFPS"), value);
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
            Imports.Extern_SetSetting(Marshal.StringToHGlobalAnsi("camTransSpeed"), trackBarTransSpeed.Value);
        }

        private void trackBarRotSpeed_ValueChanged(object sender, EventArgs e)
        {
            labelRot.Text = "Скорость поворота: " + trackBarRotSpeed.Value;
            Imports.Extern_SetSetting(Marshal.StringToHGlobalAnsi("camRotSpeed"), trackBarRotSpeed.Value);
        }

        private void trackBarWorld_ValueChanged(object sender, EventArgs e)
        {
            labelWorld.Text = "Мир: " + trackBarWorld.Value;
            Imports.Extern_SetSetting(Marshal.StringToHGlobalAnsi("rangeWorld"), trackBarWorld.Value);
        }

        private void trackBarVobs_ValueChanged(object sender, EventArgs e)
        {
            labelVobs.Text = "Вобы: " + trackBarVobs.Value;
            Imports.Extern_SetSetting(Marshal.StringToHGlobalAnsi("rangeVobs"), trackBarVobs.Value);
        }

        private void Применить_Click(object sender, EventArgs e)
        {
            OnApplySettings();

            this.Hide();
        }

        private void checkBoxFPS_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            Imports.Extern_SetSetting(Marshal.StringToHGlobalAnsi("showFps"), Convert.ToInt32(cb.Checked));
        }

        private void checkBoxTris_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            Imports.Extern_SetSetting(Marshal.StringToHGlobalAnsi("showTris"), Convert.ToInt32(cb.Checked));
        }

        private void checkBoxCamCoord_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            Imports.Extern_SetSetting(Marshal.StringToHGlobalAnsi("showCamCoords"), Convert.ToInt32(cb.Checked));
        }

        private void checkBoxVobs_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            Imports.Extern_SetSetting(Marshal.StringToHGlobalAnsi("showVobsCount"), Convert.ToInt32(cb.Checked));
        }

        private void checkBoxWaypoints_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            Imports.Extern_SetSetting(Marshal.StringToHGlobalAnsi("showWaypointsCount"), Convert.ToInt32(cb.Checked));
        }

        private void checkBoxDistVob_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            Imports.Extern_SetSetting(Marshal.StringToHGlobalAnsi("showVobDist"), Convert.ToInt32(cb.Checked));
        }

        private void checkBoxCameraHideWins_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            Imports.Extern_SetSetting(Marshal.StringToHGlobalAnsi("hideCamWindows"), Convert.ToInt32(cb.Checked));
        }

        private void textBoxLimitFPS_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
