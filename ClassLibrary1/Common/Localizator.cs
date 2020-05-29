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
            words.Add("askReset", new List<string> { "Точно сбросить мир?", "Reset world?" });
            words.Add("confirmation", new List<string> { "Подтверждение", "Confirmation" });
            words.Add("loadZen", new List<string> { "Идет загрузка ZEN...", "ZEN is loading..." });
            words.Add("isLoading", new List<string> { "загружается...", "is loading..." });
            words.Add("compileZen", new List<string> { "Идет компиляция ZEN...", "Compiling ZEN..." });
            words.Add("compileLight", new List<string> { "Идет компиляция света...", "Compiling light..." });
            words.Add("savingZen", new List<string> { "Идет сохранение ZEN...", "Saving ZEN..." });
            words.Add("waynetMsg", new List<string> { "Ошибки WayNet не найдены.", "No Waynet errors found." });

            words.Add("loadZenTime", new List<string> { "Загрузка ZEN выполнена за", "Loading ZEN time..." });
            words.Add("saveZenTime", new List<string> { "Сохранение ZEN выполнено за", "Saving ZEN time..." });
            words.Add("loadMeshTime", new List<string> { "Загрузка MESH выполнена за", "Loading MESH time..." });
            words.Add("mergeZenTime", new List<string> { "Объединение ZEN выполнено за", "Merging ZEN time..." });



            words.Add("MENU_TOP_FILE", new List<string> { "Файл", "File" });
            words.Add("MENU_TOP_RESET", new List<string> { "Сбросить мир", "Reset world" });
            words.Add("MENU_TOP_EXIT", new List<string> { "Выход", "Exit" });
            words.Add("MENU_TOP_LANG", new List<string> { "Язык", "Language" });
            words.Add("MENU_TOP_HELP", new List<string> { "Помощь", "Help" });
            words.Add("MENU_TOP_SETTINGS", new List<string> { "Настройки", "Settings" });
            words.Add("MENU_TOP_WORLD", new List<string> { "Мир", "World" });
            words.Add("MENU_TOP_VIEW", new List<string> { "Вид", "View" });

            words.Add("MENU_TOP_OPENZEN", new List<string> { "Открыть ZEN...", "Open ZEN..." });
            words.Add("MENU_TOP_MESH", new List<string> { "Открыть MESH...", "Open MESH..." });
            words.Add("MENU_TOP_MERGE", new List<string> { "Объединить ZEN...", "Merge ZEN..." });
            words.Add("MENU_TOP_SAVEZEN", new List<string> { "Сохранить ZEN...", "Save ZEN..." });
            words.Add("MENU_TOP_ABOUT", new List<string> { "О программе", "About" });

            words.Add("MENU_TOP_CAMERA", new List<string> { "Камера", "Camera" });
            words.Add("MENU_TOP_CONTROLS", new List<string> { "Управление", "Controls" });
            words.Add("MENU_TOP_MISC", new List<string> { "Прочее", "Misc" });

        }


       




    }
}
