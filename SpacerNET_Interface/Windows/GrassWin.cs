using SpacerUnion.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion.Windows
{
    public partial class GrassWin : Form
    {
        public GrassWin()
        {
            InitializeComponent();
            UpdateLang();

            comboBoxVisualCamAlign.SelectedIndex = 0;
            comboBoxVisualAniMode.SelectedIndex = 0;
            OnSettingsChanged();
        }

        private void GrassWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            SpacerNET.form.SetIconActive("grass", false);

            // turn off Grass placer
            Imports.Stack_PushString("bToggleWorkMode");
            Imports.Extern_SetSetting(0);
        }

        public void UpdateLang()
        {

            
            this.Text = Localizator.Get("WIN_GRASS_TITLE");

            this.labelWinGrassMinRadius.Text = Localizator.Get("WIN_GRASS_MINRADIUS") + trackBarWinGrassMinRadius.Value;
            this.labelWinGrassVertOffset.Text = Localizator.Get("WIN_GRASS_VERTOFFSET") + trackBarGrassWinVertical.Value;

            
            this.labelGrassWinVobName.Text = Localizator.Get("WIN_GRASS_VOBMODEL");
            this.checkBoxGrassWinCopyName.Text = Localizator.Get("WIN_GRASS_COPYNAME");
            this.checkBoxGrassWinRemove.Text = Localizator.Get("WIN_GRASS_REMOVE");
            this.checkBoxGrassWinIsItem.Text = Localizator.Get("WIN_GRASS_ISITEM");
            this.checkBoxGrassWinClickOnce.Text = Localizator.Get("WIN_GRASS_PROTECT");
            this.checkBoxGrassWinDynColl.Text = Localizator.Get("WIN_GRASS_DYNCOLL");
            this.checkBoxGrassWinRotRand.Text = Localizator.Get("WIN_GRASS_RANDANGLE");
            this.checkBoxGrassWinSetNormal.Text = Localizator.Get("WIN_GRASS_NORMALPOLYGON");


            this.buttonGrassWinApply.Text = Localizator.Get("BTN_APPLY");
            this.buttonSetDefaultValue.Text = Localizator.Get("BTN_SET_DEFAULT_VALUES");
            this.buttonOpenFile.Text = Localizator.Get("BTN_OPEN_FILE");
        }

        private void trackBarWinGrassMinRadius_ValueChanged(object sender, EventArgs e)
        {

            if (!SpacerNET.isInit)
            {
                return;
            }

            var track = sender as TrackBar;

            Imports.Stack_PushString("grassMinDist");
            Imports.Extern_SetSetting(track.Value);

            this.UpdateLang();
        }

        private void textBoxGrassWinModel_TextChanged(object sender, EventArgs e)
        {

            var text = sender as TextBox;

           
            Imports.Stack_PushString(text.Text.Trim());
            Imports.Stack_PushString("grassModelName");
            Imports.Extern_SetSettingStr();

        }



        private void trackBarGrassWinVertical_ValueChanged(object sender, EventArgs e)
        {
            if (!SpacerNET.isInit)
            {
                return;
            }

            var track = sender as TrackBar;


            Imports.Stack_PushString("grassVertOffset");
            Imports.Extern_SetSetting(track.Value);

            this.UpdateLang();
        }

        public void OnSettingsChanged()
        {
            if (!SpacerNET.isInit)
            {
                return;
            }

            int comboBoxVisualCamAlignValue = comboBoxVisualCamAlign.SelectedIndex;
            int comboBoxVisualAniModeValue = comboBoxVisualAniMode.SelectedIndex;

            float visualAniModeStrengthValue = Convert.ToSingle(textBoxVisualAniModeStrength.Text.Trim(), new CultureInfo("en-US"));
            float VobFarClipZScaleValue = Convert.ToSingle(textBoxVobFarClipZScale.Text.Trim(), new CultureInfo("en-US"));

            bool cdStaticValue = checkBoxcdStatic.Checked;
            bool staticVobValue = checkBoxstaticVob.Checked;

            Imports.Stack_PushString("grassToolcomboBoxVisualCamAlignValue");
            Imports.Extern_SetSetting(comboBoxVisualCamAlignValue);

            Imports.Stack_PushString("grassToolcomboBoxVisualAniModeValue");
            Imports.Extern_SetSetting(comboBoxVisualAniModeValue);

            Imports.Stack_PushString("grassToolvisualAniModeStrengthValue");
            Imports.Extern_SetSettingFloat(visualAniModeStrengthValue);

            Imports.Stack_PushString("grassToolVobFarClipZScaleValue");
            Imports.Extern_SetSettingFloat(VobFarClipZScaleValue);

            Imports.Stack_PushString("grassToolcdStaticValue");
            Imports.Extern_SetSetting(Convert.ToInt32(cdStaticValue));

            Imports.Stack_PushString("grassToolStaticVobValue");
            Imports.Extern_SetSetting(Convert.ToInt32(staticVobValue));
        }

        public void buttonGrassWinApply_Click(object sender, EventArgs e)
        {


            Imports.Stack_PushString("grassMinDist");
            Imports.Extern_SetSetting(trackBarWinGrassMinRadius.Value);

            Imports.Stack_PushString("grassVertOffset");
            Imports.Extern_SetSetting(trackBarGrassWinVertical.Value);


            Imports.Stack_PushString(textBoxGrassWinModel.Text.Trim());
            Imports.Stack_PushString("grassModelName");
            Imports.Extern_SetSettingStr();



        }

        private void checkBoxGrassWinRemove_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;

            Imports.Stack_PushString("grassToolRemove");
            Imports.Extern_SetSetting(Convert.ToInt32(checkBox.Checked));
        }

        private void checkBoxGrassWinIsItem_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;

            Imports.Stack_PushString("grassToolIsItem");
            Imports.Extern_SetSetting(Convert.ToInt32(checkBox.Checked));
        }

        private void checkBoxGrassWinClickOnce_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;

            Imports.Stack_PushString("grassToolClearMouse");
            Imports.Extern_SetSetting(Convert.ToInt32(checkBox.Checked));
        }

        private void checkBoxGrassWinDynColl_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;

            Imports.Stack_PushString("grassToolDynColl");
            Imports.Extern_SetSetting(Convert.ToInt32(checkBox.Checked));
        }

        private void checkBoxGrassWinRotRand_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;

            Imports.Stack_PushString("grassToolRotRandAngle");
            Imports.Extern_SetSetting(Convert.ToInt32(checkBox.Checked));
        }

        private void checkBoxGrassWinSetNormal_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;

            Imports.Stack_PushString("grassToolSetNormal");
            Imports.Extern_SetSetting(Convert.ToInt32(checkBox.Checked));
        }

        private void textBoxVisualAniModeStrength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !Utils.IsNumberInput(e.KeyChar, true, false))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxVobFarClipZScale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !Utils.IsNumberInput(e.KeyChar, true, false))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void comboBoxVisualCamAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnSettingsChanged();
        }

        private void comboBoxVisualAniMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnSettingsChanged();
        }

        private void textBoxVisualAniModeStrength_TextChanged(object sender, EventArgs e)
        {
            OnSettingsChanged();
        }

        private void textBoxVobFarClipZScale_TextChanged(object sender, EventArgs e)
        {
            OnSettingsChanged();
        }

        private void checkBoxcdStatic_CheckedChanged(object sender, EventArgs e)
        {
            OnSettingsChanged();
        }

        private void checkBoxstaticVob_CheckedChanged(object sender, EventArgs e)
        {
            OnSettingsChanged();
        }

        private void checkBoxstaticVob_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void buttonSetDefaultValue_Click(object sender, EventArgs e)
        {
            checkBoxGrassWinRemove.Checked = false;
            checkBoxGrassWinIsItem.Checked = false;
            checkBoxGrassWinClickOnce.Checked = true;
            checkBoxGrassWinDynColl.Checked = true;
            comboBoxVisualCamAlign.SelectedIndex = 0;
            comboBoxVisualAniMode.SelectedIndex = 0;
            textBoxVisualAniModeStrength.Text = "0";
            textBoxVobFarClipZScale.Text = "1";

            checkBoxcdStatic.Checked = false;
            checkBoxstaticVob.Checked = false;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {

            Imports.Stack_PushString("grassWinFilePath");
            Imports.Extern_GetSettingStr();
            string path = Utils.FixPath(Imports.Stack_PeekString());


            openFileDialog.InitialDirectory = Utils.GetInitialDirectory(path);

            openFileDialog.RestoreDirectory = true;
            openFileDialog.FileName = String.Empty;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxGrassWinModel.Text = openFileDialog.SafeFileName;


                Imports.Stack_PushString(Utils.FixPath(Path.GetDirectoryName(Utils.FixPath(openFileDialog.FileName))));
                Imports.Stack_PushString("grassWinFilePath");
                Imports.Extern_SetSettingStr();
            }
        }
    }
}
