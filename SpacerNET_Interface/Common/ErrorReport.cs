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
        ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_TEXTURE_NOT_FOUND
    }

    public class ErrorReportEntry
    {
        private ErrorReportType errorType;
        private ErrorReportProblemType problemType;

        uint objectAddr;
        private string textureName;
        private string materialName;

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
            }


            return result;
        }

        public string GetDescriptionText()
        {
            string result = String.Empty;

            switch (ProblemType)
            {
                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_NAME:
                {
                        materialName = "SOLEMN_TAR.001";

                        result = String.Format("Имя материала: {0}", materialName);
                };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_TEXTURE_BAD_NAME:
                    {
                        textureName = "TEXT_GRASS_01.TGA.TGA";
                        materialName = "SOLEMN_TAR_GONE";

                        result = String.Format("Материал: {0}, Текстура: {1}", materialName, textureName);
                    };
                    break;

                case ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_TEXTURE_NOT_FOUND:
                    {
                        textureName = "SETEXT_GRASS_01.TGA.001";
                        materialName = "SOLEMN_TAR_GONE_03";

                        result = String.Format("Материал: {0}, Текстура: {1}", materialName, textureName);
                    };
                    break;
            }

            return result;
        }

        public string GetLinkText()
        {
            return "-";
        }

        public Color GetTypeBackColor()
        {
            Color col = Color.Black;

            switch (ErrorType)
            {
                case ErrorReportType.ERROR_REPORT_TYPE_INFO: col = Color.White; break;
                case ErrorReportType.ERROR_REPORT_TYPE_WARNING: col = Color.Orange; break;
                case ErrorReportType.ERROR_REPORT_TYPE_CRITICAL: col = Color.Red; break;
            }

            return col;
        }
    }
}
