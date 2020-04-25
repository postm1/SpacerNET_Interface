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
using System.Windows.Forms;

namespace SpacerUnion
{
    public partial class ObjTree : Form
    {

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Extern_GetOpenPath(int type);

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetOpenPath(IntPtr str, int type);

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SaveVobTree(IntPtr str);

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_OpenVobTree(IntPtr str, bool globalInsert);

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SelectVobSync(int a);

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SelectVob(int a);

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_BlockMouse(bool disable);

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_RemoveVob(int vob);

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);















        const string TAG_FOLDER = "folder";

        private const int TVM_SETEXTENDEDSTYLE = 0x1100 + 44;
        private const int TVM_GETEXTENDEDSTYLE = 0x1100 + 45;
        private const int TVS_EX_DOUBLEBUFFER = 0x0004;


        public class TreeEntry
        {
            public int zCVob;
            public int parent;
            public string name;
            public TreeNode node;
            public string folderName;
            public string className;
            public bool isLevel;
            public TreeEntry parentEntry;
            public List<TreeEntry> childs;
            public bool toDelete;
            public TreeEntry()
            {
                parentEntry = null;
                childs = new List<TreeEntry>();
                toDelete = false;
            }

        }

        public class ParentResult
        {
            public TreeNode node;
            public bool isCompo;
            public TreeEntry parentEntry;
        }

        public static List<TreeEntry> globalEntries = new List<TreeEntry>();


        public ObjTree()
        {
            InitializeComponent();
            globalTree.DrawMode = TreeViewDrawMode.OwnerDrawText;
            globalTree.HideSelection = false;


            //SendMessage(globalTree.Handle, TVM_SETEXTENDEDSTYLE, (IntPtr)TVS_EX_DOUBLEBUFFER, (IntPtr)TVS_EX_DOUBLEBUFFER);

        }

        

  
        public static int CreateAndGetFolder(string className)
        {
            TreeNodeCollection nodes = UnionNET.objTreeWin.globalTree.Nodes;

            int classNameFoundPos = -1;

            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].Text == className)
                {
                    classNameFoundPos = i;
                    break;
                }
            }

            if (classNameFoundPos == -1)
            {

                TreeNode newNode = nodes.Add(className);
                newNode.Tag = TAG_FOLDER;
                newNode.ImageIndex = 0;
                newNode.SelectedImageIndex = 0;

                classNameFoundPos = newNode.Index;
            }

            return classNameFoundPos;
        }


        

        public static ParentResult GetParentResult(int parentId)
        {
            TreeEntry entry = globalEntries
                    .Where(pair => pair.zCVob == parentId)
                    .Select(pair => pair)
                    .FirstOrDefault();

            ParentResult result = null;


            if (entry != null)
            {
                result = new ParentResult();
               // Console.WriteLine("Parent found " + entry.zCVob);
                result.isCompo = entry.isLevel;
                result.node = entry.node;
                result.parentEntry = entry;
            }

            return result;
        }

        public static int noParentCount = 0;

        public static void ApplyNodeImage(string className, TreeNode node, bool isNew=false)
        {
            if (isNew)
            {
                node.ImageIndex = 3;
                node.SelectedImageIndex = 3;
                return;
            }

            if (className == "zCVobWaypoint" || className == "zCVobSpot")
            {
                node.ImageIndex = 2;
                node.SelectedImageIndex = 2;
            }
            else
            {
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;
            }
        }

        public static void AddVobToNodes(TreeEntry entry)
        {
            TreeNodeCollection nodes = UnionNET.objTreeWin.globalTree.Nodes;

            string className = entry.className;

            int classNameFoundPos = -1;

            classNameFoundPos = CreateAndGetFolder(className);

            // levelCompo или воб без родителя
            if (entry.isLevel || entry.parent == 0)
            {
                if (entry.isLevel)
                {
                   // Console.WriteLine("LevelCompo: " + entry.name + " Address: " + entry.zCVob + " Class: " + entry.className);
                }

               
                TreeNode node = nodes[classNameFoundPos].Nodes.Add(entry.name);
                node.Tag = entry.zCVob;
                
                entry.node = node;

                ApplyNodeImage(className, node);


            }
            else if (entry.parent != 0)
            {
                //Console.WriteLine("Try parent: " + entry.name + " Parent: " + entry.parent + " Class: " + entry.className);
                ParentResult parentResult = GetParentResult(entry.parent);

                if (parentResult != null)
                {
                    if (!parentResult.isCompo)
                    {
                        TreeNode parentNode = parentResult.node;

                        if (parentNode == null)
                        {
                            noParentCount++;
                            //Console.WriteLine("Parent node is null. ParentAddr: " + entry.parent 
                              //  + " Child: " + entry.name + " Parent: " + parentResult.parentEntry.name);
                            return;
                        }


                        string name = entry.name; //entry.zCVob + " " + entry.name + "[" + entry.parent + "]"
                                                  //Console.WriteLine("Parent ok");

                        TreeNode node = parentNode.Nodes.Add(name);
                        node.Tag = entry.zCVob;
                        node.ImageIndex = 1;
                        node.SelectedImageIndex = 1;
                        entry.node = node;
                        ApplyNodeImage(className, node);
                    }
                    else
                    {
                        string name = entry.name; //"!!! : " + entry.zCVob + " " + entry.name + "[" + entry.parent + "]"


                        TreeNode node = nodes[classNameFoundPos].Nodes.Add(name);
                        node.Tag = entry.zCVob;
                        node.ImageIndex = 1;
                        node.SelectedImageIndex = 1;
                        entry.node = node;
                        ApplyNodeImage(className, node);
                    }
                    
                   
                }
                else
                {
                    noParentCount++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(noParentCount + " Parent " + entry.parent + " is null: " + entry.name);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                /*
                else
                {
                    Console.WriteLine("Parent is null: " + entry.name);
                    string name = entry.name; //"!!! : " + entry.zCVob + " " + entry.name + "[" + entry.parent + "]"
                    TreeNode node = nodes[classNameFoundPos].Nodes.Add(name);
                    node.Tag = entry.zCVob;
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;
                    entry.node = node;
                }
                */
            }
            //Console.WriteLine("Entry Node: " + entry.node.Text);

        }

        public static void CreateTreeRecursive()
        {
            noParentCount = 0;

            for (int i = 0; i < globalEntries.Count; i++)
            {
                AddVobToNodes(globalEntries[i]);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Не смог вставить вобов: " + noParentCount + "/" + globalEntries.Count);
            Console.ForegroundColor = ConsoleColor.White;

        }

        [DllExport]
        public static void CreateTree()
        {
            CreateTreeRecursive();
        }

        
        [DllExport]
        public static void UpdateVobName(int ptr, IntPtr namePtr)
        {
            if (ptr == 0)
            {
                return;
            }

            Stopwatch s = new Stopwatch();
            s.Start();


            string name = Marshal.PtrToStringAnsi(namePtr);



            

            TreeEntry entry = globalEntries.Where(pair => pair.zCVob == ptr)
                .Select(pair => pair)
                .FirstOrDefault();

            if (entry != null)
            {
                if (entry.node != null)
                {
                    entry.name = name;
                    entry.node.Text = name;
                }
            }

            s.Stop();
            string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));
            Console.WriteLine("C#: UpdateName for vob: " + ptr + " Time: " + timeSpend);


        }

        [DllExport]
        public static void OnSelectVob(int ptr)
        {
            //Console.WriteLine("C#: OnSelectVob: " + ptr);

            if (ptr == 0)
            {
                return;
            }




            TreeEntry entry = globalEntries.Where(pair => pair.zCVob == ptr)
                .Select(pair => pair)
                .FirstOrDefault();


            if (entry != null)
            {
                if (entry.node != null)
                {
                    UnionNET.objTreeWin.globalTree.SelectedNode = entry.node;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("C#: OnSelectVob: found  node is null, vob is " + ptr);
                    Console.ForegroundColor = ConsoleColor.White;
                }
               
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("C#: OnSelectVob: Can't find vob in globalEntries: " + ptr);
                //Console.WriteLine("C#: OnSelectVob: Adding vob to the list: " + ptr);
                Console.ForegroundColor = ConsoleColor.White;


                /*
                TreeEntry newEntry = new TreeEntry();

                globalEntries.Add(newEntry);
                AddVobToNodes(newEntry);
                */
            }

           
        }


        public static void RemoveChildNodesRecursive(TreeEntry entry)
        {
            for (int i = 0; i < entry.childs.Count; i++)
            {
                RemoveChildNodesRecursive(entry.childs[i]);
            }

            if (entry.node != null)
            {
                Console.WriteLine("C#: Remove node: " + entry.node.Text + " Parent: " + entry.parent);
                entry.node.Remove();
            }
            else
            {
                Console.WriteLine("C#: Remove node failure. Node is null");
            }

            entry.childs.Clear();
            entry.toDelete = true;
            entry.node = null;
        }
        [DllExport]
        public static void OnVobRemove(int vob)
        {
            TreeNodeCollection nodes = UnionNET.objTreeWin.globalTree.Nodes;

            Console.WriteLine("=============================");
            Console.WriteLine("C#: OnVobRemove: " + vob);
            Console.WriteLine("GlobalEntries count: " + globalEntries.Count);

            if (vob == 0)
            {
                return;
            }


            List<TreeEntry> entries = globalEntries
                    .Where(pair => pair.zCVob == vob)
                    .ToList();


            //Console.WriteLine("Found entries with Vob value: " + entries.Count);

            if (entries.Count > 0)
            {
                TreeEntry entry = entries[0];

                RemoveChildNodesRecursive(entry);

                globalEntries = globalEntries
                        .Where(pair => !pair.toDelete)
                        .ToList();
            }

            Console.WriteLine("GlobalEntries count: " + globalEntries.Count);
            Console.WriteLine("=============================");
        }

        [DllExport]
        public static void OnVobInsert(IntPtr ptr, int vob, int parent, IntPtr classNamePtr)
        {
            string name = Marshal.PtrToStringAnsi(ptr);
            string className = Marshal.PtrToStringAnsi(classNamePtr);

            TreeNodeCollection nodes = UnionNET.objTreeWin.globalTree.Nodes;

           

            int classNameFoundPos = -1;

            classNameFoundPos = CreateAndGetFolder(className);

            TreeEntry entry = new TreeEntry();

            entry.name = name;
            entry.parent = parent;
            entry.zCVob = vob;
            entry.className = className;
            entry.isLevel = entry.className == "zCVobLevelCompo";
            globalEntries.Add(entry);


            for (int i = 0; i < globalEntries.Count; i++)
            {
                if (globalEntries[i].zCVob == entry.parent)
                {
                    //Console.WriteLine("Add parent");

                    entry.parentEntry = globalEntries[i];
                    globalEntries[i].childs.Add(entry);
                    break;
                }
            }


            ParentResult parentResult = GetParentResult(parent);


            if (parent == 0)
            {
                TreeNode node = nodes[classNameFoundPos].Nodes.Add(name);
                node.Tag = vob;
                entry.node = node;
                ApplyNodeImage(className, node, true);
                UnionNET.objTreeWin.globalTree.SelectedNode = node;
                Console.WriteLine("C# OnVobInsert globally: " + name + " parent: " + parent + " className: " + className);
            }
            else
            {

                if (parentResult != null)
                {
                    if (parentResult.node != null)
                    {
                        TreeNode node = null;

                        if (parentResult.parentEntry.isLevel)
                        {
                            node = nodes[classNameFoundPos].Nodes.Add(name);
                            Console.WriteLine("C# OnVobInsert: " + name + " parent: " + parentResult.parentEntry.name + " " + parent + " (Compo)");
                        }
                        else
                        {
                            node = parentResult.node.Nodes.Add(name);
                            Console.WriteLine("C# OnVobInsert: " + name + " parent: " + parentResult.parentEntry.name  + " " + parent + " (Node)");
                        }
                       
                        node.Tag = vob;
                        entry.node = node;
                        ApplyNodeImage(className, node, true);
                        UnionNET.objTreeWin.globalTree.SelectedNode = node;

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("C# OnVobInsert: parentResult.Node is null");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("C# OnVobInsert: parentResult is null");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("C#: GlobalCountEntries: " + globalEntries.Count);
            Console.ForegroundColor = ConsoleColor.White;
        }

        [DllExport]
        public static void AddTreeNode(IntPtr ptr, int vob, int parent, IntPtr classNamePtr)
        {
            string name = Marshal.PtrToStringAnsi(ptr);
            string className = Marshal.PtrToStringAnsi(classNamePtr);
            TreeNodeCollection nodes = UnionNET.objTreeWin.globalTree.Nodes;

            TreeEntry entry = new TreeEntry();

            entry.name = name;
            entry.parent = parent;
            entry.zCVob = vob;
            entry.className = className;
            entry.isLevel = entry.className == "zCVobLevelCompo";
            globalEntries.Add(entry);

            for (int i = 0; i < globalEntries.Count; i++)
            {
                if (globalEntries[i].zCVob == entry.parent)
                {
                    entry.parentEntry = globalEntries[i];
                    globalEntries[i].childs.Add(entry);
                    break;
                }
            }
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

        private void ObjTree_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }


        


        private void globalTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }

        private void globalTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = globalTree.SelectedNode;

            string tag = node.Tag.ToString();

            Console.WriteLine("C#: OnSelectDoubleClick: " + tag);


            if (tag.Length == 0 || tag == TAG_FOLDER)
            {
                return;
            }

            int addr = Convert.ToInt32(node.Tag);
            
            Extern_SelectVob(addr);
            UnionNET.form.Focus();
        }

        private void globalTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = globalTree.SelectedNode;

            string tag = node.Tag.ToString();

            Console.WriteLine("C#: AfterSelect event: " + tag);

            if (tag.Length == 0 || tag == TAG_FOLDER)
            {
                return;
            }

            int addr = Convert.ToInt32(node.Tag);

            if (node.Text.Contains("zCVobWaypoint") || node.Text.Contains("zCVobSpot"))
            {
                UnionNET.partWin.tabControlObjects.SelectedIndex = 4;
            }
            Extern_SelectVobSync(addr);
            UnionNET.form.Focus();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (UnionNET.objTreeWin.globalTree.SelectedNode == null)
            {
                return;
            }

            TreeNode node = globalTree.SelectedNode;

            string tag = node.Tag.ToString();

            if (tag.Length == 0 || tag == TAG_FOLDER)
            {
                return;
            }


            saveFileDialogVobTree.Filter = "Zen file (*.zen)|";
            IntPtr ptrPath = Extern_GetOpenPath((int)CmdType.TreeVobPath);
            string path = Marshal.PtrToStringAnsi(ptrPath);

            string fileName = UnionNET.objTreeWin.globalTree.SelectedNode.Text;

            //MessageBox.Show(path);

            if (path != "")
            {
                //MessageBox.Show(path);
                saveFileDialogVobTree.InitialDirectory = System.IO.Path.GetDirectoryName(@path + @"/");
            }
            else
            {
                saveFileDialogVobTree.InitialDirectory = @Directory.GetCurrentDirectory() + @"../_WORK/DATA/Worlds/";
            }

            saveFileDialogVobTree.RestoreDirectory = true;
            saveFileDialogVobTree.FileName = fileName + ".ZEN";

            //Extern_BlockMouse(true);

            if (saveFileDialogVobTree.ShowDialog() == DialogResult.OK)
            {

                IntPtr ptrPathSave = Marshal.StringToHGlobalAnsi(Path.GetDirectoryName(saveFileDialogVobTree.FileName));

                Extern_SetOpenPath(ptrPathSave, (int)CmdType.TreeVobPath);



                string filePath = saveFileDialogVobTree.FileName;
                IntPtr filePathPtr = Marshal.StringToHGlobalAnsi(filePath);
                Extern_SaveVobTree(filePathPtr);

                Marshal.FreeHGlobal(ptrPathSave);
                Marshal.FreeHGlobal(filePathPtr);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (globalTree.SelectedNode == null)
            {
                return;
            }

            TreeNode node = globalTree.SelectedNode;

            string tag = node.Tag.ToString();

            if (tag.Length == 0 || tag == TAG_FOLDER)
            {
                return;
            }


            openFileDialogVobTree.Filter = "Zen file (*.zen)|";
            IntPtr ptrPath = Extern_GetOpenPath((int)CmdType.TreeVobPath);
            string path = Marshal.PtrToStringAnsi(ptrPath);

            string fileName = UnionNET.objTreeWin.globalTree.SelectedNode.Text;

            //MessageBox.Show(path);

            if (path != "")
            {
                //MessageBox.Show(path);
                openFileDialogVobTree.InitialDirectory = System.IO.Path.GetDirectoryName(@path + @"/");
            }
            else
            {
                openFileDialogVobTree.InitialDirectory = @Directory.GetCurrentDirectory() + @"../_WORK/DATA/Worlds/";
            }

            openFileDialogVobTree.RestoreDirectory = true;

            //Extern_BlockMouse(true);

            if (openFileDialogVobTree.ShowDialog() == DialogResult.OK)
            {

                IntPtr ptrPathSave = Marshal.StringToHGlobalAnsi(Path.GetDirectoryName(openFileDialogVobTree.FileName));

                Extern_SetOpenPath(ptrPathSave, (int)CmdType.TreeVobPath);



                string filePath = openFileDialogVobTree.FileName;
                IntPtr filePathPtr = Marshal.StringToHGlobalAnsi(filePath);
                Extern_OpenVobTree(filePathPtr, false);

                Marshal.FreeHGlobal(ptrPathSave);
                Marshal.FreeHGlobal(filePathPtr);
            }
        }

        private void вставитьVobTreeГлобальноToolStripMenuItem_Click(object sender, EventArgs e)
        {


            openFileDialogVobTree.Filter = "Zen file (*.zen)|";
            IntPtr ptrPath = Extern_GetOpenPath((int)CmdType.TreeVobPath);
            string path = Marshal.PtrToStringAnsi(ptrPath);

            string fileName = UnionNET.objTreeWin.globalTree.SelectedNode.Text;

            //MessageBox.Show(path);

            if (path != "")
            {
                //MessageBox.Show(path);
                openFileDialogVobTree.InitialDirectory = System.IO.Path.GetDirectoryName(@path + @"/");
            }
            else
            {
                openFileDialogVobTree.InitialDirectory = @Directory.GetCurrentDirectory() + @"../_WORK/DATA/Worlds/";
            }

            openFileDialogVobTree.RestoreDirectory = true;

            //Extern_BlockMouse(true);

            if (openFileDialogVobTree.ShowDialog() == DialogResult.OK)
            {

                IntPtr ptrPathSave = Marshal.StringToHGlobalAnsi(Path.GetDirectoryName(openFileDialogVobTree.FileName));

                Extern_SetOpenPath(ptrPathSave, (int)CmdType.TreeVobPath);



                string filePath = openFileDialogVobTree.FileName;
                IntPtr filePathPtr = Marshal.StringToHGlobalAnsi(filePath);
                Extern_OpenVobTree(filePathPtr, true);

                Marshal.FreeHGlobal(ptrPathSave);
                Marshal.FreeHGlobal(filePathPtr);
            }
        }

        private void удалитьВобToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globalTree.SelectedNode == null)
            {
                return;
            }

            TreeNode node = globalTree.SelectedNode;

            string tag = node.Tag.ToString();

            if (tag.Length == 0 || tag == TAG_FOLDER)
            {
                return;
            }

            int vob = 0;

            int.TryParse(tag, out vob);

            Extern_RemoveVob(vob);

        }

        private void globalTree_NodeMouseClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            globalTree.SelectedNode = e.Node;
        }

        private void buttonTreeSort_Click(object sender, EventArgs e)
        {
            globalTree.Sort();
        }
    }
}
