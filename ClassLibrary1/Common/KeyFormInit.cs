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
        };

        enum KeyMod
        {
            LControl = 2 << 0,
            Alt = 2 << 1,
            LShift = 2 << 2,
            RShift = 2 << 3
        };

        class KeyEntry
        {
            public int key;
            public bool shift;
            public bool control;
            public bool alt;

            public int mod;
            public int union_key;

            public void Reset()
            {
                key = 0;
                shift = false;
                control = false;
                alt = false;
                mod = 0;
                union_key = 0;
            }

            public string FixShowChar(int val)
            {
                string s = ((char)val).ToString();

                if ((char)val == ' ') s = "Пробел";
                if (val == 37) s = "Стрелка влево";
                if (val == 38) s = "Стрелка вверх";
                if (val == 39) s = "Стрелка вправо";
                if (val == 40) s = "Стрелка вниз";
                if (val == 16) s = "LSHIFT";
                if (val == 17) s = "LCTRL";
                if (val == 18) s = "LALT";
                if (val == 46) s = "DELETE";


                if (val >= 112 && val <= 123) s = "F" + (val-111).ToString();


                
                ConsoleEx.WriteLineGreen("Char to Fix: " + val + " " + (char)val + " " + s);

                return s;
            }

            public void SetData(bool alt, bool shift, bool ctrl, int key)
            {
                this.alt = alt;
                this.shift = shift;
                this.control = ctrl;
                this.key = key;
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
                    ConsoleEx.WriteLineRed("Нет клавиши для кода: " + key);
                    union_key = 1;
                }

                if (control) mod |= (int)KeyMod.LControl;
                if (shift) mod |= (int)KeyMod.LShift;
                if (alt) mod |= (int)KeyMod.Alt;

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
                    str.Append(FixShowChar(key));
                }
                else
                {
                    if (shift) str.Append("LSHIFT");
                    if (control) str.Append("LCTRL");
                    if (alt) str.Append("LALT");
                }

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

                    char val = (char)keysGothic.Where(x => x.Value == num).Select(pair => pair.Key).FirstOrDefault();

                    str.Append(FixShowChar(val));

                }
                return str.ToString();

            }
        }





        


        private void InitRows()
        {
            string[] row;

            row = new string[] { "CAMERA_TRANS_FORWARD", "Камера (вперед)", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "CAMERA_TRANS_BACKWARD", "Камера (назад)", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "CAMERA_TRANS_RIGHT", "Камера (вправо)", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "CAMERA_TRANS_LEFT", "Камера (влево)", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "CAMERA_TRANS_UP", "Камера (вверх)", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "CAMERA_TRANS_DOWN", "Камера (вниз)", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "CAM_SPEED_X10", "Увеличить скорость полета камеры в 10 раз", "" };
            dataGridKeys.Rows.Add(row);


            row = new string[] { "CAM_SPEED_MINUS_10", "Уменьшить скорость полета камеры в 10 раз", "" };
            dataGridKeys.Rows.Add(row);


            row = new string[] { "VOB_COPY", "Скопировать воб", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_INSERT", "Вставить воб", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_CUT", "Вырезать воб (смена родителя)", "" };
            dataGridKeys.Rows.Add(row);


            row = new string[] { "VOB_TRANSLATE", "Инструмент перемещение", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_ROTATE", "Инструмент вращение", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "WP_TOGGLE", "Переключить соединение между вейпоинтами", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_DISABLE_SELECT", "Снять выделение с воба", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_NEAR_CAM", "Переместить воб перед камерой", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_FLOOR", "Прижать воб к полу", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_DELETE", "Удалить воб", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_RESET_AXIS", "Сбросить направление воба по осям", "" };
            dataGridKeys.Rows.Add(row);


            row = new string[] { "VOB_TRANS_FORWARD", "Перемещение воба (вперед)", "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "VOB_TRANS_BACKWARD", "Перемещение воба (назад)", "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "VOB_TRANS_LEFT", "Перемещение воба (влево)", "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "VOB_TRANS_RIGHT", "Перемещение воба (вправо)", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_TRANS_UP", "Перемещение воба (вверх)", "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "VOB_TRANS_DOWN", "Перемещение воба (вниз)", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_SPEED_X10", "Увеличить скорость перемещения/вращения воба в 10 раз", "" };
            dataGridKeys.Rows.Add(row);


            row = new string[] { "VOB_SPEED_MINUS_10", "Уменьшить скорость перемещения/вращения воба в 10 раз", "" };
            dataGridKeys.Rows.Add(row);


            row = new string[] { "VOB_ROT_VERT_RIGHT", "Вращение воба вокруг верт. оси (по часовой стрелке)", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_ROT_VERT_LEFT", "Вращение воба вокруг верт. оси (против часовой стрелки)", "" };
            dataGridKeys.Rows.Add(row);


            row = new string[] { "VOB_ROT_FORWARD", "Вращение воба от себя", "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "VOB_ROT_BACK", "Вращение воба на себя", "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "VOB_ROT_RIGHT", "Вращение воба вправо", "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "VOB_ROT_LEFT", "Вращение воба влево", "" };
            dataGridKeys.Rows.Add(row);



            row = new string[] { "VOBLIST_COLLECT", "Собрать вобы в окно Контейнер вобов", "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "WP_CREATEFAST", "Создать вейпоинт по кнопке", "" };
            dataGridKeys.Rows.Add(row);
            row = new string[] { "WIN_HIDEALL", "Скрыть все окна", "" };
            dataGridKeys.Rows.Add(row);

        }
    }

}
