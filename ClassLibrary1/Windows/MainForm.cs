
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

        public enum ToggleMenuType
        {
            ToggleVobs = 0,
            ToggleWaynet,
            ToggleHelpers,
            ToggleBbox,
            ToggleInvis
        }

       
        public MainForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            UpdateSpacerCaption("");
        }

        public void UpdateSpacerCaption(string title)
        {
            currentWorldName = title;
            this.Text = "Spacer.NET (Beta): " + title;
        }
        
        private void CloseApp()
        {
            Imports.Stack_PushString("askExitZen");


            if (currentWorldName != "" && Imports.Extern_GetSetting() == 1)
            {
                DialogResult res = MessageBox.Show(Localizator.Get("askExit"), Localizator.Get("confirmation"), MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (res == DialogResult.OK)
                {

                    SpacerNET.CloseApplication();
                }
            }
            else
            {
                SpacerNET.CloseApplication();
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseApp();
        }

        public void ResetInterface()
        {
            ObjTree.globalEntries.Clear();
            SpacerNET.objTreeWin.globalTree.Nodes.Clear();
            SpacerNET.vobList.ClearListBox();
            ObjectsWindow.CleanProps();
            toolStripMenuItemMerge.Enabled = false;
            saveZenToolStripMenuItem.Enabled = false;
            compileLightToolStrip.Enabled = false;
            compileWorldToolStrip.Enabled = false;

            
            // UnionNET.partWin.listBoxParticles.Items.Clear();
            // UnionNET.partWin.listBoxItems.Items.Clear();
        }

        public void UpdateLang()
        {
            ToolStripMenuFile.Text = Localizator.Get("MENU_TOP_FILE");
            toolStripMenuResetWorld.Text = Localizator.Get("MENU_TOP_RESET");
            exitToolStripMenuItem.Text = Localizator.Get("MENU_TOP_EXIT");
            languageToolStripMenuItem.Text = Localizator.Get("MENU_TOP_LANG");


            toolStripMenuHelp.Text = Localizator.Get("MENU_TOP_HELP");
            toolStripMenuItemSettings.Text = Localizator.Get("MENU_TOP_SETTINGS");
            ToolStripMenuWorld.Text = Localizator.Get("MENU_TOP_WORLD");
            ToolStripMenuView.Text = Localizator.Get("MENU_TOP_VIEW");

            openZENToolStripMenuItem.Text = Localizator.Get("MENU_TOP_OPENZEN");
            toolStripMenuOpenZEN.Text = Localizator.Get("MENU_TOP_MESH");
            toolStripMenuItemMerge.Text = Localizator.Get("MENU_TOP_MERGE");
            saveZenToolStripMenuItem.Text = Localizator.Get("MENU_TOP_SAVEZEN");
            aboutToolStripMenuItem.Text = Localizator.Get("MENU_TOP_ABOUT");


            cameraToolStripMenuItem.Text = Localizator.Get("MENU_TOP_CAM");
            controlsToolStripMenuItem.Text = Localizator.Get("MENU_TOP_CONTROLS");
            miscToolStripMenuItem.Text = Localizator.Get("MENU_TOP_MISC");


            showToolStripMenuItem.Text = Localizator.Get("MENU_TOP_VIEW_SHOW");

            toolStripMenuItem5.Text = Localizator.Get("MENU_TOP_VIEW_VOBS");
            toolStripMenuItem6.Text = Localizator.Get("MENU_TOP_VIEW_WAYNET");
            toolStripMenuItem7.Text = Localizator.Get("MENU_TOP_VIEW_HELPER");


            compileLightToolStrip.Text = Localizator.Get("MENU_TOP_COMPILE_LIGHT");
            compileWorldToolStrip.Text = Localizator.Get("MENU_TOP_COMPILE_WORLD");
            cameraCoordsToolStrip.Text = Localizator.Get("MENU_TOP_CAM");
            прыгнутьНа000КоординатыToolStripMenuItem.Text = Localizator.Get("MENU_TOP_CAM_ZERO");
            ввестиКоординатыToolStripMenuItem.Text = Localizator.Get("MENU_TOP_CAM_COORDS");
            dayTimeToolStrip.Text = Localizator.Get("MENU_TOP_DAYTIME");
            ToolStripMenuTimeMorning.Text = Localizator.Get("MENU_TOP_MORN");
            ToolStripMenuTimeDay.Text = Localizator.Get("MENU_TOP_NOON");
            ToolStripMenuTimeEvening.Text = Localizator.Get("MENU_TOP_AFTERNOON");
            ToolStripMenuTimeNight.Text = Localizator.Get("MENU_TOP_NIGHT");
            analyseWaynetToolStripMenuItem.Text = Localizator.Get("MENU_TOP_ANALYSE_WAYNET");
            playHeroToolStrip.Text = Localizator.Get("MENU_TOP_PLAY_THE_GAME");


            keyBindsToolStripMenuItem.Text = Localizator.Get("MENU_TOP_KEYSBINDS");


            toolStripButtonInfo.Text = Localizator.Get("MENU_TOP_HOVER_WININFO");
            toolStripButtonBig.Text = Localizator.Get("MENU_TOP_HOVER_WINOBJ");
            toolStripButtonSound.Text = Localizator.Get("MENU_TOP_HOVER_WINSOUND");
            toolStripButtonTree.Text = Localizator.Get("MENU_TOP_HOVER_WINTREE");
            toolStripButton8.Text = Localizator.Get("MENU_TOP_HOVER_WINPROPS");
            toolStripButton9.Text = Localizator.Get("MENU_TOP_HOVER_WINVOBLIST");

            toolStripButtonVobs.Text = Localizator.Get("MENU_TOP_VIEW_VOBS");
            toolStripButtonWaynet.Text = Localizator.Get("MENU_TOP_VIEW_WAYNET");
            toolStripButtonHelpVobs.Text = Localizator.Get("MENU_TOP_VIEW_HELPER");
            
            toolStripButtonBBox.Text = Localizator.Get("MENU_TOP_VIEW_BBOX");
            toolStripButtonInvisible.Text = Localizator.Get("MENU_TOP_VIEW_INVIS");




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

       


        [DllExport]
        public static void LoadZenAuto()
        {
            string path = Imports.Stack_PeekString();
            string fileName = Path.GetFileName(path);

            //ConsoleEx.WriteLineGreen(path);

            if (!File.Exists(path))
            {
                return;
            }



            Stopwatch s = new Stopwatch();
            s.Start();


            Imports.Stack_PushString("fullPathTitle");

            if (Imports.Extern_GetSetting() != 0)
            {
                SpacerNET.form.UpdateSpacerCaption(path);
            }
            else
            {
                SpacerNET.form.UpdateSpacerCaption(fileName);
            }

           
            SpacerNET.form.ResetInterface();

            SpacerNET.form.AddText(fileName + " " + Localizator.Get("isLoading"));
            ConsoleEx.WriteLineGreen(fileName + " " + Localizator.Get("isLoading"));

            SpacerNET.form.currentWorldName = fileName;

            Imports.Stack_PushString(path);
            Imports.Extern_LoadWorld();

            s.Stop();

            string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
            SpacerNET.form.AddText(Localizator.Get("loadZenTime") + " (" + timeSpend + ")");
            ConsoleEx.WriteLineGreen(Localizator.Get("loadZenTime") + " (" + timeSpend + ")");
            SpacerNET.form.toolStripMenuItemMerge.Enabled = false;
            SpacerNET.form.saveZenToolStripMenuItem.Enabled = true;

        }


        private void openZENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Zen files (*.zen)|";

            Imports.Stack_PushString("zenzPath");
            Imports.Extern_GetSettingStr();
            string path = Imports.Stack_PeekString();

            //ConsoleEx.WriteLineRed(path);

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
            openFileDialog1.FileName = String.Empty;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {


                Imports.Stack_PushString(Path.GetDirectoryName(openFileDialog1.FileName));
                Imports.Stack_PushString("zenzPath");
                Imports.Extern_SetSettingStr();


                Imports.Stack_PushString(openFileDialog1.FileName);
                Imports.Stack_PushString("openLastZenPath");
                Imports.Extern_SetSettingStr();

                string filePath = openFileDialog1.FileName;


                Imports.Stack_PushString("fullPathTitle");

                if (Imports.Extern_GetSetting() != 0)
                {
                    UpdateSpacerCaption(filePath);
                }
                else
                {
                    UpdateSpacerCaption(openFileDialog1.SafeFileName);
                }
               

                Stopwatch s = new Stopwatch();
                s.Start();

                ResetInterface();

                SpacerNET.form.AddText(openFileDialog1.SafeFileName + " " + Localizator.Get("isLoading"));
                ConsoleEx.WriteLineGreen(openFileDialog1.SafeFileName + " " + Localizator.Get("isLoading"));

                currentWorldName = openFileDialog1.SafeFileName;

                Imports.Stack_PushString(filePath);
                Imports.Extern_LoadWorld();


                s.Stop();

                string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
                SpacerNET.form.AddText(Localizator.Get("loadZenTime") + " (" + timeSpend + ")");
                ConsoleEx.WriteLineGreen(Localizator.Get("loadZenTime") + " (" + timeSpend + ")");

                toolStripMenuItemMerge.Enabled = false;
                SpacerNET.form.compileLightToolStrip.Enabled = true;
                SpacerNET.form.saveZenToolStripMenuItem.Enabled = true;
            }

            

        }

       

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            item.Checked = !item.Checked;

            Imports.Stack_PushString("showVobs");
            Imports.Extern_SetSetting(Convert.ToInt32(item.Checked));
            
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            item.Checked = !item.Checked;

            Imports.Stack_PushString("showVobs");
            Imports.Extern_SetSetting( Convert.ToInt32(item.Checked));
            
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            item.Checked = !item.Checked;

            Imports.Stack_PushString("showVobs");
            Imports.Extern_SetSetting( Convert.ToInt32(item.Checked));
            
        }


        private void здрастеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           SpacerNET.comLightWin.LoadSettings();
           SpacerNET.comLightWin.Show();
          
        }
        public void AddText(string text)
        {
            
            SpacerNET.infoWin.AddText(text);
            Application.DoEvents();
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            Imports.Stack_PushString("showWaynet");
            Imports.Extern_SetSetting(Convert.ToInt32(item.Checked));
            toolStripMenuItem6.Checked = item.Checked;
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            Imports.Stack_PushString("showHelpVobs");
            Imports.Extern_SetSetting(Convert.ToInt32(item.Checked));
            toolStripMenuItem7.Checked = item.Checked;
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;
            Imports.Stack_PushString("showVobs");
            Imports.Extern_SetSetting(Convert.ToInt32(item.Checked));
            toolStripMenuItem5.Checked = item.Checked;
            
        }



        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void toolStrip1_MouseEnter(object sender, EventArgs e)
        {
            SpacerNET.form.Focus();
        }

        private void menuStrip1_MouseEnter(object sender, EventArgs e)
        {
            SpacerNET.form.Focus();
        }



        

        private void сохранитьZENToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (currentWorldName.Length == 0)
            {
                return;
            }

            saveFileDialog1.Filter = "Compiled ZEN (ascii)|*.zen|Uncompiled ZEN (ascii)|*.zen|Compiled ZEN (binary safe)|*.zen";

            //saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory() + "../_WORK/DATA/Worlds/";


            Imports.Stack_PushString("zenzPath");
            Imports.Extern_GetSettingStr();
            string path = Imports.Stack_PeekString();

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

            Imports.Stack_PushString("addDatePrefix");

            int addPrefx = Imports.Extern_GetSetting();


            if (addPrefx != 0)
            {
                zenName = zenName.Replace(".zen", "").Replace(".ZEN", "") + "_" + time + ".ZEN";
            }
           

            saveFileDialog1.FileName = zenName;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {




                Imports.Stack_PushString(Path.GetDirectoryName(saveFileDialog1.FileName));
                Imports.Stack_PushString("zenzPath");
                Imports.Extern_SetSettingStr();


                Imports.Stack_PushString(saveFileDialog1.FileName);
                Imports.Stack_PushString("openLastZenPath");
                Imports.Extern_SetSettingStr();




                string filePath = saveFileDialog1.FileName;
                string selectedFileName = Path.GetFileName(saveFileDialog1.FileName);


                Imports.Stack_PushString("fullPathTitle");

                if (Imports.Extern_GetSetting() != 0)
                {
                    SpacerNET.form.UpdateSpacerCaption(filePath);
                }
                else
                {
                    UpdateSpacerCaption(selectedFileName);
                }

               


                if (saveFileDialog1.FilterIndex == 2)
                {
                    //filePath = filePath.Replace(".zen", "") + "_vobs.zen";
                }
                
                Stopwatch s = new Stopwatch();
                s.Start();


               // ConsoleEx.WriteLineGreen(selectedFileName + " " + Localizator.Get("IS_SAVING"));
                SpacerNET.form.AddText(selectedFileName + " " + Localizator.Get("IS_SAVING"));

                Imports.Stack_PushString(filePath);

                Imports.Extern_SaveWorld( saveFileDialog1.FilterIndex - 1);

                s.Stop();

                string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
                SpacerNET.form.AddText(Localizator.Get("saveZenTime") + " (" + timeSpend + ")");
                ConsoleEx.WriteLineGreen(Localizator.Get("saveZenTime") + " (" + timeSpend + ")");

            }
            
        }




        private void камераToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Imports.Stack_PushString("rangeVobs");
            Imports.Stack_PushString("rangeWorld");
            Imports.Stack_PushString("camRotSpeed");
            Imports.Stack_PushString("camTransSpeed");

            int transSpeed = Imports.Extern_GetSetting();
            int rotSpeed = Imports.Extern_GetSetting();

            int world = Imports.Extern_GetSetting();
            int vob = Imports.Extern_GetSetting();


            SpacerNET.settingsCam.trackBarTransSpeed.Value = transSpeed;
            SpacerNET.settingsCam.trackBarRotSpeed.Value = rotSpeed;

            SpacerNET.settingsCam.trackBarWorld.Value = world;
            SpacerNET.settingsCam.trackBarVobs.Value = vob;

            SpacerNET.settingsCam.UpdateAll();



            Imports.Stack_PushString("maxFPS");
            Imports.Stack_PushString("hideCamWindows");
            Imports.Stack_PushString("showVobDist");
            Imports.Stack_PushString("showWaypointsCount");
            Imports.Stack_PushString("showVobsCount");
            Imports.Stack_PushString("showCamCoords");
            Imports.Stack_PushString("showTris");
            Imports.Stack_PushString("showFps");

            SpacerNET.settingsCam.checkBoxFPS.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());
            SpacerNET.settingsCam.checkBoxTris.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());


            SpacerNET.settingsCam.checkBoxCamCoord.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());
            SpacerNET.settingsCam.checkBoxVobs.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());


            SpacerNET.settingsCam.checkBoxWaypoints.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());
            SpacerNET.settingsCam.checkBoxDistVob.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());


            SpacerNET.settingsCam.checkBoxCameraHideWins.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());


            SpacerNET.settingsCam.textBoxLimitFPS.Text = Imports.Extern_GetSetting().ToString();



            SpacerNET.settingsCam.Show();

            
        }



        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseApp();
            e.Cancel = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Mesh-File (*.3ds)|*.3ds|All Files(*.*)|*.*||";



            Imports.Stack_PushString("meshPath");
            Imports.Extern_GetSettingStr();
            string path = Imports.Stack_PeekString();
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
            openFileDialog1.FileName = String.Empty;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {



                Imports.Stack_PushString(Path.GetDirectoryName(openFileDialog1.FileName));
                Imports.Stack_PushString("meshPath");
                Imports.Extern_SetSettingStr();


                string filePath = openFileDialog1.FileName;


                UpdateSpacerCaption(openFileDialog1.SafeFileName);


                Stopwatch s = new Stopwatch();
                s.Start();

                ResetInterface();

                SpacerNET.form.AddText(openFileDialog1.SafeFileName + " " + Localizator.Get("isLoading"));

                currentWorldName = openFileDialog1.SafeFileName;

                Imports.Stack_PushString(filePath);
                Imports.Extern_LoadMesh();

                s.Stop();

                string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
                SpacerNET.form.AddText(Localizator.Get("loadMeshTime") + " (" + timeSpend + ")");

                SpacerNET.form.toolStripMenuItemMerge.Enabled = true;
                SpacerNET.form.compileWorldToolStrip.Enabled = true;

            }

            

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

            if (Imports.Extern_IsWorldCompiled())
            {
                MessageBox.Show(Localizator.Get("WIN_COMPWORLD_ALREADY_COMP"));
                return;
            }

            openFileDialog1.Filter = "World (*.Zen)|*.zen|All Files(*.*)|*.*||";



            Imports.Stack_PushString("vobsPath");
            Imports.Extern_GetSettingStr();
            string path = Imports.Stack_PeekString();

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



                Imports.Stack_PushString((Path.GetDirectoryName(openFileDialog1.FileName)));
                Imports.Stack_PushString("vobsPath");
                Imports.Extern_SetSettingStr();


                string filePath = openFileDialog1.FileName;

                UpdateSpacerCaption(openFileDialog1.SafeFileName);


                Stopwatch s = new Stopwatch();
                s.Start();

                ResetInterface();

                SpacerNET.form.AddText(openFileDialog1.SafeFileName + " " + Localizator.Get("isLoading"));

                currentWorldName = openFileDialog1.SafeFileName;

                Imports.Stack_PushString(filePath);
                Imports.Extern_MergeZen();

                s.Stop();

                string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
                SpacerNET.form.AddText(Localizator.Get("mergeZenTime") + " (" + timeSpend + ")");


                toolStripMenuItemMerge.Enabled = true;
                compileWorldToolStrip.Enabled = true;

            }

            
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show(Localizator.Get("askReset"), Localizator.Get("confirmation"), MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (res == DialogResult.OK)
            {
                currentWorldName = "";

                ResetInterface();
                Imports.Extern_ResetWorld();
            }

           
            
        }

    

        private void компиляцияМираToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
             SpacerNET.compWorldWin.LoadSettings();
             SpacerNET.compWorldWin.Show();
           
        }


        private void прыгнутьНа000КоординатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imports.Stack_PushFloat(0);
            Imports.Stack_PushFloat(0);
            Imports.Stack_PushFloat(0);

            Imports.Extern_SetCameraPos();
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
            ToolStripButton btn = sender as ToolStripButton;

            if (SpacerNET.infoWin.Visible)
            {
                SpacerNET.infoWin.Hide();
                btn.Checked = false;
            }
            else
            {
                SpacerNET.infoWin.Show();
                btn.Checked = true;
            }
        }

        private void toolStripButtonBig_Click(object sender, EventArgs e)
        {
            ToolStripButton btn = sender as ToolStripButton;
            if (SpacerNET.objectsWin.Visible)
            {
                btn.Checked = false;
                SpacerNET.objectsWin.Hide();
            }
            else
            {
                btn.Checked = true;
                SpacerNET.objectsWin.Show();
            }
        }

        private void toolStripButtonSound_Click(object sender, EventArgs e)
        {
            ToolStripButton btn = sender as ToolStripButton;

            Imports.Stack_PushString("musicVolume");
            Imports.Stack_PushString("musicZenOff");

            bool musicOff = Convert.ToBoolean(Imports.Extern_GetSetting());
            SpacerNET.soundWin.checkBoxShutMusic.Checked = musicOff;



            int volume = Imports.Extern_GetSetting();
            SpacerNET.soundWin.trackBarMusicVolume.Value = volume;


            SpacerNET.soundWin.UpdateAll();

            if (SpacerNET.soundWin.Visible)
            {
                btn.Checked = false;
                SpacerNET.soundWin.Hide();
            }
            else
            {
                btn.Checked = true;
                SpacerNET.soundWin.Show();
            }



            if (Properties.Settings.Default.SoundWinLocation != null)
            {
                SpacerNET.soundWin.Location = Properties.Settings.Default.SoundWinLocation;
            }
        }

        private void toolStripButtonTree_Click(object sender, EventArgs e)
        {
            ToolStripButton btn = sender as ToolStripButton;

            if (SpacerNET.objTreeWin.Visible)
            {
                btn.Checked = false;
                SpacerNET.objTreeWin.Hide();
            }
            else
            {
                btn.Checked = true;
                SpacerNET.objTreeWin.Show();
            }
        }

        private void toolStripButton8_Click_1(object sender, EventArgs e)
        {
            ToolStripButton btn = sender as ToolStripButton;

            if (SpacerNET.propWin.Visible)
            {
                btn.Checked = false;
                SpacerNET.propWin.Hide();
            }
            else
            {
                btn.Checked = true;
                SpacerNET.propWin.Show();
            }
        }

        private void toolStripButton9_Click_1(object sender, EventArgs e)
        {
            ToolStripButton btn = sender as ToolStripButton;

            if (SpacerNET.vobList.Visible)
            {
                btn.Checked = false;
                SpacerNET.vobList.Hide();
            }
            else
            {
                btn.Checked = true;
                SpacerNET.vobList.Show();
            }
        }


        [DllExport]
        public static void Menu_Toggle(int type)
        {
            ToggleMenuType toggleType = (ToggleMenuType)type;

            switch (toggleType)
            {
                case ToggleMenuType.ToggleVobs: SpacerNET.form.toolStripButtonVobs_Click(SpacerNET.form.toolStripButtonVobs, null);  break;
                case ToggleMenuType.ToggleWaynet: SpacerNET.form.toolStripButtonWaynet_Click(SpacerNET.form.toolStripButtonWaynet, null); break;
                case ToggleMenuType.ToggleHelpers: SpacerNET.form.toolStripButtonHelpVobs_Click(SpacerNET.form.toolStripButtonHelpVobs, null); break;
                case ToggleMenuType.ToggleBbox: SpacerNET.form.toolStripButtonBBox_Click_1(SpacerNET.form.toolStripButtonBBox, null); break;
                case ToggleMenuType.ToggleInvis: SpacerNET.form.toolStripButtonInvisible_Click(SpacerNET.form.toolStripButtonInvisible, null); break;
            }

        }


        private void toolStripButtonVobs_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            Imports.Stack_PushString("showVobs");
            Imports.Extern_SetSetting(Convert.ToInt32(item.Checked));
            toolStripMenuItem5.Checked = item.Checked;
            
        }

        private void toolStripButtonWaynet_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            Imports.Stack_PushString("showWaynet");
            Imports.Extern_SetSetting(Convert.ToInt32(item.Checked));
            toolStripMenuItem6.Checked = item.Checked;
            
        }

        private void toolStripButtonHelpVobs_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;
            Imports.Stack_PushString("showHelpVobs");
            Imports.Extern_SetSetting(Convert.ToInt32(item.Checked));
            toolStripMenuItem7.Checked = item.Checked;
            
        }

        private void toolStripButtonBBox_Click_1(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;
            Imports.Stack_PushString("drawBBoxGlobal");
            Imports.Extern_SetSetting(Convert.ToInt32(item.Checked));
            
        }

        private void управлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Imports.Stack_PushString("wpTurnOn");
            Imports.Stack_PushString("vobInsertHierarchy");
            Imports.Stack_PushString("vobInsertVobRotRand");
            Imports.Stack_PushString("vobInsertItemLevel");
            Imports.Stack_PushString("vobRotSpeed");
            Imports.Stack_PushString("vobTransSpeed");

            int transSpeed = Imports.Extern_GetSetting();
            int rotSpeed = Imports.Extern_GetSetting();
            bool insertVobItemLevel = Convert.ToBoolean(Imports.Extern_GetSetting());
            bool vobInsertVobRotRand = Convert.ToBoolean(Imports.Extern_GetSetting());
            bool vobInsertHierarchy = Convert.ToBoolean(Imports.Extern_GetSetting());
            int turnMode = Imports.Extern_GetSetting();



            SpacerNET.settingsControl.trackBarVobTransSpeed.Value = transSpeed;
            SpacerNET.settingsControl.trackBarVobRotSpeed.Value = rotSpeed;
            SpacerNET.settingsControl.checkBoxInsertVob.Checked = insertVobItemLevel;
            SpacerNET.settingsControl.checkBoxVobRotRandAngle.Checked = vobInsertVobRotRand;
            SpacerNET.settingsControl.checkBoxVobInsertHierarchy.Checked = vobInsertHierarchy;
            SpacerNET.settingsControl.UpdateAll();

            SpacerNET.settingsControl.SetRadioTurnMode(turnMode);

            SpacerNET.settingsControl.Show();
        }

        private void toolStripButtonInvisible_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            Imports.Stack_PushString("showInvisibleVobs");
            Imports.Extern_SetSetting(Convert.ToInt32(item.Checked));
            
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
            Imports.Extern_AnalyseWaynet();

            string resultStr = Imports.Stack_PeekString();

            if (resultStr.Length == 0)
            {
                MessageBox.Show(Localizator.Get("waynetMsg"));
            }
            else
            {
                MessageBox.Show(resultStr);
            }
        }

        private void игратьЗаГерояToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not working yet...");
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
            MessageBox.Show("Spacer.NET by Liker, 2020");
        }

        private void ввестиКоординатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpacerNET.camCoordsWin.Show();
        }

        private void прочееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpacerNET.miscSetWin.LoadSettings();
            SpacerNET.miscSetWin.Show();

            
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyCode == Keys.S && e.Control)
            {
                сохранитьZENToolStripMenuItem_Click(null, null);
                e.Handled = true;
            }
            */
        }

        private void русскийToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = (int)LangEnum.RU;
            Properties.Settings.Default.Save();

            Localizator.SetLanguage(LangEnum.RU);
            Localizator.UpdateInterface();
        }

        private void englishToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = (int)LangEnum.EN;
            Properties.Settings.Default.Save();

            Localizator.SetLanguage(LangEnum.EN);
            Localizator.UpdateInterface();
        }

        private void сочетанияКлавишToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpacerNET.keysWin.Show();
        }

        private void тестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deutscheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = (int)LangEnum.DE;
            Properties.Settings.Default.Save();

            Localizator.SetLanguage(LangEnum.DE);
            Localizator.UpdateInterface();
        }

        private void polskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = (int)LangEnum.PL;
            Properties.Settings.Default.Save();

            Localizator.SetLanguage(LangEnum.PL);
            Localizator.UpdateInterface();
        }

        private void toolStripButtonInfo_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
