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

        public void LoadSettings()
        {
            int useDatePrefix = Imports.Extern_GetSetting(UnionNET.AddString("addDatePrefix"));
            int askExitZen = Imports.Extern_GetSetting(UnionNET.AddString("askExitZen"));

            int openLastZen = Imports.Extern_GetSetting(UnionNET.AddString("openLastZen"));
            int fullPath = Imports.Extern_GetSetting(UnionNET.AddString("fullPathTitle"));

            UnionNET.miscSetWin.checkBoxSetDatePrefix.Checked = Convert.ToBoolean(useDatePrefix);
            UnionNET.miscSetWin.checkBoxMiscExitAsk.Checked = Convert.ToBoolean(askExitZen);
            UnionNET.miscSetWin.checkBoxLastZenAuto.Checked = Convert.ToBoolean(openLastZen);
            UnionNET.miscSetWin.checkBoxMiscFullPath.Checked = Convert.ToBoolean(fullPath);

        }

        public void OnApplySettings()
        {
            Imports.Extern_SetSetting(UnionNET.AddString("addDatePrefix"), Convert.ToInt32(checkBoxSetDatePrefix.Checked));
            Imports.Extern_SetSetting(UnionNET.AddString("askExitZen"), Convert.ToInt32(checkBoxMiscExitAsk.Checked));
            Imports.Extern_SetSetting(UnionNET.AddString("openLastZen"), Convert.ToInt32(checkBoxLastZenAuto.Checked));
            Imports.Extern_SetSetting(UnionNET.AddString("fullPathTitle"), Convert.ToInt32(checkBoxMiscFullPath.Checked));
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

        private void checkBoxMiscFullPath_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
