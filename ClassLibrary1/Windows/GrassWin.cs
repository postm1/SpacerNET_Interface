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
    public partial class GrassWin : Form
    {
        public GrassWin()
        {
            InitializeComponent();
            UpdateLang();
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
    }
}
