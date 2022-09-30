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
    public partial class MacrosForm : Form
    {
        public MacrosForm()
        {
            InitializeComponent();
        }

        private void MacrosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        public void UpdateLang()
        {

        }

        private void buttonMacrosSaveAll_Click(object sender, EventArgs e)
        {

        }
    }
}
