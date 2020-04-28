using SpacerUnion.Common;
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

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_OpenVobTree(IntPtr str, bool globalInsert);

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_LoadWorld(IntPtr str);

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_LoadMesh(IntPtr str);

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_MergeZen(IntPtr str);


        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_ResetWorld();


        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetCameraPos(int x, int y, int z);

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetSetting(IntPtr namePtr, int value);

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetSettingStr(IntPtr namePtr, IntPtr value);


        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_GetSetting(IntPtr namePtr);

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Extern_GetSettingStr(IntPtr namePtr);


        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SaveWorld(IntPtr str, int type);

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extern_Exit();
        }

        public void ResetInterface()
        {
            ObjTree.globalEntries.Clear();
            UnionNET.objTreeWin.globalTree.Nodes.Clear();
            UnionNET.vobList.ClearListBox();
           // UnionNET.partWin.listBoxParticles.Items.Clear();
           // UnionNET.partWin.listBoxItems.Items.Clear();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            renderTarget = new Form();
            renderTarget.TopLevel = false;
            panelMain.Controls.Add(renderTarget);
            renderTarget.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            renderTarget.Dock = DockStyle.Fill;
            renderTarget.Show();
        }

       

        private void openZENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Zen files (*.zen)|";

            IntPtr ptrPath = Extern_GetSettingStr(Marshal.StringToHGlobalAnsi("zenzPath"));

            string path = Marshal.PtrToStringAnsi(ptrPath);

            //MessageBox.Show(path);

            if (path != "")
            {
                //MessageBox.Show(path);
                openFileDialog1.InitialDirectory = System.IO.Path.GetDirectoryName(@path + @"/");
            }
            else
            {
                openFileDialog1.InitialDirectory = @Directory.GetCurrentDirectory() + @"../_WORK/DATA/Worlds/";
            }

            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                IntPtr ptrPathSave = Marshal.StringToHGlobalAnsi(Path.GetDirectoryName(openFileDialog1.FileName));

                Extern_SetSettingStr(ptrPathSave, Marshal.StringToHGlobalAnsi("zenzPath"));


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

            //Marshal.FreeHGlobal(ptrPath);

        }

       

        private void граттToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            item.Checked = !item.Checked;

            Extern_SetSetting(Marshal.StringToHGlobalAnsi("showVobs"), Convert.ToInt32(item.Checked));

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            item.Checked = !item.Checked;

            Extern_SetSetting(Marshal.StringToHGlobalAnsi("showVobs"), Convert.ToInt32(item.Checked));
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            item.Checked = !item.Checked;

            Extern_SetSetting(Marshal.StringToHGlobalAnsi("showVobs"), Convert.ToInt32(item.Checked));
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

            Extern_SetSetting(Marshal.StringToHGlobalAnsi("showWaynet"), Convert.ToInt32(item.Checked));
            toolStripMenuItem6.Checked = item.Checked;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            Extern_SetSetting(Marshal.StringToHGlobalAnsi("showHelpVobs"), Convert.ToInt32(item.Checked));
            toolStripMenuItem7.Checked = item.Checked;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            Extern_SetSetting(Marshal.StringToHGlobalAnsi("showVobs"), Convert.ToInt32(item.Checked));
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


        

        private void сохранитьZENToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (currentWorldName.Length == 0)
            {
                return;
            }

            saveFileDialog1.Filter = "Compiled ZEN (ascii)|*.zen|Uncompiled ZEN (ascii)|*.zen|Compiled ZEN (binary safe)|*.zen";

            //saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory() + "../_WORK/DATA/Worlds/";

            IntPtr ptrPathInit = Extern_GetSettingStr(Marshal.StringToHGlobalAnsi("zenzPath"));
            string path = Marshal.PtrToStringAnsi(ptrPathInit);

            if (path != "")
            {
                //MessageBox.Show(path);
                saveFileDialog1.InitialDirectory = System.IO.Path.GetDirectoryName(@path + @"/");
            }
            else
            {
                saveFileDialog1.InitialDirectory = @Directory.GetCurrentDirectory() + @"../_WORK/DATA/";
            }

            saveFileDialog1.RestoreDirectory = true;

            //Console.WriteLine(openFileDialog1.InitialDirectory);

            string zenName = currentWorldName.Replace(".zen", "").Replace(".ZEN", "");
            string time = DateTime.Now.ToString("yyyy_MM_dd HH-mm-ss");



            var match = Regex.Match(zenName, @"(^.*)_\d\d\d\d_\d\d_\d\d\s\d\d-\d\d-\d\d");

            if (match.Groups.Count > 1)
            {
                zenName = match.Groups[1].Value;

            }

            int addPrefx = Extern_GetSetting(Marshal.StringToHGlobalAnsi("addDatePrefix"));


            if (addPrefx != 0)
            {
                zenName = zenName.Replace(".zen", "").Replace(".ZEN", "") + "_" + time + ".ZEN";
            }
           

            saveFileDialog1.FileName = zenName;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                IntPtr ptrPath = Marshal.StringToHGlobalAnsi(System.IO.Path.GetDirectoryName(saveFileDialog1.FileName));

                Extern_SetSettingStr(ptrPath, Marshal.StringToHGlobalAnsi("zenzPath"));


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





        private void камераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int transSpeed = Extern_GetSetting(Marshal.StringToHGlobalAnsi("camTransSpeed"));
            int rotSpeed = Extern_GetSetting(Marshal.StringToHGlobalAnsi("camRotSpeed"));

            int world = Extern_GetSetting(Marshal.StringToHGlobalAnsi("rangeWorld"));
            int vob = Extern_GetSetting(Marshal.StringToHGlobalAnsi("rangeVobs"));


            UnionNET.settingsCam.trackBarTransSpeed.Value = transSpeed;
            UnionNET.settingsCam.trackBarRotSpeed.Value = rotSpeed;

            UnionNET.settingsCam.trackBarWorld.Value = world;
            UnionNET.settingsCam.trackBarVobs.Value = vob;

            UnionNET.settingsCam.UpdateAll();


            UnionNET.settingsCam.checkBoxFPS.Checked = Convert.ToBoolean(Extern_GetSetting(Marshal.StringToHGlobalAnsi("showFps")));
            UnionNET.settingsCam.checkBoxTris.Checked = Convert.ToBoolean(Extern_GetSetting(Marshal.StringToHGlobalAnsi("showTris")));

            UnionNET.settingsCam.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Extern_Exit();
            e.Cancel = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Mesh-File (*.3ds)|*.3ds|All Files(*.*)|*.*||";

            IntPtr ptrPath = Extern_GetSettingStr(Marshal.StringToHGlobalAnsi("meshPath"));
            string path = Marshal.PtrToStringAnsi(ptrPath);

            //MessageBox.Show(path);

            if (path != "")
            {
                //MessageBox.Show(path);
                openFileDialog1.InitialDirectory = System.IO.Path.GetDirectoryName(@path + @"/");
            }
            else
            {
                openFileDialog1.InitialDirectory = @Directory.GetCurrentDirectory() + @"../_WORK/DATA/";
            }

            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                IntPtr ptrPathSave = Marshal.StringToHGlobalAnsi(Path.GetDirectoryName(openFileDialog1.FileName));

                Extern_SetSettingStr(ptrPathSave, Marshal.StringToHGlobalAnsi("meshPath"));


                string filePath = openFileDialog1.FileName;

                this.Text = "Spacer.NET " + openFileDialog1.SafeFileName;

                IntPtr filePathPtr = Marshal.StringToHGlobalAnsi(filePath);

                Stopwatch s = new Stopwatch();
                s.Start();

                ResetInterface();

                UnionNET.form.AddText(openFileDialog1.SafeFileName + " загружается...");

                currentWorldName = openFileDialog1.SafeFileName;

                Extern_LoadMesh(filePathPtr);

                s.Stop();

                string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
                UnionNET.form.AddText("Загрузка MESH выполнена за (" + timeSpend + ")");

                Marshal.FreeHGlobal(filePathPtr);
            }

            //Marshal.FreeHGlobal(ptrPath);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "World (*.Zen)|*.zen|All Files(*.*)|*.*||";

            IntPtr ptrPath = Extern_GetSettingStr(Marshal.StringToHGlobalAnsi("vobsPath"));
            string path = Marshal.PtrToStringAnsi(ptrPath);

            //MessageBox.Show(path);

            if (path != "")
            {
                //MessageBox.Show(path);
                openFileDialog1.InitialDirectory = System.IO.Path.GetDirectoryName(@path + @"/");
            }
            else
            {
                openFileDialog1.InitialDirectory = @Directory.GetCurrentDirectory() + @"../_WORK/DATA/Worlds/";
            }

            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                IntPtr ptrPathSave = Marshal.StringToHGlobalAnsi(Path.GetDirectoryName(openFileDialog1.FileName));

                Extern_SetSettingStr(ptrPathSave, Marshal.StringToHGlobalAnsi("vobsPath"));



                string filePath = openFileDialog1.FileName;

                this.Text = "Spacer.NET " + openFileDialog1.SafeFileName;

                IntPtr filePathPtr = Marshal.StringToHGlobalAnsi(filePath);

                Stopwatch s = new Stopwatch();
                s.Start();

                ResetInterface();

                UnionNET.form.AddText(openFileDialog1.SafeFileName + " загружается...");

                currentWorldName = openFileDialog1.SafeFileName;

                Extern_MergeZen(filePathPtr);

                s.Stop();

                string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
                UnionNET.form.AddText("Объединение ZEN выполнено за (" + timeSpend + ")");

                Marshal.FreeHGlobal(filePathPtr);
            }
            //Marshal.FreeHGlobal(ptrPath);
            
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Точно сбросить мир?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (res == DialogResult.OK)
            {
                ResetInterface();
                Extern_ResetWorld();
            }

           
            
        }

        private void компиляцияМираToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnionNET.compWorldWin.Show();
        }

        private void toolStripButtonBBox_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            Extern_SetSetting(Marshal.StringToHGlobalAnsi("drawBBoxGlobal"), Convert.ToInt32(item.Checked));
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (UnionNET.vobList.Visible)
            {
                UnionNET.vobList.Hide();
            }
            else
            {
                UnionNET.vobList.Show();
            }
            
        }

        private void toolStripTop_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void прыгнутьНа000КоординатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extern_SetCameraPos(0, 0, 0);
        }
    }
}
