using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SpacerUnion.Common
{
    // Функции импорта из Юниона
    public class Imports
    {
        public const string UNION_DLL_NAME = "$SpacerUnionNet.dll$";
        
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetForegroundWindow();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_Exit();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_OpenVobTree(IntPtr str, bool globalInsert);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_LoadWorld(IntPtr str);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_LoadMesh(IntPtr str);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_MergeZen(IntPtr str);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_ResetWorld();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetCameraPos(float x, float y, float z);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SaveWorld(IntPtr str, int type);


        #region Функции настроек
        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_GetSetting(IntPtr namePtr);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetSetting(IntPtr namePtr, int value);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetSettingStr(IntPtr namePtr, IntPtr value);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Extern_GetSettingStr(IntPtr namePtr);
        #endregion



        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_ComplileLight(int radioButton, int radius);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Extern_CompileWorld(int type);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_PlaySound(IntPtr str);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_ApplyProps(IntPtr propStr, IntPtr propName, IntPtr ptrVisual);
        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern float Extern_GetBBox(int coord);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern float Extern_SetBBox(int x, int y, int z);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SaveVobTree(IntPtr str);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SelectVobSync(uint a);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SelectVob(uint a);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_BlockMouse(bool disable);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_RemoveVob(uint vob);

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreateItem(IntPtr name);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreatePFX(IntPtr name);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Extern_VobNameExist(IntPtr name, bool isWaypoint);



        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreateNewVob(IntPtr name, IntPtr vobName, int dyn, int stat);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreateWaypoint(IntPtr name, IntPtr vobName, bool addToWaynet, bool autoGenerate);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreateFreePoint(IntPtr name, IntPtr vobName, bool autoGenerate, bool ground);
        


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreateNewVobVisual(IntPtr name, IntPtr vobName, IntPtr visual, int dyn, int stat);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_ConnectWP();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_DisconnectWP();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Extern_StopAllSounds();

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
        public static extern void Extern_SetCollTrigger(int mode, int val);
        #endregion



        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SetTime(int hour, int min);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Extern_CheckUniqueNameExist(IntPtr vobName);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Extern_AnalyseWaynet();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_RenderSelectedVob(IntPtr visual);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_RenderPFX(IntPtr visual);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_KillPFX();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_KillPreviewItem();

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_RenderItem(IntPtr visual);



        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_ClearMouseClick();




        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_ToggleMusic(bool mod);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_PrintRed(IntPtr str);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_PrintGreen(IntPtr str);

        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_PlayHero();


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CollectTriggerSources();



        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SendNewKeyPreset(IntPtr type, int key, int mod);


        [DllImport(UNION_DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Extern_GetIniKey(IntPtr key);
    }
}
