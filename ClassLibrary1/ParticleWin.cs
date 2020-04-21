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

namespace SpacerUnion
{
    public partial class ParticleWin : Form
    {
        public static List<string> listVisuals = new List<string>();
        public ParticleWin()
        {
            InitializeComponent();
        }

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreateItem(IntPtr name);

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreatePFX(IntPtr name);


        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreateNewVob(IntPtr name, IntPtr vobName, int dyn, int stat);

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreateNewVobVisual(IntPtr name, IntPtr vobName, IntPtr visual, int dyn, int stat);


        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_ConnectWP();

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_DisconnectWP();


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

                if (strToFind.Length == 0)
                {
                    return;
                }


                for (int i = 0; i < listBoxItems.Items.Count; i++)
                {
                    string value = listBoxItems.GetItemText(listBoxItems.Items[i]);

                    if (Regex.IsMatch(value, strToFind))
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

            if (name == "oCItem")
            {
                MessageBox.Show("Итемы создаются во вкладке правее!");
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

        private void buttonWP_Click(object sender, EventArgs e)
        {
            string name = "zCVobWaypoint";

            string vobName = textBoxWP.Text.Trim();

            Console.WriteLine("C#: OnCreateVob: ClassDef: " + name);

            IntPtr ptrName = Marshal.StringToHGlobalAnsi(name);
            IntPtr ptrVobName = Marshal.StringToHGlobalAnsi(vobName);

            Extern_CreateNewVob(ptrName, ptrVobName, 0, 0);
            Marshal.FreeHGlobal(ptrName);
        }

        private void buttonFP_Click_1(object sender, EventArgs e)
        {
            string name = "zCVobSpot";

            string vobName = textBoxFP.Text.Trim();

            Console.WriteLine("C#: OnCreateVob: ClassDef: " + name);

            IntPtr ptrName = Marshal.StringToHGlobalAnsi(name);
            IntPtr ptrVobName = Marshal.StringToHGlobalAnsi(vobName);

            Extern_CreateNewVob(ptrName, ptrVobName, 0, 0);
            Marshal.FreeHGlobal(ptrName);
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

                if (strToFind.Length == 0)
                {
                    return;
                }


                for (int i = 0; i < listBoxParticles.Items.Count; i++)
                {
                    string value = listBoxParticles.GetItemText(listBoxParticles.Items[i]);

                    if (Regex.IsMatch(value, strToFind))
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

                if (strToFind.Length == 0)
                {
                    return;
                }


                for (int i = 0; i < listVisuals.Count; i++)
                {

                    if (Regex.IsMatch(listVisuals[i], strToFind))
                    {
                        listBoxVisuals.Items.Add(listVisuals[i]);
                    }
                }

                
            }
        }
    }
}
