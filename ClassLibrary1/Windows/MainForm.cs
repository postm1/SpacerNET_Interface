
using SpacerUnion.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
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
            this.KeyPreview = true;
        }

        public void UpdateSpacerCaption(string title)
        {
            currentWorldName = title;
            this.Text = "Spacer.NET: " + title;
        }
        
        private void CloseApp()
        {
            if (currentWorldName != "" && Imports.Extern_GetSetting(UnionNET.AddString("askExitZen")) == 1)
            {
                DialogResult res = MessageBox.Show("Точно выйти?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (res == DialogResult.OK)
                {

                    UnionNET.CloseApplication();
                }
            }
            else
            {
                UnionNET.CloseApplication();
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseApp();
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
            //toolStripTop.BringToFront();
        }

       

        private void openZENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Zen files (*.zen)|";

            IntPtr ptrPath = Imports.Extern_GetSettingStr(UnionNET.AddString("zenzPath"));

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

                IntPtr ptrPathSave = UnionNET.AddString(Path.GetDirectoryName(openFileDialog1.FileName));

                Imports.Extern_SetSettingStr(ptrPathSave, UnionNET.AddString("zenzPath"));


                string filePath = openFileDialog1.FileName;



                UpdateSpacerCaption(openFileDialog1.SafeFileName);

                IntPtr filePathPtr = UnionNET.AddString(filePath);

                Stopwatch s = new Stopwatch();
                s.Start();

                ResetInterface();

                UnionNET.form.AddText(openFileDialog1.SafeFileName + " загружается...");
                ConsoleEx.WriteLineGreen(openFileDialog1.SafeFileName + " загружается...");

                currentWorldName = openFileDialog1.SafeFileName;
                Imports.Extern_LoadWorld(filePathPtr);

                s.Stop();

                string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
                UnionNET.form.AddText("Загрузка ZEN выполнена за (" + timeSpend + ")");
                ConsoleEx.WriteLineGreen("Загрузка ZEN выполнена за (" + timeSpend + ")");
         
            }

            UnionNET.FreeStrings();

        }

       

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            item.Checked = !item.Checked;

            Imports.Extern_SetSetting(UnionNET.AddString("showVobs"), Convert.ToInt32(item.Checked));
            UnionNET.FreeStrings();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            item.Checked = !item.Checked;

            Imports.Extern_SetSetting(UnionNET.AddString("showVobs"), Convert.ToInt32(item.Checked));
            UnionNET.FreeStrings();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            item.Checked = !item.Checked;

            Imports.Extern_SetSetting(UnionNET.AddString("showVobs"), Convert.ToInt32(item.Checked));
            UnionNET.FreeStrings();
        }


        private void здрастеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!UnionNET.compWorldWin.Visible)
            {
                UnionNET.comLightWin.Show();
            }
            

        }
        public void AddText(string text)
        {
            
            UnionNET.infoWin.AddText(text);
            Application.DoEvents();
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            Imports.Extern_SetSetting(UnionNET.AddString("showWaynet"), Convert.ToInt32(item.Checked));
            toolStripMenuItem6.Checked = item.Checked;
            UnionNET.FreeStrings();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            Imports.Extern_SetSetting(UnionNET.AddString("showHelpVobs"), Convert.ToInt32(item.Checked));
            toolStripMenuItem7.Checked = item.Checked;
            UnionNET.FreeStrings();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            Imports.Extern_SetSetting(UnionNET.AddString("showVobs"), Convert.ToInt32(item.Checked));
            toolStripMenuItem5.Checked = item.Checked;
            UnionNET.FreeStrings();
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

            IntPtr ptrPathInit = Imports.Extern_GetSettingStr(UnionNET.AddString("zenzPath"));
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



            var match = Regex.Match(zenName, @"(^.*)_\d\d\d\d_\d\d_\d\d\s+\d\d-\d\d-\d\d");

            if (match.Groups.Count > 1)
            {
                zenName = match.Groups[1].Value;

            }

            int addPrefx = Imports.Extern_GetSetting(UnionNET.AddString("addDatePrefix"));


            if (addPrefx != 0)
            {
                zenName = zenName.Replace(".zen", "").Replace(".ZEN", "") + "_" + time + ".ZEN";
            }
           

            saveFileDialog1.FileName = zenName;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                IntPtr ptrPath = UnionNET.AddString(Path.GetDirectoryName(saveFileDialog1.FileName));

                Imports.Extern_SetSettingStr(ptrPath, UnionNET.AddString("zenzPath"));


                string filePath = saveFileDialog1.FileName;
                string selectedFileName = Path.GetFileName(saveFileDialog1.FileName);

                UpdateSpacerCaption(selectedFileName);


                if (saveFileDialog1.FilterIndex == 2)
                {
                    //filePath = filePath.Replace(".zen", "") + "_vobs.zen";
                }
                


                IntPtr filePathPtr = UnionNET.AddString(filePath);

                Stopwatch s = new Stopwatch();
                s.Start();


                ConsoleEx.WriteLineGreen(selectedFileName + " сохраняется...");
                UnionNET.form.AddText(selectedFileName + " сохраняется...");

                Imports.Extern_SaveWorld(filePathPtr, saveFileDialog1.FilterIndex - 1);

                s.Stop();

                string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
                UnionNET.form.AddText("Сохранение ZEN выполнено за (" + timeSpend + ")");
                ConsoleEx.WriteLineGreen("Сохранение ZEN выполнено за (" + timeSpend + ")");
               
            }
            UnionNET.FreeStrings();
        }




        private void камераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int transSpeed = Imports.Extern_GetSetting(UnionNET.AddString("camTransSpeed"));
            int rotSpeed = Imports.Extern_GetSetting(UnionNET.AddString("camRotSpeed"));

            int world = Imports.Extern_GetSetting(UnionNET.AddString("rangeWorld"));
            int vob = Imports.Extern_GetSetting(UnionNET.AddString("rangeVobs"));


            UnionNET.settingsCam.trackBarTransSpeed.Value = transSpeed;
            UnionNET.settingsCam.trackBarRotSpeed.Value = rotSpeed;

            UnionNET.settingsCam.trackBarWorld.Value = world;
            UnionNET.settingsCam.trackBarVobs.Value = vob;

            UnionNET.settingsCam.UpdateAll();


            UnionNET.settingsCam.checkBoxFPS.Checked = Convert.ToBoolean(Imports.Extern_GetSetting(UnionNET.AddString("showFps")));
            UnionNET.settingsCam.checkBoxTris.Checked = Convert.ToBoolean(Imports.Extern_GetSetting(UnionNET.AddString("showTris")));


            UnionNET.settingsCam.checkBoxCamCoord.Checked = Convert.ToBoolean(Imports.Extern_GetSetting(UnionNET.AddString("showCamCoords")));
            UnionNET.settingsCam.checkBoxVobs.Checked = Convert.ToBoolean(Imports.Extern_GetSetting(UnionNET.AddString("showVobsCount")));


            UnionNET.settingsCam.checkBoxWaypoints.Checked = Convert.ToBoolean(Imports.Extern_GetSetting(UnionNET.AddString("showWaypointsCount")));
            UnionNET.settingsCam.checkBoxDistVob.Checked = Convert.ToBoolean(Imports.Extern_GetSetting(UnionNET.AddString("showVobDist")));


            UnionNET.settingsCam.checkBoxCameraHideWins.Checked = Convert.ToBoolean(Imports.Extern_GetSetting(UnionNET.AddString("hideCamWindows")));


            UnionNET.settingsCam.textBoxLimitFPS.Text = Imports.Extern_GetSetting(UnionNET.AddString("maxFPS")).ToString();



            UnionNET.settingsCam.Show();

            UnionNET.FreeStrings();
        }



        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseApp();
            e.Cancel = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Mesh-File (*.3ds)|*.3ds|All Files(*.*)|*.*||";

            IntPtr ptrPath = Imports.Extern_GetSettingStr(UnionNET.AddString("meshPath"));
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

                IntPtr ptrPathSave = UnionNET.AddString(Path.GetDirectoryName(openFileDialog1.FileName));

                Imports.Extern_SetSettingStr(ptrPathSave, UnionNET.AddString("meshPath"));


                string filePath = openFileDialog1.FileName;


                UpdateSpacerCaption(openFileDialog1.SafeFileName);

                IntPtr filePathPtr = UnionNET.AddString(filePath);

                Stopwatch s = new Stopwatch();
                s.Start();

                ResetInterface();

                UnionNET.form.AddText(openFileDialog1.SafeFileName + " загружается...");

                currentWorldName = openFileDialog1.SafeFileName;

                Imports.Extern_LoadMesh(filePathPtr);

                s.Stop();

                string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
                UnionNET.form.AddText("Загрузка MESH выполнена за (" + timeSpend + ")");

              
            }

            UnionNET.FreeStrings();

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "World (*.Zen)|*.zen|All Files(*.*)|*.*||";

            IntPtr ptrPath = Imports.Extern_GetSettingStr(UnionNET.AddString("vobsPath"));
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

                IntPtr ptrPathSave = UnionNET.AddString(Path.GetDirectoryName(openFileDialog1.FileName));

                Imports.Extern_SetSettingStr(ptrPathSave, UnionNET.AddString("vobsPath"));



                string filePath = openFileDialog1.FileName;

                UpdateSpacerCaption(openFileDialog1.SafeFileName);

                IntPtr filePathPtr = UnionNET.AddString(filePath);

                Stopwatch s = new Stopwatch();
                s.Start();

                ResetInterface();

                UnionNET.form.AddText(openFileDialog1.SafeFileName + " загружается...");

                currentWorldName = openFileDialog1.SafeFileName;

                Imports.Extern_MergeZen(filePathPtr);

                s.Stop();

                string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
                UnionNET.form.AddText("Объединение ZEN выполнено за (" + timeSpend + ")");

              
            }

            UnionNET.FreeStrings();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Точно сбросить мир?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (res == DialogResult.OK)
            {
                currentWorldName = "";

                ResetInterface();
                Imports.Extern_ResetWorld();
            }

           
            
        }

        private void компиляцияМираToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!UnionNET.comLightWin.Visible)
            {
                UnionNET.compWorldWin.Show();
            }
           
        }


        private void прыгнутьНа000КоординатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imports.Extern_SetCameraPos(0, 0, 0);
        }

        private void вобыВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var entries = ObjTree.globalEntries;


            foreach (var entry in entries)
            {
                Utils.InfoFile(String.Format("Name: {0}, Addr: {1}, Parent: {2}, Class: {3}",
                    entry.Value.name, entry.Value.zCVob, entry.Value.parent, entry.Value.className));

                
                for (int i = 0; i < entry.Value.childs.Count; i++)
                {
                    Utils.InfoFile(String.Format("\tName: {0}, Addr: {1}, Parent: {2}, Class: {3}",
                   entry.Value.childs[i].name, entry.Value.childs[i].zCVob, entry.Value.childs[i].parent, entry.Value.childs[i].className));
                }
                
            }
        }

        private void toolStripButtonInfo_Click(object sender, EventArgs e)
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

        private void toolStripButtonBig_Click(object sender, EventArgs e)
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

        private void toolStripButtonSound_Click(object sender, EventArgs e)
        {

            bool musicOff = Convert.ToBoolean(Imports.Extern_GetSetting(UnionNET.AddString("musicZenOff")));
            UnionNET.soundWin.checkBoxShutMusic.Checked = musicOff;



            int volume = Imports.Extern_GetSetting(UnionNET.AddString("musicVolume"));
            UnionNET.soundWin.trackBarMusicVolume.Value = volume;


            UnionNET.soundWin.UpdateAll();

            if (UnionNET.soundWin.Visible)
            {
                UnionNET.soundWin.Hide();
            }
            else
            {
                UnionNET.soundWin.Show();
            }



            if (Properties.Settings.Default.SoundWinLocation != null)
            {
                UnionNET.soundWin.Location = Properties.Settings.Default.SoundWinLocation;
            }
        }

        private void toolStripButtonTree_Click(object sender, EventArgs e)
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

        private void toolStripButton8_Click_1(object sender, EventArgs e)
        {
            if (UnionNET.propWin.Visible)
            {
                UnionNET.propWin.Hide();
            }
            else
            {
                UnionNET.propWin.Show();
            }
        }

        private void toolStripButton9_Click_1(object sender, EventArgs e)
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

        private void toolStripButtonVobs_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            Imports.Extern_SetSetting(UnionNET.AddString("showVobs"), Convert.ToInt32(item.Checked));
            toolStripMenuItem5.Checked = item.Checked;
            UnionNET.FreeStrings();
        }

        private void toolStripButtonWaynet_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            Imports.Extern_SetSetting(UnionNET.AddString("showWaynet"), Convert.ToInt32(item.Checked));
            toolStripMenuItem6.Checked = item.Checked;
            UnionNET.FreeStrings();
        }

        private void toolStripButtonHelpVobs_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            Imports.Extern_SetSetting(UnionNET.AddString("showHelpVobs"), Convert.ToInt32(item.Checked));
            toolStripMenuItem7.Checked = item.Checked;
            UnionNET.FreeStrings();
        }

        private void toolStripButtonBBox_Click_1(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            Imports.Extern_SetSetting(UnionNET.AddString("drawBBoxGlobal"), Convert.ToInt32(item.Checked));
            UnionNET.FreeStrings();
        }

        private void управлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int transSpeed = Imports.Extern_GetSetting(UnionNET.AddString("vobTransSpeed"));
            int rotSpeed = Imports.Extern_GetSetting(UnionNET.AddString("vobRotSpeed"));
            bool insertVobItemLevel = Convert.ToBoolean(Imports.Extern_GetSetting(UnionNET.AddString("vobInsertItemLevel")));
            bool vobInsertVobRotRand = Convert.ToBoolean(Imports.Extern_GetSetting(UnionNET.AddString("vobInsertVobRotRand")));
            bool vobInsertHierarchy = Convert.ToBoolean(Imports.Extern_GetSetting(UnionNET.AddString("vobInsertHierarchy")));
            int turnMode = Imports.Extern_GetSetting(UnionNET.AddString("wpTurnOn"));



            UnionNET.settingsControl.trackBarVobTransSpeed.Value = transSpeed;
            UnionNET.settingsControl.trackBarVobRotSpeed.Value = rotSpeed;
            UnionNET.settingsControl.checkBoxInsertVob.Checked = insertVobItemLevel;
            UnionNET.settingsControl.checkBoxVobRotRandAngle.Checked = vobInsertVobRotRand;
            UnionNET.settingsControl.checkBoxVobInsertHierarchy.Checked = vobInsertHierarchy;
            UnionNET.settingsControl.UpdateAll();

            UnionNET.settingsControl.SetRadioTurnMode(turnMode);

           UnionNET.settingsControl.Show();
            UnionNET.FreeStrings();
        }

        private void toolStripButtonInvisible_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            Imports.Extern_SetSetting(UnionNET.AddString("showInvisibleVobs"), Convert.ToInt32(item.Checked));
            UnionNET.FreeStrings();
        }

        private void ToolStripMenuTimeMorning_Click(object sender, EventArgs e)
        {
            Imports.Extern_SetTime(7, 0);
        }

        private void ToolStripMenuTimeDay_Click(object sender, EventArgs e)
        {
            Imports.Extern_SetTime(12, 0);
        }

        private void ToolStripMenuTimeEvening_Click(object sender, EventArgs e)
        {
            Imports.Extern_SetTime(17, 0);
        }

        private void ToolStripMenuTimeNight_Click(object sender, EventArgs e)
        {
            Imports.Extern_SetTime(0, 0);
        }

        private void анализWaynetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntPtr result = Imports.Extern_AnalyseWaynet();

            string resultStr = Marshal.PtrToStringAnsi(result);

            if (resultStr.Length == 0)
            {
                MessageBox.Show("Ошибки waynet не найдены");
            }
            else
            {
                MessageBox.Show(resultStr);
            }
        }

        private void игратьЗаГерояToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public static Image CaptureScreens(params Screen[] screens)
        {
            if (screens == null || screens.Length == 0)
                throw new ArgumentNullException("screens");

            // Order them in logical left-to-right fashion.
            var orderedScreens = screens.OrderBy(s => s.Bounds.Left).ToList();
            // Calculate the total width needed to fit all the screen into a single image
            var totalWidth = orderedScreens.Sum(s => s.Bounds.Width);
            // In order to handle screens of different sizes, make sure to make the Bitmap large enough to fit the tallest screen
            var maxHeight = orderedScreens.Max(s => s.Bounds.Top + s.Bounds.Height);

            var bmp = new Bitmap(totalWidth, maxHeight);
            int offset = 0;

            // Copy each screen to the bitmap
            using (var g = Graphics.FromImage(bmp))
            {
                foreach (var screen in orderedScreens)
                {
                    g.CopyFromScreen(screen.Bounds.Left, screen.Bounds.Top, offset, screen.Bounds.Top, screen.Bounds.Size);
                    offset += screen.Bounds.Width;
                }
            }

            return bmp;
        }

        private void сделатьСкринToolStripMenuItem_Click(object sender, EventArgs e)
        {



            Rectangle bounds = this.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }
                bitmap.Save("./system/spacer_net/test.png", ImageFormat.Png);
            }
        }

        private void toolStripTop_MouseClick(object sender, MouseEventArgs e)
        {
            Imports.Extern_ClearMouseClick();
        }

        private void menuStripTopMain_MouseClick(object sender, MouseEventArgs e)
        {
            Imports.Extern_ClearMouseClick();
        }

        private void menuStripTopMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Imports.Extern_ClearMouseClick();
        }

        private void toolStripTop_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Imports.Extern_ClearMouseClick();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Spacer.NET, 2020");
        }

        private void ввестиКоординатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnionNET.camCoordsWin.Show();
        }

        private void прочееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnionNET.miscSetWin.LoadSettings();
            UnionNET.miscSetWin.Show();

            UnionNET.FreeStrings();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                сохранитьZENToolStripMenuItem_Click(null, null);
                e.Handled = true;
            }
        }
    }
}
