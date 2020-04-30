
using SpacerUnion.Resources;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpacerUnion
{

    public static class UnionNET
    {
        #region Imports
        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Extern_GetSetting(IntPtr namePtr);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern IntPtr GetForegroundWindow();

        #endregion

        // Окна приложения
        public static MainForm form;
        public static VobListForm vobList;
        public static ObjectsWindow objWin;
        public static InfoWin infoWin;
        public static CompileLightWin comLightWin;
        public static ObjTree objTreeWin;
        public static ParticleWin partWin;
        public static SoundWin soundWin;
        public static CompileWorldWin compWorldWin;
        public static LoadingForm loadForm;
        public static SettingsCamera settingsCam;


        // Список скрытых окон
        static List<Form> windowsToHideList = null;

        // Список окон
        static List<Form> windowsList = null;



        // Главная функция запуска, вызывается из Union
        [DllExport, STAThread]
        public static void UnionInitialize(IntPtr L)
        {
            AutoClosingMessageBox.Show("", "", 90);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            windowsToHideList = new List<Form>();
            windowsList = new List<Form>();

            form = new MainForm();
            vobList = new VobListForm();
            objWin = new ObjectsWindow();
            infoWin = new InfoWin();
            objTreeWin = new ObjTree();
            partWin = new ParticleWin();
            soundWin = new SoundWin();
            comLightWin = new CompileLightWin();
            settingsCam = new SettingsCamera();
            compWorldWin = new CompileWorldWin();
            loadForm = new LoadingForm();

            windowsList.Add(objTreeWin);
            windowsList.Add(partWin);
            windowsList.Add(infoWin);
            windowsList.Add(objWin);
            windowsList.Add(soundWin);
            windowsList.Add(vobList);
            windowsList.Add(compWorldWin);
            windowsList.Add(comLightWin);
            windowsList.Add(settingsCam);
            windowsList.Add(loadForm);


            windowsList.ForEach(x => x.Owner = form);

            form.menuStripTopMain.Enabled = false;

            form.Show();
            form.panelMain.Show();
            infoWin.Show();

            form.Left = 0;
            form.Top = 0;

            infoWin.Left = 950;
            infoWin.Top = 600;


            form.AddText(Lang.appIsLoading);
 
        }

        // Функция вызывается, когда загрузился движок игры, вызывается из Union
        [DllExport]
        public static void Form_EnableInterface()
        {
            form.AddText(Lang.appIsReady);

            form.menuStripTopMain.Enabled = true;
            objWin.Show();
            objTreeWin.Show();
            partWin.Show();
            vobList.Show();


            objTreeWin.Left = 1500;
            objTreeWin.Top = 530;

            objWin.Left = 1500;
            objWin.Top = 50;



            vobList.Left = 600;
            vobList.Top = 600;
            partWin.Left = 0;
            partWin.Top = 600;


            soundWin.Left = 0;
            soundWin.Top = 300;

            LoadSettingsToInterface();




            form.Focus();
        }

        // загружает настройки в интерфейс 
        public static void LoadSettingsToInterface()
        {
            ToolStripButton btn = form.toolStripTop.Items[7] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(Extern_GetSetting(Marshal.StringToHGlobalAnsi("showVobs")));
            btn = form.toolStripTop.Items[8] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(Extern_GetSetting(Marshal.StringToHGlobalAnsi("showWaynet")));
            btn = form.toolStripTop.Items[9] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(Extern_GetSetting(Marshal.StringToHGlobalAnsi("showHelpVobs")));
            btn = form.toolStripTop.Items[10] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(Extern_GetSetting(Marshal.StringToHGlobalAnsi("drawBBoxGlobal")));


            btn = form.toolStripTop.Items[0] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(infoWin.Visible);

            btn = form.toolStripTop.Items[1] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(partWin.Visible);

            btn = form.toolStripTop.Items[2] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(soundWin.Visible);

            btn = form.toolStripTop.Items[3] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(objTreeWin.Visible);

            btn = form.toolStripTop.Items[4] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(objWin.Visible);


            btn = form.toolStripTop.Items[5] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(vobList.Visible);
        }

        [DllExport]
        public static int GetHandlerFunc()
        {
            return (int)form.renderTarget.Handle;
        }

        

        [DllExport]
        public static int IsAppActive()
        {
            var handle = GetForegroundWindow();

            for (int i = 0; i < windowsList.Count; i++)
            {
                if (windowsList[i].Handle == handle || handle == form.Handle || handle == form.renderTarget.Handle)
                {
                    return 1;
                }
            }
            return 0;
        }

        [DllExport]
        public static int GetMainWinHandler()
        {
            return (int)form.Handle;
        }

        
        [DllExport]
        public static void HideWindows()
        {
                
            for (int i = 0; i < windowsList.Count; i++)
            {
                if (windowsList[i].Visible)
                {
                    windowsToHideList.Add(windowsList[i]);
                    windowsList[i].Hide();
                }
                
            }

        }

        [DllExport]
        public static void ShowWindows()
        {

            for (int i = 0; i < windowsToHideList.Count; i++)
            {
                windowsToHideList[i].Show();
            }

            windowsToHideList.Clear();
            form.Focus();
        }



        [DllExport]
        public static void ShowLoadingForm(int type)
        {
            if (loadForm == null)
            {
                loadForm = new LoadingForm();
            }


            if (type == 0)
            {
                loadForm.labelLoading.Text = Lang.loadZen;
            }

            if (type == 1)
            {
                loadForm.labelLoading.Text = Lang.compileZen;
            }

            if (type == 2)
            {
                loadForm.labelLoading.Text = Lang.compileLight;
            }


            if (type == 3)
            {
                loadForm.labelLoading.Text = Lang.savingZen;
            }



            loadForm.Show();
            Application.DoEvents();
        }




        [DllExport]
        public static void CloseLoadingForm()
        {
            if (loadForm != null)
            {
                loadForm.Hide();
            }

            Application.DoEvents();

        }

    }

}
