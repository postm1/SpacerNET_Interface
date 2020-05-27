
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

        static string currentContents;
        static int containsIndex;
        static TreeNode containsNode;
        static bool vobHasContainer = false;
        

        class FolderEntry
        {
            public string parent;
            public TreeNode node;
        }


        public ObjectsWindow()
        {
            InitializeComponent();

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

            props.Clear();
            folders.Clear();
            currentFolderName = "";
            TreeView tree = UnionNET.propWin.treeViewProp;

            tree.Nodes.Clear();
            EnableTab(UnionNET.propWin.tabControl1.TabPages[2], false);
            UnionNET.propWin.tabControl1.SelectedIndex = 0;

            UnionNET.propWin.HideAllInput();
            UnionNET.propWin.buttonApply.Enabled = false;
            UnionNET.propWin.buttonRestore.Enabled = false;
            UnionNET.propWin.buttonBbox.Enabled = false;
            UnionNET.propWin.buttonFileOpen.Enabled = false;
        }

        [DllExport]

        public static void CleanPropWindow()
        {
            CleanProps();

        }
        [DllExport]
        public static void AddProps(IntPtr ptr, IntPtr ptrType)
        {
            string inputStr = Marshal.PtrToStringAnsi(ptr);
            string className = Marshal.PtrToStringAnsi(ptrType);
            TreeView tree = UnionNET.propWin.treeViewProp;


            CleanProps();

            if (inputStr.Length == 0)
            {
                return;
            }

            UnionNET.propWin.panelButtons.Enabled = false;

            TreeNode firstNode = tree.Nodes.Add(className + ": zCVob");
            firstNode.Tag = "folder";



            if (className == "oCItem")
            {
                isItemSelected = true;
            }
            else
            {
                isItemSelected = false;
            }

            CProperty.originalStr = inputStr;

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
                        node.Tag = "folder";
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
                                node.Tag = "folder";
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

                    ConsoleEx.WriteLineRed("Looking for the sound...");

                    ListBox listBox = UnionNET.soundWin.listBoxSound;

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
                    node.Tag = "folder";
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
                            node.Tag = "folder";
                            break;
                        }
                    }
                }
                */

            //Console.WriteLine(folders.ElementAt(i).Key + ": " + folders.ElementAt(i).Value);

            showFirst = null;
            vobHasContainer = false;
            UnionNET.propWin.buttonOpenContainer.Enabled = false;

            for (int i = 0; i < props.Count; i++)
            {
                TreeNode baseNode = props[i].node;


                if (props[i].Name == "contains")
                {
                    vobHasContainer = true;
                    UnionNET.propWin.buttonOpenContainer.Enabled = true;
                }


                if (baseNode != null)
                {
                    TreeNode node = baseNode.Nodes.Add(props[i].Name + ": " + props[i].ShowValue());
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
                    node.SelectedImageIndex = 5;
                    node.ImageIndex = 5;
                    node.Tag = i;
                    props[i].ownNode = node;

                    if (props[i].Name == "vobName")
                    {
                        showFirst = node;
                    }
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
            

            //UnionNET.objWin.panelButtons.Visible = true;

            // tree.Nodes["Internals"].Collapse();


            /*
            string w = string.PickWord(z, "\n\t", "\n\t");

            while (!w.Contains("["))
            {
                CProperty ele = new CProperty();
                ele.Name = w;

                props.Add(ele);
                //spcCObjPropertyElement* ele = new spcCObjPropertyElement(w.ToChar());
                //propList.Insert(ele);
                z++;
                //w = propString.PickWord(z, "\n\t", "\n\t");
            }

            */

        }

        private void ObjectsWindow_Shown(object sender, EventArgs e)
        {
            this.treeViewProp.ImageList = UnionNET.objTreeWin.imageList1;
        }

        private void treeViewProp_DrawNode(object sender, DrawTreeNodeEventArgs e)
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

        private void ObjectsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
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

                    changed = true;
                    buttonApply.Enabled = true;
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
                    changed = true;
                    buttonApply.Enabled = true;
                    buttonRestore.Enabled = true;
                }

                if (prop.Name == "contains")
                {
                    OpenVobContainer(prop, index);
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
                        UnionNET.propWin.treeViewProp.SelectedNode = prop.ownNode;
                        break;
                    }
                }
            }

            EnableTab(tabControl1.TabPages[2], true);
            tabControl1.SelectedIndex = 2;

            dataGridView1.Visible = true;
            dataGridView1.Rows.Clear();

            UnionNET.partWin.tabControlObjects.SelectedIndex = 1;

            currentContents = prop.value;
            containsIndex = index;
            containsNode = props[index].node;

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
                    dataGridView1.Rows.Add(arr[0].Trim(), "1");
                }
                else
                {
                    dataGridView1.Rows.Add(arr[0].Trim(), arr[1].Trim());
                }

            }
        }
        private void buttonApply_Click(object sender, EventArgs e)
        {

            if (isItemSelected)
            {
                return;
            }


            TreeNode node = treeViewProp.SelectedNode;
            TextBox textBox = sender as TextBox;
            int index = 0;

            if (node != null && node.Tag.ToString() != "folder")
            {
                int.TryParse(node.Tag.ToString(), out index);

                if (index >= 0)
                {

                    //Console.WriteLine("Change entry with index: " + index);
                    CProperty prop = props[index];

                    if (prop.Name == "vobName")
                    {
                        string newName = prop.value;
                        IntPtr newNamePtr = UnionNET.AddString(newName);

                        if (Imports.Extern_CheckUniqueNameExist(newNamePtr))
                        {
                            MessageBox.Show("Такое имя уже существует!");
                            UnionNET.FreeStrings();
                            return;
                        }
                    }

                }
            }




            // блокируем кнопку Применить
            changed = false;
            buttonApply.Enabled = false;


            StringBuilder str = new StringBuilder();

           

            string[] words = CProperty.originalStr.Replace("\t", "").Split('\n');

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
            }

            for (int j = 0; j < words.Length; j++)
            {
                str.Append(words[j] + "\n");
            }

            IntPtr ptr = UnionNET.AddString(str.ToString());
            IntPtr ptrName = UnionNET.AddString(nameValue);
            IntPtr ptrVisual = UnionNET.AddString(visual);

            Imports.Extern_ApplyProps(ptr, ptrName, ptrVisual);
            UnionNET.FreeStrings();

        }

        public void DisableTabBBox()
        {
            textBoxBbox0.Text = "";
            textBoxBbox1.Text = "";
            textBoxBbox2.Text = "";
            EnableTab(tabControl1.TabPages[1], false);
            EnableTab(tabControl1.TabPages[2], false);
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
            DisableTabBBox();

        }
        private void treeViewProp_AfterSelect(object sender, TreeViewEventArgs e)
        {

            TreeNode node = e.Node;
            int index = 0;

            if (node.Tag != null && node.Tag.ToString() != "folder")
            {
                int.TryParse(node.Tag.ToString(), out index);

                if (index >= 0)
                {

                    HideAllInput();

                    CProperty prop = props[index];

                    if (prop.Name == "itemInstance")
                    {
                        return;
                    }

                    if (prop.type == TPropEditType.PETstring || prop.type == TPropEditType.PETraw || prop.type == TPropEditType.PETint || prop.type == TPropEditType.PETfloat)
                    {
                        textBoxString.Visible = true;
                        textBoxString.Text = prop.value;

                        if (prop.type == TPropEditType.PETstring || prop.type == TPropEditType.PETraw)
                        {
                            textBoxString.Width = 298;
                            buttonFileOpen.Enabled = true;
                        }
                        else if (prop.type == TPropEditType.PETint || prop.type == TPropEditType.PETfloat)
                        {
                            textBoxString.Width = 75;
                        }
                    }

                    if (prop.type == TPropEditType.PETvec3 || prop.type == TPropEditType.PETcolor)
                    {
                        textBoxVec0.Visible = true;
                        textBoxVec1.Visible = true;
                        textBoxVec2.Visible = true;

                       
                        

                        string[] arr = prop.value.Split(' ');

                        textBoxVec0.Text = arr[0];
                        textBoxVec1.Text = arr[1];
                        textBoxVec2.Text = arr[2];


                        if (prop.type == TPropEditType.PETcolor)
                        {
                            textBoxVec3.Visible = true;
                            textBoxVec3.Text = arr[3];
                        }
                    }

                    if (prop.type == TPropEditType.PETenum)
                    {
                        comboBoxPropsEnum.Visible = true;
                        comboBoxPropsEnum.Items.Clear();
                        comboBoxPropsEnum.Items.AddRange(prop.enumArray.ToArray());
                        comboBoxPropsEnum.SelectedIndex = prop.GetCurrentEnumIndex();
                    }

                    currentFieldtype = prop.type;

                    Label_Backup.Text = "Старое значение: " + prop.ShowBackupValue();

                    if (isItemSelected)
                    {
                        return;
                    }

                    Label_Backup.Visible = true;
                    buttonRestore.Enabled = true;
                    buttonBbox.Enabled = true;
                    
                }
            }

            UnionNET.propWin.panelButtons.Enabled = true;
        }

        private void textBoxString_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBoxString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (currentFieldtype == TPropEditType.PETint || currentFieldtype == TPropEditType.PETfloat)
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

        private void textBoxString_TextChanged(object sender, EventArgs e)
        {

            if (isItemSelected)
            {
                return;
            }



            TreeNode node = treeViewProp.SelectedNode;
            TextBox textBox = sender as TextBox;
            int index = 0;

            if (node != null && node.Tag.ToString() != "folder")
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

                    prop.value = textBox.Text.Trim();
                    node.Text = prop.Name + ": " + prop.ShowValue();
                    buttonApply.Enabled = true;
                    buttonRestore.Enabled = true;
                }
            }
            else
            {
                Console.WriteLine("C#: Textbox change with null node");
            }
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            if (isItemSelected)
            {
                return;
            }

            TreeNode node = treeViewProp.SelectedNode;
            TextBox textBox = sender as TextBox;
            int index = 0;

            if (node != null && node.Tag.ToString() != "folder")
            {
                int.TryParse(node.Tag.ToString(), out index);

                if (index >= 0)
                {

                    CProperty prop = props[index];

                    prop.value = prop.backup_value;
                    node.Text = prop.Name + ": " + prop.ShowValue();

                    if (currentFieldtype == TPropEditType.PETvec3 || prop.type == TPropEditType.PETcolor)
                    {
                        string[] arr = prop.value.Split(' ');

                        textBoxVec0.Text = arr[0];
                        textBoxVec1.Text = arr[1];
                        textBoxVec2.Text = arr[2];

                        if (prop.type == TPropEditType.PETcolor)
                        {
                            textBoxVec3.Text = arr[3];
                        }
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
                    buttonApply.Enabled = true;
                    buttonRestore.Enabled = true;
                }
            }
            else
            {
                Console.WriteLine("C#: Restore with null node");
            }
        }

        private void ChangeVecDataTextBox(object sender, EventArgs e)
        {
            TreeNode node = treeViewProp.SelectedNode;
            TextBox textBox = sender as TextBox;
            int index = 0;

            if (isItemSelected)
            {
                return;
            }

            if (node != null && node.Tag.ToString() != "folder")
            {
                int.TryParse(node.Tag.ToString(), out index);

                if (index >= 0)
                {

                    //Console.WriteLine("Change entry with index: " + index);
                    CProperty prop = props[index];

                    prop.value = textBoxVec0.Text.Trim() + " " + textBoxVec1.Text.Trim() + " " + textBoxVec2.Text.Trim();

                    if (prop.type == TPropEditType.PETcolor)
                    {
                        prop.value += " " + textBoxVec3.Text.Trim();
                    }

                    node.Text = prop.Name + ": " + prop.ShowValue();

                    changed = true;
                    buttonApply.Enabled = true;
                    buttonRestore.Enabled = true;


                }
            }
            else
            {
                Console.WriteLine("C#: Textbox change with null node");
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.') && (e.KeyChar != '-'))
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

            tabControl1.SelectTab(0);
            DisableTabBBox();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.') && (e.KeyChar != '-'))
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

            EnableTab(tabControl1.TabPages[1], true);

            tabControl1.SelectTab(1);

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
            if (UnionNET.propWin.treeViewProp.SelectedNode != null)
            {
                EnableTab(tabControl1.TabPages[1], true);

                textBoxBbox0.Text = Imports.Extern_GetBBox(0).ToString().Replace(',', '.');
                textBoxBbox1.Text = Imports.Extern_GetBBox(1).ToString().Replace(',', '.');
                textBoxBbox2.Text = Imports.Extern_GetBBox(2).ToString().Replace(',', '.');
            }
           
        }



        private void button3_Click(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
            tabControl1.SelectTab(0);
            DisableTabBBox();
        }

        private void buttonContainerApply_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();

            int index = 1;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null && row.Cells[1].Value == null)
                {
                    continue;
                }

                if (row.Cells[0].Value == null || row.Cells[0].Value.ToString().Trim().Length == 0)
                {
                    MessageBox.Show("Имя вещи не может быть пустым! Строка: " + index);
                    return;
                }

                if (row.Cells[1].Value == null || row.Cells[1].Value.ToString().Trim().Length == 0)
                {
                    MessageBox.Show("Кол-во итемов не может быть пустым! Строка: " + index);
                    return;
                }

                if (!Regex.IsMatch(row.Cells[1].Value.ToString().Trim(), @"^\d+$"))
                {
                    MessageBox.Show("Некорректное число итемов. Строка: " + index);
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


            buttonApply.Enabled = true;
            tabControl1.SelectTab(0);
            DisableTabBBox();
        }

        private void buttonClearItems_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void удалитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

       


        private void buttonRowDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.RowIndex != dataGridView1.Rows.Count-1)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
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
            openFileDialogFileName.Filter = "All files (*.)|";

            IntPtr ptrPath = Imports.Extern_GetSettingStr(UnionNET.AddString("vobResPath"));

            string path = Marshal.PtrToStringAnsi(ptrPath);

            //MessageBox.Show(path);

            if (path != "")
            {
                //MessageBox.Show(path);
                openFileDialogFileName.InitialDirectory = System.IO.Path.GetDirectoryName(@path + @"/");
            }
            else
            {
                openFileDialogFileName.InitialDirectory = @Directory.GetCurrentDirectory() + @"../_WORK/DATA/";
            }

            openFileDialogFileName.RestoreDirectory = true;

            if (openFileDialogFileName.ShowDialog() == DialogResult.OK)
            {

                IntPtr ptrPathSave = UnionNET.AddString(Path.GetDirectoryName(openFileDialogFileName.FileName));

                Imports.Extern_SetSettingStr(ptrPathSave, UnionNET.AddString("vobResPath"));

                string fileName = openFileDialogFileName.SafeFileName;


                TreeNode node = UnionNET.propWin.treeViewProp.SelectedNode;

                if (node != null)
                {
                    int index = 0;

                    if (node.Tag != null && node.Tag.ToString() != "folder")
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

                                buttonApply.Enabled = true;
                                buttonRestore.Enabled = true;
                            }
                        }

                    }
                }
            }

            UnionNET.FreeStrings();

        }

        private void buttonResetBbox_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            tabControl1.SelectTab(0);
            DisableTabBBox();
        }

        private void buttonApplyBbox_Click_1(object sender, EventArgs e)
        {
            int x, y, z;

            int.TryParse(textBoxBbox0.Text.Trim(), out x);
            int.TryParse(textBoxBbox1.Text.Trim(), out y);
            int.TryParse(textBoxBbox2.Text.Trim(), out z);

            Imports.Extern_SetBBox(x, y, z);

            tabControl1.SelectTab(0);
            DisableTabBBox();
        }

        private void comboBoxPropsEnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            TreeNode node = UnionNET.propWin.treeViewProp.SelectedNode;

            if (node != null)
            {
                int index = 0;

                if (node.Tag != null && node.Tag.ToString() != "folder")
                {
                    int.TryParse(node.Tag.ToString(), out index);

                    if (index >= 0)
                    {

                        CProperty prop = props[index];

                        if (prop.type == TPropEditType.PETenum)
                        {
                            prop.value = comboBoxPropsEnum.SelectedIndex.ToString();
                            prop.ownNode.Text = prop.Name + ": " + prop.ShowValue();
                            buttonApply.Enabled = true;
                            buttonRestore.Enabled = true;
                        }
                    }

                }
            }
        }
    }
}
