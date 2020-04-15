using System;
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
    public partial class SoundWin : Form
    {
        public SoundWin()
        {
            InitializeComponent();
        }

        [DllExport]
        public static void SortSounds()
        {
            Utils.SortListBox(UnionNET.soundWin.listBoxSound);

            UnionNET.soundWin.Text += ", всего: " + UnionNET.soundWin.listBoxSound.Items.Count;
        }

        [DllExport]
        public static void AddSoundToList(IntPtr ptr)
        {
            string name = Marshal.PtrToStringAnsi(ptr);

            UnionNET.soundWin.listBoxSound.Items.Add(name);
        }


        private void SoundWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }



        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_PlaySound(IntPtr str);

        private void buttonPlaySound_Click(object sender, EventArgs e)
        {
            ListBox listBox = UnionNET.soundWin.listBoxSound;

            if (listBox.SelectedItem == null)
            {
                return;
            }

            string name = listBox.GetItemText(listBox.SelectedItem);
            IntPtr namePtr = Marshal.StringToHGlobalAnsi(name);
            Extern_PlaySound(namePtr);
            Marshal.FreeHGlobal(namePtr);
        }
    }
}
