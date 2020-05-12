
using SpacerUnion.Common;
using SpacerUnion.Resources;
using SpacerUnion.Windows;
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
        

        // Окна приложения
        public static MainForm form;
        public static VobListForm vobList;
        public static ObjectsWindow propWin;
        public static InfoWin infoWin;
        public static CompileLightWin comLightWin;
        public static ObjTree objTreeWin;
        public static ParticleWin partWin;
        public static SoundWin soundWin;
        public static CompileWorldWin compWorldWin;
        public static LoadingForm loadForm;
        public static SettingsCamera settingsCam;
        public static SettingsControls settingsControl;

        // Список скрытых окон
        static List<Form> windowsToHideList = null;

        // Список окон
        static List<Form> windowsList = null;


        private static Dictionary<string, IntPtr> marshalList = new Dictionary<string, IntPtr>();

        public static IntPtr AddString(string s)
        {
            if (!marshalList.ContainsKey(s))
            {
                IntPtr ptr = Marshal.StringToHGlobalAnsi(s);
                marshalList.Add(s, ptr);
            }
            
            return marshalList[s];
        }

        public static void FreeStrings()
        {
            ConsoleEx.WriteLineGreen("Marshal list before: " + marshalList.Count);
            foreach (var entry in marshalList)
            {
                Marshal.FreeHGlobal(entry.Value);
            }

            marshalList.Clear();

            ConsoleEx.WriteLineGreen("Marshal list after: " + marshalList.Count);
        }



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
            propWin = new ObjectsWindow();
            infoWin = new InfoWin();
            objTreeWin = new ObjTree();
            partWin = new ParticleWin();
            soundWin = new SoundWin();
            comLightWin = new CompileLightWin();
            settingsCam = new SettingsCamera();
            settingsControl = new SettingsControls();
            compWorldWin = new CompileWorldWin();
            loadForm = new LoadingForm();

            windowsList.Add(objTreeWin);
            windowsList.Add(partWin);
            windowsList.Add(infoWin);
            windowsList.Add(propWin);
            windowsList.Add(soundWin);
            windowsList.Add(vobList);
            windowsList.Add(compWorldWin);
            windowsList.Add(comLightWin);
            windowsList.Add(settingsCam);
            windowsList.Add(loadForm);
            windowsList.Add(settingsControl);
            

            // каждому окну из списка задаем владельца: главную форму
            windowsList.ForEach(x => x.Owner = form);

            form.menuStripTopMain.Enabled = false;

            form.Show();
            //form.panelMain.Show();
           // infoWin.Show();

            form.Left = 0;
            form.Top = 0;

            //infoWin.Left = 950;
            //infoWin.Top = 600;


            form.AddText(Lang.appIsLoading);
 
        }

        // Функция вызывается, когда загрузился движок игры, вызывается из Union
        [DllExport]
        public static void Form_EnableInterface()
        {
            form.AddText(Lang.appIsReady);

            form.menuStripTopMain.Enabled = true;
            propWin.Show();
            objTreeWin.Show();
            partWin.Show();
            vobList.Show();
            infoWin.Show();


            if (Properties.Settings.Default.TreeWinLocation != null)
            {
                objTreeWin.Location = Properties.Settings.Default.TreeWinLocation;
            }

            if (Properties.Settings.Default.PartWinLocation != null)
            {
                partWin.Location = Properties.Settings.Default.PartWinLocation;
            }

            if (Properties.Settings.Default.VobListWinLocation != null)
            {
                vobList.Location = Properties.Settings.Default.VobListWinLocation;
            }

            if (Properties.Settings.Default.PropWinLocation != null)
            {
                propWin.Location = Properties.Settings.Default.PropWinLocation;
            }


            if (Properties.Settings.Default.InfoWinLocation != null)
            {
                infoWin.Location = Properties.Settings.Default.InfoWinLocation;
            }


            if (Properties.Settings.Default.SoundWinLocation != null)
            {
                soundWin.Location = Properties.Settings.Default.SoundWinLocation;
            }


            LoadSettingsToInterface();




            form.Focus();
        }

        


        // загружает настройки в интерфейс 
        public static void LoadSettingsToInterface()
        {
            ToolStripButton btn = form.toolStripTop.Items[7] as ToolStripButton;

            btn.Checked = Convert.ToBoolean(Imports.Extern_GetSetting(AddString("showVobs")));
            btn = form.toolStripTop.Items[8] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(Imports.Extern_GetSetting(AddString("showWaynet")));
            btn = form.toolStripTop.Items[9] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(Imports.Extern_GetSetting(AddString("showHelpVobs")));
            btn = form.toolStripTop.Items[10] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(Imports.Extern_GetSetting(AddString("drawBBoxGlobal")));
            btn = form.toolStripTop.Items[11] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(Imports.Extern_GetSetting(AddString("showInvisibleVobs")));

            btn = form.toolStripTop.Items[0] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(infoWin.Visible);

            btn = form.toolStripTop.Items[1] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(partWin.Visible);

            btn = form.toolStripTop.Items[2] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(soundWin.Visible);

            btn = form.toolStripTop.Items[3] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(objTreeWin.Visible);

            btn = form.toolStripTop.Items[4] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(propWin.Visible);


            btn = form.toolStripTop.Items[5] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(vobList.Visible);


           

            int radius = Imports.Extern_GetSetting(AddString("vobListRadius"));
            vobList.trackBarRadius.Value = radius;
            vobList.comboBoxVobListType.SelectedIndex = 0;

            partWin.checkBoxShowPreview.Checked = Convert.ToBoolean(Imports.Extern_GetSetting(AddString("showModelPreview")));
            partWin.checkBoxSearchOnly3DS.Checked = Convert.ToBoolean(Imports.Extern_GetSetting(AddString("searchOnly3DS")));

            FreeStrings();
        }



        public static void CloseApplication()
        {
            //MessageBox.Show("CloseApplication");
            Properties.Settings.Default.TreeWinLocation = objTreeWin.Location;
            Properties.Settings.Default.PartWinLocation = partWin.Location;
            Properties.Settings.Default.PropWinLocation = propWin.Location;
            Properties.Settings.Default.VobListWinLocation = vobList.Location;
            Properties.Settings.Default.InfoWinLocation = infoWin.Location;
            Properties.Settings.Default.SoundWinLocation = soundWin.Location;

            Properties.Settings.Default.Save();
            Imports.Extern_Exit();
        }


        [DllExport]
        public static int GetHandlerFunc()
        {
            return (int)form.renderTarget.Handle;
        }

        

        [DllExport]
        public static int IsAppActive()
        {
            var handle = Imports.GetForegroundWindow();

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

            loadForm.UpdateText(type);

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
