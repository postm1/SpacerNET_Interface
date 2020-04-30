using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacerUnion
{
    public class TriggerEntry
    {
        public bool dynColl;
        public bool statColl;
        public int m_kf_pos;
        public int maxKey;
        public string name;

        public int currentActionIndex;

        public List<uint> targetListAddr = new List<uint>();
    }
}
