using SpacerUnion.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion.Windows
{
    public partial class VobCatalogForm : Form
    {
        public VobCatalogManager vobMan;
        public ConfirmForm formConf;
        public VobCatalogPropsForm propsForm;
        string pathFile;
        string pathFileCopy;
        string pathBackups;
        bool fileWasRead;

        public VobCatalogForm()
        {
            InitializeComponent();
            vobMan = new VobCatalogManager();
            formConf = new ConfirmForm(null);
            propsForm = new VobCatalogPropsForm();
            pathFile = Path.GetFullPath(@"../_work/tools/vobcatalog_spacernet.txt");
            pathFileCopy = Path.GetFullPath(@"../_work/tools/vobcatalog_spacernet_backup.txt");
            pathBackups = Path.GetFullPath(@"../_work/tools/vobcatalog_backups/");
            fileWasRead = false;
        }

      
        private void buttonAddNewGroup_Click(object sender, EventArgs e)
        {
            formConf.buttonConfirmNo.Text = Localizator.Get("WIN_COMPLIGHT_CLOSEBUTTON");
            formConf.buttonConfirmYes.Text = Localizator.Get("WIN_BTN_CONFIRM");
            formConf.labelTextShow.Text = Localizator.Get("WIN_VOBCATALOG_GROUP_NAME");
            formConf.confType = "VOBCATALOG_NEW_GROUP";
            formConf.clearText = true;
            formConf.ShowDialog();
        }

        private void buttonRenaneSelected_Click(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItem != null)
            {

                formConf.buttonConfirmNo.Text = Localizator.Get("WIN_COMPLIGHT_CLOSEBUTTON");
                formConf.buttonConfirmYes.Text = Localizator.Get("WIN_BTN_CONFIRM");
                formConf.labelTextShow.Text = Localizator.Get("WIN_VOBCATALOG_GROUP_NAME");
                formConf.confType = "VOBCATALOG_RENAME_GROUP";
                formConf.clearText = false;
                formConf.textBoxValueEnter.Text = listBoxGroups.SelectedItem.ToString();
                formConf.ShowDialog();
            }
        }

        public void UpdateLang()
        {
            this.Text = Localizator.Get("WIN_VOBCATALOG_TITLE");
            checkBoxHideModel.Text = Localizator.Get("WIN_VOBCATALOG_HIDE_PREVIEW");

            groupBoxGroups.Text = Localizator.Get("WIN_VOBCATALOG_GROUPS");
            groupBoxItems.Text = Localizator.Get("WIN_VOBCATALOG_ITEMS");
            groupBoxActions.Text = Localizator.Get("WIN_VOBCATALOG_ACTIONS");
            groupBoxAdv.Text = Localizator.Get("WIN_VOBCATALOG_ADV");

            labelSearch.Text = Localizator.Get("WIN_VOBCATALOG_SEARCH");
            buttonCreateVob.Text = Localizator.Get("buttonAllClassesCreateVob");
            buttonSaveCopy.Text = Localizator.Get("WIN_VOBCATALOG_BUTTON_SAVE");

            buttonAddNewGroup.Text = Localizator.Get("WIN_VOBCATALOG_BTN_ADD_GROUP_NEW");
            buttonRenameSelected.Text = Localizator.Get("WIN_VOBCATALOG_BTN_RENAME_GROUP");
            buttonRemoveSelected.Text = Localizator.Get("WIN_VOBCATALOG_BTN_REMOVE_GROUP");


            

            buttonAddElement.Text = Localizator.Get("WIN_VOBCATALOG_BTN_ELEM_ADD");
            buttonChangeProps.Text = Localizator.Get("WIN_VOBCATALOG_BTN_ELEM_EDIT");
            buttonRemoveItem.Text = Localizator.Get("WIN_VOBCATALOG_BTN_ELEM_REMOVE");


            checkBoxDebugSearch.Text = Localizator.Get("WIN_VOBCATALOG_ADV_DONT_SEARCH");
            buttonDebugRemove.Text = Localizator.Get("WIN_VOBCATALOG_ADV_REMOVE_VOBS");
            buttonNoModels.Text = Localizator.Get("WIN_VOBCATALOG_ADV_PRINT_MODELS");

            UpdateTitle();
        }

        public void UpdateTitle()
        {
            this.Text = Localizator.Get("WIN_VOBCATALOG_TITLE") + ". " 
                + Localizator.Get("WIN_VOBCATALOG_ALL_COUNT") + vobMan.entries.Count
                
                ;

            if (listBoxGroups.SelectedItem != null)
            {
                this.Text += ". " + Localizator.Get("WIN_VOBCATALOG_IN_CURRENT_GROUP") + listBoxItems.Items.Count;
            }
        }

        private void VobCatalogForm_Shown(object sender, EventArgs e)
        {
            LoadFromFile();
            Application.DoEvents();

            if (Imports.Extern_IsWorldLoaded() == 0)
            {
                ToggleInterface(false);
            }

            Imports.Stack_PushString("bHidePreviewOnVobCatalogHide");
            checkBoxHideModel.Checked = Convert.ToBoolean(Imports.Extern_GetSetting());

        }

        public void ToggleInterface(bool toggle)
        {

            groupBoxGroups.Enabled = toggle;
            listBoxGroups.Enabled = toggle;
            listBoxItems.Enabled = toggle;
            buttonUP.Enabled = toggle;
            buttonDOWN.Enabled = toggle;
            groupBoxItems.Enabled = toggle;
            buttonUpRight.Enabled = toggle;
            buttonDownRight.Enabled = toggle;
            groupBoxActions.Enabled = toggle;
            buttonSortAlph.Enabled = toggle;
            buttonSortItems.Enabled = toggle;
            buttonUPAbs.Enabled = toggle;
            buttonDownAbs.Enabled = toggle;
            textBoxSearch.Enabled = toggle;
            groupBoxAdv.Enabled = toggle;
            checkBoxHideModel.Enabled = toggle;
            checkBoxDebugSearch.Enabled = toggle;
            labelSearch.Enabled = toggle;
        }


        public void SetNewGroupText(string groupName)
        {
            if (listBoxGroups.Items.Contains(groupName))
            {
                MessageBox.Show(Localizator.Get("NAME_ALREADY_EXISTS"));
                return;
            }

            if (groupName.Length == 0)
            {
                return;
            }

            listBoxGroups.Items.Add(groupName);
            listBoxGroups.Focus();
        }


        public void RenameGroup(string groupName)
        {

            if (groupName.Length == 0)
            {
                return;
            }

            string oldName = listBoxGroups.SelectedItem.ToString();

            //ConsoleEx.WriteLineRed(oldName + "->" + groupName);


            foreach (var entry in vobMan.entries)
            {
                if (entry.GroupName == oldName)
                {
                    entry.GroupName = groupName;
                }
            }

            listBoxGroups.Items[listBoxGroups.SelectedIndex] = groupName;
            listBoxGroups.Focus();

        }

        public void NewItem(string name, bool dynColl, bool statColl, bool staticVob)
        {
            if (listBoxGroups.SelectedItem != null)
            {
                if (name.Length == 0)
                {
                    return;
                }

                if (listBoxItems.Items.Contains(name))
                {
                    MessageBox.Show(Localizator.Get("NAME_ALREADY_EXISTS"));
                    return;
                }

                var newEntry = vobMan.AddNew(listBoxGroups.SelectedItem.ToString(), name, listBoxGroups.Items.Count);

                newEntry.DynColl = dynColl;
                newEntry.StatColl = statColl;
                newEntry.IsStaticVob = staticVob;

                listBoxItems.Items.Add(name);

                this.Focus();

                UpdateTitle();
            }
        }

        public void ChangeItem(string name, bool dynColl, bool statColl, bool isStaticVob)
        {
            if (listBoxItems.SelectedItem != null && listBoxGroups.SelectedItem != null)
            {
                if (name.Length == 0)
                {
                    return;
                }

                var curGroup = listBoxGroups.SelectedItem.ToString();
                var curVisual = listBoxItems.SelectedItem.ToString();

                var newEntry = vobMan.GetByGroupAndVisual(curGroup, curVisual);

                if (newEntry != null)
                {
                    newEntry.Visual = name;
                    newEntry.DynColl = dynColl;
                    newEntry.StatColl = statColl;
                    newEntry.IsStaticVob = isStaticVob;

                    listBoxItems.Items[listBoxItems.SelectedIndex] = name;

                    this.Focus();
                }

            }
        }


        public void OnSelectGroup()
        {
            Imports.Stack_PushString("");
            Imports.Extern_RenderSelectedVob();

            if (listBoxGroups.SelectedItem != null)
            {
                listBoxItems.BeginUpdate();
                listBoxItems.Items.Clear();

                var foundList = vobMan.GetAllByGroup(listBoxGroups.SelectedItem.ToString());

                foreach (var entry in foundList)
                {
                    listBoxItems.Items.Add(entry.Visual);
                }
                


                listBoxItems.EndUpdate();

                
            }

            UpdateTitle();
        }

        


        private void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show(Localizator.Get("WIN_VOBCATALOG_ASKSURE_REMOVE_GROUP"), Localizator.Get("confirmation"), MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    string groupName = listBoxGroups.SelectedItem.ToString();

                    vobMan.entries.RemoveAll(x => x.GroupName == groupName);

                    listBoxGroups.Items.RemoveAt(listBoxGroups.SelectedIndex);

                }
            }
        }


        public void LoadFromFile()
        {
            if (!File.Exists(pathFile))
            {
                return;
            }

           

            List<string> arr = System.IO.File.ReadLines(pathFile, Encoding.UTF8).ToList();

            string firstLine = arr[0].Trim();

            if (firstLine.Length > 0)
            {
                var split = firstLine.Split(';');


                listBoxGroups.BeginUpdate();

                for (int i = 0; i < split.Length; i++)
                {
                    var groupName = split[i].Trim();

                    if (groupName.Length > 0)
                    {
                        listBoxGroups.Items.Add(groupName);
                    }
                }

                listBoxGroups.EndUpdate();
            }

            if (arr.Count > 1)
            {
                for (int i = 1; i < arr.Count; i++)
                {
                    var split = arr[i].Trim().Split(';');

                    if (split.Length == 5)
                    {
                        string groupName = split[0];

                        int count = vobMan.entries.Where(x => x.GroupName == groupName).Count();

                        var newEntry = vobMan.AddNew(groupName, split[1], count);

                        newEntry.DynColl = Convert.ToBoolean(split[2]);
                        newEntry.StatColl = Convert.ToBoolean(split[3]);
                        newEntry.IsStaticVob = Convert.ToBoolean(split[4]);
                    }
                    
                }
            }

            if (vobMan.entries.Count > 0 || listBoxGroups.Items.Count > 0)
            {
                //make a copy of catalog file
                File.Copy(pathFile, pathFileCopy, true);
            }
           

            fileWasRead = true;

            UpdateTitle();
        }

        public void SaveToFile(bool isBackup = false)
        {

            if (listBoxGroups.Items.Count == 0 || !SpacerNET.isInit)
            {
                return;
            }

            var safePath = pathFile;

            string time = DateTime.Now.ToString("yyyy_MM_dd HH-mm-ss");

            if (isBackup)
            {
                

                safePath = pathBackups + "/vobcatalog_spacernet_" + time + ".txt";
            }

            FileStream fs = new FileStream(safePath, FileMode.Create);

            StreamWriter w = new StreamWriter(fs, Encoding.UTF8);

            StringBuilder groupsList = new StringBuilder();


            

            //write all groups in file
            foreach (var entry in listBoxGroups.Items)
            {
                groupsList.Append(entry.ToString() + ";");

            }

            w.WriteLine(groupsList.ToString());


            //sorting by groups 
            vobMan.entries.Sort((x, y) => x.GroupName.CompareTo(y.GroupName));

            //and indexes (position in listbox)
            //List<VobCatalogEntry> SortedList = vobMan.entries.OrderBy(o => o.Index).ToList();
            HashSet<string> writtenGroups = new HashSet<string>();

            //write all entries in file
            foreach (var tryEntry in vobMan.entries)
            {
                // get current group, find all entries and write them
                if (!writtenGroups.Contains(tryEntry.GroupName))
                {
                    writtenGroups.Add(tryEntry.GroupName);

                    var list = vobMan.entries.Where(x => x.GroupName == tryEntry.GroupName).ToList().OrderBy(x => x.Index);

                    foreach (var entry in list)
                    {
                        w.WriteLine(entry.GroupName + ";" 
                            + entry.Visual + ";" 
                            + entry.DynColl + ";" 
                            + entry.StatColl + ";"
                            + entry.IsStaticVob
                           );
                    }
                }
               
            }

            w.Close();

            ConsoleEx.WriteLineRed("VobCatalog: Save to file");

            if (isBackup)
            {
                MessageBox.Show(Localizator.Get("WIN_VOBCATALOG_SAVED_COPY") + "vobcatalog_spacernet_" + time + ".txt");
            }
        }

        

        private void VobCatalogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //wtf why? Only this windows has this bug
            if (e.CloseReason == CloseReason.FormOwnerClosing)
            {
                e.Cancel = true;
                return;
            }


            SaveToFile();

            Properties.Settings.Default.VobCatalogWinLocation = this.Location;
            this.Hide();
            e.Cancel = true;

           
        }

        private void buttonDOWN_Click(object sender, EventArgs e)
        {
            MoveItem(listBoxGroups, 1);
        }

        private void buttonUP_Click(object sender, EventArgs e)
        {
            MoveItem(listBoxGroups, - 1);
        }

        private void VobCatalogForm_VisibleChanged(object sender, EventArgs e)
        {
            SpacerNET.form.toolStripButtonCatalog.Checked = this.Visible;

            if (!this.Visible && checkBoxHideModel.Checked)
            {
                Imports.Stack_PushString("");
                Imports.Extern_RenderSelectedVob();
            }
           
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex >= 0)
            {
                var visual = listBoxItems.SelectedItem.ToString();

                Imports.Stack_PushString(visual);
                Imports.Extern_RenderSelectedVob();
            }
            else
            {
                Imports.Stack_PushString("");
                Imports.Extern_RenderSelectedVob();
            }
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedIndex >= 0)
            {
                OnSelectGroup();
            }
        }

        private void buttonAddElement_Click(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItem != null)
            {

                propsForm.buttonConfirmNo.Text = Localizator.Get("WIN_COMPLIGHT_CLOSEBUTTON");
                propsForm.buttonConfirmYes.Text = Localizator.Get("WIN_BTN_CONFIRM"); 
                propsForm.labelTextShow.Text = Localizator.Get("WIN_VOBCATALOG_VISUAL_NAME");
                propsForm.confType = "VOBCATALOG_ADD_NEW";
                propsForm.clearText = true;
                propsForm.ShowDialog();
            }
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItem != null && listBoxItems.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show(Localizator.Get("askSure"), Localizator.Get("confirmation"), MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    string groupName = listBoxGroups.SelectedItem.ToString();
                    string visualName = listBoxItems.SelectedItem.ToString();

                    vobMan.entries.RemoveAll(x => x.GroupName == groupName && x.Visual == visualName);
                    listBoxItems.Items.RemoveAt(listBoxItems.SelectedIndex);

                    UpdateTitle();
                }
            }
        }

        private void listBoxItems_MouseDown(object sender, MouseEventArgs e)
        {

            ListBox lb = sender as ListBox;

            if (e.Button == MouseButtons.Middle)
            {

                int index = lb.IndexFromPoint(e.Location);
                {
                    if (index >= 0 && lb.Items.Count > 0)
                    {
                        string name = lb.GetItemText(lb.Items[index]);
                        Utils.SetCopyText(name);
                    }
                }
            }

        }

        private void buttonUpRight_Click(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItem != null)
            {
                var groupName = listBoxGroups.SelectedItem.ToString();

                MoveItem(listBoxItems, -1);
                vobMan.UpdateIndexes(groupName, listBoxItems);
            }
            
        }

        private void buttonDownRight_Click(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItem != null)
            {
                var groupName = listBoxGroups.SelectedItem.ToString();

                MoveItem(listBoxItems, 1);
                vobMan.UpdateIndexes(groupName, listBoxItems);
            }
        }

        private void buttonChangeProps_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem != null)
            {
                propsForm.buttonConfirmNo.Text = Localizator.Get("WIN_COMPLIGHT_CLOSEBUTTON");
                propsForm.buttonConfirmYes.Text = Localizator.Get("WIN_BTN_CONFIRM");
                propsForm.labelTextShow.Text = Localizator.Get("WIN_VOBCATALOG_VISUAL_NAME");
                propsForm.confType = "VOBCATALOG_CHANGE_ELEMENT";
                propsForm.clearText = false;


                var curGroup = listBoxGroups.SelectedItem.ToString();
                var curVisual = listBoxItems.SelectedItem.ToString();

                var newEntry = vobMan.GetByGroupAndVisual(curGroup, curVisual);

                if (newEntry != null)
                {
                    propsForm.textBoxValueEnter.Text = newEntry.Visual;
                    propsForm.checkBoxDynColl.Checked = newEntry.DynColl;
                    propsForm.checkBoxStatic.Checked = newEntry.StatColl;
                    propsForm.checkBoxIsStaticVob.Checked = newEntry.IsStaticVob;

                    propsForm.ShowDialog();
                }
                
            }
        }

        private void buttonCreateVob_Click(object sender, EventArgs e)
        {
            if (SpacerNET.matFilterWin.Visible)
            {
                MessageBox.Show(Localizator.Get("WIN_VOBCATALOG_MATFILTER_TURNOFF"));
                return;
            }

            if (SpacerNET.form.toolStripButtonMaterial.Checked)
            {
                MessageBox.Show(Localizator.Get("WIN_VOBCATALOG_POLYSELECT_TURNOFF"));
                return;
            }

            if (listBoxGroups.SelectedItem != null && listBoxItems.SelectedItem != null)
            {
                var curGroup = listBoxGroups.SelectedItem.ToString();
                var curVisual = listBoxItems.SelectedItem.ToString();

                var newEntry = vobMan.GetByGroupAndVisual(curGroup, curVisual);

                if (newEntry != null)
                {
                    Imports.Stack_PushString(newEntry.Visual);
                    Imports.Stack_PushString("");
                    Imports.Stack_PushString("zCVob");
                    Imports.Stack_PushInt(Convert.ToInt32(newEntry.IsStaticVob));
                    Imports.Extern_CreateNewVobVisual(Convert.ToInt32(newEntry.DynColl), Convert.ToInt32(newEntry.StatColl));

                }
                
            }
               
        }

        private void checkBoxVobCreateActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBoxItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;

            int index = lb.IndexFromPoint(e.Location);
            {
                if (index >= 0 && lb.Items.Count > 0)
                {
                    //string name = lb.GetItemText(lb.Items[index]);
                    listBoxItems.SelectedIndex = index;
                    buttonChangeProps_Click(null, null);
                }
            }
        }

        private void buttonSortAlph_Click(object sender, EventArgs e)
        {
            if (listBoxGroups.Items.Count <= 1)
            {
                return;
            }

            List<string> itemsList = new List<string>();

            foreach (var item in listBoxGroups.Items)
            {
                itemsList.Add(item.ToString());
            }

            itemsList.Sort();

            listBoxGroups.BeginUpdate();
            listBoxGroups.Items.Clear();

            foreach (var item in itemsList)
            {
                listBoxGroups.Items.Add(item);
            }

            listBoxGroups.EndUpdate();

            listBoxGroups.SelectedIndex = 0;
        }

        private void checkBoxHideModel_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;

            Imports.Stack_PushString("bHidePreviewOnVobCatalogHide");
            Imports.Extern_SetSetting(Convert.ToInt32(checkBox.Checked));
        }

        private void buttonSortItems_Click(object sender, EventArgs e)
        {
            if (listBoxItems.Items.Count <= 1)
            {
                return;
            }

            List<string> itemsList = new List<string>();

            foreach (var item in listBoxItems.Items)
            {
                itemsList.Add(item.ToString());
            }

            itemsList.Sort();

            listBoxItems.BeginUpdate();
            listBoxItems.Items.Clear();

            foreach (var item in itemsList)
            {
                listBoxItems.Items.Add(item);
            }

            listBoxItems.EndUpdate();

            listBoxItems.SelectedIndex = 0;


            var groupName = listBoxGroups.SelectedItem.ToString();

            vobMan.UpdateIndexes(groupName, listBoxItems);
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                
                var textSearch = textBoxSearch.Text.Trim().ToUpper();

                if (listBoxItems.Items.Count > listBoxItems.SelectedIndex + 1)
                {
                    for (int i = listBoxItems.SelectedIndex + 1; i < listBoxItems.Items.Count; i++)
                    {
                        var item = listBoxItems.Items[i];

                        if (item.ToString().Contains(textSearch))
                        {
                            listBoxItems.SelectedIndex = i;
                            break;
                        }

                    }
                }
                
            }
        }

        private void buttonDebug_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(Localizator.Get("WIN_VOBCATALOG_ASKSURE_REMOVE_DEBUG"), Localizator.Get("confirmation"), MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Imports.Extern_CallFindSuchVisualsDebug(0);

                foreach (var item in vobMan.entries)
                {
                    Imports.Stack_PushString(item.Visual);
                    Imports.Extern_CallFindSuchVisualsDebugAdd();
                }

                Imports.Extern_CallFindSuchVisualsDebug(1);

            }


            
        }

        private void buttonSaveCopy_Click(object sender, EventArgs e)
        {
            SaveToFile(true);
        }


        public void MoveToTop(ListBox lb)
        {
            if(lb.SelectedItem == null || lb.SelectedIndex < 0)
                return;
            int index = lb.SelectedIndex;

            var item = lb.Items[index];
            lb.Items.RemoveAt(index);
            lb.Items.Insert(0, item);
            lb.Refresh();
            lb.SelectedIndex = 0;
        }

        public void MoveToBottom(ListBox lb)
        {
            if (lb.SelectedItem == null || lb.SelectedIndex < 0)
                return;
            int index = lb.SelectedIndex;

            var item = lb.Items[index];
            lb.Items.RemoveAt(index);
            lb.Items.Add(item);
            lb.Refresh();

            lb.SelectedIndex = lb.Items.Count - 1;
        }

        public void MoveItem(ListBox list, int direction)
        {
            var listBox1 = list;

            // Checking selected item
            if (listBox1.SelectedItem == null || listBox1.SelectedIndex < 0)
                return; // No selected item - nothing to do
                        // Calculate new index using move direction
            int newIndex = listBox1.SelectedIndex + direction;
            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= listBox1.Items.Count)
                return; // Index out of range - nothing to do
            object selected = listBox1.SelectedItem;
            // Removing removable element
            listBox1.Items.Remove(selected);
            // Insert it in new position
            listBox1.Items.Insert(newIndex, selected);
            // Restore selection
            listBox1.SetSelected(newIndex, true);
        }

        private void buttonUPAbs_Click(object sender, EventArgs e)
        {
            MoveToTop(listBoxItems);
        }

        private void buttonDownAbs_Click(object sender, EventArgs e)
        {
            MoveToBottom(listBoxItems);
        }

        private void VobCatalogForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.VobCatalogWinLocation != null)
            {
                this.Location = Properties.Settings.Default.VobCatalogWinLocation;
            }
        }

        private void buttonNoModels_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show(Localizator.Get("WIN_VOBCATALOG_ASKSURE_CMD_MODELS"), Localizator.Get("confirmation"), MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                List<string> foundNoRes = new List<string>();

                foreach (var item in vobMan.entries)
                {
                    var name = item.Visual;

                    if (!name.Contains(".3DS"))
                    {
                        continue;
                    }

                    name = name.Replace(".3DS", ".MRM");

                    Imports.Stack_PushString(name);

                    if (Imports.Extern_Union_FileExists() == 0)
                    {
                        foundNoRes.Add(name);

                    }
                }

                foundNoRes.Sort();

                ConsoleEx.WriteLineRed("VOB Catalog: No models found in VDF/_WORK: ", false);

                foreach (var item in foundNoRes)
                {
                    ConsoleEx.WriteLineRed(item, false);
                }
            }

            

            
        }
    }
}
