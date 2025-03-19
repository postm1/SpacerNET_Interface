using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SpacerUnion.Common
{
    public enum ErrorReportType
    {
        ERROR_REPORT_TYPE_NONE = 0,
        ERROR_REPORT_TYPE_INFO,
        ERROR_REPORT_TYPE_WARNING,
        ERROR_REPORT_TYPE_CRITICAL
    }
    public enum ErrorReportProblemType
    {
        ERROR_REPORT_PROBLEM_TYPE_NONE = 0,
        ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_NAME,
        ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_TEXTURE_BAD_NAME,
        ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_TEXTURE_NOT_FOUND,
        ERROR_REPORT_PROBLEM_TYPE_TRIGGER_NO_NAME,
        ERROR_REPORT_PROBLEM_TYPE_PFX_CANT_BE_PARENT,
        ERROR_REPORT_PROBLEM_TYPE_ITEM_CANT_BE_PARENT,
        ERROR_REPORT_PROBLEM_TYPE_ITEM_NO_VISUAL,
        ERROR_REPORT_PROBLEM_TYPE_ZCVOB_EMPTY_VISUAL,
        ERROR_REPORT_PROBLEM_TYPE_FOG_ZONES,
        ERROR_REPORT_PROBLEM_TYPE_VOB_ZONES,
        ERROR_REPORT_PROBLEM_TYPE_MUSIC_ZONES,
        ERROR_REPORT_PROBLEM_TYPE_STARTPOINT,
        ERROR_REPORT_PROBLEM_TYPE_EMPTY_NAME,
        ERROR_REPORT_PROBLEM_TYPE_EMPTY_NAME_MOB_FOCUS,
        ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_COLLISION,
        ERROR_REPORT_PROBLEM_TYPE_NAME_SPACE,
        ERROR_REPORT_PROBLEM_TYPE_NOT_UNIQ_NAME,
        ERROR_REPORT_PROBLEM_TYPE_BAD_NAME_SYMBOLS,
        ERROR_REPORT_PROBLEM_TYPE_NAME_IS_VISUAL,
        ERROR_REPORT_PROBLEM_TYPE_FOCUS_NAME,
        ERROR_REPORT_PROBLEM_TYPE_KEY_INSTANCE,
        ERROR_REPORT_PROBLEM_TYPE_CONTAINTER_ITEM,
        ERROR_REPORT_PROBLEM_TYPE_SPACES_CONTAINER,
        ERROR_REPORT_PROBLEM_TYPE_SOUNDNAME,
        ERROR_REPORT_PROBLEM_TYPE_SOUNDNAME_NOINST,
        ERROR_REPORT_PROBLEM_TYPE_CONTAINER_BAD_SYMBOLS,
        ERROR_REPORT_PROBLEM_TYPE_BAD_TRIGGER,
        ERROR_REPORT_PROBLEM_TYPE_BAD_USE_WITHITEM,
        ERROR_REPORT_PROBLEM_TYPE_BAD_ON_STATE_FUNC,
        ERROR_REPORT_PROBLEM_TYPE_BAD_COND_FUNC,
        ERROR_REPORT_PROBLEM_TYPE_BAD_VISUAL_SYMBOLS,
        ERROR_REPORT_PROBLEM_TYPE_MOBCONT_BAD_LOCKSTRING,
        ERROR_REPORT_PROBLEM_TYPE_BBOX_AREA_WRONG_SIZE,
        ERROR_REPORT_PROBLEM_TYPE_CHANGELEVEL_SPACE,
        ERROR_REPORT_PROBLEM_TYPE_ITEM_PARENT,
        ERROR_REPORT_PROBLEM_TYPE_VISUAL_SPACE,
        ERROR_REPORT_PROBLEM_TYPE_TRIGGER_SCRIPT_FUNC,
        ERROR_REPORT_PROBLEM_TYPE_PFX_CANT_HAVE_DYNCOLL,
        ERROR_REPORT_PROBLEM_TYPE_TGA_DYNCOLL,
        ERROR_REPORT_PROBLEM_TYPE_BAD_ZFARVOB,
        ERROR_REPORT_PROBLEM_TYPE_WP_NOT_IN_WAYNET,
        ERROR_REPORT_PROBLEM_TYPE_WP_NO_CONNECTIONS,
        ERROR_REPORT_PROBLEM_TYPE_LIGHT_CLOSE_TOGETHER,
        ERROR_REPORT_PROBLEM_TYPE_LIGHT_DYNCOLL,
        ERROR_REPORT_PROBLEM_TYPE_MOB_NO_COLL,
        ERROR_REPORT_PROBLEM_TYPE_STATIC_LIGHT_NO_PORTAL,
        ERROR_REPORT_PROBLEM_TYPE_DECAL_BAD_BLEND
    }

    public class ErrorReportEntry
    {
        private ErrorReportType errorType;
        private ErrorReportProblemType problemType;

        public uint objectAddr;
        public string textureName;
        public string materialName;
        public string vobName;
        public int id;

        public ErrorReportEntry()
        {
            ErrorType = ErrorReportType.ERROR_REPORT_TYPE_NONE;
            ProblemType = ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_NONE;
            ObjectAddr = 0;
            textureName = String.Empty;
            materialName = String.Empty;
            id = 0;
        }

        public uint ObjectAddr { get => objectAddr; set => objectAddr = value; }
        public ErrorReportType ErrorType { get => errorType; set => errorType = value; }
        public ErrorReportProblemType ProblemType { get => problemType; set => problemType = value; }


        public string GetReportTypeText()
        {
            string result = String.Empty;

            switch (errorType)
            {
                case ErrorReportType.ERROR_REPORT_TYPE_INFO: result = Localizator.Get("ERROR_REPORT_TYPE_INFO"); break;
                case ErrorReportType.ERROR_REPORT_TYPE_WARNING: result = Localizator.Get("ERROR_REPORT_TYPE_WARNING"); break;
                case ErrorReportType.ERROR_REPORT_TYPE_CRITICAL: result = Localizator.Get("ERROR_REPORT_TYPE_CRITICAL"); break;  
            }


            return result;
        }

        public string GetProblemTypeText()
        {
            string result = String.Empty;

            switch (ProblemType)
            {
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_NAME: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_NAME"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_TEXTURE_BAD_NAME: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_TEXTURE_BAD_NAME"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_TEXTURE_NOT_FOUND: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_TEXTURE_NOT_FOUND"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_TRIGGER_NO_NAME: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_TRIGGER_NO_NAME"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_PFX_CANT_BE_PARENT: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_PFX_CANT_BE_PARENT"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_ITEM_CANT_BE_PARENT: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_ITEM_CANT_BE_PARENT"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_ITEM_NO_VISUAL: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_ITEM_NO_VISUAL"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_ZCVOB_EMPTY_VISUAL: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_ZCVOB_EMPTY_VISUAL"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_FOG_ZONES: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_FOG_ZONES"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_VOB_ZONES: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_VOB_ZONES"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MUSIC_ZONES: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_MUSIC_ZONES"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_STARTPOINT: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_STARTPOINT"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_EMPTY_NAME: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_EMPTY_NAME"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_EMPTY_NAME_MOB_FOCUS: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_EMPTY_NAME_MOB_FOCUS"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_NAME_SPACE: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_NAME_SPACE"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_NOT_UNIQ_NAME: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_NOT_UNIQ_NAME"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_BAD_NAME_SYMBOLS: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_BAD_NAME_SYMBOLS"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_NAME_IS_VISUAL: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_NAME_IS_VISUAL"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_FOCUS_NAME: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_FOCUS_NAME"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_KEY_INSTANCE: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_KEY_INSTANCE"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_CONTAINTER_ITEM: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_CONTAINTER_ITEM"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_SPACES_CONTAINER: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_SPACES_CONTAINER"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_SOUNDNAME: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_SOUNDNAME"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_SOUNDNAME_NOINST: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_SOUNDNAME_NOINST"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_CONTAINER_BAD_SYMBOLS: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_CONTAINER_BAD_SYMBOLS"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_BAD_TRIGGER: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_BAD_TRIGGER"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_BAD_USE_WITHITEM: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_BAD_USE_WITHITEM"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_BAD_ON_STATE_FUNC: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_BAD_ON_STATE_FUNC"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_BAD_COND_FUNC: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_BAD_COND_FUNC"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_BAD_VISUAL_SYMBOLS: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_BAD_VISUAL_SYMBOLS"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MOBCONT_BAD_LOCKSTRING: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_MOBCONT_BAD_LOCKSTRING"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_BBOX_AREA_WRONG_SIZE: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_BBOX_AREA_WRONG_SIZE"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_CHANGELEVEL_SPACE: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_CHANGELEVEL_SPACE"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_ITEM_PARENT: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_ITEM_PARENT"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_VISUAL_SPACE: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_VISUAL_SPACE"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_TRIGGER_SCRIPT_FUNC: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_TRIGGER_SCRIPT_FUNC"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_PFX_CANT_HAVE_DYNCOLL: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_PFX_CANT_HAVE_DYNCOLL"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_TGA_DYNCOLL: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_TGA_DYNCOLL"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_BAD_ZFARVOB: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_BAD_ZFARVOB"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_WP_NOT_IN_WAYNET: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_WP_NOT_IN_WAYNET"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_WP_NO_CONNECTIONS: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_WP_NO_CONNECTIONS"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_LIGHT_CLOSE_TOGETHER: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_LIGHT_CLOSE_TOGETHER"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_LIGHT_DYNCOLL: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_LIGHT_DYNCOLL"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MOB_NO_COLL: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_MOB_NO_COLL"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_STATIC_LIGHT_NO_PORTAL: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_STATIC_LIGHT_NO_PORTAL"); break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_DECAL_BAD_BLEND: result = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_DECAL_BAD_BLEND"); break;


                    
                    //ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_COLLISION NOT USED?   
            }


            return result;
        }

        public string GetDescriptionText()
        {
            string result = String.Empty;


            var stringFormatMatTex = Localizator.Get("ERROR_REPORT_TEXT_MATERIAL") + ": {0}, " +
                            Localizator.Get("ERROR_REPORT_TEXT_TEXTURE") + ": {1}";


            

            switch (ProblemType)
            {
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_NAME:
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_TEXTURE_BAD_NAME:
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_TEXTURE_NOT_FOUND:
                    {
                            result = String.Format(stringFormatMatTex, materialName, textureName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_TRIGGER_NO_NAME:
                    {
                        result = String.Format(Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_TRIGGER_NO_NAME"));
                    };
                    break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_ITEM_NO_VISUAL:
                    {

                        var stringFormatItemNoVisual = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_ITEM_NO_VISUAL") + ": {0}";

                        result = String.Format(stringFormatItemNoVisual, vobName);
                    };
                    break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_ZCVOB_EMPTY_VISUAL:
                    {

                        var stringFormatItemNoVisual = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_ZCVOB_EMPTY_VISUAL") + ": {0}";

                        result = String.Format(stringFormatItemNoVisual, vobName);
                    };
                    break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_PFX_CANT_BE_PARENT:
                    {

                        var stringFormatPFXParent = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_PFX_CANT_BE_PARENT") + ": {0}";

                        result = String.Format(stringFormatPFXParent, vobName);
                    };
                    break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_ITEM_CANT_BE_PARENT:
                    {

                        var stringFormatPFXParent = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_ITEM_CANT_BE_PARENT") + ": {0}";

                        result = String.Format(stringFormatPFXParent, vobName);
                    };
                    break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_FOG_ZONES:
                    {

                        var stringFormatPFXParent = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_FOG_ZONES") + ": {0}";

                        result = String.Format(stringFormatPFXParent, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_VOB_ZONES:
                    {

                        var stringFormatPFXParent = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_VOB_ZONES") + ": {0}";

                        result = String.Format(stringFormatPFXParent, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MUSIC_ZONES:
                    {

                        var stringFormatPFXParent = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_MUSIC_ZONES") + ": {0}";

                        result = String.Format(stringFormatPFXParent, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_STARTPOINT:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_STARTPOINT") + ": {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_EMPTY_NAME:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_EMPTY_NAME") + ": {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_EMPTY_NAME_MOB_FOCUS:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_EMPTY_NAME_MOB_FOCUS") + ": {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_NAME_SPACE:
                    {

                        var stringFormatSpaceName = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_NAME_SPACE") + ": {0}";

                        result = String.Format(stringFormatSpaceName, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_NOT_UNIQ_NAME:
                    {

                        var stringFormatSpaceName = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_NOT_UNIQ_NAME") + ": {0}";

                        result = String.Format(stringFormatSpaceName, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_BAD_NAME_SYMBOLS:
                    {

                        var stringFormatSpaceName = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_BAD_NAME_SYMBOLS") + ": {0}";

                        result = String.Format(stringFormatSpaceName, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_NAME_IS_VISUAL:
                    {

                        var stringFormatSpaceName = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_NAME_IS_VISUAL") + ": {0}";

                        result = String.Format(stringFormatSpaceName, vobName);
                    };
                    break;


                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_FOCUS_NAME:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_FOCUS_NAME") + ": {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_KEY_INSTANCE:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_KEY_INSTANCE") + ": {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_CONTAINTER_ITEM:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_CONTAINTER_ITEM") + ": {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_SPACES_CONTAINER:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_SPACES_CONTAINER") + ": {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_SOUNDNAME:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_SOUNDNAME") + ": {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_SOUNDNAME_NOINST:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_SOUNDNAME_NOINST") + ": {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_CONTAINER_BAD_SYMBOLS:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_CONTAINER_BAD_SYMBOLS") + ": {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_BAD_TRIGGER:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_BAD_TRIGGER") + ": {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_BAD_USE_WITHITEM:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_BAD_USE_WITHITEM") + ": {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_BAD_ON_STATE_FUNC:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_BAD_ON_STATE_FUNC") + ": {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_BAD_COND_FUNC:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_BAD_COND_FUNC") + ": {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_BAD_VISUAL_SYMBOLS:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_BAD_VISUAL_SYMBOLS") + ": {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MOBCONT_BAD_LOCKSTRING:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_MOBCONT_BAD_LOCKSTRING") + ": {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_BBOX_AREA_WRONG_SIZE:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_BBOX_AREA_WRONG_SIZE") + ": {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_CHANGELEVEL_SPACE:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_CHANGELEVEL_SPACE") + ": {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_ITEM_PARENT:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_ITEM_PARENT") + ": {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_VISUAL_SPACE:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_VISUAL_SPACE") + ": {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_TRIGGER_SCRIPT_FUNC:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_TRIGGER_SCRIPT_FUNC") + ": {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;


                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_PFX_CANT_HAVE_DYNCOLL:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_PFX_CANT_HAVE_DYNCOLL") + " {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;


                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_TGA_DYNCOLL:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_TGA_DYNCOLL") + " {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_BAD_ZFARVOB:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_BAD_ZFARVOB") + " {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_WP_NOT_IN_WAYNET:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_WP_NOT_IN_WAYNET") + " {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_WP_NO_CONNECTIONS:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_WP_NO_CONNECTIONS") + " {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_LIGHT_CLOSE_TOGETHER:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_LIGHT_CLOSE_TOGETHER") + " {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_LIGHT_DYNCOLL:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_LIGHT_DYNCOLL") + " {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MOB_NO_COLL:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_MOB_NO_COLL") + " {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_STATIC_LIGHT_NO_PORTAL:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_STATIC_LIGHT_NO_PORTAL") + " {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_DECAL_BAD_BLEND:
                    {

                        var stringFormat = Localizator.Get("ERROR_REPORT_PROBLEM_TYPE_DECAL_BAD_BLEND") + " {0}";

                        result = String.Format(stringFormat, vobName);
                    };
                    break;

                    
            }


            return result;
        }

        public string GetLinkText()
        {
            if (materialName.Length > 0)
            {
                return Localizator.Get("ERROR_REPORT_COPY_MAT_NAME");
            }
            else
            {
                return Localizator.Get("ERROR_REPORT_DOUBLE_CLICK");
            }
            
        }

        public Color GetTypeBackColor()
        {
            Color col = Color.Black;

            switch (ErrorType)
            {
                case ErrorReportType.ERROR_REPORT_TYPE_INFO: col = Color.FromArgb(255, 134, 182, 255); break;
                case ErrorReportType.ERROR_REPORT_TYPE_WARNING: col = Color.Orange; break;
                case ErrorReportType.ERROR_REPORT_TYPE_CRITICAL: col = Color.Red; break;
            }

            return col;
        }

        public void SetErrorType(ErrorReportType type)
        {
            ErrorType = type;
        }

        public void SetProblemType(ErrorReportProblemType type)
        {
            problemType = type;
        }
    }
}
