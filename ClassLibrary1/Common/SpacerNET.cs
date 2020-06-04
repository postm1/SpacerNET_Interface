
using SpacerUnion.Common;
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

    public static class SpacerNET
    {
        

        // Окна приложения
        public static MainForm form;
        public static VobListForm vobList;
        public static ObjectsWindow propWin;
        public static InfoWin infoWin;
        public static CompileLightWin comLightWin;
        public static ObjTree objTreeWin;
        public static ObjectsWin objectsWin;
        public static SoundWin soundWin;
        public static CompileWorldWin compWorldWin;
        public static LoadingForm loadForm;
        public static SettingsCamera settingsCam;
        public static SettingsControls settingsControl;
        public static CameraCoords camCoordsWin;
        public static MiscSettingsWin miscSetWin;
        public static KeysForm keysWin;

        // Список скрытых окон
        static List<Form> windowsToHideList = null;

        // Список окон
        static List<Form> windowsList = null;


        private static Dictionary<string, IntPtr> marshalList = new Dictionary<string, IntPtr>();

        public static IntPtr AddString(string s)
        {
            if (!marshalList.ContainsKey(s))
            {
                ConsoleEx.WriteLineGreen("AddString: " + s);
                IntPtr ptr = Marshal.StringToHGlobalAnsi(s);
                marshalList.Add(s, ptr);
            }
            
            return marshalList[s];
        }

        public static void FreeStrings()
        {
            //ConsoleEx.WriteLineGreen("Marshal list before: " + marshalList.Count);
            foreach (var entry in marshalList)
            {
                Marshal.FreeHGlobal(entry.Value);
            }

            marshalList.Clear();

            //ConsoleEx.WriteLineGreen("Marshal list after: " + marshalList.Count);
        }



        // Главная функция запуска, вызывается из Union
        [DllExport]
        public static void UnionInitialize(IntPtr L)
        {
            AutoClosingMessageBox.Show("", "", 80);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Localizator.Init();
            Localizator.SetLanguage((LangEnum)Properties.Settings.Default.Language);
            
            windowsToHideList = new List<Form>();
            windowsList = new List<Form>();

            form = new MainForm();
            vobList = new VobListForm();
            propWin = new ObjectsWindow();
            infoWin = new InfoWin();
            objTreeWin = new ObjTree();
            objectsWin = new ObjectsWin();
            soundWin = new SoundWin();
            comLightWin = new CompileLightWin();
            settingsCam = new SettingsCamera();
            settingsControl = new SettingsControls();
            compWorldWin = new CompileWorldWin();
            loadForm = new LoadingForm();
            camCoordsWin = new CameraCoords();
            miscSetWin = new MiscSettingsWin();
            keysWin = new KeysForm();

            windowsList.Add(objTreeWin);
            windowsList.Add(objectsWin);
            windowsList.Add(infoWin);
            windowsList.Add(propWin);
            windowsList.Add(soundWin);
            windowsList.Add(vobList);
            windowsList.Add(compWorldWin);
            windowsList.Add(comLightWin);
            windowsList.Add(settingsCam);
            windowsList.Add(loadForm);
            windowsList.Add(settingsControl);
            windowsList.Add(camCoordsWin);
            windowsList.Add(miscSetWin);
            windowsList.Add(keysWin);
            
            // каждому окну из списка задаем владельца: главную форму
            windowsList.ForEach(x => x.Owner = form);

            form.menuStripTopMain.Enabled = false;

            Localizator.UpdateInterface();

            form.Show();
            //form.panelMain.Show();
           // infoWin.Show();

            form.Left = 0;
            form.Top = 0;

            //infoWin.Left = 950;
            //infoWin.Top = 600;


            form.AddText(Localizator.Get("appIsLoading"));


        }

        // Функция вызывается, когда загрузился движок игры, вызывается из Union
        [DllExport]
        public static void Form_EnableInterface()
        {
            //ConsoleEx.WriteLineRed("Form_EnableInterface");
            //Utils.Error("Form_EnableInterface");
            form.AddText(Localizator.Get("appIsReady"));

            form.menuStripTopMain.Enabled = true;


            if (Properties.Settings.Default.InfoWinShow)
            {
                infoWin.Show();
            }

            if (Properties.Settings.Default.ObjectWinShow)
            {
                objectsWin.Show();
            }

            if (Properties.Settings.Default.PropsWinShow)
            {
                propWin.Show();
            }

            if (Properties.Settings.Default.SoundWinShow)
            {
                soundWin.Show();
            }

            if (Properties.Settings.Default.TreeWinShow)
            {
                objTreeWin.Show();
            }

            if (Properties.Settings.Default.VobListWinShow)
            {
                vobList.Show();
            }



            if (Properties.Settings.Default.TreeWinLocation != null)
            {
                objTreeWin.Location = Properties.Settings.Default.TreeWinLocation;
            }

            if (Properties.Settings.Default.PartWinLocation != null)
            {
                objectsWin.Location = Properties.Settings.Default.PartWinLocation;
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
            //ConsoleEx.WriteLineRed("LoadSettingsToInterface");
            ToolStripButton btn = form.toolStripTop.Items[7] as ToolStripButton;



            Imports.Stack_PushString("vobListRadius");
            Imports.Stack_PushString("showInvisibleVobs");
            Imports.Stack_PushString("drawBBoxGlobal");
            Imports.Stack_PushString("showHelpVobs");
            Imports.Stack_PushString("showWaynet");
            Imports.Stack_PushString("showVobs");


            btn.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());
            btn = form.toolStripTop.Items[8] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());
            btn = form.toolStripTop.Items[9] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());
            btn = form.toolStripTop.Items[10] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());
            btn = form.toolStripTop.Items[11] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());

            btn = form.toolStripTop.Items[0] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(infoWin.Visible);

            btn = form.toolStripTop.Items[1] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(objectsWin.Visible);

            btn = form.toolStripTop.Items[2] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(soundWin.Visible);

            btn = form.toolStripTop.Items[3] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(objTreeWin.Visible);

            btn = form.toolStripTop.Items[4] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(propWin.Visible);


            btn = form.toolStripTop.Items[5] as ToolStripButton;
            btn.Checked = Convert.ToBoolean(vobList.Visible);


           

            int radius = Imports.Extern_GetSetting();
            vobList.trackBarRadius.Value = radius;
            vobList.comboBoxVobListType.SelectedIndex = 0;


            objectsWin.LoadSettings();
        }



        public static void CloseApplication()
        {
            Properties.Settings.Default.TreeWinLocation = objTreeWin.Location;
            Properties.Settings.Default.PartWinLocation = objectsWin.Location;
            Properties.Settings.Default.PropWinLocation = propWin.Location;
            Properties.Settings.Default.VobListWinLocation = vobList.Location;
            Properties.Settings.Default.InfoWinLocation = infoWin.Location;
            Properties.Settings.Default.SoundWinLocation = soundWin.Location;


            Properties.Settings.Default.InfoWinShow = infoWin.Visible;
            Properties.Settings.Default.ObjectWinShow = objectsWin.Visible;
            Properties.Settings.Default.PropsWinShow = propWin.Visible;
            Properties.Settings.Default.SoundWinShow = soundWin.Visible;
            Properties.Settings.Default.TreeWinShow = objTreeWin.Visible;
            Properties.Settings.Default.VobListWinShow = vobList.Visible;

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
            loadForm.buttonLoadingFormClose.Visible = false;
            loadForm.Show();
            Application.DoEvents();
        }




        [DllExport]
        public static void CloseLoadingForm()
        {
            if (loadForm != null)
            {
                loadForm.Hide();
                loadForm.buttonLoadingFormClose.Visible = true;
            }

            Application.DoEvents();

        }


        [DllExport]
        public static void AcceptKey(int key)
        {
            //ConsoleEx.WriteLineRed("Gothic key: " + key);

        }

    }

}
