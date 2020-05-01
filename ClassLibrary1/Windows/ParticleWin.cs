
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
    

    public partial class ParticleWin : Form
    {
        public static List<string> listVisuals = new List<string>();
        public TriggerEntry triggerEntry = new TriggerEntry();

        public ParticleWin()
        {
            InitializeComponent();
        }

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreateItem(IntPtr name);

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreatePFX(IntPtr name);


        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Extern_VobNameExist(IntPtr name, bool isWaypoint);
        


        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreateNewVob(IntPtr name, IntPtr vobName, int dyn, int stat);

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreateWaypoint(IntPtr name, IntPtr vobName, bool addToWaynet);


        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreateNewVobVisual(IntPtr name, IntPtr vobName, IntPtr visual, int dyn, int stat);


        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_ConnectWP();

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_DisconnectWP();

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetToKeyPos(int pos);

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_OnKeyRemove();

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_OnAddKey(int mode);


        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_GetCurrentKey();


        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_GetMaxKey();

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SendTrigger(int actionIndex);


        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetCollTrigger(int mode, int val);

        [DllExport]
        public static void AddPacticleToList(IntPtr ptr)
        {
            string name = Marshal.PtrToStringAnsi(ptr);

            UnionNET.partWin.listBoxParticles.Items.Add(name);
        }


        [DllExport]
        public static void AddVisualToList(IntPtr ptr)
        {
            string name = Marshal.PtrToStringAnsi(ptr);


            name = Path.GetFileName(name);

            //UnionNET.partWin.listBoxVisuals.Items.Add(name);
            ParticleWin.listVisuals.Add(name);

        }


        [DllExport]
        public static void SortVisuals()
        {
            ParticleWin.listVisuals = ParticleWin.listVisuals.Distinct().ToList();
            ParticleWin.listVisuals.Sort();

            UnionNET.partWin.labelSearchVisual.Text = "Поиск визуала. Всего: " + listVisuals.Count;
        }


        [DllExport]
        public static void SortPFX()
        {
            //UnionNET.partWin.listBoxParticles.Sorted = true;
            ListBox lstBox = UnionNET.partWin.listBoxParticles;
            Utils.SortListBox(lstBox);

            UnionNET.partWin.groupBox1.Text += ", всего: " + UnionNET.partWin.listBoxParticles.Items.Count;
        }

        [DllExport]
        public static void AddItemToList(IntPtr ptr)
        {
            ListBox listBox = UnionNET.partWin.listBoxItems;
            string name = Marshal.PtrToStringAnsi(ptr);

            int index = listBox.Items.Add(name);
        }

        [DllExport]
        public static void SortItems()
        {
            //UnionNET.partWin.listBoxItems.Sorted = true;
            Utils.SortListBox(UnionNET.partWin.listBoxItems);

            UnionNET.partWin.groupBox2.Text += ", всего: " + UnionNET.partWin.listBoxItems.Items.Count;
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


            UnionNET.infoWin.AddText("Создаю Item " + name);

            IntPtr item_name = Marshal.StringToHGlobalAnsi(name);

            Extern_CreateItem(item_name);
            Marshal.FreeHGlobal(item_name);

            UnionNET.form.Focus();

        }

        private void textBoxItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string strToFind = textBoxItems.Text.Trim().ToUpper();

                listBoxResult.Items.Clear();


                for (int i = 0; i < listBoxItems.Items.Count; i++)
                {
                    string value = listBoxItems.GetItemText(listBoxItems.Items[i]);

                    if (Regex.IsMatch(value, @strToFind))
                    {
                        listBoxResult.Items.Add(value);
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


            UnionNET.infoWin.AddText("Создаю PFX " + name);

            IntPtr PfxName = Marshal.StringToHGlobalAnsi(name);

            Extern_CreatePFX(PfxName);
            Marshal.FreeHGlobal(PfxName);

            UnionNET.form.Focus();
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
        public static void AddClassNode(IntPtr ptr, int depth, IntPtr ptrB)
        {
            string name = Marshal.PtrToStringAnsi(ptr);
            string baseClassName = Marshal.PtrToStringAnsi(ptrB);
            TreeNodeCollection nodes = UnionNET.partWin.classesTreeView.Nodes;
            if (name == baseClassName)
            {
                nodes.Add(name);
                return;
            }
            FindClass(nodes, baseClassName, name);

            UnionNET.partWin.classesTreeView.ExpandAll();
            UnionNET.partWin.classesTreeView.SelectedNode = UnionNET.partWin.classesTreeView.Nodes[0];
            UnionNET.partWin.classesTreeView.SelectedNode.EnsureVisible();
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

            IntPtr ptrName = Marshal.StringToHGlobalAnsi(name);
            IntPtr ptrVobName = Marshal.StringToHGlobalAnsi(vobName);
            IntPtr ptrVisual= Marshal.StringToHGlobalAnsi(visualVob);

            Extern_CreateNewVobVisual(ptrName, ptrVobName, ptrVisual, isDyn, isStat);
            Marshal.FreeHGlobal(ptrName);
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
            UnionNET.partWin.buttonWP.PerformClick();
        }

        private void buttonWP_Click(object sender, EventArgs e)
        {
            string name = "zCVobWaypoint";
            string vobName = textBoxWP.Text.Trim();
            bool addToNet = checkBoxWayNet.Checked;

            if (vobName.Length == 0)
            {
                MessageBox.Show("Нельзя ввести пустое имя!");
                return;
            }

            IntPtr ptrVobNameCheck = Marshal.StringToHGlobalAnsi(vobName);

            bool nameFound = Extern_VobNameExist(ptrVobNameCheck, true);

            if (nameFound)
            {
                MessageBox.Show("Такое имя уже существует");
                return;
            }


            Console.WriteLine("C#: OnCreateVob: ClassDef: " + name);

            IntPtr ptrName = Marshal.StringToHGlobalAnsi(name);
            IntPtr ptrVobName = Marshal.StringToHGlobalAnsi(vobName);

            Extern_CreateWaypoint(ptrName, ptrVobName, addToNet);
            Marshal.FreeHGlobal(ptrName);


            if (vobName.Contains("_"))
            {
                string strNumber = Regex.Match(vobName, @"_\d+$").Value.Replace("_", "");
                string strName = Regex.Match(vobName, @"^.*_").Value.Replace("_", "");

                int number;
                int.TryParse(strNumber, out number);
                number++;
                textBoxWP.Text = strName + "_" + number.ToString();
            }
            
        }

        private void buttonFP_Click_1(object sender, EventArgs e)
        {
            string name = "zCVobSpot";

            string vobName = textBoxFP.Text.Trim();

            if (vobName.Length == 0)
            {
                MessageBox.Show("Нельзя ввести пустое имя!");
                return;
            }


            IntPtr ptrVobNameCheck = Marshal.StringToHGlobalAnsi(vobName);

            bool nameFound = Extern_VobNameExist(ptrVobNameCheck, false);
            if (nameFound)
            {
                MessageBox.Show("Такое имя уже существует");
                return;
            }

            Console.WriteLine("C#: OnCreateVob: ClassDef: " + name);

            IntPtr ptrName = Marshal.StringToHGlobalAnsi(name);
            IntPtr ptrVobName = Marshal.StringToHGlobalAnsi(vobName);

            Extern_CreateNewVob(ptrName, ptrVobName, 0, 0);
            Marshal.FreeHGlobal(ptrName);


            if (vobName.Contains("_"))
            {
                string strNumber = Regex.Match(vobName, @"_\d+$").Value.Replace("_", "");
                string strName = Regex.Match(vobName, @"^.*_").Value.Replace("_", "");

                int number;
                int.TryParse(strNumber, out number);
                number++;
                textBoxFP.Text = strName + "_" + number.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Extern_ConnectWP();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Extern_DisconnectWP();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBoxResult.SelectedItem == null)
            {
                return;
            }
            string name = listBoxResult.GetItemText(listBoxResult.SelectedItem);

            //Console.WriteLine("Create item: " + name);


            UnionNET.infoWin.AddText("Создаю Item " + name);

            IntPtr item_name = Marshal.StringToHGlobalAnsi(name);

            Extern_CreateItem(item_name);
            Marshal.FreeHGlobal(item_name);

            UnionNET.form.Focus();
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


            UnionNET.infoWin.AddText("Создаю PFX " + name);

            IntPtr PfxName = Marshal.StringToHGlobalAnsi(name);

            Extern_CreatePFX(PfxName);
            Marshal.FreeHGlobal(PfxName);

            UnionNET.form.Focus();
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

                listBoxVisuals.Items.Clear();


                for (int i = 0; i < listVisuals.Count; i++)
                {

                    if (Regex.IsMatch(listVisuals[i], @strToFind))
                    {
                        listBoxVisuals.Items.Add(listVisuals[i]);
                    }
                }


                UnionNET.partWin.labelSearchVisual.Text = "Поиск визуала. Всего: " + listBoxVisuals.Items.Count;


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBoxVisuals.Items.Clear();
            listBoxVisuals.ClearSelected();
            UnionNET.partWin.labelSearchVisual.Text = "Поиск визуала.";
        }

        private void checkBoxDyn_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            triggerEntry.dynColl = cb.Checked;

            ObjectsWindow.ChangeProp("cdDyn", Convert.ToInt32(triggerEntry.dynColl).ToString());


            Extern_SetCollTrigger(0, Convert.ToInt32(triggerEntry.dynColl));
        }

        private void checkBoxStat_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            triggerEntry.statColl = cb.Checked;

            ObjectsWindow.ChangeProp("cdStatic", Convert.ToInt32(triggerEntry.statColl).ToString());

            Extern_SetCollTrigger(1, Convert.ToInt32(triggerEntry.statColl));
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


                Extern_SetToKeyPos(triggerEntry.m_kf_pos);
                labelCurrentKey.Text = triggerEntry.m_kf_pos.ToString();
            }


        }

        private void buttonKeyPlus_Click(object sender, EventArgs e)
        {
            if (triggerEntry.m_kf_pos + 1 < triggerEntry.maxKey)
            {
                triggerEntry.m_kf_pos++;
                Extern_SetToKeyPos(triggerEntry.m_kf_pos);
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

            UnionNET.partWin.triggerEntry.m_kf_pos = 0;
            UnionNET.partWin.triggerEntry.maxKey = 0;
            UnionNET.partWin.triggerEntry.name = "";
            UnionNET.partWin.triggerEntry.dynColl = false;
            UnionNET.partWin.triggerEntry.statColl = false;
            UnionNET.partWin.listBoxTargetList.Items.Clear();
            UnionNET.partWin.listBoxActionType.Items.Clear();
            UnionNET.partWin.triggerEntry.targetListAddr.Clear();
            


            UnionNET.partWin.UpdateTriggerWindow();

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
            UnionNET.partWin.tabControlObjects.SelectedIndex = 3;
        }


        [DllExport]
        public static void AddActionTypeMover(IntPtr itemPtr)
        {
            string value = Marshal.PtrToStringAnsi(itemPtr);
            UnionNET.partWin.listBoxActionType.Items.Add(value);


            if (UnionNET.partWin.listBoxActionType.Items.Count > 0)
            {
                UnionNET.partWin.listBoxActionType.SelectedIndex = 0;
            }
        }


        [DllExport]
        public static void AddTargetToList(IntPtr itemPtr, uint addr)
        {
            string value = Marshal.PtrToStringAnsi(itemPtr);

            UnionNET.partWin.triggerEntry.targetListAddr.Add(addr);

            UnionNET.partWin.listBoxTargetList.Items.Add(value);
        }

        [DllExport]
        public static void CreateTriggerForm(int keyCurrent, int keyMax, IntPtr ptrName, int dyn, int stat)
        {
            string name = Marshal.PtrToStringAnsi(ptrName);

            UnionNET.partWin.triggerEntry.m_kf_pos = keyCurrent;
            UnionNET.partWin.triggerEntry.maxKey = keyMax;
            UnionNET.partWin.triggerEntry.name = name;
            UnionNET.partWin.triggerEntry.dynColl = Convert.ToBoolean(dyn);
            UnionNET.partWin.triggerEntry.statColl = Convert.ToBoolean(stat);
            UnionNET.partWin.listBoxTargetList.Items.Clear();
            UnionNET.partWin.listBoxActionType.Items.Clear();
            UnionNET.partWin.triggerEntry.targetListAddr.Clear();


            UnionNET.partWin.UpdateTriggerWindow();
            UnionNET.partWin.EnableTriggerWindow();
        }

        

        private void buttonRemoveKey_Click(object sender, EventArgs e)
        {
            Extern_OnKeyRemove();

            triggerEntry.m_kf_pos = Extern_GetCurrentKey();
            triggerEntry.maxKey = Extern_GetMaxKey();
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


            Extern_OnAddKey(mode);

            triggerEntry.m_kf_pos = Extern_GetCurrentKey();
            triggerEntry.maxKey = Extern_GetMaxKey();

            //ConsoleEx.WriteLineRed("CurrentKey: " + triggerEntry.m_kf_pos + "/" + triggerEntry.maxKey);
            UpdateTriggerWindow();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string name = listBoxActionType.GetItemText(listBoxActionType.SelectedItem);

            ConsoleEx.WriteLineRed("Send trigger: action " + name);
            Extern_SendTrigger(triggerEntry.currentActionIndex);
            triggerEntry.m_kf_pos = Extern_GetCurrentKey();
        }

        private void ParticleWin_Shown(object sender, EventArgs e)
        {
            //listBoxActionType.SelectedIndex = 0;
        }

        private void listBoxTargetList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBoxTargetList.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                uint addr = triggerEntry.targetListAddr[index];

                try
                {
                    UnionNET.objTreeWin.globalTree.SelectedNode =
                    ObjTree.globalEntries[addr].node;
                }
                catch
                {
                    ConsoleEx.WriteLineGreen("C#: triggetTargetList. Can't find vob with addr: " + Utils.ToHex(addr));
                }

                Extern_SelectVob(addr);
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

            if (listBoxResult.SelectedItem != null)
            {
                name = listBoxResult.GetItemText(listBoxResult.SelectedItem).Trim();


            }
            else if (listBoxItems.SelectedItem != null)
            {
                name = listBoxItems.GetItemText(listBoxItems.SelectedItem).Trim();
            }

            if (name != String.Empty)
            {
                if (UnionNET.objWin.tabControl1.SelectedIndex == 2 && UnionNET.objWin.dataGridView1.Visible
                    && UnionNET.objWin.buttonContainerApply.Enabled
                    )
                {
                    UnionNET.objWin.dataGridView1.Rows.Add(name, count);
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
    }
}
