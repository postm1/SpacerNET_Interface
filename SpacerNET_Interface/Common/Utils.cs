using SpacerUnion.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
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
        public const string SPACER_VERSION = "1.58";


        public const string FILE_FILTER_OPEN_ZEN = "Compiled ZEN (*.zen)|*.zen|Uncompiled ZEN (*.zen)|*.zen";
        public const string FILE_FILTER_OPEN_VOBTREE = "VobTree ZEN (*.zen)|*.zen";
        public const string FILE_FILTER_OPEN_MESH = "Mesh-File (*.3ds)|*.3ds|All Files (*.*)|*.*";

        public const string FILE_FILTER_MERGE_VOBS = "World (*.zen)|*.zen|All Files (*.*)|*.*";
        public const string FILE_FILTER_SAVE_ZEN = "Compiled ZEN (ascii)|*.zen|Uncompiled ZEN (ascii)|*.zen|Compiled ZEN (binary safe)|*.zen";
        public const string FILE_FILTER_SAVE_ZEN_UNC = "Uncompiled ZEN (ascii)|*.zen";
        public const string FILE_FILTER_SAVE_ONLY_MESH = "COMPILED MESH|*.msh";

        public const string FILE_FILTER_ALL = "All files (*.*)|*.*";
        public const string FILE_FILTER_TXT = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
        public const string FILE_FILTER_HTML = "HTML file (*.html)|*.html|All files (*.*)|*.*";


 
        public const string FILE_PATH_WORK_DATA = "/_WORK/DATA";
        public const string FILE_PATH_SAVE_VOB_MESH = "/_WORK/DATA/MESHES/";

        public const string TAG_FOLDER = "folder";

    }

    class FolderEntry
    {
        public string parent;
        public TreeNode node;
    }


    // various helper functions
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

        public static bool IsSymbolic(string path)
        {
            FileInfo pathInfo = new FileInfo(path);
            return pathInfo.Attributes.HasFlag(FileAttributes.ReparsePoint);
        }

        public static bool IsPathWorkFolder(string path)
        {
            bool result = false;

            Imports.Stack_PushString("ignorePathWorkCheck");

            int ignorePathWorkCheck = Imports.Extern_GetSetting();

            if (ignorePathWorkCheck != 0)
            {
                return true;
            }

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

            if (IsSymbolic(path))
            {
                return true;
            }

            return result;  
        }

        // sets the directory the open / save dialogs start in
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

        // removes the back slashes from a path, otherwise COptios reads some\newFolder as a new line and breaks
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


        public static bool IsFoundAnyVEC3(string text)
        {
            return Regex.IsMatch(text, @"^[0-9\,\.\- ]+$");
        }

        public static bool IsOnlyLatin(string text)
        {
            return Regex.IsMatch(text, @"^[a-zA-Z0-9_\-\+\=\.\,\;\:\\\/\(\)\]\[\#\! ]+$");
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

        public static bool IsFloatOrInt(string value)
        {
            int intValue;
            float floatValue;
            return Int32.TryParse(value, out intValue) || float.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out floatValue);
        }

        public static bool IsInt(string value)
        {
            int intValue;
            return Int32.TryParse(value, out intValue);
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


        public static void SetCopyText(string text)
        {
            Clipboard.SetText(text);

            Imports.Stack_PushString(Localizator.Get("COPYBUFFER") + ": " + text);

            Imports.Extern_PrintGreen();

            ConsoleEx.WriteLineYellow(text);
        }

        public static bool IsArrayIsFullNumbers(string[] stringArray)
        {
            bool allAreNumbers = true;

            foreach (string str in stringArray)
            {
                // try to turn the string into a number
                if (!double.TryParse(str, out _))
                {
                    allAreNumbers = false;
                    break; // leave the loop as soon as a non numeric value is found
                }
            }

            return allAreNumbers;
        }

        public static int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

        public static float Clamp(float value, float min, float max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

        public static string CapitalizeFirstLetter(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return char.ToUpper(input[0]) + input.Substring(1);
        }

        public static int GetIntMaskCountTrue(int mask)
        {
            int count = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((mask & (1 << i)) != 0)
                    count++;
            }
            return count;
        }

        [DllExport]
        public static void GetConfirmWindowYesNo()
        {
            string textQuestion = Imports.Stack_PeekString();

            DialogResult dialogResult = MessageBox.Show(Localizator.Get(textQuestion), Localizator.Get("confirmation"), MessageBoxButtons.YesNo);

            bool result = dialogResult == DialogResult.Yes;

            Imports.Stack_PushInt(Convert.ToInt32(result));
        }

        public static void PrintTimeInfo(string messageKey, long ticks, string loadTimeFormat = "mm\\:ss\\.fff", string currentTimeFormat = "HH:mm:ss")
        {

            string loadTime = string.Format("{0:mm\\:ss\\.fff}", TimeSpan.FromTicks(ticks)); // only minutes:seconds.milliseconds
            string currentTime = " | " + Localizator.Get("COMMON_TIME_SYSTEM") + DateTime.Now.ToString("HH:mm:ss") + " ⏱";
            string message = $"⏱  {Localizator.Get(messageKey)} {loadTime}{currentTime}";

            SpacerNET.form.AddText(message, Color.Green);
            ConsoleEx.WriteLineGreen(message);
        }

        public static void PrintTimeInfoSimple(string loadTimeFormat = "mm\\:ss\\.fff", string currentTimeFormat = "HH:mm:ss")
        {

            string currentTime = Localizator.Get("COMMON_TIME_SYSTEM") + DateTime.Now.ToString("HH:mm:ss") + " ⏱";
            string message = $"⏱  {currentTime}";

            SpacerNET.form.AddText(message, Color.Green);
            ConsoleEx.WriteLineGreen(message);
        }

        public static readonly ExtMap[] allowedFileNames = new ExtMap[]
         {
                new ExtMap(".TGA", ".TGA"),
                new ExtMap("-C.TEX", ".TGA"),

                new ExtMap(".3DS", ".3DS"),
                new ExtMap(".MRM", ".3DS"),
                new ExtMap(".MSH ", ".3DS"),

                new ExtMap(".ASC", ".ASC"),
                new ExtMap(".MDL", ".ASC"),
                new ExtMap(".MDH", ".ASC"),

                new ExtMap(".MDS", ".MDS"),
                new ExtMap(".MSB", ".MDS"),
                new ExtMap(".MBH", ".MMS"),
         };

        public static bool IsFileAllowed(ref string name)
        {
            string checkStr = name;

            foreach (var item in allowedFileNames)
            {
                if (checkStr.EndsWith(item.OldExt, StringComparison.OrdinalIgnoreCase))
                {
                    // quick replace: cut the old tail of the name and add the new one
                    name = checkStr.Substring(0, checkStr.Length - item.OldExt.Length) + item.NewExt;
                    return true;
                }
            }

            return false;
        }

        public static void AddInfoUserAction(string info, Color color)
        {
            if (SpacerNET.infoWin.checkBoxInfoShowActions.Checked)
            {
                SpacerNET.infoWin.AddText_External(info + "\n", color);
            }
        }

        public static void PrintLogInfo(string type, string info, Color color)
        {
            var node = SpacerNET.objTreeWin.globalTree.SelectedNode;

            if (node != null)
            {

                var result = ObjTree.globalEntries.Where(x => x.Value.node == node).FirstOrDefault();
                var entry = result.Value;

                if (entry != null)
                {
                    Utils.AddInfoUserAction(type + info
                    + ". " + entry.ToString(), color);
                }
            }
        }


        private static readonly string[] ReservedNames =
        {
            "CON", "PRN", "AUX", "NUL",
            "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9",
            "LPT1", "LPT2", "LPT3", "LPT4", "LPT5", "LPT6", "LPT7", "LPT8", "LPT9"
        };

        /// <summary>
        /// Checks a path / file name for invalid characters and for reserved names.
        /// </summary>
        /// <param name="path">A path or just a file name.</param>
        /// <param name="error">The text of the error, if the check failed.</param>
        /// <returns>true - the path is fine, false - there is a problem.</returns>
        public static bool IsValidFileName(string path, out string error)
        {
            error = null;

            if (string.IsNullOrEmpty(path))
            {
                error = "PATH IS EMPTY!";
                return false;
            }

            // 1) control characters (0x00-0x1F). They are invisible, but WinAPI rejects them.
            foreach (var c in path)
            {
                if (c < 32)
                {
                    error = $"THE PATH CONTAINS BAD SYMBOL (0x{(int)c:X2}).";
                    return false;
                }
            }

            // 2) invalid characters. GetInvalidFileNameChars is usually stricter than
            //    GetInvalidPathChars, but we take the union of both - it is safer,
            //    because we check both a file name and a whole path.
            var invalidChars = Path.GetInvalidFileNameChars()
                .Union(Path.GetInvalidPathChars())
                .Distinct()
                .ToArray();

            var bad = path.Where(c => invalidChars.Contains(c)).Distinct().ToArray();

            if (bad.Length > 0)
            {
                var sb = new StringBuilder();
                foreach (var c in bad)
                {
                    sb.Append($"'{c}' (0x{(int)c:X2}) ");
                }

                error = "THE PATH CONTAINS BAD SYMBOLS: " + sb.ToString().TrimEnd();
                return false;
            }

            // 3) dots and spaces at the end of a file or folder name - Windows silently drops
            //    them, so the name can collapse and become empty.
            var trimmed = path.TrimEnd(' ', '.');
            if (trimmed.Length != path.Length && !path.EndsWith("\\") && !path.EndsWith("/"))
            {
                error = "FILE NAME CAN'T END WITH SPACE OR DOT!";
                return false;
            }

            // 4) reserved DOS names. Checked only on the file name (without the folder)
            //    and without the extension - Windows blocks even "CON.txt".
            var fileName = Path.GetFileName(path);
            if (!string.IsNullOrEmpty(fileName))
            {
                var nameNoExt = Path.GetFileNameWithoutExtension(fileName);

                if (ReservedNames.Contains(nameNoExt, StringComparer.OrdinalIgnoreCase))
                {
                    error = $"NAME '{fileName}' CAN'T BE USED!";
                    return false;
                }
            }

            return true;
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
        private const int WM_SETREDRAW = 0x0b;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        public static void BeginUpdateFast(TreeView tree)
        {
            tree.BeginUpdate();
            tree.SuspendLayout();
            SendMessage(tree.Handle, WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero);
        }

        public static void EndUpdateFast(TreeView tree)
        {
            SendMessage(tree.Handle, WM_SETREDRAW, new IntPtr(1), IntPtr.Zero);

            tree.ResumeLayout();
            tree.EndUpdate();
            tree.Refresh();
        }

        static void SortNodes(TreeNodeCollection nodes)
        {
            if (nodes.Count <= 1)
                return;

            var list = nodes.Cast<TreeNode>().ToList();
            list.Sort((a, b) => string.Compare(a.Text, b.Text, StringComparison.Ordinal));

            nodes.Clear();
            nodes.AddRange(list.ToArray());
        }

        public static void SortWholeTree(TreeView tree)
        {
            BeginUpdateFast(tree);

            SortNodes(tree.Nodes);

            foreach (TreeNode node in tree.Nodes)
                SortNodes(node.Nodes);

            EndUpdateFast(tree);

           
        }

    }

    public class ExtMap
    {
        public string OldExt;
        public string NewExt;

        public ExtMap(string oldExt, string newExt)
        {
            OldExt = oldExt;
            NewExt = newExt;
        }
    }


    
}



