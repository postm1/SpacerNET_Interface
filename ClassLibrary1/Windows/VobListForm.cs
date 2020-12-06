using SpacerUnion.Common;
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

   

    public partial class VobListForm : Form
    {
       



        public static List<uint> vobList = new List<uint>();

        public VobListForm()
        {
            InitializeComponent();
            this.comboBoxVobList.SelectedIndex = 0;
        }

        public void UpdateLang()
        {
            this.Text = Localizator.Get("WIN_VOBLIST_TITLE");
            //labelVobType.Text = Localizator.Get("labelVobType");
            labelRadius.Text = Localizator.Get("labelRadius") + ": " + trackBarRadius.Value;
        }

        [DllExport]
        public static int GetSearchRadius()
        {
            return SpacerNET.vobList.trackBarRadius.Value;
        }


        [DllExport]
        public static void ClearVobList()
        {
            SpacerNET.vobList.listBoxVobs.Items.Clear();
            vobList.Clear();
        }


        [DllExport]
        public static void AddToVobList(uint vob)
        {
            string vobName = Imports.Stack_PeekString();

            SpacerNET.vobList.listBoxVobs.Items.Add(vobName);
            vobList.Add(vob);
        }

        private void VobListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void listBoxVobs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBoxVobs.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                if (listBoxVobs.Items.Count >= index - 1)
                {
                    uint vobAddr = vobList[index];
                    //ConsoleEx.WriteLineGreen(vobAddr + " index " + index);

                    try
                    {
                        SpacerNET.objTreeWin.globalTree.SelectedNode =
                        ObjTree.globalEntries[vobAddr].node;
                    }
                    catch
                    {
                        ConsoleEx.WriteLineGreen("vobListSelect. Can't find vob with addr: " + Utils.ToHex(vobAddr));
                    }

                    Imports.Extern_SelectVob(vobAddr);


                }
                
            }
        }

        public void ClearListBox()
        {
            listBoxVobs.Items.Clear();
        }
        private void trackBarRadius_ValueChanged(object sender, EventArgs e)
        {
            labelRadius.Text = Localizator.Get("labelRadius") + ": " + trackBarRadius.Value;

            Imports.Stack_PushString("vobListRadius");

            Imports.Extern_SetSetting(trackBarRadius.Value);
            

        }

        private void listBoxVobs_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listBoxVobs.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                if (listBoxVobs.Items.Count >= index - 1)
                {
                    uint vobAddr = vobList[index];
                    //ConsoleEx.WriteLineGreen(vobAddr + " index " + index);

                    try
                    {
                        SpacerNET.objTreeWin.globalTree.SelectedNode =
                        ObjTree.globalEntries[vobAddr].node;

                        Imports.Extern_SelectVobSync(vobAddr);
                    }
                    catch
                    {
                        ConsoleEx.WriteLineGreen("vobListSelect. Can't find vob with addr: " + Utils.ToHex(vobAddr));
                    }

                   
                }

            }
        }

        private void очиститьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxVobs.Items.Clear();
        }

        private void listBoxVobs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxVobList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            int selIndex = cb.SelectedIndex;

            Imports.Extern_SetVobListType(selIndex); 
        }
    }
}
