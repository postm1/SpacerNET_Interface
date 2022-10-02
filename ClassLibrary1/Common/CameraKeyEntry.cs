using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SpacerUnion.Common
{
    public class CameraKeyEntry
    {
        public ObjectsWin win;

        public int currentKey;
        public string name;
        public int splineSelect;
        public int durationTime;
        public bool cameraRun;


        public CameraKeyEntry(ObjectsWin win)
        {
            cameraRun = false;
            currentKey = 0;
            name = String.Empty;
            splineSelect = 0;
            durationTime = 0;
            this.win = win;
        }

        public void OnInsertNewCamera(string camName)
        {
            this.name = camName;

            win.listBoxCameraSpline.Items.Clear();
            win.listBoxCameraTarget.Items.Clear();
            SpacerNET.objectsWin.labelCamKeyCurrent.Text = "0";


            Imports.Stack_PushString(this.name);
            Imports.Extern_InsertNewCamera();
        }

        
        public void OnRun()
        {
            Imports.Extern_CameraRun();
        }

        public void OnStop()
        {
            Imports.Extern_CameraStop();
        }

        public void OnUpdateKey()
        {
            //ConsoleEx.WriteLineYellow("OnUpdateKey: " + this.currentKey);

            Imports.Extern_CameraGotoKey(this.currentKey);
        }


        public void OnChangeTime(string name, bool checkedHide)
        {
            int val = 0;
            int hide = Convert.ToInt32(checkedHide);

            if (int.TryParse(name, out val))
            {
                Imports.Extern_CameraUpdateSpacerTime(val, hide);
            }
        }

        public void OnInsertSplineKey()
        {
            Imports.Extern_InsertNewSplineKey();
        }

        public void OnInsertTargetKey()
        {
            Imports.Extern_InsertNewTargetKey();
        }




        // интерфейс
        [DllExport]
        public static void OnRenameSplineKey_Interface()
        {
            int index = Imports.Stack_PeekInt();
            string name = Imports.Stack_PeekString();
           

            //ConsoleEx.WriteLineYellow("OnRenameSplineKey_Interface");


            if (index >= 0 && index < SpacerNET.objectsWin.listBoxCameraSpline.Items.Count)
            {
                SpacerNET.objectsWin.listBoxCameraSpline.Items[index] = name;
            }
            

        }

        [DllExport]
        public static void OnRenameTargetKey_Interface()
        {
            int index = Imports.Stack_PeekInt();
            string name = Imports.Stack_PeekString();


           // ConsoleEx.WriteLineYellow("OnRenameTargetKey_Interface");


            if (index >= 0 && index < SpacerNET.objectsWin.listBoxCameraTarget.Items.Count)
            {
                SpacerNET.objectsWin.listBoxCameraTarget.Items[index] = name;
            }


        }

        

        [DllExport]
        public static void OnCameraClear_Interface()
        {

           // ConsoleEx.WriteLineYellow("OnCameraClear_Interface");

            SpacerNET.objectsWin.listBoxCameraSpline.Items.Clear();
            SpacerNET.objectsWin.listBoxCameraTarget.Items.Clear();
            SpacerNET.objectsWin.labelCamKeyCurrent.Text = "0";
        }

        [DllExport]
        public static void OnInsertSplineKey_Interface()
        {
            string name = Imports.Stack_PeekString();

           // ConsoleEx.WriteLineYellow("OnInsertSplineKey_Interface: " + name);

            SpacerNET.objectsWin.listBoxCameraSpline.Items.Add(name);
        }

        [DllExport]
        public static void OnInsertTargetKey_Interface()
        {
            string name = Imports.Stack_PeekString();

           // ConsoleEx.WriteLineYellow("OnInsertTargetKey_Interface: " + name);

            SpacerNET.objectsWin.listBoxCameraTarget.Items.Add(name);
        }


        [DllExport]
        public static void OnRemoveSplineKey_Interface()
        {
            int index = Imports.Stack_PeekInt();

            //ConsoleEx.WriteLineYellow("OnRemoveSplineKey_Interface: " + index);

            if (index != -1)
            {
                SpacerNET.objectsWin.listBoxCameraSpline.Items.RemoveAt(index);
            }

            
        }


        [DllExport]
        public static void OnRemoveTargetKey_Interface()
        {
            int index = Imports.Stack_PeekInt();

            //ConsoleEx.WriteLineYellow("OnRemoveTargetKey_Interface: " + index);

            if (index != -1)
            {
                SpacerNET.objectsWin.listBoxCameraTarget.Items.RemoveAt(index);
            }


        }
    }
}
