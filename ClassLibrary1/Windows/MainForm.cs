
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
        public bool meshOpenFirst = false;
        public string locationName;
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


        [DllExport]
        public static void GetSpacerVersion()
        {
            Imports.Stack_PushString(Constants.SPACER_VERSION);

        }

        
        

        public void UpdateSpacerCaption(string title)
        {
            currentWorldName = title;
            this.Text = "Spacer.NET (" + Constants.SPACER_VERSION + ") " + title;

            locationName = title;
        }
        
        private void CloseApp()
        {
            Imports.Stack_PushString("askExitZen");


            if (currentWorldName != "" && Imports.Extern_GetSetting() == 1)
            {
                DialogResult res = MessageBox.Show(Localizator.Get("askSure"), Localizator.Get("confirmation"), MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

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
            SpacerNET.objTreeWin.matTree.Nodes.Clear();
            SpacerNET.objTreeWin.quickTree.Nodes.Clear();
            SpacerNET.vobList.ClearListBox();
            ObjectsWindow.CleanProps();
            toolStripMenuItemMerge.Enabled = false;
            saveZenToolStripMenuItem.Enabled = false;
            saveUncZenToolStrip.Enabled = false;
            toolStripMenuExtractMesh.Enabled = false;
            compileLightToolStrip.Enabled = false;
            compileWorldToolStrip.Enabled = false;
            analyseWaynetToolStripMenuItem.Enabled = false;
            playHeroToolStrip.Enabled = false;
            cameraCoordsToolStrip.Enabled = false;
            dayTimeToolStrip.Enabled = false;
            toolStripMenuResetWorld.Enabled = false;
            toolStripMenuItemMergeMesh.Enabled = false;
            stripSpecialFunctions.Enabled = false;
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
            toolStripMenuOpenMESH.Text = Localizator.Get("MENU_TOP_MESH");
            toolStripMenuItemMerge.Text = Localizator.Get("MENU_TOP_MERGE");
            toolStripMenuItemMergeMesh.Text = Localizator.Get("MENU_TOP_MERGEMESH");
            saveZenToolStripMenuItem.Text = Localizator.Get("MENU_TOP_SAVEZEN");
            saveUncZenToolStrip.Text = Localizator.Get("MENU_TOP_SAVEZENUNC");
            toolStripMenuExtractMesh.Text = Localizator.Get("MENU_TOP_SAVEMESH");
            aboutToolStripMenuItem.Text = Localizator.Get("MENU_TOP_ABOUT");


            cameraToolStripMenuItem.Text = Localizator.Get("MENU_TOP_CAM");
            controlsToolStripMenuItem.Text = Localizator.Get("MENU_TOP_CONTROLS");
            miscToolStripMenuItem.Text = Localizator.Get("MENU_TOP_MISC");


            showToolStripMenuItem.Text = Localizator.Get("MENU_TOP_VIEW_SHOW");

            WinPosMenu.Text = Localizator.Get("MENU_TOP_WIN_POS");
            resetWinAction.Text = Localizator.Get("MENU_TOP_WIN_POS_RESET");
            preset1ToolStripMenuItem.Text = Localizator.Get("MENU_TOP_WIN_POS_PRESET_1");
            



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

            stripSpecialFunctions.Text = Localizator.Get("MENU_TOP_SPECIAL_FUNCS");
            stripSpecialFormVobsVisuals.Text = Localizator.Get("MENU_TOP_CREATE_VOB_VISUALS_LIST");

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
            toolStripButtonGratt.Text = Localizator.Get("MENU_TOP_VIEW_ALTCONTROLLER");
            toolStripButtonMaterial.Text = Localizator.Get("MENU_TOP_VIEW_POLYGON");
            toolStripButtonGrass.Text = Localizator.Get("MENU_TOP_VIEW_GRASS");
            toolStripButtonMulti.Text = Localizator.Get("MENU_TOP_VIEW_MULTI");

            freezeTimeToolStripMenuItem.Text = Localizator.Get("MENU_TOP_VIEW_FREEZETIME");

            renderModeToolStripMenuItem.Text = Localizator.Get("MENU_TOP_VIEW_RENDERMODE");


            toolStripButtonMaterial.ToolTipText = toolStripButtonMaterial.Text;
            toolStripButtonGrass.ToolTipText = toolStripButtonGrass.Text;
            toolStripButtonGratt.ToolTipText = toolStripButtonGratt.Text;
            toolStripButtonMulti.ToolTipText = toolStripButtonMulti.Text;
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
        public static void GameModeToggleInterface(int mode)
        {
            SpacerNET.form.menuStripTopMain.Enabled = Convert.ToBoolean(mode);
            SpacerNET.form.toolStripTop.Enabled = Convert.ToBoolean(mode);
  
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
            SpacerNET.form.AddText(Localizator.Get("loadZenTime") + " (" + timeSpend + ")", Color.Green);
            ConsoleEx.WriteLineGreen(Localizator.Get("loadZenTime") + " (" + timeSpend + ")");
            SpacerNET.form.toolStripMenuItemMerge.Enabled = false;
            SpacerNET.form.saveZenToolStripMenuItem.Enabled = true;
            SpacerNET.form.saveUncZenToolStrip.Enabled = true;
            SpacerNET.form.toolStripMenuExtractMesh.Enabled = true;
            

            SpacerNET.form.analyseWaynetToolStripMenuItem.Enabled = true;
            SpacerNET.form.playHeroToolStrip.Enabled = true;
            SpacerNET.form.stripSpecialFunctions.Enabled = true;
            SpacerNET.form.cameraCoordsToolStrip.Enabled = true;
            SpacerNET.form.dayTimeToolStrip.Enabled = true;
            SpacerNET.form.toolStripMenuResetWorld.Enabled = true;
            SpacerNET.form.compileWorldToolStrip.Enabled = true;
            SpacerNET.form.compileLightToolStrip.Enabled = true;
        }




        private void openZENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = Constants.FILE_FILTER_OPEN_ZEN;

            Imports.Stack_PushString("zenzPath");
            Imports.Extern_GetSettingStr();
            string path = Utils.FixPath(Imports.Stack_PeekString());

            //ConsoleEx.WriteLineRed(path);


            openFileDialog.InitialDirectory = Utils.GetInitialDirectory(path);


            openFileDialog.RestoreDirectory = true;
            openFileDialog.FileName = String.Empty;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                if (!Utils.IsPathWorkFolder(filePath))
                {
                    MessageBox.Show(Localizator.Get("WORK_PATH_ERROR"));
                    return;
                }

                if (filePath.ToUpper().Contains(".3DS"))
                {
                    MessageBox.Show(Localizator.Get("ZEN_BAD_NAME"));
                    return;
                }


                Imports.Stack_PushString(Utils.FixPath(Path.GetDirectoryName(Utils.FixPath(openFileDialog.FileName))));
                Imports.Stack_PushString("zenzPath");
                Imports.Extern_SetSettingStr();


                Imports.Stack_PushString(Utils.FixPath(openFileDialog.FileName));
                Imports.Stack_PushString("openLastZenPath");
                Imports.Extern_SetSettingStr();

               


                Imports.Stack_PushString("fullPathTitle");

                if (Imports.Extern_GetSetting() != 0)
                {
                    UpdateSpacerCaption(filePath);
                }
                else
                {
                    UpdateSpacerCaption(openFileDialog.SafeFileName);
                }
               

                Stopwatch s = new Stopwatch();
                s.Start();

                ResetInterface();

                SpacerNET.form.AddText(openFileDialog.SafeFileName + " " + Localizator.Get("isLoading"));
                ConsoleEx.WriteLineGreen(openFileDialog.SafeFileName + " " + Localizator.Get("isLoading"));

                currentWorldName = openFileDialog.SafeFileName;

                Imports.Stack_PushInt(openFileDialog.FilterIndex);
                Imports.Stack_PushString(filePath);
                Imports.Extern_LoadWorld();


                s.Stop();

                string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
                SpacerNET.form.AddText(Localizator.Get("loadZenTime") + " (" + timeSpend + ")", Color.Green);
                ConsoleEx.WriteLineGreen(Localizator.Get("loadZenTime") + " (" + timeSpend + ")");


                toolStripMenuItemMerge.Enabled = false;

                /*
                if (!Imports.Extern_IsWorldCompiled())
                {
                    SpacerNET.form.toolStripMenuItemMerge.Enabled = true;
                    SpacerNET.form.compileWorldToolStrip.Enabled = true;
                    SpacerNET.form.dayTimeToolStrip.Enabled = true;
                    SpacerNET.form.toolStripMenuResetWorld.Enabled = true;
                }
                else
                {
                    SpacerNET.form.compileLightToolStrip.Enabled = true;
                    SpacerNET.form.saveZenToolStripMenuItem.Enabled = true;
                    SpacerNET.form.analyseWaynetToolStripMenuItem.Enabled = true;
                    SpacerNET.form.playHeroToolStrip.Enabled = true;
                    SpacerNET.form.cameraCoordsToolStrip.Enabled = true;
                    SpacerNET.form.dayTimeToolStrip.Enabled = true;
                    SpacerNET.form.toolStripMenuResetWorld.Enabled = true;
                }
                */

                SpacerNET.form.compileLightToolStrip.Enabled = true;
                SpacerNET.form.saveZenToolStripMenuItem.Enabled = true;
                SpacerNET.form.saveUncZenToolStrip.Enabled = true;
                SpacerNET.form.toolStripMenuExtractMesh.Enabled = true;
                SpacerNET.form.analyseWaynetToolStripMenuItem.Enabled = true;
                SpacerNET.form.playHeroToolStrip.Enabled = true;
                SpacerNET.form.stripSpecialFunctions.Enabled = true;
                SpacerNET.form.cameraCoordsToolStrip.Enabled = true;
                SpacerNET.form.dayTimeToolStrip.Enabled = true;
                SpacerNET.form.toolStripMenuResetWorld.Enabled = true;
                SpacerNET.form.compileWorldToolStrip.Enabled = true;
                SpacerNET.form.compileLightToolStrip.Enabled = true;


            }

            

        }

       

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            item.Checked = !item.Checked;

            toolStripButtonVobs.Checked = item.Checked;

            Imports.Stack_PushString("showVobs");
            Imports.Extern_SetSetting(Convert.ToInt32(item.Checked));
            
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            item.Checked = !item.Checked;

            toolStripButtonWaynet.Checked = item.Checked;

            Imports.Stack_PushString("showWaynet");
            Imports.Extern_SetSetting( Convert.ToInt32(item.Checked));
            
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            item.Checked = !item.Checked;

            toolStripButtonHelpVobs.Checked = item.Checked;

            Imports.Stack_PushString("showHelpVobs");
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

        public void AddText(string text, Color color)
        {

            SpacerNET.infoWin.AddText(text, color);
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

            saveFileDialog.Filter = Constants.FILE_FILTER_SAVE_ZEN;

            //saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory() + "../_WORK/DATA/Worlds/";


            Imports.Stack_PushString("zenzPath");
            Imports.Extern_GetSettingStr();
            string path = Utils.FixPath(Imports.Stack_PeekString());

            saveFileDialog.InitialDirectory = Utils.GetInitialDirectory(path);
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FilterIndex = 0;
            //Console.WriteLine(openFileDialog1.InitialDirectory);

            if (currentWorldName.Contains("_VOBS_"))
            {
                currentWorldName = currentWorldName.Replace("_VOBS_", "");
            }



            string zenName = Utils.GetZenName(currentWorldName);

            if (zenName.Contains(".3DS"))
            {
                zenName = zenName.Replace(".3DS", "");
            }


            //Path.GetFileName(currentWorldName.Replace(".zen", "").Replace(".ZEN", ""));




            //zenName = Utils.CorrectZenName(zenName);
            saveFileDialog.FileName = zenName;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // uncompiled zen
                if (saveFileDialog.FilterIndex == 1)
                {

                }
                Imports.Stack_PushString(Utils.FixPath(Path.GetDirectoryName(Utils.FixPath(saveFileDialog.FileName))));
                Imports.Stack_PushString("zenzPath");
                Imports.Extern_SetSettingStr();


                Imports.Stack_PushString(Utils.FixPath((saveFileDialog.FileName)));
                Imports.Stack_PushString("openLastZenPath");
                Imports.Extern_SetSettingStr();

                string filePath = saveFileDialog.FileName;
                string selectedFileName = Path.GetFileName(saveFileDialog.FileName);


                Imports.Stack_PushString("fullPathTitle");

                if (Imports.Extern_GetSetting() != 0)
                {
                    SpacerNET.form.UpdateSpacerCaption(filePath);
                }
                else
                {
                    UpdateSpacerCaption(selectedFileName);
                }

               


                if (saveFileDialog.FilterIndex == 2)
                {
                    //filePath = filePath.Replace(".zen", "") + "_vobs.zen";
                }

                bool sortPolys = true;

                int polysCountLoc = Imports.Extern_GetPolysCount();

                //ConsoleEx.WriteLineRed("Polys: " + polysCountLoc + " Check: " + SpacerNET.miscSetWin.checkBoxShowPolysSort.Checked);


                ToggleWindowOnTop(true);

                if (SpacerNET.miscSetWin.checkBoxShowPolysSort.Checked && polysCountLoc >= 200000)
                {
                    DialogResult result = MessageBox.Show(
                          Localizator.Get("CHECK_SORTING_POLYS"),
                          Localizator.Get("groupBoxInfo"),

                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Information,
                          MessageBoxDefaultButton.Button1,
                          MessageBoxOptions.DefaultDesktopOnly
                    );

                    if (result == DialogResult.No)
                    {
                        sortPolys = false;
                    }
                    Application.DoEvents();

                }

                ToggleWindowOnTop(false);


                Stopwatch s = new Stopwatch();
                s.Start();


               // ConsoleEx.WriteLineGreen(selectedFileName + " " + Localizator.Get("IS_SAVING"));
                SpacerNET.form.AddText(selectedFileName + " " + Localizator.Get("IS_SAVING"));

               

                Imports.Stack_PushString(filePath);
                Imports.Stack_PushInt(Convert.ToInt32(sortPolys));
                Imports.Extern_SaveWorld( saveFileDialog.FilterIndex - 1);

                s.Stop();

                string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
                SpacerNET.form.AddText(Localizator.Get("saveZenTime") + " (" + timeSpend + ")", Color.Green);
                ConsoleEx.WriteLineGreen(Localizator.Get("saveZenTime") + " (" + timeSpend + ")");

            }
            
        }

        public void ToggleWindowOnTop(bool toggle)
        {
            this.TopMost = toggle;
        }


        private void камераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpacerNET.settingsCam.UpdateAll();
            SpacerNET.settingsCam.Show();
        }



        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseApp();
            e.Cancel = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = Constants.FILE_FILTER_OPEN_MESH;



            Imports.Stack_PushString("meshPath");
            Imports.Extern_GetSettingStr();
            string path = Utils.FixPath(Imports.Stack_PeekString());
            //MessageBox.Show(path);

            openFileDialog.InitialDirectory = Utils.GetInitialDirectory(path);

            openFileDialog.RestoreDirectory = true;
            openFileDialog.FileName = String.Empty;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string filePath = openFileDialog.FileName;

                if (!Utils.IsPathWorkFolder(filePath))
                {
                    MessageBox.Show(Localizator.Get("WORK_PATH_ERROR"));
                    return;
                }


                string meshPathSave = Utils.FixPath(Path.GetDirectoryName(Utils.FixPath(openFileDialog.FileName)));


                Imports.Stack_PushString(meshPathSave);
                Imports.Stack_PushString("meshPath");
                Imports.Extern_SetSettingStr();



                UpdateSpacerCaption(openFileDialog.SafeFileName);


                Stopwatch s = new Stopwatch();
                s.Start();

                ResetInterface();

                SpacerNET.form.AddText(openFileDialog.SafeFileName + " " + Localizator.Get("isLoading"));

                currentWorldName = openFileDialog.SafeFileName;

                Imports.Stack_PushString(filePath);
                Imports.Extern_LoadMesh();

                s.Stop();

                string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
                SpacerNET.form.AddText(Localizator.Get("loadMeshTime") + " (" + timeSpend + ")", Color.Green);

                SpacerNET.form.toolStripMenuItemMerge.Enabled = true;
                SpacerNET.form.compileWorldToolStrip.Enabled = true;
                SpacerNET.form.dayTimeToolStrip.Enabled = true;
                SpacerNET.form.toolStripMenuResetWorld.Enabled = true;
                SpacerNET.form.toolStripMenuItemMergeMesh.Enabled = true;
                meshOpenFirst = true;
            }

            toolStripMenuResetWorld.Enabled = true;

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

            if (Imports.Extern_IsWorldCompiled() == 1)
            {
                MessageBox.Show(Localizator.Get("WIN_COMPWORLD_ALREADY_COMP"));
                return;
            }

            openFileDialog.Filter = Constants.FILE_FILTER_MERGE_VOBS;
            openFileDialog.Multiselect = false;


            Imports.Stack_PushString("vobsPath");
            Imports.Extern_GetSettingStr();
            string path = Utils.FixPath(Imports.Stack_PeekString());

            //MessageBox.Show(path);

            openFileDialog.InitialDirectory = Utils.GetInitialDirectory(path);
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                if (!Utils.IsPathWorkFolder(filePath))
                {
                    MessageBox.Show(Localizator.Get("WORK_PATH_ERROR"));
                    return;
                }

                string vobsPathSave = Utils.FixPath(Path.GetDirectoryName(Utils.FixPath(openFileDialog.FileName)));

                Imports.Stack_PushString(vobsPathSave);
                Imports.Stack_PushString("vobsPath");
                Imports.Extern_SetSettingStr();

                string zenName = openFileDialog.SafeFileName;

                if (zenName.Contains("_VOBS_"))
                {
                    zenName = zenName.Replace("_VOBS_", "");
                }

                UpdateSpacerCaption(openFileDialog.SafeFileName);


                Stopwatch sAll = new Stopwatch();
                sAll.Start();

                ResetInterface();


                SpacerNET.form.AddText(openFileDialog.SafeFileName + " " + Localizator.Get("isLoading"));

                currentWorldName = openFileDialog.SafeFileName;

                Imports.Stack_PushString(filePath);
                Imports.Extern_MergeZen();

                sAll.Stop();

                string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(sAll.Elapsed.Ticks));
                SpacerNET.form.AddText(Localizator.Get("mergeZenTime") + " (" + timeSpend + ")", Color.Green);


                toolStripMenuItemMerge.Enabled = true;
                compileWorldToolStrip.Enabled = true;
                toolStripMenuResetWorld.Enabled = true;

                openFileDialog.Multiselect = false;

                Imports.Stack_PushString("autoCompileWorldLight");
                int autoCompile = Imports.Extern_GetSetting();

                if (autoCompile == 1)
                {
                    SpacerNET.compWorldWin.OnWorldCompile();


                }
            }

            
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show(Localizator.Get("askReset"), Localizator.Get("confirmation"), MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (res == DialogResult.OK)
            {
                currentWorldName = "";
                UpdateSpacerCaption(currentWorldName);
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

            Imports.Stack_PushString("selectMoveWhenVobInsert");
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
            bool selectMove = Convert.ToBoolean(Imports.Extern_GetSetting());


            SpacerNET.settingsControl.trackBarVobTransSpeed.Value = transSpeed;
            SpacerNET.settingsControl.trackBarVobRotSpeed.Value = rotSpeed;
            SpacerNET.settingsControl.checkBoxInsertVob.Checked = insertVobItemLevel;
            SpacerNET.settingsControl.checkBoxVobRotRandAngle.Checked = vobInsertVobRotRand;
            SpacerNET.settingsControl.checkBoxVobInsertHierarchy.Checked = vobInsertHierarchy;
            SpacerNET.settingsControl.checkBoxSelectMoveInsert.Checked = selectMove;
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
            Imports.Extern_PlayHero();
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
            MessageBox.Show("Spacer.NET (version " + Constants.SPACER_VERSION + ") by Liker, 2020-2022", Localizator.Get("MENU_TOP_ABOUT"));
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

        private void toolStripSeparator6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemMergeMesh_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = Constants.FILE_FILTER_OPEN_MESH;

            Imports.Stack_PushString("meshPath");
            Imports.Extern_GetSettingStr();
            string path = Utils.FixPath(Imports.Stack_PeekString());

            openFileDialog.InitialDirectory = Utils.GetInitialDirectory(path);

            openFileDialog.RestoreDirectory = true;
            openFileDialog.FileName = String.Empty;
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {


                string filePathCheck = openFileDialog.FileName;

                if (!Utils.IsPathWorkFolder(filePathCheck))
                {
                    MessageBox.Show(Localizator.Get("WORK_PATH_ERROR"));
                    return;
                }




                Imports.Stack_PushString(Utils.FixPath(Path.GetDirectoryName(Utils.FixPath(openFileDialog.FileName))));
                Imports.Stack_PushString("meshPath");
                Imports.Extern_SetSettingStr();


                Stopwatch sAll = new Stopwatch();
                sAll.Start();

                foreach (string filePath in openFileDialog.FileNames)
                {



                    Stopwatch s = new Stopwatch();
                    s.Start();

                    string fileNameCurrent = Path.GetFileName(filePath).ToUpper();

                    if (!fileNameCurrent.EndsWith(".3DS"))
                    {
                        continue;
                    }

                    SpacerNET.form.AddText(fileNameCurrent + " " + Localizator.Get("isLoading"));

                    currentWorldName = fileNameCurrent;

                    Imports.Stack_PushString(filePath);
                    Imports.Extern_MergeMesh();

                    s.Stop();

                    string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
                    SpacerNET.form.AddText(Localizator.Get("loadMeshTime") + " (" + timeSpend + ")");
                }

                sAll.Stop();

                string timeSpendAll = string.Format("{0:HH:mm:ss.fff}", new DateTime(sAll.Elapsed.Ticks));
                SpacerNET.form.AddText("==============");
                SpacerNET.form.AddText(Localizator.Get("loadMeshTimeAll") + " (" + timeSpendAll + ")", Color.Green);

                Imports.Stack_PushString("CS_IAI_ME_ME");
                Imports.Extern_PlaySound();

            }

            openFileDialog.Multiselect = false;
        }

        private void pfxEditorToolStrip_Click(object sender, EventArgs e)
        {
            SpacerNET.pfxWin.Show();
            SpacerNET.pfxWin.LoadAllPfx();
        }

    

        private void freezeTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            item.Checked = !item.Checked;

            Imports.Stack_PushString("holdTime");
            Imports.Extern_SetSetting(Convert.ToInt32(item.Checked));

            Imports.Extern_FreezeTime(Convert.ToInt32(item.Checked));
        }

        public void UncheckRenderMode()
        {
            for (int i = 0; i < renderModeToolStripMenuItem.DropDownItems.Count; i++)
            {
                var element = renderModeToolStripMenuItem.DropDownItems[i] as ToolStripMenuItem;

                if (element != null)
                {
                    element.Checked = false;
                }

            }
        }
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;


            UncheckRenderMode();
            item.Checked = true;
            Imports.Extern_SetRenderMode(0);
        }

        private void mATERIALWIREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            UncheckRenderMode();
            item.Checked = true;
            Imports.Extern_SetRenderMode(1);
        }

        private void fLATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            UncheckRenderMode();
            item.Checked = true;
            Imports.Extern_SetRenderMode(2);
        }

        private void wIREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            UncheckRenderMode();
            item.Checked = true;
            Imports.Extern_SetRenderMode(3);
        }

        private void toolStripButtonMaterial_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            Imports.Stack_PushString("bToggleWorkMode");


            if (item.Checked)
            {
                toolStripButtonGrass.Checked = false;
                toolStripButtonMulti.Checked = false;
            }



            int mode = item.Checked ? 1 : 0;
            Imports.Extern_SetSetting(mode);
        }

        private void toolStripButtonGrass_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            int mode = item.Checked ? 2 : 0;


            if (item.Checked)
            {
                SpacerNET.grassWin.Show();

                toolStripButtonMaterial.Checked = false;
                toolStripButtonMulti.Checked = false;
            }
            else
            {
                SpacerNET.grassWin.Hide();
            }

            (toolStripTop.Items[16] as ToolStripButton).Checked = false;

            Imports.Stack_PushString("bToggleWorkMode");
            Imports.Extern_SetSetting(mode);
        }

        private void toolStripButtonGratt_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            Imports.Stack_PushString("bToggleNewController");
            Imports.Extern_SetSetting(Convert.ToInt32(item.Checked));
        }

        private void saveUncZenToolStrip_Click(object sender, EventArgs e)
        {
            if (currentWorldName.Length == 0)
            {
                return;
            }

            saveFileDialog.Filter = Constants.FILE_FILTER_SAVE_ZEN_UNC;


            Imports.Stack_PushString("zenzPath");
            Imports.Extern_GetSettingStr();
            string path = Utils.FixPath(Imports.Stack_PeekString());

            saveFileDialog.InitialDirectory = Utils.GetInitialDirectory(path);
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FilterIndex = 0;
            //Console.WriteLine(openFileDialog1.InitialDirectory);

            if (currentWorldName.Contains("_VOBS_"))
            {
                currentWorldName = currentWorldName.Replace("_VOBS_", "");
            }

            string zenName = Utils.GetZenName(currentWorldName);


            //Path.GetFileName(currentWorldName.Replace(".zen", "").Replace(".ZEN", ""));

            //zenName = Utils.CorrectZenName(zenName);
            saveFileDialog.FileName = "_VOBS_" + zenName;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                Imports.Stack_PushString(Utils.FixPath(Path.GetDirectoryName(Utils.FixPath(saveFileDialog.FileName))));
                Imports.Stack_PushString("zenzPath");
                Imports.Extern_SetSettingStr();


                Imports.Stack_PushString(Utils.FixPath((saveFileDialog.FileName)));
                Imports.Stack_PushString("openLastZenPath");
                Imports.Extern_SetSettingStr();

                string filePath = saveFileDialog.FileName;
                string selectedFileName = Path.GetFileName(saveFileDialog.FileName);

                Stopwatch s = new Stopwatch();
                s.Start();


                // ConsoleEx.WriteLineGreen(selectedFileName + " " + Localizator.Get("IS_SAVING"));
                SpacerNET.form.AddText(selectedFileName + " " + Localizator.Get("IS_SAVING"));

                Imports.Stack_PushString(filePath);
                Imports.Stack_PushInt(1); // опция сортировки поликов, здесь 1 для общности
                Imports.Extern_SaveWorld(1);

                s.Stop();

                string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
                SpacerNET.form.AddText(Localizator.Get("saveZenTime") + " (" + timeSpend + ")", Color.Green);
                ConsoleEx.WriteLineGreen(Localizator.Get("saveZenTime") + " (" + timeSpend + ")");

            }
        }

        private void toolStripButtonMulti_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;

            item.Checked = !item.Checked;

            int mode = item.Checked ? 3 : 0;

            if (item.Checked)
            {
                toolStripButtonMaterial.Checked = false;
                toolStripButtonGrass.Checked = false;
            }



            Imports.Stack_PushString("bToggleWorkMode");
            Imports.Extern_SetSetting(mode);
        }

        private void toolStripMenuExtractMesh_Click(object sender, EventArgs e)
        {
            if (currentWorldName.Length == 0)
            {
                return;
            }

            saveFileDialog.Filter = Constants.FILE_FILTER_SAVE_ONLY_MESH;


            Imports.Stack_PushString("meshPath");
            Imports.Extern_GetSettingStr();
            string path = Utils.FixPath(Imports.Stack_PeekString());

            saveFileDialog.InitialDirectory = Utils.GetInitialDirectory(path);
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FilterIndex = 0;

            string zenName = Utils.GetZenName(currentWorldName);

            //ConsoleEx.WriteLineRed(zenName);
            zenName = zenName.Replace(".ZEN", ".MSH");

            saveFileDialog.FileName = zenName;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                string filePath = saveFileDialog.FileName;
                string selectedFileName = Path.GetFileName(saveFileDialog.FileName);

                Stopwatch s = new Stopwatch();
                s.Start();


                // ConsoleEx.WriteLineGreen(selectedFileName + " " + Localizator.Get("IS_SAVING"));
                SpacerNET.form.AddText(selectedFileName + " " + Localizator.Get("IS_SAVING"));

                Imports.Stack_PushString(filePath);

                Imports.Extern_SaveMesh();

                s.Stop();

                string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
                SpacerNET.form.AddText(Localizator.Get("saveMeshTime") + " (" + timeSpend + ")", Color.Green);
                ConsoleEx.WriteLineGreen(Localizator.Get("saveMeshTime") + " (" + timeSpend + ")");

            }
        }

        private void testCoordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ConsoleEx.WriteLineRed("objTreeWin.Location: " + SpacerNET.objTreeWin.Location);
            ConsoleEx.WriteLineRed("objectsWin.Location: " + SpacerNET.objectsWin.Location);
            ConsoleEx.WriteLineRed("vobList.Location: " + SpacerNET.vobList.Location);
            ConsoleEx.WriteLineRed("infoWin.Location: " + SpacerNET.infoWin.Location);
            ConsoleEx.WriteLineRed("propWin.Location: " + SpacerNET.propWin.Location);
            ConsoleEx.WriteLineRed("grassWin.Location: " + SpacerNET.grassWin.Location);
        }

        private void resetWinPos_Click(object sender, EventArgs e)
        {

            

            
        }

        private void сброситьПоложениЕоконToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(Localizator.Get("askSure"), Localizator.Get("confirmation"), MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (res == DialogResult.OK)
            {

                SpacerNET.objTreeWin.Location = new Point(0, 300);
                SpacerNET.objectsWin.Location = new Point(0, 300);
                SpacerNET.vobList.Location = new Point(0, 300);
                SpacerNET.infoWin.Location = new Point(0, 300);
                SpacerNET.propWin.Location = new Point(0, 300);
                SpacerNET.grassWin.Location = new Point(0, 300);
            }
        }

        private void preset1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(Localizator.Get("askSure"), Localizator.Get("confirmation"), MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


            if (res == DialogResult.OK)
            {
               

                


                SpacerNET.objTreeWin.Show();
                SpacerNET.objectsWin.Show();
                SpacerNET.vobList.Show();
                SpacerNET.infoWin.Show();
                SpacerNET.propWin.Show();

                SpacerNET.objTreeWin.Location = new Point(1510, 550);
                SpacerNET.objectsWin.Location = new Point(0, 622);
                SpacerNET.vobList.Location = new Point(570, 670);
                SpacerNET.infoWin.Location = new Point(890, 655);
                SpacerNET.propWin.Location = new Point(1572, 28);
                SpacerNET.grassWin.Location = new Point(1079, 603);


            }
        }

        private void stripSpecialFormVobsVisuals_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "HTML file (*.html)|*.html|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = "./";
            saveFileDialog1.FileName = "LOCATION_VOBS_VISUALS_FILES.html";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(saveFileDialog1.FileName);

                Imports.Stack_PushString(path);

                Imports.Extern_SaveVobVisualsUnique();

            }
        }

        private void toolStripButtonNoGrass_Click(object sender, EventArgs e)
        {
            Imports.Extern_ToggleNoGrass();
            ToolStripButton btn = sender as ToolStripButton;

            btn.Checked = !btn.Checked;
        }
    }
}
