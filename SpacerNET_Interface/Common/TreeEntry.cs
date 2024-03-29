﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion
{
    public class TreeEntry
    {
        // адрес воба в памяти
        public uint zCVob;
        // адрес его родителя или 0 если родителя нет
        public uint parent;
        // имя воба
        public string name;
        // имя папки в структуре tree
        public string folderName;
        // класс моба (oCMobInter, zCVob...)
        public string className;
        // is zCVobLevelCompo
        public bool isLevel;
        // флаг для удаления
        public bool toDelete;

        // с каким узлом в TreeView связан воб
        public TreeNode node;

        // ссылка на родительскую запись
        public TreeEntry parentEntry;

        // список ссылок на своих детей
        public List<TreeEntry> childs;

       
        public TreeEntry()
        {
            parentEntry = null;
            childs = new List<TreeEntry>();
            toDelete = false;
        }

    }

}
