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
            checkBoxMiscAutoCompile.Text = Localizator.Get("checkBoxMiscAutoCompile");
            checkBoxAutoCompileUncompiled.Text = Localizator.Get("checkBoxMiscAutoCompileUncZen");
            autoRemoveLevelCompo.Text = Localizator.Get("autoRemoveLevelCompo");
            showLightRadiusVob.Text = Localizator.Get("showLightRadiusVob");
            checkBoxAutoRemoveAllVisuals.Text = Localizator.Get("checkBoxAutoRemoveAllVisuals");
            checkBoxSetNearestVobCam.Text = Localizator.Get("checkBoxSetNearestVobCam");
            checkBoxShowPolysSort.Text = Localizator.Get("checkBoxShowPolysSort");

            btnMiscSetApply.Text = Localizator.Get("BTN_APPLY");
        }

        public void LoadSettings()
        {
           
            Imports.Stack_PushString("autoRemoveLevelCompo");
            Imports.Stack_PushString("autoCompileWorldLightForUnc");
            Imports.Stack_PushString("autoCompileWorldLight");
            Imports.Stack_PushString("fullPathTitle");
            Imports.Stack_PushString("openLastZen");
            Imports.Stack_PushString("askExitZen");
            Imports.Stack_PushString("addDatePrefix");

            int useDatePrefix = Imports.Extern_GetSetting();
            int askExitZen = Imports.Extern_GetSetting();

            int openLastZen = Imports.Extern_GetSetting();
            int fullPath = Imports.Extern_GetSetting();
            int autoCompile = Imports.Extern_GetSetting();
            int autoCompileUnc = Imports.Extern_GetSetting();
            int autoRemoveCompo = Imports.Extern_GetSetting();

            SpacerNET.miscSetWin.checkBoxSetDatePrefix.Checked = Convert.ToBoolean(useDatePrefix);
            SpacerNET.miscSetWin.checkBoxMiscExitAsk.Checked = Convert.ToBoolean(askExitZen);
            SpacerNET.miscSetWin.checkBoxLastZenAuto.Checked = Convert.ToBoolean(openLastZen);
            SpacerNET.miscSetWin.checkBoxMiscFullPath.Checked = Convert.ToBoolean(fullPath);
            SpacerNET.miscSetWin.checkBoxMiscAutoCompile.Checked = Convert.ToBoolean(autoCompile);
            SpacerNET.miscSetWin.checkBoxAutoCompileUncompiled.Checked = Convert.ToBoolean(autoCompileUnc);
            SpacerNET.miscSetWin.autoRemoveLevelCompo.Checked = Convert.ToBoolean(autoRemoveCompo);



            Imports.Stack_PushString("showLightRadiusVob");
            int showLightRadiusVob = Imports.Extern_GetSetting();
            SpacerNET.miscSetWin.showLightRadiusVob.Checked = Convert.ToBoolean(showLightRadiusVob);


            Imports.Stack_PushString("checkBoxAutoRemoveAllVisuals");
            SpacerNET.miscSetWin.checkBoxAutoRemoveAllVisuals.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());

            Imports.Stack_PushString("checkBoxSetNearestVobCam");
            SpacerNET.miscSetWin.checkBoxSetNearestVobCam.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());

            Imports.Stack_PushString("checkBoxShowPolysSort");
            SpacerNET.miscSetWin.checkBoxShowPolysSort.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());
        }

        public void OnApplySettings()
        {
            Imports.Stack_PushString("autoRemoveLevelCompo");
            Imports.Stack_PushString("autoCompileWorldLightForUnc");
            Imports.Stack_PushString("autoCompileWorldLight");
            Imports.Stack_PushString("fullPathTitle");
            Imports.Stack_PushString("openLastZen");
            Imports.Stack_PushString("askExitZen");
            Imports.Stack_PushString("addDatePrefix");

            Imports.Extern_SetSetting(Convert.ToInt32(checkBoxSetDatePrefix.Checked));
            Imports.Extern_SetSetting(Convert.ToInt32(checkBoxMiscExitAsk.Checked));
            Imports.Extern_SetSetting(Convert.ToInt32(checkBoxLastZenAuto.Checked));
            Imports.Extern_SetSetting(Convert.ToInt32(checkBoxMiscFullPath.Checked));
            Imports.Extern_SetSetting(Convert.ToInt32(checkBoxMiscAutoCompile.Checked));
            Imports.Extern_SetSetting(Convert.ToInt32(checkBoxAutoCompileUncompiled.Checked));
            Imports.Extern_SetSetting(Convert.ToInt32(autoRemoveLevelCompo.Checked));


            Imports.Stack_PushString("showLightRadiusVob");
            Imports.Extern_SetSetting(Convert.ToInt32(showLightRadiusVob.Checked));



            Imports.Stack_PushString("checkBoxAutoRemoveAllVisuals");
            Imports.Extern_SetSetting(Convert.ToInt32(checkBoxAutoRemoveAllVisuals.Checked));

            Imports.Stack_PushString("checkBoxSetNearestVobCam");
            Imports.Extern_SetSetting(Convert.ToInt32(checkBoxSetNearestVobCam.Checked));


            Imports.Stack_PushString("checkBoxShowPolysSort");
            Imports.Extern_SetSetting(Convert.ToInt32(checkBoxShowPolysSort.Checked));
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
