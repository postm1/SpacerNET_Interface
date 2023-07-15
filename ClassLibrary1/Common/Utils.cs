using SpacerUnion.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SpacerUnion
{
    public class Constants
    {
        public const string SPACER_VERSION = "0.39";


        public const string FILE_FILTER_OPEN_ZEN = "Compiled ZEN (*.zen)|*.zen|Uncompiled ZEN (*.zen)|*.zen";
        public const string FILE_FILTER_OPEN_VOBTREE = "VobTree ZEN (*.zen)|*.zen";
        public const string FILE_FILTER_OPEN_MESH = "Mesh-File (*.3ds)|*.3ds|All Files(*.*)|*.*||";
        public const string FILE_FILTER_MERGE_VOBS = "World(*.zen)|*.zen|All Files(*.*)|*.*||";
        public const string FILE_FILTER_SAVE_ZEN = "Compiled ZEN (ascii)|*.zen|Uncompiled ZEN (ascii)|*.zen|Compiled ZEN (binary safe)|*.zen";
        public const string FILE_FILTER_SAVE_ZEN_UNC = "Uncompiled ZEN (ascii)|*.zen";
        public const string FILE_FILTER_SAVE_ONLY_MESH = "COMPILED MESH |*.MSH";
        public const string FILE_FILTER_ALL = "All files (*.)|";

        public const string TAG_FOLDER = "folder";

    }

    class FolderEntry
    {
        public string parent;
        public TreeNode node;
    }


    // Класс различных функций
    public class Utils
    {
        public static void SortListBox(ListBox lstBox)
        {
            ArrayList q = new ArrayList();
            foreach (object o in lstBox.Items)
            {
                q.Add(o);
            }
            q.Sort();

            lstBox.Items.Clear();
            foreach (object o in q)
            {
                lstBox.Items.Add(o);
            }
        }

        public static void WriteToFile(string str)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"./system/_SpacerNetErrors.txt", true))
            {
                file.WriteLine(str);
                file.Close();
            }
        }

        public static string ToHex(uint num)
        {
            return  String.Format("0x{0:X}", num);
        }

        public static void Error(string msg)
        {
            DateTime now = DateTime.Now;

            msg = now.ToString("dd.MM.yyyy HH:mm:ss") + " C#: " + msg;
            ConsoleEx.WriteLineRed(msg);
            Utils.WriteToFile(msg);
        }


        public static bool IsPathWorkFolder(string path)
        {
            bool result = false;

            path = path.Replace('\\', '/');

            Regex reg = new Regex("(_work/data/.*)", RegexOptions.IgnoreCase | RegexOptions.Compiled);

            MatchCollection matches = reg.Matches(path);
            if (matches.Count != 0)
            {
                //ConsoleEx.WriteLineRed("Real file part: " + matches[0].Groups[0].Value);
               // ConsoleEx.WriteLineRed("StartupPath: " + Application.StartupPath);

                string filePath = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\")).Replace('\\', '/');
                //ConsoleEx.WriteLineRed("First combine: " + filePath);

                filePath = filePath + matches[0].Groups[0].Value;

                //ConsoleEx.WriteLineRed("Last combine: " +  filePath);
                //ConsoleEx.WriteLineRed("path: " + path);
                result = filePath.ToUpper() == path.ToUpper();

            }

            return result;  
        }

        // задает начальный путь для открытия/сохранения файлов
        public static string GetInitialDirectory(string path)
        {
            string result = String.Empty;

            if (path != "")
            {
                //MessageBox.Show(path);
                result = Path.GetDirectoryName(@path + @"/");
            }
            else
            {
                result = @Directory.GetCurrentDirectory() + @"../_WORK/DATA/";
            }

            return result;
        }

        // удаляет ёбаные \\ из пути, иначе COptios считает some\newFolder = \n и пиздец
        public static string FixPath(string path)
        {
            string fixedPath = path.Trim().Replace('\\', '/');
            return fixedPath;
        }


        public static string GetZenName(string zenName)
        {
            string time = DateTime.Now.ToString("yyyy_MM_dd HH-mm-ss");

            Imports.Stack_PushString("addDatePrefix");

            int addPrefx = Imports.Extern_GetSetting();




            zenName = Path.GetFileName(zenName).ToUpper();


            if (zenName.Contains(".ZEN"))
            {
                zenName = zenName.Replace(".ZEN", "");
            }

            //ConsoleEx.WriteLineRed("First get: " + zenName);

            var match = Regex.Match(zenName, @"(^.*)_\d\d\d\d_\d\d_\d\d\s+\d\d-\d\d-\d\d.*");

            if (match.Groups.Count > 1)
            {
                zenName = match.Groups[1].Value;
            }

            //ConsoleEx.WriteLineRed(zenName);

            if (addPrefx != 0)
            {
                zenName = zenName + "_" + time + ".ZEN";
            }


            return zenName;
        }

        public static bool IsOnlyLatin(string text)
        {
            return Regex.IsMatch(text, @"^[a-zA-Z0-9_\-\=\.\,\;\:\\\/\(\)\]\[ ]+$");
        }

        public static bool IsOptionActive(string text)
        {
            Imports.Stack_PushString(text);

            return Convert.ToBoolean(Imports.Extern_GetSetting());
        }

        public static bool IsNumberInput(char input, bool isFloat, bool isNegative)
        {
            if (!isNegative && input == '-')
            {
                return false;
            }

            if (!isFloat && input == '.')
            {
                return false;
            }

            if (char.IsDigit(input) || input == '.' || input == '-')
            {
                return true;
            }

            return false;
        }

        public static String sha256_hash(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }


    }

    public static class Helper
    {
        public static void EnableDoubleBuffering(Control control)
        {
            SendMessage(control.Handle, TVM_SETEXTENDEDSTYLE, (IntPtr)TVS_EX_DOUBLEBUFFER, (IntPtr)TVS_EX_DOUBLEBUFFER);
        }

        private const int TVM_SETEXTENDEDSTYLE = 0x1100 + 44;
        private const int TVM_GETEXTENDEDSTYLE = 0x1100 + 45;
        private const int TVS_EX_DOUBLEBUFFER = 0x0004;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
    }
}

