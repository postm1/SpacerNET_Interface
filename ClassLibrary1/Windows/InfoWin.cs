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

        [DllExport]
        public static void ShowVdfWarning()
        {
            SpacerNET.infoWin.AddText(Localizator.Get("WARNING_VDF_FILE_OPEN"), Color.Red);
      
        }


        [DllExport]
        public static void InfoWin_AddText()
        {
            string color_str = Imports.Stack_PeekString();
            string str = Imports.Stack_PeekString();

            color_str = color_str.ToUpper();

            var lightGray = System.Drawing.ColorTranslator.FromHtml(color_str);

            if (lightGray != Color.Empty)
            {
                //ConsoleEx.WriteLineYellow(lightGray.ToString());
                SpacerNET.infoWin.AddText_External(str, lightGray);
            }
            else
            {
                //ConsoleEx.WriteLineYellow("No color, black");
                SpacerNET.infoWin.AddText_External(str, Color.Black);
            }

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
    }
}
