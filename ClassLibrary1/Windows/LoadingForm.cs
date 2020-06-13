using SpacerUnion.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpacerUnion
{
    public partial class LoadingForm : Form
    {
        private const int MAX_PICTURES = 2;

        public LoadingForm()
        {
            InitializeComponent();
        }

        public void UpdateText(int type)
        {
            if (type == 0)
            {
                labelLoading.Text = Localizator.Get("loadZen");
            }

            if (type == 1)
            {
                labelLoading.Text = Localizator.Get("compileZen");
            }

            if (type == 2)
            {
                labelLoading.Text = Localizator.Get("compileLight");
            }


            if (type == 3)
            {
                labelLoading.Text = Localizator.Get("savingZen");
            }

            Random rnd = new Random();

            int num = rnd.Next(1, MAX_PICTURES + 1);

            if (num == 1)
            {
                pictureBoxLoading.Image = SpacerUnion.Properties.Resources.jab;
            }

            if (num == 2)
            {
                pictureBoxLoading.Image = SpacerUnion.Properties.Resources.jab2;
            }

        }

        private void buttonLoadingFormClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
