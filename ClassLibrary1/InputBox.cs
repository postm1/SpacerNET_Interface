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
    public partial class InputBox : Form
    {
        public InputBox()
        {
            InitializeComponent();
        }


        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SendString(IntPtr name);


        private void buttonApply_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


 
        [DllExport]
        public static void GetInputBox()
        {
            string text = UnionNET.inputBox.Text.Trim();

            IntPtr ptrName = Marshal.StringToHGlobalAnsi(text);

            Extern_SendString(ptrName);
            Marshal.FreeHGlobal(ptrName);
        }

        [DllExport]
        public static void OnShowInputBox()
        {
            UnionNET.inputBox.ShowDialog();
        }
    }
}
