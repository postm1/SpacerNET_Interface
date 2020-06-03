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

        private void button2_Click(object sender, EventArgs e)
        {

            if (Imports.Extern_IsWorldCompiled())
            {
                MessageBox.Show("Мир уже скомпилирован!");
                return;
            }


            int type = radioButtonIndoor.Checked ? 0 : 1;

            SpacerNET.form.AddText("Мир компилируется...");

            Stopwatch s = new Stopwatch();
            s.Start();

            SpacerNET.form.ResetInterface();

            Imports.Extern_CompileWorld(type);

            string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
            SpacerNET.form.AddText("Компиляция мира выполнена за (" + timeSpend + ")");


            SpacerNET.form.AddText("Не забудьте удалить лишний zCVobLevelCompo");
            this.Hide();
        }


        private void CompileWorldWin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                button1_Click(null, null);
            }
        }

        public void ApplySettings()
        {
            for (int i = 0; i < 2; i++)
            {
                if (buttons[i].Checked)
                {
                    IntPtr ptrType = SpacerNET.AddString("worldCompileType");
                    Imports.Extern_SetSetting(ptrType, i);
                    break;
                }
            }

     
            SpacerNET.FreeStrings();
        }

        public void LoadSettings()
        {
            int type = Imports.Extern_GetSetting(SpacerNET.AddString("worldCompileType"));

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
