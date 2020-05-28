using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacerUnion.Common
{

    public enum LangEnum
    {
        RU = 0,
        EN
    }

    public class Localizator
    {
        private static Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

        private static LangEnum curLang;

        public static void SetLanguage(LangEnum lang)
        {
            curLang = lang;
        }

        public static string Get(string key)
        {
            if (words.ContainsKey(key))
            {
                return words[key][(int)curLang];
            }

            return "???UNKNOWN???";
        }


        public static void UpdateInterface()
        {
            UnionNET.form.UpdateLang();
        }


        public static void Init()
        {
            curLang = LangEnum.RU;
            //                                   RUSSIAN        ENGLISH 
            words.Add("appIsLoading", new List<string> { "Spacer.NET загружается...", "Spacer.NET is loading..." });
            words.Add("appIsReady", new List<string> { "Программа готова к работе!", "The program is ready!" });
            words.Add("askExit", new List<string> { "Точно выйти?", "Are you sure?" });
            words.Add("confirmation", new List<string> { "Подтверждение", "Confirmation" });
            words.Add("loadZen", new List<string> { "Идет загрузка ZEN...", "ZEN is loading..." });
            words.Add("isLoading", new List<string> { "загружается...", "is loading..." });




            words.Add("compileZen", new List<string> { "Идет компиляция ZEN...", "Compiling ZEN..." });
            words.Add("compileLight", new List<string> { "Идет компиляция света...", "Compiling light..." });
            words.Add("savingZen", new List<string> { "Идет сохранение ZEN...", "Saving ZEN..." });


            words.Add("MENU_TOP_FILE", new List<string> { "Файл", "File" });

            

        }


       




    }
}
