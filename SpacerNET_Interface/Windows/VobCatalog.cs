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
        string pathFile;

        public VobCatalogForm()
        {
            InitializeComponent();
            vobMan = new VobCatalogManager();
            formConf = new ConfirmForm(null);
            pathFile = Path.GetFullPath(@"../_work/tools/vobcatalog_spacernet.txt");
        }

        private void buttonAddNewGroup_Click(object sender, EventArgs e)
        {
            formConf.buttonConfirmNo.Text = Localizator.Get("WIN_COMPLIGHT_CLOSEBUTTON");
            formConf.buttonConfirmYes.Text = Localizator.Get("WIN_BTN_CONFIRM");
            formConf.labelTextShow.Text = Localizator.Get("MSG_MATFILTER_NEW_NAME");//fixme
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
                formConf.labelTextShow.Text = Localizator.Get("MSG_MATFILTER_NEW_NAME");//fixme
                formConf.confType = "VOBCATALOG_RENAME_GROUP";
                formConf.clearText = false;
                formConf.textBoxValueEnter.Text = listBoxGroups.SelectedItem.ToString();
                formConf.ShowDialog();
            }
        }

        public void UpdateLang()
        {

        }

        public void ToggleInterface(bool toggle)
        {

            groupBoxGroups.Enabled = toggle;
            listBoxGroups.Enabled = toggle;
            listBoxItems.Enabled = toggle;
            buttonUP.Enabled = toggle;
            buttonDOWN.Enabled = toggle;
            groupBoxItems.Enabled = toggle;

        }


        public void SetNewGroupText(string groupName)
        {
            if (listBoxGroups.Items.Contains(groupName))
            {
                //fixme
                MessageBox.Show("Such name already exists");
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

        public void NewItem(string name)
        {
            if (listBoxGroups.SelectedItem != null)
            {
                if (name.Length == 0)
                {
                    return;
                }

                vobMan.AddNew(listBoxGroups.SelectedItem.ToString(), name, name);
                listBoxItems.Items.Add(name);
            }
        }

        public void OnSelectGroup()
        {
            if (listBoxGroups.SelectedItem != null)
            {
                listBoxItems.BeginUpdate();
                listBoxItems.Items.Clear();

                var foundList = vobMan.GetAllByGroup(listBoxGroups.SelectedItem.ToString());

                foreach (var entry in foundList)
                {
                    listBoxItems.Items.Add(entry.EntryName);
                }
                


                listBoxItems.EndUpdate();
            }
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


        private void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItem != null)
            {
                //fixme
                DialogResult dialogResult = MessageBox.Show(Localizator.Get("askSure"), Localizator.Get("confirmation"), MessageBoxButtons.YesNo);

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

                    if (split.Length == 3)
                    {
                        vobMan.AddNew(split[0], split[1], split[2]);
                    }
                    
                }
            }
        }

        public void SaveToFile()
        {
            FileStream fs = new FileStream(pathFile, FileMode.Create);

            StreamWriter w = new StreamWriter(fs, Encoding.UTF8);

            HashSet<string> groupNames = new HashSet<string>();

            StringBuilder groupsList = new StringBuilder();


            //write all groups in file
            foreach (var entry in listBoxGroups.Items)
            {
                groupsList.Append(entry.ToString() + ";");

            }

            w.WriteLine(groupsList.ToString());

            //write all entries in file

            foreach (var entry in vobMan.entries)
            {
                w.WriteLine(entry.GroupName + ";" + entry.EntryName + ";" + entry.Visual);
            }

            //w.WriteLine(entry.GroupName + ";" + entry.EntryName + ";" + entry.Visual);
            w.Close();
        }

        private void VobCatalogForm_Shown(object sender, EventArgs e)
        {
            LoadFromFile();
            Application.DoEvents();
            ToggleInterface(false);
        }

        private void VobCatalogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //fixme
            //Properties.Settings.Default.SoundWinLocation = this.Location;
            this.Hide();
            e.Cancel = true;

            SaveToFile();
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

                formConf.buttonConfirmNo.Text = Localizator.Get("WIN_COMPLIGHT_CLOSEBUTTON");
                formConf.buttonConfirmYes.Text = Localizator.Get("WIN_BTN_CONFIRM");
                formConf.labelTextShow.Text = Localizator.Get("MSG_MATFILTER_NEW_NAME");//fixme
                formConf.confType = "VOBCATALOG_NEW_ITEM";
                formConf.clearText = true;
                formConf.ShowDialog();
            }
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItem != null && listBoxItems.SelectedItem != null)
            {
                //fixme
                DialogResult dialogResult = MessageBox.Show(Localizator.Get("askSure"), Localizator.Get("confirmation"), MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    string groupName = listBoxGroups.SelectedItem.ToString();
                    string visualName = listBoxItems.SelectedItem.ToString();

                    vobMan.entries.RemoveAll(x => x.GroupName == groupName && x.Visual == visualName);
                    listBoxItems.Items.RemoveAt(listBoxGroups.SelectedIndex);
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
    }
}
