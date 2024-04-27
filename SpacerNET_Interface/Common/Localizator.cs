using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;

namespace SpacerUnion.Common
{

    public enum LangEnum
    {
        RU = 0,
        EN,
        DE,
        PL,
        CZ
    }


    public partial class Localizator
    {
        private static Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

        private static LangEnum curLang;

        private static bool dontUpdateNext = false;


        public static void SetLanguage(LangEnum lang)
        {
            if (curLang == lang)
            {
               // dontUpdateNext = true;
            }
            curLang = lang;
            Imports.Extern_ClearLangStrings();
        }

        public static int GetCodePage()
        {
            int result = 1251;

            switch (curLang)
            {
                case LangEnum.RU: case LangEnum.EN: result = 1251; break;
                case LangEnum.PL: case LangEnum.DE: case LangEnum.CZ: result = 1250; break;
            }

            return result;
        }


        public static string Get(string key)
        {
            int langIndex = (int)curLang;

            string result = "";

            if (words.ContainsKey(key))
            {
                if (langIndex < words[key].Count && langIndex >= 0)
                {
                    result = words[key][(int)curLang];
                }
                else
                {
                    result = words[key][(int)LangEnum.EN];
                }

                if (result.Length == 0)
                {
                    result = words[key][(int)LangEnum.EN];
                }

            }
            else
            {
                //MessageBox.Show("Localizator. No key: " + key);
            }

            return result;
        }


        public static void UpdateInterface()
        {
            if (dontUpdateNext)
            {
                dontUpdateNext = false;
                return;
            }

            SpacerNET.form.UpdateLang();
            SpacerNET.comLightWin.UpdateLang();
            SpacerNET.compWorldWin.UpdateLang();
            SpacerNET.camCoordsWin.UpdateLang();
            SpacerNET.infoWin.UpdateLang();
            SpacerNET.miscSetWin.UpdateLang();
            SpacerNET.settingsControl.UpdateLang();
            SpacerNET.settingsCam.UpdateLang();
            SpacerNET.keysWin.UpdateLang();

            SpacerNET.objTreeWin.UpdateLang();

            if (ObjectsWin.renameWin != null)
            {
                ObjectsWin.renameWin.UpdateLang();
            }

            SpacerNET.vobList.UpdateLang();
            SpacerNET.soundWin.UpdateLang();
            SpacerNET.propWin.UpdateLang();
            SpacerNET.objectsWin.UpdateLang();
            SpacerNET.grassWin.UpdateLang();
            SpacerNET.macrosWin.UpdateLang();
            SpacerNET.matFilterWin.UpdateLang();
            SpacerNET.pfxWin.UpdateLang();
            SpacerNET.errorForm.UpdateLang();

        }

        [DllExport]
        public static int GetLangString()
        {
            string key = Imports.Stack_PeekString();
            string value = Get(key);


            //ConsoleEx.WriteLineGreen("Send string: " + value);
            Imports.Stack_PushStringWide(value);

            return GetCodePage();
        }




    }
}
