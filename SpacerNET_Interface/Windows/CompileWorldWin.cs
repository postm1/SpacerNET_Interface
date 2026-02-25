using SpacerUnion.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion
{
    public partial class CompileWorldWin : Form
    {
        RadioButton[] buttons = new RadioButton[2];

        public CompileWorldWin()
        {
            InitializeComponent();
            this.KeyPreview = true;

            buttons[0] = radioButtonIndoor;
            buttons[1] = radioButtonOutdoor;
        }

        private void CompileWorldWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void UpdateLang()
        {
            this.Text = Localizator.Get("WIN_COMPWORLD_TEXT");
            buttonCompileCancel.Text = Localizator.Get("WIN_CANCEL_BUTTON");
            buttonCompileWorld.Text = Localizator.Get("WIN_COMPLIGHT_COMPILEBUTTON");
            groupBoxTypeLoc.Text = Localizator.Get("WIN_COMPWORLD_LOCTYPE");
        }

        public void OnWorldCompile()
        {
            SpacerNET.form.toolStripMenuItemMerge.Enabled = false;
            SpacerNET.form.compileLightToolStrip.Enabled = true;
            SpacerNET.form.saveZenToolStripMenuItem.Enabled = true;
            SpacerNET.form.saveUncZenToolStrip.Enabled = true;
            SpacerNET.form.toolStripMenuExtractMesh.Enabled = true;
            
            SpacerNET.form.analyseWaynetToolStripMenuItem.Enabled = true;
            SpacerNET.form.playHeroToolStrip.Enabled = true;
            SpacerNET.form.rainToolStripMenuItem.Enabled = true;
            SpacerNET.form.stripSpecialFunctions.Enabled = true;
            SpacerNET.form.cameraCoordsToolStrip.Enabled = true;
            SpacerNET.form.dayTimeToolStrip.Enabled = true;
            SpacerNET.form.toolStripMenuResetWorld.Enabled = true;
            SpacerNET.form.toolStripMenuItemMergeMesh.Enabled = false;

            SpacerNET.errorForm.ToggleInterface(true);


            SpacerNET.form.compileWorldToolStrip.Enabled = SpacerNET.form.IsWorldCanBeCompiled();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!SpacerNET.form.IsWorldCanBeCompiled())
            {
               
               MessageBox.Show(Localizator.Get("WIN_COMPWORLD_ALREADY_COMP"));
               return;
            }


            int type = radioButtonIndoor.Checked ? 0 : 1;

            SpacerNET.form.AddText(Localizator.Get("WIN_COMPWORLD_COMPILING"));

            Stopwatch s = new Stopwatch();
            s.Start();

            SpacerNET.form.MainMenuInterfaceToggle(false);
            this.Enabled = false;

            SpacerNET.form.ResetInterface();

            Imports.Extern_CompileWorld(type);

            Utils.PrintTimeInfo("WIN_COMPWORLD_TIME", s.Elapsed.Ticks);
            // SpacerNET.form.AddText(Localizator.Get("WIN_COMPWORLD_LEVELCOMPO"));

            OnWorldCompile();

            SpacerNET.form.MainMenuInterfaceToggle(true);
            this.Enabled = true;

            this.Hide();
        }


        private void CompileWorldWin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                button1_Click(null, null);
            }

            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(null, null);
            }
        }

        public void ApplySettings()
        {
            for (int i = 0; i < 2; i++)
            {
                if (buttons[i].Checked)
                {
                    Imports.Stack_PushString("worldCompileType");
                    Imports.Extern_SetSetting(i);
                    break;
                }
            }

     
            
        }

        public void LoadSettings()
        {
            Imports.Stack_PushString("worldCompileType");
            int type = Imports.Extern_GetSetting();

            if (type >= 0 && type < buttons.Length)
            {
                buttons[type].Checked = true;
            }
        }

        private void radioButtonIndoor_CheckedChanged(object sender, EventArgs e)
        {
            ApplySettings();
        }

        private void radioButtonOutdoor_CheckedChanged(object sender, EventArgs e)
        {
            ApplySettings();
        }
    }
}
