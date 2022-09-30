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
    public partial class ConfirmForm : Form
    {
        public string confType;
        public Macros macros;

        public ConfirmForm(Macros mac)
        {
            InitializeComponent();
            macros = mac;
        }

        private void buttonConfirmNo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonConfirmYes_Click(object sender, EventArgs e)
        {

            if (confType == "RENAME_MACROS")
            {
                string text = textBoxValueEnter.Text.Trim();

                if (macros.currentEntry != null)
                {
                    int index = macros.objWin.listBoxMacros.SelectedIndex;

                    if (index != -1)
                    {
                        macros.currentEntry.name = text;
                        macros.objWin.listBoxMacros.Items[macros.objWin.listBoxMacros.SelectedIndex] = text;
                    }

                    
                }
            }
            else if (confType == "CREATE_MACROS")
            {
                string text = textBoxValueEnter.Text.Trim();

                macros.OnNewMacro(text);
            }
            this.Hide();
        }

        private void ConfirmForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void ConfirmForm_Shown(object sender, EventArgs e)
        {
            this.textBoxValueEnter.Focus();
        }
    }
}
