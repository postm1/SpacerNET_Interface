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
        private List<SpyMessageEntry> listSpyMessages;
        Timer msgTimer;

        public InfoWin()
        {
            InitializeComponent();
            listSpyMessages = new List<SpyMessageEntry>();
            msgTimer = new Timer();
            msgTimer.Interval = 100;
            msgTimer.Enabled = true;
            msgTimer.Tick += MsgTimer_Tick;
        }

        private void MsgTimer_Tick(object sender, EventArgs e)
        {
            if (!SpacerNET.isInit || listSpyMessages.Count == 0)
            {
                return;
            }

            
            richTextBoxSpy.Visible = false;

            for (int i = 0; i < listSpyMessages.Count; i++)
            {
                var entry = listSpyMessages[i];

                AddText_SpyOnTime(entry.text, entry.color);
            }

            listSpyMessages.Clear();

            

            richTextBoxSpy.SelectionStart = richTextBoxSpy.Text.Length;
            richTextBoxSpy.ScrollToCaret();
            richTextBoxSpy.Visible = true;
            Application.DoEvents();

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


        public void AddText_SpyOnTime(string str, Color color)
        {
            SetColorSpy(color);
            this.richTextBoxSpy.AppendText(str);
            SetColorSpy(Color.Black);
        }
        public void AddText_ExternalSpy(string str, Color color)
        {
            var entry = new SpyMessageEntry();

            entry.color = color;
            entry.text = str;

            listSpyMessages.Add(entry);

            if (listSpyMessages.Count >= 10)
            {
                MsgTimer_Tick(null, null);
            }

        }


        public void SetColorSpy(Color color)
        {
            richTextBoxSpy.Select(richTextBoxSpy.TextLength, 0);
            richTextBoxSpy.SelectionColor = color;
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
            richTextBoxSpy.Clear();
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

        private void richTextBoxSpy_TextChanged(object sender, EventArgs e)
        {
           
        }
    }

     class SpyMessageEntry
    {
        public Color color;
        public string text;
    }
}
