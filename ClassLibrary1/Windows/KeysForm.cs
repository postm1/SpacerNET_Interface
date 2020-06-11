using SpacerUnion.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion.Windows
{
    public partial class KeysForm : Form
    {
        KeyEntry currentKeyEntry = new KeyEntry();

        public KeysForm()
        {
            InitializeComponent();
        }
        
        public void UpdateLang()
        {
            this.Text = Localizator.Get("WIN_KEYSBIND_TEXT");
            dataGridKeys.Columns[1].HeaderText = Localizator.Get("WIN_KEYSBIND_DESC");
            dataGridKeys.Columns[2].HeaderText = Localizator.Get("WIN_KEYSBIND_BINDS");

            buttonClose.Text = Localizator.Get("BTN_APPLY");
            buttonKeysResetDefault.Text = Localizator.Get("keysResetDefault");

            if (SpacerNET.isInit)
            {
                LoadKeys();
            }
           
        }

        public void LoadKeys()
        {
            dataGridKeys.Rows.Clear();

            Fill_Table();
        }


        private void dataGridKeys_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Back || e.KeyData == Keys.CapsLock || dataGridKeys.CurrentRow.Cells[0].Value == null)
            {
                return;
            }

            currentKeyEntry.SetData(e.Alt, e.Shift, e.Control, e.KeyValue);


            if (dataGridKeys.CurrentCell != null && (dataGridKeys.CurrentCell.ColumnIndex == 2))
            {
                dataGridKeys.CurrentCell.Value = currentKeyEntry.GetKeysAsString();
            }


            if (dataGridKeys.CurrentRow.Cells[0].Value != null)
            {
                currentKeyEntry.PackToUnion();

                Imports.Stack_PushString(dataGridKeys.CurrentRow.Cells[0].Value.ToString());
                Imports.Extern_SendNewKeyPreset(currentKeyEntry.union_key, currentKeyEntry.mod);
            }
           

            e.Handled = true;
            e.SuppressKeyPress = false;
        }


        

        public void Fill_Table()
        {
            InitRows();


            dataGridKeys.Columns[0].Visible = false;

            foreach (DataGridViewRow entry in dataGridKeys.Rows)
            {
                if (entry.Cells[0].Value != null)
                {
                    string currentKey = entry.Cells[0].Value.ToString();

                    if (currentKey.Length > 0)
                    {
                        Imports.Stack_PushString(currentKey);
                        Imports.Extern_GetIniKey();
                        string gotString = Imports.Stack_PeekString();

                        if (gotString.Length > 0)
                        {
                            //ConsoleEx.WriteLineRed("gotString: " + gotString);
                            entry.Cells[2].Value = currentKeyEntry.SolveString(gotString);
                        }

                    }
                }


            }
        }

        private void KeysForm_Shown(object sender, EventArgs e)
        {
            Fill_Table();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void KeysForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void buttonKeysResetDefault_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(Localizator.Get("confirmText"), Localizator.Get("confirmation"), MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Imports.Extern_ResetKeysDefault();

                dataGridKeys.Rows.Clear();

                Fill_Table();
            }


            

        }
    }
}
