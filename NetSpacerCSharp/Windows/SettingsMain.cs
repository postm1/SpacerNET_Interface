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
    public partial class SettingsMain : Form
    {
        List<object> formPanelsList;

        public SettingsMain()
        {
            InitializeComponent();

            formPanelsList = new List<object>();

            formPanelsList.Add(panelSettingsCamera);

        }

        private void listBoxSettingsLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = sender as ListBox;

            if (listBox != null && listBox.SelectedIndex != -1)
            {
                foreach (var element in formPanelsList)
                {
                    var panel = element as Panel;

                    if (panel != null)
                    {
                        panel.Visible = false;
                    }

                    if (formPanelsList[listBox.SelectedIndex] == panel)
                    {
                        panel.Visible = true;
                    }
                }
            }
        }
    }
}
