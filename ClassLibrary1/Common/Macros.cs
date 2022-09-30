﻿using SpacerUnion.Windows;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SpacerUnion.Common
{
    public enum MacrosType
    {
        MT_NONE = 0,
        MT_COMMENT,
        MT_RESET,

        MT_LOAD_WORLD,
        MT_LOAD_MESH,


        MT_SAVE_COMPILED,
        MT_SAVE_ASCII,
        MT_SAVE_MESH,

        MT_COMPILE_WORLD_OUTDOOR,
        MT_COMPILE_WORLD_INDOOR,
        MT_COMPILE_LIGHT_VERTEX,
        MT_COMPILE_LIGHT_LOW,
        MT_COMPILE_LIGHT_MID,
        MT_COMPILE_LIGHT_HIGH

    }


    public class MacroEntry
    {
        public string name;
        public List<MacrosType> actions;
        public List<string> rawValues;
        public List<string> cmds;

        public MacroEntry()
        {
            this.actions = new List<MacrosType>();
            this.rawValues = new List<string>();
            this.cmds = new List<string>();
        }
    }

    public class Macros
    {
        public MacrosForm objWin;
        string pathFile;
        bool initOk;
        bool isMacrosRun;

        public List<MacroEntry> entries;

        public MacroEntry currentEntry = null;


        public ConfirmForm formConf;

        public Macros(MacrosForm win)
        {
            initOk = false;
            isMacrosRun = false;
            entries = new List<MacroEntry>();
            objWin = win;

            formConf = new ConfirmForm(this);
            pathFile = Path.GetFullPath(@"../_work/tools/macros_spacernet.txt");

            //ConsoleEx.WriteLineRed(pathFile);

            if (File.Exists(pathFile))
            {
                
                ReadFileData();
                
            }
        }

        public bool IsActive()
        {
            return initOk;
        }

        public void ReloadAgain()
        {
            entries.Clear();
            objWin.listBoxMacros.Items.Clear();
            objWin.richTextBoxMacros.Clear();
            currentEntry = null;
            initOk = false;
            if (File.Exists(pathFile))
            {

                ReadFileData();
                SetupInterface();
                objWin.listBoxMacros.SelectedIndex = -1;
            }

        }

        public void OnRemoveIndex(int index)
        {
            entries.RemoveAt(index);
            objWin.listBoxMacros.Items.RemoveAt(index);
        }

        public void OnNewMacro(string name)
        {
            currentEntry = new MacroEntry();

            currentEntry.name = name;


           
            entries.Add(currentEntry);

            objWin.listBoxMacros.Items.Add(name);
            objWin.listBoxMacros.SelectedIndex = objWin.listBoxMacros.Items.Count - 1;

            objWin.richTextBoxMacros.Enabled = true;
            initOk = true;
        }

        public void OnUpdateAndSave()
        {
            FileStream fs = new FileStream(pathFile, FileMode.Create);

            StreamWriter w = new StreamWriter(fs, Encoding.Default);

            for (int i = 0; i < entries.Count; i++)
            {
                var entry = entries[i];

                w.WriteLine("[" + entry.name + "]");

                for (int j = 0; j < entry.actions.Count; j++)
                {
                    w.WriteLine(entry.rawValues[j]);
                }

                w.WriteLine();

            }

            w.Close();
            
        }


        public MacroEntry TryParseString(string text, bool isFromFile=false)
        {
            //ConsoleEx.WriteLineGreen("TryParseString: " + text + "\n<<<<<<<<<<<<<<<<<");
            string[] allStrings = text.Split('\n');

            MacroEntry tempEntry = new MacroEntry();

            if (!isFromFile && currentEntry != null)
            {
                tempEntry.name = currentEntry.name;
            }

            for (int i = 0; i < allStrings.Length; i++)
            {
                string str = allStrings[i].ToUpper().Trim();

                if (str.Length == 0) continue;

                string[] words = str.Split(' ');
                string curWord = words[0];

                //ConsoleEx.WriteLineRed("current str: " + str + "\n(((((((((((((((((((((");

                if (!str.StartsWith("["))
                {
                    tempEntry.cmds.Add(curWord);

                }

                if (str.StartsWith("[") && isFromFile)
                {
                    str = str.Trim('[').Trim(']');

                    //ConsoleEx.WriteLineGreen("Set name: " + str);
                    //ConsoleEx.WriteLineGreen("\n====");
                    tempEntry.name = str;
                    continue;

                    //ConsoleEx.WriteLineGreen(text);
                }
                else if (curWord.StartsWith("//"))
                {
                    tempEntry.actions.Add(MacrosType.MT_COMMENT);
                    tempEntry.rawValues.Add(str);
                }
                else if (curWord == "RESET")
                {
                    tempEntry.actions.Add(MacrosType.MT_RESET);
                    tempEntry.rawValues.Add(str);
                }
                else if (curWord == "LOAD" && words.Length >= 3)
                {
                    string loadType = words[1];


                    if (loadType == "WORLD")
                    {
                        tempEntry.actions.Add(MacrosType.MT_LOAD_WORLD);
                        tempEntry.rawValues.Add(str);

                        string path = str.Replace("LOAD WORLD", "").Trim();

                       // ConsoleEx.WriteLineGreen("Len: " + words.Length + " " + tempEntry.cmds.Count);

                        tempEntry.cmds[tempEntry.cmds.Count - 1] = path;
                    }
                    else if (loadType == "MESH")
                    {
                        tempEntry.actions.Add(MacrosType.MT_LOAD_MESH);
                        tempEntry.rawValues.Add(str);

                        string path = str.Replace("LOAD MESH", "").Trim();

                        tempEntry.cmds[tempEntry.cmds.Count - 1] = path;
                    }
                    else
                    {
                        tempEntry.actions.Add(MacrosType.MT_COMMENT);
                        tempEntry.rawValues.Add(str);
                    }
                }
                else if (curWord == "COMPILE" && words.Length >= 3)
                {
                    string compileType = words[1];

                    if (compileType == "WORLD")
                    {
                        string worldType = words[2];

                        if (worldType == "OUTDOOR")
                        {
                            tempEntry.actions.Add(MacrosType.MT_COMPILE_WORLD_OUTDOOR);
                            tempEntry.rawValues.Add(str);
                        }
                        else if (worldType == "INDOOR")
                        {
                            tempEntry.actions.Add(MacrosType.MT_COMPILE_WORLD_INDOOR);
                            tempEntry.rawValues.Add(str);
                        }
                        else
                        {
                            tempEntry.actions.Add(MacrosType.MT_COMMENT);
                            tempEntry.rawValues.Add(str);
                        }
                    }
                    else if (compileType == "LIGHT")
                    {
                        string lightType = words[2];

                        if (lightType == "HIGH")
                        {
                            tempEntry.actions.Add(MacrosType.MT_COMPILE_LIGHT_HIGH);
                            tempEntry.rawValues.Add(str);
                        }
                        else if (lightType == "MID")
                        {
                            tempEntry.actions.Add(MacrosType.MT_COMPILE_LIGHT_MID);
                            tempEntry.rawValues.Add(str);
                        }
                        else if (lightType == "LOW")
                        {
                            tempEntry.actions.Add(MacrosType.MT_COMPILE_LIGHT_LOW);
                            tempEntry.rawValues.Add(str);
                        }
                        else if (lightType == "VERTEX")
                        {
                            tempEntry.actions.Add(MacrosType.MT_COMPILE_LIGHT_VERTEX);
                            tempEntry.rawValues.Add(str);
                        }
                        else
                        {
                            tempEntry.actions.Add(MacrosType.MT_COMMENT);
                            tempEntry.rawValues.Add(str);
                        }
                    }

                }
                else
                {
                    tempEntry.actions.Add(MacrosType.MT_COMMENT);
                    tempEntry.rawValues.Add(str);
                }
            }

            



            


            /*
            ConsoleEx.WriteLineRed("===========Parse: " + tempEntry.name + "=============");
            ConsoleEx.WriteLineRed(tempEntry.actions.Count + " " + tempEntry.cmds.Count + " " + tempEntry.rawValues.Count);

            for (int j = 0; j < tempEntry.actions.Count; j++)
            {
                ConsoleEx.WriteLineWhite(tempEntry.rawValues[j] + " " + tempEntry.actions[j].ToString() + " " + tempEntry.cmds[j]);
            }
            */

            return tempEntry;
        }
        public void OnParse()
        {
            if (!IsActive()) return;

            string text = objWin.richTextBoxMacros.Text.Trim();

            int index = objWin.listBoxMacros.SelectedIndex;

            if (index == -1)
            {
                return;
            }

            var entry = TryParseString(text, false);

            if (entry != null)
            {
                currentEntry = entry;
                entries[index] = entry;
            }

        }

        public void OnRun()
        {
            if (!IsActive()) return;

            if (isMacrosRun) return;

            if (currentEntry != null)
            {
                ConsoleEx.WriteLineRed("OnRun===============");

                isMacrosRun = true;
                /*
                for (int i = 0; i < entries.Count; i++)
                {
                    var entry = entries[i];

                    ConsoleEx.WriteLineGreen(entry.name + "=============");

                    ConsoleEx.WriteLineGreen(entry.actions.Count + " " + entry.cmds.Count + " " + entry.rawValues.Count);

                    for (int j = 0; j < entry.actions.Count; j++)
                    {
                        ConsoleEx.WriteLineRed("cmd: " + entry.cmds[j]
                            + " raw: " + entry.rawValues[j]
                            + " action: " + entry.actions[j].ToString());
                    }


                }
                */

                Imports.Extern_ClearMacrosCmd();

                for (int i = 0; i < currentEntry.actions.Count; i++)
                {
                    /*
                    //if (currentEntry.actions[i] != MacrosType.MT_COMMENT)
                    {
                        ConsoleEx.WriteLineRed("cmd: " + currentEntry.cmds[i] 
                            + " raw: " + currentEntry.rawValues[i]
                            + " action: " + currentEntry.actions[i].ToString());
                    }
                    */

                    if (currentEntry.actions[i] != MacrosType.MT_COMMENT)
                    {
                        Imports.Stack_PushString(currentEntry.cmds[i]);
                        Imports.Stack_PushString(currentEntry.rawValues[i]);
                        Imports.Stack_PushInt((int)currentEntry.actions[i]);
                        Imports.Extern_AddMacrosCmd();
                    }
                }

                SpacerNET.form.ResetInterface();

                Imports.Extern_RunMacrosCmd();



                SpacerNET.form.dayTimeToolStrip.Enabled = true;
                SpacerNET.form.toolStripMenuResetWorld.Enabled = true;
                SpacerNET.form.compileLightToolStrip.Enabled = true;
                SpacerNET.form.saveUncZenToolStrip.Enabled = true;
                SpacerNET.form.saveZenToolStripMenuItem.Enabled = true;
                SpacerNET.form.toolStripMenuExtractMesh.Enabled = true;

                if (Imports.Extern_IsWorldCompiled() == 0)
                {
                    SpacerNET.form.compileWorldToolStrip.Enabled = true;
                }

                SpacerNET.form.playHeroToolStrip.Enabled = true;
                SpacerNET.form.analyseWaynetToolStripMenuItem.Enabled = true;
                SpacerNET.form.stripSpecialFunctions.Enabled = true;
                SpacerNET.form.cameraCoordsToolStrip.Enabled = true;

                isMacrosRun = false;
            }
        }

        public void OnSelectIndex(int index)
        {
            if (!IsActive()) return;


            var entry = entries[index];

            objWin.richTextBoxMacros.Clear();
            objWin.richTextBoxMacros.Enabled = true;
            currentEntry = entry;

           // objWin.richTextBoxMacros.AppendText(entry.name);


            for (int j = 0; j < entry.actions.Count; j++)
            {

                
                objWin.richTextBoxMacros.AppendText(entry.rawValues[j] + "\n");
            }
        }
        

        public void SetupInterface()
        {
            objWin.listBoxMacros.Items.Clear();

            for (int i = 0; i < entries.Count; i++)
            {
                var entry = entries[i];

                objWin.listBoxMacros.Items.Add(entry.name);

            }

        }

        public void CheckEntry(bool newEntryForce = false)
        {
            if (newEntryForce)
            {
                currentEntry = new MacroEntry();
                entries.Add(currentEntry);
                return;
            }

            if (currentEntry == null)
            {
                currentEntry = new MacroEntry();
                entries.Add(currentEntry);
            }
        }

        public void ReadFileData()
        {
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);

            StringBuilder strInput = new StringBuilder();
            bool startEntry = false;

            //var entryCreated = TryParseString(System.IO.File.ReadAllText(pathFile));
            foreach (string line in System.IO.File.ReadLines(pathFile))
            {
                string text = line;

                text = text.Trim();

                if (text.Length == 0)
                {
                    continue;
                }


                if (text.StartsWith("["))
                {
                    if (!startEntry)
                    {
                        strInput.Append(text + "\n");
                        //ConsoleEx.WriteLineGreen("NEW: " + strInput.ToString());
                        
                        startEntry = true;
                        
                    }
                    else
                    {
                        //ConsoleEx.WriteLineRed("TRY: " + strInput.ToString());

                        var newEntry = TryParseString(strInput.ToString().Trim(), true);
                       
                        entries.Add(newEntry);
                        strInput.Clear();

                        strInput.Append(text + "\n");
                        //ConsoleEx.WriteLineGreen("NEW: " + strInput.ToString());

                    }
                }
                else if(startEntry)
                {
                    strInput.Append(text + "\n");
                    // ConsoleEx.WriteLineRed("Append: " + text.ToString() + "=====" + strInput.ToString());

                }
            }

            if (startEntry)
            {
                var newEntry = TryParseString(strInput.ToString().Trim(), true);

                entries.Add(newEntry);
                strInput.Clear();
            }



            if (entries.Count > 0)
            {
                initOk = true;
                ConsoleEx.WriteLineRed("Loaded entries from MACROS file: " + entries.Count);

                for (int i = 0; i < entries.Count; i++)
                {
                    var entry = entries[i];

                    ConsoleEx.WriteLineRed("Name: " + entry.name + " " + entry.actions.Count + " " + entry.cmds.Count + " " + entry.rawValues.Count);

                    for (int j = 0; j < entry.actions.Count; j++)
                    {
                       // ConsoleEx.WriteLineWhite("raw: " + entry.rawValues[j] + " act: " + entry.actions[j].ToString() + " cmd: " + entry.cmds[j].ToString());
                    }

                }
            }

            /*
            foreach (string line in System.IO.File.ReadLines(pathFile))
            {
                string text = line;

                text = text.Trim();


                if (text.Length == 0)
                {
                    continue;
                }

                if (text.StartsWith("["))
                {
                    text = text.Trim('[');
                    text = text.Trim(']');


                    CheckEntry(true);

                    currentEntry.name = text;
                    continue;

                    //ConsoleEx.WriteLineGreen(text);
                }
                else if (text.StartsWith("//"))
                {
                    CheckEntry();

                    currentEntry.actions.Add(MacrosType.MT_COMMENT);
                    currentEntry.rawValues.Add(text);
                    currentEntry.cmds.Add(text);

                    continue;
                    //ConsoleEx.WriteLineGreen(text);
                }
                else
                {
                    CheckEntry();

                    text = text.ToUpper();


                    if (text == "compile world outdoor".ToUpper())
                    {
                        currentEntry.actions.Add(MacrosType.MT_COMPILE_WORLD_OUTDOOR);
                        currentEntry.cmds.Add(text);
                        currentEntry.rawValues.Add(text);
                    }
                    else if (text == "compile world indoor".ToUpper())
                    {
                        currentEntry.actions.Add(MacrosType.MT_COMPILE_WORLD_INDOOR);
                        currentEntry.cmds.Add(text);
                        currentEntry.rawValues.Add(text);
                    }
                    else if (text == "reset".ToUpper())
                    {
                        currentEntry.actions.Add(MacrosType.MT_RESET);
                        currentEntry.cmds.Add(text);
                        currentEntry.rawValues.Add(text);
                    }
                    else if (text == "compile light high".ToUpper())
                    {
                        currentEntry.actions.Add(MacrosType.MT_COMPILE_LIGHT_HIGH);
                        currentEntry.cmds.Add(text);
                        currentEntry.rawValues.Add(text);
                    }
                    else if (text == "compile light mid".ToUpper())
                    {
                        currentEntry.actions.Add(MacrosType.MT_COMPILE_LIGHT_MID);
                        currentEntry.cmds.Add(text);
                        currentEntry.rawValues.Add(text);
                    }
                    else if (text == "compile light low".ToUpper())
                    {
                        currentEntry.actions.Add(MacrosType.MT_COMPILE_LIGHT_LOW);
                        currentEntry.cmds.Add(text);
                        currentEntry.rawValues.Add(text);
                    }
                    else if (text == "compile light vertex".ToUpper())
                    {
                        currentEntry.actions.Add(MacrosType.MT_COMPILE_LIGHT_VERTEX);
                        currentEntry.cmds.Add(text);
                        currentEntry.rawValues.Add(text);
                    }
                    else if (text.StartsWith("load".ToUpper()))
                    {
                        string[] split = text.Split(' ');

                        if (split[1] == "world".ToUpper() && split.Length >= 3)
                        {
                            currentEntry.rawValues.Add(text);

                            currentEntry.actions.Add(MacrosType.MT_LOAD_WORLD);

                            string path = text.Replace("LOAD WORLD", "").Trim();

                            currentEntry.cmds.Add(path);
                        }
                        else if (split[1] == "mesh".ToUpper() && split.Length >= 3)
                        {

                            currentEntry.rawValues.Add(text);
                            string path = text.Replace("LOAD MESH", "").Trim();
                            currentEntry.actions.Add(MacrosType.MT_LOAD_MESH);
                            currentEntry.cmds.Add(path);
                        }


                        continue;
                    }
                    else
                    {
                        currentEntry.actions.Add(MacrosType.MT_COMMENT);
                        currentEntry.rawValues.Add(text);
                        currentEntry.cmds.Add(text);
                    }


                    //ConsoleEx.WriteLineGreen(text);
                }
            }
            */




        }
    }
}
