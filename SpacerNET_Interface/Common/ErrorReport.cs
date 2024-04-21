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
    }

    public class ErrorReportEntry
    {
        private ErrorReportType errorType;
        private ErrorReportProblemType problemType;

        public uint objectAddr;
        public string textureName;
        public string materialName;
        public string vobName;

        public ErrorReportEntry()
        {
            ErrorType = ErrorReportType.ERROR_REPORT_TYPE_NONE;
            ProblemType = ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_NONE;
            ObjectAddr = 0;
            textureName = String.Empty;
            materialName = String.Empty;
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
            }

            return result;
        }

        public string GetLinkText()
        {
            return Localizator.Get("ERROR_REPORT_DOUBLE_CLICK");
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
