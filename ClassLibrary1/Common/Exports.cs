using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion.Common
{
    public class Exports
    {
        // Переключает окно объектов, чтобы не обновлялся
        [DllExport]
        public static void SetObjGlobalTree_VisibleToggle(int val)
        {
            bool toggle = Convert.ToBoolean(val);


            SpacerNET.objTreeWin.globalTree.Visible = Convert.ToBoolean(toggle);

            if (toggle)
            {
                SpacerNET.objTreeWin.globalTree.EndUpdate();
            }
            else
            {
                SpacerNET.objTreeWin.globalTree.BeginUpdate();
            }

        }

        //Переключает окно объектов материалов, чтобы не обновлялся
        [DllExport]
        public static void SetObjTreeMat_VisibleToggle(int val)
        {
            bool toggle = Convert.ToBoolean(val);


            SpacerNET.objTreeWin.matTree.Visible = Convert.ToBoolean(toggle);

            if (toggle)
            {
                SpacerNET.objTreeWin.matTree.EndUpdate();
            }
            else
            {
                SpacerNET.objTreeWin.matTree.BeginUpdate();
            }

        }

        // добавляет материал в список
        [DllExport]
        public static void AddGlobalEntryMat(uint mat)
        {
            TreeNodeCollection nodes = SpacerNET.objTreeWin.matTree.Nodes;


            string group = Imports.Stack_PeekString();
            string name = Imports.Stack_PeekString();

            int nodeIndex = ObjTree.CreateAndGetFolderMat(group);

            TreeNode node = nodes[nodeIndex].Nodes.Add(name);
            node.Tag = mat;
            node.Text = name;
            node.ImageIndex = 1;
            node.SelectedImageIndex = 1;

            TreeEntry entry = new TreeEntry();

            entry.name = name;

            entry.zCVob = mat;
            entry.node = node;

            try
            {
                ObjTree.matEntries.Add(mat, entry);

            }
            catch
            {

                Utils.Error("AddGlobalEntryMat: Key exists!: Key: " + Utils.ToHex(mat) + ", Name: " + name);
            }
        }
    }
}
