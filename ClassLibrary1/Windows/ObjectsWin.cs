
using SpacerUnion.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public ObjectsWin()
        {
            InitializeComponent();
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
            SpacerNET.objectsWin.labelAllModels.Text = "Всего моделей: " + listVisualsVDF.Count + "/" + listVisualsWORK.Count;
        }


        [DllExport]
        public static void SortPFX()
        {
            //UnionNET.partWin.listBoxParticles.Sorted = true;
            ListBox lstBox = SpacerNET.objectsWin.listBoxParticles;
            Utils.SortListBox(lstBox);

            SpacerNET.objectsWin.groupBox1.Text += ", всего: " + SpacerNET.objectsWin.listBoxParticles.Items.Count;
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

            SpacerNET.objectsWin.groupBox2.Text += ", всего: " + SpacerNET.objectsWin.listBoxItems.Items.Count;
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


            SpacerNET.infoWin.AddText("Создаю Item " + name);

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


            SpacerNET.infoWin.AddText("Создаю PFX " + name);


            Imports.Stack_PushString(name);
            Imports.Extern_CreatePFX();
            Imports.Extern_KillPFX();   

            SpacerNET.form.Focus();
        }

        public static void FindClass(TreeNodeCollection nodes, string baseClass, string name)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].Text == baseClass)
                {
                    nodes[i].Nodes.Add(name);
                    return;
                }

                FindClass(nodes[i].Nodes, baseClass, name);
            }
        }

        [DllExport]
        public static void AddClassNode(int depth)
        {
            string name = Imports.Stack_PeekString();
            string baseClassName = Imports.Stack_PeekString();
            TreeNodeCollection nodes = SpacerNET.objectsWin.classesTreeView.Nodes;
            if (name == baseClassName)
            {
                nodes.Add(name);
                return;
            }
            FindClass(nodes, baseClassName, name);

            SpacerNET.objectsWin.comboBoxSearchClass.Items.Add(name);
            SpacerNET.objectsWin.comboBoxSearchClass.SelectedIndex = 0;

            SpacerNET.objectsWin.classesTreeView.ExpandAll();
            SpacerNET.objectsWin.classesTreeView.SelectedNode = SpacerNET.objectsWin.classesTreeView.Nodes[0];
            SpacerNET.objectsWin.classesTreeView.SelectedNode.EnsureVisible();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (classesTreeView.SelectedNode == null)
            {
                return;
            }

            string name = classesTreeView.SelectedNode.Text;
            string vobName = textBoxVobName.Text.Trim();
            string visualVob = "";
            int isDyn = Convert.ToInt32(checkBoxDynStat.Checked);
            int isStat = Convert.ToInt32(checkBoxStaStat.Checked);


            if (listBoxVisuals.SelectedItem != null)
            {
                visualVob = listBoxVisuals.GetItemText(listBoxVisuals.SelectedItem);
            }

            Console.WriteLine("C#: OnCreateVob: ClassDef: " + name);

            if (name == "oCItem" || name == "zCVobWaypoint" || name == "zCVobSpot")
            {
                MessageBox.Show("Данный тип воба создается в отдельной вкладке справа!");
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
            SpacerNET.objectsWin.buttonWP.PerformClick();
        }

        private void buttonWP_Click(object sender, EventArgs e)
        {
            string name = "zCVobWaypoint";
            string vobName = textBoxWP.Text.Trim();
            bool addToNet = checkBoxWayNet.Checked;
            bool autoGenerate = checkBoxWPAutoName.Checked;

            if (vobName.Length == 0)
            {
                MessageBox.Show("Нельзя ввести пустое имя!");
                return;
            }

            if (vobName.All(char.IsDigit))
            {
                MessageBox.Show("Имя вейпоинта не может состоять только из цифр!");
                return;
            }


            Imports.Stack_PushString(vobName);
            bool nameFound = Imports.Extern_VobNameExist(true);

            if (nameFound && !autoGenerate)
            {
                MessageBox.Show("Такое имя уже существует");
                
                return;
            }


            Console.WriteLine("C#: OnCreateVob: ClassDef: " + name);


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
                MessageBox.Show("Нельзя ввести пустое имя!");
                return;
            }

            Imports.Stack_PushString(vobName);

            bool nameFound = Imports.Extern_VobNameExist(false);
            if (nameFound)
            {
                
                MessageBox.Show("Такое имя уже существует");
                return;
            }

            Console.WriteLine("C#: OnCreateVob: ClassDef: " + name);


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


            SpacerNET.infoWin.AddText("Создаю Item " + name);
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


            SpacerNET.infoWin.AddText("Создаю PFX " + name);

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

                listBoxVisuals.Items.Clear();

                if (radioButtonVdf.Checked)
                {
                    for (int i = 0; i < listVisualsVDF.Count; i++)
                    {
                        if (Regex.IsMatch(listVisualsVDF[i], @strToFind))
                        {
                            listBoxVisuals.Items.Add(listVisualsVDF[i]);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < listVisualsWORK.Count; i++)
                    {
                        if (Regex.IsMatch(listVisualsWORK[i], @strToFind))
                        {
                            listBoxVisuals.Items.Add(listVisualsWORK[i]);
                        }
                    }
                }


                SpacerNET.objectsWin.labelSearchVisual.Text = "Поиск визуала. Всего: " + listBoxVisuals.Items.Count;


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBoxVisuals.Items.Clear();
            listBoxVisuals.ClearSelected();
            textBoxVisuals.Clear();

            SpacerNET.objectsWin.labelSearchVisual.Text = "Поиск визуала.";

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
                labelCurrentKey.Text = triggerEntry.m_kf_pos.ToString();
            }


        }

        private void buttonKeyPlus_Click(object sender, EventArgs e)
        {
            if (triggerEntry.m_kf_pos + 1 < triggerEntry.maxKey)
            {
                triggerEntry.m_kf_pos++;
                Imports.Extern_SetToKeyPos(triggerEntry.m_kf_pos);
                labelCurrentKey.Text = triggerEntry.m_kf_pos.ToString();
            }



        }


        public void UpdateTriggerWindow()
        {
            labelTriggerName.Text = triggerEntry.name;
            labelCurrentKey.Text = triggerEntry.m_kf_pos.ToString();
            checkBoxDyn.Checked = triggerEntry.dynColl;
            checkBoxStat.Checked = triggerEntry.statColl;

            if (listBoxActionType.SelectedItem == null)
            {
                //listBoxActionType.SelectedIndex = 0;
            }

            buttonRemoveKey.Enabled = false;
            buttonNewKey.Enabled = false;
            buttonKeyMinus.Enabled = false;
            buttonKeyPlus.Enabled = false;


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


        [DllExport]
        public static void SelectMoversTab()
        {
            SpacerNET.objectsWin.tabControlObjects.SelectedIndex = 3;
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
            UpdateTriggerWindow();
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
            UpdateTriggerWindow();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string name = listBoxActionType.GetItemText(listBoxActionType.SelectedItem);

            ConsoleEx.WriteLineRed("Send trigger: action " + name);
            Imports.Extern_SendTrigger(triggerEntry.currentActionIndex);
            triggerEntry.m_kf_pos = Imports.Extern_GetCurrentKey();
        }

        private void ParticleWin_Shown(object sender, EventArgs e)
        {
            //listBoxActionType.SelectedIndex = 0;
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
                    Utils.Error("C#: triggetSourcesList. Can't find vob with addr: " + Utils.ToHex(addr));
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
                    ConsoleEx.WriteLineGreen("C#: triggetTargetList. Can't find vob with addr: " + Utils.ToHex(addr));
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

                        Imports.Stack_PushString("Скопировано в буфер: " + visual);

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

                if (checkBoxItemShow.Checked)
                {
                    SendRenderItems(visual);
                }
            }
        }

       
    }
}
