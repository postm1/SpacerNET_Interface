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
    public partial class CompileLightWin : Form
    {
  
        const int RADIO_BUTTONS_MAX = 4;

        RadioButton[] buttons = new RadioButton[RADIO_BUTTONS_MAX];
        public CompileLightWin()
        {
            InitializeComponent();

            buttons[0] = radioButton1;
            buttons[1] = radioButton2;
            buttons[2] = radioButton3;
            buttons[3] = radioButton4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        


        public void PrintLightInfo(int type)
        {
            switch (type)
            {
                case 0: UnionNET.form.AddText("Компиляция (только вершины)"); break;
                case 1: UnionNET.form.AddText("Компиляция (низкое)"); break;
                case 2: UnionNET.form.AddText("Компиляция (среднее)"); break;
                case 3: UnionNET.form.AddText("Компиляция (высокое)"); break;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

            int radiusCamera = 0;

            if (checkBox1.Checked)
            {
                radiusCamera = Convert.ToInt32(textBox1.Text.Trim());
            }

            this.Hide();

            Stopwatch s = new Stopwatch();
            s.Start();
            UnionNET.form.AddText("Компиляция света...");

       

            for (int i = 0; i < RADIO_BUTTONS_MAX; i++)
            {
                if (buttons[i].Checked)
                {
                    PrintLightInfo(i);
                    Imports.Extern_ComplileLight(i, radiusCamera);
                    break;
                }
            }
            s.Stop();

            string timeSpend = string.Format("{0:HH:mm:ss}", new DateTime(s.Elapsed.Ticks));
            UnionNET.form.AddText("Компиляция света выполнена за (" + timeSpend + ")");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;

            textBox1.Enabled = check.Checked;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CompileLightWin_Load(object sender, EventArgs e)
        {

        }
    }
}
