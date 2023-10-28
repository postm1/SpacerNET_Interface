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


            //For special symbols use @ before string like @"someString"
            /*
             * 
             *  Use the 3rd column for German, the 4th for Polish
             *  For special symbols use @ before string like @"someString"
             */
            // RUSSIAN, ENGLISH, GERMAN, POLISH                                            

            words.Add("appIsLoading", new List<string> { "Spacer.NET загружается...", "Spacer.NET is loading...", "Spacer.NET lädt", "Spacer.NET trwa ładowanie..." });
            words.Add("appIsReady", new List<string> { "Программа готова к работе!", "The program is ready!", "Programm ist bereit!", "Program jest gotowy do pracy!" });
            words.Add("askSure", new List<string> { "Вы уверены?", "Are you sure?", "Bist du sicher?", "Czy jesteś pewny?" });
            words.Add("askReset", new List<string> { "Точно сбросить мир?", "Reset world?", "Welt zurücksetzen?", "Zresetować świat?" });
            words.Add("confirmation", new List<string> { "Подтверждение", "Confirmation", "Bestätigen", "Potwierdzenie" });
            words.Add("loadZen", new List<string> { "Идет загрузка ZEN...", "ZEN is loading...", "ZEN lädt...", "ZEN jest ładowany..." });
            words.Add("isLoading", new List<string> { "загружается...", "is loading...", "lädt...", " jest ładowany..." });
            words.Add("compileZen", new List<string> { "Идет компиляция ZEN...", "Compiling ZEN...", "Kompilieren der ZEN...", @"Kompilowanie ZEN'a..." });
            words.Add("compileLight", new List<string> { "Идет компиляция света...", "Compiling light...", "Kompilieren von Licht...", "Kompilowanie światła..." });
            words.Add("savingZen", new List<string> { "Идет сохранение ZEN...", "Saving ZEN...", "Speichere ZEN...", @"Zapisywanie ZEN'a..." });
            words.Add("waynetMsg", new List<string> { "Ошибки WayNet не найдены.", "No Waynet errors found.", "Keine Fehler im Waynet gefunden.", "Nie znaleziono błędów Waynetu." });

            words.Add("loadZenTime", new List<string> { "Загрузка ZEN выполнена за", "Loading ZEN time...", "Laden der ZEN dauerte...", @"Czas wczytywania ZEN'a..." });
            words.Add("saveZenTime", new List<string> { "Сохранение ZEN выполнено за", "Saving ZEN time...", "Speichern der ZEN dauerte", @"Czas zapisywania ZEN'a..." });
            words.Add("loadMeshTime", new List<string> { "Загрузка MESH выполнена за", "Loading MESH time...", "Laden des MESH dauerte...", @"Czas wczytywania MESH'a..." });
            words.Add("mergeZenTime", new List<string> { "Объединение ZEN выполнено за", "Merging ZEN time...", "Zusammenfügen des MESH dauerte...", @"Czas zapisywania MESH'a..." });



            words.Add("MENU_TOP_FILE", new List<string> { "Файл", "File", "Datei", "Plik" });
            words.Add("MENU_TOP_RESET", new List<string> { "Сбросить мир", "Reset world", "Welt zurücksetzen", "Zresetuj świat" });
            words.Add("MENU_TOP_EXIT", new List<string> { "Выход", "Exit", "Beenden", "Zakończ" });
            words.Add("MENU_TOP_LANG", new List<string> { "Язык", "Language", "Sprache", "Język" });
            words.Add("MENU_TOP_HELP", new List<string> { "Помощь", "Help", "Hilfe", "Pomoc" });
            words.Add("MENU_TOP_SETTINGS", new List<string> { "Настройки", "Settings", "Einstellungen", "Ustawienia" });
            words.Add("MENU_TOP_WORLD", new List<string> { "Мир", "World", "Welt", "Świat" });
            words.Add("MENU_TOP_VIEW", new List<string> { "Вид", "View", "Ansicht", "Widok" });

            words.Add("MENU_TOP_OPENZEN", new List<string> { "Открыть ZEN...", "Open ZEN...", "ZEN öffnen...", "Otwórz ZEN..." });
            words.Add("MENU_TOP_MESH", new List<string> { "Открыть MESH...", "Open MESH...", "MESH öffnen...", "Otwórz MESH..." });
            words.Add("MENU_TOP_MERGE", new List<string> { "Объединить ZEN...", "Merge ZEN...", "ZEN zusammenfügen...", "Połącz ZEN..." });
            words.Add("MENU_TOP_SAVEZEN", new List<string> { "Сохранить ZEN...", "Save ZEN...", "ZEN speichern...", "Zapisz ZEN..." });
            words.Add("MENU_TOP_ABOUT", new List<string> { "О программе", "About", "Über", "O programie" });

            words.Add("MENU_TOP_CAM", new List<string> { "Камера", "Camera", "Kamera", "Kamera" });
            words.Add("MENU_TOP_CONTROLS", new List<string> { "Управление", "Controls", "Steuerung", "Sterowanie" });
            words.Add("MENU_TOP_MISC", new List<string> { "Прочее", "Misc", "Sonstiges", "Różne" });


            words.Add("MENU_TOP_VIEW_SHOW", new List<string> { "Показать", "Show", "Anzeigen", "Pokaż" });
            words.Add("MENU_TOP_VIEW_VOBS", new List<string> { "Вобы", "Vobs", "Vobs", "Voby" });
            words.Add("MENU_TOP_VIEW_WAYNET", new List<string> { "Сетка Waynet", "Waynet", "Wegpunkte", "Waynet" });
            words.Add("MENU_TOP_VIEW_HELPER", new List<string> { "Help-вобы", "Help vobs", "Hilfs-Vobs", "Pomocnicze voby" });

            words.Add("MENU_TOP_VIEW_BBOX", new List<string> { "Показать все BBox", "Show all the BBoxes", "Alle BBoxen anzeigen", "Pokaż wszystkie BBoxy" });
            words.Add("MENU_TOP_VIEW_INVIS", new List<string> { "Показать невидимые вобы", "Show invisible vobs", "Unsichtbare Vobs anzeigen", "Pokaż niewidzialne voby" });


            words.Add("MENU_TOP_COMPILE_LIGHT", new List<string> { "Компиляция света", "Compile light", "Licht kompilieren", "Kompiluj światło" });
            words.Add("MENU_TOP_COMPILE_WORLD", new List<string> { "Компиляция мира", "Compile world", "Welt kompilieren", "Kompiluj świat" });


            words.Add("MENU_TOP_CAM_ZERO", new List<string> { "Прыгнуть на 000 координаты", "Jump to 000 coordinates", "Springe zu 000 Koordinate", "Przeskocz do koordynatów: 000" });

            words.Add("MENU_TOP_CAM_COORDS", new List<string> { "Ввести координаты", "Enter coordinates", "Koordinaten einfügen", "Wpisz koordynaty" });
            words.Add("MENU_TOP_DAYTIME", new List<string> { "Время суток", "Day time", "Tageszeit", "Pora dnia" });
            words.Add("MENU_TOP_MORN", new List<string> { "Утро (07:00)", "Morning (07:00)", "Morgens (07:00)", "Poranek (07:00)" });


            words.Add("MENU_TOP_NOON", new List<string> { "Обед (12:00)", "Midday (12:00)", "Mittags (12:00)", "Południe (12:00)" });
            words.Add("MENU_TOP_AFTERNOON", new List<string> { "Вечер (17:00)", "Evening (17:00)", "Abends (17:00)", "Wieczór (17:00)" });
            words.Add("MENU_TOP_NIGHT", new List<string> { "Ночь (00:00)", "Night (00:00)", "Nachts (00:00)", "Noc (00:00)" });
            words.Add("MENU_TOP_ANALYSE_WAYNET", new List<string> { "Анализ WayNet", "Analyze Waynet", "Wegpunkte analysieren", "Analizuj Waynet" });
            words.Add("MENU_TOP_PLAY_THE_GAME", new List<string> { "Играть за героя", "Play the hero", "Spiele den Helden", "Zagraj bohaterem" });
            words.Add("MENU_TOP_KEYSBINDS", new List<string> { "Сочетания клавиш", "Keys bindings", "Tastaturbelegung", "Przypisanie klawiszy" });

            words.Add("MENU_TOP_HOVER_WININFO", new List<string> { "Окно информации", "Information window", "Infofenster", "Okno informacji" });
            words.Add("MENU_TOP_HOVER_WINOBJ", new List<string> { "Окно объектов", "Objects window", "Objektfenster", "Okno obiektów" });
            words.Add("MENU_TOP_HOVER_WINSOUND", new List<string> { "Окно звуков", "Sounds window", "Soundfenster", "Okno dźwięków" });
            words.Add("MENU_TOP_HOVER_WINTREE", new List<string> { "Окно списка вобов", "All-vobs window", "Alle Vobs-Fenster", "Okno wszystkich obiektów" });
            words.Add("MENU_TOP_HOVER_WINPROPS", new List<string> { "Окно свойств", "Properties window", "Eigenschaftsfenster", "Okno właściwości" });
            words.Add("MENU_TOP_HOVER_WINVOBLIST", new List<string> { "Окно воб-лист", "VobList window", "Voblisten-Fenster", "Okno listy vobów" });



            words.Add("WIN_COMPLIGHT_TEXT", new List<string> { "Компиляция света", "Light compilation", "Licht kompilieren", "Kompilacja światła" });
            words.Add("WIN_COMPLIGHT_QUALITY", new List<string> { "Качество", "Quality", "Qualität", "Jakość" });
            words.Add("WIN_COMPLIGHT_COMPILEBUTTON", new List<string> { "Компилировать", "Compile", "Kompilieren", "Kompiluj" });

            words.Add("WIN_INPUT", new List<string> { "Ввод", "Input", "Eingabe", "Wejście" });
            words.Add("WIN_CANCEL_BUTTON", new List<string> { "Отмена", "Cancel", "Abbrechen", "Anuluj" });
            words.Add("WIN_COMPLIGHT_CLOSEBUTTON", new List<string> { "Закрыть", "Close", "Schließen", "Zamknij" });
            words.Add("WIN_COMPLIGHT_REGION", new List<string> { "Регион", "Region", "Region", "Region" });
            words.Add("WIN_COMPLIGHT_QUALITY0", new List<string> { "Только вершины", "Vertexes only", "Nur Vertexes", "Tylko vertexy" });
            words.Add("WIN_COMPLIGHT_QUALITY1", new List<string> { "Lightmaps (низкое)", "Lightmaps (low)", "Lightmaps (niedrig)", "Lightmapa (niska)" });
            words.Add("WIN_COMPLIGHT_QUALITY2", new List<string> { "Lightmaps (среднее)", "Lightmaps (medium)", "Lightmaps (mittel)", "Lightmapa (średnia)" });
            words.Add("WIN_COMPLIGHT_QUALITY3", new List<string> { "Lightmaps (высокое)", "Lightmaps (high)", "Lightmaps (hoch)", "Lightmapa (wysoka)" });

            words.Add("WIN_COMPLIGHT_COMPILECHECKBOX", new List<string> { "Компилировать регион", "Compile region", "Region kompilieren", "Kompiluj region" });


            words.Add("WIN_COMPLIGHT_METERS", new List<string> { "метров", "meters", "Meter", "metry" });
            words.Add("WIN_COMPLIGHT_AROUNDCAM", new List<string> { "вокруг камеры", "around the camera", "um die Kamera", "na około kamery" });


            words.Add("WIN_COMPWORLD_TEXT", new List<string> { "Компиляция мира", "World compilation", "Kompilation Welt", "Kompilacja świata" });
            words.Add("WIN_COMPWORLD_LOCTYPE", new List<string> { "Тип локации", "World type", "Welt Typ", "Typ świata" });

            words.Add("WIN_CAM_TEXT", new List<string> { "Камера", "Camera", "Kamera", "Kamera" });
            words.Add("WIN_CAM_CLOSEWIN", new List<string> { "Закрывать окно при переходе", "Close the window after the jump", "Das Fenster nach dem Wechsel schließen", "Zamknij okno po skoku" });
            words.Add("WIN_CAM_GO", new List<string> { "Перейти", "Jump", "Wechsel", "Skok" });

            // UNION STRING
            words.Add("UNION_VOB_INSERTED", new List<string> { "Воб вставлен", "The vob inserted", "Vob eingefügt", "Vob został wklejony" });
            words.Add("UNION_VOB_AXIS_RESET", new List<string> { "Направление воба сброшено", "Vob axes were reset", "Richtung des Vobs geändert", "Osie Voba zostały zresetowane" });
            words.Add("CANT_APPLY_PARENT", new List<string> { "Данный тип воба перенести в родителя нельзя!", "Can't insert this vob type into a parent vob!", "Dieses Vob kann nicht in die übergeordneten Vob eingefügt werden!", "Nie można dodać tego typu Voba jako nadrzędnego." });
            words.Add("PARENT_ERROR_OCITEM", new List<string> { "oCItem не может быть родителем!", "oCItem can't be a parent!", "oCItem kann nicht übergeornet sein!", "oCItem nie może być nadrzędny!" });
            words.Add("PARENT_CHANGE_OK", new List<string> { "Родитель для воба изменен!", "The parent has been changed", "Überordnung für Vob wurde geändert", "Vob nadrzędny został zmieniony" });

            words.Add("VOB_COPY_OK", new List<string> { "Воб скопирован", "Vob was copied", "Vob kopiert", "Vob został skopiowany" });
            words.Add("VOB_CUT_OK", new List<string> { "Воб вырезан", "Vob was cut", "Vob ausgeschnitten", "Vob został wycięty" });
            words.Add("VOB_NEAR_CAMERA", new List<string> { "Воб вставлен перед камерой", "Vob inserted in front of the camera", "Vob vor die Kamera eingefügt", "Vob został stworzony na przeciwko kamery" });


            words.Add("TOOL_TRANS", new List<string> { "Выбран инструмент перемещение", "Tool: moving", "Werkzeug: Verschieben", "Narzędzie: Przemieszczanie" });
            words.Add("TOOL_ROT", new List<string> { "Выбран инструмент вращение", "Tool: rotation", "Werkzeug: Rotieren", "Narzędzie: Rotacja" });
            words.Add("TOOL_UNSELECT", new List<string> { "Выделение воба снято", "Vob selection cancel", "Vobauswahl aufgehoben", "Wybranie voba zostało anulowane" });
            words.Add("TOOL_FLOOR", new List<string> { "Прижимание воба к полу", "Try to floor the vob", "Vob am Boden fixieren", "Spróbuj postawić Voba na podłodze" });

            words.Add("UNION_LIGHT_RAD_INC", new List<string> { "Радиус освещения увеличен", "Light radius increased", "Lichtradius erhöht", "Promień światła został zwiększony" });
            words.Add("UNION_LIGHT_RAD_DEC", new List<string> { "Радиус освещения уменьшен", "Light radius decreased", "Lichtradius verringert", "Promień światła został zmniejszony" });

            words.Add("UNION_LIGHT_RAD_ZERO", new List<string> { "Радиус освещения сброшен в 0", "Light radius set to 0", "Lichtradius auf 0 gesetzt", "Promień światła został ustawiony na 0" });
            words.Add("UNION_MESH_LOADED", new List<string> { "Меш загружен", "Mesh is loaded", "Mesh geladen", "Mesh jest załadowany" });
            words.Add("UNION_MESH_READY", new List<string> { "Меш и вобы объединены. Скомпилируйте мир", "Mesh and vobs were merged. Compile the world", "Mesh und Vobs zusammengeführt. Bitte Welt kompilieren!", "Mesh i voby zostały połączone. Skompiluj świat." });
            words.Add("UNION_EDITOR", new List<string> { "Редактор для ZenGin", "Editor for ZenGin", "Editor für ZenGin", "Edytor dla ZenGine" });
            words.Add("UNION_TEAM", new List<string> { "Разработчик: Liker. Помогали: Patrix & Haart & Saturas & Gratt & Jr", "Author: Liker. Assistance from: Patrix & Haart & Saturas & Gratt & Jr", "Entwicklerteam: Liker & Patrix &Haart & Saturas & Gratt & Jr", "Deweloperzy: Liker & Patrix & Haart & Saturas & Gratt & Jr" });
            words.Add("UNION_DATE_COMPILE", new List<string> { "Дата компиляции: ", "Compilation date: ", "Datum der Kompilation: ", "Data kompilacji: " });
            words.Add("UNION_RESOLUTION", new List<string> { "Разрешение рендера: ", "Render resolution: ", "Rendererauflösung: ", "Rozdzielczość renderowania: " });
            words.Add("UNION_NOWORLD", new List<string> { "Мир не загружен", "World is not loaded", "Welt wurde nicht geladen", "Świat nie został wczytany." });
            words.Add("UNION_CANT_ABSTRACT", new List<string> { "Не могу создать объект абстрактного класса!", "Can't create a vob of an abstract class", "Kann keine vob von einer abstrakten Klasse erstellen!", "Nie można utworzyć voba klasy abstrakcyjnej" });
            words.Add("ENTER_NAME", new List<string> { "Введите имя воба!", "Enter the name!", "Namen eingeben!", "Podaj nazwę!" });
            words.Add("CANT_DELETE_LEVELCOMPO", new List<string> { "Не могу удалить zCVobLevelCompo!", "Can't remove zCVobLevelCompo!", "zCVVobLevelCompo kann nicht entfernt werden!", "Nie można usunąć zCVobLevelCompo!" });
            words.Add("CANT_DELETE_CAM", new List<string> { "Не могу удалить основную камеру!", "Can't remove the camera!", "Kamera kann nicht entfernt werden", "Nie można usunąć kamery!" });
            words.Add("UNION_NO_WAYPOINT", new List<string> { "Вейпоинт не выбран!", "No waypoint selected!", "Keinen Wegpunkt ausgewählt", @"Nie wybrano Waypointa" });
            words.Add("UNION_NO_WAYPOINT_TEMPLATE", new List<string> { "Шаблон имени вейпоинта пуст!", "Waypoint name template is empty!", "Die Vorlage für den Wegpunktnamen ist leer!", "Nazwa szablonu Waypointów jest pusta!" });
            words.Add("UNION_WP_INSERT", new List<string> { "Вейпоинт вставлен: ", "Waypoint inserted: ", "Wegpunkt hinzugefügt:", "Dodano Waypoint: " });
            words.Add("UNION_WORLD_ONCOMPILE", new List<string> { "Мир скомпилирован.", "World has been compiled.", "Welt wurde kompiliert.", "Świat został skompilowany." });
            words.Add("UNION_VOBTREE_SAVE", new List<string> { "VobTree сохранен!", "VobTree saved!", "VobTree gespeichert!", "Drzewko vobów zostało zapisane!" });
            words.Add("UNION_VOBTREE_INSERT", new List<string> { "VobTree вставлен!", "VobTree inserted!", "VobTree eingefügt!", "Dodano drzewko vobów!" });
            words.Add("UNION_SHOW_TRIS", new List<string> { "Кол-во треугольников: ", "Tris amount: ", "Anzahl Tris: ", "Ilość tri: " });
            words.Add("UNION_CAM_POS", new List<string> { "Позиция камеры: ", "Camera pos: ", "Kameraposition: ", "Pozycja kamery: " });
            words.Add("UNION_VOB_COUNT", new List<string> { "Кол-во вобов: ", "Vobs amount: ", "Anzahl der Vobs: ", "Ilość vobów: " });
            words.Add("UNION_WP_COUNT", new List<string> { "Кол-во вейпоинтов: ", "Waypoint amount: ", "Anzahl der Wegpunkte: ", "Ilość Waypointów: " });
            words.Add("UNION_DIST", new List<string> { "Дистанция: ", "Distance: ", "Entfernung: ", "Dystans: " });
            //NEW
            words.Add("WIN_COMPLIGHT_NOWORLD", new List<string> { "Мир не загружен!", "World is not loaded!", "Welt ist nicht geladen!", "Świat nie jest załadowany!" });
            words.Add("WIN_COMPLIGHT_NOWORLDCOMPILED", new List<string> { "Мир не скомпилирован!", "World is not compiled!", "Welt ist nicht kompiliert!", "Świat nie jest skompilowany!" });
            words.Add("WIN_COMPLIGHT_TIME", new List<string> { "Компиляция света выполнена за", "Light compilaton time", "Licht Kompilierungszeit", "Czas kompilacji światła" });
            words.Add("WIN_COMPLIGHT_QUALITY0_COMP", new List<string> { "Компиляция (только вершины)", "Compilation (Vertexes only)", "Kompilierung (nur Vertexes)", "Kompilacja (Tylko Vertexy)" });
            words.Add("WIN_COMPLIGHT_QUALITY1_COMP", new List<string> { "Компиляция Lightmaps (низкое)", "Compilation Lightmaps (low)", "Kompilierung Lightmaps (niedrig)", "Kompilacja Lightmap (niskie)" });
            words.Add("WIN_COMPLIGHT_QUALITY2_COMP", new List<string> { "Компиляция Lightmaps (среднее)", "Compilation Lightmaps (medium)", "Kompilierung Lightmaps (mittel)", "Kompilacja Lightmap (średnie)" });
            words.Add("WIN_COMPLIGHT_QUALITY3_COMP", new List<string> { "Компиляция Lightmaps (высокое)", "Compilation Lightmaps (high)", "Kompilierung Lightmaps (hoch)", "Kompilacja Lightmap (wysokie)" });
            words.Add("WIN_COMPWORLD_ALREADY_COMP", new List<string> { "Мир уже скомпилирован!", "World is already compiled!", "Welt wurde bereits kompiliert.", "Świat jest już skompilowany!" });
            words.Add("WIN_COMPWORLD_COMPILING", new List<string> { "Мир компилируется...", "World is being compiled!", "Welt wird gerade kompiliert.", "Świat się kompiluje!" });
            words.Add("WIN_COMPWORLD_TIME", new List<string> { "Компиляция мира выполнена за", "World compiling time", "Welt Kompilierungszeit", "Czas kompilacji świata" });
            words.Add("WIN_COMPWORLD_LEVELCOMPO", new List<string> { "Не забудьте удалить лишний zCVobLevelCompo!", "Don't forget to remove the spare zCVobLevelCompo", "Vergiss nicht den 'spare' zCVobLevelCompo zu entfernen", "Nie zapomnij usunąć zapasowego zCVobLevelCompo" });
            words.Add("WIN_INFO_TITLE", new List<string> { "Окно информации", "Information window", "Informationsfenster", "Okno informacyjne" });
            words.Add("WIN_INFO_CLEAR", new List<string> { "Очистить", "Clear", "Löschen", "Wyczyść" });
            words.Add("IS_SAVING", new List<string> { "сохраняется...", "is saving...", "wird gespeichert...", "zapisywanie..." });
            words.Add("WIN_CAM_GETFROMBUFFER", new List<string> { "Взять из буфера", "Get from clipboard", "Wird aus der Zwischenablage geholt", "Pobierz ze schowka" });
            words.Add("BTN_APPLY", new List<string> { "Применить", "Apply", "Anwenden", "Zastosuj" });
            words.Add("BTN_SAVE_CHANGES", new List<string> { "Сохранить изменения", "Save changes", "Änderungen speichern", "Zapisz zmiany" });
            words.Add("BTN_UP", new List<string> { "Вверх", "Up", "Hoch", "Góra" });
            words.Add("BTN_DOWN", new List<string> { "Вниз", "Down", "Runter", "Dół" });
            words.Add("WIN_MISC_SET", new List<string> { "Прочие настройки", "Misc settings", "Verschiedene Einstellungen", "Inne ustawienia" });
            words.Add("checkBoxSetDatePrefix", new List<string> { "Добавлять префикс даты при сохранении зена", "Add DATE prefix to file when saving ZEN", "Füge Datum Präfix zu Datei hinzu wenn die ZEN gespeichert wird", "Dodaj prefix daty do nazwy zapisanego pliku" });
            words.Add("checkBoxMiscExitAsk", new List<string> { "Подтверждать выход если открыт зен", "Confirm exit if ZEN is opened", "Falls ZEN geöffnet ist, bestätige beenden des Editors", "Potwierdź wyjście, gdy ZEN jest otwarty" });
            words.Add("checkBoxLastZenAuto", new List<string> { "Открывать последний ZEN автоматически", "Auto opening last ZEN", "Letzte ZEN automatisch öffnen", "Otwórz automatycznie ostatni świat" });
            words.Add("checkBoxMiscFullPath", new List<string> { "Писать полный путь до ZEN в главном окне", "Show full path to ZEN file in main window", "Zeige den vollständigen Pfad zur ZEN Datei im Hauptmenü an", "Pokaż pełną ścieżkę do świata w głównym oknie" });
            words.Add("WIN_CONTROLSET_TEXT", new List<string> { "Настройки управления", "Controls setttings", "Steuerungseinstellungen", "Ustawienia sterowania" });
            words.Add("WIN_CONTROLSET_TRANSSPEED", new List<string> { "Скорость перемещения: ", "Moving speed: ", "Bewegungsgeschwindigkeit: ", "Szybkość poruszania: " });
            words.Add("WIN_CONTROLSET_ROTSPEED", new List<string> { "Скорость вращения: ", "Rotation speed: ", "Rotationsgeschiwndigkeit: ", "Szybkość rotacji: " });
            words.Add("WIN_CONTROLSET_GROUP0", new List<string> { "Управление вобом", "Vob control", "Vob Kontrolle", "Kontrola Voba" });
            words.Add("WIN_CONTROLSET_GROUP1", new List<string> { "Вставка воба", "Vob insertion", "Vob Einfügung", "Wstawianie Voba" });
            words.Add("checkBoxInsertVob", new List<string> { "Вставлять воб на той же высоте", "Insert vob on the source height", "Füge Vob in der Höhe der Quelle ein", "Wstaw Voba na wysokości kamery" });
            words.Add("checkBoxVobRotRandAngle", new List<string> { "Поворачивать воб на случайный угол", "Turn vob on a random angle", "Versetze den Vob in einen zufälligen Winkel", "Obróć voba pod dowolnym kątem" });
            words.Add("checkBoxVobInsertHierarchy", new List<string> { "Учитывать иерархию при копировании", "Use hierarchy when copying", "Nutze die Hierachie beim Kopieren", "Użyj hierarchi podczas kopiowania" });
            words.Add("labelRotWpFP", new List<string> { "Разворачивать WP/FP при вставке", "Turn WP/FP when inserting", "WP/FP beim Einfügen drehen", "Obróć WP/FP podczas dodawania" });
            words.Add("radioButtonWPTurnNone", new List<string> { "Нет", "None ", "Keine ", "Brak" });
            words.Add("radioButtonWPTurnAgainst", new List<string> { "От камеры", "From the camera", "Von der Kamera aus", "Z kamery" });
            words.Add("radioButtonWPTurnOn", new List<string> { "На камеру", "At the camera", "Bei der Kamera", "Do kamery" });
            words.Add("WIN_CONTROLCAM_TEXT", new List<string> { "Настройки камеры", "Camera settings", "Kameraeinstellungen", "Ustawienia kamery" });
            words.Add("groupBoxCam", new List<string> { "Камера", "Camera", "Kamera", "Kamera" });
            words.Add("labelTrans", new List<string> { "Скорость полета", "Moving speed", "Bewegungsgeschwindigkeit", "Prędkość poruszania" });
            words.Add("labelRot", new List<string> { "Скорость повотора", "Rotation speed", "Rotationsgeschiwndigkeit", "Prędkość rotacji" });
            words.Add("groupBoxRange", new List<string> { "Прорисовка", "Rendering range", "Sichtweite", "Zasięg renderowania" });
            words.Add("labelWorld", new List<string> { "Мир", "World", "Welt", "Świat" });
            words.Add("labelVobs", new List<string> { "Вобы", "Vobs", "Vobs", "Obiekty" });
            words.Add("labelLimitFPS", new List<string> { "Ограничить FPS", "Limit FPS", "FPS Limit", "Limit FPS" });
            words.Add("groupBoxInfo", new List<string> { "Информация", "Information", "Information", "Informacje" });
            words.Add("checkBoxFPS", new List<string> { "Показывать FPS", "Show FPS", "Zeige FPS", "Pokaż FPS" });
            words.Add("checkBoxTris", new List<string> { "Показывать кол-во рисуемых треугольников", "Show rendered triangles", "Zeige Anzahl gerenderter Tris.", "Pokaż ilość renderowanych trójkątów" });
            
            words.Add("checkBoxVobs", new List<string> { "Показывать кол-во вобов", "Show vobs count", "Zeige die Vobs Anzahl", "Pokaż ilość vobów" });
            words.Add("checkBoxWaypoints", new List<string> { "Показывать кол-во вейпоинтов", "Show waypoints count", "Zeige die Wegpunktanzahl", "Pokaż ilość Waypointów" });
            words.Add("checkBoxDistVob", new List<string> { "Показывать расстояние до выбранного воба", "Show distance to selected vob", "Zeige die Distanz zum ausgewählen Vob", "Pokaż dystans do zaznaczonego voba" });
            words.Add("checkBoxCameraHideWins", new List<string> { "Скрывать окна при полете камеры", "Hide windows when moving camera", "Verstecke die Menüs während der Kamerabewegung", "Ukryj okna podczas poruszania kamerą" });
            words.Add("WIN_KEYSBIND_TEXT", new List<string> { "Сочетания клавиш", "Keys binding", "Tasteneinstellungen", "Przypisanie klawiszy" });
            words.Add("WIN_KEYSBIND_DESC", new List<string> { "Описание", "Description", "Beschreibung", "Opis" });
            words.Add("WIN_KEYSBIND_BINDS", new List<string> { "Сочетание", "Bind", "Festlegen", "Powiązanie" });
            words.Add("WIN_KEYSBIND_KEY_SPACE", new List<string> { "Пробел", "Space", "Leertaste", "Spacja" });
            words.Add("WIN_KEYSBIND_KEY_ARROW_LEFT", new List<string> { "Стрелка влево", "Arrow left", "linke Pfeiltaste", "Strzałka w lewo" });
            words.Add("WIN_KEYSBIND_KEY_ARROW_UP", new List<string> { "Стрелка вверх", "Arrow up", "obere Pfeiltaste", "Strzałka w górę" });
            words.Add("WIN_KEYSBIND_KEY_ARROW_RIGHT", new List<string> { "Стрелка вправо", "Arrow right", "rechte Pfeiltaste", "Strzałka w prawo" });
            words.Add("WIN_KEYSBIND_KEY_ARROW_DOWN", new List<string> { "Стрелка вниз", "Arrow down", "untere Pfeiltaste", "Strzałka w dół" });
            words.Add("CAMERA_TRANS_FORWARD", new List<string> { "Камера (вперед)", "Camera (forward)", "Kamera (vorwärts)", "Kamera (do przodu)" });
            words.Add("CAMERA_TRANS_BACKWARD", new List<string> { "Камера (назад)", "Camera (backward)", "Kamera (rückwärts)", "Kamera (do tyłu)" });
            words.Add("CAMERA_TRANS_RIGHT", new List<string> { "Камера (вправо)", "Camera (right)", "Kamera (rechts)", "Kamera (w prawo)" });
            words.Add("CAMERA_TRANS_LEFT", new List<string> { "Камера (влево)", "Camera (left)", "Kamera (links)", "Kamera (w lewo)" });
            words.Add("CAMERA_TRANS_UP", new List<string> { "Камера (вверх)", "Camera (up)", "Kamera (oben)", "Kamera (do góry)" });
            words.Add("CAMERA_TRANS_DOWN", new List<string> { "Камера (вниз)", "Camera (down)", "Kamera (unten)", "Kamera (w dół)" });
            words.Add("CAM_SPEED_X10", new List<string> { "Увеличить скорость полета камеры в 10 раз", "Increase camera moving speed x10", "Erhöhe Kamerageschwindigkeit x10", "Zwiększ prędkość kamery x10" });
            words.Add("CAM_SPEED_MINUS_10", new List<string> { "Уменьшить скорость полета камеры в 10 раз", "Decrease camera moving speed x10", "Verringere Kamerageschwindigkeit x10", "Zmniejsz prędkość kamery x10" });
            words.Add("VOB_COPY", new List<string> { "Скопировать воб", "Copy vob", "Kopiere Vob", "Kopiuj voba" });
            words.Add("VOB_INSERT", new List<string> { "Вставить воб", "Insert vob", "Füge Vob ein", "Wklej voba" });
            words.Add("VOB_CUT", new List<string> { "Вырезать воб (смена родителя)", "Cut vob (parent change)", "Schneide Vob aus (Elternwechsel)", "Wytnij voba (Zmiana nadrzędnego)" });
            words.Add("VOB_FLOOR", new List<string> { "Прижать воб к полу", "Floor the vob", "Den Vob auf den Boden setzen", "Umieść voba na podłodze" });
            words.Add("VOB_RESET_AXIS", new List<string> { "Сбросить направление воба по осям", "Reset axes of the vob", "Die Achse vom Vob resetten", "Zresetuj osie voba" });
            words.Add("VOB_DELETE", new List<string> { "Удалить воб", "Remove vob", "Vob entfernen", "Usuń voba" });
            words.Add("VOB_TRANSLATE", new List<string> { "Инструмент перемещение", "Tool moving", "Bewegungswerkzeug", "Narzędzie poruszania" });
            words.Add("VOB_ROTATE", new List<string> { "Инструмент вращение", "Tool rotating", "Rotationswerkzeug", "Narzędzie rotacji" });
            words.Add("WP_TOGGLE", new List<string> { "Переключить соединение между вейпоинтами", "Toggle connection between waypoints", "Verbindung zwischen Wegpunkten umschalten", "Pokaż połączenia między Waypointami" });
            words.Add("VOB_DISABLE_SELECT", new List<string> { "Снять выделение с воба", "Unselect the vob", "Die Auswahl vom Vob aufheben", "Odznacz voba" });
            words.Add("VOB_NEAR_CAM", new List<string> { "Переместить воб перед камерой", "Move vob in front of the camera", "Bewege den Vob vor die Kamera", "Przenieś voba przed kamerę" });
            words.Add("VOB_TRANS_FORWARD", new List<string> { "Перемещение воба (вперед)", "Moving vob (forward)", "Bewege den Vob (vorwärts)", "Poruszanie voba (do przodu)" });
            words.Add("VOB_TRANS_BACKWARD", new List<string> { "Перемещение воба (назад)", "Moving vob (back)", "Bewege den Vob (rückwärts)", "Poruszanie voba (do tyłu)" });
            words.Add("VOB_TRANS_LEFT", new List<string> { "Перемещение воба (влево)", "Moving vob (left)", "Bewege den Vob (links)", "Poruszanie voba (w lewo)" });
            words.Add("VOB_TRANS_RIGHT", new List<string> { "Перемещение воба (вправо)", "Moving vob (right)", "Bewege den Vob (rechts)", "Poruszanie voba (w prawo)" });
            words.Add("VOB_TRANS_UP", new List<string> { "Перемещение воба (вверх)", "Moving vob (up)", "Bewege den Vob (oben)", "Poruszanie voba (w górę)" });
            words.Add("VOB_TRANS_DOWN", new List<string> { "Перемещение воба (вниз)", "Moving vob (down)", "Bewege den Vob (unten)", "Poruszanie voba (w dół)" });
            words.Add("VOB_SPEED_X10", new List<string> { "Увеличить скорость перемещения/вращения воба в 10 раз", "Increase vob moving/rotating speed x10", "Erhöhe Vob Bewegungsgeschwindigkeit/Rotationsgeschiwndigkeit x10", "Zwiększ szybkość przemieszacznia i rotacji x10" });
            words.Add("VOB_SPEED_MINUS_10", new List<string> { "Уменьшить скорость перемещения/вращения воба в 10 раз", "Decrease vob moving/rotating speed x10", "Verringere vob Bewegungsgeschwindigkeit/Rotationsgeschiwndigkeit x10", "Zmniejsz szybkość przemieszacznia i rotacji x10" });
            words.Add("VOB_ROT_VERT_RIGHT", new List<string> { "Вращение воба вокруг верт. оси (по часовой стрелке)", "Rotating vob around vertical axis (clockwise)", "Den vob um die vertikale Achse rotieren lassen (Im Uhrzeigersinn)", "Obracanie voba w osi pionowej (zgodnie z wskazówkami zegara)" });
            words.Add("VOB_ROT_VERT_LEFT", new List<string> { "Вращение воба вокруг верт. оси (против часовой стрелки)", "Rotating vob around vertical axis (counterclock-wise)", "Den vob um die vertikale Achse rotieren lassen (Gegen den Uhrzeigersinn)", "Obracanie voba w osi pionowej (przeciwnie do wskazówek zegara)" });
            words.Add("VOB_ROT_FORWARD", new List<string> { "Вращение воба от себя", "Vob rotating from the camera", "Vob vor der Kamera rotieren lassen", "Rotacja voba od kamery" });
            words.Add("VOB_ROT_BACK", new List<string> { "Вращение воба на себя", "Vob rotating at the camera", "Vob in der Kamera rotieren lassen", "Rotacja voba w kamerze" });
            words.Add("VOB_ROT_RIGHT", new List<string> { "Вращение воба вправо", "Vob rotating to the right", "Vob rechtsherum rotieren lassen", "Rotacja voba w prawo" });
            words.Add("VOB_ROT_LEFT", new List<string> { "Вращение воба влево", "Vob rotating to the left", "Vob linksherum rotieren lassen", "Rotacja voba w lewo" });
            words.Add("VOBLIST_COLLECT", new List<string> { "Собрать вобы в окно Контейнер вобов", "Collect vobes in Vob-List window", "Alle vobs in der Vob-Liste sammeln", "Zbieraj voby w oknie listy-vobów" });
            words.Add("WP_CREATEFAST", new List<string> { "Создать WP/FP по кнопке", "Create WP/FP", "WP/FP erstellen", "Utwórz WP/FP" });
            words.Add("WIN_HIDEALL", new List<string> { "Скрыть все окна", "Hide all windows", "Alle Fenster verstecken", "Ukryj wszystkie okna" });
            words.Add("OPEN_CONTAINER", new List<string> { "Открыть содержимое контейнера oCMobContainer", "Open oCMobContainer container", "Öffne den oCMobContainer Container", "Otwórz kontener oCMobContainer" });
            words.Add("TOGGLE_BBOX", new List<string> { "Показать/Скрыть все BBox", "Show/Hide all the BBoxes", "Zeige/Verstecke alle BBoxen", "Pokaż/Ukryj wszystkie BBoxy" });
            words.Add("TOGGLE_INVIS", new List<string> { "Показать/Скрыть невидимые вобы", "Show/Hide invisible vobs", "Zeige/Verstecke alle unsichtbaren vobs", "Pokaż/Ukryj niewidzialne voby" });
            words.Add("TOGGLE_VOBS", new List<string> { "Показать/Скрыть все вобы", "Show/Hide all vobs", "Zeige/Verstecke alle vobs", "Pokaż/Ukryj wszystkie voby" });
            words.Add("TOGGLE_WAYNET", new List<string> { "Показать/Скрыть Waynet", "Show/Hide Waynet", "Zeige/Verstecke alle Wegpunkte", "Pokaż/Ukryj waynet" });
            words.Add("TOGGLE_HELPERS", new List<string> { "Показать/Скрыть help-вобы", "Show/Hide help vobs", "Zeige/Verstecke Hilfvobs", "Pokaż/Ukryj voby pomocnicze" });
            words.Add("WIN_TREE_TITLE", new List<string> { "Список объектов", "Objects list window", "Objektlisten Fenster", "Okno listy obiektów" });
            words.Add("buttonCollapse", new List<string> { "Свернуть все", "Collapse all", "Alle einklappen", "Ukryj wszystkie" });
            words.Add("buttonExpand", new List<string> { "Развернуть все", "Expand all", "Alles ausklappen", "Rozwiń wszystkie" });
            words.Add("buttonTreeSort", new List<string> { "Сортировать", "Sort", "Sortieren", "Sortuj" });
            words.Add("CONTEXTMENU_TREE_INSERT_VOBTREE_PARENT", new List<string> { "Вставить VobTree в выделенный воб", "Insert VobTree into the vob", "Einen Vobbaum in den Vob einfügen", "Dodaj Drzewko-Vobów do voba" });
            words.Add("CONTEXTMENU_TREE_INSERT_VOBTREE_GLOBAL", new List<string> { "Вставить VobTree глобально", "Insert VobTree globally", "Einen Vobbaum global einfügen", "Dodaj Drzewko-Vobów globalnie" });
            words.Add("CONTEXTMENU_TREE_SAVE_VOBTREE", new List<string> { "Сохранить выделенный воб в VobTree", "Save vob as VobTree", "Vob als Vobbaum speichern", "Zapisz voba jako Drzewko-Vobów" });
            words.Add("CONTEXTMENU_TREE_REMOVE_VOB", new List<string> { "Удалить воб", "Remove the vob", "Vob entfernen", "Usuń voba" });
            words.Add("WIN_VOBLIST_TITLE", new List<string> { "Контейнер вобов", "VobList window", "Vob-Liste", "Okno listy vobów" });
            words.Add("labelVobType", new List<string> { "Тип воба", "Vob type", "Vob Typ", "Typ voba" });
            words.Add("labelRadius", new List<string> { "Радиус поиска", "Search radius", "Suchradius", "Promień wyszukiwania" });
            words.Add("WIN_SOUND_TITLE", new List<string> { "Звуки и музыка", "Sounds and music window", "Sound und Musik Fenster", "Okno dźwięku i muzyki" });
            words.Add("groupBoxSound", new List<string> { "Звуки", "Sounds", "Sounds", "Dźwięki" });
            words.Add("groupBoxMusic", new List<string> { "Музыка", "Music", "Musik", "Muzyka" });
            words.Add("buttonPlaySound", new List<string> { "Воспроизвести", "Play", "Abspielen", "Odtwórz" });
            words.Add("labelAllSounds", new List<string> { "Все звуки. Кол-во", "All sound. Count", "Alle Sounds. Anzahl", "Wszystkie dźwięki. Ilość" });
            words.Add("labelSndList", new List<string> { "Поиск по рег. выражению", "Search using regex", "Suche mit regex", "Wyszukaj za pomocą wyrażenia regularnego" });
            words.Add("buttonOffMusic", new List<string> { "Отключить музыку", "Turn off music", "Musik abschalten", "Wyłącz muzykę" });
            words.Add("buttonMusicOn", new List<string> { "Включить музыку", "Turn on music", "Musik anschalten", "Włącz muzykę" });
            words.Add("checkBoxShutMusic", new List<string> { "Отключать музыку при загрузке", "Shut music after world loaded", "Musik nach Welt laden Stummen", "Wyłącz muzykę po wczytaniu świata" });
            words.Add("labelMusicVolume", new List<string> { "Громкость", "Volume", "Lautstärke", "Głośność" });

            words.Add("WIN_PROPS_TITLE", new List<string> { "Окно свойств", "Properties window", "Eigenschaftenfenster", "Okno właściwości" });
            words.Add("buttonApplyOnVob", new List<string> { "Применить на вобе", "Apply on the vob", "Auf den vob anwenden", "Zastosuj dla voba" });
            words.Add("buttonFileOpen", new List<string> { "Файл", "File", "Datei", "Plik" });
            words.Add("buttonRestoreVobProp", new List<string> { "Восстановить", "Restore", "Wiederherstellen", "Przywróć" });
            words.Add("buttonOpenContainer", new List<string> { "Контейнер", "Container", "Container", "Kontener" });
            words.Add("tabControlProps_0", new List<string> { "Редактирование", "Edit", "Editieren", "Edytuj" });
            words.Add("tabControlProps_1", new List<string> { "BBox", "Bbox", "Bbox", "BBox" });
            words.Add("tabControlProps_2", new List<string> { "Контейнер", "Container", "Container", "Kontener" });
            words.Add("groupBoxEditBbox", new List<string> { "Редактирование BBox", "Editing BBox", "BBox Bearbeitung", @"Edytuj BBox'y" });
            words.Add("NO_ITEM_NAME", new List<string> { "Имя вещи не может быть пустым! Строка: ", "Item name is empty! Row: ", "Itemname ist leer! Reihe:", "Nazwa przedmiotu jest pusta! Rząd: " });
            words.Add("NO_ITEM_COUNT", new List<string> { "Кол-во итемов не может быть пустым! Строка: ", "Item count is empty! Row: ", "Itemanzahl ist leer! Reihe:", "Ilość przedmiotów jest pusta! Rząd: " });
            words.Add("ITEM_BAD_COUNT", new List<string> { "Некорректное число итемов. Строка: ", "Bad item count value! Row: ", "Falscher Itemanzahl Wert! Reihe:", "Zła wartość ilości przedmiotu! Rząd: " });
            words.Add("groupBoxContainer", new List<string> { "Редактирование BBox", "Editing BBox", "BBox Bearbeitung", @"Edytuj BBox'y" });
            words.Add("buttonClearItems", new List<string> { "Очистить все", "Clear all", "Alles löschen", "Wyczyść wszystkie" });
            words.Add("buttonRowDelete", new List<string> { "Удалить текущую", "Remove current", "Aktuelles entfernen", "Wyczyść obecny" });
            words.Add("ITEMS_COLUMN_INSTANCE", new List<string> { "Инстанция", "Instance", "Instanz", "Instancja" });
            words.Add("ITEMS_COLUMN_COUNT", new List<string> { "Кол-во", "Count", "Anzahl", "Ilość" });
            words.Add("WIN_OBJ_TITLE", new List<string> { "Окно объектов", "Objects window", "Objektfenster", "Okno obiektów" });
            words.Add("WIN_OBJ_TAB0", new List<string> { "Все классы", "All classes", "Alle Klassen", "Wszystkie klasy" });
            words.Add("WIN_OBJ_TAB1", new List<string> { "Вещи", "Items", "Items", "Przedmioty" });
            words.Add("WIN_OBJ_TAB2", new List<string> { "Эффекты", "Particles", "Partikel", "Efekty cząsteczkowe" });
            words.Add("WIN_OBJ_TAB3", new List<string> { "Триггеры", "Triggers", "Triggers", "Wyzwalacze" });
            words.Add("WIN_OBJ_TAB4", new List<string> { "WP/FP", "WP/FP", "WP/FP", "WP/FP" });
            words.Add("WIN_OBJ_TAB5", new List<string> { "Поиск", "Search", "Suche", "Szukaj" });
            words.Add("WIN_OBJ_TAB6", new List<string> { "Камера", "Camera", "Kamera", "Kamera" });
            words.Add("WIN_OBJ_TAB7", new List<string> { "Свет", "Light", "Licht", "Światło" });
            words.Add("WIN_OBJ_ALLMODELS", new List<string> { "Поиск визуала", "Visual search", "Visuelle Suche", "Szukaj wyglądu" });
            words.Add("WIN_OBJ_ALL", new List<string> { "всего", "count", "Anzahl", "ilość" });
            words.Add("WIN_OBJ_TYPE_CANTHERE", new List<string> { "Данный тип воба создается в отдельной вкладке справа!", "This vob type can be created in a special tab!", "Dieser Vob Typ kann in einem speziellen Tap erschaffen werden", "Ten typ voba może zostać dodany w specjalnej zakładce!" });
            words.Add("WIN_OBJ_NO_EMPTY_NAME", new List<string> { "Нельзя ввести пустое имя!", "You can't enter an empty name!", "Es kann kein leerer Name genutzt werden!", "Nie możesz podać pustej nazwy!" });
            words.Add("WIN_OBJ_NO_WAYPOINT_NUMBERSONLY", new List<string> { "Имя вейпоинта не может состоять только из цифр!", "Waypoint can't have only numbers in its name!", "Ein Wegpunkte kann nicht nur Zahlen in seinem Namen enthalten", "Waypoint nie może mieć tylko liczb w nazwie!" });
            words.Add("WIN_OBJ_SEARCHVISUAL", new List<string> { "всего", "count", "Anzahl", "ilość" });
            words.Add("WIN_OBJ_SEARCHVISUAL_ALL", new List<string> { "Поиск визуала. Всего", "Visual search. Count", "Visuelle Suche. Anzahl", "Wyszukiwanie po wyglądzie. Ilość" });
            words.Add("COPYBUFFER", new List<string> { "Скопировано в буфер", "Copied to clipboard", "In die Zwischenablage kopieren", "Skopiowano do schowka" });
            words.Add("groupBoxObjAllClasses", new List<string> { "Все классы вобов", "All vobs classes", "Alle Vob Klassen", "Wszystkie klasy vobów" });
            words.Add("groupBoxObjPropVobs", new List<string> { "Свойства воба", "Vob properties", "Vob Eigenschaften", "Właściwości voba" });
            words.Add("labelObjAllClassesNameVob", new List<string> { "Имя воба", "Vob name", "Vob Name", "Nazwa voba" });
            words.Add("buttonAllClassesCreateVob", new List<string> { "Создать Vob", "Create Vob", "Vob erstellen", "Utwórz voba" });
            words.Add("checkBoxDynStat", new List<string> { "Динамич. коллизия", "Dynamic collision", "Dynamische Kollision", "Kolizja dynamiczna" });
            words.Add("checkBoxStaStat", new List<string> { "Стат. коллизия", "Static collision", "Statische Kollision", "Kolizja statyczna" });
            words.Add("checkBoxShowPreview", new List<string> { "Показывать модель", "Show model preview", "Zeige Modelvorschau", "Pokaż podgląd modelu" });
            words.Add("checkBoxSearchOnly3DS", new List<string> { "Искать только 3DS", "Search only 3DS", "Suche nur in 3DS", "Szukaj tylko 3DS" });
            words.Add("buttonAllClassesClear", new List<string> { "Очистить", "Clear", "Löschen", "Wyczyść" });
            words.Add("groupBoxObjItems", new List<string> { "Предметы", "Items", "Items", "Przedmioty" });
            words.Add("buttonItemsCreate", new List<string> { "Создать Item", "Create Item", "Item erschaffen", "Utwórz przedmiot" });
            words.Add("buttonAddContainer", new List<string> { "Добавить в контейнер->", "Add to container->", "Dem Contrainer hinzufügen->", "Dodaj do kontenera->" });
            words.Add("groupBoxItemsCont", new List<string> { "Редактор сундука", "Edit the container", "Den Container bearbeiten", "Edytuj kontener" });
            words.Add("checkBoxItemShow", new List<string> { "Отображать вещь на экране", "Show model preview", "Zeige Modelvorschau", "Pokaż podgląd modelu" });
            words.Add("labelItemsEditContCount", new List<string> { "Количество", "Count", "Anzahl", "Ilość" });
            words.Add("labelItemsAllItems", new List<string> { "Все вещи игры", "All game items", "Alle Spielitems", "Wszystkie przedmioty z gry" });
            words.Add("labelItemsFindReg", new List<string> { "Поиск по рег. выражению", "Search using regex", "Mit regex suchen", "Wyszukiwanie standardowe" });
            words.Add("groupBoxPFX", new List<string> { "Эффекты частиц", "Particles", "Partikel", "Efekty cząsteczkowe" });
            words.Add("buttonParticles", new List<string> { "Создать PFX", "Create PFX", "PFX erschaffen", "Utwórz PFX" });
            words.Add("checkBoxShowPFXPreview", new List<string> { "Отображать эффект на экране", "Show PFX preview", "Zeige PFX Vorschau", "Pokaż podgląd PFX" });
            words.Add("labelAllPfx", new List<string> { "Все эффекты игры", "All game PFXes", "Alle Spiel PFXs", @"Wszystkie PFX'y z gry" });
            words.Add("groupBoxTriggersVob", new List<string> { "Выбранный воб", "Selected vob", "Ausgewählter Vob", "Wybrany vob" });
            words.Add("groupBoxTriggersKeys", new List<string> { "Ключи", "Keys", "Tasten", "Klawisze" });
            words.Add("buttonSendTrigger", new List<string> { "Запустить >>>", "Run >>>", "Starten >>>", "Uruchom >>>" });
            words.Add("buttonTriggerCollectSources", new List<string> { "Собрать", "Collect", "Einsammeln", "Zbierz" });
            words.Add("buttonNewKey", new List<string> { "Новый ключ", "New key", "Neuer Key", "Nowy klawisz" });
            words.Add("buttonRemoveKey", new List<string> { "Удалить ключ", "Remove key", "Key entfernen", "Usuń klawisz" });
            words.Add("labelTriggerName", new List<string> { "Триггер", "Trigger", "Trigger", "Wyzwalacze" });
            words.Add("labelTriggerCollision", new List<string> { "Коллизия", "Collision", "Kollision", "Kolizja" });
            words.Add("checkBoxDyn", new List<string> { "динамическая", "dynamic", "Dynamisch", "dynamiczna" });
            words.Add("checkBoxStat", new List<string> { "статическая", "static", "Statisch", "statyczna" });
            words.Add("radioButtonOverwrite", new List<string> { "перезаписать", "overwrite", "überschreiben", "nadpisz" });
            words.Add("labelTriggerInsert", new List<string> { "Вставить", "Insert key", "Taste einfügen", "Dodaj klawisz" });
            words.Add("radioButtonAfter", new List<string> { "после", "after", "danach", "przed" });
            words.Add("radioButtonBefore", new List<string> { "до", "before", "davor", "po" });
            words.Add("labelTriggerTargets", new List<string> { "Цели (targets)", "Targets", "Ziele", "Cele" });
            words.Add("labelTriggersSources", new List<string> { "Источники (sources)", "Sources", "Quellen", "Źródła" });
            words.Add("groupBoxWPFP", new List<string> { "Мировые точки", "World points", "Weltpunkte", "Punkty świata" });
            words.Add("labelNameWPMandatory", new List<string> { "Имя Waypoint (обязательно)", "Waypoint name (mandatory)", "Wegpunktname (verpflichtend)", "Nazwa waypointa (obowiązkowa)" });
            words.Add("labelFreepointMandatory", new List<string> { "Имя Freepoint (обязательно)", "Freepoint name (mandatory)", "Freepoint Name (verpflichtend)", "Nazwa freepointa (obowiązkowa)" });
            words.Add("checkBoxWayNet", new List<string> { "Сразу соединять в сеть", "Connect to waynet at once", "Einmalig dem Wegenetzwerk hinzufügen", "Połącz natychmiast z waynetem" });
            words.Add("checkBoxWPAutoName", new List<string> { "Автогенерация имени", "Auto-generated name", "Automatischer Namengenerator", "Nazwa wygenerowana automatycznie" });
            words.Add("checkBoxFPGround", new List<string> { "Прижимать к земле", "Floor the freepoint", "Den Freepoint an den Boden haften", @"Połóż freepoint'a na podłodze" });
            words.Add("checkBoxAutoNameFP", new List<string> { "Автогенерация имени", "Auto-generated name", "Automatischer Namengenerator", "Nazwa wygenerowana automatycznie" });
            words.Add("buttonWPCreate", new List<string> { "Создать Waypoint", "Create Waypoint", "Wegpunkt erstellen", "Utwórz Waypoint" });
            words.Add("buttonConnectWp", new List<string> { "Соединить WP", "Connect waypoints", "Wegpunkte verbinden", "Połącz Waypointy" });
            words.Add("buttonDisconnectWP", new List<string> { "Разъединить WP", "Disconnect waypoints", "Wegpunkte trennen", "Rozłącz Waypointy" });
            words.Add("buttonFPCreate", new List<string> { "Создать Freepoint", "Create Freepoint", "Freepoint erstellen", "Utwórz Freepoint" });

            //NEW
            words.Add("labelCamSetSlerp", new List<string> { "Плавность поворота камеры", "Camera rotation smoothing", "Kameraroation glätten", "Wygładzenie rotacji kamery" });
            words.Add("keysResetDefault", new List<string> { "Сбросить по-умолчанию", "Reset default", "Einstellung zurückstellen", "Przywróć domyślne" });
            words.Add("confirmText", new List<string> { "Вы уверены?", "Are you sure?", "Bist du dir sicher ?", "Jesteś pewny?" });
            words.Add("MENU_TOP_MERGEMESH", new List<string> { "Объединить MESH...", "Merge MESH...", "MESH zusammenfügen...", "Połącz MESH..." });

            words.Add("LIGHT_RAD_INC", new List<string> { "Увеличить радиус освещения", "Increase light radius", "Lichtradius erhöhen", "Zwiększ promień światła" });
            words.Add("LIGHT_RAD_DEC", new List<string> { "Уменьшить радиус освещения", "Decrease light radius", "Lichtradius verringern", "Zmniejsz promień światła" });
            words.Add("LIGHT_RAD_ZERO", new List<string> { "Сбросить радиус освещения", "Reset light radius to 0", "Lichtradius auf 0 setzen", "Zresetuj promień światła do wartości 0" });
            words.Add("checkBoxSelectMoveInsert", new List<string> { "Включать инструмент перемещение при вставке воба", "Select Moving tool after inserting a vob", "Bewegungswerkzeug auswählen, nachdem vob eingefügt worden ist", "Wybierz narzędzie przemieszczania przed dodaniem voba" });

            words.Add("labelSpeedPreview", new List<string> { "Скорость вращения превью-модели", "Model preview rotation speed", "Rotationsgeschwindigkeit der Modelvorschau", "Prędkość rotacji podglądu" });

            words.Add("loadMeshTimeAll", new List<string> { "Общее время объединения всех мешей", "Total time of merging all the meshes", "Gesamtzeit um alle Meshes zu verschmelzen", @"Czałkowicy czas łączenia wszystkich mesh'y" });

            words.Add("WORK_PATH_ERROR", new List<string> { "Вы пытаетесь загрузить файл, который не находится в папке _WORK/DATA/. Поместите файл внутрь игры!", "You are trying to load a file which is not in _WORK/DATA/. Place this file inside the game folder!", "Du versuchst eine Datei zu laden, welche nicht im _WORK/DATA/ Ordner ist. Kopiere die Datei zuerst in den Spieleordner!", "Próbujesz wczytać plik, który nie znajduje się w _WORK/DATA/. Umieść go w folderze gry!" });
            words.Add("buttonStopAllSounds", new List<string> { "Заглушить все звуки", "Turn off all sounds", "Alle Sounds abschalten", "Wyłącz wszystkie dźwięki" });
            //

            words.Add("vobs_found_amount", new List<string> { "Найдено", "Found", "Gefunden", "Klasy vobów" });
            words.Add("all_vobs_classes", new List<string> { "Все классы вобов", "Vob classes", "Vob Klassen", "Szukaj w klasach pochodnych" });
            words.Add("search_derived", new List<string> { "Искать в дочерних классах", "Search in derived classes", "In der abgeleiteten Klasse suchen", "Szukaj w klasach pochodnych" });
            words.Add("search_use_regex", new List<string> { "Использовать рег. выражение", "Use regular expression", "Reguläre expression nutzen", "Użyj standardowego wyrażenia" });
            words.Add("BTN_RESET", new List<string> { "Сбросить", "Reset", "Zurücksetzen", "Reset" });

            words.Add("NAME_ALREADY_EXISTS", new List<string> { "Такое имя уже существует!", "This name already exists!", "Diesen Namen gibt es bereits!", "Ta nazwa jest już zajęta!" });
            words.Add("Label_Backup", new List<string> { "Старое значение", "Old value", "Alter Wert", "Stara wartość" });
            words.Add("SET_ANY_FIELD_SEARCH", new List<string> { "Выберите хотя бы одно поле!", "Select one field at least!", "Du musst zumindestens ein Feld auswählen!", "Wybierz przynajmniej jedno pole!" });

            words.Add("VOB_SEARCH_START", new List<string> { "Поиск вобов начался...", "Looking for vobs...", "Suche nach Vobs...", "Rozglądanie się za vobami..." });


            //
            words.Add("BAD_REGEX", new List<string> { "Введено некорректное регулярное выражение!", "Wrong regular expression!", "Falscher Regex eingeführt!", "Błędne wyrażenie regularne!" });
            words.Add("VOB_SEARCH_TYPE0", new List<string> { "Искать", "Search", "Suchen", "Szukaj" });

            words.Add("VOB_SEARCH_REPLACEZEN", new List<string> { "Заменено вобов на VobTree: ", "Vobs replaced with VobTree: ", "Vobs mit Vobbaum ersetzt: ", "Voby zastąpione drzewkiem vobów: " });
            words.Add("VOB_SEARCH_REMOVEVOBS", new List<string> { "Удалено вобов: ", "Vobs removed: ", "Vobs entfernt: ", "Usunięto voby: " });
            words.Add("NO_REPLACE_VOBTREE", new List<string> { "VobTree не выбран!", "No VobTree selected!", "Kein Vobbaum ausgewählt!", "Nie wybrano drzewka vobów!" });
            words.Add("VOB_SEARCH_CONVERT", new List<string> { "Преобразовано вобов: ", "Vobs converted: ", " Vobs konvertiert: ", "Przekonwertowane voby: " });
            words.Add("VOB_SEARCH_STOP", new List<string> { "Найдено вобов: ", "Vobs found: ", "Vobs gefunden: ", "Znalezione voby: " });
            words.Add("VOB_SEARCH_TYPE1", new List<string> { "Конвертировать", "Convert", "Konvertieren", "Konwertuj" });
            words.Add("VOB_SEARCH_TYPE2", new List<string> { "Заменить на VobTree", "Replace with VobTree", "Mit Vobbaum tauschen", "Zamień na drzewko vobów" });
            words.Add("VOB_SEARCH_TYPE3", new List<string> { "Удалить", "Remove", "Entfernen", "Usuń" });
            words.Add("VOB_SEARCH_CONVERT_RADIO0", new List<string> { "Старый", "Old", "Alt", "Stary" });
            words.Add("VOB_SEARCH_CONVERT_RADIO1", new List<string> { "Новый", "New", "Neu", "Nowy" });


            words.Add("WARNING_VDF_FILE_OPEN", new List<string> { "Внимание! Файл был загружен из VDF/MOD, а не из _WORK/DATA!", "Warning! The file was loaded from VDF/MOD, not from _WORK/DATA!", "Achtung! Die Dati wurde von einer VDF/MOD und nicht vom _WORK/DATA geladen!", "Uwaga! Plik został załadowany z paczki VDF/MOD, nie z _WORK/DATA." });
            words.Add("VOB_SEARCH_TYPE4", new List<string> { "Переименовать", "Rename", "Umbenennen", "Zmień nazwę" });
            words.Add("VOB_SEARCH_RENAME_VOBS", new List<string> { "Переименовано вобов: ", "Vobs renamed: ", "Vobs umbeanannt: ", "Vobom zmieniono nazwę: " });
            words.Add("labelRenameVob", new List<string> { "Новое имя", "New name", "Neuer Name", "Nowa nazwa" });
            words.Add("checkBoxAutoNumerate", new List<string> { "Авто-нумерация имен", "Auto numeration of names", "Automatische Nummerierung der Namen", "Automatycznie numeruj nazwy" });

            words.Add("MENU_TOP_VIEW_FREEZETIME", new List<string> { "Заморозить время", "Freeze time", "Ingamezeit einfrieren", "Zatrzymanie czasu" });
            words.Add("MENU_TOP_VIEW_POLYGON", new List<string> { "Выделение полигона", "Polygon select", "Polygonauswahl", "Wybór polygonu" });
            words.Add("MENU_TOP_VIEW_RENDERMODE", new List<string> { "Режим рендера", "Render mode", "Renderermodus", "Tryb renderowania" });

            words.Add("CHECK_BADPLUGINS_MSG", new List<string> { "У вас есть плагины, которые могут помешать работе Spacer.net!", "You have plugins which may not work with Spacer.net!", "Möglicherweise sind Plugins installiert, welche nicht mit Spacer.net kompatibel sind!", "Masz pluginy, które mogą nie działać poprawnie z Spacer.net" });

            words.Add("WIN_GRASS_TITLE", new List<string> { "Сеятель объектов", "Objects sewer", "Objektgenerator", "Generator obiektów" });
            words.Add("WIN_GRASS_VOBMODEL", new List<string> { "Название модели воба:", "Vob's model:", "Vob Modell: ", "Model voba:" });
            words.Add("WIN_GRASS_VERTOFFSET", new List<string> { "Смещение воба по вертикали: ", "Vob's vertical offset: ", "Vertikaler Versatz vom Vob: ", "Przesunięcie pionowe voba:" });
            words.Add("WIN_GRASS_MINRADIUS", new List<string> { "Мин. расстояние между вобами: ", "Minimal distance between vobs: ", "Minimale Distanz zwischen Vobs: ", "Minimalny dystans pomiędzy vobami:" });
            words.Add("VOB_SEARCH_TYPE_DYNAMIC", new List<string> { "Сменить динамич. коллизию", "Toggle dynamic collision", "Dynamische Kollision umschalten", "Przełącz dynamiczną kolizję" });
            words.Add("VOB_SEARCH_DYNCOLL_VOBS", new List<string> { "Проставлено коллизий: ", "Collisions set: ", "Kollision eingestellt: ", "Ustawione kolizje:" });
            words.Add("MENU_TOP_SAVEZENUNC", new List<string> { "Сохранить Vobs", "Save Vobs", "Vobs Speichern", "Zapisz Voby" });


            words.Add("WIN_GRASS_COPYNAME", new List<string> { "При выделении модели в поиске копировать ее сюда", "Copy model name from another window", "Modellnamen aus einem anderen Fenster kopieren", "Skopiuj nazwę modelu z innego okna" });
            words.Add("WIN_GRASS_REMOVE", new List<string> { "Режим удаления вобов", "Removing vob mod", "Entfernen der Vob modifikation", "Usuwanie vobów z moda" });
            words.Add("WIN_GRASS_ISITEM", new List<string> { "Воб - это oCItem", "Inserted vob is oCItem", "Vob als oCItem einfügen", "Dodany vob to oCItem" });
            words.Add("WIN_GRASS_PROTECT", new List<string> { "Защита от зажатия левой кнопки мыши", "Protect from left mouse button pushing", "Schutz vor Drücken der linken Maustaste", "Ochrona przed naciśnięciem lewego przycisku myszki" });
            words.Add("WIN_GRASS_DYNCOLL", new List<string> { "Ставить вобу динамическую коллизию", "Set dynamic collision for vob", "Anschalten der Dynamischen Kollision", "Ustaw dynamiczną kolizję dla voba" });
            words.Add("WIN_GRASS_RANDANGLE", new List<string> { "Поворачивать воб на случайный угол вокруг вертикальной оси", "Rotate vob on random angle above vertical axis", "Drehen des Vobs um einen zufälligen Winkel über der vertikalen Achse", "Obróć vob o losowy kąt powyżej osi pionowej" });
            words.Add("WIN_GRASS_NORMALPOLYGON", new List<string> { "Ставить воб перпендикулярно полигону", "Set vob perpendicular to the polygon", "Vob rechtwinklig zum Polygon setzen", "Ustaw vob prostopadle do polygona" });
            words.Add("checkBoxMiscAutoCompile", new List<string> { "Автокомпиляция мира и света после объединения меша с вобами", "Autocompile world and light after merging mesh with vobs", "Autokompilieren von Welt und Licht nach dem Zusammenführen des Mesh mit Vobs", "Autokompilacja świata i światła po połączeniu mesha z vobami" });
            words.Add("checkBoxMiscAutoCompileUncZen", new List<string> { "Автокомпиляция мира и света при загрузки некомпилированного ZEN", "Autocompile world and light after loading uncompiled ZEN", "Autokompilieren von Welt und Licht nach dem Laden von nicht kompilierter ZEN", "Autokompilacja świata i światła po załadowaniu nieskompilowanego ZENA" });
            words.Add("autoRemoveLevelCompo", new List<string> { "Автоматически удалять лишний zCVobLevelCompo после объединения MESH с вобами", "Auto removing zCVobLevelCompo after merging mesh with vobs", "Automatisches Entfernen von zCVobLevelCompo nach dem Zusammenführen des Mesh mit Vobs", "Automatyczne usuwanie zCVobLevelCompo po połączeniu mesha z vobami" });



            words.Add("MENU_TOP_VIEW_GRASS", new List<string> { "Сеятель объектов", "Objects sewer", "Objektgenerator", "Generator obiektów" });
            words.Add("MENU_TOP_VIEW_ALTCONTROLLER", new List<string> { "Альтернативное управление", "Alternative controller", "Alternativer Controller", "Alternatywna kamera" });

            words.Add("CANT_APPLY_PARENT_VOB", new List<string> { "Данный тип воба не может быть родителем!", "This type of vob can't be a parent!", "Diese Art von Vob kann keine Übergeordung sein!", "Ten typ voba nie może być zapisany jako rodzic!" });

            words.Add("saveMeshTime", new List<string> { "Сохранение MESH выполнено за", "Saving MESH time...", "Speichern der MESH dauerte", @"Czas zapisywania MESH'a..." });
            words.Add("MENU_TOP_SAVEMESH", new List<string> { "Сохранить MESH", "Save MESH", "MESH Speichern", "Zapisz MESH" });

            words.Add("WIN_MSG_CONFIRM", new List<string> { "Подтвердите действие", "Confirm the action", "Bestätige die Aktion", "Potwierdź akcję" });
            words.Add("WIN_MSG_CONFIRM_PLACENEARCAM", new List<string> { "Вставить Vobtree перед камерой?", "Do insert vobtree near the camera?", "Vobtree in der Nähe der Kamera einfügen?", "Czy wstawiasz vobtree w pobliżu kamery?" });
            words.Add("CONTEXTMENU_TREE_ADD_PARENT", new List<string> { "Сделать глобальным родителем", "Make this vob as a global parent", "Dieses Vob als globale übergeordnet einrichten", "Stwórz ten vob jako globalnego rodzica dla wszystkich nowych vobów" });
            words.Add("CONTEXTMENU_TREE_REMOVE_PARENT", new List<string> { "Очистить глобального родителя", "Remove the global parent", "Globale Überordnung entfernen", "Usuń globalnego rodzica" });


            words.Add("CONTEXTMENU_TREE_ADD_VOB", new List<string> { "Добавить воб в быстрый доступ", "Add vob into Fast access list", "Vob in die Schnellzugriffsliste aufnehmen", "Dodaj vob do listy szybkiego dostępu" });
            words.Add("QUICKVOBS_PARENT", new List<string> { "Глобальный воб-родитель", "Global parent vob", "Globales Überordetes Vob", "Globalny rodzic voba" });
            words.Add("QUICKVOBS_ACCESS", new List<string> { "Быстрый доступ", "Fast access", "Schneller Zugriff", "Szybki dostęp" });
            words.Add("TAB_PAGE_OBJECTS", new List<string> { "Объекты", "Objects", "Objekte", "Obiekty" });
            words.Add("CONTEXTMENU_FAST_REMOVE_VOB", new List<string> { " Удалить воб из быстрого доступа", "Remove the vob from fast access", "Vob von der Schnellzugriffsliste löschen", "Usuń vob z szybkiego dostępu" });
            words.Add("QUICKVOBS_CANTBE_PARENT", new List<string> { "Данный воб не может быть родителем!", "Current vob can't be a parent!", "Aktuelles von kann nicht Übergeordnet sein!", "Obecny vob nie może być rodzicem!" });

            words.Add("PROP_BUTTON_COLOR", new List<string> { "Цвет", "Color", "Farbe", "Kolor" });
            words.Add("labelItemLocatorRadius", new List<string> { "Радиус показа вещей: ", "Items show radius: ", "Item Sichtweite", "Pokaż promień: " });
            words.Add("groupBoxItemsLocator", new List<string> { "Локатор предметов: ", "Items locator: ", "Item Locator: ", "Lokalizator przedmiotów" });
            words.Add("checkBoxLocatorEnabled", new List<string> { "Включить", "Enabled", "Aktiviert", "Włączony" });
            words.Add("checkBoxLocatorOnlySusp", new List<string> { "Только \"плохие\" oCItem", "Only 'bad' oCItem", "Nur 'schlechte' oCItem", "Tylko 'zły' oCItem" });

            words.Add("MENU_TOP_WIN_POS", new List<string> { "Положение окон", "Position of windows", "Position der Fenster", "Pozycja okien" });
            words.Add("MENU_TOP_WIN_POS_RESET", new List<string> { "Сбросить положение окон", "Reset windows' position", "Fenster Positionen zurücksetzen", "Zresetuj pozycje okien" });
            words.Add("MENU_TOP_WIN_POS_PRESET_1", new List<string> { "Использовать пресет #1 (FullHD)", "Use windows presets #1 (FullHD)", "Fenstervoreinstellungen #1 (FullHD) verwenden", "Użyj ustawień dla okien #1 (FullHD)" });
            words.Add("MENU_TOP_WIN_POS_PRESET_2", new List<string> { "Использовать пресет #2 (QuadHD)", "Use windows presets #2 (QuadHD)", "Fenstervoreinstellungen #2 (QuadHD) verwenden", "Użyj ustawień dla okien #2 (QuadHD)" });


            words.Add("checkBoxShutSounds", new List<string> { "Глушить звуки при загрузке", "Shut sounds after world loaded", "Sounds nach Welt laden Stummen", "Wyłącz dźwięki po załadowaniu świata" });
            words.Add("checkBoxConstSound", new List<string> { "Постоянно глушить звуки", "Always shut all sounds", "Immer alle Sounds stummen", "Zawsze wyłączaj wszystkie dźwięki" });
            words.Add("OnlyOneVobCanBe", new List<string> { "Воб такого типа может быть на карте ТОЛЬКО ОДИН!", "Only ONE vob like this can be on the map!", "Nur EIN Vob wie dieses kann auf der Karte sein!", "Tylko jeden vob takiego typu może znajdować się na mapie!" });

            words.Add("checkBoxAutoRemoveAllVisuals", new List<string> { "Автоматически очищать visual для всех zCVobLevelCompo при сохранении ZEN", "Auto cleaning visual for all zCVobLevelCompo before saving ZEN", "Automatische visuelle Reinigung für alle zCVobLevelCompo vor dem Speichern ZEN", "Automatyczne usuwanie visuali dla wszystkich zCVobLevelCompo przed zapisaniem ZENA" });
            words.Add("GAME_MODE", new List<string> { "Играть за героя", "Play the hero", "Spiele den Helden", "Zagraj bohaterem" });
            words.Add("ZEN_BAD_NAME", new List<string> { "В имени ZEN не может содержаться '.3DS' ! Переименуйте файл!", "ZEN's name can't contain '.3DS' ! Rename the file.", "Der Name der ZEN darf nicht '.3DS' enthalten! Benenne die Datei um.", "Nazwa ZEN nie może zawierać '.3DS' ! Zmień nazwę pliku." });
            words.Add("CONTEXTMENU_TREE_RESTORE_POS", new List<string> { "Восстановить позицию воба", "Restore vob's position", "Die Position des Vobs wiederherstellen", "Przywróć pozycję voba" });

            words.Add("CANT_COPY_INITSELF", new List<string> { "Нельзя скопировать и вставить глобального родителя в самого себя!", "Can't copy and insert global parent vob into itself!", "Kann keine globale übergeordnete Vob-Datei in sich selbst kopieren und einfügen!", "Nie można skopiować i dodać globalnego rodzica voba do siebie!" });
            words.Add("checkBoxSetNearestVobCam", new List<string> { "Устанавливать камеру на воб с именем VOB_SPACER_CAMERA_START или zCVobStartpoint после загрузки ZEN", "Set the camera near the vob with name VOB_SPACER_CAMERA_START or zCVobStartpoint after loading ZEN", "Setze die Kamera in der Nähe des Vobs mit dem Namen VOB_SPACER_CAMERA_START oder zCVobStartpoint nach dem Laden der ZEN", "Ustaw kamerę w pobliżu voba z nazwą VOB_SPACER_CAMERA_START lub zCVobStartpoint po załadowaniu ZENA" });


            words.Add("tabControlProps_3", new List<string> { "Настройки", "Settings", "Einstellungen", "Ustawienia" });
            words.Add("checkBoxBoldFontProps", new List<string> { "Выделять основные поля жирным шрифтом", "Use bold font for main fields", "Fettschrift für Hauptfelder verwenden", "Użyj pogrubionej czcionki dla głównych pól" });
            words.Add("checkBoxFontUnderstroke", new List<string> { "Выделять основные поля подчеркнутым шрифтом", "Use understroke font for main fields", "Unterstrichene Schriftart für Hauptfelder verwenden", "Użyj czcionki z podkreśleniem dla pól głównych" });
            words.Add("buttonSelectFontProps", new List<string> { "Выбрать шрифт для свойств", "Select font for properties", "Schriftart für Eigenschaften wählen", "Wybierz czcionkę dla właściwości" });
            words.Add("buttonResetFontDefault", new List<string> { "Сбросить шрифт по умолчанию", "Reset font by default", "Schriftart standardmäßig zurücksetzen", "Przywróć domyślną czcionkę" });
            words.Add("labelChangeFontStyleText", new List<string> { "* Для применения выберите объект снова", "* For applying reselect the object", "* Zum Anwenden das Objekt erneut auswählen", "* Aby zastosować ponownie wybierz obiekt" });

            words.Add("MENU_TOP_VIEW_MULTI", new List<string> { "Режим множественного выделения", "Multi selection mode", "Multi Selektions Modus", "Tryb wielokrotnego wyboru" });

            words.Add("TAB_PAGE_MATERIALS", new List<string> { "Материалы", "Materials", "Materialien", "Materiały" });
            words.Add("NoVisualForSuchVob", new List<string> { "Воб данного типа не может иметь визуал!", "This type of a vob can't have any visual!", "Dieser Typ Von kann kein Visual haben!", "Ten typ voba nie może mieć visuala!" });


            words.Add("MENU_TOP_SPECIAL_FUNCS", new List<string> { "Специальные функции", "Special functions", "Spezial Funktionen", "Funkcje specjalne" });
            words.Add("MENU_TOP_CREATE_VOB_VISUALS_LIST", new List<string> { "Сформировать список визуалов локации", "Create a list of files which are used in the location", "Erstelle eine Liste der Dateien, die in diesem Bereich verwendet werden", "Stwórz lisę plików, któresą używane w lokacji" });
            words.Add("labelFindVisualArchive", new List<string> { "Искать только в архиве (VDF)", "Search only in selected (VDF)", "Suche nur in ausgewählter (VDF)", "Szukaj tylko w wybranych (VDF)" });
            words.Add("checkBoxLocatorByName", new List<string> { "Искать по имени:", "Search by name:", "Suche nach Namen:", "Szukaj według nazwy:" });
            words.Add("checkBoxSearchHasChildren", new List<string> { "У воба есть дети", "Vob has children", "Vob hat untergeordnete", "Vob ma dzieci" });


            words.Add("CONTEXTMENU_TREE_REPLACE_FROM_PARENT", new List<string> { "Переместить все вобы из родителя", "Move all vobs from the parent", "Verschieben aller Vobs aus dem übergeordneten", "Przenieś wszystkie voby od rodzica" });
            words.Add("checkBoxCamShowPortalsInfo", new List<string> { "Показывать информацию о порталах", "Show portals info", "Zeige Portal Infos", "Pokaż info o portalach" });

            words.Add("CHECK_SORTING_POLYS", new List<string> { "Сортировать полигоны локации?\nСортировка полигонов в локации сильно замедляет сохранение больших локаций (по времени), однако, это необходимо делать для финальной версии локации, для промежуточных версий локации это необязательно и экономит время.", "Should we sort polygons of the location?\nSorting polygons is necessary for the final version of the location, but it requires much time for saving in big locations, for work version of locations you don't need to sort them every time while saving.", "Sollen die Polygone des Ortes sortiert werden? Das Sortieren der Polygone ist für die endgültige Version des Ortes notwendig, erfordert aber viel Zeit beim Speichern von großen Orten, für die Arbeitsversion von Orten müssen sie nicht jedes Mal beim Speichern sortiert werden.", "Czy chcesz sortować wielokąty lokacji?\nSortowanie wielokątów jest konieczne dla ostatniej wersji lokacji, ale wymaga dużo czasu przy zapisie w dużych lokacjach, dla wersji roboczych lokacji nie trzeba ich sortować za każdym razem przy zapisie." });
            words.Add("checkBoxShowPolysSort", new List<string> { "При сохранении больших локаций спрашивать о сортировке полигонов (более 200 тыс. полигонов)", "Ask for sorting polygons while saving big locations (more than 200k polygons)", "Frage nach dem Sortieren von Polygonen beim Speichern großer Orte (mehr als 200k Polygone)", "Sortowanie wielokątów podczas zapisywania dużych lokacji (ponad 200k wielokątów)" });

            //0.27

            words.Add("checkBoxShowVobTraceFloor", new List<string> { "Подсвечивать положение воба на поверхности", "Brighten selected vob position on the floor", "Ausgewählte Vob-Position auf dem Boden aufhellen", "Rozjaśnij pozycję wybranego voba na podłodze" });

            words.Add("WIN_MSG_CONFIRM_REMOVEVOB", new List<string> { "Удалить воб?", "Remove the vob?", "Vob löschen?", "Czy chcesz usunąć vob?" });


            words.Add("WIN_BTN_CONFIRM", new List<string> { "Подтвердить", "Confirm", "Bestätigen", "Potwierdź" });
            words.Add("WIN_LABEL_MACROS_RENAME", new List<string> { "Введите имя:", "Enter the name:", "Gebe den Namen ein:", "Ustal nazwę:" });
            words.Add("WIN_LABEL_MACROS_NEW", new List<string> { "Введите имя нового макроса:", "Enter the name of a new macros:", "Gebe den Namen eines neuen Makros ein:", "Ustal nazwę dla nowego macrosa:" });
            words.Add("WIN_OBJ_TAB8", new List<string> { "Макросы", "Macros", "Makros", "Macros" });
            words.Add("buttonCreateNewMacros", new List<string> { "Создать новый макрос", "Create a new macros", "Neues Makro erstellen", "Utwórz nowy macros" });
            words.Add("buttonMacrosRenameCurrent", new List<string> { "Переименовать", "Rename", "Umbenennen", "Zmień nazwę" });
            words.Add("buttonMacrosRemoveCurrent", new List<string> { "Удалить", "Delete", "Löschen", "Usuń" });
            words.Add("buttonMacrosReloadFromFile", new List<string> { "Перезагрузить всё из файла", "Reload all from the file", "Alles aus der Datei neu laden", "Załaduj ponownie wszystko z pliku" });
            words.Add("buttonMacrosSaveAll", new List<string> { "Сохранить всё в файла", "Save all to the file", "Alles in die Datei speichern", "Zapisz wszystko do pliku" });
            words.Add("buttonMacrosRun", new List<string> { "Выполнить", "Run", "Ausführen", "Uruchom" });
            words.Add("buttonMacrosParse", new List<string> { "Парсить и сохранить текущий текст", "Parse and save current text", "Parse und speichere aktuellen Text", "Parsuj i zapisz aktualny tekst" });
            words.Add("groupBoxMacrosButtons", new List<string> { "Действия", "Actions", "Aktionen", "Akcje" });





            words.Add("WIN_CAMERA_START", new List<string> { "Старт", "Start", "Start", "Start" });
            words.Add("WIN_CAMERA_STOP", new List<string> { "Стоп", "Stop", "Stop", "Stop" });
            words.Add("CANT_APPLY_PARENT_CAMERA", new List<string> { "Нельзя вставить новую камеру в другую камеру!", "Can't set current camera as a parent for a new camera!", "Ich kann die aktuelle Kamera nicht als Überordnung für eine neue Kamera festlegen!", "Nie można ustawić bieżącej kamery jako rodzica dla nowej kamery!" });
            words.Add("CANT_APPLY_CAMERA_NEWKEY", new List<string> { "Свойство камеры стоит FOR_OBJECT, а воба нет!", "Camera has FOR_OBJECT value, but no vob found", "Kamera hat FOR_OBJECT-Wert, aber kein Vob gefunden", "Kamera a wartość FOR_OBJECT, ale nie znaleziono voba" });
            words.Add("CAMERA_ITEMS_FORCE_RENAME", new List<string> { "Ключам камеры были проставлены имена", "Camera's keys got its names", "Die Keys der Kamera haben ihre Namen", "Klatki kamery mają swoje nazwy" });
            words.Add("FORM_ENTER_BAD_VALUE_INT", new List<string> { "Введено недопустимое значение! Данное поле целочисленное!", "Invalid value entered. Only integer is allowed in this field!", "Falscher Wert eingegeben. Nur Integer sind erlaubt!", "Wprowadzono nieprawidłową wartość. W tym polu dozwolone są tylko liczby całkowite!" });
            words.Add("FORM_ENTER_BAD_STRING_INPUT", new List<string> { "Введены недопустимые символы!", "Invalid symbols found in the input", "Falsche Symbole in der EIngabe gefunden", "W danych wejściowych znaleziono nieprawidłowe symbole" });
            words.Add("checkBoxOnlyLatinInInput", new List<string> { "Допускать ввод только латинских символов в поля свойств", "Allow only Latin symbols as input values", "Es sind nur Lateinische Buchstaben als Wert erlaubt", "Zezwalaj tylko na symbole łacińskie jako wartości wejściowe" });
            words.Add("MSG_VOB_CANT_BE_COPIED", new List<string> { "Данный тип воба нельзя скопировать!", "This vob type can't be copied!", "Dieser Vob Typ kann nicht kopiert werden!", "Ten typ voba nie może zostać skopiowany!" });

            words.Add("groupBoxCameraNew", new List<string> { "Новая камера", "New camera", "Neue Kamera", "Nowa kamera" });
            words.Add("FORM_COMMON_NAME", new List<string> { "Имя", "Name", "Name", "Nazwa" });
            words.Add("FORM_COMMON_CREATE", new List<string> { "Создать", "Create", "Erstellen", "Utwórz" });


            words.Add("groupBoxCamKeys", new List<string> { "Ключи", "Keyframes", "Keyframes", " Klatki kluczowe" });
            words.Add("buttonCamSpline", new List<string> { "Добавить позицию", "Add a position", "Position hinzufügen", "Dodaj pozycję" });
            words.Add("buttonCamTargetSpline", new List<string> { "Добавить цель", "Add a target", "Ziel hinzufügen", "Dodaj cel" });


            words.Add("groupBoxCamSettings", new List<string> { "Настройки", "Settings", "Einstellungen", "Ustawienia" });
            words.Add("labelCamTimeSec", new List<string> { "Время полета:", "Fly time:", "Flug Zeit", "Czas lotu:" });
            words.Add("checkBoxCameraHide", new List<string> { "Скрывать вобы в полете", "Hide vobs while camera active", "Vobs bei aktiver Kamera ausblenden", "Ukryj voby, gdy kamera jest aktywna" });
            words.Add("labelCamGotoKey", new List<string> { "Перейти к ключу: ", "Go to key", "Zum Key gehen", "Przejdź do klatki" });

            words.Add("groupBoxLightPresetProperties", new List<string> { "Свойства пресета", "Preset properties", "Preset Eigenschaften", "Właściwości presetu" });
            words.Add("labelLightPresetName", new List<string> { "Имя пресета (обязательно)", "Preset name (mandatory)", "Preset Name (notwendig)", "Nazwa presetu (obowiązkowa)" });
            words.Add("buttonNewLightPreset", new List<string> { "Новый пресет", "New preset", "Neues preset", "Nowy preset" });
            words.Add("buttonDeleteSelectedLightPreset", new List<string> { "Удалить выбранный пресет", "Delete selected preset", "Ausgewähltes Preset löschen", "Usuń wybrany preset" });
            words.Add("buttonSaveLightPresets", new List<string> { "Сохранить пресеты", "Save presets", "Presets speichern", "Zapisz presety" });
            words.Add("buttonUpdateLightPresetOnLightVobs", new List<string> { "Обновить пресет на все lightvobs", "Update preset on lightvobs", "Preset auf LightVob erneuern", "Zaktualizuj preset na lightvobach" });
            words.Add("buttonUpdateLightPresetFromVob", new List<string> { "Обновить пресет из lightvob <<", "Update preset from lightvob <<", "Preset von LightVob erneuern <<", "Zaktualizuj preset z lightvoba <<" });
            words.Add("buttonUsePresetOnLightVob", new List<string> { "Применить пресет на lightvob >>", "Use preset on lightvob >>", "Preset auf LightVob anwenden >>", "Użyj presetu na lightvobie >>" });
            words.Add("buttonCreateLightVob", new List<string> { "Создать LightVob", "Create LightVob", "LightVob erstellen", "Utwórz LightVob" });
            words.Add("groupBoxLightSelected_Preset", new List<string> { "Выбранный пресет", "Selected preset", "Ausgewähltes Preset", "Wybrany preset" });
            words.Add("groupBoxLightSelected_LightVob", new List<string> { "Выбранный lightvob", "Selected lightvob", "Ausgewähltes LightVob", "Wybrany lightvob" });
            words.Add("labelLightVobName", new List<string> { "Имя воба:", "Vob name:", "Vob-Name:", "Nazwa Voba:" });
            words.Add("groupBoxLightType", new List<string> { "Тип света", "Light type", "Licht-Typ", "Rodzaj światła" });
            words.Add("checkBoxShowLightVobRadius", new List<string> { "Показать радиус", "Show radius", "Radius anzeigen", "Pokaż zasięg" });
            words.Add("checkBoxLightVobInstantCompile", new List<string> { "Мгновенная компиляция", "Instant compile", "Sofortiges Kompilieren", "Natychmiastowa kompilacja" });
            words.Add("radioButtonLightVobStatic", new List<string> { "Статический", "Static", "Statisch", "Statyczne" });
            words.Add("radioButtonLightVobDynamic", new List<string> { "Динамичный", "Dynamic", "Dynamisch", "Dynamiczne" });
            words.Add("groupBoxLightColorProperties", new List<string> { "Свойства цвета", "Color properties", "Farbeigenschaften", "Właściwości koloru" });
            words.Add("groupBoxLightRangeProperties", new List<string> { "Свойства диапазона", "Range properties", "Reichweiteneigenschaften", "Właściwości zasięgu" });


            words.Add("FORM_COMMON_DELETE", new List<string> { "Удалить", "Delete", "Löschen", "Usuń" });
            words.Add("FORM_CAMERA_INSERT_KEY_HERE", new List<string> { "Вставить новый ключ сюда", "Insert a new key here", "", "Wstaw nową klatkę" });
            words.Add("TOOL_BBOX_CHANGE", new List<string> { "Режим 'Изменение Bbox'", "Bbox change mode", "Bbox Änderungs-Modus", "Tryb zmiany BBoxa" });
            words.Add("TOOL_BBOX_CHANGE_LEAVE", new List<string> { "Выход из режима 'Изменение Bbox'", "Bbox Änderungs-Modus verlassen", "", "Opuszczenie trybu zmiany Bboxa" });

            words.Add("TOOL_BBOX_MAXS", new List<string> { "Изменение bbox maxs", "Changing bbox maxs", "Bbox max ändern", "Zmiana maks. bbox" });
            words.Add("TOOL_BBOX_MINS", new List<string> { "Изменение bbox mins", "Changing bbox mins", "Bbox min ändern", "Zmiana min. bbox" });
            words.Add("TOOL_BBOX_CANT_WORK", new List<string> { "У текущего типа воба нельзя менять bbox!", "Can't change bbox of this vob type", "Kann Bbox dieses Vob Typens nicht ändern", "Nie można zmienić bboxa w tym typie voba" });

            words.Add("FORM_HINT_INSERT_WPFP", new List<string> { "*Кнопка {0}, чтобы вставить новый воб", "*Press {0} button to insert a new vob", "*Drücke {0} zum Hinzufügen eines neuen Vobs", "*Wciśnij klawisz {0} aby dodać nowy vob" });



            words.Add("checkBoxInfoUseZSpy", new List<string> { "Отладочные сообщения zSpy", "zSpy debug messages", "zSpy Debug Nachrichten", "Komunikaty debugowania zSpy" });
            words.Add("MSG_COMMON_SEARCH", new List<string> { "Поиск", "Search", "Suchen", "Szukaj" });
            words.Add("MSG_COMMON_COMMON", new List<string> { "Общее", "Common", "Allgemein", "Ogólne" });
            words.Add("MSG_COMMON_MATSEACH", new List<string> { "Поиск материала:", "Material search:", "Material Suche:", "Szukaj materiał:" });


            words.Add("MSG_MATFILTER_NEW_NAME", new List<string> { "Имя фильтра:", "Filter name:", "Filter Name:", "Nazwa filtra:" });
            words.Add("MSG_MATFILTER_RENAME", new List<string> { "Переименование фильтра:", "Rename Filter:", "Filter umbenennen:", "Zmień nazwę filtru:" });

            words.Add("checkBoxMatchNames", new List<string> { "Совпадение имен", "Match vobs names", "Namen von Vobs abgleichen", "Dopasuj nazwy vobów" });
            words.Add("checkBoxSearchItem", new List<string> { "Искать oCItem в oCMobContainer", "Search oCItem in oCMobContainer", "Suche oCItem in oCMobContainer", "Szukaj oCItem w oCMobContainer" });

            words.Add("VOBLIST_TYPE_ANY", new List<string> { "Любой тип", "Any type", "Jeder Typ", "Dowolny typ" });

            words.Add("MENU_TOP_CONTROLS_VOBS", new List<string> { "Вобы", "Vobs", "Vob", "Voby" });
            words.Add("WIN_CONTROLSET_VOBS_TEXT", new List<string> { "Настройки вобов", "Vobs settings", "Vob Einstellungen", "Ustawienia vobów" });



            words.Add("MSG_COMMON_NO_EMPTY_NAME", new List<string> {  "Имя не может быть пустым!", "Name can't be empty!", "Der Name darf nicht leer sein!", "Nazwa nie może być pusta!" });
            words.Add("MSG_COMMON_NO_UNIQUE_NAME", new List<string> { "Такое имя уже есть", "The name already exists!", "Der Name existiert bereits!", "Nazwa już istnieje!" });
        
           
            words.Add("WIN_MATFILTER_FILTER_NEW", new List<string> { "Создать новый", "New filter", "Neuer Filter", " Nowy filtr" });
            words.Add("WIN_MATFILTER_FILTERLIST_RENAME", new List<string> { "Переименовать выбранный", "Rename selected", "Selektiertes umbenennen", "Zmień nazwę wybranego" });
            words.Add("WIN_MATFILTER_FILTERLIST_SAVE", new List<string> { "Сохранить файл фильтров", "Save filters file", "Filterdatei speichern", "Zapisz plik filtrów" });

            words.Add("WIN_MATFILTER_FILTER_TITLE", new List<string> { "Фильтр материалов", "Materials filter", "Material Filter", "Filtr materiałów" });
            words.Add("WIN_MATFILTER_FILTER_TAB_MESH", new List<string> { "Меш", "Mesh", "Mesh", "Mesh" });
            words.Add("WIN_MATFILTER_FILTER_TAB_VOBS", new List<string> { "Вобы", "Vobs", "Vobs", "Voby" });


 
            words.Add("WIN_MATFILTER_FILTER_SEARCH_IN_MATS", new List<string> { "Поиск материала:", "Search material:", "Suche Material", "Wyszukaj materiał:" });
            words.Add("WIN_MATFILTER_FILTER_TEXTURE", new List<string> { "Текстура", "Texture", "Texture", "Tekstura" });
            words.Add("WIN_MATFILTER_FILTER_SETTINGS", new List<string> { "Настройки выбранного материала", "Properties of selected material", "Eigenschaften des selektierten Materials", "Właściwości wybranego materiału" });
            words.Add("WIN_MATFILTER_FILTER_SET_FILTER", new List<string> { "Задать фильтр:", "Set filter:", "Filter setzen:", "Ustaw filtr:" });
            words.Add("WIN_MATFILTER_FILTER_SET_GROUP", new List<string> { "Задать группу:", "Set group:", "Setze Gruppe:", "Ustaw grupę:" });

            words.Add("WIN_MATFILTER_FILTER_SETTINGS_SIZE", new List<string> { "Размер:", "Size:", "Größe:", "Rozmiar:" });
            words.Add("WIN_MATFILTER_FILTER_SETTINGS_ALPHA", new List<string> { "Альфа-канал:", "Alpha channel:", "Alpha Kanal", "Kanał alpha:" });
            words.Add("WIN_MATFILTER_FILTER_SETTINGS_ALPHA_YES", new List<string> { "Альфа-канал: да", "Alpha channel: yes", "Alpha Kanal: Ja", "Kanał alpha: tak" });
            words.Add("WIN_MATFILTER_FILTER_SETTINGS_ALPHA_NO", new List<string> { "Альфа-канал: нет", "Alpha channel: no", "Alpha Kanal: Nein", "Kanał alpha: nie" });
            words.Add("WIN_MATFILTER_FILTER_SETTINGS_BITS", new List<string> { "бит", "bits", "bits", "bity" });


            words.Add("WIN_MATFILTER_FILTER_SETTINGS_NAME", new List<string> { "Настройки предпросмотра", "Preview settings", "Vorschau Einstellungen", "Ustawienia podglądu" });
            words.Add("WIN_MATFILTER_FILTER_SETTINGS_USE_ALPHA", new List<string> { "Прозрачность", "Transparency", "Transparenz", "Przezroczystość" });
            words.Add("WIN_MATFILTER_FILTER_SETTINGS_USE_CENTER", new List<string> { "Всегда по центру", "Always in center", "Immer in der Mitte", "Zawsze na środku" });
            words.Add("WIN_MATFILTER_FILTER_SETTINGS_USE_SCALE", new List<string> { "Автомасштаб малых текстур", "Autoscale small textures", "Autoskalieren kleiner Texturen", "Automatyczne skalowanie małych tekstur" });



            words.Add("WIN_MATFILTER_FILTER_MAT_NAME_ALREADY_EXISTS", new List<string> { "Материал с таким именем уже существует!", "Material with this name already exists!", "Material mit diesem Namen existiert bereits!", "Materiał o tej nazwie już istnieje!" });
            words.Add("MSG_MATFILTER_NEW_MAT_NAME", new List<string> { "Имя материала:", "Material name:", "Material Name:", "Nazwa materiału:" });
            words.Add("WIN_MATFILTER_TEXTURE_NOT_FOUND", new List<string> { "(Не найдена)", "(Not found)", "(Nicht gefunden)", "(Nie znaleziono)" });

            words.Add("WIN_MATFILTER_FILTERS_MENU", new List<string> { "Меню фильтров", "Filters menu", "Filter Menü", "Menu filtrów" });

            words.Add("WIN_MATFILTER_MATLIST_CURRENT", new List<string> { "Материалы {0} фильтра: ", "Materials of {0} filter: ", "Materialien des {0}-Filters: ", "Materiały {0} filtra: " });
            words.Add("WIN_MATFILTER_MATLIST_CURRENT_EMPTY", new List<string> { "Материалы фильтра: (0) ", "Materials of the filter: (0) ", "", "Materiały filtra: (0)" });

            words.Add("WIN_MATFILTER_ERR_NO", new List<string> { "Все готово к работе", "Everything is ready", "", "Wszystko jest gotowe" });
            words.Add("WIN_MATFILTER_ERR_WORK", new List<string> { "Для работы загрузите ZEN или 3DS файл", "Load any ZEN or 3DS to activate Materials Filter", "Lade eine beliebige ZEN oder 3DS, um den Materialfilter zu aktivieren.", "Załaduj dowolny ZEN lub 3DS, aby aktywować filtr materiałów" });
            words.Add("WIN_MATFILTER_ERR_READONLY", new List<string> { "Файл MatLib.ini имеет аттрибут 'Только чтение'. Изменения в 'Библиотеке фильтров' не будут работать!", "File Matlib.ini has 'read only' attribute, no changes will be saved in 'Filters library'", "Datei Matlib.ini hat das Attribut 'Schreibgeschützt', Änderungen werden nicht in der 'Filter Bibliothek' gespeichert", "Plik Matlib.ini ma atrybut 'tylko do odczytu', żadne zmiany nie zostaną zapisane w 'Bibliotece filtrów'" });
            words.Add("WIN_MATFILTER_FILTERLIST_REMOVE", new List<string> { "Удалить фильтр", "Remove filter", "Filter entfernen", "Usuń filtr" });
            words.Add("MSG_MATFILTER_REMOVE_ONLY_NONEMPTY", new List<string> { "Можно удалить только пустой фильтр!", "You can remove only empty filter!", "Du kannst nur leere Filter entfernen!", "Możesz usunąć jedynie pusty filtr!" });
            words.Add("WIN_MATFILTER_FILTERS_MENU_MISC", new List<string> { "Прочее", "Misc", "Sonstiges", "Pozostałe" });
            words.Add("WIN_MATFILTER_NEW_MATERIAL", new List<string> { "Новый материал", "New material", "Neues Material", "Nowy materiał" });
            words.Add("WIN_MATFILTER_FILTERLIST_FILES", new List<string> { "Библиотека фильтров", "Filters library", "Filter Bibliothek", "Biblioteka filtrów" });
            words.Add("WIN_MATFILTER_TEXTURE_TOO_BIG", new List<string> { "Размер текстуры слишком большой для отображения", "Texture is too big for being shown", "Texture ist zum Zeigen zu groß", "Tekstura jest za duża, by ją wyświetić" });



            words.Add("WIN_MATFILTER_CONV_TGA", new List<string> { "Конвертация TGA текстур: ", "Convering TGA textures: ", "Konvertiere TGA Texturen", "Konwersja tekstur TGA:" });
            words.Add("WIN_MATFILTER_CONV_WARNING", new List<string> { "Не выключайте SpacerNET!", "Don't shut down SpacerNET!", "Du darfst SpacerNET nicht beenden!", "Nie wyłączaj SpacerNET!" });

            words.Add("WIN_MATFILTER_CONV_INFO", new List<string> { "Некоторые из ваших материалов используют текстуры, которые не скомпилированы в '-C.TEX'.\nДля сохранения фильтров необходимо скомпилировать эти текстуры из TGA текстур.\nВыполняю конвертацию...", "Some of your materials don't have a compiled '-C.TEX' version of texture.\nTo save the filter such textures must be compiled from TGA textures.\nConverting...", "Einige deiner Materialien haben keine kompilierte '-C.TEX'-Version der Textur.\nUm den Filter zu speichern, müssen solche Texturen aus TGA-Texturen kompiliert werden.\nKonvertiere...", "Niektóre z materiałów nie mają skompilowanej wersji tekstury '-C.TEX'.\nAby zapisać filtr, takie tekstury muszą być skompilowane z tekstur TGA.\nKonwersja..." });
            words.Add("WIN_MATFILTER_FOLLOW_MAT", new List<string> { "Следовать за материалом при применении", "Follow material after applying", "Material nach anwenden folgen", "Śledź materiał po zatwierdzeniu" });
            words.Add("WIN_MATFILTER_SAVE_LAST_FILTER", new List<string> { "Принудительно ставить последний фильтр", "Forcedly set last filter", "Letzten Filter zwangsweise setzen", "Wymuś ustawienie ostatniego filtra" });



            words.Add("Trigget_BTN_JUMPTOKEY", new List<string> { "Прыгнуть на ключ", "Jump to key", "Zu Key Springen", "Przejdź do klucza" });
            words.Add("TOOL_BBOX_EDIT_MODE_SELECTED", new List<string> { "Режим изменения BBOX", "BBOX editing mode", "Bbox Editier Modus", "Tryb edycji BBOX" });


            words.Add("VOB_SEARCH_TYPE_SINGLE_WP", new List<string> { "Поиск несоединенных WP", "Search for unconnected WP", "Suche nach unverbundenden WP's", "Szukaj dla niepołączonych WP" });
            words.Add("OBJ_TAB_PICKFILTER", new List<string> { "Фильтр выделения вобов", "Vob select filter", "Vob Filter auswählen", "Wybierz filtr voba" });



            //=========================
            words.Add("UNION_VOB_POS", new List<string> { "Позиция воба: ", "Vob pos: ", "Vob pos: ", "Pozycja voba: " });
            words.Add("checkBoxCamCoord", new List<string> { "Показывать координаты камеры и воба", "Show camera and vob coordinates", "Kamera- und Vob-Koordinaten anzeigen", "Pokaż kamerę i współrzędne voba" });
            words.Add("VOB_ONEMODE", new List<string> { "Единый режим перемещения воба", "United mod of vob moving", "United mod of vob moving", "Wspólny tryb poruszania vobem" });
            words.Add("VOB_ONEMODE_OFF", new List<string> { "Единый режим отключен", "United mod disabled", "United Mod deaktiviert", "Wspólny tryb wyłączony" });
            
        }
        
    }
}
