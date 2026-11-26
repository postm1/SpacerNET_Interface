using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion
{
    public class TreeEntry
    {
        // address of the vob in memory
        public uint zCVob;
        // address of its parent, or 0 when there is no parent
        public uint parent;
        // name of the vob
        public string name;
        // name of the folder in the tree structure
        public string folderName;
        // class of the actor (oCMobInter, zCVob...)
        public string className;
        // is zCVobLevelCompo
        public bool isLevel;
        // flag for deletion
        public bool toDelete;

        // the node of the TreeView this vob is bound to
        public TreeNode node;

        // link to the parent entry
        public TreeEntry parentEntry;

        // links to the children of this entry
        public List<TreeEntry> childs;

       
        public TreeEntry()
        {
            parentEntry = null;
            childs = new List<TreeEntry>();
            toDelete = false;
        }

        public string ToString()
        {
            return name + " | " + Utils.ToHex(zCVob);
        }

    }

}
