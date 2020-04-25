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
        public static MainForm form;
        public static VobListForm vobList;
        public static ObjectsWindow objWin;

        public static InfoWin infoWin;

        public static CompileLightWin comLightWin;
        public static ObjTree objTreeWin;
        public static ParticleWin partWin;
        public static SoundWin soundWin;
        public static InputBox inputBox;
        public static CompileWorldWin compWorldWin;


        public static SettingsCamera settingsCam;

        static Thread th = null;


        

        [STAThread]

        public static void StartDLL()
        {

            AutoClosingMessageBox.Show("", "Spacer is loading...", 90);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //
            form = new MainForm();
            form.Left = 0;
            form.Top = 0;


            vobList = new VobListForm();
            vobList.Owner = form;

            objWin = new ObjectsWindow();
            objWin.Owner = form;



            infoWin = new InfoWin();
            infoWin.Owner = form;
            


            objTreeWin = new ObjTree();
            objTreeWin.Owner = form;

            partWin = new ParticleWin();
            partWin.Owner = form;

            soundWin = new SoundWin();
            soundWin.Owner = form;


            inputBox = new InputBox();
            inputBox.Owner = form;



            comLightWin = new CompileLightWin();
            comLightWin.Owner = form;

            settingsCam = new SettingsCamera();
            settingsCam.Owner = form;

            compWorldWin = new CompileWorldWin();
            compWorldWin.Owner = form;

            form.Show();
            form.panel1.Show();


            infoWin.Show();
            infoWin.Left = 600;
            infoWin.Top = 600;



            form.AddText("Загрузка Spacer...");

            //  form.Enabled = false;
            form.menuStrip1.Enabled = false;

        
        }


        [DllExport, STAThread]
        public static void UnionInitialize(IntPtr L)
        {
            StartDLL();

        }

        [DllExport]
        public static void Form_EnableInterface()
        {
            form.AddText("Программа готова к работе!");
            //form.Enabled = true;
            form.menuStrip1.Enabled = true;
            //loadWin.Hide();
            objWin.Show();
            //vobList.Show();
            objTreeWin.Show();
            partWin.Show();

            //soundWin.Show();


            objTreeWin.Left = 1500;
            objTreeWin.Top = 530;

            objWin.Left = 1500;
            objWin.Top = 50;

            
            partWin.Left = 0;
            partWin.Top = 600;

            
            soundWin.Left = 0;
            soundWin.Top = 300;


            form.Focus();
        }

        [DllExport]
        public static int GetHandlerFunc()
        {
            return (int)form.renderTarget.Handle;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern IntPtr GetForegroundWindow();

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

        static List<Form> windowsToHideList = null;
        static List<Form> windowsList = null;
        [DllExport]
        public static void HideWindows()
        {
            //Console.WriteLine("HideWindows");

            if (windowsToHideList == null)
            {
                windowsToHideList = new List<Form>();
            }

            if (windowsList == null)
            {
                windowsList = new List<Form>();
                windowsList.Add(objTreeWin);
                windowsList.Add(partWin);
                windowsList.Add(infoWin);
                windowsList.Add(objWin);
                windowsList.Add(soundWin);
            }
                
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
            //Console.WriteLine("ShowWindows");

            for (int i = 0; i < windowsToHideList.Count; i++)
            {
                windowsToHideList[i].Show();
            }

            windowsToHideList.Clear();
            form.Focus();
        }

      


        
    }

}
