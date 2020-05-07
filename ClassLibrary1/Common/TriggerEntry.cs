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

        //текущая позиция ключа
        public int m_kf_pos;
        //максимальная позиция ключа
        public int maxKey;

        public string name;

        //текущее действие (TRIGGER, UNTRIGGER...)
        public int currentActionIndex;

        public bool enabled;

        // Адреса вобов-triggerTarget
        public List<uint> targetListAddr;


        public TriggerEntry()
        {
            this.enabled = false;
            this.targetListAddr = new List<uint>();
        }

    }

    
}
