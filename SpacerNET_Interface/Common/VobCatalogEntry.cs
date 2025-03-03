using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion.Common
{
    public class VobCatalogEntry
    {
        private int index;
        private string groupName;
        private string visual;
        private bool dynColl;
        private bool statColl;
        private bool isStaticVob;

        public string GroupName { get => groupName; set => groupName = value; }
        public string Visual { get => visual; set => visual = value; }
        public int Index { get => index; set => index = value; }
        public bool DynColl { get => dynColl; set => dynColl = value; }
        public bool StatColl { get => statColl; set => statColl = value; }
        public bool IsStaticVob { get => isStaticVob; set => isStaticVob = value; }
    }

    public class VobCatalogManager
    {
        public List<VobCatalogEntry> entries;


        public VobCatalogManager()
        {
            entries = new List<VobCatalogEntry>();
        }

        public VobCatalogEntry AddNew(string group, string visual, int index)
        {
            var newEntry = new VobCatalogEntry();

            newEntry.GroupName = group;
            newEntry.Visual = visual;
            newEntry.Index = index;

            entries.Add(newEntry);

            return newEntry;
        }

        public List<VobCatalogEntry> GetAllByGroup(string group)
        {
            List<VobCatalogEntry> list = entries.Where(x => x.GroupName == group).OrderBy(x => x.Index).ToList();

            return list;
        }

        public VobCatalogEntry GetByGroupAndVisual(string group, string visual)
        {
            return entries.Where(x => x.GroupName == group && x.Visual == visual).FirstOrDefault();
        }

        public List<VobCatalogEntry> GetByVisualAll(string visual)
        {
            return entries.Where(x => x.Visual == visual).ToList();
        }

        public int GetAmountInGroup(string group)
        {
            return entries.Where(x => x.GroupName == group).Count();
        }

        public VobCatalogEntry GetByVisual(string visual)
        {
            return entries.Where(x => x.Visual == visual).FirstOrDefault();
        }

        public void Clear()
        {
            entries.Clear();
        }

        public void UpdateIndexes(string groupName, ListBox box)
        {
            foreach (var entry in entries)
            {
                if (entry.GroupName == groupName)
                {
                    int index = box.FindString(entry.Visual);

                    if (index >= 0)
                    {
                        entry.Index = index;
                        //ConsoleEx.WriteLineRed(entry.Index + ": " + entry.Visual);
                    }
                }
            }

        }

        public void CopyVisualToGroup(string groupName, string visual)
        {
            var checkVisual = GetByGroupAndVisual(groupName, visual);

            if (checkVisual != null)
            {
                MessageBox.Show(Localizator.Get("WIN_VOBCATALOG_GROUP_ERR_ALREADY"));
                return;
            }

            int count = GetAmountInGroup(groupName);



            //ConsoleEx.WriteLineRed("Count in " + groupName + ": " + count);

            AddNew(groupName, visual, count);


        }

        public void MoveVisualToGroup(string groupName, string visual, string oldGroup)
        {
            var checkVisual = GetByGroupAndVisual(groupName, visual);

            if (checkVisual != null)
            {
                MessageBox.Show(Localizator.Get("WIN_VOBCATALOG_GROUP_ERR_ALREADY"));
                return;
            }

            int count = GetAmountInGroup(groupName);
            AddNew(groupName, visual, count);

            SpacerNET.vobCatForm.RemoveVisualFromList(oldGroup, visual);
            
        }
    }

}
