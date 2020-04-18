﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion.zEngine
{
    public enum TPropEditType
    {
        PETunknown,
        PETbool,
        PETenum,
        PETint,
        PETfloat,
        PETstring,
        PETvec3,
        PETcolor,
        PETraw,
        PETclass,
        PETgroup,
        PETchunkend
    };

    public class CProperty
    {
        string groupName;
        string name;
        public string value;
        public string backup_value;
        private bool oldValueInit;
        public TPropEditType type;
        public List<string> enumArray = new List<string>();
        public TreeNode node;
        public TreeNode ownNode;

        public CProperty()
        {
            node = null;
            ownNode = null;
            backup_value = "";
            oldValueInit = false;
            value = "";
        }

        public string ShowValue()
        {
            string result = "";

            if (type == TPropEditType.PETbool)
            {
                if (value == "0") result = "FALSE"; else result = "TRUE";
            }
            else
            if (type == TPropEditType.PETenum)
            {
                int index = 0;

                Int32.TryParse(value, out index);

                Console.WriteLine("Get Enum with index {0}. Result is {1} Value is {2}", index, enumArray[index], value);
                result = enumArray[index];

            }
            else
            {
                result = value;
            }

            if (!oldValueInit)
            {
                backup_value = result;
                oldValueInit = true;
            }

            return result;
        }

        public void SetType(string dtw)
        {
            
            if (dtw.Contains("enum"))
            {
                type = TPropEditType.PETenum;
                enumArray = dtw.Split(';').ToList();
                enumArray.RemoveAt(0);

                for (int i = 0; i < enumArray.Count; i++)
                {
                    //Console.WriteLine("Enum value: " + enumArray[i]);
                }
            }
            else if (dtw.Contains("bool"))
            {
                type = TPropEditType.PETbool;
            }
            else if (dtw.Contains("string"))
            {
                type = TPropEditType.PETstring;
            }
            else if (dtw.Contains("int"))
            {
                type = TPropEditType.PETint;
            }
            else if (dtw.Contains("float"))
            {
                type = TPropEditType.PETfloat;
            }
            else if (dtw.Contains("raw"))
            {
                type = TPropEditType.PETraw;
            }
            else if (dtw.Contains("vec3"))
            {
                type = TPropEditType.PETvec3;
            }
            else if (dtw.Contains("color"))
            {
                type = TPropEditType.PETcolor;
            }
            else
            {
                type = TPropEditType.PETint;
            }
        }

        public string GroupName
        {
            get
            {
                return groupName;
            }

            set
            {
                groupName = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public void SetValue(string v)
        {
            value = v;

            if (!oldValueInit)
            {
                backup_value = v;
                oldValueInit = true;
            }
        }

        public string ShowBackupValue()
        {
            string result = "";

            if (type == TPropEditType.PETbool)
            {
                if (backup_value == "0") result = "FALSE"; else result = "TRUE";
            }
            else
            if (type == TPropEditType.PETenum)
            {
                int index = 0;

                Int32.TryParse(backup_value, out index);

                ///Console.WriteLine("Get Enum with index {0}. Result is {1} Value is {2}", index, enumArray[index], backup_value);
                result = enumArray[index];

            }
            else
            {
                result = backup_value;
            }


            return result;
        }
    }
}
