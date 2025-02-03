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
        bool vobList_MouseClick = false;


        public static List<uint> vobList = new List<uint>();

        public VobListForm()
        {
            InitializeComponent();
            this.comboBoxVobList.SelectedIndex = 0;
            this.comboBoxFilterPick.SelectedIndex = 0;
        }

        public void UpdateLang()
        {
            this.Text = Localizator.Get("WIN_VOBLIST_TITLE");
            //labelVobType.Text = Localizator.Get("labelVobType");
            labelRadius.Text = Localizator.Get("labelRadius") + ": " + trackBarRadius.Value;
            btnRemoveContainerVobs.Text = Localizator.Get("WIN_INFO_CLEAR");
            buttonVobListSearch.Text = Localizator.Get("MSG_COMMON_SEARCH");
            
            labelFilterVobsPick.Text = Localizator.Get("OBJ_TAB_PICKFILTER");

            comboBoxVobList.Items[0] = Localizator.Get("VOBLIST_TYPE_ANY");
            comboBoxVobList.Items[10] = Localizator.Get("VOB_FILTER_SHOW_ONLY_INVISIBLE");


            
            comboBoxFilterPick.Items[0] = Localizator.Get("OPTION_CHECK_NONE");
            comboBoxFilterPick.Items[10] = Localizator.Get("VOB_FILTER_IGNORE_PFX");
            comboBoxFilterPick.Items[11] = Localizator.Get("VOB_FILTER_SHOW_ONLY_INVISIBLE");
            comboBoxFilterPick.Items[12] = Localizator.Get("VOB_FILTER_IGNORE_DECALS");
            comboBoxFilterPick.Items[13] = Localizator.Get("VOB_FILTER_IGNORE_DECALS_PFX");

            CleanListVobList.Text = Localizator.Get("WIN_INFO_CLEAR");
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

            var listBox = SpacerNET.vobList.listBoxVobs;

            listBox.Items.Add(vobName);

            vobList.Add(vob);
        }

        public void ClearListBox()
        {
            listBoxVobs.Items.Clear();
            vobList.Clear();
            vobList_MouseClick = false;
        }

        public void OnVobDelete(uint addr)
        {
            if (addr == 0) return;

            var index = vobList.FindIndex(ele => ele == addr);


            //ConsoleEx.WriteLineYellow("VobListForm OnVobDelete: " + addr);
            //MessageBox.Show(index.ToString());

            if (index >= 0)
            {
                if (listBoxVobs.Items.Count > 0 && listBoxVobs.Items.Count >= index + 1)
                {
                    listBoxVobs.Items.RemoveAt(index);
                    vobList.RemoveAt(index);
                }
            }

        }

        private void VobListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;

            SpacerNET.form.SetIconActive("vobCont", false);
        }

        private void listBoxVobs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBoxVobs.IndexFromPoint(e.Location);

            SelectVobInWorldByListIndex(index, true);
        }

        
        private void trackBarRadius_ValueChanged(object sender, EventArgs e)
        {
            labelRadius.Text = Localizator.Get("labelRadius") + ": " + trackBarRadius.Value;

            Imports.Stack_PushString("vobListRadius");

            Imports.Extern_SetSetting(trackBarRadius.Value);
            

        }

        private void listBoxVobs_MouseClick(object sender, MouseEventArgs e)
        {
            vobList_MouseClick = true;

            int index = listBoxVobs.IndexFromPoint(e.Location);

            if (SelectVobInWorldByListIndex(index, false))
                this.Activate();
        }

        private void очиститьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearListBox();
        }

        private void listBoxVobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vobList_MouseClick == true)
            {
                vobList_MouseClick = false;
                return;
            }

            if (SelectVobInWorldByListIndex(listBoxVobs.SelectedIndex, false))
                this.Activate();
        }

        private void comboBoxVobList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            int selIndex = cb.SelectedIndex;

            Imports.Extern_SetVobListType(selIndex); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearListBox();
        }

        private void buttonVobListSearch_Click(object sender, EventArgs e)
        {
            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                return;
            }

            Imports.Extern_SearchVobList();
        }

        private void comboBoxFilterPick_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox ch = sender as ComboBox;

            int index = ch.SelectedIndex;

            Imports.Extern_SetVobPickFilter(index);

        }

        [DllExport]
        public static void SetSelectioFilterByIndex(int index)
        {
            if (index >= 0 && index < SpacerNET.vobList.comboBoxFilterPick.Items.Count)
            {
                switch (index)
                {
                    case 0:
                    {
                        Imports.Stack_PushString(Localizator.Get("SET_SELECT_FILTER_NONE"));
                        Imports.Extern_PrintRed();
                        break;
                    }
                    case 13:
                        {
                            Imports.Stack_PushString(Localizator.Get("SET_SELECT_FILTER_DECALS_PFX"));
                            Imports.Extern_PrintRed();
                            break;
                        }
                }
                SpacerNET.vobList.comboBoxFilterPick.SelectedIndex = index;

            }

        }

        bool SelectVobInWorldByListIndex(int index, bool bMoveCamToVob)
        {
            if (index < 0 || index >= listBoxVobs.Items.Count)
                // выходим
                return false;


            uint vobAddr = vobList[index];
            // ConsoleEx.WriteLineGreen(vobAddr + " index " + index);

            try
            {
                SpacerNET.objTreeWin.globalTree.SelectedNode =
                ObjTree.globalEntries[vobAddr].node;
            }
            catch
            {
                ConsoleEx.WriteLineGreen("vobListSelect. Can't find vob with addr: " + Utils.ToHex(vobAddr));
            }

            if (bMoveCamToVob)
                Imports.Extern_SelectVob(vobAddr);
            else 
                Imports.Extern_SelectVobSync(vobAddr);

            return true;
        }

        private void comboBoxVobList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            int selIndex = cb.SelectedIndex;

            Imports.Extern_SetVobListType(selIndex);
        }
    }
}
