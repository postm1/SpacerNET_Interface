using SpacerUnion.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion.Windows
{
    public partial class VobCatalogMoveForm : Form
    {
        private string operationType;
        private string visual;
        private string oldGroup;

        public VobCatalogMoveForm()
        {
            InitializeComponent();
            operationType = String.Empty;
        }

        public string OperationType { get => operationType; set => operationType = value; }
        public string Visual { get => visual; set => visual = value; }
        public string OldGroup { get => oldGroup; set => oldGroup = value; }

        private void VobCatalogMoveForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }


        public void UpdateWindow()
        {
            if (operationType == "COPYING")
            {
                labelMode.Text = Localizator.Get("WIN_VOBCATALOG_MODE_COPY");
            }
            else if (operationType == "MOVING")
            {
                labelMode.Text = Localizator.Get("WIN_VOBCATALOG_MODE_MOVE");
            }

            labelVisual.Text = Localizator.Get("WIN_VOBCATALOG_VISUAL_NAME") + visual;
            labelGroups.Text = Localizator.Get("WIN_VOBCATALOG_MOVE_SELECT_GROUP");

            

            buttonApply.Text = Localizator.Get("BTN_APPLY");
            buttonCancel.Text = Localizator.Get("WIN_CANCEL_BUTTON");

            this.Text = Localizator.Get("WIN_VOBCATALOG_MOVE_WIN_TITLE");
            this.Font = SpacerNET.form.Font;



            FillGroups();
        }

        public void FillGroups()
        {
            listBoxGroups.BeginUpdate();
            listBoxGroups.Items.Clear();

            listBoxGroups.Items.AddRange(SpacerNET.vobCatForm.listBoxGroups.Items);

            listBoxGroups.EndUpdate();

            if (listBoxGroups.Items.Count > 0)
            {
                listBoxGroups.SelectedIndex = 0;
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (listBoxGroups.Items.Count > 0 && listBoxGroups.SelectedItem != null)
            {
                if (Visual.Trim().Length > 0)
                {
                    string groupName = listBoxGroups.GetItemText(listBoxGroups.Items[listBoxGroups.SelectedIndex]);
                    string visual = Visual;


                    if (operationType == "COPYING")
                    {
                        SpacerNET.vobCatForm.vobMan.CopyVisualToGroup(groupName, visual);
                    }
                    else if (operationType == "MOVING")
                    {
                        SpacerNET.vobCatForm.vobMan.MoveVisualToGroup(groupName, visual, OldGroup);
                    }
                       
                }
                else
                {
                    MessageBox.Show(Localizator.Get("WIN_VOBCATALOG_GROUP_ERR_NO_VISUAL"));
                }
                
            }
            else
            {
                MessageBox.Show(Localizator.Get("WIN_VOBCATALOG_GROUP_ERR_NO_SELECT"));
            }

            this.Close();
        }
    }
}
