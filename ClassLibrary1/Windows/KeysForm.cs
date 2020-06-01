using SpacerUnion.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion.Windows
{
    public partial class KeysForm : Form
    {
        public KeysForm()
        {
            InitializeComponent();
        }


        enum KeyMod
        {
            LControl = 2 << 0,
            Alt = 2 << 1,
            LShift = 2 << 2,
            RShift = 2 << 3
        };


        private Dictionary<int, int> keysGothic = new Dictionary<int, int>()
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

            //SPACE      LSHIFT
            {32, 0x39}, {160, 0x2A},

            // 0 1-9
            {48, 0x0B},  {49, 0x02}, {50, 0x03}, {51, 0x04},{52, 0x05},{53, 0x06},{54, 0x07},{55, 0x08},{56, 0x09},{57, 0x0A},


            // arrows left down right up
            {37, 0xCB},  {40, 0xD0}, {39, 0xCD}, {38, 0xC8}
        };


        public int key;
        public bool shift;
        public bool control;
        public bool alt;
        public char name;


        private void dataGridKeys_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) != 0)
            {

            }
        }

        public string ShowKeys()
        {
            StringBuilder str = new StringBuilder();

            if (shift) str.Append("LSHIFT + ");
            if (control) str.Append("LCTRL + ");
            if (alt) str.Append("LALT + ");

            if (name == ' ')
            {
                str.Append("Пробел");
            }
            else
            {
                str.Append(name);
            }


            return str.ToString();
        }

        public string GetSendString()
        {
            StringBuilder str = new StringBuilder();

            if (control) str.Append("1"); else str.Append("0");
            if (alt) str.Append("1"); else str.Append("0");
            if (shift) str.Append("1"); else str.Append("0");

            str.Append("0");

            if (keysGothic.ContainsKey(key))
            {
                str.Append(keysGothic[key].ToString());
            }
            else
            {
                str.Append("0");
            }
            

            return str.ToString();
        }

        private void dataGridKeys_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Back || e.KeyData == Keys.CapsLock || dataGridKeys.CurrentRow.Cells[0].Value == null)
            {
                return;
            }

            key = e.KeyValue;
            shift = e.Shift;
            control = e.Control;
            alt = e.Alt;

            name = (char)e.KeyData;

            if (dataGridKeys.CurrentCell != null && (dataGridKeys.CurrentCell.ColumnIndex == 2))
            {
                dataGridKeys.CurrentCell.Value = ShowKeys();
            }

            string keyString = GetSendString();
            string keyRow = dataGridKeys.CurrentRow.Cells[0].Value.ToString();



            if (dataGridKeys.CurrentRow.Cells[0].Value != null)
            {
                ConsoleEx.WriteLineRed("C# key: " + e.KeyValue);

                Imports.Extern_SendNewKeyPreset(Marshal.StringToHGlobalAnsi(keyRow), Marshal.StringToHGlobalAnsi(keyString));

                SpacerNET.FreeStrings();
            }
           

            e.Handled = true;
            e.SuppressKeyPress = false;
        }

        private string SolveString(string input)
        {
            StringBuilder str = new StringBuilder();

            int index = input.IndexOf('_');

            string mod = input.Substring(0, index);
            string key = input.Substring(index + 1, input.Length - index - 1);


            ConsoleEx.WriteLineRed(String.Format("mod {0}, key {1}", mod, key));

            int modVal = Convert.ToInt32(mod);

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

            int num = Convert.ToInt32(key);

            char val = (char)keysGothic.Where(x => x.Value == num).Select(pair => pair.Key).FirstOrDefault();

            if (val == ' ')
            {
                str.Append("Пробел");
            }
            else
            {
                str.Append(val);
            }
            

            return str.ToString();

        }

        private void KeysForm_Shown(object sender, EventArgs e)
        {

            string[] row = new string[] { "CAMERA_TRANS_FORWARD", "Камера (вперед)", "" };
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


            row = new string[] { "VOB_COPY", "Скопировать воб", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_INSERT", "Вставить воб", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_CUT", "Вырезать воб (смена родителя)", "" };
            dataGridKeys.Rows.Add(row);


            row = new string[] { "VOB_NEAR_CAM", "Переместить воб перед камерой", "" };
            dataGridKeys.Rows.Add(row);


            row = new string[] { "VOB_TRANSLATE", "Инструмент перемещение", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_ROTATE", "Инструмент вращение", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "WP_TOGGLE", "Переключить соединение между вейпоинтами", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_DISABLE_SELECT", "Снять выделение с воба", "" };
            dataGridKeys.Rows.Add(row);

            row = new string[] { "VOB_FLOOR", "Прижать воб к полу", "" };
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


            row = new string[] { "SPEED_X10", "Увеличить скорость полета камеры в 10 раз", "" };
            dataGridKeys.Rows.Add(row);
            
            dataGridKeys.Columns[0].Visible = false;

            foreach (DataGridViewRow entry in dataGridKeys.Rows)
            {
                if (entry.Cells[0].Value != null)
                {
                    string currentKey = entry.Cells[0].Value.ToString();

                    if (currentKey.Length > 0)
                    {
                        string gotString = Marshal.PtrToStringAnsi(Imports.Extern_GetIniKey(Marshal.StringToHGlobalAnsi(currentKey)));

                        if (gotString.Length > 0)
                        {
                            ConsoleEx.WriteLineRed("gotString: " + gotString);
                            entry.Cells[2].Value = SolveString(gotString);
                        }

                    }
                }
                
                
            }

            SpacerNET.FreeStrings();

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void KeysForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
