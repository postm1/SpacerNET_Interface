using SpacerUnion.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
        UI_LIST_SEARCH_RESULT,
        UI_WIN_VOBLIST
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

                case UIElementType.UI_WIN_VOBLIST:
                    {
                        obj = SpacerNET.vobList.listBoxVobs;

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
                entry = ObjTree.globalEntries
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

        [DllExport]
        public static void ShowVdfWarning()
        {
            SpacerNET.infoWin.AddText(Localizator.Get("WARNING_VDF_FILE_OPEN"), Color.Red);

        }

        // сообщение в окно
        [DllExport]
        public static void InfoWin_AddText()
        {
            string color_str = Imports.Stack_PeekString();
            string str = Imports.Stack_PeekString();

            color_str = color_str.ToUpper();

            var lightGray = System.Drawing.ColorTranslator.FromHtml(color_str);

            if (lightGray != Color.Empty)
            {
                //ConsoleEx.WriteLineYellow(lightGray.ToString());
                SpacerNET.infoWin.AddText_External(str, lightGray);
            }
            else
            {
                //ConsoleEx.WriteLineYellow("No color, black");
                SpacerNET.infoWin.AddText_External(str, Color.Black);
            }

        }


        // сообщение в окно zspy
        [DllExport]
        public static void InfoWin_AddTextZSPY()
        {
            string color_str = Imports.Stack_PeekString();
            string str = Imports.Stack_PeekString();

            color_str = color_str.ToUpper();

            var lightGray = System.Drawing.ColorTranslator.FromHtml(color_str);

            if (lightGray != Color.Empty)
            {
                //ConsoleEx.WriteLineYellow(lightGray.ToString());
                SpacerNET.infoWin.AddText_ExternalSpy(str, lightGray);
            }
            else
            {
                //ConsoleEx.WriteLineYellow("No color, black");
                SpacerNET.infoWin.AddText_ExternalSpy(str, Color.Black);
            }

        }


        [DllExport]
        public static void Export_GetSha256()
        {
            string input = Imports.Stack_PeekString();
            string hash = Utils.sha256_hash(input);

            Imports.Stack_PushString(hash);
        }



        // фильтр материалов
        [DllExport]
        public static void Fill_MatFilter_Filters()
        {
            var listView = SpacerNET.matFilterWin.listBoxFilter;

            int id = Imports.Stack_PeekInt();
            string name = Imports.Stack_PeekString();

            MatFilter mat = new MatFilter();

            mat.id = id;
            mat.name = name;

            SpacerNET.matFilterWin.filters.Add(mat);

            listView.Items.Add(name);
        }

        [DllExport]
        public static void Clear_MatFilter_Filters()
        {
            var listView = SpacerNET.matFilterWin.listBoxFilter;
            listView.Items.Clear();
        }


        [DllExport]
        public static void AddMatByMatFilterName()
        {
            var listView = SpacerNET.matFilterWin.listBoxMatList;
            uint addr = Imports.Stack_PeekUInt();
            string name = Imports.Stack_PeekString();


            SpacerNET.matFilterWin.matAddr.Add(name, addr);

            listView.Items.Add(name);
        }


        [DllExport]
        public static void MatFilter_SelectFilterByIndex()
        {
            var listView = SpacerNET.matFilterWin.listBoxFilter;
            int index = Imports.Stack_PeekInt();

            if (listView.Items.Count > 0 && listView.Items.Count > index)
            {
                listView.SelectedIndex = index;
            }
        }

        [DllExport]
        public static void MatFilter_SelectMaterialByAddr()
        {
            var listView = SpacerNET.matFilterWin.listBoxMatList;
            var dict = SpacerNET.matFilterWin.matAddr;

            uint addr = Imports.Stack_PeekUInt();

            if (dict.ContainsValue(addr))
            {
                var myKey = dict.FirstOrDefault(x => x.Value == addr).Key;

                listView.SelectedItem = myKey;
            }
        }

        [DllExport]
        public static void MatFilter_ToggleWindow()
        {
            bool toggle = Convert.ToBoolean(Imports.Stack_PeekInt());
            bool blocked = Convert.ToBoolean(Imports.Stack_PeekInt());

 
            SpacerNET.matFilterWin.groupBoxMatSettings.Enabled = SpacerNET.matFilterWin.listBoxFilter.SelectedIndex != -1;
            SpacerNET.matFilterWin.panelFilters.Enabled = toggle;
            

            if (blocked)
            {
                SpacerNET.matFilterWin.labelMatBadFormat.Visible = blocked;
            }
        }


        [DllExport]
        public static void MatFilter_SetTextureColor()
        {
            int b = Imports.Stack_PeekInt();
            int g = Imports.Stack_PeekInt();
            int r = Imports.Stack_PeekInt();

            Color color = Color.FromArgb(r, g, b);

            SpacerNET.matFilterWin.pictureBoxTexture.BackColor = color;
        }

        [DllExport]
        public static void MatFilter_SendTexture()
        {
            int size = Imports.Stack_PeekInt();
            uint addr = Imports.Stack_PeekUInt();


            //ConsoleEx.WriteLineYellow("size: " + size + " addr: " + addr);
            var box = SpacerNET.matFilterWin.pictureBoxTexture;

            const int IMAGE_SIZE = 128;

            Bitmap myBitmap = new Bitmap(IMAGE_SIZE, IMAGE_SIZE, PixelFormat.Format32bppArgb);
            byte[] pixels = new byte[IMAGE_SIZE * IMAGE_SIZE * 4];

            IntPtr ptr = new IntPtr(addr);
            

            Marshal.Copy(ptr, pixels, 0, pixels.Length);


            //Array.Reverse(pixels);


            int count = 0;

            for (int x = 0; x < IMAGE_SIZE; x++)
            {
                int row = x * IMAGE_SIZE * 4;

                for (int y = 0; y < IMAGE_SIZE; y++)
                {
                    int col = row + (y * 4);
                    byte r = pixels[col + 2];
                    byte g = pixels[col + 1];
                    byte b = pixels[col + 0];
                    byte a = pixels[col + 3];

                    Color c = Color.FromArgb(
                           a, r, g, b
                        );

                    myBitmap.SetPixel(x, y, c);
                }
            }

            box.BackColor = Color.Transparent;
            box.Image = myBitmap;
         
        }
    }
}
