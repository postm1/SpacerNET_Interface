﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion
{
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
            new System.IO.StreamWriter(@"./system/_SpacerNetErrors.txt"))
            {
                file.WriteLine(str);
                file.Close();
            }
        }

        public static string ToHex(int num)
        {
            return  String.Format("0x{0:X}", num);
        }
    }

    
}

