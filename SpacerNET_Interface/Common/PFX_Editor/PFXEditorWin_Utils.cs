using SpacerUnion.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion.Windows
{
    public partial class PFXEditorWin : Form
    {
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
        


        public void SetNodeStyle(CProperty prop)
        {
            FontStyle style = FontStyle.Underline;

            if (prop.Name == "shpType_s" || prop.Name == "visName_s" || prop.Name == "trlTexture_s" || prop.Name == "shpMesh_s" 
                || prop.Name == "ppsCreateEm_s"
                || prop.Name == "visTexColorStart_s"
                || prop.Name == "visTexColorEnd_s"

                )
            {
                prop.ownNode.NodeFont = new Font(treeViewPFX.Font, style);
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
            AddNewProp("visOrientation_s", "VISUAL", "enum", "");
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

        public void LoadPfx(string name)
        {

            ConsoleEx.WriteLineRed("Load PFX: " + name);

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
            else if (prop.Name == "shpMeshRender_b")
            {
                prop.enumArray.Add("NONE");
                prop.enumArray.Add("DEFAULT");
                prop.enumArray.Add("ADD");
                prop.enumArray.Add("MULT");
                prop.enumArray.Add("BLEND");
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

        public bool PFX_CheckValidInput(string input, CProperty prop)
        {
            // empty string is good
            if (prop.type == TPropEditType.PETstring && input.Trim().Length == 0)
            {
                return true;
            }

            if (prop.type == TPropEditType.PETfloat || prop.type == TPropEditType.PETint)
            {
                if (!Utils.IsFloatOrInt(input))
                {
                    MessageBox.Show(Localizator.Get("PFX_EDITOR_WRONG_INPUT_NOT_NUMBER"));
                    return false;
                }
               
            }

           

            if (prop.Name == "visAlphaStart" || prop.Name == "visAlphaEnd")
            {
                float f = float.Parse(input, CultureInfo.InvariantCulture);

                if (f < 0 || f > 255.0f)
                {
                    MessageBox.Show(Localizator.Get("PFX_EDITOR_WRONG_INPUT_0_255"));
                    return false;
                }
            }
            else if (prop.Name == "ppsValue" 
                || prop.Name == "ppsFPS"
                || prop.Name == "ppsCreateEmDelay" 
                || prop.Name == "shpDistribWalkSpeed"
                || prop.Name == "shpScaleFPS" 
                || prop.Name == "visTexAniFPS"
                || prop.Name == "visSizeEndScale" 
                || prop.Name == "trlFadeSpeed"
                || prop.Name == "trlWidth" 
                || prop.Name == "mrkFadeSpeed"  
                || prop.Name == "mrkSize"
                || prop.Name == "flockStrength"
                )
            {
                float f = float.Parse(input, CultureInfo.InvariantCulture);

                if (f < 0)
                {
                    MessageBox.Show(Localizator.Get("PFX_EDITOR_WRONG_INPUT_CANTBE_NEGATIVE"));
                    return false;
                }
            }
            else if (prop.Name == "shpOffsetVec_s" || prop.Name == "flyGravity_s" || prop.Name == "dirModeTargetPos_s"

                )
            {
                var split = input.Split(' ');

                if (split.Length != 3)
                {
                    MessageBox.Show(Localizator.Get("PFX_EDITOR_WRONG_FORMAT_VECTOR3"));
                    return false;
                }
               
            }
            else if (prop.Name == "visTexColorStart_s" || prop.Name == "visTexColorEnd_s")
            {
                var split = input.Split(' ');

                if (split.Length != 3)
                {
                    MessageBox.Show(Localizator.Get("PFX_EDITOR_WRONG_FORMAT_COLOR"));
                    return false;
                }
            }
            else if (prop.Name == "visSizeStart_s" || prop.Name == "timeStartEnd_s")
            {
                var split = input.Split(' ');

                if (split.Length != 2)
                {
                    MessageBox.Show(Localizator.Get("PFX_EDITOR_WRONG_FORMAT_VECTOR2"));
                    return false;
                }
            }
                

            return true;
        }
    }

    

}
