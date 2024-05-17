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

            words.Add("appIsLoading", new List<string> { "Spacer.NET загружается...", "Spacer.NET is loading...", "Spacer.NET lädt", "Spacer.NET trwa ładowanie..." , "Spacer.NET se načítá..." });
            words.Add("appIsReady", new List<string> { "Программа готова к работе!", "The program is ready!", "Programm ist bereit!", "Program jest gotowy do pracy!" , "Program je připraven!" });
            words.Add("askSure", new List<string> { "Вы уверены?", "Are you sure?", "Bist du sicher?", "Czy jesteś pewny?" , "Jsi si jistý?" });
            words.Add("askReset", new List<string> { "Точно сбросить мир?", "Reset world?", "Welt zurücksetzen?", "Zresetować świat?" , "Resetovat svět?" });
            words.Add("confirmation", new List<string> { "Подтверждение", "Confirmation", "Bestätigen", "Potwierdzenie" , "Potvrzení" });
            words.Add("loadZen", new List<string> { "Идет загрузка ZEN...", "ZEN is loading...", "ZEN lädt...", "ZEN jest ładowany..." , "ZEN se načítá" });
            words.Add("isLoading", new List<string> { "загружается...", "is loading...", "lädt...", " jest ładowany..." , "se načítá..." });
            words.Add("compileZen", new List<string> { "Идет компиляция ZEN...", "Compiling ZEN...", "Kompilieren der ZEN...", @"Kompilowanie ZEN'a..." , "Kompilovování ZENu probíhá..." });
            words.Add("compileLight", new List<string> { "Идет компиляция света...", "Compiling light...", "Kompilieren von Licht...", "Kompilowanie światła..." , "Kompilování světla..." });
            words.Add("savingZen", new List<string> { "Идет сохранение ZEN...", "Saving ZEN...", "Speichere ZEN...", @"Zapisywanie ZEN'a..." , "Ukládání ZENu" });
            words.Add("waynetMsg", new List<string> { "Ошибки WayNet не найдены.", "No Waynet errors found.", "Keine Fehler im Waynet gefunden.", "Nie znaleziono błędów Waynetu." , "Nebyly nalezeny žádné chyby Waynetu." });

            words.Add("loadZenTime", new List<string> { "Загрузка ZEN выполнена за", "Loading ZEN time...", "Laden der ZEN dauerte...", @"Czas wczytywania ZEN'a..." , "Čas načítání ZENu..." });
            words.Add("saveZenTime", new List<string> { "Сохранение ZEN выполнено за", "Saving ZEN time...", "Speichern der ZEN dauerte", @"Czas zapisywania ZEN'a..." , "Čas ukládání ZENu..." });
            words.Add("loadMeshTime", new List<string> { "Загрузка MESH выполнена за", "Loading MESH time...", "Laden des MESH dauerte...", @"Czas wczytywania MESH'a..." , "Čas načítání MESHe..." });
            words.Add("mergeZenTime", new List<string> { "Объединение ZEN выполнено за", "Merging ZEN time...", "Zusammenfügen des MESH dauerte...", @"Czas zapisywania MESH'a..." , "Čas ukládání MESHe" });



            words.Add("MENU_TOP_FILE", new List<string> { "Файл", "File", "Datei", "Plik" , "Soubor" });
            words.Add("MENU_TOP_RESET", new List<string> { "Сбросить мир", "Reset world", "Welt zurücksetzen", "Zresetuj świat" , "Zresetuj świat", "Resetování světa" });
            words.Add("MENU_TOP_EXIT", new List<string> { "Выход", "Exit", "Beenden", "Zakończ" , "Ukončit" });
            words.Add("MENU_TOP_LANG", new List<string> { "Язык", "Language", "Sprache", "Język" , "Jazyk" });
            words.Add("MENU_TOP_HELP", new List<string> { "Помощь", "Help", "Hilfe", "Pomoc" , "Pomoc" });
            words.Add("MENU_TOP_SETTINGS", new List<string> { "Настройки", "Settings", "Einstellungen", "Ustawienia" , "Nastavení" });
            words.Add("MENU_TOP_WORLD", new List<string> { "Мир", "World", "Welt", "Świat" , "Svět" });
            words.Add("MENU_TOP_VIEW", new List<string> { "Вид", "View", "Ansicht", "Widok" , "Zobrazení" });

            words.Add("MENU_TOP_OPENZEN", new List<string> { "Открыть ZEN...", "Open ZEN...", "ZEN öffnen...", "Otwórz ZEN..." , "Otevřít ZEN..." });
            words.Add("MENU_TOP_MESH", new List<string> { "Открыть MESH...", "Open MESH...", "MESH öffnen...", "Otwórz MESH..." , "Otevřít MESH..." });
            words.Add("MENU_TOP_MERGE", new List<string> { "Объединить ZEN...", "Merge ZEN...", "ZEN zusammenfügen...", "Połącz ZEN..." , "Sloučit ZEN" });
            words.Add("MENU_TOP_SAVEZEN", new List<string> { "Сохранить ZEN...", "Save ZEN...", "ZEN speichern...", "Zapisz ZEN..." , "Uložit ZEN" });
            words.Add("MENU_TOP_ABOUT", new List<string> { "О программе", "About", "Über", "O programie" , "O programu" });

            words.Add("MENU_TOP_CAM", new List<string> { "Камера", "Camera", "Kamera", "Kamera" , "Kamera" });
            words.Add("MENU_TOP_CONTROLS", new List<string> { "Управление", "Controls", "Steuerung", "Sterowanie" , "Ovládání" });
            words.Add("MENU_TOP_MISC", new List<string> { "Прочее", "Misc", "Sonstiges", "Różne" , "Různé" });


            words.Add("MENU_TOP_VIEW_SHOW", new List<string> { "Показать", "Show", "Anzeigen", "Pokaż" , "Ukaž" });
            words.Add("MENU_TOP_VIEW_VOBS", new List<string> { "Вобы", "Vobs", "Vobs", "Voby" , "Voby" });
            words.Add("MENU_TOP_VIEW_WAYNET", new List<string> { "Сетка Waynet", "Waynet", "Wegpunkte", "Waynet" , "Waynet" });
            words.Add("MENU_TOP_VIEW_HELPER", new List<string> { "Help-вобы", "Help vobs", "Hilfs-Vobs", "Pomocnicze voby" , "Pomocné voby" });

            words.Add("MENU_TOP_VIEW_BBOX", new List<string> { "Показать все BBox", "Show all the BBoxes", "Alle BBoxen anzeigen", "Pokaż wszystkie BBoxy" , "Zobrazit všechny BBoxy" });
            words.Add("MENU_TOP_VIEW_INVIS", new List<string> { "Показать невидимые вобы", "Show invisible vobs", "Unsichtbare Vobs anzeigen", "Pokaż niewidzialne voby" , "Zobrazit neviditelné voby" });


            words.Add("MENU_TOP_COMPILE_LIGHT", new List<string> { "Компиляция света", "Compile light", "Licht kompilieren", "Kompiluj światło" , "Kompilace světla" });
            words.Add("MENU_TOP_COMPILE_WORLD", new List<string> { "Компиляция мира", "Compile world", "Welt kompilieren", "Kompiluj świat" , "Kompilace světa" });


            words.Add("MENU_TOP_CAM_ZERO", new List<string> { "Прыгнуть на 000 координаты", "Jump to 000 coordinates", "Springe zu 000 Koordinate", "Przeskocz do koordynatów: 000" , "Skočit na souřadnice 000" });

            words.Add("MENU_TOP_CAM_COORDS", new List<string> { "Ввести координаты", "Enter coordinates", "Koordinaten einfügen", "Wpisz koordynaty" , "Zadej souřadnice" });
            words.Add("MENU_TOP_DAYTIME", new List<string> { "Время суток", "Day time", "Tageszeit", "Pora dnia" , "Denní doba" });
            words.Add("MENU_TOP_MORN", new List<string> { "Утро (07:00)", "Morning (07:00)", "Morgens (07:00)", "Poranek (07:00)" , "Ráno (07:00)" });


            words.Add("MENU_TOP_NOON", new List<string> { "Обед (12:00)", "Midday (12:00)", "Mittags (12:00)", "Południe (12:00)" , "Poledne (12:00)" });
            words.Add("MENU_TOP_AFTERNOON", new List<string> { "Вечер (17:00)", "Evening (17:00)", "Abends (17:00)", "Wieczór (17:00)" , "Večer (17:00)" });
            words.Add("MENU_TOP_NIGHT", new List<string> { "Ночь (00:00)", "Night (00:00)", "Nachts (00:00)", "Noc (00:00)" , "Noc (00:00)" });
            words.Add("MENU_TOP_ANALYSE_WAYNET", new List<string> { "Анализ WayNet", "Analyze Waynet", "Wegpunkte analysieren", "Analizuj Waynet" , "Analyzuj Waynet" });
            words.Add("MENU_TOP_PLAY_THE_GAME", new List<string> { "Играть за героя", "Play the hero", "Spiele den Helden", "Zagraj bohaterem" , "Hrát za hrdinu" });
            words.Add("MENU_TOP_KEYSBINDS", new List<string> { "Сочетания клавиш", "Keys bindings", "Tastaturbelegung", "Przypisanie klawiszy" , "Nastavení kláves" });

            words.Add("MENU_TOP_HOVER_WININFO", new List<string> { "Окно информации", "Information window", "Infofenster", "Okno informacji" , "Informační okno" });
            words.Add("MENU_TOP_HOVER_WINOBJ", new List<string> { "Окно объектов", "Objects window", "Objektfenster", "Okno obiektów" , "Okno objektů" });
            words.Add("MENU_TOP_HOVER_WINSOUND", new List<string> { "Окно звуков", "Sounds window", "Soundfenster", "Okno dźwięków" , "Okno zvuků" });
            words.Add("MENU_TOP_HOVER_WINTREE", new List<string> { "Окно списка вобов", "All-vobs window", "Alle Vobs-Fenster", "Okno wszystkich obiektów" , "Okno všech vobů" });
            words.Add("MENU_TOP_HOVER_WINPROPS", new List<string> { "Окно свойств", "Properties window", "Eigenschaftsfenster", "Okno właściwości" , "Okno vlastností" });
            words.Add("MENU_TOP_HOVER_WINVOBLIST", new List<string> { "Окно воб-лист", "VobList window", "Voblisten-Fenster", "Okno listy vobów" , "Okno vob-listu" });



            words.Add("WIN_COMPLIGHT_TEXT", new List<string> { "Компиляция света", "Light compilation", "Licht kompilieren", "Kompilacja światła" , "Kompilace světla" });
            words.Add("WIN_COMPLIGHT_QUALITY", new List<string> { "Качество", "Quality", "Qualität", "Jakość" , "Kvalita" });
            words.Add("WIN_COMPLIGHT_COMPILEBUTTON", new List<string> { "Компилировать", "Compile", "Kompilieren", "Kompiluj" , "Kompilovat" });

            words.Add("WIN_INPUT", new List<string> { "Ввод", "Input", "Eingabe", "Wejście" , "Vstup" });
            words.Add("WIN_CANCEL_BUTTON", new List<string> { "Отмена", "Cancel", "Abbrechen", "Anuluj" , "Zrušit" });
            words.Add("WIN_COMPLIGHT_CLOSEBUTTON", new List<string> { "Закрыть", "Close", "Schließen", "Zamknij" , "Zavřít" });
            words.Add("WIN_COMPLIGHT_REGION", new List<string> { "Регион", "Region", "Region", "Region" , "Region" });
            words.Add("WIN_COMPLIGHT_QUALITY0", new List<string> { "Только вершины", "Vertexes only", "Nur Vertexes", "Tylko vertexy" , "Pouze vertexy" });
            words.Add("WIN_COMPLIGHT_QUALITY1", new List<string> { "Lightmaps (низкое)", "Lightmaps (low)", "Lightmaps (niedrig)", "Lightmapa (niska)" , "Lightmapy (nízké)" });
            words.Add("WIN_COMPLIGHT_QUALITY2", new List<string> { "Lightmaps (среднее)", "Lightmaps (medium)", "Lightmaps (mittel)", "Lightmapa (średnia)" , "Lightmapy (střední)" });
            words.Add("WIN_COMPLIGHT_QUALITY3", new List<string> { "Lightmaps (высокое)", "Lightmaps (high)", "Lightmaps (hoch)", "Lightmapa (wysoka)" , "Lightmapy (vysoké)" });

            words.Add("WIN_COMPLIGHT_COMPILECHECKBOX", new List<string> { "Компилировать регион", "Compile region", "Region kompilieren", "Kompiluj region" , "Kompilovat region" });


            words.Add("WIN_COMPLIGHT_METERS", new List<string> { "метров", "meters", "Meter", "metry" , "metry" });
            words.Add("WIN_COMPLIGHT_AROUNDCAM", new List<string> { "вокруг камеры", "around the camera", "um die Kamera", "na około kamery" , "kolem kamery" });


            words.Add("WIN_COMPWORLD_TEXT", new List<string> { "Компиляция мира", "World compilation", "Kompilation Welt", "Kompilacja świata" , "Kompilace světa" });
            words.Add("WIN_COMPWORLD_LOCTYPE", new List<string> { "Тип локации", "World type", "Welt Typ", "Typ świata" , "Typ světa" });

            words.Add("WIN_CAM_TEXT", new List<string> { "Камера", "Camera", "Kamera", "Kamera" , "Kamera" });
            words.Add("WIN_CAM_CLOSEWIN", new List<string> { "Закрывать окно при переходе", "Close the window after the jump", "Das Fenster nach dem Wechsel schließen", "Zamknij okno po skoku" , "Zavřít okno po skoku" });
            words.Add("WIN_CAM_GO", new List<string> { "Перейти", "Jump", "Wechsel", "Skok" , "Skok" });

            // UNION STRING
            words.Add("UNION_VOB_INSERTED", new List<string> { "Воб вставлен", "The vob inserted", "Vob eingefügt", "Vob został wklejony", "Vob vložen" });
            words.Add("UNION_VOB_AXIS_RESET", new List<string> { "Направление воба сброшено", "Vob axes were reset", "Richtung des Vobs geändert", "Osie Voba zostały zresetowane", "Osy Vobu resetovány" });
            words.Add("CANT_APPLY_PARENT", new List<string> { "Данный тип воба перенести в родителя нельзя!", "Can't insert this vob type into a parent vob!", "Dieses Vob kann nicht in die übergeordneten Vob eingefügt werden!", "Nie można dodać tego typu Voba jako nadrzędnego.", "Tento typ Vobu není možné přidat jako rodiče." });
            words.Add("PARENT_ERROR_OCITEM", new List<string> { "oCItem не может быть родителем!", "oCItem can't be a parent!", "oCItem kann nicht übergeornet sein!", "oCItem nie może być nadrzędny!", "oCItem nemůže být rodičem!" });
            words.Add("PARENT_CHANGE_OK", new List<string> { "Родитель для воба изменен!", "The parent has been changed", "Überordnung für Vob wurde geändert", "Vob nadrzędny został zmieniony", "Vob rodiče byl změněn" });
            words.Add("VOB_COPY_OK", new List<string> { "Воб скопирован", "Vob was copied", "Vob kopiert", "Vob został skopiowany", "Vob byl zkopírován" });
            words.Add("VOB_CUT_OK", new List<string> { "Воб вырезан", "Vob was cut", "Vob ausgeschnitten", "Vob został wycięty", "Vob by vystřižen" });
            words.Add("VOB_NEAR_CAMERA", new List<string> { "Воб вставлен перед камерой", "Vob inserted in front of the camera", "Vob vor die Kamera eingefügt", "Vob został stworzony na przeciwko kamery", "Vob vložen před kameru" });
            words.Add("TOOL_TRANS", new List<string> { "Выбран инструмент перемещение", "Tool: moving", "Werkzeug: Verschieben", "Narzędzie: Przemieszczanie", "Nástroj: přesun" });
            words.Add("TOOL_ROT", new List<string> { "Выбран инструмент вращение", "Tool: rotation", "Werkzeug: Rotieren", "Narzędzie: Rotacja", "Nástroj: rotace" });
            words.Add("TOOL_UNSELECT", new List<string> { "Выделение воба снято", "Vob selection cancel", "Vobauswahl aufgehoben", "Wybranie voba zostało anulowane", "Výběr vobu byl zrušen" });
            words.Add("TOOL_FLOOR", new List<string> { "Прижимание воба к полу", "Try to floor the vob", "Vob am Boden fixieren", "Spróbuj postawić Voba na podłodze", "Zkusit položit Vob na podlahu" });
            words.Add("UNION_LIGHT_RAD_INC", new List<string> { "Радиус освещения увеличен", "Light radius increased", "Lichtradius erhöht", "Promień światła został zwiększony", "Rozsah světla zvýšen" });
            words.Add("UNION_LIGHT_RAD_DEC", new List<string> { "Радиус освещения уменьшен", "Light radius decreased", "Lichtradius verringert", "Promień światła został zmniejszony", "Rozsah světla snížen" });
            words.Add("UNION_LIGHT_RAD_ZERO", new List<string> { "Радиус освещения сброшен в 0", "Light radius set to 0", "Lichtradius auf 0 gesetzt", "Promień światła został ustawiony na 0", "Rozsah světla nastaven na 0" });
            words.Add("UNION_MESH_LOADED", new List<string> { "Меш загружен", "Mesh is loaded", "Mesh geladen", "Mesh jest załadowany", "Mesh je načten" });
            words.Add("UNION_MESH_READY", new List<string> { "Меш и вобы объединены. Скомпилируйте мир", "Mesh and vobs were merged. Compile the world", "Mesh und Vobs zusammengeführt. Bitte Welt kompilieren!", "Mesh i voby zostały połączone. Skompiluj świat.", "Meshe a Voby jsou sloučeny. Zkompiluj svět." });
            words.Add("UNION_EDITOR", new List<string> { "Редактор для ZenGin", "Editor for ZenGin", "Editor für ZenGin", "Edytor dla ZenGine", "Editor pro ZenGin" });
            words.Add("UNION_TEAM", new List<string> { "Разработчик: Liker. Помогали: Patrix & Haart & Saturas & Gratt & Jr", "Author: Liker. Assistance from: Patrix & Haart & Saturas & Gratt & Jr", "Entwicklerteam: Liker & Patrix & Haart & Saturas & Gratt & Jr", "Deweloperzy: Liker & Patrix & Haart & Saturas & Gratt & Jr", "Autoři: Liker & Patrix & Haart & Saturas & Gratt & Jr" });
            words.Add("UNION_DATE_COMPILE", new List<string> { "Дата компиляции: ", "Compilation date: ", "Datum der Kompilation: ", "Data kompilacji: ", "Datum kompilace" });
            words.Add("UNION_RESOLUTION", new List<string> { "Разрешение рендера: ", "Render resolution: ", "Rendererauflösung: ", "Rozdzielczość renderowania: ", "Rozlišení renderování" });
            words.Add("UNION_NOWORLD", new List<string> { "Мир не загружен", "World is not loaded", "Welt wurde nicht geladen", "Świat nie został wczytany.", "Svět nebyl načten" });
            words.Add("UNION_CANT_ABSTRACT", new List<string> { "Не могу создать объект абстрактного класса!", "Can't create a vob of an abstract class", "Kann keine vob von einer abstrakten Klasse erstellen!", "Nie można utworzyć voba klasy abstrakcyjnej", "Nemůžeš vytvořit vob s abstraktní třídou" });
            words.Add("ENTER_NAME", new List<string> { "Введите имя воба!", "Enter the name!", "Namen eingeben!", "Podaj nazwę!", "Zadej jméno" });
            words.Add("CANT_DELETE_LEVELCOMPO", new List<string> { "Не могу удалить zCVobLevelCompo!", "Can't remove zCVobLevelCompo!", "zCVVobLevelCompo kann nicht entfernt werden!", "Nie można usunąć zCVobLevelCompo!", "Nelze odstranit zCVobLevelCompo" });
            words.Add("CANT_DELETE_CAM", new List<string> { "Не могу удалить основную камеру!", "Can't remove the camera!", "Kamera kann nicht entfernt werden", "Nie można usunąć kamery!", "Nelze odstranit kameru!" });
            words.Add("UNION_NO_WAYPOINT", new List<string> { "Вейпоинт не выбран!", "No waypoint selected!", "Keinen Wegpunkt ausgewählt", @"Nie wybrano Waypointa", "Nevybrán žádný waypoint" });
            words.Add("UNION_NO_WAYPOINT_TEMPLATE", new List<string> { "Шаблон имени вейпоинта пуст!", "Waypoint name template is empty!", "Die Vorlage für den Wegpunktnamen ist leer!", "Nazwa szablonu Waypointów jest pusta!", "Jméno šablony waypointů je prázdné" });
            words.Add("UNION_WP_INSERT", new List<string> { "Вейпоинт вставлен: ", "Waypoint inserted: ", "Wegpunkt hinzugefügt:", "Dodano Waypoint: ", "Waypoint vložen" });
            words.Add("UNION_WORLD_ONCOMPILE", new List<string> { "Мир скомпилирован.", "World has been compiled.", "Welt wurde kompiliert.", "Świat został skompilowany.", "Svět byl zkompilován" });
            words.Add("UNION_VOBTREE_SAVE", new List<string> { "VobTree сохранен!", "VobTree saved!", "VobTree gespeichert!", "Drzewko vobów zostało zapisane!", "VobTree uložen!" });
            words.Add("UNION_VOBTREE_INSERT", new List<string> { "VobTree вставлен!", "VobTree inserted!", "VobTree eingefügt!", "Dodano drzewko vobów!", "VobTree vložen!" });
            words.Add("UNION_SHOW_TRIS", new List<string> { "Кол-во треугольников: ", "Tris amount: ", "Anzahl Tris: ", "Ilość trisów: ", "Množství trojúhelníků" });
            words.Add("UNION_CAM_POS", new List<string> { "Позиция камеры: ", "Camera pos: ", "Kameraposition: ", "Pozycja kamery: ", "Pozice kamery" });
            words.Add("UNION_VOB_COUNT", new List<string> { "Кол-во вобов: ", "Vobs amount: ", "Anzahl der Vobs: ", "Ilość vobów: ", "Počet Vobů" });
            words.Add("UNION_WP_COUNT", new List<string> { "Кол-во вейпоинтов: ", "Waypoint amount: ", "Anzahl der Wegpunkte: ", "Ilość waypointów: ", "Počet waypointů" });
            words.Add("UNION_DIST", new List<string> { "Дистанция: ", "Distance: ", "Entfernung: ", "Dystans: ", "Vzdálenost" });
            //NEW
            words.Add("WIN_COMPLIGHT_NOWORLD", new List<string> { "Мир не загружен!", "World is not loaded!", "Welt ist nicht geladen!", "Świat nie jest załadowany!", "Svět nebyl načten!" });
            words.Add("WIN_COMPLIGHT_NOWORLDCOMPILED", new List<string> { "Мир не скомпилирован!", "World is not compiled!", "Welt ist nicht kompiliert!", "Świat nie jest skompilowany!", "Svět není zkompilován!" });
            words.Add("WIN_COMPLIGHT_TIME", new List<string> { "Компиляция света выполнена за", "Light compilaton time", "Licht Kompilierungszeit", "Czas kompilacji światła", "Čas kompilace světla" });
            words.Add("WIN_COMPLIGHT_QUALITY0_COMP", new List<string> { "Компиляция (только вершины)", "Compilation (Vertexes only)", "Kompilierung (nur Vertexes)", "Kompilacja (Tylko Vertexy)", "Kompilace (Pouze Vertexy)" });
            words.Add("WIN_COMPLIGHT_QUALITY1_COMP", new List<string> { "Компиляция Lightmaps (низкое)", "Compilation Lightmaps (low)", "Kompilierung Lightmaps (niedrig)", "Kompilacja Lightmap (niskie)", "Kompilace Lightmap (nízké)" });
            words.Add("WIN_COMPLIGHT_QUALITY2_COMP", new List<string> { "Компиляция Lightmaps (среднее)", "Compilation Lightmaps (medium)", "Kompilierung Lightmaps (mittel)", "Kompilacja Lightmap (średnie)", "Kompilace Lightmap (střední)" });
            words.Add("WIN_COMPLIGHT_QUALITY3_COMP", new List<string> { "Компиляция Lightmaps (высокое)", "Compilation Lightmaps (high)", "Kompilierung Lightmaps (hoch)", "Kompilacja Lightmap (wysokie)", "Kompilace Lightmap (vysoké)" });
            words.Add("WIN_COMPWORLD_ALREADY_COMP", new List<string> { "Мир уже скомпилирован!", "World is already compiled!", "Welt wurde bereits kompiliert.", "Świat jest już skompilowany!", "Svět je již zkompilován!" });
            words.Add("WIN_COMPWORLD_COMPILING", new List<string> { "Мир компилируется...", "World is being compiled!", "Welt wird gerade kompiliert.", "Świat się kompiluje!", "Svět se kompiluje!" });
            words.Add("WIN_COMPWORLD_TIME", new List<string> { "Компиляция мира выполнена за", "World compiling time", "Welt Kompilierungszeit", "Czas kompilacji świata", "Čas kompilace světa" });
            words.Add("WIN_COMPWORLD_LEVELCOMPO", new List<string> { "Не забудьте удалить лишний zCVobLevelCompo!", "Don't forget to remove the spare zCVobLevelCompo", "Vergiss nicht den 'spare' zCVobLevelCompo zu entfernen", "Nie zapomnij usunąć zapasowego zCVobLevelCompo", "Nezapomeň odstranit náhradní zCVobLevelCompo" });
            words.Add("WIN_INFO_TITLE", new List<string> { "Окно информации", "Information window", "Informationsfenster", "Okno informacyjne", "Informační okno" });
            words.Add("WIN_INFO_CLEAR", new List<string> { "Очистить", "Clear", "Löschen", "Wyczyść", "Vyčistit" });
            words.Add("IS_SAVING", new List<string> { "сохраняется...", "is saving...", "wird gespeichert...", "zapisywanie...", "se ukládá..." });
            words.Add("WIN_CAM_GETFROMBUFFER", new List<string> { "Взять из буфера", "Get from clipboard", "Wird aus der Zwischenablage geholt", "Pobierz ze schowka", "Načtení ze schránky" });
            words.Add("BTN_APPLY", new List<string> { "Применить", "Apply", "Anwenden", "Zastosuj", "Použít" });
            words.Add("BTN_SAVE_CHANGES", new List<string> { "Сохранить изменения", "Save changes", "Änderungen speichern", "Zapisz zmiany", "Uložit změny" });
            words.Add("BTN_UP", new List<string> { "Вверх", "Up", "Hoch", "Góra", "Nahoru" });
            words.Add("BTN_DOWN", new List<string> { "Вниз", "Down", "Runter", "Dół", "Dolů" });
            words.Add("WIN_MISC_SET", new List<string> { "Прочие настройки", "Misc settings", "Verschiedene Einstellungen", "Inne ustawienia", "Další nastavení" });
            words.Add("checkBoxSetDatePrefix", new List<string> { "Добавлять префикс даты при сохранении зена", "Add DATE prefix to file when saving ZEN", "Füge Datum Präfix zu Datei hinzu wenn die ZEN gespeichert wird", "Dodaj prefix daty do nazwy zapisanego pliku", "Přidání prefixu datumu do názvu uloženého souboru" });
            words.Add("checkBoxMiscExitAsk", new List<string> { "Подтверждать выход если открыт зен", "Confirm exit if ZEN is opened", "Falls ZEN geöffnet ist, bestätige beenden des Editors", "Potwierdź wyjście, gdy ZEN jest otwarty", "Potvrzení ukončení, pokud je otevřen ZEN" });
            words.Add("checkBoxLastZenAuto", new List<string> { "Открывать последний ZEN автоматически", "Auto opening last ZEN", "Letzte ZEN automatisch öffnen", "Otwórz automatycznie ostatni świat", "Automaticky otevřít poslední ZEN" });
            words.Add("checkBoxMiscFullPath", new List<string> { "Писать полный путь до ZEN в главном окне", "Show full path to ZEN file in main window", "Zeige den vollständigen Pfad zur ZEN Datei im Hauptmenü an", "Pokaż pełną ścieżkę do świata w głównym oknie", "Zobrazení úplné cesty k souboru ZEN v hlavním okně" });
            words.Add("WIN_CONTROLSET_TEXT", new List<string> { "Настройки управления", "Controls setttings", "Steuerungseinstellungen", "Ustawienia sterowania", "Nastavení ovládání" });
            words.Add("WIN_CONTROLSET_TRANSSPEED", new List<string> { "Скорость перемещения: ", "Moving speed: ", "Bewegungsgeschwindigkeit: ", "Szybkość poruszania: ", "Rychlost pohybu:" });
            words.Add("WIN_CONTROLSET_ROTSPEED", new List<string> { "Скорость вращения: ", "Rotation speed: ", "Rotationsgeschiwndigkeit: ", "Szybkość rotacji: ", "Rychlost rotace:" });
            words.Add("WIN_CONTROLSET_GROUP0", new List<string> { "Управление вобом", "Vob control", "Vob Kontrolle", "Kontrola Voba", "Ovládání Vobu" });
            words.Add("WIN_CONTROLSET_GROUP1", new List<string> { "Вставка воба", "Vob insertion", "Vob Einfügung", "Wstawianie Voba", "Vkládání Vobu" });
            words.Add("checkBoxInsertVob", new List<string> { "Вставлять воб на той же высоте", "Insert vob on the same height", "Füge Vob in der Höhe der Quelle ein", "Wstaw voba na wysokości kamery", "Vložit Vob do výšky kamery" });
            words.Add("checkBoxVobRotRandAngle", new List<string> { "Поворачивать воб на случайный угол", "Turn vob on a random angle", "Versetze den Vob in einen zufälligen Winkel", "Obróć voba pod dowolnym kątem", "Otočit Vob v náhodném úhlu" });
            words.Add("checkBoxVobInsertHierarchy", new List<string> { "Учитывать иерархию при копировании", "Use hierarchy when copying", "Nutze die Hierachie beim Kopieren", "Użyj hierarchii podczas kopiowania", "Při kopírování použít hierarchii" });
            words.Add("labelRotWpFP", new List<string> { "Разворачивать WP/FP при вставке", "Turn WP/FP when inserting", "WP/FP beim Einfügen drehen", "Obróć WP/FP podczas dodawania", "Otočit WP/FP při vkládání" });
            words.Add("OPTION_CHECK_NONE", new List<string> { "Нет", "None ", "Keine ", "Brak", "Žádné" });
            words.Add("radioButtonWPTurnNone", new List<string> { "Нет", "None ", "Keine ", "Nie obracaj", "Žádné" });
            words.Add("radioButtonWPTurnAgainst", new List<string> { "От камеры", "From the camera", "Von der Kamera aus", "Z kamery", "Z kamery" });
            words.Add("radioButtonWPTurnOn", new List<string> { "На камеру", "At the camera", "Bei der Kamera", "Do kamery", "Do kamery" });
            words.Add("radioButtonWPTurnOnRandom", new List<string> { "Случайно", "Random", "Zufällig", "Losowo", "Náhodně" });
            words.Add("WIN_CONTROLCAM_TEXT", new List<string> { "Настройки камеры", "Camera settings", "Kameraeinstellungen", "Ustawienia kamery", "Nastavení kamery" });
            words.Add("groupBoxCam", new List<string> { "Камера", "Camera", "Kamera", "Kamera", "Kamera" });
            words.Add("labelTrans", new List<string> { "Скорость полета", "Moving speed", "Bewegungsgeschwindigkeit", "Prędkość poruszania", "Rychlost pohybu" });
            words.Add("labelRot", new List<string> { "Скорость повотора", "Rotation speed", "Rotationsgeschiwndigkeit", "Prędkość rotacji", "Rychlost rotace" });
            words.Add("groupBoxRange", new List<string> { "Прорисовка", "Rendering range", "Sichtweite", "Zasięg renderowania", "Rozsah renderování" });
            words.Add("labelWorld", new List<string> { "Мир", "World", "Welt", "Świat", "Svět" });
            words.Add("labelVobs", new List<string> { "Вобы", "Vobs", "Vobs", "Obiekty", "Voby" });
            words.Add("labelLimitFPS", new List<string> { "Ограничить FPS", "Limit FPS", "FPS Limit", "Limit FPS", "Limit FPS" });
            words.Add("groupBoxInfo", new List<string> { "Информация", "Information", "Information", "Informacje", "Informace" });
            words.Add("checkBoxFPS", new List<string> { "Показывать FPS", "Show FPS", "Zeige FPS", "Pokaż FPS", "Ukaž FPS" });
            words.Add("checkBoxTris", new List<string> { "Показывать кол-во рисуемых треугольников", "Show rendered triangles", "Zeige Anzahl gerenderter Tris.", "Pokaż ilość renderowanych trójkątów", "Zobrazit renderované trojúhelníky" });
            words.Add("checkBoxVobs", new List<string> { "Показывать кол-во вобов", "Show vobs count", "Zeige die Vobs Anzahl", "Pokaż ilość vobów", "Zobrazit počet vobů" });
            words.Add("checkBoxWaypoints", new List<string> { "Показывать кол-во вейпоинтов", "Show waypoints count", "Zeige die Wegpunktanzahl", "Pokaż ilość waypointów", "Zobrazit počet waypointů" });
            words.Add("checkBoxDistVob", new List<string> { "Показывать расстояние до выбранного воба", "Show distance to selected vob", "Zeige die Distanz zum ausgewählen Vob", "Pokaż dystans do zaznaczonego voba", "Zobrazit vzdálenost do vybraného vobu" });
            words.Add("checkBoxCameraHideWins", new List<string> { "Скрывать окна при полете камеры", "Hide windows when moving camera", "Verstecke die Menüs während der Kamerabewegung", "Ukryj okna podczas poruszania kamerą", "Skrýt okno když se kamera pohybuje" });
            words.Add("WIN_KEYSBIND_TEXT", new List<string> { "Сочетания клавиш", "Keys binding", "Tasteneinstellungen", "Przypisanie klawiszy", "Nastavení kláves" });
            words.Add("WIN_KEYSBIND_DESC", new List<string> { "Описание", "Description", "Beschreibung", "Opis", "Popis" });
            words.Add("WIN_KEYSBIND_BINDS", new List<string> { "Сочетание", "Bind", "Festlegen", "Powiązanie", "Přiřadit" });
            words.Add("WIN_KEYSBIND_KEY_SPACE", new List<string> { "Пробел", "Space", "Leertaste", "Spacja", "Mezerník" });
            words.Add("WIN_KEYSBIND_KEY_ARROW_LEFT", new List<string> { "Стрелка влево", "Arrow left", "linke Pfeiltaste", "Strzałka w lewo", "Šipka vlevo" });
            words.Add("WIN_KEYSBIND_KEY_ARROW_UP", new List<string> { "Стрелка вверх", "Arrow up", "obere Pfeiltaste", "Strzałka w górę", "Šipka nahoru" });
            words.Add("WIN_KEYSBIND_KEY_ARROW_RIGHT", new List<string> { "Стрелка вправо", "Arrow right", "rechte Pfeiltaste", "Strzałka w prawo", "Šipka vpravo" });
            words.Add("WIN_KEYSBIND_KEY_ARROW_DOWN", new List<string> { "Стрелка вниз", "Arrow down", "untere Pfeiltaste", "Strzałka w dół", "Šipka dolů" });
            words.Add("CAMERA_TRANS_FORWARD", new List<string> { "Камера (вперед)", "Camera (forward)", "Kamera (vorwärts)", "Kamera (do przodu)", "Kamera (dopředu)" });
            words.Add("CAMERA_TRANS_BACKWARD", new List<string> { "Камера (назад)", "Camera (backward)", "Kamera (rückwärts)", "Kamera (do tyłu)", "Kamera (dozadu)" });
            words.Add("CAMERA_TRANS_RIGHT", new List<string> { "Камера (вправо)", "Camera (right)", "Kamera (rechts)", "Kamera (w prawo)", "Kamera (doprava)" });
            words.Add("CAMERA_TRANS_LEFT", new List<string> { "Камера (влево)", "Camera (left)", "Kamera (links)", "Kamera (w lewo)", "Kamera (doleva)" });
            words.Add("CAMERA_TRANS_UP", new List<string> { "Камера (вверх)", "Camera (up)", "Kamera (oben)", "Kamera (do góry)", "Kamera (nahoru)" });
            words.Add("CAMERA_TRANS_DOWN", new List<string> { "Камера (вниз)", "Camera (down)", "Kamera (unten)", "Kamera (w dół)", "Kamera (dolů)" });
            words.Add("CAM_SPEED_X10", new List<string> { "Увеличить скорость полета камеры в 10 раз", "Increase camera moving speed x10", "Erhöhe Kamerageschwindigkeit x10", "Zwiększ prędkość kamery x10", "Zvýšení rychlosti kamery x10" });
            words.Add("CAM_SPEED_MINUS_10", new List<string> { "Уменьшить скорость полета камеры в 10 раз", "Decrease camera moving speed x10", "Verringere Kamerageschwindigkeit x10", "Zmniejsz prędkość kamery x10", "Snížení rychlosti kamery x10" });
            words.Add("VOB_COPY", new List<string> { "Скопировать воб", "Copy vob", "Kopiere Vob", "Kopiuj voba", "Kopírovat Vob" });
            words.Add("VOB_INSERT", new List<string> { "Вставить воб", "Insert vob", "Füge Vob ein", "Wklej voba", "Vložit Vob" });
            words.Add("VOB_CUT", new List<string> { "Вырезать воб (смена родителя)", "Cut vob (parent change)", "Schneide Vob aus (Elternwechsel)", "Wytnij voba (Zmiana nadrzędnego)", "Vyjmout vob (Změna rodiče)" });
            words.Add("VOB_FLOOR", new List<string> { "Прижать воб к полу", "Floor the vob", "Den Vob auf den Boden setzen", "Umieść voba na podłodze", "Umístit vob na podlahu" });
            words.Add("VOB_RESET_AXIS", new List<string> { "Сбросить направление воба по осям", "Reset axes of the vob", "Die Achse vom Vob resetten", "Zresetuj osie voba", "Resetování osy vobu" });
            words.Add("VOB_DELETE", new List<string> { "Удалить воб", "Remove vob", "Vob entfernen", "Usuń voba", "Odstranit vob" });
            words.Add("VOB_TRANSLATE", new List<string> { "Инструмент перемещение", "Tool moving", "Bewegungswerkzeug", "Narzędzie poruszania", "Nástroj pohybu" });
            words.Add("VOB_ROTATE", new List<string> { "Инструмент вращение", "Tool rotating", "Rotationswerkzeug", "Narzędzie rotacji", "Nástroj rotace" });
            words.Add("WP_TOGGLE", new List<string> { "Переключить соединение между вейпоинтами", "Toggle connection between waypoints", "Verbindung zwischen Wegpunkten umschalten", "Pokaż połączenia między Waypointami", "Přepínání spojení mezi Waypointy" });
            words.Add("VOB_DISABLE_SELECT", new List<string> { "Снять выделение с воба", "Unselect the vob", "Die Auswahl vom Vob aufheben", "Odznacz voba", "Odznačit vob" });
            words.Add("VOB_NEAR_CAM", new List<string> { "Переместить воб перед камерой", "Move vob in front of the camera", "Bewege den Vob vor die Kamera", "Przenieś voba przed kamerę", "Přesunout vob před kameru" });
            words.Add("VOB_TRANS_FORWARD", new List<string> { "Перемещение воба (вперед)", "Moving vob (forward)", "Bewege den Vob (vorwärts)", "Poruszanie voba (do przodu)", "Pohyb vobu (dopředu)" });
            words.Add("VOB_TRANS_BACKWARD", new List<string> { "Перемещение воба (назад)", "Moving vob (back)", "Bewege den Vob (rückwärts)", "Poruszanie voba (do tyłu)", "Pohyb vobu (dozadu)" });
            words.Add("VOB_TRANS_LEFT", new List<string> { "Перемещение воба (влево)", "Moving vob (left)", "Bewege den Vob (links)", "Poruszanie voba (w lewo)", "Pohyb vobu (doleva)" });
            words.Add("VOB_TRANS_RIGHT", new List<string> { "Перемещение воба (вправо)", "Moving vob (right)", "Bewege den Vob (rechts)", "Poruszanie voba (w prawo)", "Pohyb vobu (doprava)" });
            words.Add("VOB_TRANS_UP", new List<string> { "Перемещение воба (вверх)", "Moving vob (up)", "Bewege den Vob (oben)", "Poruszanie voba (w górę)", "Pohyb vobu (nahoru)" });
            words.Add("VOB_TRANS_DOWN", new List<string> { "Перемещение воба (вниз)", "Moving vob (down)", "Bewege den Vob (unten)", "Poruszanie voba (w dół)", "Pohyb vobu (dolů)" });
            words.Add("VOB_SPEED_X10", new List<string> { "Увеличить скорость перемещения/вращения воба в 10 раз", "Increase vob moving/rotating speed x10", "Erhöhe Vob Bewegungsgeschwindigkeit/Rotationsgeschiwndigkeit x10", "Zwiększ szybkość przemieszacznia i rotacji x10", "Zvýšení rychlosti pohybu/rotace vobu 10x" });
            words.Add("VOB_SPEED_MINUS_10", new List<string> { "Уменьшить скорость перемещения/вращения воба в 10 раз", "Decrease vob moving/rotating speed x10", "Verringere vob Bewegungsgeschwindigkeit/Rotationsgeschiwndigkeit x10", "Zmniejsz szybkość przemieszacznia i rotacji x10", "Snížení rychlosti pohybu/rotace vobu 10x" });
            words.Add("VOB_ROT_VERT_RIGHT", new List<string> { "Вращение воба вокруг верт. оси (по часовой стрелке)", "Rotating vob around vertical axis (clockwise)", "Den vob um die vertikale Achse rotieren lassen (Im Uhrzeigersinn)", "Obracanie voba w osi pionowej (zgodnie z wskazówkami zegara)", "Rotace vobu kolem svislé osy (ve směru hodinových ručiček)" });
            words.Add("VOB_ROT_VERT_LEFT", new List<string> { "Вращение воба вокруг верт. оси (против часовой стрелки)", "Rotating vob around vertical axis (counterclock-wise)", "Den vob um die vertikale Achse rotieren lassen (Gegen den Uhrzeigersinn)", "Obracanie voba w osi pionowej (przeciwnie do wskazówek zegara)", "Rotace vobu kolem svislé osy (proti směru hodinových ručiček)" });
            words.Add("VOB_ROT_FORWARD", new List<string> { "Вращение воба от себя", "Vob rotating from the camera", "Vob vor der Kamera rotieren lassen", "Rotacja voba od kamery", "Rotace vobu od kamery" });
            words.Add("VOB_ROT_BACK", new List<string> { "Вращение воба на себя", "Vob rotating at the camera", "Vob in der Kamera rotieren lassen", "Rotacja voba w kamerze", "Rotace vobu do kamery" });
            words.Add("VOB_ROT_RIGHT", new List<string> { "Вращение воба вправо", "Vob rotating to the right", "Vob rechtsherum rotieren lassen", "Rotacja voba w prawo", "Rotace vobu doprava" });
            words.Add("VOB_ROT_LEFT", new List<string> { "Вращение воба влево", "Vob rotating to the left", "Vob linksherum rotieren lassen", "Rotacja voba w lewo", "Rotace vobu doleva" });
            words.Add("VOBLIST_COLLECT", new List<string> { "Собрать вобы в окно Контейнер вобов", "Collect vobes in Vob-List window", "Alle vobs in der Vob-Liste sammeln", "Zbieraj voby w oknie listy-vobów", "Vybrat voby v okně Vob-Listu" });
            words.Add("WP_CREATEFAST", new List<string> { "Создать WP/FP по кнопке", "Create WP/FP", "WP/FP erstellen", "Utwórz WP/FP", "Vytvořit WP/FP" });
            words.Add("WIN_HIDEALL", new List<string> { "Скрыть все окна", "Hide all windows", "Alle Fenster verstecken", "Ukryj wszystkie okna", "Skrýt všechna okna" });
            words.Add("OPEN_CONTAINER", new List<string> { "Открыть содержимое контейнера oCMobContainer", "Open oCMobContainer container", "Öffne den oCMobContainer Container", "Otwórz kontener oCMobContainer", "Otevřít oCMobContainer kontejner" });
            words.Add("TOGGLE_BBOX", new List<string> { "Показать/Скрыть все BBox", "Show/Hide all the BBoxes", "Zeige/Verstecke alle BBoxen", "Pokaż/Ukryj wszystkie BBoxy", "Zobrazit/Skrýt všechny BBoxy" });
            words.Add("TOGGLE_INVIS", new List<string> { "Показать/Скрыть невидимые вобы", "Show/Hide invisible vobs", "Zeige/Verstecke alle unsichtbaren vobs", "Pokaż/Ukryj niewidzialne voby", "Zobrazit/Skrýt neviditelné voby" });
            words.Add("TOGGLE_VOBS", new List<string> { "Показать/Скрыть все вобы", "Show/Hide all vobs", "Zeige/Verstecke alle vobs", "Pokaż/Ukryj wszystkie voby", "Zobrazit/Skrýt všechny voby" });
            words.Add("TOGGLE_WAYNET", new List<string> { "Показать/Скрыть Waynet", "Show/Hide Waynet", "Zeige/Verstecke alle Wegpunkte", "Pokaż/Ukryj waynet", "Zobrazit/Skrýt Waynet" });
            words.Add("TOGGLE_HELPERS", new List<string> { "Показать/Скрыть help-вобы", "Show/Hide help vobs", "Zeige/Verstecke Hilfvobs", "Pokaż/Ukryj voby pomocnicze", "Zobrazit/Skrýt pomocné voby" });
            words.Add("WIN_TREE_TITLE", new List<string> { "Список объектов", "Objects list window", "Objektlisten Fenster", "Okno listy obiektów", "Okno listu objektů" });
            words.Add("buttonCollapse", new List<string> { "Свернуть все", "Collapse all", "Alle einklappen", "Ukryj wszystkie", "Sbalit vše" });
            words.Add("buttonExpand", new List<string> { "Развернуть все", "Expand all", "Alles ausklappen", "Rozwiń wszystkie", "Rozbalit vše" });
            words.Add("buttonTreeSort", new List<string> { "Сортировать", "Sort", "Sortieren", "Sortuj", "Seřadit" });
            words.Add("CONTEXTMENU_TREE_INSERT_VOBTREE_PARENT", new List<string> { "Вставить VobTree в выделенный воб", "Insert VobTree into the vob", "Einen Vobbaum in den Vob einfügen", "Dodaj Drzewko-Vobów do voba", "Vložit VobTree do vobu" });
            words.Add("CONTEXTMENU_TREE_INSERT_VOBTREE_GLOBAL", new List<string> { "Вставить VobTree глобально", "Insert VobTree globally", "Einen Vobbaum global einfügen", "Dodaj Drzewko-Vobów globalnie", "Vložit VobTree globálně" });
            words.Add("CONTEXTMENU_TREE_SAVE_VOBTREE", new List<string> { "Сохранить выделенный воб в VobTree", "Save vob as VobTree", "Vob als Vobbaum speichern", "Zapisz voba jako Drzewko-Vobów", "Uložit vob jako VobTree" });
            words.Add("CONTEXTMENU_TREE_REMOVE_VOB", new List<string> { "Удалить воб", "Remove the vob", "Vob entfernen", "Usuń voba", "Odstranit vob" });
            words.Add("WIN_VOBLIST_TITLE", new List<string> { "Контейнер вобов", "VobList window", "Vob-Liste", "Okno listy vobów", "Okno Vob listu" });
            words.Add("labelVobType", new List<string> { "Тип воба", "Vob type", "Vob Typ", "Typ voba", "Typ vobu" });
            words.Add("labelRadius", new List<string> { "Радиус поиска", "Search radius", "Suchradius", "Promień szukania", "Rozsah hledání" });
            words.Add("WIN_SOUND_TITLE", new List<string> { "Звуки и музыка", "Sounds and music window", "Sound und Musik Fenster", "Okno dźwięku i muzyki", "Okno zvuků a hudby" });
            words.Add("groupBoxSound", new List<string> { "Звуки", "Sounds", "Sounds", "Dźwięki", "Zvuky" });
            words.Add("groupBoxMusic", new List<string> { "Музыка", "Music", "Musik", "Muzyka", "Hudba" });
            words.Add("buttonPlaySound", new List<string> { "Воспроизвести", "Play", "Abspielen", "Odtwórz", "Hrát" });
            words.Add("labelAllSounds", new List<string> { "Все звуки. Кол-во", "All sound. Count", "Alle Sounds. Anzahl", "Wszystkie dźwięki. Ilość", "Všechny zvuky. Počet" });
            words.Add("labelSndList", new List<string> { "Поиск по рег. выражению", "Search using regex", "Suche mit regex", "Wyszukaj za pomocą wyrażenia regularnego", "Hledání skrze regex" });
            words.Add("buttonOffMusic", new List<string> { "Отключить музыку", "Turn off music", "Musik abschalten", "Wyłącz muzykę", "Vypnutí hudby" });
            words.Add("buttonMusicOn", new List<string> { "Включить музыку", "Turn on music", "Musik anschalten", "Włącz muzykę", "Zapnutí hudby" });
            words.Add("checkBoxShutMusic", new List<string> { "Отключать музыку при загрузке", "Shut music after world loaded", "Musik nach Welt laden Stummen", "Wyłącz muzykę po wczytaniu świata", "Vypnout hudbu po načtení světa" });
            words.Add("labelMusicVolume", new List<string> { "Громкость", "Volume", "Lautstärke", "Głośność", "Hlasitost" });
            words.Add("WIN_PROPS_TITLE", new List<string> { "Окно свойств", "Properties window", "Eigenschaftenfenster", "Okno właściwości", "Okno vlastností" });
            words.Add("buttonApplyOnVob", new List<string> { "Применить на вобе", "Apply on the vob", "Auf den vob anwenden", "Zastosuj dla voba", "Aplikovat na vob" });
            words.Add("buttonFileOpen", new List<string> { "Файл", "File", "Datei", "Plik", "Soubor" });
            words.Add("buttonRestoreVobProp", new List<string> { "Восстановить", "Restore", "Wiederherstellen", "Przywróć", "Obnovit" });
            words.Add("buttonOpenContainer", new List<string> { "Контейнер", "Container", "Container", "Kontener", "Kontejner" });
            words.Add("tabControlProps_0", new List<string> { "Редактирование", "Edit", "Editieren", "Edytuj", "Editovat" });
            words.Add("tabControlProps_1", new List<string> { "BBox", "Bbox", "Bbox", "BBox", "BBox" });
            words.Add("tabControlProps_2", new List<string> { "Контейнер", "Container", "Container", "Kontener", "Kontejner" });
            words.Add("groupBoxEditBbox", new List<string> { "Редактирование BBox", "Editing BBox", "BBox Bearbeitung", @"Edytuj BBox'y", "Editace BBoxu" });
            words.Add("NO_ITEM_NAME", new List<string> { "Имя вещи не может быть пустым! Строка: ", "Item name is empty! Row: ", "Itemname ist leer! Reihe:", "Nazwa przedmiotu jest pusta! Rząd: ", "Jméno předmětu je prázdné! Řádek:" });
            words.Add("NO_ITEM_COUNT", new List<string> { "Кол-во итемов не может быть пустым! Строка: ", "Item count is empty! Row: ", "Itemanzahl ist leer! Reihe:", "Ilość przedmiotów jest pusta! Rząd: ", "Počet předmětů je prázdný! Řádek:" });
            words.Add("ITEM_BAD_COUNT", new List<string> { "Некорректное число итемов. Строка: ", "Bad item count value! Row: ", "Falscher Itemanzahl Wert! Reihe:", "Zła wartość ilości przedmiotu! Rząd: ", "Špatná hodnota počtu předmětů! Řádek: " });
            words.Add("groupBoxContainer", new List<string> { "Редактирование BBox", "Editing BBox", "BBox Bearbeitung", @"Edytuj BBox'y", "Editace BBoxu" });
            words.Add("buttonClearItems", new List<string> { "Очистить все", "Clear all", "Alles löschen", "Wyczyść wszystkie", "Vyčistit vše" });
            words.Add("buttonRowDelete", new List<string> { "Удалить текущую", "Remove current", "Aktuelles entfernen", "Wyczyść obecny", "Odstranit stávající" });
            words.Add("ITEMS_COLUMN_INSTANCE", new List<string> { "Инстанция", "Instance", "Instanz", "Instancja", "Instance" });
            words.Add("ITEMS_COLUMN_COUNT", new List<string> { "Кол-во", "Count", "Anzahl", "Ilość", "Počet" });
            words.Add("WIN_OBJ_TITLE", new List<string> { "Окно объектов", "Objects window", "Objektfenster", "Okno obiektów", "Okno objektů" });
            words.Add("WIN_OBJ_TAB0", new List<string> { "Все классы", "All classes", "Alle Klassen", "Wszystkie klasy", "Všechny třídy" });
            words.Add("WIN_OBJ_TAB1", new List<string> { "Вещи", "Items", "Items", "Przedmioty", "Předmět" });
            words.Add("WIN_OBJ_TAB2", new List<string> { "Эффекты", "Particles", "Partikel", "Efekty cząsteczkowe", "Částice" });
            words.Add("WIN_OBJ_TAB3", new List<string> { "Триггеры", "Triggers", "Triggers", "Wyzwalacze", "Triggery" });
            words.Add("WIN_OBJ_TAB4", new List<string> { "WP/FP", "WP/FP", "WP/FP", "WP/FP", "WP/FP" });
            words.Add("WIN_OBJ_TAB5", new List<string> { "Поиск", "Search", "Suche", "Szukaj", "Hledat" });
            words.Add("WIN_OBJ_TAB6", new List<string> { "Камера", "Camera", "Kamera", "Kamera", "Kamera" });
            words.Add("WIN_OBJ_TAB7", new List<string> { "Свет", "Light", "Licht", "Światło", "Světlo" });
            words.Add("WIN_OBJ_ALLMODELS", new List<string> { "Поиск визуала", "Visual search", "Visuelle Suche", "Szukaj wyglądu", "Vizuální hledávání" });
            words.Add("WIN_OBJ_ALL", new List<string> { "всего", "count", "Anzahl", "ilość", "počet" });
            words.Add("WIN_OBJ_TYPE_CANTHERE", new List<string> { "Данный тип воба создается в отдельной вкладке справа!", "This vob type can be created in a special tab!", "Dieser Vob Typ kann in einem speziellen Tap erschaffen werden", "Ten typ voba może zostać dodany w specjalnej zakładce!", "Tento typ vobu lze vytvořit ve speciální kartě!" });
            words.Add("WIN_OBJ_NO_EMPTY_NAME", new List<string> { "Нельзя ввести пустое имя!", "You can't enter an empty name!", "Es kann kein leerer Name genutzt werden!", "Nie możesz podać pustej nazwy!", "Nelze zadat prázdné jméno!" });
            words.Add("WIN_OBJ_NO_WAYPOINT_NUMBERSONLY", new List<string> { "Имя вейпоинта не может состоять только из цифр!", "Waypoint can't have only numbers in its name!", "Ein Wegpunkte kann nicht nur Zahlen in seinem Namen enthalten", "Waypoint nie może mieć tylko liczb w nazwie!", "Waypoint nemůže mít v názvu pouze čísla!" });
            words.Add("WIN_OBJ_SEARCHVISUAL", new List<string> { "всего", "count", "Anzahl", "ilość", "počet" });
            words.Add("WIN_OBJ_SEARCHVISUAL_ALL", new List<string> { "Поиск визуала. Всего", "Visual search. Count", "Visuelle Suche. Anzahl", "Wyszukiwanie po wyglądzie. Ilość", "Vizuální hledání. Počet" });
            words.Add("COPYBUFFER", new List<string> { "Скопировано в буфер", "Copied to clipboard", "In die Zwischenablage kopieren", "Skopiowano do schowka", "Zkopírováno do schránky" });
            words.Add("groupBoxObjAllClasses", new List<string> { "Все классы вобов", "All vobs classes", "Alle Vob Klassen", "Wszystkie klasy vobów", "Všechny vob třídy" });
            words.Add("groupBoxObjPropVobs", new List<string> { "Свойства воба", "Vob properties", "Vob Eigenschaften", "Właściwości voba", "Vlastnosti vobu" });
            words.Add("labelObjAllClassesNameVob", new List<string> { "Имя воба", "Vob name", "Vob Name", "Nazwa voba", "Jméno vobu" });
            words.Add("buttonAllClassesCreateVob", new List<string> { "Создать Vob", "Create Vob", "Vob erstellen", "Utwórz voba", "Vytvořit vob" });
            words.Add("checkBoxDynStat", new List<string> { "Динамич. коллизия", "Dynamic collision", "Dynamische Kollision", "Kolizja dynamiczna", "Dynamická kolize" });
            words.Add("checkBoxStaStat", new List<string> { "Стат. коллизия", "Static collision", "Statische Kollision", "Kolizja statyczna", "Statická kolize" });
            words.Add("checkBoxShowPreview", new List<string> { "Показывать модель", "Show model preview", "Zeige Modelvorschau", "Pokaż podgląd modelu", "Zobrazit náhled modelu" });
            words.Add("checkBoxSearchOnly3DS", new List<string> { "Искать только 3DS", "Search only 3DS", "Suche nur in 3DS", "Szukaj tylko 3DS", "Hledej jen 3DS" });
            words.Add("buttonAllClassesClear", new List<string> { "Очистить", "Clear", "Löschen", "Wyczyść", "Vyčistit" });
            words.Add("groupBoxObjItems", new List<string> { "Предметы", "Items", "Items", "Przedmioty", "Předměty" });
            words.Add("buttonItemsCreate", new List<string> { "Создать Item", "Create Item", "Item erschaffen", "Utwórz przedmiot", "Vytvořit předmět" });
            words.Add("buttonAddContainer", new List<string> { "Добавить в контейнер->", "Add to container->", "Dem Contrainer hinzufügen->", "Dodaj do kontenera->", "Přidat do kontejneru->" });
            words.Add("groupBoxItemsCont", new List<string> { "Редактор сундука", "Edit the container", "Den Container bearbeiten", "Edytuj kontener", "Editovat kontejner" });
            words.Add("checkBoxItemShow", new List<string> { "Отображать вещь на экране", "Show model preview", "Zeige Modelvorschau", "Pokaż podgląd modelu", "Zobrazit náhled předmětu" });
            words.Add("labelItemsEditContCount", new List<string> { "Количество", "Count", "Anzahl", "Ilość", "Počet" });
            words.Add("labelItemsAllItems", new List<string> { "Все вещи игры", "All game items", "Alle Spielitems", "Wszystkie przedmioty z gry", "Všechny předměty hry" });
            words.Add("labelItemsFindReg", new List<string> { "Поиск по рег. выражению", "Search using regex", "Mit regex suchen", "Wyszukiwanie standardowe", "Hledání skrze regex" });
            words.Add("groupBoxPFX", new List<string> { "Эффекты частиц", "Particles", "Partikel", "Efekty cząsteczkowe", "Částice" });
            words.Add("buttonParticles", new List<string> { "Создать PFX", "Create PFX", "PFX erschaffen", "Utwórz PFX", "Vytvořit PFX" });
            words.Add("checkBoxShowPFXPreview", new List<string> { "Отображать эффект на экране", "Show PFX preview", "Zeige PFX Vorschau", "Pokaż podgląd PFX", "Zobrazit náhled PFX" });
            words.Add("labelAllPfx", new List<string> { "Все эффекты игры", "All game PFXes", "Alle Spiel PFXs", @"Wszystkie PFX'y z gry", "Všechny PFX hry" });
            words.Add("groupBoxTriggersVob", new List<string> { "Выбранный воб", "Selected vob", "Ausgewählter Vob", "Wybrany vob", "Vybraný vob" });
            words.Add("groupBoxTriggersKeys", new List<string> { "Ключи", "Keys", "Tasten", "Klucze", "Klávesy" });
            words.Add("buttonSendTrigger", new List<string> { "Запустить >>>", "Run >>>", "Starten >>>", "Uruchom >>>", "Spustit >>>" });
            words.Add("buttonTriggerCollectSources", new List<string> { "Собрать", "Collect", "Einsammeln", "Zbierz", "Sbírat" });
            words.Add("buttonNewKey", new List<string> { "Новый ключ", "New key", "Neuer Key", "Nowy klucz", "Nová klávesa" });
            words.Add("buttonRemoveKey", new List<string> { "Удалить ключ", "Remove key", "Key entfernen", "Usuń klucz", "Odstraň klávesu" });
            words.Add("labelTriggerName", new List<string> { "Триггер", "Trigger", "Trigger", "Wyzwalacze", "Trigger" });
            words.Add("labelTriggerCollision", new List<string> { "Коллизия", "Collision", "Kollision", "Kolizja", "Kolize" });
            words.Add("checkBoxDyn", new List<string> { "динамическая", "dynamic", "Dynamisch", "dynamiczna", "dynamické" });
            words.Add("checkBoxStat", new List<string> { "статическая", "static", "Statisch", "statyczna", "statické" });
            words.Add("radioButtonOverwrite", new List<string> { "перезаписать", "overwrite", "überschreiben", "nadpisz", "přepsat" });
            words.Add("labelTriggerInsert", new List<string> { "Вставить", "Insert key", "Taste einfügen", "Dodaj klucz", "Vložit klávesu" });
            words.Add("radioButtonAfter", new List<string> { "после", "after", "danach", "przed", "po" });
            words.Add("radioButtonBefore", new List<string> { "до", "before", "davor", "po", "před" });
            words.Add("labelTriggerTargets", new List<string> { "Цели (targets)", "Targets", "Ziele", "Cele", "Cíle" });
            words.Add("labelTriggersSources", new List<string> { "Источники (sources)", "Sources", "Quellen", "Źródła", "Zdroje" });
            words.Add("groupBoxWPFP", new List<string> { "Мировые точки", "World points", "Weltpunkte", "Punkty świata", "Body světa" });
            words.Add("labelNameWPMandatory", new List<string> { "Имя Waypoint (обязательно)", "Waypoint name (mandatory)", "Wegpunktname (verpflichtend)", "Nazwa waypointa (obowiązkowa)", "Jméno waypointu (povinné)" });
            words.Add("labelFreepointMandatory", new List<string> { "Имя Freepoint (обязательно)", "Freepoint name (mandatory)", "Freepoint Name (verpflichtend)", "Nazwa freepointa (obowiązkowa)", "Jméno freepointu (povinné)" });
            words.Add("checkBoxWayNet", new List<string> { "Сразу соединять в сеть", "Connect to waynet at once", "Einmalig dem Wegenetzwerk hinzufügen", "Połącz natychmiast z waynetem", "Připojit se k waynetu najednou" });
            words.Add("checkBoxWPAutoName", new List<string> { "Автогенерация имени", "Auto-generated name", "Automatischer Namengenerator", "Nazwa wygenerowana automatycznie", "Automaticky generovaný název" });
            words.Add("checkBoxFPGround", new List<string> { "Прижимать к земле", "Floor the freepoint", "Den Freepoint an den Boden haften", @"Połóż freepoint'a na podłodze", "Podlaha freepointu" });
            words.Add("checkBoxAutoNameFP", new List<string> { "Автогенерация имени", "Auto-generated name", "Automatischer Namengenerator", "Nazwa wygenerowana automatycznie", "Automaticky generovaný název" });
            words.Add("buttonWPCreate", new List<string> { "Создать Waypoint", "Create Waypoint", "Wegpunkt erstellen", "Utwórz Waypoint", "Vytvořit waypoint" });
            words.Add("buttonConnectWp", new List<string> { "Соединить WP", "Connect waypoints", "Wegpunkte verbinden", "Połącz Waypointy", "Spojit waypoint" });
            words.Add("buttonDisconnectWP", new List<string> { "Разъединить WP", "Disconnect waypoints", "Wegpunkte trennen", "Rozłącz Waypointy", "Odpojit waypoint" });
            words.Add("buttonFPCreate", new List<string> { "Создать Freepoint", "Create Freepoint", "Freepoint erstellen", "Utwórz Freepoint", "Vytvořit freepoint" });
            //NEW
            words.Add("labelCamSetSlerp", new List<string> { "Плавность поворота камеры", "Camera rotation smoothing", "Kameraroation glätten", "Wygładzenie rotacji kamery", "Vyhlazení otáčení kamery" });
            words.Add("keysResetDefault", new List<string> { "Сбросить по-умолчанию", "Reset default", "Einstellung zurückstellen", "Przywróć domyślne", "Obnovení výchozího nastavení" });
            words.Add("confirmText", new List<string> { "Вы уверены?", "Are you sure?", "Bist du dir sicher ?", "Jesteś pewny?", "Jsi si jistý?" });
            words.Add("MENU_TOP_MERGEMESH", new List<string> { "Объединить MESH...", "Merge MESH...", "MESH zusammenfügen...", "Połącz MESH...", "Sloučit MESH..." });
            words.Add("LIGHT_RAD_INC", new List<string> { "Увеличить радиус освещения", "Increase light radius", "Lichtradius erhöhen", "Zwiększ promień światła", "Zvětšit rozsah světla" });
            words.Add("LIGHT_RAD_DEC", new List<string> { "Уменьшить радиус освещения", "Decrease light radius", "Lichtradius verringern", "Zmniejsz promień światła", "Zmenšit rozsah světla" });
            words.Add("LIGHT_RAD_ZERO", new List<string> { "Сбросить радиус освещения", "Reset light radius to 0", "Lichtradius auf 0 setzen", "Zresetuj promień światła do wartości 0", "Resetování rozsahu světla na 0" });
            words.Add("checkBoxSelectMoveInsert", new List<string> { "Включать инструмент перемещение при вставке воба", "Select Moving tool after inserting a vob", "Bewegungswerkzeug auswählen, nachdem vob eingefügt worden ist", "Wybierz narzędzie przemieszczania przed dodaniem voba", "Výběr nástroje pohybu po vložení vobu" });
            words.Add("labelSpeedPreview", new List<string> { "Скорость вращения превью-модели", "Model preview rotation speed", "Rotationsgeschwindigkeit der Modelvorschau", "Prędkość rotacji podglądu", "Rychlost otáčení náhledu modelu" });
            words.Add("loadMeshTimeAll", new List<string> { "Общее время объединения всех мешей", "Total time of merging all the meshes", "Gesamtzeit um alle Meshes zu verschmelzen", @"Czałkowicy czas łączenia wszystkich mesh'y", "Celkový čas sloučení všech meshů" });
            words.Add("WORK_PATH_ERROR", new List<string> { "Вы пытаетесь загрузить файл, который не находится в папке _WORK/DATA/. Поместите файл внутрь игры!", "You are trying to load a file which is not in _WORK/DATA/. Place this file inside the game folder!", "Du versuchst eine Datei zu laden, welche nicht im _WORK/DATA/ Ordner ist. Kopiere die Datei zuerst in den Spieleordner!", "Próbujesz wczytać plik, który nie znajduje się w _WORK/DATA/. Umieść go w folderze gry!", "Pokoušíš se načíst soubor, který se nenachází v adresáři _WORK/DATA/. Umísti tento soubor do složky hry!" });
            words.Add("buttonStopAllSounds", new List<string> { "Заглушить все звуки", "Turn off all sounds", "Alle Sounds abschalten", "Wyłącz wszystkie dźwięki", "Vypnout všechny zvuky" });
            //
            words.Add("vobs_found_amount", new List<string> { "Найдено", "Found", "Gefunden", "Klasy vobów", "Nalezeno" });
            words.Add("all_vobs_classes", new List<string> { "Все классы вобов", "Vob classes", "Vob Klassen", "Szukaj w klasach pochodnych", "Vob třídy" });
            words.Add("search_derived", new List<string> { "Искать в дочерних классах", "Search in derived classes", "In der abgeleiteten Klasse suchen", "Szukaj w klasach pochodnych", "Hledání v odvozených třídách" });
            words.Add("search_use_regex", new List<string> { "Использовать рег. выражение", "Use regular expression", "Reguläre expression nutzen", "Użyj standardowego wyrażenia", "Použití regulárního výrazu" });
            words.Add("BTN_RESET", new List<string> { "Сбросить", "Reset", "Zurücksetzen", "Reset", "Reset" });
            words.Add("NAME_ALREADY_EXISTS", new List<string> { "Такое имя уже существует!", "This name already exists!", "Diesen Namen gibt es bereits!", "Ta nazwa jest już zajęta!", "Tenhle název již existuje!" });
            words.Add("Label_Backup", new List<string> { "Старое значение", "Old value", "Alter Wert", "Stara wartość", "Stará hodnota" });
            words.Add("SET_ANY_FIELD_SEARCH", new List<string> { "Выберите хотя бы одно поле!", "Select one field at least!", "Du musst zumindestens ein Feld auswählen!", "Wybierz przynajmniej jedno pole!", "Vyber alespoň jedno pole!" });
            words.Add("VOB_SEARCH_START", new List<string> { "Поиск вобов начался...", "Looking for vobs...", "Suche nach Vobs...", "Rozglądanie się za vobami...", "Hledání vobů..." });
            //
            words.Add("BAD_REGEX", new List<string> { "Введено некорректное регулярное выражение!", "Wrong regular expression!", "Falscher Regex eingeführt!", "Błędne wyrażenie regularne!", "Špatný regulární výraz!" });
            words.Add("VOB_SEARCH_TYPE0", new List<string> { "Искать", "Search", "Suchen", "Szukaj", "Hledat" });
            words.Add("VOB_SEARCH_REPLACEZEN", new List<string> { "Заменено вобов на VobTree: ", "Vobs replaced with VobTree: ", "Vobs mit Vobbaum ersetzt: ", "Voby zastąpione drzewkiem vobów: ", "Voby nahrazeny VobTree: " });
            words.Add("VOB_SEARCH_REMOVEVOBS", new List<string> { "Удалено вобов: ", "Vobs removed: ", "Vobs entfernt: ", "Usunięto voby: ", "Voby ostraněny:" });
            words.Add("NO_REPLACE_VOBTREE", new List<string> { "VobTree не выбран!", "No VobTree selected!", "Kein Vobbaum ausgewählt!", "Nie wybrano drzewka vobów!", "Žádný VobTree není vybrán!" });
            words.Add("VOB_SEARCH_CONVERT", new List<string> { "Преобразовано вобов: ", "Vobs converted: ", " Vobs konvertiert: ", "Przekonwertowane voby: ", "Konvertované voby" });
            words.Add("VOB_SEARCH_STOP", new List<string> { "Найдено вобов: ", "Vobs found: ", "Vobs gefunden: ", "Znalezione voby: ", "Nalezené voby" });
            words.Add("VOB_SEARCH_TYPE1", new List<string> { "Конвертировать", "Convert", "Konvertieren", "Konwertuj", "Konvertovat" });
            words.Add("VOB_SEARCH_TYPE2", new List<string> { "Заменить на VobTree", "Replace with VobTree", "Mit Vobbaum tauschen", "Zamień na drzewko vobów", "Nahrazení pomocí VobTree" });
            words.Add("VOB_SEARCH_TYPE3", new List<string> { "Удалить", "Remove", "Entfernen", "Usuń", "Odstranit" });
            words.Add("VOB_SEARCH_CONVERT_RADIO0", new List<string> { "Старый", "Old", "Alt", "Stary", "Starý" });
            words.Add("VOB_SEARCH_CONVERT_RADIO1", new List<string> { "Новый", "New", "Neu", "Nowy", "Nový" });
            words.Add("WARNING_VDF_FILE_OPEN", new List<string> { "Внимание! Файл был загружен из VDF/MOD, а не из _WORK/DATA!", "Warning! The file was loaded from VDF/MOD, not from _WORK/DATA!", "Achtung! Die Dati wurde von einer VDF/MOD und nicht vom _WORK/DATA geladen!", "Uwaga! Plik został załadowany z paczki VDF/MOD, nie z _WORK/DATA.", "Pozor! Soubor byl načten z VDF/MOD, nikoli z _WORK/DATA!" });
            words.Add("VOB_SEARCH_TYPE_RENAME", new List<string> { "Переименовать", "Rename", "Umbenennen", "Zmień nazwę", "Přejmenovat" });
            words.Add("VOB_SEARCH_RENAME_VOBS", new List<string> { "Переименовано вобов: ", "Vobs renamed: ", "Vobs umbeanannt: ", "Vobom zmieniono nazwę: ", "Přejmenované voby" });
            words.Add("labelRenameVob", new List<string> { "Новое имя", "New name", "Neuer Name", "Nowa nazwa", "Nové jméno" });
            words.Add("checkBoxAutoNumerate", new List<string> { "Авто-нумерация имен", "Auto numeration of names", "Automatische Nummerierung der Namen", "Automatycznie numeruj nazwy", "Automatické číslování jmen" });
            words.Add("MENU_TOP_VIEW_FREEZETIME", new List<string> { "Заморозить время", "Freeze time", "Ingamezeit einfrieren", "Zatrzymanie czasu", "Zamrznutí času" });
            words.Add("MENU_TOP_VIEW_POLYGON", new List<string> { "Выделение полигона", "Polygon select", "Polygonauswahl", "Wybór polygonu", "Výběr polygonu" });
            words.Add("MENU_TOP_VIEW_RENDERMODE", new List<string> { "Режим рендера", "Render mode", "Renderermodus", "Tryb renderowania", "Režim renderování" });
            words.Add("CHECK_BADPLUGINS_MSG", new List<string> { "У вас есть плагины, которые могут помешать работе Spacer.net!", "You have plugins which may not work with Spacer.net!", "Möglicherweise sind Plugins installiert, welche nicht mit Spacer.net kompatibel sind!", "Masz pluginy, które mogą nie działać poprawnie z Spacer.net", "Máte pluginy, které nemusí fungovat se Spacer.net!" });
            words.Add("WIN_GRASS_TITLE", new List<string> { "Сеятель объектов", "Objects sower", "Objektgenerator", "Generator obiektów", "Generátor objektů" });
            words.Add("WIN_GRASS_VOBMODEL", new List<string> { "Название модели воба:", "Vob's model:", "Vob Modell: ", "Model voba:", "Model vobů" });
            words.Add("WIN_GRASS_VERTOFFSET", new List<string> { "Смещение воба по вертикали: ", "Vob's vertical offset: ", "Vertikaler Versatz vom Vob: ", "Przesunięcie pionowe voba:", "Vertikální posun vobu:" });
            words.Add("WIN_GRASS_MINRADIUS", new List<string> { "Мин. расстояние между вобами: ", "Minimal distance between vobs: ", "Minimale Distanz zwischen Vobs: ", "Minimalny dystans pomiędzy vobami:", "Minimální vzdálenost mezi voby" });
            words.Add("VOB_SEARCH_TYPE_DYNAMIC", new List<string> { "Сменить динамич. коллизию", "Toggle dynamic collision", "Dynamische Kollision umschalten", "Przełącz dynamiczną kolizję", "Přepínání dynamických kolizí" });
            words.Add("VOB_SEARCH_DYNCOLL_VOBS", new List<string> { "Проставлено коллизий: ", "Collisions set: ", "Kollision eingestellt: ", "Ustawione kolizje:", "Nastavení kolizí:" });
            words.Add("MENU_TOP_SAVEZENUNC", new List<string> { "Сохранить Vobs", "Save Vobs", "Vobs Speichern", "Zapisz Voby", "Uložit voby" });
            words.Add("WIN_GRASS_COPYNAME", new List<string> { "При выделении модели в поиске копировать ее сюда", "Copy model name from another window", "Modellnamen aus einem anderen Fenster kopieren", "Skopiuj nazwę modelu z innego okna", "Kopírování jména modelu z jiného okna" });
            words.Add("WIN_GRASS_REMOVE", new List<string> { "Режим удаления вобов", "Removing vob mod", "Entfernen der Vob modifikation", "Usuwanie vobów z moda", "Odstranění vobů z modu" });
            words.Add("WIN_GRASS_ISITEM", new List<string> { "Воб - это oCItem", "Inserted vob is oCItem", "Vob als oCItem einfügen", "Dodany vob to oCItem", "Vložený vob je oCItem" });
            words.Add("WIN_GRASS_PROTECT", new List<string> { "Защита от зажатия левой кнопки мыши", "Protect from left mouse button pushing", "Schutz vor Drücken der linken Maustaste", "Ochrona przed naciśnięciem lewego przycisku myszki", "Ochrana před stisknutím levého tlačítka myši" });
            words.Add("WIN_GRASS_DYNCOLL", new List<string> { "Ставить вобу динамическую коллизию", "Set dynamic collision for vob", "Anschalten der Dynamischen Kollision", "Ustaw dynamiczną kolizję dla voba", "Nastavení dynamické kolize pro vob" });
            words.Add("WIN_GRASS_RANDANGLE", new List<string> { "Поворачивать воб на случайный угол вокруг вертикальной оси", "Rotate vob on random angle about vertical axis", "Drehen des Vobs um einen zufälligen Winkel über der vertikalen Achse", "Obróć vob o losowy kąt powyżej osi pionowej", "Otáčení vobu o náhodný úhel kolem svislé osy" });
            words.Add("WIN_GRASS_NORMALPOLYGON", new List<string> { "Ставить воб перпендикулярно полигону", "Set vob perpendicular to the polygon", "Vob rechtwinklig zum Polygon setzen", "Ustaw vob prostopadle do poligona", "Nastavení vobu kolmo k polygonu" });
            words.Add("checkBoxMiscAutoCompile", new List<string> { "Автокомпиляция мира и света после объединения меша с вобами", "Autocompile world and light after merging mesh with vobs", "Autokompilieren von Welt und Licht nach dem Zusammenführen des Mesh mit Vobs", "Autokompilacja świata i światła po połączeniu mesha z vobami", "Automatická kompilace světa a světla po sloučení meshů s voby" });
            words.Add("checkBoxMiscAutoCompileUncZen", new List<string> { "Автокомпиляция мира и света при загрузки некомпилированного ZEN", "Autocompile world and light after loading uncompiled ZEN", "Autokompilieren von Welt und Licht nach dem Laden von nicht kompilierter ZEN", "Autokompilacja świata i światła po załadowaniu nieskompilowanego ZENA", "Automatická kompilace světa a světla po načtení nezkompilovaného ZENu" });
            words.Add("checkBoxAutoRemoveAllVisuals", new List<string> { "Автоматически очищать visual для всех zCVobLevelCompo при сохранении ZEN", "Auto cleaning visual for all zCVobLevelCompo before saving ZEN", "Automatische visuelle Reinigung für alle zCVobLevelCompo vor dem Speichern ZEN", "Automatyczne usuwanie visuali dla wszystkich zCVobLevelCompo przed zapisaniem ZENA", "Automatické vizuální čištění pro všechny zCVobLevelCompo před uložením ZENu" });
            words.Add("checkBoxMiscRemoveAllLevelCompos", new List<string> { "Удалить все zCVobLevelCompo при загрузке ZEN", "Remove all zCVobLevelCompo while loading ZEN", "Entfernen Sie alle zCVobLevelCompo beim Laden von ZEN", "Usuń wszystkie zCVobLevelCompo podczas wczytywania ZEN", "Odstranění všech zCVobLevelCompo při načítání ZENu" });
            words.Add("checkBoxShowPolysSort", new List<string> { "При сохранении больших локаций спрашивать о сортировке полигонов (более 200 тыс. полигонов)", "Ask for sorting polygons while saving big locations (more than 200k polygons)", "Frage nach dem Sortieren von Polygonen beim Speichern großer Orte (mehr als 200k Polygone)", "Sortowanie wielokątów podczas zapisywania dużych lokacji (ponad 200k wielokątów)", "Žádost o třídění polygonů při ukládání velkých lokací (více než 200k polygonů)" });
            words.Add("MENU_TOP_VIEW_GRASS", new List<string> { "Сеятель объектов", "Objects sower", "Objektgenerator", "Generator obiektów", "Generátor objektů" });
            words.Add("MENU_TOP_VIEW_ALTCONTROLLER", new List<string> { "Альтернативное управление", "Alternative controller", "Alternativer Controller", "Alternatywna kamera", "Alternativní ovladač" });
            words.Add("CANT_APPLY_PARENT_VOB", new List<string> { "Данный тип воба не может быть родителем!", "This type of vob can't be a parent!", "Diese Art von Vob kann keine Übergeordung sein!", "Ten typ voba nie może być zapisany jako rodzic!", "Tenhle typ vobu nemůže být rodičem!" });
            words.Add("saveMeshTime", new List<string> { "Сохранение MESH выполнено за", "Saving MESH time...", "Speichern der MESH dauerte", @"Czas zapisywania MESH'a...", "Čas ukládání MESHe..." });
            words.Add("MENU_TOP_SAVEMESH", new List<string> { "Сохранить MESH", "Save MESH", "MESH Speichern", "Zapisz MESH", "Uložit MESH" });
            words.Add("WIN_MSG_CONFIRM", new List<string> { "Подтвердите действие", "Confirm the action", "Bestätige die Aktion", "Potwierdź akcję", "Potvrdit akci" });
            words.Add("WIN_MSG_CONFIRM_PLACENEARCAM", new List<string> { "Вставить Vobtree перед камерой?", "Do insert vobtree near the camera?", "Vobtree in der Nähe der Kamera einfügen?", "Czy wstawiasz vobtree w pobliżu kamery?", "Vložit vobtree v blízkosti kamery?" });
            words.Add("CONTEXTMENU_TREE_ADD_PARENT", new List<string> { "Сделать глобальным родителем", "Make this vob as a global parent", "Dieses Vob als globale übergeordnet einrichten", "Stwórz ten vob jako globalnego rodzica dla wszystkich nowych vobów", "Vytvořit tento vob jako globálního rodiče" });
            words.Add("CONTEXTMENU_TREE_REMOVE_PARENT", new List<string> { "Очистить глобального родителя", "Remove the global parent", "Globale Überordnung entfernen", "Usuń globalnego rodzica", "Odstranit globálního rodiče" });
            words.Add("CONTEXTMENU_TREE_ADD_VOB", new List<string> { "Добавить воб в быстрый доступ", "Add vob into Fast access list", "Vob in die Schnellzugriffsliste aufnehmen", "Dodaj vob do listy szybkiego dostępu", "Přidání vobu do seznamu rychlého přístupu" });
            words.Add("QUICKVOBS_PARENT", new List<string> { "Глобальный воб-родитель", "Global parent vob", "Globales Überordetes Vob", "Globalny rodzic voba", "Globální rodičovský vob" });
            words.Add("QUICKVOBS_ACCESS", new List<string> { "Быстрый доступ", "Fast access", "Schneller Zugriff", "Szybki dostęp", "Rychlý přístup" });
            words.Add("TAB_PAGE_OBJECTS", new List<string> { "Объекты", "Objects", "Objekte", "Obiekty", "Objekty" });
            words.Add("CONTEXTMENU_FAST_REMOVE_VOB", new List<string> { " Удалить воб из быстрого доступа", "Remove the vob from fast access", "Vob von der Schnellzugriffsliste löschen", "Usuń vob z szybkiego dostępu", "Odstranění vobu z rychlého přístupu" });
            words.Add("QUICKVOBS_CANTBE_PARENT", new List<string> { "Данный воб не может быть родителем!", "Current vob can't be a parent!", "Aktuelles von kann nicht Übergeordnet sein!", "Obecny vob nie może być rodzicem!", "Současný vob nemůže být rodičem!" });
            words.Add("PROP_BUTTON_COLOR", new List<string> { "Цвет", "Color", "Farbe", "Kolor", "Barva" });
            words.Add("labelItemLocatorRadius", new List<string> { "Радиус показа вещей: ", "Items show radius: ", "Item Sichtweite", "Pokaż promień: ", "Poloměr zobrazení předmětů: " });
            words.Add("groupBoxItemsLocator", new List<string> { "Локатор предметов: ", "Items locator: ", "Item Locator: ", "Lokalizator przedmiotów", "Lokalizátor předmětů: " });
            words.Add("checkBoxLocatorEnabled", new List<string> { "Включить", "Enabled", "Aktiviert", "Włączony", "Zapnuto" });
            words.Add("checkBoxLocatorOnlySusp", new List<string> { "Только \"плохие\" oCItem", "Only 'bad' oCItem", "Nur 'schlechte' oCItem", "Tylko 'zły' oCItem", "Pouze 'špatný' oCItem" });
            words.Add("MENU_TOP_WIN_POS", new List<string> { "Положение окон", "Position of windows", "Position der Fenster", "Pozycja okien", "Pozice oken" });
            words.Add("MENU_TOP_WIN_POS_RESET", new List<string> { "Сбросить положение окон", "Reset windows' position", "Fenster Positionen zurücksetzen", "Zresetuj pozycje okien", "Resetování pozice oken" });
            words.Add("MENU_TOP_WIN_POS_PRESET_1", new List<string> { "Использовать пресет #1 (FullHD)", "Use windows presets #1 (FullHD)", "Fenstervoreinstellungen #1 (FullHD) verwenden", "Użyj ustawień dla okien #1 (FullHD)", "Použití nastavení oken #1 (FullHD)" });
            words.Add("MENU_TOP_WIN_POS_PRESET_2", new List<string> { "Использовать пресет #2 (QuadHD)", "Use windows presets #2 (QuadHD)", "Fenstervoreinstellungen #2 (QuadHD) verwenden", "Użyj ustawień dla okien #2 (QuadHD)", "Použití nastavení oken #2 (QuadHD)" });
            words.Add("checkBoxShutSounds", new List<string> { "Глушить звуки при загрузке", "Shut sounds after world loaded", "Sounds nach Welt laden Stummen", "Wyłącz dźwięki po załadowaniu świata", "Vypnutí zvuků po načtení světa" });
            words.Add("checkBoxConstSound", new List<string> { "Постоянно глушить звуки", "Always shut all sounds", "Immer alle Sounds stummen", "Zawsze wyłączaj wszystkie dźwięki", "Vždy vypnout všechny zvuky" });
            words.Add("OnlyOneVobCanBe", new List<string> { "Воб такого типа может быть на карте ТОЛЬКО ОДИН!", "Only ONE vob like this can be on the map!", "Nur EIN Vob wie dieses kann auf der Karte sein!", "Tylko jeden vob takiego typu może znajdować się na mapie!", "Na mapě může být pouze JEDEN takový vob!" });
            words.Add("GAME_MODE", new List<string> { "Играть за героя", "Play the hero", "Spiele den Helden", "Zagraj bohaterem", "Hrát za hrdinu" });
            words.Add("ZEN_BAD_NAME", new List<string> { "В имени ZEN не может содержаться '.3DS' ! Переименуйте файл!", "ZEN's name can't contain '.3DS' ! Rename the file.", "Der Name der ZEN darf nicht '.3DS' enthalten! Benenne die Datei um.", "Nazwa ZEN nie może zawierać '.3DS' ! Zmień nazwę pliku.", "Jméno ZENu nemůže obsahovat '.3DS' ! Přejmenujte soubor." });
            words.Add("CONTEXTMENU_TREE_RESTORE_POS", new List<string> { "Восстановить позицию воба", "Restore vob's position", "Die Position des Vobs wiederherstellen", "Przywróć pozycję voba", "Obnovit pozici vobu" });
            words.Add("CANT_COPY_INITSELF", new List<string> { "Нельзя скопировать и вставить глобального родителя в самого себя!", "Can't copy and insert global parent vob into itself!", "Kann keine globale übergeordnete Vob-Datei in sich selbst kopieren und einfügen!", "Nie można skopiować i dodać globalnego rodzica voba do siebie!", "Nelze zkopírovat a vložit globální rodičovský vob do sebe!" });
            words.Add("checkBoxSetNearestVobCam", new List<string> { "Устанавливать камеру на воб с именем VOB_SPACER_CAMERA_START или zCVobStartpoint после загрузки ZEN", "Set the camera near the vob with name VOB_SPACER_CAMERA_START or zCVobStartpoint after loading ZEN", "Setze die Kamera in der Nähe des Vobs mit dem Namen VOB_SPACER_CAMERA_START oder zCVobStartpoint nach dem Laden der ZEN", "Ustaw kamerę w pobliżu voba z nazwą VOB_SPACER_CAMERA_START lub zCVobStartpoint po załadowaniu ZENA", "Nastavení kamery v blízkosti vobu s názvem VOB_SPACER_CAMERA_START nebo zCVobStartpoint po načtení ZENu" });
            words.Add("tabControlProps_3", new List<string> { "Настройки", "Settings", "Einstellungen", "Ustawienia", "Nastavení" });
            words.Add("checkBoxBoldFontProps", new List<string> { "Выделять основные поля жирным шрифтом", "Use bold font for main fields", "Fettschrift für Hauptfelder verwenden", "Użyj pogrubionej czcionki dla głównych pól", "Použití tučného písma pro hlavní pole" });
            words.Add("checkBoxFontUnderstroke", new List<string> { "Выделять основные поля подчеркнутым шрифтом", "Use understroke font for main fields", "Unterstrichene Schriftart für Hauptfelder verwenden", "Użyj czcionki z podkreśleniem dla pól głównych", "Použití podtrženého písma pro hlavní pole" });
            words.Add("buttonSelectFontProps", new List<string> { "Выбрать шрифт для свойств", "Select font for properties", "Schriftart für Eigenschaften wählen", "Wybierz czcionkę dla właściwości", "Výběr písma pro vlastnosti" });
            words.Add("buttonResetFontDefault", new List<string> { "Сбросить шрифт по умолчанию", "Reset font by default", "Schriftart standardmäßig zurücksetzen", "Przywróć domyślną czcionkę", "Obnovení výchozího písma" });
            words.Add("labelChangeFontStyleText", new List<string> { "* Для применения выберите объект снова", "* For applying reselect the object", "* Zum Anwenden das Objekt erneut auswählen", "* Aby zastosować ponownie wybierz obiekt", "* Pro použití znovu vyberte objekt" });
            words.Add("MENU_TOP_VIEW_MULTI", new List<string> { "Режим множественного выделения", "Multi selection mode", "Multi Selektions Modus", "Tryb wielokrotnego wyboru", "Režim multifunkční volby" });
            words.Add("TAB_PAGE_MATERIALS", new List<string> { "Материалы", "Materials", "Materialien", "Materiały", "Materiály" });
            words.Add("NoVisualForSuchVob", new List<string> { "Воб данного типа не может иметь визуал!", "This type of a vob can't have any visual!", "Dieser Typ Von kann kein Visual haben!", "Ten typ voba nie może mieć visuala!", "Tento typ vobu nemůže mít žádný vizuál!" });
            words.Add("MENU_TOP_SPECIAL_FUNCS", new List<string> { "Специальные функции", "Special functions", "Spezial Funktionen", "Funkcje specjalne", "Speciální funkce" });
            words.Add("MENU_TOP_CREATE_VOB_VISUALS_LIST", new List<string> { "Сформировать список визуалов локации", "Create a list of files which are used in the location", "Erstelle eine Liste der Dateien, die in diesem Bereich verwendet werden", "Stwórz lisę plików, któresą używane w lokacji", "Vytvoření seznamu souborů, které se používají v této lokaci" });
            words.Add("labelFindVisualArchive", new List<string> { "Искать только в архиве (VDF)", "Search only in selected (VDF)", "Suche nur in ausgewählter (VDF)", "Szukaj tylko w wybranych (VDF)", "Hledat pouze ve vybraných (VDF)" });
            words.Add("checkBoxLocatorByName", new List<string> { "Искать по имени:", "Search by name:", "Suche nach Namen:", "Szukaj według nazwy:", "Vyhledávání podle jména:" });
            words.Add("checkBoxSearchHasChildren", new List<string> { "У воба есть дети", "Vob has children", "Vob hat untergeordnete", "Vob ma dzieci", "Vob má děti" });
            words.Add("CONTEXTMENU_TREE_REPLACE_FROM_PARENT", new List<string> { "Переместить все вобы из родителя", "Move all vobs from the parent", "Verschieben aller Vobs aus dem übergeordneten", "Przenieś wszystkie voby od rodzica", "Přesunout všechny voby od rodiče" });
            words.Add("checkBoxCamShowPortalsInfo", new List<string> { "Показывать информацию о порталах", "Show portals info", "Zeige Portal Infos", "Pokaż info o portalach", "Zobrazit informace o portálech" });
            words.Add("CHECK_SORTING_POLYS", new List<string> { "Сортировать полигоны локации?\nСортировка полигонов в локации сильно замедляет сохранение больших локаций (по времени), однако, это необходимо делать для финальной версии локации, для промежуточных версий локации это необязательно и экономит время.", "Should we sort polygons of the location?\nSorting polygons is necessary for the final version of the location, but it requires much time for saving in big locations, for work version of locations you don't need to sort them every time while saving.", "Sollen die Polygone des Ortes sortiert werden? Das Sortieren der Polygone ist für die endgültige Version des Ortes notwendig, erfordert aber viel Zeit beim Speichern von großen Orten, für die Arbeitsversion von Orten müssen sie nicht jedes Mal beim Speichern sortiert werden.", "Czy chcesz sortować wielokąty lokacji?\nSortowanie wielokątów jest konieczne dla ostatniej wersji lokacji, ale wymaga dużo czasu przy zapisie w dużych lokacjach, dla wersji roboczych lokacji nie trzeba ich sortować za każdym razem przy zapisie.", "Je třeba třídit polygony lokace?Třídění polygonů je nutné pro finální verzi lokace, ale při ukládání velkých lokací to vyžaduje hodně času, pro pracovní verzi lokací není třeba je třídit pokaždé při ukládání." });
            //0.27
            words.Add("checkBoxShowVobTraceFloor", new List<string> { "Подсвечивать положение воба на поверхности", "Brighten selected vob position on the floor", "Ausgewählte Vob-Position auf dem Boden aufhellen", "Rozjaśnij pozycję wybranego voba na podłodze", "Zesvětlení vybrané pozice vobu na podlaze" });
            words.Add("WIN_MSG_CONFIRM_REMOVEVOB", new List<string> { "Удалить воб?", "Remove the vob?", "Vob löschen?", "Czy chcesz usunąć vob?", "Odstranit vob?" });
            words.Add("WIN_BTN_CONFIRM", new List<string> { "Подтвердить", "Confirm", "Bestätigen", "Potwierdź", "Potvrdit" });
            words.Add("WIN_LABEL_MACROS_RENAME", new List<string> { "Введите имя:", "Enter the name:", "Gebe den Namen ein:", "Ustal nazwę:", "Zadat jméno:" });
            words.Add("WIN_LABEL_MACROS_NEW", new List<string> { "Введите имя нового макроса:", "Enter the name of a new macros:", "Gebe den Namen eines neuen Makros ein:", "Ustal nazwę dla nowego macrosa:", "Zadejte název nového makra:" });
            words.Add("WIN_OBJ_TAB8", new List<string> { "Макросы", "Macros", "Makros", "Macros", "Makra" });
            words.Add("buttonCreateNewMacros", new List<string> { "Создать новый макрос", "Create a new macros", "Neues Makro erstellen", "Utwórz nowy macros", "Vytvořit nové makra" });
            words.Add("buttonMacrosRenameCurrent", new List<string> { "Переименовать", "Rename", "Umbenennen", "Zmień nazwę", "Přejmenovat" });
            words.Add("buttonMacrosRemoveCurrent", new List<string> { "Удалить", "Delete", "Löschen", "Usuń", "Odstranit" });
            words.Add("buttonMacrosReloadFromFile", new List<string> { "Перезагрузить всё из файла", "Reload all from the file", "Alles aus der Datei neu laden", "Załaduj ponownie wszystko z pliku", "Znovu načíst vše ze souboru" });
            words.Add("buttonMacrosSaveAll", new List<string> { "Сохранить всё в файл", "Save all to the file", "Alles in die Datei speichern", "Zapisz wszystko do pliku", "Uložit vše do souboru" });
            words.Add("buttonMacrosRun", new List<string> { "Выполнить", "Run", "Ausführen", "Uruchom", "Spustit" });
            words.Add("buttonMacrosParse", new List<string> { "Парсить и сохранить текущий текст", "Parse and save current text", "Parse und speichere aktuellen Text", "Parsuj i zapisz aktualny tekst", "Parsování a ukládání aktuálního textu" });
            words.Add("groupBoxMacrosButtons", new List<string> { "Действия", "Actions", "Aktionen", "Akcje", "Akce" });
            words.Add("WIN_CAMERA_START", new List<string> { "Старт", "Start", "Start", "Start", "Start" });
            words.Add("WIN_CAMERA_STOP", new List<string> { "Стоп", "Stop", "Stop", "Stop", "Stop" });
            words.Add("CANT_APPLY_PARENT_CAMERA", new List<string> { "Нельзя вставить новую камеру в другую камеру!", "Can't set current camera as a parent for a new camera!", "Ich kann die aktuelle Kamera nicht als Überordnung für eine neue Kamera festlegen!", "Nie można ustawić bieżącej kamery jako rodzica dla nowej kamery!", "Nelze nastavit stávající kameru jako rodičovskou kameru pro novou kameru!" });
            words.Add("CANT_APPLY_CAMERA_NEWKEY", new List<string> { "Свойство камеры стоит FOR_OBJECT, а воба нет!", "Camera has FOR_OBJECT value, but no vob found", "Kamera hat FOR_OBJECT-Wert, aber kein Vob gefunden", "Kamera a wartość FOR_OBJECT, ale nie znaleziono voba", "Kamera má hodnotu FOR_OBJECT, ale nebyl nalezen žádný vob" });
            words.Add("CAMERA_ITEMS_FORCE_RENAME", new List<string> { "Ключам камеры были проставлены имена", "Camera's keys got its names", "Die Keys der Kamera haben ihre Namen", "Klatki kamery mają swoje nazwy", "Klávesy kamery dostaly svá jména" });
            words.Add("FORM_ENTER_BAD_VALUE_INT", new List<string> { "Введено недопустимое значение! Данное поле целочисленное!", "Invalid value entered. Only integer is allowed in this field!", "Falscher Wert eingegeben. Nur Integer sind erlaubt!", "Wprowadzono nieprawidłową wartość. W tym polu dozwolone są tylko liczby całkowite!", "Zadána neplatná hodnota. V tomto poli je povoleno pouze celé číslo!" });
            words.Add("FORM_ENTER_BAD_STRING_INPUT", new List<string> { "Введены недопустимые символы!", "Invalid symbols found in the input", "Falsche Symbole in der EIngabe gefunden", "W danych wejściowych znaleziono nieprawidłowe symbole", "Na vstupu byly nalezeny neplatné symboly" });
            words.Add("checkBoxOnlyLatinInInput", new List<string> { "Допускать ввод только латинских символов в поля свойств", "Allow only Latin symbols as input values", "Es sind nur Lateinische Buchstaben als Wert erlaubt", "Zezwalaj tylko na symbole łacińskie jako wartości wejściowe", "Povolit jako vstupní hodnoty pouze latinské symboly" });
            words.Add("MSG_VOB_CANT_BE_COPIED", new List<string> { "Данный тип воба нельзя скопировать!", "This vob type can't be copied!", "Dieser Vob Typ kann nicht kopiert werden!", "Ten typ voba nie może zostać skopiowany!", "Tento typ vob unelze kopírovat!" });
            words.Add("groupBoxCameraNew", new List<string> { "Новая камера", "New camera", "Neue Kamera", "Nowa kamera", "Nová kamera" });
            words.Add("FORM_COMMON_NAME", new List<string> { "Имя", "Name", "Name", "Nazwa", "Jméno" });
            words.Add("FORM_COMMON_CREATE", new List<string> { "Создать", "Create", "Erstellen", "Utwórz", "Vytvořit" });
            words.Add("groupBoxCamKeys", new List<string> { "Ключи", "Keyframes", "Keyframes", " Klatki kluczowe", "Klávesy" });
            words.Add("buttonCamSpline", new List<string> { "Добавить позицию", "Add a position", "Position hinzufügen", "Dodaj pozycję", "Přidat pozici" });
            words.Add("buttonCamTargetSpline", new List<string> { "Добавить цель", "Add a target", "Ziel hinzufügen", "Dodaj cel", "Přidat cíl" });
            words.Add("groupBoxCamSettings", new List<string> { "Настройки", "Settings", "Einstellungen", "Ustawienia", "Nastavení" });
            words.Add("labelCamTimeSec", new List<string> { "Время полета:", "Fly time:", "Flug Zeit", "Czas lotu:", "Čas letu:" });
            words.Add("checkBoxCameraHide", new List<string> { "Скрывать вобы в полете", "Hide vobs while camera active", "Vobs bei aktiver Kamera ausblenden", "Ukryj voby, gdy kamera jest aktywna", "Skrytí vobů při aktivní kameře" });
            words.Add("labelCamGotoKey", new List<string> { "Перейти к ключу: ", "Go to key", "Zum Key gehen", "Przejdź do klatki", "Přejít na klávesu" });
            words.Add("groupBoxLightPresetProperties", new List<string> { "Свойства пресета", "Preset properties", "Preset Eigenschaften", "Właściwości presetu", "Vlastnosti předvolby" });
            words.Add("labelLightPresetName", new List<string> { "Имя пресета (обязательно)", "Preset name (mandatory)", "Preset Name (notwendig)", "Nazwa presetu (obowiązkowa)", "Název předvolby (povinné)" });
            words.Add("buttonNewLightPreset", new List<string> { "Новый пресет", "New preset", "Neues preset", "Nowy preset", "Nová předvolba" });
            words.Add("buttonDeleteSelectedLightPreset", new List<string> { "Удалить выбранный пресет", "Delete selected preset", "Ausgewähltes Preset löschen", "Usuń wybrany preset", "Odstranění vybrané předvolby" });
            words.Add("buttonSaveLightPresets", new List<string> { "Сохранить пресеты", "Save presets", "Presets speichern", "Zapisz presety", "Uložit předvolby" });
            words.Add("buttonUpdateLightPresetOnLightVobs", new List<string> { "Обновить пресет на все lightvobs", "Update preset on lightvobs", "Preset auf LightVob erneuern", "Zaktualizuj preset na lightvobach", "Aktualizace předvolby na lightvobech" });
            words.Add("buttonUpdateLightPresetFromVob", new List<string> { "Обновить пресет из lightvob <<", "Update preset from lightvob <<", "Preset von LightVob erneuern <<", "Zaktualizuj preset z lightvoba <<", "Aktualizace předvolby z lightvobu <<" });
            words.Add("buttonUsePresetOnLightVob", new List<string> { "Применить пресет на lightvob >>", "Use preset on lightvob >>", "Preset auf LightVob anwenden >>", "Użyj presetu na lightvobie >>", "Použití předvolby na lightvobu >>" });
            words.Add("buttonCreateLightVob", new List<string> { "Создать LightVob", "Create LightVob", "LightVob erstellen", "Utwórz LightVob", "Vytvořit LightVob" });
            words.Add("groupBoxLightSelected_Preset", new List<string> { "Выбранный пресет", "Selected preset", "Ausgewähltes Preset", "Wybrany preset", "Vybraná předvolba" });
            words.Add("groupBoxLightSelected_LightVob", new List<string> { "Выбранный lightvob", "Selected lightvob", "Ausgewähltes LightVob", "Wybrany lightvob", "Vybraný lightvob" });
            words.Add("labelLightVobName", new List<string> { "Имя воба:", "Vob name:", "Vob-Name:", "Nazwa Voba:", "Jméno Vobu" });
            words.Add("groupBoxLightType", new List<string> { "Тип света", "Light type", "Licht-Typ", "Rodzaj światła", "Typ světla" });
            words.Add("checkBoxShowLightVobRadius", new List<string> { "Показать радиус", "Show radius", "Radius anzeigen", "Pokaż zasięg", "Zobrazit rozsah" });
            words.Add("checkBoxLightVobInstantCompile", new List<string> { "Мгновенная компиляция", "Instant compile", "Sofortiges Kompilieren", "Natychmiastowa kompilacja", "Okamžitá kompilace" });
            words.Add("radioButtonLightVobStatic", new List<string> { "Статический", "Static", "Statisch", "Statyczne", "Statické" });
            words.Add("radioButtonLightVobDynamic", new List<string> { "Динамичный", "Dynamic", "Dynamisch", "Dynamiczne", "Dynamické" });
            words.Add("groupBoxLightColorProperties", new List<string> { "Свойства цвета", "Color properties", "Farbeigenschaften", "Właściwości koloru", "Vlastnosti barvy" });
            words.Add("groupBoxLightRangeProperties", new List<string> { "Свойства диапазона", "Range properties", "Reichweiteneigenschaften", "Właściwości zasięgu", "Vlastnosti rozsahu" });
            words.Add("FORM_COMMON_DELETE", new List<string> { "Удалить", "Delete", "Löschen", "Usuń", "Smazat" });
            words.Add("FORM_CAMERA_INSERT_KEY_HERE", new List<string> { "Вставить новый ключ сюда", "Insert a new key here", "", "Wstaw nową klatkę", "Vložit novou klávesu zde" });
            words.Add("TOOL_BBOX_CHANGE", new List<string> { "Режим 'Изменение Bbox'", "Bbox change mode", "Bbox Änderungs-Modus", "Tryb zmiany BBoxa", "Režim změny Bboxu" });
            words.Add("TOOL_BBOX_CHANGE_LEAVE", new List<string> { "Выход из режима 'Изменение Bbox'", "Exit from bbox editing", "Bbox Änderungs-Modus verlassen", "Opuszczenie trybu zmiany Bboxa", "Ukončení editace Bboxu" });
            words.Add("TOOL_BBOX_MAXS", new List<string> { "Изменение bbox maxs", "Changing bbox maxs", "Bbox max ändern", "Zmiana maks. bbox", "Změna max. hodnot Bboxu" });
            words.Add("TOOL_BBOX_MINS", new List<string> { "Изменение bbox mins", "Changing bbox mins", "Bbox min ändern", "Zmiana min. bbox", "Změna min. hodnot Bboxu" });
            words.Add("TOOL_BBOX_CANT_WORK", new List<string> { "У текущего типа воба нельзя менять bbox!", "Can't change bbox of this vob type", "Kann Bbox dieses Vob Typens nicht ändern", "Nie można zmienić bboxa w tym typie voba", "Nelze změnit Bbox tohoto typu vobu" });
            words.Add("FORM_HINT_INSERT_WPFP", new List<string> { "*Кнопка {0}, чтобы вставить новый воб", "*Press {0} button to insert a new vob", "*Drücke {0} zum Hinzufügen eines neuen Vobs", "*Wciśnij klawisz {0} aby dodać nowy vob", "*Stisknutím tlačítka {0} vložíte nový vob" });
            words.Add("checkBoxInfoUseZSpy", new List<string> { "Отладочные сообщения zSpy", "zSpy debug messages", "zSpy Debug Nachrichten", "Komunikaty debugowania zSpy", "Ladicí zprávy zSpy" });
            words.Add("MSG_COMMON_SEARCH", new List<string> { "Поиск", "Search", "Suchen", "Szukaj", "Hledat" });
            words.Add("MSG_COMMON_COMMON", new List<string> { "Общее", "Common", "Allgemein", "Ogólne", "Běžné" });
            words.Add("MSG_COMMON_MATSEACH", new List<string> { "Поиск материала:", "Material search:", "Material Suche:", "Szukaj materiał:", "Hledání materiálu:" });
            words.Add("MSG_MATFILTER_NEW_NAME", new List<string> { "Имя фильтра:", "Filter name:", "Filter Name:", "Nazwa filtra:", "Jméno filtru:" });
            words.Add("MSG_MATFILTER_RENAME", new List<string> { "Переименование фильтра:", "Rename Filter:", "Filter umbenennen:", "Zmień nazwę filtru:", "Přejmenování filtru:" });
            words.Add("checkBoxMatchNames", new List<string> { "Совпадение имен", "Match vobs names", "Namen von Vobs abgleichen", "Dopasuj nazwy vobów", "Shoda jmen vobů" });
            words.Add("checkBoxSearchItem", new List<string> { "Искать oCItem в oCMobContainer", "Search oCItem in oCMobContainer", "Suche oCItem in oCMobContainer", "Szukaj oCItem w oCMobContainer", "Hledat oCItem v oCMobContainer" });
            words.Add("VOBLIST_TYPE_ANY", new List<string> { "Любой тип", "Any type", "Jeder Typ", "Dowolny typ", "Jakýkoli typ" });
            words.Add("MENU_TOP_CONTROLS_VOBS", new List<string> { "Вобы", "Vobs", "Vob", "Voby", "Voby" });
            words.Add("WIN_CONTROLSET_VOBS_TEXT", new List<string> { "Настройки вобов", "Vobs settings", "Vob Einstellungen", "Ustawienia vobów", "Nastavení vobů" });
            words.Add("MSG_COMMON_NO_EMPTY_NAME", new List<string> { "Имя не может быть пустым!", "Name can't be empty!", "Der Name darf nicht leer sein!", "Nazwa nie może być pusta!", "Jméno nemůže být prázdné!" });
            words.Add("MSG_COMMON_NO_UNIQUE_NAME", new List<string> { "Такое имя уже есть", "The name already exists!", "Der Name existiert bereits!", "Nazwa już istnieje!", "Toto jméno již existuje!" });
            words.Add("WIN_MATFILTER_FILTER_NEW", new List<string> { "Создать новый", "New filter", "Neuer Filter", " Nowy filtr", "Nový filtr" });
            words.Add("WIN_MATFILTER_FILTERLIST_RENAME", new List<string> { "Переименовать выбранный", "Rename selected", "Selektiertes umbenennen", "Zmień nazwę wybranego", "Přejmenovat vybrané" });
            words.Add("WIN_MATFILTER_FILTERLIST_SAVE", new List<string> { "Сохранить файл фильтров", "Save filters file", "Filterdatei speichern", "Zapisz plik filtrów", "Uložit soubor s filtry" });
            words.Add("WIN_MATFILTER_FILTER_TITLE", new List<string> { "Фильтр материалов", "Materials filter", "Material Filter", "Filtr materiałów", "Filtr materiálů" });
            words.Add("WIN_MATFILTER_FILTER_TAB_MESH", new List<string> { "Меш", "Mesh", "Mesh", "Mesh", "Mesh" });
            words.Add("WIN_MATFILTER_FILTER_TAB_VOBS", new List<string> { "Вобы", "Vobs", "Vobs", "Voby", "Voby" });
            words.Add("WIN_MATFILTER_FILTER_SEARCH_IN_MATS", new List<string> { "Поиск материала:", "Search material:", "Suche Material", "Wyszukaj materiał:", "Hledat materiál:" });
            words.Add("WIN_MATFILTER_FILTER_TEXTURE", new List<string> { "Текстура", "Texture", "Texture", "Tekstura", "Textura" });
            words.Add("WIN_MATFILTER_FILTER_SETTINGS", new List<string> { "Настройки выбранного материала", "Properties of selected material", "Eigenschaften des selektierten Materials", "Właściwości wybranego materiału", "Vlastnosti vybraného materiálu" });
            words.Add("WIN_MATFILTER_FILTER_SET_FILTER", new List<string> { "Задать фильтр:", "Set filter:", "Filter setzen:", "Ustaw filtr:", "Nastavení filtru" });
            words.Add("WIN_MATFILTER_FILTER_SET_GROUP", new List<string> { "Задать группу:", "Set group:", "Setze Gruppe:", "Ustaw grupę:", "Nastavení skupiny:" });
            words.Add("WIN_MATFILTER_FILTER_SETTINGS_SIZE", new List<string> { "Размер:", "Size:", "Größe:", "Rozmiar:", "Rozměr" });
            words.Add("WIN_MATFILTER_FILTER_SETTINGS_ALPHA", new List<string> { "Альфа-канал:", "Alpha channel:", "Alpha Kanal", "Kanał alpha:", "Alpha kanál" });
            words.Add("WIN_MATFILTER_FILTER_SETTINGS_ALPHA_YES", new List<string> { "Альфа-канал: да", "Alpha channel: yes", "Alpha Kanal: Ja", "Kanał alpha: tak", "Alpha kanál: ano" });
            words.Add("WIN_MATFILTER_FILTER_SETTINGS_ALPHA_NO", new List<string> { "Альфа-канал: нет", "Alpha channel: no", "Alpha Kanal: Nein", "Kanał alpha: nie", "Alpha kanál: ne" });
            words.Add("WIN_MATFILTER_FILTER_SETTINGS_BITS", new List<string> { "бит", "bits", "bits", "bity", "bity" });
            words.Add("WIN_MATFILTER_FILTER_SETTINGS_NAME", new List<string> { "Настройки предпросмотра", "Preview settings", "Vorschau Einstellungen", "Ustawienia podglądu", "Nastavení náhledu" });
            words.Add("WIN_MATFILTER_FILTER_SETTINGS_USE_ALPHA", new List<string> { "Прозрачность", "Transparency", "Transparenz", "Przezroczystość", "Průhlednost" });
            words.Add("WIN_MATFILTER_FILTER_SETTINGS_USE_CENTER", new List<string> { "Всегда по центру", "Always in center", "Immer in der Mitte", "Zawsze na środku", "Vždy ve středu" });
            words.Add("WIN_MATFILTER_FILTER_SETTINGS_USE_SCALE", new List<string> { "Автомасштаб малых текстур", "Autoscale small textures", "Autoskalieren kleiner Texturen", "Automatyczne skalowanie małych tekstur", "Automatické škálování malých textur" });
            words.Add("WIN_MATFILTER_FILTER_MAT_NAME_ALREADY_EXISTS", new List<string> { "Материал с таким именем уже существует!", "Material with this name already exists!", "Material mit diesem Namen existiert bereits!", "Materiał o tej nazwie już istnieje!", "Materiál s tímto názvem již existuje!" });
            words.Add("MSG_MATFILTER_NEW_MAT_NAME", new List<string> { "Имя материала:", "Material name:", "Material Name:", "Nazwa materiału:", "Jméno materiálu:" });
            words.Add("WIN_MATFILTER_TEXTURE_NOT_FOUND", new List<string> { "(Не найдена)", "(Not found)", "(Nicht gefunden)", "(Nie znaleziono)", "(Nenalezeno)" });
            words.Add("WIN_MATFILTER_FILTERS_MENU", new List<string> { "Меню фильтров", "Filters menu", "Filter Menü", "Menu filtrów", "Menu filtrů" });
            words.Add("WIN_MATFILTER_MATLIST_CURRENT", new List<string> { "Материалы {0} фильтра: ", "Materials of {0} filter: ", "Materialien des {0}-Filters: ", "Materiały {0} filtra: ", "Materiály filtru {0}:" });
            words.Add("WIN_MATFILTER_MATLIST_CURRENT_EMPTY", new List<string> { "Материалы фильтра: (0) ", "Materials of the filter: (0) ", "", "Materiały filtra: (0)", "Materiály filtru: (0) " });
            words.Add("WIN_MATFILTER_ERR_NO", new List<string> { "Все готово к работе", "Everything is ready", "", "Wszystko jest gotowe", "Vše je připraveno" });
            words.Add("WIN_MATFILTER_ERR_WORK", new List<string> { "Для работы загрузите ZEN или 3DS файл", "Load any ZEN or 3DS to activate Materials Filter", "Lade eine beliebige ZEN oder 3DS, um den Materialfilter zu aktivieren.", "Załaduj dowolny ZEN lub 3DS, aby aktywować filtr materiałów", "Pro aktivaci filtru materiálů načtěte libovolný ZEN nebo 3DS" });
            words.Add("WIN_MATFILTER_ERR_READONLY", new List<string> { "Файл MatLib.ini имеет аттрибут 'Только чтение'. Изменения в 'Библиотеке фильтров' не будут работать!", "File Matlib.ini has 'read only' attribute, no changes will be saved in 'Filters library'", "Datei Matlib.ini hat das Attribut 'Schreibgeschützt', Änderungen werden nicht in der 'Filter Bibliothek' gespeichert", "Plik Matlib.ini ma atrybut 'tylko do odczytu', żadne zmiany nie zostaną zapisane w 'Bibliotece filtrów'", "Soubor Matlib.ini má atribut 'pouze pro čtení', v 'Knihovně filtrů' nebudou uloženy žádné změny." });
            words.Add("WIN_MATFILTER_FILTERLIST_REMOVE", new List<string> { "Удалить фильтр", "Remove filter", "Filter entfernen", "Usuń filtr", "Odstranit filtr" });
            words.Add("MSG_MATFILTER_REMOVE_ONLY_NONEMPTY", new List<string> { "Можно удалить только пустой фильтр!", "You can remove only empty filter!", "Du kannst nur leere Filter entfernen!", "Możesz usunąć jedynie pusty filtr!", "Můžete odstranit pouze prázdný filtr!" });
            words.Add("WIN_MATFILTER_FILTERS_MENU_MISC", new List<string> { "Прочее", "Misc", "Sonstiges", "Pozostałe", "Různé" });
            words.Add("WIN_MATFILTER_NEW_MATERIAL", new List<string> { "Новый материал", "New material", "Neues Material", "Nowy materiał", "Nový materiál" });
            words.Add("WIN_MATFILTER_FILTERLIST_FILES", new List<string> { "Библиотека фильтров", "Filters library", "Filter Bibliothek", "Biblioteka filtrów", "Knihovna filtrů" });
            words.Add("WIN_MATFILTER_TEXTURE_TOO_BIG", new List<string> { "Размер текстуры слишком большой для отображения", "Texture is too big for being shown", "Texture ist zum Zeigen zu groß", "Tekstura jest za duża, by ją wyświetić", "Textura je příliš velká pro zobrazení" });
            words.Add("WIN_MATFILTER_CONV_TGA", new List<string> { "Конвертация TGA текстур: ", "Convering TGA textures: ", "Konvertiere TGA Texturen", "Konwersja tekstur TGA:", "Konverze textur TGA: " });
            words.Add("WIN_MATFILTER_CONV_WARNING", new List<string> { "Не выключайте SpacerNET!", "Don't shut down SpacerNET!", "Du darfst SpacerNET nicht beenden!", "Nie wyłączaj SpacerNET!", "Nevypínejte SpacerNET!" });
            words.Add("WIN_MATFILTER_CONV_INFO", new List<string> { "Некоторые из ваших материалов используют текстуры, которые не скомпилированы в '-C.TEX'.\nДля сохранения фильтров необходимо скомпилировать эти текстуры из TGA текстур.\nВыполняю конвертацию...", "Some of your materials don't have a compiled '-C.TEX' version of texture.\nTo save the filter such textures must be compiled from TGA textures.\nConverting...", "Einige deiner Materialien haben keine kompilierte '-C.TEX'-Version der Textur.\nUm den Filter zu speichern, müssen solche Texturen aus TGA-Texturen kompiliert werden.\nKonvertiere...", "Niektóre z materiałów nie mają skompilowanej wersji tekstury '-C.TEX'.\nAby zapisać filtr, takie tekstury muszą być skompilowane z tekstur TGA.\nKonwersja...", "Některé z vašich materiálů nemají zkompilovanou verzi textury '-C.TEX'.\nPro uložení filtru musí být takové textury zkompilovány z textur TGA.\nKonverze..." });
            words.Add("WIN_MATFILTER_FOLLOW_MAT", new List<string> { "Следовать за материалом при применении", "Follow material after applying", "Material nach anwenden folgen", "Śledź materiał po zatwierdzeniu", "Sledování materiálu po aplikaci" });
            words.Add("WIN_MATFILTER_SAVE_LAST_FILTER", new List<string> { "Принудительно ставить последний фильтр", "Forcedly set last filter", "Letzten Filter zwangsweise setzen", "Wymuś ustawienie ostatniego filtra", "Vynuceně nastavit poslední filtr" });
            words.Add("Trigget_BTN_JUMPTOKEY", new List<string> { "Прыгнуть на ключ", "Jump to key", "Zu Key Springen", "Przejdź do klucza", "Skočit na klávesu" });
            words.Add("TOOL_BBOX_EDIT_MODE_SELECTED", new List<string> { "Режим изменения BBOX", "BBOX editing mode", "Bbox Editier Modus", "Tryb edycji BBOX", "Režim editace BBOX" });
            words.Add("VOB_SEARCH_TYPE_SINGLE_WP", new List<string> { "Поиск несоединенных WP", "Search for unconnected WP", "Suche nach unverbundenden WP's", "Szukaj dla niepołączonych WP", "Hledání nepřipojených WP" });
            words.Add("OBJ_TAB_PICKFILTER", new List<string> { "Фильтр выделения вобов", "Vob select filter", "Vob Filter auswählen", "Wybierz filtr voba", "Výběr filtru Vobu" });

           
            
            //=========================
            words.Add("UNION_VOB_POS", new List<string> { "Позиция воба: ", "Vob pos: ", "Vob pos: ", "Pozycja voba: ", "Pozice vobu: " });
            words.Add("checkBoxCamCoord", new List<string> { "Показывать координаты камеры и воба", "Show camera and vob coordinates", "Kamera- und Vob-Koordinaten anzeigen", "Pokaż kamerę i współrzędne voba", "Zobrazit souřadnice kamery a vobu" });
            words.Add("VOB_ONEMODE", new List<string> { "Единый режим перемещения воба", "United mod of vob moving", "United mod of vob moving", "Wspólny tryb poruszania vobem", "Společný režim pohybu vobu" });
            words.Add("VOB_ONEMODE_OFF", new List<string> { "Единый режим отключен", "United mod disabled", "United Mod deaktiviert", "Wspólny tryb wyłączony", "Společný režim vypnut" });
            words.Add("MSG_VOB_FAV_ADD", new List<string> { "Воб добавлен в быстрый доступ", "Vob added to fast access list", "Vob ist zur Schellzugriffsliste hinzugefügt", "Vob dodany do listy szybkiego dostępu", "Vob přidán do seznamu rychlého přístupu" });
            words.Add("KEYS_VOB_FAV_ADD", new List<string> { "Добавить воб в быстрый доступ", "Add vob to fast access list", "Vob zur Schellzugriffsliste hinzufügen", "Dodaj voba do listy szybkiego dostępu", "Přidání vobu do seznamu rychlého přístupu" });
            words.Add("BTN_SET_DEFAULT_VALUES", new List<string> { "Сбросить настройки", "Set default settings", "Option zurücksetzen", "Ustaw domyślne wartości", "Nastavení výchozího nastavení" });
            words.Add("VOB_FILTER_SHOW_ONLY_INVISIBLE", new List<string> { "Только невидимые", "Only invisible", "Nur unsichtbare", "Tylko niewidoczne", "Pouze neviditelné" });
            words.Add("UNION_NO_WP_FP", new List<string> { "Сначала выберите и скопируйте WP или FP!", "First select and copy WP or FP", "Markiere und kopiere zuerst WP oder FP", "Zaznacz i skopiuj WP lub FP", "Nejprve vyberte a zkopírujte WP nebo FP" });
            words.Add("BTN_OPEN_FILE", new List<string> { "Выбрать файл...", "Load file...", "Lade Datei", "Wczytaj plik...", "Načíst soubor..." });
            words.Add("TOGGLE_MUSIC", new List<string> { "Включить/отключить музыку", "Toggle music", "Musik umschalten", "Przełącz muzykę", "Přepínání hudby" });
            words.Add("UNION_MUSIC_ON", new List<string> { "Музыка включена", "Music is ON", "Musik EIN", "Muzyka jest włączona", "Hudba je zapnutá" });
            words.Add("UNION_MUSIC_OFF", new List<string> { "Музыка отключена", "Music is OFF", "Musik AUS", "Muzyka jest wyłączona", "Hudba je vypnutá" });
            words.Add("checkBoxShowMoverKeys", new List<string> { "Показать ключи визуально", "Show keys visually", "Tasten visuell anzeigen", "Pokaż wizualizacje kluczy", "Vizuální zobrazení kláves" });
            words.Add("checkBoxAddPFX", new List<string> { "Добавлять .pfx при копировании", "Add .pfx when copy", "Beim kopieren .pfx hinzufügen", "Dodaj .pfx przy kopiowaniu", "Přidání souboru .pfx při kopírování" });
            words.Add("buttonRemoveMoverAllKeys", new List<string> { "Удалить все (сохранив позицию воба)", "Remove all (save vob position)", "Alle entfernen (vob-Position speichern)", "Usuń wszystko (zapisz pozycje voba)", "Odstranit vše (uložit pozici vobu)" });
            words.Add("buttonMoverResetKeyTo0", new List<string> { "Удалить все (поставить воб на 0 ключ)", "Remove all (set vob on 0 key)", "Alle entfernen (vob auf Taste 0 setzen)", "Usuń wszystko (ustaw voba na 0 klucz)", "Odstranit vše (nastavit vob na klávesu 0)" });
            words.Add("noSelectToolNowFilterMat", new List<string> { "Пока активно окно Фильтра материалов нельзя выключить выделение полигонов!", "You can't turn off polygons select tool while Material filter window is active!", "Du kannst das Polygonauswahlwerkzeug nicht ausschalten, während das Materialfilterfenster aktiv ist!", "Nie możesz wyłączyć narzędzia do zaznaczania poligonów gdy okno filtru materiałów jest aktywne!", "Nástroj pro výběr polygonů nelze vypnout, pokud je aktivní okno filtru materiálů!" });
            words.Add("TOGGLE_SCREENINFO", new List<string> { "Включить/отключить информацию на экране", "Toggle screen info", "Bildschirminfo umschalten", "Włącz/wyłącz informacje wyświetlane na ekranie", "Přepínání informací na obrazovce" });
            words.Add("RESTART_REQUIRED", new List<string> { "*требуется перезапуск", "*restart required", "*Neustart erforderlich", "*Wymagany restart", "*vyžadován restart" });
            words.Add("MOD_CAMERA_SYNC_ON", new List<string> { "Включен режим синхронизации камеры с вобом", "Camera sync mod is ON", "Kamera Sync Mod ist AN", "Tryb synchronizacji kamery jest WŁĄCZONY", "Synchronizace kamery je ZAPNUTA" });
            words.Add("MOD_CAMERA_SYNC_OFF", new List<string> { "Отключен режим синхронизации камеры с вобом", "Camera sync mod is OFF", "Kamera Sync Mod ist AUS", "Tryb synchronizacji kamery jest WYŁĄCZONY", "Synchronizace kamery je VYPNUTA" });
            words.Add("KEYS_MOD_CAMERA_SYNC", new List<string> { "Режим синхронизации камеры с вобом", "Camera sync mod with selected vob", "Kamera Sync Mod mit ausgewähltem vob", "Tryb synchronizacji kamery z wybranym vobem", "Synchronizace kamery s vybraným vobem" });
            words.Add("CONTEXTMENU_SAVE_VISUAL_TO_FILE", new List<string> { "Сохранить визуал для импорта в 3DMAX/Blender", "Save visual for importing in 3DMAX/Blender", "Visuelles zum Importieren in 3DMAX/Blender speichern", "Zapisz visual do importu w 3DSMAX/Blenderze", "Uložení vizuálu pro import do 3DMAX/Blenderu" });
            words.Add("CONTEXTMENU_SAVE_VISUAL_TO_FILE_CHILDREN", new List<string> { "Включая дочерние вобы", "Including children vobs", "Einschließlich Innere VOBs", "Wraz z dziećmi vobów", "Včetně dceřinných vobů" });
            words.Add("CONTEXTMENU_SAVE_VISUAL_TO_FILE_ONLY_PARENT", new List<string> { "Только родительский воб", "Only parent vob", "Nur Haupt VOBs", "Tylko rodzic voba", "Pouze rodičovský vob" });
            words.Add("VOB_VISUAL_SAVE_SUCCESS", new List<string> { "Успешно сохранено!", "Saved successfully!", "Erfolgreich gespeichert!", "Zapisano pomyślnie!", "Úspěšně uloženo!" });
            words.Add("VOB_VISUAL_SAVE_FAIL", new List<string> { "Не удалось сохранить!", "Fail to save file!", "Datei konnte nicht gespeichert werden!", "Nie udało się zapisać pliku!", "Nepodařilo se uložit soubor!" });
            words.Add("ROT_MOD_CHANGE", new List<string> { "Сменить режим вращения воба (WORLD/LOCAL/CAMERA)", "Change rotation mod (WORLD/LOCAL/CAMERA)", "Rotationsmodus ändern (WORLD/LOCAL/CAMERA)", "Zmiana trybu rotacji (WORLD/LOCAL/CAMERA)", "Změna módu otáčení (WORLD/LOCAL/CAMERA)" });
            words.Add("ACTION_FORBIDDEN", new List<string> { "Недопустимое действие!", "This action is forbidden!", "Diese Aktion ist verboten!", "To działanie jest zakazane!", "Tato činnost je zakázána!" });
            words.Add("SET_SELECT_FILTER_PFX", new List<string> { "Установлен фильтр выделения: Игнорировать PFX", "Selection filter set: Ignore PFX", "Filter Auswahl: PFX Ignorieren", "Ustawiony filtr wyboru: Ignoruj PFX", "Výběr sady filtrů: Ignorovat PFX" });
            words.Add("SET_SELECT_FILTER_NONE", new List<string> { "Установлен фильтр выделения: Нет", "Selection filter set: NONE", "Filter Auswahl: KEINE", "Ustawiony filtr wyboru: BRAK", "Výběr sady filtrů: ŽÁDNÝ" });
            words.Add("VOB_FILTER_IGNORE_PFX", new List<string> { "Игнорировать PFX", "Ignore PFX", "PFX Ignorieren", "Ignoruj PFX", "Ignoruj PFX" });
            words.Add("MSG_WRONG_COLOR_FORMAT", new List<string> { "Недопустимый формат цвета! Используйте формат RGBA '255 255 255 255'", "Wrong color format! Format is RGBA '255 255 255 255'", "Falsches Farbformat! Format ist RGBA '255 255 255 255'", "Zły format koloru! Prawidłowy format to '255, 255, 255, 255'", "Špatný formát barev! Formát je RGBA '255 255 255 255'" });
            words.Add("MSG_WRONG_COLOR_FORMAT_RANGE", new List<string> { "Допустимый диапазон цвета от 0 до 255!", "Valid color range is 0 to 255 ", "Gültiger Farbbereich ist 0 bis 255", "Dopuszczalny zakres koloru jest od wartości 0 do 255!", "Platný rozsah barev je 0 až 255!" });
            words.Add("VOB_INFO_VISUAL_COPIED", new List<string> { "Информация о визуале воба скопирована в буфер и консоль", "Vob's visual info copied to clipboard and console", "Visuelle Infos von VOBs in die Zwischenablage und Konsole kopiert", "Informacje dotyczące visuala voba zostały skopiowane do schowka i konsoli", "Vizuální informace vobu zkopírovany do schránky a konzole" });
            words.Add("changeFontToolStripMenuItem", new List<string> { "Настроить шрифт", "Font settings", "Schriftart Einstellungen", "Ustawienia czcionki", "Nastavení písma" });
            words.Add("setFontUIToolStripMenuItem", new List<string> { "Установить шрифт", "Set font", "Schriftart einstellen", "Ustaw czcionkę", "Nastavit písmo" });
            words.Add("resetDefaultToolStripMenuItem", new List<string> { "Сбросить шрифт по умолчанию", "Reset font to default", "Schriftart auf Standard zurücksetzen", "Ustaw domyślną czcionkę", "Obnovit výchozí písmo" });
            words.Add("TOP_MENU_CHANGE_ICONS_SCALE", new List<string> { "Сменить маштаб иконок", "Change icons scale", "Skalierung der Icons ändern", "Zmień skalę ikon", "Změna měřítka ikon" });
            words.Add("TOP_MENU_CHANGE_ICONS_DEFAULT", new List<string> { "Установить по умолчанию 1.0", "Set default 1.0", "Standardwert 1,0 einstellen", "Ustaw domyślną 1.0", "Nastavit výchozí hodnotu 1.0" });
            words.Add("RENAME_WIN_TITLE", new List<string> { "Опции переименования", "Rename options", "Optionen umbenennen", "Opcje zmiany nazwy", "Možnosti přejmenování" });
            words.Add("radioButtonRenameEmpty", new List<string> { "Установить пустое имя для всех вобов", "Set empty name for all vobs", "Leeren Namen für alle VOBs festlegen", "Ustaw pustą nazwę dla wszystkich vobów", "Nastavení prázdného jména pro všechny voby" });
            words.Add("radioButtonNameForAll", new List<string> { "Установить единое имя для всех вобов", "Set one name for all vobs", "Einen Namen für alle VOBs festlegen", "Ustaw jedną nazwę dla wszystkich vobów", "Nastavení jednoho jména pro všechny voby" });
            words.Add("radioButtonNameOneNumberPostfix", new List<string> { "Установить имя с числом в конце начиная с...", "Set one name with number postfix started from...", "Benenne mit nummerischem Anhang, beginnend ab...", "Ustaw jedną nazwę z liczbą postfix zaczynającą się od...", "Nastavení jednoho jména s číslem postfixu od..." });
            words.Add("PFX_EDITOR_WRONG_INPUT", new List<string> { "Введено недопустимое значение!", "Wrong input!", "Falsche Eingabe!", "Podano nieprawidłową wartość!", "Špatný vstup!" });
            words.Add("PFX_EDITOR_WRONG_INPUT_0_255", new List<string> { "Допустимый диапазон от 0 до 255!", "Allowed range is from 0 to 255", "Erlaubter Bereich ist von 0 bis 255!", "Dozwolony zakres jest od 0 do 255!", "Povolený rozsah je 0 až 255" });
            words.Add("PFX_EDITOR_WRONG_INPUT_NOT_NUMBER", new List<string> { "Введеная строка не является числом!", "Input text is not a number!", "Eingegebener Text ist keine Zahl!", "Wprowadzony tekst nie jest liczbą!", "Vstupní text není číslo!" });
            words.Add("PFX_EDITOR_WRONG_INPUT_CANTBE_NEGATIVE", new List<string> { "Данное поле не может быть отрицательным!", "This field can't be negative!", "Feld darf nicht Negativ sein!", "To pole nie może być ujemne!", "Toto pole nemůže být záporné!" });
            words.Add("PFX_EDITOR_WRONG_FORMAT_VECTOR3", new List<string> { "Правильный формат (вектор): 10.0 -20.0 55.0", "Correct format (vector): 10.0 -20.0 55.0", "Aktuelles Format (Vector): 10.0 -20.0 55.0", "Prawidłowy format (vector): 10.0, -20.0 55.0", "Správný formát (vektor): 10.0 -20.0 55.0" });
            words.Add("PFX_EDITOR_WRONG_FORMAT_COLOR", new List<string> { "Правильный формат (цвет, 3 числа от 0 до 255): 255 20 30", "Correct format (color, 3 numbers from 0 to 255): 255 20 30", "Aktuelles Format (Farbe, 3 Zahlen von 0 bis 255): 255 20 30", "Prawidłowy format (color, 3 liczby od 0 do 255): 255 20 30", "Správný formát (barva, 3 čísla od 0 do 255): 255 20 30" });
            words.Add("PFX_EDITOR_WRONG_FORMAT_VECTOR2", new List<string> { "Правильный формат (два числа): 5 8", "Correct format (two numbers): 5 8", "Aktuelles Format (zwei Zahlen): 5 8", "Prawidłowy format (dwie liczby): 5 8", "Správný formát (dvě čísla): 5 8" });
            words.Add("PFX_EDITOR_TITLE", new List<string> { "Редактор частиц", "Particles editor", "Partikel-Editor", "Edytor cząsteczek", "Editor částic" });
            words.Add("PFX_EDITOR_INSTANCE", new List<string> { "Инстанция PFX: ", "PFX instance: ", "PFX-Instanz: ", "Instancja PFX: ", "PFX instance: " });
            words.Add("PFX_EDITOR_PLAY_AGAIN", new List<string> { "Вызвать эффект снова", "Play effect again", "Effekt erneut abspielen", "Odtwórz efekt ponownie", "Znovu přehrát efekt" });
            words.Add("PFX_EDITOR_SAVE_ALL_FIELDS", new List<string> { "Сохранять все поля (даже пустые)", "Save all fields (even empty ones)", "Alle Felder speichern (auch leere)", "Zapisz wszystkie pola (również te puste)", "Uložit všechna pole (i prázdná)" });
            words.Add("PFX_EDITOR_SAVE_IN_FILE", new List<string> { "Сохранить в файл", "Save into a file", "In Datei speichern", "Zapisz do pliku", "Uložit do souboru" });
            words.Add("PFX_EDITOR_AUTO_PLAY", new List<string> { "Повторно вызвать эффект", "Repeat playing effect", "Effekt wiederholen", "Powtarzaj odtwarzany efekt", "Efekt opakovaného přehrávání" });
            words.Add("PFX_EDITOR_SET_NEAR_CAMERA", new List<string> { "Переместить эффект к камере", "Place effect near camera", "Platziere Effekt nahe der Kamera", "Ustaw efekt w pobliżu kamery", "Umístění efektu v blízkosti kamery" });
            words.Add("PFX_EDITOR_SET_NEAR_CAMERA_DONE", new List<string> { "Эффект перемещен к камере", "The effect was placed near camera", "Effekt wurde nahe der Kamera platziert", "Efekt został umieszony w pobliżu kamery", "Efekt byl umístěn v blízkosti kamery" });
            words.Add("PFX_EDITOR_REMOVE_EFFECT", new List<string> { "Удалить эффект с экрана", "Remove effect from screen", "Effekt vom Bildschirm entfernen", "Usuń efekt z ekranu", "Odstranit efekt z obrazovky" });
            words.Add("WIN_TOOLTIP_VISUAL_INFO", new List<string> { "Режим информации о визуале воба", "Vob's visual info mode", "VOBs visueller Info-Modus", "Tryb informacji wizualnych o Vobie", "Režim vizuálních informací vobu" });
            words.Add("WIN_TOOLTIP_NOGRASS", new List<string> { "Режим скрытия травы (nograss)", "No grass mode", "Kein Gras-Modus", "Tryb bez trawy", "Režim bez trávy" });


            words.Add("PFX_EDITOR_WARNING_WRONG_NAME", new List<string> { "Нельзя вызывать эффект из самого себя! Измените поле ppsCreateEm_s!", "You cannot call the effect from itself! Change the ppsCreateEm_s field!", "Du kannst den Effekt nicht von sich aus aufrufen! Ändere das ppsCreateEm_s Feld!", "Nie możesz wywołać efektu na samym sobie! Zmień pole ppsCreateEm_s!", "Efekt nelze přivolat sám od sebe! Změňte pole ppsCreateEm_s!" });
            words.Add("ERROR_REPORT_TITLE", new List<string> { "Поиск ошибок в ZEN", "Search errors in ZEN", "Suche nach Fehlern im ZEN", "Szukaj błędów w ZEN", "Hledání chyb ve ZENu" });
            words.Add("ERROR_REPORT_COLUMN_PROBLEM_TYPE", new List<string> { "Тип проблемы", "Problem type", "Art des Problems", "Rodzaj problemu", "Typ problému" });
            words.Add("ERROR_REPORT_COLUMN_PROBLEM_LEVEL", new List<string> { "Уровень ошибки", "Error level", "Fehlerquote", "Poziom błędu", "Úroveň chyb" });
            words.Add("ERROR_REPORT_COLUMN_PROBLEM_DESC", new List<string> { "Описание", "Description", "Beschreibung", "Opis", "Popis" });
            words.Add("ERROR_REPORT_COLUMN_PROBLEM_ACTION", new List<string> { "Действие", "Action", "Aktion", "Akcja", "Akce" });
            words.Add("ERROR_REPORT_BUTTON_FIND_ALL", new List<string> { "Найти все ошибки", "Find all errors", "Finde alle Fehler", "Znajdź wszystkie błędy", "Vyhledat všechny chyby" });
            words.Add("ERROR_REPORT_TYPE_INFO", new List<string> { "Оповещение", "Information", "Information", "Informacje", "Informace" });
            words.Add("ERROR_REPORT_TYPE_WARNING", new List<string> { "Предупреждение", "Warning", "Warnung", "Ostrzeżenie", "Varování" });
            words.Add("ERROR_REPORT_TYPE_CRITICAL", new List<string> { "Критическая ошибка", "Critical error", "Kritischer Fehler", "Błąd krytyczny", "Kritická chyba" });
            words.Add("ERROR_REPORT_TYPE_ALL", new List<string> { "Все", "All", "Alle", "Wszystko", "Vše" });
            words.Add("ERROR_REPORT_DOUBLE_CLICK", new List<string> { "Двойной клик для выбора...", "Double click to select...", "Doppelklick zum auswählen...", "Naciśnij dwa razy by zaznaczyć...", "Dvojklikem vyberte..." });
            words.Add("ERROR_REPORT_TEXT_MATERIAL", new List<string> { "Материал", "Material", "Material", "Materiał", "Materiál" });
            words.Add("ERROR_REPORT_TEXT_TEXTURE", new List<string> { "Текстура", "Texture", "Textur", "Tekstura", "Textura" });

      
            words.Add("ERROR_REPORT_NO_ERRORS", new List<string> { "Ошибки не найдены!", "Errors not found!", "Fehler nicht gefunden!", "Nie znaleziono błędów!", "Nebyly nalezeny chyby!" });
            words.Add("ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_NAME", new List<string> { "Подозрительное имя материала", "Suspicious material's name", "Name des verdächtigen Materials", "Podejrzana nazwa materiału", "Podezřelé jméno materiálu" });
            words.Add("ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_TEXTURE_BAD_NAME", new List<string> { "Неправильное имя текстуры", "Wrong texture name", "Falscher Texturname", "Zła nazwa tekstury", "Špatný název textury" });
            words.Add("ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_TEXTURE_NOT_FOUND", new List<string> { "Текстура не найдена", "Texture not found", "Textur nicht gefunden", "Tekstura nie znaleziona", "Textura nebyla nalezena" });
            words.Add("ERROR_REPORT_PROBLEM_TYPE_TRIGGER_NO_NAME", new List<string> { "Нет имени у триггера", "Trigger has no name", "Trigger hat keinen Namen", "Trigger nie ma nazwy", "Trigger nemá jméno" });
            words.Add("ERROR_REPORT_PROBLEM_TYPE_PFX_CANT_BE_PARENT", new List<string> { "PFX не может содержать в себе другие вобы!", "PFX vob can't contain vobs inside itself!", "PFX VOB kann keine VOBs in sich selbst enthalten!", "PFX nie może zawierać vobów wewnątrz siebie!", "PFX vob nemůže obsahovat voby uvnitř sebe!" });
            words.Add("ERROR_REPORT_PROBLEM_TYPE_ITEM_CANT_BE_PARENT", new List<string> { "oCItem не может содержать в себе другие вобы", "oCItem vob can't contain vobs inside itself!", "oCItem VOB kann keine VOBs in sich selbst enthalten!", "Vob oCItem nie może mieć w sobie vobów!", "oCItem vob nemůže obsahovat vob uvnitř sebe!" });
            words.Add("ERROR_REPORT_PROBLEM_TYPE_ITEM_NO_VISUAL", new List<string> { "oCItem не имеет визуала", "oCItem does not have a visual", "oCItem hat kein Aussehen", "oCItem nie ma ustawionego visuala", "oCItem nemá vizuál" });
            words.Add("ERROR_REPORT_PROBLEM_TYPE_ZCVOB_EMPTY_VISUAL", new List<string> { "zCVob не имеет визуала", "zCVob does not have a visual", "zCVob hat kein Aussehen", "zCVob nie ma ustawionego visuala", "zCVob nemá vizuál" });
            words.Add("ERROR_REPORT_PROBLEM_TYPE_FOG_ZONES", new List<string> { "Неверное количество zCZoneZFogDefault, должно быть 1", "Wrong number of zCZoneZFogDefault, must be 1", "Falsche Nummer von zCZoneZFogDefault, muss 1 sein", "Nieprawidłowa ilość obiektów zCZonezFogDefault, musi być tylko 1", "Špatné číslo zCZoneZFogDefault, musí být 1" });
            words.Add("ERROR_REPORT_PROBLEM_TYPE_VOB_ZONES", new List<string> { "Неверное количество zCZoneVobFarPlaneDefault, должно быть 1", "Wrong number of zCZoneVobFarPlaneDefault, must be 1", "Falsche Nummer von zCZoneVobFarPlaneDefault, muss 1 sein", "Nieprawidłowa ilość obiektów zCZoneVobFarPlaneDefault, musi być tylko 1", "Špatné číslo zCZoneVobFarPlaneDefault, musí být 1" });
            words.Add("ERROR_REPORT_PROBLEM_TYPE_MUSIC_ZONES", new List<string> { "Неверное количество oCZoneMusicDefault, должно быть 1", "Wrong number of oCZoneMusicDefault, must be 1", "Falsche Nummer von oCZoneMusicDefault, muss 1 sein", "Nieprawidłowa ilość obiektów oCZoneMusicDefault, musi być tylko 1", "Špatné číslo oCZoneMusicDefault, musí být 1" });
            words.Add("ERROR_REPORT_PROBLEM_TYPE_STARTPOINT", new List<string> { "Неверное количество zCVobStartpoint, должно быть 0 или 1", "Wrong number of zCVobStartpoint, must be 0 or 1", "Falsche Nummer von zCVobStartpoint, muss 0 oder 1 sein", "Nieprawidłowa ilość obiektów zCVobStartpoint, musi być albo 0 albo 1", "Špatné číslo zCVobStartpoint, musí být 0 nebo 1" });
            words.Add("ERROR_REPORT_PROBLEM_TYPE_EMPTY_NAME", new List<string> { "У объекта пустое имя", "The vob has an empty name", "Der VOB hat keinen Namen", "Vob ma pustą nazwę", "Vob má prázdný název" });

 
            words.Add("ERROR_REPORT_PROBLEM_TYPE_EMPTY_NAME_MOB_FOCUS", new List<string> { "oCMob не имеет focusName", "oCMob does not have focusName", "oCMob hat keinen focusName", "oCMob nie ma ustawionego focusName", "oCMob nemá focusName" });
            words.Add("CANT_CHANGE_PARENT_INTO_INSELF", new List<string> { "Нельзя установить родителя воба самого себя!", "Can't set vob parent as the vob itself!", "Ich kann dem Haupt VOB nicht als die VOB selbst festlegen!", "Nie można ustawić rodzica voba jako samego siebie!", "Nelze nastavit rodičovský vob jako samotný vob!" });
            words.Add("WIN_GRASS_INSERT_INTO_GLOBAL_PARENT", new List<string> { "Вставлять воб в Глобального родителя", "Insert the vob into Global parent", "Füge die VOB in die übergeordnete Gruppe ein", "Dodaj voba do globalnego rodzica", "Vložení vobu do globálního rodiče" });
            words.Add("SEWER_NO_PLACE_TO_PUT_VOB", new List<string> { "Нет места для размещения воба", "No place to put vob", "Kein Platz zum Ablegen von VOB", "Brak miejsca by dodać voba", "Není kam umístit vob" });
            words.Add("checkBoxSearchInRadius", new List<string> { "В радиусе:", "In radius:", "Im Radius:", "W promieniu:", "V rozsahu:" });
            words.Add("VOB_FILTER_IGNORE_DECALS", new List<string> { "Игнорировать zCDecal", "Ignore zCDecal", "Ignoriere zCDecal", "Ignoruj zCDecal", "Ignorovat zCDecal" });
            words.Add("VOB_FILTER_IGNORE_DECALS_PFX", new List<string> { "Игнорир. zCDecal и PFX", "Ignore zCDecal and PFX", "Ignoriere zCDecal und PFX", "Ignoruj zCDecal i PFX", "Ignorovat zCDecal a PFX" });
            words.Add("SET_SELECT_FILTER_DECALS_PFX", new List<string> { "Установлен фильтр выделения: Игнорировать zCDecal и PFX", "Selection filter set: zCDecal and PFX", "Auswahlfilterset: zCDecal und PFX", "Wybrany filtr: zCDecal i PFX", "Výběrová sada filtrů: zCDecal a PFX" });
            words.Add("KEYS_FAST_FILTER_IGNOREPFX", new List<string> { "Выбрать фильтр выделения вобов: Игнорировать zCDecal и PFX", "Choose vob filter selection mod: Ignore zCDecal и PFX", "Wähle VOB Filter Auswahl-Modus: Ignoriere zCDecal und PFX", "Wybierz filtr zaznaczania vobów: Ignoruj zCDecal i PFX", "Vyberte vob filtr režimu výběru: Ignorovat zCDecal a PFX" });
            words.Add("ERROR_NAME_CANT_CONTAIN_SPACE", new List<string> { "Имя не может содержать символ 'пробел'!", "Vob's name can't contain a space symbol!", "Name von VOBs darf kein Leerzeichen enthalten!", "Nazwa Voba nie może zawierać spacji", "Jméno vobu nemůže obsahovat symbol mezery!" });
            words.Add("ERROR_REPORT_PROBLEM_TYPE_NAME_SPACE", new List<string> { "В имени воба есть символ 'пробел'", "Vob's name contains a space symbol", "Name von VOB enthält ein Leerzeichen", "Nazwa Voba zawiera spację", "Jméno vobu obsahuje symbol mezery" });
            words.Add("ERROR_REPORT_PROBLEM_TYPE_NOT_UNIQ_NAME", new List<string> { "Имя воба не уникально", "Vob's name is not unique", "VOBs Name ist nicht einzigartig", "Nazwa Voba nie jest unikalna", "Jméno vobu není jedinečné" });

            words.Add("ERROR_REPORT_PROBLEM_TYPE_BAD_NAME_SYMBOLS", new List<string> { "Имя воба содержит недопустимые символы", "Vob's name contains bad symbols", "Der Name von VOB enthält falsche Symbole", "Nazwa Voba zawiera złe symbole", "Jméno Vob obsahuje špatné symboly" });
            words.Add("ERROR_REPORT_COPY_MAT_NAME", new List<string> { "Скопируйте имя материала и вставьте его в Фильтр материалов", "Copy material's name and copy it into Material Filter", "Kopiere den Namen des Materials und kopiere ihn in den Materialfilter", "Skopiuj nazwę materiału do filtru materiału", "Zkopírujte název materiálu a zkopírujte ho do Filtru materiálů" });


            words.Add("ERROR_REPORT_SAVE_REPORT", new List<string> { "Сохранить отчет в файл", "Save report to a file", "Bericht in eine Datei speichern", "Zapisz raport do pliku", "Uložit hlášení do souboru" });


            words.Add("SET_VOB_SET_ZERO_PARENT", new List<string> { "Воб помещен в центр родительского воба", "The vob is set to the center of parent vob", "Das VOB wird in die Mitte des übergeordneten VOBs gesetzt", "Vob jest ustawiony na środku voba rodzica", "Vob je nastaven do středu vobu rodiče" });
            words.Add("SET_VOB_SET_ZERO_PARENT_CANT", new List<string> { "У данного воба нет родителя!", "The vob does not have a parent vob!", "Das VOB hat kein übergeordnetes VOB!", "Vob nie ma voba rodzica!", "Tento vob nemá rodiče!" });
            words.Add("KEYS_VOB_SET_ZERO_PARENT", new List<string> { "Поместить воб в центр родительского воба", "Move the vob to the center of parent vob", "Verschiebe das VOB in die Mitte des übergeordneten VOBs", "Przenieś voba na środek voba rodzica", "Přesun vobu do středu vobu rodiče" });


            words.Add("ERROR_REPORT_PROBLEM_TYPE_NAME_IS_VISUAL", new List<string> { "Имя воба совпадает с его визуалом", "Vob's name is the same as its visual", "VOB Name ist identisch mit dem visuellen Objekt", "Nazwa Voba jest taka sama jak jego wygląd", "Jméno vobu je stejné jako jeho vizuál" });


            words.Add("WIN_VOBCATALOG_TITLE", new List<string> { "Каталог вобов", "Vobs catalog", "", "", "" });
            words.Add("WIN_VOBCATALOG_GROUP_NAME", new List<string> { "Имя группы: ", "Group name: ", "", "", "" });
            words.Add("WIN_VOBCATALOG_VISUAL_NAME", new List<string> { "Визуал: ", "Visual: ", "", "", "" });
            words.Add("WIN_VOBCATALOG_MATFILTER_TURNOFF", new List<string> { "Сначала закройте окно Фильтра материалов!", "Turn off Materials filter window first!", "", "", "" });
            words.Add("WIN_VOBCATALOG_POLYSELECT_TURNOFF", new List<string> { "Сначала выключите режим выделения полигонов!", "Turn off polygon select mod first!", "", "", "" });


        }

        
    }
}
