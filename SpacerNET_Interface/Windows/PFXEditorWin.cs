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

            FillProps();
        }

        public void FillFolders()
        {
            TreeNode node = treeViewPFX.Nodes.Add("PPS");
            node.Tag = Constants.TAG_FOLDER;
            node.SelectedImageIndex = 0;
            node.ImageIndex = 0;

            node = treeViewPFX.Nodes.Add("SHAPE");
            node.Tag = Constants.TAG_FOLDER;
            node.SelectedImageIndex = 0;
            node.ImageIndex = 0;

            node = treeViewPFX.Nodes.Add("DIR");
            node.Tag = Constants.TAG_FOLDER;
            node.SelectedImageIndex = 0;
            node.ImageIndex = 0;

            node = treeViewPFX.Nodes.Add("VEL");
            node.Tag = Constants.TAG_FOLDER;
            node.SelectedImageIndex = 0;
            node.ImageIndex = 0;


            node = treeViewPFX.Nodes.Add("FLY");
            node.Tag = Constants.TAG_FOLDER;
            node.SelectedImageIndex = 0;
            node.ImageIndex = 0;

            node = treeViewPFX.Nodes.Add("VISUAL");
            node.Tag = Constants.TAG_FOLDER;
            node.SelectedImageIndex = 0;
            node.ImageIndex = 0;


            node = treeViewPFX.Nodes.Add("TRAIL");
            node.Tag = Constants.TAG_FOLDER;
            node.SelectedImageIndex = 0;
            node.ImageIndex = 0;

            node = treeViewPFX.Nodes.Add("OTHER");
            node.Tag = Constants.TAG_FOLDER;
            node.SelectedImageIndex = 0;
            node.ImageIndex = 0;
        }

        public void SetPFXIcon(CProperty prop)
        {
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

        public void FillEnumProp(CProperty prop)
        {
            if (prop.Name == "shpType_s")
            {
                prop.enumArray.Add("POINT");
                prop.enumArray.Add("LINE");
                prop.enumArray.Add("BOX");
                prop.enumArray.Add("CIRCLE");
                prop.enumArray.Add("SPHERE");
                prop.enumArray.Add("MESH");
            }
            else if (prop.Name == "shpFor_s")
            {
                prop.enumArray.Add("WORLD");
                prop.enumArray.Add("OBJECT");
            }
            else if (prop.Name == "shpDistribType_s")
            {
                prop.enumArray.Add("RAND");
                prop.enumArray.Add("UNI");
                prop.enumArray.Add("WALK");
            }
            else if (prop.Name == "dirMode_s")
            {
                prop.enumArray.Add("NONE");
                prop.enumArray.Add("DIR");
                prop.enumArray.Add("TARGET");
                prop.enumArray.Add("MESH");
            }
            else if (prop.Name == "dirFor_s")
            {
                prop.enumArray.Add("OBJECT");
                prop.enumArray.Add("WORLD");
                prop.enumArray.Add("FRAME");
            }
            else if (prop.Name == "dirModeTargetFor_s")
            {
                prop.enumArray.Add("OBJECT");
                prop.enumArray.Add("WORLD");
            }
            else if (prop.Name == "visTexAniIsLooping")
            {
                prop.enumArray.Add("FALSE");
                prop.enumArray.Add("TRUE");
                prop.enumArray.Add("SPECIAL");
            }
            else if (prop.Name == "flyCollDet_b")
            {
                prop.enumArray.Add("NONE");
                prop.enumArray.Add("SLOWER_REFLECT");
                prop.enumArray.Add("FASTER_REFLECT");
                prop.enumArray.Add("FREEZE");
                prop.enumArray.Add("REMOVE");
            }
            else if (prop.Name == "visOrientation_s")
            {
                prop.enumArray.Add("NONE");
                prop.enumArray.Add("VEL");
                prop.enumArray.Add("VOB");
                prop.enumArray.Add("VEL3D");
            }
            else if (prop.Name == "visAlphaFunc_s")
            {
                prop.enumArray.Add("MAT_DEFAULT");
                prop.enumArray.Add("NONE");
                prop.enumArray.Add("BLEND");
                prop.enumArray.Add("ADD");
                prop.enumArray.Add("SUB");
                prop.enumArray.Add("MUL");
                prop.enumArray.Add("MUL2");
                prop.enumArray.Add("TEST");
                prop.enumArray.Add("BLEND_TEST");
            }
            else if (prop.Name == "flockMode")
            {
                prop.enumArray.Add("NONE");
                prop.enumArray.Add("WIND");
                prop.enumArray.Add("WIND_PLANTS");
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
            AddNewProp("shpMeshRender_b", "SHAPE", "bool", "0");
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


         
 
            stat.FlyCollDet_b = (FLYCOLLDET_B)Imports.Stack_PeekInt();
            stat.FlyGravity_s = Imports.Stack_PeekString();
            stat.LspPartVar = Imports.Stack_PeekFloat();
            stat.LspPartAvg = Imports.Stack_PeekFloat();
            stat.VelVar = Imports.Stack_PeekFloat();
            stat.VelAvg = Imports.Stack_PeekFloat();
            stat.DirAngleElevVar = Imports.Stack_PeekFloat();
            stat.DirAngleElev = Imports.Stack_PeekFloat();
            stat.DirAngleHeadVar = Imports.Stack_PeekFloat();
            stat.DirAngleHead = Imports.Stack_PeekFloat();

            stat.DirModeTargetPos_s = Imports.Stack_PeekString();
            stat.DirModeTargetFor_s = Imports.Stack_PeekString();
            stat.DirFor_s = Imports.Stack_PeekString();
            stat.DirMode_s = Imports.Stack_PeekString();
       
            stat.ShpScaleFPS = Imports.Stack_PeekFloat();
            stat.ShpScaleIsSmooth = Convert.ToBoolean(Imports.Stack_PeekInt());
            stat.ShpScaleIsLooping = Convert.ToBoolean(Imports.Stack_PeekInt());

            stat.ShpScaleKeys_s = Imports.Stack_PeekString();
            stat.ShpMeshRender_b = Convert.ToBoolean(Imports.Stack_PeekInt());
            stat.ShpMesh_s = Imports.Stack_PeekString();
            stat.ShpDim_s = Imports.Stack_PeekString();
            stat.ShpIsVolume = Convert.ToBoolean(Imports.Stack_PeekInt());
            stat.ShpDistribWalkSpeed = Imports.Stack_PeekFloat();
            stat.ShpDistribType_s = Imports.Stack_PeekString();
            stat.ShpOffsetVec_s = Imports.Stack_PeekString();
         
            SHPFOR_S ShpFor_s = ExtClass.ToEnum<SHPFOR_S>(Imports.Stack_PeekString());
            stat.ShpFor_s = ShpFor_s;

            SHPTYPE_S ShpType_s = ExtClass.ToEnum<SHPTYPE_S>(Imports.Stack_PeekString());
            stat.ShpType_s = ShpType_s;
     
            stat.PpsCreateEmDelay = Imports.Stack_PeekFloat();
            stat.PpsCreateEm_s = Imports.Stack_PeekString();
            stat.PpsFPS = Imports.Stack_PeekFloat();
            stat.PpsIsSmooth = Convert.ToBoolean(Imports.Stack_PeekInt());
            stat.PpsIsLooping = Convert.ToBoolean(Imports.Stack_PeekInt());
            stat.PpsScaleKeys_s = Imports.Stack_PeekString();
            stat.PpsValue = Imports.Stack_PeekFloat();


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
    }
}
