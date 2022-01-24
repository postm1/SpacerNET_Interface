﻿
using SpacerUnion.Common;
using System;
using System.Collections;
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
using System.Windows.Forms;
using static SpacerUnion.ObjTree;

namespace SpacerUnion
{
    

    public partial class ObjectsWin : Form
    {
        public static List<string> listVisualsVDF = new List<string>();
        public static List<string> listVisualsWORK = new List<string>();
        public TriggerEntry triggerEntry = new TriggerEntry();
        public CameraKeyEntry camEntry = new CameraKeyEntry();


        static List<CProperty> searchProps = new List<CProperty>();
        static List<CProperty> compareProps = new List<CProperty>();
        static List<CProperty> newProps = new List<CProperty>();
        static List<CProperty> convertProps = new List<CProperty>();
        static int selectTabBlocked = 0;

        public ObjectsWin()
        {
            InitializeComponent();
            comboBoxSearchType.SelectedIndex = 0;
        }


        public void UpdateLang()
        {
            this.Text = Localizator.Get("WIN_OBJ_TITLE");
            tabControlObjects.TabPages[0].Text = Localizator.Get("WIN_OBJ_TAB0");
            tabControlObjects.TabPages[1].Text = Localizator.Get("WIN_OBJ_TAB1");
            tabControlObjects.TabPages[2].Text = Localizator.Get("WIN_OBJ_TAB2");
            tabControlObjects.TabPages[3].Text = Localizator.Get("WIN_OBJ_TAB3");
            tabControlObjects.TabPages[4].Text = Localizator.Get("WIN_OBJ_TAB4");
            tabControlObjects.TabPages[5].Text = Localizator.Get("WIN_OBJ_TAB5");
            tabControlObjects.TabPages[6].Text = Localizator.Get("WIN_OBJ_TAB6");
            tabControlObjects.TabPages[7].Text = Localizator.Get("WIN_OBJ_TAB7");

            groupBoxObjAllClasses.Text = Localizator.Get("groupBoxObjAllClasses");
            groupBoxObjPropVobs.Text = Localizator.Get("groupBoxObjPropVobs");
            labelObjAllClassesNameVob.Text = Localizator.Get("labelObjAllClassesNameVob");
            buttonAllClassesCreateVob.Text = Localizator.Get("buttonAllClassesCreateVob");
            checkBoxDynStat.Text = Localizator.Get("checkBoxDynStat");
            checkBoxStaStat.Text = Localizator.Get("checkBoxStaStat");
            labelAllModels.Text = Localizator.Get("WIN_OBJ_ALLMODELS");
            labelSearchVisual.Text = Localizator.Get("WIN_OBJ_ALLMODELS");
            checkBoxShowPreview.Text = Localizator.Get("checkBoxShowPreview");
            checkBoxSearchOnly3DS.Text = Localizator.Get("checkBoxSearchOnly3DS");
            buttonAllClassesClear.Text = Localizator.Get("buttonAllClassesClear");

            groupBoxObjItems.Text = Localizator.Get("groupBoxObjItems");
            buttonItemsCreate.Text = Localizator.Get("buttonItemsCreate");
            buttonItemsCreateReg.Text = Localizator.Get("buttonItemsCreate");
            buttonAddContainer.Text = Localizator.Get("buttonAddContainer");
            groupBoxItemsCont.Text = Localizator.Get("groupBoxItemsCont");
            checkBoxItemShow.Text = Localizator.Get("checkBoxItemShow");
            labelItemsEditContCount.Text = Localizator.Get("labelItemsEditContCount");
            labelItemsAllItems.Text = Localizator.Get("labelItemsAllItems");
            labelItemsFindReg.Text = Localizator.Get("labelItemsFindReg");

            groupBoxPFX.Text = Localizator.Get("groupBoxPFX");
            buttonParticles.Text = Localizator.Get("buttonParticles");
            buttonCreatePFXReg.Text = Localizator.Get("buttonParticles");
            checkBoxShowPFXPreview.Text = Localizator.Get("checkBoxShowPFXPreview");
            labelAllPfx.Text = Localizator.Get("labelAllPfx");
            labelSearchRegPFx.Text = Localizator.Get("labelItemsFindReg");



            groupBoxTriggersVob.Text = Localizator.Get("groupBoxTriggersVob");
            groupBoxTriggersKeys.Text = Localizator.Get("groupBoxTriggersKeys");
            buttonSendTrigger.Text = Localizator.Get("buttonSendTrigger");
            buttonTriggerCollectSources.Text = Localizator.Get("buttonTriggerCollectSources");
            buttonNewKey.Text = Localizator.Get("buttonNewKey");
            buttonRemoveKey.Text = Localizator.Get("buttonRemoveKey");
            labelTriggerName.Text = Localizator.Get("labelTriggerName");
            labelTriggerCollision.Text = Localizator.Get("labelTriggerCollision");
            checkBoxDyn.Text = Localizator.Get("checkBoxDyn");
            checkBoxStat.Text = Localizator.Get("checkBoxStat");
            radioButtonOverwrite.Text = Localizator.Get("radioButtonOverwrite");
            labelTriggerInsert.Text = Localizator.Get("labelTriggerInsert");
            radioButtonAfter.Text = Localizator.Get("radioButtonAfter");
            radioButtonBefore.Text = Localizator.Get("radioButtonBefore");
            labelTriggerTargets.Text = Localizator.Get("labelTriggerTargets");
            labelTriggersSources.Text = Localizator.Get("labelTriggersSources");



            groupBoxWPFP.Text = Localizator.Get("groupBoxWPFP");
            labelNameWPMandatory.Text = Localizator.Get("labelNameWPMandatory");
            labelFreepointMandatory.Text = Localizator.Get("labelFreepointMandatory");
            checkBoxWayNet.Text = Localizator.Get("checkBoxWayNet");
            checkBoxWPAutoName.Text = Localizator.Get("checkBoxWPAutoName");
            checkBoxFPGround.Text = Localizator.Get("checkBoxFPGround");
            checkBoxAutoNameFP.Text = Localizator.Get("checkBoxAutoNameFP");
            buttonWPCreate.Text = Localizator.Get("buttonWPCreate");
            buttonConnectWp.Text = Localizator.Get("buttonConnectWp");
            buttonDisconnectWP.Text = Localizator.Get("buttonDisconnectWP");
            buttonFPCreate.Text = Localizator.Get("buttonFPCreate");



            //labelNotReady0.Text = Localizator.Get("TEST_NOT_READY");
            labelNotReady1.Text = Localizator.Get("TEST_NOT_READY");
            labelNotReady2.Text = Localizator.Get("TEST_NOT_READY");


            groupBoxSearchClasses.Text = Localizator.Get("all_vobs_classes");
            checkBoxSearchDerived.Text = Localizator.Get("search_derived");
            checkBoxSearchUseRegex.Text = Localizator.Get("search_use_regex");
            buttonSearchVobsDo.Text = Localizator.Get("VOB_SEARCH_TYPE0");
            buttonSearchVobsReset.Text = Localizator.Get("BTN_RESET");

            labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ":";


            comboBoxSearchType.Items.Clear();
            comboBoxSearchType.Items.Add(Localizator.Get("VOB_SEARCH_TYPE0"));
            comboBoxSearchType.Items.Add(Localizator.Get("VOB_SEARCH_TYPE1"));
            comboBoxSearchType.Items.Add(Localizator.Get("VOB_SEARCH_TYPE2"));
            comboBoxSearchType.Items.Add(Localizator.Get("VOB_SEARCH_TYPE3"));
            comboBoxSearchType.Items.Add(Localizator.Get("VOB_SEARCH_TYPE_DYNAMIC"));
            comboBoxSearchType.SelectedIndex = 0;

            radioButtonConvertOld.Text = Localizator.Get("VOB_SEARCH_CONVERT_RADIO0");
            radioButtonConvertNew.Text = Localizator.Get("VOB_SEARCH_CONVERT_RADIO1");

            labelRenameVob.Text = Localizator.Get("labelRenameVob");

            
        }


        [DllExport]
        public static void AddPacticleToList()
        {
            string name = Imports.Stack_PeekString();

            SpacerNET.objectsWin.listBoxParticles.Items.Add(name);
        }

        public static HashSet<string> ignoreFileNameSet = new HashSet<string>()
        {
            ".WAV", ".DAT", ".D", ".FNT", ".BIN", ".ZEN", ".M3D", ".BMP", ".SGT",
            ".DLI", ".DLS", ".STY", ".PML", ".TXT", ".DLE", ".MI", ".DDS",
            ".TEX", ".FNT", ".DAT", ".MRM", ".ZEN", ".BIN", ".MDM", ".MAN", ".MDH", ".MSB", ".MAN1", ".MMB", ".WAV", ".MDL",
            ".DLL", ".M3D", ".BMP", ".MSH", ".MMS", ".TGA", ".MDS", ".SCC", ".3DS", ".SGT", ".DLS", ".STY", ".RAR", ".D",
            ".CSL", ".LSC", ".SRC", ".INF", ".INI", ".BAK", ".BIK", ".GSP", ".FBX", "", ".LNK", ".EXE", ".MOD", ".NSH",
            ".RTF", ".BAT", ".NSI", ".VM", ".PML", ".OPF", ".CONFIG", ".XML", ".ZMF", ".DLE", ".TXT", ".DLI", ".CFG",
            ".LOG", ".DLL2", ".EXP", ".IOBJ", ".IPDB", ".LIB", ".PDB", ".LAST", ".MTL", ".OBJ", ".PNG", ".MCACHE",
            ".VI", ".H", ".HLSL", ".FX", ".FXH", ".DDS", ".MI", ".JPG", ".MANIFEST", ".FLT", ".RPT", ".TLB",
            ".PATCH", ".SAV", ".BMP$",

            // ".TEX", ".MRM", ".MDM", ".MAN", ".MDH", ".MSB", ".MMB", ".MDL", ".MSH", ".MMS", ".MDS"
        };

        public static Dictionary<string, string> allowedFileNames = new Dictionary<string, string>
        {      
            //  1        1                              1               1                        1
            //".TEX", ".MRM", ".MDM", ".MAN", ".MDH", ".MSB", ".MMB", ".MDL", ".MSH", ".MMS", ".MDS"
            
            {".TGA", ".TGA" },
            {"-C.TEX", ".TGA" },

            {".3DS", ".3DS" },
            {".MRM", ".3DS" },
            {".MSH ", ".3DS" },

            {".ASC", ".ASC" },
            {".MDL", ".ASC" },
            //{".MAN", ".ASC" },
            {".MDH", ".ASC" },


            {".MDS", ".MDS" },
            {".MSB", ".MDS" },
            {".MBH", ".MMS" },



        };

        public static bool IsFileAllowed(StringBuilder name)
        {
            string checkStr = name.ToString();

            foreach (var item in allowedFileNames)
            {
                if (checkStr.EndsWith(item.Key))
                {
                    name = name.Replace(item.Key, item.Value);
                    return true;
                }
            }

            return false;
        }

        public static void AddVisualsFiles(string name, bool isVDF=true)
        {
            StringBuilder fileName = new StringBuilder();

            fileName.Append(name);

            if (IsFileAllowed(fileName))
            {
                if (isVDF)
                {
                    ObjectsWin.listVisualsVDF.Add(fileName.ToString());
                }
                else
                {
                    ObjectsWin.listVisualsWORK.Add(fileName.ToString());
                }
            }

            
        }

        [DllExport]
        public static void AddVisualToListVDF()
        {
            string name = Imports.Stack_PeekString();

            AddVisualsFiles(Path.GetFileName(name).ToUpper());
 
        }

        [DllExport]
        public static void AddVisualToListWORK()
        {
            string name = Imports.Stack_PeekString();

            AddVisualsFiles(Path.GetFileName(name).ToUpper(), false);
        }



        [DllExport]
        public static void SortVisuals()
        {
            ObjectsWin.listVisualsVDF = ObjectsWin.listVisualsVDF.Distinct().ToList();
            ObjectsWin.listVisualsVDF.Sort();


            ObjectsWin.listVisualsWORK = ObjectsWin.listVisualsWORK.Distinct().ToList();
            ObjectsWin.listVisualsWORK.Sort();


            
            //UnionNET.partWin.labelSearchVisual.Text = "Поиск визуала. Всего: " + listVisualsVDF.Count + "/" + listVisualsWORK.Count;
            SpacerNET.objectsWin.labelAllModels.Text = Localizator.Get("WIN_OBJ_ALLMODELS") + ": " + listVisualsVDF.Count + "/" + listVisualsWORK.Count;
        }


        [DllExport]
        public static void SortPFX()
        {
            //UnionNET.partWin.listBoxParticles.Sorted = true;
            ListBox lstBox = SpacerNET.objectsWin.listBoxParticles;
            Utils.SortListBox(lstBox);

            SpacerNET.objectsWin.groupBoxPFX.Text += ", " + Localizator.Get("WIN_OBJ_ALL") 
                + ": " + SpacerNET.objectsWin.listBoxParticles.Items.Count;
        }

        [DllExport]
        public static void AddItemToList()
        {
            ListBox listBox = SpacerNET.objectsWin.listBoxItems;
            string name = Imports.Stack_PeekString();

            int index = listBox.Items.Add(name);
        }

        [DllExport]
        public static void SortItems()
        {
            //UnionNET.partWin.listBoxItems.Sorted = true;
            Utils.SortListBox(SpacerNET.objectsWin.listBoxItems);

            SpacerNET.objectsWin.groupBoxObjItems.Text += ", " + Localizator.Get("WIN_OBJ_ALL") 
                + ": " + SpacerNET.objectsWin.listBoxItems.Items.Count;
        }

        private void ParticleWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }


        

        private void buttonItems_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem == null)
            {
                return;
            }
            string name = listBoxItems.GetItemText(listBoxItems.SelectedItem);

            //Console.WriteLine("Create item: " + name);


            //SpacerNET.infoWin.AddText("Создаю Item " + name);

            Imports.Extern_KillPreviewItem();

       
            Imports.Stack_PushString(name);
            Imports.Extern_CreateItem();

            SpacerNET.form.Focus();

            

        }

        private void textBoxItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string strToFind = textBoxItems.Text.Trim().ToUpper();

                Regex regEx = null;

                try
                {
                    regEx = new Regex(@strToFind, RegexOptions.IgnoreCase | RegexOptions.Compiled);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show(Localizator.Get("BAD_REGEX"));
                    return;
                }


                listBoxResultItems.Items.Clear();


                for (int i = 0; i < listBoxItems.Items.Count; i++)
                {
                    string value = listBoxItems.GetItemText(listBoxItems.Items[i]);

                    if (Regex.IsMatch(value, @strToFind))
                    {
                        listBoxResultItems.Items.Add(value);
                    }
                }
            }
        }

        private void textBoxItems_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBoxItems_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonParticles_Click(object sender, EventArgs e)
        {
            if (listBoxParticles.SelectedItem == null)
            {
                return;
            }
            string name = listBoxParticles.GetItemText(listBoxParticles.SelectedItem);


            //SpacerNET.infoWin.AddText("Создаю PFX " + name);


            Imports.Stack_PushString(name);
            Imports.Extern_CreatePFX();
            Imports.Extern_KillPFX();   

            SpacerNET.form.Focus();
        }

        static int deep = 0;

        public static void FindClass(TreeNodeCollection nodes, string name, ZenGinClass entry)
        {
            

            if (entry.parentName == String.Empty)
            {
                TreeNode newNode = nodes.Add(name + entry.postFix);
                newNode.Tag = entry;
                SpacerNET.objectsWin.comboBoxSearchClass.Items.Add(name);
                return;
            }

            deep++;

            for (int i = 0; i < nodes.Count; i++)
            {
                ZenGinClass objNode = nodes[i].Tag as ZenGinClass;

                if (objNode != null)
                {
                    if (objNode.name == entry.parentName)
                    {
                        TreeNode newNode = nodes[i].Nodes.Add(name + entry.postFix);
                        newNode.Tag = entry;

                        if (name != "oCNpc")
                        {
                            SpacerNET.objectsWin.comboBoxSearchClass.Items.Add(new String('.', deep * 2) + name);
                        }
                       
                    }
                }
                
                FindClass(nodes[i].Nodes, entry.name, entry);
               
            }
            deep--;


        }

        public class ZenGinClass
        {
            public string name;
            public string parentName;
            public string postFix;
            public TreeNode node;
        };


        static Dictionary<string, ZenGinClass> classesList = new Dictionary<string, ZenGinClass>();

        [DllExport]
        public static void FillClassNodes()
        {
            TreeNodeCollection nodes = SpacerNET.objectsWin.classesTreeView.Nodes;

            foreach (var entry in classesList)
            {
                FindClass(nodes, entry.Key, entry.Value);
            }

            SpacerNET.objectsWin.classesTreeView.ExpandAll();
            SpacerNET.objectsWin.classesTreeView.SelectedNode = SpacerNET.objectsWin.classesTreeView.Nodes[0];
            SpacerNET.objectsWin.classesTreeView.SelectedNode.EnsureVisible();
            SpacerNET.objectsWin.comboBoxSearchClass.SelectedIndex = 0;
        }

        [DllExport]
        public static void AddClassNode()
        {
            string postFixName = Imports.Stack_PeekString();
            string name = Imports.Stack_PeekString();
            string baseClassName = Imports.Stack_PeekString();
            


            classesList.Add(name, new ZenGinClass()
            {
                name = name,
                parentName = baseClassName,
                postFix = postFixName
            }
            );


           

            // ConsoleEx.WriteLineGreen(String.Format("prefixName: {0}, name: {1}, baseClassName: {2}", postFixName, name, baseClassName));

            return;
            /*

            if (name == baseClassName)
            {
                TreeNode node = nodes.Add(prefixName);
                node.Tag = name.ToString();
                return;
            }

            FindClass(nodes, prefixName, name);

            SpacerNET.objectsWin.comboBoxSearchClass.Items.Add(name);
            SpacerNET.objectsWin.comboBoxSearchClass.SelectedIndex = 0;

            SpacerNET.objectsWin.classesTreeView.ExpandAll();
            SpacerNET.objectsWin.classesTreeView.SelectedNode = SpacerNET.objectsWin.classesTreeView.Nodes[0];
            SpacerNET.objectsWin.classesTreeView.SelectedNode.EnsureVisible();
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (classesTreeView.SelectedNode == null)
            {
                return;
            }

            ZenGinClass entry = classesTreeView.SelectedNode.Tag as ZenGinClass;

            if (entry == null)
            {
                return;
            }


            string name = entry.name;
            string vobName = textBoxVobName.Text.Trim();
            string visualVob = "";
            int isDyn = Convert.ToInt32(checkBoxDynStat.Checked);
            int isStat = Convert.ToInt32(checkBoxStaStat.Checked);


            if (listBoxVisuals.SelectedItem != null)
            {
                visualVob = listBoxVisuals.GetItemText(listBoxVisuals.SelectedItem);
            }

            ConsoleEx.WriteLineGreen("OnCreateVob: ClassDef: " + name);

            if (name == "oCItem" || name == "zCVobWaypoint" || name == "zCVobSpot")
            {
                MessageBox.Show(Localizator.Get("WIN_OBJ_TYPE_CANTHERE"));
                return;
            }

            textBoxVobName.Text = "";


            Imports.Stack_PushString(visualVob);
            Imports.Stack_PushString(vobName);
            Imports.Stack_PushString(name);
            Imports.Extern_CreateNewVobVisual(isDyn, isStat);

            

        }

        private void classesTreeView_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (e.Node == null) return;

            // if treeview's HideSelection property is "True", 
            // this will always returns "False" on unfocused treeview
            var selected = (e.State & TreeNodeStates.Selected) == TreeNodeStates.Selected;
            var unfocused = !e.Node.TreeView.Focused;

            // we need to do owner drawing only on a selected node
            // and when the treeview is unfocused, else let the OS do it for us
            if (selected && unfocused)
            {
                var font = e.Node.NodeFont ?? e.Node.TreeView.Font;
                e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.Node.Text, font, e.Bounds, SystemColors.HighlightText, TextFormatFlags.GlyphOverhangPadding);
            }
            else
            {
                e.DrawDefault = true;
            }
        }

        private void buttonFP_Click(object sender, EventArgs e)
        {

            
        }

        [DllExport]
        public static void HotKey_AddWaypoint()
        {
            SpacerNET.objectsWin.buttonWPCreate.PerformClick();
        }

        private void buttonWP_Click(object sender, EventArgs e)
        {
            string name = "zCVobWaypoint";
            string vobName = textBoxWP.Text.Trim();
            bool addToNet = checkBoxWayNet.Checked;
            bool autoGenerate = checkBoxWPAutoName.Checked;

            if (vobName.Length == 0)
            {
                MessageBox.Show(Localizator.Get("WIN_OBJ_NO_EMPTY_NAME"));
                return;
            }

            if (vobName.All(char.IsDigit))
            {
                MessageBox.Show(Localizator.Get("WIN_OBJ_NO_WAYPOINT_NUMBERSONLY"));
                return;
            }
            

            Imports.Stack_PushString(vobName);
            int nameFound = Imports.Extern_VobNameExist(true);

            if (nameFound == 1 && !autoGenerate)
            {
                MessageBox.Show(Localizator.Get("NAME_ALREADY_EXISTS"));
                
                return;
            }


            ConsoleEx.WriteLineGreen("OnCreateVob: ClassDef: " + name);


            Imports.Stack_PushString(vobName);
            Imports.Stack_PushString(name);

            Imports.Extern_CreateWaypoint(addToNet, autoGenerate);

            SpacerNET.form.Focus();
            /*
            if (vobName.Contains("_"))
            {
                string strNumber = Regex.Match(vobName, @"_\d+$").Value.Replace("_", "");
                string strName = Regex.Match(vobName, @"^.*_").Value.Replace("_", "");

                int number;
                int.TryParse(strNumber, out number);
                number++;
                textBoxWP.Text = strName + "_" + number.ToString();
            }
            */
        }

        private void buttonFP_Click_1(object sender, EventArgs e)
        {
            string name = "zCVobSpot";

            string vobName = textBoxFP.Text.Trim();
            bool autoName = checkBoxAutoNameFP.Checked;
            bool ground = checkBoxFPGround.Checked;

            if (vobName.Length == 0)
            {
                MessageBox.Show(Localizator.Get("WIN_OBJ_NO_EMPTY_NAME"));
                return;
            }

            Imports.Stack_PushString(vobName);

            int nameFound = Imports.Extern_VobNameExist(false);
            if (nameFound == 1)
            {
                
                MessageBox.Show(Localizator.Get("NAME_ALREADY_EXISTS"));
                return;
            }

            ConsoleEx.WriteLineGreen("OnCreateVob: ClassDef: " + name);


            Imports.Stack_PushString(vobName);
            Imports.Stack_PushString(name);

            Imports.Extern_CreateFreePoint(autoName, ground);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Imports.Extern_ConnectWP();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Imports.Extern_DisconnectWP();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBoxResultItems.SelectedItem == null)
            {
                return;
            }

            string name = listBoxResultItems.GetItemText(listBoxResultItems.SelectedItem);

            //Console.WriteLine("Create item: " + name);


            //SpacerNET.infoWin.AddText("Создаю Item " + name);
            Imports.Extern_KillPreviewItem();
            Imports.Stack_PushString(name);
            Imports.Extern_CreateItem();

            SpacerNET.form.Focus();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPfxReg_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBoxPfxResult.SelectedItem == null)
            {
                return;
            }
            string name = listBoxParticles.GetItemText(listBoxPfxResult.SelectedItem);


            //SpacerNET.infoWin.AddText("Создаю PFX " + name);

            Imports.Stack_PushString(name);
            Imports.Extern_CreatePFX();
            Imports.Extern_KillPFX();

            SpacerNET.form.Focus();
        }

        private void textBoxPfxReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string strToFind = textBoxPfxReg.Text.Trim().ToUpper();


                Regex regEx = null;

                try
                {
                    regEx = new Regex(@strToFind, RegexOptions.IgnoreCase | RegexOptions.Compiled);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show(Localizator.Get("BAD_REGEX"));
                    return;
                }



                listBoxPfxResult.Items.Clear();



                for (int i = 0; i < listBoxParticles.Items.Count; i++)
                {
                    string value = listBoxParticles.GetItemText(listBoxParticles.Items[i]);

                    if (Regex.IsMatch(value, @strToFind))
                    {
                        listBoxPfxResult.Items.Add(value);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void textBoxVisuals_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string strToFind = textBoxVisuals.Text.Trim().ToUpper();

                if (checkBoxSearchOnly3DS.Checked)
                {
                    strToFind += ".*3DS";
                }

                Regex regEx = null;

                try
                {
                    regEx = new Regex(@strToFind, RegexOptions.IgnoreCase | RegexOptions.Compiled);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show(Localizator.Get("BAD_REGEX"));
                    return;
                }


                listBoxVisuals.Items.Clear();

                if (radioButtonVdf.Checked)
                {
                    for (int i = 0; i < listVisualsVDF.Count; i++)
                    {
                        if (regEx.IsMatch(listVisualsVDF[i]))
                        {
                            listBoxVisuals.Items.Add(listVisualsVDF[i]);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < listVisualsWORK.Count; i++)
                    {
                        if (regEx.IsMatch(listVisualsWORK[i]))
                        {
                            listBoxVisuals.Items.Add(listVisualsWORK[i]);
                        }
                    }
                }


                SpacerNET.objectsWin.labelSearchVisual.Text = Localizator.Get("WIN_OBJ_SEARCHVISUAL_ALL") + ": " + listBoxVisuals.Items.Count;


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBoxVisuals.Items.Clear();
            listBoxVisuals.ClearSelected();
            textBoxVisuals.Clear();

            SpacerNET.objectsWin.labelSearchVisual.Text = Localizator.Get("WIN_OBJ_ALLMODELS");

            string visual = "";
 

            Imports.Stack_PushString(visual);
            Imports.Extern_RenderSelectedVob();
            

        }

        private void checkBoxDyn_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            triggerEntry.dynColl = cb.Checked;

            ObjectsWindow.ChangeProp("cdDyn", Convert.ToInt32(triggerEntry.dynColl).ToString());


            Imports.Extern_SetCollTrigger(0, Convert.ToInt32(triggerEntry.dynColl));
        }

        private void checkBoxStat_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            triggerEntry.statColl = cb.Checked;

            ObjectsWindow.ChangeProp("cdStatic", Convert.ToInt32(triggerEntry.statColl).ToString());

            Imports.Extern_SetCollTrigger(1, Convert.ToInt32(triggerEntry.statColl));
        }

        private void listBoxActionType_SelectedIndexChanged(object sender, EventArgs e)
        {

            string name = listBoxActionType.GetItemText(listBoxActionType.SelectedItem);
            triggerEntry.currentActionIndex = listBoxActionType.SelectedIndex;
        }

        private void buttonKeyMinus_Click(object sender, EventArgs e)
        {
            if (triggerEntry.m_kf_pos >= 1)
            {
                triggerEntry.m_kf_pos--;

                Imports.Extern_SetToKeyPos(triggerEntry.m_kf_pos);
                UpdateCurrentKeyLabel();
            }


        }


        private void UpdateCurrentKeyLabel()
        {
            int keyMax = triggerEntry.maxKey - 1;

            if (keyMax < 0) keyMax = 0;


            labelCurrentKey.Text = triggerEntry.m_kf_pos.ToString() + "/" + keyMax.ToString();
        }

        private void buttonKeyPlus_Click(object sender, EventArgs e)
        {
            if (triggerEntry.m_kf_pos + 1 < triggerEntry.maxKey)
            {
                triggerEntry.m_kf_pos++;
                Imports.Extern_SetToKeyPos(triggerEntry.m_kf_pos);
                UpdateCurrentKeyLabel();
            }



        }


        public void UpdateTriggerWindow(bool block=true)
        {
            labelTriggerName.Text = triggerEntry.name;
            UpdateCurrentKeyLabel();
            checkBoxDyn.Checked = triggerEntry.dynColl;
            checkBoxStat.Checked = triggerEntry.statColl;

            if (listBoxActionType.SelectedItem == null)
            {
                //listBoxActionType.SelectedIndex = 0;
            }

            if (block)
            {
                buttonRemoveKey.Enabled = false;
                buttonNewKey.Enabled = false;
                buttonKeyMinus.Enabled = false;
                buttonKeyPlus.Enabled = false;
            }
           


        }

        [DllExport]
        public static void CleanTriggerForm()
        {

            SpacerNET.objectsWin.triggerEntry.m_kf_pos = 0;
            SpacerNET.objectsWin.triggerEntry.maxKey = 0;
            SpacerNET.objectsWin.triggerEntry.name = "";
            SpacerNET.objectsWin.triggerEntry.dynColl = false;
            SpacerNET.objectsWin.triggerEntry.statColl = false;
            SpacerNET.objectsWin.listBoxTargetList.Items.Clear();
            SpacerNET.objectsWin.listBoxSources.Items.Clear();
            SpacerNET.objectsWin.listBoxActionType.Items.Clear();
            SpacerNET.objectsWin.triggerEntry.targetListAddr.Clear();
            SpacerNET.objectsWin.triggerEntry.sourcesListAddr.Clear();

            
            SpacerNET.objectsWin.UpdateTriggerWindow();

        }

        private void EnableTriggerWindow()
        {
            buttonRemoveKey.Enabled = true;
            buttonNewKey.Enabled = true;
            buttonKeyMinus.Enabled = true;
            buttonKeyPlus.Enabled = true;
        }

        public static void ChangeTab(int num)
        {
            if (selectTabBlocked > 0)
            {
                selectTabBlocked--;
                return;
            }

            SpacerNET.objectsWin.tabControlObjects.SelectedIndex = num;
        }

        [DllExport]
        public static void SelectMoversTab()
        {
           
            ChangeTab(3);
        }


        [DllExport]
        public static void AddActionTypeMover()
        {
            string value = Imports.Stack_PeekString();
            SpacerNET.objectsWin.listBoxActionType.Items.Add(value);


            if (SpacerNET.objectsWin.listBoxActionType.Items.Count > 0)
            {
                SpacerNET.objectsWin.listBoxActionType.SelectedIndex = 0;
            }
        }


        [DllExport]
        public static void AddTargetToList(uint addr)
        {
            string value = Imports.Stack_PeekString();

            SpacerNET.objectsWin.triggerEntry.targetListAddr.Add(addr);

            SpacerNET.objectsWin.listBoxTargetList.Items.Add(value);
        }

        [DllExport]
        public static void AddSourcesToList(uint addr)
        {
            string value = Imports.Stack_PeekString();
            SpacerNET.objectsWin.triggerEntry.sourcesListAddr.Add(addr);
            SpacerNET.objectsWin.listBoxSources.Items.Add(value);

            //ConsoleEx.WriteLineGreen("Add Source List: " + value);
        }

        [DllExport]
        public static void CreateTriggerForm(int keyCurrent, int keyMax, int dyn, int stat)
        {
            string name = Imports.Stack_PeekString();

            SpacerNET.objectsWin.triggerEntry.m_kf_pos = keyCurrent;
            SpacerNET.objectsWin.triggerEntry.maxKey = keyMax;
            SpacerNET.objectsWin.triggerEntry.name = name;
            SpacerNET.objectsWin.triggerEntry.dynColl = Convert.ToBoolean(dyn);
            SpacerNET.objectsWin.triggerEntry.statColl = Convert.ToBoolean(stat);
            SpacerNET.objectsWin.listBoxTargetList.Items.Clear();
            SpacerNET.objectsWin.listBoxActionType.Items.Clear();
            SpacerNET.objectsWin.triggerEntry.targetListAddr.Clear();
            SpacerNET.objectsWin.listBoxSources.Items.Clear();
            SpacerNET.objectsWin.triggerEntry.sourcesListAddr.Clear();

            SpacerNET.objectsWin.UpdateTriggerWindow();
            SpacerNET.objectsWin.EnableTriggerWindow();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            listBoxSources.Items.Clear();
            SpacerNET.objectsWin.triggerEntry.sourcesListAddr.Clear();
            Imports.Extern_CollectTriggerSources();
        }

        private void buttonRemoveKey_Click(object sender, EventArgs e)
        {
            Imports.Extern_OnKeyRemove();

            triggerEntry.m_kf_pos = Imports.Extern_GetCurrentKey();
            triggerEntry.maxKey = Imports.Extern_GetMaxKey();
            UpdateTriggerWindow(false);
        }

        private void buttonNewKey_Click(object sender, EventArgs e)
        {
            int mode = 0;


            if (radioButtonOverwrite.Checked)
            {
                mode = 2;
            }
            else
            if (radioButtonAfter.Checked)
            {
                mode = 0;
            }
            else
            if (radioButtonBefore.Checked)
            {
                mode = 1;
            }


            Imports.Extern_OnAddKey(mode);

            triggerEntry.m_kf_pos = Imports.Extern_GetCurrentKey();
            triggerEntry.maxKey = Imports.Extern_GetMaxKey();

            //ConsoleEx.WriteLineRed("CurrentKey: " + triggerEntry.m_kf_pos + "/" + triggerEntry.maxKey);
            UpdateTriggerWindow(false);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string name = listBoxActionType.GetItemText(listBoxActionType.SelectedItem);

            //ConsoleEx.WriteLineRed("Send trigger: action " + name);
            Imports.Extern_SendTrigger(triggerEntry.currentActionIndex);
            triggerEntry.m_kf_pos = Imports.Extern_GetCurrentKey();

           // UpdateTriggerWindow(false);
        }

        private void ParticleWin_Shown(object sender, EventArgs e)
        {
            //listBoxActionType.SelectedIndex = 0;

            this.treeViewSearchClass.ImageList = SpacerNET.objTreeWin.imageList1;
        }

        private void listBoxSources_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBoxSources.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                uint addr = triggerEntry.sourcesListAddr[index];

                try
                {
                    SpacerNET.objTreeWin.globalTree.SelectedNode =
                    ObjTree.globalEntries[addr].node;
                }
                catch
                {
                    Utils.Error("triggetSourcesList. Can't find vob with addr: " + Utils.ToHex(addr));
                }

                Imports.Extern_SelectVob(addr);
            }

        }

        private void listBoxTargetList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBoxTargetList.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                uint addr = triggerEntry.targetListAddr[index];

                try
                {
                    SpacerNET.objTreeWin.globalTree.SelectedNode =
                    ObjTree.globalEntries[addr].node;
                }
                catch
                {
                    ConsoleEx.WriteLineGreen("triggetTargetList. Can't find vob with addr: " + Utils.ToHex(addr));
                }

                Imports.Extern_SelectVob(addr);
            }
        }

        private void listBoxTargetList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxTargetList_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string name = "";
            string count = textBoxItemCount.Text.Trim();

            if (count == String.Empty)
            {
                count = "1";
            }

            if (listBoxResultItems.SelectedItem != null)
            {
                name = listBoxResultItems.GetItemText(listBoxResultItems.SelectedItem).Trim();


            }
            else if (listBoxItems.SelectedItem != null)
            {
                name = listBoxItems.GetItemText(listBoxItems.SelectedItem).Trim();
            }

            if (name != String.Empty)
            {
                if (SpacerNET.propWin.tabControlProps.SelectedIndex == 2 && SpacerNET.propWin.dataGridViewItems.Visible
                    && SpacerNET.propWin.buttonContainerApply.Enabled
                    )
                {
                    SpacerNET.propWin.dataGridViewItems.Rows.Add(name, count);
                }
            }
        }

        private void textBoxItemCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void listBoxVisuals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxVisuals.SelectedItem != null && checkBoxShowPreview.Checked)
            {
                string visual = listBoxVisuals.GetItemText(listBoxVisuals.SelectedItem);


                if (SpacerNET.grassWin.checkBoxGrassWinCopyName.Checked)
                {
                    SpacerNET.grassWin.textBoxGrassWinModel.Text = visual;
                    SpacerNET.grassWin.buttonGrassWinApply_Click(null, null);
                }

                Imports.Stack_PushString(visual);
                Imports.Extern_RenderSelectedVob();



                SpacerNET.form.Focus();
            }
            
        }

        private void checkBoxShowPreview_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ch = sender as CheckBox;


            Imports.Stack_PushString("showModelPreview");
            Imports.Extern_SetSetting(Convert.ToInt32(ch.Checked));


            if (!ch.Checked)
            {
                string visual = "";
  

                Imports.Stack_PushString(visual);
                Imports.Extern_RenderSelectedVob();

                SpacerNET.form.Focus();
            }
            else
            {
                if (listBoxVisuals.SelectedItem != null)
                {
                    string visual = listBoxVisuals.GetItemText(listBoxVisuals.SelectedItem);

                    Imports.Stack_PushString(visual);
                    Imports.Extern_RenderSelectedVob();

              

                    SpacerNET.form.Focus();
                }
                
            }
        }

        private void tabControlObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tab = sender as TabControl;

            if (tab.SelectedIndex != 0)
            {
                string visual = "";

                Imports.Stack_PushString(visual);
                Imports.Extern_RenderSelectedVob();

                //UnionNET.form.Focus();
            }


            if (tab.SelectedIndex != 1)
            {

                Imports.Extern_KillPreviewItem();
                //UnionNET.form.Focus();
            }


            if (tab.SelectedIndex != 2)
            {

                Imports.Extern_KillPFX();
                //UnionNET.form.Focus();
            }
        }

        private void checkBoxSearchOnly3DS_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ch = sender as CheckBox;
            Imports.Stack_PushString("searchOnly3DS");

            Imports.Extern_SetSetting(Convert.ToInt32(ch.Checked));
        }

        private void listBoxVisuals_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void listBoxVisuals_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;
            if (e.Button == MouseButtons.Right)
            {

                int index = lb.IndexFromPoint(e.Location);
                {
                    if (index == lb.SelectedIndex)
                    {
                        string visual = listBoxVisuals.GetItemText(listBoxVisuals.SelectedItem);
                        Clipboard.SetText(visual);


                        Imports.Stack_PushString(Localizator.Get("COPYBUFFER")  + ": " + visual);

                        Imports.Extern_PrintGreen();

                        
                    }
                }


                

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void buttonCamSpline_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;

      
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void LoadSettings()
        {


            Imports.Stack_PushString("addFPAutoName");
            Imports.Stack_PushString("downFPToGround");
            Imports.Stack_PushString("addWPAutoName");
            Imports.Stack_PushString("addWPToNet");
            Imports.Stack_PushString("searchOnly3DS");
            Imports.Stack_PushString("showModelPreview");


            checkBoxShowPreview.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());
            checkBoxSearchOnly3DS.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());


            checkBoxWayNet.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());
            checkBoxWPAutoName.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());
            checkBoxFPGround.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());
            checkBoxAutoNameFP.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());

            
        }

        private void checkBoxWayNet_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            Imports.Stack_PushString("addWPToNet");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
        }

        private void checkBoxWPAutoName_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            Imports.Stack_PushString("addWPAutoName");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
        }

        private void checkBoxFPGround_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
  
            Imports.Stack_PushString("downFPToGround");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
        }

        private void checkBoxAutoNameFP_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            Imports.Stack_PushString("addFPAutoName");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
        }

        private void listBoxParticles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (lb.SelectedItem != null)
            {
                string visual = lb.GetItemText(lb.SelectedItem);

                if (checkBoxShowPFXPreview.Checked)
                {
                    SendRenderPFX(visual);
                }
            }

           
        }

        private void listBoxPfxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (lb.SelectedItem != null)
            {
                string visual = lb.GetItemText(lb.SelectedItem);

                if (checkBoxShowPFXPreview.Checked)
                {
                    SendRenderPFX(visual);
                }
            }
        }


        public void SendRenderPFX(string visual)
        {
            Imports.Stack_PushString(visual);
            Imports.Extern_RenderPFX();
        }

        private void checkBoxShowPFXPreview_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb.Checked)
            {
                if (listBoxParticles.SelectedItem != null)
                {
                    string visual = listBoxParticles.GetItemText(listBoxParticles.SelectedItem);
                    SendRenderPFX(visual);
                }
                else if (listBoxPfxResult.SelectedItem != null)
                {
                    string visual = listBoxPfxResult.GetItemText(listBoxPfxResult.SelectedItem);
                    SendRenderPFX(visual);
                }

                
            }
            else
            {
                Imports.Extern_KillPFX();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void SendRenderItems(string visual)
        {
            Imports.Stack_PushString(visual);
            Imports.Extern_RenderItem();
        }


        private void checkBoxItemShow_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb.Checked)
            {
                if (listBoxItems.SelectedItem != null)
                {
                    string visual = listBoxItems.GetItemText(listBoxItems.SelectedItem);
                    SendRenderItems(visual);
                }
                else if (listBoxResultItems.SelectedItem != null)
                {
                    string visual = listBoxResultItems.GetItemText(listBoxResultItems.SelectedItem);
                    SendRenderItems(visual);
                }


            }
            else
            {
                Imports.Extern_KillPreviewItem();
            }
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (lb.SelectedItem != null)
            {
                string visual = lb.GetItemText(lb.SelectedItem);

                if (SpacerNET.grassWin.checkBoxGrassWinCopyName.Checked)
                {
                    SpacerNET.grassWin.textBoxGrassWinModel.Text = visual;
                    SpacerNET.grassWin.buttonGrassWinApply_Click(null, null);
                }

                if (checkBoxItemShow.Checked)
                {
                    SendRenderItems(visual);
                }
            }
        }

        private void listBoxResultItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (lb.SelectedItem != null)
            {
                string visual = lb.GetItemText(lb.SelectedItem);

                if (SpacerNET.grassWin.checkBoxGrassWinCopyName.Checked)
                {
                    SpacerNET.grassWin.textBoxGrassWinModel.Text = visual;
                    SpacerNET.grassWin.buttonGrassWinApply_Click(null, null);
                }


                if (checkBoxItemShow.Checked)
                {
                    SendRenderItems(visual);
                }
            }
        }

        private void labelTriggerTargets_Click(object sender, EventArgs e)
        {

        }

        private void labelTriggersSources_Click(object sender, EventArgs e)
        {

        }

        private void listBoxSources_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCamPlus_Click(object sender, EventArgs e)
        {
            if (camEntry.currentKey < camEntry.maxKey)
            {
                camEntry.currentKey += 1;
                UpdateCurrentKeyLabel();
            }
           

        }

        private void buttonCamMinus_Click(object sender, EventArgs e)
        {
            if (camEntry.currentKey > 0)
            {
                camEntry.currentKey -= 1;
                UpdateCurrentKeyLabel();
            }
        }


        static Dictionary<string, FolderEntry> folders = new Dictionary<string, FolderEntry>();
        static string currentFolderName = "";
        static TPropEditType currentFieldtype;


        static Dictionary<string, FolderEntry> foldersCompare = new Dictionary<string, FolderEntry>();
        static string currentFolderNameCompare = "";

        static Dictionary<string, FolderEntry> foldersConvert = new Dictionary<string, FolderEntry>();
        static string currentFolderNameConvert = "";



        static Dictionary<string, FolderEntry> foldersConvertVob = new Dictionary<string, FolderEntry>();
        static string currentFolderNameConvertVob = "";


        public static List<uint> searchResultVobsAddr = new List<uint>();
        public static string replaceZenPath = "";

        
        private void CleanNewProps()
        {
            treeViewSearchClass.Nodes.Clear();
            currentFolderNameConvert = String.Empty;
            foldersConvert.Clear();
            newProps.Clear();
        }

        private void CleanFindProps()
        {
            treeViewSearchClass.Nodes.Clear();
            currentFolderName = String.Empty;
            folders.Clear();
            searchProps.Clear();
        }


        public void FillClassFields(string inputStr, bool clean = true)
        {

            if (clean)
            {
                CleanFindProps();
            }
            else
            {
                treeViewSearchClass.Nodes.Clear();
                currentFolderName = String.Empty;
                folders.Clear();
            }

            TreeNode showFirst = null;


            if (inputStr.Length == 0)
            {
                return;
            }

            CProperty.originalStrSearchWindow = inputStr;
            string[] words = inputStr.Replace("\t", "").Split('\n');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();

                if (words[i].Length == 0 || words[i].Contains('[') || (!words[i].Contains(':') || !words[i].Contains('=')))
                {
                    continue;
                }

                if (words[i].Contains("groupBegin"))
                {
                    string folderName = words[i].Substring(0, words[i].IndexOf('='));

                    FolderEntry f = new FolderEntry();
                    f.parent = currentFolderName;


                    if (currentFolderName == "")
                    {
                        TreeNode node = treeViewSearchClass.Nodes.Add(folderName);
                        node.Tag = Constants.TAG_FOLDER;
                        f.node = node;
                    }
                    else
                    {
                        for (int j = 0; j < treeViewSearchClass.Nodes.Count; j++)
                        {
                            if (treeViewSearchClass.Nodes[j].Text == currentFolderName)
                            {
                                TreeNode node = treeViewSearchClass.Nodes[j].Nodes.Add(folderName);
                                node.Tag = Constants.TAG_FOLDER;
                                f.node = node;
                                break;
                            }
                        }
                    }

                    folders.Add(folderName, f);
                    currentFolderName = folderName;
                    continue;
                }

                if (words[i].Contains("groupEnd"))
                {
                    currentFolderName = folders[currentFolderName].parent;
                    continue;
                }

                if (clean)
                {
                    CProperty prop = new CProperty();
                    prop.Name = words[i].Substring(0, words[i].IndexOf('='));
                    prop.GroupName = currentFolderName;

                    int pos = words[i].IndexOf('=');
                    int pos2 = words[i].IndexOf(':');

                    prop.SetType(words[i].Substring(pos + 1, pos2 - pos - 1));

                    pos = words[i].IndexOf(':');

                    prop.SetValue(words[i].Substring(pos + 1, words[i].Length - pos - 1));

                    if (currentFolderName != "")
                    {
                        prop.node = folders[currentFolderName].node;
                    }

                    searchProps.Add(prop);
                }
                else
                {
                    CProperty prop = searchProps.Where(x => x.Name == words[i].Substring(0, words[i].IndexOf('='))).ToArray()[0];

                    if (prop != null && currentFolderName != "")
                    {
                        prop.node = folders[currentFolderName].node;
                    }
                }
                

            }

            
            for (int i = 0; i < searchProps.Count; i++)
            {
                TreeNode baseNode = searchProps[i].node;

                if (baseNode != null)
                {
                    TreeNode node = baseNode.Nodes.Add(searchProps[i].Name + ": " + searchProps[i].ShowValue());
                    node.SelectedImageIndex = 5;
                    node.ImageIndex = 5;
                    node.Tag = i;
                    searchProps[i].ownNode = node;

                    if (searchProps[i].Name == "vobName")
                    {
                        showFirst = node;
                    }
                }
                else
                {
                    TreeNode node = treeViewSearchClass.Nodes.Add(searchProps[i].Name + ": " + searchProps[i].ShowValue());
                    node.SelectedImageIndex = 5;
                    node.ImageIndex = 5;
                    node.Tag = i;
                    searchProps[i].ownNode = node;
                    if (searchProps[i].Name == "vobName")
                    {
                        showFirst = node;
                    }
                }

                if (searchProps[i].selectedForSearch)
                {
                    TreeNode node = searchProps[i].ownNode;

                    node.Text = searchProps[i].Name + ": " + searchProps[i].ShowValue();
                    node.SelectedImageIndex = 4;
                    node.ImageIndex = 4;
                }
            }


            treeViewSearchClass.ExpandAll();

            for (int j = 0; j < folders.Count; j++)
            {
                if (folders.ElementAt(j).Key == "Internals")
                {
                    folders.ElementAt(j).Value.node.Collapse();
                }
            }

            if (showFirst != null)
            {
                treeViewSearchClass.SelectedNode = showFirst;
            }
        }


        public void FillClassFieldsConvert(string inputStr, bool clean=true)
        {
            if (clean)
            {
                CleanNewProps();
            }
            else
            {
                treeViewSearchClass.Nodes.Clear();
                currentFolderNameConvert = String.Empty;
                foldersConvert.Clear();
            }

            TreeNode showFirst = null;


            if (inputStr.Length == 0)
            {
                return;
            }

            string[] words = inputStr.Replace("\t", "").Split('\n');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();

                if (words[i].Length == 0 || words[i].Contains('[') || (!words[i].Contains(':') || !words[i].Contains('=')))
                {
                    continue;
                }

                if (words[i].Contains("groupBegin"))
                {
                    string folderName = words[i].Substring(0, words[i].IndexOf('='));

                    FolderEntry f = new FolderEntry();
                    f.parent = currentFolderNameConvert;


                    if (currentFolderNameConvert == "")
                    {
                        TreeNode node = treeViewSearchClass.Nodes.Add(folderName);
                        node.Tag = Constants.TAG_FOLDER;
                        f.node = node;
                    }
                    else
                    {
                        for (int j = 0; j < treeViewSearchClass.Nodes.Count; j++)
                        {
                            if (treeViewSearchClass.Nodes[j].Text == currentFolderNameConvert)
                            {
                                TreeNode node = treeViewSearchClass.Nodes[j].Nodes.Add(folderName);
                                node.Tag = Constants.TAG_FOLDER;
                                f.node = node;
                                break;
                            }
                        }
                    }

                    foldersConvert.Add(folderName, f);
                    currentFolderNameConvert = folderName;
                    continue;
                }

                if (words[i].Contains("groupEnd"))
                {
                    currentFolderNameConvert = foldersConvert[currentFolderNameConvert].parent;
                    continue;
                }


                if (clean)
                {
                    CProperty prop = new CProperty();
                    prop.Name = words[i].Substring(0, words[i].IndexOf('='));
                    prop.GroupName = currentFolderNameConvert;

                    int pos = words[i].IndexOf('=');
                    int pos2 = words[i].IndexOf(':');

                    prop.SetType(words[i].Substring(pos + 1, pos2 - pos - 1));

                    pos = words[i].IndexOf(':');

                    prop.SetValue(words[i].Substring(pos + 1, words[i].Length - pos - 1));

                    if (currentFolderNameConvert != "")
                    {
                        prop.node = foldersConvert[currentFolderNameConvert].node;
                    }

                    newProps.Add(prop);
                }
                else
                {
                    CProperty prop = newProps.Where(x => x.Name == words[i].Substring(0, words[i].IndexOf('='))).ToArray()[0];

                    if (prop != null && currentFolderNameConvert != "")
                    {
                        prop.node = foldersConvert[currentFolderNameConvert].node;
                    }
                }
                

            }


            for (int i = 0; i < newProps.Count; i++)
            {
                TreeNode baseNode = newProps[i].node;

                if (baseNode != null)
                {
                    TreeNode node = baseNode.Nodes.Add(newProps[i].Name + ": " + newProps[i].ShowValue());
                    node.SelectedImageIndex = 5;
                    node.ImageIndex = 5;
                    node.Tag = i;
                    newProps[i].ownNode = node;

                    if (newProps[i].Name == "vobName")
                    {
                        showFirst = node;
                    }
                }
                else
                {
                    TreeNode node = treeViewSearchClass.Nodes.Add(newProps[i].Name + ": " + newProps[i].ShowValue());
                    node.SelectedImageIndex = 5;
                    node.ImageIndex = 5;
                    node.Tag = i;
                    newProps[i].ownNode = node;

                    if (newProps[i].Name == "vobName")
                    {
                        showFirst = node;
                    }
                }

                if (newProps[i].selectedForSearch)
                {
                    TreeNode node = newProps[i].ownNode;

                    node.Text = newProps[i].Name + ": " + newProps[i].ShowValue();
                    node.SelectedImageIndex = 3;
                    node.ImageIndex = 3;
                }
            }


            treeViewSearchClass.ExpandAll();

            for (int j = 0; j < foldersConvert.Count; j++)
            {
                if (foldersConvert.ElementAt(j).Key == "Internals")
                {
                    foldersConvert.ElementAt(j).Value.node.Collapse();
                }
            }

            if (showFirst != null)
            {
                treeViewSearchClass.SelectedNode = showFirst;
            }

        }
        //

        [DllExport]
        public static void AddSubClassConvert()
        {
            string value = Imports.Stack_PeekString();
            SpacerNET.objectsWin.comboBoxSearchClassReplace.Items.Add(value);
        }


        private void comboBoxSearchClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (!SpacerNET.isInit)
            {
                return;
            }

            string selectedClass = cb.Text.Replace(".", "").Trim();
           // ConsoleEx.WriteLineRed(selectedClass);

            Imports.Stack_PushString(selectedClass);
            Imports.Extern_GetClassFields(false);

            string result = Imports.Stack_PeekString();

            
            FillClassFields(result);

            comboBoxSearchClassReplace.Items.Clear();

            Imports.Stack_PushString(selectedClass);
            Imports.Extern_GetConvertSubClasses();


            radioButtonConvertOld.Checked = true;

            //searchProps
            //ConsoleEx.WriteLineRed(result);
        }

        private void treeViewSearchClass_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            int index = 0;
            TreeNode node = e.Node;


            int.TryParse(node.Tag.ToString(), out index);


            if (index >= 0 && node.Tag != null && node.Tag.ToString() != Constants.TAG_FOLDER)
            {

                CProperty prop = null;

                if (radioButtonConvertOld.Checked)
                {
                    prop = searchProps[index];
                    if (prop.selectedForSearch)
                    {
                        prop.selectedForSearch = false;
                        node.Text = prop.Name + ": " + prop.ShowValue();
                        node.SelectedImageIndex = 5;
                        node.ImageIndex = 5;

                    }
                    else
                    {
                        prop.selectedForSearch = true;
                        node.Text = prop.Name + ": " + prop.ShowValue();
                        node.SelectedImageIndex = 4;
                        node.ImageIndex = 4;
                    }
                }
                else
                {
                    prop = newProps[index];

                    if (prop.selectedForSearch)
                    {
                        prop.selectedForSearch = false;
                        node.Text = prop.Name + ": " + prop.ShowValue();
                        node.SelectedImageIndex = 5;
                        node.ImageIndex = 5;

                    }
                    else
                    {
                        prop.selectedForSearch = true;
                        node.Text = prop.Name + ": " + prop.ShowValue();
                        node.SelectedImageIndex = 3;
                        node.ImageIndex = 3;
                    }
                }

               
                
            }
        }

        public void HideAllInput()
        {
            textBoxSearchVobs.Visible = false;
            textBoxVecSearch0.Visible = false;
            textBoxVecSearch1.Visible = false;
            textBoxVecSearch2.Visible = false;
            comboBoxPropsEnumSearch.Visible = false;
        }

        private void treeViewSearchClass_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            int index = 0;

            //ConsoleEx.WriteLineRed(node.Tag.ToString());

            if (node.Tag != null && node.Tag.ToString() != Constants.TAG_FOLDER)
            {
                int.TryParse(node.Tag.ToString(), out index);

                if (index >= 0)
                {

                    HideAllInput();

                    CProperty prop = null;

                    if (radioButtonConvertOld.Checked)
                    {
                        prop = searchProps[index];
                    }
                    else
                    {
                        prop = newProps[index];
                    }
                    


                    if (prop.type == TPropEditType.PETstring || prop.type == TPropEditType.PETraw || prop.type == TPropEditType.PETint || prop.type == TPropEditType.PETfloat)
                    {
                        textBoxSearchVobs.Visible = true;
                        textBoxSearchVobs.Text = prop.value;

                        if (prop.type == TPropEditType.PETstring || prop.type == TPropEditType.PETraw)
                        {
                            textBoxSearchVobs.Width = 300;
                        }
                        else if (prop.type == TPropEditType.PETint || prop.type == TPropEditType.PETfloat)
                        {
                            textBoxSearchVobs.Width = 75;
                        }
                    }

                    if (prop.type == TPropEditType.PETvec3 || prop.type == TPropEditType.PETcolor)
                    {
                        textBoxVecSearch0.Visible = true;
                        textBoxVecSearch1.Visible = true;
                        textBoxVecSearch2.Visible = true;

                        string[] arr = prop.value.Split(' ');

                        textBoxVecSearch0.Text = arr[0];
                        textBoxVecSearch1.Text = arr[1];
                        textBoxVecSearch2.Text = arr[2];


                        if (prop.type == TPropEditType.PETcolor)
                        {
                            textBoxVecSearch3.Visible = true;
                            textBoxVecSearch3.Text = arr[3];
                        }
                    }

                    if (prop.type == TPropEditType.PETenum)
                    {
                        comboBoxPropsEnumSearch.Visible = true;
                        comboBoxPropsEnumSearch.Items.Clear();
                        comboBoxPropsEnumSearch.Items.AddRange(prop.enumArray.ToArray());
                        comboBoxPropsEnumSearch.SelectedIndex = prop.GetCurrentEnumIndex();
                    }

                    if (prop.type == TPropEditType.PETbool)
                    {
                        comboBoxPropsEnumSearch.Visible = true;
                        comboBoxPropsEnumSearch.Items.Clear();
                        comboBoxPropsEnumSearch.Items.Add("FALSE");
                        comboBoxPropsEnumSearch.Items.Add("TRUE");

                        if (prop.value == "0")
                        {
                            comboBoxPropsEnumSearch.SelectedIndex = 0;
                        }
                        else
                        {
                            comboBoxPropsEnumSearch.SelectedIndex = 1;
                        }
                    }


                    currentFieldtype = prop.type;

                    //Label_Backup.Text = Localizator.Get("Label_Backup") + ": " + prop.ShowBackupValue();


                }
            }
        }

        /*
         * 
         * treeViewSearchClass.Nodes.Clear();
            currentFolderName = String.Empty;
            folders.Clear();
            searchProps.Clear();
         * 
         * */
        private void comboBoxPropsEnumSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            TreeNode node = treeViewSearchClass.SelectedNode;

            if (node != null)
            {
                int index = 0;

                if (node.Tag != null && node.Tag.ToString() != Constants.TAG_FOLDER)
                {
                    int.TryParse(node.Tag.ToString(), out index);

                    if (index >= 0)
                    {

                        CProperty prop = null;

                        if (radioButtonConvertOld.Checked)
                        {
                            prop = searchProps[index];
                        }
                        else
                        {
                            prop = newProps[index];
                        }

                       

                        if (prop.type == TPropEditType.PETenum)
                        {
                            prop.value = comboBoxPropsEnumSearch.SelectedIndex.ToString();
                            prop.ownNode.Text = prop.Name + ": " + prop.ShowValue();

                        }

                        if (prop.type == TPropEditType.PETbool)
                        {
                            prop.value = comboBoxPropsEnumSearch.SelectedIndex.ToString();
                            prop.ownNode.Text = prop.Name + ": " + prop.ShowValue();

                        }
                    }

                }
            }
            else
            {
                ConsoleEx.WriteLineRed("Node is null");
            }
        }

        private void textBoxSearchVobs_TextChanged(object sender, EventArgs e)
        {
            TreeNode node = treeViewSearchClass.SelectedNode;
            TextBox textBox = sender as TextBox;
            int index = 0;

            if (node != null && node.Tag.ToString() != Constants.TAG_FOLDER)
            {
                int.TryParse(node.Tag.ToString(), out index);

                if (index >= 0)
                {


                    //Console.WriteLine("Change entry with index: " + index);
                    CProperty prop = null;

                    if (radioButtonConvertOld.Checked)
                    {
                        prop = searchProps[index];
                    }
                    else
                    {
                        prop = newProps[index];
                    }

                    /*
                    if (prop.backup_value == textBox.Text.Trim())
                    {
                        buttonApply.Enabled = false;
                        buttonRestore.Enabled = false;
                        return;
                    }
                    */

                    prop.value = textBox.Text.Trim().ToUpper();
                    node.Text = prop.Name + ": " + prop.ShowValue();
                }
            }
            else
            {
                ConsoleEx.WriteLineGreen("Textbox change with null node");
            }
        }

        private void textBoxSearchVobs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (currentFieldtype == TPropEditType.PETint || currentFieldtype == TPropEditType.PETfloat)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBoxVecSearch0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void ChangeVecDataTextBox(object sender, EventArgs e)
        {
            TreeNode node = treeViewSearchClass.SelectedNode;
            TextBox textBox = sender as TextBox;
            int index = 0;


            if (node != null && node.Tag.ToString() != Constants.TAG_FOLDER)
            {
                int.TryParse(node.Tag.ToString(), out index);

                if (index >= 0)
                {

                    //Console.WriteLine("Change entry with index: " + index);
                    CProperty prop = null;

                    if (radioButtonConvertOld.Checked)
                    {
                        prop = searchProps[index];
                    }
                    else
                    {
                        prop = newProps[index];
                    }

                    prop.value = textBoxVecSearch0.Text.Trim() + " " + textBoxVecSearch1.Text.Trim() + " " + textBoxVecSearch2.Text.Trim();

                    if (prop.type == TPropEditType.PETcolor)
                    {
                        prop.value += " " + textBoxVecSearch3.Text.Trim();
                    }

                    node.Text = prop.Name + ": " + prop.ShowValue();

                }
            }
            else
            {
                ConsoleEx.WriteLineGreen("Textbox change with null node");
            }
        }


        private void textBoxVecSearch0_TextChanged(object sender, EventArgs e)
        {
            ChangeVecDataTextBox(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bool checkValueFound = false;

            if (comboBoxSearchType.SelectedItem == null)
            {
                return;
            }

            int countSelected = 0;

            for (int i = 0; i < searchProps.Count; i++)
            {
                if (searchProps[i].selectedForSearch)
                {
                    checkValueFound = true;
                    countSelected++;


                    if (searchProps[i].type == TPropEditType.PETstring && checkBoxSearchUseRegex.Checked)
                    {

                        Regex regEx = null;

                        try
                        {
                            regEx = new Regex(@searchProps[i].value, RegexOptions.IgnoreCase | RegexOptions.Compiled);
                        }
                        catch (ArgumentException)
                        {
                            MessageBox.Show(Localizator.Get("BAD_REGEX"));
                            return;
                        }

                    }
                }
            }



            //ConsoleEx.WriteLineRed(countSelected + " " + isNameSelected + " " + isVisualSelected);


            if (!checkValueFound)
            {
                //MessageBox.Show(Localizator.Get("SET_ANY_FIELD_SEARCH"));
                //return;
            }


            if (comboBoxSearchType.SelectedIndex == 2 && replaceZenPath.Length == 0)
            {
                MessageBox.Show(Localizator.Get("NO_REPLACE_VOBTREE"));
                return;
            }

            if (comboBoxSearchType.SelectedIndex != 0)
            {
                DialogResult res = MessageBox.Show(Localizator.Get("askSure"), Localizator.Get("confirmation"), MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (res != DialogResult.OK)
                {
                    return;
                }
            }


       

            SpacerNET.form.AddText(Localizator.Get("VOB_SEARCH_START"));

            Stopwatch s = new Stopwatch();
            s.Start();

            listBoxSearchResult.Items.Clear();
            searchResultVobsAddr.Clear();

            
            if (comboBoxSearchType.SelectedIndex == 2)
            {
                Imports.Stack_PushString(replaceZenPath);
            }

            Imports.Stack_PushInt(countSelected);
            int result = Imports.Extern_SearchVobs(checkBoxSearchDerived.Checked, comboBoxSearchType.SelectedIndex);


            s.Stop();

  

            string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));

   
            if (comboBoxSearchType.SelectedIndex == 0)
            {
                labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ": " + listBoxSearchResult.Items.Count;
                SpacerNET.form.AddText(Localizator.Get("VOB_SEARCH_STOP") + result.ToString() + " (" + timeSpend + ")");
            }

            if (comboBoxSearchType.SelectedIndex == 1)
            {
                labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ": ";
                SpacerNET.form.AddText(Localizator.Get("VOB_SEARCH_CONVERT") + result.ToString() + " (" + timeSpend + ")");
            }


            if (comboBoxSearchType.SelectedIndex == 2)
            {
                //labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ": " + listBoxSearchResult.Items.Count;
                labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ": ";
                SpacerNET.form.AddText(Localizator.Get("VOB_SEARCH_REPLACEZEN") + result.ToString() +  " (" + timeSpend + ")");
            }

            if (comboBoxSearchType.SelectedIndex == 3)
            {
                //labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ": " + listBoxSearchResult.Items.Count;
                labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ": ";
                SpacerNET.form.AddText(Localizator.Get("VOB_SEARCH_REMOVEVOBS") + result.ToString() + " (" + timeSpend + ")");
            }


           /* if (comboBoxSearchType.SelectedIndex == 4)
            {
                //labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ": " + listBoxSearchResult.Items.Count;
                labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ": ";
                SpacerNET.form.AddText(Localizator.Get("VOB_SEARCH_RENAME_VOBS") + result.ToString() + " (" + timeSpend + ")");
            }
            */

            if (comboBoxSearchType.SelectedIndex == 4)
            {
                //labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ": " + listBoxSearchResult.Items.Count;
                labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ": ";
                SpacerNET.form.AddText(Localizator.Get("VOB_SEARCH_DYNCOLL_VOBS") + result.ToString() + " (" + timeSpend + ")");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ": ";
            listBoxSearchResult.Items.Clear();
            searchResultVobsAddr.Clear();
            textBoxSearchVobs.Text = "";

            for (int i = 0; i < searchProps.Count; i++)
            {
                searchProps[i].selectedForSearch = false;
                searchProps[i].value = searchProps[i].backup_value;
                searchProps[i].ownNode.SelectedImageIndex = 5;
                searchProps[i].ownNode.ImageIndex = 5;
                searchProps[i].ownNode.Text = searchProps[i].Name + ": " + searchProps[i].ShowValue();
            }
        }


        [DllExport]
        public static void AddSearchVobResult(uint addr)
        {
            /*
            if (searchResultVobsAddr.Contains(addr))
            {
                return;
            }
            */
            SpacerNET.objectsWin.listBoxSearchResult.Items.Add(Imports.Stack_PeekString());
            searchResultVobsAddr.Add(addr);
        }

        [DllExport]
        public static bool ConvertVobs()
        {
            string vobInfo = Imports.Stack_PeekString();

            convertProps.Clear();
            foldersConvertVob.Clear();
            currentFolderNameConvertVob = "";


            //static Dictionary<string, FolderEntry> foldersConvertVob = new Dictionary<string, FolderEntry>();
            //static string currentFolderNameConvertVob = "";

            bool useRegx = SpacerNET.objectsWin.checkBoxSearchUseRegex.Checked;

            string[] words = vobInfo.Replace("\t", "").Split('\n');

            List<string> rawProps = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();
                rawProps.Add(words[i]);

                if (words[i].Length == 0 || words[i].Contains('[') || (!words[i].Contains(':') || !words[i].Contains('=')))
                {
                    continue;
                }

                

                if (words[i].Contains("groupBegin"))
                {
                    string folderName = words[i].Substring(0, words[i].IndexOf('='));

                    FolderEntry f = new FolderEntry();
                    f.parent = currentFolderNameConvertVob;

                    foldersConvertVob.Add(folderName, f);
                    currentFolderNameConvertVob = folderName;
                    continue;
                }

                if (words[i].Contains("groupEnd"))
                {
                    currentFolderNameConvertVob = foldersConvertVob[currentFolderNameConvertVob].parent;
                    continue;
                }

                CProperty prop = new CProperty();
                prop.Name = words[i].Substring(0, words[i].IndexOf('='));
                prop.GroupName = currentFolderNameConvertVob;

                int pos = words[i].IndexOf('=');
                int pos2 = words[i].IndexOf(':');

                prop.SetType(words[i].Substring(pos + 1, pos2 - pos - 1));

                pos = words[i].IndexOf(':');

                prop.SetValue(words[i].Substring(pos + 1, words[i].Length - pos - 1));

                if (currentFolderNameConvertVob != "")
                {
                    prop.node = foldersConvertVob[currentFolderNameConvertVob].node;
                }

                convertProps.Add(prop);
            }



            bool changed = false;

            for (int i = 0; i < newProps.Count; i++)
                if (newProps[i].selectedForSearch)
                {
                    bool found = false;
                    int pc = 0;
                    while (!found && pc < convertProps.Count)
                    {
                        found = convertProps[pc].Name == newProps[i].Name;
                        if (!found) pc++;
                    }

                    if (found)
                    {
                        convertProps[pc] = newProps[i];
                        changed = true;
                    }
                }

            bool result = false;


            string className = SpacerNET.objectsWin.comboBoxSearchClassReplace.Text.Replace(".", "").Trim();



            if (changed)
            {

                string[] raw = vobInfo.Replace("\t", "").Split('\n');

                for (int j = 0; j < raw.Length; j++)
                {
                    if (raw[j].Length == 0)
                    {
                        continue;
                    }

                    for (int i = 0; i < convertProps.Count; i++)
                    {
                        if (Regex.IsMatch(raw[j], "^" + convertProps[i].Name + @"=\w", RegexOptions.IgnoreCase))
                        {
                            string baseStr = raw[j].Substring(0, raw[j].IndexOf(':') + 1) + convertProps[i].value;
                            //Console.WriteLine(baseStr);
                            raw[j] = baseStr;
                        }
                    }

                }


                StringBuilder str = new StringBuilder(); 

                for (int j = 0; j < words.Length; j++)
                {
                    str.Append(words[j] + "\n");
                }

                Imports.Stack_PushString(str.ToString());
                Imports.Extern_AddConvertVob();
                /*
                zCBuffer zbuf(zstrBuf.ToChar(), zstrBuf.Length());

                zCArchiver* arch = zarcFactory.CreateArchiverRead(&zbuf);
                arch->SetStringEOL(zSTRING("\n"));
                arch->ReadObject(vob);
                arch->Close();
                zRELEASE(arch);
                */
                result = true;
            }

            return result;

        }

        [DllExport]
        public static bool CompareVobs()
        {
            string vobInfo = Imports.Stack_PeekString();

            compareProps.Clear();
            foldersCompare.Clear();
            currentFolderNameCompare = "";

            //ConsoleEx.WriteLineRed("");

            bool useRegx = SpacerNET.objectsWin.checkBoxSearchUseRegex.Checked;


            string[] words = vobInfo.Replace("\t", "").Split('\n');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();

                if (words[i].Length == 0 || words[i].Contains('[') || (!words[i].Contains(':') || !words[i].Contains('=')))
                {
                    continue;
                }

                if (words[i].Contains("groupBegin"))
                {
                    string folderName = words[i].Substring(0, words[i].IndexOf('='));

                    FolderEntry f = new FolderEntry();
                    f.parent = currentFolderNameCompare;

                    foldersCompare.Add(folderName, f);
                    currentFolderNameCompare = folderName;
                    continue;
                }

                if (words[i].Contains("groupEnd"))
                {
                    currentFolderNameCompare = foldersCompare[currentFolderNameCompare].parent;
                    continue;
                }

                CProperty prop = new CProperty();
                prop.Name = words[i].Substring(0, words[i].IndexOf('='));
                prop.GroupName = currentFolderNameCompare;

                int pos = words[i].IndexOf('=');
                int pos2 = words[i].IndexOf(':');

                prop.SetType(words[i].Substring(pos + 1, pos2 - pos - 1));

                pos = words[i].IndexOf(':');

                prop.SetValue(words[i].Substring(pos + 1, words[i].Length - pos - 1));

                if (currentFolderNameCompare != "")
                {
                    prop.node = foldersCompare[currentFolderNameCompare].node;
                }

                compareProps.Add(prop);
            }

            //ConsoleEx.WriteLineRed(compareProps.Count.ToString());

            bool match = true;
            int j = 0;
            while (match && j < searchProps.Count)
            {
                if (searchProps[j].selectedForSearch)
                {
                    match = false;
                    int pc = 0;

                    while (!match && pc < compareProps.Count)
                    {
                        if (compareProps[pc].Name == searchProps[j].Name)
                        {
                            //ConsoleEx.WriteLineRed(compareProps[pc].Name + ": " + compareProps[pc].value + "/" + searchProps[j].value);

                            if (useRegx)
                            {
                                Regex reg = new Regex(searchProps[j].value, RegexOptions.IgnoreCase);

                                match = reg.IsMatch(compareProps[pc].value);
                            }
                            else
                            {
                                match = compareProps[pc].value == searchProps[j].value;
                            }
                            
                            
                            
                        }
                        if (!match) pc++;
                    }

                }
                ++j;
            }

            return match;

        }

        private void listBoxSearchResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBoxSearchResult.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                if (listBoxSearchResult.Items.Count >= index - 1)
                {
                    uint vobAddr = searchResultVobsAddr[index];
                    //ConsoleEx.WriteLineGreen(vobAddr + " index " + index);

                    try
                    {
                        SpacerNET.objTreeWin.globalTree.SelectedNode =
                        ObjTree.globalEntries[vobAddr].node;
                    }
                    catch
                    {
                        ConsoleEx.WriteLineGreen("listBoxSearchResult_MouseDoubleClick. Can't find vob with addr: " + Utils.ToHex(vobAddr));
                    }
                    selectTabBlocked = 2;
                    Imports.Extern_SelectVob(vobAddr);


                }

            }
        }

        private void listBoxSearchResult_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listBoxSearchResult.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                if (listBoxSearchResult.Items.Count >= index - 1)
                {
                    uint vobAddr = searchResultVobsAddr[index];
                    //ConsoleEx.WriteLineGreen(vobAddr + " index " + index);

                    try
                    {
                        SpacerNET.objTreeWin.globalTree.SelectedNode =
                        ObjTree.globalEntries[vobAddr].node;

                        selectTabBlocked = 2;
                        Imports.Extern_SelectVobSync(vobAddr);
                    }
                    catch
                    {
                        ConsoleEx.WriteLineGreen("vobListSelect. Can't find vob with addr: " + Utils.ToHex(vobAddr));
                    }


                }

            }
        }

        private void comboBoxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            comboBoxSearchClassReplace.Visible = false;
            radioButtonConvertOld.Visible = false;
            radioButtonConvertNew.Visible = false;
            textBoxRenameVob.Visible = false;
            labelRenameVob.Visible = false;
            checkBoxAutoNumerate.Visible = false;

            switch (cb.SelectedIndex)
            {
                case 0: buttonSearchVobsDo.Text = Localizator.Get("VOB_SEARCH_TYPE0"); break;
                case 1: buttonSearchVobsDo.Text = Localizator.Get("VOB_SEARCH_TYPE1"); break;
                case 2: buttonSearchVobsDo.Text = Localizator.Get("VOB_SEARCH_TYPE2"); break;
                case 3: buttonSearchVobsDo.Text = Localizator.Get("VOB_SEARCH_TYPE3"); break;
                //case 4: buttonSearchVobsDo.Text = Localizator.Get("VOB_SEARCH_TYPE4"); break;
                case 4: buttonSearchVobsDo.Text = Localizator.Get("VOB_SEARCH_TYPE_DYNAMIC"); break;
            }

            if (cb.SelectedIndex == 1)
            {
                comboBoxSearchClassReplace.Visible = true;
                radioButtonConvertOld.Visible = true;
                radioButtonConvertNew.Visible = true;
                MessageBox.Show("Not working yet!");
            }
            else if (radioButtonConvertNew.Checked)
            {

                treeViewSearchClass.Nodes.Clear();

                string selectedClass = comboBoxSearchClass.Text.Replace(".", "").Trim();

                Imports.Stack_PushString(selectedClass);
                Imports.Extern_GetClassFields(true);

                string result = Imports.Stack_PeekString();

                FillClassFields(result);

                comboBoxSearchClassReplace_SelectedIndexChanged(comboBoxSearchClassReplace, null);
            }



            if (cb.SelectedIndex == 2)
            {
                OpenFileDialog openFileDialogVobTree = new OpenFileDialog();

                openFileDialogVobTree.Filter = Constants.FILE_FILTER_OPEN_VOBTREE;

                Imports.Stack_PushString("treeVobPath");
                Imports.Extern_GetSettingStr();
                string path = Imports.Stack_PeekString();

                openFileDialogVobTree.InitialDirectory = Utils.GetInitialDirectory(path);

                openFileDialogVobTree.RestoreDirectory = true;

                if (openFileDialogVobTree.ShowDialog() == DialogResult.OK)
                {
                    replaceZenPath = openFileDialogVobTree.FileName.Trim();
                }

            }
            /*
            if (cb.SelectedIndex == 4)
            {

                checkBoxAutoNumerate.Visible = true;
                textBoxRenameVob.Visible = true;
                labelRenameVob.Visible = true;
                labelRenameVob.Text = Localizator.Get("labelRenameVob");
                checkBoxAutoNumerate.Text = Localizator.Get("checkBoxAutoNumerate");
                
                textBoxRenameVob.Text = String.Empty;
            }
            */
            //dynamic
            if (cb.SelectedIndex == 4)
            {
                
            }
        }


        private void radioButtonConvertNew_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                treeViewSearchClass.Nodes.Clear();


                string selectedClass = comboBoxSearchClassReplace.Text.Replace(".", "").Trim();
                // ConsoleEx.WriteLineRed(selectedClass);

                Imports.Stack_PushString(selectedClass);
                Imports.Extern_GetClassFields(true);

                string result = Imports.Stack_PeekString();

                FillClassFieldsConvert(result, false);


            }
        }

        private void radioButtonConvertOld_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                treeViewSearchClass.Nodes.Clear();


                string selectedClass = comboBoxSearchClass.Text.Replace(".", "").Trim();

                Imports.Stack_PushString(selectedClass);
                Imports.Extern_GetClassFields(false);

                string result = Imports.Stack_PeekString();

                FillClassFields(result, false);
            }
        }

        private void comboBoxSearchClassReplace_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (!SpacerNET.isInit)
            {
                return;
            }

            string selectedClass = cb.Text.Replace(".", "").Trim();

            Imports.Stack_PushString(selectedClass);
            Imports.Extern_GetClassFields(true);

            string result = Imports.Stack_PeekString();


            FillClassFieldsConvert(result);

            radioButtonConvertNew.Checked = true;
        }
    }
}
