using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        
        public void AddText(string str)
        {
            this.richTextBox1.AppendText(" " + str + "\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void InfoWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }
    }
}
