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
    public partial class RenameForm : Form
    {
        public RenameForm()
        {
            InitializeComponent();
        }


        public void UpdateLang()
        {
            this.Text = Localizator.Get("RENAME_WIN_TITLE");
            this.buttonRenameWin_Apply.Text = Localizator.Get("BTN_APPLY");
            this.radioButtonRenameEmpty.Text = Localizator.Get("radioButtonRenameEmpty");
            this.radioButtonNameForAll.Text = Localizator.Get("radioButtonNameForAll");
            this.radioButtonNameOneNumberPostfix.Text = Localizator.Get("radioButtonNameOneNumberPostfix");
        }
        private void RenameForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonRenameWin_Apply_Click(object sender, EventArgs e)
        {
            var checkedButton = this.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);


            var indexSelected = Convert.ToInt32(checkedButton.Tag);
            var textStartNumber = textBoxRenamesStarNumber.Text.Trim();
            int numberStart = 0;

            if (int.TryParse(textStartNumber, out int value))
            {
                numberStart = value;
            }

            Imports.Stack_PushString(textBoxRenameForAllVobs.Text.Trim());
            Imports.Stack_PushString(textBoxRenameWithPrefix.Text.Trim());

            Imports.Extern_SetRenameOptions(indexSelected, numberStart);

            this.Hide();
        }

        private void RenameForm_VisibleChanged(object sender, EventArgs e)
        {
            UpdateLang();
        }

        private void RenameForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void RenameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            buttonRenameWin_Apply_Click(null, null);
            
        }
    }
}
