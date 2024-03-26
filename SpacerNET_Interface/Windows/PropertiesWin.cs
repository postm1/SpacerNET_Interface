
using SpacerUnion.Common;
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
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SpacerUnion
{
    public partial class ObjectsWindow : Form
    {
        

        static List<CProperty> props = new List<CProperty>();
        static Dictionary<string, FolderEntry> folders = new Dictionary<string, FolderEntry>();
        static string currentFolderName;
        static bool changed = false;
        static TPropEditType currentFieldtype;
        static TreeNode showFirst;
        static bool isItemSelected;
        static bool isMaterialSelected;

        static string currentContents;
        static int containsIndex;
        static TreeNode containsNode;
        static bool vobHasContainer = false;
        static bool updateRenderWindow = false;
        static string classNameGlobal;

        public static string lastSelectedNodeName;
        static bool blockUpdateLastNodeName;

        static Timer updateTimer;

        protected override CreateParams CreateParams
        {
            get
            {
                // Activate double buffering at the form level.  All child controls will be double buffered as well.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                return cp;
            }
        }


        public ObjectsWindow()
        {
            InitializeComponent();

            lastSelectedNodeName = String.Empty;
            blockUpdateLastNodeName = false;

            updateTimer = new Timer();
            updateTimer.Enabled = true;
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Interval = 1;

            this.DoubleBuffered = true;

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            Helper.EnableDoubleBuffering(this.treeViewProp);

        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            //this.treeViewProp.Refresh();
        }

        public void UpdateLang()
        {
            this.Text = Localizator.Get("WIN_PROPS_TITLE");
            Label_Backup.Text = Localizator.Get("Label_Backup");
            buttonApplyOnVob.Text = Localizator.Get("BTN_APPLY");
            buttonFileOpen.Text = Localizator.Get("buttonFileOpen");
            buttonRestoreVobProp.Text = Localizator.Get("buttonRestoreVobProp");
            buttonOpenContainer.Text = Localizator.Get("buttonOpenContainer");
            tabControlProps.TabPages[0].Text = Localizator.Get("tabControlProps_0");
            tabControlProps.TabPages[1].Text = Localizator.Get("tabControlProps_1");
            tabControlProps.TabPages[2].Text = Localizator.Get("tabControlProps_2");
            tabControlProps.TabPages[3].Text = Localizator.Get("tabControlProps_3");

            // groupBoxEditBbox.Text = Localizator.Get("groupBoxEditBbox");
            buttonResetBbox.Text = Localizator.Get("WIN_CANCEL_BUTTON");
            buttonApplyBbox.Text = Localizator.Get("BTN_APPLY");

            //groupBoxContainer.Text = Localizator.Get("groupBoxContainer");
            buttonClearItems.Text = Localizator.Get("buttonClearItems");
            buttonRowDelete.Text = Localizator.Get("buttonRowDelete");
            buttonContainerCancel.Text = Localizator.Get("WIN_CANCEL_BUTTON");
            buttonContainerApply.Text = Localizator.Get("BTN_APPLY");
            buttonSelectColor.Text = Localizator.Get("PROP_BUTTON_COLOR");

            

            dataGridViewItems.Columns[0].HeaderText = Localizator.Get("ITEMS_COLUMN_INSTANCE");
            dataGridViewItems.Columns[1].HeaderText = Localizator.Get("ITEMS_COLUMN_COUNT");


            checkBoxBoldFontProps.Text = Localizator.Get("checkBoxBoldFontProps");
            checkBoxFontUnderstroke.Text = Localizator.Get("checkBoxFontUnderstroke");
            buttonSelectFontProps.Text = Localizator.Get("buttonSelectFontProps");
            buttonResetFontDefault.Text = Localizator.Get("buttonResetFontDefault");
            labelChangeFontStyleText.Text = Localizator.Get("labelChangeFontStyleText");
        }

        public static void ChangeProp(string propName, string value)
        {
            for (int i = 0; i < props.Count; i++)
            {
                if (props[i].Name == propName)
                {
                    props[i].value = value;
                    props[i].ownNode.Text = props[i].Name + ": " + props[i].ShowValue();
                    break;
                }
            }
        }


        public static void CleanProps()
        {
            props.Clear();
            folders.Clear();

            currentFolderName = "";
            vobHasContainer = false;
            TreeView tree = SpacerNET.propWin.treeViewProp;

 
            tree.Nodes.Clear();


            EnableTab(SpacerNET.propWin.tabControlProps.TabPages[1], false); //edit props
            EnableTab(SpacerNET.propWin.tabControlProps.TabPages[2], false);//bbox
            EnableTab(SpacerNET.propWin.tabControlProps.TabPages[3], true);//container
            SpacerNET.propWin.tabControlProps.SelectedIndex = 0;

            SpacerNET.propWin.HideAllInput();
            SpacerNET.propWin.buttonApplyOnVob.Enabled = false;
            SpacerNET.propWin.buttonRestoreVobProp.Enabled = false;
            SpacerNET.propWin.buttonBbox.Enabled = false;
            SpacerNET.propWin.buttonFileOpen.Enabled = false;

            classNameGlobal = "";

        }

        [DllExport]

        public static void CleanPropWindow()
        {
            TreeView tree = SpacerNET.propWin.treeViewProp;
            //tree.Visible = false;
            CleanProps();
            //tree.Visible = true;
        }

        [DllExport]
        public static void PropsOpenContainer()
        {
            if (vobHasContainer && props.Count > 0)
            {
                SpacerNET.propWin.OpenVobContainer();
            }

        }

        
        [DllExport]
        public static void AddProps()
        {
            string inputStr = Imports.Stack_PeekString();
            string className = Imports.Stack_PeekString();
            TreeView tree = SpacerNET.propWin.treeViewProp;
           // ConsoleEx.WriteLineRed("AddProps");

            CleanProps();

            if (inputStr.Length == 0)
            {
                return;
            }

            SpacerNET.propWin.panelButtons.Enabled = false;
            tree.BeginUpdate();
            // tree.Visible = false;

            blockUpdateLastNodeName = true;

            TreeNode firstNode = tree.Nodes.Add(className + ": zCVob");
            firstNode.Tag = Constants.TAG_FOLDER;



            if (className == "oCItem")
            {
                isItemSelected = true;
            }
            else
            {
                isItemSelected = false;
            }

            if (className == "zCMaterial")
            {
                isMaterialSelected = true;
            }
            else
            {
                isMaterialSelected = false;
                EnableTab(SpacerNET.propWin.tabControlProps.TabPages[1], false);
                EnableTab(SpacerNET.propWin.tabControlProps.TabPages[2], false);
            }


            classNameGlobal = className;

            CProperty.originalStrPropsWindow = inputStr;

            string[] words = inputStr.Replace("\t", "").Split('\n');

            // сохраняем нетронутую строку
           

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();

                if (words[i].Length == 0 || words[i].Contains('[') || (!words[i].Contains(':') || !words[i].Contains('=')))
                {
                    continue;
                }

                if (words[i].Contains("groupBegin"))
                {
                    string folderName = words[i].Substring(0, words[i].IndexOf('='));

                    FolderEntry f = new FolderEntry();
                    f.parent = currentFolderName;
                    

                    if (currentFolderName == "")
                    {
                        TreeNode node = tree.Nodes.Add(folderName);
                        node.SelectedImageIndex = 0;
                        node.ImageIndex = 0;
                        node.Tag = Constants.TAG_FOLDER;
                        f.node = node;
                    }
                    else
                    {
                        for (int j = 0; j < tree.Nodes.Count; j++)
                        {
                            if (tree.Nodes[j].Text == currentFolderName)
                            {
                                TreeNode node = tree.Nodes[j].Nodes.Add(folderName);
                                node.SelectedImageIndex = 0;
                                node.ImageIndex = 0;
                                node.Tag = Constants.TAG_FOLDER;
                                f.node = node;
                                break;
                            }
                        }
                    }

                    folders.Add(folderName, f);
                    currentFolderName = folderName;
                    continue;
                }

                if (words[i].Contains("groupEnd"))
                {
                    currentFolderName = folders[currentFolderName].parent;
                    continue;
                }





                CProperty prop = new CProperty();
                prop.Name = words[i].Substring(0, words[i].IndexOf('='));
                prop.GroupName = currentFolderName;

                

                int pos = words[i].IndexOf('=');
                int pos2 = words[i].IndexOf(':');

                prop.SetType(words[i].Substring(pos+1, pos2 - pos-1));

                pos = words[i].IndexOf(':');

                prop.SetValue(words[i].Substring(pos + 1, words[i].Length - pos - 1));

                if (currentFolderName != "")
                {
                    prop.node = folders[currentFolderName].node;
                }

              
               

                if (prop.Name == "sndName")
                {
                    string value = prop.value;

                    //ConsoleEx.WriteLineRed("Looking for the sound...");

                    ListBox listBox = SpacerNET.soundWin.listBoxSound;

                    for (int k = 0; k < listBox.Items.Count; k++)
                    {
                        if (listBox.GetItemText(listBox.Items[k]) == value)
                        {
                            listBox.SelectedIndex = k;
                            break;
                        }
                            
                    }

                }



                

                /*
                Console.WriteLine("=================================");
                Console.WriteLine(words[i]);
                Console.WriteLine("[" + prop.Name + "][" + prop.GroupName + "][" + prop.type + "][" + prop.value + "]");
                Console.WriteLine("=================================");
                */

                props.Add(prop);

            }




            /*
            for (int i = 0; i < folders.Count; i++)
            {
                if (folders.ElementAt(i).Value.Length == 0)
                {
                    TreeNode node = tree.Nodes.Add(folders.ElementAt(i).Key);
                    node.SelectedImageIndex = 0;
                    node.ImageIndex = 0;
                    node.Tag = Constants.TAG_FOLDER;
                }
                else
                {
                    for (int j = 0; j < tree.Nodes.Count; j++)
                    {
                        if (tree.Nodes[j].Text == folders.ElementAt(i).Value)
                        {
                            TreeNode node = tree.Nodes[j].Nodes.Add(folders.ElementAt(i).Key);
                            node.SelectedImageIndex = 0;
                            node.ImageIndex = 0;
                            node.Tag = Constants.TAG_FOLDER;
                            break;
                        }
                    }
                }
                */

            //Console.WriteLine(folders.ElementAt(i).Key + ": " + folders.ElementAt(i).Value);

            showFirst = null;
            vobHasContainer = false;
            SpacerNET.propWin.buttonOpenContainer.Enabled = false;

            for (int i = 0; i < props.Count; i++)
            {
                TreeNode baseNode = props[i].node;
                var prop = props[i];

                if (props[i].Name == "contains")
                {
                    vobHasContainer = true;
                    SpacerNET.propWin.buttonOpenContainer.Enabled = true;
                }

                if (props[i].Name == "color")
                {
                    var color = props[i].value;

                    bool result = SpacerNET.propWin.SetColorPanelColor(color);

                    if (result)
                    {

                    }
                }


                if (baseNode != null)
                {
                    TreeNode node = baseNode.Nodes.Add(props[i].Name + ": " + props[i].ShowValue());

                    SetFieldBold(props[i].Name, node, className);
                    node.SelectedImageIndex = 5;
                    node.ImageIndex = 5;
                    node.Tag = i;
                    props[i].ownNode = node;

                    if (props[i].Name == "vobName")
                    {
                        showFirst = node;
                    }
                }
                else
                {
                    TreeNode node = tree.Nodes.Add(props[i].Name + ": " + props[i].ShowValue());
                   
                    SetFieldBold(props[i].Name, node, className);
                    node.SelectedImageIndex = 5;
                    node.ImageIndex = 5;
                    node.Tag = i;
                    props[i].ownNode = node;

                    if (props[i].Name == "vobName")
                    {
                        showFirst = node;
                    }
                }


                // значки для свойств
               
                if (prop.type == TPropEditType.PETbool)
                {
                    prop.ownNode.SelectedImageIndex = 5;
                    prop.ownNode.ImageIndex = 5;
                }
                else if (prop.type == TPropEditType.PETint)
                {
                    prop.ownNode.SelectedImageIndex = 11;
                    prop.ownNode.ImageIndex = 11;
                }
                else if (prop.type == TPropEditType.PETfloat)
                {
                    prop.ownNode.SelectedImageIndex = 9;
                    prop.ownNode.ImageIndex = 9;
                }
                else if (prop.type == TPropEditType.PETstring)
                {
                    prop.ownNode.SelectedImageIndex = 12;
                    prop.ownNode.ImageIndex = 12;
                }
                else if (prop.type == TPropEditType.PETenum)
                {
                    prop.ownNode.SelectedImageIndex = 8;
                    prop.ownNode.ImageIndex = 8;
                }
                else if (prop.type == TPropEditType.PETraw)
                {
                    prop.ownNode.SelectedImageIndex = 10;
                    prop.ownNode.ImageIndex = 10;
                }
                else if (prop.type == TPropEditType.PETvec3)
                {
                    prop.ownNode.SelectedImageIndex = 14;
                    prop.ownNode.ImageIndex = 14;
                }
                

            }


               


            tree.ExpandAll();

            for (int j = 0; j < folders.Count; j++)
            {
                if (folders.ElementAt(j).Key == "Internals")
                {
                    folders.ElementAt(j).Value.node.Collapse();
                }
            }

            if (showFirst != null)
            {
                tree.SelectedNode = showFirst;
            }


            blockUpdateLastNodeName = false;

            //ConsoleEx.WriteLineYellow("lastSelectedNodeName PRE aPPLY: " + lastSelectedNodeName);

            if (lastSelectedNodeName != String.Empty)
            {
               // ConsoleEx.WriteLineYellow("lastSelectedNodeName: " + lastSelectedNodeName);

                for (int i = 0; i < props.Count; i++)
                {
                    var prop = props[i];

                    //ConsoleEx.WriteLineYellow("Name: " + prop.Name);

                    if (prop.Name == lastSelectedNodeName)
                    {
                        //ConsoleEx.WriteLineGreen("Select Node: " + lastSelectedNodeName + " Index " + i);


                        tree.SelectedNode = prop.ownNode;
                        break;

                    }
                }
               
                //lastSelectedNodeName = String.Empty;
            }

            tree.EndUpdate();
            tree.Refresh();


            if (className == "zCVobLight")
            {
                SpacerNET.propWin.colorPanel.Visible = true;
            }

            //ConsoleEx.WriteLineYellow("AddProps End");
            if (Imports.Extern_CanEditBboxCurrentVob() == 0)
            {
                EnableTab(SpacerNET.propWin.tabControlProps.TabPages[1], false);
                SpacerNET.propWin.buttonBbox.Enabled = false;
                ///  ConsoleEx.WriteLineYellow("Disable");
            }
            else
            {
                SpacerNET.propWin.buttonBbox.Enabled = true;
            }




            // tree.Visible = true;
            //ConsoleEx.WriteLineYellow("AddProps End");
        }



        private void ObjectsWindow_Shown(object sender, EventArgs e)
        {
             this.treeViewProp.ImageList = imageListProps;

            if (Properties.Settings.Default.PropWindowFont != null)
            {

                TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));

                Font font = (Font)converter.ConvertFromString(Properties.Settings.Default.PropWindowFont);

                treeViewProp.Font = font;
            }


            Imports.Stack_PushString("checkBoxBoldFontProps");
            SpacerNET.propWin.checkBoxBoldFontProps.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());

            Imports.Stack_PushString("checkBoxFontUnderstroke");
            SpacerNET.propWin.checkBoxFontUnderstroke.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());


        }

        private void treeViewProp_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {

            /*
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
            */
        }

        private void ObjectsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
            SpacerNET.form.SetIconActive("props", false);
        }

        private void treeViewProp_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            int index = 0;
            TreeNode node = e.Node;


            if (isItemSelected)
            {
                return;
            }

            int.TryParse(node.Tag.ToString(), out index);


            if (index >= 0)
            {
                CProperty prop = props[index];

                if (prop.type == TPropEditType.PETbool)
                {
                    prop.value = prop.value == "0" ?  "1" : "0"; ;

                    node.Text = prop.Name + ": " + prop.ShowValue();

                    comboBoxPropsEnum.SelectedIndex = prop.value == "0" ? 0 : 1;

                    changed = true;
                    buttonApplyOnVob.Enabled = true;
                }

                if (prop.type == TPropEditType.PETenum)
                {
                    int currentIndex = 0;

                    Int32.TryParse(prop.value, out currentIndex);

                    currentIndex++;

                    if (currentIndex >= prop.enumArray.Count)
                    {
                        currentIndex = 0;
                    }

                    prop.value = currentIndex.ToString();

                    node.Text = prop.Name + ": " + prop.ShowValue();

                    comboBoxPropsEnum.SelectedIndex = currentIndex;

                    changed = true;
                    
                    buttonApplyOnVob.Enabled = true;
                    buttonRestoreVobProp.Enabled = true;
                }

                if (prop.Name == "contains")
                {
                    OpenVobContainer(prop, index);
                }
                else if (prop.Name == "visual" || prop.Name == "texture")
                {
                    buttonFileOpen_Click(null, null);
                }
            }

        }


        public void OpenVobContainer(CProperty prop = null, int index=-1)
        {

            if (prop == null)
            {
                for (int i = 0; i < props.Count; i++)
                {
                    if (props[i].Name == "contains")
                    {
                        prop = props[i];
                        index = i;
                        SpacerNET.propWin.treeViewProp.SelectedNode = prop.ownNode;
                        break;
                    }
                }
            }

            EnableTab(tabControlProps.TabPages[2], true);
            tabControlProps.SelectedIndex = 2;

            dataGridViewItems.Visible = true;
            dataGridViewItems.Rows.Clear();

            ObjectsWin.ChangeTab(1);

            currentContents = prop.value;
            containsIndex = index;
            containsNode = props[index].node;

            currentContents = currentContents.Replace(';', ',');

            List<string> items = currentContents.Split(',').ToList();

            for (int i = 0; i < items.Count; i++)
            {
                string item = items[i].Trim();

                string[] arr = item.Split(':');

                if (arr[0].Trim().Length == 0)
                {
                    continue;
                }

                if (arr.Length == 1)
                {
                    dataGridViewItems.Rows.Add(arr[0].Trim(), "1");
                }
                else
                {
                    dataGridViewItems.Rows.Add(arr[0].Trim(), arr[1].Trim());
                }

            }
        }
        private void buttonApply_Click(object sender, EventArgs e)
        {

            if (isItemSelected)
            {
                //return;
            }


            TreeNode node = treeViewProp.SelectedNode;
            TextBox textBox = sender as TextBox;
            int index = 0;

            if (node != null && node.Tag.ToString() != Constants.TAG_FOLDER)
            {
                int.TryParse(node.Tag.ToString(), out index);

                if (index >= 0)
                {

                    //Console.WriteLine("Change entry with index: " + index);
                    CProperty prop = props[index];

                    if (prop.Name == "vobName")
                    {
                        string newName = prop.value;

                        Imports.Stack_PushString(newName);

                        if (Imports.Extern_CheckUniqueNameExist() == 1)
                        {
                            MessageBox.Show(Localizator.Get("NAME_ALREADY_EXISTS"));
                            
                            return;
                        }
                    }
                    else if (prop.Name == "name")
                    {
                        string newName = prop.value;

                        Imports.Stack_PushString(newName);

                        if (Imports.Extern_CheckUniqueNameExist() == 1)
                        {
                            MessageBox.Show(Localizator.Get("NAME_ALREADY_EXISTS"));

                            return;
                        }
                    }
                }
            }




            // блокируем кнопку Применить
            changed = false;
            buttonApplyOnVob.Enabled = false;


            StringBuilder str = new StringBuilder();

           

            string[] words = CProperty.originalStrPropsWindow.Replace("\t", "").Split('\n');

            //Console.WriteLine("Original: {0}", CProperty.originalStr);


            string nameValue = "";
            string visual = "";

            for (int j = 0; j < words.Length; j++)
            {
                if (words[j].Length == 0)
                {
                    continue;
                }
                
                for (int i = 0; i < props.Count; i++)
                {
                    if (Regex.IsMatch(words[j], "^" + props[i].Name + @"=\w", RegexOptions.IgnoreCase))
                    {
                        string baseStr = words[j].Substring(0, words[j].IndexOf(':') + 1) + props[i].value;
                        //Console.WriteLine(baseStr);
                        words[j] = baseStr;
                    }


                }
                
            }

            int wasPositionChanged = 0;
             
            for (int i = 0; i < props.Count; i++)
            {
                if (props[i].Name == "vobName")
                {
                    nameValue = props[i].value;
                }

                if (props[i].Name == "visual")
                {
                    visual = props[i].value;
                }

                // обновляем позицию воба из введенных данных
                if (props[i].Name == "trafoOSToWSPos" && props[i].value != props[i].backup_value)
                {
                    wasPositionChanged = 1;
                    //ConsoleEx.WriteLineYellow("Pos was changed");
                }

                if (props[i].Name == "color")
                {
                    bool result = SpacerNET.propWin.SetColorPanelColor(props[i].value);

                    if (!result)
                    {
                        return;
                    }
                }
            }

            for (int j = 0; j < words.Length; j++)
            {
                str.Append(words[j] + "\n");
            }


            Imports.Stack_PushString(visual);
            Imports.Stack_PushString(nameValue);
            Imports.Stack_PushString(str.ToString());
            Imports.Stack_PushInt(wasPositionChanged);
            Imports.Extern_ApplyProps();
            this.treeViewProp.Refresh();
        }

        public void DisableTabBBox()
        {
            textBoxBbox0.Text = "";
            textBoxBbox1.Text = "";
            textBoxBbox2.Text = "";
            EnableTab(tabControlProps.TabPages[1], false);
            EnableTab(tabControlProps.TabPages[2], false);
        }

        public void HideAllInput()
        {
            textBoxString.Visible = false;
            Label_Backup.Visible = false;
            textBoxVec0.Visible = false;
            textBoxVec1.Visible = false;
            textBoxVec2.Visible = false;
            textBoxVec3.Visible = false;
            buttonFileOpen.Enabled = false;
            comboBoxPropsEnum.Visible = false;
            buttonSelectColor.Visible = false;
            colorPanel.Visible = false;
            DisableTabBBox();

        }

        public bool IsItemFieldAllowed(string name)
        {
            if (name == "trafoOSToWSPos" || name == "trafoOSToWSRot")
            {
                return true;
            }

            return false;
        }
        private void treeViewProp_AfterSelect(object sender, TreeViewEventArgs e)
        {

           // ConsoleEx.WriteLineRed("treeViewProp_AfterSelect");
            TreeNode node = e.Node;
            int index = 0;

            if (node.Tag != null && node.Tag.ToString() != Constants.TAG_FOLDER)
            {
                int.TryParse(node.Tag.ToString(), out index);

                if (index >= 0)
                {

                    

                    HideAllInput();


                   


                    CProperty prop = props[index];

                    if (!blockUpdateLastNodeName)
                    {
                        lastSelectedNodeName = prop.Name;
                       // ConsoleEx.WriteLineRed("lastSelectedNodeName set: " + prop.Name + " index: " + index);
                    }


                    if (classNameGlobal == "zCVobLight")
                    {
                        if (prop.Name != "trafoOSToWSPos" && prop.Name != "trafoOSToWSRot" && prop.Name != "bbox3DWS")
                        {
                            SpacerNET.propWin.colorPanel.Visible = true;
                        }

                    }

                    if (prop.Name == "itemInstance")
                    {
                        return;
                    }

                    if (isItemSelected)
                    {
                        if (!IsItemFieldAllowed(prop.Name))
                        {
                            return;
                        }
                    }

                    if (prop.type == TPropEditType.PETstring || prop.type == TPropEditType.PETraw || prop.type == TPropEditType.PETint 
                        || prop.type == TPropEditType.PETfloat || prop.type == TPropEditType.PETcolor)
                    {
                        textBoxString.Visible = true;
                        textBoxString.Text = prop.value;

                        if ((prop.type == TPropEditType.PETstring || prop.type == TPropEditType.PETraw || prop.type == TPropEditType.PETcolor) && prop.Name != "trafoOSToWSRot")
                        {
                            textBoxString.Width = 298;
                            buttonFileOpen.Enabled = true;
                        }
                        else if (prop.type == TPropEditType.PETint || prop.type == TPropEditType.PETfloat)
                        {
                            textBoxString.Width = 75;
                        }
                    }

                    if (prop.type == TPropEditType.PETvec3)
                    {
                        textBoxVec0.Visible = true;
                        textBoxVec1.Visible = true;
                        textBoxVec2.Visible = true;



                        string[] arr = prop.value.Split(' ');

                        textBoxVec0.Text = arr[0];
                        textBoxVec1.Text = arr[1];
                        textBoxVec2.Text = arr[2];

                    }

                    if (prop.type == TPropEditType.PETcolor)
                    {
                        buttonSelectColor.Visible = true;
                    }

                    if (prop.type == TPropEditType.PETenum)
                    {
                        comboBoxPropsEnum.Visible = true;
                        comboBoxPropsEnum.Items.Clear();
                        comboBoxPropsEnum.Items.AddRange(prop.enumArray.ToArray());
                        comboBoxPropsEnum.SelectedIndex = prop.GetCurrentEnumIndex();
                    }

                    if (prop.type == TPropEditType.PETbool)
                    {
                        comboBoxPropsEnum.Visible = true;
                        comboBoxPropsEnum.Items.Clear();
                        comboBoxPropsEnum.Items.Add("FALSE");
                        comboBoxPropsEnum.Items.Add("TRUE");
                        comboBoxPropsEnum.SelectedIndex = prop.value == "1" ? 1 : 0;
                    }




                    currentFieldtype = prop.type;

                    Label_Backup.Text = Localizator.Get("Label_Backup") + ": " + prop.ShowBackupValue();

                    if (isItemSelected)
                    {
                        //return;
                    }

                    Label_Backup.Visible = true;

                  
                    buttonRestoreVobProp.Enabled = true;
                    
                    
                }
            }

            SpacerNET.propWin.panelButtons.Enabled = true;
        }

        private void textBoxString_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBoxString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (currentFieldtype == TPropEditType.PETint)
            {
                if (!char.IsControl(e.KeyChar) && !Utils.IsNumberInput(e.KeyChar, false, true))
                {
                    e.Handled = true;
                }
            }
            else if ( currentFieldtype == TPropEditType.PETfloat)
            {
                if (!char.IsControl(e.KeyChar) && !Utils.IsNumberInput(e.KeyChar, true, true))
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

        private void textBoxString_TextChanged(object sender, EventArgs e)
        {

            if (isItemSelected)
            {
                //return;
            }



            TreeNode node = treeViewProp.SelectedNode;
            TextBox textBox = sender as TextBox;
            int index = 0;

            if (node != null && node.Tag.ToString() != Constants.TAG_FOLDER)
            {
                int.TryParse(node.Tag.ToString(), out index);

                if (index >= 0)
                {


                    //Console.WriteLine("Change entry with index: " + index);
                    CProperty prop = props[index];

                    /*
                    if (prop.backup_value == textBox.Text.Trim())
                    {
                        buttonApply.Enabled = false;
                        buttonRestore.Enabled = false;
                        return;
                    }
                    */

                    string textTry = textBox.Text.Trim();



                    if (prop.type == TPropEditType.PETfloat)
                    {
                        textTry = textTry.Replace(',', '.');
                    }
                    else if (prop.type == TPropEditType.PETint)
                    {
                        if (textTry.Contains('.'))
                        {
                            
                            MessageBox.Show(Localizator.Get("FORM_ENTER_BAD_VALUE_INT"));
                            textBox.Text = String.Empty;
                            return;
                        }
                    }
                    else
                    {
                        if (textTry.Length > 0 && !Utils.IsOnlyLatin(textTry) && Utils.IsOptionActive("checkBoxOnlyLatinInInput"))
                        {
                            MessageBox.Show(Localizator.Get("FORM_ENTER_BAD_STRING_INPUT"));
                            return;
                        }
                    }

                    prop.value = textTry;
                    node.Text = prop.Name + ": " + prop.ShowValue();
                    buttonApplyOnVob.Enabled = true;
                    buttonRestoreVobProp.Enabled = true;
                }
            }
            else
            {
                ConsoleEx.WriteLineGreen("Textbox change with null node");
            }
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            if (isItemSelected)
            {
                //return;
            }

            TreeNode node = treeViewProp.SelectedNode;
            TextBox textBox = sender as TextBox;
            int index = 0;

            if (node != null && node.Tag.ToString() != Constants.TAG_FOLDER)
            {
                int.TryParse(node.Tag.ToString(), out index);

                if (index >= 0)
                {

                    CProperty prop = props[index];

                    prop.value = prop.backup_value;
                    node.Text = prop.Name + ": " + prop.ShowValue();

                    if (currentFieldtype == TPropEditType.PETvec3)
                    {
                        string[] arr = prop.value.Split(' ');

                        textBoxVec0.Text = arr[0];
                        textBoxVec1.Text = arr[1];
                        textBoxVec2.Text = arr[2];

                    }
                    else if (currentFieldtype == TPropEditType.PETenum)
                    {
                        comboBoxPropsEnum.SelectedIndex = prop.GetCurrentEnumIndex();
                    }
                    else
                    {
                        textBoxString.Text = prop.value;
                    }
                   

                    changed = true;
                    buttonApplyOnVob.Enabled = true;
                    buttonRestoreVobProp.Enabled = true;
                }
            }
            else
            {
                ConsoleEx.WriteLineGreen("Restore with null node");
            }
        }

        private void ChangeVecDataTextBox(object sender, EventArgs e)
        {
            TreeNode node = treeViewProp.SelectedNode;
            TextBox textBox = sender as TextBox;
            int index = 0;

            if (isItemSelected)
            {
                //return;
            }

            if (node != null && node.Tag.ToString() != Constants.TAG_FOLDER)
            {
                int.TryParse(node.Tag.ToString(), out index);

                if (index >= 0)
                {

                    //Console.WriteLine("Change entry with index: " + index);
                    CProperty prop = props[index];

                    prop.value = textBoxVec0.Text.Trim() + " " + textBoxVec1.Text.Trim() + " " + textBoxVec2.Text.Trim();

                    node.Text = prop.Name + ": " + prop.ShowValue();

                    changed = true;
                    buttonApplyOnVob.Enabled = true;
                    buttonRestoreVobProp.Enabled = true;


                }
            }
            else
            {
                ConsoleEx.WriteLineGreen("Textbox change with null node");
            }
        }

        private void textBoxVec0_TextChanged(object sender, EventArgs e)
        {
            ChangeVecDataTextBox(sender, e);
        }

        private void textBoxVec1_TextChanged(object sender, EventArgs e)
        {
            ChangeVecDataTextBox(sender, e);
        }

        private void textBoxVec2_TextChanged(object sender, EventArgs e)
        {
            ChangeVecDataTextBox(sender, e);
        }


        private void textBoxVec3_TextChanged(object sender, EventArgs e)
        {
            ChangeVecDataTextBox(sender, e);
        }



        private void textBoxVec0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Utils.IsNumberInput(e.KeyChar, true, true))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void buttonResetBbox_Click(object sender, EventArgs e)
        {
            if (isItemSelected)
            {
                return;
            }

            tabControlProps.SelectTab(0);
            DisableTabBBox();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Utils.IsNumberInput(e.KeyChar, true, true))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


      


        private void button2_Click(object sender, EventArgs e)
        {

            EnableTab(tabControlProps.TabPages[1], true);

            tabControlProps.SelectTab(1);

            textBoxBbox0.Text = Imports.Extern_GetBBox(0).ToString().Replace(',', '.');
            textBoxBbox1.Text = Imports.Extern_GetBBox(1).ToString().Replace(',', '.');
            textBoxBbox2.Text = Imports.Extern_GetBBox(2).ToString().Replace(',', '.');


            //(Control)(tabControl1.TabPages[1]).Enable = true;
        }


        public static void EnableTab(TabPage page, bool enable)
        {
            EnableControls(page.Controls, enable);
        }
        private static void EnableControls(Control.ControlCollection ctls, bool enable)
        {
            foreach (Control ctl in ctls)
            {
                ctl.Enabled = enable;
                EnableControls(ctl.Controls, enable);
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (SpacerNET.propWin.treeViewProp.SelectedNode != null)
            {

                if (Imports.Extern_CanEditBboxCurrentVob() == 1)
                {
                    EnableTab(tabControlProps.TabPages[1], true);

                    textBoxBbox0.Text = Imports.Extern_GetBBox(0).ToString().Replace(',', '.');
                    textBoxBbox1.Text = Imports.Extern_GetBBox(1).ToString().Replace(',', '.');
                    textBoxBbox2.Text = Imports.Extern_GetBBox(2).ToString().Replace(',', '.');
                }
                
               
            }
           
        }



        private void button3_Click(object sender, EventArgs e)
        {
            buttonApplyOnVob.Enabled = true;
            tabControlProps.SelectTab(0);
            DisableTabBBox();
        }

        private void buttonContainerApply_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();

            int index = 1;

            foreach (DataGridViewRow row in dataGridViewItems.Rows)
            {
                if (row.Cells[0].Value == null && row.Cells[1].Value == null)
                {
                    continue;
                }

                if (row.Cells[0].Value == null || row.Cells[0].Value.ToString().Trim().Length == 0)
                {
                    MessageBox.Show(Localizator.Get("NO_ITEM_NAME") + index);
                    return;
                }

                if (row.Cells[1].Value == null || row.Cells[1].Value.ToString().Trim().Length == 0)
                {
                    MessageBox.Show(Localizator.Get("NO_ITEM_COUNT") + index);
                    return;
                }

                if (!Regex.IsMatch(row.Cells[1].Value.ToString().Trim(), @"^\d+$"))
                {
                    MessageBox.Show(Localizator.Get("ITEM_BAD_COUNT") + index);
                    return;
                }

                str.Append(row.Cells[0].Value.ToString().Trim() + ":" + row.Cells[1].Value.ToString().Trim() + ",");
                index++;
            }



            string final = str.ToString().Trim();

            if (final.Length != 0)
            {
                final = final.Substring(0, final.Length - 1);
            }
            

            props[containsIndex].value = final;
            textBoxString.Text = final;
            props[containsIndex].ownNode.Text = props[containsIndex].Name + ": " + props[containsIndex].ShowValue();


            buttonApplyOnVob.Enabled = true;

            buttonApply_Click(textBoxString, null);
            //DisableTabBBox();
            /*
            tabControlProps.SelectTab(0);
            DisableTabBBox();
            */
        }

        private void buttonClearItems_Click(object sender, EventArgs e)
        {
            dataGridViewItems.Rows.Clear();
        }

        private void удалитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

       


        private void buttonRowDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.CurrentCell != null && dataGridViewItems.CurrentCell.RowIndex != dataGridViewItems.Rows.Count-1)
            {
                dataGridViewItems.Rows.RemoveAt(dataGridViewItems.CurrentCell.RowIndex);
            }
            
        }

        private void buttonOpenContainer_Click(object sender, EventArgs e)
        {
            if (vobHasContainer)
            {
                OpenVobContainer();
            }
        }

        private void buttonFileOpen_Click(object sender, EventArgs e)
        {
            openFileDialogFileName.Filter = Constants.FILE_FILTER_ALL;


            Imports.Stack_PushString("vobResPath");
            Imports.Extern_GetSettingStr();
            string path = Utils.FixPath(Imports.Stack_PeekString());

            //MessageBox.Show(path);

            try
            {
                openFileDialogFileName.InitialDirectory = Utils.GetInitialDirectory(path);
            }
            catch
            {
                MessageBox.Show("Wrong path! " + path);
                return;
            }

            openFileDialogFileName.RestoreDirectory = true;

            if (openFileDialogFileName.ShowDialog() == DialogResult.OK)
            {
                Imports.Stack_PushString(Utils.FixPath(Path.GetDirectoryName(openFileDialogFileName.FileName)));
                Imports.Stack_PushString("vobResPath");
                Imports.Extern_SetSettingStr();

                string fileName = openFileDialogFileName.SafeFileName;
                TreeNode node = SpacerNET.propWin.treeViewProp.SelectedNode;

                if (node != null)
                {
                    int index = 0;

                    if (node.Tag != null && node.Tag.ToString() != Constants.TAG_FOLDER)
                    {
                        int.TryParse(node.Tag.ToString(), out index);

                        if (index >= 0)
                        {

                            CProperty prop = props[index];

                            if (prop.type == TPropEditType.PETstring)
                            {
                                prop.value = fileName.ToUpper();
                                prop.ownNode.Text = prop.Name + ": " + prop.ShowValue();
                                textBoxString.Text = prop.value;

                                buttonApplyOnVob.Enabled = true;
                                buttonRestoreVobProp.Enabled = true;
                            }
                        }

                    }
                }
            }

            

        }

        private void buttonResetBbox_Click_1(object sender, EventArgs e)
        {
            dataGridViewItems.Visible = false;
            tabControlProps.SelectTab(0);
            DisableTabBBox();
        }

        private void buttonApplyBbox_Click_1(object sender, EventArgs e)
        {
            int x, y, z;

            int.TryParse(textBoxBbox0.Text.Trim(), out x);
            int.TryParse(textBoxBbox1.Text.Trim(), out y);
            int.TryParse(textBoxBbox2.Text.Trim(), out z);

            Imports.Extern_SetBBox(x, y, z);

            tabControlProps.SelectTab(0);
            DisableTabBBox();
        }

        private void comboBoxPropsEnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            TreeNode node = SpacerNET.propWin.treeViewProp.SelectedNode;

            if (node != null)
            {
                int index = 0;

                if (node.Tag != null && node.Tag.ToString() != Constants.TAG_FOLDER)
                {
                    int.TryParse(node.Tag.ToString(), out index);

                    if (index >= 0)
                    {

                        CProperty prop = props[index];

                        if (prop.type == TPropEditType.PETenum)
                        {
                            prop.value = comboBoxPropsEnum.SelectedIndex.ToString();
                            prop.ownNode.Text = prop.Name + ": " + prop.ShowValue();
                            buttonApplyOnVob.Enabled = true;
                            buttonRestoreVobProp.Enabled = true;
                        }
                        else if (prop.type == TPropEditType.PETbool)
                        {
                            prop.value = comboBoxPropsEnum.SelectedIndex.ToString();
                            prop.ownNode.Text = prop.Name + ": " + prop.ShowValue();
                            buttonApplyOnVob.Enabled = true;
                            buttonRestoreVobProp.Enabled = true;
                        }
                    }

                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
     
        }

        private void tabControlProps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlProps.SelectedIndex == 2)
            {
                if (vobHasContainer)
                {
                    OpenVobContainer();
                }
            }

            if (updateRenderWindow)
            {
                updateRenderWindow = false;
            }
        }

        private void buttonSelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();

            var split = textBoxString.Text.Split(' ');

            if (split.Count() < 4)
            {
                return;
            }

            int r = Convert.ToInt32(split[0]);
            int g = Convert.ToInt32(split[1]);
            int b = Convert.ToInt32(split[2]);
            int a = Convert.ToInt32(split[3]);

            MyDialog.Color = Color.FromArgb(a, r, g, b);

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxString.Text =
                    MyDialog.Color.R.ToString()
                    + " " + MyDialog.Color.G.ToString()
                    + " " + MyDialog.Color.B.ToString()
                    + " " + MyDialog.Color.A.ToString()
                    ;
            }
               
        }

        private void buttonSelectFontProps_Click(object sender, EventArgs e)
        {
            if (fontDialogSelect.ShowDialog() == DialogResult.OK)
            {

                treeViewProp.Font = fontDialogSelect.Font;
                updateRenderWindow = true;
                SaveFontToSettings();
            }
        }

        private void buttonResetFontDefault_Click(object sender, EventArgs e)
        {
            treeViewProp.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            updateRenderWindow = true;
            SaveFontToSettings();
        }

        private void checkBoxBoldFontProps_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;

            if (checkBox.Checked) checkBoxFontUnderstroke.Checked = false;



            Imports.Stack_PushString("checkBoxBoldFontProps");
            Imports.Extern_SetSetting(Convert.ToInt32(checkBoxBoldFontProps.Checked));


            updateRenderWindow = true;
        }

        private void checkBoxFontUnderstroke_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;

            if (checkBox.Checked) checkBoxBoldFontProps.Checked = false;


            Imports.Stack_PushString("checkBoxFontUnderstroke");
            Imports.Extern_SetSetting(Convert.ToInt32(checkBoxFontUnderstroke.Checked));

            updateRenderWindow = true;
        }

        public void SaveFontToSettings()
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));

            string fontString = converter.ConvertToString(treeViewProp.Font);

            //ConsoleEx.WriteLineRed(fontString);

            Properties.Settings.Default.PropWindowFont = fontString;
        }

        public static void SetFieldBold(string fieldName, TreeNode node, string className)
        {
            TreeView tree = SpacerNET.propWin.treeViewProp;

            FontStyle style = FontStyle.Regular;

            if (SpacerNET.propWin.checkBoxFontUnderstroke.Checked)
            {
                style = FontStyle.Underline;
            }
            else if (SpacerNET.propWin.checkBoxBoldFontProps.Checked)
            {
                style = FontStyle.Bold;
            }


            if (className == "zCMaterial")
            {
                if (fieldName == "name" || fieldName == "texture" || fieldName == "matGroup" || fieldName == "noCollDet")
                {
                    node.NodeFont = new Font(tree.Font, style);
                }
            }
            else
            {
                if (fieldName == "vobName" || fieldName == "visual" || fieldName == "cdDyn" || fieldName == "cdStattic"
                    || fieldName == "focusName" || fieldName == "triggerTarget" || fieldName == "conditionFunc"
                    || fieldName == "onStateFunc" || fieldName == "useWithItem" || fieldName == "contains"
                    )
                {
                    node.NodeFont = new Font(tree.Font, style);
                }
            }
        }

        private void groupBoxEditBbox_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxBbox0_KeyDown(object sender, KeyEventArgs e)
        {
            var box = sender as TextBox;

            if (e.KeyCode == Keys.Tab)
            {
                if (textBoxBbox0.Focused)
                {
                    textBoxBbox1.Focus();
                }
                else if (textBoxBbox1.Focused)
                {
                    textBoxBbox2.Focus();
                }
                else if (textBoxBbox2.Focused)
                {
                    textBoxBbox0.Focus();
                }
                e.SuppressKeyPress = true;
            }
        }

        private void ObjectsWindow_Resize(object sender, EventArgs e)
        {
            
        }

        private void ObjectsWindow_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
               // this.Refresh();
               // this.Update();
            }
           // MessageBox.Show("re2");
        }

        private void ObjectsWindow_Activated(object sender, EventArgs e)
        {
           // MessageBox.Show("re3");
        }


        public bool SetColorPanelColor(string input)
        {
            string[] colorValues = input.Split(' ');

            if (colorValues.Length != 4)
            {
                MessageBox.Show(Localizator.Get("MSG_WRONG_COLOR_FORMAT"));
                return false;
            }

            int r = int.Parse(colorValues[0]);
            int g = int.Parse(colorValues[1]);
            int b = int.Parse(colorValues[2]);
            int a = int.Parse(colorValues[3]);

            if (r < 0 || r > 255 || g < 0 || g > 255 || b < 0 || b > 255 || a < 0 || a > 255)
            {
                MessageBox.Show(Localizator.Get("MSG_WRONG_COLOR_FORMAT_RANGE"));
                return false;
            }

            Color color = Color.FromArgb(a, r, g, b);

            colorPanel.BackColor = color;

            return true;
        }

        private void colorPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (classNameGlobal == "zCVobLight")
            {

                for (int i = 0; i < props.Count; i++)
                {
                    if (props[i].Name == "color")
                    {

                        treeViewProp.SelectedNode = props[i].ownNode;

                        treeViewProp.SelectedNode.EnsureVisible();
                        return;
                    }
                }
            }
        }

        private void tabControlProps_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void treeViewProp_MouseDown(object sender, MouseEventArgs e)
        {
            TreeNode node = treeViewProp.GetNodeAt(e.Location);
            int index = 0;

            if (node != null && node.Tag.ToString() != Constants.TAG_FOLDER)
            {

                int.TryParse(node.Tag.ToString(), out index);

                if (index >= 0)
                {

                    CProperty prop = props[index];

                    if (prop.value == String.Empty)
                    {
                        return;
                    }

                    if (prop.Name == "visual" || prop.Name == "vobName" || prop.Name == "texture" || prop.Name == "name")
                    {
                        if (e.Button == MouseButtons.Middle)
                        {
                            Utils.SetCopyText(prop.ShowValue());
                        }
                    }

                }
            }
        }
    }
}
