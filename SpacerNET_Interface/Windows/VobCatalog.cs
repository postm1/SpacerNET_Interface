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

        public void MoveItem(int direction)
        {
            var listBox1 = listBoxGroups;

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



            //w.WriteLine(entry.GroupName + ";" + entry.EntryName + ";" + entry.Visual);
            w.Close();
        }

        private void VobCatalogForm_Shown(object sender, EventArgs e)
        {
            LoadFromFile();
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
            MoveItem(1);
        }

        private void buttonUP_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        private void VobCatalogForm_VisibleChanged(object sender, EventArgs e)
        {
            SpacerNET.form.toolStripButtonCatalog.Checked = this.Visible;
        }
    }
}
