using System;
using System.Collections.Generic;
using System.Drawing;
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

            if (prop.Name == "visName_s" || prop.Name == "trlTexture_s" || prop.Name == "shpMesh_s" || prop.Name == "ppsCreateEm_s")
            {
                prop.ownNode.NodeFont = new Font(treeViewPFX.Font, style);
            }
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
    }

}
