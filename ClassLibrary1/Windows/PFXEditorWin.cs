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

        public PFXEditorWin()
        {
            stat = new PFX_Stat();
            InitializeComponent();

            stat.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(stat_PropertyChanged);

        }

        static void stat_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (!SpacerNET.pfxWin.firstTimeInit)
            {
                return;
            }

            //Console.WriteLine(e.PropertyName + " has been changed.");
            var propInfo = SpacerNET.pfxWin.stat.GetType().GetProperty(e.PropertyName);

            ConsoleEx.WriteLineRed("stat_PropertyChanged: " + e.PropertyName);

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
            propertyGridPfx.PropertySort = PropertySort.Categorized;
            propertyGridPfx.SelectedObject = stat;

            Imports.Stack_PushString(name);
            Imports.Extern_GetInstanceProps();

            //int size = Imports.Stack_PeekInt();

            //MessageBox.Show("Size: " + size);

            stat.BIsAmbientPFX = Convert.ToBoolean(Imports.Stack_PeekInt());
            stat.TimeStartEnd_s = Imports.Stack_PeekString();
            stat.UseEmittersFor = Convert.ToBoolean(Imports.Stack_PeekInt());
            stat.FlockStrength = Imports.Stack_PeekFloat();

            stat.FlockMode = Imports.Stack_PeekString();
            stat.MrkSize = Imports.Stack_PeekFloat();
            stat.MrkTexture_s = Imports.Stack_PeekString();
            stat.MrkFadeSpeed = Imports.Stack_PeekFloat();
            stat.TrlWidth = Imports.Stack_PeekFloat();
            stat.TrlTexture_s = Imports.Stack_PeekString();
            stat.TrlFadeSpeed = Imports.Stack_PeekFloat();

            stat.VisAlphaEnd = Imports.Stack_PeekFloat();
            stat.VisAlphaStart = Imports.Stack_PeekFloat();
            stat.VisAlphaFunc_s = Imports.Stack_PeekString();
            stat.VisSizeEndScale = Imports.Stack_PeekFloat();
            stat.VisSizeStart_s = Imports.Stack_PeekString();

            stat.VisTexColorEnd_s = Imports.Stack_PeekString();
            stat.VisTexColorStart_s = Imports.Stack_PeekString();

            stat.VisTexAniIsLooping = (VISTEXANIISLOOPING)Imports.Stack_PeekInt();


            stat.VisTexAniFPS = Imports.Stack_PeekFloat();
            stat.VisTexIsQuadPoly = Convert.ToBoolean(Imports.Stack_PeekInt());
            stat.VisOrientation_s = Imports.Stack_PeekString();
            stat.VisName_s = Imports.Stack_PeekString();
 
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

            propertyGridPfx.Refresh();
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
    }
}
