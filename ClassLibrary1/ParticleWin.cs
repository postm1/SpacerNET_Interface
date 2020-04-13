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

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreateItem(IntPtr name);

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_CreatePFX(IntPtr name);


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
            ListBox listBox = UnionNET.partWin.listBoxItems;
            string name = Marshal.PtrToStringAnsi(ptr);

            int index = listBox.Items.Add(name);
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


        

        private void buttonItems_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem == null)
            {
                return;
            }
            string name = listBoxItems.GetItemText(listBoxItems.SelectedItem);

            //Console.WriteLine("Create item: " + name);


            UnionNET.infoWin.AddText("Создаю Item " + name);

            IntPtr item_name = Marshal.StringToHGlobalAnsi(name);

            Extern_CreateItem(item_name);
            Marshal.FreeHGlobal(item_name);

            UnionNET.form.Focus();

        }

        private void textBoxItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBoxItems_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBoxItems_TextChanged(object sender, EventArgs e)
        {
            string strToFind = textBoxItems.Text.Trim().ToUpper();

            for (int i = 0; i < listBoxItems.Items.Count; i++)
            {
                if (listBoxItems.GetItemText(listBoxItems.Items[i]).Contains(strToFind))
                {
                    listBoxItems.SelectedIndex = i;
                    break;
                }
            }
        }

        private void buttonParticles_Click(object sender, EventArgs e)
        {
            if (listBoxParticles.SelectedItem == null)
            {
                return;
            }
            string name = listBoxParticles.GetItemText(listBoxParticles.SelectedItem);


            UnionNET.infoWin.AddText("Создаю PFX " + name);

            IntPtr PfxName = Marshal.StringToHGlobalAnsi(name);

            Extern_CreatePFX(PfxName);
            Marshal.FreeHGlobal(PfxName);

            UnionNET.form.Focus();
        }
    }
}
