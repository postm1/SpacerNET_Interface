using System;
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
        }

        [DllExport]
        public static void GetLangString()
        {
            string key = Imports.Stack_PeekString();
            string value = Get(key);

            Imports.Stack_PushString(value);
        }

        public static void Init()
        {
            curLang = LangEnum.RU;

            /*
             * 
             *  Use the 3rd column for German, the 4th for Polish
             */
            //                                                      RUSSIAN                     ENGLISH         GERMAN POLISH   
            words.Add("appIsLoading", new List<string> { "Spacer.NET загружается...", "Spacer.NET is loading...", "", ""});
            words.Add("appIsReady", new List<string> { "Программа готова к работе!", "The program is ready!", "", ""});
            words.Add("askExit", new List<string> { "Точно выйти?", "Are you sure?", "", ""});
            words.Add("askReset", new List<string> { "Точно сбросить мир?", "Reset world?", "", ""});
            words.Add("confirmation", new List<string> { "Подтверждение", "Confirmation", "", ""});
            words.Add("loadZen", new List<string> { "Идет загрузка ZEN...", "ZEN is loading...", "", ""});
            words.Add("isLoading", new List<string> { "загружается...", "is loading...", "", ""});
            words.Add("compileZen", new List<string> { "Идет компиляция ZEN...", "Compiling ZEN...", "", ""});
            words.Add("compileLight", new List<string> { "Идет компиляция света...", "Compiling light...", "", ""});
            words.Add("savingZen", new List<string> { "Идет сохранение ZEN...", "Saving ZEN...", "", ""});
            words.Add("waynetMsg", new List<string> { "Ошибки WayNet не найдены.", "No Waynet errors found.", "", ""});

            words.Add("loadZenTime", new List<string> { "Загрузка ZEN выполнена за", "Loading ZEN time...", "", ""});
            words.Add("saveZenTime", new List<string> { "Сохранение ZEN выполнено за", "Saving ZEN time...", "", ""});
            words.Add("loadMeshTime", new List<string> { "Загрузка MESH выполнена за", "Loading MESH time...", "", ""});
            words.Add("mergeZenTime", new List<string> { "Объединение ZEN выполнено за", "Merging ZEN time...", "", ""});



            words.Add("MENU_TOP_FILE", new List<string> { "Файл", "File", "", ""});
            words.Add("MENU_TOP_RESET", new List<string> { "Сбросить мир", "Reset world", "", ""});
            words.Add("MENU_TOP_EXIT", new List<string> { "Выход", "Exit", "", ""});
            words.Add("MENU_TOP_LANG", new List<string> { "Язык", "Language", "", ""});
            words.Add("MENU_TOP_HELP", new List<string> { "Помощь", "Help", "", ""});
            words.Add("MENU_TOP_SETTINGS", new List<string> { "Настройки", "Settings", "", ""});
            words.Add("MENU_TOP_WORLD", new List<string> { "Мир", "World", "", ""});
            words.Add("MENU_TOP_VIEW", new List<string> { "Вид", "View", "", ""});

            words.Add("MENU_TOP_OPENZEN", new List<string> { "Открыть ZEN...", "Open ZEN...", "", ""});
            words.Add("MENU_TOP_MESH", new List<string> { "Открыть MESH...", "Open MESH...", "", ""});
            words.Add("MENU_TOP_MERGE", new List<string> { "Объединить ZEN...", "Merge ZEN...", "", ""});
            words.Add("MENU_TOP_SAVEZEN", new List<string> { "Сохранить ZEN...", "Save ZEN...", "", ""});
            words.Add("MENU_TOP_ABOUT", new List<string> { "О программе", "About", "", ""});

            words.Add("MENU_TOP_CAM", new List<string> { "Камера", "Camera", "", ""});
            words.Add("MENU_TOP_CONTROLS", new List<string> { "Управление", "Controls", "", ""});
            words.Add("MENU_TOP_MISC", new List<string> { "Прочее", "Misc", "", ""});

            
            words.Add("MENU_TOP_VIEW_SHOW", new List<string> { "Показать", "Show", "", ""});
            words.Add("MENU_TOP_VIEW_VOBS", new List<string> { "Вобы", "Vobs", "", ""});
            words.Add("MENU_TOP_VIEW_WAYNET", new List<string> { "Сетка WayNet", "Waynet", "", ""});
            words.Add("MENU_TOP_VIEW_HELPER", new List<string> { "Help-вобы", "Help vobs", "", ""});

            words.Add("MENU_TOP_VIEW_BBOX", new List<string> { "Показать все BBox", "Show all the BBoxes", "", ""});
            words.Add("MENU_TOP_VIEW_INVIS", new List<string> { "Показать невидимые вобы", "Show invisible vobs", "", ""});

            
            words.Add("MENU_TOP_COMPILE_LIGHT", new List<string> { "Компиляция света", "Compile light", "", ""});
            words.Add("MENU_TOP_COMPILE_WORLD", new List<string> { "Компиляция мира", "Compile world", "", ""});


            words.Add("MENU_TOP_CAM_ZERO", new List<string> { "Прыгнуть на 000 координаты", "Jump to 000 coordinates", "", ""});
            
            words.Add("MENU_TOP_CAM_COORDS", new List<string> { "Ввести координаты", "Enter coordinates", "", ""});
            words.Add("MENU_TOP_DAYTIME", new List<string> { "Время суток", "Day time", "", ""});
            words.Add("MENU_TOP_MORN", new List<string> { "Утро (07:00)", "Morning (07:00)", "", ""});
            
            
            words.Add("MENU_TOP_NOON", new List<string> { "Обед (12:00)", "Midday (12:00)", "", ""});
            words.Add("MENU_TOP_AFTERNOON", new List<string> { "Вечер (17:00)", "Evening (17:00)", "", ""});
            words.Add("MENU_TOP_NIGHT", new List<string> { "Ночь (00:00)", "Night (00:00)", "", ""});
            words.Add("MENU_TOP_ANALYSE_WAYNET", new List<string> { "Анализ WayNet", "Analyze Waynet", "", ""});
            words.Add("MENU_TOP_PLAY_THE_GAME", new List<string> { "Играть за героя", "Play the hero", "", ""});

            
            words.Add("MENU_TOP_HOVER_WININFO", new List<string> { "Окно информации", "Information window", "", ""});
            words.Add("MENU_TOP_HOVER_WINOBJ", new List<string> { "Окно объектов", "Objects window", "", ""});
            words.Add("MENU_TOP_HOVER_WINSOUND", new List<string> { "Окно звуков", "Sounds window", "", ""});
            words.Add("MENU_TOP_HOVER_WINTREE", new List<string> { "Окно списка вобов", "All-vobs window", "", ""});
            words.Add("MENU_TOP_HOVER_WINPROPS", new List<string> { "Окно свойств", "Properties window", "", ""});
            words.Add("MENU_TOP_HOVER_WINVOBLIST", new List<string> { "Окно воб-лист", "VobList window", "", ""});



            words.Add("WIN_COMPLIGHT_TEXT", new List<string> { "Компиляция света", "Light compilation", "", ""});
            words.Add("WIN_COMPLIGHT_QUALITY", new List<string> { "Качество", "Quality", "", ""});
            words.Add("WIN_COMPLIGHT_COMPILEBUTTON", new List<string> { "Компилировать", "Compile", "", ""});


            words.Add("WIN_COMPLIGHT_CLOSEBUTTON", new List<string> { "Закрыть", "Close", "", ""});
            words.Add("WIN_COMPLIGHT_REGION", new List<string> { "Регион", "Region", "", ""});
            words.Add("WIN_COMPLIGHT_QUALITY0", new List<string> { "Только вершины", "Vertexes only", "", ""});
            words.Add("WIN_COMPLIGHT_QUALITY1", new List<string> { "Lightmaps (низкое)", "Lightmaps (low)", "", ""});
            words.Add("WIN_COMPLIGHT_QUALITY2", new List<string> { "Lightmaps (среднее)", "Lightmaps (medium)", "", ""});
            words.Add("WIN_COMPLIGHT_QUALITY3", new List<string> { "Lightmaps (высокое)", "Lightmaps (high)", "", ""});

            words.Add("WIN_COMPLIGHT_COMPILECHECKBOX", new List<string> { "Компилировать регион", "Compile region", "", ""});


            words.Add("WIN_COMPLIGHT_METERS", new List<string> { "метров", "meters", "", ""});
            words.Add("WIN_COMPLIGHT_AROUNDCAM", new List<string> { "вокруг камеры", "around the camera", "", ""});
            words.Add("MENU_TOP_KEYSBINDS", new List<string> { "Сочетания клавиш", "Keys bindings", "", "" });



            // UNION STRING
            words.Add("UNION_VOB_INSERTED", new List<string> { "Воб вставлен", "The vob inserted", "", "" });
            words.Add("UNION_VOB_AXIS_RESET", new List<string> { "Направление воба сброшено", "Vob axes were reset", "", "" });
            words.Add("CANT_APPLY_PARENT", new List<string> { "Данный тип воба перенести в родителя нельзя!", "Can't insert this vob type into a parent vob!", "", "" });
            words.Add("PARENT_ERROR_OCITEM", new List<string> { "oCItem не может быть родителем!", "oCItem can't be a parent!", "", "" });
            words.Add("PARENT_CHANGE_OK", new List<string> { "Родитель для воба изменен!", "The parent has been changed", "", "" });

            words.Add("VOB_COPY_OK", new List<string> { "Воб скопирован", "Vob was copied", "", "" });
            words.Add("VOB_CUT", new List<string> { "Воб вырезан", "Vob was cut", "", "" });
            words.Add("VOB_NEAR_CAMERA", new List<string> { "Воб вставлен перед камерой", "Vob inserted in front of the camera", "", "" });


            words.Add("TOOL_TRANS", new List<string> { "Выбран инструмент перемещение", "Tool: translation", "", "" });
            words.Add("TOOL_ROT", new List<string> { "Выбран инструмент вращение", "Tool: rotation", "", "" });
            words.Add("TOOL_UNSELECT", new List<string> { "Выделение воба снято", "Vob selection cancel", "", "" });
            words.Add("TOOL_FLOOR", new List<string> { "Прижимание воба к полу", "Try to floor the vob", "", "" });

            words.Add("UNION_LIGHT_RAD_INC", new List<string> { "Радиус освещения увеличен", "Light radius increased", "", "" });
            words.Add("UNION_LIGHT_RAD_DEC", new List<string> { "Радиус освещения уменьшен", "Light radius decreased", "", "" });

            words.Add("UNION_LIGHT_RAD_ZERO", new List<string> { "Радиус освещения сброшен в 0", "Light radius set to 0", "", "" });
            words.Add("UNION_MESH_LOADED", new List<string> { "Меш загружен", "Mesh is loaded", "", "" });
            words.Add("UNION_MESH_READY", new List<string> { "Меш и вобы объединены. Скомпилируйте мир", "Mesh and vobs were merged. Compile the world", "", "" });

            words.Add("UNION_EDITOR", new List<string> { "Редактор для ZenGin", "Editor for ZenGin", "", "" });
            words.Add("UNION_TEAM", new List<string> { "Команда разработки: Liker & Haart & Saturas & Gratt", "Dev team: Liker & Haart & Saturas & Gratt", "", "" });
            words.Add("UNION_DATE_COMPILE", new List<string> { "Дата компиляции: ", "Compilation date", "", "" });


            words.Add("UNION_RESOLUTION", new List<string> { "Разрешение рендера: ", "Render resolution", "", "" });
            words.Add("UNION_NOWORLD", new List<string> { "Мир не загружен", "World is not loaded", "", "" });
            words.Add("UNION_CANT_ABSTRACT", new List<string> { "Не могу создать объект абстрактного класса!", "Can't create a vob of an abstract class", "", "" });

            words.Add("ENTER_NAME", new List<string> { "Введите имя воба!", "Enter the name!", "", "" });
            words.Add("CANT_DELETE_LEVELCOMPO", new List<string> { "Не могу удалить zCVobLevelCompo!", "Can't remove zCVobLevelCompo!", "", "" });


            words.Add("CANT_DELETE_CAM", new List<string> { "Не могу удалить основную камеру!", "Can't remove the camera!", "", "" });
            words.Add("UNION_NO_WAYPOINT", new List<string> { "Вейпоинт не выбран!", "No waypoint selected!", "", "" });
            words.Add("UNION_NO_WAYPOINT_TEMPLATE", new List<string> { "Шаблон имени вейпоинта пуст!", "Waypoint name template is empty!", "", "" });
            words.Add("UNION_WP_INSERT", new List<string> { "Вейпоинт вставлен: ", "Waypoint inserted: ", "", "" });
            words.Add("UNION_WORLD_ONCOMPILE", new List<string> { "Мир скомпилирован. Не забудьте удалить лишний zCVobLevelCompo", "World has been compiled. Don't forget to remove the spare zCVobLevelCompo", "", "" });
            words.Add("UNION_VOBTREE_SAVE", new List<string> { "VobTree сохранен!", "VobTree saved!", "", "" });


            words.Add("UNION_VOBTREE_INSERT", new List<string> { "VobTree вставлен!", "VobTree inserted!", "", "" });
            words.Add("UNION_SHOW_TRIS", new List<string> { "Кол-во треугольников: ", "Tris amount: ", "", "" });
            words.Add("UNION_CAM_POS", new List<string> { "Позиция камеры: (", "Camera pos: ", "", "" });
            words.Add("UNION_VOB_COUNT", new List<string> { "Кол-во вобов: ", "Vobs amount: ", "", "" });
            words.Add("UNION_WP_COUNT", new List<string> { "Кол-во вейпоинтов: ", "Waypoint amount: ", "", "" });
            words.Add("UNION_DIST", new List<string> { "Дистанция: ", "Distance: ", "", "" });
        }


       




    }
}
