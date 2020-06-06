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
            words.Add("MENU_TOP_VIEW_WAYNET", new List<string> { "Сетка Waynet", "Waynet", "", ""});
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
            words.Add("MENU_TOP_KEYSBINDS", new List<string> { "Сочетания клавиш", "Keys bindings", "", "" });

            words.Add("MENU_TOP_HOVER_WININFO", new List<string> { "Окно информации", "Information window", "", ""});
            words.Add("MENU_TOP_HOVER_WINOBJ", new List<string> { "Окно объектов", "Objects window", "", ""});
            words.Add("MENU_TOP_HOVER_WINSOUND", new List<string> { "Окно звуков", "Sounds window", "", ""});
            words.Add("MENU_TOP_HOVER_WINTREE", new List<string> { "Окно списка вобов", "All-vobs window", "", ""});
            words.Add("MENU_TOP_HOVER_WINPROPS", new List<string> { "Окно свойств", "Properties window", "", ""});
            words.Add("MENU_TOP_HOVER_WINVOBLIST", new List<string> { "Окно воб-лист", "VobList window", "", ""});



            words.Add("WIN_COMPLIGHT_TEXT", new List<string> { "Компиляция света", "Light compilation", "", ""});
            words.Add("WIN_COMPLIGHT_QUALITY", new List<string> { "Качество", "Quality", "", ""});
            words.Add("WIN_COMPLIGHT_COMPILEBUTTON", new List<string> { "Компилировать", "Compile", "", ""});

            words.Add("WIN_CANCEL_BUTTON", new List<string> { "Отмена", "Cancel", "", "" });
            words.Add("WIN_COMPLIGHT_CLOSEBUTTON", new List<string> { "Закрыть", "Close", "", ""});
            words.Add("WIN_COMPLIGHT_REGION", new List<string> { "Регион", "Region", "", ""});
            words.Add("WIN_COMPLIGHT_QUALITY0", new List<string> { "Только вершины", "Vertexes only", "", ""});
            words.Add("WIN_COMPLIGHT_QUALITY1", new List<string> { "Lightmaps (низкое)", "Lightmaps (low)", "", ""});
            words.Add("WIN_COMPLIGHT_QUALITY2", new List<string> { "Lightmaps (среднее)", "Lightmaps (medium)", "", ""});
            words.Add("WIN_COMPLIGHT_QUALITY3", new List<string> { "Lightmaps (высокое)", "Lightmaps (high)", "", ""});

            words.Add("WIN_COMPLIGHT_COMPILECHECKBOX", new List<string> { "Компилировать регион", "Compile region", "", ""});


            words.Add("WIN_COMPLIGHT_METERS", new List<string> { "метров", "meters", "", ""});
            words.Add("WIN_COMPLIGHT_AROUNDCAM", new List<string> { "вокруг камеры", "around the camera", "", ""});


            words.Add("WIN_COMPWORLD_TEXT", new List<string> { "Компиляция мира", "World compilation", "", "" });
            words.Add("WIN_COMPWORLD_LOCTYPE", new List<string> { "Тип локации", "World type", "", "" });

            words.Add("WIN_CAM_TEXT", new List<string> { "Камера", "Camera", "", "" });
            words.Add("WIN_CAM_CLOSEWIN", new List<string> { "Закрывать окно при переходе", "Close the window after the jump", "", "" });
            words.Add("WIN_CAM_GO", new List<string> { "Перейти", "Jump", "", "" });

            // UNION STRING
            words.Add("UNION_VOB_INSERTED", new List<string> { "Воб вставлен", "The vob inserted", "", "" });
            words.Add("UNION_VOB_AXIS_RESET", new List<string> { "Направление воба сброшено", "Vob axes were reset", "", "" });
            words.Add("CANT_APPLY_PARENT", new List<string> { "Данный тип воба перенести в родителя нельзя!", "Can't insert this vob type into a parent vob!", "", "" });
            words.Add("PARENT_ERROR_OCITEM", new List<string> { "oCItem не может быть родителем!", "oCItem can't be a parent!", "", "" });
            words.Add("PARENT_CHANGE_OK", new List<string> { "Родитель для воба изменен!", "The parent has been changed", "", "" });

            words.Add("VOB_COPY_OK", new List<string> { "Воб скопирован", "Vob was copied", "", "" });
            words.Add("VOB_CUT_OK", new List<string> { "Воб вырезан", "Vob was cut", "", "" });
            words.Add("VOB_NEAR_CAMERA", new List<string> { "Воб вставлен перед камерой", "Vob inserted in front of the camera", "", "" });


            words.Add("TOOL_TRANS", new List<string> { "Выбран инструмент перемещение", "Tool: moving", "", "" });
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
            words.Add("UNION_DATE_COMPILE", new List<string> { "Дата компиляции: ", "Compilation date: ", "", "" });


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


            //NEW

            words.Add("WIN_COMPLIGHT_NOWORLD", new List<string> { "Мир не загружен!", "World is not loaded!", "", "" });
            words.Add("WIN_COMPLIGHT_NOWORLDCOMPILED", new List<string> { "Мир не скомпилирован!", "World is not compiled!", "", "" });
            words.Add("WIN_COMPLIGHT_TIME", new List<string> { "Компиляция света выполнена за", "Light compilaton time", "", "" });
            words.Add("WIN_COMPLIGHT_QUALITY0_COMP", new List<string> { "Компиляция (только вершины)", "Compilation (Vertexes only)", "", "" });
            words.Add("WIN_COMPLIGHT_QUALITY1_COMP", new List<string> { "Компиляция Lightmaps (низкое)", "Compilation Lightmaps (low)", "", "" });
            words.Add("WIN_COMPLIGHT_QUALITY2_COMP", new List<string> { "Компиляция Lightmaps (среднее)", "Compilation Lightmaps (medium)", "", "" });
            words.Add("WIN_COMPLIGHT_QUALITY3_COMP", new List<string> { "Компиляция Lightmaps (высокое)", "Compilation Lightmaps (high)", "", "" });
            words.Add("WIN_COMPWORLD_ALREADY_COMP", new List<string> { "Мир уже скомпилирован!", "World is already compiled!", "", "" });
            words.Add("WIN_COMPWORLD_COMPILING", new List<string> { "Мир компилируется...", "World is being compiled!", "", "" });
            words.Add("WIN_COMPWORLD_TIME", new List<string> { "Компиляция мира выполнена за", "World compiling time", "", "" });
            words.Add("WIN_COMPWORLD_LEVELCOMPO", new List<string> { "Не забудьте удалить лишний zCVobLevelCompo!", "Don't forget to remove the spare zCVobLevelCompo", "", "" });

            words.Add("WIN_INFO_TITLE", new List<string> { "Окно информации", "Information window", "", "" });
            words.Add("WIN_INFO_CLEAR", new List<string> { "Очистить", "Clear", "", "" });
            words.Add("IS_SAVING", new List<string> { "сохраняется...", "is saving...", "", "" });
            words.Add("WIN_CAM_GETFROMBUFFER", new List<string> { "Взять из буфера", "Get from clipboard", "", "" });
            

            words.Add("BTN_APPLY", new List<string> { "Применить", "Apply", "", "" });
            words.Add("WIN_MISC_SET", new List<string> { "Прочие настройки", "Misc settings", "", "" });
            words.Add("checkBoxSetDatePrefix", new List<string> { "Добавлять префикс даты при сохранении зена", "Add DATE prefix to file when saving ZEN", "", "" });
            words.Add("checkBoxMiscExitAsk", new List<string> { "Подтверждать выход если открыт зен", "Confirm exit if ZEN is opened", "", "" });
            words.Add("checkBoxLastZenAuto", new List<string> { "Открывать последний ZEN автоматически", "Open last ZEN auto", "", "" });
            words.Add("checkBoxMiscFullPath", new List<string> { "Писать полный путь до ZEN в главном окне", "Show full path to ZEN file in main window", "", "" });



            

            words.Add("WIN_CONTROLSET_TEXT", new List<string> { "Настройки управления", "Controls setttings", "", "" });
            words.Add("WIN_CONTROLSET_TRANSSPEED", new List<string> { "Скорость перемещения: ", "Moving speed: ", "", "" });
            words.Add("WIN_CONTROLSET_ROTSPEED", new List<string> { "Скорость вращения: ", "Rotation speed: ", "", "" });

            words.Add("WIN_CONTROLSET_GROUP0", new List<string> { "Управление вобом", "Vob control", "", "" });
            words.Add("WIN_CONTROLSET_GROUP1", new List<string> { "Вставка воба", "Vob insertion", "", "" });
            words.Add("checkBoxInsertVob", new List<string> { "Вставлять воб на той же высоте", "Insert vob on the source height", "", "" });
            words.Add("checkBoxVobRotRandAngle", new List<string> { "Поворачивать воб на случайный угол", "Turn vob on a random angle", "", "" });
            words.Add("checkBoxVobInsertHierarchy", new List<string> { "Учитывать иерархию при копировании", "Use hierarchy when copying", "", "" });
            words.Add("labelRotWpFP", new List<string> { "Разворачивать WP/FP при вставке:", "Turn WP/FP when inserting:", "", "" });
            words.Add("radioButtonWPTurnNone", new List<string> { "Нет", "None ", "None", "" });
            words.Add("radioButtonWPTurnAgainst", new List<string> { "От камеры", "From the camera", "", "" });
            words.Add("radioButtonWPTurnOn", new List<string> { "На камеру", "At the camera", "", "" });



            words.Add("WIN_CONTROLCAM_TEXT", new List<string> { "Настройки камеры", "Camera settings", "", "" });
            words.Add("groupBoxCam", new List<string> { "Камера", "Camera", "", "" });
            words.Add("labelTrans", new List<string> { "Скорость полета", "Moving speed", "", "" });
            words.Add("labelRot", new List<string> { "Скорость повотора", "Rotation speed", "", "" });

            words.Add("groupBoxRange", new List<string> { "Прорисовка", "Rendering range", "", "" });
            words.Add("labelWorld", new List<string> { "Мир", "World", "", "" });
            words.Add("labelVobs", new List<string> { "Вобы", "Vobs", "", "" });
            words.Add("labelLimitFPS", new List<string> { "Ограничить FPS", "Limit FPS", "", "" });

            words.Add("groupBoxInfo", new List<string> { "Информация", "Information", "", "" });
            words.Add("checkBoxFPS", new List<string> { "Показывать FSP", "Show FPS", "", "" });
            words.Add("checkBoxTris", new List<string> { "Показывать кол-во рисуемых треугольников", "Show rendered triangles", "", "" });
            words.Add("checkBoxCamCoord", new List<string> { "Показывать координаты камеры", "Show camera coordinates", "", "" });

            words.Add("checkBoxVobs", new List<string> { "Показывать кол-во вобов", "Show vobs count", "", "" });
            words.Add("checkBoxWaypoints", new List<string> { "Показывать кол-во вейпоинтов", "Show waypoints count", "", "" });
            words.Add("checkBoxDistVob", new List<string> { "Показывать расстояние до выбранного воба", "Show distance to selected vob", "", "" });
            words.Add("checkBoxCameraHideWins", new List<string> { "Скрывать окна при полете камеры", "Hide windows when moving camera", "", "" });


            words.Add("WIN_KEYSBIND_TEXT", new List<string> { "Сочетания клавиш", "Keys binding", "", "" });
            words.Add("WIN_KEYSBIND_DESC", new List<string> { "Описание", "Description", "", "" });
            words.Add("WIN_KEYSBIND_BINDS", new List<string> { "Сочетание", "Bind", "", "" });



            words.Add("WIN_KEYSBIND_KEY_SPACE", new List<string> { "Пробел", "Space", "", "" });
            words.Add("WIN_KEYSBIND_KEY_ARROW_LEFT", new List<string> { "Стрелка влево", "Arrow left", "", "" });
            words.Add("WIN_KEYSBIND_KEY_ARROW_UP", new List<string> { "Стрелка вверх", "Arrow up", "", "" });
            words.Add("WIN_KEYSBIND_KEY_ARROW_RIGHT", new List<string> { "Стрелвка вправо", "Arrow right", "", "" });
            words.Add("WIN_KEYSBIND_KEY_ARROW_DOWN", new List<string> { "Стрелка вниз", "Arrow down", "", "" });


            words.Add("CAMERA_TRANS_FORWARD", new List<string> { "Камера (вперед)", "Camera (forward)", "", "" });
            words.Add("CAMERA_TRANS_BACKWARD", new List<string> { "Камера (назад)", "Camera (backward)", "", "" });
            words.Add("CAMERA_TRANS_RIGHT", new List<string> { "Камера (вправо)", "Camera (right)", "", "" });
            words.Add("CAMERA_TRANS_LEFT", new List<string> { "Камера (влево)", "Camera (left)", "", "" });
            words.Add("CAMERA_TRANS_UP", new List<string> { "Камера (вверх)", "Camera (up)", "", "" });
            words.Add("CAMERA_TRANS_DOWN", new List<string> { "Камера (вниз)", "Camera (down)", "", "" });
            words.Add("CAM_SPEED_X10", new List<string> { "Увеличить скорость полета камеры в 10 раз", "Increase camera moving speed x10", "", "" });
            words.Add("CAM_SPEED_MINUS_10", new List<string> { "Уменьшить скорость полета камеры в 10 раз", "Decrease camera moving speed x10", "", "" });
            words.Add("VOB_COPY", new List<string> { "Скопировать воб", "Copy vob", "", "" });
            words.Add("VOB_INSERT", new List<string> { "Вставить воб", "Insert vob", "", "" });
            words.Add("VOB_CUT", new List<string> { "Вырезать воб (смена родителя)", "Cut vob (parent change)", "", "" });
            words.Add("VOB_FLOOR", new List<string> { "Прижать воб к полу", "Floor the vob", "", "" });
            words.Add("VOB_RESET_AXIS", new List<string> { "Сбросить направление воба по осям", "Reset axes of the vob", "", "" });
            words.Add("VOB_DELETE", new List<string> { "Удалить воб", "Remove vob", "", "" });
            words.Add("VOB_TRANSLATE", new List<string> { "Инструмент перемещение", "Tool moving", "", "" });
            words.Add("VOB_ROTATE", new List<string> { "Инструмент вращение", "Tool rotating", "", "" });
            words.Add("WP_TOGGLE", new List<string> { "Переключить соединение между вейпоинтами", "Toggle connection between waypoints", "", "" });
            words.Add("VOB_DISABLE_SELECT", new List<string> { "Снять выделение с воба", "Unselect the vob", "", "" });
            words.Add("VOB_NEAR_CAM", new List<string> { "Переместить воб перед камерой", "Move vob in front of the camera", "", "" });
            words.Add("VOB_TRANS_FORWARD", new List<string> { "Перемещение воба (вперед)", "Moving vob (forward)", "", "" });
            words.Add("VOB_TRANS_BACKWARD", new List<string> { "Перемещение воба (назад)", "Moving vob (back)", "", "" });
            words.Add("VOB_TRANS_LEFT", new List<string> { "Перемещение воба (влево)", "Moving vob (left)", "", "" });
            words.Add("VOB_TRANS_RIGHT", new List<string> { "Перемещение воба (вправо)", "Moving vob (right)", "", "" });
            words.Add("VOB_TRANS_UP", new List<string> { "Перемещение воба (вверх)", "Moving vob (up)", "", "" });
            words.Add("VOB_TRANS_DOWN", new List<string> { "Перемещение воба (вниз)", "Moving vob (down)", "", "" });

            words.Add("VOB_SPEED_X10", new List<string> { "Увеличить скорость перемещения/вращения воба в 10 раз", "Increase vob moving/rotating speed x10", "", "" });
            words.Add("VOB_SPEED_MINUS_10", new List<string> { "Уменьшить скорость перемещения/вращения воба в 10 раз", "Decrease vob moving/rotating speed x10", "", "" });
            words.Add("VOB_ROT_VERT_RIGHT", new List<string> { "Вращение воба вокруг верт. оси (по часовой стрелке)", "Rotating vob around vertical axis (clockwise)", "", "" });
            words.Add("VOB_ROT_VERT_LEFT", new List<string> { "Вращение воба вокруг верт. оси (против часовой стрелки)", "Rotating vob around vertical axis (counterclock-wise)", "", "" });
            words.Add("VOB_ROT_FORWARD", new List<string> { "Вращение воба от себя", "Vob rotating from the camera", "", "" });
            words.Add("VOB_ROT_BACK", new List<string> { "Вращение воба на себя", "Vob rotating at the camera", "", "" });
            words.Add("VOB_ROT_RIGHT", new List<string> { "Вращение воба вправо", "Vob rotating to the right", "", "" });
            words.Add("VOB_ROT_LEFT", new List<string> { "Вращение воба влево", "Vob rotating to the left", "", "" });
            words.Add("VOBLIST_COLLECT", new List<string> { "Собрать вобы в окно Контейнер вобов", "Collect vobes in Vob-List window", "", "" });
            words.Add("WP_CREATEFAST", new List<string> { "Создать вейпоинт по кнопке", "Create waypoint", "", "" });
            words.Add("WIN_HIDEALL", new List<string> { "Скрыть все окна", "Hide all windows", "", "" });
            words.Add("OPEN_CONTAINER", new List<string> { "Открыть содержимое контейнера oCMobContainer", "Open oCMobContainer container", "", "" });



            words.Add("TOGGLE_BBOX", new List<string> { "Показать/Скрыть все BBox", "Show/Hide all the BBoxes", "", "" });
            words.Add("TOGGLE_INVIS", new List<string> { "Показать/Скрыть невидимые вобы", "Show/Hide invisible vobs", "", "" });
            words.Add("TOGGLE_VOBS", new List<string> { "Показать/Скрыть все вобы", "Show/Hide all vobs", "", "" });
            words.Add("TOGGLE_WAYNET", new List<string> { "Показать/Скрыть Waynet", "Show/Hide Waynet", "", "" });
            words.Add("TOGGLE_HELPERS", new List<string> { "Показать/Скрыть help-вобы", "Show/Hide help vobs", "", "" });


            words.Add("WIN_TREE_TITLE", new List<string> { "Список объектов", "Objects list window", "", "" });
            words.Add("buttonCollapse", new List<string> { "Свернуть все", "Collapse all", "", "" });
            words.Add("buttonExpand", new List<string> { "Развернуть все", "Expand all", "", "" });
            words.Add("buttonTreeSort", new List<string> { "Сортировать", "Sort", "", "" });


            words.Add("CONTEXTMENU_TREE_INSERT_VOBTREE_PARENT", new List<string> { "Вставить VobTree в выделенный воб", "Insert VobTree into the vob", "", "" });
            words.Add("CONTEXTMENU_TREE_INSERT_VOBTREE_GLOBAL", new List<string> { "Вставить VobTree глобально", "Insert VobTree globally", "", "" });
            words.Add("CONTEXTMENU_TREE_SAVE_VOBTREE", new List<string> { "Сохранить выделенный воб в VobTree", "Save vob as VobTree", "", "" });
            words.Add("CONTEXTMENU_TREE_REMOVE_VOB", new List<string> { "Удалить воб", "Remove the vob", "", "" });


            words.Add("WIN_VOBLIST_TITLE", new List<string> { "Контейнер вобов", "VobList window", "", "" });
            words.Add("labelVobType", new List<string> { "Тип воба", "Vob type", "", "" });
            words.Add("labelRadius", new List<string> { "Радиус поиска", "Search radius", "", "" });



            words.Add("WIN_SOUND_TITLE", new List<string> { "Звуки и музыка", "Sounds and music window", "", "" });
            words.Add("groupBoxSound", new List<string> { "Звуки", "Sounds", "", "" });
            words.Add("groupBoxMusic", new List<string> { "Музыка", "Music", "", "" });
            words.Add("buttonPlaySound", new List<string> { "Воспроизвести", "Play", "", "" });
            words.Add("labelAllSounds", new List<string> { "Все звуки. Кол-во:", "All sound. Count:", "", "" });
            words.Add("labelSndList", new List<string> { "Поиск по рег. выражению", "Search using regex", "", "" });
            words.Add("buttonOffMusic", new List<string> { "Отключить музыку", "Turn off music", "", "" });
            words.Add("buttonMusicOn", new List<string> { "Включить музыку", "Turn on music", "", "" });
            words.Add("checkBoxShutMusic", new List<string> { "Отключать музыку при загрузке", "Shut music after world loaded", "", "" });
            words.Add("labelMusicVolume", new List<string> { "Громкость", "Volume", "", "" });
            words.Add("buttonStopAllSounds", new List<string> { "Заглушить все звуки", "Turn off all sounds", "", "" });


            words.Add("NAME_ALREADY_EXISTS", new List<string> { "Такое имя уже существует!", "Turn off all sounds", "", "" });
            words.Add("Label_Backup", new List<string> { "Старое значение", "Turn off all sounds", "", "" });


            words.Add("WIN_PROPS_TITLE", new List<string> { "Окно свойств", "Properties window", "", "" });
            words.Add("buttonApplyOnVob", new List<string> { "Применить на вобе", "Apply on the vob", "", "" });
            words.Add("buttonFileOpen", new List<string> { "Файл", "File", "", "" });
            words.Add("buttonRestoreVobProp", new List<string> { "Восстановить", "Restore", "", "" });
            words.Add("buttonOpenContainer", new List<string> { "Контейнер", "Container", "", "" });
            words.Add("tabControlProps_0", new List<string> { "Редактирование", "Edit", "", "" });
            words.Add("tabControlProps_1", new List<string> { "BBox", "Bbox", "", "" });
            words.Add("tabControlProps_2", new List<string> { "Контейнер", "Container", "", "" });


            words.Add("groupBoxEditBbox", new List<string> { "Редактирование BBox", "Editing BBox", "", "" });

            
            words.Add("NO_ITEM_NAME", new List<string> { "Имя вещи не может быть пустым! Строка: ", "Item name is empty! Row: ", "", "" });
            words.Add("NO_ITEM_COUNT", new List<string> { "Кол-во итемов не может быть пустым! Строка: ", "Item count is empty! Row: ", "", "" });
            words.Add("ITEM_BAD_COUNT", new List<string> { "Некорректное число итемов. Строка: ", "Bad item count value! Row: ", "", "" });

            
            words.Add("groupBoxContainer", new List<string> { "Редактирование BBox", "Editing BBox", "", "" });
            words.Add("buttonClearItems", new List<string> { "Очистить все", "Clear all", "", "" });
            words.Add("buttonRowDelete", new List<string> { "Удалить текущую", "Remove current", "", "" });

            words.Add("ITEMS_COLUMN_INSTANCE", new List<string> { "Инстанция", "Instance", "", "" });
            words.Add("ITEMS_COLUMN_COUNT", new List<string> { "Кол-во", "Count", "", "" });


            /*
            this.Text = Localizator.Get("WIN_SOUND_TITLE");
            groupBoxSound.Text = Localizator.Get("groupBoxSound");
            groupBoxMusic.Text = Localizator.Get("groupBoxMusic");
            buttonPlaySound.Text = Localizator.Get("buttonPlaySound");
            buttonPlaySoundRegex.Text = Localizator.Get("buttonPlaySound");
            labelAllSounds.Text = Localizator.Get("labelAllSounds");
            labelSndList.Text = Localizator.Get("labelSndList");
            buttonOffMusic.Text = Localizator.Get("buttonOffMusic");
            buttonMusicOn.Text = Localizator.Get("buttonMusicOn");
            checkBoxShutMusic.Text = Localizator.Get("checkBoxShutMusic");

            labelMusicVolume.Text = Localizator.Get("labelMusicVolume");
            checkBoxShutMusic.Text = Localizator.Get("checkBoxShutMusic");
            groupBoxSoundsMisc.Text = Localizator.Get("groupBoxSound");
            buttonStopAllSounds.Text = Localizator.Get("buttonStopAllSounds");
            */



        }







    }
}
