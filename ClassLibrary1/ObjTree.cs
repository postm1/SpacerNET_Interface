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
        }

        static TreeNode node = null;

        public struct TreeEntry
        {

            public int zCVob;
            public int parent;
            public string name;
            TreeNode node;
        }

        public static List<TreeEntry> globalNodes = new List<TreeEntry>();
        //static Dictionary<TreeNode, TreeEntry> globalNodes = new Dictionary<TreeNode, TreeEntry>();

        [DllExport]
        public static void CreateTree()
        {
            //MessageBox.Show("CreateTree");
            TreeNodeCollection nodes = UnionNET.objTreeWin.globalTree.Nodes;

            for (int i = 0; i < globalNodes.Count; i++)
            {
                TreeNode node = nodes.Add(globalNodes[i].name);
                node.Tag = globalNodes[i].zCVob;
            }
        }
        
        [DllExport]
        public static void AddTreeNode(IntPtr ptr, int parent, int vob)
        {
            string name = Marshal.PtrToStringAnsi(ptr);
            TreeNodeCollection nodes = UnionNET.objTreeWin.globalTree.Nodes;


            if (name.Trim().Length == 0)
            {
                name = "_NoName";
            }

            TreeEntry entry = new TreeEntry();

            entry.name = name;
            entry.parent = parent;
            entry.zCVob = vob;
            globalNodes.Add(entry);
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

        [DllExport]
        public static void AddTreeNodeChild(IntPtr ptr)
        {
            string name = Marshal.PtrToStringAnsi(ptr);
            TreeNodeCollection nodes = UnionNET.objTreeWin.globalTree.Nodes;

            if (node != null)
            {
                node.Nodes.Add(name);
                node = null;
            }
            
        }

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SelectVob(int a);

        private void globalTree_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = globalTree.SelectedNode;

            int addr = Convert.ToInt32(node.Tag);
            Extern_SelectVob(addr);
            UnionNET.form.Focus();
        }

        private void globalTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }
    }
}
