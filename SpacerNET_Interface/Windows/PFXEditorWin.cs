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
        public void FillProps()
        {
            props.Clear();

            treeViewPFX.ImageList = SpacerNET.propWin.imageListProps;

            treeViewPFX.BeginUpdate();

            FillFolders();

            AddNewProp("ppsValue", "PPS", "float", "10.0");
            AddNewProp("ppsScaleKeys_s", "PPS", "string", "1");
            AddNewProp("ppsIsLooping", "PPS", "bool", "0");
            AddNewProp("ppsIsSmooth", "PPS", "bool", "1");
            AddNewProp("ppsFPS", "PPS", "float", "10");
            AddNewProp("ppsCreateEm_s", "PPS", "string", "");
            AddNewProp("ppsCreateEmDelay", "PPS", "float", "0"); //7


            AddNewProp("shpType_s", "SHAPE", "enum", "0");
            AddNewProp("shpFor_s", "SHAPE", "enum", "0");
            AddNewProp("shpOffsetVec_s", "SHAPE", "string", "0 0 0");
            AddNewProp("shpDistribType_s", "SHAPE", "enum", "0");
            AddNewProp("shpDistribWalkSpeed", "SHAPE", "float", "0.0");
            AddNewProp("shpIsVolume", "SHAPE", "bool", "0");
            AddNewProp("shpDim_s", "SHAPE", "string", "10");
            AddNewProp("shpMesh_s", "SHAPE", "string", "");
            AddNewProp("shpMeshRender_b", "SHAPE", "enum", "0");
            AddNewProp("shpScaleKeys_s", "SHAPE", "string", "1");
            AddNewProp("shpScaleIsLooping", "SHAPE", "bool", "0");
            AddNewProp("shpScaleIsSmooth", "SHAPE", "bool", "0");
            AddNewProp("shpScaleFPS", "SHAPE", "float", "2"); //20


            AddNewProp("dirMode_s", "DIR", "enum", "0");
            AddNewProp("dirFor_s", "DIR", "enum", "0");
            AddNewProp("dirModeTargetFor_s", "DIR", "enum", "0");
            AddNewProp("dirModeTargetPos_s", "DIR", "string", "0");
            AddNewProp("dirAngleHead", "DIR", "float", "0");
            AddNewProp("dirAngleHeadVar", "DIR", "float", "0");
            AddNewProp("dirAngleElev", "DIR", "float", "0");
            AddNewProp("dirAngleElevVar", "DIR", "float", "0"); //28

            AddNewProp("velAvg", "VEL", "float", "1000");
            AddNewProp("velVar", "VEL", "float", "100");
            AddNewProp("lspPartAvg", "VEL", "float", "500");
            AddNewProp("lspPartVar", "VEL", "float", "10");

            AddNewProp("flyGravity_s", "FLY", "string", "0 0 0");
            AddNewProp("flyCollDet_b", "FLY", "enum", "0"); //34


            AddNewProp("visName_s", "VISUAL", "string", "BLACK.TGA");
            AddNewProp("visOrientation_s", "VISUAL", "string", "");
            AddNewProp("visTexIsQuadPoly", "VISUAL", "bool", "1");
            AddNewProp("visTexAniFPS", "VISUAL", "float", "12");
            AddNewProp("visTexAniIsLooping", "VISUAL", "bool", "1");

            AddNewProp("visTexColorStart_s", "VISUAL", "string", "255 255 255");
            AddNewProp("visTexColorEnd_s", "VISUAL", "string", "255 255 255");
            AddNewProp("visSizeStart_s", "VISUAL", "string", "10 10");
            AddNewProp("visSizeEndScale", "VISUAL", "float", "20");

            AddNewProp("visAlphaFunc_s", "VISUAL", "enum", "1");
            AddNewProp("visAlphaStart", "VISUAL", "float", "255");
            AddNewProp("visAlphaEnd", "VISUAL", "float", "255"); //46


            AddNewProp("trlFadeSpeed", "TRAIL", "float", "1.0");
            AddNewProp("trlTexture_s", "TRAIL", "string", "");
            AddNewProp("trlWidth", "TRAIL", "float", "1.0");
            AddNewProp("mrkFadeSpeed", "TRAIL", "float", "1.0");
            AddNewProp("mrkTexture_s", "TRAIL", "string", "1.0");
            AddNewProp("mrkSize", "TRAIL", "float", "1.0");

            AddNewProp("flockMode", "OTHER", "enum", "0");
            AddNewProp("flockStrength", "OTHER", "float", "0");
            AddNewProp("useEmittersFor", "OTHER", "bool", "0");
            AddNewProp("timeStartEnd_s", "OTHER", "string", "0 0");
            AddNewProp("m_bIsAmbientPFX", "OTHER", "bool", "0"); //57 END


            treeViewPFX.ExpandAll();
            treeViewPFX.EndUpdate();
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

        public void LoadPfx(string name)
        {
            Imports.Stack_PushString(name);
            Imports.Extern_GetInstanceProps();


            treeViewPFX.BeginUpdate();

            SetProp("m_bIsAmbientPFX", Imports.Stack_PeekInt().ToString());
            SetProp("timeStartEnd_s", Imports.Stack_PeekString());
            SetProp("useEmittersFor", Imports.Stack_PeekInt().ToString());
            SetProp("flockStrength", Imports.Stack_PeekFloat().ToString());
            SetProp("flockMode", Imports.Stack_PeekString());


            SetProp("mrkSize", Imports.Stack_PeekFloat().ToString());
            SetProp("mrkTexture_s", Imports.Stack_PeekString());
            SetProp("mrkFadeSpeed", Imports.Stack_PeekFloat().ToString());
            SetProp("trlWidth", Imports.Stack_PeekFloat().ToString());
            SetProp("trlTexture_s", Imports.Stack_PeekString());
            SetProp("trlFadeSpeed", Imports.Stack_PeekFloat().ToString());




            SetProp("visAlphaEnd", Imports.Stack_PeekFloat().ToString());
            SetProp("visAlphaStart", Imports.Stack_PeekFloat().ToString());
            SetProp("visAlphaFunc_s", Imports.Stack_PeekString());
            SetProp("visSizeEndScale", Imports.Stack_PeekFloat().ToString());
            SetProp("visSizeStart_s", Imports.Stack_PeekString());
            SetProp("visTexColorEnd_s", Imports.Stack_PeekString());
            SetProp("visTexColorStart_s", Imports.Stack_PeekString());


            SetProp("visTexAniIsLooping", Imports.Stack_PeekInt().ToString());
            SetProp("visTexAniFPS", Imports.Stack_PeekFloat().ToString());
            SetProp("visTexIsQuadPoly", Imports.Stack_PeekInt().ToString());
            SetProp("visOrientation_s", Imports.Stack_PeekString());
            SetProp("visName_s", Imports.Stack_PeekString());

            SetProp("flyCollDet_b", Imports.Stack_PeekInt().ToString());
            SetProp("flyGravity_s", Imports.Stack_PeekString());

            SetProp("lspPartVar", Imports.Stack_PeekFloat().ToString());
            SetProp("lspPartAvg", Imports.Stack_PeekFloat().ToString());
            SetProp("velVar", Imports.Stack_PeekFloat().ToString());
            SetProp("velAvg", Imports.Stack_PeekFloat().ToString());


            SetProp("dirAngleElevVar", Imports.Stack_PeekFloat().ToString());
            SetProp("dirAngleElev", Imports.Stack_PeekFloat().ToString());

            SetProp("dirAngleHeadVar", Imports.Stack_PeekFloat().ToString());
            SetProp("dirAngleHead", Imports.Stack_PeekFloat().ToString());


            SetProp("dirModeTargetPos_s", Imports.Stack_PeekString());
            SetProp("dirModeTargetFor_s", Imports.Stack_PeekString());
            SetProp("dirFor_s", Imports.Stack_PeekString());
            SetProp("dirMode_s", Imports.Stack_PeekString());

            SetProp("shpScaleFPS", Imports.Stack_PeekFloat().ToString());
            SetProp("shpScaleIsSmooth", Imports.Stack_PeekInt().ToString());
            SetProp("shpScaleIsLooping", Imports.Stack_PeekInt().ToString());
            SetProp("shpScaleKeys_s", Imports.Stack_PeekString());
            SetProp("shpMeshRender_b", Imports.Stack_PeekInt().ToString());
            SetProp("shpMesh_s", Imports.Stack_PeekString());
            SetProp("shpDim_s", Imports.Stack_PeekString());
            SetProp("shpIsVolume", Imports.Stack_PeekInt().ToString());

            SetProp("shpDistribWalkSpeed", Imports.Stack_PeekFloat().ToString());
            SetProp("shpDistribType_s", Imports.Stack_PeekString());
            SetProp("shpOffsetVec_s", Imports.Stack_PeekString());

            SetProp("shpFor_s", Imports.Stack_PeekString());
            SetProp("shpType_s", Imports.Stack_PeekString());
            SetProp("ppsCreateEmDelay", Imports.Stack_PeekFloat().ToString());


            SetProp("ppsCreateEm_s", Imports.Stack_PeekString());
            SetProp("ppsFPS", Imports.Stack_PeekFloat().ToString());
            SetProp("ppsIsSmooth", Imports.Stack_PeekInt().ToString());
            SetProp("ppsIsLooping", Imports.Stack_PeekInt().ToString());
            SetProp("ppsScaleKeys_s", Imports.Stack_PeekString());
            SetProp("ppsValue", Imports.Stack_PeekFloat().ToString());

     

            treeViewPFX.EndUpdate();

            //propertyGridPfx.Refresh();
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
    }
}
