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
        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SelectVobSync(uint a);

        [DllImport("SpacerUnionNet.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Extern_SelectVob(uint a);



        public static List<uint> vobList = new List<uint>();

        public VobListForm()
        {
            InitializeComponent();
        }


        [DllExport]
        public static int GetSearchRadius()
        {
            return UnionNET.vobList.trackBarRadius.Value;
        }


        [DllExport]
        public static void ClearVobList()
        {
            UnionNET.vobList.listBoxVobs.Items.Clear();
            vobList.Clear();
        }


        [DllExport]
        public static void AddToVobList(uint vob, IntPtr vobNamePtr)
        {
            string vobName = Marshal.PtrToStringAnsi(vobNamePtr);

            UnionNET.vobList.listBoxVobs.Items.Add(vobName);
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
                        UnionNET.objTreeWin.globalTree.SelectedNode =
                        ObjTree.globalEntries[vobAddr].node;
                    }
                    catch
                    {
                        ConsoleEx.WriteLineGreen("C#: vobListSelect. Can't find vob with addr: " + Utils.ToHex(vobAddr));
                    }

                    Extern_SelectVob(vobAddr);


                }
                
            }
        }

        public void ClearListBox()
        {
            listBoxVobs.Items.Clear();
        }
        private void trackBarRadius_ValueChanged(object sender, EventArgs e)
        {
            labelRadius.Text = "Радиус поиска: " + trackBarRadius.Value;
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
                        UnionNET.objTreeWin.globalTree.SelectedNode =
                        ObjTree.globalEntries[vobAddr].node;
                    }
                    catch
                    {
                        ConsoleEx.WriteLineGreen("C#: vobListSelect. Can't find vob with addr: " + Utils.ToHex(vobAddr));
                    }

                    Extern_SelectVobSync(vobAddr);
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

        
    }
}
