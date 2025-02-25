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
    public partial class UVReporterForm : Form
    {
        public UVReporterForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void UVReporterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.FormOwnerClosing)
            {
                e.Cancel = true;
                return;
            }

            this.Hide();
            e.Cancel = true;
        }

        public void ToggleInterface(bool toggle)
        {

            if (!toggle)
            {
                listUVErrors.Items.Clear();
            }

            panelBottomControls.Enabled = toggle;

        }

        public void UpdateLang()
        {

        }

        private void UVReporterForm_VisibleChanged(object sender, EventArgs e)
        {
            SpacerNET.form.toolStripButtonUV.Checked = this.Visible;
        }
    }

    
}
