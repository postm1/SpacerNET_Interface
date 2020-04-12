using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion
{
    public partial class ObjTree : Form
    {
        public ObjTree()
        {
            InitializeComponent();
            globalTree.DrawMode = TreeViewDrawMode.OwnerDrawText;
            globalTree.HideSelection = false;

        }

        public class TreeEntry
        {
            public int zCVob;
            public int parent;
            public string name;
            public TreeNode node;
            public string folderName;
            public string className;
            public bool isLevel;
        }

        public static List<TreeEntry> globalEntries = new List<TreeEntry>();
        //static Dictionary<TreeNode, TreeEntry> globalNodes = new Dictionary<TreeNode, TreeEntry>();


        public static TreeNode GetParentNode(int parentId)
        {
            //Console.WriteLine("Inside parent");

            TreeNodeCollection nodes = UnionNET.objTreeWin.globalTree.Nodes;

            for (int i = 0; i < nodes.Count; i++)
            {
                string tag = nodes[i].Tag.ToString();

                if (tag.Length == 0 || tag == "Class")
                {
                    continue;
                }

                //Console.WriteLine("Trying to convert " + tag);
                int addr = Convert.ToInt32(tag);

                if (addr == parentId)
                {
                   
                    return nodes[i];
                }
            }
            //Console.WriteLine("Found NULL");
            return null;
        }
        public static void AddVobToNodes(TreeEntry entry)
        {
            TreeNodeCollection nodes = UnionNET.objTreeWin.globalTree.Nodes;

            string className = entry.className;

            int classNameFoundPos = -1;

            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].Text == className)
                {
                    classNameFoundPos = i;
                    break;
                }
            }

            //Console.WriteLine("AddVobToNodes: " + entry.name + " Parent: " + entry.parent + " Class: " + entry.className);



            if (classNameFoundPos == -1)
            {
               
                TreeNode newNode = nodes.Add(className);
                newNode.Tag = "Class";
                newNode.ImageIndex = 0;
                newNode.SelectedImageIndex = 0;

                classNameFoundPos = newNode.Index;
            }
            
            if (entry.isLevel)
            {
                //Console.WriteLine("LevelCompo: " + entry.name + " Parent: " + entry.parent + " Class: " + entry.className);
                TreeNode node = nodes[classNameFoundPos].Nodes.Add(entry.zCVob + " " + entry.name + "[" + entry.parent + "]");
                node.Tag = entry.zCVob;
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;
                entry.node = node;
            }
            else if (entry.parent != 0)
            {

               // Console.WriteLine("Pre parent");

                TreeNode parent = GetParentNode(entry.parent);
               // Console.WriteLine("After parent");

                if (parent != null)
                {
                    //Console.WriteLine("Parent ok");
                    string name = entry.name; //entry.zCVob + " " + entry.name + "[" + entry.parent + "]"
                    TreeNode node = parent.Nodes.Add(name);
                    node.Tag = entry.zCVob;
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;
                    entry.node = node;
                }
                else
                {
                    //Console.WriteLine("Parent null");
                    string name = entry.name; //"!!! : " + entry.zCVob + " " + entry.name + "[" + entry.parent + "]"
                    TreeNode node = nodes[classNameFoundPos].Nodes.Add(name);
                    node.Tag = entry.zCVob;
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;
                    entry.node = node;
                }
            }
            else
            {
                //Console.WriteLine("3: " + entry.name + " Parent: " + entry.parent + " Class: " + entry.className);
                string name = entry.name; //entry.zCVob + " " + entry.name + "[" + entry.parent + "]"
                TreeNode node = nodes[classNameFoundPos].Nodes.Add(name);
                node.Tag = entry.zCVob;
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;
                entry.node = node;
            }
            //Console.WriteLine("Entry Node: " + entry.node.Text);

        }
        [DllExport]
        public static void CreateTree()
        {
            Console.WriteLine("CreateTree");
            //TreeNodeCollection nodes = UnionNET.objTreeWin.globalTree.Nodes;

            for (int i = 0; i < globalEntries.Count; i++)
            {
               // Console.WriteLine("AddVobToNodes: " + i);

                AddVobToNodes(globalEntries[i]);
            }
            
        }

        [DllExport]
        public static void OnSelectVob(int ptr)
        {
            Console.WriteLine("OnSelectVob: " + ptr);

            if (ptr == 0)
            {
                return;
            }



            //MessageBox.Show(ptr.ToString());
            for (int i = 0; i < globalEntries.Count; i++)
            {
                // Console.WriteLine("AddVobToNodes: " + i);

                

                if (globalEntries[i].zCVob == ptr)
                {
                    TreeNode node = globalEntries[i].node;
                    //Console.WriteLine(node.Text);

                    if (node == null)
                    {
                        Console.WriteLine("OnSelectVob addr " + ptr + ", node is null, index is " + i);
                    }
                    else
                    {
                        UnionNET.objTreeWin.globalTree.SelectedNode = globalEntries[i].node;
                        //UnionNET.objTreeWin.globalTree.SelectedNode.Expand();
                    }
                    
                   
                    break;
                }
            }
        }

        [DllExport]
        public static void AddTreeNode(IntPtr ptr, int parent, int vob, IntPtr visual, IntPtr classNamePtr, int isLevel)
        {
            string name = Marshal.PtrToStringAnsi(ptr);
            TreeNodeCollection nodes = UnionNET.objTreeWin.globalTree.Nodes;
            string visualName = Marshal.PtrToStringAnsi(visual);
            string className = Marshal.PtrToStringAnsi(classNamePtr);

            //Console.WriteLine("Got a name {" + name + "}");

            TreeEntry entry = new TreeEntry();

            entry.name = name;
            entry.parent = parent;
            entry.zCVob = vob;
            entry.className = className;
            entry.isLevel = Convert.ToBoolean(isLevel);
            globalEntries.Add(entry);
            /*

            if (globalNodes.ContainsValue(parent))
            {
                TreeNode existNode = globalNodes.Where(pair => pair.Value == parent)
                    .Select(pair => pair.Key)
                    .First();

                if (existNode != null)
                {
                    existNode.Nodes.Add(name);
                }
                else
                {
                    Console.WriteLine("No parent found");
                }
            }
            else
            {
                node = nodes.Add(name);
                globalNodes.Add(node, parent);
            }
            */


        }


        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SelectVob(int a);

        private void globalTree_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = globalTree.SelectedNode;

            string tag = node.Tag.ToString();

            if (tag.Length == 0 || tag == "Class")
            {
                return;
            }

            int addr = Convert.ToInt32(node.Tag);
            Extern_SelectVob(addr);
            UnionNET.form.Focus();
        }

        private void globalTree_DrawNode(object sender, DrawTreeNodeEventArgs e)
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

        private void buttonCollapse_Click(object sender, EventArgs e)
        {
            globalTree.CollapseAll();
        }

        private void buttonExpand_Click(object sender, EventArgs e)
        {
            globalTree.ExpandAll();
        }
    }
}
