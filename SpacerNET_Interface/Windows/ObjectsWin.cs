﻿
using SpacerUnion.Common;
using SpacerUnion.Windows;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static SpacerUnion.ObjTree;

namespace SpacerUnion
{


    public partial class ObjectsWin : Form
    {
        public static RenameForm renameWin = null;
        public static List<string> listVisualsVDF = new List<string>();
        public static List<string> listVisualsWORK = new List<string>();
        public TriggerEntry triggerEntry = new TriggerEntry();
        public CameraKeyEntry camEntry;


        static List<CProperty> searchProps = new List<CProperty>();
        static List<CProperty> compareProps = new List<CProperty>();
        static List<CProperty> newProps = new List<CProperty>();
        static List<CProperty> convertProps = new List<CProperty>();
        static int selectTabBlocked = 0;

        public Dictionary<string, List<string>> spawnListData;
        string pathFile;


        public static bool dontUpdateNumType = false;

        public ConfirmForm formConf;

        int onlyNameVisualSearch = 0;

        public ObjectsWin()
        {
            InitializeComponent();
            comboBoxSearchType.SelectedIndex = 0;
            comboBoxLightVobLightQuality.SelectedIndex = 1;
            comboBoxSphereType.SelectedIndex = 0;
            camEntry = new CameraKeyEntry(this);
            formConf = new ConfirmForm(null);
            spawnListData = new Dictionary<string, List<string>>();
            pathFile = Path.GetFullPath(@"../_work/tools/spawnlist_spacernet.txt");
        }


        public void Reset()
        {
            listBoxSearchResult.Items.Clear();
            comboBoxSearchType.SelectedIndex = 0;
            labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ":";
            UpdateLightWindow(false);
        }

        public void UpdateLang()
        {
            //ConsoleEx.WriteLineRed("WinObj:UpdateLang");

            this.Text = Localizator.Get("WIN_OBJ_TITLE");
            tabControlObjects.TabPages[0].Text = Localizator.Get("WIN_OBJ_TAB0");
            tabControlObjects.TabPages[1].Text = Localizator.Get("WIN_OBJ_TAB1");
            tabControlObjects.TabPages[2].Text = Localizator.Get("WIN_OBJ_TAB2");
            tabControlObjects.TabPages[3].Text = Localizator.Get("WIN_OBJ_TAB3");
            tabControlObjects.TabPages[4].Text = Localizator.Get("WIN_OBJ_TAB4");
            tabControlObjects.TabPages[5].Text = Localizator.Get("WIN_OBJ_TAB5");
            tabControlObjects.TabPages[6].Text = Localizator.Get("WIN_OBJ_TAB6");
            tabControlObjects.TabPages[7].Text = Localizator.Get("WIN_OBJ_TAB7");
            tabControlObjects.TabPages[8].Text = Localizator.Get("WIN_OBJ_TAB8");

            groupBoxObjAllClasses.Text = Localizator.Get("groupBoxObjAllClasses");
            groupBoxObjPropVobs.Text = Localizator.Get("groupBoxObjPropVobs");
            labelObjAllClassesNameVob.Text = Localizator.Get("labelObjAllClassesNameVob");
            buttonAllClassesCreateVob.Text = Localizator.Get("buttonAllClassesCreateVob");
            checkBoxDynStat.Text = Localizator.Get("checkBoxDynStat");
            checkBoxStaStat.Text = Localizator.Get("checkBoxStaStat");
            labelAllModels.Text = Localizator.Get("WIN_OBJ_ALLMODELS");
            labelSearchVisual.Text = Localizator.Get("WIN_OBJ_ALLMODELS");
            checkBoxShowPreview.Text = Localizator.Get("checkBoxShowPreview");
            checkBoxSearchOnly3DS.Text = Localizator.Get("checkBoxSearchOnly3DS");
            buttonAllClassesClear.Text = Localizator.Get("buttonAllClassesClear");

            groupBoxObjItems.Text = Localizator.Get("groupBoxObjItems");
            buttonItemsCreate.Text = Localizator.Get("buttonItemsCreate");
            buttonItemsCreateReg.Text = Localizator.Get("buttonItemsCreate");
            buttonAddContainer.Text = Localizator.Get("buttonAddContainer");
            groupBoxItemsCont.Text = Localizator.Get("groupBoxItemsCont");
            checkBoxItemShow.Text = Localizator.Get("checkBoxItemShow");
            labelItemsEditContCount.Text = Localizator.Get("labelItemsEditContCount");
            labelItemsAllItems.Text = Localizator.Get("labelItemsAllItems");
            labelItemsFindReg.Text = Localizator.Get("labelItemsFindReg");

            groupBoxPFX.Text = Localizator.Get("groupBoxPFX");
            buttonParticles.Text = Localizator.Get("buttonParticles");
            buttonCreatePFXReg.Text = Localizator.Get("buttonParticles");
            checkBoxShowPFXPreview.Text = Localizator.Get("checkBoxShowPFXPreview");
            checkBoxAddPFX.Text = Localizator.Get("checkBoxAddPFX");
            labelAllPfx.Text = Localizator.Get("labelAllPfx");
            labelSearchRegPFx.Text = Localizator.Get("labelItemsFindReg");



            labelFindVisualArchive.Text = Localizator.Get("labelFindVisualArchive");


            groupBoxTriggersVob.Text = Localizator.Get("groupBoxTriggersVob");
            groupBoxTriggersKeys.Text = Localizator.Get("groupBoxTriggersKeys");
            buttonSendTrigger.Text = Localizator.Get("buttonSendTrigger");
            buttonTriggerCollectSources.Text = Localizator.Get("buttonTriggerCollectSources");
            buttonNewKey.Text = Localizator.Get("buttonNewKey");
            buttonRemoveKey.Text = Localizator.Get("buttonRemoveKey");

            buttonRemoveMoverAllKeys.Text = Localizator.Get("buttonRemoveMoverAllKeys");
            buttonMoverResetKeyTo0.Text = Localizator.Get("buttonMoverResetKeyTo0");


            buttonTriggersJumpToKey.Text = Localizator.Get("Trigget_BTN_JUMPTOKEY");
            labelTriggerName.Text = Localizator.Get("labelTriggerName");
            labelTriggerCollision.Text = Localizator.Get("labelTriggerCollision");
            checkBoxDyn.Text = Localizator.Get("checkBoxDyn");
            checkBoxStat.Text = Localizator.Get("checkBoxStat");
            radioButtonOverwrite.Text = Localizator.Get("radioButtonOverwrite");
            labelTriggerInsert.Text = Localizator.Get("labelTriggerInsert");
            radioButtonAfter.Text = Localizator.Get("radioButtonAfter");
            radioButtonBefore.Text = Localizator.Get("radioButtonBefore");
            labelTriggerTargets.Text = Localizator.Get("labelTriggerTargets");
            labelTriggersSources.Text = Localizator.Get("labelTriggersSources");
            checkBoxShowMoverKeys.Text = Localizator.Get("checkBoxShowMoverKeys");


            groupBoxWPFP.Text = Localizator.Get("groupBoxWPFP");
            labelNameWPMandatory.Text = Localizator.Get("labelNameWPMandatory");
            labelFreepointMandatory.Text = Localizator.Get("labelFreepointMandatory");
            checkBoxWayNet.Text = Localizator.Get("checkBoxWayNet");
            checkBoxWPAutoName.Text = Localizator.Get("checkBoxWPAutoName");
            checkBoxFPGround.Text = Localizator.Get("checkBoxFPGround");
            checkBoxAutoNameFP.Text = Localizator.Get("checkBoxAutoNameFP");
            buttonWPCreate.Text = Localizator.Get("buttonWPCreate");
            buttonConnectWp.Text = Localizator.Get("buttonConnectWp");
            buttonDisconnectWP.Text = Localizator.Get("buttonDisconnectWP");
            buttonFPCreate.Text = Localizator.Get("buttonFPCreate");



            groupBoxSearchClasses.Text = Localizator.Get("all_vobs_classes");
            checkBoxSearchDerived.Text = Localizator.Get("search_derived");
            checkBoxSearchHasChildren.Text = Localizator.Get("checkBoxSearchHasChildren");
            checkBoxMatchNames.Text = Localizator.Get("checkBoxMatchNames");
            checkBoxSearchItem.Text = Localizator.Get("checkBoxSearchItem");




            checkBoxSearchInRadius.Text = Localizator.Get("checkBoxSearchInRadius");
            checkBoxSearchUseRegex.Text = Localizator.Get("search_use_regex");
            buttonSearchVobsDo.Text = Localizator.Get("VOB_SEARCH_TYPE0");
            buttonSearchVobsReset.Text = Localizator.Get("BTN_RESET");

            labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ":";


            comboBoxSearchType.Items.Clear();
            comboBoxSearchType.Items.Add(Localizator.Get("VOB_SEARCH_TYPE0"));
            comboBoxSearchType.Items.Add(Localizator.Get("VOB_SEARCH_TYPE1"));
            comboBoxSearchType.Items.Add(Localizator.Get("VOB_SEARCH_TYPE2"));
            comboBoxSearchType.Items.Add(Localizator.Get("VOB_SEARCH_TYPE3"));
            comboBoxSearchType.Items.Add(Localizator.Get("VOB_SEARCH_TYPE_DYNAMIC"));
            comboBoxSearchType.Items.Add(Localizator.Get("VOB_SEARCH_TYPE_SINGLE_WP"));
            comboBoxSearchType.Items.Add(Localizator.Get("VOB_SEARCH_TYPE_RENAME")); //index 6
            comboBoxSearchType.SelectedIndex = 0;

            radioButtonConvertOld.Text = Localizator.Get("VOB_SEARCH_CONVERT_RADIO0");
            radioButtonConvertNew.Text = Localizator.Get("VOB_SEARCH_CONVERT_RADIO1");

            labelRenameVob.Text = Localizator.Get("labelRenameVob");

            groupBoxItemsLocator.Text = Localizator.Get("groupBoxItemsLocator");
            checkBoxLocatorEnabled.Text = Localizator.Get("checkBoxLocatorEnabled");
            checkBoxLocatorOnlySusp.Text = Localizator.Get("checkBoxLocatorOnlySusp");
            comboBoxLocatorItemType.Items[0] = Localizator.Get("VOBLIST_TYPE_ANY");

            checkBoxLocatorByName.Text = Localizator.Get("checkBoxLocatorByName");
            labelItemLocatorRadius.Text = Localizator.Get("labelItemLocatorRadius") + trackBarLocatorRad.Value;




            // camera
            groupBoxCameraNew.Text = Localizator.Get("groupBoxCameraNew");
            labelCamNewName.Text = Localizator.Get("FORM_COMMON_NAME");
            buttonCamInsert.Text = Localizator.Get("FORM_COMMON_CREATE");


            groupBoxCamKeys.Text = Localizator.Get("groupBoxCamKeys");
            buttonCamSpline.Text = Localizator.Get("buttonCamSpline");
            buttonCamTargetSpline.Text = Localizator.Get("buttonCamTargetSpline");


            groupBoxCamSettings.Text = Localizator.Get("groupBoxCamSettings");
            labelCamTimeSec.Text = Localizator.Get("labelCamTimeSec");
            checkBoxCameraHide.Text = Localizator.Get("checkBoxCameraHide");
            checkBoxAutoRenameKeys.Text = Localizator.Get("WIN_CAMERA_AUTO_RENAME");

            if (camEntry.cameraRun)
            {
                buttonCamPlay.Text = Localizator.Get("WIN_CAMERA_STOP");
            }
            else
            {
                buttonCamPlay.Text = Localizator.Get("WIN_CAMERA_START");
            }

            labelCamGotoKey.Text = Localizator.Get("labelCamGotoKey");

            contextMenuStripCam.Items[0].Text = Localizator.Get("FORM_COMMON_DELETE");
            contextMenuStripCam.Items[1].Text = Localizator.Get("FORM_CAMERA_INSERT_KEY_HERE");

            contextMenuStripCamTarget.Items[0].Text = Localizator.Get("FORM_COMMON_DELETE");
            contextMenuStripCamTarget.Items[1].Text = Localizator.Get("FORM_CAMERA_INSERT_KEY_HERE");

            // light
            groupBoxLightPresetProperties.Text = Localizator.Get("groupBoxLightPresetProperties");
            labelLightPresetName.Text = Localizator.Get("labelLightPresetName");
            buttonNewLightPreset.Text = Localizator.Get("buttonNewLightPreset");
            buttonDeleteSelectedLightPreset.Text = Localizator.Get("buttonDeleteSelectedLightPreset");
            buttonSaveLightPresets.Text = Localizator.Get("buttonSaveLightPresets");
            buttonUpdateLightPresetOnLightVobs.Text = Localizator.Get("buttonUpdateLightPresetOnLightVobs");
            buttonUpdateLightPresetFromLightVob.Text = Localizator.Get("buttonUpdateLightPresetFromVob");
            buttonUsePresetOnLightVob.Text = Localizator.Get("buttonUsePresetOnLightVob");
            groupBoxLightSelected.Text = Localizator.Get("groupBoxLightSelected_Preset");
            labelLightVobName.Text = Localizator.Get("labelLightVobName");
            groupBoxLightType.Text = Localizator.Get("groupBoxLightType");
            checkBoxShowLightVobRadius.Text = Localizator.Get("checkBoxShowLightVobRadius");
            checkBoxLightVobInstantCompile.Text = Localizator.Get("checkBoxLightVobInstantCompile");
            buttonCreateLightVob.Text = Localizator.Get("buttonCreateLightVob");
            buttonApplyChangesLight.Text = Localizator.Get("BTN_APPLY");
            radioButtonLightVobStatic.Text = Localizator.Get("radioButtonLightVobStatic");
            radioButtonLightVobDynamic.Text = Localizator.Get("radioButtonLightVobDynamic");
            groupBoxLightColorProperties.Text = Localizator.Get("groupBoxLightColorProperties");
            groupBoxLightRangeProperties.Text = Localizator.Get("groupBoxLightRangeProperties");
            buttonMoveLightPresetColorUp.Text = Localizator.Get("BTN_UP");
            buttonMoveLightPresetColorDown.Text = Localizator.Get("BTN_DOWN");
            buttonMoveLightPresetRangeAniScaleUp.Text = Localizator.Get("BTN_UP");
            buttonMoveLightPresetRangeAniScaleDown.Text = Localizator.Get("BTN_DOWN");


            labelSpawnLocations.Text = Localizator.Get("WIN_SPAWN_PRESETS") + ":";
            labelScriptFunction.Text = Localizator.Get("WIN_SPAWN_SCRIPT_FUNCTIONS");
            labelSpawnShowRadius.Text = Localizator.Get("WIN_SPAWN_LABEL_RADIUS");
            groupBoxLocations.Text = Localizator.Get("WIN_SPAWN_PRESETS");
            groupBoxFunctions.Text = Localizator.Get("WIN_SPAWN_GROUPBOX_FUNCTIONS");

            buttonSpawnSetRadius.Text = Localizator.Get("WIN_SPAWN_BUTTON_RADIUS");
            buttonSpawnClear.Text = Localizator.Get("WIN_SPAWN_BUTTON_CLEAR");
            buttonSpawnDo.Text = Localizator.Get("WIN_SPAWN_BUTTON_SHOW");

            buttonLocationSpawnNew.Text = Localizator.Get("WIN_VOBCATALOG_BTN_ELEM_ADD");
            buttonLocationRename.Text = Localizator.Get("buttonMacrosRenameCurrent");
            buttonLocationDelete.Text = Localizator.Get("WIN_VOBCATALOG_BTN_ELEM_REMOVE");
            buttonFuncAdd.Text = Localizator.Get("WIN_SPAWN_ADD_NEW_FUNCTION");
            buttonFuncDelete.Text = Localizator.Get("WIN_VOBCATALOG_BTN_ELEM_REMOVE");
            buttonSpawnSaveBase.Text = Localizator.Get("WIN_SPAWN_SAVE_FILE");


            //comboBoxSphereType.Items[0] = Localizator.Get("OPTION_CHECK_NONE");
            comboBoxSphereType.Items[1] = Localizator.Get("LIGHT_EDITOR_SPHERE_TYPE_ORBITS");
            comboBoxSphereType.Items[2] = Localizator.Get("LIGHT_EDITOR_SPHERE_TYPE_SPHERE");

        }


        public void OnClose()
        {
            Imports.Extern_Light_SavePresets();
        }

        public void SetHintWPFP()
        {
            //ConsoleEx.WriteLineRed("SetHintWPFP");

            string text = String.Format(Localizator.Get("FORM_HINT_INSERT_WPFP"), SpacerNET.keysWin.keysTable["WP_CREATEFAST"]);

            labelHintWP.Text = text;
            labelHintFP.Text = text;


        }

        public void LoadSettings()
        {
            Imports.Stack_PushString("showModelPreview");
            checkBoxShowPreview.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());

            Imports.Stack_PushString("searchOnly3DS");
            checkBoxSearchOnly3DS.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());

            Imports.Stack_PushString("addWPToNet");
            checkBoxWayNet.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());

            Imports.Stack_PushString("addWPAutoName");
            checkBoxWPAutoName.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());

            Imports.Stack_PushString("downFPToGround");
            checkBoxFPGround.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());

            Imports.Stack_PushString("addFPAutoName");
            checkBoxAutoNameFP.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());

            Imports.Stack_PushString("itemLocatorEnabled");
            checkBoxLocatorEnabled.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());

            Imports.Stack_PushString("itemLocatorOnlySusp");
            checkBoxLocatorOnlySusp.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());

            Imports.Stack_PushString("itemLocatorOnlyByName");
            checkBoxLocatorByName.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());

            Imports.Stack_PushString("itemLocatorRadius");
            trackBarLocatorRad.Value = Imports.Extern_GetSetting();

            GetVdfArchivesList();

            comboBoxLocatorItemType.SelectedIndex = 0;

            Imports.Stack_PushString("showLightRadiusVob");
            SpacerNET.objectsWin.checkBoxShowLightVobRadius.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());


            Imports.Stack_PushString("showMoverKeysVisually");
            checkBoxShowMoverKeys.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());



            Imports.Stack_PushString("showSpawnListRadius");
            textBoxSpawnSetRad.Text = Imports.Extern_GetSetting().ToString();




            Imports.Stack_PushString("sphereWireColorR");
            int r = Imports.Extern_GetSetting();

            Imports.Stack_PushString("sphereWireColorG");
            int g = Imports.Extern_GetSetting();

            Imports.Stack_PushString("sphereWireColorB");
            int b = Imports.Extern_GetSetting();

            panelColor.BackColor = Color.FromArgb(r, g, b);



            Imports.Stack_PushString("bDrawRadiusValue");
            checkBoxShowLightRadiusAsText.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());

            Imports.Stack_PushString("sphereDrawMode");
            comboBoxSphereType.SelectedIndex = Convert.ToInt32(Imports.Extern_GetSetting());


            Imports.Stack_PushString("bCameraAutoRenameKeys");
            SpacerNET.objectsWin.checkBoxAutoRenameKeys.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());

        }

        public void GetVdfArchivesList()
        {
            DirectoryInfo d = new DirectoryInfo(@"./Data/");

            FileInfo[] Files = d.GetFiles("*.vdf");

            comboBoxArchiveList.Items.Clear();

            comboBoxArchiveList.Items.Add("-");

            foreach (FileInfo file in Files)
            {
                comboBoxArchiveList.Items.Add(file.Name);
            }

            comboBoxArchiveList.SelectedIndex = 0;
        }

        [DllExport]
        public static void AddPacticleToList()
        {
            string name = Imports.Stack_PeekString();

            SpacerNET.objectsWin.listBoxParticles.Items.Add(name);
        }

        [DllExport]
        public static void AddPacticleToListNew()
        {
            string name = Imports.Stack_PeekString();

            SpacerNET.objectsWin.listBoxParticles.Items.Add(name);
            SpacerNET.objectsWin.listBoxParticles.SelectedIndex = SpacerNET.objectsWin.listBoxParticles.Items.Count - 1;
            SpacerNET.objectsWin.listBoxParticles.TopIndex = SpacerNET.objectsWin.listBoxParticles.SelectedIndex;
        }

        public static HashSet<string> ignoreFileNameSet = new HashSet<string>()
        {
            ".WAV", ".DAT", ".D", ".FNT", ".BIN", ".ZEN", ".M3D", ".BMP", ".SGT",
            ".DLI", ".DLS", ".STY", ".PML", ".TXT", ".DLE", ".MI", ".DDS",
            ".TEX", ".FNT", ".DAT", ".MRM", ".ZEN", ".BIN", ".MDM", ".MAN", ".MDH", ".MSB", ".MAN1", ".MMB", ".WAV", ".MDL",
            ".DLL", ".M3D", ".BMP", ".MSH", ".MMS", ".TGA", ".MDS", ".SCC", ".3DS", ".SGT", ".DLS", ".STY", ".RAR", ".D",
            ".CSL", ".LSC", ".SRC", ".INF", ".INI", ".BAK", ".BIK", ".GSP", ".FBX", "", ".LNK", ".EXE", ".MOD", ".NSH",
            ".RTF", ".BAT", ".NSI", ".VM", ".PML", ".OPF", ".CONFIG", ".XML", ".ZMF", ".DLE", ".TXT", ".DLI", ".CFG",
            ".LOG", ".DLL2", ".EXP", ".IOBJ", ".IPDB", ".LIB", ".PDB", ".LAST", ".MTL", ".OBJ", ".PNG", ".MCACHE",
            ".VI", ".H", ".HLSL", ".FX", ".FXH", ".DDS", ".MI", ".JPG", ".MANIFEST", ".FLT", ".RPT", ".TLB",
            ".PATCH", ".SAV", ".BMP$",

            // ".TEX", ".MRM", ".MDM", ".MAN", ".MDH", ".MSB", ".MMB", ".MDL", ".MSH", ".MMS", ".MDS"
        };

        public static Dictionary<string, string> allowedFileNames = new Dictionary<string, string>
        {      
            //  1        1                              1               1                        1
            //".TEX", ".MRM", ".MDM", ".MAN", ".MDH", ".MSB", ".MMB", ".MDL", ".MSH", ".MMS", ".MDS"
            
            {".TGA", ".TGA" },
            {"-C.TEX", ".TGA" },

            {".3DS", ".3DS" },
            {".MRM", ".3DS" },
            {".MSH ", ".3DS" },

            {".ASC", ".ASC" },
            {".MDL", ".ASC" },
            //{".MAN", ".ASC" },
            {".MDH", ".ASC" },


            {".MDS", ".MDS" },
            {".MSB", ".MDS" },
            {".MBH", ".MMS" },



        };

        public static bool IsFileAllowed(StringBuilder name)
        {
            string checkStr = name.ToString();

            foreach (var item in allowedFileNames)
            {
                if (checkStr.EndsWith(item.Key))
                {
                    name = name.Replace(item.Key, item.Value);
                    return true;
                }
            }

            return false;
        }

        public static void AddVisualsFiles(string name, bool isVDF = true)
        {
            StringBuilder fileName = new StringBuilder();

            fileName.Append(name);

            if (IsFileAllowed(fileName))
            {
                if (isVDF)
                {
                    ObjectsWin.listVisualsVDF.Add(fileName.ToString());
                }
                else
                {
                    ObjectsWin.listVisualsWORK.Add(fileName.ToString());
                }
            }


        }

        [DllExport]
        public static void AddVisualToListVDF()
        {
            string name = Imports.Stack_PeekString();

            AddVisualsFiles(Path.GetFileName(name).ToUpper());

        }

        [DllExport]
        public static void AddVisualToListWORK()
        {
            string name = Imports.Stack_PeekString();

            AddVisualsFiles(Path.GetFileName(name).ToUpper(), false);
        }



        [DllExport]
        public static void SortVisuals()
        {
            ObjectsWin.listVisualsVDF = ObjectsWin.listVisualsVDF.Distinct().ToList();
            ObjectsWin.listVisualsVDF.Sort();


            ObjectsWin.listVisualsWORK = ObjectsWin.listVisualsWORK.Distinct().ToList();
            ObjectsWin.listVisualsWORK.Sort();



            //UnionNET.partWin.labelSearchVisual.Text = "Поиск визуала. Всего: " + listVisualsVDF.Count + "/" + listVisualsWORK.Count;
            SpacerNET.objectsWin.labelAllModels.Text = Localizator.Get("WIN_OBJ_ALLMODELS") + ": " + listVisualsVDF.Count + "/" + listVisualsWORK.Count;
        }


        [DllExport]
        public static void SortPFX()
        {
            //UnionNET.partWin.listBoxParticles.Sorted = true;
            ListBox lstBox = SpacerNET.objectsWin.listBoxParticles;
            Utils.SortListBox(lstBox);

            SpacerNET.objectsWin.groupBoxPFX.Text += ", " + Localizator.Get("WIN_OBJ_ALL")
                + ": " + SpacerNET.objectsWin.listBoxParticles.Items.Count;
        }

        [DllExport]
        public static void AddItemToList()
        {
            ListBox listBox = SpacerNET.objectsWin.listBoxItems;
            string name = Imports.Stack_PeekString();

            int index = listBox.Items.Add(name);
        }

        [DllExport]
        public static void SortItems()
        {
            //UnionNET.partWin.listBoxItems.Sorted = true;
            Utils.SortListBox(SpacerNET.objectsWin.listBoxItems);

            SpacerNET.objectsWin.groupBoxObjItems.Text += ", " + Localizator.Get("WIN_OBJ_ALL")
                + ": " + SpacerNET.objectsWin.listBoxItems.Items.Count;
        }

        private void ParticleWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            SpacerNET.form.SetIconActive("object", false);
        }




        private void buttonItems_Click(object sender, EventArgs e)
        {
            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            if (listBoxItems.SelectedItem == null)
            {
                return;
            }
            string name = listBoxItems.GetItemText(listBoxItems.SelectedItem);

            //Console.WriteLine("Create item: " + name);


            //SpacerNET.infoWin.AddText("Создаю Item " + name);

            Imports.Extern_KillPreviewItem();

            //ConsoleEx.WriteLineYellow("=========================");
            Imports.Stack_PushString(name);
            Imports.Extern_CreateItem();
            //ConsoleEx.WriteLineYellow("=========================");
            SpacerNET.form.Focus();



        }

        private void textBoxItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string strToFind = textBoxItems.Text.Trim().ToUpper();

                Regex regEx = null;

                try
                {
                    regEx = new Regex(@strToFind, RegexOptions.IgnoreCase | RegexOptions.Compiled);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show(Localizator.Get("BAD_REGEX"));
                    return;
                }


                listBoxResultItems.Items.Clear();


                for (int i = 0; i < listBoxItems.Items.Count; i++)
                {
                    string value = listBoxItems.GetItemText(listBoxItems.Items[i]);

                    if (Regex.IsMatch(value, @strToFind))
                    {
                        listBoxResultItems.Items.Add(value);
                    }
                }
            }
        }

        private void textBoxItems_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxItems_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonParticles_Click(object sender, EventArgs e)
        {
            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            if (listBoxParticles.SelectedItem == null)
            {
                return;
            }
            string name = listBoxParticles.GetItemText(listBoxParticles.SelectedItem);


            //SpacerNET.infoWin.AddText("Создаю PFX " + name);


            Imports.Stack_PushString(name);
            Imports.Extern_CreatePFX();
            Imports.Extern_KillPFX();

            SpacerNET.form.Focus();
        }

        static int deep = 0;

        public static void FindClass(TreeNodeCollection nodes, string name, ZenGinClass entry)
        {


            if (entry.parentName == String.Empty)
            {
                TreeNode newNode = nodes.Add(name + entry.postFix);
                newNode.Tag = entry;
                SpacerNET.objectsWin.comboBoxSearchClass.Items.Add(name);
                return;
            }

            deep++;

            for (int i = 0; i < nodes.Count; i++)
            {
                ZenGinClass objNode = nodes[i].Tag as ZenGinClass;

                if (objNode != null)
                {
                    if (objNode.name == entry.parentName)
                    {
                        TreeNode newNode = nodes[i].Nodes.Add(name + entry.postFix);
                        newNode.Tag = entry;

                        if (name != "oCNpc")
                        {
                            SpacerNET.objectsWin.comboBoxSearchClass.Items.Add(new String('.', deep * 2) + name);
                        }

                    }
                }

                FindClass(nodes[i].Nodes, entry.name, entry);

            }
            deep--;


        }

        public class ZenGinClass
        {
            public string name;
            public string parentName;
            public string postFix;
            public TreeNode node;
        };


        static Dictionary<string, ZenGinClass> classesList = new Dictionary<string, ZenGinClass>();

        [DllExport]
        public static void FillClassNodes()
        {
            TreeNodeCollection nodes = SpacerNET.objectsWin.classesTreeView.Nodes;

            foreach (var entry in classesList)
            {
                FindClass(nodes, entry.Key, entry.Value);
            }

            SpacerNET.objectsWin.classesTreeView.ExpandAll();
            SpacerNET.objectsWin.classesTreeView.SelectedNode = SpacerNET.objectsWin.classesTreeView.Nodes[0];
            SpacerNET.objectsWin.classesTreeView.SelectedNode.EnsureVisible();
            SpacerNET.objectsWin.comboBoxSearchClass.SelectedIndex = 0;
        }

        [DllExport]
        public static void AddClassNode()
        {
            string postFixName = Imports.Stack_PeekString();
            string name = Imports.Stack_PeekString();
            string baseClassName = Imports.Stack_PeekString();



            classesList.Add(name, new ZenGinClass()
            {
                name = name,
                parentName = baseClassName,
                postFix = postFixName
            }
            );




            // ConsoleEx.WriteLineGreen(String.Format("prefixName: {0}, name: {1}, baseClassName: {2}", postFixName, name, baseClassName));

            return;
            /*

            if (name == baseClassName)
            {
                TreeNode node = nodes.Add(prefixName);
                node.Tag = name.ToString();
                return;
            }

            FindClass(nodes, prefixName, name);

            SpacerNET.objectsWin.comboBoxSearchClass.Items.Add(name);
            SpacerNET.objectsWin.comboBoxSearchClass.SelectedIndex = 0;

            SpacerNET.objectsWin.classesTreeView.ExpandAll();
            SpacerNET.objectsWin.classesTreeView.SelectedNode = SpacerNET.objectsWin.classesTreeView.Nodes[0];
            SpacerNET.objectsWin.classesTreeView.SelectedNode.EnsureVisible();
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            if (classesTreeView.SelectedNode == null)
            {
                return;
            }

            ZenGinClass entry = classesTreeView.SelectedNode.Tag as ZenGinClass;

            if (entry == null)
            {
                return;
            }


            string name = entry.name;
            string vobName = textBoxVobName.Text.Trim();



            if (vobName.Length > 0 && !Utils.IsOnlyLatin(vobName) && Utils.IsOptionActive("checkBoxOnlyLatinInInput"))
            {
                MessageBox.Show(Localizator.Get("FORM_ENTER_BAD_STRING_INPUT"));
                return;
            }
            string visualVob = "";
            int isDyn = Convert.ToInt32(checkBoxDynStat.Checked);
            int isStat = Convert.ToInt32(checkBoxStaStat.Checked);


            if (listBoxVisuals.SelectedItem != null)
            {
                visualVob = listBoxVisuals.GetItemText(listBoxVisuals.SelectedItem);
            }


            ConsoleEx.WriteLineGreen("OnCreateVob: ClassDef: " + name);

            if (name == "oCItem" || name == "zCVobWaypoint" || name == "zCVobSpot" || name == "zCCSCamera" || name == "zCCamTrj_KeyFrame")
            {
                MessageBox.Show(Localizator.Get("WIN_OBJ_TYPE_CANTHERE"));
                return;
            }

            textBoxVobName.Text = "";


            Imports.Stack_PushString(visualVob);
            Imports.Stack_PushString(vobName);
            Imports.Stack_PushString(name);
            Imports.Stack_PushInt(0); //isStaticVob
            Imports.Extern_CreateNewVobVisual(isDyn, isStat);



        }

        private void classesTreeView_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (e.Node == null) return;

            // if treeview's HideSelection property is "True", 
            // this will always returns "False" on unfocused treeview
            var selected = (e.State & TreeNodeStates.Selected) == TreeNodeStates.Selected;
            var unfocused = !e.Node.TreeView.Focused;

            // we need to do owner drawing only on a selected node
            // and when the treeview is unfocused, else let the OS do it for us
            if (selected && unfocused)
            {
                var font = e.Node.NodeFont ?? e.Node.TreeView.Font;
                e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.Node.Text, font, e.Bounds, SystemColors.HighlightText, TextFormatFlags.GlyphOverhangPadding);
            }
            else
            {
                e.DrawDefault = true;
            }
        }

        private void buttonFP_Click(object sender, EventArgs e)
        {


        }

        [DllExport]
        public static void HotKey_AddWaypoint()
        {
            SpacerNET.objectsWin.buttonWPCreate.PerformClick();
        }

        private void buttonWP_Click(object sender, EventArgs e)
        {
            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            string name = "zCVobWaypoint";
            string vobName = textBoxWP.Text.Trim();
            bool addToNet = checkBoxWayNet.Checked;
            bool autoGenerate = checkBoxWPAutoName.Checked;

            if (vobName.Length == 0)
            {
                MessageBox.Show(Localizator.Get("WIN_OBJ_NO_EMPTY_NAME"));
                return;
            }

            if (vobName.Length > 0 && !Utils.IsOnlyLatin(vobName) && Utils.IsOptionActive("checkBoxOnlyLatinInInput"))
            {
                MessageBox.Show(Localizator.Get("FORM_ENTER_BAD_STRING_INPUT"));
                return;
            }

            if (vobName.All(char.IsDigit))
            {
                MessageBox.Show(Localizator.Get("WIN_OBJ_NO_WAYPOINT_NUMBERSONLY"));
                return;
            }

            if (vobName.Contains(' '))
            {
                MessageBox.Show(Localizator.Get("ERROR_NAME_CANT_CONTAIN_SPACE"));
                return;
            }


            Imports.Stack_PushString(vobName);
            int nameFound = Imports.Extern_VobNameExist(true);

            if (nameFound == 1 && !autoGenerate)
            {
                MessageBox.Show(Localizator.Get("NAME_ALREADY_EXISTS"));

                return;
            }


            ConsoleEx.WriteLineGreen("OnCreateVob: ClassDef: " + name);


            Imports.Stack_PushString(vobName);
            Imports.Stack_PushString(name);

            Imports.Extern_CreateWaypoint(addToNet, autoGenerate);

            SpacerNET.form.Focus();
            /*
            if (vobName.Contains("_"))
            {
                string strNumber = Regex.Match(vobName, @"_\d+$").Value.Replace("_", "");
                string strName = Regex.Match(vobName, @"^.*_").Value.Replace("_", "");

                int number;
                int.TryParse(strNumber, out number);
                number++;
                textBoxWP.Text = strName + "_" + number.ToString();
            }
            */
        }

        private void buttonFP_Click_1(object sender, EventArgs e)
        {
            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;

            }
            string name = "zCVobSpot";

            string vobName = textBoxFP.Text.Trim();
            bool autoName = checkBoxAutoNameFP.Checked;
            bool ground = checkBoxFPGround.Checked;

            if (vobName.Length == 0)
            {
                MessageBox.Show(Localizator.Get("WIN_OBJ_NO_EMPTY_NAME"));
                return;
            }

            if (vobName.Length > 0 && !Utils.IsOnlyLatin(vobName) && Utils.IsOptionActive("checkBoxOnlyLatinInInput"))
            {
                MessageBox.Show(Localizator.Get("FORM_ENTER_BAD_STRING_INPUT"));
                return;
            }

            if (vobName.Contains(' '))
            {
                MessageBox.Show(Localizator.Get("ERROR_NAME_CANT_CONTAIN_SPACE"));
                return;
            }

            Imports.Stack_PushString(vobName);

            int nameFound = Imports.Extern_VobNameExist(false);
            if (nameFound == 1)
            {

                MessageBox.Show(Localizator.Get("NAME_ALREADY_EXISTS"));
                return;
            }

            ConsoleEx.WriteLineGreen("OnCreateVob: ClassDef: " + name);


            Imports.Stack_PushString(vobName);
            Imports.Stack_PushString(name);

            Imports.Extern_CreateFreePoint(autoName, ground);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Imports.Extern_ConnectWP();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Imports.Extern_DisconnectWP();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            if (listBoxResultItems.SelectedItem == null)
            {
                return;
            }

            string name = listBoxResultItems.GetItemText(listBoxResultItems.SelectedItem);

            //Console.WriteLine("Create item: " + name);


            //SpacerNET.infoWin.AddText("Создаю Item " + name);
            Imports.Extern_KillPreviewItem();
            Imports.Stack_PushString(name);
            Imports.Extern_CreateItem();

            SpacerNET.form.Focus();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPfxReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            if (listBoxPfxResult.SelectedItem == null)
            {
                return;
            }
            string name = listBoxParticles.GetItemText(listBoxPfxResult.SelectedItem);


            //SpacerNET.infoWin.AddText("Создаю PFX " + name);

            Imports.Stack_PushString(name);
            Imports.Extern_CreatePFX();
            Imports.Extern_KillPFX();

            SpacerNET.form.Focus();
        }

        private void textBoxPfxReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string strToFind = textBoxPfxReg.Text.Trim().ToUpper();


                Regex regEx = null;

                try
                {
                    regEx = new Regex(@strToFind, RegexOptions.IgnoreCase | RegexOptions.Compiled);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show(Localizator.Get("BAD_REGEX"));
                    return;
                }

                listBoxPfxResult.BeginUpdate();

                listBoxPfxResult.Items.Clear();



                for (int i = 0; i < listBoxParticles.Items.Count; i++)
                {
                    string value = listBoxParticles.GetItemText(listBoxParticles.Items[i]);

                    if (Regex.IsMatch(value, @strToFind))
                    {
                        listBoxPfxResult.Items.Add(value);
                    }
                }

                listBoxPfxResult.EndUpdate();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBoxVisuals_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            bool checkBoxDebugSearch = SpacerNET.vobCatForm.checkBoxDebugSearch.Checked;

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;

                string strToFind = textBoxVisuals.Text.Trim().ToUpper();

                if (checkBoxSearchOnly3DS.Checked && !strToFind.ToUpper().Contains("3DS"))
                {
                    strToFind += ".*3DS";
                }

                //ConsoleEx.WriteLineRed(strToFind);

                Regex regEx = null;

                try
                {
                    regEx = new Regex(@strToFind, RegexOptions.IgnoreCase | RegexOptions.Compiled);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show(Localizator.Get("BAD_REGEX"));
                    return;
                }

                listBoxVisuals.BeginUpdate();

                listBoxVisuals.Items.Clear();

                if (radioButtonVdf.Checked)
                {
                    for (int i = 0; i < listVisualsVDF.Count; i++)
                    {

                        if (regEx.IsMatch(listVisualsVDF[i]))
                        {

                            if (comboBoxArchiveList.SelectedIndex > 0)
                            {
                                string searchArchive = comboBoxArchiveList.GetItemText(comboBoxArchiveList.SelectedItem);

                                if (searchArchive.Length > 0)
                                {
                                    Imports.Stack_PushString(listVisualsVDF[i]);
                                    Imports.Stack_PushString(searchArchive);

                                    if (Imports.Extern_VisualIsInVDF() == 1)
                                    {
                                        if (checkBoxDebugSearch)
                                        {
                                            var name = listVisualsVDF[i];

                                            var entry = SpacerNET.vobCatForm.vobMan.GetByVisual(name);

                                            if (entry != null)
                                            {
                                                //ConsoleEx.WriteLineRed(String.Format("{0} / {1}", name, entry.Visual));
                                            }
                                            else
                                            {
                                                listBoxVisuals.Items.Add(name);
                                            }
                                        }
                                        else
                                        {
                                            listBoxVisuals.Items.Add(listVisualsVDF[i]);
                                        }

                                    }
                                }
                            }
                            else
                            {

                                if (checkBoxDebugSearch)
                                {
                                    var name = listVisualsVDF[i];

                                    var entry = SpacerNET.vobCatForm.vobMan.GetByVisual(name);

                                    if (entry != null)
                                    {
                                        //ConsoleEx.WriteLineRed(String.Format("{0} / {1}", name, entry.Visual));
                                    }
                                    else
                                    {
                                        listBoxVisuals.Items.Add(name);
                                    }

                                }
                                else
                                {
                                    listBoxVisuals.Items.Add(listVisualsVDF[i]);
                                }

                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < listVisualsWORK.Count; i++)
                    {
                        if (regEx.IsMatch(listVisualsWORK[i]))
                        {

                            if (checkBoxDebugSearch)
                            {
                                var name = listVisualsWORK[i];

                                var entry = SpacerNET.vobCatForm.vobMan.GetByVisual(name);

                                if (entry != null)
                                {
                                    //ConsoleEx.WriteLineRed(String.Format("{0} / {1}", name, entry.Visual));
                                }
                                else
                                {
                                    listBoxVisuals.Items.Add(name);
                                }

                            }
                            else
                            {
                                listBoxVisuals.Items.Add(listVisualsWORK[i]);
                            }


                        }
                    }
                }


                SpacerNET.objectsWin.labelSearchVisual.Text = Localizator.Get("WIN_OBJ_SEARCHVISUAL_ALL") + ": " + listBoxVisuals.Items.Count;

                listBoxVisuals.EndUpdate();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBoxVisuals.Items.Clear();
            listBoxVisuals.ClearSelected();
            textBoxVisuals.Clear();

            SpacerNET.objectsWin.labelSearchVisual.Text = Localizator.Get("WIN_OBJ_ALLMODELS");

            string visual = "";


            Imports.Stack_PushString(visual);
            Imports.Extern_RenderSelectedVob();


        }

        private void checkBoxDyn_CheckedChanged(object sender, EventArgs e)
        {
            //CheckBox cb = sender as CheckBox;

            //triggerEntry.dynColl = cb.Checked;

            //ObjectsWindow.ChangeProp("cdDyn", Convert.ToInt32(triggerEntry.dynColl).ToString());


            //Imports.Extern_SetCollTrigger(0, Convert.ToInt32(triggerEntry.dynColl));
        }

        private void checkBoxStat_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            triggerEntry.statColl = cb.Checked;

            ObjectsWindow.ChangeProp("cdStatic", Convert.ToInt32(triggerEntry.statColl).ToString());

            Imports.Extern_SetCollTrigger(1, Convert.ToInt32(triggerEntry.statColl));
        }

        private void listBoxActionType_SelectedIndexChanged(object sender, EventArgs e)
        {

            string name = listBoxActionType.GetItemText(listBoxActionType.SelectedItem);
            triggerEntry.currentActionIndex = listBoxActionType.SelectedIndex;
        }

        private void buttonKeyMinus_Click(object sender, EventArgs e)
        {
            if (triggerEntry.m_kf_pos >= 1)
            {
                triggerEntry.m_kf_pos--;

                Imports.Extern_SetToKeyPos(triggerEntry.m_kf_pos);
                UpdateCurrentKeyLabel();
            }


        }


        private void UpdateCurrentKeyLabel()
        {
            int keyMax = triggerEntry.maxKey - 1;

            if (keyMax < 0) keyMax = 0;


            labelCurrentKey.Text = triggerEntry.m_kf_pos.ToString() + "/" + keyMax.ToString();
        }

        private void buttonKeyPlus_Click(object sender, EventArgs e)
        {
            if (triggerEntry.m_kf_pos + 1 < triggerEntry.maxKey)
            {
                triggerEntry.m_kf_pos++;
                Imports.Extern_SetToKeyPos(triggerEntry.m_kf_pos);
                UpdateCurrentKeyLabel();
            }



        }


        public void UpdateTriggerWindow(bool block = true, bool collisionBlock = true)
        {
            labelTriggerName.Text = triggerEntry.name;
            labelTriggerClassName.Text = triggerEntry.className;

            UpdateCurrentKeyLabel();
            checkBoxDyn.Checked = triggerEntry.dynColl;
            checkBoxStat.Checked = triggerEntry.statColl;

            if (listBoxActionType.SelectedItem == null)
            {
                //listBoxActionType.SelectedIndex = 0;
            }

            if (block)
            {
                buttonRemoveKey.Enabled = false;
                buttonNewKey.Enabled = false;
                buttonKeyMinus.Enabled = false;
                buttonKeyPlus.Enabled = false;

                buttonTriggersJumpToKey.Enabled = false;
                textBoxTrigersJumpKey.Enabled = false;
                checkBoxShowMoverKeys.Enabled = false;

                buttonRemoveMoverAllKeys.Enabled = false;
                buttonMoverResetKeyTo0.Enabled = false;
                labelCurrentKey.Enabled = false;
                labelCurrentKey.Text = "0/0";




            }

            if (collisionBlock)
            {
                checkBoxDyn.Enabled = false;
                checkBoxStat.Enabled = false;
            }
            else
            {
                checkBoxDyn.Enabled = true;
                checkBoxStat.Enabled = true;
            }

        }


        [DllExport]
        public static void Trigger_UpdateKeys(int cur, int max)
        {

            SpacerNET.objectsWin.triggerEntry.m_kf_pos = cur;
            SpacerNET.objectsWin.triggerEntry.maxKey = max;

            SpacerNET.objectsWin.UpdateTriggerWindow(false, false);

        }

        [DllExport]
        public static void CleanTriggerForm()
        {

            SpacerNET.objectsWin.triggerEntry.m_kf_pos = 0;
            SpacerNET.objectsWin.triggerEntry.maxKey = 0;
            SpacerNET.objectsWin.triggerEntry.name = "";
            SpacerNET.objectsWin.triggerEntry.className = "";
            SpacerNET.objectsWin.triggerEntry.dynColl = false;
            SpacerNET.objectsWin.triggerEntry.statColl = false;
            SpacerNET.objectsWin.listBoxTargetList.Items.Clear();
            SpacerNET.objectsWin.listBoxSources.Items.Clear();
            SpacerNET.objectsWin.listBoxActionType.Items.Clear();
            SpacerNET.objectsWin.triggerEntry.targetListAddr.Clear();
            SpacerNET.objectsWin.triggerEntry.sourcesListAddr.Clear();

            SpacerNET.objectsWin.labelCurrentKey.Text = "0/0";
            SpacerNET.objectsWin.labelCurrentKey.Enabled = false;

            SpacerNET.objectsWin.checkBoxShowMoverKeys.Enabled = false;

            SpacerNET.objectsWin.buttonRemoveMoverAllKeys.Enabled = false;
            SpacerNET.objectsWin.buttonMoverResetKeyTo0.Enabled = false;

            SpacerNET.objectsWin.checkBoxDyn.Enabled = false;
            SpacerNET.objectsWin.checkBoxStat.Enabled = false;




            SpacerNET.objectsWin.UpdateTriggerWindow();

        }

        private void EnableTriggerWindow()
        {
            buttonRemoveKey.Enabled = true;
            buttonNewKey.Enabled = true;
            buttonKeyMinus.Enabled = true;
            buttonKeyPlus.Enabled = true;
            buttonTriggersJumpToKey.Enabled = true;
            textBoxTrigersJumpKey.Enabled = true;
            checkBoxShowMoverKeys.Enabled = true;

            labelCurrentKey.Enabled = true;

            buttonRemoveMoverAllKeys.Enabled = true;
            buttonMoverResetKeyTo0.Enabled = true;

            checkBoxDyn.Enabled = true;
            checkBoxStat.Enabled = true;
        }

        public static void ChangeTab(int num)
        {
            if (selectTabBlocked > 0)
            {
                selectTabBlocked--;
                return;
            }

            if (SpacerNET.objectsWin.tabControlObjects.SelectedIndex != num)
            {
                SpacerNET.objectsWin.tabControlObjects.SelectedIndex = num;
            }

        }

        [DllExport]
        public static void SelectMoversTab()
        {
            // ConsoleEx.WriteLineRed("SelectMoversTab");
            ChangeTab(3);
        }

        [DllExport]
        public static void SelectWPTab()
        {
            // ConsoleEx.WriteLineRed("SelectWPTab");
            ChangeTab(4);
        }

        [DllExport]
        public static void SelectCameraTab()
        {

            ChangeTab(6);
        }

        [DllExport]
        public static void SelectLightTab()
        {

            ChangeTab(7);
        }

        [DllExport]
        public static void AddActionTypeMover()
        {
            string value = Imports.Stack_PeekString();
            SpacerNET.objectsWin.listBoxActionType.Items.Add(value);


            if (SpacerNET.objectsWin.listBoxActionType.Items.Count > 0)
            {
                SpacerNET.objectsWin.listBoxActionType.SelectedIndex = 0;
            }
        }


        [DllExport]
        public static void AddTargetToList(uint addr)
        {
            string value = Imports.Stack_PeekString();

            SpacerNET.objectsWin.triggerEntry.targetListAddr.Add(addr);

            SpacerNET.objectsWin.listBoxTargetList.Items.Add(value);
        }

        [DllExport]
        public static void AddSourcesToList(uint addr)
        {
            string value = Imports.Stack_PeekString();
            SpacerNET.objectsWin.triggerEntry.sourcesListAddr.Add(addr);
            SpacerNET.objectsWin.listBoxSources.Items.Add(value);

            //ConsoleEx.WriteLineGreen("Add Source List: " + value);
        }

        [DllExport]
        public static void CreateTriggerForm(int keyCurrent, int keyMax, int dyn, int stat)
        {
            string name = Imports.Stack_PeekString();
            string className = Imports.Stack_PeekString();

            SpacerNET.objectsWin.triggerEntry.m_kf_pos = keyCurrent;
            SpacerNET.objectsWin.triggerEntry.maxKey = keyMax;
            SpacerNET.objectsWin.triggerEntry.name = name;
            SpacerNET.objectsWin.triggerEntry.className = className;
            SpacerNET.objectsWin.triggerEntry.dynColl = Convert.ToBoolean(dyn);
            SpacerNET.objectsWin.triggerEntry.statColl = Convert.ToBoolean(stat);
            SpacerNET.objectsWin.listBoxTargetList.Items.Clear();
            SpacerNET.objectsWin.listBoxActionType.Items.Clear();
            SpacerNET.objectsWin.triggerEntry.targetListAddr.Clear();
            SpacerNET.objectsWin.listBoxSources.Items.Clear();
            SpacerNET.objectsWin.triggerEntry.sourcesListAddr.Clear();

            SpacerNET.objectsWin.UpdateTriggerWindow();
            SpacerNET.objectsWin.EnableTriggerWindow();
        }


        [DllExport]
        public static void CreateTriggerFormEmptyRealTrigger()
        {
            string name = Imports.Stack_PeekString();
            string className = Imports.Stack_PeekString();

            SpacerNET.objectsWin.triggerEntry.name = name;
            SpacerNET.objectsWin.triggerEntry.className = className;
            SpacerNET.objectsWin.listBoxTargetList.Items.Clear();
            SpacerNET.objectsWin.listBoxActionType.Items.Clear();
            SpacerNET.objectsWin.triggerEntry.targetListAddr.Clear();
            SpacerNET.objectsWin.listBoxSources.Items.Clear();
            SpacerNET.objectsWin.triggerEntry.sourcesListAddr.Clear();

            SpacerNET.objectsWin.UpdateTriggerWindow(true, false);
            //SpacerNET.objectsWin.EnableTriggerWindow();
        }

        [DllExport]
        public static void CreateTriggerFormEmpty()
        {
            string name = Imports.Stack_PeekString();
            string className = Imports.Stack_PeekString();

            SpacerNET.objectsWin.triggerEntry.name = name;
            SpacerNET.objectsWin.triggerEntry.className = className;
            SpacerNET.objectsWin.listBoxTargetList.Items.Clear();
            SpacerNET.objectsWin.listBoxActionType.Items.Clear();
            SpacerNET.objectsWin.triggerEntry.targetListAddr.Clear();
            SpacerNET.objectsWin.listBoxSources.Items.Clear();
            SpacerNET.objectsWin.triggerEntry.sourcesListAddr.Clear();

            SpacerNET.objectsWin.UpdateTriggerWindow(true, true);
            //SpacerNET.objectsWin.EnableTriggerWindow();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBoxSources.Items.Clear();
            SpacerNET.objectsWin.triggerEntry.sourcesListAddr.Clear();
            Imports.Extern_CollectTriggerSources();
        }

        private void buttonRemoveKey_Click(object sender, EventArgs e)
        {
            Imports.Extern_OnKeyRemove();

            triggerEntry.m_kf_pos = Imports.Extern_GetCurrentKey();
            triggerEntry.maxKey = Imports.Extern_GetMaxKey();

            //ConsoleEx.WriteLineRed(triggerEntry.m_kf_pos + "/" + triggerEntry.maxKey);

            UpdateTriggerWindow(false);
            SpacerNET.form.Focus();
        }

        private void buttonNewKey_Click(object sender, EventArgs e)
        {
            int mode = 0;


            if (radioButtonOverwrite.Checked)
            {
                mode = 2;
            }
            else if (radioButtonAfter.Checked)
            {
                mode = 0;
            }
            else
            if (radioButtonBefore.Checked)
            {
                mode = 1;
            }


            Imports.Extern_OnAddKey(mode);

            triggerEntry.m_kf_pos = Imports.Extern_GetCurrentKey();
            triggerEntry.maxKey = Imports.Extern_GetMaxKey();

            //ConsoleEx.WriteLineRed("CurrentKey: " + triggerEntry.m_kf_pos + "/" + triggerEntry.maxKey);
            UpdateTriggerWindow(false);

            SpacerNET.form.Focus();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            string name = listBoxActionType.GetItemText(listBoxActionType.SelectedItem);

            //ConsoleEx.WriteLineRed("Send trigger: action " + name);
            Imports.Extern_SendTrigger(triggerEntry.currentActionIndex);
            triggerEntry.m_kf_pos = Imports.Extern_GetCurrentKey();

            // UpdateTriggerWindow(false);
        }

        private void ParticleWin_Shown(object sender, EventArgs e)
        {
            //listBoxActionType.SelectedIndex = 0;

            this.treeViewSearchClass.ImageList = SpacerNET.objTreeWin.imageListObjects;
            InitCameraTab();

            LoadSpawnFile();
            Application.DoEvents();
        }

        private void listBoxSources_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBoxSources.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                uint addr = triggerEntry.sourcesListAddr[index];

                try
                {
                    SpacerNET.objTreeWin.globalTree.SelectedNode =
                    ObjTree.globalEntries[addr].node;
                }
                catch
                {
                    Utils.Error("triggetSourcesList. Can't find vob with addr: " + Utils.ToHex(addr));
                }

                Imports.Extern_SelectVob(addr);
            }

        }

        private void listBoxTargetList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBoxTargetList.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                uint addr = triggerEntry.targetListAddr[index];

                try
                {
                    SpacerNET.objTreeWin.globalTree.SelectedNode =
                    ObjTree.globalEntries[addr].node;
                }
                catch
                {
                    ConsoleEx.WriteLineGreen("triggetTargetList. Can't find vob with addr: " + Utils.ToHex(addr));
                }

                Imports.Extern_SelectVob(addr);
            }
        }

        private void listBoxTargetList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxTargetList_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            string name = "";
            string count = textBoxItemCount.Text.Trim();

            if (count == String.Empty)
            {
                count = "1";
            }

            if (listBoxResultItems.SelectedItem != null)
            {
                name = listBoxResultItems.GetItemText(listBoxResultItems.SelectedItem).Trim();


            }
            else if (listBoxItems.SelectedItem != null)
            {
                name = listBoxItems.GetItemText(listBoxItems.SelectedItem).Trim();
            }

            if (name != String.Empty)
            {
                if (SpacerNET.propWin.tabControlProps.SelectedIndex == 2 && SpacerNET.propWin.dataGridViewItems.Visible
                    && SpacerNET.propWin.buttonContainerApply.Enabled
                    )
                {
                    SpacerNET.propWin.dataGridViewItems.Rows.Add(name, count);
                }
            }
        }

        private void textBoxItemCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !Utils.IsNumberInput(e.KeyChar, false, false))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void listBoxVisuals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxVisuals.SelectedItem != null && checkBoxShowPreview.Checked)
            {
                string visual = listBoxVisuals.GetItemText(listBoxVisuals.SelectedItem);


                if (SpacerNET.grassWin.checkBoxGrassWinCopyName.Checked)
                {
                    if (Utils.IsOptionActive("checkBoxOnlyLatinInInput"))
                    {
                        if (visual.Length > 0 && Utils.IsOnlyLatin(visual))
                        {
                            SpacerNET.grassWin.textBoxGrassWinModel.Text = visual;
                            SpacerNET.grassWin.buttonGrassWinApply_Click(null, null);
                        }
                    }
                    else
                    {
                        SpacerNET.grassWin.textBoxGrassWinModel.Text = visual;
                        SpacerNET.grassWin.buttonGrassWinApply_Click(null, null);
                    }

                }

                Imports.Stack_PushString(visual);
                Imports.Extern_RenderSelectedVob();



                SpacerNET.form.Focus();
            }

        }

        private void checkBoxShowPreview_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ch = sender as CheckBox;


            Imports.Stack_PushString("showModelPreview");
            Imports.Extern_SetSetting(Convert.ToInt32(ch.Checked));


            if (!ch.Checked)
            {
                string visual = "";


                Imports.Stack_PushString(visual);
                Imports.Extern_RenderSelectedVob();

                SpacerNET.form.Focus();
            }
            else
            {
                if (listBoxVisuals.SelectedItem != null)
                {
                    string visual = listBoxVisuals.GetItemText(listBoxVisuals.SelectedItem);

                    Imports.Stack_PushString(visual);
                    Imports.Extern_RenderSelectedVob();



                    SpacerNET.form.Focus();
                }

            }
        }

        private void tabControlObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tab = sender as TabControl;

            if (tab.SelectedIndex != 0)
            {
                string visual = "";

                Imports.Stack_PushString(visual);
                Imports.Extern_RenderSelectedVob();

                //UnionNET.form.Focus();
            }


            if (tab.SelectedIndex != 1)
            {

                Imports.Extern_KillPreviewItem();
                //UnionNET.form.Focus();
            }


            if (tab.SelectedIndex != 2)
            {

                Imports.Extern_KillPFX();
                //UnionNET.form.Focus();
            }
        }

        private void checkBoxSearchOnly3DS_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ch = sender as CheckBox;
            Imports.Stack_PushString("searchOnly3DS");

            Imports.Extern_SetSetting(Convert.ToInt32(ch.Checked));
        }

        private void listBoxVisuals_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void listBoxVisuals_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (e.Button == MouseButtons.Middle && lb != null)
            {

                int index = lb.IndexFromPoint(e.Location);

                if (index >= 0 && lb.Items.Count > 0)
                {
                    string visual = lb.GetItemText(lb.Items[index]);
                    Utils.SetCopyText(visual);
                }

            }
        }

        private void buttonCamSpline_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;

            camEntry.OnInsertSplineKey();


            listBoxCameraSpline.SelectedIndex = listBoxCameraSpline.Items.Count - 1;
        }

        private void checkBoxWayNet_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            Imports.Stack_PushString("addWPToNet");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
        }

        private void checkBoxWPAutoName_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            Imports.Stack_PushString("addWPAutoName");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
        }

        private void checkBoxFPGround_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            Imports.Stack_PushString("downFPToGround");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
        }

        private void checkBoxAutoNameFP_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            Imports.Stack_PushString("addFPAutoName");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
        }

        private void listBoxParticles_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            if (lb.SelectedItem != null)
            {
                string visual = lb.GetItemText(lb.SelectedItem);

                SpacerNET.pfxWin.SetLastVisualSelected(visual);

                if (checkBoxShowPFXPreview.Checked && !SpacerNET.pfxWin.Visible)
                {
                    SendRenderPFX(visual);
                }

                SpacerNET.pfxWin.SetCurrentPFX(visual);
            }


        }

        private void listBoxPfxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            if (lb.SelectedItem != null)
            {
                string visual = lb.GetItemText(lb.SelectedItem);

                SpacerNET.pfxWin.SetLastVisualSelected(visual);

                if (checkBoxShowPFXPreview.Checked && !SpacerNET.pfxWin.Visible)
                {
                    SendRenderPFX(visual);
                }

                SpacerNET.pfxWin.SetCurrentPFX(visual);
            }
        }


        public void SendRenderPFX(string visual)
        {
            Imports.Stack_PushString(visual);
            Imports.Extern_RenderPFX();
        }

        private void checkBoxShowPFXPreview_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb.Checked)
            {
                if (listBoxParticles.SelectedItem != null)
                {
                    string visual = listBoxParticles.GetItemText(listBoxParticles.SelectedItem);
                    SendRenderPFX(visual);
                }
                else if (listBoxPfxResult.SelectedItem != null)
                {
                    string visual = listBoxPfxResult.GetItemText(listBoxPfxResult.SelectedItem);
                    SendRenderPFX(visual);
                }


            }
            else
            {
                Imports.Extern_KillPFX();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void SendRenderItems(string visual)
        {
            Imports.Stack_PushString(visual);
            Imports.Extern_RenderItem();
        }


        private void checkBoxItemShow_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb.Checked)
            {
                if (listBoxItems.SelectedItem != null)
                {
                    string visual = listBoxItems.GetItemText(listBoxItems.SelectedItem);
                    SendRenderItems(visual);
                }
                else if (listBoxResultItems.SelectedItem != null)
                {
                    string visual = listBoxResultItems.GetItemText(listBoxResultItems.SelectedItem);
                    SendRenderItems(visual);
                }


            }
            else
            {
                Imports.Extern_KillPreviewItem();
            }
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (lb.SelectedItem != null)
            {
                string visual = lb.GetItemText(lb.SelectedItem);

                if (SpacerNET.grassWin.checkBoxGrassWinCopyName.Checked)
                {
                    SpacerNET.grassWin.textBoxGrassWinModel.Text = visual;
                    SpacerNET.grassWin.buttonGrassWinApply_Click(null, null);
                }

                if (checkBoxItemShow.Checked)
                {
                    SendRenderItems(visual);
                }
            }
        }

        private void listBoxResultItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (lb.SelectedItem != null)
            {
                string visual = lb.GetItemText(lb.SelectedItem);

                if (SpacerNET.grassWin.checkBoxGrassWinCopyName.Checked)
                {
                    SpacerNET.grassWin.textBoxGrassWinModel.Text = visual;
                    SpacerNET.grassWin.buttonGrassWinApply_Click(null, null);
                }


                if (checkBoxItemShow.Checked)
                {
                    SendRenderItems(visual);
                }
            }
        }

        private void labelTriggerTargets_Click(object sender, EventArgs e)
        {

        }

        private void labelTriggersSources_Click(object sender, EventArgs e)
        {

        }

        private void listBoxSources_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        static Dictionary<string, FolderEntry> folders = new Dictionary<string, FolderEntry>();
        static string currentFolderName = "";
        static TPropEditType currentFieldtype;


        static Dictionary<string, FolderEntry> foldersCompare = new Dictionary<string, FolderEntry>();
        static string currentFolderNameCompare = "";

        static Dictionary<string, FolderEntry> foldersConvert = new Dictionary<string, FolderEntry>();
        static string currentFolderNameConvert = "";



        static Dictionary<string, FolderEntry> foldersConvertVob = new Dictionary<string, FolderEntry>();
        static string currentFolderNameConvertVob = "";


        public static List<uint> searchResultVobsAddr = new List<uint>();
        public static List<string> searchResultVobsNamesTemp = new List<string>();
        public static string replaceZenPath = "";


        private void CleanNewProps()
        {
            treeViewSearchClass.Nodes.Clear();
            currentFolderNameConvert = String.Empty;
            foldersConvert.Clear();
            newProps.Clear();
        }

        private void CleanFindProps()
        {
            treeViewSearchClass.Nodes.Clear();
            currentFolderName = String.Empty;
            folders.Clear();
            searchProps.Clear();
        }


        public void FillClassFields(string inputStr, bool clean = true)
        {

            if (clean)
            {
                CleanFindProps();
            }
            else
            {
                treeViewSearchClass.Nodes.Clear();
                currentFolderName = String.Empty;
                folders.Clear();
            }

            TreeNode showFirst = null;


            if (inputStr.Length == 0)
            {
                return;
            }

            CProperty.originalStrSearchWindow = inputStr;
            string[] words = inputStr.Replace("\t", "").Split('\n');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();

                if (words[i].Length == 0 || words[i].Contains('[') || (!words[i].Contains(':') || !words[i].Contains('=')))
                {
                    continue;
                }

                if (words[i].Contains("groupBegin"))
                {
                    string folderName = words[i].Substring(0, words[i].IndexOf('='));

                    FolderEntry f = new FolderEntry();
                    f.parent = currentFolderName;


                    if (currentFolderName == "")
                    {
                        TreeNode node = treeViewSearchClass.Nodes.Add(folderName);
                        node.Tag = Constants.TAG_FOLDER;
                        f.node = node;
                    }
                    else
                    {
                        for (int j = 0; j < treeViewSearchClass.Nodes.Count; j++)
                        {
                            if (treeViewSearchClass.Nodes[j].Text == currentFolderName)
                            {
                                TreeNode node = treeViewSearchClass.Nodes[j].Nodes.Add(folderName);
                                node.Tag = Constants.TAG_FOLDER;
                                f.node = node;
                                break;
                            }
                        }
                    }

                    folders.Add(folderName, f);
                    currentFolderName = folderName;
                    continue;
                }

                if (words[i].Contains("groupEnd"))
                {
                    currentFolderName = folders[currentFolderName].parent;
                    continue;
                }

                if (clean)
                {
                    CProperty prop = new CProperty();
                    prop.Name = words[i].Substring(0, words[i].IndexOf('='));
                    prop.GroupName = currentFolderName;

                    int pos = words[i].IndexOf('=');
                    int pos2 = words[i].IndexOf(':');

                    prop.SetType(words[i].Substring(pos + 1, pos2 - pos - 1));

                    pos = words[i].IndexOf(':');

                    prop.SetValue(words[i].Substring(pos + 1, words[i].Length - pos - 1));

                    if (currentFolderName != "")
                    {
                        prop.node = folders[currentFolderName].node;
                    }

                    searchProps.Add(prop);
                }
                else
                {
                    CProperty prop = searchProps.Where(x => x.Name == words[i].Substring(0, words[i].IndexOf('='))).ToArray()[0];

                    if (prop != null && currentFolderName != "")
                    {
                        prop.node = folders[currentFolderName].node;
                    }
                }


            }


            for (int i = 0; i < searchProps.Count; i++)
            {
                TreeNode baseNode = searchProps[i].node;

                if (baseNode != null)
                {
                    TreeNode node = baseNode.Nodes.Add(searchProps[i].Name + ": " + searchProps[i].ShowValue());
                    node.SelectedImageIndex = 5;
                    node.ImageIndex = 5;
                    node.Tag = i;
                    searchProps[i].ownNode = node;

                    if (searchProps[i].Name == "vobName")
                    {
                        showFirst = node;
                    }
                }
                else
                {
                    TreeNode node = treeViewSearchClass.Nodes.Add(searchProps[i].Name + ": " + searchProps[i].ShowValue());
                    node.SelectedImageIndex = 5;
                    node.ImageIndex = 5;
                    node.Tag = i;
                    searchProps[i].ownNode = node;
                    if (searchProps[i].Name == "vobName")
                    {
                        showFirst = node;
                    }
                }

                if (searchProps[i].selectedForSearch)
                {
                    TreeNode node = searchProps[i].ownNode;

                    node.Text = searchProps[i].Name + ": " + searchProps[i].ShowValue();
                    node.SelectedImageIndex = 4;
                    node.ImageIndex = 4;
                }
            }


            treeViewSearchClass.ExpandAll();

            for (int j = 0; j < folders.Count; j++)
            {
                if (folders.ElementAt(j).Key == "Internals")
                {
                    folders.ElementAt(j).Value.node.Collapse();
                }
            }

            if (showFirst != null)
            {
                treeViewSearchClass.SelectedNode = showFirst;
            }
        }


        public void FillClassFieldsConvert(string inputStr, bool clean = true)
        {
            if (clean)
            {
                CleanNewProps();
            }
            else
            {
                treeViewSearchClass.Nodes.Clear();
                currentFolderNameConvert = String.Empty;
                foldersConvert.Clear();
            }

            TreeNode showFirst = null;


            if (inputStr.Length == 0)
            {
                return;
            }

            string[] words = inputStr.Replace("\t", "").Split('\n');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();

                if (words[i].Length == 0 || words[i].Contains('[') || (!words[i].Contains(':') || !words[i].Contains('=')))
                {
                    continue;
                }

                if (words[i].Contains("groupBegin"))
                {
                    string folderName = words[i].Substring(0, words[i].IndexOf('='));

                    FolderEntry f = new FolderEntry();
                    f.parent = currentFolderNameConvert;


                    if (currentFolderNameConvert == "")
                    {
                        TreeNode node = treeViewSearchClass.Nodes.Add(folderName);
                        node.Tag = Constants.TAG_FOLDER;
                        f.node = node;
                    }
                    else
                    {
                        for (int j = 0; j < treeViewSearchClass.Nodes.Count; j++)
                        {
                            if (treeViewSearchClass.Nodes[j].Text == currentFolderNameConvert)
                            {
                                TreeNode node = treeViewSearchClass.Nodes[j].Nodes.Add(folderName);
                                node.Tag = Constants.TAG_FOLDER;
                                f.node = node;
                                break;
                            }
                        }
                    }

                    foldersConvert.Add(folderName, f);
                    currentFolderNameConvert = folderName;
                    continue;
                }

                if (words[i].Contains("groupEnd"))
                {
                    currentFolderNameConvert = foldersConvert[currentFolderNameConvert].parent;
                    continue;
                }


                if (clean)
                {
                    CProperty prop = new CProperty();
                    prop.Name = words[i].Substring(0, words[i].IndexOf('='));
                    prop.GroupName = currentFolderNameConvert;

                    int pos = words[i].IndexOf('=');
                    int pos2 = words[i].IndexOf(':');

                    prop.SetType(words[i].Substring(pos + 1, pos2 - pos - 1));

                    pos = words[i].IndexOf(':');

                    prop.SetValue(words[i].Substring(pos + 1, words[i].Length - pos - 1));

                    if (currentFolderNameConvert != "")
                    {
                        prop.node = foldersConvert[currentFolderNameConvert].node;
                    }

                    newProps.Add(prop);
                }
                else
                {
                    CProperty prop = newProps.Where(x => x.Name == words[i].Substring(0, words[i].IndexOf('='))).ToArray()[0];

                    if (prop != null && currentFolderNameConvert != "")
                    {
                        prop.node = foldersConvert[currentFolderNameConvert].node;
                    }
                }


            }


            for (int i = 0; i < newProps.Count; i++)
            {
                TreeNode baseNode = newProps[i].node;

                if (baseNode != null)
                {
                    TreeNode node = baseNode.Nodes.Add(newProps[i].Name + ": " + newProps[i].ShowValue());
                    node.SelectedImageIndex = 5;
                    node.ImageIndex = 5;
                    node.Tag = i;
                    newProps[i].ownNode = node;

                    if (newProps[i].Name == "vobName")
                    {
                        showFirst = node;
                    }
                }
                else
                {
                    TreeNode node = treeViewSearchClass.Nodes.Add(newProps[i].Name + ": " + newProps[i].ShowValue());
                    node.SelectedImageIndex = 5;
                    node.ImageIndex = 5;
                    node.Tag = i;
                    newProps[i].ownNode = node;

                    if (newProps[i].Name == "vobName")
                    {
                        showFirst = node;
                    }
                }

                if (newProps[i].selectedForSearch)
                {
                    TreeNode node = newProps[i].ownNode;

                    node.Text = newProps[i].Name + ": " + newProps[i].ShowValue();
                    node.SelectedImageIndex = 3;
                    node.ImageIndex = 3;
                }
            }


            treeViewSearchClass.ExpandAll();

            for (int j = 0; j < foldersConvert.Count; j++)
            {
                if (foldersConvert.ElementAt(j).Key == "Internals")
                {
                    foldersConvert.ElementAt(j).Value.node.Collapse();
                }
            }

            if (showFirst != null)
            {
                treeViewSearchClass.SelectedNode = showFirst;
            }

        }
        //

        [DllExport]
        public static void AddSubClassConvert()
        {
            string value = Imports.Stack_PeekString();
            SpacerNET.objectsWin.comboBoxSearchClassReplace.Items.Add(value);
        }


        private void comboBoxSearchClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (!SpacerNET.isInit)
            {
                return;
            }

            string selectedClass = cb.Text.Replace(".", "").Trim();
            // ConsoleEx.WriteLineRed(selectedClass);

            Imports.Stack_PushString(selectedClass);
            Imports.Extern_GetClassFields(false);

            string result = Imports.Stack_PeekString();


            FillClassFields(result);

            comboBoxSearchClassReplace.Items.Clear();

            Imports.Stack_PushString(selectedClass);
            Imports.Extern_GetConvertSubClasses();


            radioButtonConvertOld.Checked = true;

            //searchProps
            //ConsoleEx.WriteLineRed(result);
        }

        private void treeViewSearchClass_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            int index = 0;
            TreeNode node = e.Node;


            int.TryParse(node.Tag.ToString(), out index);

            // ConsoleEx.WriteLineRed("ModeMouseDoubleClick index: " + index);

            if (index >= 0 && node.Tag != null && node.Tag.ToString() != Constants.TAG_FOLDER)
            {

                CProperty prop = null;

                if (radioButtonConvertOld.Checked)
                {
                    prop = searchProps[index];
                    if (prop.selectedForSearch)
                    {
                        prop.selectedForSearch = false;
                        node.Text = prop.Name + ": " + prop.ShowValue();
                        node.SelectedImageIndex = 5;
                        node.ImageIndex = 5;

                    }
                    else
                    {
                        prop.selectedForSearch = true;
                        node.Text = prop.Name + ": " + prop.ShowValue();
                        node.SelectedImageIndex = 4;
                        node.ImageIndex = 4;
                    }
                }
                else
                {
                    prop = newProps[index];

                    if (prop.selectedForSearch)
                    {
                        prop.selectedForSearch = false;
                        node.Text = prop.Name + ": " + prop.ShowValue();
                        node.SelectedImageIndex = 5;
                        node.ImageIndex = 5;

                    }
                    else
                    {
                        prop.selectedForSearch = true;
                        node.Text = prop.Name + ": " + prop.ShowValue();
                        node.SelectedImageIndex = 3;
                        node.ImageIndex = 3;
                    }
                }



            }
        }

        public void HideAllInput()
        {
            textBoxSearchVobs.Visible = false;
            textBoxVecSearch0.Visible = false;
            textBoxVecSearch1.Visible = false;
            textBoxVecSearch2.Visible = false;
            comboBoxPropsEnumSearch.Visible = false;

            dontUpdateNumType = true;


            panelRadioNumType.Visible = false;

            dontUpdateNumType = false;
        }

        private void treeViewSearchClass_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            int index = 0;

            //ConsoleEx.WriteLineRed(node.Tag.ToString());



            if (node.Tag != null && node.Tag.ToString() != Constants.TAG_FOLDER)
            {
                int.TryParse(node.Tag.ToString(), out index);



                if (index >= 0)
                {

                    HideAllInput();


                    CProperty prop = null;
                    //ConsoleEx.WriteLineRed("try index: " + index);


                    if (radioButtonConvertOld.Checked)
                    {
                        prop = searchProps[index];
                    }
                    else
                    {
                        prop = newProps[index];
                    }


                    if (prop.type == TPropEditType.PETstring || prop.type == TPropEditType.PETraw || prop.type == TPropEditType.PETint
                        || prop.type == TPropEditType.PETfloat
                        || prop.type == TPropEditType.PETcolor
                        )
                    {
                        textBoxSearchVobs.Visible = true;
                        textBoxSearchVobs.Text = prop.value;

                        if (prop.type == TPropEditType.PETstring || prop.type == TPropEditType.PETraw || prop.type == TPropEditType.PETcolor)
                        {
                            textBoxSearchVobs.Width = 300;
                        }
                        else if (prop.type == TPropEditType.PETint || prop.type == TPropEditType.PETfloat)
                        {
                            textBoxSearchVobs.Width = 75;


                            dontUpdateNumType = true;

                            panelRadioNumType.Visible = true;


                            radioButtonSearchEquals.Checked = true;

                            dontUpdateNumType = false;

                        }
                    }

                    if (prop.type == TPropEditType.PETvec3)
                    {
                        textBoxVecSearch0.Visible = true;
                        textBoxVecSearch1.Visible = true;
                        textBoxVecSearch2.Visible = true;

                        string[] arr = prop.value.Split(' ');

                        textBoxVecSearch0.Text = arr[0];
                        textBoxVecSearch1.Text = arr[1];
                        textBoxVecSearch2.Text = arr[2];

                    }

                    if (prop.type == TPropEditType.PETenum)
                    {
                        comboBoxPropsEnumSearch.Visible = true;
                        comboBoxPropsEnumSearch.Items.Clear();
                        comboBoxPropsEnumSearch.Items.AddRange(prop.enumArray.ToArray());
                        comboBoxPropsEnumSearch.SelectedIndex = prop.GetCurrentEnumIndex();
                    }

                    if (prop.type == TPropEditType.PETbool)
                    {
                        comboBoxPropsEnumSearch.Visible = true;
                        comboBoxPropsEnumSearch.Items.Clear();
                        comboBoxPropsEnumSearch.Items.Add("FALSE");
                        comboBoxPropsEnumSearch.Items.Add("TRUE");

                        if (prop.value == "0")
                        {
                            comboBoxPropsEnumSearch.SelectedIndex = 0;
                        }
                        else
                        {
                            comboBoxPropsEnumSearch.SelectedIndex = 1;
                        }
                    }

                    //MessageBox.Show("after");

                    currentFieldtype = prop.type;

                    //Label_Backup.Text = Localizator.Get("Label_Backup") + ": " + prop.ShowBackupValue();


                }
            }
        }

        /*
         * 
         * treeViewSearchClass.Nodes.Clear();
            currentFolderName = String.Empty;
            folders.Clear();
            searchProps.Clear();
         * 
         * */
        private void comboBoxPropsEnumSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            TreeNode node = treeViewSearchClass.SelectedNode;

            if (node != null)
            {
                int index = 0;

                if (node.Tag != null && node.Tag.ToString() != Constants.TAG_FOLDER)
                {
                    int.TryParse(node.Tag.ToString(), out index);

                    if (index >= 0)
                    {

                        CProperty prop = null;

                        if (radioButtonConvertOld.Checked)
                        {
                            prop = searchProps[index];
                        }
                        else
                        {
                            prop = newProps[index];
                        }



                        if (prop.type == TPropEditType.PETenum)
                        {
                            prop.value = comboBoxPropsEnumSearch.SelectedIndex.ToString();
                            prop.ownNode.Text = prop.Name + ": " + prop.ShowValue();

                        }

                        if (prop.type == TPropEditType.PETbool)
                        {
                            prop.value = comboBoxPropsEnumSearch.SelectedIndex.ToString();
                            prop.ownNode.Text = prop.Name + ": " + prop.ShowValue();

                        }
                    }

                }
            }
            else
            {
                ConsoleEx.WriteLineRed("Node is null");
            }
        }

        private void textBoxSearchVobs_TextChanged(object sender, EventArgs e)
        {
            TreeNode node = treeViewSearchClass.SelectedNode;
            TextBox textBox = sender as TextBox;
            int index = 0;

            if (node != null && node.Tag.ToString() != Constants.TAG_FOLDER)
            {
                int.TryParse(node.Tag.ToString(), out index);

                if (index >= 0)
                {


                    //Console.WriteLine("Change entry with index: " + index);
                    CProperty prop = null;

                    if (radioButtonConvertOld.Checked)
                    {
                        prop = searchProps[index];
                    }
                    else
                    {
                        prop = newProps[index];
                    }

                    /*
                    if (prop.backup_value == textBox.Text.Trim())
                    {
                        buttonApply.Enabled = false;
                        buttonRestore.Enabled = false;
                        return;
                    }
                    */


                    if (prop.type == TPropEditType.PETint || prop.type == TPropEditType.PETfloat)
                    {
                        if (radioButtonSearchLessThan.Checked)
                        {
                            prop.numSearchType = TSearchNumberType.TS_LESSTHAN;
                        }
                        else if (radioButtonSearchBiggerThan.Checked)
                        {
                            prop.numSearchType = TSearchNumberType.TS_MORETHAN;
                        }
                        else if (radioButtonSearchEquals.Checked)
                        {
                            prop.numSearchType = TSearchNumberType.TS_EQUALS;
                        }

                        
                    }

                    prop.moreThanZero = checkBoxMoreThanZero.Checked;

                    prop.value = textBox.Text.Trim().ToUpper();
                    node.Text = prop.Name + ": " + prop.ShowValue();
                }
            }
            else
            {
                ConsoleEx.WriteLineGreen("Textbox change with null node");
            }
        }

        private void textBoxSearchVobs_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (currentFieldtype == TPropEditType.PETint)
            {
                if (!char.IsControl(e.KeyChar) && !Utils.IsNumberInput(e.KeyChar, false, true))
                {
                    e.Handled = true;
                }
            }
            else if (currentFieldtype == TPropEditType.PETfloat)
            {
                if (!char.IsControl(e.KeyChar) && !Utils.IsNumberInput(e.KeyChar, true, true))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                button9_Click(null, null);
            }
        }

        private void textBoxVecSearch0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void ChangeVecDataTextBox(object sender, EventArgs e)
        {
            TreeNode node = treeViewSearchClass.SelectedNode;
            TextBox textBox = sender as TextBox;
            int index = 0;


            if (node != null && node.Tag.ToString() != Constants.TAG_FOLDER)
            {
                int.TryParse(node.Tag.ToString(), out index);

                if (index >= 0)
                {

                    //Console.WriteLine("Change entry with index: " + index);
                    CProperty prop = null;

                    if (radioButtonConvertOld.Checked)
                    {
                        prop = searchProps[index];
                    }
                    else
                    {
                        prop = newProps[index];
                    }

                    prop.value = textBoxVecSearch0.Text.Trim() + " " + textBoxVecSearch1.Text.Trim() + " " + textBoxVecSearch2.Text.Trim();


                    node.Text = prop.Name + ": " + prop.ShowValue();

                }
            }
            else
            {
                ConsoleEx.WriteLineGreen("Textbox change with null node");
            }
        }


        private void textBoxVecSearch0_TextChanged(object sender, EventArgs e)
        {
            ChangeVecDataTextBox(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            bool checkValueFound = false;

            if (comboBoxSearchType.SelectedItem == null)
            {
                return;
            }

            onlyNameVisualSearch = 0;
            int countSelected = 0;

            string searchName = "";

            SpaceFastVobFieldsSearch fastSearchType = SpaceFastVobFieldsSearch.FAST_SEARCH_FIELD_NONE;

            Imports.Extern_PrepareSearchEntry(Convert.ToInt32(checkBoxSearchUseRegex.Checked));

            for (int i = 0; i < searchProps.Count; i++)
            {
                var curProp = searchProps[i];

                if (curProp.selectedForSearch)
                {
                    checkValueFound = true;
                    countSelected++;

                    // vobName, TPropEditType, value (string)
                    Imports.Stack_PushString(curProp.Name);
                    Imports.Stack_PushString(curProp.GroupName);
                    Imports.Stack_PushInt((int)curProp.type);
                    Imports.Stack_PushString(curProp.value);
                    Imports.Stack_PushInt((int)curProp.numSearchType);
                    Imports.Stack_PushInt(Convert.ToInt32(curProp.moreThanZero));
                    Imports.Extern_AddSearchEntry();

                    if (curProp.GroupName == "Vob")
                    {
                        if (curProp.Name == "vobName")
                        {
                            fastSearchType |= SpaceFastVobFieldsSearch.FAST_SEARCH_FIELD_NAME;
                            searchName = searchProps[i].value;
                        }
                        else if (curProp.Name == "visual")
                        {
                            fastSearchType |= SpaceFastVobFieldsSearch.FAST_SEARCH_FIELD_VISUAL;
                        }
                        else if (curProp.Name == "showVisual")
                        {
                            fastSearchType |= SpaceFastVobFieldsSearch.FAST_SEARCH_FIELD_SHOW_VISUAL;
                        }
                        else if (curProp.Name == "cdDyn")
                        {
                            fastSearchType |= SpaceFastVobFieldsSearch.FAST_SEARCH_FIELD_CD_DYNYAMIC;
                        }
                        else if (curProp.Name == "cdStatic")
                        {
                            fastSearchType |= SpaceFastVobFieldsSearch.FAST_SEARCH_FIELD_CD_STATIC;
                        }
                        else if (curProp.Name == "staticVob")
                        {
                            fastSearchType |= SpaceFastVobFieldsSearch.FAST_SEARCH_FIELD_STATIC_VOB;
                        }
                        else if (curProp.Name == "visualAniMode")
                        {
                            fastSearchType |= SpaceFastVobFieldsSearch.FAST_SEARCH_FIELD_ANI_MODE;
                        }
                        else if (curProp.Name == "visualAniModeStrength")
                        {
                            fastSearchType |= SpaceFastVobFieldsSearch.FAST_SEARCH_FIELD_ANI_MODE_STR;
                        }
                        else if (curProp.Name == "vobFarClipZScale")
                        {
                            fastSearchType |= SpaceFastVobFieldsSearch.FAST_SEARCH_FIELD_FAR_CLIP_ZSCALE;
                        }
                        else if (curProp.Name == "visualCamAlign")
                        {
                            fastSearchType |= SpaceFastVobFieldsSearch.FAST_SEARCH_FIELD_VISUAL_CAM_ALIGN;
                        }
                    }
                    

                    if (curProp.type == TPropEditType.PETstring && checkBoxSearchUseRegex.Checked)
                    {

                        Regex regEx = null;

                        try
                        {
                            regEx = new Regex(@curProp.value, RegexOptions.IgnoreCase | RegexOptions.Compiled);
                        }
                        catch (ArgumentException)
                        {
                            MessageBox.Show(Localizator.Get("BAD_REGEX"));
                            return;
                        }

                    }
                }
            }

            // if we found ANY selected field which CAN'T be checked in a fast way => no fast search AT ALL
            if (countSelected != Utils.GetIntMaskCountTrue(Convert.ToInt32(fastSearchType)))
            {
                fastSearchType = SpaceFastVobFieldsSearch.FAST_SEARCH_FIELD_NONE;
            }

            //ConsoleEx.WriteLineRed(countSelected + " " + isNameSelected + " " + isVisualSelected);


            if (!checkValueFound)
            {
                //MessageBox.Show(Localizator.Get("SET_ANY_FIELD_SEARCH"));
                //return;
            }


            if (comboBoxSearchType.SelectedIndex == 2 && replaceZenPath.Length == 0)
            {
                MessageBox.Show(Localizator.Get("NO_REPLACE_VOBTREE"));
                return;
            }

            if (comboBoxSearchType.SelectedIndex != 0 && comboBoxSearchType.SelectedIndex != 5)
            {
                DialogResult res = MessageBox.Show(Localizator.Get("askSure"), Localizator.Get("confirmation"), MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (res != DialogResult.OK)
                {
                    return;
                }
            }


            int collectRadius = -1;
            // check radius
            if (checkBoxSearchInRadius.Checked)
            {
                var text = textBoxInRadius.Text.Trim();

                if (text.Length > 0)
                {
                    collectRadius = int.Parse(textBoxInRadius.Text.Trim());

                    if (collectRadius == 0)
                    {
                        collectRadius = -1;
                    }
                }

            }


            SpacerNET.form.AddText(Localizator.Get("VOB_SEARCH_START"));

            Stopwatch s = new Stopwatch();
            s.Start();

            listBoxSearchResult.Items.Clear();
            searchResultVobsNamesTemp.Clear();
            searchResultVobsAddr.Clear();






            //ConsoleEx.WriteLineYellow(searchName);


            Imports.Stack_PushString(searchName);
            Imports.Stack_PushString(replaceZenPath);
            Imports.Extern_SetSearchVobName();


            Imports.Stack_PushInt(countSelected);
            Imports.Stack_PushInt(Convert.ToInt32(checkBoxSearchItem.Checked));
            Imports.Stack_PushInt(Convert.ToInt32(checkBoxMatchNames.Checked));
            Imports.Stack_PushInt(collectRadius);

            int result = Imports.Extern_SearchVobs(checkBoxSearchDerived.Checked, 
                checkBoxSearchHasChildren.Checked, comboBoxSearchType.SelectedIndex, Convert.ToInt32(fastSearchType));


            s.Stop();



            string timeSpend = string.Format("{0:HH:mm:ss.fff}", new DateTime(s.Elapsed.Ticks));


            if (comboBoxSearchType.SelectedIndex == 0 || comboBoxSearchType.SelectedIndex == 5)
            {
                labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ": " + listBoxSearchResult.Items.Count;
                SpacerNET.form.AddText(Localizator.Get("VOB_SEARCH_STOP") + result.ToString() + " (" + timeSpend + ")");
            }

            if (comboBoxSearchType.SelectedIndex == 1)
            {
                labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ": ";
                SpacerNET.form.AddText(Localizator.Get("VOB_SEARCH_CONVERT") + result.ToString() + " (" + timeSpend + ")");
            }


            if (comboBoxSearchType.SelectedIndex == 2)
            {
                //labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ": " + listBoxSearchResult.Items.Count;
                labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ": ";
                SpacerNET.form.AddText(Localizator.Get("VOB_SEARCH_REPLACEZEN") + result.ToString() + " (" + timeSpend + ")");
            }

            if (comboBoxSearchType.SelectedIndex == 3)
            {
                //labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ": " + listBoxSearchResult.Items.Count;
                labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ": ";
                SpacerNET.form.AddText(Localizator.Get("VOB_SEARCH_REMOVEVOBS") + result.ToString() + " (" + timeSpend + ")");
            }





            if (comboBoxSearchType.SelectedIndex == 4)
            {
                //labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ": " + listBoxSearchResult.Items.Count;
                labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ": ";
                SpacerNET.form.AddText(Localizator.Get("VOB_SEARCH_DYNCOLL_VOBS") + result.ToString() + " (" + timeSpend + ")");
            }

            if (comboBoxSearchType.SelectedIndex == 6)
            {
                labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ": ";
                SpacerNET.form.AddText(Localizator.Get("VOB_SEARCH_RENAME_VOBS") + result.ToString() + " (" + timeSpend + ")");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            labelSearchResult.Text = Localizator.Get("vobs_found_amount") + ": ";
            listBoxSearchResult.Items.Clear();
            searchResultVobsAddr.Clear();
            textBoxSearchVobs.Text = "";

            for (int i = 0; i < searchProps.Count; i++)
            {
                searchProps[i].selectedForSearch = false;
                searchProps[i].value = searchProps[i].backup_value;
                searchProps[i].ownNode.SelectedImageIndex = 5;
                searchProps[i].ownNode.ImageIndex = 5;
                searchProps[i].ownNode.Text = searchProps[i].Name + ": " + searchProps[i].ShowValue();
            }
        }


        [DllExport]
        public static void AddSearchVobResult(uint addr)
        {
            /*
            if (searchResultVobsAddr.Contains(addr))
            {
                return;
            }
            */
            //SpacerNET.objectsWin.listBoxSearchResult.Items.Add(Imports.Stack_PeekString());
            searchResultVobsNamesTemp.Add(Imports.Stack_PeekString());
            searchResultVobsAddr.Add(addr);
        }

        [DllExport]
        public static void OnSearchResultEnd()
        {
            SpacerNET.objectsWin.listBoxSearchResult.Items.AddRange(searchResultVobsNamesTemp.ToArray());

            searchResultVobsNamesTemp.Clear();
        }

        [DllExport]
        public static bool ConvertVobs()
        {
            string vobInfo = Imports.Stack_PeekString();

            convertProps.Clear();
            foldersConvertVob.Clear();
            currentFolderNameConvertVob = "";


            //static Dictionary<string, FolderEntry> foldersConvertVob = new Dictionary<string, FolderEntry>();
            //static string currentFolderNameConvertVob = "";

            bool useRegx = SpacerNET.objectsWin.checkBoxSearchUseRegex.Checked;

            string[] words = vobInfo.Replace("\t", "").Split('\n');

            List<string> rawProps = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();
                rawProps.Add(words[i]);

                if (words[i].Length == 0 || words[i].Contains('[') || (!words[i].Contains(':') || !words[i].Contains('=')))
                {
                    continue;
                }

                

                if (words[i].Contains("groupBegin"))
                {
                    string folderName = words[i].Substring(0, words[i].IndexOf('='));

                    FolderEntry f = new FolderEntry();
                    f.parent = currentFolderNameConvertVob;

                    foldersConvertVob.Add(folderName, f);
                    currentFolderNameConvertVob = folderName;
                    continue;
                }

                if (words[i].Contains("groupEnd"))
                {
                    currentFolderNameConvertVob = foldersConvertVob[currentFolderNameConvertVob].parent;
                    continue;
                }

                CProperty prop = new CProperty();
                prop.Name = words[i].Substring(0, words[i].IndexOf('='));
                prop.GroupName = currentFolderNameConvertVob;

                int pos = words[i].IndexOf('=');
                int pos2 = words[i].IndexOf(':');

                prop.SetType(words[i].Substring(pos + 1, pos2 - pos - 1));

                pos = words[i].IndexOf(':');

                prop.SetValue(words[i].Substring(pos + 1, words[i].Length - pos - 1));

                if (currentFolderNameConvertVob != "")
                {
                    prop.node = foldersConvertVob[currentFolderNameConvertVob].node;
                }

                convertProps.Add(prop);
            }



            bool changed = false;

            for (int i = 0; i < newProps.Count; i++)
                if (newProps[i].selectedForSearch)
                {
                    bool found = false;
                    int pc = 0;
                    while (!found && pc < convertProps.Count)
                    {
                        found = convertProps[pc].Name == newProps[i].Name;
                        if (!found) pc++;
                    }

                    if (found)
                    {
                        convertProps[pc] = newProps[i];
                        changed = true;
                    }
                }

            bool result = false;


            string className = SpacerNET.objectsWin.comboBoxSearchClassReplace.Text.Replace(".", "").Trim();



            if (changed)
            {

                string[] raw = vobInfo.Replace("\t", "").Split('\n');

                for (int j = 0; j < raw.Length; j++)
                {
                    if (raw[j].Length == 0)
                    {
                        continue;
                    }

                    for (int i = 0; i < convertProps.Count; i++)
                    {
                        if (Regex.IsMatch(raw[j], "^" + convertProps[i].Name + @"=\w", RegexOptions.IgnoreCase))
                        {
                            string baseStr = raw[j].Substring(0, raw[j].IndexOf(':') + 1) + convertProps[i].value;
                            //Console.WriteLine(baseStr);
                            raw[j] = baseStr;
                        }
                    }

                }


                StringBuilder str = new StringBuilder(); 

                for (int j = 0; j < words.Length; j++)
                {
                    str.Append(words[j] + "\n");
                }

                Imports.Stack_PushString(str.ToString());
                Imports.Extern_AddConvertVob();
                /*
                zCBuffer zbuf(zstrBuf.ToChar(), zstrBuf.Length());

                zCArchiver* arch = zarcFactory.CreateArchiverRead(&zbuf);
                arch->SetStringEOL(zSTRING("\n"));
                arch->ReadObject(vob);
                arch->Close();
                zRELEASE(arch);
                */
                result = true;
            }

            return result;

        }


        [DllExport]
        public static bool CompareByNameOrVisual()
        {
            bool match = false;
            bool useRegx = SpacerNET.objectsWin.checkBoxSearchUseRegex.Checked;
            string visualName = Imports.Stack_PeekString();
            string vobName = Imports.Stack_PeekString();

            bool flagSearchName = SpacerNET.objectsWin.onlyNameVisualSearch == 1;
            bool flagSearchVisual = SpacerNET.objectsWin.onlyNameVisualSearch == 2;

            compareProps.Clear();
            foldersCompare.Clear();
            currentFolderNameCompare = "";

            //ConsoleEx.WriteLineGreen(vobName + "; " + visualName + " SearchPropsCount: " + searchProps.Count);

            int j = 0;
            while (j < searchProps.Count)
            {
                if (flagSearchName && searchProps[j].selectedForSearch && searchProps[j].Name == "vobName")
                {
                    if (useRegx)
                    {
                        Regex reg = new Regex(searchProps[j].value, RegexOptions.IgnoreCase);

                        match = reg.IsMatch(vobName);
                    }
                    else
                    {
                        match = vobName == searchProps[j].value;
                    }

                    return match;
                }
                else if (flagSearchVisual && searchProps[j].selectedForSearch && searchProps[j].Name == "visual")
                {
                    if (useRegx)
                    {
                        Regex reg = new Regex(searchProps[j].value, RegexOptions.IgnoreCase);

                        match = reg.IsMatch(visualName);
                    }
                    else
                    {
                        match = visualName == searchProps[j].value;
                    }

                    return match;
                }
                j++;
            }

            return false;
        }

        [DllExport]
        public static bool CompareVobs()
        {
            string vobInfo = Imports.Stack_PeekString();

            compareProps.Clear();
            foldersCompare.Clear();
            currentFolderNameCompare = "";

            //ConsoleEx.WriteLineRed("");

            bool useRegx = SpacerNET.objectsWin.checkBoxSearchUseRegex.Checked;


            string[] words = vobInfo.Replace("\t", "").Split('\n');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();

                if (words[i].Length == 0 || words[i].Contains('[') || (!words[i].Contains(':') || !words[i].Contains('=')))
                {
                    continue;
                }

                if (words[i].Contains("groupBegin"))
                {
                    string folderName = words[i].Substring(0, words[i].IndexOf('='));

                    FolderEntry f = new FolderEntry();
                    f.parent = currentFolderNameCompare;

                    foldersCompare.Add(folderName, f);
                    currentFolderNameCompare = folderName;
                    continue;
                }

                if (words[i].Contains("groupEnd"))
                {
                    currentFolderNameCompare = foldersCompare[currentFolderNameCompare].parent;
                    continue;
                }

                CProperty prop = new CProperty();
                prop.Name = words[i].Substring(0, words[i].IndexOf('='));
                prop.GroupName = currentFolderNameCompare;

                int pos = words[i].IndexOf('=');
                int pos2 = words[i].IndexOf(':');

                prop.SetType(words[i].Substring(pos + 1, pos2 - pos - 1));

                pos = words[i].IndexOf(':');

                prop.SetValue(words[i].Substring(pos + 1, words[i].Length - pos - 1));

                if (currentFolderNameCompare != "")
                {
                    prop.node = foldersCompare[currentFolderNameCompare].node;
                }

                compareProps.Add(prop);
            }

            //ConsoleEx.WriteLineRed(compareProps.Count.ToString());

            bool match = true;
            int j = 0;
            while (match && j < searchProps.Count)
            {
                if (searchProps[j].selectedForSearch)
                {
                    match = false;
                    int pc = 0;

                    while (!match && pc < compareProps.Count)
                    {
                        if (compareProps[pc].Name == searchProps[j].Name)
                        {
                            //ConsoleEx.WriteLineRed(compareProps[pc].Name + ": " + compareProps[pc].value + "/" + searchProps[j].value);
                            // compare это текущий воб, search это то что в интерфейсе

                            if (compareProps[pc].type == TPropEditType.PETint || compareProps[pc].type == TPropEditType.PETfloat)
                            {

                                match = compareProps[pc].value == searchProps[j].value;

                                // если строки (числа) не равны, то
                                if (!match 
                                    && searchProps[j].numSearchType != TSearchNumberType.TS_EQUALS
                                    && searchProps[j].value != ""
                                    && compareProps[pc].value != ""
                                   )
                                {
                                    if (compareProps[pc].type == TPropEditType.PETint)
                                    {
                                       // ConsoleEx.WriteLineRed("INT");
                                        int vobIntValue = Convert.ToInt32(compareProps[pc].value);
                                        int searchIntValue = Convert.ToInt32(searchProps[j].value);

                                        
                                        if (searchProps[j].numSearchType == TSearchNumberType.TS_LESSTHAN)
                                        {
                                            match = vobIntValue <= searchIntValue;

                                            // check > 0
                                            if (match && searchProps[j].moreThanZero)
                                            {
                                                match = vobIntValue > 0;
                                            }
                                        }
                                        else if (searchProps[j].numSearchType == TSearchNumberType.TS_MORETHAN)
                                        {
                                            match = vobIntValue >= searchIntValue;

                                            // check > 0
                                            if (match && searchProps[j].moreThanZero)
                                            {
                                                match = vobIntValue > 0;
                                            }
                                        }
                                    }
                                    else if (compareProps[pc].type == TPropEditType.PETfloat)
                                    {
                                        //ConsoleEx.WriteLineRed("FLOAT");

                                        double vobFloatValue = 0;
                                        double searchFloatValue = 0;

                                        if (Double.TryParse(searchProps[j].value, NumberStyles.Any, CultureInfo.InvariantCulture, out searchFloatValue) 
                                            && Double.TryParse(compareProps[pc].value, NumberStyles.Any, CultureInfo.InvariantCulture, out vobFloatValue)
                                            )
                                        {
                                           // ConsoleEx.WriteLineGreen("TryParse ok");

                                            float valCompare = Convert.ToSingle(searchFloatValue, CultureInfo.InvariantCulture);
                                            float valVob = Convert.ToSingle(vobFloatValue, CultureInfo.InvariantCulture);


                                            if (searchProps[j].numSearchType == TSearchNumberType.TS_LESSTHAN)
                                            {
                                                match = valVob <= valCompare;
                                                // check > 0
                                                if (match && searchProps[j].moreThanZero)
                                                {
                                                    match = valVob > 0;
                                                }
                                            }
                                            else if (searchProps[j].numSearchType == TSearchNumberType.TS_MORETHAN)
                                            {
                                                match = valVob >= valCompare;
                                                // check > 0
                                                if (match && searchProps[j].moreThanZero)
                                                {
                                                    match = valVob > 0;
                                                }
                                            }
                                        }

                                        
                                    }
                                }

                            }
                            else if (useRegx)
                            {
                                Regex reg = new Regex(searchProps[j].value, RegexOptions.IgnoreCase);

                                match = reg.IsMatch(compareProps[pc].value);
                            }
                            else
                            {
                                match = compareProps[pc].value == searchProps[j].value;
                            }
                            
                            
                            
                        }
                        if (!match) pc++;
                    }

                }
                ++j;
            }

            return match;

        }

        private void listBoxSearchResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBoxSearchResult.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                if (listBoxSearchResult.Items.Count >= index - 1)
                {
                    uint vobAddr = searchResultVobsAddr[index];
                    //ConsoleEx.WriteLineGreen(vobAddr + " index " + index);

                    try
                    {
                        SpacerNET.objTreeWin.globalTree.SelectedNode =
                        ObjTree.globalEntries[vobAddr].node;
                    }
                    catch
                    {
                        ConsoleEx.WriteLineGreen("listBoxSearchResult_MouseDoubleClick. Can't find vob with addr: " + Utils.ToHex(vobAddr));
                    }
                    selectTabBlocked = 2;
                    Imports.Extern_SelectVob(vobAddr);


                }

            }
        }

        private void listBoxSearchResult_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listBoxSearchResult.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                if (listBoxSearchResult.Items.Count >= index - 1)
                {
                    uint vobAddr = searchResultVobsAddr[index];
                    //ConsoleEx.WriteLineGreen(vobAddr + " index " + index);

                    try
                    {
                        SpacerNET.objTreeWin.globalTree.SelectedNode =
                        ObjTree.globalEntries[vobAddr].node;

                        selectTabBlocked = 2;
                        Imports.Extern_SelectVobSync(vobAddr);
                    }
                    catch
                    {
                        ConsoleEx.WriteLineGreen("vobListSelect. Can't find vob with addr: " + Utils.ToHex(vobAddr));
                    }


                }

            }
        }

        private void comboBoxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            comboBoxSearchClassReplace.Visible = false;
            radioButtonConvertOld.Visible = false;
            radioButtonConvertNew.Visible = false;
            textBoxRenameVob.Visible = false;
            labelRenameVob.Visible = false;
            checkBoxAutoNumerate.Visible = false;

            switch (cb.SelectedIndex)
            {
                case 0: buttonSearchVobsDo.Text = Localizator.Get("VOB_SEARCH_TYPE0"); break;
                case 1: buttonSearchVobsDo.Text = Localizator.Get("VOB_SEARCH_TYPE1"); break;
                case 2: buttonSearchVobsDo.Text = Localizator.Get("VOB_SEARCH_TYPE2"); break;
                case 3: buttonSearchVobsDo.Text = Localizator.Get("VOB_SEARCH_TYPE3"); break;
                case 4: buttonSearchVobsDo.Text = Localizator.Get("VOB_SEARCH_TYPE_DYNAMIC"); break;
                case 5: buttonSearchVobsDo.Text = Localizator.Get("VOB_SEARCH_TYPE0"); break;
                case 6: buttonSearchVobsDo.Text = Localizator.Get("VOB_SEARCH_TYPE_RENAME"); break;

                 
            }

            //rename
            if (cb.SelectedIndex == 6)
            {
                if (renameWin == null)
                {
                    renameWin = new RenameForm();
                }

                renameWin.ShowDialog();
            }

            if (cb.SelectedIndex == 1)
            {
                
                MessageBox.Show("Not working yet!");
                return;
                comboBoxSearchClassReplace.Visible = true;
                radioButtonConvertOld.Visible = true;
                radioButtonConvertNew.Visible = true;
            }
            else if (radioButtonConvertNew.Checked)
            {

                treeViewSearchClass.Nodes.Clear();

                string selectedClass = comboBoxSearchClass.Text.Replace(".", "").Trim();

                Imports.Stack_PushString(selectedClass);
                Imports.Extern_GetClassFields(true);

                string result = Imports.Stack_PeekString();

                FillClassFields(result);

                comboBoxSearchClassReplace_SelectedIndexChanged(comboBoxSearchClassReplace, null);
            }



            if (cb.SelectedIndex == 2)
            {
                OpenFileDialog openFileDialogVobTree = new OpenFileDialog();

                openFileDialogVobTree.Filter = Constants.FILE_FILTER_OPEN_VOBTREE;

                Imports.Stack_PushString("treeVobPath");
                Imports.Extern_GetSettingStr();
                string path = Imports.Stack_PeekString();

                openFileDialogVobTree.InitialDirectory = Utils.GetInitialDirectory(path);

                openFileDialogVobTree.RestoreDirectory = true;

                if (openFileDialogVobTree.ShowDialog() == DialogResult.OK)
                {
                    replaceZenPath = openFileDialogVobTree.FileName.Trim();
                }

            }
            /*
            if (cb.SelectedIndex == 4)
            {

                checkBoxAutoNumerate.Visible = true;
                textBoxRenameVob.Visible = true;
                labelRenameVob.Visible = true;
                labelRenameVob.Text = Localizator.Get("labelRenameVob");
                checkBoxAutoNumerate.Text = Localizator.Get("checkBoxAutoNumerate");
                
                textBoxRenameVob.Text = String.Empty;
            }
            */
            //dynamic
            if (cb.SelectedIndex == 4)
            {
                
            }
        }


        private void radioButtonConvertNew_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                treeViewSearchClass.Nodes.Clear();


                string selectedClass = comboBoxSearchClassReplace.Text.Replace(".", "").Trim();
                // ConsoleEx.WriteLineRed(selectedClass);

                Imports.Stack_PushString(selectedClass);
                Imports.Extern_GetClassFields(true);

                string result = Imports.Stack_PeekString();

                FillClassFieldsConvert(result, false);


            }
        }

        private void radioButtonConvertOld_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                treeViewSearchClass.Nodes.Clear();


                string selectedClass = comboBoxSearchClass.Text.Replace(".", "").Trim();

                Imports.Stack_PushString(selectedClass);
                Imports.Extern_GetClassFields(false);

                string result = Imports.Stack_PeekString();

                FillClassFields(result, false);
            }
        }

        private void comboBoxSearchClassReplace_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (!SpacerNET.isInit)
            {
                return;
            }

            string selectedClass = cb.Text.Replace(".", "").Trim();

            Imports.Stack_PushString(selectedClass);
            Imports.Extern_GetClassFields(true);

            string result = Imports.Stack_PeekString();


            FillClassFieldsConvert(result);

            radioButtonConvertNew.Checked = true;
        }

        private void trackBarLocatorRad_ValueChanged(object sender, EventArgs e)
        {
            labelItemLocatorRadius.Text = Localizator.Get("labelItemLocatorRadius") + trackBarLocatorRad.Value;

            Imports.Stack_PushString("itemLocatorRadius");
            Imports.Extern_SetSetting(trackBarLocatorRad.Value);
        }

        private void checkBoxLocatorEnabled_CheckedChanged(object sender, EventArgs e)
        {
            var locatorCheck = sender as CheckBox;

            Imports.Stack_PushString("itemLocatorEnabled");
            Imports.Extern_SetSetting(Convert.ToInt32(locatorCheck.Checked));
        }

        private void checkBoxLocatorOnlySusp_CheckedChanged(object sender, EventArgs e)
        {
            var locatorCheck = sender as CheckBox;

            Imports.Stack_PushString("itemLocatorOnlySusp");
            Imports.Extern_SetSetting(Convert.ToInt32(locatorCheck.Checked));
        }

        //========================================================


        public void InitCameraTab()
        {

        }


        private void checkBoxLocatorByName_CheckedChanged(object sender, EventArgs e)
        {
            var locatorCheck = sender as CheckBox;

            Imports.Stack_PushString("itemLocatorOnlyByName");
            Imports.Extern_SetSetting(Convert.ToInt32(locatorCheck.Checked));

            if (locatorCheck.Checked)
            {
                textBoxLocatorByName_TextChanged(null, null);
            }
        }

        private void textBoxLocatorByName_TextChanged(object sender, EventArgs e)
        {
            if (!SpacerNET.isInit)
            {
                return;
            }

            var text = textBoxLocatorByName.Text.Trim();

            //ConsoleEx.WriteLineRed(text);

            if (text.Length > 0)
            {
                if (text.Contains(' '))
                {
                    MessageBox.Show(Localizator.Get("ERROR_NAME_CANT_CONTAIN_SPACE"));
                    return;
                }

                if (!Utils.IsOnlyLatin(text))
                {
                    MessageBox.Show(Localizator.Get("FORM_ENTER_BAD_STRING_INPUT"));
                    return;
                }
            }

            Imports.Stack_PushString(text);
            Imports.Stack_PushString("itemLocatorNameSearch");
            Imports.Extern_SetSettingStr();
        }

        private void listBoxVisuals_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            ListBox listBox = sender as ListBox;

            ConsoleEx.WriteLineRed("listBoxVisuals_KeyDown");

            if (e.KeyCode == Keys.S && listBox.SelectedIndex < listBox.Items.Count - 1)
            {
                listBox.SelectedIndex += 1;

                ConsoleEx.WriteLineRed("index plus");
            }

            if (e.KeyCode == Keys.W && listBox.SelectedIndex > 0)
            {
                listBox.SelectedIndex -= 1;
            }

            Application.DoEvents();
            */
        }

        private void listBoxVisuals_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ConsoleEx.WriteLineRed("listBoxVisuals_KeyPress");
        }

        private void radioButtonSearchEquals_CheckedChanged(object sender, EventArgs e)
        {
            if (dontUpdateNumType || Imports.Extern_IsWorldLoaded() == 0) return;

            textBoxSearchVobs_TextChanged(textBoxSearchVobs, null);
        }

        private void ObjectsWin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        // CAMERA============================================================================
        private void buttonCamInsert_Click(object sender, EventArgs e)
        {
            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            string camName = textBoxCamName.Text.Trim();

            if (camName.Length == 0)
            {
                MessageBox.Show(Localizator.Get("ENTER_NAME"));
                return;
            }

            Imports.Stack_PushString(camName.ToUpper());

            int nameFound = Imports.Extern_VobNameExist(false);
            if (nameFound == 1)
            {

                MessageBox.Show(Localizator.Get("NAME_ALREADY_EXISTS"));
                return;
            }


            camEntry.OnInsertNewCamera(camName);

            SpacerNET.form.Focus();
        }


        public void BlockInterfaceWhileCameraMoving(bool toggle, bool blockNewCam = false)
        {
            if (blockNewCam)
            {
                buttonCamInsert.Enabled = !toggle;
                textBoxCamName.Enabled = !toggle;
            }
            
            buttonCamSpline.Enabled = !toggle;
            buttonCamTargetSpline.Enabled = !toggle;
            listBoxCameraSpline.Enabled = !toggle;
            listBoxCameraTarget.Enabled = !toggle;
            
            checkBoxCameraHide.Enabled = !toggle;
            textBoxCamTime.Enabled = !toggle;
        }

        [DllExport]
        public static void OnToggleCamera_Interface()
        {
            bool val = Convert.ToBoolean(Imports.Stack_PeekInt());

            SpacerNET.objectsWin.BlockInterfaceWhileCameraMoving(!val);

            //SpacerNET.objectsWin.buttonCamMinus.Enabled = val;
            //SpacerNET.objectsWin.buttonCamPlus.Enabled = val;
            SpacerNET.objectsWin.buttonCamPlay.Enabled = val;
            
        }

        public void EnableInterfaceWhileCameraMoving(bool toggle)
        {
            buttonCamMinus.Enabled = toggle;
            buttonCamPlus.Enabled = toggle;
        }
        private void buttonCamPlay_Click(object sender, EventArgs e)
        {
            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            var btn = sender as Button;

            if (camEntry.cameraRun)
            {
                camEntry.cameraRun = false;
                BlockInterfaceWhileCameraMoving(false, true);
                EnableInterfaceWhileCameraMoving(false);
                camEntry.currentKey = 0;
                labelCamKeyCurrent.Text = camEntry.currentKey.ToString();
                btn.Text = Localizator.Get("WIN_CAMERA_START");
                camEntry.OnStop();
                
            }
            else
            {
                camEntry.OnChangeTime(textBoxCamTime.Text.Trim(), checkBoxCameraHide.Checked);
                camEntry.cameraRun = true;
                BlockInterfaceWhileCameraMoving(true, true);
                EnableInterfaceWhileCameraMoving(true);
                camEntry.currentKey = 0;
                labelCamKeyCurrent.Text = camEntry.currentKey.ToString();
                btn.Text = Localizator.Get("WIN_CAMERA_STOP");
                camEntry.OnRun();
                
            }
            
        }

        private void buttonCamTargetSpline_Click(object sender, EventArgs e)
        {
            camEntry.OnInsertTargetKey();

            listBoxCameraTarget.SelectedIndex = listBoxCameraTarget.Items.Count - 1;
        }

        private void buttonCameraStop_Click(object sender, EventArgs e)
        {
            camEntry.OnStop();
        }

        private void textBoxCamTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
         (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            
        }

        private void textBoxCamTime_KeyUp(object sender, KeyEventArgs e)
        {
            camEntry.OnChangeTime(textBoxCamTime.Text.Trim(), checkBoxCameraHide.Checked);
        }

        private void checkBoxCameraHide_CheckedChanged(object sender, EventArgs e)
        {
            camEntry.OnChangeTime(textBoxCamTime.Text.Trim(), checkBoxCameraHide.Checked);
        }

        private void buttonCamPlus_Click(object sender, EventArgs e)
        {
            if (camEntry.currentKey < Imports.Extern_CameraGetMaxKey())
            {
                camEntry.currentKey += 1;
                labelCamKeyCurrent.Text = camEntry.currentKey.ToString();
                camEntry.OnUpdateKey();
                
            }


        }

        private void buttonCamMinus_Click(object sender, EventArgs e)
        {
            if (camEntry.currentKey > 0)
            {
                camEntry.currentKey -= 1;
                labelCamKeyCurrent.Text = camEntry.currentKey.ToString();
                camEntry.OnUpdateKey();
                
            }
        }


        private void labelCamGotoKey_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemCamRemove_Click(object sender, EventArgs e)
        {
            int index = listBoxCameraSpline.SelectedIndex;
            if (index != -1)
            {

                DialogResult dialogResult = MessageBox.Show(Localizator.Get("WIN_MSG_CONFIRM_REMOVEVOB"), Localizator.Get("WIN_MSG_CONFIRM"), MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Imports.Extern_RemoveSplineKeyByIndex(index);
                }


               
            }
        }

        private void listBoxCameraTarget_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void listBoxCameraTarget_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listBoxCameraTarget.SelectedIndex;

            if (index != -1)
            {
                Imports.Extern_SelectTargetKeyByIndex(index);
            }

            listBoxCameraTarget.SelectedIndex = index;

        }

        private void listBoxCameraSpline_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listBoxCameraSpline.SelectedIndex;

            if (index != -1)
            {
                Imports.Extern_SelectSplineKeyByIndex(index);
            }

            listBoxCameraSpline.SelectedIndex = index;

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int index = listBoxCameraTarget.SelectedIndex;
            if (index != -1)
            {

                DialogResult dialogResult = MessageBox.Show(Localizator.Get("WIN_MSG_CONFIRM_REMOVEVOB"), Localizator.Get("WIN_MSG_CONFIRM"), MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Imports.Extern_RemoveTargetKeyByIndex(index);
                }

                
            }
        }

        private void stInsertNewKeyHere_Click(object sender, EventArgs e)
        {
            int index = listBoxCameraSpline.SelectedIndex;

            if (index != -1)
            {
                Imports.Extern_InsertPosKeyAtIndex(index);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int index = listBoxCameraTarget.SelectedIndex;

            if (index != -1)
            {
                Imports.Extern_InsertTargetKeyAtIndex(index);
            }
        }

        private void listBoxSearchResult_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (e.Button == MouseButtons.Middle)
            {

                int index = lb.IndexFromPoint(e.Location);
                {
                    if (index >= 0 && lb.Items.Count > 0)
                    {
                        string name = lb.GetItemText(lb.Items[index]);


                        string text = name;
                        int indexMiddle = text.LastIndexOf('(');

                        text = text.Substring(0, indexMiddle - 1);
                        text = text.Trim();

                        Utils.SetCopyText(text);
                    }
                }
            }
        }

        private void listBoxItems_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (e.Button == MouseButtons.Middle && lb != null)
            {

                int index = lb.IndexFromPoint(e.Location);

                if (index >= 0 && lb.Items.Count > 0)
                {
                    string visual = lb.GetItemText(lb.Items[index]);

                    Utils.SetCopyText(visual);
                }

            }
        }

        private void listBoxResultItems_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (e.Button == MouseButtons.Middle && lb != null)
            {

                int index = lb.IndexFromPoint(e.Location);

                if (index >= 0 && lb.Items.Count > 0)
                {
                    string visual = lb.GetItemText(lb.Items[index]);

                    Utils.SetCopyText(visual);
                }

            }
        }

        private void groupBoxSearchClasses_Enter(object sender, EventArgs e)
        {

        }

        private void checkBoxSearchItem_CheckedChanged(object sender, EventArgs e)
        {
            var box = sender as CheckBox;

            
            if (checkBoxSearchHasChildren.Checked && box.Checked)
            {
                checkBoxSearchHasChildren.Checked = false;
            }

            if (checkBoxMatchNames.Checked && box.Checked)
            {
                checkBoxMatchNames.Checked = false;
            }
            
        }

        private void checkBoxSearchHasChildren_CheckedChanged(object sender, EventArgs e)
        {
            var box = sender as CheckBox;


            if (checkBoxSearchItem.Checked && box.Checked)
            {
                checkBoxSearchItem.Checked = false;
            }

            if (checkBoxMatchNames.Checked && box.Checked)
            {
                checkBoxMatchNames.Checked = false;
            }
        }

        private void checkBoxMatchNames_CheckedChanged(object sender, EventArgs e)
        {
            var box = sender as CheckBox;


            if (checkBoxSearchItem.Checked && box.Checked)
            {
                checkBoxSearchItem.Checked = false;
            }

            if (checkBoxSearchHasChildren.Checked && box.Checked)
            {
                checkBoxSearchHasChildren.Checked = false;
            }
        }

        private void comboBoxLocatorItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Imports.Stack_PushInt(comboBoxLocatorItemType.SelectedIndex);

            Imports.Extern_SetLocatorItemType();
        }

        private void textBoxTrigersJumpKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !Utils.IsNumberInput(e.KeyChar, false, false))
            {
                e.Handled = true;
            }
        }

        private void buttonTriggersJumpToKey_Click(object sender, EventArgs e)
        {
            string text = textBoxTrigersJumpKey.Text.Trim();

            if (text.Length == 0)
            {
                return;
            }

            int val = 0;

            int.TryParse(textBoxTrigersJumpKey.Text.Trim(), out val);

            Imports.Stack_PushInt(val);

            Imports.Extern_SetMoverToKey();
        }

        public static DialogResult ShowInputDialog(ref string text)
        {
            Form prompt = new Form();
            prompt.ShowIcon = false;
            prompt.MinimizeBox = false;
            prompt.MaximizeBox = false;
            prompt.FormBorderStyle = FormBorderStyle.FixedSingle;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            prompt.Width = 225;
            prompt.Height = 122;
            prompt.Text = Localizator.Get("WIN_INPUT");

            TextBox inputBox = new TextBox() { Text = text, Left = 10, Top = 27, Width = 200 };
            prompt.Controls.Add(inputBox);

            Button buttonOK = new Button() { Text = "OK", Left = 10, Top = 60, Width = 75 };
            buttonOK.Click += (sender, e) => {
                prompt.DialogResult = DialogResult.OK;
                prompt.Close();
            };
            prompt.Controls.Add(buttonOK);
            prompt.AcceptButton = buttonOK;

            Button buttonCancel = new Button() { Text = Localizator.Get("WIN_CANCEL_BUTTON"), Left = 95, Top = 60, Width = 75 };
            buttonCancel.Click += (sender, e) => {
                prompt.DialogResult = DialogResult.Cancel;
                prompt.Close();
            };
            prompt.Controls.Add(buttonCancel);

            DialogResult result = prompt.ShowDialog();
            text = inputBox.Text;

            return result;
        }

        [DllExport]
        public static void AddLightPresetToList()
        {
            string presetName = Imports.Stack_PeekString();
            SpacerNET.objectsWin.listBoxLightPresets.Items.Add(presetName);
        }

        [DllExport]
        public static void UpdateLightPresetView()
        {
            bool staticLight = Imports.Stack_PeekBool();
            if (staticLight)
                SpacerNET.objectsWin.radioButtonLightVobStatic.Checked = true;
            else
                SpacerNET.objectsWin.radioButtonLightVobDynamic.Checked = true;

            int lightQuality = Imports.Stack_PeekInt();
            SpacerNET.objectsWin.comboBoxLightVobLightQuality.SelectedIndex = lightQuality;
            SpacerNET.objectsWin.comboBoxLightVobLightQuality.Enabled = !staticLight;

            int range = Imports.Stack_PeekInt();
            SpacerNET.objectsWin.numericUpDownLightVobRange.Value = range;

            SpacerNET.objectsWin.listBoxLightPresetColors.Items.Clear();
            int colorsCount = Imports.Stack_PeekInt();
            for (int i = 0; i < colorsCount; ++i)
            {
                Color color = Color.FromArgb(Imports.Stack_PeekInt());
                SpacerNET.objectsWin.listBoxLightPresetColors.Items.Add(color);
            }

            float colorAniFPS = Imports.Stack_PeekFloat() * 1000.0f;
            SpacerNET.objectsWin.textBoxLightVobColorAniFPS.Text = colorAniFPS.ToString(CultureInfo.InvariantCulture);

            bool colorAniSmooth = Imports.Stack_PeekBool();
            SpacerNET.objectsWin.checkBoxLightVobColorAniSmooth.Checked = colorAniSmooth;

            SpacerNET.objectsWin.listBoxLightPresetRangeAniScales.Items.Clear();
            int rangeAniScalesCount = Imports.Stack_PeekInt();
            for (int i = 0; i < rangeAniScalesCount; ++i)
            {
                float rangeAniScale = Imports.Stack_PeekFloat();
                SpacerNET.objectsWin.listBoxLightPresetRangeAniScales.Items.Add(rangeAniScale.ToString(CultureInfo.InvariantCulture));
            }

            float rangeAniFPS = Imports.Stack_PeekFloat() * 1000.0f;
            SpacerNET.objectsWin.textBoxLightVobRangeAniFPS.Text = rangeAniFPS.ToString(CultureInfo.InvariantCulture);

            bool rangeAniSmooth = Imports.Stack_PeekBool();
            SpacerNET.objectsWin.checkBoxLightVobRangeAniSmooth.Checked = rangeAniSmooth;
        }

        [DllExport]
        public static void OnSelectLightVob()
        {
            string vobName = Imports.Stack_PeekString();
            string presetName = Imports.Stack_PeekString();

            SpacerNET.objectsWin.textBoxLightVobName.Text = vobName;
            SpacerNET.objectsWin.textBoxLightVobPresetName.Text = presetName;

            SpacerNET.objectsWin.UpdateLightWindow(true);
        }

        [DllExport]
        public static void OnDeselectLightVob()
        {
            SpacerNET.objectsWin.textBoxLightVobName.Text = "";
            SpacerNET.objectsWin.textBoxLightVobPresetName.Text = "";

            if (SpacerNET.objectsWin.listBoxLightPresets.SelectedItem != null)
            {
                Imports.Stack_PushString(SpacerNET.objectsWin.listBoxLightPresets.SelectedItem.ToString());
                Imports.Extern_Light_QueryPresetData();
            }

            SpacerNET.objectsWin.UpdateLightWindow(false);
        }

        private void PushLightPresetData()
        {
            Imports.Stack_PushBool(checkBoxLightVobRangeAniSmooth.Checked);

            float value = 0.0f;
            float.TryParse(textBoxLightVobRangeAniFPS.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out value);
            Imports.Stack_PushFloat(value * 0.001f);

            foreach (string item in listBoxLightPresetRangeAniScales.Items)
            {
                value = 0.0f;
                float.TryParse(item, NumberStyles.Float, CultureInfo.InvariantCulture, out value);
                Imports.Stack_PushFloat(value);
            }

            Imports.Stack_PushInt(listBoxLightPresetRangeAniScales.Items.Count);

            Imports.Stack_PushBool(checkBoxLightVobColorAniSmooth.Checked);

            value = 0.0f;
            float.TryParse(textBoxLightVobColorAniFPS.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out value);
            Imports.Stack_PushFloat(value * 0.001f);

            foreach (Color item in listBoxLightPresetColors.Items)
                Imports.Stack_PushInt(item.ToArgb());

            Imports.Stack_PushInt(listBoxLightPresetColors.Items.Count);

            Imports.Stack_PushInt((int)numericUpDownLightVobRange.Value);
            Imports.Stack_PushInt(comboBoxLightVobLightQuality.SelectedIndex);
            Imports.Stack_PushBool(radioButtonLightVobStatic.Checked);
        }
        private void radioButtonLightVobStatic_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxLightVobLightQuality.Enabled = false;
        }

        private void radioButtonLightVobDynamic_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxLightVobLightQuality.Enabled = true;
        }

        private void buttonCreateLightVob_Click(object sender, EventArgs e)
        {
            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            if (listBoxLightPresets.SelectedItem == null)
                PushLightPresetData();

            Imports.Stack_PushString(listBoxLightPresets.SelectedItem != null ? listBoxLightPresets.SelectedItem.ToString() : "");
            Imports.Stack_PushString(textBoxLightVobName.Text);
            Imports.Extern_Light_CreateVob();
        }
        private void buttonApplyChangesLight_Click(object sender, EventArgs e)
        {
            PushLightPresetData();
            Imports.Stack_PushString(textBoxLightVobName.Text);

            Imports.Stack_PushString(listBoxLightPresets.SelectedItem != null ? listBoxLightPresets.SelectedItem.ToString() : "");
            if (Imports.Extern_Light_ApplyChanges() == 1)
                buttonSaveLightPresets.Enabled = true;
        }

        private void buttonAddLightPresetColor_Click(object sender, EventArgs e)
        {
            if (colorDialogLightPresetColor.ShowDialog() != DialogResult.OK)
                return;

            listBoxLightPresetColors.Items.Add(colorDialogLightPresetColor.Color);
        }

        private void buttonRemoveLightPresetColor_Click(object sender, EventArgs e)
        {
            if (listBoxLightPresetColors.Items.Count == 1)
                return;

            listBoxLightPresetColors.Items.RemoveAt((listBoxLightPresetColors.SelectedIndex != -1) ? listBoxLightPresetColors.SelectedIndex : listBoxLightPresetColors.Items.Count - 1);
        }

        private void buttonMoveLightPresetColorUp_Click(object sender, EventArgs e)
        {
            int index = listBoxLightPresetColors.SelectedIndex;
            if (index == -1)
                return;

            var item = listBoxLightPresetColors.Items[index];
            listBoxLightPresetColors.Items.RemoveAt(index);

            index = Math.Min(Math.Max(index - 1, 0), Math.Max(listBoxLightPresetColors.Items.Count - 1, 0));
            listBoxLightPresetColors.Items.Insert(index, item);

            listBoxLightPresetColors.SelectedIndex = index;
        }

        private void buttonMoveLightPresetColorDown_Click(object sender, EventArgs e)
        {
            int index = listBoxLightPresetColors.SelectedIndex;
            if (index == -1)
                return;

            var item = listBoxLightPresetColors.Items[index];
            listBoxLightPresetColors.Items.RemoveAt(index);

            index = Math.Min(Math.Max(index + 1, 0), listBoxLightPresetColors.Items.Count);
            listBoxLightPresetColors.Items.Insert(index, item);

            listBoxLightPresetColors.SelectedIndex = index;
        }

        private object listBoxLightPresetsPreviouslySelectedItem = null;
        private void listBoxLightPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxLightPresets.SelectedItem == listBoxLightPresetsPreviouslySelectedItem)
                listBoxLightPresets.SelectedItem = null;

            if (listBoxLightPresets.SelectedItem != null)
            {
                Imports.Stack_PushString(listBoxLightPresets.SelectedItem.ToString());
                Imports.Extern_Light_QueryPresetData();
            }

            listBoxLightPresetsPreviouslySelectedItem = listBoxLightPresets.SelectedItem;
        }

        private void listBoxLightPresetColors_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1)
                return;

            ListBox colorListBox = (ListBox)sender;
            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            uint color = (uint)((Color)colorListBox.Items[e.Index]).ToArgb();
            color = color & 0x00FFFFFFu;
            color = color | 0xFF000000u;

            e = new DrawItemEventArgs(
                e.Graphics,
                e.Font,
                e.Bounds,
                e.Index,
                selected ? e.State ^ DrawItemState.Selected : e.State,
                e.ForeColor,
                selected ? Color.Red : Color.Black
            );

            e.DrawBackground();

            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb((int)color)), new Rectangle(e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 2, e.Bounds.Height - 2));

            e.DrawFocusRectangle();
        }

        private void listBoxLightPresetColors_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBoxLightPresetColors.IndexFromPoint(e.Location);
            if (index == -1)
                return;

            int color = ((Color)listBoxLightPresetColors.Items[index]).ToArgb();

            colorDialogLightPresetColor.Color = Color.FromArgb(color);

            if (colorDialogLightPresetColor.ShowDialog() != DialogResult.OK)
                return;

            listBoxLightPresetColors.Items[index] = colorDialogLightPresetColor.Color;
        }

        private void buttonAddLightRangeScale_Click(object sender, EventArgs e)
        {
            string text = "";
            if (ShowInputDialog(ref text) != DialogResult.OK)
                return;

            float value = 0.0f;
            if (!float.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out value))
                return;

            listBoxLightPresetRangeAniScales.Items.Add(value.ToString(CultureInfo.InvariantCulture));
        }

        private void buttonRemoveLightRangeScale_Click(object sender, EventArgs e)
        {
            if (listBoxLightPresetRangeAniScales.Items.Count == 0)
                return;

            listBoxLightPresetRangeAniScales.Items.RemoveAt((listBoxLightPresetRangeAniScales.SelectedIndex != -1) ? listBoxLightPresetRangeAniScales.SelectedIndex : listBoxLightPresetRangeAniScales.Items.Count - 1);
        }

        private void buttonMoveLightPresetRangeAniScaleUp_Click(object sender, EventArgs e)
        {
            int index = listBoxLightPresetRangeAniScales.SelectedIndex;
            if (index == -1)
                return;

            var item = listBoxLightPresetRangeAniScales.Items[index];
            listBoxLightPresetRangeAniScales.Items.RemoveAt(index);

            index = Math.Min(Math.Max(index - 1, 0), Math.Max(listBoxLightPresetRangeAniScales.Items.Count - 1, 0));
            listBoxLightPresetRangeAniScales.Items.Insert(index, item);

            listBoxLightPresetRangeAniScales.SelectedIndex = index;
        }

        private void buttonMoveLightPresetRangeAniScaleDown_Click(object sender, EventArgs e)
        {
            int index = listBoxLightPresetRangeAniScales.SelectedIndex;
            if (index == -1)
                return;

            var item = listBoxLightPresetRangeAniScales.Items[index];
            listBoxLightPresetRangeAniScales.Items.RemoveAt(index);

            index = Math.Min(Math.Max(index + 1, 0), listBoxLightPresetRangeAniScales.Items.Count);
            listBoxLightPresetRangeAniScales.Items.Insert(index, item);

            listBoxLightPresetRangeAniScales.SelectedIndex = index;
        }

        private void listBoxLightPresetRangeAniScales_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBoxLightPresetRangeAniScales.IndexFromPoint(e.Location);
            if (index == -1)
                return;

            string text = listBoxLightPresetRangeAniScales.Items[index].ToString();
            if (ShowInputDialog(ref text) != DialogResult.OK)
                return;

            listBoxLightPresetRangeAniScales.Items[index] = text;
        }

        private void buttonNewLightPreset_Click(object sender, EventArgs e)
        {
            var presetName = textBoxLightPresetName.Text.ToUpper();

            if (presetName.Length == 0)
            {
                MessageBox.Show(Localizator.Get("WIN_OBJ_NO_EMPTY_NAME"));
                return;
            }

            if (listBoxLightPresets.Items.Contains(presetName))
            {
                MessageBox.Show(Localizator.Get("MSG_COMMON_NO_UNIQUE_NAME"));
                return;
            }

            if (!Utils.IsOnlyLatin(presetName) && Utils.IsOptionActive("checkBoxOnlyLatinInInput"))
            {
                MessageBox.Show(Localizator.Get("FORM_ENTER_BAD_STRING_INPUT"));
                return;
            }

            listBoxLightPresets.Items.Add(presetName);
            buttonSaveLightPresets.Enabled = true;

            PushLightPresetData();
            Imports.Stack_PushString(presetName);
            Imports.Extern_Light_AddPreset();
        }

        private void buttonDeleteSelectedLightPreset_Click(object sender, EventArgs e)
        {
            if (listBoxLightPresets.SelectedIndex == -1)
                return;

            Imports.Stack_PushString(listBoxLightPresets.SelectedItem.ToString());
            Imports.Extern_Light_DeletePreset();
            listBoxLightPresets.Items.RemoveAt(listBoxLightPresets.SelectedIndex);

            buttonSaveLightPresets.Enabled = true;
        }
        private void buttonSaveLightPresets_Click(object sender, EventArgs e)
        {
            Imports.Extern_Light_SavePresets();
            buttonSaveLightPresets.Enabled = false;
        }

        private void listBoxLightPresets_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBoxLightPresets.IndexFromPoint(e.Location);
            if (index == -1)
                return;

            string text = listBoxLightPresets.Items[index].ToString();
            if (ShowInputDialog(ref text) != DialogResult.OK)
                return;

            text = text.ToUpper();
            if (text.Length == 0)
            {
                MessageBox.Show(Localizator.Get("WIN_OBJ_NO_EMPTY_NAME"));
                return;
            }

            if (listBoxLightPresets.Items.Contains(text))
            {
                MessageBox.Show(Localizator.Get("MSG_COMMON_NO_UNIQUE_NAME"));
                return;
            }

            if (!Utils.IsOnlyLatin(text) && Utils.IsOptionActive("checkBoxOnlyLatinInInput"))
            {
                MessageBox.Show(Localizator.Get("FORM_ENTER_BAD_STRING_INPUT"));
                return;
            }

            Imports.Stack_PushString(text);
            Imports.Stack_PushString(listBoxLightPresets.Items[index].ToString());
            Imports.Extern_Light_UpdatePresetName();
            listBoxLightPresets.Items[index] = text;
        }
        private void buttonUpdateLightPresetOnLightVobs_Click(object sender, EventArgs e)
        {
            if (listBoxLightPresets.SelectedItem == null)
                return;

            Imports.Stack_PushString(listBoxLightPresets.SelectedItem.ToString());
            Imports.Extern_Light_ApplyPresetOnLightVobs();
        }

        private void buttonUpdateLightPresetFromLightVob_Click(object sender, EventArgs e)
        {
            if (listBoxLightPresets.SelectedItem == null)
                return;

            Imports.Stack_PushString(listBoxLightPresets.SelectedItem.ToString());
            if (Imports.Extern_Light_UpdatePresetFromLightVob() == 1)
                buttonSaveLightPresets.Enabled = true;
        }

        private void buttonUsePresetOnLightVob_Click(object sender, EventArgs e)
        {
            if (listBoxLightPresets.SelectedItem == null)
                return;

            Imports.Stack_PushString(listBoxLightPresets.SelectedItem.ToString());
            Imports.Extern_Light_UsePresetOnLightVob();
        }

        private void checkBoxShowLightVobRadius_CheckedChanged(object sender, EventArgs e)
        {
            Imports.Stack_PushString("showLightRadiusVob");
            Imports.Extern_SetSetting(Convert.ToInt32(checkBoxShowLightVobRadius.Checked));
        }

        private void checkBoxShowLightVobInstantCompile_CheckedChanged(object sender, EventArgs e)
        {
            Imports.Extern_Light_DynamicCompile(checkBoxLightVobInstantCompile.Checked);
        }

        private void checkBoxShowMoverKeys_CheckedChanged(object sender, EventArgs e)
        {

            Imports.Stack_PushString("showMoverKeysVisually");
            Imports.Extern_SetSetting(Convert.ToInt32(checkBoxShowMoverKeys.Checked));
        }

        private void listBoxParticles_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (e.Button == MouseButtons.Middle && lb != null)
            {

                int index = lb.IndexFromPoint(e.Location);

                if (index >= 0 && lb.Items.Count > 0)
                {
                    string visual = lb.GetItemText(lb.Items[index]);

                    if (checkBoxAddPFX.Checked)
                    {
                        visual += ".pfx";
                    }

                    Utils.SetCopyText(visual);
                }

            }
        }

        private void listBoxPfxResult_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (e.Button == MouseButtons.Middle && lb != null)
            {

                int index = lb.IndexFromPoint(e.Location);

                if (index >= 0 && lb.Items.Count > 0)
                {
                    string visual = lb.GetItemText(lb.Items[index]);

                    if (checkBoxAddPFX.Checked)
                    {
                        visual += ".pfx";
                    }

                    Utils.SetCopyText(visual);
                }

            }
        }

        private void buttonRemoveMoverAllKeys_Click(object sender, EventArgs e)
        {
            Imports.Extern_RemoveAllMoverKeysWithSavePosition();

            triggerEntry.m_kf_pos = Imports.Extern_GetCurrentKey();
            triggerEntry.maxKey = Imports.Extern_GetMaxKey();

            //ConsoleEx.WriteLineRed(triggerEntry.m_kf_pos + "/" + triggerEntry.maxKey);

            UpdateTriggerWindow(false);
        }

        private void buttonMoverResetKeyTo0_Click(object sender, EventArgs e)
        {
            Imports.Extern_RemoveAllMoverKeysWithSetZero();

            triggerEntry.m_kf_pos = Imports.Extern_GetCurrentKey();
            triggerEntry.maxKey = Imports.Extern_GetMaxKey();

            //ConsoleEx.WriteLineRed(triggerEntry.m_kf_pos + "/" + triggerEntry.maxKey);

            UpdateTriggerWindow(false);
        }

        private void textBoxInRadius_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Utils.IsNumberInput(e.KeyChar, false, false) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBoxSearchInRadius_CheckedChanged(object sender, EventArgs e)
        {
            textBoxInRadius.Enabled = checkBoxSearchInRadius.Checked;
        }

        //========= CAMERA PRESETS

        [DllExport]
        public static void AddCameraPresetToList()
        {
            string presetName = Imports.Stack_PeekString();
            SpacerNET.objectsWin.listBoxPresetsCamera.Items.Add(presetName);
        }

        private void listBoxPresetsCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPresetsCamera.SelectedItem == null)
            {
                buttonPresetRemove.Enabled = false;
                buttonPresetUpdate.Enabled = false;
                return;
            }
            else
            {
                buttonPresetRemove.Enabled = true;
                buttonPresetUpdate.Enabled = true;
            }
        }

        private void buttonPresetsInsert_Click(object sender, EventArgs e)
        {
            if (SpacerNET.form.toolStripButtonMaterial.Checked)
            {
                Imports.Stack_PushString(Localizator.Get("WIN_VOBCATALOG_POLYSELECT_TURNOFF"));
                Imports.Extern_PrintRed();
                return;
            }

            if (listBoxPresetsCamera.SelectedItem == null)
            {
                return;
            }

            string presetName = listBoxPresetsCamera.SelectedItem.ToString();

            Imports.Stack_PushString(presetName);
            Imports.Extern_Camera_CreateVobFromPreset();
        }

        private void buttonPresetRemove_Click(object sender, EventArgs e)
        {

        }

        private void buttonPresetCreate_Click(object sender, EventArgs e)
        {

        }

        private void buttonPresetUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonSpawnClear_Click(object sender, EventArgs e)
        {
            Imports.Extern_Spawn_ClearList();
        }

        private void buttonSpawnDo_Click(object sender, EventArgs e)
        {
            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            if (listBoxLocations.SelectedItem == null)
            {
                MessageBox.Show(Localizator.Get("WIN_SPAWN_NO_GROUP_SELECTED"));
                return;
            }

            if (!SpacerNET.form.toolStripButtonHelpVobs.Checked)
            {
                MessageBox.Show(Localizator.Get("WIN_SPAWN_NO_HELP_VOBS"));
                return;
            }

            Imports.Extern_Spawn_ClearList();

            Imports.Extern_Spawn_ClearFuncList();

            foreach (var item in listBoxFuncs.Items)
            {
                Imports.Stack_PushString(item.ToString());
                Imports.Extern_Spawn_AddInList();
            }
 

            Imports.Extern_Spawn_Collect();
        }

        private void buttonLocationSpawnNew_Click(object sender, EventArgs e)
        {
            formConf.buttonConfirmNo.Text = Localizator.Get("WIN_COMPLIGHT_CLOSEBUTTON");
            formConf.buttonConfirmYes.Text = Localizator.Get("WIN_BTN_CONFIRM");
            formConf.labelTextShow.Text = Localizator.Get("WIN_SPAWN_PRESET_NAME");
            formConf.confType = "SPAWN_NEW_GROUP";
            formConf.clearText = true;
            formConf.ShowDialog();
        }

        private void buttonLocationRename_Click(object sender, EventArgs e)
        {
            if (listBoxLocations.SelectedItem != null)
            {

                formConf.buttonConfirmNo.Text = Localizator.Get("WIN_COMPLIGHT_CLOSEBUTTON");
                formConf.buttonConfirmYes.Text = Localizator.Get("WIN_BTN_CONFIRM");
                formConf.labelTextShow.Text = Localizator.Get("WIN_SPAWN_PRESET_NAME");
                formConf.confType = "SPAWN_RENAME_GROUP";
                formConf.clearText = false;
                formConf.textBoxValueEnter.Text = listBoxLocations.SelectedItem.ToString();
                formConf.ShowDialog();
            }
        }

        private void buttonLocationDelete_Click(object sender, EventArgs e)
        {
            if (listBoxLocations.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show(Localizator.Get("WIN_SPAWN_ASKSURE_REMOVE_GROUP"), Localizator.Get("confirmation"), MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    string groupName = listBoxLocations.SelectedItem.ToString();

                    listBoxLocations.Items.RemoveAt(listBoxLocations.SelectedIndex);
                    spawnListData.Remove(groupName);

                    if (listBoxLocations.Items.Count > 0)
                    {
                        listBoxLocations.SelectedIndex = 0;
                    }
                   
                }
            }
        }

        public void SetNewSpawnGroupText(string groupName)
        {
            if (listBoxLocations.Items.Contains(groupName))
            {
                MessageBox.Show(Localizator.Get("NAME_ALREADY_EXISTS"));
                return;
            }

            if (groupName.Length == 0)
            {
                return;
            }

            spawnListData.Add(groupName, new List<string>());

            listBoxLocations.Items.Add(groupName);
            listBoxLocations.Focus();
        }


        public void RenameSpawnGroup(string groupName)
        {

            if (groupName.Length == 0)
            {
                return;
            }

            if (listBoxLocations.Items.Contains(groupName))
            {
                MessageBox.Show(Localizator.Get("NAME_ALREADY_EXISTS"));
                return;
            }

            var oldGroup = listBoxLocations.SelectedItem.ToString();


            if (spawnListData.ContainsKey(oldGroup))
            {
                List<string> value = spawnListData[oldGroup];

                spawnListData.Remove(oldGroup);
                spawnListData.Add(groupName, value);
            }
            

            listBoxLocations.Items[listBoxLocations.SelectedIndex] = groupName;
            listBoxLocations.Focus();

        }

        private void buttonFuncAdd_Click(object sender, EventArgs e)
        {
            if (listBoxLocations.SelectedItem == null)
            {
                return;
            }

            formConf.buttonConfirmNo.Text = Localizator.Get("WIN_COMPLIGHT_CLOSEBUTTON");
            formConf.buttonConfirmYes.Text = Localizator.Get("WIN_BTN_CONFIRM");
            formConf.labelTextShow.Text = Localizator.Get("WIN_SPAWN_FUNC_NAME");
            formConf.confType = "SPAWN_NEW_FUNC";
            formConf.clearText = true;
            formConf.ShowDialog();
        }

        private void buttonFuncDelete_Click(object sender, EventArgs e)
        {
            if (listBoxLocations.SelectedItem == null)
            {
                return;
            }

            if (listBoxFuncs.SelectedItem == null)
            {
                return;
            }

            DialogResult dialogResult = MessageBox.Show(Localizator.Get("confirmText"), Localizator.Get("confirmation"), MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                string groupName = listBoxLocations.SelectedItem.ToString();

                spawnListData[groupName].RemoveAt(listBoxFuncs.SelectedIndex);
                listBoxFuncs.Items.RemoveAt(listBoxFuncs.SelectedIndex);
                
            }
        }

        private void listBoxLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxLocations.SelectedItem == null)
            {
                return;
            }

            var group = listBoxLocations.SelectedItem.ToString();

            var funcsList = spawnListData.Where(x => x.Key == group);

            listBoxFuncs.BeginUpdate();
            listBoxFuncs.Items.Clear();


            if (spawnListData.ContainsKey(group))
            {
                foreach (string value in spawnListData[group])
                {
                    listBoxFuncs.Items.Add(value);
                }
            }

           

            listBoxFuncs.EndUpdate();
        }

        public void SetNewSpawnFuncText(string name)
        {
            if (name.Length == 0)
            {
                return;
            }

            var group = listBoxLocations.SelectedItem.ToString();

            if (spawnListData.ContainsKey(group))
            {
                foreach (string value in spawnListData[group])
                {
                    if (value == name)
                    {
                        MessageBox.Show(Localizator.Get("NAME_ALREADY_EXISTS"));
                        return;
                    }
                   
                }

                spawnListData[group].Add(name);
                listBoxFuncs.Items.Add(name);
            }


        }

        void LoadSpawnFile()
        {
            if (!File.Exists(pathFile))
            {
                return;
            }

            List<string> arr = System.IO.File.ReadLines(pathFile, Encoding.UTF8).ToList();

            if (arr.Count() == 0)
            {
                return;
            }

            string firstLine = arr[0].Trim();

            if (firstLine.Length > 0)
            {
                var split = firstLine.Split(';');


                listBoxLocations.BeginUpdate();

                for (int i = 0; i < split.Length; i++)
                {
                    var groupName = split[i].Trim();

                    if (groupName.Length > 0)
                    {
                        listBoxLocations.Items.Add(groupName);
                        spawnListData.Add(groupName, new List<string>());
                    }
                }

                listBoxLocations.EndUpdate();
            }

            if (arr.Count > 1)
            {
                for (int i = 1; i < arr.Count; i++)
                {
                    var split = arr[i].Trim().Split(';');

                    if (split.Length == 2)
                    {
                        string groupName = split[0];
                        string value = split[1];
                        spawnListData[groupName].Add(value);
                    }

                }
            }

        }

        public void SaveSpawnFile()
        {

            if (listBoxLocations.Items.Count == 0 || !SpacerNET.isInit)
            {
                return;
            }


            FileStream fs = new FileStream(pathFile, FileMode.Create);

            StreamWriter w = new StreamWriter(fs, Encoding.UTF8);

            StringBuilder groupsList = new StringBuilder();

            groupsList.Clear();

            foreach (var entry in listBoxLocations.Items)
            {
                groupsList.Append(entry.ToString() + ";");

            }

            w.WriteLine(groupsList.ToString());

            foreach (var key in spawnListData.Keys)
            {
                foreach (string value in spawnListData[key])
                {
                    w.WriteLine(key + ";" + value);
                }
            }

            w.Close();
        
        }

        private void buttonSpawnSaveBase_Click(object sender, EventArgs e)
        {
            SaveSpawnFile();
        }

        private void buttonSpawnSetRadius_Click(object sender, EventArgs e)
        {
            
            
        }

        private void buttonSpawnSetRadius_Click_1(object sender, EventArgs e)
        {
            var textVal = textBoxSpawnSetRad.Text.Trim();

            if (Utils.IsInt(textVal))
            {
                int value = Convert.ToInt32(textVal);

                if (value < 2000 || value > 25000)
                {
                    MessageBox.Show(Localizator.Get("WIN_SPAWN_RADIUS_RANGE"));
                    return;
                }

                Imports.Stack_PushString("showSpawnListRadius");
                Imports.Extern_SetSetting(value);
                Imports.Extern_Spawn_SetRadius(value);
            }
            else
            {
                MessageBox.Show(Localizator.Get("PFX_EDITOR_WRONG_INPUT_NOT_NUMBER"));
            }
        }

        private void radioButtonOverwrite_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton cb = sender as RadioButton;

            if (cb != null)
            {

                if (cb.Checked)
                {
                    buttonNewKey.Text = Utils.CapitalizeFirstLetter(Localizator.Get("radioButtonOverwrite"));
                }
                else
                {
                    buttonNewKey.Text = Localizator.Get("buttonNewKey");
                }
            }
        }

        private void panelColor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panelColor_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            colorDialog.Color = panelColor.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panelColor.BackColor = colorDialog.Color;

                Imports.Stack_PushString("sphereWireColorR");
                Imports.Extern_SetSetting(colorDialog.Color.R);

                Imports.Stack_PushString("sphereWireColorG");
                Imports.Extern_SetSetting(colorDialog.Color.G);

                Imports.Stack_PushString("sphereWireColorB");
                Imports.Extern_SetSetting(colorDialog.Color.B);


            }
        }

        private void checkBoxShowLightRadiusAsText_CheckedChanged(object sender, EventArgs e)
        {
            Imports.Stack_PushString("bDrawRadiusValue");
            Imports.Extern_SetSetting(Convert.ToInt32(checkBoxShowLightRadiusAsText.Checked));
            //checkBoxShowLightRadiusAsText
        }

        private void comboBoxSphereType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SpacerNET.isInit)
            {
                Imports.Stack_PushString("sphereDrawMode");
                Imports.Extern_SetSetting(comboBoxSphereType.SelectedIndex);
            }
        }

        void UpdateLightWindow(bool toggleButtons)
        {
            buttonApplyChangesLight.Enabled = toggleButtons;
            buttonUpdateLightPresetFromLightVob.Enabled = toggleButtons;
            buttonUsePresetOnLightVob.Enabled = toggleButtons;
        }

        [DllExport]
        public static void UpdateLightWindowButtons()
        {
            int mode = Imports.Stack_PeekInt();

            SpacerNET.objectsWin.UpdateLightWindow(Convert.ToBoolean(mode));

        }

        private void checkBoxMoreThanZero_CheckedChanged(object sender, EventArgs e)
        {
            if (dontUpdateNumType || Imports.Extern_IsWorldLoaded() == 0) return;

            textBoxSearchVobs_TextChanged(textBoxSearchVobs, null);
        }

        private void checkBoxAutoRenameKeys_CheckedChanged(object sender, EventArgs e)
        {
            Imports.Stack_PushString("bCameraAutoRenameKeys");
            Imports.Extern_SetSetting(Convert.ToInt32(checkBoxAutoRenameKeys.Checked));
        }
    }
}
