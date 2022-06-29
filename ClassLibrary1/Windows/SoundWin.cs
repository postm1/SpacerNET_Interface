﻿using SpacerUnion.Common;
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

        public void UpdateLang()
        {
            this.Text = Localizator.Get("WIN_SOUND_TITLE");
            groupBoxSound.Text = Localizator.Get("groupBoxSound");
            groupBoxMusic.Text = Localizator.Get("groupBoxMusic");
            buttonPlaySound.Text = Localizator.Get("buttonPlaySound");
           // buttonPlaySoundRegex.Text = Localizator.Get("buttonPlaySound");
            labelAllSounds.Text = Localizator.Get("labelAllSounds");
            labelSndList.Text = Localizator.Get("labelSndList");
            buttonOffMusic.Text = Localizator.Get("buttonOffMusic");
            buttonMusicOn.Text = Localizator.Get("buttonMusicOn");
            checkBoxShutMusic.Text = Localizator.Get("checkBoxShutMusic");
            labelMusicVolume.Text = Localizator.Get("labelMusicVolume");
            //groupBoxSoundsMisc.Text = Localizator.Get("groupBoxSound");
            buttonStopAllSounds.Text = Localizator.Get("buttonStopAllSounds");
            checkBoxShutSounds.Text = Localizator.Get("checkBoxShutSounds");
            checkBoxConstSound.Text = Localizator.Get("checkBoxConstSound");
            
        }


        public void UpdateAll()
        {
            trackBarMusicVoluem_ValueChanged(null, EventArgs.Empty);

        }


        [DllExport]
        public static void SortSounds()
        {
            Utils.SortListBox(SpacerNET.soundWin.listBoxSound);

            SpacerNET.soundWin.labelAllSounds.Text = Localizator.Get("labelAllSounds") + ": " + SpacerNET.soundWin.listBoxSound.Items.Count;

            //UnionNET.soundWin.Text += ", всего: " + UnionNET.soundWin.listBoxSound.Items.Count;
        }

        [DllExport]
        public static void SortMusic()
        {
            Utils.SortListBox(SpacerNET.soundWin.listBoxMusic);

            SpacerNET.soundWin.labelAllSounds.Text = Localizator.Get("labelAllSounds") + ": " + SpacerNET.soundWin.listBoxSound.Items.Count;

            //UnionNET.soundWin.Text += ", всего: " + UnionNET.soundWin.listBoxSound.Items.Count;
        }


        [DllExport]
        public static void AddSoundToList()
        {
            string name = Imports.Stack_PeekString();

            SpacerNET.soundWin.listBoxSound.Items.Add(name);
        }

        [DllExport]
        public static void AddMusicToList()
        {
            string name = Imports.Stack_PeekString();

            SpacerNET.soundWin.listBoxMusic.Items.Add(name);
        }


        private void SoundWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }



       

        private void buttonPlaySound_Click(object sender, EventArgs e)
        {
            ListBox listBox = SpacerNET.soundWin.listBoxSound;

            if (listBox.SelectedItem == null)
            {
                return;
            }

            string name = listBox.GetItemText(listBox.SelectedItem);
            Imports.Stack_PushString(name);
            Imports.Extern_PlaySound();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Imports.Extern_StopAllSounds();
        }

        /*
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
            ListBox listBox = SpacerNET.soundWin.listBoxSndResult;

            if (listBoxSndResult.SelectedItem == null)
            {
                return;
            }

            string name = listBoxSndResult.GetItemText(listBoxSndResult.SelectedItem);
            Imports.Stack_PushString(name);
            Imports.Extern_PlaySound();

        }
        */

        private void buttonOffMusic_Click(object sender, EventArgs e)
        {
            Imports.Extern_ToggleMusic(false);
        }

        private void trackBarMusicVoluem_ValueChanged(object sender, EventArgs e)
        {
            labelMusicVolume.Text = Localizator.Get("labelMusicVolume") + " " + trackBarMusicVolume.Value + "%";

            Imports.Stack_PushString("musicVolume");
            Imports.Extern_SetSetting(trackBarMusicVolume.Value);
            
        }

        private void buttonMusicOn_Click(object sender, EventArgs e)
        {
            Imports.Extern_ToggleMusic(true);
            Imports.Stack_PushString("musicVolume");
            Imports.Extern_SetSetting(trackBarMusicVolume.Value);
            
        }

        private void checkBoxShutMusic_CheckedChanged(object sender, EventArgs e)
        {

            CheckBox cb = sender as CheckBox;
            Imports.Stack_PushString("musicZenOff");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
        }

        private void listBoxSound_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;

            int index = lb.IndexFromPoint(e.Location);
            {
                if (index == lb.SelectedIndex)
                {
                    string name = listBoxSound.GetItemText(listBoxSound.SelectedItem);
                    Imports.Stack_PushString(name);
                    Imports.Extern_PlaySound();
                }
            }
        }

        /*
        private void listBoxSndResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;

            int index = lb.IndexFromPoint(e.Location);
            {
                if (index == lb.SelectedIndex)
                {
                    string name = listBoxSndResult.GetItemText(listBoxSndResult.SelectedItem);
                    Imports.Stack_PushString(name);
                    Imports.Extern_PlaySound();
                }
            }
        }
        */

        private void checkBoxShutSounds_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            Imports.Stack_PushString("soundZenOff");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
        }

        private void checkBoxShutMusic_ChangeUICues(object sender, UICuesEventArgs e)
        {
            
        }

        private void SoundWin_Shown(object sender, EventArgs e)
        {
            Imports.Stack_PushString("musicZenOff");
            bool musicOff = Convert.ToBoolean(Imports.Extern_GetSetting());
            SpacerNET.soundWin.checkBoxShutMusic.Checked = musicOff;


            Imports.Stack_PushString("soundZenOff");
            bool soundOff = Convert.ToBoolean(Imports.Extern_GetSetting());
            SpacerNET.soundWin.checkBoxShutSounds.Checked = soundOff;


            Imports.Stack_PushString("alwaysShutSounds");
            bool soundConst = Convert.ToBoolean(Imports.Extern_GetSetting());
            SpacerNET.soundWin.checkBoxConstSound.Checked = soundConst;


            Imports.Stack_PushString("musicVolume");
            int volume = Imports.Extern_GetSetting();
            SpacerNET.soundWin.trackBarMusicVolume.Value = volume;


            SpacerNET.soundWin.UpdateAll();
        }

        private void checkBoxConstSound_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            Imports.Stack_PushString("alwaysShutSounds");
            Imports.Extern_SetSetting(Convert.ToInt32(cb.Checked));
        }

        private void listBoxMusic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;

            int index = lb.IndexFromPoint(e.Location);
            {
                if (index == lb.SelectedIndex)
                {
                    string name = listBoxMusic.GetItemText(listBoxMusic.SelectedItem);
                    Imports.Stack_PushString(name);
                    Imports.Extern_PlayMusic();
                }
            }
        }
    }
}
