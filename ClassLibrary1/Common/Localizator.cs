﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SpacerUnion.Common
{

    public enum LangEnum
    {
        RU = 0,
        EN,
        DE,
        PL
    }


    public partial class Localizator
    {
        private static Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

        private static LangEnum curLang;

  

        public static void SetLanguage(LangEnum lang)
        {
            curLang = lang;
        }

        public static int GetCodePage()
        {
            int result = 1251;

            switch (curLang)
            {
                case LangEnum.RU: case LangEnum.EN: result = 1251; break;
                case LangEnum.PL: case LangEnum.DE: result = 1250; break;
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
                    result = words[key][0];
                }

                if (result.Length == 0)
                {
                    result = words[key][0];
                }

            }

            return result;
        }


        public static void UpdateInterface()
        {
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

            SpacerNET.vobList.UpdateLang();
            SpacerNET.soundWin.UpdateLang();
            SpacerNET.propWin.UpdateLang();
            SpacerNET.objectsWin.UpdateLang();
        }

        [DllExport]
        public static int GetLangString()
        {
            string key = Imports.Stack_PeekString();
            string value = Get(key);

            Imports.Stack_PushStringWide(value);

            return GetCodePage();
        }




    }
}
