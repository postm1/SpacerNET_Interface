using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacerUnion.Common
{
    public class VobCatalogEntry
    {
        private string groupName;
        private string entryName;
        private string visual;


        public string GroupName { get => groupName; set => groupName = value; }
        public string EntryName { get => entryName; set => entryName = value; }
        public string Visual { get => visual; set => visual = value; }
    }

    public class VobCatalogManager
    {
        public List<VobCatalogEntry> entries;


        public VobCatalogManager()
        {
            entries = new List<VobCatalogEntry>();
        }

        public void AddNew(string group, string name, string visual)
        {
            var newEntry = new VobCatalogEntry();

            newEntry.GroupName = group;
            newEntry.EntryName = name;
            newEntry.Visual = visual;

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
    }

}
