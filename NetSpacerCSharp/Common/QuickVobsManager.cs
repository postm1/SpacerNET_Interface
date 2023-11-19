using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion.Common
{
    public class QuickVobsEntry
    {
        public TreeNode quickNode;
        public TreeNode realNode;
        public bool isParent;

        public QuickVobsEntry()
        {
            quickNode = null;
            realNode = null;
            isParent = false;
        }

        public void Clean()
        {
            quickNode = null;
            realNode = null;
        }


    }

    public class QuickVobsManager
    {
        public static List<QuickVobsEntry> quickVobList;

        public QuickVobsManager()
        {
            quickVobList = new List<QuickVobsEntry>();
        }

        public QuickVobsEntry GetGlobalParentNode()
        {
            QuickVobsEntry result = null;

            for (int i = 0; i < quickVobList.Count; i++)
            {
                var entry = quickVobList[i];

                if (entry.isParent)
                {
                    result = entry;
                    break;
                }
            }

            return result;
        }

        public void Remove(QuickVobsEntry entry)
        {
            quickVobList.Remove(entry);
        }

        public void RemoveByQuickNode(TreeNode quickNode)
        {
            for (int i = 0; i < quickVobList.Count; i++)
            {
                var entry = quickVobList[i];

                if (entry.quickNode == quickNode && entry.isParent == false)
                {
                    quickVobList.RemoveAt(i);
                    break;
                }
            }
        }

        public QuickVobsEntry Add()
        {
            var entry = new QuickVobsEntry();

            quickVobList.Add(entry);

            return entry;
        }

        public bool AlreadyInList(uint vob)
        {
            bool result = false;

            for (int i = 0; i < quickVobList.Count; i++)
            {
                var entry = quickVobList[i];

                if (entry.realNode != null && Convert.ToUInt32(entry.realNode.Tag) == vob)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public void Clear()
        {
            quickVobList.Clear();
        }

        public QuickVobsEntry GetEntryByQuickNode(TreeNode quickNode)
        {
            QuickVobsEntry result = null;

            for (int i = 0; i < quickVobList.Count; i++)
            {
                var entry = quickVobList[i];

                if (entry.quickNode == quickNode)
                {
                    result = entry;
                    break;
                }
            }

            return result;
        }

        public QuickVobsEntry GetEntryByRealNode(TreeNode realNode)
        {
            QuickVobsEntry result = null;

            for (int i = 0; i < quickVobList.Count; i++)
            {
                var entry = quickVobList[i];

                if (entry.realNode == realNode)
                {
                    result = entry;
                    break;
                }
            }

            return result;
        }
    }
}
