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

        // current position of the key
        public int m_kf_pos;
        // highest position of the key
        public int maxKey;

        public string name;

        public string className;

        // current action (TRIGGER, UNTRIGGER...)
        public int currentActionIndex;

        public bool enabled;

        // addresses of the vobs that are targets of this trigger
        public List<uint> targetListAddr;

        // addresses of the vobs that are sources of this trigger
        public List<uint> sourcesListAddr;


        public TriggerEntry()
        {
            this.enabled = false;
            this.targetListAddr = new List<uint>();
            this.sourcesListAddr = new List<uint>();
        }

    }

    
}
