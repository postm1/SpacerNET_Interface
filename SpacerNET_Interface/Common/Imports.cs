using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SpacerUnion.Common
{
    // Функции импорта из Юниона
    public partial class Imports
    {
        public const string UNION_DLL_NAME = "SpacerUnionNet.dll";
        
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        [DllImport("Ole32.dll")]
        public static extern IntPtr CoInitialize(IntPtr reserved);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_Exit();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_OpenVobTree(bool globalInsert, bool insertNearCamera);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_LoadWorld();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_LoadMesh();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_MergeMesh();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_MergeZen();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_ResetWorld();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetCameraPos();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SaveWorld(int type);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SaveMesh();


        #region Settings functions
        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_GetSetting();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern float Extern_GetSettingFloat();
        

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetSetting(int value);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetSettingFloat(float value);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetSettingStr();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_GetSettingStr();
        #endregion



        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_ComplileLight(int radioButton, int radius);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CompileWorld(int type);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_PlaySound();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_PlayMusic();

        

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_ApplyProps();
        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern float Extern_GetBBox(int coord);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern float Extern_SetBBox(int x, int y, int z);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SaveVobTree();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SelectVobSync(uint a);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SelectVob(uint a);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SelectMat(uint a);
        


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_RestorePosition(uint a);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_BlockMouse(bool disable);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_RemoveVob(uint vob);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_MakeGlobalParent(uint vob);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_RemoveAsParent(uint vob);

        // check global parent
        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_CanBeGlobalParent(uint vob);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CleanGlobalParent();

        

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreateItem();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreatePFX();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_VobNameExist(bool isWaypoint);



        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreateNewVobVisual(int dyn, int stat);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreateWaypoint(bool addToWaynet, bool autoGenerate);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreateFreePoint(bool autoGenerate, bool ground);
        


        


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_ConnectWP();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_DisconnectWP();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_StopAllSounds();

        #region Функции триггеров
        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetToKeyPos(int pos);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_OnKeyRemove();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_OnAddKey(int mode);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_GetCurrentKey();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_GetMaxKey();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SendTrigger(int actionIndex);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetMoverToKey();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetCollTrigger(int mode, int val);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_RemoveAllMoverKeysWithSavePosition();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_RemoveAllMoverKeysWithSetZero();

        #endregion



        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetTime(int hour, int min);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_CheckUniqueNameExist();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_AnalyseWaynet();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_RenderSelectedVob();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_RenderPFX();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_KillPFX();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_KillPreviewItem();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_RenderItem();



        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_ClearMouseClick();




        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_ToggleMusic(bool mod);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_PrintRed();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_PrintGreen();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_PlayHero();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CollectTriggerSources();



        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SendNewKeyPreset(int key, int mod);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_GetIniKey();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_IsWorldLoaded();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_IsWorldCompiled();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_ClearLangStrings();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_ResetKeysDefault();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_GetClassFields(bool isNew);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_SearchVobs(bool derived, bool hasChildren, int type, int onlyVisualOrName);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_GetConvertSubClasses();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_AddConvertVob();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_GetInstanceProps();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_GetAllPfx();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_PfxValueChanged();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_UpdatePFXField();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetVobListType(int type);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_FreezeTime(int enabled);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetRenderMode(int mode);



        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SaveVobVisualsUnique();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_VisualIsInVDF();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_GetPolysCount();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_ToggleNoGrass();



        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_ClearMacrosCmd();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_AddMacrosCmd();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_RunMacrosCmd();



        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_InsertNewCamera();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_InsertNewSplineKey();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_InsertNewTargetKey();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CameraRun();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CameraStop();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CameraUpdateSpacerTime(int time, int hide);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CameraGotoKey(int key);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_CameraGetMaxKey();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_CameraGetCurrentKey();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_RemoveTargetKeyByIndex(int index);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_RemoveSplineKeyByIndex(int index);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SelectTargetKeyByIndex(int index);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SelectSplineKeyByIndex(int index);




        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_InsertPosKeyAtIndex(int index);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_InsertTargetKeyAtIndex(int index);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_CanEditBboxCurrentVob();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SearchVobList();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_FillMatListByFilterName();



        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_FillMat_GetCurrentMat_FilterIndex();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_FillMat_GetCurrentMat_GroupIndex();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_FillMat_ApplyFilterAndGroup(int filter, int group, int followFilter, int changeFilter);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_FilterMat_SaveFilters();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_FillMat_AddNewFilter();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_MatFilter_SaveCurrentFilter();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_MatFilter_RenameFilter();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetSearchVobName();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_MatFilter_UpdateTextureShowSettings();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_Filter_CreateNewMaterial();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Exter_MatFilter_SearchMatByName();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetLocatorItemType();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_MatFilter_RemoveFilterByIndex();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_GetOption_CanCompileWorldAgain();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetVobPickFilter(int index);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_Light_AddPreset();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_Light_DeletePreset();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_Light_SavePresets();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_Light_UpdatePresetName();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_Light_ApplyPresetOnLightVobs();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_Light_UpdatePresetFromLightVob();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_Light_UsePresetOnLightVob();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_Light_QueryPresetData();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_Light_ApplyChanges();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_Light_CreateVob();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_Light_DynamicCompile(bool toggle);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_IsGameModActive();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetFilterMatActive(bool toggle);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_OnExitPolySelectMod();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SaveVobsVisualToFile(uint vob, bool includedChildren);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_ToggleVisualVobInfo(bool toggle);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetRenameOptions(int optType, int startNumber);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_PlacePfxNearCam();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_PfxEditorStopEffect();

        

    }
    
}
