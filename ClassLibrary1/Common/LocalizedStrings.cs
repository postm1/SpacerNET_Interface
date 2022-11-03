﻿using System;
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
            words.Add("askSure", new List<string> { "Вы уверены?", "Are you sure?", "Sind Sie sich sicher?", "Czy jesteś pewny?" });
            words.Add("askReset", new List<string> { "Точно сбросить мир?", "Reset world?", "Welt zurücksetzen?", "Zresetować świat?" });
            words.Add("confirmation", new List<string> { "Подтверждение", "Confirmation", "Bestätigung", "Potwierdzenie" });
            words.Add("loadZen", new List<string> { "Идет загрузка ZEN...", "ZEN is loading...", "ZEN lädt...", "ZEN jest ładowany..." });
            words.Add("isLoading", new List<string> { "загружается...", "is loading...", "lädt...", " jest ładowany..." });
            words.Add("compileZen", new List<string> { "Идет компиляция ZEN...", "Compiling ZEN...", "Kompilierung der ZEN im Gange...", @"Kompilowanie ZEN'a..." });
            words.Add("compileLight", new List<string> { "Идет компиляция света...", "Compiling light...", "Kompilierung von Licht im Gange...", "Kompilowanie światła..." });
            words.Add("savingZen", new List<string> { "Идет сохранение ZEN...", "Saving ZEN...", "Speichern der ZEN im Gange...", @"Zapisywanie ZEN'a..." });
            words.Add("waynetMsg", new List<string> { "Ошибки WayNet не найдены.", "No Waynet errors found.", "Keine Fehler im Waynet gefunden.", "Nie znaleziono błędów Waynetu." });

            words.Add("loadZenTime", new List<string> { "Загрузка ZEN выполнена за", "Loading ZEN time...", "Laden der ZEN dauerte...", @"Czas wczytywania ZEN'a..." });
            words.Add("saveZenTime", new List<string> { "Сохранение ZEN выполнено за", "Saving ZEN time...", "Speichern der ZEN dauerte", @"Czas zapisywania ZEN'a..." });
            words.Add("loadMeshTime", new List<string> { "Загрузка MESH выполнена за", "Loading MESH time...", "Laden der MESH dauerte...", @"Czas wczytywania MESH'a..." });
            words.Add("mergeZenTime", new List<string> { "Объединение ZEN выполнено за", "Merging ZEN time...", "Zusammenfügen der MESH dauerte...", @"Czas zapisywania MESH'a..." });



            words.Add("MENU_TOP_FILE", new List<string> { "Файл", "File", "Datei", "Plik" });
            words.Add("MENU_TOP_RESET", new List<string> { "Сбросить мир", "Reset world", "Welt zurücksetzen", "Zresetuj świat" });
            words.Add("MENU_TOP_EXIT", new List<string> { "Выход", "Exit", "Verlassen", "Zakończ" });
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


            words.Add("MENU_TOP_VIEW_SHOW", new List<string> { "Показать", "Show", "Zeugen", "Pokaż" });
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
            words.Add("MENU_TOP_MORN", new List<string> { "Утро (07:00)", "Morning (07:00)", "Morgen (07:00)", "Poranek (07:00)" });


            words.Add("MENU_TOP_NOON", new List<string> { "Обед (12:00)", "Midday (12:00)", "Mittag (12:00)", "Południe (12:00)" });
            words.Add("MENU_TOP_AFTERNOON", new List<string> { "Вечер (17:00)", "Evening (17:00)", "Abend (17:00)", "Wieczór (17:00)" });
            words.Add("MENU_TOP_NIGHT", new List<string> { "Ночь (00:00)", "Night (00:00)", "Nacht (00:00)", "Noc (00:00)" });
            words.Add("MENU_TOP_ANALYSE_WAYNET", new List<string> { "Анализ WayNet", "Analyze Waynet", "Wegpunkte analysieren", "Analizuj Waynet" });
            words.Add("MENU_TOP_PLAY_THE_GAME", new List<string> { "Играть за героя", "Play the hero", "Helden spielen", "Zagraj bohaterem" });
            words.Add("MENU_TOP_KEYSBINDS", new List<string> { "Сочетания клавиш", "Keys bindings", "Tastaturbelegung", "Przypisanie klawiszy" });

            words.Add("MENU_TOP_HOVER_WININFO", new List<string> { "Окно информации", "Information window", "Infofenster", "Okno informacji" });
            words.Add("MENU_TOP_HOVER_WINOBJ", new List<string> { "Окно объектов", "Objects window", "Objektfenster", "Okno obiektów" });
            words.Add("MENU_TOP_HOVER_WINSOUND", new List<string> { "Окно звуков", "Sounds window", "Soundfenster", "Okno dźwięków" });
            words.Add("MENU_TOP_HOVER_WINTREE", new List<string> { "Окно списка вобов", "All-vobs window", "Allvob-Fenster", "Okno wszystkich obiektów" });
            words.Add("MENU_TOP_HOVER_WINPROPS", new List<string> { "Окно свойств", "Properties window", "Eigenschaftsfenster", "Okno właściwości" });
            words.Add("MENU_TOP_HOVER_WINVOBLIST", new List<string> { "Окно воб-лист", "VobList window", "Voblisten-Fenster", "Okno listy vobów" });



            words.Add("WIN_COMPLIGHT_TEXT", new List<string> { "Компиляция света", "Light compilation", "Kompilation Licht", "Kompilacja światła" });
            words.Add("WIN_COMPLIGHT_QUALITY", new List<string> { "Качество", "Quality", "Qualität", "Jakość" });
            words.Add("WIN_COMPLIGHT_COMPILEBUTTON", new List<string> { "Компилировать", "Compile", "Kompilieren", "Kompiluj" });

            words.Add("WIN_CANCEL_BUTTON", new List<string> { "Отмена", "Cancel", "Abbrechen", "Anuluj" });
            words.Add("WIN_COMPLIGHT_CLOSEBUTTON", new List<string> { "Закрыть", "Close", "Schließen", "Zamknij" });
            words.Add("WIN_COMPLIGHT_REGION", new List<string> { "Регион", "Region", "Region", "Region" });
            words.Add("WIN_COMPLIGHT_QUALITY0", new List<string> { "Только вершины", "Vertexes only", "Nur die Spitzen", "Tylko vertexy" });
            words.Add("WIN_COMPLIGHT_QUALITY1", new List<string> { "Lightmaps (низкое)", "Lightmaps (low)", "Lightmaps (niedrig)", "Lightmapa (niska)" });
            words.Add("WIN_COMPLIGHT_QUALITY2", new List<string> { "Lightmaps (среднее)", "Lightmaps (medium)", "Lightmaps (mittel)", "Lightmapa (średnia)" });
            words.Add("WIN_COMPLIGHT_QUALITY3", new List<string> { "Lightmaps (высокое)", "Lightmaps (high)", "Lightmaps (hoch)", "Lightmapa (wysoka)" });

            words.Add("WIN_COMPLIGHT_COMPILECHECKBOX", new List<string> { "Компилировать регион", "Compile region", "Region kompilieren", "Kompiluj region" });


            words.Add("WIN_COMPLIGHT_METERS", new List<string> { "метров", "meters", "Meter", "metry" });
            words.Add("WIN_COMPLIGHT_AROUNDCAM", new List<string> { "вокруг камеры", "around the camera", "um die Kamera", "na około kamery" });


            words.Add("WIN_COMPWORLD_TEXT", new List<string> { "Компиляция мира", "World compilation", "Kompilation Welt", "Kompilacja świata" });
            words.Add("WIN_COMPWORLD_LOCTYPE", new List<string> { "Тип локации", "World type", "Typ Welt", "Typ świata" });

            words.Add("WIN_CAM_TEXT", new List<string> { "Камера", "Camera", "Kamera", "Kamera" });
            words.Add("WIN_CAM_CLOSEWIN", new List<string> { "Закрывать окно при переходе", "Close the window after the jump", "Nach Wechsel Fenster schließen", "Zamknij okno po skoku" });
            words.Add("WIN_CAM_GO", new List<string> { "Перейти", "Jump", "Wechsel", "Skok" });

            // UNION STRING
            words.Add("UNION_VOB_INSERTED", new List<string> { "Воб вставлен", "The vob inserted", "Vob eingefügt", "Vob został wklejony" });
            words.Add("UNION_VOB_AXIS_RESET", new List<string> { "Направление воба сброшено", "Vob axes were reset", "Richtung der Vob geändert", "Osie Voba zostały zresetowane" });
            words.Add("CANT_APPLY_PARENT", new List<string> { "Данный тип воба перенести в родителя нельзя!", "Can't insert this vob type into a parent vob!", "Diese Vob kann nicht in die übergeordnete Vob eingefügt werden!", "Nie można dodać tego typu Voba jako nadrzędnego." });
            words.Add("PARENT_ERROR_OCITEM", new List<string> { "oCItem не может быть родителем!", "oCItem can't be a parent!", "oCItem kann nicht übergeornet sein!", "oCItem nie może być nadrzędny!" });
            words.Add("PARENT_CHANGE_OK", new List<string> { "Родитель для воба изменен!", "The parent has been changed", "Überordnung für Vob wurde geändert", "Vob nadrzędny został zmieniony" });

            words.Add("VOB_COPY_OK", new List<string> { "Воб скопирован", "Vob was copied", "Vob kopiert", "Vob został skopiowany" });
            words.Add("VOB_CUT_OK", new List<string> { "Воб вырезан", "Vob was cut", "Wob ausgeschnitten", "Vob został wycięty" });
            words.Add("VOB_NEAR_CAMERA", new List<string> { "Воб вставлен перед камерой", "Vob inserted in front of the camera", "Vob vor der Kamera eingefügt", "Vob został stworzony na przeciwko kamery" });


            words.Add("TOOL_TRANS", new List<string> { "Выбран инструмент перемещение", "Tool: moving", "Werkzeug: verschieben", "Narzędzie: Przemieszczanie" });
            words.Add("TOOL_ROT", new List<string> { "Выбран инструмент вращение", "Tool: rotation", "Werkzeug: rotieren", "Narzędzie: Rotacja" });
            words.Add("TOOL_UNSELECT", new List<string> { "Выделение воба снято", "Vob selection cancel", "Vobauswahl aufgehoben", "Wybranie voba zostało anulowane" });
            words.Add("TOOL_FLOOR", new List<string> { "Прижимание воба к полу", "Try to floor the vob", "Vob am Boden fixieren", "Spróbuj postawić Voba na podłodze" });

            words.Add("UNION_LIGHT_RAD_INC", new List<string> { "Радиус освещения увеличен", "Light radius increased", "Lichtradius erhöht", "Promień światła został zwiększony" });
            words.Add("UNION_LIGHT_RAD_DEC", new List<string> { "Радиус освещения уменьшен", "Light radius decreased", "Lichtradius reduziert", "Promień światła został zmniejszony" });

            words.Add("UNION_LIGHT_RAD_ZERO", new List<string> { "Радиус освещения сброшен в 0", "Light radius set to 0", "Lichtradius auf 0 gesetzt", "Promień światła został ustawiony na 0" });
            words.Add("UNION_MESH_LOADED", new List<string> { "Меш загружен", "Mesh is loaded", "Mesh geladen", "Mesh jest załadowany" });
            words.Add("UNION_MESH_READY", new List<string> { "Меш и вобы объединены. Скомпилируйте мир", "Mesh and vobs were merged. Compile the world", "Mesh und Vobs verbunden. Bitte Welt kompilieren!", "Mesh i voby zostały połączone. Skompiluj świat." });
            words.Add("UNION_EDITOR", new List<string> { "Редактор для ZenGin", "Editor for ZenGin", "Editor für ZenGin", "Edytor dla ZenGine" });
            words.Add("UNION_TEAM", new List<string> { "Разработчик: Liker. Помогали: Haart & Saturas & Gratt & Jr", "Author: Liker. Assistance from: Haart & Saturas & Gratt & Jr", "Entwicklerteam: Liker & Haart & Saturas & Gratt & Jr", "Deweloperzy: Liker & Haart & Saturas & Gratt & Jr" });
            words.Add("UNION_DATE_COMPILE", new List<string> { "Дата компиляции: ", "Compilation date: ", "Datum der Kompilation: ", "Data kompilacji: " });
            words.Add("UNION_RESOLUTION", new List<string> { "Разрешение рендера: ", "Render resolution: ", "Rendererauflösung: ", "Rozdzielczość renderowania: " });
            words.Add("UNION_NOWORLD", new List<string> { "Мир не загружен", "World is not loaded", "Welt wurde nicht geladen", "Świat nie został wczytany." });
            words.Add("UNION_CANT_ABSTRACT", new List<string> { "Не могу создать объект абстрактного класса!", "Can't create a vob of an abstract class", "Die Vob der abstrakten Klasse kann nicht erstellt werden!", "Nie można utworzyć voba klasy abstrakcyjnej" });
            words.Add("ENTER_NAME", new List<string> { "Введите имя воба!", "Enter the name!", "Name eingeben!", "Podaj nazwę!" });
            words.Add("CANT_DELETE_LEVELCOMPO", new List<string> { "Не могу удалить zCVobLevelCompo!", "Can't remove zCVobLevelCompo!", "zCVVobLevelCompo kann nicht entfernt werden!", "Nie można usunąć zCVobLevelCompo!" });
            words.Add("CANT_DELETE_CAM", new List<string> { "Не могу удалить основную камеру!", "Can't remove the camera!", "Kamera kann nicht entfernt werden", "Nie można usunąć kamery!" });
            words.Add("UNION_NO_WAYPOINT", new List<string> { "Вейпоинт не выбран!", "No waypoint selected!", "Keinen Wegpunkt ausgewählt", @"Nie wybrano Waypoint'a!" });
            words.Add("UNION_NO_WAYPOINT_TEMPLATE", new List<string> { "Шаблон имени вейпоинта пуст!", "Waypoint name template is empty!", "Plakette für Wegpunkt Bezeichnung ist leer!", "Nazwa szablonu Waypointów jest pusta!" });
            words.Add("UNION_WP_INSERT", new List<string> { "Вейпоинт вставлен: ", "Waypoint inserted: ", "Wegpunkt hinzugefügt:", "Dodano Waypoint: " });
            words.Add("UNION_WORLD_ONCOMPILE", new List<string> { "Мир скомпилирован.", "World has been compiled.", "Welt wurde kompiliert.", "Świat został skompilowany." });
            words.Add("UNION_VOBTREE_SAVE", new List<string> { "VobTree сохранен!", "VobTree saved!", "VobTree gespeichert!", "Drzewko vobów zostało zapisane!" });
            words.Add("UNION_VOBTREE_INSERT", new List<string> { "VobTree вставлен!", "VobTree inserted!", "VobTree eingefügt!", "Dodano drzewko vobów!" });
            words.Add("UNION_SHOW_TRIS", new List<string> { "Кол-во треугольников: ", "Tris amount: ", "Anzahl Dreiecke: ", "Ilość tri: " });
            words.Add("UNION_CAM_POS", new List<string> { "Позиция камеры: ", "Camera pos: ", "Kameraposition: ", "Pozycja kamery: " });
            words.Add("UNION_VOB_COUNT", new List<string> { "Кол-во вобов: ", "Vobs amount: ", "Anzahl der Vobs: ", "Ilość vobów: " });
            words.Add("UNION_WP_COUNT", new List<string> { "Кол-во вейпоинтов: ", "Waypoint amount: ", "Anzahl der Wegpunkte: ", "Ilość Waypointów: " });
            words.Add("UNION_DIST", new List<string> { "Дистанция: ", "Distance: ", "Entfernung: ", "Dystans: " });
            //NEW
            words.Add("WIN_COMPLIGHT_NOWORLD", new List<string> { "Мир не загружен!", "World is not loaded!", "Welt ist nicht geladen!", "Świat nie jest załadowany!" });
            words.Add("WIN_COMPLIGHT_NOWORLDCOMPILED", new List<string> { "Мир не скомпилирован!", "World is not compiled!", "Welt ist nicht kompiliert!", "Świat nie jest skompilowany!" });
            words.Add("WIN_COMPLIGHT_TIME", new List<string> { "Компиляция света выполнена за", "Light compilaton time", "Licht Kompilierungszeit", "Czas kompilacji światła" });
            words.Add("WIN_COMPLIGHT_QUALITY0_COMP", new List<string> { "Компиляция (только вершины)", "Compilation (Vertexes only)", "Compilierung (nur Vertexes)", "Kompilacja (Tylko Vertexy)" });
            words.Add("WIN_COMPLIGHT_QUALITY1_COMP", new List<string> { "Компиляция Lightmaps (низкое)", "Compilation Lightmaps (low)", "Compilierung Lightmaps (niedrig)", "Kompilacja Lightmap (niskie)" });
            words.Add("WIN_COMPLIGHT_QUALITY2_COMP", new List<string> { "Компиляция Lightmaps (среднее)", "Compilation Lightmaps (medium)", "Compilierung Lightmaps (mittel)", "Kompilacja Lightmap (średnie)" });
            words.Add("WIN_COMPLIGHT_QUALITY3_COMP", new List<string> { "Компиляция Lightmaps (высокое)", "Compilation Lightmaps (high)", "Compilierung Lightmaps (hoch)", "Kompilacja Lightmap (wysokie)" });
            words.Add("WIN_COMPWORLD_ALREADY_COMP", new List<string> { "Мир уже скомпилирован!", "World is already compiled!", "Welt wurde bereits kompiliert.", "Świat jest już skompilowany!" });
            words.Add("WIN_COMPWORLD_COMPILING", new List<string> { "Мир компилируется...", "World is being compiled!", "Welt wird gerade kompiliert.", "Świat się kompiluje!" });
            words.Add("WIN_COMPWORLD_TIME", new List<string> { "Компиляция мира выполнена за", "World compiling time", "Welt Kompilierungszeit", "Czas kompilacji świata" });
            words.Add("WIN_COMPWORLD_LEVELCOMPO", new List<string> { "Не забудьте удалить лишний zCVobLevelCompo!", "Don't forget to remove the spare zCVobLevelCompo", "Vergiss nicht den 'spare' zCVobLevelCompo zu entfernen", "Nie zapomnij usunąć zapasowego zCVobLevelCompo" });
            words.Add("WIN_INFO_TITLE", new List<string> { "Окно информации", "Information window", "Informationsansicht", "Okno informacyjne" });
            words.Add("WIN_INFO_CLEAR", new List<string> { "Очистить", "Clear", "Klar", "Wyczyść" });
            words.Add("IS_SAVING", new List<string> { "сохраняется...", "is saving...", "wird gespeichert...", "zapisywanie..." });
            words.Add("WIN_CAM_GETFROMBUFFER", new List<string> { "Взять из буфера", "Get from clipboard", "Wird aus der Zwischenablage geholt", "Pobierz ze schowka" });
            words.Add("BTN_APPLY", new List<string> { "Применить", "Apply", "Anwenden", "Zastosuj" });
            words.Add("WIN_MISC_SET", new List<string> { "Прочие настройки", "Misc settings", "Verschiedene Einstellungen", "Inne ustawienia" });
            words.Add("checkBoxSetDatePrefix", new List<string> { "Добавлять префикс даты при сохранении зена", "Add DATE prefix to file when saving ZEN", "Füge Datum Präfix zu Datei hinzu wenn die ZEN gespeichert wird", "Dodaj prefix daty do nazwy zapisanego pliku" });
            words.Add("checkBoxMiscExitAsk", new List<string> { "Подтверждать выход если открыт зен", "Confirm exit if ZEN is opened", "Falls ZEN geöffnet ist, dann bestätige den Abbruch", "Potwierdź wyjście, gdy ZEN jest otwarty" });
            words.Add("checkBoxLastZenAuto", new List<string> { "Открывать последний ZEN автоматически", "Auto opening last ZEN", "Letzte ZEN automatisch öffnen", "Otwórz automatycznie ostatni świat" });
            words.Add("checkBoxMiscFullPath", new List<string> { "Писать полный путь до ZEN в главном окне", "Show full path to ZEN file in main window", "Zeige den vollständigen Pfad zur ZEN Datei im Hauptmenü an", "Pokaż pełną ścieżkę do świata w głównym oknie" });
            words.Add("WIN_CONTROLSET_TEXT", new List<string> { "Настройки управления", "Controls setttings", "Steuerungseinstellungen", "Ustawienia sterowania" });
            words.Add("WIN_CONTROLSET_TRANSSPEED", new List<string> { "Скорость перемещения: ", "Moving speed: ", "Bewegungsgeschwindigkeit: ", "Szybkość poruszania: " });
            words.Add("WIN_CONTROLSET_ROTSPEED", new List<string> { "Скорость вращения: ", "Rotation speed: ", "Rotationsgeschiwndigkeit: ", "Szybkość rotacji: " });
            words.Add("WIN_CONTROLSET_GROUP0", new List<string> { "Управление вобом", "Vob control", "Vob Kontrolle", "Kontrola Voba" });
            words.Add("WIN_CONTROLSET_GROUP1", new List<string> { "Вставка воба", "Vob insertion", "VoB Einfügung", "Wstawianie Voba" });
            words.Add("checkBoxInsertVob", new List<string> { "Вставлять воб на той же высоте", "Insert vob on the source height", "Füge VoB an der Höhe der Quelle ein", "Wstaw Voba na wysokości kamery" });
            words.Add("checkBoxVobRotRandAngle", new List<string> { "Поворачивать воб на случайный угол", "Turn vob on a random angle", "Versetze den VoB in einen zufälligen Winkel", "Obróć voba pod dowolnym kątem" });
            words.Add("checkBoxVobInsertHierarchy", new List<string> { "Учитывать иерархию при копировании", "Use hierarchy when copying", "Nutze die Hierachie beim Kopieren", "Użyj hierarchi podczas kopiowania" });
            words.Add("labelRotWpFP", new List<string> { "Разворачивать WP/FP при вставке", "Turn WP/FP when inserting", "Aktivere WP/FP beim Einfügen", "Obróć WP/FP podczas dodawania" });
            words.Add("radioButtonWPTurnNone", new List<string> { "Нет", "None ", "None", "Brak" });
            words.Add("radioButtonWPTurnAgainst", new List<string> { "От камеры", "From the camera", "Von der Kameraperspektive", "Z kamery" });
            words.Add("radioButtonWPTurnOn", new List<string> { "На камеру", "At the camera", "Bei der Kamera", "Do kamery" });
            words.Add("WIN_CONTROLCAM_TEXT", new List<string> { "Настройки камеры", "Camera settings", "Kameraeinstellungen", "Ustawienia kamery" });
            words.Add("groupBoxCam", new List<string> { "Камера", "Camera", "Kamera", "Kamera" });
            words.Add("labelTrans", new List<string> { "Скорость полета", "Moving speed", "Bewegungsgeschwindigkeit", "Prędkość poruszania" });
            words.Add("labelRot", new List<string> { "Скорость повотора", "Rotation speed", "Rotationsgeschiwndigkeit", "Prędkość rotacji" });
            words.Add("groupBoxRange", new List<string> { "Прорисовка", "Rendering range", "Rendering Reichweite", "Zasięg renderowania" });
            words.Add("labelWorld", new List<string> { "Мир", "World", "Welt", "Świat" });
            words.Add("labelVobs", new List<string> { "Вобы", "Vobs", "Vobs", "Obiekty" });
            words.Add("labelLimitFPS", new List<string> { "Ограничить FPS", "Limit FPS", "FPS Limit", "Limit FPS" });
            words.Add("groupBoxInfo", new List<string> { "Информация", "Information", "Information", "Informacje" });
            words.Add("checkBoxFPS", new List<string> { "Показывать FPS", "Show FPS", "Zeige FPS", "Pokaż FPS" });
            words.Add("checkBoxTris", new List<string> { "Показывать кол-во рисуемых треугольников", "Show rendered triangles", "Zeige die gerenderten Dreiecke", "Pokaż ilość renderowanych trójkątów" });
            words.Add("checkBoxCamCoord", new List<string> { "Показывать координаты камеры", "Show camera coordinates", "Zeige die Kamera Koordinaten", "Pokaż koordynaty kamery" });
            words.Add("checkBoxVobs", new List<string> { "Показывать кол-во вобов", "Show vobs count", "Zeige die Vobs Anzahl", "Pokaż ilość vobów" });
            words.Add("checkBoxWaypoints", new List<string> { "Показывать кол-во вейпоинтов", "Show waypoints count", "Zeige die Wegpunktanzahl", "Pokaż ilość Waypointów" });
            words.Add("checkBoxDistVob", new List<string> { "Показывать расстояние до выбранного воба", "Show distance to selected vob", "Zeige die Distanz zum ausgewählen Vob", "Pokaż dystans do zaznaczonego voba" });
            words.Add("checkBoxCameraHideWins", new List<string> { "Скрывать окна при полете камеры", "Hide windows when moving camera", "Verstecke die Menüs während der Kamerabewegung", "Ukryj okna podczas poruszania kamerą" });
            words.Add("WIN_KEYSBIND_TEXT", new List<string> { "Сочетания клавиш", "Keys binding", "Tasteneinstellungen", "Przypisanie klawiszy" });
            words.Add("WIN_KEYSBIND_DESC", new List<string> { "Описание", "Description", "Erklörung", "Opis" });
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
            words.Add("CAM_SPEED_X10", new List<string> { "Увеличить скорость полета камеры в 10 раз", "Increase camera moving speed x10", "Erhöhe Kamerageschwindigkeit mal 10", "Zwiększ prędkość kamery x10" });
            words.Add("CAM_SPEED_MINUS_10", new List<string> { "Уменьшить скорость полета камеры в 10 раз", "Decrease camera moving speed x10", "Verringere Kamerageschwindigkeit mal 10", "Zmniejsz prędkość kamery x10" });
            words.Add("VOB_COPY", new List<string> { "Скопировать воб", "Copy vob", "Kopiere vob", "Kopiuj voba" });
            words.Add("VOB_INSERT", new List<string> { "Вставить воб", "Insert vob", "Füge vob ein", "Wklej voba" });
            words.Add("VOB_CUT", new List<string> { "Вырезать воб (смена родителя)", "Cut vob (parent change)", "Schneide Vob aus (Elternwechsel?)", "Wytnij voba (Zmiana nadrzędnego)" });
            words.Add("VOB_FLOOR", new List<string> { "Прижать воб к полу", "Floor the vob", "den vob auf den Boden setzen", "Umieść voba na podłodze" });
            words.Add("VOB_RESET_AXIS", new List<string> { "Сбросить направление воба по осям", "Reset axes of the vob", "die Achse vom vob resetten", "Zresetuj osie voba" });
            words.Add("VOB_DELETE", new List<string> { "Удалить воб", "Remove vob", "vob entfernen", "Usuń voba" });
            words.Add("VOB_TRANSLATE", new List<string> { "Инструмент перемещение", "Tool moving", "Bewegungswerkzeug", "Narzędzie poruszania" });
            words.Add("VOB_ROTATE", new List<string> { "Инструмент вращение", "Tool rotating", "Rotationswerkzeug", "Narzędzie rotacji" });
            words.Add("WP_TOGGLE", new List<string> { "Переключить соединение между вейпоинтами", "Toggle connection between waypoints", "Verbindung zwischen zwei Wegpunkten schalten", "Pokaż połączenia między Waypointami" });
            words.Add("VOB_DISABLE_SELECT", new List<string> { "Снять выделение с воба", "Unselect the vob", "Die Auswahl vom vob aufheben", "Odznacz voba" });
            words.Add("VOB_NEAR_CAM", new List<string> { "Переместить воб перед камерой", "Move vob in front of the camera", "Bewege den vob vor die Kamera", "Przenieś voba przed kamerę" });
            words.Add("VOB_TRANS_FORWARD", new List<string> { "Перемещение воба (вперед)", "Moving vob (forward)", "Bewege den vob (vorwärts)", "Poruszanie voba (do przodu)" });
            words.Add("VOB_TRANS_BACKWARD", new List<string> { "Перемещение воба (назад)", "Moving vob (back)", "Bewege den vob (rückwärts)", "Poruszanie voba (do tyłu)" });
            words.Add("VOB_TRANS_LEFT", new List<string> { "Перемещение воба (влево)", "Moving vob (left)", "Bewege den vob (links)", "Poruszanie voba (w lewo)" });
            words.Add("VOB_TRANS_RIGHT", new List<string> { "Перемещение воба (вправо)", "Moving vob (right)", "Bewege den vob (rechts)", "Poruszanie voba (w prawo)" });
            words.Add("VOB_TRANS_UP", new List<string> { "Перемещение воба (вверх)", "Moving vob (up)", "Bewege den vob (oben)", "Poruszanie voba (w górę)" });
            words.Add("VOB_TRANS_DOWN", new List<string> { "Перемещение воба (вниз)", "Moving vob (down)", "Bewege den vob (unten)", "Poruszanie voba (w dół)" });
            words.Add("VOB_SPEED_X10", new List<string> { "Увеличить скорость перемещения/вращения воба в 10 раз", "Increase vob moving/rotating speed x10", "Erhöhe vob Bewegungsgeschwindigkeit/Rotationsgeschiwndigkeit mal 10", "Zwiększ szybkość przemieszacznia i rotacji x10" });
            words.Add("VOB_SPEED_MINUS_10", new List<string> { "Уменьшить скорость перемещения/вращения воба в 10 раз", "Decrease vob moving/rotating speed x10", "Verringere vob Bewegungsgeschwindigkeit/Rotationsgeschiwndigkeit mal 10", "Zmniejsz szybkość przemieszacznia i rotacji x10" });
            words.Add("VOB_ROT_VERT_RIGHT", new List<string> { "Вращение воба вокруг верт. оси (по часовой стрелке)", "Rotating vob around vertical axis (clockwise)", "Den vob um die vertikale Achse rotieren lassen (Im Uhrzeigersinn)", "Obracanie voba w osi pionowej (zgodnie z wskazówkami zegara)" });
            words.Add("VOB_ROT_VERT_LEFT", new List<string> { "Вращение воба вокруг верт. оси (против часовой стрелки)", "Rotating vob around vertical axis (counterclock-wise)", "Den vob um die vertikale Achse rotieren lassen (Gegen den Uhrzeigersinn)", "Obracanie voba w osi pionowej (przeciwnie do wskazówek zegara)" });
            words.Add("VOB_ROT_FORWARD", new List<string> { "Вращение воба от себя", "Vob rotating from the camera", "vob vor der Kamera rotieren lassen", "Rotacja voba od kamery" });
            words.Add("VOB_ROT_BACK", new List<string> { "Вращение воба на себя", "Vob rotating at the camera", "vob in der Kamera rotieren lassen", "Rotacja voba w kamerze" });
            words.Add("VOB_ROT_RIGHT", new List<string> { "Вращение воба вправо", "Vob rotating to the right", "Vob rechtsherum rotieren lassen", "Rotacja voba w prawo" });
            words.Add("VOB_ROT_LEFT", new List<string> { "Вращение воба влево", "Vob rotating to the left", "Vob linksherum rotieren lassen", "Rotacja voba w lewo" });
            words.Add("VOBLIST_COLLECT", new List<string> { "Собрать вобы в окно Контейнер вобов", "Collect vobes in Vob-List window", "Alle vobs in der VoB-Liste sammeln", "Zbieraj voby w oknie listy-vobów" });
            words.Add("WP_CREATEFAST", new List<string> { "Создать WP/FP по кнопке", "Create WP/FP", "", "Utwórz WP/FP" });
            words.Add("WIN_HIDEALL", new List<string> { "Скрыть все окна", "Hide all windows", "Alle Fenster verstecken", "Ukryj wszystkie okna" });
            words.Add("OPEN_CONTAINER", new List<string> { "Открыть содержимое контейнера oCMobContainer", "Open oCMobContainer container", "Öffne den oCMobContainer Container", "Otwórz kontener oCMobContainer" });
            words.Add("TOGGLE_BBOX", new List<string> { "Показать/Скрыть все BBox", "Show/Hide all the BBoxes", "Zeige/Verstecke alle BBoxen", "Pokaż/Ukryj wszystkie BBoxy" });
            words.Add("TOGGLE_INVIS", new List<string> { "Показать/Скрыть невидимые вобы", "Show/Hide invisible vobs", "Zeige/Verstecke alle unsichtbaren vobs", "Pokaż/Ukryj niewidzialne voby" });
            words.Add("TOGGLE_VOBS", new List<string> { "Показать/Скрыть все вобы", "Show/Hide all vobs", "Zeige/Verstecke alle vobs", "Pokaż/Ukryj wszystkie voby" });
            words.Add("TOGGLE_WAYNET", new List<string> { "Показать/Скрыть Waynet", "Show/Hide Waynet", "Zeige/Verstecke alle Wegpunkte", "Pokaż/Ukryj waynet" });
            words.Add("TOGGLE_HELPERS", new List<string> { "Показать/Скрыть help-вобы", "Show/Hide help vobs", "Zeige/Verstecke Hilfevobs", "Pokaż/Ukryj voby pomocnicze" });
            words.Add("WIN_TREE_TITLE", new List<string> { "Список объектов", "Objects list window", "Objekt-Liste", "Okno listy obiektów" });
            words.Add("buttonCollapse", new List<string> { "Свернуть все", "Collapse all", "alles einstürzen lassen", "Ukryj wszystkie" });
            words.Add("buttonExpand", new List<string> { "Развернуть все", "Expand all", "alles erweitern", "Rozwiń wszystkie" });
            words.Add("buttonTreeSort", new List<string> { "Сортировать", "Sort", "Sortieren", "Sortuj" });
            words.Add("CONTEXTMENU_TREE_INSERT_VOBTREE_PARENT", new List<string> { "Вставить VobTree в выделенный воб", "Insert VobTree into the vob", "Einen Vobbaum in den vob einfügen", "Dodaj Drzewko-Vobów do voba" });
            words.Add("CONTEXTMENU_TREE_INSERT_VOBTREE_GLOBAL", new List<string> { "Вставить VobTree глобально", "Insert VobTree globally", "Einen Vobbaum global einfügen", "Dodaj Drzewko-Vobów globalnie" });
            words.Add("CONTEXTMENU_TREE_SAVE_VOBTREE", new List<string> { "Сохранить выделенный воб в VobTree", "Save vob as VobTree", "vob als vobbaum speichern", "Zapisz voba jako Drzewko-Vobów" });
            words.Add("CONTEXTMENU_TREE_REMOVE_VOB", new List<string> { "Удалить воб", "Remove the vob", "Vob entfernen", "Usuń voba" });
            words.Add("WIN_VOBLIST_TITLE", new List<string> { "Контейнер вобов", "VobList window", "Vob-Liste", "Okno listy vobów" });
            words.Add("labelVobType", new List<string> { "Тип воба", "Vob type", "Vob Typ", "Typ voba" });
            words.Add("labelRadius", new List<string> { "Радиус поиска", "Search radius", "Suchradius", "Promień wyszukiwania" });
            words.Add("WIN_SOUND_TITLE", new List<string> { "Звуки и музыка", "Sounds and music window", "Sound und Musik Fenster", "Okno dźwięku i muzyki" });
            words.Add("groupBoxSound", new List<string> { "Звуки", "Sounds", "Sounds", "Dźwięki" });
            words.Add("groupBoxMusic", new List<string> { "Музыка", "Music", "Musik", "Muzyka" });
            words.Add("buttonPlaySound", new List<string> { "Воспроизвести", "Play", "Abspielen", "Odtwórz" });
            words.Add("labelAllSounds", new List<string> { "Все звуки. Кол-во", "All sound. Count", "Alle sound. Anzahl", "Wszystkie dźwięki. Ilość" });
            words.Add("labelSndList", new List<string> { "Поиск по рег. выражению", "Search using regex", "Suche mit regex", "Wyszukaj za pomocą wyrażenia regularnego" });
            words.Add("buttonOffMusic", new List<string> { "Отключить музыку", "Turn off music", "Musik abschalten", "Wyłącz muzykę" });
            words.Add("buttonMusicOn", new List<string> { "Включить музыку", "Turn on music", "Musik anschalten", "Włącz muzykę" });
            words.Add("checkBoxShutMusic", new List<string> { "Отключать музыку при загрузке", "Shut music after world loaded", "Musik schließen nachdem die Welt geladen worden ist", "Wyłącz muzykę po wczytaniu świata" });
            words.Add("labelMusicVolume", new List<string> { "Громкость", "Volume", "Volumen", "Głośność" });

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
            words.Add("ITEM_BAD_COUNT", new List<string> { "Некорректное число итемов. Строка: ", "Bad item count value! Row: ", "Schlechte Itemanzahl Wert! Reihe:", "Zła wartość ilości przedmiotu! Rząd: " });
            words.Add("groupBoxContainer", new List<string> { "Редактирование BBox", "Editing BBox", "BBox Bearbeitung", @"Edytuj BBox'y" });
            words.Add("buttonClearItems", new List<string> { "Очистить все", "Clear all", "Alles klären", "Wyczyść wszystkie" });
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
            words.Add("WIN_OBJ_TYPE_CANTHERE", new List<string> { "Данный тип воба создается в отдельной вкладке справа!", "This vob type can be created in a special tab!", "Dieser vob Typ kann in einem speziellen Tap erschaffen werden", "Ten typ voba może zostać dodany w specjalnej zakładce!" });
            words.Add("WIN_OBJ_NO_EMPTY_NAME", new List<string> { "Нельзя ввести пустое имя!", "You can't enter an empty name!", "Es kann kein leerer Name genutzt werden!", "Nie możesz podać pustej nazwy!" });
            words.Add("WIN_OBJ_NO_WAYPOINT_NUMBERSONLY", new List<string> { "Имя вейпоинта не может состоять только из цифр!", "Waypoint can't have only numbers in its name!", "Ein Wegpunkte kann nicht nur Zahlen in seinem Namen enthalten", "Waypoint nie może mieć tylko liczb w nazwie!" });
            words.Add("WIN_OBJ_SEARCHVISUAL", new List<string> { "всего", "count", "Anzahl", "ilość" });
            words.Add("WIN_OBJ_SEARCHVISUAL_ALL", new List<string> { "Поиск визуала. Всего", "Visual search. Count", "Visuelle Suche. Anzahl", "Wyszukiwanie po wyglądzie. Ilość" });
            words.Add("COPYBUFFER", new List<string> { "Скопировано в буфер", "Copied to clipboard", "In die Auslage kopieren", "Skopiowano do schowka" });
            words.Add("groupBoxObjAllClasses", new List<string> { "Все классы вобов", "All vobs classes", "Alle vob Klassen", "Wszystkie klasy vobów" });
            words.Add("groupBoxObjPropVobs", new List<string> { "Свойства воба", "Vob properties", "Vob Eigenschaften", "Właściwości voba" });
            words.Add("labelObjAllClassesNameVob", new List<string> { "Имя воба", "Vob name", "Vob Name", "Nazwa voba" });
            words.Add("buttonAllClassesCreateVob", new List<string> { "Создать Vob", "Create Vob", "Vob erschaffen", "Utwórz voba" });
            words.Add("checkBoxDynStat", new List<string> { "Динамич. коллизия", "Dynamic collision", "dynamische Kollision", "Kolizja dynamiczna" });
            words.Add("checkBoxStaStat", new List<string> { "Стат. коллизия", "Static collision", "statische Kollision", "Kolizja statyczna" });
            words.Add("checkBoxShowPreview", new List<string> { "Показывать модель", "Show model preview", "Zeige Modelvorschau", "Pokaż podgląd modelu" });
            words.Add("checkBoxSearchOnly3DS", new List<string> { "Искать только 3DS", "Search only 3DS", "Suche nur in 3DS", "Szukaj tylko 3DS" });
            words.Add("buttonAllClassesClear", new List<string> { "Очистить", "Clear", "Klären", "Wyczyść" });
            words.Add("groupBoxObjItems", new List<string> { "Предметы", "Items", "Items", "Przedmioty" });
            words.Add("TEST_NOT_READY", new List<string> { "ЕЩЕ НЕ СДЕЛАНО", "NOT READY YET", "Noch nicht bereit", "JESZCZE NIE GOTOWE" });
            words.Add("buttonItemsCreate", new List<string> { "Создать Item", "Create Item", "Item erschaffen", "Utwórz przedmiot" });
            words.Add("buttonAddContainer", new List<string> { "Добавить в контейнер->", "Add to container->", "Dem Contrainer hinzufügen->", "Dodaj do kontenera->" });
            words.Add("groupBoxItemsCont", new List<string> { "Редактор сундука", "Edit the container", "Den Container bearbeiten", "Edytuj kontener" });
            words.Add("checkBoxItemShow", new List<string> { "Отображать вещь на экране", "Show model preview", "Zeige Modelvorschau", "Pokaż podgląd modelu" });
            words.Add("labelItemsEditContCount", new List<string> { "Количество", "Count", "Anzahl", "Ilość" });
            words.Add("labelItemsAllItems", new List<string> { "Все вещи игры", "All game items", "Alle Spielitems", "Wszystkie przedmioty z gry" });
            words.Add("labelItemsFindReg", new List<string> { "Поиск по рег. выражению", "Search using regex", "Mit regex suchen", "Wyszukiwanie standardowe" });
            words.Add("groupBoxPFX", new List<string> { "Эффекты частиц", "Particles", "Partikel", "Efekty cząsteczkowe" });
            words.Add("buttonParticles", new List<string> { "Создать PFX", "Create PFX", "PFX erschaffen", "Utwórz PFX" });
            words.Add("checkBoxShowPFXPreview", new List<string> { "Отображать эффект на экране", "Show PFX preview", "Zeige PFXvorschau", "Pokaż podgląd PFX" });
            words.Add("labelAllPfx", new List<string> { "Все эффекты игры", "All game PFXes", "Alle Spiel PFXs", @"Wszystkie PFX'y z gry" });
            words.Add("groupBoxTriggersVob", new List<string> { "Выбранный воб", "Selected vob", "Ausgewählter Vob", "Wybrany vob" });
            words.Add("groupBoxTriggersKeys", new List<string> { "Ключи", "Keys", "Tasten", "Klawisze" });
            words.Add("buttonSendTrigger", new List<string> { "Запустить >>>", "Run >>>", "starten >>>", "Uruchom >>>" });
            words.Add("buttonTriggerCollectSources", new List<string> { "Собрать", "Collect", "Einsammeln", "Zbierz" });
            words.Add("buttonNewKey", new List<string> { "Новый ключ", "New key", "Neue Tasten", "Nowy klawisz" });
            words.Add("buttonRemoveKey", new List<string> { "Удалить ключ", "Remove key", "Taste entfernen", "Usuń klawisz" });
            words.Add("labelTriggerName", new List<string> { "Триггер", "Trigger", "Trigger", "Wyzwalacze" });
            words.Add("labelTriggerCollision", new List<string> { "Коллизия", "Collision", "Kollision", "Kolizja" });
            words.Add("checkBoxDyn", new List<string> { "динамическая", "dynamic", "dynamisch", "dynamiczna" });
            words.Add("checkBoxStat", new List<string> { "статическая", "static", "statisch", "statyczna" });
            words.Add("radioButtonOverwrite", new List<string> { "перезаписать", "overwrite", "überschreiben", "nadpisz" });
            words.Add("labelTriggerInsert", new List<string> { "Вставить", "Insert key", "Taste einfügen", "Dodaj klawisz" });
            words.Add("radioButtonAfter", new List<string> { "после", "after", "danach", "przed" });
            words.Add("radioButtonBefore", new List<string> { "до", "before", "davor", "po" });
            words.Add("labelTriggerTargets", new List<string> { "Цели (targets)", "Targets", "Ziele", "Cele" });
            words.Add("labelTriggersSources", new List<string> { "Источники (sources)", "Sources", "Quellen", "Źródła" });
            words.Add("groupBoxWPFP", new List<string> { "Мировые точки", "World points", "Weltpunkte", "Punkty świata" });
            words.Add("labelNameWPMandatory", new List<string> { "Имя Waypoint (обязательно)", "Waypoint name (mandatory)", "Wegpunktname (verpflichtend)", "Nazwa waypointa (obowiązkowa)" });
            words.Add("labelFreepointMandatory", new List<string> { "Имя Freepoint (обязательно)", "Freepoint name (mandatory)", "Freierpunktname (verpflichtend)", "Nazwa freepointa (obowiązkowa)" });
            words.Add("checkBoxWayNet", new List<string> { "Сразу соединять в сеть", "Connect to waynet at once", "Einmalig dem Wegnetzwerk hinzufügen", "Połącz natychmiast z waynetem" });
            words.Add("checkBoxWPAutoName", new List<string> { "Автогенерация имени", "Auto-generated name", "automatischer Namengenerator", "Nazwa wygenerowana automatycznie" });
            words.Add("checkBoxFPGround", new List<string> { "Прижимать к земле", "Floor the freepoint", "Den Freipunkt an den Boden haften", @"Połóż freepoint'a na podłodze" });
            words.Add("checkBoxAutoNameFP", new List<string> { "Автогенерация имени", "Auto-generated name", "automatischer Namengenerator", "Nazwa wygenerowana automatycznie" });
            words.Add("buttonWPCreate", new List<string> { "Создать Waypoint", "Create Waypoint", "Wegpunkt erschaffen", "Utwórz Waypoint" });
            words.Add("buttonConnectWp", new List<string> { "Соединить WP", "Connect waypoints", "Wegpunkte verbinden", "Połącz Waypointy" });
            words.Add("buttonDisconnectWP", new List<string> { "Разъединить WP", "Disconnect waypoints", "Wegpunkte trennen", "Rozłącz Waypointy" });
            words.Add("buttonFPCreate", new List<string> { "Создать Freepoint", "Create Freepoint", "Freipunkt erschaffen", "Utwórz Freepoint" });

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

            words.Add("loadMeshTimeAll", new List<string> { "Общее время объединения всех мешей", "Total time of merging all the meshes", "Gesamtzeit um alle Meshes zu vereinen", @"Czałkowicy czas łączenia wszystkich mesh'y" });

            words.Add("WORK_PATH_ERROR", new List<string> { "Вы пытаетесь загрузить файл, который не находится в папке _WORK/DATA/. Поместите файл внутрь игры!", "You are trying to load a file which is not in _WORK/DATA/. Place this file inside the game folder!", "Du versuchst eine Datei zu laden, welche nicht im _WORK/DATA/ Ordner ist. Ziehe die Datei zuerst in den Spieleordner!", "Próbujesz wczytać plik, który nie znajduje się w _WORK/DATA/. Umieść go w folderze gry!" });
            words.Add("buttonStopAllSounds", new List<string> { "Заглушить все звуки", "Turn off all sounds", "Alle Sounds abschalten", "Wyłącz wszystkie dźwięki" });
            //

            words.Add("vobs_found_amount", new List<string> { "Найдено", "Found", "Gefunden", "Klasy vobów" });
            words.Add("all_vobs_classes", new List<string> { "Все классы вобов", "Vob classes", "Vob Klassen", "Szukaj w klasach pochodnych" });
            words.Add("search_derived", new List<string> { "Искать в дочерних классах", "Search in derived classes", "In der abgeleiteten Klasse suchen", "Szukaj w klasach pochodnych" });
            words.Add("search_use_regex", new List<string> { "Использовать рег. выражение", "Use regular expression", "Reguläre expression nutzen", "Użyj standardowego wyrażenia" });
            words.Add("BTN_RESET", new List<string> { "Сбросить", "Reset", "Resetten", "Reset" });

            words.Add("NAME_ALREADY_EXISTS", new List<string> { "Такое имя уже существует!", "This name already exists!", "Diesen Namen gibt es bereits!", "Ta nazwa jest już zajęta!" });
            words.Add("Label_Backup", new List<string> { "Старое значение", "Old value", "Alter Wert", "Stara wartość" });
            words.Add("SET_ANY_FIELD_SEARCH", new List<string> { "Выберите хотя бы одно поле!", "Select one field at least!", "Du musst zumindestens ein Feld auswählen!", "Wybierz przynajmniej jedno pole!" });

            words.Add("VOB_SEARCH_START", new List<string> { "Поиск вобов начался...", "Looking for vobs...", "Nach Vob suchen....", "Rozglądanie się za vobami..." });


            //
            words.Add("BAD_REGEX", new List<string> { "Введено некорректное регулярное выражение!", "Wrong regular expression!", "Falscher Regex eingeführt!", "Błędne wyrażenie regularne!" });
            words.Add("VOB_SEARCH_TYPE0", new List<string> { "Искать", "Search", "Suchen", "Szukaj" });

            words.Add("VOB_SEARCH_REPLACEZEN", new List<string> { "Заменено вобов на VobTree: ", "Vobs replaced with VobTree: ", "Vobs mit Vobbaum ersetzt: ", "Voby zastąpione drzewkiem vobów: " });
            words.Add("VOB_SEARCH_REMOVEVOBS", new List<string> { "Удалено вобов: ", "Vobs removed: ", "Vobs entfernt: ", "Usunięto voby: " });
            words.Add("NO_REPLACE_VOBTREE", new List<string> { "VobTree не выбран!", "No VobTree selected!", "Kein Vobbaum ausgewählt!", "Nie wybrano drzewka vobów!" });
            words.Add("VOB_SEARCH_CONVERT", new List<string> { "Преобразовано вобов: ", "Vobs converted: ", " Vobs konvertiert: ", "Przekonwertowane voby: " });
            words.Add("VOB_SEARCH_STOP", new List<string> { "Найдено вобов: ", "Vobs found: ", "Vobs gefunden: ", "Znalezione voby: " });
            words.Add("VOB_SEARCH_TYPE1", new List<string> { "Конвертировать", "Convert", "konvertieren", "Konwertuj" });
            words.Add("VOB_SEARCH_TYPE2", new List<string> { "Заменить на VobTree", "Replace with VobTree", "Mit Vobbaum tauschen", "Zamień na drzewko vobów" });
            words.Add("VOB_SEARCH_TYPE3", new List<string> { "Удалить", "Remove", "Entfernen", "Usuń" });
            words.Add("VOB_SEARCH_CONVERT_RADIO0", new List<string> { "Старый", "Old", "Alt", "Stary" });
            words.Add("VOB_SEARCH_CONVERT_RADIO1", new List<string> { "Новый", "New", "Neu", "Nowy" });


            words.Add("WARNING_VDF_FILE_OPEN", new List<string> { "Внимание! Файл был загружен из VDF/MOD, а не из _WORK/DATA!", "Warning! The file was loaded from VDF/MOD, not from _WORK/DATA!", "Achtung! Die Dati wurde von einer VDF/MOD und nicht vom _WORK/DATA geladen!", "Uwaga! Plik został załadowany z paczki VDF/MOD, nie z _WORK/DATA." });
            words.Add("VOB_SEARCH_TYPE4", new List<string> { "Переименовать", "Rename", "Umbenennen", "Zmień nazwę" });
            words.Add("VOB_SEARCH_RENAME_VOBS", new List<string> { "Переименовано вобов: ", "Vobs renamed: ", "Vobs umbenennen: ", "Vobom zmieniono nazwę: " });
            words.Add("labelRenameVob", new List<string> { "Новое имя", "New name", "Neuer Name", "Nowa nazwa" });
            words.Add("checkBoxAutoNumerate", new List<string> { "Авто-нумерация имен", "Auto numeration of names", "Automaitsche Nummerierung der Namen", "Automatycznie numeruj nazwy" });

            words.Add("MENU_TOP_VIEW_FREEZETIME", new List<string> { "Заморозить время", "Freeze time", "Ingamezeit einfrieren", "Zatrzymanie czasu" });
            words.Add("MENU_TOP_VIEW_POLYGON", new List<string> { "Выделение полигона", "Polygon select", "Polygonauswahl", "Wybór polygonu" });
            words.Add("MENU_TOP_VIEW_RENDERMODE", new List<string> { "Режим рендера", "Render mode", "Renderermodus", "Tryb renderowania" });

            words.Add("CHECK_BADPLUGINS_MSG", new List<string> { "У вас есть плагины, которые могут помешать работе Spacer.net!", "You have plugins which may not work with Spacer.net!", "Möglicherweise sind Plugins installiert, welche nicht mit Spacer.net kompatibel sind!", "Masz pluginy, które mogą nie działać poprawnie z Spacer.net" });

            words.Add("WIN_GRASS_TITLE", new List<string> { "Сеятель объектов", "Objects sewer", "", "Generator obiektów" });
            words.Add("WIN_GRASS_VOBMODEL", new List<string> { "Название модели воба:", "Vob's model:", "", "Model voba:" });
            words.Add("WIN_GRASS_VERTOFFSET", new List<string> { "Смещение воба по вертикали: ", "Vob's vertical offset: ", "", "Przesunięcie pionowe voba:" });
            words.Add("WIN_GRASS_MINRADIUS", new List<string> { "Мин. расстояние между вобами: ", "Minimal distance between vobs: ", "", "Minimalny dystans pomiędzy vobami:" });
            words.Add("VOB_SEARCH_TYPE_DYNAMIC", new List<string> { "Сменить динамич. коллизию", "Toggle dynamic collision", "", "Przełącz dynamiczną kolizję" });
            words.Add("VOB_SEARCH_DYNCOLL_VOBS", new List<string> { "Проставлено коллизий: ", "Collisions set: ", "", "Ustawione kolizje:" });
            words.Add("MENU_TOP_SAVEZENUNC", new List<string> { "Сохранить Vobs", "Save Vobs", "", "Zapisz Voby" });


            words.Add("WIN_GRASS_COPYNAME", new List<string> { "При выделении модели в поиске копировать ее сюда", "Copy model name from another window", "", "Skopiuj nazwę modelu z innego okna" });
            words.Add("WIN_GRASS_REMOVE", new List<string> { "Режим удаления вобов", "Removing vob mod", "", "Usuwanie vobów z moda" });
            words.Add("WIN_GRASS_ISITEM", new List<string> { "Воб - это oCItem", "Inserted vob is oCItem", "", "Dodany vob to oCItem" });
            words.Add("WIN_GRASS_PROTECT", new List<string> { "Защита от зажатия левой кнопки мыши", "Protect from left mouse button pushing", "", "Ochrona przed naciśnięciem lewego przycisku myszki" });
            words.Add("WIN_GRASS_DYNCOLL", new List<string> { "Ставить вобу динамическую коллизию", "Set dynamic collision for vob", "", "Ustaw dynamiczną kolizję dla voba" });
            words.Add("WIN_GRASS_RANDANGLE", new List<string> { "Поворачивать воб на случайный угол вокруг вертикальной оси", "Rotate vob on random angle above vertical axis", "", "Obróć vob o losowy kąt powyżej osi pionowej" });
            words.Add("WIN_GRASS_NORMALPOLYGON", new List<string> { "Ставить воб перпендикулярно полигону", "Set vob perpendicular to the polygon", "", "Ustaw vob prostopadle do polygona" });
            words.Add("checkBoxMiscAutoCompile", new List<string> { "Автокомпиляция мира и света после объединения меша с вобами", "Autocompile world and light after merging mesh with vobs", "", "Autokompilacja świata i światła po połączeniu mesha z vobami" });
            words.Add("checkBoxMiscAutoCompileUncZen", new List<string> { "Автокомпиляция мира и света при загрузки некомпилированного ZEN", "Autocompile world and light after loading uncompiled ZEN", "", "Autokompilacja świata i światła po załadowaniu nieskompilowanego ZENA" });
            words.Add("autoRemoveLevelCompo", new List<string> { "Автоматически удалять лишний zCVobLevelCompo после объединения MESH с вобами", "Auto removing zCVobLevelCompo after merging mesh with vobs", "", "Automatyczne usuwanie zCVobLevelCompo po połączeniu mesha z vobami" });



            words.Add("MENU_TOP_VIEW_GRASS", new List<string> { "Сеятель объектов", "Objects sewer", "", "Generator obiektów" });
            words.Add("MENU_TOP_VIEW_ALTCONTROLLER", new List<string> { "Альтернативное управление", "Alternative controller", "", "Alternatywna kamera" });

            words.Add("CANT_APPLY_PARENT_VOB", new List<string> { "Данный тип воба не может быть родителем!", "This type of vob can't be a parent!", "", "Ten typ voba nie może być zapisany jako rodzic!" });

            words.Add("saveMeshTime", new List<string> { "Сохранение MESH выполнено за", "Saving MESH time...", "Speichern der MESH dauerte", @"Czas zapisywania MESH'a..." });
            words.Add("MENU_TOP_SAVEMESH", new List<string> { "Сохранить MESH", "Save MESH", "", "Zapisz MESH" });

            words.Add("WIN_MSG_CONFIRM", new List<string> { "Подтвердите действие", "Confirm the action", "", "Potwierdź akcję" });
            words.Add("WIN_MSG_CONFIRM_PLACENEARCAM", new List<string> { "Вставить Vobtree перед камерой?", "Do insert vobtree near the camera?", "", "Czy wstawiasz vobtree w pobliżu kamery?" });
            words.Add("CONTEXTMENU_TREE_ADD_PARENT", new List<string> { "Сделать глобальным родителем", "Make this vob as a global parent", "", "Stwórz ten vob jako globalnego rodzica dla wszystkich nowych vobów" });
            words.Add("CONTEXTMENU_TREE_REMOVE_PARENT", new List<string> { "Очистить глобального родителя", "Remove the global parent", "", "Usuń globalnego rodzica" });


            words.Add("CONTEXTMENU_TREE_ADD_VOB", new List<string> { "Добавить воб в быстрый доступ", "Add vob into Fast access list", "", "Dodaj vob do listy szybkiego dostępu" });
            words.Add("QUICKVOBS_PARENT", new List<string> { "Глобальный воб-родитель", "Global parent vob", "", "Globalny rodzic voba" });
            words.Add("QUICKVOBS_ACCESS", new List<string> { "Быстрый доступ", "Fast access", "", "Szybki dostęp" });
            words.Add("TAB_PAGE_OBJECTS", new List<string> { "Объекты", "Objects", "", "Obiekty" });
            words.Add("CONTEXTMENU_FAST_REMOVE_VOB", new List<string> { " Удалить воб из быстрого доступа", "Remove the vob from fast access", "", "Usuń vob z szybkiego dostępu" });
            words.Add("QUICKVOBS_CANTBE_PARENT", new List<string> { "Данный воб не может быть родителем!", "Current vob can't be a parent!", "", "Obecny vob nie może być rodzicem!" });

            words.Add("showLightRadiusVob", new List<string> { "Показывать радиус освещения zCVobLight", "Show radius of light for zCVobLight vobs", "", "Pokaż promień światła dla vobów zCVobLight" });
            words.Add("PROP_BUTTON_COLOR", new List<string> { "Цвет", "Color", "", "Kolor" });
            words.Add("labelItemLocatorRadius", new List<string> { "Радиус показа вещей: ", "Items show radius: ", "", "Pokaż promień: " });
            words.Add("groupBoxItemsLocator", new List<string> { "Локатор предметов: ", "Items locator: ", "", "Lokalizator przedmiotów" });
            words.Add("checkBoxLocatorEnabled", new List<string> { "Включить", "Enabled", "", "Włączony" });
            words.Add("checkBoxLocatorOnlySusp", new List<string> { "Только \"плохие\" oCItem", "Only 'bad' oCItem", "", "Tylko 'zły' oCItem" });

            words.Add("MENU_TOP_WIN_POS", new List<string> { "Положение окон", "Position of windows", "", "Pozycja okien" });
            words.Add("MENU_TOP_WIN_POS_RESET", new List<string> { "Сбросить положение окон", "Reset windows' position", "", "Zresetuj pozycje okien" });
            words.Add("MENU_TOP_WIN_POS_PRESET_1", new List<string> { "Использовать пресет #1 (FullHD)", "Use windows presets #1 (FullHD)", "", "Użyj ustawień dla okien #1 (FullHD)" });



            words.Add("checkBoxShutSounds", new List<string> { "Глушить звуки при загрузке", "Shut sounds after world loaded", "", "Wyłącz dźwięki po załadowaniu świata" });
            words.Add("checkBoxConstSound", new List<string> { "Постоянно глушить звуки", "Always shut all sounds", "", "Zawsze wyłączaj wszystkie dźwięki" });
            words.Add("OnlyOneVobCanBe", new List<string> { "Воб такого типа может быть на карте ТОЛЬКО ОДИН!", "Only ONE vob like this can be on the map!", "", "Tylko jeden vob takiego typu może znajdować się na mapie!" });

            words.Add("checkBoxAutoRemoveAllVisuals", new List<string> { "Автоматически очищать visual для всех zCVobLevelCompo при сохранении ZEN", "Auto cleaning visual for all zCVobLevelCompo before saving ZEN", "", "Automatyczne usuwanie visuali dla wszystkich zCVobLevelCompo przed zapisaniem ZENA" });
            words.Add("GAME_MODE", new List<string> { "Играть за героя", "Play the hero", "", "Zagraj bohaterem" });
            words.Add("ZEN_BAD_NAME", new List<string> { "В имени ZEN не может содержаться '.3DS' ! Переименуйте файл!", "ZEN's name can't contain '.3DS' ! Rename the file.", "", "Nazwa ZEN nie może zawierać '.3DS' ! Zmień nazwę pliku." });
            words.Add("CONTEXTMENU_TREE_RESTORE_POS", new List<string> { "Восстановить позицию воба", "Restore vob's position", "", "Przywróć pozycję voba" });

            words.Add("CANT_COPY_INITSELF", new List<string> { "Нельзя скопировать и вставить глобального родителя в самого себя!", "Can't copy and insert global parent vob into itself!", "", "Nie można skopiować i dodać globalnego rodzica voba do siebie!" });
            words.Add("checkBoxSetNearestVobCam", new List<string> { "Устанавливать камеру на воб с именем VOB_SPACER_CAMERA_START или zCVobStartpoint после загрузки ZEN", "Set the camera near the vob with name VOB_SPACER_CAMERA_START or zCVobStartpoint after loading ZEN", "", "Ustaw kamerę w pobliżu voba z nazwą VOB_SPACER_CAMERA_START lub zCVobStartpoint po załadowaniu ZENA" });


            words.Add("tabControlProps_3", new List<string> { "Настройки", "Settings", "", "Ustawienia" });
            words.Add("checkBoxBoldFontProps", new List<string> { "Выделять основные поля жирным шрифтом", "Use bold font for main fields", "", "Użyj pogrubionej czcionki dla głównych pól" });
            words.Add("checkBoxFontUnderstroke", new List<string> { "Выделять основные поля подчеркнутым шрифтом", "Use understroke font for main fields", "", "Użyj czcionki z podkreśleniem dla pól głównych" });
            words.Add("buttonSelectFontProps", new List<string> { "Выбрать шрифт для свойств", "Select font for properties", "", "Wybierz czcionkę dla właściwości" });
            words.Add("buttonResetFontDefault", new List<string> { "Сбросить шрифт по умолчанию", "Reset font by default", "", "Przywróć domyślną czcionkę" });
            words.Add("labelChangeFontStyleText", new List<string> { "* Для применения выберите объект снова", "* For applying reselect the object", "", "* Aby zastosować ponownie wybierz obiekt" });

            words.Add("MENU_TOP_VIEW_MULTI", new List<string> { "Режим множественного выделения", "Multi selection mode", "", "Tryb wielokrotnego wyboru" });

            words.Add("TAB_PAGE_MATERIALS", new List<string> { "Материалы", "Materials", "", "Materiały" });
            words.Add("NoVisualForSuchVob", new List<string> { "Воб данного типа не может иметь визуал!", "This type of a vob can't have any visual!", "", "Ten typ voba nie może mieć visuala!" });


            words.Add("MENU_TOP_SPECIAL_FUNCS", new List<string> { "Специальные функции", "Special functions", "", "Funkcje specjalne" });
            words.Add("MENU_TOP_CREATE_VOB_VISUALS_LIST", new List<string> { "Сформировать список визуалов локации", "Create a list of files which are used in the location", "", "Stwórz lisę plików, któresą używane w lokacji" });
            words.Add("labelFindVisualArchive", new List<string> { "Искать только в архиве (VDF)", "Search only in selected (VDF)", "", "Szukaj tylko w wybranych (VDF)" });
            words.Add("checkBoxLocatorByName", new List<string> { "Искать по имени:", "Search by name:", "", "Szukaj według nazwy:" });
            words.Add("checkBoxSearchHasChildren", new List<string> { "У воба есть дети", "Vob has children", "", "Vob ma dzieci" });


            words.Add("CONTEXTMENU_TREE_REPLACE_FROM_PARENT", new List<string> { "Переместить все вобы из родителя", "Move all vobs from the parent", "", "Przenieś wszystkie voby od rodzica" });
            words.Add("checkBoxCamShowPortalsInfo", new List<string> { "Показывать информацию о порталах", "Show portals info", "", "Pokaż info o portalach" });

            words.Add("CHECK_SORTING_POLYS", new List<string> { "Сортировать полигоны локации?\nСортировка полигонов в локации сильно замедляет сохранение больших локаций (по времени), однако, это необходимо делать для финальной версии локации, для промежуточных версий локации это необязательно и экономит время.", "Should we sort polygons of the location?\nSorting polygons is necessary for the final version of the location, but it requires much time for saving in big locations, for work version of locations you don't need to sort them every time while saving.", "", "Czy chcesz sortować wielokąty lokacji?\nSortowanie wielokątów jest konieczne dla ostatniej wersji lokacji, ale wymaga dużo czasu przy zapisie w dużych lokacjach, dla wersji roboczych lokacji nie trzeba ich sortować za każdym razem przy zapisie." });
            words.Add("checkBoxShowPolysSort", new List<string> { "При сохранении больших локаций спрашивать о сортировке полигонов (более 200 тыс. полигонов)", "Ask for sorting polygons while saving big locations (more than 200k polygons)", "", "Sortowanie wielokątów podczas zapisywania dużych lokacji (ponad 200k wielokątów)" });

            //0.27

            words.Add("checkBoxShowVobTraceFloor", new List<string> { "Подсвечивать положение воба на поверхности", "Brighten selected vob position on the floor", "", "Rozjaśnij pozycję wybranego voba na podłodze" });

            words.Add("WIN_MSG_CONFIRM_REMOVEVOB", new List<string> { "Удалить воб?", "Remove the vob?", "", "Czy chcesz usunąć vob?" });


            words.Add("WIN_BTN_CONFIRM", new List<string> { "Подтвердить", "Confirm", "", "Potwierdź" });
            words.Add("WIN_LABEL_MACROS_RENAME", new List<string> { "Введите имя:", "Enter the name:", "", "Ustal nazwę:" });
            words.Add("WIN_LABEL_MACROS_NEW", new List<string> { "Введите имя нового макроса:", "Enter the name of a new macros:", "", "Ustal nazwę dla nowego macrosa:" });
            words.Add("WIN_OBJ_TAB8", new List<string> { "Макросы", "Macros", "", "Macros" });
            words.Add("buttonCreateNewMacros", new List<string> { "Создать новый макрос", "Create a new macros", "", "Utwórz nowy macros" });
            words.Add("buttonMacrosRenameCurrent", new List<string> { "Переименовать", "Rename", "", "Zmień nazwę" });
            words.Add("buttonMacrosRemoveCurrent", new List<string> { "Удалить", "Delete", "", "Usuń" });
            words.Add("buttonMacrosReloadFromFile", new List<string> { "Перезагрузить всё из файла", "Reload all from the file", "", "Załaduj ponownie wszystko z pliku" });
            words.Add("buttonMacrosSaveAll", new List<string> { "Сохранить всё в файла", "Save all to the file", "", "Zapisz wszystko do pliku" });
            words.Add("buttonMacrosRun", new List<string> { "Выполнить", "Run", "", "Uruchom" });
            words.Add("buttonMacrosParse", new List<string> { "Парсить и сохранить текущий текст", "Parse and save current text", "", "Parsuj i zapisz aktualny tekst" });
            words.Add("groupBoxMacrosButtons", new List<string> { "Действия", "Actions", "", "Akcje" });





            words.Add("WIN_CAMERA_START", new List<string> { "Старт", "Start", "", "Start" });
            words.Add("WIN_CAMERA_STOP", new List<string> { "Стоп", "Stop", "", "Stop" });
            words.Add("CANT_APPLY_PARENT_CAMERA", new List<string> { "Нельзя вставить новую камеру в другую камеру!", "Can't set current camera as a parent for a new camera!", "", "Nie można ustawić bieżącej kamery jako rodzica dla nowej kamery!" });
            words.Add("CANT_APPLY_CAMERA_NEWKEY", new List<string> { "Свойство камеры стоит FOR_OBJECT, а воба нет!", "Camera has FOR_OBJECT value, but no vob found", "", "Kamera a wartość FOR_OBJECT, ale nie znaleziono voba" });
            words.Add("CAMERA_ITEMS_FORCE_RENAME", new List<string> { "Ключам камеры были проставлены имена", "Camera's keys got its names", "", "Klatki kamery mają swoje nazwy" });
            words.Add("FORM_ENTER_BAD_VALUE_INT", new List<string> { "Введено недопустимое значение! Данное поле целочисленное!", "Invalid value entered. Only integer is allowed in this field!", "", "Wprowadzono nieprawidłową wartość. W tym polu dozwolone są tylko liczby całkowite!" });
            words.Add("FORM_ENTER_BAD_STRING_INPUT", new List<string> { "Введены недопустимые символы!", "Invalid symbols found in the input", "", "W danych wejściowych znaleziono nieprawidłowe symbole" });
            words.Add("checkBoxOnlyLatinInInput", new List<string> { "Допускать ввод только латинских символов в поля свойств", "Allow only Latin symbols as input values", "", "Zezwalaj tylko na symbole łacińskie jako wartości wejściowe" });
            words.Add("MSG_VOB_CANT_BE_COPIED", new List<string> { "Данный тип воба нельзя скопировать!", "This vob type can't be copied!", "", "Ten typ voba nie może zostać skopiowany!" });

            words.Add("groupBoxCameraNew", new List<string> { "Новая камера", "New camera", "", "Nowa kamera" });
            words.Add("FORM_COMMON_NAME", new List<string> { "Имя", "Name", "", "Nazwa" });
            words.Add("FORM_COMMON_CREATE", new List<string> { "Создать", "Create", "", "Utwórz" });


            words.Add("groupBoxCamKeys", new List<string> { "Ключи", "Keyframes", "", " Klatki kluczowe" });
            words.Add("buttonCamSpline", new List<string> { "Добавить позицию", "Add a position", "", "Dodaj pozycję" });
            words.Add("buttonCamTargetSpline", new List<string> { "Добавить цель", "Add a target", "", "Dodaj cel" });


            words.Add("groupBoxCamSettings", new List<string> { "Настройки", "Settings", "", "Ustawienia" });
            words.Add("labelCamTimeSec", new List<string> { "Время полета:", "Fly time:", "", "Czas lotu:" });
            words.Add("checkBoxCameraHide", new List<string> { "Скрывать вобы в полете", "Hide vobs while camera active", "", "Ukryj voby, gdy kamera jest aktywna" });
            words.Add("labelCamGotoKey", new List<string> { "Перейти к ключу: ", "Go to key", "", "Przejdź do klatki" });


            words.Add("FORM_COMMON_DELETE", new List<string> { "Удалить", "Delete", "", "Usuń" });
            words.Add("FORM_CAMERA_INSERT_KEY_HERE", new List<string> { "Вставить новый ключ сюда", "Insert a new key here", "", "Wstaw nową klatkę" });
            words.Add("TOOL_BBOX_CHANGE", new List<string> { "Режим 'Изменение Bbox'", "Bbox change mode", "", "Tryb zmiany BBoxa" });
            words.Add("TOOL_BBOX_CHANGE_LEAVE", new List<string> { "Выход из режима 'Изменение Bbox'", "Leaving bbox change mode", "", "Opuszczenie trybu zmiany Bboxa" });

            words.Add("TOOL_BBOX_MAXS", new List<string> { "Изменение bbox maxs", "Changing bbox maxs", "", "Zmiana maks. bbox" });
            words.Add("TOOL_BBOX_MINS", new List<string> { "Изменение bbox mins", "Changing bbox mins", "", "Zmiana min. bbox" });
            words.Add("TOOL_BBOX_CANT_WORK", new List<string> { "У текущего типа воба нельзя менять bbox!", "Can't change bbox of this vob type", "", "Nie można zmienić bboxa w tym typie voba" });

            words.Add("FORM_HINT_INSERT_WPFP", new List<string> { "*Кнопка {0}, чтобы вставить новый воб", "*Press {0} button to insert a new vob", "", "*Wciśnij klawisz {0} aby dodać nowy vob" });



            words.Add("checkBoxInfoUseZSpy", new List<string> { "Отладочные сообщения zSpy", "zSpy debug messages", "", "Komunikaty debugowania zSpy" });
            words.Add("MSG_COMMON_SEARCH", new List<string> { "Поиск", "Search", "", "Szukaj" });
            words.Add("MSG_COMMON_COMMON", new List<string> { "Общее", "Common", "", "Ogólne" });
            words.Add("MSG_COMMON_MATSEACH", new List<string> { "Поиск материала:", "Material search:", "", "Szukaj materiał:" });


            words.Add("MSG_MATFILTER_NEW_NAME", new List<string> { "Имя фильтра:", "Filter name:", "", "Nazwa filtra:" });
            words.Add("MSG_MATFILTER_RENAME", new List<string> { "Переименование фильтра:", "Rename Filter:", "", "Zmień nazwę filtru:" });

            words.Add("checkBoxMatchNames", new List<string> { "Совпадение имен", "Match vobs names", "", "Dopasuj nazwy vobów" });
            words.Add("checkBoxSearchItem", new List<string> { "Искать oCItem в oCMobContainer", "Search oCItem in oCMobContainer", "", "Szukaj oCItem w oCMobContainer" });

            words.Add("VOBLIST_TYPE_ANY", new List<string> { "Любой тип", "Any type", "", "Dowolny typ" });

            words.Add("MENU_TOP_CONTROLS_VOBS", new List<string> { "Вобы", "Vobs", "", "Voby" });
            words.Add("WIN_CONTROLSET_VOBS_TEXT", new List<string> { "Настройки вобов", "Vobs settings", "", "Ustawienia vobów" });



            words.Add("MSG_COMMON_NO_EMPTY_NAME", new List<string> {  "Имя не может быть пусты", "Name can't be empty!", "", "" });
            words.Add("MSG_COMMON_NO_UNIQUE_NAME", new List<string> { "Такое имя уже есть", "The name already exists!", "", "" });
            words.Add("WIN_MATFILTER_MATLIST", new List<string> { "Список материалов: ", "Materials list: ", "", "" });
            words.Add("WIN_MATFILTER_FILTERLIST_FILES", new List<string> { "Список фильтров", "Filters list", "", "" });
            words.Add("WIN_MATFILTER_FILTER_NEW", new List<string> { "Новый фильтр", "New filter", "", "" });
            words.Add("WIN_MATFILTER_FILTERLIST_RENAME", new List<string> { "Переименовать выбранный", "Rename selected", "", "" });
            words.Add("WIN_MATFILTER_FILTERLIST_SAVE", new List<string> { "Сохранить файл фильтров", "Save filters file", "", "" });

            words.Add("WIN_MATFILTER_FILTER_TITLE", new List<string> { "Фильтр материалов", "Materials filter", "", "" });
            words.Add("WIN_MATFILTER_FILTER_TAB_MESH", new List<string> { "Меш", "Mesh", "", "" });
            words.Add("WIN_MATFILTER_FILTER_TAB_VOBS", new List<string> { "Вобы", "Vobs", "", "Voby" });


            //add : in polish, filters too
            words.Add("WIN_MATFILTER_FILTER_SEARCH_IN_MATS", new List<string> { "Поиск материала в фильтре:", "Search material in the filter:", "", "" });
            words.Add("WIN_MATFILTER_FILTER_TEXTURE", new List<string> { "Текстура", "Texture", "", "" });
            words.Add("WIN_MATFILTER_FILTER_SETTINGS", new List<string> { "Настройки выбранного материала", "Properties of selected material", "", "" });
            words.Add("WIN_MATFILTER_FILTER_SET_FILTER", new List<string> { "Задать фильтр:", "Set filter:", "", "" });
            words.Add("WIN_MATFILTER_FILTER_SET_GROUP", new List<string> { "Задать группу:", "Set group:", "", "" });
            words.Add("WIN_MATFILTER_FILTER_SAVE_FILTER", new List<string> { "Сохранить текущий фильтр", "Save current filter", "", "" });
        }
        
    }
}
