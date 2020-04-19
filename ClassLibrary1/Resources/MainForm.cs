using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
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
        public string currentWorldName = "";
       
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

        public void ResetInterface()
        {
            ObjTree.globalEntries.Clear();
            UnionNET.objTreeWin.globalTree.Nodes.Clear();
           // UnionNET.partWin.listBoxParticles.Items.Clear();
           // UnionNET.partWin.listBoxItems.Items.Clear();
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

                this.Text = "Spacer.NET " + openFileDialog1.SafeFileName;

                IntPtr filePathPtr = Marshal.StringToHGlobalAnsi(filePath);

                Stopwatch s = new Stopwatch();
                s.Start();

                ResetInterface();

                UnionNET.form.AddText(openFileDialog1.SafeFileName + " загружается...");

                currentWorldName = openFileDialog1.SafeFileName;
                Extern_LoadWorld(filePathPtr);

                s.Stop();

                string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
                UnionNET.form.AddText("Загрузка ZEN выполнена за (" + timeSpend + ")");

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

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (UnionNET.partWin.Visible)
            {
                UnionNET.partWin.Hide();
            }
            else
            {
                UnionNET.partWin.Show();
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (UnionNET.soundWin.Visible)
            {
                UnionNET.soundWin.Hide();
            }
            else
            {
                UnionNET.soundWin.Show();
            }
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void toolStrip1_MouseEnter(object sender, EventArgs e)
        {
            UnionNET.form.Focus();
        }

        private void menuStrip1_MouseEnter(object sender, EventArgs e)
        {
            UnionNET.form.Focus();
        }


        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SaveWorld(IntPtr str, int type);

        private void сохранитьZENToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (currentWorldName.Length == 0)
            {
                return;
            }

            saveFileDialog1.Filter = "Compiled ZEN (ascii)|*.zen|Uncompiled ZEN (ascii)|*.zen|Compiled ZEN (binary safe)|*.zen";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory() + "../WORK/DATA/Worlds/";


            string zenName = currentWorldName.Replace(".zen", "").Replace(".ZEN", "");
            string time = DateTime.Now.ToString("yyyy_MM_dd HH-mm-ss");



            var match = Regex.Match(zenName, @"(^.*)_\d\d\d\d_\d\d_\d\d\s\d\d-\d\d-\d\d");

            if (match.Groups.Count > 1)
            {
                zenName = match.Groups[1].Value;

            }


            zenName = zenName.Replace(".zen", "").Replace(".ZEN", "") +  "_" + time + ".ZEN";

            saveFileDialog1.FileName = zenName;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filePath = saveFileDialog1.FileName;
              


                if (saveFileDialog1.FilterIndex == 2)
                {
                    //filePath = filePath.Replace(".zen", "") + "_vobs.zen";
                }


                IntPtr filePathPtr = Marshal.StringToHGlobalAnsi(filePath);

                Stopwatch s = new Stopwatch();
                s.Start();

               


                UnionNET.form.AddText(zenName + " сохраняется...");

                Extern_SaveWorld(filePathPtr, saveFileDialog1.FilterIndex - 1);

                s.Stop();

                string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
                UnionNET.form.AddText("Сохранение ZEN выполнено за (" + timeSpend + ")");

                Marshal.FreeHGlobal(filePathPtr);
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (UnionNET.objTreeWin.Visible)
            {
                UnionNET.objTreeWin.Hide();
            }
            else
            {
                UnionNET.objTreeWin.Show();
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (UnionNET.objWin.Visible)
            {
                UnionNET.objWin.Hide();
            }
            else
            {
                UnionNET.objWin.Show();
            }
        }
    }
}
