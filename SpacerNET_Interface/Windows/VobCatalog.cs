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
            pathFile = Path.GetFullPath(@"../_work/tools/spacernet_vobcatalog.txt");
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


        public void SetNewGroupText(string groupName)
        {
            if (listBoxGroups.Items.Contains(groupName))
            {
                MessageBox.Show("Such name already exists");
                return;
            }

            listBoxGroups.Items.Add(groupName);
        }


        public void RenameGroup(string groupName)
        {
            if (groupName.Contains(";"))
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


        }
        

        private void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItem != null)
            {

                DialogResult dialogResult = MessageBox.Show(Localizator.Get("askSure"), Localizator.Get("confirmation"), MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    listBoxGroups.Items.RemoveAt(listBoxGroups.SelectedIndex);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var result = vobMan.GetAllByGroup("SOME");

            ConsoleEx.WriteLineYellow("_____");

            for (int i = 0; i < result.Count; i++)
            {
                ConsoleEx.WriteLineYellow(result[i].EntryName);
            }

            SaveToFile();


        }

        public void SaveToFile()
        {
            FileStream fs = new FileStream(pathFile, FileMode.Create);

            StreamWriter w = new StreamWriter(fs, Encoding.Default);

            HashSet<string> groupNames = new HashSet<string>();

            StringBuilder groupsList = new StringBuilder();

            foreach (var entry in vobMan.entries)
            {
                if (!groupNames.Contains(entry.GroupName))
                {
                    groupNames.Add(entry.GroupName);
                    groupsList.Append(entry.GroupName + ";");
                }
                
            }

            w.WriteLine(groupsList.ToString());

            //w.WriteLine(entry.GroupName + ";" + entry.EntryName + ";" + entry.Visual);
            w.Close();
        }

        
    }
}
