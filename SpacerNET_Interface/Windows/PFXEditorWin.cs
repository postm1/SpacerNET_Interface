using SpacerUnion.Common;
using SpacerUnion.Common.PFX_Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SpacerUnion.Windows
{ 
    

    public partial class PFXEditorWin : Form
    {
        PFX_Stat stat;
        bool firstTimeInit = false;
        static List<CProperty> props = new List<CProperty>();

        public PFXEditorWin()
        {
            stat = new PFX_Stat();
            InitializeComponent();

            stat.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(stat_PropertyChanged);

            this.DoubleBuffered = true;

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            Helper.EnableDoubleBuffering(this.treeViewPFX);
        }

        

        public void AddNewProp(string name, string folder, string type, string val)
        {
            CProperty prop = new CProperty();

            prop.Name = name;
            prop.GroupName = folder;
            prop.SetTypePFXEditor(type);
            prop.SetValue(val);


            var baseNode = treeViewPFX.Nodes.OfType<TreeNode>()
                            .FirstOrDefault(node => node.Text.Equals(folder));

            if (baseNode != null)
            {


                if (type == "enum")
                {
                    FillEnumProp(prop);
                }

                TreeNode node = baseNode.Nodes.Add(name + ": " + prop.ShowValue());
                prop.ownNode = node;
               
                props.Add(prop);


                SetPFXIcon(prop);
                SetNodeStyle(prop);
            }
            else
            {
                ConsoleEx.WriteLineRed("NO NODE!");
            }
           
        }

        public void SetProp(string name, string val)
        {
            var prop = props.FirstOrDefault(curProp => curProp.Name.Equals(name));

            if (prop != null)
            {
                
                if (prop.type == TPropEditType.PETfloat)
                {
                    val = val.Replace(",", ".");
                }

                // forcely set backup value with new pfx selected
                prop.oldValueInit = false;

                val = val.ToUpper().Trim();

                if (prop.enumArray.Count > 0)
                {
                    bool foundFlag = false;

                    for (int i = 0; i < prop.enumArray.Count; i++)
                    {
                        if (prop.enumArray[i].ToUpper() == val.ToUpper())
                        {
                            prop.SetValue(i.ToString());
                            foundFlag = true;
                            break;
                        }
                    }

                    // if we don't find proper enum value
                    if (!foundFlag)
                    {
                        prop.SetValue("0");
                    }
                }
                else
                {
                   
                    prop.SetValue(val);
                }


                

                prop.ownNode.Text = prop.Name + ": " + prop.ShowValue();
            }
        }
        

        

        static void stat_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (!SpacerNET.pfxWin.firstTimeInit)
            {
                return;
            }

            //Console.WriteLine(e.PropertyName + " has been changed.");
            var propInfo = SpacerNET.pfxWin.stat.GetType().GetProperty(e.PropertyName);

            //ConsoleEx.WriteLineRed("stat_PropertyChanged: " + e.PropertyName);

            if (propInfo != null)
            {
                object val = propInfo.GetValue(SpacerNET.pfxWin.stat, null);

                Console.WriteLine(e.PropertyName + " has been changed: " + val.ToString() + " : " + propInfo.PropertyType.ToString());

                if (propInfo.PropertyType == Type.GetType("System.Int32"))
                {
                    Imports.Stack_PushInt(Convert.ToInt32(val));
                    Imports.Stack_PushString(e.PropertyName);
                    Imports.Extern_UpdatePFXField();
                }
                else if (propInfo.PropertyType == Type.GetType("System.Single"))
                {
                    Imports.Stack_PushFloat(Convert.ToSingle(val));
                    Imports.Stack_PushString(e.PropertyName);
                    Imports.Extern_UpdatePFXField();
                }
                else if (propInfo.PropertyType == Type.GetType("System.String"))
                {
                    Imports.Stack_PushString(Convert.ToString(val));
                    Imports.Stack_PushString(e.PropertyName);
                    Imports.Extern_UpdatePFXField();
                }
                else if (propInfo.PropertyType == Type.GetType("System.Boolean"))
                {
                    Imports.Stack_PushInt(Convert.ToInt32(val));
                    Imports.Stack_PushString(e.PropertyName);
                    Imports.Extern_UpdatePFXField();
                }
            }

        }



        [DllExport]
        public static void AddPfxInstancemName()
        {
            string name = Imports.Stack_PeekString();

            SpacerNET.pfxWin.comboBoxPfxInst.Items.Add(name);
        }

        public void LoadAllPfx()
        {
            comboBoxPfxInst.Items.Clear();
            Imports.Extern_GetAllPfx();
        }

        
        private void savePFXButton_Click(object sender, EventArgs e)
        {
           
            /*
            int type = Imports.Stack_PeekInt();
            
            if (type == 1)
            {
                MessageBox.Show(Imports.Stack_PeekFloat().ToString());
            }
            if (type == 2)
            {
                MessageBox.Show(Imports.Stack_PeekInt().ToString());
            }

            if (type == 3)
            {
              
            }
            */


            //stat.PpsFPS = Imports.Stack_PeekFloat();
            // stat.PpsScaleKeys_s = Imports.Stack_PeekString();
        }

        private void comboBoxPfxInst_SelectedIndexChanged(object sender, EventArgs e)
        {

            string value = comboBoxPfxInst.Text;

            firstTimeInit = false;

            if (value != String.Empty)
            {
                LoadPfx(value);
                firstTimeInit = true;
            }
        }

        private void propertyGridPfx_SelectedGridItemChanged(object sender, SelectedGridItemChangedEventArgs e)
        {
            //MessageBox.Show(e.NewSelection.Label + "/" + e.NewSelection.Value);
        }

        private void PFXEditorWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void propertyGridPfx_Click(object sender, EventArgs e)
        {

        }

        private void PFXEditorWin_Shown(object sender, EventArgs e)
        {
             FillProps();
        }

        private void treeViewPFX_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void treeViewPFX_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            TreeNode node = e.Node;

            if (node == null)
            {
                return;
            }

            //ConsoleEx.WriteLineRed(node.Text);


            var prop = props.FirstOrDefault(curProp => curProp.ownNode == node);

            if (prop == null)
            {
                return;
            }

            if (prop.type == TPropEditType.PETbool)
            {
                prop.value = prop.value == "0" ? "1" : "0"; ;

                node.Text = prop.Name + ": " + prop.ShowValue();

                comboBoxPfxField.SelectedIndex = prop.value == "1" ? 1 : 0;
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
                comboBoxPfxField.SelectedIndex = prop.GetCurrentEnumIndex();
            }

            
        }

        private void treeViewPFX_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;

            comboBoxPfxField.Visible = false;
            textBoxPfxInput.Visible = false;


            if (node != null && node.Tag != null && node.Tag.ToString() == Constants.TAG_FOLDER)
            {
                return;
            }

            if (node != null)
            {


                var prop = props.FirstOrDefault(curProp => curProp.ownNode == node);

                if (prop == null)
                {
                    return;
                }

                

                if (prop.type == TPropEditType.PETenum)
                {
                    comboBoxPfxField.Items.Clear();

                    for (int i = 0; i < prop.enumArray.Count; i++)
                    {
                        comboBoxPfxField.Items.Add(prop.enumArray[i]);
                    }

                    comboBoxPfxField.SelectedIndex = prop.GetCurrentEnumIndex();
                    comboBoxPfxField.Visible = true;
                }
                else if (prop.type == TPropEditType.PETbool)
                {
                    comboBoxPfxField.Items.Clear();
                    comboBoxPfxField.Items.Add("FALSE");
                    comboBoxPfxField.Items.Add("TRUE");
                    comboBoxPfxField.SelectedIndex = prop.value == "1" ? 1 : 0;
                    comboBoxPfxField.Visible = true;
                }
                else
                {
                    textBoxPfxInput.Text = prop.ShowValue();
                    textBoxPfxInput.Visible = true;
                }
            }
        }

        

        private void buttonPfxEditorApply_Click(object sender, EventArgs e)
        {
            if (treeViewPFX.SelectedNode != null)
            {
                var prop = props.FirstOrDefault(curProp => curProp.ownNode == treeViewPFX.SelectedNode);

                if (prop == null)
                {
                    return;
                }

                if (prop.type == TPropEditType.PETenum)
                {
                    int selectedIndex = comboBoxPfxField.SelectedIndex;

                    prop.SetValue(selectedIndex.ToString());

                }
                else if (prop.type == TPropEditType.PETbool)
                {
                    int selectedIndex = comboBoxPfxField.SelectedIndex;

                    prop.SetValue(selectedIndex.ToString());
                }
                else
                {
                    string input = textBoxPfxInput.Text.Trim().ToUpper();

                    if (!PFX_CheckValidInput(input, prop))
                    {
                        return;
                    }

                    // Fixing float format
                    if (prop.type == TPropEditType.PETfloat)
                    {
                        input = input.Replace(",", ".");
                    }

                    prop.SetValue(input);


                }

                treeViewPFX.SelectedNode.Text = prop.Name + ": " + prop.ShowValue();
            }
        }

        private void buttonPfxRestore_Click(object sender, EventArgs e)
        {
            if (treeViewPFX.SelectedNode != null)
            {
                var prop = props.FirstOrDefault(curProp => curProp.ownNode == treeViewPFX.SelectedNode);

                if (prop == null)
                {
                   
                    return;
                }

                prop.SetValue(prop.backup_value);
                treeViewPFX.SelectedNode.Text = prop.Name + ": " + prop.ShowValue();

                var events = new TreeViewEventArgs(treeViewPFX.SelectedNode);

                treeViewPFX_AfterSelect(null, events);
            }
        }

        private void comboBoxPfxField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (treeViewPFX.SelectedNode != null)
            {
                var prop = props.FirstOrDefault(curProp => curProp.ownNode == treeViewPFX.SelectedNode);

                if (prop == null)
                {
                    return;
                }

                if (prop.type != TPropEditType.PETenum)
                {
                    return;
                }

                int selectedIndex = comboBoxPfxField.SelectedIndex;

                prop.SetValue(selectedIndex.ToString());
                treeViewPFX.SelectedNode.Text = prop.Name + ": " + prop.ShowValue();
            }
                
        }
    }
}
