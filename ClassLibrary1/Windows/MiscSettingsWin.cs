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
    public partial class MiscSettingsWin : Form
    {
        public MiscSettingsWin()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public void OnApplySettings()
        {
            Imports.Extern_SetSetting(UnionNET.AddString("addDatePrefix"), Convert.ToInt32(checkBoxSetDatePrefix.Checked));
            UnionNET.FreeStrings();
        }

        private void MiscSettingsWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnApplySettings();
            this.Hide();
            e.Cancel = true;
        }

        private void btnMiscSetApply_Click(object sender, EventArgs e)
        {
            OnApplySettings();
            this.Hide();
        }

        private void MiscSettingsWin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MiscSettingsWin_FormClosing(null, new FormClosingEventArgs(CloseReason.UserClosing, true));
            }
        }
    }
}
