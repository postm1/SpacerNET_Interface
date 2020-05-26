using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion
{
    // Класс различных функций
    public class Utils
    {
        public static void SortListBox(ListBox lstBox)
        {
            ArrayList q = new ArrayList();
            foreach (object o in lstBox.Items)
            {
                q.Add(o);
            }
            q.Sort();

            lstBox.Items.Clear();
            foreach (object o in q)
            {
                lstBox.Items.Add(o);
            }
        }

        public static void WriteToFile(string str)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"./system/_SpacerNetErrors.txt", true))
            {
                file.WriteLine(str);
                file.Close();
            }
        }

        public static string ToHex(uint num)
        {
            return  String.Format("0x{0:X}", num);
        }

        public static void Error(string msg)
        {
            DateTime now = DateTime.Now;

            msg = now.ToString("dd.MM.yyyy HH:mm:ss") + " C#: " + msg;
            ConsoleEx.WriteLineRed(msg);
            Utils.WriteToFile(msg);
        }

        public static void InfoFile(string msg)
        {
            DateTime now = DateTime.Now;

            msg = now.ToString("dd.MM.yyyy HH:mm:ss") + " C# info: " + msg;
            Utils.WriteToFile(msg);
        }
    }

    
}

