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

        public void UpdateLang()
        {
            checkBoxDynColl.Text = Localizator.Get("checkBoxDynStat");
            checkBoxStatic.Text = Localizator.Get("checkBoxStaStat");
        }

        private void buttonConfirmYes_Click(object sender, EventArgs e)
        {
            bool dynColl = checkBoxDynColl.Checked;
            bool statColl = checkBoxStatic.Checked;


            if (confType == "VOBCATALOG_ADD_NEW")
            {
                string text = textBoxValueEnter.Text.Trim();

                if (text.Contains(";"))
                {
                    MessageBox.Show("Symbol ; is not allowed here"); //fixme
                    return;
                }

               

                SpacerNET.vobCatForm.NewItem(text, dynColl, statColl);
            }
            else if (confType == "VOBCATALOG_CHANGE_ELEMENT")
            {
                string text = textBoxValueEnter.Text.Trim();

                if (text.Contains(";"))
                {
                    MessageBox.Show("Symbol ; is not allowed here"); //fixme
                    return;
                }

    

                SpacerNET.vobCatForm.ChangeItem(text, dynColl, statColl);
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

        private void VobCatalogPropsForm_Shown(object sender, EventArgs e)
        {
            this.textBoxValueEnter.Focus();

            if (clearText)
            {
                this.textBoxValueEnter.Clear();
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogFileName = new OpenFileDialog();

            openFileDialogFileName.Filter = Constants.FILE_FILTER_ALL;


            Imports.Stack_PushString("vobResPath");
            Imports.Extern_GetSettingStr();
            string path = Utils.FixPath(Imports.Stack_PeekString());

            //MessageBox.Show(path);

            try
            {
                openFileDialogFileName.InitialDirectory = Utils.GetInitialDirectory(path);
            }
            catch
            {
                MessageBox.Show("Wrong path! " + path);
                return;
            }

            openFileDialogFileName.RestoreDirectory = true;

            if (openFileDialogFileName.ShowDialog() == DialogResult.OK)
            {
                Imports.Stack_PushString(Utils.FixPath(Path.GetDirectoryName(openFileDialogFileName.FileName)));
                Imports.Stack_PushString("vobResPath");
                Imports.Extern_SetSettingStr();

                string fileName = openFileDialogFileName.SafeFileName;

                textBoxValueEnter.Text = fileName.ToUpper();
            }
        }
    }
}
