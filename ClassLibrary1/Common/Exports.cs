using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion.Common
{

    public enum UIElementType
    {
        UI_SOUND_LIST = 0,
        UI_MUSIC_LIST,
        UI_MAIN_CLASSES,
        UI_LIST_PFX,
        UI_LIST_ITEMS,
        UI_ALL_VOBS_TREE_LIST,
        UI_MAT_LIST,
        UI_LIST_SEARCH_RESULT
    };


    public class Exports
    {

        // Переключает интерфейс чтобы не лагал во время загрузки списков
        [DllExport]
        public static void Export_ToggleUIElement(int elemType, int val)
        {
            UIElementType type = (UIElementType)elemType;
            bool toggle = Convert.ToBoolean(val);
            object obj = null;

            switch (type)
            {
                case UIElementType.UI_SOUND_LIST:
                {
                   obj = SpacerNET.soundWin.listBoxSound;

                }; break;

                case UIElementType.UI_MUSIC_LIST:
                {
                    obj = SpacerNET.soundWin.listBoxMusic;

                }; break;

                case UIElementType.UI_LIST_PFX:
                {
                    obj = SpacerNET.objectsWin.listBoxParticles;

                }; break;

                case UIElementType.UI_LIST_ITEMS:
                {
                    obj = SpacerNET.objectsWin.listBoxItems;

                }; break;

                case UIElementType.UI_ALL_VOBS_TREE_LIST:
                {
                    obj = SpacerNET.objTreeWin.globalTree;

                }; break;


                case UIElementType.UI_MAIN_CLASSES:
                {
                    obj = SpacerNET.objectsWin.classesTreeView;

                }; break;

                case UIElementType.UI_MAT_LIST:
                {
                    obj = SpacerNET.objTreeWin.matTree;

                }; break;

                case UIElementType.UI_LIST_SEARCH_RESULT:
                {
                    obj = SpacerNET.objectsWin.listBoxSearchResult;

                }; break;

                    
            }

            if (obj != null)
            {
                var listBox = obj as ListBox;
                var treeView = obj as TreeView;

                if (listBox != null)
                {
                    if (toggle)
                    {
                        //ConsoleEx.WriteLineYellow(type.ToString() + " End ");
                        listBox.EndUpdate();
                    }
                    else
                    {
                        listBox.BeginUpdate();

                        //ConsoleEx.WriteLineYellow(type.ToString() + " Begin ");
                    }
                }
                else if (treeView != null)
                {
                    if (toggle)
                    {
                        //ConsoleEx.WriteLineYellow(type.ToString() + " End ");
                        treeView.EndUpdate();
                    }
                    else
                    {
                        treeView.BeginUpdate();

                        //ConsoleEx.WriteLineYellow(type.ToString() + " Begin ");
                    }
                }
            }
        }




        // добавляет материал в список
        [DllExport]
        public static void AddGlobalEntryMat(uint mat)
        {
            TreeNodeCollection nodes = SpacerNET.objTreeWin.matTree.Nodes;


            string group = Imports.Stack_PeekString();
            string name = Imports.Stack_PeekString();

            int nodeIndex = ObjTree.CreateAndGetFolderMat(group);

            TreeNode node = nodes[nodeIndex].Nodes.Add(name);
            node.Tag = mat;
            node.Text = name;
            node.ImageIndex = 1;
            node.SelectedImageIndex = 1;

            TreeEntry entry = new TreeEntry();

            entry.name = name;

            entry.zCVob = mat;
            entry.node = node;

            try
            {
                ObjTree.matEntries.Add(mat, entry);

            }
            catch
            {

                Utils.Error("AddGlobalEntryMat: Key exists!: Key: " + Utils.ToHex(mat) + ", Name: " + name);
            }
        }

        // выбранный (picked) воб принудительно выделяем в списке
        [DllExport]
        public static void Export_SelectNodeByPtr(uint ptr)
        {
            if (ptr == 0)
            {
                return;
            }

            TreeEntry entry = null;

            try
            {
                entry =ObjTree.globalEntries
                    .Where(x => x.Value.zCVob == ptr)
                    .Select(pair => pair.Value)
                    .FirstOrDefault();
            }
            catch
            {
                ConsoleEx.WriteLineRed("Export_SelectNodeByPtr fail. No vob found in globalList. Addr: " + Utils.ToHex(ptr));

            }


            if (entry != null)
            {
                if (entry.node != null)
                {
                    //ConsoleEx.WriteLineYellow("SELECT");
                    SpacerNET.objTreeWin.globalTree.SelectedNode = entry.node;
                    entry.node.Expand();
                    entry.node.EnsureVisible();
                    Application.DoEvents();
                }
            }
        }
    }
}
