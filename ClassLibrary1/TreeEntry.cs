using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion
{
    public class TreeEntry
    {
        public int zCVob;
        public int parent;
        public string name;
        public TreeNode node;
        public string folderName;
        public string className;
        public bool isLevel;
        public TreeEntry parentEntry;
        public List<TreeEntry> childs;
        public bool toDelete;
        public int? parentTest;
        public TreeEntry()
        {
            parentEntry = null;
            childs = new List<TreeEntry>();
            toDelete = false;
        }

    }

}
