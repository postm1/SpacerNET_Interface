
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SpacerUnion.Common.PFX_Editor
{
    

    public class PFX_Stat : System.ComponentModel.INotifyPropertyChanged
    {


        float ppsValue;
        string ppsScaleKeys_s;
        bool ppsIsLooping;
        bool ppsIsSmooth;
        float ppsFPS;
        string ppsCreateEm_s;
        float ppsCreateEmDelay;

        SHPTYPE_S shpType_s;
        SHPFOR_S shpFor_s;
        string shpOffsetVec_s;
        string shpDistribType_s;
        float shpDistribWalkSpeed;
        bool shpIsVolume;
        string shpDim_s;
        string shpMesh_s;
        bool shpMeshRender_b;
        string shpScaleKeys_s;
        bool shpScaleIsLooping;
        bool shpScaleIsSmooth;
        float shpScaleFPS;

        string dirMode_s;
        string dirFor_s;
        string dirModeTargetFor_s;
        string dirModeTargetPos_s;
        float dirAngleHead;
        float dirAngleHeadVar;
        float dirAngleElev;
        float dirAngleElevVar;

        float velAvg;
        float velVar;
        float lspPartAvg;
        float lspPartVar;
        string flyGravity_s;
        FLYCOLLDET_B flyCollDet_b;

        string visName_s;
        string visOrientation_s;
        bool visTexIsQuadPoly;
        float visTexAniFPS;
        VISTEXANIISLOOPING visTexAniIsLooping;
        string visTexColorStart_s;
        string visTexColorEnd_s;
        string visSizeStart_s;
        float visSizeEndScale;
        string visAlphaFunc_s;
        float visAlphaStart;
        float visAlphaEnd;

        float trlFadeSpeed;
        string trlTexture_s;
        float trlWidth;
        float mrkFadeSpeed;
        string mrkTexture_s;
        float mrkSize;
        string flockMode;
        float flockStrength;
        bool useEmittersFor;
        string timeStartEnd_s;
        bool m_bIsAmbientPFX;


        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName)
        {
            ConsoleEx.WriteLineRed(propertyName);
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));

        }

        public PFX_Stat()
        {
        }

        [Browsable(true)]
        [DisplayName("ppsValue")]
        [Description("Возможные значения: 0 до 10000")]
        [Category("PPS")]
        public float PpsValue
        {
            get
            {
                return ppsValue;
            }

            set
            {

                ppsValue = value;
                NotifyPropertyChanged("PpsValue");
            }
        }

        [Category("PPS")]
        [Browsable(true)]
        [DisplayName("ppsScaleKeys_s")]
        [Description("Example of text field")]
        public string PpsScaleKeys_s
        {
            get
            {
                return ppsScaleKeys_s;
            }

            set
            {
                ppsScaleKeys_s = value;
                NotifyPropertyChanged("PpsScaleKeys_s");
            }
        }

        [Category("PPS")]
        [Browsable(true)]
        [DisplayName("ppsIsLooping")]
        [Description("Example of text field")]

        public bool PpsIsLooping
        {
            get
            {
                return ppsIsLooping;
            }

            set
            {
                ppsIsLooping = value;
                NotifyPropertyChanged("PpsIsLooping");
            }
        }

        [Category("PPS")]
        [Browsable(true)]
        [DisplayName("ppsIsSmooth")]
        [Description("Example of text field")]

        public bool PpsIsSmooth
        {
            get
            {
                return ppsIsSmooth;
            }

            set
            {
                ppsIsSmooth = value;
                NotifyPropertyChanged("PpsIsSmooth");
            }
        }

        [Category("PPS")]
        [Browsable(true)]
        [DisplayName("ppsFPS")]
        [Description("Example of text field")]
        public float PpsFPS
        {
            get
            {
                return ppsFPS;
            }

            set
            {
                ppsFPS = value;
                NotifyPropertyChanged("PpsFPS");
            }
        }

        [Category("PPS")]
        [Browsable(true)]
        [DisplayName("ppsCreateEm_s")]
        [Description("Example of text field")]
        public string PpsCreateEm_s
        {
            get
            {
                return ppsCreateEm_s;
            }

            set
            {
                ppsCreateEm_s = value;
                NotifyPropertyChanged("PpsCreateEm_s");
            }
        }
       
        [Category("PPS")]
        [Browsable(true)]
        [DisplayName("ppsCreateEmDelay")]
        [Description("Example of text field")]
        public float PpsCreateEmDelay
        {
            get
            {
                return ppsCreateEmDelay;
            }

            set
            {
                ppsCreateEmDelay = value;
                NotifyPropertyChanged("PpsCreateEmDelay");
            }
        }
        //===============================================================
        [DisplayName("shpType_s")]
        [Description("xample of text field")]
        [Category("SHAPE")]
        [TypeConverter(typeof(DirConverter))]
        public SHPTYPE_S ShpType_s
        {
            get
            {
                return shpType_s;
            }

            set
            {
                shpType_s = value;
                NotifyPropertyChanged("ShpType_s");
            }
        }

        [DisplayName("shpFor_s")]
        [Browsable(true)]
        [Description("Example of text field")]
        [Category("SHAPE")]
        [TypeConverter(typeof(DirConverter))]
        public SHPFOR_S ShpFor_s
        {
            get
            {
                return shpFor_s;
            }

            set
            {
                shpFor_s = value;
                NotifyPropertyChanged("ShpFor_s");
            }
        }
        [Browsable(true)]
        [DisplayName("shpOffsetVec_s")]
        [Description("Example of text field")]
        [Category("SHAPE")]
        public string ShpOffsetVec_s
        {
            get
            {
                return shpOffsetVec_s;
            }

            set
            {
                shpOffsetVec_s = value;
                NotifyPropertyChanged("ShpOffsetVec_s");
            }
        }
        [Browsable(true)]
        [DisplayName("shpDistribType_s")]
        [Description("Example of text field")]
        [Category("SHAPE")]
        public string ShpDistribType_s
        {
            get
            {
                return shpDistribType_s;
            }

            set
            {
                shpDistribType_s = value;
                NotifyPropertyChanged("ShpDistribType_s");
            }
        }
        [Browsable(true)]
        [DisplayName("shpDistribWalkSpeed")]
        [Description("Example of text field")]
        [Category("SHAPE")]
        public float ShpDistribWalkSpeed
        {
            get
            {
                return shpDistribWalkSpeed;
            }

            set
            {
                shpDistribWalkSpeed = value;
                NotifyPropertyChanged("ShpDistribWalkSpeed");
            }
        }
        [Browsable(true)]
        [DisplayName("shpIsVolume")]
        [Description("Example of text field")]
        [Category("SHAPE")]
        public bool ShpIsVolume
        {
            get
            {
                return shpIsVolume;
            }

            set
            {
                shpIsVolume = value;
                NotifyPropertyChanged("ShpIsVolume");
            }
        }
        [Browsable(true)]
        [DisplayName("shpDim_s")]
        [Description("Example of text field")]
        [Category("SHAPE")]
        public string ShpDim_s
        {
            get
            {
                return shpDim_s;
            }

            set
            {
                shpDim_s = value;
                NotifyPropertyChanged("ShpDim_s");
            }
        }
        [Browsable(true)]
        [DisplayName("shpMesh_s")]
        [Description("Example of text field")]
        [Category("SHAPE")]
        public string ShpMesh_s
        {
            get
            {
                return shpMesh_s;
            }

            set
            {
                shpMesh_s = value;
                NotifyPropertyChanged("ShpMesh_s");
            }
        }
        [Browsable(true)]
        [DisplayName("shpMeshRender_b")]
        [Description("Example of text field")]
        [Category("SHAPE")]
        public bool ShpMeshRender_b
        {
            get
            {
                return shpMeshRender_b;
            }

            set
            {
                shpMeshRender_b = value;
                NotifyPropertyChanged("ShpMeshRender_b");
            }
        }
        [Browsable(true)]
        [DisplayName("shpScaleKeys_s")]
        [Description("Example of text field")]
        [Category("SHAPE")]
        public string ShpScaleKeys_s
        {
            get
            {
                return shpScaleKeys_s;
            }

            set
            {
                shpScaleKeys_s = value;
                NotifyPropertyChanged("ShpScaleKeys_s");
            }
        }
        [Browsable(true)]
        [DisplayName("shpScaleIsLooping")]
        [Description("Example of text field")]
        [Category("SHAPE")]
        public bool ShpScaleIsLooping
        {
            get
            {
                return shpScaleIsLooping;
            }

            set
            {
                shpScaleIsLooping = value;
                NotifyPropertyChanged("ShpScaleIsLooping");
            }
        }
        [Browsable(true)]
        [DisplayName("shpScaleIsSmooth")]
        [Description("Example of text field")]
        [Category("SHAPE")]
        public bool ShpScaleIsSmooth
        {
            get
            {
                return shpScaleIsSmooth;
            }

            set
            {
                shpScaleIsSmooth = value;
                NotifyPropertyChanged("ShpScaleIsSmooth");
            }
        }
        [Browsable(true)]
        [DisplayName("shpScaleFPS")]
        [Description("Example of text field")]
        [Category("SHAPE")]
        public float ShpScaleFPS
        {
            get
            {
                return shpScaleFPS;
            }

            set
            {
                shpScaleFPS = value;
                NotifyPropertyChanged("ShpScaleFPS");
            }
        }


        [Category("DIRECTION")]
        [Browsable(true)]
        [DisplayName("dirMode_s")]
        [Description("Example of text field")]
        public string DirMode_s
        {
            get
            {
                return dirMode_s;
            }

            set
            {
                dirMode_s = value;
            }
        }

        [Category("DIRECTION")]
        [Browsable(true)]
        [DisplayName("dirFor_s")]
        [Description("Example of text field")]
        public string DirFor_s
        {
            get
            {
                return dirFor_s;
            }

            set
            {
                dirFor_s = value;
            }
        }
        [Category("DIRECTION")]
        [Browsable(true)]
        [DisplayName("dirModeTargetFor_s")]
        [Description("Example of text field")]
        public string DirModeTargetFor_s
        {
            get
            {
                return dirModeTargetFor_s;
            }

            set
            {
                dirModeTargetFor_s = value;
            }
        }
        [Category("DIRECTION")]
        [Browsable(true)]
        [DisplayName("dirModeTargetPos_s")]
        [Description("Example of text field")]
        public string DirModeTargetPos_s
        {
            get
            {
                return dirModeTargetPos_s;
            }

            set
            {
                dirModeTargetPos_s = value;
            }
        }
        [Category("DIRECTION")]
        [Browsable(true)]
        [DisplayName("dirAngleHead")]
        [Description("Example of text field")]
        public float DirAngleHead
        {
            get
            {
                return dirAngleHead;
            }

            set
            {
                dirAngleHead = value;
            }
        }
        [Category("DIRECTION")]
        [Browsable(true)]
        [DisplayName("dirAngleHeadVar")]
        [Description("Example of text field")]
        public float DirAngleHeadVar
        {
            get
            {
                return dirAngleHeadVar;
            }

            set
            {
                dirAngleHeadVar = value;
            }
        }
        [Category("DIRECTION")]
        [Browsable(true)]
        [DisplayName("dirAngleElev")]
        [Description("Example of text field")]
        public float DirAngleElev
        {
            get
            {
                return dirAngleElev;
            }

            set
            {
                dirAngleElev = value;
            }
        }
        [Category("DIRECTION")]
        [Browsable(true)]
        [DisplayName("dirAngleElevVar")]
        [Description("Example of text field")]
        public float DirAngleElevVar
        {
            get
            {
                return dirAngleElevVar;
            }

            set
            {
                dirAngleElevVar = value;
            }
        }

        [Category("PARTICLES")]
        [Browsable(true)]
        [DisplayName("velAvg")]
        [Description("Example of text field")]
        public float VelAvg
        {
            get
            {
                return velAvg;
            }

            set
            {
                velAvg = value;
            }
        }
        [Category("PARTICLES")]
        [Browsable(true)]
        [DisplayName("velVar")]
        [Description("Example of text field")]
        public float VelVar
        {
            get
            {
                return velVar;
            }

            set
            {
                velVar = value;
            }
        }
        [Category("PARTICLES")]
        [Browsable(true)]
        [DisplayName("lspPartAvg")]
        [Description("Example of text field")]
        public float LspPartAvg
        {
            get
            {
                return lspPartAvg;
            }

            set
            {
                lspPartAvg = value;
            }
        }
        [Category("PARTICLES")]
        [Browsable(true)]
        [DisplayName("lspPartVar")]
        [Description("Example of text field")]
        public float LspPartVar
        {
            get
            {
                return lspPartVar;
            }

            set
            {
                lspPartVar = value;
            }
        }
        [Category("PARTICLES")]
        [Browsable(true)]
        [DisplayName("flyGravity_s")]
        [Description("Example of text field")]
        public string FlyGravity_s
        {
            get
            {
                return flyGravity_s;
            }

            set
            {
                flyGravity_s = value;
            }
        }
        [Category("PARTICLES")]
        [Browsable(true)]
        [DisplayName("flyCollDet_b")]
        [Description("Example of text field")]
        [TypeConverter(typeof(DirConverter))]
        public FLYCOLLDET_B FlyCollDet_b
        {
            get
            {
                return flyCollDet_b;
            }

            set
            {
                flyCollDet_b = value;
            }
        }
        [Category("VISUAL")]
        [Browsable(true)]
        [DisplayName("visName_s")]
        [Description("Example of text field")]
        public string VisName_s
        {
            get
            {
                return visName_s;
            }

            set
            {
                visName_s = value;
                NotifyPropertyChanged("VisName_s");
            }
        }
        [Category("VISUAL")]
        [Browsable(true)]
        [DisplayName("visOrientation_s")]
        [Description("Example of text field")]
        public string VisOrientation_s
        {
            get
            {
                return visOrientation_s;
            }

            set
            {
                visOrientation_s = value;
                NotifyPropertyChanged("VisOrientation_s");
            }
        }
        [Category("VISUAL")]
        [Browsable(true)]
        [DisplayName("visTexIsQuadPoly")]
        [Description("Example of text field")]
        public bool VisTexIsQuadPoly
        {
            get
            {
                return visTexIsQuadPoly;
            }

            set
            {
                visTexIsQuadPoly = value;
                NotifyPropertyChanged("VisTexIsQuadPoly");
            }
        }
        [Category("VISUAL")]
        [Browsable(true)]
        [DisplayName("visTexAniFPS")]
        [Description("Example of text field")]
        public float VisTexAniFPS
        {
            get
            {
                return visTexAniFPS;
            }

            set
            {
                visTexAniFPS = value;
                NotifyPropertyChanged("VisTexAniFPS");
            }
        }
        [Category("VISUAL")]
        [Browsable(true)]
        [DisplayName("visTexAniIsLooping")]
        [Description("Example of text field")]
        //VISTEXANIISLOOPING
        [TypeConverter(typeof(DirConverter))]
        public VISTEXANIISLOOPING VisTexAniIsLooping
        {
            get
            {
                return visTexAniIsLooping;
            }

            set
            {
                visTexAniIsLooping = value;
                NotifyPropertyChanged("VisTexAniIsLooping");
            }
        }
        [Category("VISUAL")]
        [Browsable(true)]
        [DisplayName("visTexColorStart_s")]
        [Description("Example of text field")]
        public string VisTexColorStart_s
        {
            get
            {
                return visTexColorStart_s;
            }

            set
            {
                visTexColorStart_s = value;
                NotifyPropertyChanged("VisTexColorStart_s");
            }
        }
        [Category("VISUAL")]
        [Browsable(true)]
        [DisplayName("visTexColorEnd_s")]
        [Description("Example of text field")]
        public string VisTexColorEnd_s
        {
            get
            {
                return visTexColorEnd_s;
            }

            set
            {
                visTexColorEnd_s = value;
                NotifyPropertyChanged("VisTexColorEnd_s");
            }
        }
        [Category("VISUAL")]
        [Browsable(true)]
        [DisplayName("visSizeStart_s")]
        [Description("Example of text field")]
        public string VisSizeStart_s
        {
            get
            {
                return visSizeStart_s;
            }

            set
            {
                visSizeStart_s = value;
                NotifyPropertyChanged("VisSizeStart_s");
            }
        }
        [Category("VISUAL")]
        [Browsable(true)]
        [DisplayName("visSizeEndScale")]
        [Description("Example of text field")]
        public float VisSizeEndScale
        {
            get
            {
                return visSizeEndScale;
            }

            set
            {
                visSizeEndScale = value;
                NotifyPropertyChanged("VisSizeEndScale");
            }
        }
        [Category("VISUAL")]
        [Browsable(true)]
        [DisplayName("visAlphaFunc_s")]
        [Description("Example of text field")]
        public string VisAlphaFunc_s
        {
            get
            {
                return visAlphaFunc_s;
            }

            set
            {
                visAlphaFunc_s = value;
                NotifyPropertyChanged("VisAlphaFunc_s");
            }
        }
        [Category("VISUAL")]
        [Browsable(true)]
        [DisplayName("visAlphaStart")]
        [Description("Example of text field")]
        public float VisAlphaStart
        {
            get
            {
                return visAlphaStart;
            }

            set
            {
                visAlphaStart = value;
                NotifyPropertyChanged("VisAlphaStart");
            }
        }
        [Category("VISUAL")]
        [Browsable(true)]
        [DisplayName("visAlphaEnd")]
        [Description("Example of text field")]
        public float VisAlphaEnd
        {
            get
            {
                return visAlphaEnd;
            }

            set
            {
                visAlphaEnd = value;
                NotifyPropertyChanged("VisAlphaEnd");
            }
        }
        [Category("MISC")]
        [Browsable(true)]
        [DisplayName("trlFadeSpeed")]
        [Description("Example of text field")]
        public float TrlFadeSpeed
        {
            get
            {
                return trlFadeSpeed;
            }

            set
            {
                trlFadeSpeed = value;
            }
        }
        [Category("MISC")]
        [Browsable(true)]
        [DisplayName("trlTexture_s")]
        [Description("Example of text field")]
        public string TrlTexture_s
        {
            get
            {
                return trlTexture_s;
            }

            set
            {
                trlTexture_s = value;
            }
        }
        [Category("MISC")]
        [Browsable(true)]
        [DisplayName("trlWidth")]
        [Description("Example of text field")]
        public float TrlWidth
        {
            get
            {
                return trlWidth;
            }

            set
            {
                trlWidth = value;
            }
        }
        [Category("MISC")]
        [Browsable(true)]
        [DisplayName("mrkFadeSpeed")]
        [Description("Example of text field")]
        public float MrkFadeSpeed
        {
            get
            {
                return mrkFadeSpeed;
            }

            set
            {
                mrkFadeSpeed = value;
            }
        }
        [Category("MISC")]
        [Browsable(true)]
        [DisplayName("mrkTexture_s")]
        [Description("Example of text field")]
        public string MrkTexture_s
        {
            get
            {
                return mrkTexture_s;
            }

            set
            {
                mrkTexture_s = value;
            }
        }
        [Category("MISC")]
        [Browsable(true)]
        [DisplayName("mrkSize")]
        [Description("Example of text field")]
        public float MrkSize
        {
            get
            {
                return mrkSize;
            }

            set
            {
                mrkSize = value;
            }
        }
        [Category("MISC")]
        [Browsable(true)]
        [DisplayName("flockMode")]
        [Description("Example of text field")]
        public string FlockMode
        {
            get
            {
                return flockMode;
            }

            set
            {
                flockMode = value;
            }
        }
        [Category("MISC")]
        [Browsable(true)]
        [DisplayName("flockStrength")]
        [Description("Example of text field")]
        public float FlockStrength
        {
            get
            {
                return flockStrength;
            }

            set
            {
                flockStrength = value;
            }
        }

        [Category("MISC")]
        [Browsable(true)]
        [DisplayName("useEmittersFor")]
        [Description("Example of text field")]
        public bool UseEmittersFor
        {
            get
            {
                return useEmittersFor;
            }

            set
            {
                useEmittersFor = value;
            }
        }
        [Category("MISC")]
        [Browsable(true)]
        [DisplayName("timeStartEnd_s")]
        [Description("Example of text field")]
        public string TimeStartEnd_s
        {
            get
            {
                return timeStartEnd_s;
            }

            set
            {
                timeStartEnd_s = value;
            }
        }



        [Category("MISC")]
        [Browsable(true)]
        [DisplayName("m_bIsAmbientPFX")]
        [Description("Example of text field")]
        public bool BIsAmbientPFX
        {
            get
            {
                return m_bIsAmbientPFX;
            }

            set
            {
                m_bIsAmbientPFX = value;
            }
        }

       
    }


    class PFX_Editor
    {
    }
}
