using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion
{
    public partial class ParticleWin : Form
    {
        public ParticleWin()
        {
            InitializeComponent();
        }

        [DllExport]
        public static void AddPacticleToList(IntPtr ptr)
        {
            string name = Marshal.PtrToStringAnsi(ptr);

            UnionNET.partWin.listBoxParticles.Items.Add(name);
        }

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
        [DllExport]
        public static void SortPFX()
        {
            //UnionNET.partWin.listBoxParticles.Sorted = true;
            ListBox lstBox = UnionNET.partWin.listBoxParticles;
            SortListBox(lstBox);



        }

        [DllExport]
        public static void AddItemToList(IntPtr ptr)
        {
            string name = Marshal.PtrToStringAnsi(ptr);

            UnionNET.partWin.listBoxItems.Items.Add(name);
        }

        [DllExport]
        public static void SortItems()
        {
            //UnionNET.partWin.listBoxItems.Sorted = true;
            SortListBox(UnionNET.partWin.listBoxItems);
        }

        private void ParticleWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }


        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreateItem(IntPtr name);

        private void buttonItems_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem == null)
            {
                return;
            }


            string name = listBoxItems.GetItemText(listBoxItems.SelectedItem);

            Console.WriteLine("Create item: " + name);


            

            IntPtr item_name = Marshal.StringToHGlobalAnsi(name);

            Extern_CreateItem(item_name);
            Marshal.FreeHGlobal(item_name);
        }
    }
}
