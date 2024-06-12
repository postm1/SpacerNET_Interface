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
    public partial class MacrosForm : Form
    {
        public Macros macros;
        
        public MacrosForm()
        {
            InitializeComponent();

            macros = new Macros(this);

        }

        private void MacrosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.MacrosWinLocation = SpacerNET.macrosWin.Location;
            this.Hide();
            e.Cancel = true;

            SpacerNET.form.SetIconActive("macros", false);
        }
        public void UpdateLang()
        {
            buttonCreateNewMacros.Text = Localizator.Get("buttonCreateNewMacros");
            buttonMacrosRenameCurrent.Text = Localizator.Get("buttonMacrosRenameCurrent");
            buttonMacrosRemoveCurrent.Text = Localizator.Get("buttonMacrosRemoveCurrent");
            buttonMacrosReloadFromFile.Text = Localizator.Get("buttonMacrosReloadFromFile");
            buttonMacrosSaveAll.Text = Localizator.Get("buttonMacrosSaveAll");

            buttonMacrosRun.Text = Localizator.Get("buttonMacrosRun");
            groupBoxMacrosButtons.Text = Localizator.Get("groupBoxMacrosButtons");

            this.Text = Localizator.Get("WIN_MACROSES");
        }

        private void buttonMacrosSaveAll_Click(object sender, EventArgs e)
        {
            macros.OnUpdateAndSave();
        }

        private void listBoxMacros_DoubleClick(object sender, EventArgs e)
        {
            int index = listBoxMacros.SelectedIndex;

            if (index == -1) return;
            macros.OnRun();
        }

        private void listBoxMacros_SelectedIndexChanged(object sender, EventArgs e)
        {

            var listBox = sender as ListBox;

            int index = listBox.SelectedIndex;

            if (index == -1) return;
            //ConsoleEx.WriteLineRed("listBoxMacros_SelectedIndexChanged: " + index);

            macros.OnSelectIndex(index);

            buttonMacrosRun.Enabled = true;
        }

        private void buttonMacrosRun_Click(object sender, EventArgs e)
        {
            int index = listBoxMacros.SelectedIndex;

            if (index == -1) return;
            macros.OnRun();
        }

        private void buttonMacrosRenameCurrent_Click(object sender, EventArgs e)
        {
            int index = listBoxMacros.SelectedIndex;

            if (index == -1) return;

            macros.formConf.buttonConfirmNo.Text = Localizator.Get("WIN_COMPLIGHT_CLOSEBUTTON");
            macros.formConf.buttonConfirmYes.Text = Localizator.Get("WIN_BTN_CONFIRM");
            macros.formConf.labelTextShow.Text = Localizator.Get("WIN_LABEL_MACROS_RENAME");
            macros.formConf.confType = "RENAME_MACROS";
            if (macros.currentEntry != null)
            {
                macros.formConf.textBoxValueEnter.Text = macros.currentEntry.name;
            }


            macros.formConf.ShowDialog();
        }

        private void buttonCreateNewMacros_Click(object sender, EventArgs e)
        {
            macros.formConf.buttonConfirmNo.Text = Localizator.Get("WIN_COMPLIGHT_CLOSEBUTTON");
            macros.formConf.buttonConfirmYes.Text = Localizator.Get("WIN_BTN_CONFIRM");
            macros.formConf.labelTextShow.Text = Localizator.Get("WIN_LABEL_MACROS_NEW");
            macros.formConf.confType = "CREATE_MACROS";

            macros.formConf.textBoxValueEnter.Text = "";

            macros.formConf.ShowDialog();
        }

        private void richTextBoxMacros_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void buttonMacrosReloadFromFile_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(Localizator.Get("askSure"), Localizator.Get("confirmation"), MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (res == DialogResult.OK)
            {
                macros.ReloadAgain();
            }
        }

        private void buttonMacrosRemoveCurrent_Click(object sender, EventArgs e)
        {
            if (!macros.IsActive()) return;

            int index = listBoxMacros.SelectedIndex;

            if (index == -1) return;



            DialogResult res = MessageBox.Show(Localizator.Get("askSure"), Localizator.Get("confirmation"), MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (res == DialogResult.OK)
            {
                if (index >= 0)
                {
                    macros.OnRemoveIndex(index);
                    richTextBoxMacros.Clear();
                    richTextBoxMacros.Enabled = false;
                }
            }


        }

        private void richTextBoxMacros_KeyUp(object sender, KeyEventArgs e)
        {
            buttonMacrosRun.Enabled = false;


            int index = listBoxMacros.SelectedIndex;

            if (index == -1) return;

            macros.OnParse();

            buttonMacrosRun.Enabled = true;
        }
    }
}
