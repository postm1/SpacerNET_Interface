
using SpacerUnion.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion
{
   

    public partial class ObjTree : Form
    {

        public static TreeNode previousSelectedNode = null;
        public static QuickVobsManager quickVobMan = null;


        public static Dictionary<uint, TreeEntry> globalEntries = new Dictionary<uint, TreeEntry>();
        public static Dictionary<uint, TreeEntry> matEntries = new Dictionary<uint, TreeEntry>();
        public static Dictionary<uint, TreeEntry> tempEntries = new Dictionary<uint, TreeEntry>();
        private static Dictionary<string, TreeNode> _folderCache = new Dictionary<string, TreeNode>();


        static bool nextAfterEventBlocked = false;
        static TreeNode lastSelectedNode = null;
        static bool IsWaypointReload = false;

        public ObjTree()
        {
            InitializeComponent();
            quickVobMan = new QuickVobsManager();

            //this.imageListObjects.ImageSize = new Size(16, 16);
        }

        public void UpdateLang()
        {
            this.Text = Localizator.Get("WIN_TREE_TITLE");
            buttonCollapse.Text = Localizator.Get("buttonCollapse");
            buttonExpand.Text = Localizator.Get("buttonExpand");
            buttonTreeSort.Text = Localizator.Get("buttonTreeSort");

            contextMenuStripTree.Items[0].Text = Localizator.Get("CONTEXTMENU_TREE_INSERT_VOBTREE_PARENT");
            contextMenuStripTree.Items[1].Text = Localizator.Get("CONTEXTMENU_TREE_INSERT_VOBTREE_GLOBAL");
            contextMenuStripTree.Items[2].Text = Localizator.Get("CONTEXTMENU_TREE_SAVE_VOBTREE");
            contextMenuStripTree.Items[3].Text = Localizator.Get("CONTEXTMENU_TREE_REMOVE_VOB");
            //---------------------------------
            contextMenuStripTree.Items[5].Text = Localizator.Get("CONTEXTMENU_TREE_ADD_PARENT");
            contextMenuStripTree.Items[6].Text = Localizator.Get("CONTEXTMENU_TREE_REMOVE_PARENT");
            contextMenuStripTree.Items[7].Text = Localizator.Get("CONTEXTMENU_TREE_ADD_VOB");
            //---------------------------------
            contextMenuStripTree.Items[9].Text = Localizator.Get("CONTEXTMENU_TREE_RESTORE_POS");
            contextMenuStripTree.Items[10].Text = Localizator.Get("CONTEXTMENU_TREE_REPLACE_FROM_PARENT");


            contextMenuStripTree.Items[12].Text = Localizator.Get("CONTEXTMENU_SAVE_VISUAL_TO_FILE");
            allChildrenVobsToolStripMenuItem.Text = Localizator.Get("CONTEXTMENU_SAVE_VISUAL_TO_FILE_CHILDREN");
            onlyParentVobToolStripMenuItem.Text = Localizator.Get("CONTEXTMENU_SAVE_VISUAL_TO_FILE_ONLY_PARENT");



            tabControlObjectList.TabPages[0].Text = Localizator.Get("TAB_PAGE_OBJECTS");
            tabControlObjectList.TabPages[1].Text = Localizator.Get("QUICKVOBS_ACCESS");
            // tabControlObjectList.TabPages[2].Text = Localizator.Get("TAB_PAGE_MATERIALS");

            contextMenuQuick.Items[0].Text = Localizator.Get("CONTEXTMENU_TREE_REMOVE_PARENT");
            contextMenuQuick.Items[1].Text = Localizator.Get("CONTEXTMENU_FAST_REMOVE_VOB");
            contextMenuQuick.Items[2].Text = Localizator.Get("CONTEXTMENU_TREE_CREATE_CAMERA_START_POS");
            /*
            buttonCollapseMatTree.Text = Localizator.Get("buttonCollapse");
            buttonExpandMatTree.Text = Localizator.Get("buttonExpand");
            buttonSortMatTree.Text = Localizator.Get("buttonTreeSort");
            */
        }

        

  
        public static int CreateAndGetFolder(string className)
        {
            /*
            TreeNodeCollection nodes = SpacerNET.objTreeWin.globalTree.Nodes;

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
                newNode.Tag = Constants.TAG_FOLDER;
                newNode.ImageIndex = 0;
                newNode.SelectedImageIndex = 0;

                classNameFoundPos = newNode.Index;
            }

            return classNameFoundPos;
            */
            if (_folderCache.TryGetValue(className, out TreeNode cachedNode))
                return cachedNode.Index;

            TreeNodeCollection nodes = SpacerNET.objTreeWin.globalTree.Nodes;

            // Создаем новую папку только если её нет в кэше
            TreeNode newNode = nodes.Add(className);
            newNode.Tag = Constants.TAG_FOLDER;
            newNode.ImageIndex = 0;
            newNode.SelectedImageIndex = 0;

            _folderCache[className] = newNode;
            return newNode.Index;
        }


        public static int CreateAndGetFolderQuickTree(string className)
        {
            TreeNodeCollection nodes = SpacerNET.objTreeWin.quickTree.Nodes;

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
                newNode.Tag = Constants.TAG_FOLDER;
                newNode.ImageIndex = 0;
                newNode.SelectedImageIndex = 0;

                classNameFoundPos = newNode.Index;
            }

            return classNameFoundPos;
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
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;
            }
            else
            {
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;
            }

            if (node.Tag.ToString() == Constants.TAG_FOLDER)
            {
                node.ImageIndex = 0;
                node.SelectedImageIndex = 0;
            }

        }

        public static void AddVobToNodes(TreeEntry entry)
        {
            TreeNodeCollection nodes = SpacerNET.objTreeWin.globalTree.Nodes;

            string className = entry.className;

            int classNameFoundPos = -1;

            classNameFoundPos = CreateAndGetFolder(className);

            // levelCompo или воб без родителя
            if (entry.isLevel || entry.parent == 0)
            {
                TreeNode node = nodes[classNameFoundPos].Nodes.Add(entry.name);
                node.Tag = entry.zCVob;
                
                entry.node = node;

                ApplyNodeImage(className, node);

            }
            else if (entry.parentEntry != null)
            {
                if (!entry.parentEntry.isLevel)
                {
                    TreeNode parentNode = entry.parentEntry.node;

                    if (parentNode == null)
                    {
                        noParentCount++;


                        ConsoleEx.WriteLineRed(noParentCount + " ParentNode " + Utils.ToHex(entry.parent) + " is null: " + entry.name);
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


                ConsoleEx.WriteLineRed(noParentCount + " ParentEntry " + Utils.ToHex(entry.parent) + " is null: " + entry.name);


                Utils.WriteToFile(String.Format("AddVobToNodes: Parent entry is null, parent {0}, name {1}", entry.parent, entry.name));
            }

        }




        [DllExport]

        public static void ClearSelectedObjectInObjTree()
        {
            SpacerNET.objTreeWin.globalTree.SelectedNode = null;
        }


        [DllExport]
        public static void ClearAllEntries()
        {
            SpacerNET.objTreeWin.globalTree.Nodes.Clear();
            SpacerNET.objTreeWin.quickTree.Nodes.Clear();
           // SpacerNET.objTreeWin.matTree.Nodes.Clear();

            globalEntries.Clear();
            matEntries.Clear();
            quickVobMan.Clear();
            quickVobMan.Clear();
            _folderCache.Clear();

            //SpacerNET.objTreeWin.tabControlObjectList.SelectedIndex = 0;

            CreateAndGetFolderQuickTree(Localizator.Get("QUICKVOBS_PARENT"));
            CreateAndGetFolderQuickTree(Localizator.Get("QUICKVOBS_ACCESS"));
        }




        // Обновление родителя для сущ. воба
        [DllExport]
        public static void updateParentAddNode(uint ptr, uint ptrParent)
        {
            if (ptr == 0)
            {
                return;
            }

            TreeEntry entryParent = null;
            TreeEntry entry = null;

            try
            {
                entryParent = globalEntries
                    .Where(x => x.Value.zCVob == ptrParent)
                    .Select(pair => pair.Value)
                    .FirstOrDefault();

                entry = globalEntries
                    .Where(x => x.Value.zCVob == ptr)
                    .Select(pair => pair.Value)
                    .FirstOrDefault();
            }
            catch
            {
                Utils.Error("updateParentAddNode fail. No parent found. Addr vob: " + Utils.ToHex(ptr));
            }

            if (entryParent != null && entry != null)
            {
                ConsoleEx.WriteLineGreen("Обновляю родителя для воба: " + entry.name);
                entry.parent = ptrParent;
                entry.parentEntry = entryParent;
                entryParent.childs.Add(entry);

                TreeNodeCollection nodes = SpacerNET.objTreeWin.globalTree.Nodes;

                AddVobToNodes(entry);
            }

            
            //ConsoleEx.WriteLineGreen("Всего вобов в списке: " + globalEntries.Count);
            countNodeView = 0;
            CalcNodesCount(SpacerNET.objTreeWin.globalTree.Nodes);
           // ConsoleEx.WriteLineGreen("C#: Всего узлов TreeView: " + countNodeView);


        }
        [DllExport]
        public static void UpdateParentRemoveNode(uint ptr)
        {
            if (ptr == 0)
            {
                return;
            }

            TreeEntry entry = null;

            try
            {
                entry = globalEntries
                    .Where(x => x.Value.zCVob == ptr)
                    .Select(pair => pair.Value)
                    .FirstOrDefault();
        
            }
            catch
            {
                Utils.Error("C#: UpdateParentRemoveNode fail. No vob found in globalList. Addr: " + Utils.ToHex(ptr));
            }

            if (entry != null)
            {
                if (entry.node != null)
                {
                    entry.node.Remove();

                    if (entry.parentEntry != null)
                    {
                        entry.parentEntry.childs.Remove(entry);
                    }
                }
            }
        }



        [DllExport]
        public static void UpdateVobName(uint ptr)
        {
            if (ptr == 0)
            {
                return;
            }

            Stopwatch s = new Stopwatch();
            s.Start();

            string name = Imports.Stack_PeekString();

            TreeEntry entry = null;

            try
            {
                entry = globalEntries
                    .Where(x => x.Value.zCVob == ptr)
                    .Select(pair => pair.Value)
                    .FirstOrDefault();
            }
            catch
            {
                ConsoleEx.WriteLineRed("UpdateName fail. No vob found in globalList. Addr: " + Utils.ToHex(ptr));

                Utils.WriteToFile(String.Format("UpdateName: No vob found in globalList addr: {0}, name {1}", Utils.ToHex(ptr), name));
            }


            if (entry != null)
            {
                if (entry.node != null)
                {
                    entry.name = name;
                    entry.node.Text = name;
                    SpacerNET.objTreeWin.globalTree.SelectedNode = entry.node;
                }
            }


            ConsoleEx.WriteLineGreen("UpdateName for vob: " + Utils.ToHex(ptr));


        }


        [DllExport]
        public static void SelectNode(uint ptr)
        {
            TreeEntry entry = null;


            entry = globalEntries
                    .Where(x => x.Value.zCVob == ptr)
                    .Select(pair => pair.Value)
                    .FirstOrDefault();

            if (entry != null)
            {
                if (entry.node != null)
                {
                    SpacerNET.objTreeWin.globalTree.SelectedNode = entry.node;
                    SpacerNET.objTreeWin.globalTree.SelectedNode.Expand();
                }
            }
        }



        [DllExport]
        public static void OnSelectMaterial(uint ptr)
        {
            /*
            if (ptr == 0)
            {
                return;
            }

            //ConsoleEx.WriteLineGreen("OnSelectMaterial: " + Utils.ToHex(ptr));


            TreeEntry entry = null;


            entry = matEntries
                    .Where(x => x.Value.zCVob == ptr)
                    .Select(pair => pair.Value)
                    .FirstOrDefault();

            if (entry != null)
            {
                if (entry.node != null)
                {
                    SpacerNET.objTreeWin.matTree.SelectedNode = entry.node;
                }
                else
                {
                    Utils.Error("OnSelectMaterial: entry.node is null, key/addr/vob is " + Utils.ToHex(ptr));
                }

            }
            else
            {
                Utils.Error("OnSelectMaterial: No key/addr/vob found in matEntries. Key: " + Utils.ToHex(ptr));
            }
            */
        }

        [DllExport]
        public static void OnSelectVob(uint ptr)
        {

            if (ptr == 0)
            {
                return;
            }

            TreeEntry entry = null;


            entry = globalEntries
                    .Where(x => x.Value.zCVob == ptr)
                    .Select(pair => pair.Value)
                    .FirstOrDefault();


           // ConsoleEx.WriteLineGreen("OnSelectVob: " + Utils.ToHex(ptr));


            if (entry != null)
            {
                if (entry.node != null)
                {
                    SpacerNET.objTreeWin.globalTree.SelectedNode = entry.node;

                    if (SpacerNET.objTreeWin.globalTree.Visible)
                    {
                        SpacerNET.objTreeWin.globalTree.SelectedNode.EnsureVisible();
                    }
                    
                }
                else
                {
                    Utils.Error("OnSelectVob: entry.node is null, key/addr/vob is " + Utils.ToHex(ptr));
                }
               
            }
            else
            {
                Utils.Error("OnSelectVob: No key/addr/vob found in globalList. Key: " + Utils.ToHex(ptr));
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
                //ConsoleEx.WriteLineGreen("Remove node: " + entry.node.Text + " Parent: " + Utils.ToHex(entry.parent));
                var entryQuick = quickVobMan.GetEntryByRealNode(entry.node);

                if (entryQuick != null)
                {
                    SpacerNET.objTreeWin.quickTree.Nodes.Remove(entryQuick.quickNode);
                    quickVobMan.Remove(entryQuick);
                    
                }
                entry.node.Remove();
            }
            else
            {
                //ConsoleEx.WriteLineGreen("Remove node failure. Node is null");
            }

            entry.childs.Clear();
            entry.toDelete = true;
            entry.node = null;
        }

        static int countNodeView = 0;

        public static void CalcNodesCount(TreeNodeCollection nodes)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                CalcNodesCount(nodes[i].Nodes);

                if (nodes[i].Tag != null && nodes[i].Tag.ToString() != Constants.TAG_FOLDER)
                {
                    countNodeView++;
                }

            }


        }

        [DllExport]
        public static void ReloadWaypoint()
        {
            //ConsoleEx.WriteLineGreen("C#: Перестраиваю список вейпоинтов в интерфейсе: Кол-во вобов в списке " + globalEntries.Count);

            foreach (var entry in tempEntries)
            {
                AddVobToNodes(entry.Value);
            }

            IsWaypointReload = false;
            tempEntries.Clear();

            //ConsoleEx.WriteLineGreen("C#: Дерево вейпоинтов обновлено заполнено. Всего записей: " + globalEntries.Count);
        }
        
        [DllExport]
        public static void ClearWaypoints()
        {

            //ConsoleEx.WriteLineGreen("C#: Начало очистки вейпоинтов: Кол-во вобов в списке " + globalEntries.Count);


            TreeNode node = SpacerNET.objTreeWin.globalTree.SelectedNode;

            // Если есть выделенный объект и это вейпоинт, то снимает выделение, потому что Node будет удален, иначе вылет
            if (node != null)
            {
                string tag = node.Tag.ToString();

                if (tag != Constants.TAG_FOLDER && tag.Length > 0)
                {
                    uint addr = Convert.ToUInt32(node.Tag);

                    if (globalEntries[addr].className == "zCVobWaypoint")
                    {
                        SpacerNET.objTreeWin.globalTree.SelectedNode = null;
                    }
                }
            }

         
            var waypointsNodesList = globalEntries
                        .Where(pair => pair.Value.className == "zCVobWaypoint")
                        .ToDictionary(pair => pair.Key, pair => pair.Value);



            foreach (var entry in waypointsNodesList)
            {
                if (entry.Value.node != null)
                {
                    entry.Value.node.Remove();
                }
            }

            globalEntries = globalEntries
                        .Where(pair => pair.Value.className != "zCVobWaypoint")
                        .ToDictionary(pair => pair.Key, pair => pair.Value);


            IsWaypointReload = true;
            tempEntries.Clear();
           // ConsoleEx.WriteLineGreen("Clean waypoints. All vobs count: " + globalEntries.Count);

        }

        [DllExport]
        public static void OnVobRemove(uint vob)
        {
            TreeNodeCollection nodes = SpacerNET.objTreeWin.globalTree.Nodes;

           // ConsoleEx.WriteLineGreen("OnVobRemove: " + Utils.ToHex(vob));
            //ConsoleEx.WriteLineGreen("All vobs count: " + globalEntries.Count);

            if (vob == 0)
            {
                return;
            }


            List<TreeEntry> entries = globalEntries
                    .Where(pair => pair.Value.zCVob == vob)
                    .Select(pair => pair.Value)
                    .ToList();


            //Console.WriteLine("Found entries with Vob value: " + entries.Count);

            if (entries.Count > 0)
            {
                TreeEntry entry = entries[0];

                RemoveChildNodesRecursive(entry);

                globalEntries = globalEntries
                        .Where(pair => !pair.Value.toDelete)
                        .ToDictionary(pair=>pair.Key, pair=>pair.Value);

                if (globalEntries.ContainsKey(vob))
                {
                    Utils.Error("WTF? I have removed the vob with such key: " + Utils.ToHex(vob) + " " + entry.name);
                }

                if (entries.Count > 1)
                {
                    Utils.Error("Warning! I found more than 1 entries with same Vob addr! Count: " + entries.Count);
                }
            }
            
            // if we have this vob in search result, remove it from list / interface
            if (ObjectsWin.searchResultVobsAddr.Contains(vob))
            {
                int index = ObjectsWin.searchResultVobsAddr.IndexOf(vob);

                if (index >= 0)
                {
                    //ConsoleEx.WriteLineRed("Remove vob at index: " + index);

                    ObjectsWin.searchResultVobsAddr.RemoveAt(index);
                    SpacerNET.objectsWin.listBoxSearchResult.Items.RemoveAt(index);
                }
            }

            SpacerNET.errorForm.OnRemoveVob(vob);
            SpacerNET.vobList.OnVobDelete(vob);
            ObjectsWindow.CleanProps();

            ConsoleEx.WriteLineGreen("OnVobRemove: All vobs count: " + globalEntries.Count);
            countNodeView = 0;
            //CalcNodesCount(SpacerNET.objTreeWin.globalTree.Nodes);
            //ConsoleEx.WriteLineGreen("All TreeView nodes count: " + countNodeView);
            
            //Console.WriteLine("=============================");
            

            if (SpacerNET.objTreeWin.globalTree.SelectedNode != null)
            {
                SpacerNET.objTreeWin.globalTree_AfterSelect(null, null);
            }

        }

       
        [DllExport]
        public static void OnVobInsert(uint vob, uint parent, int isNodeBlocked, int isSelect)
        {
            string name = Imports.Stack_PeekString();
            string className = Imports.Stack_PeekString();
            bool select = Convert.ToBoolean(isSelect);

            TreeNodeCollection nodes = SpacerNET.objTreeWin.globalTree.Nodes;

          //  ConsoleEx.WriteLineYellow("\nOnVobInsert: " + name);
            int classNameFoundPos = -1;

            classNameFoundPos = CreateAndGetFolder(className);

            TreeEntry entry = new TreeEntry();


            entry.name = name;
            entry.parent = parent;
            entry.zCVob = vob;
            entry.className = className;
            entry.isLevel = entry.className == "zCVobLevelCompo";

            if (!globalEntries.ContainsKey(vob))
            {
                globalEntries.Add(vob, entry);
            }
            else
            {

                string msg = "==============================\nОшибка! Пытаюсь добавить воб "
                    + Utils.ToHex(vob)
                    + ", но такой адрес-ключ уже есть в globalEntries!"
                    + "\nNewVob: " + globalEntries[vob].name 
                    + " addr: zCVob = "
                    + Utils.ToHex(globalEntries[vob].zCVob)
                    + ", Parent: " + Utils.ToHex(globalEntries[vob].parent)
                    + ", ChildrenCount: " + globalEntries[vob].childs.Count
                    + ", ToDelete: " + globalEntries[vob].toDelete;


                msg += "\nglobalEntries Count: " + globalEntries.Count.ToString();


                countNodeView = 0;
                CalcNodesCount(SpacerNET.objTreeWin.globalTree.Nodes);


                msg += "\nNodes Count: " + countNodeView.ToString();

                if (globalEntries[vob].node != null)
                {
                    msg += "\nnode.text: " + globalEntries[vob].node.Text;
                    msg += ", node.Tag: " + Utils.ToHex(Convert.ToUInt32(globalEntries[vob].node.Tag.ToString()));
                }

                if (globalEntries[vob].parentEntry != null)
                {
                    msg += "\nparentEntryName: " + globalEntries[vob].parentEntry.name;
                    msg += ", parentEntryClassName: " + globalEntries[vob].parentEntry.className;
                    msg += ", parentEntryAddr: " + Utils.ToHex(globalEntries[vob].parentEntry.zCVob);
                }

                msg += "\n==============================";

                Utils.Error(msg);

                MessageBox.Show(msg);
                return;
            }




            TreeEntry foundEntry = null;

            try
            {
                foundEntry = globalEntries[entry.parent];
            }
            catch
            {
                foundEntry = null;

                //ConsoleEx.WriteLineRed("C#: OnVobInsert. Can't found parent entry!");
                //Utils.WriteToFile("C#: OnVobInsert. Can't found parent entry!");
            }
            
            if (foundEntry != null)
            {
                entry.parentEntry = foundEntry;
                foundEntry.childs.Add(entry);
            }
            

            if (parent == 0)
            {
                TreeNode node = nodes[classNameFoundPos].Nodes.Add(name);
                node.Tag = vob;
                entry.node = node;
                ApplyNodeImage(className, node, true);

                
                if (select)
                {
                    SpacerNET.objTreeWin.globalTree.SelectedNode = node;
                }
                else
                {
                    //ConsoleEx.WriteLineRed("No select parent == 0");
                }
               
                
                
                //Console.WriteLine("OnVobInsert globally: " + name + " parent: " + Utils.ToHex(parent) + " className: " + className);
            }
            else if (entry.parentEntry != null)
            {
                if (entry.parentEntry.node != null)
                {
                    TreeNode node = null;

                    if (entry.parentEntry.isLevel)
                    {
                        node = nodes[classNameFoundPos].Nodes.Add(name);
                    }
                    else
                    {
                        node = entry.parentEntry.node.Nodes.Add(name);
                    }

                    node.Tag = vob;
                    entry.node = node;
                    ApplyNodeImage(className, node, true);


                    if (select)
                    {
                        SpacerNET.objTreeWin.globalTree.SelectedNode = node;
                    }
                    else
                    {
                        //ConsoleEx.WriteLineRed("No select");
                    }



                }
                else
                {

                    string msg = "OnVobInsert: parent node is null. Vob  "
                    + entry.parentEntry.name;


                    Utils.Error(msg);
                }

            }
            else
            {
                Utils.Error("OnVobInsert: parent entry is null");
            }


            ConsoleEx.WriteLineGreen("Vobs count: " + globalEntries.Count);
            countNodeView = 0;
            CalcNodesCount(SpacerNET.objTreeWin.globalTree.Nodes);
            ConsoleEx.WriteLineGreen("TreeView Nodes count: " + countNodeView);
        }


        [DllExport]
        public static void CreateTree()
        {
            noParentCount = 0;

           // SpacerNET.objTreeWin.globalTree.Visible = false;


            //globalEntries = globalEntries.OrderBy(x => x.Value.name).ToDictionary(x => x.Key, x => x.Value);

            foreach (var entry in globalEntries)
            {
                AddVobToNodes(entry.Value);
            }

            ConsoleEx.WriteLineGreen("Tree is ready. GlobalEntries count: " + globalEntries.Count);

            //Application.DoEvents();

        }

        [DllExport]
        public static void AddGlobalEntry(uint vob, uint parent)
        {

            string name = Imports.Stack_PeekString();
            string className = Imports.Stack_PeekString();


            TreeNodeCollection nodes = SpacerNET.objTreeWin.globalTree.Nodes;

            TreeEntry entry = new TreeEntry();

            entry.name = name;
            entry.parent = parent;

            entry.zCVob = vob;
            entry.className = className;
            entry.isLevel = entry.className == "zCVobLevelCompo";


            try
            {
                globalEntries.Add(vob, entry);

                if (IsWaypointReload)
                {
                    tempEntries.Add(vob, entry);
                }
            }
            catch
            {

                Utils.Error("AddGlobalEntry: Key exists!: Key: " + Utils.ToHex(vob) + ", Name: " + name + " Parent: " + Utils.ToHex(parent));
            }
            

            if (entry.parent == 0)
            {
                return;
            }

            TreeEntry foundEntry = null;

            try
            {
                foundEntry = globalEntries[entry.parent];
            }
            catch
            {
                foundEntry = null;

                Utils.Error("AddGlobalEntry: Не смог найти entry.parent!: " + Utils.ToHex(vob) + ", Name: " + name + " Parent: " + Utils.ToHex(entry.parent));

            }
           

            if (foundEntry != null)
            {
                entry.parentEntry = foundEntry;
                foundEntry.childs.Add(entry);
            }
        }


      

        private void buttonCollapse_Click(object sender, EventArgs e)
        {
            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            globalTree.CollapseAll();
        }

        private void buttonExpand_Click(object sender, EventArgs e)
        {
            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            globalTree.ExpandAll();
        }

        private void ObjTree_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            SpacerNET.form.SetIconActive("objlist", false);
        }


        


        private void globalTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (SpacerNET.form.toolStripButtonMaterial.Checked)
            {
                Imports.Stack_PushString(Localizator.Get("WIN_VOBCATALOG_POLYSELECT_TURNOFF"));
                Imports.Extern_PrintRed();
                return;
            }

            TreeNode node = globalTree.SelectedNode;

            string tag = node.Tag.ToString();

           


            if (tag.Length == 0 || tag == Constants.TAG_FOLDER)
            {
                return;
            }

            

            uint addr = Convert.ToUInt32(node.Tag);

            ConsoleEx.WriteLineGreen("OnSelectDoubleClick node: vob " + Utils.ToHex(addr));

            Imports.Extern_SelectVob(addr);
            SpacerNET.form.Focus();
        }

        private void globalTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (SpacerNET.form.toolStripButtonMaterial.Checked)
            {
                return;
            }

            TreeView tree = sender as TreeView;

            if (nextAfterEventBlocked)
            {
                ConsoleEx.WriteLineGreen("AfterSelect event was aborted.");
                nextAfterEventBlocked = false;

                if (lastSelectedNode != null)
                {
                    tree.SelectedNode = lastSelectedNode;
                }

                return;
            }
           
            TreeNode node = globalTree.SelectedNode;

            if (previousSelectedNode != null)
            {
                if (previousSelectedNode.Tag.ToString() == Constants.TAG_FOLDER)
                {
                    previousSelectedNode.SelectedImageIndex = 0;
                }
                else
                {
                    previousSelectedNode.SelectedImageIndex = 1;
                }
                
            }

            string tag = node.Tag.ToString();

            if (tag.Length == 0 || tag == Constants.TAG_FOLDER)
            {
                return;
            }

            node.SelectedImageIndex = 4;



           

            uint addr = Convert.ToUInt32(node.Tag);

           // ConsoleEx.WriteLineGreen("AfterSelect node: vob " + Utils.ToHex(addr));

            if (node.Text.Contains("zCVobWaypoint") || node.Text.Contains("zCVobSpot"))
            {
               // ObjectsWin.ChangeTab(4);
            }

            Imports.Extern_SelectVobSync(addr);

            SpacerNET.form.Focus();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (SpacerNET.objTreeWin.globalTree.SelectedNode == null)
            {
                return;
            }

            TreeNode node = globalTree.SelectedNode;

            string tag = node.Tag.ToString();

            if (tag.Length == 0 || tag == Constants.TAG_FOLDER)
            {
                return;
            }


            saveFileDialogVobTree.Filter = Constants.FILE_FILTER_OPEN_VOBTREE;



            Imports.Stack_PushString("treeVobPath");
            Imports.Extern_GetSettingStr();
            string path = Imports.Stack_PeekString();

            string fileName = SpacerNET.objTreeWin.globalTree.SelectedNode.Text;

            //MessageBox.Show(path);


            saveFileDialogVobTree.InitialDirectory = Utils.GetInitialDirectory(path);


            saveFileDialogVobTree.RestoreDirectory = true;
            saveFileDialogVobTree.FileName = fileName + ".ZEN";

            //Imports.Extern_BlockMouse(true);

            if (saveFileDialogVobTree.ShowDialog() == DialogResult.OK)
            {



                Imports.Stack_PushString(Utils.FixPath(Path.GetDirectoryName(Utils.FixPath(saveFileDialogVobTree.FileName))));
                Imports.Stack_PushString("treeVobPath");
                Imports.Extern_SetSettingStr();


                string filePath = saveFileDialogVobTree.FileName;
                Imports.Stack_PushString(filePath);
                Imports.Extern_SaveVobTree();
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

            if (tag.Length == 0 || tag == Constants.TAG_FOLDER)
            {
                return;
            }


            openFileDialogVobTree.Filter = Constants.FILE_FILTER_OPEN_VOBTREE;
    


            Imports.Stack_PushString("treeVobPath");
            Imports.Extern_GetSettingStr();
            string path = Imports.Stack_PeekString();

            string fileName = SpacerNET.objTreeWin.globalTree.SelectedNode.Text;

            //MessageBox.Show(path);

            openFileDialogVobTree.InitialDirectory = Utils.GetInitialDirectory(path);

            openFileDialogVobTree.RestoreDirectory = true;

            //Imports.Extern_BlockMouse(true);

            if (openFileDialogVobTree.ShowDialog() == DialogResult.OK)
            {
                bool insertNearCamera = false;

                DialogResult dialogResult = MessageBox.Show(Localizator.Get("WIN_MSG_CONFIRM_PLACENEARCAM"), Localizator.Get("WIN_MSG_CONFIRM_INSERTVOBTREE"), MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    insertNearCamera = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    insertNearCamera = false;
                }

                Imports.Stack_PushString(Utils.FixPath(Path.GetDirectoryName(Utils.FixPath(openFileDialogVobTree.FileName))));
                Imports.Stack_PushString("treeVobPath");
                Imports.Extern_SetSettingStr();


                string filePath = openFileDialogVobTree.FileName;
                Imports.Stack_PushString(filePath);
                Imports.Extern_OpenVobTree(false, insertNearCamera);

            }

            
        }

        private void вставитьVobTreeГлобальноToolStripMenuItem_Click(object sender, EventArgs e)
        {


            openFileDialogVobTree.Filter = Constants.FILE_FILTER_OPEN_VOBTREE;



            Imports.Stack_PushString("treeVobPath");
            Imports.Extern_GetSettingStr();
            string path = Imports.Stack_PeekString();

            string fileName = SpacerNET.objTreeWin.globalTree.SelectedNode.Text;

            //MessageBox.Show(path);

            openFileDialogVobTree.InitialDirectory = Utils.GetInitialDirectory(path);

            openFileDialogVobTree.RestoreDirectory = true;

            //Imports.Extern_BlockMouse(true);

            if (openFileDialogVobTree.ShowDialog() == DialogResult.OK)
            {
                bool insertNearCamera = false;

                DialogResult dialogResult = MessageBox.Show(Localizator.Get("WIN_MSG_CONFIRM_PLACENEARCAM"), Localizator.Get("WIN_MSG_CONFIRM_INSERTVOBTREE"), MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    insertNearCamera = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    insertNearCamera = false;
                }

                Imports.Stack_PushString(Utils.FixPath(Path.GetDirectoryName(Utils.FixPath(openFileDialogVobTree.FileName))));
                Imports.Stack_PushString("treeVobPath");
                Imports.Extern_SetSettingStr();


                string filePath = openFileDialogVobTree.FileName;
                Imports.Stack_PushString(filePath);
                Imports.Extern_OpenVobTree(true, insertNearCamera);

                if (SpacerNET.objTreeWin.globalTree.SelectedNode != null)
                {
                    SpacerNET.objTreeWin.globalTree.SelectedNode.Expand();
                }

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

            if (tag.Length == 0 || tag == Constants.TAG_FOLDER)
            {
                return;
            }

            SpacerNET.form.ToggleWindowOnTop(true);

            DialogResult dialogResult = MessageBox.Show(Localizator.Get("WIN_MSG_CONFIRM_REMOVEVOB"), Localizator.Get("WIN_MSG_CONFIRM"), MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                uint vob = 0;

                uint.TryParse(tag, out vob);

                Imports.Extern_RemoveVob(vob);
            }

            SpacerNET.form.ToggleWindowOnTop(false);


        }

        private void globalTree_NodeMouseClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (SpacerNET.form.toolStripButtonMaterial.Checked)
            {
                Imports.Stack_PushString(Localizator.Get("WIN_VOBCATALOG_POLYSELECT_TURNOFF"));
                Imports.Extern_PrintRed();
                return;
            }

            globalTree.SelectedNode = e.Node;
        }

        private void buttonTreeSort_Click(object sender, EventArgs e)
        {
            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            globalTree.Sort();
        }

        private void globalTree_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (SpacerNET.form.toolStripButtonMaterial.Checked)
            {
                Imports.Stack_PushString(Localizator.Get("WIN_VOBCATALOG_POLYSELECT_TURNOFF"));
                Imports.Extern_PrintRed();
                e.Cancel = true;
                return;
            }

            previousSelectedNode = globalTree.SelectedNode;
        }

        private void ObjTree_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.TreeWinLocation != null)
            {
                this.Location = Properties.Settings.Default.TreeWinLocation;
            }

            

        }

        private void ObjTree_Shown(object sender, EventArgs e)
        {
        }

        private void ObjTree_KeyPress(object sender, KeyPressEventArgs e)
        {
           // e.Handled = true;
        }

        private void globalTree_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void globalTree_KeyDown(object sender, KeyEventArgs e)
        {
           // e.Handled = true;
        }

        private void сделатьРодителемДляНовыхВобовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globalTree.SelectedNode == null)
            {
                return;
            }

            TreeNode node = globalTree.SelectedNode;

            string tag = node.Tag.ToString();

            if (tag.Length == 0 || tag == Constants.TAG_FOLDER)
            {
                return;
            }


            uint vob = 0;


            uint.TryParse(tag, out vob);



            int canBeParent = Imports.Extern_CanBeGlobalParent(vob);


            if (canBeParent == 0)
            {
                MessageBox.Show(Localizator.Get("QUICKVOBS_CANTBE_PARENT"));
                return;
            }



            var globalEntry = quickVobMan.GetGlobalParentNode();


            if (globalEntry != null )
            {
                if (globalEntry.quickNode != null)
                {
                    quickTree.Nodes.Remove(globalEntry.quickNode);
                }

                globalEntry.Clean();
            }
            else
            {
                globalEntry = quickVobMan.Add();
                globalEntry.isParent = true;
            }

            

            TreeNodeCollection nodes = SpacerNET.objTreeWin.quickTree.Nodes;

            int classNameFoundPos = -1;

            classNameFoundPos = CreateAndGetFolderQuickTree(Localizator.Get("QUICKVOBS_PARENT"));

            TreeNode newNode = nodes[classNameFoundPos].Nodes.Add(node.Name);
            newNode.Tag = node.Tag;
            newNode.ImageIndex = 1;
            newNode.SelectedImageIndex = 1;
            newNode.Text = node.Text;

            globalEntry.quickNode = newNode;
            globalEntry.realNode = node;
 

            Imports.Extern_MakeGlobalParent(vob);
        }

        private void очиститьРодителяДляВобовToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var globalEntry = quickVobMan.GetGlobalParentNode();

            if (globalEntry != null && globalEntry.quickNode != null)
            {
                quickTree.Nodes.Remove(globalEntry.quickNode);
                globalEntry.Clean();

            }

            Imports.Extern_CleanGlobalParent();
        }

        private void contextMenuStripTree_Opening(object sender, CancelEventArgs e)
        {
            if (SpacerNET.form.toolStripButtonMaterial.Checked)
            {
                Imports.Stack_PushString(Localizator.Get("WIN_VOBCATALOG_POLYSELECT_TURNOFF"));
                Imports.Extern_PrintRed();
                e.Cancel = true;
                return;
            }


        }

        private void quickTree_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlObjectList.SelectedIndex == 1)
            {
                quickTree.ExpandAll();
            }

        }

        private void quickTree_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TreeNode node = quickTree.SelectedNode;

            string tag = node.Tag.ToString();


            if (tag.Length == 0 || tag == Constants.TAG_FOLDER)
            {
                return;
            }


            tabControlObjectList.SelectedIndex = 0;

            var globalEntry = quickVobMan.GetEntryByQuickNode(node);


            if (globalEntry != null)
            {
                globalTree.SelectedNode = globalEntry.realNode;
            }
           

            uint addr = Convert.ToUInt32(node.Tag);

            ConsoleEx.WriteLineGreen("OnSelectDoubleClick quickNode: vob " + Utils.ToHex(addr));

            Imports.Extern_SelectVob(addr);
            SpacerNET.form.Focus();
        }


        void AddVobInQuickList(TreeNode node, uint vob)
        {
            if (!quickVobMan.AlreadyInList(vob))
            {
                var entry = quickVobMan.Add();

                TreeNodeCollection nodes = SpacerNET.objTreeWin.quickTree.Nodes;

                int classNameFoundPos = -1;

                classNameFoundPos = CreateAndGetFolderQuickTree(Localizator.Get("QUICKVOBS_ACCESS"));

                TreeNode newNode = nodes[classNameFoundPos].Nodes.Add(node.Name);
                newNode.Tag = node.Tag;
                newNode.ImageIndex = 1;
                newNode.SelectedImageIndex = 1;
                newNode.Text = node.Text;

                entry.quickNode = newNode;
                entry.realNode = node;
            }
        }

        private void AddQuickVobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globalTree.SelectedNode == null)
            {
                return;
            }

            TreeNode node = globalTree.SelectedNode;

            string tag = node.Tag.ToString();

            if (tag.Length == 0 || tag == Constants.TAG_FOLDER)
            {
                return;
            }

            uint vob = 0;

            uint.TryParse(tag, out vob);

            AddVobInQuickList(node, vob);


        }

        private void toolStripClearGlobalPar_Click(object sender, EventArgs e)
        {
            var globalEntry = quickVobMan.GetGlobalParentNode();

            if (globalEntry != null && globalEntry.quickNode != null)
            {
                quickTree.Nodes.Remove(globalEntry.quickNode);
                globalEntry.Clean();

            }

            Imports.Extern_CleanGlobalParent();
        }

        private void toolStripMenuRemoveQuickVob_Click(object sender, EventArgs e)
        {
            TreeNode node = quickTree.SelectedNode;

            string tag = node.Tag.ToString();


            if (tag.Length == 0 || tag == Constants.TAG_FOLDER)
            {
                return;
            }

            quickVobMan.RemoveByQuickNode(node);
            quickTree.Nodes.Remove(node);
        }

        private void quickTree_MouseClick(object sender, MouseEventArgs e)
        {
            
            
        }

        private void quickTree_MouseDown(object sender, MouseEventArgs e)
        {
            TreeNode node = quickTree.GetNodeAt(e.Location);

            if (node == null)
            {
                return;
            }

            string tag = node.Tag.ToString();


            if (tag.Length == 0 || tag == Constants.TAG_FOLDER)
            {
                return;
            }


            uint addr = Convert.ToUInt32(node.Tag);

            ConsoleEx.WriteLineGreen("FastAccess select node: vob " + Utils.ToHex(addr));


            Imports.Extern_SelectVobSync(addr);

            SpacerNET.form.Focus();
        }

        private void toolStripMenuRestorePos_Click(object sender, EventArgs e)
        {
            if (globalTree.SelectedNode == null)
            {
                return;
            }

            TreeNode node = globalTree.SelectedNode;

            string tag = node.Tag.ToString();

            if (tag.Length == 0 || tag == Constants.TAG_FOLDER)
            {
                return;
            }

            uint vob = 0;

            uint.TryParse(tag, out vob);


            ConsoleEx.WriteLineGreen("RestorePos: vob " + Utils.ToHex(vob));

            Imports.Extern_RestorePosition(vob);
            SpacerNET.form.Focus();

        }

        [DllExport]
        public static void OnRemoveGlobalParent()
        {
            var globalEntry = quickVobMan.GetGlobalParentNode();

            if (globalEntry != null && globalEntry.quickNode != null)
            {
                SpacerNET.objTreeWin.quickTree.Nodes.Remove(globalEntry.quickNode);
                globalEntry.Clean();

            }
        }


        //================================================================

            /*
        public static int CreateAndGetFolderMat(string className)
        {

            TreeNodeCollection nodes = SpacerNET.objTreeWin.matTree.Nodes;

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
                newNode.Tag = Constants.TAG_FOLDER;
                newNode.ImageIndex = 0;
                newNode.SelectedImageIndex = 0;

                classNameFoundPos = newNode.Index;
            }

            return classNameFoundPos;
        }

    */


       

        

        private void matTree_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*
            TreeNode node = matTree.SelectedNode;

            if (node == null) return;

            string tag = node.Tag.ToString();

            if (tag.Length == 0 || tag == Constants.TAG_FOLDER)
            {
                return;
            }

            uint addr = Convert.ToUInt32(node.Tag);

            ConsoleEx.WriteLineGreen("OnSelectDoubleClick node: material " + Utils.ToHex(addr));

            Imports.Extern_SelectMat(addr);
            SpacerNET.form.Focus();
            */
        }

        private void buttonSortMatTree_Click(object sender, EventArgs e)
        {
           // matTree.Sort();
        }

        private void buttonCollapseMatTree_Click(object sender, EventArgs e)
        {
           // matTree.CollapseAll();
        }

        private void buttonExpandMatTree_Click(object sender, EventArgs e)
        {
           // matTree.ExpandAll();
        }

        private void matTree_MouseClick(object sender, MouseEventArgs e)
        {
            //matTree_MouseDoubleClick(null, e);
        }

        private void tempInvisibleToolStrip_Click(object sender, EventArgs e)
        {
            if (globalTree.SelectedNode == null)
            {
                return;
            }

            TreeNode node = globalTree.SelectedNode;

            string tag = node.Tag.ToString();

            if (tag.Length == 0 || tag == Constants.TAG_FOLDER)
            {
                return;
            }

            uint vob = 0;

            uint.TryParse(tag, out vob);

            Imports.Extern_RemoveAsParent(vob);
        }

        private void comboBoxFilterVobsSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox ch = sender as ComboBox;

            int index = ch.SelectedIndex;

            Imports.Extern_SetVobPickFilter(index);
        }



        [DllExport]
        public static void AddVobToFastList()
        {
            var globalTree = SpacerNET.objTreeWin.globalTree;

            if (globalTree.SelectedNode == null)
            {
                return;
            }

            TreeNode node = globalTree.SelectedNode;

            string tag = node.Tag.ToString();

            if (tag.Length == 0 || tag == Constants.TAG_FOLDER)
            {
                return;
            }


            uint vob = Imports.Stack_PeekUInt();

            uint.TryParse(tag, out vob);

            if (vob == 0)
            {
                return;
            }

            SpacerNET.objTreeWin.AddVobInQuickList(node, vob);
        }

        private void globalTree_MouseDown(object sender, MouseEventArgs e)
        {
            if (SpacerNET.form.toolStripButtonMaterial.Checked)
            {
                Imports.Stack_PushString(Localizator.Get("WIN_VOBCATALOG_POLYSELECT_TURNOFF"));
                Imports.Extern_PrintRed();
                return;
            }


            switch (e.Button)
            {
                case MouseButtons.Middle:
                {

                        TreeNode node = globalTree.GetNodeAt(e.Location);

                        if (node != null)
                        {
                            // fix proper name for selected node
                            string text = node.Text;

                            if (text.Length == 0 || !text.Contains('('))
                            {
                                return;
                            }

                            int index = text.LastIndexOf('(');

                            text = text.Substring(0, index - 1);
                            text = text.Trim();

                            Utils.SetCopyText(text);
                        }
                        
                }
                    
                break;
            }
        }

        public void SaveVisualDialog(bool includeChildren)
        {
            if (globalTree.SelectedNode == null)
            {
                return;
            }

            TreeNode node = globalTree.SelectedNode;

            string tag = node.Tag.ToString();

            if (tag.Length == 0 || tag == Constants.TAG_FOLDER)
            {
                return;
            }


            uint vob = 0;


            uint.TryParse(tag, out vob);

            if (vob == 0)
            {
                return;
            }


            saveFileDialogVobTree.Filter = Constants.FILE_FILTER_SAVE_ONLY_MESH;

            Imports.Stack_PushString("savedVobsVisualPath");
            Imports.Extern_GetSettingStr();
            string path = Imports.Stack_PeekString();

            string fileName = SpacerNET.objTreeWin.globalTree.SelectedNode.Text;

            fileName = fileName.Replace(" (zCVob)", "");
            fileName = fileName.Replace(".3DS", "");

            if (fileName.Length == 0)
            {
                fileName = "VOBNAME";
            }

            if (path.Length == 0)
            {

                path = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "..\\_work\\data\\meshes\\"));

                ConsoleEx.WriteLineRed(path);
            }


            saveFileDialogVobTree.InitialDirectory = Utils.GetInitialDirectory(path);


            saveFileDialogVobTree.RestoreDirectory = true;
            saveFileDialogVobTree.FileName = fileName + ".MSH";

            //Imports.Extern_BlockMouse(true);

            if (saveFileDialogVobTree.ShowDialog() == DialogResult.OK)
            {
                string pathSave = Utils.FixPath(Path.GetDirectoryName(Utils.FixPath(saveFileDialogVobTree.FileName)));

                string selectedPath = Utils.FixPath(Path.GetFullPath(saveFileDialogVobTree.FileName));
                string appDirectory = Utils.FixPath(Path.GetDirectoryName(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath)))) + Constants.FILE_PATH_SAVE_VOB_MESH;

                Console.WriteLine(selectedPath);
                Console.WriteLine(appDirectory);

                if (!selectedPath.StartsWith(appDirectory, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(Localizator.Get("MSG_COMMON_FILE_PATH_SAVE_VOB_MESH"));
                    return;
                }
 


                Imports.Stack_PushString(pathSave);
                Imports.Stack_PushString("savedVobsVisualPath");
                Imports.Extern_SetSettingStr();




                FileInfo fi = new FileInfo(saveFileDialogVobTree.FileName);
                string filePath = fi.Name;

                Imports.Stack_PushString(filePath);

                Imports.Extern_SaveVobsVisualToFile(vob, includeChildren);
            }
        }
        private void allChildrenVobsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveVisualDialog(true);


        }

        private void onlyParentVobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveVisualDialog(false);
        }

        private void globalTree_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void createCONTEXTMENUTREECREATECAMERASTARTPOSVobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            Imports.Extern_CreateVobSpacerCameraStartPos();

            SpacerNET.form.Focus();
        }
    }
}
