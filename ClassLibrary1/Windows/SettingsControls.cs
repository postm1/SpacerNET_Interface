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


namespace SpacerUnion.Windows
{
    public partial class SettingsControls : Form
    {
        public SettingsControls()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public void UpdateLang()
        {
            this.Text = Localizator.Get("WIN_CONTROLSET_TEXT");
            groupBoxControlVob.Text = Localizator.Get("WIN_CONTROLSET_GROUP0");
            groupBoxSet.Text = Localizator.Get("WIN_CONTROLSET_GROUP1");
            checkBoxInsertVob.Text = Localizator.Get("checkBoxInsertVob");
            checkBoxVobRotRandAngle.Text = Localizator.Get("checkBoxVobRotRandAngle");
            checkBoxVobInsertHierarchy.Text = Localizator.Get("checkBoxVobInsertHierarchy");

            labelRotWpFP.Text = Localizator.Get("labelRotWpFP");
            radioButtonWPTurnNone.Text = Localizator.Get("radioButtonWPTurnNone");
            radioButtonWPTurnAgainst.Text = Localizator.Get("radioButtonWPTurnAgainst");
            radioButtonWPTurnOn.Text = Localizator.Get("radioButtonWPTurnOn");

            buttonVobControlApply.Text = Localizator.Get("BTN_APPLY");

            labelVobTrans.Text = Localizator.Get("WIN_CONTROLSET_TRANSSPEED") + trackBarVobTransSpeed.Value;
            labelVobRot.Text = Localizator.Get("WIN_CONTROLSET_ROTSPEED") + trackBarVobRotSpeed.Value;
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
            labelVobTrans.Text = Localizator.Get("WIN_CONTROLSET_TRANSSPEED") + trackBarVobTransSpeed.Value;
            textBoxVobTrans.Text = trackBarVobTransSpeed.Value.ToString();
            Imports.Stack_PushString("vobTransSpeed");
            Imports.Extern_SetSetting(trackBarVobTransSpeed.Value);
            
        }

        private void trackBarVobRotSpeed_ValueChanged(object sender, EventArgs e)
        {
            labelVobRot.Text = Localizator.Get("WIN_CONTROLSET_ROTSPEED") + trackBarVobRotSpeed.Value;
            textBoxVobRot.Text = trackBarVobRotSpeed.Value.ToString();
            Imports.Stack_PushString("vobRotSpeed");
            Imports.Extern_SetSetting(trackBarVobRotSpeed.Value);
            
        }

        private void buttonVobControlApply_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkBoxInsertVob_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            Imports.Stack_PushString("vobInsertItemLevel");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
            
        }

        private void checkBoxVobRotRandAngle_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            Imports.Stack_PushString("vobInsertVobRotRand");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
            
        }

        private void checkBoxVobInsertHierarchy_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            Imports.Stack_PushString("vobInsertHierarchy");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
            
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
                Imports.Stack_PushString("wpTurnOn");
                Imports.Extern_SetSetting(val);
                
            }
            
        }

        private void SettingsControls_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                SettingsControls_FormClosing(null, new FormClosingEventArgs(CloseReason.UserClosing, true));
            }
        }

        private void textBoxVobTrans_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxVobTrans_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxVobTrans.Text.Trim();

            if (text.Length == 0)
            {
                return;
            }

            int value = Convert.ToInt32(text);

            if (value > trackBarVobTransSpeed.Maximum)
            {
                value = trackBarVobTransSpeed.Maximum;
            }
            if (value < trackBarVobTransSpeed.Minimum)
            {
                value = trackBarVobTransSpeed.Minimum;
            }

            trackBarVobTransSpeed.Value = value;
        }

        private void textBoxVobRot_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxVobRot.Text.Trim();

            if (text.Length == 0)
            {
                return;
            }

            int value = Convert.ToInt32(text);

            if (value > trackBarVobRotSpeed.Maximum)
            {
                value = trackBarVobRotSpeed.Maximum;
            }
            if (value < trackBarVobRotSpeed.Minimum)
            {
                value = trackBarVobRotSpeed.Minimum;
            }

            trackBarVobRotSpeed.Value = value;
        }
    }
}
