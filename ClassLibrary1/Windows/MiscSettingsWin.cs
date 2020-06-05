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

        public void UpdateLang()
        {
            this.Text = Localizator.Get("WIN_MISC_SET");
            checkBoxSetDatePrefix.Text = Localizator.Get("checkBoxSetDatePrefix");
            checkBoxMiscExitAsk.Text = Localizator.Get("checkBoxMiscExitAsk");
            checkBoxLastZenAuto.Text = Localizator.Get("checkBoxLastZenAuto");
            checkBoxMiscFullPath.Text = Localizator.Get("checkBoxMiscFullPath");
            btnMiscSetApply.Text = Localizator.Get("BTN_APPLY");
        }

        public void LoadSettings()
        {
            Imports.Stack_PushString("fullPathTitle");
            Imports.Stack_PushString("openLastZen");
            Imports.Stack_PushString("askExitZen");
            Imports.Stack_PushString("addDatePrefix");

            int useDatePrefix = Imports.Extern_GetSetting();
            int askExitZen = Imports.Extern_GetSetting();

            int openLastZen = Imports.Extern_GetSetting();
            int fullPath = Imports.Extern_GetSetting();

            SpacerNET.miscSetWin.checkBoxSetDatePrefix.Checked = Convert.ToBoolean(useDatePrefix);
            SpacerNET.miscSetWin.checkBoxMiscExitAsk.Checked = Convert.ToBoolean(askExitZen);
            SpacerNET.miscSetWin.checkBoxLastZenAuto.Checked = Convert.ToBoolean(openLastZen);
            SpacerNET.miscSetWin.checkBoxMiscFullPath.Checked = Convert.ToBoolean(fullPath);

        }

        public void OnApplySettings()
        {
            Imports.Stack_PushString("fullPathTitle");
            Imports.Stack_PushString("openLastZen");
            Imports.Stack_PushString("askExitZen");
            Imports.Stack_PushString("addDatePrefix");

            Imports.Extern_SetSetting(Convert.ToInt32(checkBoxSetDatePrefix.Checked));
            Imports.Extern_SetSetting(Convert.ToInt32(checkBoxMiscExitAsk.Checked));
            Imports.Extern_SetSetting(Convert.ToInt32(checkBoxLastZenAuto.Checked));
            Imports.Extern_SetSetting(Convert.ToInt32(checkBoxMiscFullPath.Checked));
            
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
