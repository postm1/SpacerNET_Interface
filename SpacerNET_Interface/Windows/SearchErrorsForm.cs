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
    
    public partial class SearchErrorsForm : Form
    {
        public SearchErrorsForm()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            Helper.EnableDoubleBuffering(this.listViewErrors);
        }

        public void UpdateLang()
        {

        }

        private void SearchErrorsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        public void AddNewRow(ErrorReportEntry entry)
        {
            List<string> texts = new List<string>();

            texts.Add(entry.GetProblemTypeText());
            texts.Add(entry.GetReportTypeText());
            texts.Add(entry.GetDescriptionText());
            texts.Add("-");

            ListViewItem newItem = new ListViewItem(texts.ToArray());

            newItem.UseItemStyleForSubItems = false;

            newItem.SubItems[0].BackColor = Color.White;
            newItem.SubItems[1].BackColor = entry.GetTypeBackColor();
            newItem.SubItems[2].BackColor = Color.White;
            newItem.SubItems[3].BackColor = Color.White;

            //for (int i = 0; i < newItem.SubItems.Count; i++)
            //{
            //    ConsoleEx.WriteLineRed(newItem.SubItems[i].Text);
            //}

            // Add the new item to the ListView control
            listViewErrors.Items.Add(newItem);
        }

        private void buttonErrorsSearch_Click(object sender, EventArgs e)
        {
            listViewErrors.Items.Clear();

             ErrorReportEntry entry = new ErrorReportEntry();

            entry.ProblemType = ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_TEXTURE_NOT_FOUND;
            entry.ErrorType = ErrorReportType.ERROR_REPORT_TYPE_CRITICAL;
            AddNewRow(entry);

            entry = new ErrorReportEntry();

            entry.ProblemType = ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_NAME;
            entry.ErrorType = ErrorReportType.ERROR_REPORT_TYPE_WARNING;


            AddNewRow(entry);


            entry.ProblemType = ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_TEXTURE_BAD_NAME;
            entry.ErrorType = ErrorReportType.ERROR_REPORT_TYPE_CRITICAL;


            AddNewRow(entry);
        }

        private void listViewErrors_MouseClick(object sender, MouseEventArgs e)
        {
            if (listViewErrors.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewErrors.SelectedItems[0];
                //MessageBox.Show(item.ToString());
            }
        }

        private void listViewErrors_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            int column = e.Column;

            //MessageBox.Show(column.ToString());

        }
    }
}
