using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SpacerUnion.Common;

namespace SpacerUnion.Windows
{
    // Data model of the unified settings page.
    //
    // Every option of the old "Camera settings" / "Vobs settings" / "Misc settings" windows is
    // described here once: on which key it lives in the C++ settings stack, which localization key
    // prints its caption, how it is drawn and how it is found by the search box.
    //
    // The page itself (SettingsMain.cs) only knows how to build a row out of a Setting and how to
    // read / write its value — adding a new option is a single line in BuildCatalog().
    public partial class SettingsMain
    {
        // Categories of the left navigation list.
        private const string CAT_CAMERA = "camera";
        private const string CAT_VOBS = "vobs";
        private const string CAT_MISC = "misc";

        private enum SettingKind
        {
            CheckBox,       // single check box
            Track,          // caption + track bar, value is shown in the caption
            TrackBox,       // caption + track bar + editable numeric box
            Number,         // caption + numeric box
            RadioGroup,     // caption + a group of radio buttons
            CheckTrack      // check box with the value in its caption + track bar
        }

        // One option of the page: description + the controls generated for it.
        private class Setting
        {
            // --- description -------------------------------------------------------------
            public string Key = "";             // key used in the C++ settings stack
            public string SecondaryKey = "";     // second stack key (CheckTrack: the track bar)
            public string LocKey = "";           // localization key of the visible caption
            public string Category = CAT_MISC;   // category of the left navigation list
            public string Group = "";            // section title key inside the category
            public SettingKind Kind = SettingKind.CheckBox;

            public int Minimum;
            public int Maximum = 100;
            public int TickFrequency;
            public int Value;                    // current value: also answers GetFlag() / GetValue()
            public int TrackValue;               // value of the track bar of a CheckTrack option
            public bool ShowValueInCaption = true;
            public string ValueSeparator = ": ";
            public bool StoreLocally;             // value lives in Properties.Settings, not in the core
            public string HintLocKey;             // small note next to the option (like "*restart required")
            public string[] RadioKeys;            // radio group: localization keys of the options
            public int[] RadioValues;             // radio group: value written for every option
            public string DependsOnKey;           // option is enabled only while that option is used
            public bool InvertDependency;         // ... and only while it is NOT checked
            public Action<Setting> AfterChange;   // extra reaction after the value was written
            public Func<int> LocalGetter;         // reading of a StoreLocally option
            public Action<int> LocalSetter;       // writing of a StoreLocally option

            // --- generated controls ------------------------------------------------------
            public Control Row;                   // whole row: the search stripe is drawn on it
            public Control Main;                  // main interactive control of the row
            public Label Caption;                 // caption label (also used by the search)
            public TextBox Number;                // numeric box of TrackBox / Number
            public TrackBar Track;                // track bar of Track / TrackBox / CheckTrack
            public CheckBox Box;                  // check box of CheckBox / CheckTrack
            public Label Hint;                    // small note of a Number option
            public readonly List<RadioButton> Radios = new List<RadioButton>();
            public string SearchText = "";        // everything the search box matches against
            public bool IsMatch;                  // the current search query matches this option
            public bool Dirty;                    // the user changed the value: it has to be written back

            public bool Flag
            {
                get { return Value != 0; }
            }

            public string CaptionText
            {
                get { return Localizator.Get(LocKey); }
            }
        }

        // A titled box on the page holding a few options.
        private class Section
        {
            public GroupBox Box;
            public TableLayoutPanel Table;
            public string Category = "";
            public string TitleKey = "";
            public bool MainTitle;              // first box of its category: its title is printed bold
            public readonly List<Setting> Items = new List<Setting>();
        }

        // A category of the left navigation list.
        private class CategoryInfo
        {
            public string Id = "";
            public string TitleKey = "";
            public readonly List<Section> Sections = new List<Section>();

            public int Total
            {
                get
                {
                    int count = 0;
                    for (int i = 0; i < Sections.Count; i++)
                    {
                        count += Sections[i].Items.Count;
                    }
                    return count;
                }
            }
        }

        // The radio list field initializer above keeps the field declaration in one place.
        private class RadioButtonList : List<RadioButton>
        {
        }

        // Builds the description of every option of the page. Order = order on the page.
        private static List<Setting> BuildCatalog()
        {
            List<Setting> list = new List<Setting>();

            //========================================== CAMERA ==========================================
            string group = "groupBoxCam";

            list.Add(TrackBoxOption("camTransSpeed", "labelTrans", CAT_CAMERA, group, 1, 200));
            list.Add(TrackBoxOption("camRotSpeed", "labelRot", CAT_CAMERA, group, 1, 100));
            list.Add(TrackBoxOption("slerpRot", "labelCamSetSlerp", CAT_CAMERA, group, 0, 90, 10));

            group = "groupBoxRange";

            list.Add(TrackBoxOption("rangeWorld", "labelWorld", CAT_CAMERA, group, 100, 20000, 10));
            list.Add(TrackBoxOption("rangeVobs", "labelVobs", CAT_CAMERA, group, 100, 20000, 10));

            group = "groupBoxInfo";

            list.Add(CheckOption("showFps", "checkBoxFPS", CAT_CAMERA, group));
            list.Add(CheckOption("showTris", "checkBoxTris", CAT_CAMERA, group));
            list.Add(CheckOption("showCamCoords", "checkBoxCamCoord", CAT_CAMERA, group));
            list.Add(CheckOption("showVobsCount", "checkBoxVobs", CAT_CAMERA, group));
            list.Add(CheckOption("showWaypointsCount", "checkBoxWaypoints", CAT_CAMERA, group));
            list.Add(CheckOption("showVobDist", "checkBoxDistVob", CAT_CAMERA, group));
            list.Add(CheckOption("hideCamWindows", "checkBoxCameraHideWins", CAT_CAMERA, group));
            list.Add(CheckOption("showPortalsInfo", "checkBoxCamShowPortalsInfo", CAT_CAMERA, group));

            Setting limitFps = NumberOption("maxFPS", "labelLimitFPS", CAT_CAMERA, group, 0, 10000);
            limitFps.HintLocKey = "RESTART_REQUIRED";
            list.Add(limitFps);

            list.Add(TrackOption("previewSpeed", "labelSpeedPreview", CAT_CAMERA, group, 0, 100, 10));

            //=========================================== VOBS ===========================================
            group = "WIN_CONTROLSET_GROUP0";

            // The captions of these two end with ':' already, so they print the value directly.
            list.Add(TrackBoxOption("vobTransSpeed", "WIN_CONTROLSET_TRANSSPEED", CAT_VOBS, group, 1, 50000, 500));
            list.Add(TrackBoxOption("vobRotSpeed", "WIN_CONTROLSET_ROTSPEED", CAT_VOBS, group, 1, 200));

            group = "WIN_CONTROLSET_GROUP1";

            list.Add(CheckOption("vobInsertItemLevel", "checkBoxInsertVob", CAT_VOBS, group));
            list.Add(CheckOption("vobInsertVobRotRand", "checkBoxVobRotRandAngle", CAT_VOBS, group));
            list.Add(CheckOption("vobInsertHierarchy", "checkBoxVobInsertHierarchy", CAT_VOBS, group));
            list.Add(CheckOption("selectMoveWhenVobInsert", "checkBoxSelectMoveInsert", CAT_VOBS, group));
            list.Add(CheckOption("checkBoxShowVobTraceFloor", "checkBoxShowVobTraceFloor", CAT_VOBS, group));

            Setting turnMode = new Setting
            {
                Key = "wpTurnOn",
                LocKey = "labelRotWpFP",
                Category = CAT_VOBS,
                Group = group,
                Kind = SettingKind.RadioGroup,
                RadioKeys = new string[]
                {
                    "radioButtonWPTurnNone",
                    "radioButtonWPTurnAgainst",
                    "radioButtonWPTurnOn",
                    "radioButtonWPTurnOnRandom"
                },
                RadioValues = new int[] { 0, 1, 2, 3 },
                // The selected radio button says everything, no need to repeat the number.
                ShowValueInCaption = false
            };
            list.Add(turnMode);

            //=========================================== MISC ===========================================
            group = "";

            list.Add(CheckOption("addDatePrefix", "checkBoxSetDatePrefix", CAT_MISC, group));
            list.Add(CheckOption("askExitZen", "checkBoxMiscExitAsk", CAT_MISC, group));
            list.Add(CheckOption("fullPathTitle", "checkBoxMiscFullPath", CAT_MISC, group));
            list.Add(CheckOption("checkBoxSetNearestVobCam", "checkBoxSetNearestVobCam", CAT_MISC, group));
            list.Add(CheckOption("autoCompileWorldLight", "checkBoxMiscAutoCompile", CAT_MISC, group));
            list.Add(CheckOption("autoCompileWorldLightForUnc", "checkBoxMiscAutoCompileUncZen", CAT_MISC, group));
            list.Add(CheckOption("removeAllLevelCompos", "checkBoxMiscRemoveAllLevelCompos", CAT_MISC, group));
            list.Add(CheckOption("checkBoxAutoRemoveAllVisuals", "checkBoxAutoRemoveAllVisuals", CAT_MISC, group));
            list.Add(CheckOption("checkBoxShowPolysSort", "checkBoxShowPolysSort", CAT_MISC, group));
            list.Add(CheckOption("bFastLoad3DSLocation", "TITLE_3DS_FAST_MODE", CAT_MISC, group));
            list.Add(CheckOption("bSkipPolysCut", "checkBoxSkipPolysCut", CAT_MISC, group));
            list.Add(CheckOption("checkBoxOnlyLatinInInput", "checkBoxOnlyLatinInInput", CAT_MISC, group));

            // "Make some vob's fields to upper case" makes no sense when converting is disabled.
            Setting upperCase = CheckOption("bHandleNamesUpperCase", "checkBoxUpperCase", CAT_MISC, group);
            upperCase.DependsOnKey = "checkBoxDisableUpper";
            upperCase.InvertDependency = true;
            list.Add(upperCase);

            list.Add(CheckOption("checkBoxDisableUpper", "checkBoxDisableUpper", CAT_MISC, group));
            list.Add(CheckOption("bShowAmbientLightDx11", "checkBoxDx11Amb", CAT_MISC, group));
            list.Add(CheckOption("ignorePathWorkCheck", "MISC_SETTINGS_NO_WORK_CHECK", CAT_MISC, group));

            Setting autoSave = CheckTrackOption("checkBoxAutoSave", "checkBoxAutoSave", CAT_MISC, group, "autoSaveZenTime", 1, 60);
            list.Add(autoSave);

            Setting remind = CheckTrackOption("warnLastSaveMsg", "checkBoxRemind", CAT_MISC, group, "remindSaveTime", 1, 60);
            list.Add(remind);

            Setting statusBar = CheckOption("showStatusBar", "checkBoxShowStatusBar", CAT_MISC, group);
            statusBar.AfterChange = delegate(Setting s)
            {
                if (SpacerNET.form != null)
                {
                    SpacerNET.form.ApplyStatusBarVisibility(s.Flag);
                }
            };
            list.Add(statusBar);

            // Dark mode is an interface setting: it is stored in the user config, not in the core.
            Setting darkMode = CheckOption("DarkMode", "checkBoxDarkMode", CAT_MISC, group);
            darkMode.StoreLocally = true;
            darkMode.LocalGetter = delegate { return Properties.Settings.Default.DarkMode ? 1 : 0; };
            darkMode.LocalSetter = delegate(int value)
            {
                bool enabled = value != 0;

                if (Properties.Settings.Default.DarkMode == enabled)
                {
                    return;
                }

                Properties.Settings.Default.DarkMode = enabled;
                Properties.Settings.Default.Save();

                Theme.IsDark = enabled;
                Theme.RaiseChanged();
            };
            list.Add(darkMode);

            return list;
        }

        // A check box does not print a value: its state is the check mark itself.
        private static Setting CheckOption(string key, string locKey, string category, string group)
        {
            return new Setting
            {
                Key = key,
                LocKey = locKey,
                Category = category,
                Group = group,
                Kind = SettingKind.CheckBox,
                ShowValueInCaption = false
            };
        }

        private static Setting TrackOption(string key, string locKey, string category, string group, int min, int max, int tick)
        {
            return new Setting
            {
                Key = key,
                LocKey = locKey,
                Category = category,
                Group = group,
                Kind = SettingKind.Track,
                Minimum = min,
                Maximum = max,
                TickFrequency = tick,
                ShowValueInCaption = true
            };
        }

        private static Setting TrackBoxOption(string key, string locKey, string category, string group, int min, int max)
        {
            return TrackBoxOption(key, locKey, category, group, min, max, 0);
        }

        private static Setting TrackBoxOption(string key, string locKey, string category, string group, int min, int max, int tick)
        {
            Setting setting = TrackOption(key, locKey, category, group, min, max, tick);
            setting.Kind = SettingKind.TrackBox;
            return setting;
        }

        private static Setting NumberOption(string key, string locKey, string category, string group, int min, int max)
        {
            Setting setting = new Setting
            {
                Key = key,
                LocKey = locKey,
                Category = category,
                Group = group,
                Kind = SettingKind.Number,
                Minimum = min,
                Maximum = max,
                ShowValueInCaption = false
            };
            return setting;
        }

        private static Setting CheckTrackOption(string key, string locKey, string category, string group, string trackKey, int min, int max)
        {
            Setting setting = TrackOption(key, locKey, category, group, min, max, 0);
            setting.Kind = SettingKind.CheckTrack;
            setting.SecondaryKey = trackKey;
            setting.ValueSeparator = ""; // the localized captions end with ':' already
            return setting;
        }
    }
}
