using SpacerUnion.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SpacerUnion
{
    public partial class SoundWin : Form
    {

        

        public SoundWin()
        {
            InitializeComponent();
        }


        public void UpdateAll()
        {
            trackBarMusicVoluem_ValueChanged(null, EventArgs.Empty);

        }


        [DllExport]
        public static void SortSounds()
        {
            Utils.SortListBox(UnionNET.soundWin.listBoxSound);

            UnionNET.soundWin.labelAllSounds.Text = "Все звуки игры. Всего: " + UnionNET.soundWin.listBoxSound.Items.Count;

            //UnionNET.soundWin.Text += ", всего: " + UnionNET.soundWin.listBoxSound.Items.Count;
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
            IntPtr namePtr = UnionNET.AddString(name);
            Extern_PlaySound(namePtr);
            UnionNET.FreeStrings();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Imports.Extern_StopAllSounds();
        }

        private void textBoxSnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string strToFind = textBoxSnd.Text.Trim().ToUpper();

                listBoxSndResult.Items.Clear();


                for (int i = 0; i < listBoxSound.Items.Count; i++)
                {
                    string value = listBoxSound.GetItemText(listBoxSound.Items[i]);

                    if (Regex.IsMatch(value, @strToFind))
                    {
                        listBoxSndResult.Items.Add(value);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListBox listBox = UnionNET.soundWin.listBoxSndResult;

            if (listBoxSndResult.SelectedItem == null)
            {
                return;
            }

            string name = listBoxSndResult.GetItemText(listBoxSndResult.SelectedItem);
            IntPtr namePtr = UnionNET.AddString(name);
            Extern_PlaySound(namePtr);
            UnionNET.FreeStrings();

        }

        private void buttonOffMusic_Click(object sender, EventArgs e)
        {
            Imports.Extern_ToggleMusic(false);
        }

        private void trackBarMusicVoluem_ValueChanged(object sender, EventArgs e)
        {
            labelMusicVolume.Text = "Громкость " + trackBarMusicVolume.Value + "%";

            Imports.Extern_SetSetting(UnionNET.AddString("musicVolume"), trackBarMusicVolume.Value);
            UnionNET.FreeStrings();
            
        }

        private void buttonMusicOn_Click(object sender, EventArgs e)
        {
            Imports.Extern_ToggleMusic(true);

            Imports.Extern_SetSetting(UnionNET.AddString("musicVolume"), trackBarMusicVolume.Value);
            
            UnionNET.FreeStrings();
        }

        private void checkBoxShutMusic_CheckedChanged(object sender, EventArgs e)
        {

            CheckBox cb = sender as CheckBox;

            Imports.Extern_SetSetting(UnionNET.AddString("musicZenOff"), Convert.ToInt32(cb.Checked));
            UnionNET.FreeStrings();
        }

        private void listBoxSound_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;

            int index = lb.IndexFromPoint(e.Location);
            {
                if (index == lb.SelectedIndex)
                {
                    string name = listBoxSound.GetItemText(listBoxSound.SelectedItem);
                    IntPtr namePtr = UnionNET.AddString(name);
                    Extern_PlaySound(namePtr);
                    UnionNET.FreeStrings();
                }
            }
        }

        private void listBoxSndResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;

            int index = lb.IndexFromPoint(e.Location);
            {
                if (index == lb.SelectedIndex)
                {
                    string name = listBoxSndResult.GetItemText(listBoxSndResult.SelectedItem);
                    IntPtr namePtr = UnionNET.AddString(name);
                    Extern_PlaySound(namePtr);
                    UnionNET.FreeStrings();
                }
            }
        }
    }
}
