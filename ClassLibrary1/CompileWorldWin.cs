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

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Extern_CompileWorld(int type);


        public CompileWorldWin()
        {
            InitializeComponent();
        }

        private void CompileWorldWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int type = radioButton1.Checked ? 0 : 1;


          

            UnionNET.form.AddText("Мир компилируется...");

            Stopwatch s = new Stopwatch();
            s.Start();

            UnionNET.form.ResetInterface();

            Extern_CompileWorld(type);

            string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
            UnionNET.form.AddText("Компиляция мира выполнена за (" + timeSpend + ")");
            

            this.Hide();
        }
    }
}
