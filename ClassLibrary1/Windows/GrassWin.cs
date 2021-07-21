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
        }

        private void GrassWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        public void UpdateLang()
        {
            //this.Text = Localizator.Get("WIN_VOBLIST_TITLE");

            this.labelWinGrassMinRadius.Text = "Мин. расстояние между вобами: " + trackBarWinGrassMinRadius.Value;
        }

        private void trackBarWinGrassMinRadius_ValueChanged(object sender, EventArgs e)
        {
            var track = sender as TrackBar;

            this.labelWinGrassMinRadius.Text = "Мин. расстояние между вобами: " + track.Value;

            Imports.Stack_PushString("grassMinDist");
            Imports.Extern_SetSetting(track.Value);
        }

        private void textBoxGrassWinModel_TextChanged(object sender, EventArgs e)
        {
            var text = sender as TextBox;

           
            Imports.Stack_PushString(text.Text.Trim());
            Imports.Stack_PushString("grassModelName");
            Imports.Extern_SetSettingStr();
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

        private void trackBarGrassWinVertical_ValueChanged(object sender, EventArgs e)
        {
            var track = sender as TrackBar;

            this.labelWinGrassVertOffset.Text = "Вертикальное смещение: " + track.Value;

            Imports.Stack_PushString("grassVertOffset");
            Imports.Extern_SetSetting(track.Value);
        }
    }
}
