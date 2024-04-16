using SpacerUnion.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SpacerUnion.Windows
{ 
    

    public partial class PFXEditorWin : Form
    {
        static List<CProperty> props = new List<CProperty>();
        bool dontUpdateFieldNow = false;
        string currentPfxName = String.Empty;
        Dictionary<string, string> backupFieldsValues = new Dictionary<string, string>();

        public PFXEditorWin()
        {

            InitializeComponent();

            this.DoubleBuffered = true;

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            Helper.EnableDoubleBuffering(this.treeViewPFX);

            ToggleInterface(false);

        }

        public void OnFontUpdate()
        {
            for (int i = 0; i < props.Count; i++)
            {
                var prop = props[i];

                SetNodeStyle(prop);
            }
        }

        public void ToggleInterface(bool toggle)
        {
            buttonPFXPlayAgain.Enabled = toggle;
            savePFXButton.Enabled = toggle;
            buttonPfxEditorApply.Enabled = toggle;
            buttonPfxRestore.Enabled = toggle;
            savePFXButton.Enabled = toggle;
            checkBoxPfxSaveAllFields.Enabled = toggle;
            comboBoxPfxInst.Enabled = toggle;

            treeViewPFX.Enabled = toggle;
            textBoxPfxInput.Enabled = toggle;

            if (!toggle)
            {
                comboBoxPfxInst.SelectedIndex = -1;
                buttonFile.Enabled = toggle;
                buttonColor.Enabled = toggle;
            }

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


                    if (IsFieldRealInt(prop.Name))
                    {
                        foundFlag = true;
                        prop.SetValue(val);
                    }
                    else
                    {
                        for (int i = 0; i < prop.enumArray.Count; i++)
                        {
                            if (prop.enumArray[i].ToUpper() == val.ToUpper())
                            {
                                prop.SetValue(i.ToString());
                                foundFlag = true;
                                break;
                            }
                        }
                    }
                    

                    // if we don't find proper enum value
                    if (!foundFlag)
                    {
                        ConsoleEx.WriteLineRed("ENUM VALUE NOT FOUND : " + prop.Name + " Val: " + val);
                        prop.SetValue("0");
                    }
                }
                else
                {
                   
                    prop.SetValue(val);
                }

                // save backup value for any pfx
                var key = currentPfxName + "_" + prop.Name;

                if (!backupFieldsValues.ContainsKey(key))
                {
                    backupFieldsValues[key] = prop.value;
                }

                prop.ownNode.Text = prop.Name + ": " + prop.ShowValue();

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

        
        

        private void comboBoxPfxInst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPfxInst.SelectedIndex < 0)
            {
                return;
            }

            string value = comboBoxPfxInst.Text;


            if (value != String.Empty)
            {
                currentPfxName = value;

                LoadPfx(value);

                if (comboBoxPfxInst.SelectedIndex >= 0)
                {
                    ToggleInterface(true);
                }
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

                OnFieldChanged(prop);
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

                OnFieldChanged(prop);
            }

            
        }

        private void treeViewPFX_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;

            comboBoxPfxField.Visible = false;
            textBoxPfxInput.Visible = false;
            buttonColor.Enabled = false;
            buttonFile.Enabled = false;

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
                    dontUpdateFieldNow = true;
                    comboBoxPfxField.SelectedIndex = prop.GetCurrentEnumIndex();
                    comboBoxPfxField.Visible = true;
                }
                else if (prop.type == TPropEditType.PETbool)
                {
                    dontUpdateFieldNow = true;

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

                    if (IsColorField(prop.Name))
                    {
                        buttonColor.Enabled = true;
                    }

                    if (IsTextureField(prop.Name))
                    {
                        buttonFile.Enabled = true;
                    }
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

                    bool isValidFastString = false;

                    ConsoleEx.WriteLineYellow("Input: " + input);

                    if (input.StartsWith("!") && (prop.Name == "ppsScaleKeys_s" || prop.Name == "shpScaleKeys_s"))
                    {

                        string fastString = input.Replace("!", "").Trim();
                        StringBuilder fastStringResult = new StringBuilder();

                        var split = fastString.Split(' ');

                        if (split.Length == 3)
                        {
                            var startNum = Convert.ToSingle(split[0],  CultureInfo.InvariantCulture);
                            var endNum = Convert.ToSingle(split[1], CultureInfo.InvariantCulture);
                            var step = Convert.ToSingle(split[2], CultureInfo.InvariantCulture);

                            int startIntNum = (int)(startNum * 10);
                            int endIntNum = (int)(endNum * 10);
                            int stepInt = (int)(step * 10);

                            //ConsoleEx.WriteLineYellow(startNum + " " + endNum + " " + step);
                            //ConsoleEx.WriteLineYellow(startIntNum + " " + endIntNum + " " + stepInt);

                            isValidFastString = true;

                            if (startIntNum < endIntNum)
                            {
                                while (startIntNum <= endIntNum)
                                {
                                    fastStringResult.Append((float)startIntNum / 10.0f + " ");
                                    startIntNum += stepInt;
                                }
                            }
                            else
                            {
                                // 10 5
                                while (startIntNum >= endIntNum)
                                {
                                    fastStringResult.Append((float)startIntNum / 10.0f + " ");
                                    startIntNum -= stepInt;
                                }
                            }
                            //C#: Input: ! 0,2 5,2 0,5
                            //C#: 20 520 50
                            //C#: GenString: 2 7 12 17 22 27 32 37 42 47 52

                           

                            

                            input = fastStringResult.ToString().Trim().Replace(",", ".");

                            //ConsoleEx.WriteLineYellow("GenString: " + input);
                        }
                    }

                    if (!isValidFastString && !PFX_CheckValidInput(input, prop))
                    {
                        return;
                    }

                    // Fixing float format
                    if (prop.type == TPropEditType.PETfloat)
                    {
                        input = input.Replace(",", ".");
                    }

                    // Fixing texture name if no .TGA
                    if (IsTextureField(prop.Name) && input.Length > 0 && !input.Contains(".TGA"))
                    {
                        input += ".TGA";
                    }

                    prop.SetValue(input);


                }

                treeViewPFX.SelectedNode.Text = prop.Name + ": " + prop.ShowValue();
                OnFieldChanged(prop);
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

                // save backup value for any pfx
                var key = currentPfxName + "_" + prop.Name;

                if (!backupFieldsValues.ContainsKey(key))
                {
                    return;
                }

                prop.SetValue(backupFieldsValues[key]);
                treeViewPFX.SelectedNode.Text = prop.Name + ": " + prop.ShowValue();

                var events = new TreeViewEventArgs(treeViewPFX.SelectedNode);

                treeViewPFX_AfterSelect(null, events);

                OnFieldChanged(prop);
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

                if (prop.type != TPropEditType.PETenum && prop.type != TPropEditType.PETbool)
                {
                    return;
                }

                int selectedIndex = comboBoxPfxField.SelectedIndex;

                prop.SetValue(selectedIndex.ToString());
                
                treeViewPFX.SelectedNode.Text = prop.Name + ": " + prop.ShowValue();

                //onchange if not block
                if (!dontUpdateFieldNow)
                {
                    OnFieldChanged(prop);
                }

                // turn off block any way
                dontUpdateFieldNow = false;
            }
                
        }

        private void buttonPFXPlayAgain_Click(object sender, EventArgs e)
        {
            string value = comboBoxPfxInst.Text;


            if (value != String.Empty)
            {
                LoadPfx(value);
            }
        }


        //update current PFX emitter
        public void OnFieldChanged(CProperty prop)
        {
            ConsoleEx.WriteLineYellow(prop.Name + " changed " + prop.type);

            if (prop.type == TPropEditType.PETbool || prop.type == TPropEditType.PETint)
            {
                Imports.Stack_PushInt(Convert.ToInt32(prop.value));
                Imports.Stack_PushString(prop.Name);
                Imports.Extern_UpdatePFXField();
            }
            else if (prop.type == TPropEditType.PETenum)
            {
                if (IsFieldRealInt(prop.Name))
                {
                    Imports.Stack_PushInt(Convert.ToInt32(prop.value));
                    Imports.Stack_PushString(prop.Name);
                    Imports.Extern_UpdatePFXField();
                }
                else if (IsFieldRealString(prop.Name))
                {
                    Imports.Stack_PushString(prop.ShowValue());
                    Imports.Stack_PushString(prop.Name);
                    Imports.Extern_UpdatePFXField();
                }
                else
                {
                    Imports.Stack_PushString(prop.value);
                    Imports.Stack_PushString(prop.Name);
                    Imports.Extern_UpdatePFXField();
                }
                
            }
            else if (prop.type == TPropEditType.PETfloat)
            {
                Imports.Stack_PushFloat(Convert.ToSingle(prop.value, CultureInfo.InvariantCulture));
                Imports.Stack_PushString(prop.Name);
                Imports.Extern_UpdatePFXField();
            }
            else if (prop.type == TPropEditType.PETstring)
            {
                Imports.Stack_PushString(prop.value);
                Imports.Stack_PushString(prop.Name);
                Imports.Extern_UpdatePFXField();
            }

            
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();

            var split = textBoxPfxInput.Text.Split(' ');

            if (split.Count() < 3)
            {
                return;
            }

            int r = Convert.ToInt32(split[0]);
            int g = Convert.ToInt32(split[1]);
            int b = Convert.ToInt32(split[2]);

            MyDialog.Color = Color.FromArgb(255, r, g, b);

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPfxInput.Text =
                    MyDialog.Color.R.ToString()
                    + " " + MyDialog.Color.G.ToString()
                    + " " + MyDialog.Color.B.ToString()
                    ;
            }
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogFileName = new OpenFileDialog();

            openFileDialogFileName.Filter = Constants.FILE_FILTER_ALL;


            Imports.Stack_PushString("pfxTexturesPath");
            Imports.Extern_GetSettingStr();
            string path = Utils.FixPath(Imports.Stack_PeekString());

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
                Imports.Stack_PushString("pfxTexturesPath");
                Imports.Extern_SetSettingStr();

                string fileName = openFileDialogFileName.SafeFileName;
                TreeNode node = treeViewPFX.SelectedNode;

                if (node != null)
                {

                    var prop = props.FirstOrDefault(curProp => curProp.ownNode == treeViewPFX.SelectedNode);

                    if (prop == null)
                    {
                        return;
                    }

                    prop.value = fileName.ToUpper();
                    prop.ownNode.Text = prop.Name + ": " + prop.ShowValue();
                    textBoxPfxInput.Text = prop.value;
                }
            }
        }

        private void textBoxPfxInput_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                buttonPfxEditorApply_Click(null, null);
                e.Handled = true;
            }
        }


        private void savePFXButton_Click(object sender, EventArgs e)
        {
            bool saveAllFields = checkBoxPfxSaveAllFields.Checked;

            SaveFileDialog safeFileDialogFileName = new SaveFileDialog();

            safeFileDialogFileName.Filter = Constants.FILE_FILTER_ALL;
            safeFileDialogFileName.FileName = currentPfxName + ".txt";

            Imports.Stack_PushString("pfxSavesPath");
            Imports.Extern_GetSettingStr();
            string path = Utils.FixPath(Imports.Stack_PeekString());

            try
            {
                safeFileDialogFileName.InitialDirectory = Utils.GetInitialDirectory(path);
            }
            catch
            {
                MessageBox.Show("Wrong path! " + path);
                return;
            }

            safeFileDialogFileName.RestoreDirectory = true;

            if (safeFileDialogFileName.ShowDialog() == DialogResult.OK)
            {
                Imports.Stack_PushString(Utils.FixPath(Path.GetDirectoryName(safeFileDialogFileName.FileName)));
                Imports.Stack_PushString("pfxSavesPath");
                Imports.Extern_SetSettingStr();


                using (StreamWriter file = new StreamWriter(safeFileDialogFileName.FileName))
                {
                    file.WriteLine("instance " + currentPfxName.ToUpper() + "(C_PARTICLEFX)");
                    file.WriteLine("{");


                    for (int i = 0; i < props.Count; i++)
                    {
                        var value = props[i].value;
                        var name = props[i].Name;


                        // don't save empty or default fields
                        if (!saveAllFields)
                        {
                            if (value == String.Empty || value == "0")
                            {
                                continue;
                            }
                        }

                        if (IsFieldRealInt(name))
                        {
                            file.WriteLine("\t" + name + " = " + value + ";");
                        }
                        else if (IsFieldRealString(name))
                        {
                            file.WriteLine("\t" + name + " = \"" + props[i].ShowValue() + "\";");
                        }
                        else if (props[i].type == TPropEditType.PETstring || props[i].type == TPropEditType.PETenum)
                        {
                            file.WriteLine("\t" + name + " = \"" + value + "\";");
                        }
                        else
                        {
                            file.WriteLine("\t" + name + " = " + value + ";");
                        }
                        
                    }

                    file.WriteLine("};");
                    file.WriteLine("");

                    file.Close();
                }

                
            }
        }

        private void PFXEditorWin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PFXEditorLocation != null)
            {
                this.Location = Properties.Settings.Default.PFXEditorLocation;
            }
        }

        private void labelPFXName_Click(object sender, EventArgs e)
        {

        }

    }
}
