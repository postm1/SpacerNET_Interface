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

namespace SpacerUnion
{
    public partial class InfoWin : Form
    {

        public InfoWin()
        {
            InitializeComponent();
        }




        public void LoadSettings()
        {

            Imports.Stack_PushString("infoWinzSpyEnabled");
            checkBoxInfoUseZSpy.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());

            Imports.Stack_PushString("infoWinzSpyLevel");
            trackBarSpy.Value = Imports.Extern_GetSetting();


            checkBoxInfoUseZSpy_CheckedChanged(null, null);
            trackBarSpy_ValueChanged(null, null);
        }

        public void AddText_External(string str, Color color)
        {
            SetColor(color);
            this.richTextBoxInfo.AppendText(str);
            SetColor(Color.Black);
        }


        public void SetColor(Color color)
        {
            richTextBoxInfo.Select(richTextBoxInfo.TextLength, 0);
            richTextBoxInfo.SelectionColor = color;
        }

        

        public void UpdateLang()
        {
            this.Text = Localizator.Get("WIN_INFO_TITLE");
            buttonInfoClear.Text = Localizator.Get("WIN_INFO_CLEAR");
            checkBoxInfoUseZSpy.Text = Localizator.Get("checkBoxInfoUseZSpy");
        }
        
        public void AddText(string str)
        {
            this.richTextBoxInfo.AppendText(str + "\n");
        }

        public void AddText(string str, Color color)
        {
            SetColor(color);
            this.richTextBoxInfo.AppendText(str + "\n");
            SetColor(Color.Black);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBoxInfo.Clear();
        }

        private void InfoWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBoxInfo.SelectionStart = richTextBoxInfo.Text.Length;
            richTextBoxInfo.ScrollToCaret();
        }

        private void InfoWin_Move(object sender, EventArgs e)
        {
        }

        private void trackBarSpy_ValueChanged(object sender, EventArgs e)
        {
            labelLevelzSPY.Text = trackBarSpy.Value.ToString();

            Imports.Stack_PushString("infoWinzSpyLevel");
            Imports.Extern_SetSetting(trackBarSpy.Value);


        }

        private void checkBoxInfoUseZSpy_CheckedChanged(object sender, EventArgs e)
        {
            trackBarSpy.Enabled = checkBoxInfoUseZSpy.Checked;

            Imports.Stack_PushString("infoWinzSpyEnabled");
            Imports.Extern_SetSetting(Convert.ToInt32(checkBoxInfoUseZSpy.Checked));
        }

        private void labelLevelzSPY_Click(object sender, EventArgs e)
        {

        }
    }
}
