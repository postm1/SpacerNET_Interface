using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SpacerUnion.zEngine
{
    [StructLayout(LayoutKind.Sequential)]
    struct zCObject
    {
        int refCtr;
        ushort hashIndex;
    }
}
