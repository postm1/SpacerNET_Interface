using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace SpacerUnion.Common
{
    public partial class Localizator
    {
        public static void Init()
        {


            //For special symbols use @ before string like @"someString"
            /*
             * 
             *  Use the 3rd column for German, the 4th for Polish, 5th for Czech
             *  For special symbols use @ before string like @"someString"
             */
            // RUSSIAN, ENGLISH, GERMAN, POLISH, CZECH                                        

            AddNewWord("appIsLoading", new List<string> { "Spacer.NET загружается...", "Spacer.NET is loading...", "Spacer.NET lädt", "Spacer.NET trwa ładowanie...", "Spacer.NET se načítá..." });
            AddNewWord("appIsReady", new List<string> { "Программа готова к работе!", "The program is ready!", "Programm ist bereit!", "Program jest gotowy do pracy!", "Program je připraven!" });
            AddNewWord("askSure", new List<string> { "Вы уверены?", "Are you sure?", "Bist du sicher?", "Czy jesteś pewny?", "Jsi si jistý?" });
            AddNewWord("askReset", new List<string> { "Точно сбросить мир?", "Reset world?", "Welt zurücksetzen?", "Zresetować świat?", "Resetovat svět?" });
            AddNewWord("confirmation", new List<string> { "Подтверждение", "Confirmation", "Bestätigen", "Potwierdzenie", "Potvrzení" });
            AddNewWord("loadZen", new List<string> { "Идет загрузка ZEN...", "ZEN is loading...", "ZEN lädt...", "ZEN jest ładowany...", "ZEN se načítá" });
            AddNewWord("isLoading", new List<string> { "загружается...", "is loading...", "lädt...", " jest ładowany...", "se načítá..." });
            AddNewWord("compileZen", new List<string> { "Идет компиляция ZEN...", "Compiling ZEN...", "Kompilieren der ZEN...", @"Kompilowanie ZEN'a...", "Kompilovování ZENu probíhá..." });
            AddNewWord("compileLight", new List<string> { "Идет компиляция света...", "Compiling light...", "Kompilieren von Licht...", "Kompilowanie światła...", "Kompilování světla..." });
            AddNewWord("savingZen", new List<string> { "Идет сохранение ZEN...", "Saving ZEN...", "Speichere ZEN...", @"Zapisywanie ZEN'a...", "Ukládání ZENu" });
            AddNewWord("waynetMsg", new List<string> { "Ошибки WayNet не найдены.", "No Waynet errors found.", "Keine Fehler im Waynet gefunden.", "Nie znaleziono błędów Waynetu.", "Nebyly nalezeny žádné chyby Waynetu." });

            AddNewWord("loadZenTime", new List<string> { "Загрузка ZEN выполнена за", "Loading ZEN time...", "Laden der ZEN dauerte...", @"Czas wczytywania ZEN'a...", "Čas načítání ZENu..." });
            AddNewWord("saveZenTime", new List<string> { "Сохранение ZEN выполнено за", "Saving ZEN time...", "Speichern der ZEN dauerte", @"Czas zapisywania ZEN'a...", "Čas ukládání ZENu..." });
            AddNewWord("loadMeshTime", new List<string> { "Загрузка MESH выполнена за", "Loading MESH time...", "Laden des MESH dauerte...", @"Czas wczytywania MESH'a...", "Čas načítání MESHe..." });
            AddNewWord("mergeZenTime", new List<string> { "Объединение ZEN выполнено за", "Merging ZEN time...", "Zusammenfügen des MESH dauerte...", @"Czas zapisywania MESH'a...", "Čas ukládání MESHe" });
            AddNewWord("saveVobsTime", new List<string> { "Сохранение вобов выполнено за", "Saving vobs time...", "Speichern der VOBS Dauer...", @"Czas zapisywania vobów...", "Čas ukládání VOBS..." });


            AddNewWord("MENU_TOP_FILE", new List<string> { "Файл", "File", "Datei", "Plik", "Soubor" });
            AddNewWord("MENU_TOP_RESET", new List<string> { "Сбросить мир", "Reset world", "Welt zurücksetzen", "Zresetuj świat", "Zresetuj świat", "Resetování světa" });
            AddNewWord("MENU_TOP_EXIT", new List<string> { "Выход", "Exit", "Beenden", "Zakończ", "Ukončit" });
            AddNewWord("MENU_TOP_LANG", new List<string> { "Язык", "Language", "Sprache", "Język", "Jazyk" });
            AddNewWord("MENU_TOP_HELP", new List<string> { "Помощь", "Help", "Hilfe", "Pomoc", "Pomoc" });
            AddNewWord("MENU_TOP_SETTINGS", new List<string> { "Настройки", "Settings", "Einstellungen", "Ustawienia", "Nastavení" });
            AddNewWord("MENU_TOP_WORLD", new List<string> { "Мир", "World", "Welt", "Świat", "Svět" });
            AddNewWord("MENU_TOP_VIEW", new List<string> { "Вид", "View", "Ansicht", "Widok", "Zobrazení" });

            AddNewWord("MENU_TOP_OPENZEN", new List<string> { "Открыть ZEN...", "Open ZEN...", "ZEN öffnen...", "Otwórz ZEN...", "Otevřít ZEN..." });
            AddNewWord("MENU_TOP_MESH", new List<string> { "Открыть MESH...", "Open MESH...", "MESH öffnen...", "Otwórz MESH...", "Otevřít MESH..." });
            AddNewWord("MENU_TOP_MERGE", new List<string> { "Объединить ZEN...", "Merge ZEN...", "ZEN zusammenfügen...", "Połącz ZEN...", "Sloučit ZEN" });
            AddNewWord("MENU_TOP_SAVEZEN", new List<string> { "Сохранить ZEN...", "Save ZEN...", "ZEN speichern...", "Zapisz ZEN...", "Uložit ZEN" });
            AddNewWord("MENU_TOP_ABOUT", new List<string> { "О программе", "About", "Über", "O programie", "O programu" });

            AddNewWord("MENU_TOP_CAM", new List<string> { "Камера", "Camera", "Kamera", "Kamera", "Kamera" });
            AddNewWord("MENU_TOP_CONTROLS", new List<string> { "Управление", "Controls", "Steuerung", "Sterowanie", "Ovládání" });
            AddNewWord("MENU_TOP_MISC", new List<string> { "Прочее", "Misc", "Sonstiges", "Różne", "Různé" });


            AddNewWord("MENU_TOP_VIEW_SHOW", new List<string> { "Показать", "Show", "Anzeigen", "Pokaż", "Ukaž" });
            AddNewWord("MENU_TOP_VIEW_VOBS", new List<string> { "Вобы", "Vobs", "Vobs", "Voby", "Voby" });
            AddNewWord("MENU_TOP_VIEW_WAYNET", new List<string> { "Сетка Waynet", "Waynet", "Wegpunkte", "Waynet", "Waynet" });
            AddNewWord("MENU_TOP_VIEW_HELPER", new List<string> { "Help-вобы", "Help vobs", "Hilfs-Vobs", "Pomocnicze voby", "Pomocné voby" });

            AddNewWord("MENU_TOP_VIEW_BBOX", new List<string> { "Показать все BBox", "Show all the BBoxes", "Alle BBoxen anzeigen", "Pokaż wszystkie BBoxy", "Zobrazit všechny BBoxy" });
            AddNewWord("MENU_TOP_VIEW_INVIS", new List<string> { "Показать невидимые вобы", "Show invisible vobs", "Unsichtbare Vobs anzeigen", "Pokaż niewidzialne voby", "Zobrazit neviditelné voby" });


            AddNewWord("MENU_TOP_COMPILE_LIGHT", new List<string> { "Компиляция света", "Compile light", "Licht kompilieren", "Kompiluj światło", "Kompilace světla" });
            AddNewWord("MENU_TOP_COMPILE_WORLD", new List<string> { "Компиляция мира", "Compile world", "Welt kompilieren", "Kompiluj świat", "Kompilace světa" });


            AddNewWord("MENU_TOP_CAM_ZERO", new List<string> { "Прыгнуть на 000 координаты", "Jump to 000 coordinates", "Springe zu 000 Koordinate", "Przeskocz do koordynatów: 000", "Skočit na souřadnice 000" });

            AddNewWord("MENU_TOP_CAM_COORDS", new List<string> { "Ввести координаты", "Enter coordinates", "Koordinaten einfügen", "Wpisz koordynaty", "Zadej souřadnice" });
            AddNewWord("MENU_TOP_DAYTIME", new List<string> { "Время суток", "Day time", "Tageszeit", "Pora dnia", "Denní doba" });
            AddNewWord("MENU_TOP_MORN", new List<string> { "Утро (07:00)", "Morning (07:00)", "Morgens (07:00)", "Poranek (07:00)", "Ráno (07:00)" });


            AddNewWord("MENU_TOP_NOON", new List<string> { "Обед (12:00)", "Midday (12:00)", "Mittags (12:00)", "Południe (12:00)", "Poledne (12:00)" });
            AddNewWord("MENU_TOP_AFTERNOON", new List<string> { "Вечер (17:00)", "Evening (17:00)", "Abends (17:00)", "Wieczór (17:00)", "Večer (17:00)" });
            AddNewWord("MENU_TOP_NIGHT", new List<string> { "Ночь (00:00)", "Night (00:00)", "Nachts (00:00)", "Noc (00:00)", "Noc (00:00)" });
            AddNewWord("MENU_TOP_ANALYSE_WAYNET", new List<string> { "Анализ WayNet", "Analyze Waynet", "Wegpunkte analysieren", "Analizuj Waynet", "Analyzuj Waynet" });
            AddNewWord("MENU_TOP_PLAY_THE_GAME", new List<string> { "Играть за героя", "Play the hero", "Spiele den Helden", "Zagraj bohaterem", "Hrát za hrdinu" });
            AddNewWord("MENU_TOP_KEYSBINDS", new List<string> { "Сочетания клавиш", "Keys bindings", "Tastaturbelegung", "Przypisanie klawiszy", "Nastavení kláves" });

            AddNewWord("MENU_TOP_HOVER_WININFO", new List<string> { "Окно информации", "Information window", "Infofenster", "Okno informacji", "Informační okno" });
            AddNewWord("MENU_TOP_HOVER_WINOBJ", new List<string> { "Окно объектов", "Objects window", "Objektfenster", "Okno obiektów", "Okno objektů" });
            AddNewWord("MENU_TOP_HOVER_WINSOUND", new List<string> { "Окно звуков", "Sounds window", "Soundfenster", "Okno dźwięków", "Okno zvuků" });
            AddNewWord("MENU_TOP_HOVER_WINTREE", new List<string> { "Окно списка вобов", "All-vobs window", "Alle Vobs-Fenster", "Okno wszystkich obiektów", "Okno všech vobů" });
            AddNewWord("MENU_TOP_HOVER_WINPROPS", new List<string> { "Окно свойств", "Properties window", "Eigenschaftsfenster", "Okno właściwości", "Okno vlastností" });
            AddNewWord("MENU_TOP_HOVER_WINVOBLIST", new List<string> { "Окно воб-лист", "VobList window", "Voblisten-Fenster", "Okno listy vobów", "Okno vob-listu" });



            AddNewWord("WIN_COMPLIGHT_TEXT", new List<string> { "Компиляция света", "Light compilation", "Licht kompilieren", "Kompilacja światła", "Kompilace světla" });
            AddNewWord("WIN_COMPLIGHT_QUALITY", new List<string> { "Качество", "Quality", "Qualität", "Jakość", "Kvalita" });
            AddNewWord("WIN_COMPLIGHT_COMPILEBUTTON", new List<string> { "Компилировать", "Compile", "Kompilieren", "Kompiluj", "Kompilovat" });

            AddNewWord("WIN_INPUT", new List<string> { "Ввод", "Input", "Eingabe", "Wejście", "Vstup" });
            AddNewWord("WIN_CANCEL_BUTTON", new List<string> { "Отмена", "Cancel", "Abbrechen", "Anuluj", "Zrušit" });
            AddNewWord("WIN_COMPLIGHT_CLOSEBUTTON", new List<string> { "Закрыть", "Close", "Schließen", "Zamknij", "Zavřít" });
            AddNewWord("WIN_COMPLIGHT_REGION", new List<string> { "Регион", "Region", "Region", "Region", "Region" });
            AddNewWord("WIN_COMPLIGHT_QUALITY0", new List<string> { "Только вершины", "Vertexes only", "Nur Vertexes", "Tylko vertexy", "Pouze vertexy" });
            AddNewWord("WIN_COMPLIGHT_QUALITY1", new List<string> { "Lightmaps (низкое)", "Lightmaps (low)", "Lightmaps (niedrig)", "Lightmapa (niska)", "Lightmapy (nízké)" });
            AddNewWord("WIN_COMPLIGHT_QUALITY2", new List<string> { "Lightmaps (среднее)", "Lightmaps (medium)", "Lightmaps (mittel)", "Lightmapa (średnia)", "Lightmapy (střední)" });
            AddNewWord("WIN_COMPLIGHT_QUALITY3", new List<string> { "Lightmaps (высокое)", "Lightmaps (high)", "Lightmaps (hoch)", "Lightmapa (wysoka)", "Lightmapy (vysoké)" });

            AddNewWord("WIN_COMPLIGHT_COMPILECHECKBOX", new List<string> { "Компилировать регион", "Compile region", "Region kompilieren", "Kompiluj region", "Kompilovat region" });


            AddNewWord("WIN_COMPLIGHT_METERS", new List<string> { "метров", "meters", "Meter", "metry", "metry" });
            AddNewWord("WIN_COMPLIGHT_AROUNDCAM", new List<string> { "вокруг камеры", "around the camera", "um die Kamera", "na około kamery", "kolem kamery" });


            AddNewWord("WIN_COMPWORLD_TEXT", new List<string> { "Компиляция мира", "World compilation", "Kompilation Welt", "Kompilacja świata", "Kompilace světa" });
            AddNewWord("WIN_COMPWORLD_LOCTYPE", new List<string> { "Тип локации", "World type", "Welt Typ", "Typ świata", "Typ světa" });

            AddNewWord("WIN_CAM_TEXT", new List<string> { "Камера", "Camera", "Kamera", "Kamera", "Kamera" });
            AddNewWord("WIN_CAM_CLOSEWIN", new List<string> { "Закрывать окно при переходе", "Close the window after the jump", "Das Fenster nach dem Wechsel schließen", "Zamknij okno po skoku", "Zavřít okno po skoku" });
            AddNewWord("WIN_CAM_GO", new List<string> { "Перейти", "Jump", "Wechsel", "Skok", "Skok" });

            // UNION STRING
            AddNewWord("UNION_VOB_INSERTED", new List<string> { "Воб вставлен", "The vob inserted", "Vob eingefügt", "Vob został wklejony", "Vob vložen" });
            AddNewWord("UNION_VOB_AXIS_RESET", new List<string> { "Направление воба сброшено", "Vob axes were reset", "Richtung des Vobs geändert", "Osie Voba zostały zresetowane", "Osy Vobu resetovány" });
            AddNewWord("CANT_APPLY_PARENT", new List<string> { "Данный тип воба перенести в родителя нельзя!", "Can't insert this vob type into a parent vob!", "Dieses Vob kann nicht in die übergeordneten Vob eingefügt werden!", "Nie można dodać tego typu Voba jako nadrzędnego.", "Tento typ Vobu není možné přidat jako rodiče." });
            AddNewWord("PARENT_ERROR_OCITEM", new List<string> { "oCItem не может быть родителем!", "oCItem can't be a parent!", "oCItem kann nicht übergeornet sein!", "oCItem nie może być nadrzędny!", "oCItem nemůže být rodičem!" });
            AddNewWord("PARENT_CHANGE_OK", new List<string> { "Родитель для воба изменен!", "The parent has been changed", "Überordnung für Vob wurde geändert", "Vob nadrzędny został zmieniony", "Vob rodiče byl změněn" });
            AddNewWord("VOB_COPY_OK", new List<string> { "Воб скопирован", "Vob was copied", "Vob kopiert", "Vob został skopiowany", "Vob byl zkopírován" });
            AddNewWord("VOB_CUT_OK", new List<string> { "Воб вырезан", "Vob was cut", "Vob ausgeschnitten", "Vob został wycięty", "Vob by vystřižen" });
            AddNewWord("VOB_NEAR_CAMERA", new List<string> { "Воб вставлен перед камерой", "Vob inserted in front of the camera", "Vob vor die Kamera eingefügt", "Vob został stworzony na przeciwko kamery", "Vob vložen před kameru" });
            AddNewWord("TOOL_TRANS", new List<string> { "Выбран инструмент перемещение", "Tool: moving", "Werkzeug: Verschieben", "Narzędzie: Przemieszczanie", "Nástroj: přesun" });
            AddNewWord("TOOL_ROT", new List<string> { "Выбран инструмент вращение", "Tool: rotation", "Werkzeug: Rotieren", "Narzędzie: Rotacja", "Nástroj: rotace" });
            AddNewWord("TOOL_UNSELECT", new List<string> { "Выделение воба снято", "Vob selection cancel", "Vobauswahl aufgehoben", "Wybranie voba zostało anulowane", "Výběr vobu byl zrušen" });
            AddNewWord("TOOL_FLOOR", new List<string> { "Прижимание воба к полу", "Try to floor the vob", "Vob am Boden fixieren", "Spróbuj postawić Voba na podłodze", "Zkusit položit Vob na podlahu" });
            AddNewWord("UNION_LIGHT_RAD_INC", new List<string> { "Радиус освещения увеличен", "Light radius increased", "Lichtradius erhöht", "Promień światła został zwiększony", "Rozsah světla zvýšen" });
            AddNewWord("UNION_LIGHT_RAD_DEC", new List<string> { "Радиус освещения уменьшен", "Light radius decreased", "Lichtradius verringert", "Promień światła został zmniejszony", "Rozsah světla snížen" });
            AddNewWord("UNION_LIGHT_RAD_ZERO", new List<string> { "Радиус освещения сброшен в 0", "Light radius set to 0", "Lichtradius auf 0 gesetzt", "Promień światła został ustawiony na 0", "Rozsah světla nastaven na 0" });
            AddNewWord("UNION_MESH_LOADED", new List<string> { "Меш загружен", "Mesh is loaded", "Mesh geladen", "Mesh jest załadowany", "Mesh je načten" });
            AddNewWord("UNION_MESH_READY", new List<string> { "Меш и вобы объединены. Скомпилируйте мир", "Mesh and vobs were merged. Compile the world", "Mesh und Vobs zusammengeführt. Bitte Welt kompilieren!", "Mesh i voby zostały połączone. Skompiluj świat.", "Meshe a Voby jsou sloučeny. Zkompiluj svět." });
            AddNewWord("UNION_EDITOR", new List<string> { "Редактор для ZenGin", "Editor for ZenGin", "Editor für ZenGin", "Edytor dla ZenGine", "Editor pro ZenGin" });
            AddNewWord("UNION_TEAM", new List<string> { "Разработчик: Liker. Помогали: Patrix & Feuerbarde & Haart & Saturas & Gratt & Jr", "Author: Liker. Assistance from: Patrix & Feuerbarde & Haart & Saturas & Gratt & Jr", "Entwicklerteam: Liker & Patrix  & Feuerbarde & Haart & Saturas & Gratt & Jr", "Deweloperzy: Liker & Patrix & Feuerbarde & Haart & Saturas & Gratt & Jr", "Autoři: Liker & Patrix & Feuerbarde & Haart & Saturas & Gratt & Jr" });
            AddNewWord("UNION_DATE_COMPILE", new List<string> { "Дата компиляции: ", "Compilation date: ", "Datum der Kompilation: ", "Data kompilacji: ", "Datum kompilace: " });
            AddNewWord("UNION_RESOLUTION", new List<string> { "Разрешение рендера: ", "Render resolution: ", "Rendererauflösung: ", "Rozdzielczość renderowania: ", "Rozlišení renderování: " });
            AddNewWord("UNION_NOWORLD", new List<string> { "Мир не загружен", "World is not loaded", "Welt wurde nicht geladen", "Świat nie został wczytany.", "Svět nebyl načten" });
            AddNewWord("UNION_CANT_ABSTRACT", new List<string> { "Не могу создать объект абстрактного класса!", "Can't create a vob of an abstract class", "Kann keine vob von einer abstrakten Klasse erstellen!", "Nie można utworzyć voba klasy abstrakcyjnej", "Nemůžeš vytvořit vob s abstraktní třídou" });
            AddNewWord("ENTER_NAME", new List<string> { "Введите имя воба!", "Enter the name!", "Namen eingeben!", "Podaj nazwę!", "Zadej jméno" });
            AddNewWord("CANT_DELETE_LEVELCOMPO", new List<string> { "Не могу удалить zCVobLevelCompo!", "Can't remove zCVobLevelCompo!", "zCVVobLevelCompo kann nicht entfernt werden!", "Nie można usunąć zCVobLevelCompo!", "Nelze odstranit zCVobLevelCompo" });
            AddNewWord("CANT_DELETE_CAM", new List<string> { "Не могу удалить основную камеру!", "Can't remove the camera!", "Kamera kann nicht entfernt werden", "Nie można usunąć kamery!", "Nelze odstranit kameru!" });
            AddNewWord("UNION_NO_WAYPOINT", new List<string> { "Вейпоинт не выбран!", "No waypoint selected!", "Keinen Wegpunkt ausgewählt", @"Nie wybrano Waypointa", "Nevybrán žádný waypoint" });
            AddNewWord("UNION_NO_WAYPOINT_TEMPLATE", new List<string> { "Шаблон имени вейпоинта пуст!", "Waypoint name template is empty!", "Die Vorlage für den Wegpunktnamen ist leer!", "Nazwa szablonu Waypointów jest pusta!", "Jméno šablony waypointů je prázdné" });
            AddNewWord("UNION_WP_INSERT", new List<string> { "Вейпоинт вставлен: ", "Waypoint inserted: ", "Wegpunkt hinzugefügt:", "Dodano Waypoint: ", "Waypoint vložen" });
            AddNewWord("UNION_WORLD_ONCOMPILE", new List<string> { "Мир скомпилирован.", "World has been compiled.", "Welt wurde kompiliert.", "Świat został skompilowany.", "Svět byl zkompilován" });
            AddNewWord("UNION_VOBTREE_SAVE", new List<string> { "VobTree сохранен!", "VobTree saved!", "VobTree gespeichert!", "Drzewko vobów zostało zapisane!", "VobTree uložen!" });
            AddNewWord("UNION_VOBTREE_INSERT", new List<string> { "VobTree вставлен!", "VobTree inserted!", "VobTree eingefügt!", "Dodano drzewko vobów!", "VobTree vložen!" });
            AddNewWord("UNION_SHOW_TRIS", new List<string> { "Кол-во треугольников: ", "Tris amount: ", "Anzahl Tris: ", "Ilość trisów: ", "Množství trojúhelníků: " });
            AddNewWord("UNION_CAM_POS", new List<string> { "Позиция камеры: ", "Camera pos: ", "Kameraposition: ", "Pozycja kamery: ", "Pozice kamery: " });
            AddNewWord("UNION_CAM_ROT", new List<string> { "Вращение камеры: ", "Camera rot: ", "Kameradrehung: ", "Rotacja kamery: ", "Rotace kamery: " });
            AddNewWord("UNION_VOB_COUNT", new List<string> { "Кол-во вобов: ", "Vobs amount: ", "Anzahl der Vobs: ", "Ilość vobów: ", "Počet Vobů: " });
            AddNewWord("UNION_WP_COUNT", new List<string> { "Кол-во вейпоинтов: ", "Waypoint amount: ", "Anzahl der Wegpunkte: ", "Ilość waypointów: ", "Počet waypointů: " });
            AddNewWord("UNION_DIST", new List<string> { "Дистанция: ", "Distance: ", "Entfernung: ", "Dystans: ", "Vzdálenost: " });
            //NEW
            AddNewWord("WIN_COMPLIGHT_NOWORLD", new List<string> { "Мир не загружен!", "World is not loaded!", "Welt ist nicht geladen!", "Świat nie jest załadowany!", "Svět nebyl načten!" });
            AddNewWord("WIN_COMPLIGHT_NOWORLDCOMPILED", new List<string> { "Мир не скомпилирован!", "World is not compiled!", "Welt ist nicht kompiliert!", "Świat nie jest skompilowany!", "Svět není zkompilován!" });
            AddNewWord("WIN_COMPLIGHT_TIME", new List<string> { "Компиляция света выполнена за", "Light compilaton time", "Licht Kompilierungszeit", "Czas kompilacji światła", "Čas kompilace světla" });
            AddNewWord("WIN_COMPLIGHT_QUALITY0_COMP", new List<string> { "Компиляция (только вершины)", "Compilation (Vertexes only)", "Kompilierung (nur Vertexes)", "Kompilacja (Tylko Vertexy)", "Kompilace (Pouze Vertexy)" });
            AddNewWord("WIN_COMPLIGHT_QUALITY1_COMP", new List<string> { "Компиляция Lightmaps (низкое)", "Compilation Lightmaps (low)", "Kompilierung Lightmaps (niedrig)", "Kompilacja Lightmap (niskie)", "Kompilace Lightmap (nízké)" });
            AddNewWord("WIN_COMPLIGHT_QUALITY2_COMP", new List<string> { "Компиляция Lightmaps (среднее)", "Compilation Lightmaps (medium)", "Kompilierung Lightmaps (mittel)", "Kompilacja Lightmap (średnie)", "Kompilace Lightmap (střední)" });
            AddNewWord("WIN_COMPLIGHT_QUALITY3_COMP", new List<string> { "Компиляция Lightmaps (высокое)", "Compilation Lightmaps (high)", "Kompilierung Lightmaps (hoch)", "Kompilacja Lightmap (wysokie)", "Kompilace Lightmap (vysoké)" });
            AddNewWord("WIN_COMPWORLD_ALREADY_COMP", new List<string> { "Мир уже скомпилирован!", "World is already compiled!", "Welt wurde bereits kompiliert.", "Świat jest już skompilowany!", "Svět je již zkompilován!" });
            AddNewWord("WIN_COMPWORLD_COMPILING", new List<string> { "Мир компилируется...", "World is being compiled!", "Welt wird gerade kompiliert.", "Świat się kompiluje!", "Svět se kompiluje!" });
            AddNewWord("WIN_COMPWORLD_TIME", new List<string> { "Компиляция мира выполнена за", "World compiling time", "Welt Kompilierungszeit", "Czas kompilacji świata", "Čas kompilace světa" });
            AddNewWord("WIN_COMPWORLD_LEVELCOMPO", new List<string> { "Не забудьте удалить лишний zCVobLevelCompo!", "Don't forget to remove the spare zCVobLevelCompo", "Vergiss nicht den 'spare' zCVobLevelCompo zu entfernen", "Nie zapomnij usunąć zapasowego zCVobLevelCompo", "Nezapomeň odstranit náhradní zCVobLevelCompo" });
            AddNewWord("WIN_INFO_TITLE", new List<string> { "Окно информации", "Information window", "Informationsfenster", "Okno informacyjne", "Informační okno" });
            AddNewWord("WIN_INFO_CLEAR", new List<string> { "Очистить", "Clear", "Löschen", "Wyczyść", "Vyčistit" });
            AddNewWord("IS_SAVING", new List<string> { "сохраняется...", "is saving...", "wird gespeichert...", "zapisywanie...", "se ukládá..." });
            AddNewWord("WIN_CAM_GETFROMBUFFER", new List<string> { "Взять из буфера", "Get from clipboard", "Wird aus der Zwischenablage geholt", "Pobierz ze schowka", "Načtení ze schránky" });
            AddNewWord("BTN_APPLY", new List<string> { "Применить", "Apply", "Anwenden", "Zastosuj", "Použít" });
            AddNewWord("BTN_SAVE_CHANGES", new List<string> { "Сохранить изменения", "Save changes", "Änderungen speichern", "Zapisz zmiany", "Uložit změny" });
            AddNewWord("BTN_UP", new List<string> { "Вверх", "Up", "Hoch", "Góra", "Nahoru" });
            AddNewWord("BTN_DOWN", new List<string> { "Вниз", "Down", "Runter", "Dół", "Dolů" });
            AddNewWord("WIN_MISC_SET", new List<string> { "Прочие настройки", "Misc settings", "Verschiedene Einstellungen", "Inne ustawienia", "Další nastavení" });
            AddNewWord("checkBoxSetDatePrefix", new List<string> { "Добавлять префикс даты при сохранении зена", "Add DATE prefix to file when saving ZEN", "Füge Datum Präfix zu Datei hinzu wenn die ZEN gespeichert wird", "Dodaj prefix daty do nazwy zapisanego pliku", "Přidání prefixu datumu do názvu uloženého souboru" });
            AddNewWord("checkBoxMiscExitAsk", new List<string> { "Подтверждать выход если открыт зен", "Confirm exit if ZEN is opened", "Falls ZEN geöffnet ist, bestätige beenden des Editors", "Potwierdź wyjście, gdy ZEN jest otwarty", "Potvrzení ukončení, pokud je otevřen ZEN" });
            AddNewWord("checkBoxLastZenAuto", new List<string> { "Открывать последний ZEN автоматически", "Auto opening last ZEN", "Letzte ZEN automatisch öffnen", "Otwórz automatycznie ostatni świat", "Automaticky otevřít poslední ZEN" });
            AddNewWord("checkBoxMiscFullPath", new List<string> { "Писать полный путь до ZEN в главном окне", "Show full path to ZEN file in main window", "Zeige den vollständigen Pfad zur ZEN Datei im Hauptmenü an", "Pokaż pełną ścieżkę do świata w głównym oknie", "Zobrazení úplné cesty k souboru ZEN v hlavním okně" });
            AddNewWord("WIN_CONTROLSET_TEXT", new List<string> { "Настройки управления", "Controls setttings", "Steuerungseinstellungen", "Ustawienia sterowania", "Nastavení ovládání" });
            AddNewWord("WIN_CONTROLSET_TRANSSPEED", new List<string> { "Скорость перемещения: ", "Moving speed: ", "Bewegungsgeschwindigkeit: ", "Szybkość poruszania: ", "Rychlost pohybu:" });
            AddNewWord("WIN_CONTROLSET_ROTSPEED", new List<string> { "Скорость вращения: ", "Rotation speed: ", "Rotationsgeschiwndigkeit: ", "Szybkość rotacji: ", "Rychlost rotace:" });
            AddNewWord("WIN_CONTROLSET_GROUP0", new List<string> { "Управление вобом", "Vob control", "Vob Kontrolle", "Kontrola Voba", "Ovládání Vobu" });
            AddNewWord("WIN_CONTROLSET_GROUP1", new List<string> { "Вставка воба", "Vob insertion", "Vob Einfügung", "Wstawianie Voba", "Vkládání Vobu" });
            AddNewWord("checkBoxInsertVob", new List<string> { "Вставлять воб на той же высоте", "Insert vob on the same height", "Füge Vob in der Höhe der Quelle ein", "Wstaw voba na wysokości kamery", "Vložit Vob do výšky kamery" });
            AddNewWord("checkBoxVobRotRandAngle", new List<string> { "Поворачивать воб на случайный угол", "Turn vob on a random angle", "Versetze den Vob in einen zufälligen Winkel", "Obróć voba pod dowolnym kątem", "Otočit Vob v náhodném úhlu" });
            AddNewWord("checkBoxVobInsertHierarchy", new List<string> { "Учитывать иерархию при копировании", "Use hierarchy when copying", "Nutze die Hierachie beim Kopieren", "Użyj hierarchii podczas kopiowania", "Při kopírování použít hierarchii" });
            AddNewWord("labelRotWpFP", new List<string> { "Разворачивать WP/FP при вставке", "Turn WP/FP when inserting", "WP/FP beim Einfügen drehen", "Obróć WP/FP podczas dodawania", "Otočit WP/FP při vkládání" });
            AddNewWord("OPTION_CHECK_NONE", new List<string> { "Нет", "None ", "Keine ", "Brak", "Žádné" });
            AddNewWord("radioButtonWPTurnNone", new List<string> { "Нет", "None ", "Keine ", "Nie obracaj", "Žádné" });
            AddNewWord("radioButtonWPTurnAgainst", new List<string> { "От камеры", "From the camera", "Von der Kamera aus", "Z kamery", "Z kamery" });
            AddNewWord("radioButtonWPTurnOn", new List<string> { "На камеру", "At the camera", "Bei der Kamera", "Do kamery", "Do kamery" });
            AddNewWord("radioButtonWPTurnOnRandom", new List<string> { "Случайно", "Random", "Zufällig", "Losowo", "Náhodně" });
            AddNewWord("WIN_CONTROLCAM_TEXT", new List<string> { "Настройки камеры", "Camera settings", "Kameraeinstellungen", "Ustawienia kamery", "Nastavení kamery" });
            AddNewWord("groupBoxCam", new List<string> { "Камера", "Camera", "Kamera", "Kamera", "Kamera" });
            AddNewWord("labelTrans", new List<string> { "Скорость полета", "Moving speed", "Bewegungsgeschwindigkeit", "Prędkość poruszania", "Rychlost pohybu" });
            AddNewWord("labelRot", new List<string> { "Скорость повотора", "Rotation speed", "Rotationsgeschiwndigkeit", "Prędkość rotacji", "Rychlost rotace" });
            AddNewWord("groupBoxRange", new List<string> { "Прорисовка", "Rendering range", "Sichtweite", "Zasięg renderowania", "Rozsah renderování" });
            AddNewWord("labelWorld", new List<string> { "Мир", "World", "Welt", "Świat", "Svět" });
            AddNewWord("labelVobs", new List<string> { "Вобы", "Vobs", "Vobs", "Obiekty", "Voby" });
            AddNewWord("labelLimitFPS", new List<string> { "Ограничить FPS", "Limit FPS", "FPS Limit", "Limit FPS", "Limit FPS" });
            AddNewWord("groupBoxInfo", new List<string> { "Информация", "Information", "Information", "Informacje", "Informace" });
            AddNewWord("checkBoxFPS", new List<string> { "Показывать FPS", "Show FPS", "Zeige FPS", "Pokaż FPS", "Ukaž FPS" });
            AddNewWord("checkBoxTris", new List<string> { "Показывать кол-во рисуемых треугольников", "Show rendered triangles", "Zeige Anzahl gerenderter Tris.", "Pokaż ilość renderowanych trójkątów", "Zobrazit renderované trojúhelníky" });
            AddNewWord("checkBoxVobs", new List<string> { "Показывать кол-во вобов", "Show vobs count", "Zeige die Vobs Anzahl", "Pokaż ilość vobów", "Zobrazit počet vobů" });
            AddNewWord("checkBoxWaypoints", new List<string> { "Показывать кол-во вейпоинтов", "Show waypoints count", "Zeige die Wegpunktanzahl", "Pokaż ilość waypointów", "Zobrazit počet waypointů" });
            AddNewWord("checkBoxDistVob", new List<string> { "Показывать расстояние до выбранного воба", "Show distance to selected vob", "Zeige die Distanz zum ausgewählen Vob", "Pokaż dystans do zaznaczonego voba", "Zobrazit vzdálenost do vybraného vobu" });
            AddNewWord("checkBoxCameraHideWins", new List<string> { "Скрывать окна при полете камеры", "Hide windows when moving camera", "Verstecke die Menüs während der Kamerabewegung", "Ukryj okna podczas poruszania kamerą", "Skrýt okno když se kamera pohybuje" });
            AddNewWord("WIN_KEYSBIND_TEXT", new List<string> { "Сочетания клавиш", "Keys binding", "Tasteneinstellungen", "Przypisanie klawiszy", "Nastavení kláves" });
            AddNewWord("WIN_KEYSBIND_DESC", new List<string> { "Описание", "Description", "Beschreibung", "Opis", "Popis" });
            AddNewWord("WIN_KEYSBIND_BINDS", new List<string> { "Сочетание", "Bind", "Festlegen", "Powiązanie", "Přiřadit" });
            AddNewWord("WIN_KEYSBIND_KEY_SPACE", new List<string> { "Пробел", "Space", "Leertaste", "Spacja", "Mezerník" });
            AddNewWord("WIN_KEYSBIND_KEY_ARROW_LEFT", new List<string> { "Стрелка влево", "Arrow left", "linke Pfeiltaste", "Strzałka w lewo", "Šipka vlevo" });
            AddNewWord("WIN_KEYSBIND_KEY_ARROW_UP", new List<string> { "Стрелка вверх", "Arrow up", "obere Pfeiltaste", "Strzałka w górę", "Šipka nahoru" });
            AddNewWord("WIN_KEYSBIND_KEY_ARROW_RIGHT", new List<string> { "Стрелка вправо", "Arrow right", "rechte Pfeiltaste", "Strzałka w prawo", "Šipka vpravo" });
            AddNewWord("WIN_KEYSBIND_KEY_ARROW_DOWN", new List<string> { "Стрелка вниз", "Arrow down", "untere Pfeiltaste", "Strzałka w dół", "Šipka dolů" });
            AddNewWord("CAMERA_TRANS_FORWARD", new List<string> { "Камера (вперед)", "Camera (forward)", "Kamera (vorwärts)", "Kamera (do przodu)", "Kamera (dopředu)" });
            AddNewWord("CAMERA_TRANS_BACKWARD", new List<string> { "Камера (назад)", "Camera (backward)", "Kamera (rückwärts)", "Kamera (do tyłu)", "Kamera (dozadu)" });
            AddNewWord("CAMERA_TRANS_RIGHT", new List<string> { "Камера (вправо)", "Camera (right)", "Kamera (rechts)", "Kamera (w prawo)", "Kamera (doprava)" });
            AddNewWord("CAMERA_TRANS_LEFT", new List<string> { "Камера (влево)", "Camera (left)", "Kamera (links)", "Kamera (w lewo)", "Kamera (doleva)" });
            AddNewWord("CAMERA_TRANS_UP", new List<string> { "Камера (вверх)", "Camera (up)", "Kamera (oben)", "Kamera (do góry)", "Kamera (nahoru)" });
            AddNewWord("CAMERA_TRANS_DOWN", new List<string> { "Камера (вниз)", "Camera (down)", "Kamera (unten)", "Kamera (w dół)", "Kamera (dolů)" });
            AddNewWord("CAM_SPEED_X10", new List<string> { "Увеличить скорость полета камеры в 10 раз", "Increase camera moving speed x10", "Erhöhe Kamerageschwindigkeit x10", "Zwiększ prędkość kamery x10", "Zvýšení rychlosti kamery x10" });
            AddNewWord("CAM_SPEED_MINUS_10", new List<string> { "Уменьшить скорость полета камеры в 10 раз", "Decrease camera moving speed x10", "Verringere Kamerageschwindigkeit x10", "Zmniejsz prędkość kamery x10", "Snížení rychlosti kamery x10" });
            AddNewWord("VOB_COPY", new List<string> { "Скопировать воб", "Copy vob", "Kopiere Vob", "Kopiuj voba", "Kopírovat Vob" });
            AddNewWord("VOB_INSERT", new List<string> { "Вставить воб", "Insert vob", "Füge Vob ein", "Wklej voba", "Vložit Vob" });
            AddNewWord("VOB_CUT", new List<string> { "Вырезать воб (смена родителя)", "Cut vob (parent change)", "Schneide Vob aus (Elternwechsel)", "Wytnij voba (Zmiana nadrzędnego)", "Vyjmout vob (Změna rodiče)" });
            AddNewWord("VOB_FLOOR", new List<string> { "Прижать воб к полу", "Floor the vob", "Den Vob auf den Boden setzen", "Umieść voba na podłodze", "Umístit vob na podlahu" });
            AddNewWord("VOB_RESET_AXIS", new List<string> { "Сбросить направление воба по осям", "Reset axes of the vob", "Die Achse vom Vob resetten", "Zresetuj osie voba", "Resetování osy vobu" });
            AddNewWord("VOB_DELETE", new List<string> { "Удалить воб", "Remove vob", "Vob entfernen", "Usuń voba", "Odstranit vob" });
            AddNewWord("VOB_TRANSLATE", new List<string> { "Инструмент перемещение", "Tool moving", "Bewegungswerkzeug", "Narzędzie poruszania", "Nástroj pohybu" });
            AddNewWord("VOB_ROTATE", new List<string> { "Инструмент вращение", "Tool rotating", "Rotationswerkzeug", "Narzędzie rotacji", "Nástroj rotace" });
            AddNewWord("WP_TOGGLE", new List<string> { "Переключить соединение между вейпоинтами", "Toggle connection between waypoints", "Verbindung zwischen Wegpunkten umschalten", "Pokaż połączenia między Waypointami", "Přepínání spojení mezi Waypointy" });
            AddNewWord("VOB_DISABLE_SELECT", new List<string> { "Снять выделение с воба", "Unselect the vob", "Die Auswahl vom Vob aufheben", "Odznacz voba", "Odznačit vob" });
            AddNewWord("VOB_NEAR_CAM", new List<string> { "Переместить воб перед камерой", "Move vob in front of the camera", "Bewege den Vob vor die Kamera", "Przenieś voba przed kamerę", "Přesunout vob před kameru" });
            AddNewWord("VOB_TRANS_FORWARD", new List<string> { "Перемещение воба (вперед)", "Moving vob (forward)", "Bewege den Vob (vorwärts)", "Poruszanie voba (do przodu)", "Pohyb vobu (dopředu)" });
            AddNewWord("VOB_TRANS_BACKWARD", new List<string> { "Перемещение воба (назад)", "Moving vob (back)", "Bewege den Vob (rückwärts)", "Poruszanie voba (do tyłu)", "Pohyb vobu (dozadu)" });
            AddNewWord("VOB_TRANS_LEFT", new List<string> { "Перемещение воба (влево)", "Moving vob (left)", "Bewege den Vob (links)", "Poruszanie voba (w lewo)", "Pohyb vobu (doleva)" });
            AddNewWord("VOB_TRANS_RIGHT", new List<string> { "Перемещение воба (вправо)", "Moving vob (right)", "Bewege den Vob (rechts)", "Poruszanie voba (w prawo)", "Pohyb vobu (doprava)" });
            AddNewWord("VOB_TRANS_UP", new List<string> { "Перемещение воба (вверх)", "Moving vob (up)", "Bewege den Vob (oben)", "Poruszanie voba (w górę)", "Pohyb vobu (nahoru)" });
            AddNewWord("VOB_TRANS_DOWN", new List<string> { "Перемещение воба (вниз)", "Moving vob (down)", "Bewege den Vob (unten)", "Poruszanie voba (w dół)", "Pohyb vobu (dolů)" });
            AddNewWord("VOB_SPEED_X10", new List<string> { "Увеличить скорость перемещения/вращения воба в 10 раз", "Increase vob moving/rotating speed x10", "Erhöhe Vob Bewegungsgeschwindigkeit/Rotationsgeschiwndigkeit x10", "Zwiększ szybkość przemieszacznia i rotacji x10", "Zvýšení rychlosti pohybu/rotace vobu 10x" });
            AddNewWord("VOB_SPEED_MINUS_10", new List<string> { "Уменьшить скорость перемещения/вращения воба в 10 раз", "Decrease vob moving/rotating speed x10", "Verringere vob Bewegungsgeschwindigkeit/Rotationsgeschiwndigkeit x10", "Zmniejsz szybkość przemieszacznia i rotacji x10", "Snížení rychlosti pohybu/rotace vobu 10x" });
            AddNewWord("VOB_ROT_VERT_RIGHT", new List<string> { "Вращение воба вокруг верт. оси (по часовой стрелке)", "Rotating vob around vertical axis (clockwise)", "Den vob um die vertikale Achse rotieren lassen (Im Uhrzeigersinn)", "Obracanie voba w osi pionowej (zgodnie z wskazówkami zegara)", "Rotace vobu kolem svislé osy (ve směru hodinových ručiček)" });
            AddNewWord("VOB_ROT_VERT_LEFT", new List<string> { "Вращение воба вокруг верт. оси (против часовой стрелки)", "Rotating vob around vertical axis (counterclock-wise)", "Den vob um die vertikale Achse rotieren lassen (Gegen den Uhrzeigersinn)", "Obracanie voba w osi pionowej (przeciwnie do wskazówek zegara)", "Rotace vobu kolem svislé osy (proti směru hodinových ručiček)" });
            AddNewWord("VOB_ROT_FORWARD", new List<string> { "Вращение воба от себя", "Vob rotating from the camera", "Vob vor der Kamera rotieren lassen", "Rotacja voba od kamery", "Rotace vobu od kamery" });
            AddNewWord("VOB_ROT_BACK", new List<string> { "Вращение воба на себя", "Vob rotating at the camera", "Vob in der Kamera rotieren lassen", "Rotacja voba w kamerze", "Rotace vobu do kamery" });
            AddNewWord("VOB_ROT_RIGHT", new List<string> { "Вращение воба вправо", "Vob rotating to the right", "Vob rechtsherum rotieren lassen", "Rotacja voba w prawo", "Rotace vobu doprava" });
            AddNewWord("VOB_ROT_LEFT", new List<string> { "Вращение воба влево", "Vob rotating to the left", "Vob linksherum rotieren lassen", "Rotacja voba w lewo", "Rotace vobu doleva" });
            AddNewWord("VOBLIST_COLLECT", new List<string> { "Собрать вобы в окно Контейнер вобов", "Collect vobes in Vob-List window", "Alle vobs in der Vob-Liste sammeln", "Zbieraj voby w oknie listy-vobów", "Vybrat voby v okně Vob-Listu" });
            AddNewWord("WP_CREATEFAST", new List<string> { "Создать WP/FP по кнопке", "Create WP/FP", "WP/FP erstellen", "Utwórz WP/FP", "Vytvořit WP/FP" });
            AddNewWord("WIN_HIDEALL", new List<string> { "Скрыть все окна", "Hide all windows", "Alle Fenster verstecken", "Ukryj wszystkie okna", "Skrýt všechna okna" });
            AddNewWord("OPEN_CONTAINER", new List<string> { "Открыть содержимое контейнера oCMobContainer", "Open oCMobContainer container", "Öffne den oCMobContainer Container", "Otwórz kontener oCMobContainer", "Otevřít oCMobContainer kontejner" });
            AddNewWord("TOGGLE_BBOX", new List<string> { "Показать/Скрыть все BBox", "Show/Hide all the BBoxes", "Zeige/Verstecke alle BBoxen", "Pokaż/Ukryj wszystkie BBoxy", "Zobrazit/Skrýt všechny BBoxy" });
            AddNewWord("TOGGLE_INVIS", new List<string> { "Показать/Скрыть невидимые вобы", "Show/Hide invisible vobs", "Zeige/Verstecke alle unsichtbaren vobs", "Pokaż/Ukryj niewidzialne voby", "Zobrazit/Skrýt neviditelné voby" });
            AddNewWord("TOGGLE_VOBS", new List<string> { "Показать/Скрыть все вобы", "Show/Hide all vobs", "Zeige/Verstecke alle vobs", "Pokaż/Ukryj wszystkie voby", "Zobrazit/Skrýt všechny voby" });
            AddNewWord("TOGGLE_WAYNET", new List<string> { "Показать/Скрыть Waynet", "Show/Hide Waynet", "Zeige/Verstecke alle Wegpunkte", "Pokaż/Ukryj waynet", "Zobrazit/Skrýt Waynet" });
            AddNewWord("TOGGLE_HELPERS", new List<string> { "Показать/Скрыть help-вобы", "Show/Hide help vobs", "Zeige/Verstecke Hilfvobs", "Pokaż/Ukryj voby pomocnicze", "Zobrazit/Skrýt pomocné voby" });
            AddNewWord("WIN_TREE_TITLE", new List<string> { "Список объектов", "Objects list window", "Objektlisten Fenster", "Okno listy obiektów", "Okno listu objektů" });
            AddNewWord("buttonCollapse", new List<string> { "Свернуть все", "Collapse all", "Alle einklappen", "Ukryj wszystkie", "Sbalit vše" });
            AddNewWord("buttonExpand", new List<string> { "Развернуть все", "Expand all", "Alles ausklappen", "Rozwiń wszystkie", "Rozbalit vše" });
            AddNewWord("buttonTreeSort", new List<string> { "Сортировать", "Sort", "Sortieren", "Sortuj", "Seřadit" });
            AddNewWord("CONTEXTMENU_TREE_INSERT_VOBTREE_PARENT", new List<string> { "Вставить VobTree в выделенный воб", "Insert VobTree into the vob", "Einen Vobbaum in den Vob einfügen", "Dodaj Drzewko-Vobów do voba", "Vložit VobTree do vobu" });
            AddNewWord("CONTEXTMENU_TREE_INSERT_VOBTREE_GLOBAL", new List<string> { "Вставить VobTree глобально", "Insert VobTree globally", "Einen Vobbaum global einfügen", "Dodaj Drzewko-Vobów globalnie", "Vložit VobTree globálně" });
            AddNewWord("CONTEXTMENU_TREE_SAVE_VOBTREE", new List<string> { "Сохранить выделенный воб в VobTree", "Save vob as VobTree", "Vob als Vobbaum speichern", "Zapisz voba jako Drzewko-Vobów", "Uložit vob jako VobTree" });
            AddNewWord("CONTEXTMENU_TREE_REMOVE_VOB", new List<string> { "Удалить воб", "Remove the vob", "Vob entfernen", "Usuń voba", "Odstranit vob" });
            AddNewWord("WIN_VOBLIST_TITLE", new List<string> { "Контейнер вобов", "VobList window", "Vob-Liste", "Okno listy vobów", "Okno Vob listu" });
            AddNewWord("labelVobType", new List<string> { "Тип воба", "Vob type", "Vob Typ", "Typ voba", "Typ vobu" });
            AddNewWord("labelRadius", new List<string> { "Радиус поиска", "Search radius", "Suchradius", "Promień szukania", "Rozsah hledání" });
            AddNewWord("WIN_SOUND_TITLE", new List<string> { "Звуки и музыка", "Sounds and music window", "Sound und Musik Fenster", "Okno dźwięku i muzyki", "Okno zvuků a hudby" });
            AddNewWord("groupBoxSound", new List<string> { "Звуки", "Sounds", "Sounds", "Dźwięki", "Zvuky" });
            AddNewWord("groupBoxMusic", new List<string> { "Музыка", "Music", "Musik", "Muzyka", "Hudba" });
            AddNewWord("buttonPlaySound", new List<string> { "Воспроизвести", "Play", "Abspielen", "Odtwórz", "Hrát" });
            AddNewWord("labelAllSounds", new List<string> { "Все звуки. Кол-во", "All sound. Count", "Alle Sounds. Anzahl", "Wszystkie dźwięki. Ilość", "Všechny zvuky. Počet" });
            AddNewWord("labelSndList", new List<string> { "Поиск по рег. выражению", "Search using regex", "Suche mit regex", "Wyszukaj za pomocą wyrażenia regularnego", "Hledání skrze regex" });
            AddNewWord("buttonOffMusic", new List<string> { "Отключить музыку", "Turn off music", "Musik abschalten", "Wyłącz muzykę", "Vypnutí hudby" });
            AddNewWord("buttonMusicOn", new List<string> { "Включить музыку", "Turn on music", "Musik anschalten", "Włącz muzykę", "Zapnutí hudby" });
            AddNewWord("checkBoxShutMusic", new List<string> { "Отключать музыку при загрузке", "Shut music after world loaded", "Musik nach Welt laden Stummen", "Wyłącz muzykę po wczytaniu świata", "Vypnout hudbu po načtení světa" });
            AddNewWord("labelMusicVolume", new List<string> { "Громкость", "Volume", "Lautstärke", "Głośność", "Hlasitost" });
            AddNewWord("WIN_PROPS_TITLE", new List<string> { "Окно свойств", "Properties window", "Eigenschaftenfenster", "Okno właściwości", "Okno vlastností" });
            AddNewWord("buttonApplyOnVob", new List<string> { "Применить на вобе", "Apply on the vob", "Auf den vob anwenden", "Zastosuj dla voba", "Aplikovat na vob" });
            AddNewWord("buttonFileOpen", new List<string> { "Файл", "File", "Datei", "Plik", "Soubor" });
            AddNewWord("buttonRestoreVobProp", new List<string> { "Восстановить", "Restore", "Wiederherstellen", "Przywróć", "Obnovit" });
            AddNewWord("buttonOpenContainer", new List<string> { "Контейнер", "Container", "Container", "Kontener", "Kontejner" });
            AddNewWord("tabControlProps_0", new List<string> { "Редактирование", "Edit", "Editieren", "Edytuj", "Editovat" });
            AddNewWord("tabControlProps_1", new List<string> { "BBox", "Bbox", "Bbox", "BBox", "BBox" });
            AddNewWord("tabControlProps_2", new List<string> { "Контейнер", "Container", "Container", "Kontener", "Kontejner" });
            AddNewWord("groupBoxEditBbox", new List<string> { "Редактирование BBox", "Editing BBox", "BBox Bearbeitung", @"Edytuj BBox'y", "Editace BBoxu" });
            AddNewWord("NO_ITEM_NAME", new List<string> { "Имя вещи не может быть пустым! Строка: ", "Item name is empty! Row: ", "Itemname ist leer! Reihe:", "Nazwa przedmiotu jest pusta! Rząd: ", "Jméno předmětu je prázdné! Řádek: " });
            AddNewWord("NO_ITEM_COUNT", new List<string> { "Кол-во итемов не может быть пустым! Строка: ", "Item count is empty! Row: ", "Itemanzahl ist leer! Reihe:", "Ilość przedmiotów jest pusta! Rząd: ", "Počet předmětů je prázdný! Řádek: " });
            AddNewWord("ITEM_BAD_COUNT", new List<string> { "Некорректное число итемов. Строка: ", "Bad item count value! Row: ", "Falscher Itemanzahl Wert! Reihe:", "Zła wartość ilości przedmiotu! Rząd: ", "Špatná hodnota počtu předmětů! Řádek: " });
            AddNewWord("groupBoxContainer", new List<string> { "Редактирование BBox", "Editing BBox", "BBox Bearbeitung", @"Edytuj BBox'y", "Editace BBoxu" });
            AddNewWord("buttonClearItems", new List<string> { "Очистить все", "Clear all", "Alles löschen", "Wyczyść wszystkie", "Vyčistit vše" });
            AddNewWord("buttonRowDelete", new List<string> { "Удалить текущую", "Remove current", "Aktuelles entfernen", "Wyczyść obecny", "Odstranit stávající" });
            AddNewWord("ITEMS_COLUMN_INSTANCE", new List<string> { "Инстанция", "Instance", "Instanz", "Instancja", "Instance" });
            AddNewWord("ITEMS_COLUMN_COUNT", new List<string> { "Кол-во", "Count", "Anzahl", "Ilość", "Počet" });
            AddNewWord("WIN_OBJ_TITLE", new List<string> { "Окно объектов", "Objects window", "Objektfenster", "Okno obiektów", "Okno objektů" });
            AddNewWord("WIN_OBJ_TAB0", new List<string> { "Все классы", "All classes", "Alle Klassen", "Wszystkie klasy", "Všechny třídy" });
            AddNewWord("WIN_OBJ_TAB1", new List<string> { "Вещи", "Items", "Items", "Przedmioty", "Předmět" });
            AddNewWord("WIN_OBJ_TAB2", new List<string> { "Эффекты", "Particles", "Partikel", "Efekty cząsteczkowe", "Částice" });
            AddNewWord("WIN_OBJ_TAB3", new List<string> { "Триггеры", "Triggers", "Triggers", "Wyzwalacze", "Triggery" });
            AddNewWord("WIN_OBJ_TAB4", new List<string> { "WP/FP", "WP/FP", "WP/FP", "WP/FP", "WP/FP" });
            AddNewWord("WIN_OBJ_TAB5", new List<string> { "Поиск", "Search", "Suche", "Szukaj", "Hledat" });
            AddNewWord("WIN_OBJ_TAB6", new List<string> { "Камера", "Camera", "Kamera", "Kamera", "Kamera" });
            AddNewWord("WIN_OBJ_TAB7", new List<string> { "Свет", "Light", "Licht", "Światło", "Světlo" });
            AddNewWord("WIN_OBJ_ALLMODELS", new List<string> { "Поиск визуала", "Visual search", "Visuelle Suche", "Szukaj wyglądu", "Vizuální hledávání" });
            AddNewWord("WIN_OBJ_ALL", new List<string> { "всего", "count", "Anzahl", "ilość", "počet" });
            AddNewWord("WIN_OBJ_TYPE_CANTHERE", new List<string> { "Данный тип воба создается в отдельной вкладке справа!", "This vob type can be created in a special tab!", "Dieser Vob Typ kann in einem speziellen Tap erschaffen werden", "Ten typ voba może zostać dodany w specjalnej zakładce!", "Tento typ vobu lze vytvořit ve speciální kartě!" });
            AddNewWord("WIN_OBJ_NO_EMPTY_NAME", new List<string> { "Нельзя ввести пустое имя!", "You can't enter an empty name!", "Es kann kein leerer Name genutzt werden!", "Nie możesz podać pustej nazwy!", "Nelze zadat prázdné jméno!" });
            AddNewWord("WIN_OBJ_NO_WAYPOINT_NUMBERSONLY", new List<string> { "Имя вейпоинта не может состоять только из цифр!", "Waypoint can't have only numbers in its name!", "Ein Wegpunkte kann nicht nur Zahlen in seinem Namen enthalten", "Waypoint nie może mieć tylko liczb w nazwie!", "Waypoint nemůže mít v názvu pouze čísla!" });
            AddNewWord("WIN_OBJ_SEARCHVISUAL", new List<string> { "всего", "count", "Anzahl", "ilość", "počet" });
            AddNewWord("WIN_OBJ_SEARCHVISUAL_ALL", new List<string> { "Поиск визуала. Всего", "Visual search. Count", "Visuelle Suche. Anzahl", "Wyszukiwanie po wyglądzie. Ilość", "Vizuální hledání. Počet" });
            AddNewWord("COPYBUFFER", new List<string> { "Скопировано в буфер", "Copied to clipboard", "In die Zwischenablage kopieren", "Skopiowano do schowka", "Zkopírováno do schránky" });
            AddNewWord("groupBoxObjAllClasses", new List<string> { "Все классы вобов", "All vobs classes", "Alle Vob Klassen", "Wszystkie klasy vobów", "Všechny vob třídy" });
            AddNewWord("groupBoxObjPropVobs", new List<string> { "Свойства воба", "Vob properties", "Vob Eigenschaften", "Właściwości voba", "Vlastnosti vobu" });
            AddNewWord("labelObjAllClassesNameVob", new List<string> { "Имя воба", "Vob name", "Vob Name", "Nazwa voba", "Jméno vobu" });
            AddNewWord("buttonAllClassesCreateVob", new List<string> { "Создать Vob", "Create Vob", "Vob erstellen", "Utwórz voba", "Vytvořit vob" });
            AddNewWord("checkBoxDynStat", new List<string> { "Динамич. коллизия", "Dynamic collision", "Dynamische Kollision", "Kolizja dynamiczna", "Dynamická kolize" });
            AddNewWord("checkBoxStaStat", new List<string> { "Стат. коллизия", "Static collision", "Statische Kollision", "Kolizja statyczna", "Statická kolize" });
            AddNewWord("checkBoxShowPreview", new List<string> { "Показывать модель", "Show model preview", "Zeige Modelvorschau", "Pokaż podgląd modelu", "Zobrazit náhled modelu" });
            AddNewWord("checkBoxSearchOnly3DS", new List<string> { "Искать только 3DS", "Search only 3DS", "Suche nur in 3DS", "Szukaj tylko 3DS", "Hledej jen 3DS" });
            AddNewWord("buttonAllClassesClear", new List<string> { "Очистить", "Clear", "Löschen", "Wyczyść", "Vyčistit" });
            AddNewWord("groupBoxObjItems", new List<string> { "Предметы", "Items", "Items", "Przedmioty", "Předměty" });
            AddNewWord("buttonItemsCreate", new List<string> { "Создать Item", "Create Item", "Item erschaffen", "Utwórz przedmiot", "Vytvořit předmět" });
            AddNewWord("buttonAddContainer", new List<string> { "Добавить в контейнер->", "Add to container->", "Dem Contrainer hinzufügen->", "Dodaj do kontenera->", "Přidat do kontejneru->" });
            AddNewWord("groupBoxItemsCont", new List<string> { "Редактор сундука", "Edit the container", "Den Container bearbeiten", "Edytuj kontener", "Editovat kontejner" });
            AddNewWord("checkBoxItemShow", new List<string> { "Отображать вещь на экране", "Show model preview", "Zeige Modelvorschau", "Pokaż podgląd modelu", "Zobrazit náhled předmětu" });
            AddNewWord("labelItemsEditContCount", new List<string> { "Количество", "Count", "Anzahl", "Ilość", "Počet" });
            AddNewWord("labelItemsAllItems", new List<string> { "Все вещи игры", "All game items", "Alle Spielitems", "Wszystkie przedmioty z gry", "Všechny předměty hry" });
            AddNewWord("labelItemsFindReg", new List<string> { "Поиск по рег. выражению", "Search using regex", "Mit regex suchen", "Wyszukiwanie standardowe", "Hledání skrze regex" });
            AddNewWord("groupBoxPFX", new List<string> { "Эффекты частиц", "Particles", "Partikel", "Efekty cząsteczkowe", "Částice" });
            AddNewWord("buttonParticles", new List<string> { "Создать PFX", "Create PFX", "PFX erschaffen", "Utwórz PFX", "Vytvořit PFX" });
            AddNewWord("checkBoxShowPFXPreview", new List<string> { "Отображать эффект на экране", "Show PFX preview", "Zeige PFX Vorschau", "Pokaż podgląd PFX", "Zobrazit náhled PFX" });
            AddNewWord("labelAllPfx", new List<string> { "Все эффекты игры", "All game PFXes", "Alle Spiel PFXs", @"Wszystkie PFX'y z gry", "Všechny PFX hry" });
            AddNewWord("groupBoxTriggersVob", new List<string> { "Выбранный воб", "Selected vob", "Ausgewählter Vob", "Wybrany vob", "Vybraný vob" });
            AddNewWord("groupBoxTriggersKeys", new List<string> { "Ключи", "Keys", "Tasten", "Klucze", "Klávesy" });
            AddNewWord("buttonSendTrigger", new List<string> { "Запустить >>>", "Run >>>", "Starten >>>", "Uruchom >>>", "Spustit >>>" });
            AddNewWord("buttonTriggerCollectSources", new List<string> { "Собрать", "Collect", "Einsammeln", "Zbierz", "Sbírat" });
            AddNewWord("buttonNewKey", new List<string> { "Новый ключ", "New key", "Neuer Key", "Nowy klucz", "Nová klávesa" });
            AddNewWord("buttonRemoveKey", new List<string> { "Удалить ключ", "Remove key", "Key entfernen", "Usuń klucz", "Odstraň klávesu" });
            AddNewWord("labelTriggerName", new List<string> { "Триггер", "Trigger", "Trigger", "Wyzwalacze", "Trigger" });
            AddNewWord("labelTriggerCollision", new List<string> { "Коллизия", "Collision", "Kollision", "Kolizja", "Kolize" });
            AddNewWord("checkBoxDyn", new List<string> { "динамическая", "dynamic", "Dynamisch", "dynamiczna", "dynamické" });
            AddNewWord("checkBoxStat", new List<string> { "статическая", "static", "Statisch", "statyczna", "statické" });
            AddNewWord("radioButtonOverwrite", new List<string> { "перезаписать", "overwrite", "überschreiben", "nadpisz", "přepsat" });
            AddNewWord("labelTriggerInsert", new List<string> { "Вставить", "Insert key", "Taste einfügen", "Dodaj klucz", "Vložit klávesu" });
            AddNewWord("radioButtonAfter", new List<string> { "после", "after", "danach", "przed", "po" });
            AddNewWord("radioButtonBefore", new List<string> { "до", "before", "davor", "po", "před" });
            AddNewWord("labelTriggerTargets", new List<string> { "Цели (targets)", "Targets", "Ziele", "Cele", "Cíle" });
            AddNewWord("labelTriggersSources", new List<string> { "Источники (sources)", "Sources", "Quellen", "Źródła", "Zdroje" });
            AddNewWord("groupBoxWPFP", new List<string> { "Мировые точки", "World points", "Weltpunkte", "Punkty świata", "Body světa" });
            AddNewWord("labelNameWPMandatory", new List<string> { "Имя Waypoint (обязательно)", "Waypoint name (mandatory)", "Wegpunktname (verpflichtend)", "Nazwa waypointa (obowiązkowa)", "Jméno waypointu (povinné)" });
            AddNewWord("labelFreepointMandatory", new List<string> { "Имя Freepoint (обязательно)", "Freepoint name (mandatory)", "Freepoint Name (verpflichtend)", "Nazwa freepointa (obowiązkowa)", "Jméno freepointu (povinné)" });
            AddNewWord("checkBoxWayNet", new List<string> { "Сразу соединять в сеть", "Connect to waynet at once", "Einmalig dem Wegenetzwerk hinzufügen", "Połącz natychmiast z waynetem", "Připojit se k waynetu najednou" });
            AddNewWord("checkBoxWPAutoName", new List<string> { "Автогенерация имени", "Auto-generated name", "Automatischer Namengenerator", "Nazwa wygenerowana automatycznie", "Automaticky generovaný název" });
            AddNewWord("checkBoxFPGround", new List<string> { "Прижимать к земле", "Floor the freepoint", "Den Freepoint an den Boden haften", @"Połóż freepoint'a na podłodze", "Podlaha freepointu" });
            AddNewWord("checkBoxAutoNameFP", new List<string> { "Автогенерация имени", "Auto-generated name", "Automatischer Namengenerator", "Nazwa wygenerowana automatycznie", "Automaticky generovaný název" });
            AddNewWord("buttonWPCreate", new List<string> { "Создать Waypoint", "Create Waypoint", "Wegpunkt erstellen", "Utwórz Waypoint", "Vytvořit waypoint" });
            AddNewWord("buttonConnectWp", new List<string> { "Соединить WP", "Connect waypoints", "Wegpunkte verbinden", "Połącz Waypointy", "Spojit waypoint" });
            AddNewWord("buttonDisconnectWP", new List<string> { "Разъединить WP", "Disconnect waypoints", "Wegpunkte trennen", "Rozłącz Waypointy", "Odpojit waypoint" });
            AddNewWord("buttonFPCreate", new List<string> { "Создать Freepoint", "Create Freepoint", "Freepoint erstellen", "Utwórz Freepoint", "Vytvořit freepoint" });
            //NEW
            AddNewWord("labelCamSetSlerp", new List<string> { "Плавность поворота камеры", "Camera rotation smoothing", "Kameraroation glätten", "Wygładzenie rotacji kamery", "Vyhlazení otáčení kamery" });
            AddNewWord("keysResetDefault", new List<string> { "Сбросить по-умолчанию", "Reset default", "Einstellung zurückstellen", "Przywróć domyślne", "Obnovení výchozího nastavení" });
            AddNewWord("confirmText", new List<string> { "Вы уверены?", "Are you sure?", "Bist du dir sicher ?", "Jesteś pewny?", "Jsi si jistý?" });
            AddNewWord("MENU_TOP_MERGEMESH", new List<string> { "Объединить MESH...", "Merge MESH...", "MESH zusammenfügen...", "Połącz MESH...", "Sloučit MESH..." });
            AddNewWord("LIGHT_RAD_INC", new List<string> { "Увеличить радиус освещения", "Increase light radius", "Lichtradius erhöhen", "Zwiększ promień światła", "Zvětšit rozsah světla" });
            AddNewWord("LIGHT_RAD_DEC", new List<string> { "Уменьшить радиус освещения", "Decrease light radius", "Lichtradius verringern", "Zmniejsz promień światła", "Zmenšit rozsah světla" });
            AddNewWord("LIGHT_RAD_ZERO", new List<string> { "Сбросить радиус освещения", "Reset light radius to 0", "Lichtradius auf 0 setzen", "Zresetuj promień światła do wartości 0", "Resetování rozsahu světla na 0" });
            AddNewWord("checkBoxSelectMoveInsert", new List<string> { "Включать инструмент перемещение при вставке воба", "Select Moving tool after inserting a vob", "Bewegungswerkzeug auswählen, nachdem vob eingefügt worden ist", "Wybierz narzędzie przemieszczania przed dodaniem voba", "Výběr nástroje pohybu po vložení vobu" });
            AddNewWord("labelSpeedPreview", new List<string> { "Скорость вращения превью-модели", "Model preview rotation speed", "Rotationsgeschwindigkeit der Modelvorschau", "Prędkość rotacji podglądu", "Rychlost otáčení náhledu modelu" });
            AddNewWord("loadMeshTimeAll", new List<string> { "Общее время объединения всех мешей", "Total time of merging all the meshes", "Gesamtzeit um alle Meshes zu verschmelzen", @"Czałkowicy czas łączenia wszystkich mesh'y", "Celkový čas sloučení všech meshů" });
            AddNewWord("WORK_PATH_ERROR", new List<string> { "Вы пытаетесь загрузить файл, который не находится в папке _WORK/DATA/. Поместите файл в папку с игрой!", "You are trying to load a file which is not in _WORK/DATA/. Place this file inside the game folder!", "Du versuchst eine Datei zu laden, welche nicht im _WORK/DATA/ Ordner ist. Kopiere die Datei zuerst in den Spieleordner!", "Próbujesz wczytać plik, który nie znajduje się w _WORK/DATA/. Umieść go w folderze gry!", "Pokoušíš se načíst soubor, který se nenachází v adresáři _WORK/DATA/. Umísti tento soubor do složky hry!" });
            AddNewWord("buttonStopAllSounds", new List<string> { "Заглушить все звуки", "Turn off all sounds", "Alle Sounds abschalten", "Wyłącz wszystkie dźwięki", "Vypnout všechny zvuky" });
            //
            AddNewWord("vobs_found_amount", new List<string> { "Найдено", "Found", "Gefunden", "Klasy vobów", "Nalezeno" });
            AddNewWord("all_vobs_classes", new List<string> { "Все классы вобов", "Vob classes", "Vob Klassen", "Szukaj w klasach pochodnych", "Vob třídy" });
            AddNewWord("search_derived", new List<string> { "Искать в дочерних классах", "Search in derived classes", "In der abgeleiteten Klasse suchen", "Szukaj w klasach pochodnych", "Hledání v odvozených třídách" });
            AddNewWord("search_use_regex", new List<string> { "Использовать рег. выражение", "Use regular expression", "Reguläre expression nutzen", "Użyj standardowego wyrażenia", "Použití regulárního výrazu" });
            AddNewWord("BTN_RESET", new List<string> { "Сбросить", "Reset", "Zurücksetzen", "Reset", "Reset" });
            AddNewWord("NAME_ALREADY_EXISTS", new List<string> { "Такое имя уже существует!", "This name already exists!", "Diesen Namen gibt es bereits!", "Ta nazwa jest już zajęta!", "Tenhle název již existuje!" });
            AddNewWord("Label_Backup", new List<string> { "Старое значение", "Old value", "Alter Wert", "Stara wartość", "Stará hodnota" });
            AddNewWord("SET_ANY_FIELD_SEARCH", new List<string> { "Выберите хотя бы одно поле!", "Select one field at least!", "Du musst zumindestens ein Feld auswählen!", "Wybierz przynajmniej jedno pole!", "Vyber alespoň jedno pole!" });
            AddNewWord("VOB_SEARCH_START", new List<string> { "Поиск вобов начался...", "Looking for vobs...", "Suche nach Vobs...", "Rozglądanie się za vobami...", "Hledání vobů..." });
            //
            AddNewWord("BAD_REGEX", new List<string> { "Введено некорректное регулярное выражение!", "Wrong regular expression!", "Falscher Regex eingeführt!", "Błędne wyrażenie regularne!", "Špatný regulární výraz!" });
            AddNewWord("VOB_SEARCH_TYPE0", new List<string> { "Искать", "Search", "Suchen", "Szukaj", "Hledat" });
            AddNewWord("VOB_SEARCH_REPLACEZEN", new List<string> { "Заменено вобов на VobTree: ", "Vobs replaced with VobTree: ", "Vobs mit Vobbaum ersetzt: ", "Voby zastąpione drzewkiem vobów: ", "Voby nahrazeny VobTree: " });
            AddNewWord("VOB_SEARCH_REMOVEVOBS", new List<string> { "Удалено вобов: ", "Vobs removed: ", "Vobs entfernt: ", "Usunięto voby: ", "Voby ostraněny: " });
            AddNewWord("NO_REPLACE_VOBTREE", new List<string> { "VobTree не выбран!", "No VobTree selected!", "Kein Vobbaum ausgewählt!", "Nie wybrano drzewka vobów!", "Žádný VobTree není vybrán!" });
            AddNewWord("VOB_SEARCH_CONVERT", new List<string> { "Преобразовано вобов: ", "Vobs converted: ", " Vobs konvertiert: ", "Przekonwertowane voby: ", "Konvertované voby: " });
            AddNewWord("VOB_SEARCH_STOP", new List<string> { "Найдено вобов: ", "Vobs found: ", "Vobs gefunden: ", "Znalezione voby: ", "Nalezené voby: " });
            AddNewWord("VOB_SEARCH_TYPE1", new List<string> { "Конвертировать", "Convert", "Konvertieren", "Konwertuj", "Konvertovat" });
            AddNewWord("VOB_SEARCH_TYPE2", new List<string> { "Заменить на VobTree", "Replace with VobTree", "Mit Vobbaum tauschen", "Zamień na drzewko vobów", "Nahrazení pomocí VobTree" });
            AddNewWord("VOB_SEARCH_TYPE3", new List<string> { "Удалить", "Remove", "Entfernen", "Usuń", "Odstranit" });
            AddNewWord("VOB_SEARCH_CONVERT_RADIO0", new List<string> { "Старый", "Old", "Alt", "Stary", "Starý" });
            AddNewWord("VOB_SEARCH_CONVERT_RADIO1", new List<string> { "Новый", "New", "Neu", "Nowy", "Nový" });
            AddNewWord("WARNING_VDF_FILE_OPEN", new List<string> { "Внимание! Файл был загружен из VDF/MOD, а не из _WORK/DATA!", "Warning! The file was loaded from VDF/MOD, not from _WORK/DATA!", "Achtung! Die Dati wurde von einer VDF/MOD und nicht vom _WORK/DATA geladen!", "Uwaga! Plik został załadowany z paczki VDF/MOD, nie z _WORK/DATA.", "Pozor! Soubor byl načten z VDF/MOD, nikoli z _WORK/DATA!" });
            AddNewWord("VOB_SEARCH_TYPE_RENAME", new List<string> { "Переименовать", "Rename", "Umbenennen", "Zmień nazwę", "Přejmenovat" });
            AddNewWord("VOB_SEARCH_RENAME_VOBS", new List<string> { "Переименовано вобов: ", "Vobs renamed: ", "Vobs umbeanannt: ", "Vobom zmieniono nazwę: ", "Přejmenované voby: " });
            AddNewWord("labelRenameVob", new List<string> { "Новое имя", "New name", "Neuer Name", "Nowa nazwa", "Nové jméno" });
            AddNewWord("checkBoxAutoNumerate", new List<string> { "Авто-нумерация имен", "Auto numeration of names", "Automatische Nummerierung der Namen", "Automatycznie numeruj nazwy", "Automatické číslování jmen" });
            AddNewWord("MENU_TOP_VIEW_FREEZETIME", new List<string> { "Заморозить время", "Freeze time", "Ingamezeit einfrieren", "Zatrzymanie czasu", "Zamrznutí času" });
            AddNewWord("MENU_TOP_VIEW_POLYGON", new List<string> { "Выделение полигона", "Polygon select", "Polygonauswahl", "Wybór polygonu", "Výběr polygonu" });
            AddNewWord("MENU_TOP_VIEW_RENDERMODE", new List<string> { "Режим рендера", "Render mode", "Renderermodus", "Tryb renderowania", "Režim renderování" });
            AddNewWord("CHECK_BADPLUGINS_MSG", new List<string> { "У вас есть плагины, которые могут помешать работе Spacer.net!", "You have plugins which may not work with Spacer.net!", "Möglicherweise sind Plugins installiert, welche nicht mit Spacer.net kompatibel sind!", "Masz pluginy, które mogą nie działać poprawnie z Spacer.net", "Máte pluginy, které nemusí fungovat se Spacer.net!" });
            AddNewWord("WIN_GRASS_TITLE", new List<string> { "Сеятель объектов", "Objects sower", "Objektgenerator", "Generator obiektów", "Generátor objektů" });
            AddNewWord("WIN_GRASS_VOBMODEL", new List<string> { "Название модели воба:", "Vob's model:", "Vob Modell:", "Model voba:", "Model vobů:" });
            AddNewWord("WIN_GRASS_VERTOFFSET", new List<string> { "Смещение воба по вертикали: ", "Vob's vertical offset: ", "Vertikaler Versatz vom Vob: ", "Przesunięcie pionowe voba:", "Vertikální posun vobu: " });
            AddNewWord("WIN_GRASS_MINRADIUS", new List<string> { "Мин. расстояние между вобами: ", "Minimal distance between vobs: ", "Minimale Distanz zwischen Vobs: ", "Minimalny dystans pomiędzy vobami: ", "Minimální vzdálenost mezi voby: " });
            AddNewWord("VOB_SEARCH_TYPE_DYNAMIC", new List<string> { "Сменить динамич. коллизию", "Toggle dynamic collision", "Dynamische Kollision umschalten", "Przełącz dynamiczną kolizję", "Přepínání dynamických kolizí" });
            AddNewWord("VOB_SEARCH_DYNCOLL_VOBS", new List<string> { "Проставлено коллизий: ", "Collisions set: ", "Kollision eingestellt: ", "Ustawione kolizje: ", "Nastavení kolizí: " });
            AddNewWord("MENU_TOP_SAVEZENUNC", new List<string> { "Сохранить Vobs", "Save Vobs", "Vobs Speichern", "Zapisz Voby", "Uložit voby" });
            AddNewWord("WIN_GRASS_COPYNAME", new List<string> { "При выделении модели в поиске копировать ее сюда", "Copy model name from another window", "Modellnamen aus einem anderen Fenster kopieren", "Skopiuj nazwę modelu z innego okna", "Kopírování jména modelu z jiného okna" });
            AddNewWord("WIN_GRASS_REMOVE", new List<string> { "Режим удаления вобов", "Removing vob mod", "Entfernen der Vob modifikation", "Usuwanie vobów z moda", "Odstranění vobů z modu" });
            AddNewWord("WIN_GRASS_ISITEM", new List<string> { "Воб - это oCItem", "Inserted vob is oCItem", "Vob als oCItem einfügen", "Dodany vob to oCItem", "Vložený vob je oCItem" });
            AddNewWord("WIN_GRASS_PROTECT", new List<string> { "Защита от зажатия левой кнопки мыши", "Protect from left mouse button pushing", "Schutz vor Drücken der linken Maustaste", "Ochrona przed naciśnięciem lewego przycisku myszki", "Ochrana před stisknutím levého tlačítka myši" });
            AddNewWord("WIN_GRASS_DYNCOLL", new List<string> { "Ставить вобу динамическую коллизию", "Set dynamic collision for vob", "Anschalten der Dynamischen Kollision", "Ustaw dynamiczną kolizję dla voba", "Nastavení dynamické kolize pro vob" });
            AddNewWord("WIN_GRASS_RANDANGLE", new List<string> { "Поворачивать воб на случайный угол вокруг вертикальной оси", "Rotate vob on random angle about vertical axis", "Drehen des Vobs um einen zufälligen Winkel über der vertikalen Achse", "Obróć vob o losowy kąt powyżej osi pionowej", "Otáčení vobu o náhodný úhel kolem svislé osy" });
            AddNewWord("WIN_GRASS_NORMALPOLYGON", new List<string> { "Ставить воб перпендикулярно полигону", "Set vob perpendicular to the polygon", "Vob rechtwinklig zum Polygon setzen", "Ustaw vob prostopadle do poligona", "Nastavení vobu kolmo k polygonu" });
            AddNewWord("checkBoxMiscAutoCompile", new List<string> { "Автокомпиляция мира и света после объединения меша с вобами", "Autocompile world and light after merging mesh with vobs", "Autokompilieren von Welt und Licht nach dem Zusammenführen des Mesh mit Vobs", "Autokompilacja świata i światła po połączeniu mesha z vobami", "Automatická kompilace světa a světla po sloučení meshů s voby" });
            AddNewWord("checkBoxMiscAutoCompileUncZen", new List<string> { "Автокомпиляция мира и света при загрузке некомпилированного ZEN", "Autocompile world and light after loading uncompiled ZEN", "Autokompilieren von Welt und Licht nach dem Laden von nicht kompilierter ZEN", "Autokompilacja świata i światła po załadowaniu nieskompilowanego ZENA", "Automatická kompilace světa a světla po načtení nezkompilovaného ZENu" });
            AddNewWord("checkBoxAutoRemoveAllVisuals", new List<string> { "Автоматически очищать visual для всех zCVobLevelCompo при сохранении ZEN", "Auto cleaning visual for all zCVobLevelCompo before saving ZEN", "Automatische visuelle Reinigung für alle zCVobLevelCompo vor dem Speichern ZEN", "Automatyczne usuwanie visuali dla wszystkich zCVobLevelCompo przed zapisaniem ZENA", "Automatické vizuální čištění pro všechny zCVobLevelCompo před uložením ZENu" });
            AddNewWord("checkBoxMiscRemoveAllLevelCompos", new List<string> { "Удалить все zCVobLevelCompo при загрузке ZEN", "Remove all zCVobLevelCompo while loading ZEN", "Entfernen Sie alle zCVobLevelCompo beim Laden von ZEN", "Usuń wszystkie zCVobLevelCompo podczas wczytywania ZEN", "Odstranění všech zCVobLevelCompo při načítání ZENu" });
            AddNewWord("checkBoxShowPolysSort", new List<string> { "При сохранении больших локаций спрашивать о сортировке полигонов (более 200 тыс. полигонов)", "Ask for sorting polygons while saving big locations (more than 200k polygons)", "Frage nach dem Sortieren von Polygonen beim Speichern großer Orte (mehr als 200k Polygone)", "Sortowanie wielokątów podczas zapisywania dużych lokacji (ponad 200k wielokątów)", "Žádost o třídění polygonů při ukládání velkých lokací (více než 200k polygonů)" });
            AddNewWord("MENU_TOP_VIEW_GRASS", new List<string> { "Сеятель объектов", "Objects sower", "Objektgenerator", "Generator obiektów", "Generátor objektů" });
            AddNewWord("MENU_TOP_VIEW_ALTCONTROLLER", new List<string> { "Альтернативное управление", "Alternative controller", "Alternativer Controller", "Alternatywna kamera", "Alternativní ovladač" });
            AddNewWord("CANT_APPLY_PARENT_VOB", new List<string> { "Данный тип воба не может быть родителем!", "This type of vob can't be a parent!", "Diese Art von Vob kann keine Übergeordung sein!", "Ten typ voba nie może być zapisany jako rodzic!", "Tenhle typ vobu nemůže být rodičem!" });
            AddNewWord("saveMeshTime", new List<string> { "Сохранение MESH выполнено за", "Saving MESH time...", "Speichern der MESH dauerte", @"Czas zapisywania MESH'a...", "Čas ukládání MESHe..." });
            AddNewWord("MENU_TOP_SAVEMESH", new List<string> { "Сохранить MESH", "Save MESH", "MESH Speichern", "Zapisz MESH", "Uložit MESH" });
            AddNewWord("WIN_MSG_CONFIRM", new List<string> { "Подтвердите действие", "Confirm the action", "Bestätige die Aktion", "Potwierdź akcję", "Potvrdit akci" });
            AddNewWord("WIN_MSG_CONFIRM_PLACENEARCAM", new List<string> { "Вставить Vobtree перед камерой?", "Do insert vobtree near the camera?", "Vobtree in der Nähe der Kamera einfügen?", "Czy wstawiasz vobtree w pobliżu kamery?", "Vložit vobtree v blízkosti kamery?" });
            AddNewWord("CONTEXTMENU_TREE_ADD_PARENT", new List<string> { "Сделать глобальным родителем", "Make this vob as a global parent", "Dieses Vob als globale übergeordnet einrichten", "Stwórz ten vob jako globalnego rodzica dla wszystkich nowych vobów", "Vytvořit tento vob jako globálního rodiče" });
            AddNewWord("CONTEXTMENU_TREE_REMOVE_PARENT", new List<string> { "Очистить глобального родителя", "Remove the global parent", "Globale Überordnung entfernen", "Usuń globalnego rodzica", "Odstranit globálního rodiče" });
            AddNewWord("CONTEXTMENU_TREE_ADD_VOB", new List<string> { "Добавить воб в быстрый доступ", "Add vob into Fast access list", "Vob in die Schnellzugriffsliste aufnehmen", "Dodaj vob do listy szybkiego dostępu", "Přidání vobu do seznamu rychlého přístupu" });
            AddNewWord("QUICKVOBS_PARENT", new List<string> { "Глобальный воб-родитель", "Global parent vob", "Globales Überordetes Vob", "Globalny rodzic voba", "Globální rodičovský vob" });
            AddNewWord("QUICKVOBS_ACCESS", new List<string> { "Быстрый доступ", "Fast access", "Schneller Zugriff", "Szybki dostęp", "Rychlý přístup" });
            AddNewWord("TAB_PAGE_OBJECTS", new List<string> { "Объекты", "Objects", "Objekte", "Obiekty", "Objekty" });
            AddNewWord("CONTEXTMENU_FAST_REMOVE_VOB", new List<string> { " Удалить воб из быстрого доступа", "Remove the vob from fast access", "Vob von der Schnellzugriffsliste löschen", "Usuń vob z szybkiego dostępu", "Odstranění vobu z rychlého přístupu" });
            AddNewWord("QUICKVOBS_CANTBE_PARENT", new List<string> { "Данный воб не может быть родителем!", "Current vob can't be a parent!", "Aktuelles von kann nicht Übergeordnet sein!", "Obecny vob nie może być rodzicem!", "Současný vob nemůže být rodičem!" });
            AddNewWord("PROP_BUTTON_COLOR", new List<string> { "Цвет", "Color", "Farbe", "Kolor", "Barva" });
            AddNewWord("labelItemLocatorRadius", new List<string> { "Радиус показа вещей: ", "Items show radius: ", "Item Sichtweite", "Pokaż promień: ", "Poloměr zobrazení předmětů: " });
            AddNewWord("groupBoxItemsLocator", new List<string> { "Локатор предметов: ", "Items locator: ", "Item Locator: ", "Lokalizator przedmiotów", "Lokalizátor předmětů: " });
            AddNewWord("checkBoxLocatorEnabled", new List<string> { "Включить", "Enabled", "Aktiviert", "Włączony", "Zapnuto" });
            AddNewWord("checkBoxLocatorOnlySusp", new List<string> { "Только \"плохие\" oCItem", "Only 'bad' oCItem", "Nur 'schlechte' oCItem", "Tylko 'zły' oCItem", "Pouze 'špatný' oCItem" });
            AddNewWord("MENU_TOP_WIN_POS", new List<string> { "Положение окон", "Position of windows", "Position der Fenster", "Pozycja okien", "Pozice oken" });
            AddNewWord("MENU_TOP_WIN_POS_RESET", new List<string> { "Сбросить положение окон", "Reset windows' position", "Fenster Positionen zurücksetzen", "Zresetuj pozycje okien", "Resetování pozice oken" });
            AddNewWord("MENU_TOP_WIN_POS_PRESET_1", new List<string> { "Использовать пресет #1 (FullHD)", "Use windows presets #1 (FullHD)", "Fenstervoreinstellungen #1 (FullHD) verwenden", "Użyj ustawień dla okien #1 (FullHD)", "Použití nastavení oken #1 (FullHD)" });
            AddNewWord("MENU_TOP_WIN_POS_PRESET_2", new List<string> { "Использовать пресет #2 (QuadHD)", "Use windows presets #2 (QuadHD)", "Fenstervoreinstellungen #2 (QuadHD) verwenden", "Użyj ustawień dla okien #2 (QuadHD)", "Použití nastavení oken #2 (QuadHD)" });
            AddNewWord("checkBoxShutSounds", new List<string> { "Глушить звуки при загрузке", "Shut sounds after world loaded", "Sounds nach Welt laden Stummen", "Wyłącz dźwięki po załadowaniu świata", "Vypnutí zvuků po načtení světa" });
            AddNewWord("checkBoxConstSound", new List<string> { "Постоянно глушить звуки", "Always shut all sounds", "Immer alle Sounds stummen", "Zawsze wyłączaj wszystkie dźwięki", "Vždy vypnout všechny zvuky" });
            AddNewWord("OnlyOneVobCanBe", new List<string> { "Воб такого типа может быть на карте ТОЛЬКО ОДИН!", "Only ONE vob like this can be on the map!", "Nur EIN Vob wie dieses kann auf der Karte sein!", "Tylko jeden vob takiego typu może znajdować się na mapie!", "Na mapě může být pouze JEDEN takový vob!" });
            AddNewWord("GAME_MODE", new List<string> { "Играть за героя", "Play the hero", "Spiele den Helden", "Zagraj bohaterem", "Hrát za hrdinu" });
            AddNewWord("ZEN_BAD_NAME", new List<string> { "В имени ZEN не может содержаться '.3DS' ! Переименуйте файл!", "ZEN's name can't contain '.3DS' ! Rename the file.", "Der Name der ZEN darf nicht '.3DS' enthalten! Benenne die Datei um.", "Nazwa ZEN nie może zawierać '.3DS' ! Zmień nazwę pliku.", "Jméno ZENu nemůže obsahovat '.3DS' ! Přejmenujte soubor." });
            AddNewWord("CONTEXTMENU_TREE_RESTORE_POS", new List<string> { "Восстановить позицию воба", "Restore vob's position", "Die Position des Vobs wiederherstellen", "Przywróć pozycję voba", "Obnovit pozici vobu" });
            AddNewWord("CANT_COPY_INITSELF", new List<string> { "Нельзя скопировать и вставить глобального родителя в самого себя!", "Can't copy and insert global parent vob into itself!", "Kann keine globale übergeordnete Vob-Datei in sich selbst kopieren und einfügen!", "Nie można skopiować i dodać globalnego rodzica voba do siebie!", "Nelze zkopírovat a vložit globální rodičovský vob do sebe!" });
            AddNewWord("checkBoxSetNearestVobCam", new List<string> { "Устанавливать камеру на воб с именем VOB_SPACER_CAMERA_START или zCVobStartpoint после загрузки ZEN", "Set the camera near the vob with name VOB_SPACER_CAMERA_START or zCVobStartpoint after loading ZEN", "Setze die Kamera in der Nähe des Vobs mit dem Namen VOB_SPACER_CAMERA_START oder zCVobStartpoint nach dem Laden der ZEN", "Ustaw kamerę w pobliżu voba z nazwą VOB_SPACER_CAMERA_START lub zCVobStartpoint po załadowaniu ZENA", "Nastavení kamery v blízkosti vobu s názvem VOB_SPACER_CAMERA_START nebo zCVobStartpoint po načtení ZENu" });
            AddNewWord("tabControlProps_3", new List<string> { "Настройки", "Settings", "Einstellungen", "Ustawienia", "Nastavení" });
            AddNewWord("checkBoxBoldFontProps", new List<string> { "Выделять основные поля жирным шрифтом", "Use bold font for main fields", "Fettschrift für Hauptfelder verwenden", "Użyj pogrubionej czcionki dla głównych pól", "Použití tučného písma pro hlavní pole" });
            AddNewWord("checkBoxFontUnderstroke", new List<string> { "Выделять основные поля подчеркнутым шрифтом", "Use understroke font for main fields", "Unterstrichene Schriftart für Hauptfelder verwenden", "Użyj czcionki z podkreśleniem dla pól głównych", "Použití podtrženého písma pro hlavní pole" });
            AddNewWord("buttonSelectFontProps", new List<string> { "Выбрать шрифт для свойств", "Select font for properties", "Schriftart für Eigenschaften wählen", "Wybierz czcionkę dla właściwości", "Výběr písma pro vlastnosti" });
            AddNewWord("buttonResetFontDefault", new List<string> { "Сбросить шрифт по умолчанию", "Reset font by default", "Schriftart standardmäßig zurücksetzen", "Przywróć domyślną czcionkę", "Obnovení výchozího písma" });
            AddNewWord("labelChangeFontStyleText", new List<string> { "* Для применения выберите объект снова", "* For applying reselect the object", "* Zum Anwenden das Objekt erneut auswählen", "* Aby zastosować ponownie wybierz obiekt", "* Pro použití znovu vyberte objekt" });
            AddNewWord("MENU_TOP_VIEW_MULTI", new List<string> { "Режим множественного выделения", "Multi selection mode", "Multi Selektions Modus", "Tryb wielokrotnego wyboru", "Režim multifunkční volby" });
            AddNewWord("TAB_PAGE_MATERIALS", new List<string> { "Материалы", "Materials", "Materialien", "Materiały", "Materiály" });
            AddNewWord("NoVisualForSuchVob", new List<string> { "Воб данного типа не может иметь визуал!", "This type of a vob can't have any visual!", "Dieser Typ Von kann kein Visual haben!", "Ten typ voba nie może mieć visuala!", "Tento typ vobu nemůže mít žádný vizuál!" });
            AddNewWord("MENU_TOP_SPECIAL_FUNCS", new List<string> { "Специальные функции", "Special functions", "Spezial Funktionen", "Funkcje specjalne", "Speciální funkce" });
            AddNewWord("MENU_TOP_CREATE_VOB_VISUALS_LIST", new List<string> { "Сформировать список визуалов локации", "Create a list of files which are used in the location", "Erstelle eine Liste der Dateien, die in diesem Bereich verwendet werden", "Stwórz lisę plików, któresą używane w lokacji", "Vytvoření seznamu souborů, které se používají v této lokaci" });
            AddNewWord("labelFindVisualArchive", new List<string> { "Искать только в архиве (VDF)", "Search only in selected (VDF)", "Suche nur in ausgewählter (VDF)", "Szukaj tylko w wybranych (VDF)", "Hledat pouze ve vybraných (VDF)" });
            AddNewWord("checkBoxLocatorByName", new List<string> { "Искать по имени:", "Search by name:", "Suche nach Namen:", "Szukaj według nazwy:", "Vyhledávání podle jména:" });
            AddNewWord("checkBoxSearchHasChildren", new List<string> { "У воба есть дети", "Vob has children", "Vob hat untergeordnete", "Vob ma dzieci", "Vob má děti" });
            AddNewWord("CONTEXTMENU_TREE_REPLACE_FROM_PARENT", new List<string> { "Переместить все вобы из родителя", "Move all vobs from the parent", "Verschieben aller Vobs aus dem übergeordneten", "Przenieś wszystkie voby od rodzica", "Přesunout všechny voby od rodiče" });
            AddNewWord("checkBoxCamShowPortalsInfo", new List<string> { "Показывать информацию о порталах", "Show portals info", "Zeige Portal Infos", "Pokaż info o portalach", "Zobrazit informace o portálech" });
            AddNewWord("CHECK_SORTING_POLYS", new List<string> { "Сортировать полигоны локации?\nСортировка полигонов в локации сильно замедляет сохранение больших локаций (по времени), однако, это необходимо делать для финальной версии локации, для промежуточных версий локации это необязательно и экономит время.", "Should we sort polygons of the location?\nSorting polygons is necessary for the final version of the location, but it requires much time for saving in big locations, for work version of locations you don't need to sort them every time while saving.", "Sollen die Polygone des Ortes sortiert werden? Das Sortieren der Polygone ist für die endgültige Version des Ortes notwendig, erfordert aber viel Zeit beim Speichern von großen Orten, für die Arbeitsversion von Orten müssen sie nicht jedes Mal beim Speichern sortiert werden.", "Czy chcesz sortować wielokąty lokacji?\nSortowanie wielokątów jest konieczne dla ostatniej wersji lokacji, ale wymaga dużo czasu przy zapisie w dużych lokacjach, dla wersji roboczych lokacji nie trzeba ich sortować za każdym razem przy zapisie.", "Je třeba třídit polygony lokace?Třídění polygonů je nutné pro finální verzi lokace, ale při ukládání velkých lokací to vyžaduje hodně času, pro pracovní verzi lokací není třeba je třídit pokaždé při ukládání." });
            //0.27
            AddNewWord("checkBoxShowVobTraceFloor", new List<string> { "Подсвечивать положение воба на поверхности", "Brighten selected vob position on the floor", "Ausgewählte Vob-Position auf dem Boden aufhellen", "Rozjaśnij pozycję wybranego voba na podłodze", "Zesvětlení vybrané pozice vobu na podlaze" });
            AddNewWord("WIN_MSG_CONFIRM_REMOVEVOB", new List<string> { "Удалить воб?", "Remove the vob?", "Vob löschen?", "Czy chcesz usunąć vob?", "Odstranit vob?" });
            AddNewWord("WIN_BTN_CONFIRM", new List<string> { "Подтвердить", "Confirm", "Bestätigen", "Potwierdź", "Potvrdit" });
            AddNewWord("WIN_LABEL_MACROS_RENAME", new List<string> { "Введите имя:", "Enter the name:", "Gebe den Namen ein:", "Ustal nazwę:", "Zadat jméno:" });
            AddNewWord("WIN_LABEL_MACROS_NEW", new List<string> { "Введите имя нового макроса:", "Enter the name of a new macros:", "Gebe den Namen eines neuen Makros ein:", "Ustal nazwę dla nowego macrosa:", "Zadejte název nového makra:" });
            AddNewWord("WIN_MACROSES", new List<string> { "Макросы", "Macros", "Makros", "Macros", "Makra" });
            AddNewWord("buttonCreateNewMacros", new List<string> { "Создать новый макрос", "Create a new macros", "Neues Makro erstellen", "Utwórz nowy macros", "Vytvořit nové makra" });
            AddNewWord("buttonMacrosRenameCurrent", new List<string> { "Переименовать", "Rename", "Umbenennen", "Zmień nazwę", "Přejmenovat" });
            AddNewWord("buttonMacrosRemoveCurrent", new List<string> { "Удалить", "Delete", "Löschen", "Usuń", "Odstranit" });
            AddNewWord("buttonMacrosReloadFromFile", new List<string> { "Перезагрузить всё из файла", "Reload all from the file", "Alles aus der Datei neu laden", "Załaduj ponownie wszystko z pliku", "Znovu načíst vše ze souboru" });
            AddNewWord("buttonMacrosSaveAll", new List<string> { "Сохранить всё в файл", "Save all to the file", "Alles in die Datei speichern", "Zapisz wszystko do pliku", "Uložit vše do souboru" });
            AddNewWord("buttonMacrosRun", new List<string> { "Выполнить", "Run", "Ausführen", "Uruchom", "Spustit" });
            AddNewWord("buttonMacrosParse", new List<string> { "Парсить и сохранить текущий текст", "Parse and save current text", "Parse und speichere aktuellen Text", "Parsuj i zapisz aktualny tekst", "Parsování a ukládání aktuálního textu" });
            AddNewWord("groupBoxMacrosButtons", new List<string> { "Действия", "Actions", "Aktionen", "Akcje", "Akce" });
            AddNewWord("WIN_CAMERA_START", new List<string> { "Старт", "Start", "Start", "Start", "Start" });
            AddNewWord("WIN_CAMERA_STOP", new List<string> { "Стоп", "Stop", "Stop", "Stop", "Stop" });
            AddNewWord("CANT_APPLY_PARENT_CAMERA", new List<string> { "Нельзя вставить новую камеру в другую камеру!", "Can't set current camera as a parent for a new camera!", "Ich kann die aktuelle Kamera nicht als Überordnung für eine neue Kamera festlegen!", "Nie można ustawić bieżącej kamery jako rodzica dla nowej kamery!", "Nelze nastavit stávající kameru jako rodičovskou kameru pro novou kameru!" });
            AddNewWord("CANT_APPLY_CAMERA_NEWKEY", new List<string> { "Свойство камеры стоит FOR_OBJECT, а воба нет!", "Camera has FOR_OBJECT value, but no vob found", "Kamera hat FOR_OBJECT-Wert, aber kein Vob gefunden", "Kamera a wartość FOR_OBJECT, ale nie znaleziono voba", "Kamera má hodnotu FOR_OBJECT, ale nebyl nalezen žádný vob" });
            AddNewWord("CAMERA_ITEMS_FORCE_RENAME", new List<string> { "Ключам камеры были проставлены имена", "Camera's keys got its names", "Die Keys der Kamera haben ihre Namen", "Klatki kamery mają swoje nazwy", "Klávesy kamery dostaly svá jména" });
            AddNewWord("FORM_ENTER_BAD_VALUE_INT", new List<string> { "Введено недопустимое значение! Данное поле целочисленное!", "Invalid value entered. Only integer is allowed in this field!", "Falscher Wert eingegeben. Nur Integer sind erlaubt!", "Wprowadzono nieprawidłową wartość. W tym polu dozwolone są tylko liczby całkowite!", "Zadána neplatná hodnota. V tomto poli je povoleno pouze celé číslo!" });
            AddNewWord("FORM_ENTER_BAD_STRING_INPUT", new List<string> { "Введены недопустимые символы!", "Invalid symbols found in the input", "Falsche Symbole in der EIngabe gefunden", "W danych wejściowych znaleziono nieprawidłowe symbole", "Na vstupu byly nalezeny neplatné symboly" });
            AddNewWord("checkBoxOnlyLatinInInput", new List<string> { "Допускать ввод только латинских символов в поля свойств", "Allow only Latin symbols as input values", "Es sind nur Lateinische Buchstaben als Wert erlaubt", "Zezwalaj tylko na symbole łacińskie jako wartości wejściowe", "Povolit jako vstupní hodnoty pouze latinské symboly" });
            AddNewWord("MSG_VOB_CANT_BE_COPIED", new List<string> { "Данный тип воба нельзя скопировать!", "This vob type can't be copied!", "Dieser Vob Typ kann nicht kopiert werden!", "Ten typ voba nie może zostać skopiowany!", "Tento typ vob unelze kopírovat!" });
            AddNewWord("groupBoxCameraNew", new List<string> { "Новая камера", "New camera", "Neue Kamera", "Nowa kamera", "Nová kamera" });
            AddNewWord("FORM_COMMON_NAME", new List<string> { "Имя", "Name", "Name", "Nazwa", "Jméno" });
            AddNewWord("FORM_COMMON_CREATE", new List<string> { "Создать", "Create", "Erstellen", "Utwórz", "Vytvořit" });
            AddNewWord("groupBoxCamKeys", new List<string> { "Ключи", "Keyframes", "Keyframes", " Klatki kluczowe", "Klávesy" });
            AddNewWord("buttonCamSpline", new List<string> { "Добавить позицию", "Add a position", "Position hinzufügen", "Dodaj pozycję", "Přidat pozici" });
            AddNewWord("buttonCamTargetSpline", new List<string> { "Добавить цель", "Add a target", "Ziel hinzufügen", "Dodaj cel", "Přidat cíl" });
            AddNewWord("groupBoxCamSettings", new List<string> { "Настройки", "Settings", "Einstellungen", "Ustawienia", "Nastavení" });
            AddNewWord("labelCamTimeSec", new List<string> { "Время полета:", "Fly time:", "Flug Zeit", "Czas lotu:", "Čas letu:" });
            AddNewWord("checkBoxCameraHide", new List<string> { "Скрывать вобы в полете", "Hide vobs while camera active", "Vobs bei aktiver Kamera ausblenden", "Ukryj voby, gdy kamera jest aktywna", "Skrytí vobů při aktivní kameře" });
            AddNewWord("labelCamGotoKey", new List<string> { "Перейти к ключу: ", "Go to key", "Zum Key gehen", "Przejdź do klatki", "Přejít na klávesu" });
            AddNewWord("groupBoxLightPresetProperties", new List<string> { "Свойства пресета", "Preset properties", "Preset Eigenschaften", "Właściwości presetu", "Vlastnosti předvolby" });
            AddNewWord("labelLightPresetName", new List<string> { "Имя пресета (обязательно)", "Preset name (mandatory)", "Preset Name (notwendig)", "Nazwa presetu (obowiązkowa)", "Název předvolby (povinné)" });
            AddNewWord("buttonNewLightPreset", new List<string> { "Новый пресет", "New preset", "Neues preset", "Nowy preset", "Nová předvolba" });
            AddNewWord("buttonDeleteSelectedLightPreset", new List<string> { "Удалить выбранный пресет", "Delete selected preset", "Ausgewähltes Preset löschen", "Usuń wybrany preset", "Odstranění vybrané předvolby" });
            AddNewWord("buttonSaveLightPresets", new List<string> { "Сохранить пресеты", "Save presets", "Presets speichern", "Zapisz presety", "Uložit předvolby" });
            AddNewWord("buttonUpdateLightPresetOnLightVobs", new List<string> { "Обновить пресет на все lightvobs", "Update preset on lightvobs", "Preset auf LightVob erneuern", "Zaktualizuj preset na lightvobach", "Aktualizace předvolby na lightvobech" });
            AddNewWord("buttonUpdateLightPresetFromVob", new List<string> { "Обновить пресет из lightvob <<", "Update preset from lightvob <<", "Preset von LightVob erneuern <<", "Zaktualizuj preset z lightvoba <<", "Aktualizace předvolby z lightvobu <<" });
            AddNewWord("buttonUsePresetOnLightVob", new List<string> { "Применить пресет на lightvob >>", "Use preset on lightvob >>", "Preset auf LightVob anwenden >>", "Użyj presetu na lightvobie >>", "Použití předvolby na lightvobu >>" });
            AddNewWord("buttonCreateLightVob", new List<string> { "Создать LightVob", "Create LightVob", "LightVob erstellen", "Utwórz LightVob", "Vytvořit LightVob" });
            AddNewWord("groupBoxLightSelected_Preset", new List<string> { "Выбранный пресет", "Selected preset", "Ausgewähltes Preset", "Wybrany preset", "Vybraná předvolba" });
            AddNewWord("groupBoxLightSelected_LightVob", new List<string> { "Выбранный lightvob", "Selected lightvob", "Ausgewähltes LightVob", "Wybrany lightvob", "Vybraný lightvob" });
            AddNewWord("labelLightVobName", new List<string> { "Имя воба:", "Vob name:", "Vob-Name:", "Nazwa Voba:", "Jméno Vobu" });
            AddNewWord("groupBoxLightType", new List<string> { "Тип света", "Light type", "Licht-Typ", "Rodzaj światła", "Typ světla" });
            AddNewWord("checkBoxShowLightVobRadius", new List<string> { "Показать радиус", "Show radius", "Radius anzeigen", "Pokaż zasięg", "Zobrazit rozsah" });
            AddNewWord("checkBoxLightVobInstantCompile", new List<string> { "Мгновенная компиляция", "Instant compile", "Sofortiges Kompilieren", "Natychmiastowa kompilacja", "Okamžitá kompilace" });
            AddNewWord("radioButtonLightVobStatic", new List<string> { "Статический", "Static", "Statisch", "Statyczne", "Statické" });
            AddNewWord("radioButtonLightVobDynamic", new List<string> { "Динамичный", "Dynamic", "Dynamisch", "Dynamiczne", "Dynamické" });
            AddNewWord("groupBoxLightColorProperties", new List<string> { "Свойства цвета", "Color properties", "Farbeigenschaften", "Właściwości koloru", "Vlastnosti barvy" });
            AddNewWord("groupBoxLightRangeProperties", new List<string> { "Свойства диапазона", "Range properties", "Reichweiteneigenschaften", "Właściwości zasięgu", "Vlastnosti rozsahu" });
            AddNewWord("FORM_COMMON_DELETE", new List<string> { "Удалить", "Delete", "Löschen", "Usuń", "Smazat" });
            AddNewWord("FORM_CAMERA_INSERT_KEY_HERE", new List<string> { "Вставить новый ключ сюда", "Insert a new key here", "", "Wstaw nową klatkę", "Vložit novou klávesu zde" });
            AddNewWord("TOOL_BBOX_CHANGE", new List<string> { "Режим 'Изменение Bbox'", "Bbox change mode", "Bbox Änderungs-Modus", "Tryb zmiany BBoxa", "Režim změny Bboxu" });
            AddNewWord("TOOL_BBOX_CHANGE_LEAVE", new List<string> { "Выход из режима 'Изменение Bbox'", "Exit from bbox editing", "Bbox Änderungs-Modus verlassen", "Opuszczenie trybu zmiany Bboxa", "Ukončení editace Bboxu" });
            AddNewWord("TOOL_BBOX_MAXS", new List<string> { "Изменение bbox maxs", "Changing bbox maxs", "Bbox max ändern", "Zmiana maks. bbox", "Změna max. hodnot Bboxu" });
            AddNewWord("TOOL_BBOX_MINS", new List<string> { "Изменение bbox mins", "Changing bbox mins", "Bbox min ändern", "Zmiana min. bbox", "Změna min. hodnot Bboxu" });
            AddNewWord("TOOL_BBOX_CANT_WORK", new List<string> { "У текущего типа воба нельзя менять bbox!", "Can't change bbox of this vob type", "Kann Bbox dieses Vob Typens nicht ändern", "Nie można zmienić bboxa w tym typie voba", "Nelze změnit Bbox tohoto typu vobu" });
            AddNewWord("FORM_HINT_INSERT_WPFP", new List<string> { "*Кнопка {0}, чтобы вставить новый воб", "*Press {0} button to insert a new vob", "*Drücke {0} zum Hinzufügen eines neuen Vobs", "*Wciśnij klawisz {0} aby dodać nowy vob", "*Stisknutím tlačítka {0} vložíte nový vob" });
            AddNewWord("checkBoxInfoUseZSpy", new List<string> { "Отладочные сообщения zSpy", "zSpy debug messages", "zSpy Debug Nachrichten", "Komunikaty debugowania zSpy", "Ladicí zprávy zSpy" });
            AddNewWord("MSG_COMMON_SEARCH", new List<string> { "Поиск", "Search", "Suchen", "Szukaj", "Hledat" });
            AddNewWord("MSG_COMMON_COMMON", new List<string> { "Общее", "Common", "Allgemein", "Ogólne", "Běžné" });
            AddNewWord("MSG_COMMON_MATSEACH", new List<string> { "Поиск материала:", "Material search:", "Material Suche:", "Szukaj materiał:", "Hledání materiálu:" });
            AddNewWord("MSG_MATFILTER_NEW_NAME", new List<string> { "Имя фильтра:", "Filter name:", "Filter Name:", "Nazwa filtra:", "Jméno filtru:" });
            AddNewWord("MSG_MATFILTER_RENAME", new List<string> { "Переименование фильтра:", "Rename Filter:", "Filter umbenennen:", "Zmień nazwę filtru:", "Přejmenování filtru:" });
            AddNewWord("checkBoxMatchNames", new List<string> { "Совпадение имен", "Match vobs names", "Namen von Vobs abgleichen", "Dopasuj nazwy vobów", "Shoda jmen vobů" });
            AddNewWord("checkBoxSearchItem", new List<string> { "Искать oCItem в oCMobContainer", "Search oCItem in oCMobContainer", "Suche oCItem in oCMobContainer", "Szukaj oCItem w oCMobContainer", "Hledat oCItem v oCMobContainer" });
            AddNewWord("VOBLIST_TYPE_ANY", new List<string> { "Любой тип", "Any type", "Jeder Typ", "Dowolny typ", "Jakýkoli typ" });
            AddNewWord("MENU_TOP_CONTROLS_VOBS", new List<string> { "Вобы", "Vobs", "Vob", "Voby", "Voby" });
            AddNewWord("WIN_CONTROLSET_VOBS_TEXT", new List<string> { "Настройки вобов", "Vobs settings", "Vob Einstellungen", "Ustawienia vobów", "Nastavení vobů" });
            AddNewWord("MSG_COMMON_NO_EMPTY_NAME", new List<string> { "Имя не может быть пустым!", "Name can't be empty!", "Der Name darf nicht leer sein!", "Nazwa nie może być pusta!", "Jméno nemůže být prázdné!" });
            AddNewWord("MSG_COMMON_NO_UNIQUE_NAME", new List<string> { "Такое имя уже есть", "The name already exists!", "Der Name existiert bereits!", "Nazwa już istnieje!", "Toto jméno již existuje!" });
            AddNewWord("WIN_MATFILTER_FILTER_NEW", new List<string> { "Создать новый", "New filter", "Neuer Filter", " Nowy filtr", "Nový filtr" });
            AddNewWord("WIN_MATFILTER_FILTERLIST_RENAME", new List<string> { "Переименовать выбранный", "Rename selected", "Selektiertes umbenennen", "Zmień nazwę wybranego", "Přejmenovat vybrané" });
            AddNewWord("WIN_MATFILTER_FILTERLIST_SAVE", new List<string> { "Сохранить файл фильтров", "Save filters file", "Filterdatei speichern", "Zapisz plik filtrów", "Uložit soubor s filtry" });
            AddNewWord("WIN_MATFILTER_FILTER_TITLE", new List<string> { "Фильтр материалов", "Materials filter", "Material Filter", "Filtr materiałów", "Filtr materiálů" });
            AddNewWord("WIN_MATFILTER_FILTER_TAB_MESH", new List<string> { "Меш", "Mesh", "Mesh", "Mesh", "Mesh" });
            AddNewWord("WIN_MATFILTER_FILTER_TAB_VOBS", new List<string> { "Вобы", "Vobs", "Vobs", "Voby", "Voby" });
            AddNewWord("WIN_MATFILTER_FILTER_SEARCH_IN_MATS", new List<string> { "Поиск материала:", "Search material:", "Suche Material", "Wyszukaj materiał:", "Hledat materiál:" });
            AddNewWord("WIN_MATFILTER_FILTER_TEXTURE", new List<string> { "Текстура", "Texture", "Texture", "Tekstura", "Textura" });
            AddNewWord("WIN_MATFILTER_FILTER_SETTINGS", new List<string> { "Настройки выбранного материала", "Properties of selected material", "Eigenschaften des selektierten Materials", "Właściwości wybranego materiału", "Vlastnosti vybraného materiálu" });
            AddNewWord("WIN_MATFILTER_FILTER_SET_FILTER", new List<string> { "Задать фильтр:", "Set filter:", "Filter setzen:", "Ustaw filtr:", "Nastavení filtru" });
            AddNewWord("WIN_MATFILTER_FILTER_SET_GROUP", new List<string> { "Задать группу:", "Set group:", "Setze Gruppe:", "Ustaw grupę:", "Nastavení skupiny:" });
            AddNewWord("WIN_MATFILTER_FILTER_SETTINGS_SIZE", new List<string> { "Размер:", "Size:", "Größe:", "Rozmiar:", "Rozměr" });
            AddNewWord("WIN_MATFILTER_FILTER_SETTINGS_ALPHA", new List<string> { "Альфа-канал:", "Alpha channel:", "Alpha Kanal", "Kanał alpha:", "Alpha kanál" });
            AddNewWord("WIN_MATFILTER_FILTER_SETTINGS_ALPHA_YES", new List<string> { "Альфа-канал: да", "Alpha channel: yes", "Alpha Kanal: Ja", "Kanał alpha: tak", "Alpha kanál: ano" });
            AddNewWord("WIN_MATFILTER_FILTER_SETTINGS_ALPHA_NO", new List<string> { "Альфа-канал: нет", "Alpha channel: no", "Alpha Kanal: Nein", "Kanał alpha: nie", "Alpha kanál: ne" });
            AddNewWord("WIN_MATFILTER_FILTER_SETTINGS_BITS", new List<string> { "бит", "bits", "bits", "bity", "bity" });
            AddNewWord("WIN_MATFILTER_FILTER_SETTINGS_NAME", new List<string> { "Настройки предпросмотра", "Preview settings", "Vorschau Einstellungen", "Ustawienia podglądu", "Nastavení náhledu" });
            AddNewWord("WIN_MATFILTER_FILTER_SETTINGS_USE_ALPHA", new List<string> { "Прозрачность", "Transparency", "Transparenz", "Przezroczystość", "Průhlednost" });
            AddNewWord("WIN_MATFILTER_FILTER_SETTINGS_USE_CENTER", new List<string> { "Всегда по центру", "Always in center", "Immer in der Mitte", "Zawsze na środku", "Vždy ve středu" });
            AddNewWord("WIN_MATFILTER_FILTER_SETTINGS_USE_SCALE", new List<string> { "Автомасштаб малых текстур", "Autoscale small textures", "Autoskalieren kleiner Texturen", "Automatyczne skalowanie małych tekstur", "Automatické škálování malých textur" });
            AddNewWord("WIN_MATFILTER_FILTER_MAT_NAME_ALREADY_EXISTS", new List<string> { "Материал с таким именем уже существует!", "Material with this name already exists!", "Material mit diesem Namen existiert bereits!", "Materiał o tej nazwie już istnieje!", "Materiál s tímto názvem již existuje!" });
            AddNewWord("MSG_MATFILTER_NEW_MAT_NAME", new List<string> { "Имя материала:", "Material name:", "Material Name:", "Nazwa materiału:", "Jméno materiálu:" });
            AddNewWord("WIN_MATFILTER_TEXTURE_NOT_FOUND", new List<string> { "(Не найдена)", "(Not found)", "(Nicht gefunden)", "(Nie znaleziono)", "(Nenalezeno)" });
            AddNewWord("WIN_MATFILTER_FILTERS_MENU", new List<string> { "Меню фильтров", "Filters menu", "Filter Menü", "Menu filtrów", "Menu filtrů" });
            AddNewWord("WIN_MATFILTER_MATLIST_CURRENT", new List<string> { "Материалы {0} фильтра: ", "Materials of {0} filter: ", "Materialien des {0}-Filters: ", "Materiały {0} filtra: ", "Materiály filtru {0}: " });
            AddNewWord("WIN_MATFILTER_MATLIST_CURRENT_EMPTY", new List<string> { "Материалы фильтра: (0) ", "Materials of the filter: (0) ", "", "Materiały filtra: (0)", "Materiály filtru: (0) " });
            AddNewWord("WIN_MATFILTER_ERR_NO", new List<string> { "Все готово к работе", "Everything is ready", "", "Wszystko jest gotowe", "Vše je připraveno" });
            AddNewWord("WIN_MATFILTER_ERR_WORK", new List<string> { "Для работы загрузите ZEN или 3DS файл", "Load any ZEN or 3DS to activate Materials Filter", "Lade eine beliebige ZEN oder 3DS, um den Materialfilter zu aktivieren.", "Załaduj dowolny ZEN lub 3DS, aby aktywować filtr materiałów", "Pro aktivaci filtru materiálů načtěte libovolný ZEN nebo 3DS" });
            AddNewWord("WIN_MATFILTER_ERR_READONLY", new List<string> { "Файл MatLib.ini имеет аттрибут 'Только чтение'. Изменения в 'Библиотеке фильтров' не будут работать!", "File Matlib.ini has 'read only' attribute, no changes will be saved in 'Filters library'", "Datei Matlib.ini hat das Attribut 'Schreibgeschützt', Änderungen werden nicht in der 'Filter Bibliothek' gespeichert", "Plik Matlib.ini ma atrybut 'tylko do odczytu', żadne zmiany nie zostaną zapisane w 'Bibliotece filtrów'", "Soubor Matlib.ini má atribut 'pouze pro čtení', v 'Knihovně filtrů' nebudou uloženy žádné změny." });
            AddNewWord("WIN_MATFILTER_FILTERLIST_REMOVE", new List<string> { "Удалить фильтр", "Remove filter", "Filter entfernen", "Usuń filtr", "Odstranit filtr" });
            AddNewWord("MSG_MATFILTER_REMOVE_ONLY_NONEMPTY", new List<string> { "Можно удалить только пустой фильтр!", "You can remove only empty filter!", "Du kannst nur leere Filter entfernen!", "Możesz usunąć jedynie pusty filtr!", "Můžete odstranit pouze prázdný filtr!" });
            AddNewWord("WIN_MATFILTER_FILTERS_MENU_MISC", new List<string> { "Прочее", "Misc", "Sonstiges", "Pozostałe", "Různé" });
            AddNewWord("WIN_MATFILTER_NEW_MATERIAL", new List<string> { "Новый материал", "New material", "Neues Material", "Nowy materiał", "Nový materiál" });
            AddNewWord("WIN_MATFILTER_FILTERLIST_FILES", new List<string> { "Библиотека фильтров", "Filters library", "Filter Bibliothek", "Biblioteka filtrów", "Knihovna filtrů" });
            AddNewWord("WIN_MATFILTER_TEXTURE_TOO_BIG", new List<string> { "Размер текстуры слишком большой для отображения", "Texture is too big for being shown", "Texture ist zum Zeigen zu groß", "Tekstura jest za duża, by ją wyświetić", "Textura je příliš velká pro zobrazení" });
            AddNewWord("WIN_MATFILTER_CONV_TGA", new List<string> { "Конвертация TGA текстур: ", "Convering TGA textures: ", "Konvertiere TGA Texturen", "Konwersja tekstur TGA:", "Konverze textur TGA: " });
            AddNewWord("WIN_MATFILTER_CONV_WARNING", new List<string> { "Не выключайте SpacerNET!", "Don't shut down SpacerNET!", "Du darfst SpacerNET nicht beenden!", "Nie wyłączaj SpacerNET!", "Nevypínejte SpacerNET!" });
            AddNewWord("WIN_MATFILTER_CONV_INFO", new List<string> { "Некоторые из ваших материалов используют текстуры, которые не скомпилированы в '-C.TEX'.\nДля сохранения фильтров необходимо скомпилировать эти текстуры из TGA текстур.\nВыполняю конвертацию...", "Some of your materials don't have a compiled '-C.TEX' version of texture.\nTo save the filter such textures must be compiled from TGA textures.\nConverting...", "Einige deiner Materialien haben keine kompilierte '-C.TEX'-Version der Textur.\nUm den Filter zu speichern, müssen solche Texturen aus TGA-Texturen kompiliert werden.\nKonvertiere...", "Niektóre z materiałów nie mają skompilowanej wersji tekstury '-C.TEX'.\nAby zapisać filtr, takie tekstury muszą być skompilowane z tekstur TGA.\nKonwersja...", "Některé z vašich materiálů nemají zkompilovanou verzi textury '-C.TEX'.\nPro uložení filtru musí být takové textury zkompilovány z textur TGA.\nKonverze..." });
            AddNewWord("WIN_MATFILTER_FOLLOW_MAT", new List<string> { "Следовать за материалом при применении", "Follow material after applying", "Material nach anwenden folgen", "Śledź materiał po zatwierdzeniu", "Sledování materiálu po aplikaci" });
            AddNewWord("WIN_MATFILTER_SAVE_LAST_FILTER", new List<string> { "Принудительно ставить последний фильтр", "Forcedly set last filter", "Letzten Filter zwangsweise setzen", "Wymuś ustawienie ostatniego filtra", "Vynuceně nastavit poslední filtr" });
            AddNewWord("Trigget_BTN_JUMPTOKEY", new List<string> { "Прыгнуть на ключ", "Jump to key", "Zu Key Springen", "Przejdź do klucza", "Skočit na klávesu" });
            AddNewWord("TOOL_BBOX_EDIT_MODE_SELECTED", new List<string> { "Режим изменения BBOX", "BBOX editing mode", "Bbox Editier Modus", "Tryb edycji BBOX", "Režim editace BBOX" });
            AddNewWord("VOB_SEARCH_TYPE_SINGLE_WP", new List<string> { "Поиск несоединенных WP", "Search for unconnected WP", "Suche nach unverbundenden WP's", "Szukaj dla niepołączonych WP", "Hledání nepřipojených WP" });
            AddNewWord("OBJ_TAB_PICKFILTER", new List<string> { "Фильтр выделения вобов", "Vob selection filter", "Vob Filter auswählen", "Wybierz filtr voba", "Výběr filtru Vobu" });



            //=========================
            AddNewWord("UNION_VOB_POS", new List<string> { "Позиция воба: ", "Vob pos: ", "Vob pos: ", "Pozycja voba: ", "Pozice vobu: " });
            AddNewWord("checkBoxCamCoord", new List<string> { "Показывать координаты камеры и воба", "Show camera and vob coordinates", "Kamera- und Vob-Koordinaten anzeigen", "Pokaż kamerę i współrzędne voba", "Zobrazit souřadnice kamery a vobu" });
            AddNewWord("VOB_ONEMODE", new List<string> { "Единый режим перемещения воба", "United mod of vob moving", "United mod of vob moving", "Wspólny tryb poruszania vobem", "Společný režim pohybu vobu" });
            AddNewWord("VOB_ONEMODE_OFF", new List<string> { "Единый режим отключен", "United mod disabled", "United Mod deaktiviert", "Wspólny tryb wyłączony", "Společný režim vypnut" });
            AddNewWord("MSG_VOB_FAV_ADD", new List<string> { "Воб добавлен в быстрый доступ", "Vob added to fast access list", "Vob ist zur Schellzugriffsliste hinzugefügt", "Vob dodany do listy szybkiego dostępu", "Vob přidán do seznamu rychlého přístupu" });
            AddNewWord("KEYS_VOB_FAV_ADD", new List<string> { "Добавить воб в быстрый доступ", "Add vob to fast access list", "Vob zur Schellzugriffsliste hinzufügen", "Dodaj voba do listy szybkiego dostępu", "Přidání vobu do seznamu rychlého přístupu" });
            AddNewWord("BTN_SET_DEFAULT_VALUES", new List<string> { "Сбросить настройки", "Set default settings", "Option zurücksetzen", "Ustaw domyślne wartości", "Nastavení výchozího nastavení" });
            AddNewWord("VOB_FILTER_SHOW_ONLY_INVISIBLE", new List<string> { "Только невидимые", "Only invisible", "Nur unsichtbare", "Tylko niewidoczne", "Pouze neviditelné" });
            AddNewWord("UNION_NO_WP_FP", new List<string> { "Сначала выберите и скопируйте WP или FP!", "First select and copy WP or FP", "Markiere und kopiere zuerst WP oder FP", "Zaznacz i skopiuj WP lub FP", "Nejprve vyberte a zkopírujte WP nebo FP" });
            AddNewWord("BTN_OPEN_FILE", new List<string> { "Выбрать файл...", "Load file...", "Lade Datei", "Wczytaj plik...", "Načíst soubor..." });
            AddNewWord("TOGGLE_MUSIC", new List<string> { "Включить/отключить музыку", "Toggle music", "Musik umschalten", "Przełącz muzykę", "Přepínání hudby" });
            AddNewWord("UNION_MUSIC_ON", new List<string> { "Музыка включена", "Music is ON", "Musik EIN", "Muzyka jest włączona", "Hudba je zapnutá" });
            AddNewWord("UNION_MUSIC_OFF", new List<string> { "Музыка отключена", "Music is OFF", "Musik AUS", "Muzyka jest wyłączona", "Hudba je vypnutá" });
            AddNewWord("checkBoxShowMoverKeys", new List<string> { "Показать ключи визуально", "Show keys visually", "Tasten visuell anzeigen", "Pokaż wizualizacje kluczy", "Vizuální zobrazení kláves" });
            AddNewWord("checkBoxAddPFX", new List<string> { "Добавлять .pfx при копировании", "Add .pfx when copy", "Beim kopieren .pfx hinzufügen", "Dodaj .pfx przy kopiowaniu", "Přidání souboru .pfx při kopírování" });
            AddNewWord("buttonRemoveMoverAllKeys", new List<string> { "Удалить все (сохранив позицию воба)", "Remove all (save vob position)", "Alle entfernen (vob-Position speichern)", "Usuń wszystko (zapisz pozycje voba)", "Odstranit vše (uložit pozici vobu)" });
            AddNewWord("buttonMoverResetKeyTo0", new List<string> { "Удалить все (поставить воб на 0 ключ)", "Remove all (set vob on 0 key)", "Alle entfernen (vob auf Taste 0 setzen)", "Usuń wszystko (ustaw voba na 0 klucz)", "Odstranit vše (nastavit vob na klávesu 0)" });
            AddNewWord("noSelectToolNowFilterMat", new List<string> { "Пока активно окно Фильтра материалов нельзя выключить выделение полигонов!", "You can't turn off polygons select tool while Material filter window is active!", "Du kannst das Polygonauswahlwerkzeug nicht ausschalten, während das Materialfilterfenster aktiv ist!", "Nie możesz wyłączyć narzędzia do zaznaczania poligonów gdy okno filtru materiałów jest aktywne!", "Nástroj pro výběr polygonů nelze vypnout, pokud je aktivní okno filtru materiálů!" });
            AddNewWord("TOGGLE_SCREENINFO", new List<string> { "Включить/отключить информацию на экране", "Toggle screen info", "Bildschirminfo umschalten", "Włącz/wyłącz informacje wyświetlane na ekranie", "Přepínání informací na obrazovce" });
            AddNewWord("RESTART_REQUIRED", new List<string> { "*требуется перезапуск", "*restart required", "*Neustart erforderlich", "*Wymagany restart", "*vyžadován restart" });
            AddNewWord("MOD_CAMERA_SYNC_ON", new List<string> { "Включен режим синхронизации камеры с вобом", "Camera sync mod is ON", "Kamera Sync Mod ist AN", "Tryb synchronizacji kamery jest WŁĄCZONY", "Synchronizace kamery je ZAPNUTA" });
            AddNewWord("MOD_CAMERA_SYNC_OFF", new List<string> { "Отключен режим синхронизации камеры с вобом", "Camera sync mod is OFF", "Kamera Sync Mod ist AUS", "Tryb synchronizacji kamery jest WYŁĄCZONY", "Synchronizace kamery je VYPNUTA" });
            AddNewWord("KEYS_MOD_CAMERA_SYNC", new List<string> { "Режим синхронизации камеры с вобом", "Camera sync mod with selected vob", "Kamera Sync Mod mit ausgewähltem vob", "Tryb synchronizacji kamery z wybranym vobem", "Synchronizace kamery s vybraným vobem" });
            AddNewWord("CONTEXTMENU_SAVE_VISUAL_TO_FILE", new List<string> { "Сохранить визуал для импорта в 3DMAX/Blender", "Save visual for importing in 3DMAX/Blender", "Visuelles zum Importieren in 3DMAX/Blender speichern", "Zapisz visual do importu w 3DSMAX/Blenderze", "Uložení vizuálu pro import do 3DMAX/Blenderu" });
            AddNewWord("CONTEXTMENU_SAVE_VISUAL_TO_FILE_CHILDREN", new List<string> { "Включая дочерние вобы", "Including children vobs", "Einschließlich Innere VOBs", "Wraz z dziećmi vobów", "Včetně dceřinných vobů" });
            AddNewWord("CONTEXTMENU_SAVE_VISUAL_TO_FILE_ONLY_PARENT", new List<string> { "Только родительский воб", "Only parent vob", "Nur Haupt VOBs", "Tylko rodzic voba", "Pouze rodičovský vob" });
            AddNewWord("VOB_VISUAL_SAVE_SUCCESS", new List<string> { "Успешно сохранено!", "Saved successfully!", "Erfolgreich gespeichert!", "Zapisano pomyślnie!", "Úspěšně uloženo!" });
            AddNewWord("VOB_VISUAL_SAVE_FAIL", new List<string> { "Не удалось сохранить!", "Fail to save file!", "Datei konnte nicht gespeichert werden!", "Nie udało się zapisać pliku!", "Nepodařilo se uložit soubor!" });
            AddNewWord("ROT_MOD_CHANGE", new List<string> { "Сменить режим вращения воба (WORLD/LOCAL/CAMERA)", "Change rotation mod (WORLD/LOCAL/CAMERA)", "Rotationsmodus ändern (WORLD/LOCAL/CAMERA)", "Zmiana trybu rotacji (WORLD/LOCAL/CAMERA)", "Změna módu otáčení (WORLD/LOCAL/CAMERA)" });
            AddNewWord("ACTION_FORBIDDEN", new List<string> { "Недопустимое действие!", "This action is forbidden!", "Diese Aktion ist verboten!", "To działanie jest zakazane!", "Tato činnost je zakázána!" });
            AddNewWord("SET_SELECT_FILTER_PFX", new List<string> { "Установлен фильтр выделения: Игнорировать PFX", "Selection filter set: Ignore PFX", "Filter Auswahl: PFX Ignorieren", "Ustawiony filtr wyboru: Ignoruj PFX", "Výběr sady filtrů: Ignorovat PFX" });
            AddNewWord("SET_SELECT_FILTER_NONE", new List<string> { "Установлен фильтр выделения: Нет", "Selection filter set: NONE", "Filter Auswahl: KEINE", "Ustawiony filtr wyboru: BRAK", "Výběr sady filtrů: ŽÁDNÝ" });
            AddNewWord("VOB_FILTER_IGNORE_PFX", new List<string> { "Игнорировать PFX", "Ignore PFX", "PFX Ignorieren", "Ignoruj PFX", "Ignoruj PFX" });
            AddNewWord("MSG_WRONG_COLOR_FORMAT", new List<string> { "Недопустимый формат цвета! Используйте формат RGBA '255 255 255 255'", "Wrong color format! Format is RGBA '255 255 255 255'", "Falsches Farbformat! Format ist RGBA '255 255 255 255'", "Zły format koloru! Prawidłowy format to '255, 255, 255, 255'", "Špatný formát barev! Formát je RGBA '255 255 255 255'" });
            AddNewWord("MSG_WRONG_COLOR_FORMAT_RANGE", new List<string> { "Допустимый диапазон цвета от 0 до 255!", "Valid color range is 0 to 255 ", "Gültiger Farbbereich ist 0 bis 255", "Dopuszczalny zakres koloru jest od wartości 0 do 255!", "Platný rozsah barev je 0 až 255!" });
            AddNewWord("VOB_INFO_VISUAL_COPIED", new List<string> { "Информация о визуале воба скопирована в буфер и консоль", "Vob's visual info copied to clipboard and console", "Visuelle Infos von VOBs in die Zwischenablage und Konsole kopiert", "Informacje dotyczące visuala voba zostały skopiowane do schowka i konsoli", "Vizuální informace vobu zkopírovany do schránky a konzole" });
            AddNewWord("changeFontToolStripMenuItem", new List<string> { "Настроить шрифт", "Font settings", "Schriftart Einstellungen", "Ustawienia czcionki", "Nastavení písma" });
            AddNewWord("setFontUIToolStripMenuItem", new List<string> { "Установить шрифт", "Set font", "Schriftart einstellen", "Ustaw czcionkę", "Nastavit písmo" });
            AddNewWord("resetDefaultToolStripMenuItem", new List<string> { "Сбросить шрифт по умолчанию", "Reset font to default", "Schriftart auf Standard zurücksetzen", "Ustaw domyślną czcionkę", "Obnovit výchozí písmo" });
            AddNewWord("TOP_MENU_CHANGE_ICONS_SCALE", new List<string> { "Сменить маштаб иконок", "Change icons scale", "Skalierung der Icons ändern", "Zmień skalę ikon", "Změna měřítka ikon" });
            AddNewWord("TOP_MENU_CHANGE_ICONS_DEFAULT", new List<string> { "Установить по умолчанию 1.0", "Set default 1.0", "Standardwert 1,0 einstellen", "Ustaw domyślną 1.0", "Nastavit výchozí hodnotu 1.0" });
            AddNewWord("RENAME_WIN_TITLE", new List<string> { "Опции переименования", "Rename options", "Optionen umbenennen", "Opcje zmiany nazwy", "Možnosti přejmenování" });
            AddNewWord("radioButtonRenameEmpty", new List<string> { "Установить пустое имя для всех вобов", "Set empty name for all vobs", "Leeren Namen für alle VOBs festlegen", "Ustaw pustą nazwę dla wszystkich vobów", "Nastavení prázdného jména pro všechny voby" });
            AddNewWord("radioButtonNameForAll", new List<string> { "Установить единое имя для всех вобов", "Set one name for all vobs", "Einen Namen für alle VOBs festlegen", "Ustaw jedną nazwę dla wszystkich vobów", "Nastavení jednoho jména pro všechny voby" });
            AddNewWord("radioButtonNameOneNumberPostfix", new List<string> { "Установить имя с числом в конце начиная с...", "Set one name with number postfix started from...", "Benenne mit nummerischem Anhang, beginnend ab...", "Ustaw jedną nazwę z liczbą postfix zaczynającą się od...", "Nastavení jednoho jména s číslem postfixu od..." });
            AddNewWord("PFX_EDITOR_WRONG_INPUT", new List<string> { "Введено недопустимое значение!", "Wrong input!", "Falsche Eingabe!", "Podano nieprawidłową wartość!", "Špatný vstup!" });
            AddNewWord("PFX_EDITOR_WRONG_INPUT_0_255", new List<string> { "Допустимый диапазон от 0 до 255!", "Allowed range is from 0 to 255", "Erlaubter Bereich ist von 0 bis 255!", "Dozwolony zakres jest od 0 do 255!", "Povolený rozsah je 0 až 255" });
            AddNewWord("PFX_EDITOR_WRONG_INPUT_NOT_NUMBER", new List<string> { "Введеная строка не является числом!", "Input text is not a number!", "Eingegebener Text ist keine Zahl!", "Wprowadzony tekst nie jest liczbą!", "Vstupní text není číslo!" });
            AddNewWord("PFX_EDITOR_WRONG_INPUT_CANTBE_NEGATIVE", new List<string> { "Данное поле не может быть отрицательным!", "This field can't be negative!", "Feld darf nicht Negativ sein!", "To pole nie może być ujemne!", "Toto pole nemůže být záporné!" });
            AddNewWord("PFX_EDITOR_WRONG_FORMAT_VECTOR3", new List<string> { "Правильный формат (вектор): 10.0 -20.0 55.0", "Correct format (vector): 10.0 -20.0 55.0", "Aktuelles Format (Vector): 10.0 -20.0 55.0", "Prawidłowy format (vector): 10.0, -20.0 55.0", "Správný formát (vektor): 10.0 -20.0 55.0" });
            AddNewWord("PFX_EDITOR_WRONG_FORMAT_COLOR", new List<string> { "Правильный формат (цвет, 3 числа от 0 до 255): 255 20 30", "Correct format (color, 3 numbers from 0 to 255): 255 20 30", "Aktuelles Format (Farbe, 3 Zahlen von 0 bis 255): 255 20 30", "Prawidłowy format (color, 3 liczby od 0 do 255): 255 20 30", "Správný formát (barva, 3 čísla od 0 do 255): 255 20 30" });
            AddNewWord("PFX_EDITOR_WRONG_FORMAT_VECTOR2", new List<string> { "Правильный формат (два числа): 5 8", "Correct format (two numbers): 5 8", "Aktuelles Format (zwei Zahlen): 5 8", "Prawidłowy format (dwie liczby): 5 8", "Správný formát (dvě čísla): 5 8" });
            AddNewWord("PFX_EDITOR_TITLE", new List<string> { "Редактор частиц", "Particles editor", "Partikel-Editor", "Edytor cząsteczek", "Editor částic" });
            AddNewWord("PFX_EDITOR_INSTANCE", new List<string> { "Инстанция PFX: ", "PFX instance: ", "PFX-Instanz: ", "Instancja PFX: ", "PFX instance: " });
            AddNewWord("PFX_EDITOR_PLAY_AGAIN", new List<string> { "Вызвать эффект снова", "Play effect again", "Effekt erneut abspielen", "Odtwórz efekt ponownie", "Znovu přehrát efekt" });

            AddNewWord("PFX_EDITOR_SAVE_IN_FILE", new List<string> { "Сохранить в файл", "Save into a file", "In Datei speichern", "Zapisz do pliku", "Uložit do souboru" });
            AddNewWord("PFX_EDITOR_AUTO_PLAY", new List<string> { "Повторно вызывать эффект", "Repeat playing effect", "Effekt wiederholen", "Powtarzaj odtwarzany efekt", "Efekt opakovaného přehrávání" });
            AddNewWord("PFX_EDITOR_SET_NEAR_CAMERA", new List<string> { "Переместить эффект к камере", "Place effect near camera", "Platziere Effekt nahe der Kamera", "Ustaw efekt w pobliżu kamery", "Umístění efektu v blízkosti kamery" });
            AddNewWord("PFX_EDITOR_SET_NEAR_CAMERA_DONE", new List<string> { "Эффект перемещен к камере", "The effect was placed near camera", "Effekt wurde nahe der Kamera platziert", "Efekt został umieszony w pobliżu kamery", "Efekt byl umístěn v blízkosti kamery" });
            AddNewWord("PFX_EDITOR_REMOVE_EFFECT", new List<string> { "Удалить эффект с экрана", "Remove effect from screen", "Effekt vom Bildschirm entfernen", "Usuń efekt z ekranu", "Odstranit efekt z obrazovky" });
            AddNewWord("WIN_TOOLTIP_VISUAL_INFO", new List<string> { "Режим информации о визуале воба", "Vob's visual info mode", "VOBs visueller Info-Modus", "Tryb informacji wizualnych o Vobie", "Režim vizuálních informací vobu" });
            AddNewWord("WIN_TOOLTIP_NOGRASS", new List<string> { "Режим скрытия травы (nograss)", "No grass mode", "Kein Gras-Modus", "Tryb bez trawy", "Režim bez trávy" });


            AddNewWord("PFX_EDITOR_WARNING_WRONG_NAME", new List<string> { "Нельзя вызывать эффект из самого себя! Измените поле ppsCreateEm_s!", "You cannot call the effect from itself! Change the ppsCreateEm_s field!", "Du kannst den Effekt nicht von sich aus aufrufen! Ändere das ppsCreateEm_s Feld!", "Nie możesz wywołać efektu na samym sobie! Zmień pole ppsCreateEm_s!", "Efekt nelze přivolat sám od sebe! Změňte pole ppsCreateEm_s!" });
            AddNewWord("ERROR_REPORT_TITLE", new List<string> { "Поиск ошибок в ZEN", "Search errors in ZEN", "Suche nach Fehlern im ZEN", "Szukaj błędów w ZEN", "Hledání chyb ve ZENu" });
            AddNewWord("ERROR_REPORT_COLUMN_PROBLEM_TYPE", new List<string> { "Тип проблемы", "Problem type", "Art des Problems", "Rodzaj problemu", "Typ problému" });
            AddNewWord("ERROR_REPORT_COLUMN_PROBLEM_LEVEL", new List<string> { "Уровень ошибки", "Error level", "Fehlerquote", "Poziom błędu", "Úroveň chyb" });
            AddNewWord("ERROR_REPORT_COLUMN_PROBLEM_DESC", new List<string> { "Описание", "Description", "Beschreibung", "Opis", "Popis" });
            AddNewWord("ERROR_REPORT_COLUMN_PROBLEM_ACTION", new List<string> { "Действие", "Action", "Aktion", "Akcja", "Akce" });
            AddNewWord("ERROR_REPORT_BUTTON_FIND_ALL", new List<string> { "Найти все ошибки", "Find all errors", "Finde alle Fehler", "Znajdź wszystkie błędy", "Vyhledat všechny chyby" });
            AddNewWord("ERROR_REPORT_TYPE_INFO", new List<string> { "Оповещение", "Information", "Information", "Informacje", "Informace" });
            AddNewWord("ERROR_REPORT_TYPE_WARNING", new List<string> { "Предупреждение", "Warning", "Warnung", "Ostrzeżenie", "Varování" });
            AddNewWord("ERROR_REPORT_TYPE_CRITICAL", new List<string> { "Критическая ошибка", "Critical error", "Kritischer Fehler", "Błąd krytyczny", "Kritická chyba" });
            AddNewWord("ERROR_REPORT_TYPE_ALL", new List<string> { "Все", "All", "Alle", "Wszystko", "Vše" });
            AddNewWord("ERROR_REPORT_DOUBLE_CLICK", new List<string> { "Двойной клик для выбора...", "Double click to select...", "Doppelklick zum auswählen...", "Naciśnij dwa razy by zaznaczyć...", "Dvojklikem vyberte..." });
            AddNewWord("ERROR_REPORT_TEXT_MATERIAL", new List<string> { "Материал", "Material", "Material", "Materiał", "Materiál" });
            AddNewWord("ERROR_REPORT_TEXT_TEXTURE", new List<string> { "Текстура", "Texture", "Textur", "Tekstura", "Textura" });


            AddNewWord("ERROR_REPORT_NO_ERRORS", new List<string> { "Ошибки не найдены!", "Errors not found!", "Fehler nicht gefunden!", "Nie znaleziono błędów!", "Nebyly nalezeny chyby!" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_NAME", new List<string> { "Подозрительное имя материала", "Suspicious material's name", "Name des verdächtigen Materials", "Podejrzana nazwa materiału", "Podezřelé jméno materiálu" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_TEXTURE_BAD_NAME", new List<string> { "Неправильное имя текстуры", "Wrong texture name", "Falscher Texturname", "Zła nazwa tekstury", "Špatný název textury" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_TEXTURE_NOT_FOUND", new List<string> { "Текстура не найдена", "Texture not found", "Textur nicht gefunden", "Tekstura nie znaleziona", "Textura nebyla nalezena" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_TRIGGER_NO_NAME", new List<string> { "Нет имени у триггера", "Trigger has no name", "Trigger hat keinen Namen", "Trigger nie ma nazwy", "Trigger nemá jméno" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_PFX_CANT_BE_PARENT", new List<string> { "PFX не может содержать в себе другие вобы!", "PFX vob can't contain vobs inside itself!", "PFX VOB kann keine VOBs in sich selbst enthalten!", "PFX nie może zawierać vobów wewnątrz siebie!", "PFX vob nemůže obsahovat voby uvnitř sebe!" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_ITEM_CANT_BE_PARENT", new List<string> { "oCItem не может содержать в себе другие вобы", "oCItem vob can't contain vobs inside itself!", "oCItem VOB kann keine VOBs in sich selbst enthalten!", "Vob oCItem nie może mieć w sobie vobów!", "oCItem vob nemůže obsahovat vob uvnitř sebe!" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_ITEM_NO_VISUAL", new List<string> { "oCItem не имеет визуала", "oCItem does not have a visual", "oCItem hat kein Aussehen", "oCItem nie ma ustawionego visuala", "oCItem nemá vizuál" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_ZCVOB_EMPTY_VISUAL", new List<string> { "zCVob не имеет визуала", "zCVob does not have a visual", "zCVob hat kein Aussehen", "zCVob nie ma ustawionego visuala", "zCVob nemá vizuál" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_FOG_ZONES", new List<string> { "Неверное количество zCZoneZFogDefault, должно быть 1", "Wrong number of zCZoneZFogDefault, must be 1", "Falsche Nummer von zCZoneZFogDefault, muss 1 sein", "Nieprawidłowa ilość obiektów zCZonezFogDefault, musi być tylko 1", "Špatné číslo zCZoneZFogDefault, musí být 1" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_VOB_ZONES", new List<string> { "Неверное количество zCZoneVobFarPlaneDefault, должно быть 1", "Wrong number of zCZoneVobFarPlaneDefault, must be 1", "Falsche Nummer von zCZoneVobFarPlaneDefault, muss 1 sein", "Nieprawidłowa ilość obiektów zCZoneVobFarPlaneDefault, musi być tylko 1", "Špatné číslo zCZoneVobFarPlaneDefault, musí být 1" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_MUSIC_ZONES", new List<string> { "Неверное количество oCZoneMusicDefault, должно быть 1", "Wrong number of oCZoneMusicDefault, must be 1", "Falsche Nummer von oCZoneMusicDefault, muss 1 sein", "Nieprawidłowa ilość obiektów oCZoneMusicDefault, musi być tylko 1", "Špatné číslo oCZoneMusicDefault, musí být 1" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_STARTPOINT", new List<string> { "Неверное количество zCVobStartpoint, должно быть 0 или 1", "Wrong number of zCVobStartpoint, must be 0 or 1", "Falsche Nummer von zCVobStartpoint, muss 0 oder 1 sein", "Nieprawidłowa ilość obiektów zCVobStartpoint, musi być albo 0 albo 1", "Špatné číslo zCVobStartpoint, musí být 0 nebo 1" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_EMPTY_NAME", new List<string> { "У объекта пустое имя", "The vob has an empty name", "Der VOB hat keinen Namen", "Vob ma pustą nazwę", "Vob má prázdný název" });


            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_EMPTY_NAME_MOB_FOCUS", new List<string> { "oCMob не имеет focusName", "oCMob does not have focusName", "oCMob hat keinen focusName", "oCMob nie ma ustawionego focusName", "oCMob nemá focusName" });
            AddNewWord("CANT_CHANGE_PARENT_INTO_ITSELF", new List<string> { "Нельзя установить родителя воба самого себя!", "Can't set vob parent as the vob itself!", "Ich kann dem Haupt VOB nicht als die VOB selbst festlegen!", "Nie można ustawić rodzica voba jako samego siebie!", "Nelze nastavit rodičovský vob jako samotný vob!" });
            AddNewWord("WIN_GRASS_INSERT_INTO_GLOBAL_PARENT", new List<string> { "Вставлять воб в Глобального родителя", "Insert the vob into Global parent", "Füge die VOB in die übergeordnete Gruppe ein", "Dodaj voba do globalnego rodzica", "Vložení vobu do globálního rodiče" });
            AddNewWord("SEWER_NO_PLACE_TO_PUT_VOB", new List<string> { "Нет места для размещения воба", "No place to put vob", "Kein Platz zum Ablegen von VOB", "Brak miejsca by dodać voba", "Není kam umístit vob" });
            AddNewWord("checkBoxSearchInRadius", new List<string> { "В радиусе:", "In radius:", "Im Radius:", "W promieniu:", "V rozsahu:" });
            AddNewWord("VOB_FILTER_IGNORE_DECALS", new List<string> { "Игнорировать zCDecal", "Ignore zCDecal", "Ignoriere zCDecal", "Ignoruj zCDecal", "Ignorovat zCDecal" });
            AddNewWord("VOB_FILTER_IGNORE_DECALS_PFX", new List<string> { "Игнорир. zCDecal и PFX", "Ignore zCDecal and PFX", "Ignoriere zCDecal und PFX", "Ignoruj zCDecal i PFX", "Ignorovat zCDecal a PFX" });
            AddNewWord("SET_SELECT_FILTER_DECALS_PFX", new List<string> { "Установлен фильтр выделения: Игнорировать zCDecal и PFX", "Selection filter set: zCDecal and PFX", "Auswahlfilterset: zCDecal und PFX", "Wybrany filtr: zCDecal i PFX", "Výběrová sada filtrů: zCDecal a PFX" });
            AddNewWord("KEYS_FAST_FILTER_IGNOREPFX", new List<string> { "Выбрать фильтр выделения вобов: Игнорировать zCDecal и PFX", "Choose vob filter selection mod: Ignore zCDecal и PFX", "Wähle VOB Filter Auswahl-Modus: Ignoriere zCDecal und PFX", "Wybierz filtr zaznaczania vobów: Ignoruj zCDecal i PFX", "Vyberte vob filtr režimu výběru: Ignorovat zCDecal a PFX" });
            AddNewWord("ERROR_NAME_CANT_CONTAIN_SPACE", new List<string> { "Имя не может содержать символ 'пробел'!", "Vob's name can't contain a space symbol!", "Name von VOBs darf kein Leerzeichen enthalten!", "Nazwa Voba nie może zawierać spacji", "Jméno vobu nemůže obsahovat symbol mezery!" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_NAME_SPACE", new List<string> { "В имени воба есть символ 'пробел'", "Vob's name contains a space symbol", "Name von VOB enthält ein Leerzeichen", "Nazwa Voba zawiera spację", "Jméno vobu obsahuje symbol mezery" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_NOT_UNIQ_NAME", new List<string> { "Имя воба не уникально", "Vob's name is not unique", "VOBs Name ist nicht einzigartig", "Nazwa Voba nie jest unikalna", "Jméno vobu není jedinečné" });

            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_BAD_NAME_SYMBOLS", new List<string> { "Имя воба содержит недопустимые символы", "Vob's name contains bad symbols", "Der Name von VOB enthält falsche Symbole", "Nazwa Voba zawiera złe symbole", "Jméno Vob obsahuje špatné symboly" });
            AddNewWord("ERROR_REPORT_COPY_MAT_NAME", new List<string> { "Скопируйте имя материала и вставьте его в Фильтр материалов", "Copy material's name and copy it into Material Filter", "Kopiere den Namen des Materials und kopiere ihn in den Materialfilter", "Skopiuj nazwę materiału do filtru materiału", "Zkopírujte název materiálu a zkopírujte ho do Filtru materiálů" });


            AddNewWord("ERROR_REPORT_SAVE_REPORT", new List<string> { "Сохранить отчет в файл", "Save report to a file", "Bericht in eine Datei speichern", "Zapisz raport do pliku", "Uložit hlášení do souboru" });


            AddNewWord("SET_VOB_SET_ZERO_PARENT", new List<string> { "Воб помещен в центр родительского воба", "The vob is set to the center of parent vob", "Das VOB wird in die Mitte des übergeordneten VOBs gesetzt", "Vob jest ustawiony na środku voba rodzica", "Vob je nastaven do středu vobu rodiče" });
            AddNewWord("SET_VOB_SET_ZERO_PARENT_CANT", new List<string> { "У данного воба нет родителя!", "The vob does not have a parent vob!", "Das VOB hat kein übergeordnetes VOB!", "Vob nie ma voba rodzica!", "Tento vob nemá rodiče!" });
            AddNewWord("KEYS_VOB_SET_ZERO_PARENT", new List<string> { "Поместить воб в центр родительского воба", "Move the vob to the center of parent vob", "Verschiebe das VOB in die Mitte des übergeordneten VOBs", "Przenieś voba na środek voba rodzica", "Přesun vobu do středu vobu rodiče" });


            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_NAME_IS_VISUAL", new List<string> { "Имя воба совпадает с его визуалом", "Vob's name is the same as its visual", "VOB Name ist identisch mit dem visuellen Objekt", "Nazwa Voba jest taka sama jak jego wygląd", "Jméno vobu je stejné jako jeho vizuál" });


            AddNewWord("WIN_VOBCATALOG_TITLE", new List<string> { "Каталог вобов", "Vobs catalog", "VOBs Katalog", "Katalog vobów", "Katalog vobů" });
            AddNewWord("WIN_VOBCATALOG_GROUP_NAME", new List<string> { "Имя группы: ", "Group name: ", "Gruppen Name: ", "Nazwa grupy: ", "Jméno skupiny: " });
            AddNewWord("WIN_VOBCATALOG_VISUAL_NAME", new List<string> { "Визуал: ", "Visual: ", "Visuelles: ", "Visual: ", "Vizuál: " });
            AddNewWord("WIN_VOBCATALOG_MATFILTER_TURNOFF", new List<string> { "Сначала закройте окно Фильтра материалов!", "Turn off Materials filter window first!", "Schalte zuerst das Materialfilterfenster aus!", "Wpierw zamknij okno filtr materiałów!", "Nejprve vypněte okno filtru materiálů!" });
            AddNewWord("WIN_VOBCATALOG_POLYSELECT_TURNOFF", new List<string> { "Сначала выключите режим выделения полигонов!", "Turn off polygon select mod first!", "Schalte zuerst den Polygonauswahlmodus aus!", "Wpierw wyłącz tryb wyboru poligonów", "Nejprve vypněte režim výběru polygonu!" });
            AddNewWord("WIN_VOBCATALOG_ASKSURE_REMOVE_GROUP", new List<string> { "Вы уверены? Все вобы в группе будут удалены!", "Are you sure? All vobs in the group will be deleted!", "Bist du sicher? Alle VOBs in der Gruppe werden gelöscht!", "Jesteś pewien? Wszystkie voby w grubie zostaną skasowane!", "Jste si jistý? Všechny voby ve skupině budou smazány!" });
            AddNewWord("WIN_VOBCATALOG_IS_STATIC_VOB", new List<string> { "Статичный воб (isStatic): ", "Static vob (isStatic): ", "Statische VOB (isStatic): ", "Vob statyczny (isStatic): ", "Statický vob (isStatic): " });
            AddNewWord("WIN_VOBCATALOG_BAD_SYMBOL", new List<string> { "Нельзя использовать символ ;", "Symbol ; is not allowed here", "Symbol ; ist nicht erlaubt", "Znak ; nie jest dozwolony w tym miejscu", "Symbol ; zde není povolen" });
            AddNewWord("WIN_VOBCATALOG_HIDE_PREVIEW", new List<string> { "Скрывать 3D превью-модель при скрытии окна", "Hide 3D preview when window is hidden", "3D-Vorschau ausblenden, wenn das Fenster ausgeblendet ist", "Schowaj podgląd 3d gdy okno jest schowane", "Skrytí 3D náhledu při skrytém okně" });

            AddNewWord("WIN_VOBCATALOG_GROUPS", new List<string> { "Группы", "Groups", "Gruppen", "Grupy", "Skupiny" });
            AddNewWord("WIN_VOBCATALOG_ITEMS", new List<string> { "Элементы", "Entries", "Einträge", "Wpisy", "Záznamy" });
            AddNewWord("WIN_VOBCATALOG_ACTIONS", new List<string> { "Действия", "Actions", "Aktionen", "Akcje", "Akce" });

            AddNewWord("WIN_VOBCATALOG_ALL_COUNT", new List<string> { "Всего объектов: ", "Objects amount: ", "Objektanzahl: ", "Ilość obiektów: ", "Počet objektů: " });
            AddNewWord("WIN_VOBCATALOG_SEARCH", new List<string> { "Поиск: ", "Search: ", "Suche: ", "Szukaj: ", "Hledat: " });

            AddNewWord("WIN_VOBCATALOG_BUTTON_SAVE", new List<string> { "Сохранить копию базы каталога", "Save a copy of Vob Catalog", "Eine Kopie des VOB-Katalogs speichern", "Zapisz kopie katalogu vobów", "Uložit kopii Katalogu Vobů" });
            AddNewWord("WIN_VOBCATALOG_SAVED_COPY", new List<string> { "Создана копия базы каталога, сохранено по пути: _work/tools/vobcatalog_backups/", "A copy of the catalog database has been created and saved to the path: _work/tools/vobcatalog_backups/", "Es wurde eine Kopie der Katalogdatenbank erstellt und in dem Pfad gespeichert: _work/tools/vobcatalog_backups/", "Kopia katalogu vobów została utworzona i zapisana w ścieżce: _work/tools/vobcatalog_backups/", "Byla vytvořena kopie databáze katalogu a uložena do cesty: _work/tools/vobcatalog_backups/" });

            AddNewWord("WIN_VOBCATALOG_BTN_ADD_GROUP_NEW", new List<string> { "Добавить новую группу", "Add new group", "Neue Gruppe hinzufügen", "Dodaj nową grupę", "Přidat novou skupinu" });
            AddNewWord("WIN_VOBCATALOG_BTN_RENAME_GROUP", new List<string> { "Переименовать группу", "Rename group", "Gruppe umbenennen", "Zmień nazwę grupy", "Přejmenovat skupinu" });
            AddNewWord("WIN_VOBCATALOG_BTN_REMOVE_GROUP", new List<string> { "Удалить группу", "Delete group", "Gruppe löschen", "Usuń grupę", "Odstranit skupinu" });


            AddNewWord("WIN_VOBCATALOG_BTN_ELEM_ADD", new List<string> { "Добавить новый", "Add new", "Neu hinzufügen", "Dodaj nowe", "Přidat nový" });
            AddNewWord("WIN_VOBCATALOG_BTN_ELEM_EDIT", new List<string> { "Изменить", "Edit", "Bearbeiten", "Edytuj", "Editovat" });
            AddNewWord("WIN_VOBCATALOG_BTN_ELEM_REMOVE", new List<string> { "Удалить", "Remove", "Entfernen", "Usuń", "Odstranit" });

            AddNewWord("WIN_VOBCATALOG_IN_CURRENT_GROUP", new List<string> { "В выделенной группе: ", "In selected group: ", "In ausgewählter Gruppe: ", "W zaznaczonej grupie: ", "Ve vybrané skupině: " });

            AddNewWord("WIN_VOBCATALOG_ASKSURE_REMOVE_DEBUG", new List<string> { "Данная функция удалит все вобы (zCVob) в локации, визуалы которых есть в Каталоге вобов. Это удобная функция при заполнении Каталога. Разумеется, вы не должны сохранять локацию после удаления вобов. Продолжить?", "This function will delete all vobs (zCVobs) in locations whose visuals are in the Vob Catalog. This is a convenient function when filling out the Catalog. Of course, you should not save the location after removing the vobs. Continue?", "Mit dieser Funktion werden alle VOBs (zCVobs) an Orten gelöscht, deren Bildmaterial im VOB-Katalog enthalten ist. Das ist eine praktische Funktion, wenn du den Katalog ausfüllst. Natürlich solltest du den Ort nach dem Löschen der VOBs nicht speichern. Weiter?", "a funkcja usunie wszystkie voby (zCVobs) w lokalizacjach, których wizualizacje znajdują się w katalogu Vob. Jest to wygodna funkcja podczas wypełniania Katalogu. Oczywiście nie należy zapisywać lokalizacji po usunięciu vobów. Kontynuować?", "Tato funkce odstraní všechny voby (zCVoby) v místech, jejichž vizuály jsou v Katalogu Vobů. Tato funkce je vhodná při vyplňování Katalogu. Po odstranění vobů byste samozřejmě neměli lokaci ukládat. Pokračovat?" });
            AddNewWord("WIN_VOBCATALOG_ASKSURE_CMD_MODELS", new List<string> { "Данная функция выведет в консоль визуалы вобов, для которых нет файлов моделей в VDF/_WORK. Продолжить?", "This function will display vobs' visuals for which there are no model files in VDF/_WORK to the console. Continue?", "Mit dieser Funktion werden visuelle VOBs, für die es keine Modelldateien in VDF/_WORK gibt, auf der Konsole angezeigt. Weiter?", "Ta funkcja wyświetli na konsoli wizualne voby, dla których nie ma plików modelu w VDF/_WORK. Kontynuować?", "Tato funkce zobrazí vizuální voby pro které neexistují modelové soubory ve složce VDF/_WORK, do konzole. Pokračovat?" });
            AddNewWord("WIN_VOBCATALOG_ADV", new List<string> { "Продвинутые", "Advanced", "Erweitert", "Zaawansowane", "Pokročilé" });

            AddNewWord("WIN_VOBCATALOG_ADV_DONT_SEARCH", new List<string> { "Не показывать Вобы Каталога в глобальном поиске", "Don't show Catalog's vobs in global search", "Keine Katalog VOBs in allgemeiner Suche anzeigen", "Nie pokazuj vobsów Katalogu w wyszukiwaniu globalnym", "Nezobrazovat Katalog vobů v globálním vyhledávání" });
            AddNewWord("WIN_VOBCATALOG_ADV_REMOVE_VOBS", new List<string> { "Удалить вобы (подробнее)", "Remove vobs (more details)", "Entferne VOBs (mehr Details)", "Usuń voby (więcej szczegółów)", "Odstranění vobů (více informací)" });
            AddNewWord("WIN_VOBCATALOG_ADV_PRINT_MODELS", new List<string> { "Вывести список моделей (подробнее)", "Output models (more details)", "Ausgabe-Modelle (mehr Details)", "Modele wyjściowe (więcej szczegółów)", "Zobrazení seznamu modelů (více informací)" });



            AddNewWord("WIN_VOBCATALOG_COPY_VISUAL", new List<string> { "Скопировать визуал в другую группу...", "Copy visual to another group...", "Visuelles in eine andere Gruppe kopieren...", "Skopiuj visual do innej grupy...", "Zkopírovat vizuál do jiné skupiny..." });
            AddNewWord("WIN_VOBCATALOG_MOVE_VISUAL", new List<string> { "Переместить визуал в другую группу...", "Move visual to another group...", "Visuelles in eine andere Gruppe verschieben...", "Przenieś visual do innej grupy...", "Přesunout vizuál do jiné skupiny..." });

            AddNewWord("WIN_VOBCATALOG_MODE_COPY", new List<string> { "Режим: копирование в другую группу", "Mode: copying to another group", "Modus: Kopieren in eine andere Gruppe", "Tryb: kopiowanie do innej grupy", "Režim: kopírování do jiné skupiny" });
            AddNewWord("WIN_VOBCATALOG_MODE_MOVE", new List<string> { "Режим: перемещение в другую группу", "Mode: moving to another group", "Modus: Verschiebe in eine andere Gruppe", "Tryb: przeniesienie do innej grupy", "Režim: přesun do jiné skupiny" });
            AddNewWord("WIN_VOBCATALOG_MOVE_WIN_TITLE", new List<string> { "Настройки перемещения визуала", "Visual's moving settings", "Visuelle Bewegungseinstellungen", "Ustawienia poruszania visualem", "Nastavení pro přesun vizuálu" });
            AddNewWord("WIN_VOBCATALOG_MOVE_SELECT_GROUP", new List<string> { "Выберите группу:", "Select a group:", "Wähle eine Gruppe:", "Wybierz grupę:", "Výběr skupiny:" });
            AddNewWord("WIN_VOBCATALOG_GROUP_ERR_NO_SELECT", new List<string> { "Ни одна группа не выбрана или список пуст!", "No group selected or the list is empty!", "Keine Gruppe ausgewählt oder die Liste ist leer!", "Nie wybrano żadnej grupy lub lista jest pusta!", "Není vybrána žádná skupina nebo je seznam prázdný!" });
            AddNewWord("WIN_VOBCATALOG_GROUP_ERR_NO_VISUAL", new List<string> { "Пустой визуал!", "No visual found!", "Keine visuellen Objekte gefunden!", "Nie znaleziono visuala!", "Nebyl nalezen žádný vizuál!" });

            AddNewWord("WIN_VOBCATALOG_GROUP_ERR_ALREADY", new List<string> { "Такой визуал уже существует в данной группе!", "Such visual already exists in such group!", "Visuelles Objekt existiert bereits in dieser Gruppe", "Taki visual już istnieje w takiej grupie!", "Takový vizuál již v takové skupině existuje!" });


            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_FOCUS_NAME", new List<string> { "Такой 'focusName' не существует в скриптах", "Such 'focusName' does not exist in scripts", "Ein solcher 'focusName' existiert nicht in den Skripten", "Taki 'focusName' nie istnieje w skryptach", "Takový 'focusName' ve skriptech neexistuje" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_KEY_INSTANCE", new List<string> { "Такой 'keyInstance' не существует в скриптах", "Such 'keyInstance' does not exist in scripts", "Eine solche 'keyInstance' existiert nicht in den Skripten", "Taki 'keyInstance' nie istnieje w skryptach", "Taková 'keyInstance' ve skriptech neexistuje" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_CONTAINTER_ITEM", new List<string> { "Такой oCItem из 'contains' не существует в скриптах", "Such oCItem in 'contains' does not exist", "Ein solches oCItem in 'contains' existiert nicht", "Taki oCItem w 'contains' nie istnieje", "Takový oCItem v 'contains' neexistuje" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_SPACES_CONTAINER", new List<string> { "Поле 'contains' содержит пробелы", "Field 'contains' has spaces", "Feld 'contains' hat Leerzeichen", "Pole 'constains' zawiera spacje", "Pole 'contains' obsahuje mezery" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_SOUNDNAME", new List<string> { "Поле 'sndName' пустое", "Field 'sndName' is empty", "Feld 'sndName' ist leer", "Pole 'sndName' jest puste", "Pole 'sndName' je prázdné" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_SOUNDNAME_NOINST", new List<string> { "Прописанный sndName не существует в SFX.dat", "Such sndName does not exist in SFX.dat", "Ein solcher sndName existiert nicht in SFX.dat", "Takie sndName nie istnieje w SFX.dat", "Takový sndName v souboru SFX.dat neexistuje" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_CONTAINER_BAD_SYMBOLS", new List<string> { "Поле 'contains' содержит неверные символы", "Field 'contains' has bad symbols", "Feld 'contains' hat falsche Symbole", "Pole 'contains' zawiera nieprawidłowe symbole", "Pole 'contains' má špatné symboly" });



            AddNewWord("WIN_SPAWN_ASKSURE_REMOVE_GROUP", new List<string> { "Вы уверены? Все функции в пресете будут удалены!", "Are you sure? All functions in the preset will be deleted!", "Bist du sicher? Alle Funkionen in der Voreinstellung werden gelöscht!", "Czy na pewno? Wszystkie funkcje w presecie zostaną usunięte!", "Jste si jistý? Všechny funkce v předvolbě budou smazány!" });
            AddNewWord("WIN_SPAWN_FUNC_NAME", new List<string> { "Имя функции: ", "Function name: ", "Funktion Name: ", " Nazwa funkcji: ", "Název funkce: " });
            AddNewWord("WIN_SPAWN_NO_GROUP_SELECTED", new List<string> { "Сначала выберите любой пресет!", "Select any preset first!", "Wähle zuerst eine Voreinstellung aus!", " Wybierz najpierw pierwszy preset!", "Nejprve vyberte libovolnou předvolbu!" });
            AddNewWord("WIN_SPAWN_NO_HELP_VOBS", new List<string> { "Сначала включите режим показа help-вобов!", "Activate help vobs show mode!", "Aktiviere den Hilfe VOBs Anzeige Modus!", "Aktywuj tryb wyświetlania vobów pomocniczych!", "Aktivujte režim zobrazení nápovědy vobů!" });
            AddNewWord("WIN_SPAWN_RADIUS_RANGE", new List<string> { "Достустимый диапазон от 2000 до 25000", "Allowed range is from 2000 to 25000", "Der zulässige Bereich liegt zwischen 2000 und 25000", "Dozwolony zakres wynosi od 2000 do 25000", "Povolený rozsah je 2000 až 25000" });

            AddNewWord("WIN_OBJ_TAB8", new List<string> { "Спавн", "Spawn", "Spawn", "Spawn", "Spawn" });
            AddNewWord("WIN_SPAWN_PRESETS", new List<string> { "Пресеты", "Presets", "Voreinstellungen", "Presets", "Předvolby" });
            AddNewWord("WIN_SPAWN_SCRIPT_FUNCTIONS", new List<string> { "Скриптовые функции:", "Script functions:", "Skript Funktionen:", "Funkcje skryptu:", "Funkce skriptu:" });
            AddNewWord("WIN_SPAWN_LABEL_RADIUS", new List<string> { "Радиус показа: ", "Show radius: ", "Zeige Radius: ", "Pokaż promień: ", "Zobrazit poloměr: " });
            AddNewWord("WIN_SPAWN_BUTTON_RADIUS", new List<string> { "Установить", "Set", "Festlegen", "Ustaw", "Nastavit" });
            AddNewWord("WIN_SPAWN_BUTTON_CLEAR", new List<string> { "Очистить точки", "Clear points", "Lösche Punkte", "Wyczyść punkty", "Vymazat body" });
            AddNewWord("WIN_SPAWN_BUTTON_SHOW", new List<string> { "Показать точки спавна (WP/FP)", "Show spawn points (WP/FP)", "Spawnpunkte anzeigen (WB/FP)", "Pokaż punkty spawnu (WP/FP)", "Zobrazit spawn body (WP/FP)" });
            AddNewWord("WIN_SPAWN_GROUPBOX_FUNCTIONS", new List<string> { "Функции", "Functions", "Funktionen", "Funkcje", "Funkce" });

            AddNewWord("WIN_SPAWN_SAVE_FILE", new List<string> { "Сохранить файл пресетов", "Save presets file", "Speichere Voreinstellungsdatei", "Zapisz plik presets", "Uložení souboru předvoleb" });
            AddNewWord("WIN_SPAWN_ADD_NEW_FUNCTION", new List<string> { "Добавить новую", "Add new", "Neu hinzufügen", "Dodaj nowy", "Přidat nové" });
            AddNewWord("WIN_SPAWN_PRESET_NAME", new List<string> { "Имя пресета: ", "Preset name: ", "Vorsteinstellungsname: ", " Nazwa presetu: ", "Název předvolby: " });



            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_BAD_TRIGGER", new List<string> { "Указанный triggerTarget не существует", "Such 'triggerTarget' does not exist", "Ein solcher 'triggerTarget' existiert nicht", "Taki 'triggerTarget' nie istnieje", "Takový 'triggerTarget' neexistuje" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_BAD_USE_WITHITEM", new List<string> { "Указанный useWithItem не существует", "Such 'useWithItem' does not exist", "Ein solcher 'useWithItem' existiert nicht", "Taki 'useWithItem' nie istnieje", "Takový 'useWithItem' neexistuje" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_BAD_ON_STATE_FUNC", new List<string> { "Указанная функция onStateFunc не существует", "Such 'onStateFunc' function does not exist", "Die Funktion 'onStateFunc' existiert nicht", "Taka funkcja 'onStateFunc' nie istnieje", "Taková funkce 'onStateFunc' neexistuje" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_BAD_COND_FUNC", new List<string> { "Указанная функция conditionFunc не существует", "Such 'conditionFunc' function does not exist", "Die Funktion 'conditionFunc' existiert nicht", "Taka funkcja 'conditionFunc' nie istnieje", "Taková funkce 'conditionFunc' neexistuje" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_BAD_VISUAL_SYMBOLS", new List<string> { "'Visual' воба содержит подозрительные символы", "Vob's 'visual' contains unexpected symbols", "Das 'Visual' vom VOB enthält verdächtige Symbole", "Visual' voba zawiera nieoczekiwane symbole", "Vobův 'vizuál' obsahuje podezřelé symboly" });



            AddNewWord("checkBoxUpperCase", new List<string> { "Переводить некоторые поля вобов в верхний регистр при сохранении локации", "Make some vob's fields to upper case when saving a location", "Einige Felder der VOBs beim Speichern einer Location in Großbuchstaben umwandeln", "Podczas zapisywania lokalizacji zmień niektóre pola voba na wielkie litery", "Přeložit některá pole vobů do velkých písmen při ukládání lokace" });


            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_MOBCONT_BAD_LOCKSTRING", new List<string> { "Поле 'pickLockStr' может содержать только символы R или L", "The 'pickLockStr' field can only contain the characters R or L", "Das Feld 'pickLockStr' darf nur die Zeichen R oder L enthalten", "Pole 'pickLockStr' może zawierać tylko znaki R lub L", "Pole „pickLockStr“ může obsahovat pouze znaky R nebo L" });



            AddNewWord("WARNING_3DS_FAST_MODE", new List<string> { "3DS файл был загружен в 'Быстром режиме'", "3DS file was loaded with 'Fast mod'", "3DS-Datei wurde im 'Schnellmodus' geladen", "Plik 3DS został załadowany w szybkim trybie", "3DS soubor byl načten v „Rychlém Režimu“" });
            AddNewWord("TITLE_3DS_FAST_MODE", new List<string> { "Быстрый режим загрузки 3DS файла локации (дает +30% к скорости). Только для рабочих версий!", "Fast mod of loading 3DS location file (gives +30% speed of 3DS file loading time). Work versions of ZENs only!", "Schnellmodus für das Laden von 3DS-Dateien (bringt +30% Ladegeschwindigkeit). Nur für Arbeitsversionen!", "Szybki tryb ładowania plików 3DS (około +30% szybsze ładowanie plików 3DS). Tylko w wersji roboczej!", "Rychlý režim načítání 3DS souboru lokace (zvyšuje rychlost načítání 3DS souboru o 30 %). Pouze pracovní verze!" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_BBOX_AREA_WRONG_SIZE", new List<string> { "BBox (зона) этого воба имеет подозрительный размер", "Bbox size is unexpected", "BBox (Bereich) dieses Objekts hat eine verdächtige Größe", "Nieoczekiwany rozmiar Bboxa", "Velikost Bboxu je neočekávaná" });

            // angles
            AddNewWord("labelPitch", new List<string> { "Тангаж", "Pitch", "Pitch", "Pochylenie", "Náměr" });
            AddNewWord("labelYaw", new List<string> { "Рысканье", "Yaw", "Yaw", "Odchylenie", "Klopení" });
            AddNewWord("camSetCurPos", new List<string> { "Установить в поля ввода текущие координаты", "Set current coordinates into text fields", "Aktuelle Koordinaten in Feld eintragen", "Ustaw bieżące koordynaty do pól tekstowych", "Nastavit aktuální souřadnice do polí" });

            AddNewWord("WIN_CAM_SET_TO_BUFFER", new List<string> { "Скопировать введенные координаты в буфер", "Copy entered coordinates to clipboard", "Kopiere die eingegebenen Koordinaten in die Zwischenablage", "Skopiuj wprowadzone współrzędne do schowka", "Zkopírujte zadané souřadnice do schránky" });
            AddNewWord("VISUALINFO_COPY", new List<string> { "Ctrl+C, чтобы скопировать инфу в буфер", "Ctrl+C to copy the info to the clipboard", "Strg+C, um die Informationen in die Zwischenablage zu kopieren", "Ctrl+C, aby skopiować informacje do schowka", "Ctrl+C pro zkopírování informací do schránky" });



            AddNewWord("WORLD_COMPILED_PRE_WORK_WARN", new List<string> { "Мир скомпилирован. Не меняйте ничего, сначала сохраните и перезагрузите ZEN файл!", "The world is compiled. Don't change anything until you save and reload ZEN file!", "Die Welt ist kompiliert. Ändere nichts, bis du die ZEN-Datei speicherst und neu ladest!", "Świat jest skompilowany. Nie zmieniaj niczego, dopóki nie zapiszesz i nie wczytasz ponownie pliku ZEN!", "Svět je sestaven. Nic neměňte, dokud soubor ZEN neuložíte a znovu nenahrajete!" });
            AddNewWord("CONTEXTMENU_TREE_CREATE_CAMERA_START_POS", new List<string> { "Создать стартовую точку камеры VOB_SPACER_CAMERA_START", "Create VOB_SPACER_CAMERA_START vob", "VOB_SPACER_CAMERA_START vob erstellen", "Utwórz plik vob VOB_SPACER_CAMERA_START", "Vytvořit VOB_SPACER_CAMERA_START vob" });
            AddNewWord("WRONG_NOT_VOB_MOD", new List<string> { "Выбран неверный режим выделения!", "Wrong selection mode!", "Falscher Auswahlmodus!", "Nieprawidłowy tryb wyboru!", "Špatný režim výběru!" });
            AddNewWord("ERR_VOB_EXISTS", new List<string> { "Такой воб уже существует!", "Such vob is already exists!", "Eine solche Vob ist bereits vorhanden!", "Taki vob już istnieje!", "Takový vob již existuje!" });

            //not used
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_ITEM_PARENT", new List<string> { "Данный oCItem находится в другом вобе!", "This oCItem is inside another vob!", "Dieses oCItem befindet sich in einem anderen VOB!", "", "" });


            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_CHANGELEVEL_SPACE", new List<string> { "Поле levelName содержит пробел. Это критическая ошибка!", "Field levelName contains space symbol. This is a critical error!", "Das Feld levelName enthält Leerzeichen. Das ist ein kritischer Fehler!", "Pole levelName zawiera symbol spacji. Jest to błąd krytyczny!", "Pole levelName obsahuje symbol mezery. Jedná se o kritickou chybu!" });

            AddNewWord("UV_WIN_TITLE", new List<string> { "Окно поиска проблем в UV развертке", "Finding UV wrapping problems", "Suchfenster von UV-Mapping-Problemen", "Okno wyszukiwania problemów z mapowaniem UV", "Vyhledávání problémů s UV obalem" });
            AddNewWord("UV_WIN_DESCR_1", new List<string> { "Данный инструмент может найти проблемы в UV развертке в меше локации", "This tool can find problems in UV mapping in a location mesh", "Dieses Werkzeug kann Probleme im UV-Mapping eines Standort-Meshes finden", "To narzędzie może znaleźć problemy w mapowaniu UV w siatce mesha lokacji", "Tento nástroj dokáže najít problémy v mapování UV v síti umístění" });
            AddNewWord("UV_WIN_DESCR_2", new List<string> { "Внимание! Инструмент показывает ПРЕДПОЛАГАЕМЫЕ проблемы.", "Attention! The tool shows POTENTIAL problems.", "Achtung! Das Werkzeug zeigt MÖGLICHE Probleme an.", "Uwaga! To narzędzie pokazuje POTENCJALNE problemy.", "Pozor! Nástroj zobrazuje POTENCIÁLNÍ problémy." });
            AddNewWord("UV_WIN_DESCR_3", new List<string> { "UV развертку найденного полигона вы оцениваете визуально самостоятельно! ", "You must visually check the UV mapping of the found polygon!", "Du musst das UV-Mapping des gefundenen Polygons selbst visuell überprüfen!", "Należy wizualnie sprawdzić mapowanie UV znalezionego poligonu!", "Musíte vizuálně zkontrolovat UV mapování nalezeného polygonu!" });
            AddNewWord("UV_WIN_BUTTON_FIND_UV", new List<string> { "Найти проблемы UV", "Find UV problems", "UV-Probleme finden", "Znajdź problemy z UV", "Vyhledávání problémů s UV zářením" });
            AddNewWord("UV_WIN_MIN_AREA", new List<string> { "Минимальная площадь UV. Плохие развертки имеют значение ≤ 0.001", "Minimal UV area. Bad UV's have value ≤ 0.001", "Minimale UV-Fläche. Schlechte UVs haben einen Wert ≤ 0,001", "Minimalny zakres UV. Złe UV mają wartość ≤ 0.001", "" });
            AddNewWord("UV_WIN_MAX_AREA", new List<string> { "Максимальная площадь UV. Плохие развертки имеют значение ≥ 5 (не всегда)", "Max UV area. Bad UV's can have value ≥ 5 (not always)", "Maximale UV-Fläche. Schlechte UVs können einen Wert ≥ 5 haben (nicht immer)", "Maksymalny zakres UV. Złe UV mają wartość ≥ 5 (nie zawsze)", "" });
            AddNewWord("UV_WIN_MAX_ANGLE_DIST", new List<string> { "Угол искажения (от 1 до 179). Плохие развертки имеют значение ≥ 30 (не всегда)", "Distortion angle (from 0 to 179). Bad UV's can have value ≥ 30 (not always)", "Verzerrungswinkel (von 1 bis 179). Schlechte UVs können einen Wert ≥ 30 haben (nicht immer)", "Kąt zniekształcenia (od 0 do 179). Złe UV mogą mieć wartość ≥ 30 (nie zawsze)", "" });
            AddNewWord("UV_WIN_IGNORE_NOCOLL", new List<string> { "Игнорировать материалы/полигоны без коллизии", "Ignore materials/polygons without collision", "Materialien/Polygone ohne Kollision ignorieren", "Ignoruj materiały/poligony bez kolizji", "" });
            AddNewWord("UV_WIN_POLY_SELECT_MUST_BE_ON", new List<string> { "Сначала ВКЛЮЧИТЕ режим выделения полигонов!", "Turn ON polygon select mod first!", "Schalte zuerst den Polygon-Auswahlmodus EIN!", "Najpierw włącz tryb zaznaczania poligonów!", "" });
            AddNewWord("UV_WIN_SLIDER_DIST", new List<string> { "Радиус отрисовки 'плохих' полигонов: ", "Draw distance of 'bad' polygons: ", "Darstellungsradius der „schlechten“ Polygone: ", "Zasięg rysowania 'złych' poligonów: ", "" });

            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_VISUAL_SPACE", new List<string> { "В поле 'visual' есть символ 'пробел'. Пробел можно удалить введя другой визуал воба, а затем вернув оригинальный без пробела.", "Field 'visual' contains space symbol. The space can be removed by entering a different visual and then returning the original one without the space symbol.", "Das Feld 'visual' enthält ein Leerzeichen. Das Leerzeichen kann entfernt werden, indem du ein anderes Visual eingibst und anschließend das ursprüngliche ohne Leerzeichen wiederherstellst.", "Pole 'visual' zawiera znak spacji. Spacja może zostać usunięta poprzez wprowadzenie innego visuala i przywróceniu oryginalnego bez znaku spacji.", "" });


            AddNewWord("checkBoxDisableUpper", new List<string> { "Запретить переводить значения свойств воба в верхний регистр", "Disable converting vob's fields to uppercase", "Verhindert die Umwandlung von Vob-Feldern in Großbuchstaben", "Wyłacz konwersje nazw pól voba do DUŻYCH LITER", "" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_TRIGGER_SCRIPT_FUNC", new List<string> { "Функция в поле 'scriptFunc' не существует в скриптах", "Function in field 'scriptFunc' does not exist in scripts", "Die Funktion im Feld 'scriptFunc' existiert nicht in den Skripten", "Funkcja użyta w polu 'scriptFunc' nie jest zdefiniowana w skryptach", "" });

            AddNewWord("WIN_VOBCATALOG_COMPARE_BUTTON", new List<string> { "Сравнить динам. коллизию", "Compare dyn. collision", "Dynamische Kollision vergleichen", "Porównaj dynamiczną kolizje", "" });
            AddNewWord("WIN_VOBCATALOG_COMPARE_COLL_TITLE", new List<string> { "Данная функция сравнит динамическую коллизию всех объектов с базой Каталога. Если коллизия не совпадает, то воб будет показан красной линией. Если воба вообще нет в каталоге, то линия будет зеленая. Список подозрительных визуалов будет выведен в консоль.", "This function will compare the dynamic collision of all objects with the Catalog base. If the collision does not match, the vob will be shown as a red line. If the vob is not in the Catalog at all, the line will be green. The list of suspicious visuals will be output to the console.", "Diese Funktion vergleicht die dynamische Kollision aller Objekte mit der Katalogbasis. Wenn die Kollision nicht übereinstimmt, wird der Vob als rote Linie angezeigt. Falls der Vob überhaupt nicht im Katalog vorhanden ist, erscheint die Linie grün. Eine Liste verdächtiger Visuals wird in der Konsole ausgegeben.", "Ta funkcja porówna dynamiczną kolizje wszystkich obiektów z bazą z Katalogu. Jeśli kolizje nie będą się zgadzały, na pozycji voba zostanie wyświetlona czerwona pionowa linia. Jeśli vob nie znajduje się w Katalogu, na pozycji voba zostanie wyświetlona zielona pionowa linia. Lista podejrzanych visuali zostanie wyświetlona w konsoli.", "" });


            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_TGA_DYNCOLL", new List<string> { "У воба c TGA визуалом динамическая коллизия. Вы уверены?", "Vob with TGA visual has dynamic collision. Are you sure?", "Der Vob mit einem TGA-Visual hat eine dynamische Kollision. Bist du sicher?", "Vob z visualem TGA ma dynamiczną kolizje. Jesteś pewien?", "" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_PFX_CANT_HAVE_DYNCOLL", new List<string> { "У PFX не может быть динамической коллизии!", "PFX can't have dynamic collision!", "Ein PFX kann keine dynamische Kollision haben!", "PFX nie może mieć dynamicznej kolizji!", "" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_BAD_ZFARVOB", new List<string> { "Подозрительное значение поля 'vobFarClipZScale'. Оно должно быть от 0 до 3", "Suspicious value of field 'vobFarClipZScale'. It should be from 0 to 3", "Verdächtiger Wert im Feld 'vobFarClipZScale'. Er muss zwischen 0 und 3 liegen.", "Podejrzana wartość pola 'vobFarClipZScale'. Oczekiwana wartość w zakresie od 0 do 3", "" });

            AddNewWord("COLL_REPORT_ALL_BAD_COLL", new List<string> { "Всего найдено вобов: ", "Found vobs count: ", "Anzahl gefundener Vobs: ", "Ilość znalezionych vobów: ", "" });
            AddNewWord("COLL_REPORT_ALL_NOT_CATALOG", new List<string> { "Всего вобов вне Каталога: ", "Vobs which are not in Catalog: ", "Vobs außerhalb des Katalogs insgesamt: ", "Voby które nie znajdują się w Katalogu: ", "" });
            AddNewWord("REPORT_ALL_CONSOLE", new List<string> { "Информация выведена в консоль!", "All info is in console!", "Informationen wurden in der Konsole ausgegeben!", "Informacje znajdują się w konsoli!", "" });


            AddNewWord("ERROR_REPORT_AUTO_FIX_BUTTON", new List<string> { "Автоматически исправить", "Auto fix some problems", "Probleme automatisch beheben", "Napraw automatycznie", "" });
            AddNewWord("ERROR_REPORT_AUTO_FIX_DESCR", new List<string> { "Данная функция автоматически исправит некоторые проблемы, которые возможно исправить автоматически. Например, проставить значение vobFarClipZScale, удалить лишнее имя из zCVob и т.д. Список исправленных вобов будет выведен в консоль.", "This function will automatically fix some problems that can be fixed automatically. For example, set the value vobFarClipZScale, remove the extra name from zCVob, etc. The list of fixed vobs will be output to the console.", "Diese Funktion behebt automatisch einige der Probleme, die automatisch korrigiert werden können. Zum Beispiel setzt sie den Wert von vobFarClipZScale, entfernt überflüssige Namen aus zCVob usw. Die Liste der korrigierten Vobs wird in der Konsole ausgegeben.", "Ta funkcja automatycznie naprawi niektóre problemy. Dla przykładu, ustawi prawidłową wartość dla pola vobFarClipZScale, usunie niepotrzebną nazwę z zCVob, itp. Lista naprawionych vobów zostanie wyświetlona w konsoli.", "" });




            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_WP_NOT_IN_WAYNET", new List<string> { "Waypoint не находится в Waynet сети! Удалите и пересоздайте WP: ", "Waypoint is not in the Waynet list! Remove and create it again: ", "Waypoint befindet sich nicht im Waynet-Netzwerk! Lösche und erstelle neu: ", "", "" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_WP_NO_CONNECTIONS", new List<string> { "Waypoint не имеет никаких связей с другими WP: ", "Waypoint has no connections with other waypoints: ", "Waypoint hat keine Verbindungen zu anderen Wegpunkten: ", "", "" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_LIGHT_CLOSE_TOGETHER", new List<string> { "zCVobLight расположены вплотную. Дубликат? ", "zCVobLight has almost the same position. A duplicate? ", "zCVobLight befindet sich fast an derselben Position. Ein Duplikat? ", "", "" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_LIGHT_DYNCOLL", new List<string> { "У zCVobLight не может быть динамической коллизии!", "zCVobLight can't have dynamic collision!", "zCVobLight darf keine dynamische Kollision haben!", "", "" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_MOB_NO_COLL", new List<string> { "У oCMob нет динамической коллизии: ", "oCMob does not have a dynamic collision: ", "oCMob hat keine dynamische Kollision: ", "", "" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_STATIC_LIGHT_NO_PORTAL", new List<string> { "zCVobLight находится вне портала и имеет значение lightStatic: TRUE. Возможно, это ошибка, но не обязательно.", "zCVobLight is not in a portal and it has lightStatic: TRUE. This may be a bug, but may be not.", "zCVobLight befindet sich außerhalb eines Portals und hat den Wert lightStatic: TRUE. Möglicherweise ein Fehler, aber nicht zwingend.", "", "" });


            AddNewWord("PFX_EDITOR_HIGHTLIGHT_FIELDS", new List<string> { "Подсвечивать основные поля", "Highlight important fields", "Wichtige Felder hervorheben", "", "" });
            AddNewWord("PFX_EDITOR_HIGHTLIGHT_LINE", new List<string> { "Подчеркивание", "Underline", "Unterstreichen", "", "" });
            AddNewWord("PFX_EDITOR_HIGHTLIGHT_BOLD", new List<string> { "Жирный шрифт", "Bold", "Fettschrift", "", "" });
            AddNewWord("PFX_EDITOR_HIGHTLIGHT_ITALIC", new List<string> { "Курсив", "Italic", "Kursiv", "", "" });
            AddNewWord("PFX_EDITOR_SHOW_MOTION_TYPE", new List<string> { "Движение эффекта", "Effect motion", "Effektbewegung", "", "" });

            AddNewWord("PFX_EDITOR_SHOW_MOTION_TYPE_STATIC", new List<string> { "Статичное", "Static", "Statisch", "", "" });
            AddNewWord("PFX_EDITOR_SHOW_MOTION_TYPE_CIRCLE", new List<string> { "Двигать по окружности", "Move in a circle", "Kreisförmig bewegen", "", "" });
            AddNewWord("PFX_EDITOR_SHOW_MOTION_TYPE_FORW", new List<string> { "Двигать вперед-назад", "Move forward/backward", "Vor- und zurückbewegen", "", "" });
            AddNewWord("PFX_EDITOR_SHOW_MOTION_TYPE_ROTATE", new List<string> { "Вращать вокруг вертикальной оси", "Rotate around vertical axis", "Um die vertikale Achse drehen", "", "" });
            AddNewWord("PFX_EDITOR_SHOW_MOTION_TYPE_FORW_ONLY", new List<string> { "Двигать только вперед", "Move forward only", "Nur vorwärts bewegen", "", "" });
            AddNewWord("PFX_EDITOR_SHOW_MOTION_SPEED", new List<string> { "Скорость: ", "Speed: ", "Geschwindigkeit: ", "", "" });
            AddNewWord("PFX_EDITOR_SAVE_ALL_FIELDS", new List<string> { "Сохранять в файл все поля PFX (даже пустые)", "Save all PFX fields in a file (even empty ones)", "Alle PFX-Felder in Datei speichern (auch leere)", "", "" });


            AddNewWord("LIGHT_EDITOR_SPHERE_TYPE_SPHERE", new List<string> { "Сфера", "Sphere", "Kugel", "", "" });
            AddNewWord("LIGHT_EDITOR_SPHERE_TYPE_ORBITS", new List<string> { "Орбиты", "Orbits", "Umlaufbahnen", "", "" });

            AddNewWord("FORM_ENTER_BAD_STRING_NOPFX", new List<string> { "Добавлять .PFX к имени не нужно!", "Don't add .PFX in the name!", "Füge kein .PFX zum Namen hinzu!", "", "" });
            AddNewWord("PFX_EDITOR_NEW_PFX_NAME", new List<string> { "Имя PFX эффекта: ", "PFX name: ", "Name des PFX-Effekts: ", "", "" });
            AddNewWord("PFX_EDITOR_NEW_CREATED", new List<string> { "Новый PFX успешно создан и выбран как текущий активный эффект", "New PFX was created and selected as active current one", "Neuer PFX wurde erstellt und als aktuell aktiver Effekt ausgewählt", "", "" });

            AddNewWord("checkBoxDx11Amb", new List<string> { "Внешнее освещения для dx11. NumPad+- для изменения радиуса", "Ambient light source for dx11. NumPad+- for radius change", "Umgebungslichtquelle für dx11. NumPad+- zum Ändern des Radius", "", "" });

            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_DECAL_BAD_BLEND", new List<string> { "У декали не настроен decalAlphaFunc", "Decal vob does not have decalAlphaFunc configured", "Decal-Vob hat keine decalAlphaFunc-Konfiguration", "", "" });




            AddNewWord("MSG_COMMON_CANT_SAVE_OUTSIDE", new List<string> { "Сохранять файлы можно только внутри папки _WORK/DATA", "You can save files only inside _WORK/DATA folder!", "Du kannst Dateien nur im Ordner _WORK/DATA speichern!", "", "" });
            AddNewWord("MSG_COMMON_FILE_PATH_SAVE_VOB_MESH", new List<string> { "Сохранять MESH вобов можно только внутри папки _WORK/DATA/MESHES/", "You can save vob's mesh only inside _WORK/DATA/MESHES/ folder!", "Du kannst VOB Meshes nur im Ordner _WORK/DATA/MESHES/ speichern!", "", "" });
            AddNewWord("MSG_COMMON_FILE_PATH_SAVE_LOCATION_MESH", new List<string> { "Сохранять MESH локации можно только внутри папки _WORK/DATA/MESHES/", "You can save location mesh only inside _WORK/DATA/MESHES/ folder!", "Du kannst Location Meshes nur im Ordner _WORK/DATA/MESHES/ speichern!", "", "" });


            AddNewWord("checkBoxSkipPolysCut", new List<string> { "Не удалять 'Лишние' полигоны в локации (если отключено, могут быть дырки в меше локации)", "Do not delete 'Redundant' polygons in the location (if disabled, there may be holes in the mesh of the location)", "Lösche keine „Redundanten“ Polygone im Gebiet (wenn deaktiviert, könnten Löcher im Mesh der Umgebung entstehen)", "", "" });

            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_MAT_NOT_UNIQ_MAT", new List<string> { "Кривой материал! Его имя не уникально и эти материалы используют разные текстуры!", "", "", "", "" });
            AddNewWord("VOB_CHANGE_POS_BLOCKED", new List<string> { "Текущий воб имеет вложенные вобы. Изменение позиции/вращения заблокировано!", "Current vob has children vobs. Changing position/rotation is blocked!", "Der aktuelle Vob hat Child-Vobs. Positions- oder Rotationsänderung ist gesperrt!", "", "" });
            AddNewWord("CHANGE_VOB_COMPLEX_MOVE", new List<string> { "Режим блокировки перемещения воба", "Vob blocking movement mod", "Modus zur Blockierung der Vob-Bewegung", "", "" });
            AddNewWord("COMMON_TURN_ON", new List<string> { "включен", "is on", "aktiviert", "", "" });
            AddNewWord("COMMON_TURN_OFF", new List<string> { "отключен", "is off", "deaktiviert", "", "" });


            AddNewWord("COMMON_WARN_NOT_USUAL_VISUAL", new List<string> { "Тип воба не zCVob, а его визуал 3DS или TGA. Вы уверены?", "The type of the vob is not zCVob, but its visual is 3DS or TGA. Are you sure?", "Der Typ des Vobs ist nicht zCVob, aber das Visual hat 3DS oder TGA. Bist du sicher?", "", "" });
            AddNewWord("COMMON_WARN_MEMORY_FULL", new List<string> { "Память начинается заканчиваться. Сохраните результат работы и перезапустите SpacerNET!", "Memory is starting to run out. Save your work and restart SpacerNET!", "Der Speicher geht langsam zur Neige. Speichere deine Arbeit und starte SpacerNET neu!", "", "" });
            AddNewWord("CANT_COPY_INITSELF_USUAL_VOB", new List<string> { "Нельзя скопировать и вставить воб в самого себя!", "Can't copy vob into itself!", "Kann VOB nicht in sich selbst kopieren!", "", "" });

            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_WP_NO_TOT", new List<string> { "В локации не существует Waypoint с именем TOT", "There is no TOT waypoint", "Es gibt keinen TOT-Wegpunkt", "", "" });


            AddNewWord("MENU_TOP_RAIN_COMMON", new List<string> { "Дождь", "Rain", "Regen", "Deszcz", "" });
            AddNewWord("MENU_TOP_RAIN_STOP", new List<string> { "Остановить дождь", "Stop rain", "Regen stoppen", "Zatrzymaj deszcz", "" });
            AddNewWord("MENU_TOP_RAIN_START_SMOOTHLY", new List<string> { "Запустить дождь (плавно)", "Start rain (smoothly)", "Regen (sanft) starten", "Rozpocznij deszcz (stopniowo)", "" });
            AddNewWord("MENU_TOP_RAIN_START_FULLY", new List<string> { "Запустить дождь (полностью)", "Start rain (fully)", "Regen (vollständig) starten", "Rozpocznij deszcz (natychmiastowo)", "" });


            AddNewWord("WIN_GRASS_SET_ON_VOB", new List<string> { "Ставить объекты на вобы", "Set objects on vobs", "Objekte auf VOBs platzieren", "", "" });
            AddNewWord("MISC_SETTINGS_NO_WORK_CHECK", new List<string> { "Не проверять путь загружаемого ZEN (игнорировать папку _WORK)", "Don't check path while loading ZEN (ignore _WORK folder)", "Beim Laden von ZEN den Pfad nicht prüfen (Ordner _WORK ignorieren)", "", "" });

            AddNewWord("UNION_VOB_UPSIDE_DOWN", new List<string> { "Воб успешно перевернут", "Vob has been flipped", "VOB wurde erfolgreich gedreht", "", "" });
            AddNewWord("KEYS_SET_UPSIDE_DOWN", new List<string> { "Перевернуть воб", "Flip vob upside down", "VOB drehen", "", "" });
            AddNewWord("WIN_CAMERA_AUTO_RENAME", new List<string> { "Авто-переименовывание ключей с пустыми именам", "Auto rename keys which have empty names", "VOB drehen", "Tasten mit leerem Namen automatisch umbenennen", "" });

            AddNewWord("WIN_GRASS_AUTO_HEIGHT", new List<string> { "Смещение по высоте (%)", "Vertical offset (%)", "Vertikaler Versatz (%)", "", "" });

            AddNewWord("WIN_GRASS_AUTO_HEIGHT_TYPE_0", new List<string> { "Ниже (-20%)", "Lower (-20%)", "Niedriger (-20%)", "", "" });
            AddNewWord("WIN_GRASS_AUTO_HEIGHT_TYPE_1", new List<string> { "Ниже (-15%)", "Lower (-15%)", "Niedriger (-15%)", "", "" });
            AddNewWord("WIN_GRASS_AUTO_HEIGHT_TYPE_2", new List<string> { "Ниже (-10%)", "Lower (-10%)", "Niedriger (-10%)", "", "" });
            AddNewWord("WIN_GRASS_AUTO_HEIGHT_TYPE_3", new List<string> { "Ниже (-5%)", "Lower (-5%)", "Niedriger (-5%)", "", "" });
            AddNewWord("WIN_GRASS_AUTO_HEIGHT_TYPE_4", new List<string> { "Не менять (0%)", "Default (0%)", "Standard (0%)", "", "" });
            AddNewWord("WIN_GRASS_AUTO_HEIGHT_TYPE_5", new List<string> { "Выше (+5%)", "Higher (+5%)", "Höher (+5%)", "", "" });
            AddNewWord("WIN_GRASS_AUTO_HEIGHT_TYPE_6", new List<string> { "Выше (+10%)", "Higher (+10%)", "Höher (+10%)", "", "" });
            AddNewWord("WIN_GRASS_AUTO_HEIGHT_TYPE_7", new List<string> { "Выше (+15%)", "Higher (+15%)", "Höher (+15%)", "", "" });
            AddNewWord("WIN_GRASS_AUTO_HEIGHT_TYPE_8", new List<string> { "Выше (+20%)", "Higher (+20%)", "Höher (+20%)", "", "" });


            AddNewWord("WIN_INFO_RENDER_TYPE", new List<string> { "Подсветить выбранный тип воба в рендере", "Highlight selected vob type in render", "Ausgewählten VOB-Typ im Render hervorheben", "Podświetl wybrany typ voba w renderze", "" });

            AddNewWord("MSG_ERR_BROKEN_ITEM", new List<string> { "В локации найден(ы) oCItem, которых нет в скриптах!", "Found oCItem(s) which are used, but not found in scripts.", "oCItem(s) gefunden, die verwendet werden, aber nicht in Skripten gefunden wurden.", "", "" });

            AddNewWord("MSG_NOT_SAVED_WARN", new List<string> { "Последнее сохранение локации было {0} минут назад!", "Last file save was {0} minutes ago!", "Die letzte Datei wurde vor {0} Minuten gespeichert!", "Ostatni zapis był {0} minut temu!", "" });
            AddNewWord("WIN_INFO_VOB_VISUAL", new List<string> { "Подсвечивать вобы с заданным визуалом", "Highlight vobs with such visual", "VOBs mit solchen visuellen Elementen hervorheben", "Podświetlaj voby o podanym wizualu", "" });


            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_MOBCONT_NOT_CLOSED", new List<string> { "oCMobContainer имеет locked = FALSE, но комбинация взлома или инстанция ключа установлены", "oCMobContainer has locked = FALSE, but a lock combination or key instance is set", "", "", "" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_MOBCONT_CLOSED_NO_KEY", new List<string> { "oCMobContainer имеет locked = TRUE, но комбинация взлома или инстанция ключа не прописаны", "oCMobContainer has locked = TRUE, but no lock combination or key instance is set", "", "", "" });


            AddNewWord("MSG_ERR_BROKEN_VISUAL_FILE", new List<string> { "В локации найден(ы) вобы, для которых не найден visual (модель или эффект). После сохранения их поля visual будут пустыми!", "Vob(s) were found in the location for which no visual (model/instance) file was found. After saving, their 'visual' fields will be empty!", "", "", "" });
            AddNewWord("MSG_LOAD_AUTOFIX_SPACE_IN_NAME", new List<string> { "Удаляю символ 'пробел' в имени визуала: ", "Removing symbol 'space' in visual name: ", "", "", "" });
            AddNewWord("MSG_LOAD_AUTOFIX_3DS_END", new List<string> { "Исправляю имя визуала у .3DS воба: ", "Fixing visual name in .3DS vob: ", "", "", "" });
            AddNewWord("MSG_LOAD_NO_VISUAL_FOUND", new List<string> { "(zCVob::SetVisual): Не найден визуал (в файлах/скриптах)", "(zCVob::SetVisual): No such visual found (in files/scripts)", "", "", "" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_SOUNDNAMEDAYTIME_NOINST", new List<string> { "Прописанный sndName2 (zCVobSoundDaytime) не существует в SFX.dat", "Such sndName2 (zCVobSoundDaytime) does not exist in SFX.dat", "Ein solcher sndName2 (zCVobSoundDaytime) existiert nicht in SFX.dat", "Takie sndName2 (zCVobSoundDaytime) nie istnieje w SFX.dat", "Takový sndName2 (zCVobSoundDaytime) v souboru SFX.dat neexistuje" });

            AddNewWord("MSG_ERR_NO_SUCH_VAR_ATALL", new List<string> { "Ошибка. Вы используете строку для 'focusname', которой не существует в скриптах: ", "Error: you use string for 'focusname' which does not exist in scripts: ", "", "", "" });
            AddNewWord("MSG_ERR_FOCUSNAME_BAD_TYPE", new List<string> { "Ошибка. Вы используете константу для 'focusname', которая в скриптах вообще не STRING (ошибка в типе данных): ", "Error: you use string for 'focusname' which IS NOT a string in scripts (type error): ", "", "", "" });
            AddNewWord("ERROR_REPORT_PROBLEM_TYPE_WP_HAS_CHILDREN", new List<string> { "У zCVobWaypoint есть вложенные вобы! Их быть не должно.", "zCVobWaypoint has child vob(s) inside itself. It should not be", "", "", "" });


            AddNewWord("COMMON_TIME_SYSTEM", new List<string> { "Текущее время: ", "Current time: ", "Aktuelle Zeit: ", "Aktualny czas: ", "" });

            
        }


    }
}
