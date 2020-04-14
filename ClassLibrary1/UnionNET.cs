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

        public static LoadWindow loadWin;

        public static CompileLightWin comLightWin;
        public static ObjTree objTreeWin;
        public static ParticleWin partWin;
        public static SoundWin soundWin;

        [STAThread]
        public static void StartDLL()
        {
            //..Thread.SetApartmentState(ApartmentState.STA);

            //Application.DoEvents();
            //Thread.Sleep(1000);
            // Application.
            // Console.WriteLine();
            MessageBox.Show("C# init");
            //Console.WriteLine(Application.MessageLoop);
            //Thread.Sleep(2000);
            //Application.DoEvents();
            // Application.DoEvents();
            //Application.UnregisterMessageLoop();

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //  Thread.Sleep(2000);
            //Thread.Sleep(2000);
            //Application.DoEvents();

            //
            form = new MainForm();
            form.Left = 0;
            form.Top = 0;


            vobList = new VobListForm();
            vobList.Owner = form;


            objWin = new ObjectsWindow();
            objWin.Owner = form;


            loadWin = new LoadWindow();
            loadWin.Owner = form;


            infoWin = new InfoWin();
            infoWin.Owner = form;
            infoWin.Show();


            objTreeWin = new ObjTree();
            objTreeWin.Owner = form;

            partWin = new ParticleWin();
            partWin.Owner = form;

            soundWin = new SoundWin();
            soundWin.Owner = form;




            comLightWin = new CompileLightWin();
            comLightWin.Owner = form;


            form.Show();
            form.panel1.Show();

            infoWin.Left = 0;
            infoWin.Top = 600;



            form.AddText("Загрузка Spacer...");

            //  form.Enabled = false;
            form.menuStrip1.Enabled = false;
        }


        [DllExport]
        public static int UnionInitialize(IntPtr L)
        {

            StartDLL();

            return 0;
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
            soundWin.Show();


            objTreeWin.Left = 1500;
            objTreeWin.Top = 530;

            objWin.Left = 1500;
            objWin.Top = 50;

            
            partWin.Left = 430;
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
            Console.WriteLine("HideWindows");

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
            Console.WriteLine("ShowWindows");

            for (int i = 0; i < windowsToHideList.Count; i++)
            {
                windowsToHideList[i].Show();
            }

            windowsToHideList.Clear();
        }

    }

}
