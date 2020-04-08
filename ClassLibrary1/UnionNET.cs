﻿using System;
using System.Collections.Generic;
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

        [DllExport]
        public static int UnionInitialize(IntPtr L)
        {
            MessageBox.Show("C# init");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

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

            infoWin.Left = 0;
            infoWin.Top = 600;

            comLightWin = new CompileLightWin();
            comLightWin.Owner = form;


            form.Show();
            form.panel1.Show();
 
           

            form.AddText("Загрузка Spacer...");

          //  form.Enabled = false;
            form.menuStrip1.Enabled = false;

            return 0;
        }

        [DllExport]
        public static void Form_EnableInterface()
        {
            form.AddText("Программа готова к работе!");
            //form.Enabled = true;
            form.menuStrip1.Enabled = true;
            //loadWin.Hide();
            //objWin.Show();
            //vobList.Show();
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


        [DllExport]
        public static void ShowLoading()
        {
            form.AddText("ZEN загружается...");
            
        }

        [DllExport]
        public static void CloseLoading()
        {
            form.AddText("ZEN успешно загружен!");

           // objWin.Show();
           // vobList.Show();
        }
    }

}
