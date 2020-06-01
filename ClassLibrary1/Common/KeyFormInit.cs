using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion.Windows
{
    public partial class KeysForm : Form
    {

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


        public string FixChars(int val)
        {
            string s = ((char)val).ToString();

            if ((char)val == ' ')
            {
                s = "Пробел";
            }

            if (val == 37)
            {
                s = "Стрелка влево";
            }

            if (val == 39)
            {
                s = "Стрелка вправо";
            }

            if (val == 38)
            {
                s = "Стрелка вверх";
            }

            if (val == 40)
            {
                s = "Стрелка вниз";
            }

            return s;
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

            row = new string[] { "SPEED_X10", "Увеличить скорость полета камеры в 10 раз", "" };
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
        }
    }

}
