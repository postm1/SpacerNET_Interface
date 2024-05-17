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
    public partial class VobCatalogPropsForm : Form
    {
        public string confType;
        public bool clearText;

        public VobCatalogPropsForm()
        {
            InitializeComponent();

            clearText = false;
            confType = String.Empty;
        }

        private void buttonConfirmYes_Click(object sender, EventArgs e)
        {
            if (confType == "VOBCATALOG_ADD_NEW")
            {
                string text = textBoxValueEnter.Text.Trim();

                if (text.Contains(";"))
                {
                    MessageBox.Show("Symbol ; is not allowed here"); //fixme
                    return;
                }

                bool dynColl = checkBoxDynColl.Checked;

                SpacerNET.vobCatForm.NewItem(text, dynColl);
            }
            else if (confType == "VOBCATALOG_CHANGE_ELEMENT")
            {
                string text = textBoxValueEnter.Text.Trim();

                if (text.Contains(";"))
                {
                    MessageBox.Show("Symbol ; is not allowed here"); //fixme
                    return;
                }

                bool dynColl = checkBoxDynColl.Checked;

                SpacerNET.vobCatForm.ChangeItem(text, dynColl);
            }
            this.Hide();
        }

        private void buttonConfirmNo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void VobCatalogPropsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
