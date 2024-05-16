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
        private string entryName;
        private string visual;


        public string GroupName { get => groupName; set => groupName = value; }
        public string EntryName { get => entryName; set => entryName = value; }
        public string Visual { get => visual; set => visual = value; }
        public int Index { get => index; set => index = value; }
    }

    public class VobCatalogManager
    {
        public List<VobCatalogEntry> entries;


        public VobCatalogManager()
        {
            entries = new List<VobCatalogEntry>();
        }

        public void AddNew(string group, string name, string visual, int index)
        {
            var newEntry = new VobCatalogEntry();

            newEntry.GroupName = group;
            newEntry.EntryName = name;
            newEntry.Visual = visual;
            newEntry.Index = index;

            entries.Add(newEntry);
        }

        public List<VobCatalogEntry> GetAllByGroup(string group)
        {
            List<VobCatalogEntry> list = entries.Where(x => x.GroupName == group).ToList();

            return list;
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
    }

}
