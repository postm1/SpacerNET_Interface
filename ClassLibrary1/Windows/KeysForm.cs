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
        public KeysForm()
        {
            InitializeComponent();
        }


        public int key;
        public bool shift;
        public bool control;
        public bool alt;
        public char name;


        private void dataGridKeys_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) != 0)
            {

            }
        }



        public string ShowKeys()
        {
            StringBuilder str = new StringBuilder();

            if (shift) str.Append("LSHIFT + ");
            if (control) str.Append("LCTRL + ");
            if (alt) str.Append("LALT + ");

            str.Append(FixChars(key));
         

            return str.ToString();
        }

        public string GetSendString()
        {
            StringBuilder str = new StringBuilder();

            if (control) str.Append("1"); else str.Append("0");
            if (alt) str.Append("1"); else str.Append("0");
            if (shift) str.Append("1"); else str.Append("0");

            str.Append("0");

            if (keysGothic.ContainsKey(key))
            {
                str.Append(keysGothic[key].ToString());
            }
            else
            {
                str.Append("0");
            }
            

            return str.ToString();
        }

        private void dataGridKeys_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Back || e.KeyData == Keys.CapsLock || dataGridKeys.CurrentRow.Cells[0].Value == null)
            {
                return;
            }

            key = e.KeyValue;
            shift = e.Shift;
            control = e.Control;
            alt = e.Alt;

            name = (char)e.KeyData;

            if (dataGridKeys.CurrentCell != null && (dataGridKeys.CurrentCell.ColumnIndex == 2))
            {
                dataGridKeys.CurrentCell.Value = ShowKeys();
            }

            string keyString = GetSendString();
            string keyRow = dataGridKeys.CurrentRow.Cells[0].Value.ToString();



            if (dataGridKeys.CurrentRow.Cells[0].Value != null)
            {
                ConsoleEx.WriteLineRed("C# key: " + e.KeyValue);

                Imports.Extern_SendNewKeyPreset(Marshal.StringToHGlobalAnsi(keyRow), Marshal.StringToHGlobalAnsi(keyString));

                SpacerNET.FreeStrings();
            }
           

            e.Handled = true;
            e.SuppressKeyPress = false;
        }

        private string SolveString(string input)
        {
            StringBuilder str = new StringBuilder();

            int index = input.IndexOf('_');

            string mod = input.Substring(0, index);
            string key = input.Substring(index + 1, input.Length - index - 1);


            ConsoleEx.WriteLineRed(String.Format("mod {0}, key {1}", mod, key));

            int modVal = Convert.ToInt32(mod);

            if ((modVal & (int)KeyMod.LControl) != 0)
            {
                str.Append("LCTRL + ");
            }

            if ((modVal & (int)KeyMod.Alt) != 0)
            {
                str.Append("LALT + ");
            }

            if ((modVal & (int)KeyMod.LShift) != 0)
            {
                str.Append("LSHIFT + ");
            }

            int num = Convert.ToInt32(key);

            char val = (char)keysGothic.Where(x => x.Value == num).Select(pair => pair.Key).FirstOrDefault();

            str.Append(FixChars(val));


            return str.ToString();

        }

        private void KeysForm_Shown(object sender, EventArgs e)
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
                        string gotString = Marshal.PtrToStringAnsi(Imports.Extern_GetIniKey(Marshal.StringToHGlobalAnsi(currentKey)));

                        if (gotString.Length > 0)
                        {
                            ConsoleEx.WriteLineRed("gotString: " + gotString);
                            entry.Cells[2].Value = SolveString(gotString);
                        }

                    }
                }
                
                
            }

            SpacerNET.FreeStrings();

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
    }
}
