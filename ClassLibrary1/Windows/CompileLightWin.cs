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

            this.KeyPreview = true;

            buttons[0] = radioButtonVertex;
            buttons[1] = radioButtonLow;
            buttons[2] = radioButtonMiddle;
            buttons[3] = radioButtonHigh;
        }


        public void ApplySettings()
        {
            for (int i = 0; i < RADIO_BUTTONS_MAX; i++)
            {
                if (buttons[i].Checked)
                {
                    Imports.Stack_PushString("lightCompileType");
                    Imports.Extern_SetSetting(i);
                    break;
                }
            }

            int value;

            int.TryParse(textBoxRadius.Text.Trim(), out value);

            if (checkBoxCompileRegion.Checked)
            {
                Imports.Stack_PushString("lightCompileRegionOn");
                Imports.Extern_SetSetting(1);

                Imports.Stack_PushString("lightCompileRadius");
                Imports.Extern_SetSetting(value);
            }
            else
            {
                Imports.Stack_PushString("lightCompileRegionOn");
                Imports.Extern_SetSetting(0);
            }

            
        }

        public void LoadSettings()
        {
            Imports.Stack_PushString("lightCompileType");

            int type = Imports.Extern_GetSetting();

            if (type >= 0 && type < buttons.Length)
            {
                buttons[type].Checked = true;
            }


            Imports.Stack_PushString("lightCompileRegionOn");

            bool regionChecked = Convert.ToBoolean(Imports.Extern_GetSetting());

            Imports.Stack_PushString("lightCompileRadius");

            int radius = Imports.Extern_GetSetting();

            
            checkBoxCompileRegion.Checked = regionChecked;
            

            textBoxRadius.Text = radius.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApplySettings();
            this.Hide();
        }


        public void UpdateLang()
        {
            this.Text = Localizator.Get("WIN_COMPLIGHT_TEXT");
            groupBoxQuality.Text = Localizator.Get("WIN_COMPLIGHT_QUALITY");
            buttonCompileLight.Text = Localizator.Get("WIN_COMPLIGHT_COMPILEBUTTON");


            buttonCompileLightClose.Text = Localizator.Get("WIN_COMPLIGHT_CLOSEBUTTON");
            groupBoxRegion.Text = Localizator.Get("WIN_COMPLIGHT_REGION");
            radioButtonVertex.Text = Localizator.Get("WIN_COMPLIGHT_QUALITY0");
            radioButtonLow.Text = Localizator.Get("WIN_COMPLIGHT_QUALITY1");
            radioButtonMiddle.Text = Localizator.Get("WIN_COMPLIGHT_QUALITY2");
            radioButtonHigh.Text = Localizator.Get("WIN_COMPLIGHT_QUALITY3");


            checkBoxCompileRegion.Text = Localizator.Get("WIN_COMPLIGHT_COMPILECHECKBOX");
            labelMeters.Text = Localizator.Get("WIN_COMPLIGHT_METERS");
            labelAroundCamera.Text = Localizator.Get("WIN_COMPLIGHT_AROUNDCAM");


            


        }


        public void PrintLightInfo(int type)
        {
            switch (type)
            {
                case 0: SpacerNET.form.AddText("Компиляция (только вершины)"); break;
                case 1: SpacerNET.form.AddText("Компиляция (низкое)"); break;
                case 2: SpacerNET.form.AddText("Компиляция (среднее)"); break;
                case 3: SpacerNET.form.AddText("Компиляция (высокое)"); break;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!Imports.Extern_IsWorldLoaded())
            {
                MessageBox.Show("Мир не загружен!");
                return;
            }

            if (!Imports.Extern_IsWorldCompiled())
            {
                MessageBox.Show("Мир не скомпилирован!");
                return;
            }

            

            int radiusCamera = 0;

            if (checkBoxCompileRegion.Checked)
            {
                radiusCamera = Convert.ToInt32(textBoxRadius.Text.Trim());
            }

            ApplySettings();

            this.Hide();

            Stopwatch s = new Stopwatch();
            s.Start();
            SpacerNET.form.AddText(Localizator.Get("compileLight"));

            

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
            SpacerNET.form.AddText("Компиляция света выполнена за (" + timeSpend + ")");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;

            textBoxRadius.Enabled = check.Checked;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CompileLightWin_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void CompileLightWin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                button2_Click(null, null);
            }
        }

        private void CompileLightWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplySettings();
            this.Hide();
            e.Cancel = true;
        }
    }
}
