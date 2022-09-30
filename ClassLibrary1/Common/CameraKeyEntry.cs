using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacerUnion.Common
{
    public class CameraKeyEntry
    {

        public int currentKey;
        public int maxKey;
        public string name;
        public int splineSelect;
        public int durationTime;


        public CameraKeyEntry()
        {
            currentKey = 0;
            maxKey = 0;
            name = String.Empty;
            splineSelect = 0;
            durationTime = 0;
        }

        public void OnInsertNewCamera(string camName)
        {
            this.name = camName;

            Imports.Stack_PushString(this.name);
            Imports.Extern_InsertNewCamera();
        }

        public void OnRun()
        {

        }
    }
}
