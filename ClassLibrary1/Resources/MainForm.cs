using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SpacerUnion
{

    public enum CmdType
    {
        ShowVobs,
        ShowWaynet,
        ShowHelpVobs,
    };
    public partial class MainForm : Form
    {
        public Form renderTarget = null;
       
        public MainForm()
        {
            InitializeComponent();
        }

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_Exit();

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extern_Exit();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            renderTarget = new Form();
            renderTarget.TopLevel = false;
            panel1.Controls.Add(renderTarget);
            renderTarget.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            renderTarget.Dock = DockStyle.Fill;
            renderTarget.Show();
        }

        [DllImport("SpacerUnionNet.dll", CharSet=CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_LoadWorld(IntPtr str);

        private void openZENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Zen files (*.zen)|";
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory() + "../WORK/DATA/Worlds/";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

                IntPtr filePathPtr = Marshal.StringToHGlobalAnsi(filePath);


                Extern_LoadWorld(filePathPtr);

                Marshal.FreeHGlobal(filePathPtr);
            }
            
        }

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetValue(int type, int value);

        private void граттToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            item.Checked = !item.Checked;

            Extern_SetValue((int)CmdType.ShowVobs, Convert.ToInt32(item.Checked));

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            item.Checked = !item.Checked;

            Extern_SetValue((int)CmdType.ShowWaynet, Convert.ToInt32(item.Checked));
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            item.Checked = !item.Checked;

            Extern_SetValue((int)CmdType.ShowHelpVobs, Convert.ToInt32(item.Checked));
        }

        private void оНасToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void здрастеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnionNET.comLightWin.Show();

        }
        public void AddText(string text)
        {
            
            UnionNET.infoWin.AddText(text);
            Application.DoEvents();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            if (UnionNET.infoWin.Visible)
            {
                UnionNET.infoWin.Hide();
            }
            else
            {
                UnionNET.infoWin.Show();
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            Extern_SetValue((int)CmdType.ShowWaynet, Convert.ToInt32(item.Checked));
            toolStripMenuItem6.Checked = item.Checked;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            Extern_SetValue((int)CmdType.ShowHelpVobs, Convert.ToInt32(item.Checked));
            toolStripMenuItem7.Checked = item.Checked;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            Extern_SetValue((int)CmdType.ShowVobs, Convert.ToInt32(item.Checked));
            toolStripMenuItem5.Checked = item.Checked;
        }
    }
}
