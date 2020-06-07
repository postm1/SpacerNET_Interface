using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacerUnion.Common
{
    public partial class Localizator
    {
        public static void Init()
        {
            curLang = LangEnum.RU;

            //For special symbols use @ before string like @"someString"
            /*
             * 
             *  Use the 3rd column for German, the 4th for Polish
             *  For special symbols use @ before string like @"someString"
             */
            // RUSSIAN, ENGLISH, GERMAN, POLISH                                            

            words.Add("appIsLoading", new List<string> { "Spacer.NET загружается...", "Spacer.NET is loading...", "", "Spacer.NET trwa ładowanie..." });
            words.Add("appIsReady", new List<string> { "Программа готова к работе!", "The program is ready!", "", "Program jest gotowy do pracy!" });
            words.Add("askExit", new List<string> { "Точно выйти?", "Are you sure?", "", "Czy jesteś pewny?" });
            words.Add("askReset", new List<string> { "Точно сбросить мир?", "Reset world?", "", "Zresetować świat?" });
            words.Add("confirmation", new List<string> { "Подтверждение", "Confirmation", "", "Potwierdzenie" });
            words.Add("loadZen", new List<string> { "Идет загрузка ZEN...", "ZEN is loading...", "", "ZEN jest ładowany..." });
            words.Add("isLoading", new List<string> { "загружается...", "is loading...", "", " jest ładowany..." });
            words.Add("compileZen", new List<string> { "Идет компиляция ZEN...", "Compiling ZEN...", "", @"Kompilowanie ZEN'a..." });
            words.Add("compileLight", new List<string> { "Идет компиляция света...", "Compiling light...", "", "Kompilowanie światła..." });
            words.Add("savingZen", new List<string> { "Идет сохранение ZEN...", "Saving ZEN...", "", @"Zapisywanie ZEN'a..." });
            words.Add("waynetMsg", new List<string> { "Ошибки WayNet не найдены.", "No Waynet errors found.", "", "Nie znaleziono błędów Waynetu." });

            words.Add("loadZenTime", new List<string> { "Загрузка ZEN выполнена за", "Loading ZEN time...", "", @"Czas wczytywania ZEN'a..." });
            words.Add("saveZenTime", new List<string> { "Сохранение ZEN выполнено за", "Saving ZEN time...", "", @"Czas zapisywania ZEN'a..." });
            words.Add("loadMeshTime", new List<string> { "Загрузка MESH выполнена за", "Loading MESH time...", "", @"Czas wczytywania MESH'a..." });
            words.Add("mergeZenTime", new List<string> { "Объединение ZEN выполнено за", "Merging ZEN time...", "", @"Czas zapisywania MESH'a..." });



            words.Add("MENU_TOP_FILE", new List<string> { "Файл", "File", "", "Plik" });
            words.Add("MENU_TOP_RESET", new List<string> { "Сбросить мир", "Reset world", "", "Zresetuj świat" });
            words.Add("MENU_TOP_EXIT", new List<string> { "Выход", "Exit", "", "Zakończ" });
            words.Add("MENU_TOP_LANG", new List<string> { "Язык", "Language", "", "Język" });
            words.Add("MENU_TOP_HELP", new List<string> { "Помощь", "Help", "", "Pomoc" });
            words.Add("MENU_TOP_SETTINGS", new List<string> { "Настройки", "Settings", "", "Opcje" });
            words.Add("MENU_TOP_WORLD", new List<string> { "Мир", "World", "", "Świat" });
            words.Add("MENU_TOP_VIEW", new List<string> { "Вид", "View", "", "Widok" });

            words.Add("MENU_TOP_OPENZEN", new List<string> { "Открыть ZEN...", "Open ZEN...", "", "Otwórz ZEN..." });
            words.Add("MENU_TOP_MESH", new List<string> { "Открыть MESH...", "Open MESH...", "", "Otwórz MESH..." });
            words.Add("MENU_TOP_MERGE", new List<string> { "Объединить ZEN...", "Merge ZEN...", "", "Połącz ZEN..." });
            words.Add("MENU_TOP_SAVEZEN", new List<string> { "Сохранить ZEN...", "Save ZEN...", "", "Zapisz ZEN..." });
            words.Add("MENU_TOP_ABOUT", new List<string> { "О программе", "About", "", "O programie" });

            words.Add("MENU_TOP_CAM", new List<string> { "Камера", "Camera", "", "Kamera" });
            words.Add("MENU_TOP_CONTROLS", new List<string> { "Управление", "Controls", "", "Sterowanie" });
            words.Add("MENU_TOP_MISC", new List<string> { "Прочее", "Misc", "", "Różne" });


            words.Add("MENU_TOP_VIEW_SHOW", new List<string> { "Показать", "Show", "", "Pokaż" });
            words.Add("MENU_TOP_VIEW_VOBS", new List<string> { "Вобы", "Vobs", "", "Voby" });
            words.Add("MENU_TOP_VIEW_WAYNET", new List<string> { "Сетка Waynet", "Waynet", "", "Waynet" });
            words.Add("MENU_TOP_VIEW_HELPER", new List<string> { "Help-вобы", "Help vobs", "", "Pomocnicze Voby" });

            words.Add("MENU_TOP_VIEW_BBOX", new List<string> { "Показать все BBox", "Show all the BBoxes", "", "Pokaż wszystkie BBoxy" });
            words.Add("MENU_TOP_VIEW_INVIS", new List<string> { "Показать невидимые вобы", "Show invisible vobs", "", "Pokaż niewidzialne Voby" });


            words.Add("MENU_TOP_COMPILE_LIGHT", new List<string> { "Компиляция света", "Compile light", "", "Kompiluj światło" });
            words.Add("MENU_TOP_COMPILE_WORLD", new List<string> { "Компиляция мира", "Compile world", "", "Kompiluj świat" });


            words.Add("MENU_TOP_CAM_ZERO", new List<string> { "Прыгнуть на 000 координаты", "Jump to 000 coordinates", "", "Przeskocz do koordynatów: 000" });

            words.Add("MENU_TOP_CAM_COORDS", new List<string> { "Ввести координаты", "Enter coordinates", "", "Wpisz koordynaty" });
            words.Add("MENU_TOP_DAYTIME", new List<string> { "Время суток", "Day time", "", "Pora dnia" });
            words.Add("MENU_TOP_MORN", new List<string> { "Утро (07:00)", "Morning (07:00)", "", "Poranek (07:00)" });


            words.Add("MENU_TOP_NOON", new List<string> { "Обед (12:00)", "Midday (12:00)", "", "Południe (12:00)" });
            words.Add("MENU_TOP_AFTERNOON", new List<string> { "Вечер (17:00)", "Evening (17:00)", "", "Wieczór (17:00)" });
            words.Add("MENU_TOP_NIGHT", new List<string> { "Ночь (00:00)", "Night (00:00)", "", "Noc(00:00)" });
            words.Add("MENU_TOP_ANALYSE_WAYNET", new List<string> { "Анализ WayNet", "Analyze Waynet", "", "Analizuj Waynet" });
            words.Add("MENU_TOP_PLAY_THE_GAME", new List<string> { "Играть за героя", "Play the hero", "", "Zagraj bohaterem" });
            words.Add("MENU_TOP_KEYSBINDS", new List<string> { "Сочетания клавиш", "Keys bindings", "", "Przypisania klawisze" });

            words.Add("MENU_TOP_HOVER_WININFO", new List<string> { "Окно информации", "Information window", "", "Okno informacji" });
            words.Add("MENU_TOP_HOVER_WINOBJ", new List<string> { "Окно объектов", "Objects window", "", "Okno obiektów" });
            words.Add("MENU_TOP_HOVER_WINSOUND", new List<string> { "Окно звуков", "Sounds window", "", "Okno dźwięków" });
            words.Add("MENU_TOP_HOVER_WINTREE", new List<string> { "Окно списка вобов", "All-vobs window", "", "Okno wszystkich obiektów" });
            words.Add("MENU_TOP_HOVER_WINPROPS", new List<string> { "Окно свойств", "Properties window", "", "Okno właściwości" });
            words.Add("MENU_TOP_HOVER_WINVOBLIST", new List<string> { "Окно воб-лист", "VobList window", "", "Okno listy vobów" });



            words.Add("WIN_COMPLIGHT_TEXT", new List<string> { "Компиляция света", "Light compilation", "", "Kompilacja światła" });
            words.Add("WIN_COMPLIGHT_QUALITY", new List<string> { "Качество", "Quality", "", "Jakość" });
            words.Add("WIN_COMPLIGHT_COMPILEBUTTON", new List<string> { "Компилировать", "Compile", "", "Kompiluj" });

            words.Add("WIN_CANCEL_BUTTON", new List<string> { "Отмена", "Cancel", "", "Anuluj" });
            words.Add("WIN_COMPLIGHT_CLOSEBUTTON", new List<string> { "Закрыть", "Close", "", "Zamknij" });
            words.Add("WIN_COMPLIGHT_REGION", new List<string> { "Регион", "Region", "", "Region" });
            words.Add("WIN_COMPLIGHT_QUALITY0", new List<string> { "Только вершины", "Vertexes only", "", "Tylko vertexy" });
            words.Add("WIN_COMPLIGHT_QUALITY1", new List<string> { "Lightmaps (низкое)", "Lightmaps (low)", "", "Lightmapa (niska)" });
            words.Add("WIN_COMPLIGHT_QUALITY2", new List<string> { "Lightmaps (среднее)", "Lightmaps (medium)", "", "Lightmapa (średnia)" });
            words.Add("WIN_COMPLIGHT_QUALITY3", new List<string> { "Lightmaps (высокое)", "Lightmaps (high)", "", "Lightmapa (wysoka)" });

            words.Add("WIN_COMPLIGHT_COMPILECHECKBOX", new List<string> { "Компилировать регион", "Compile region", "", "Kompiluj region" });


            words.Add("WIN_COMPLIGHT_METERS", new List<string> { "метров", "meters", "", "metry" });
            words.Add("WIN_COMPLIGHT_AROUNDCAM", new List<string> { "вокруг камеры", "around the camera", "", "na około kamery" });


            words.Add("WIN_COMPWORLD_TEXT", new List<string> { "Компиляция мира", "World compilation", "", "Kompilacja świata" });
            words.Add("WIN_COMPWORLD_LOCTYPE", new List<string> { "Тип локации", "World type", "", "Typ świata" });

            words.Add("WIN_CAM_TEXT", new List<string> { "Камера", "Camera", "", "Kamera" });
            words.Add("WIN_CAM_CLOSEWIN", new List<string> { "Закрывать окно при переходе", "Close the window after the jump", "", "Zamknij okno po skoku" });
            words.Add("WIN_CAM_GO", new List<string> { "Перейти", "Jump", "", "Skok" });

            // UNION STRING
            words.Add("UNION_VOB_INSERTED", new List<string> { "Воб вставлен", "The vob inserted", "", "Vob został wklejony" });
            words.Add("UNION_VOB_AXIS_RESET", new List<string> { "Направление воба сброшено", "Vob axes were reset", "", "Osie Voba zostały zresetowane" });
            words.Add("CANT_APPLY_PARENT", new List<string> { "Данный тип воба перенести в родителя нельзя!", "Can't insert this vob type into a parent vob!", "", "Nie można dodać tego typu Voba jako nadrzędnego." });
            words.Add("PARENT_ERROR_OCITEM", new List<string> { "oCItem не может быть родителем!", "oCItem can't be a parent!", "", "oCItem nie może być nadrzędny!" });
            words.Add("PARENT_CHANGE_OK", new List<string> { "Родитель для воба изменен!", "The parent has been changed", "", "Vob nadrzędny został zmieniony" });

            words.Add("VOB_COPY_OK", new List<string> { "Воб скопирован", "Vob was copied", "", "Vob został skopiowany" });
            words.Add("VOB_CUT_OK", new List<string> { "Воб вырезан", "Vob was cut", "", "Vob został wycięty" });
            words.Add("VOB_NEAR_CAMERA", new List<string> { "Воб вставлен перед камерой", "Vob inserted in front of the camera", "", "Vob został stworzony na przeciwko kamery" });


            words.Add("TOOL_TRANS", new List<string> { "Выбран инструмент перемещение", "Tool: translation", "", "Narzędzie: Przemieszczanie" });
            words.Add("TOOL_ROT", new List<string> { "Выбран инструмент вращение", "Tool: rotation", "", "Narzędzie: Rotacja" });
            words.Add("TOOL_UNSELECT", new List<string> { "Выделение воба снято", "Vob selection cancel", "", "Wybranie voba zostało anulowane" });
            words.Add("TOOL_FLOOR", new List<string> { "Прижимание воба к полу", "Try to floor the vob", "", "Spróbuj postawić Voba na podłodze" });

            words.Add("UNION_LIGHT_RAD_INC", new List<string> { "Радиус освещения увеличен", "Light radius increased", "", "Promień światła został zwiększony" });
            words.Add("UNION_LIGHT_RAD_DEC", new List<string> { "Радиус освещения уменьшен", "Light radius decreased", "", "Promień światła został zmniejszony" });

            words.Add("UNION_LIGHT_RAD_ZERO", new List<string> { "Радиус освещения сброшен в 0", "Light radius set to 0", "", "Promień światła został ustawiony na 0" });
            words.Add("UNION_MESH_LOADED", new List<string> { "Меш загружен", "Mesh is loaded", "", "Mesh jest załadowany" });
            words.Add("UNION_MESH_READY", new List<string> { "Меш и вобы объединены. Скомпилируйте мир", "Mesh and vobs were merged. Compile the world", "", "Mesh i voby zostały połączone. Skompiluj świat." });
            words.Add("UNION_EDITOR", new List<string> { "Редактор для ZenGin", "Editor for ZenGin", "", "Edytor dla ZenGine" });
            words.Add("UNION_TEAM", new List<string> { "Команда разработки: Liker & Haart & Saturas & Gratt", "Dev team: Liker & Haart & Saturas & Gratt", "", "Deweloperzy: Liker & Haart & Saturas & Gratt" });
            words.Add("UNION_DATE_COMPILE", new List<string> { "Дата компиляции: ", "Compilation date: ", "", "Data kompilacji: " });
            words.Add("UNION_RESOLUTION", new List<string> { "Разрешение рендера: ", "Render resolution: ", "", "Rozdzielczość renderowania: " });
            words.Add("UNION_NOWORLD", new List<string> { "Мир не загружен", "World is not loaded", "", "Świat nie został wczytany." });
            words.Add("UNION_CANT_ABSTRACT", new List<string> { "Не могу создать объект абстрактного класса!", "Can't create a vob of an abstract class", "", "Nie można utworzyć voba klasy abstrakcyjnej" });
            words.Add("ENTER_NAME", new List<string> { "Введите имя воба!", "Enter the name!", "", "Podaj nazwę!" });
            words.Add("CANT_DELETE_LEVELCOMPO", new List<string> { "Не могу удалить zCVobLevelCompo!", "Can't remove zCVobLevelCompo!", "", "Nie można usunąć zCVobLevelCompo!" });
            words.Add("CANT_DELETE_CAM", new List<string> { "Не могу удалить основную камеру!", "Can't remove the camera!", "", "Nie można usunąć kamery!" });
            words.Add("UNION_NO_WAYPOINT", new List<string> { "Вейпоинт не выбран!", "No waypoint selected!", "", @"Nie wybrano Waypoint'a!" });
            words.Add("UNION_NO_WAYPOINT_TEMPLATE", new List<string> { "Шаблон имени вейпоинта пуст!", "Waypoint name template is empty!", "", "Nazwa szablonu Waypointów jest pusta!" });
            words.Add("UNION_WP_INSERT", new List<string> { "Вейпоинт вставлен: ", "Waypoint inserted: ", "", "Dodano Waypoint: " });
            words.Add("UNION_WORLD_ONCOMPILE", new List<string> { "Мир скомпилирован.", "World has been compiled.", "", "Świat został skompilowany." });
            words.Add("UNION_VOBTREE_SAVE", new List<string> { "VobTree сохранен!", "VobTree saved!", "", "Drzewko vobów zostało zapisane!" });
            words.Add("UNION_VOBTREE_INSERT", new List<string> { "VobTree вставлен!", "VobTree inserted!", "", "Dodano drzewko vobów!" });
            words.Add("UNION_SHOW_TRIS", new List<string> { "Кол-во треугольников: ", "Tris amount: ", "", "Ilość tri: " });
            words.Add("UNION_CAM_POS", new List<string> { "Позиция камеры: (", "Camera pos: ", "", "Pozycja kamery: " });
            words.Add("UNION_VOB_COUNT", new List<string> { "Кол-во вобов: ", "Vobs amount: ", "", "Ilość vobów: " });
            words.Add("UNION_WP_COUNT", new List<string> { "Кол-во вейпоинтов: ", "Waypoint amount: ", "", "Ilość Waypointów: " });
            words.Add("UNION_DIST", new List<string> { "Дистанция: ", "Distance: ", "", "Dystans: " });
            //NEW
            words.Add("WIN_COMPLIGHT_NOWORLD", new List<string> { "Мир не загружен!", "World is not loaded!", "", "Świat nie jest załadowany!" });
            words.Add("WIN_COMPLIGHT_NOWORLDCOMPILED", new List<string> { "Мир не скомпилирован!", "World is not compiled!", "", "Świat nie jest skompilowany!" });
            words.Add("WIN_COMPLIGHT_TIME", new List<string> { "Компиляция света выполнена за", "Light compilaton time", "", "Czas kompilacji światła" });
            words.Add("WIN_COMPLIGHT_QUALITY0_COMP", new List<string> { "Компиляция (только вершины)", "Compilation (Vertexes only)", "", "Kompilacja (Tylko Vertexy)" });
            words.Add("WIN_COMPLIGHT_QUALITY1_COMP", new List<string> { "Компиляция Lightmaps (низкое)", "Compilation Lightmaps (low)", "", "Kompilacja Lightmap (niskie)" });
            words.Add("WIN_COMPLIGHT_QUALITY2_COMP", new List<string> { "Компиляция Lightmaps (среднее)", "Compilation Lightmaps (medium)", "", "Kompilacja Lightmap (średnie)" });
            words.Add("WIN_COMPLIGHT_QUALITY3_COMP", new List<string> { "Компиляция Lightmaps (высокое)", "Compilation Lightmaps (high)", "", "Kompilacja Lightmap (wysokie)" });
            words.Add("WIN_COMPWORLD_ALREADY_COMP", new List<string> { "Мир уже скомпилирован!", "World is already compiled!", "", "Świat jest już skompilowany!" });
            words.Add("WIN_COMPWORLD_COMPILING", new List<string> { "Мир компилируется...", "World is being compiled!", "", "Świat się kompiluje!" });
            words.Add("WIN_COMPWORLD_TIME", new List<string> { "Компиляция мира выполнена за", "World compiling time", "", "Czas kompilacji świata" });
            words.Add("WIN_COMPWORLD_LEVELCOMPO", new List<string> { "Не забудьте удалить лишний zCVobLevelCompo!", "Don't forget to remove the spare zCVobLevelCompo", "", "Nie zapomnij usunąć zapasowego zCVobLevelCompo" });
            words.Add("WIN_INFO_TITLE", new List<string> { "Окно информации", "Information window", "", "Okno informacyjne" });
            words.Add("WIN_INFO_CLEAR", new List<string> { "Очистить", "Clear", "", "Wyczyść" });
            words.Add("IS_SAVING", new List<string> { "сохраняется...", "is saving...", "", "zapisywanie..." });
            words.Add("WIN_CAM_GETFROMBUFFER", new List<string> { "Взять из буфера", "Get from clipboard", "", "Pobierz ze schowka" });
            words.Add("BTN_APPLY", new List<string> { "Применить", "Apply", "", "Zapisz" });
            words.Add("WIN_MISC_SET", new List<string> { "Прочие настройки", "Misc settings", "", "Inne ustawienia" });
            words.Add("checkBoxSetDatePrefix", new List<string> { "Добавлять префикс даты при сохранении зена", "Add DATE prefix to file when saving ZEN", "", "Dodaj prefix daty do nazwy zapisanego pliku" });
            words.Add("checkBoxMiscExitAsk", new List<string> { "Подтверждать выход если открыт зен", "Confirm exit if ZEN is opened", "", "Potwierdź wyjście gdzy ZEN jest otwarty." });
            words.Add("checkBoxLastZenAuto", new List<string> { "Открывать последний ZEN автоматически", "Open last ZEN auto", "", "Otwórz automatycznie ostatni świat." });
            words.Add("checkBoxMiscFullPath", new List<string> { "Писать полный путь до ZEN в главном окне", "Show full path to ZEN file in main window", "", "Pokaż pełną ścieżkę do świata w głównym oknie" });
            words.Add("WIN_CONTROLSET_TEXT", new List<string> { "Настройки управления", "Controls setttings", "", "Ustawienia sterowania" });
            words.Add("WIN_CONTROLSET_TRANSSPEED", new List<string> { "Скорость перемещения: ", "Moving speed: ", "", "Szybkość poruszania: " });
            words.Add("WIN_CONTROLSET_ROTSPEED", new List<string> { "Скорость вращения: ", "Rotation speed: ", "", "Szybkość rotacji: " });
            words.Add("WIN_CONTROLSET_GROUP0", new List<string> { "Управление вобом", "Vob control", "", "Kontrola Voba" });
            words.Add("WIN_CONTROLSET_GROUP1", new List<string> { "Вставка воба", "Vob insertion", "", "Wstawianie Voba" });
            words.Add("checkBoxInsertVob", new List<string> { "Вставлять воб на той же высоте", "Insert vob on the source height", "", "Wstaw Voba na wysokości kamery" });
            words.Add("checkBoxVobRotRandAngle", new List<string> { "Поворачивать воб на случайный угол", "Turn vob on a random angle", "", "Obróć voba pod dowolnym kątem" });
            words.Add("checkBoxVobInsertHierarchy", new List<string> { "Учитывать иерархию при копировании", "Use hierarchy when copying", "", "Użyj hierarchi podczas kopiowania" });
            words.Add("labelRotWpFP", new List<string> { "Разворачивать WP/FP при вставке:", "Turn WP/FP when inserting:", "", "Obróć WP/FP podczas dodawania:" });
            words.Add("radioButtonWPTurnNone", new List<string> { "Нет", "None ", "None", "Brak" });
            words.Add("radioButtonWPTurnAgainst", new List<string> { "От камеры", "From the camera", "", "Z kamery" });
            words.Add("radioButtonWPTurnOn", new List<string> { "На камеру", "At the camera", "", "Do kamery" });
            words.Add("WIN_CONTROLCAM_TEXT", new List<string> { "Настройки камеры", "Camera settings", "", "Ustawienia kamery" });
            words.Add("groupBoxCam", new List<string> { "Камера", "Camera", "", "Kamera" });
            words.Add("labelTrans", new List<string> { "Скорость полета", "Moving speed", "", "Prędkość poruszania" });
            words.Add("labelRot", new List<string> { "Скорость повотора", "Rotation speed", "", "Prędkość rotacji" });
            words.Add("groupBoxRange", new List<string> { "Прорисовка", "Rendering range", "", "Zasięg renderowania" });
            words.Add("labelWorld", new List<string> { "Мир", "World", "", "Świat" });
            words.Add("labelVobs", new List<string> { "Вобы", "Vobs", "", "Obiekty" });
            words.Add("labelLimitFPS", new List<string> { "Ограничить FPS", "Limit FPS", "", "Limit FPS" });
            words.Add("groupBoxInfo", new List<string> { "Информация", "Information", "", "Informacje" });
            words.Add("checkBoxFPS", new List<string> { "Показывать FSP", "Show FPS", "", "Pokaż FPS" });
            words.Add("checkBoxTris", new List<string> { "Показывать кол-во рисуемых треугольников", "Show rendered triangles", "", "Pokaż ilość renderowanych trójkątów" });
            words.Add("checkBoxCamCoord", new List<string> { "Показывать координаты камеры", "Show camera coordinates", "", "Pokaż koordynaty kamery" });
            words.Add("checkBoxVobs", new List<string> { "Показывать кол-во вобов", "Show vobs count", "", "Pokaż ilość vobów" });
            words.Add("checkBoxWaypoints", new List<string> { "Показывать кол-во вейпоинтов", "Show waypoints count", "", "Pokaż ilość Waypointów" });
            words.Add("checkBoxDistVob", new List<string> { "Показывать расстояние до выбранного воба", "Show distance to selected vob", "", "Pokaż dystans do zaznaczonego voba" });
            words.Add("checkBoxCameraHideWins", new List<string> { "Скрывать окна при полете камеры", "Hide windows when moving camera", "", "Ukryj okna podczas poruszania kamerą" });
            words.Add("WIN_KEYSBIND_TEXT", new List<string> { "Сочетания клавиш", "Keys binding", "", "Przypisanie klawiszy" });
            words.Add("WIN_KEYSBIND_DESC", new List<string> { "Описание", "Description", "", "Opis" });
            words.Add("WIN_KEYSBIND_BINDS", new List<string> { "Сочетание", "Bind", "", "Powiązanie" });
            words.Add("WIN_KEYSBIND_KEY_SPACE", new List<string> { "Пробел", "Space", "", "Spacja" });
            words.Add("WIN_KEYSBIND_KEY_ARROW_LEFT", new List<string> { "Стрелка влево", "Arrow left", "", "Strzałka w lewo" });
            words.Add("WIN_KEYSBIND_KEY_ARROW_UP", new List<string> { "Стрелка вверх", "Arrow up", "", "Strzałka w górę" });
            words.Add("WIN_KEYSBIND_KEY_ARROW_RIGHT", new List<string> { "Стрелвка вправо", "Arrow right", "", "Strzałka w prawo" });
            words.Add("WIN_KEYSBIND_KEY_ARROW_DOWN", new List<string> { "Стрелка вниз", "Arrow down", "", "Strzałka w dół" });
            words.Add("CAMERA_TRANS_FORWARD", new List<string> { "Камера (вперед)", "Camera (forward)", "", "Kamera (do przodu)" });
            words.Add("CAMERA_TRANS_BACKWARD", new List<string> { "Камера (назад)", "Camera (backward)", "", "Kamera (do tyłu)" });
            words.Add("CAMERA_TRANS_RIGHT", new List<string> { "Камера (вправо)", "Camera (right)", "", "Kamera (w prawo)" });
            words.Add("CAMERA_TRANS_LEFT", new List<string> { "Камера (влево)", "Camera (left)", "", "Kamera (w lewo)" });
            words.Add("CAMERA_TRANS_UP", new List<string> { "Камера (вверх)", "Camera (up)", "", "Kamera (do góry)" });
            words.Add("CAMERA_TRANS_DOWN", new List<string> { "Камера (вниз)", "Camera (down)", "", "Kamera (w dół)" });
            words.Add("CAM_SPEED_X10", new List<string> { "Увеличить скорость полета камеры в 10 раз", "Increase camera moving speed x10", "", "Zwiększ prędkość kamery x10" });
            words.Add("CAM_SPEED_MINUS_10", new List<string> { "Уменьшить скорость полета камеры в 10 раз", "Decrease camera moving speed x10", "", "Zmniejsz prędkość kamery x10" });
            words.Add("VOB_COPY", new List<string> { "Скопировать воб", "Copy vob", "", "Kopiuj voba" });
            words.Add("VOB_INSERT", new List<string> { "Вставить воб", "Insert vob", "", "Wklej voba" });
            words.Add("VOB_CUT", new List<string> { "Вырезать воб (смена родителя)", "Cut vob (parent change)", "", "Wytnij voba (Zmiana nadrzędnego)" });
            words.Add("VOB_FLOOR", new List<string> { "Прижать воб к полу", "Floor the vob", "", "Umieść voba na podłodze" });
            words.Add("VOB_RESET_AXIS", new List<string> { "Сбросить направление воба по осям", "Reset axes of the vob", "", "Zresetuj osie voba" });
            words.Add("VOB_DELETE", new List<string> { "Удалить воб", "Remove vob", "", "Usuń voba" });
            words.Add("VOB_TRANSLATE", new List<string> { "Инструмент перемещение", "Tool moving", "", "Narzędzie poruszania" });
            words.Add("VOB_ROTATE", new List<string> { "Инструмент вращение", "Tool rotating", "", "Narzędzie rotacji" });
            words.Add("WP_TOGGLE", new List<string> { "Переключить соединение между вейпоинтами", "Toggle connection between waypoints", "", "Pokaż połączenia między Waypointami" });
            words.Add("VOB_DISABLE_SELECT", new List<string> { "Снять выделение с воба", "Unselect the vob", "", "Odznacz voba" });
            words.Add("VOB_NEAR_CAM", new List<string> { "Переместить воб перед камерой", "Move vob in front of the camera", "", "Przenieś voba przed kamerę" });
            words.Add("VOB_TRANS_FORWARD", new List<string> { "Перемещение воба (вперед)", "Moving vob (forward)", "", "Poruszanie voba (do przodu)" });
            words.Add("VOB_TRANS_BACKWARD", new List<string> { "Перемещение воба (назад)", "Moving vob (back)", "", "Poruszanie voba (do tyłu)" });
            words.Add("VOB_TRANS_LEFT", new List<string> { "Перемещение воба (влево)", "Moving vob (left)", "", "Poruszanie voba (w lewo)" });
            words.Add("VOB_TRANS_RIGHT", new List<string> { "Перемещение воба (вправо)", "Moving vob (right)", "", "Poruszanie voba (w prawo)" });
            words.Add("VOB_TRANS_UP", new List<string> { "Перемещение воба (вверх)", "Moving vob (up)", "", "Poruszanie voba (w górę)" });
            words.Add("VOB_TRANS_DOWN", new List<string> { "Перемещение воба (вниз)", "Moving vob (down)", "", "Poruszanie voba (w dół)" });
            words.Add("VOB_SPEED_X10", new List<string> { "Увеличить скорость перемещения/вращения воба в 10 раз", "Increase vob moving/rotating speed x10", "", "Zwiększ szybkość przemieszacznia i rotacji x10" });
            words.Add("VOB_SPEED_MINUS_10", new List<string> { "Уменьшить скорость перемещения/вращения воба в 10 раз", "Decrease vob moving/rotating speed x10", "", "Zmniejsz szybkość przemieszacznia i rotacji x10" });
            words.Add("VOB_ROT_VERT_RIGHT", new List<string> { "Вращение воба вокруг верт. оси (по часовой стрелке)", "Rotating vob around vertical axis (clockwise)", "", "Obracanie voba w osi pionowej (zgodnie z wskazówkami zegara)" });
            words.Add("VOB_ROT_VERT_LEFT", new List<string> { "Вращение воба вокруг верт. оси (против часовой стрелки)", "Rotating vob around vertical axis (counterclock-wise)", "", "Obracanie voba w osi pionowej (przeciwnie do wskazówek zegara)" });
            words.Add("VOB_ROT_FORWARD", new List<string> { "Вращение воба от себя", "Vob rotating from the camera", "", "Rotacja voba od kamery" });
            words.Add("VOB_ROT_BACK", new List<string> { "Вращение воба на себя", "Vob rotating at the camera", "", "Rotacja voba w kamerze" });
            words.Add("VOB_ROT_RIGHT", new List<string> { "Вращение воба вправо", "Vob rotating to the right", "", "Rotacja voba w prawo" });
            words.Add("VOB_ROT_LEFT", new List<string> { "Вращение воба влево", "Vob rotating to the left", "", "Rotacja voba w lewo" });
            words.Add("VOBLIST_COLLECT", new List<string> { "Собрать вобы в окно Контейнер вобов", "Collect vobes in Vob-List window", "", "Zbieraj voby w oknie listy-vobów" });
            words.Add("WP_CREATEFAST", new List<string> { "Создать вейпоинт по кнопке", "Create waypoint", "", "Utwórz waypoint" });
            words.Add("WIN_HIDEALL", new List<string> { "Скрыть все окна", "Hide all windows", "", "Ukryj wszystkie okna" });
            words.Add("OPEN_CONTAINER", new List<string> { "Открыть содержимое контейнера oCMobContainer", "Open oCMobContainer container", "", "Otwórz kontener oCMobContainer" });
            words.Add("TOGGLE_BBOX", new List<string> { "Показать/Скрыть все BBox", "Show/Hide all the BBoxes", "", "Pokaż/Ukryj wszystkie BBoxy" });
            words.Add("TOGGLE_INVIS", new List<string> { "Показать/Скрыть невидимые вобы", "Show/Hide invisible vobs", "", "Pokaż/Ukryj niewidzialne voby" });
            words.Add("TOGGLE_VOBS", new List<string> { "Показать/Скрыть все вобы", "Show/Hide all vobs", "", "Pokaż/Ukryj wszystkie voby" });
            words.Add("TOGGLE_WAYNET", new List<string> { "Показать/Скрыть Waynet", "Show/Hide Waynet", "", "Pokaż/Ukryj waynet" });
            words.Add("TOGGLE_HELPERS", new List<string> { "Показать/Скрыть help-вобы", "Show/Hide help vobs", "", "Pokaż/Ukryj voby pomocnicze" });
            words.Add("WIN_TREE_TITLE", new List<string> { "Список объектов", "Objects list window", "", "Okno listy obiektów" });
            words.Add("buttonCollapse", new List<string> { "Свернуть все", "Collapse all", "", "Ukryj wszystkie" });
            words.Add("buttonExpand", new List<string> { "Развернуть все", "Expand all", "", "Rozwiń wszystkie" });
            words.Add("buttonTreeSort", new List<string> { "Сортировать", "Sort", "", "Sortuj" });
            words.Add("CONTEXTMENU_TREE_INSERT_VOBTREE_PARENT", new List<string> { "Вставить VobTree в выделенный воб", "Insert VobTree into the vob", "", "Dodaj Drzewko-Vobów do voba" });
            words.Add("CONTEXTMENU_TREE_INSERT_VOBTREE_GLOBAL", new List<string> { "Вставить VobTree глобально", "Insert VobTree globally", "", "Dodaj Drzewko-Vobów globalnie" });
            words.Add("CONTEXTMENU_TREE_SAVE_VOBTREE", new List<string> { "Сохранить выделенный воб в VobTree", "Save vob as VobTree", "", "Zapisz voba jako Drzewko-Vobów" });
            words.Add("CONTEXTMENU_TREE_REMOVE_VOB", new List<string> { "Удалить воб", "Remove the vob", "", "Usuń voba" });
            words.Add("WIN_VOBLIST_TITLE", new List<string> { "Контейнер вобов", "VobList window", "", "Okno listy vobów" });
            words.Add("labelVobType", new List<string> { "Тип воба", "Vob type", "", "Typ voba" });
            words.Add("labelRadius", new List<string> { "Радиус поиска", "Search radius", "", "Promień wyszukiwania" });
            words.Add("WIN_SOUND_TITLE", new List<string> { "Звуки и музыка", "Sounds and music window", "", "Okno dźwięku i muzyki" });
            words.Add("groupBoxSound", new List<string> { "Звуки", "Sounds", "", "Dźwięki" });
            words.Add("groupBoxMusic", new List<string> { "Музыка", "Music", "", "Muzyka" });
            words.Add("buttonPlaySound", new List<string> { "Воспроизвести", "Play", "", "Zagraj" });
            words.Add("labelAllSounds", new List<string> { "Все звуки. Кол-во:", "All sound. Count:", "", "Wszystkie dźwięki. Ilość:" });
            words.Add("labelSndList", new List<string> { "Поиск по рег. выражению", "Search using regex", "", "Wyszukaj za pomocą wyrażenia regularnego" });
            words.Add("buttonOffMusic", new List<string> { "Отключить музыку", "Turn off music", "", "Wyłącz muzykę" });
            words.Add("buttonMusicOn", new List<string> { "Включить музыку", "Turn on music", "", "Włącz muzykę" });
            words.Add("checkBoxShutMusic", new List<string> { "Отключать музыку при загрузке", "Shut music after world loaded", "", "Utnij muzykę po wczytaniu świata" });
            words.Add("labelMusicVolume", new List<string> { "Громкость", "Volume", "", "Głośność" });
            words.Add("buttonStopAllSounds", new List<string> { "Заглушить все звуки", "Turn off all sounds", "", "Wyłącz wszystkie dźwięki" });
            words.Add("NAME_ALREADY_EXISTS", new List<string> { "Такое имя уже существует!", "Turn off all sounds", "", "Wyłącz wszystkie dźwięki" });
            words.Add("Label_Backup", new List<string> { "Старое значение", "Turn off all sounds", "", "Wyłącz wszystkie dźwięki" });
            words.Add("WIN_PROPS_TITLE", new List<string> { "Окно свойств", "Properties window", "", "Okno właściwości" });
            words.Add("buttonApplyOnVob", new List<string> { "Применить на вобе", "Apply on the vob", "", "Zastosuj dla voba" });
            words.Add("buttonFileOpen", new List<string> { "Файл", "File", "", "Plik" });
            words.Add("buttonRestoreVobProp", new List<string> { "Восстановить", "Restore", "", "Odzyskaj" });
            words.Add("buttonOpenContainer", new List<string> { "Контейнер", "Container", "", "Kontener" });
            words.Add("tabControlProps_0", new List<string> { "Редактирование", "Edit", "", "Edytuj" });
            words.Add("tabControlProps_1", new List<string> { "BBox", "Bbox", "", "BBox" });
            words.Add("tabControlProps_2", new List<string> { "Контейнер", "Container", "", "Kontener" });
            words.Add("groupBoxEditBbox", new List<string> { "Редактирование BBox", "Editing BBox", "", @"Edytuj BBox'y" });
            words.Add("NO_ITEM_NAME", new List<string> { "Имя вещи не может быть пустым! Строка: ", "Item name is empty! Row: ", "", "Nazwa przedmiotu jest pusta! Rząd: " });
            words.Add("NO_ITEM_COUNT", new List<string> { "Кол-во итемов не может быть пустым! Строка: ", "Item count is empty! Row: ", "", "Ilość przedmiotów jest pusta! Rząd: " });
            words.Add("ITEM_BAD_COUNT", new List<string> { "Некорректное число итемов. Строка: ", "Bad item count value! Row: ", "", "Zła wartość ilości przedmiotu! Rząd: " });
            words.Add("groupBoxContainer", new List<string> { "Редактирование BBox", "Editing BBox", "", @"Edytuj BBox'y" });
            words.Add("buttonClearItems", new List<string> { "Очистить все", "Clear all", "", "Wyczyść wszystkie" });
            words.Add("buttonRowDelete", new List<string> { "Удалить текущую", "Remove current", "", "Wyczyść obecny" });
            words.Add("ITEMS_COLUMN_INSTANCE", new List<string> { "Инстанция", "Instance", "", "Instancja" });
            words.Add("ITEMS_COLUMN_COUNT", new List<string> { "Кол-во", "Count", "", "Ilość" });
            words.Add("WIN_OBJ_TITLE", new List<string> { "Окно объектов", "Objects window", "", "Okno obiektów" });
            words.Add("WIN_OBJ_TAB0", new List<string> { "Все классы", "All classes", "", "Wszystkie klasy" });
            words.Add("WIN_OBJ_TAB1", new List<string> { "Вещи", "Items", "", "Przedmioty" });
            words.Add("WIN_OBJ_TAB2", new List<string> { "Эффекты", "Particles", "", "Efekty cząsteczkowe" });
            words.Add("WIN_OBJ_TAB3", new List<string> { "Триггеры", "Triggers", "", "Wyzwalacze" });
            words.Add("WIN_OBJ_TAB4", new List<string> { "WP/FP", "WP/FP", "", "WP/FP" });
            words.Add("WIN_OBJ_TAB5", new List<string> { "Поиск", "Search", "", "Szukaj" });
            words.Add("WIN_OBJ_TAB6", new List<string> { "Камера", "Camera", "", "Kamera" });
            words.Add("WIN_OBJ_TAB7", new List<string> { "Свет", "Light", "", "Światło" });
            words.Add("WIN_OBJ_ALLMODELS", new List<string> { "Поиск визуала", "Visual search", "", "Szukaj wyglądu" });
            words.Add("WIN_OBJ_ALL", new List<string> { "всего", "count", "", "ilość" });
            words.Add("WIN_OBJ_TYPE_CANTHERE", new List<string> { "Данный тип воба создается в отдельной вкладке справа!", "This vob type can be created in a special tab!", "", "Ten typ voba może zostać dodany w specjalnej zakładce!" });
            words.Add("WIN_OBJ_NO_EMPTY_NAME", new List<string> { "Нельзя ввести пустое имя!", "You can't enter an empty name!", "", "Nie możesz podać pustej nazwy!" });
            words.Add("WIN_OBJ_NO_WAYPOINT_NUMBERSONLY", new List<string> { "Имя вейпоинта не может состоять только из цифр!", "Waypoint can't have only numbers in its name!", "", "Waypoint nie może mieć tylko liczb w nazwie!" });
            words.Add("WIN_OBJ_SEARCHVISUAL", new List<string> { "всего", "count", "", "ilość" });
            words.Add("WIN_OBJ_SEARCHVISUAL_ALL", new List<string> { "Поиск визуала. Всего", "Visual search. Count", "", "Wyszukiwanie po wyglądzie. Ilość" });
            words.Add("COPYBUFFER", new List<string> { "Скопировано в буфер", "Copied to clipboard", "", "Skopiowano do schowka" });
            words.Add("groupBoxObjAllClasses", new List<string> { "Все классы вобов", "All vobs classes", "", "Wszystkie klasy vobów" });
            words.Add("groupBoxObjPropVobs", new List<string> { "Свойства воба", "Vob properties", "", "Właściwości voba" });
            words.Add("labelObjAllClassesNameVob", new List<string> { "Имя воба", "Vob name", "", "Nazwa voba" });
            words.Add("buttonAllClassesCreateVob", new List<string> { "Создать Vob", "Create Vob", "", "Utwórz voba" });
            words.Add("checkBoxDynStat", new List<string> { "Динамич. коллизия", "Dynamic collision", "", "Kolizja dynamiczna" });
            words.Add("checkBoxStaStat", new List<string> { "Стат. коллизия", "Static collision", "", "Kolizja statyczna" });
            words.Add("checkBoxShowPreview", new List<string> { "Показывать модель", "Show model preview", "", "Pokaż podgląd modelu" });
            words.Add("checkBoxSearchOnly3DS", new List<string> { "Искать только 3DS", "Search only 3DS", "", "Szukaj tylko 3DS" });
            words.Add("buttonAllClassesClear", new List<string> { "Очистить", "Clear", "", "Wyczyść" });
            words.Add("groupBoxObjItems", new List<string> { "Предметы", "Items", "", "Przedmioty" });
            words.Add("TEST_NOT_READY", new List<string> { "ЕЩЕ НЕ СДЕЛАНО", "NOT READY YET", "", "JESZCZE NIE GOTOWE" });
            words.Add("buttonItemsCreate", new List<string> { "Создать Item", "Create Item", "", "Utwórz przedmiot" });
            words.Add("buttonAddContainer", new List<string> { "Добавить в контейнер->", "Add to container->", "", "Dodaj do kontenera->" });
            words.Add("groupBoxItemsCont", new List<string> { "Редактор сундука", "Edit the container", "", "Edytuj kontener" });
            words.Add("checkBoxItemShow", new List<string> { "Отображать вещь на экране", "Show model preview", "", "Pokaż podgląd modelu" });
            words.Add("labelItemsEditContCount", new List<string> { "Количество", "Count", "", "Ilość" });
            words.Add("labelItemsAllItems", new List<string> { "Все вещи игры", "All game items", "", "Wszystkie przedmioty z gry" });
            words.Add("labelItemsFindReg", new List<string> { "Поиск по рег. выражению", "Search using regex", "", "Wyszukiwanie standardowe" });
            words.Add("groupBoxPFX", new List<string> { "Эффекты частиц", "Particles", "", "Efekty cząsteczkowe" });
            words.Add("buttonParticles", new List<string> { "Создать PFX", "Create PFX", "", "Utwórz PFX" });
            words.Add("checkBoxShowPFXPreview", new List<string> { "Отображать эффект на экране", "Show PFX preview", "", "Pokaż podgląd PFX" });
            words.Add("labelAllPfx", new List<string> { "Все эффекты игры", "All game PFXes", "", @"Wszystkie PFX'y z gry" });
            words.Add("groupBoxTriggersVob", new List<string> { "Выбранный воб", "Selected vob", "", "Wybrany vob" });
            words.Add("groupBoxTriggersKeys", new List<string> { "Ключи", "Keys", "", "Klawisze" });
            words.Add("buttonSendTrigger", new List<string> { "Запустить >>>", "Run >>>", "", "Uruchom >>>" });
            words.Add("buttonTriggerCollectSources", new List<string> { "Собрать", "Collect", "", "Zbierz" });
            words.Add("buttonNewKey", new List<string> { "Новый ключ", "New key", "", "Nowy klawisz" });
            words.Add("buttonRemoveKey", new List<string> { "Удалить ключ", "Remove key", "", "Usuń klawisz" });
            words.Add("labelTriggerName", new List<string> { "Триггер", "Trigger", "", "Wyzwalacze" });
            words.Add("labelTriggerCollision", new List<string> { "Коллизия", "Collision", "", "Kolizja" });
            words.Add("checkBoxDyn", new List<string> { "динамич.", "dynamic", "", "dynamiczna" });
            words.Add("checkBoxStat", new List<string> { "статич.", "static", "", "statyczna" });
            words.Add("radioButtonOverwrite", new List<string> { "Перезаписать", "Overwrite", "", "Przepisz" });
            words.Add("labelTriggerInsert", new List<string> { "Вставить", "Insert key", "", "Dodaj klawisz" });
            words.Add("radioButtonAfter", new List<string> { "После", "After", "", "Przed" });
            words.Add("radioButtonBefore", new List<string> { "До", "Before", "", "Po" });
            words.Add("labelTriggerTargets", new List<string> { "Цели (targets)", "Targets", "", "Cele" });
            words.Add("labelTriggersSources", new List<string> { "Источники (sources)", "Sources", "", "Źródła" });
            words.Add("groupBoxWPFP", new List<string> { "Мировые точки", "World points", "", "Punkty świata" });
            words.Add("labelNameWPMandatory", new List<string> { "Имя Waypoint (обязательно)", "Waypoint name (mandatory)", "", "Nazwa waypointa (obowiązkowa)" });
            words.Add("labelFreepointMandatory", new List<string> { "Имя Freepoint (обязательно)", "Freepoint name (mandatory)", "", "Nazwa freepointa (obowiązkowa)" });
            words.Add("checkBoxWayNet", new List<string> { "Сразу соединять в сеть", "Connect to waynet at once", "", "Połącz natychmiast z waynetem" });
            words.Add("checkBoxWPAutoName", new List<string> { "Автогенерация имени", "Auto-generated name", "", "Nazwa wygenerowana automatycznie" });
            words.Add("checkBoxFPGround", new List<string> { "Прижимать к земле", "Floor the freepoint", "", @"Połóż freepoint'a na podłodze" });
            words.Add("checkBoxAutoNameFP", new List<string> { "Автогенерация имени", "Auto-generated name", "", "Nazwa wygenerowana automatycznie" });
            words.Add("buttonWPCreate", new List<string> { "Создать Waypoint", "Create Waypoint", "", "Utwórz Waypoint" });
            words.Add("buttonConnectWp", new List<string> { "Соединить WP", "Connect waypoints", "", "Połącz Waypointy" });
            words.Add("buttonDisconnectWP", new List<string> { "Разъединить WP", "Disconnect waypoints", "", "Rozłącz Waypointy" });
            words.Add("buttonFPCreate", new List<string> { "Создать Freepoint", "Create Freepoint", "", "Utwórz Freepoint" });

        }
    }
}
