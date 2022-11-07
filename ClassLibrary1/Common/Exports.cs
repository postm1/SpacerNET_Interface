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
using System.Threading.Tasks;
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
                        //obj = SpacerNET.objTreeWin.matTree;

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
            /*
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
            */
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
        public static void MatFilter_AddMatInSearchByName()
        {
            var listView = SpacerNET.matFilterWin.listBoxMatFilSearch;
            
            string name = Imports.Stack_PeekString();
            int libFlag = Imports.Stack_PeekInt();
            listView.Items.Add(name);

            SpacerNET.matFilterWin.foundMatList.Add(name, libFlag);
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
        public static void MatFilter_AddCurrentFilterIndexToSave()
        {
            var index = SpacerNET.matFilterWin.listBoxFilter.SelectedIndex;
            var listBox = SpacerNET.matFilterWin.listBoxMatList;
            string matName = Imports.Stack_PeekString();

            if (index != -1)
            {
                if (!SpacerNET.matFilterWin.filderIndexToSaveList.Contains(index))
                {
                    SpacerNET.matFilterWin.filderIndexToSaveList.Add(index);
                    //ConsoleEx.WriteLineRed("Save index by set params: " + index);
                    //SpacerNET.matFilterWin.SaveFilterChanges();

                    //int indexPrev = listBox.SelectedIndex;

                    
                }
                SpacerNET.matFilterWin.lastMaterialSelectIndex = -1;
                SpacerNET.matFilterWin.buttonSavePML_File.Enabled = true;
                SpacerNET.matFilterWin.listBoxMatList_SelectedIndexChanged(listBox, null);

                string currentName = SpacerNET.matFilterWin.listBoxMatList.SelectedItem.ToString();
               // ConsoleEx.WriteLineRed(currentName + " " + matName);

                matName = matName.ToUpper();

                if (currentName != matName)
                {
                    //ConsoleEx.WriteLineRed("Change name");
                    if (SpacerNET.matFilterWin.matAddr.ContainsKey(currentName))
                    {

                       //ConsoleEx.WriteLineRed("Rename");

                        uint addr = SpacerNET.matFilterWin.matAddr[currentName];

                        SpacerNET.matFilterWin.matAddr.Remove(currentName);

                        SpacerNET.matFilterWin.matAddr.Add(matName, addr);

                        SpacerNET.matFilterWin.listBoxMatList.Items[SpacerNET.matFilterWin.listBoxMatList.SelectedIndex] = matName;


                    }
                }
                    
            }
        }

        
        [DllExport]
        public static void MatFilter_SetEmptyTexture()
        {
            string texName = Imports.Stack_PeekString();
            SpacerNET.matFilterWin.pictureBoxTexture.Image = Properties.Resources.TEX_NOT_FOUND_V5;
            SpacerNET.matFilterWin.textBoxTexName.Text = texName + " " + Localizator.Get("WIN_MATFILTER_TEXTURE_NOT_FOUND");
            SpacerNET.matFilterWin.textBoxTexName.ForeColor = Color.Red;

            SpacerNET.matFilterWin.labelTexSize.Text = Localizator.Get("WIN_MATFILTER_FILTER_SETTINGS_SIZE") + " -";
            SpacerNET.matFilterWin.labelTexAlpha.Text = Localizator.Get("WIN_MATFILTER_FILTER_SETTINGS_ALPHA") + " -";

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
            int blockedWin = Imports.Stack_PeekInt();

 
            SpacerNET.matFilterWin.groupBoxMatSettings.Enabled = SpacerNET.matFilterWin.listBoxFilter.SelectedIndex != -1;
            SpacerNET.matFilterWin.groupBoxFilterTexShowSettings.Enabled = SpacerNET.matFilterWin.listBoxFilter.SelectedIndex != -1;
            SpacerNET.matFilterWin.groupBoxFilterMenu.Enabled = toggle;
            SpacerNET.matFilterWin.textBoxFilterSearch.Enabled = toggle;
            SpacerNET.matFilterWin.groupBoxMatFilterMisc.Enabled = toggle;
            

            if (blockedWin == 0)
            {
                // SpacerNET.matFilterWin.labelMatBadFormat.Text = Localizator.Get("WIN_MATFILTER_ERR_FORMAT");
                SpacerNET.matFilterWin.toolStripStatusFilterMat.Text = Localizator.Get("WIN_MATFILTER_ERR_NO");
                SpacerNET.matFilterWin.toolStripStatusFilterMat.ForeColor = Color.Black;

                if (!toggle)
                {
                    SpacerNET.matFilterWin.toolStripStatusFilterMat.Text = Localizator.Get("WIN_MATFILTER_ERR_WORK");
                    
                }
            }
            else if (blockedWin == 1)
            {
               // SpacerNET.matFilterWin.labelMatBadFormat.Text = Localizator.Get("WIN_MATFILTER_ERR_FORMAT");
                SpacerNET.matFilterWin.toolStripStatusFilterMat.Text = Localizator.Get("WIN_MATFILTER_ERR_FORMAT");
                SpacerNET.matFilterWin.toolStripStatusFilterMat.ForeColor = Color.Red;
            }
            else if (blockedWin == 2)
            {
                SpacerNET.matFilterWin.toolStripStatusFilterMat.Text = Localizator.Get("WIN_MATFILTER_ERR_READONLY");
                SpacerNET.matFilterWin.toolStripStatusFilterMat.ForeColor = Color.Red;
            }

           // SpacerNET.matFilterWin.labelMatBadFormat.Visible = blockedWin != 0;
        }


        [DllExport]
        public static void MatFilter_SetTextureColor()
        {
            int b = Imports.Stack_PeekInt();
            int g = Imports.Stack_PeekInt();
            int r = Imports.Stack_PeekInt();

            Color color = Color.FromArgb(r, g, b);


            if (SpacerNET.matFilterWin.pictureBoxTexture.Image != null)
            {
                SpacerNET.matFilterWin.pictureBoxTexture.Image.Dispose();
                SpacerNET.matFilterWin.pictureBoxTexture.Image = null;
            }
            

            SpacerNET.matFilterWin.pictureBoxTexture.BackColor = color;

            SpacerNET.matFilterWin.labelTexSize.Text = Localizator.Get("WIN_MATFILTER_FILTER_SETTINGS_SIZE") + " -";
            SpacerNET.matFilterWin.labelTexAlpha.Text = Localizator.Get("WIN_MATFILTER_FILTER_SETTINGS_ALPHA") + " -";
            SpacerNET.matFilterWin.textBoxTexName.Text = String.Empty;
            SpacerNET.matFilterWin.textBoxTexName.ForeColor = Color.Black;

        }

        // labelTexSize.Text = "Размер: " 

        [DllExport]
        public static void MatFilter_UpdateTextureSize()
        {
            string size = Imports.Stack_PeekString();
            string name = Imports.Stack_PeekString();

            SpacerNET.matFilterWin.labelTexSize.Text = Localizator.Get("WIN_MATFILTER_FILTER_SETTINGS_SIZE") + size + Localizator.Get("WIN_MATFILTER_FILTER_SETTINGS_BITS");
            // SpacerNET.matFilterWin.labelTextureName.Text = "Текстура: " + name;
            SpacerNET.matFilterWin.textBoxTexName.Text = name;
            SpacerNET.matFilterWin.textBoxTexName.ForeColor = Color.Black;
        }


        [DllExport]
        public static void MatFilter_UpdateTextureAlphaInfo()
        {
            bool isAlpha = Convert.ToBoolean(Imports.Stack_PeekInt());

            if (isAlpha)
            {
                SpacerNET.matFilterWin.labelTexAlpha.Text = Localizator.Get("WIN_MATFILTER_FILTER_SETTINGS_ALPHA_YES");
            }
            else
            {
                SpacerNET.matFilterWin.labelTexAlpha.Text = Localizator.Get("WIN_MATFILTER_FILTER_SETTINGS_ALPHA_NO");
            }
           
        }

        

        [DllExport]
        public static void MatFilter_Clear()
        {
            var win = SpacerNET.matFilterWin;

            win.listBoxMatList.Items.Clear();
            win.listBoxMatFilSearch.Items.Clear();
            win.matAddr.Clear();
            win.foundMatList.Clear();

            if (win.pictureBoxTexture.Image != null)
            {
                win.pictureBoxTexture.Image.Dispose();
                win.pictureBoxTexture.Image = null;
            }

            win.pictureBoxTexture.BackColor = Color.White;

            win.listBoxFilter.Items.Clear();
            win.filderIndexToSaveList.Clear();
            win.buttonSavePML_File.Enabled = false;
            win.lastForceFilterIndex = -1;

            win.labelTexSize.Text = Localizator.Get("WIN_MATFILTER_FILTER_SETTINGS_SIZE") + " -";
            win.labelTexAlpha.Text = Localizator.Get("WIN_MATFILTER_FILTER_SETTINGS_ALPHA") + " -";
            win.textBoxTexName.Text = String.Empty;
            win.textBoxTexName.ForeColor = Color.Black;
    
            win.labelMatCountCurrentFilter.Text = Localizator.Get("WIN_MATFILTER_MATLIST_CURRENT_EMPTY");
        }

        private static void Fill_BlackLayer()
        {
           // ConsoleEx.WriteLineYellow("black enter");
            var box = SpacerNET.matFilterWin.pictureBoxTexture;

            Graphics g = Graphics.FromImage(box.Image);

            SolidBrush blackBrush = new SolidBrush(Color.FromArgb(255, 0, 0, 0));

            g.FillRectangle(blackBrush, 0, 0, 128, 128);
          //  ConsoleEx.WriteLineYellow("black end");
        }

        private static void Fill_AlphaChannelLayer()
        {
           // ConsoleEx.WriteLineYellow("alpha enter");
            var box = SpacerNET.matFilterWin.pictureBoxTexture;

            // создаём полотно для рисования из текущей картинки в pictureBox
            Graphics g = Graphics.FromImage(box.Image);

            // создаём серую кисть для закрашивания подкладки альфа-канала
            using (SolidBrush gray = new SolidBrush(Color.FromArgb(255, 192, 192, 192)))
            {

                // смещение слева от начала закрашивания серых квадратов
                // (пропадает(0) и появляется(4) с каждой новой закрашиваемой строкой)
                int offsetX = 0;

                // размеры элементов(квадратов) альфа-канала (в пикселях)
                int fillBox = 8;

                // очищаем полотно перед началом рисования
                g.Clear(Color.White);

                // пробегаемся по всей высоте бокса
                // (каждую новую строку переключаем смещение от начала для имитации шахматной доски)
                for (int y = 0; y < box.Height; y = y + fillBox)
                {
                    // и по всей ширине бокса
                    // (блок закрашиваем, блок пропускаем и так по всему ряду)
                    for (int x = offsetX; x < box.Width; x = x + fillBox * 2)
                    {
                        // закрашиваем серый квадрат заданным размером в "fillBox"
                        g.FillRectangle(gray, x, y, fillBox, fillBox);
                    }

                    // если смещения не было
                    if (offsetX == 0)
                        // включаем
                        offsetX = fillBox;
                    else // иначе, смещение было
                        // выключаем
                        offsetX = 0;
                }

            } // end using gray brush

            //ConsoleEx.WriteLineYellow("alpha end");
        }

        [DllExport]
        public static void MatFilter_SendTexture()
        {
            //ConsoleEx.WriteLineYellow("MatFilter_SendTexture");

            uint addr = Imports.Stack_PeekUInt();
            bool hasAlpha = Convert.ToBoolean(Imports.Stack_PeekInt());

           // var watch = System.Diagnostics.Stopwatch.StartNew();
            //ConsoleEx.WriteLineYellow("size: " + size + " addr: " + addr);
            var box = SpacerNET.matFilterWin.pictureBoxTexture;

            const int IMAGE_SIZE = 128;

            int[] pixels = new int[IMAGE_SIZE * IMAGE_SIZE];


            UIntPtr ptr = new UIntPtr(addr);

            IntPtr intPtr = (IntPtr)(int)(uint)ptr;

            Marshal.Copy(intPtr, pixels, 0, pixels.Length);



            if (box.Image != null)
            {
                box.Image.Dispose();
            }

            //ConsoleEx.WriteLineYellow("3");
            var bitMap = new Bitmap(IMAGE_SIZE, IMAGE_SIZE);
            box.Image = bitMap;


            if (!hasAlpha || !SpacerNET.matFilterWin.checkBoxTexImageUseAlpha.Checked)
            {
                Fill_BlackLayer();
            }
            else
            {
                Fill_AlphaChannelLayer();
            }

            //ConsoleEx.WriteLineYellow("4");

           // watch.Stop();
          //  ConsoleEx.WriteLineYellow("Fill_AlphaChannelLayer: " + watch.ElapsedMilliseconds);


           // watch = System.Diagnostics.Stopwatch.StartNew();






            
            Graphics graph = Graphics.FromImage(box.Image);

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(128, 255, 0, 0)))
            {


                for (int y = 0; y < IMAGE_SIZE; y++)
                {
                    for (int x = 0; x < IMAGE_SIZE; x++)
                    {
                        int pos = y * IMAGE_SIZE + x;

                        int col = pixels[pos];
                        byte[] intBytes = BitConverter.GetBytes(col);


                        byte r = intBytes[2];
                        byte g = intBytes[1];
                        byte b = intBytes[0];
                        byte a = intBytes[3];

                        brush.Color = Color.FromArgb(
                               a, r, g, b
                            );

                        graph.FillRectangle(brush, x, y, 1, 1);
                    }
                }
            }
            
            //watch.Stop();
           // ConsoleEx.WriteLineYellow("5");
            // ConsoleEx.WriteLineYellow("FillBrush: " + watch.ElapsedMilliseconds);

        }
    }
}
