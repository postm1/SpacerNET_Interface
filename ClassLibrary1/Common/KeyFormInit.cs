using SpacerUnion.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion.Windows
{
    public partial class KeysForm : Form
    {

        public static Dictionary<int, int> keysGothic = new Dictionary<int, int>()
        {
            // A            B          C           D           E
            {65, 0x1E}, {66, 0x30}, {67, 0x2E}, {68, 0x20},  {69, 0x12},

            // F            G         H          I              J
            {70, 0x21}, {71, 0x22}, {72, 0x23}, {73, 0x17},  {74, 0x24},

            // K            L         M         N             O
            {75, 0x25}, {76, 0x26}, {77, 0x32}, {78, 0x31},  {79, 0x18},

            // P            Q        R         S          T
            {80, 0x19}, {81, 0x10}, {82, 0x13}, {83, 0x1F},  {84, 0x14},

            // U           V        W        X                  Y         Z
            {85, 0x16}, {86, 0x2F}, {87, 0x11}, {88, 0x2D},  {89, 0x15}, {90, 0x2C},

            //SPACE      
            {32, 0x39},  {46, 0xD3},

            // 0 1-9
            {48, 0x0B},  {49, 0x02}, {50, 0x03}, {51, 0x04},{52, 0x05},{53, 0x06},{54, 0x07},{55, 0x08},{56, 0x09},{57, 0x0A},


            // arrows left down right up
            {37, 0xCB},  {40, 0xD0}, {39, 0xCD}, {38, 0xC8},

            //F1-F12
            {112, 59}, {113, 60},{114, 61},{115, 62},{116, 63},
            {117, 64},{118, 65},{119, 66},{120, 67},{121, 68},
            {122, 87},{123, 88},

            //NUM
            {96, 82}, {97, 0x4F},{98, 0x50},{99, 0x51},{100, 0x4B},
            {101, 0x4C},{102, 0x4D},{103, 0x47},{104, 0x48},{105, 0x49},

            // modifiest shift/ctrl/alt/
            {16, 1}, {17, 1}, {18, 1 },

            //modifiest rshift/rctrl/ralt/,
            //{16, 1}, {17, 1}, {18, 1 },

            // - = [ ]
            {189, 12}, {187, 13}, {219, 26 }, {221, 27 },

            // ~ ; ' \
            {192, 41}, {186, 39}, {222, 40 }, {220, 43 },

            // < > ?
            {188, 51}, {190, 52}, {191, 53},

            //NUMPAD - + / *
            {109, 74}, {107, 78 }, {111, 181}, {106, 55},
            
            //Insert/home/page up, down/End
            {45, 0xD2}, {36, 0xC7 }, {33, 0xC9}, {34, 0xD1}, {35, 0xCF},
        };

        enum KeyMod
        {
            LControl = 2 << 0,
            Alt = 2 << 1,
            LShift = 2 << 2,
            RShift = 2 << 3,
            RAlt = 2 << 4,
            RCtrl = 2 << 5
        };

        class KeyEntry
        {
            public int key;
            public bool shift;
            public bool control;
            public bool alt;

            public bool r_shift;
            public bool r_control;
            public bool r_alt;

            public int mod;
            public int union_key;


            public void Reset()
            {
                key = 0;
                shift = false;
                control = false;
                alt = false;
                r_shift = false;
                r_control = false;
                r_alt = false;
                mod = 0;
                union_key = 0;
            }


            // если введены 2 и более только клафиш shift/ctrl/alt
            public bool IsOnlyModKeys()
            {
                bool result = false;

                int count = 0;

                //ConsoleEx.WriteLineRed("IsOnlyModKeys: " + key);
                if (IsModKey(key))
                {
                    if (alt) count++;
                    if (r_alt) count++;
                    if (shift) count++;
                    if (r_shift) count++;
                    if (control) count++;
                    if (r_control) count++;


                    if (count >= 2) result = true;
                }


                return result;
            }
            public string FixShowChar(int val)
            {
                string s = ((char)val).ToString();

                //ConsoleEx.WriteLineGreen("FixShowChar, Key int: " + val);

                if ((char)val == ' ') s = Localizator.Get("WIN_KEYSBIND_KEY_SPACE");
                if (val == 37) s = Localizator.Get("WIN_KEYSBIND_KEY_ARROW_LEFT");
                if (val == 38) s = Localizator.Get("WIN_KEYSBIND_KEY_ARROW_UP");
                if (val == 39) s = Localizator.Get("WIN_KEYSBIND_KEY_ARROW_RIGHT");
                if (val == 40) s = Localizator.Get("WIN_KEYSBIND_KEY_ARROW_DOWN");


                if (val == 16) s = "LSHIFT";
                if (val == 17) s = "LCTRL";
                if (val == 18) s = "LALT";


                if (r_shift && val == 16)
                {
                    s = "RSHIFT";
                }

                if (r_control && val == 17)
                {
                    s = "RCTRL";
                }

                if (r_alt && val == 18)
                {
                    s = "RALT";
                }




                if (val == 46) s = "DELETE";
                if (val == 36) s = "HOME";
                if (val == 45) s = "INSERT";

                if (val == 33) s = "PAGE_UP";
                if (val == 34) s = "PAGE_DOWN";
                if (val == 35) s = "END";

                if (val == 189) s = "-";
                if (val == 187) s = "=";
                if (val == 219) s = "[";
                if (val == 221) s = "]";

                if (val == 192) s = "~";
                if (val == 186) s = ";";
                if (val == 222) s = "'";
                if (val == 220) s = "\\";

                if (val == 188) s = "<";
                if (val == 190) s = ">";
                if (val == 191) s = "/";

                if (val == 109) s = "NUMPAD -";
                if (val == 107) s = "NUMPAD +";
                if (val == 111) s = "NUMPAD /";
                if (val == 106) s = "NUMPAD *";


                if (val >= 112 && val <= 123) s = "F" + (val-111).ToString();
                if (val >= 96 && val <= 105) s = "NUMPAD" + (val - 96).ToString();


                //ConsoleEx.WriteLineGreen("Char to Fix: " + val + " " + (char)val + " " + s);

                return s;
            }

            public void SetData(KeyEventArgs e)
            {

                Reset();

                this.alt = e.Alt;
                this.shift = e.Shift;
                this.control = e.Control;
                this.key = e.KeyValue;

                
                //ConsoleEx.WriteLineRed("SetData KeyValue: " + e.KeyValue);
               

                if (this.control && System.Windows.Input.Keyboard.IsKeyDown(System.Windows.Input.Key.RightCtrl))
                {
                   // ConsoleEx.WriteLineRed("RCTRL");

                    this.r_control = true;
                    this.control = false;
                }

                if (this.shift && System.Windows.Input.Keyboard.IsKeyDown(System.Windows.Input.Key.RightShift))
                {
                    //ConsoleEx.WriteLineRed("RSHIFT");
                    this.r_shift = true;
                    this.shift = false;
                }

                if (this.alt && System.Windows.Input.Keyboard.IsKeyDown(System.Windows.Input.Key.RightAlt))
                {

                    this.r_alt = true;
                    this.alt = false;
                   // ConsoleEx.WriteLineRed("RALT");
                }
            }

            public void PackToUnion()
            {
                mod = 0;

                if (keysGothic.ContainsKey(key))
                {
                    union_key = keysGothic[key];
                }
                else
                {
                    ConsoleEx.WriteLineRed("not key found: " + key);
                    union_key = 1;
                }

                if (control) mod |= (int)KeyMod.LControl;
                if (shift) mod |= (int)KeyMod.LShift;
                if (alt) mod |= (int)KeyMod.Alt;

                if (r_control) mod |= (int)KeyMod.RCtrl;
                if (r_shift) mod |= (int)KeyMod.RShift;
                if (r_alt) mod |= (int)KeyMod.RAlt;
            }

            public bool IsModKey(int key)
            {
                return (key == 16 || key == 17 || key == 18);
            }

            public string GetKeysAsString()
            {
                StringBuilder str = new StringBuilder();

                if (!IsModKey(key))
                {
                    if (shift) str.Append("LSHIFT + ");
                    if (control) str.Append("LCTRL + ");
                    if (alt) str.Append("LALT + ");

                    if (r_shift) str.Append("RSHIFT + ");
                    if (r_control) str.Append("RCTRL + ");
                    if (r_alt) str.Append("RALT + ");

                    str.Append(FixShowChar(key));
                }
                else if (!IsOnlyModKeys())
                {
                    if (shift) str.Append("LSHIFT");
                    if (control) str.Append("LCTRL");
                    if (alt) str.Append("LALT");


                    if (r_shift) str.Append("RSHIFT");
                    if (r_control) str.Append("RCTRL");
                    if (r_alt) str.Append("RALT");
                }
                else
                {
                    if (shift) str.Append("LSHIFT + ");
                    if (control) str.Append("LCTRL + ");
                    if (alt) str.Append("LALT + ");

                    if (r_shift) str.Append("RSHIFT + ");
                    if (r_control) str.Append("RCTRL + ");
                    if (r_alt) str.Append("RALT + ");
                }

               // ConsoleEx.WriteLineGreen("GetKeysAsString: " + str.ToString());
                return str.ToString();
            }


            public string SolveString(string input)
            {
                StringBuilder str = new StringBuilder();


                int index = input.IndexOf('_');

                string mod = input.Substring(0, index);
                string key = input.Substring(index + 1, input.Length - index - 1);

                int num = Convert.ToInt32(key);
                int modVal = Convert.ToInt32(mod);

                if (num == 1)
                {
                    if ((modVal & (int)KeyMod.LControl) != 0) str.Append("LCTRL");
                    if ((modVal & (int)KeyMod.Alt) != 0) str.Append("LALT");
                    if ((modVal & (int)KeyMod.LShift) != 0) str.Append("LSHIFT");

                    if ((modVal & (int)KeyMod.RCtrl) != 0) str.Append("RCTRL");
                    if ((modVal & (int)KeyMod.RAlt) != 0) str.Append("RALT");
                    if ((modVal & (int)KeyMod.RShift) != 0) str.Append("RSHIFT");
                }
                else
                {
                    if ((modVal & (int)KeyMod.LControl) != 0)
                    {
                        str.Append("LCTRL + ");
                    }

                    if ((modVal & (int)KeyMod.Alt) != 0)
                    {
                        str.Append("LALT + ");
                    }

                    if ((modVal & (int)KeyMod.LShift) != 0)
                    {
                        str.Append("LSHIFT + ");
                    }


                    if ((modVal & (int)KeyMod.RCtrl) != 0)
                    {
                        str.Append("RCTRL + ");
                    }

                    if ((modVal & (int)KeyMod.RAlt) != 0)
                    {
                        str.Append("RALT + ");
                    }

                    if ((modVal & (int)KeyMod.RShift) != 0)
                    {
                        str.Append("RSHIFT + ");
                    }

                    char val = (char)keysGothic.Where(x => x.Value == num).Select(pair => pair.Key).FirstOrDefault();

                    str.Append(FixShowChar(val));

                }
                return str.ToString();

            }
        }



        private void InitRows()
        {
            string[] row;

            row = new string[] { "CAMERA_TRANS_FORWARD", Localizator.Get("CAMERA_TRANS_FORWARD"), "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "CAMERA_TRANS_BACKWARD", Localizator.Get("CAMERA_TRANS_BACKWARD"), "" };
            dataGridKeys.Rows.Add(row);

            

            row = new string[] { "CAMERA_TRANS_LEFT", Localizator.Get("CAMERA_TRANS_LEFT"), "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "CAMERA_TRANS_RIGHT", Localizator.Get("CAMERA_TRANS_RIGHT"), "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "CAMERA_TRANS_UP", Localizator.Get("CAMERA_TRANS_UP"), "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "CAMERA_TRANS_DOWN", Localizator.Get("CAMERA_TRANS_DOWN"), "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "CAM_SPEED_X10", Localizator.Get("CAM_SPEED_X10"), "" };
            dataGridKeys.Rows.Add(row);


            row = new string[] { "CAM_SPEED_MINUS_10", Localizator.Get("CAM_SPEED_MINUS_10"), "" };
            dataGridKeys.Rows.Add(row);


            row = new string[] { "VOB_COPY", Localizator.Get("VOB_COPY"), "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_INSERT", Localizator.Get("VOB_INSERT"), "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_CUT", Localizator.Get("VOB_CUT"), "" };
            dataGridKeys.Rows.Add(row);



            row = new string[] { "VOB_FLOOR", Localizator.Get("VOB_FLOOR"), "" };
            dataGridKeys.Rows.Add(row);



            row = new string[] { "VOB_RESET_AXIS", Localizator.Get("VOB_RESET_AXIS"), "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_DELETE", Localizator.Get("VOB_DELETE"), "" };
            dataGridKeys.Rows.Add(row);


            row = new string[] { "VOB_RESTORE_POS", Localizator.Get("CONTEXTMENU_TREE_RESTORE_POS"), "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_TRANSLATE", Localizator.Get("VOB_TRANSLATE"), "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_ROTATE", Localizator.Get("VOB_ROTATE"), "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_ONEMODE", Localizator.Get("VOB_ONEMODE"), "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "WP_TOGGLE", Localizator.Get("WP_TOGGLE"), "" };
            dataGridKeys.Rows.Add(row);


            row = new string[] { "VOB_DISABLE_SELECT", Localizator.Get("VOB_DISABLE_SELECT"), "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_NEAR_CAM", Localizator.Get("VOB_NEAR_CAM"), "" };
            dataGridKeys.Rows.Add(row);


            row = new string[] { "VOB_TRANS_FORWARD", Localizator.Get("VOB_TRANS_FORWARD"), "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "VOB_TRANS_BACKWARD", Localizator.Get("VOB_TRANS_BACKWARD"), "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "VOB_TRANS_LEFT", Localizator.Get("VOB_TRANS_LEFT"), "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "VOB_TRANS_RIGHT", Localizator.Get("VOB_TRANS_RIGHT"), "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_TRANS_UP", Localizator.Get("VOB_TRANS_UP"), "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "VOB_TRANS_DOWN", Localizator.Get("VOB_TRANS_DOWN"), "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_SPEED_X10", Localizator.Get("VOB_SPEED_X10"), "" };
            dataGridKeys.Rows.Add(row);


            row = new string[] { "VOB_SPEED_MINUS_10", Localizator.Get("VOB_SPEED_MINUS_10"), "" };
            dataGridKeys.Rows.Add(row);



            row = new string[] { "VOB_ROT_VERT_LEFT", Localizator.Get("VOB_ROT_VERT_LEFT"), "" };
            dataGridKeys.Rows.Add(row);


            row = new string[] { "VOB_ROT_VERT_RIGHT", Localizator.Get("VOB_ROT_VERT_RIGHT"), "" };
            dataGridKeys.Rows.Add(row);

            


            row = new string[] { "VOB_ROT_FORWARD", Localizator.Get("VOB_ROT_FORWARD"), "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "VOB_ROT_BACK", Localizator.Get("VOB_ROT_BACK"), "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_ROT_LEFT", Localizator.Get("VOB_ROT_LEFT"), "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_ROT_RIGHT", Localizator.Get("VOB_ROT_RIGHT"), "" };
            dataGridKeys.Rows.Add(row);
            



            row = new string[] { "VOBLIST_COLLECT", Localizator.Get("VOBLIST_COLLECT"), "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "WP_CREATEFAST", Localizator.Get("WP_CREATEFAST"), "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "WIN_HIDEALL", Localizator.Get("WIN_HIDEALL"), "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "GAME_MODE", Localizator.Get("GAME_MODE"), "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "OPEN_CONTAINER", Localizator.Get("OPEN_CONTAINER"), "" };
            dataGridKeys.Rows.Add(row);


            row = new string[] { "TOGGLE_VOBS", Localizator.Get("TOGGLE_VOBS"), "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "TOGGLE_WAYNET", Localizator.Get("TOGGLE_WAYNET"), "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "TOGGLE_HELPERS", Localizator.Get("TOGGLE_HELPERS"), "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "TOGGLE_BBOX", Localizator.Get("TOGGLE_BBOX"), "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "TOGGLE_INVIS", Localizator.Get("TOGGLE_INVIS"), "" };
            dataGridKeys.Rows.Add(row);



            row = new string[] { "LIGHT_RAD_INC", Localizator.Get("LIGHT_RAD_INC"), "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "LIGHT_RAD_DEC", Localizator.Get("LIGHT_RAD_DEC"), "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "LIGHT_RAD_ZERO", Localizator.Get("LIGHT_RAD_ZERO"), "" };
            dataGridKeys.Rows.Add(row);



            row = new string[] { "TOOL_BBOX_CHANGE", Localizator.Get("TOOL_BBOX_CHANGE"), "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "TOOL_BBOX_MAXS", Localizator.Get("TOOL_BBOX_MAXS"), "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "TOOL_BBOX_MINS", Localizator.Get("TOOL_BBOX_MINS"), "" };
            dataGridKeys.Rows.Add(row);
        }
    }

}
