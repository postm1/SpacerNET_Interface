﻿using SpacerUnion.Common;
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
        public bool clearText;

        public ConfirmForm(Macros mac)
        {
            InitializeComponent();
            macros = mac;
            clearText = true;
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



                if (!Utils.IsOnlyLatin(text))
                {
                    MessageBox.Show(Localizator.Get("FORM_ENTER_BAD_STRING_INPUT"));
                    return;
                }

                macros.OnNewMacro(text);
            }
            else if (confType == "MATFILTER_NEWFILTER")
            {
                string text = textBoxValueEnter.Text.Trim();
                if (!SpacerNET.matFilterWin.OnCreateNewFilter(text))
                {
                    return;
                }
            }
            else if (confType == "MATFILTER_RENAME_FILTER")
            {
                string text = textBoxValueEnter.Text.Trim();


                if (!SpacerNET.matFilterWin.OnRenameFilter(text))
                {
                    return;
                }
            }
            else if (confType == "MATFILTER_NEWMATERIAL")
            {
                string text = textBoxValueEnter.Text.Trim();

                if (!Utils.IsOnlyLatin(text))
                {
                    MessageBox.Show(Localizator.Get("FORM_ENTER_BAD_STRING_INPUT"));
                    return;
                }


                Imports.Stack_PushInt(SpacerNET.matFilterWin.listBoxFilter.SelectedIndex);
                Imports.Stack_PushString(text);
                Imports.Extern_Filter_CreateNewMaterial();
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

            if (clearText)
            {
                this.textBoxValueEnter.Clear();
            }
        }

        private void textBoxValueEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                buttonConfirmYes_Click(null, null);
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                e.Handled = true;
                this.Close();
            }

        }
    }
}
