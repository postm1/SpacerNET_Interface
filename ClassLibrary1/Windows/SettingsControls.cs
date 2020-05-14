﻿using SpacerUnion.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace SpacerUnion.Windows
{
    public partial class SettingsControls : Form
    {
        public SettingsControls()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void SettingsControls_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        public void UpdateAll()
        {
            trackBarVobTransSpeed_ValueChanged(null, EventArgs.Empty);
            trackBarVobRotSpeed_ValueChanged(null, EventArgs.Empty);

        }


        private void trackBarVobTransSpeed_ValueChanged(object sender, EventArgs e)
        {
            labelVobTrans.Text = "Скорость перемещения: " + trackBarVobTransSpeed.Value;
            Imports.Extern_SetSetting(UnionNET.AddString("vobTransSpeed"), trackBarVobTransSpeed.Value);
            UnionNET.FreeStrings();
        }

        private void trackBarVobRotSpeed_ValueChanged(object sender, EventArgs e)
        {
            labelVobRot.Text = "Скорость вращения: " + trackBarVobRotSpeed.Value;
            Imports.Extern_SetSetting(UnionNET.AddString("vobRotSpeed"), trackBarVobRotSpeed.Value);
            UnionNET.FreeStrings();
        }

        private void buttonVobControlApply_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkBoxInsertVob_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            Imports.Extern_SetSetting(UnionNET.AddString("vobInsertItemLevel"), Convert.ToInt32(cb.Checked));
            UnionNET.FreeStrings();
        }

        private void checkBoxVobRotRandAngle_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            Imports.Extern_SetSetting(UnionNET.AddString("vobInsertVobRotRand"), Convert.ToInt32(cb.Checked));
            UnionNET.FreeStrings();
        }

        private void checkBoxVobInsertHierarchy_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            Imports.Extern_SetSetting(UnionNET.AddString("vobInsertHierarchy"), Convert.ToInt32(cb.Checked));
            UnionNET.FreeStrings();
        }

        public void SetRadioTurnMode(int mode)
        {
            if (mode == 0)
            {
                radioButtonWPTurnNone.Checked = true;
            }

            if (mode == 1)
            {
                radioButtonWPTurnAgainst.Checked = true;
            }

            if (mode == 2)
            {
                radioButtonWPTurnOn.Checked = true;
            }
        }

        private void radioButtonWPTurnNone_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            int val;

            if (rb.Checked)
            {
                int.TryParse(rb.Tag.ToString(), out val);

                Imports.Extern_SetSetting(UnionNET.AddString("wpTurnOn"), val);
                UnionNET.FreeStrings();
            }
            
        }

        private void SettingsControls_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                SettingsControls_FormClosing(null, new FormClosingEventArgs(CloseReason.UserClosing, true));
            }
        }
    }
}
