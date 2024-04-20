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
        public List<ErrorReportEntry> entriesList;

        public SearchErrorsForm()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            Helper.EnableDoubleBuffering(this.listViewErrors);

            entriesList = new List<ErrorReportEntry>();
        }

        public void UpdateLang()
        {

        }

        private void SearchErrorsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        public void SelectEntry(int row)
        {
            row -= 1;

            if (entriesList.Count - 1 >= row)
            {
                var entry = entriesList[row];

                MessageBox.Show(entry.GetProblemTypeText());
            }
        }

        public void AddNewRow(ErrorReportEntry entry)
        {
            var rowColor = Color.White;
            List<string> texts = new List<string>();

            texts.Add((listViewErrors.Items.Count + 1).ToString());
            texts.Add(entry.GetProblemTypeText());
            texts.Add(entry.GetReportTypeText());
            texts.Add(entry.GetDescriptionText());
            texts.Add(entry.GetLinkText());

            ListViewItem newItem = new ListViewItem(texts.ToArray());

            newItem.UseItemStyleForSubItems = false;


            // even string has another color
            if (listViewErrors.Items.Count % 2 == 0)
            {
                rowColor = Color.FromArgb(255, 236, 237, 239);
            }

            newItem.SubItems[0].BackColor = rowColor;
            newItem.SubItems[1].BackColor = rowColor;
            newItem.SubItems[2].BackColor = entry.GetTypeBackColor();
            newItem.SubItems[3].BackColor = rowColor;
            newItem.SubItems[4].BackColor = rowColor;

            listViewErrors.Items.Add(newItem);

            entriesList.Add(entry);
        }

        private void buttonErrorsSearch_Click(object sender, EventArgs e)
        {
            listViewErrors.Items.Clear();
            entriesList.Clear();



            ErrorReportEntry entry = new ErrorReportEntry();

            entry.ProblemType = ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_TEXTURE_NOT_FOUND;
            entry.ErrorType = ErrorReportType.ERROR_REPORT_TYPE_CRITICAL;
            AddNewRow(entry);

            entry = new ErrorReportEntry();
            entry.ProblemType = ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_NAME;
            entry.ErrorType = ErrorReportType.ERROR_REPORT_TYPE_WARNING;
            AddNewRow(entry);


            entry = new ErrorReportEntry();
            entry.ProblemType = ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_TEXTURE_BAD_NAME;
            entry.ErrorType = ErrorReportType.ERROR_REPORT_TYPE_CRITICAL;
            AddNewRow(entry);

            entry = new ErrorReportEntry();
            entry.ProblemType = ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_TEXTURE_BAD_NAME;
            entry.ErrorType = ErrorReportType.ERROR_REPORT_TYPE_CRITICAL;
            AddNewRow(entry);


            entry = new ErrorReportEntry();
            entry.ProblemType = ErrorReportProblemType.ERROR_REPORT_PROBLEM_TYPE_MESH_MAT_NAME;
            entry.ErrorType = ErrorReportType.ERROR_REPORT_TYPE_WARNING;
            AddNewRow(entry);


            listViewErrors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void listViewErrors_MouseClick(object sender, MouseEventArgs e)
        {

            //Point mousePosition = listViewErrors.PointToClient(Control.MousePosition);
            //ListViewHitTestInfo hit = listViewErrors.HitTest(mousePosition);

            //if (hit == null)
            //{
            //    return;
            //}

            //int columnindex = hit.Item.SubItems.IndexOf(hit.SubItem);
            //int rowIndex = Convert.ToInt32(hit.Item.Text);

            ////MessageBox.Show(rowIndex + "/" + columnindex + " " + hit.SubItem.Text);
            ////MessageBox.Show(columnindex.ToString() + " " + columnindex + " " + rowIndex);
        }

        private void listViewErrors_MouseDown(object sender, MouseEventArgs e)
        {
            Point mousePosition = listViewErrors.PointToClient(Control.MousePosition);
            ListViewHitTestInfo hit = listViewErrors.HitTest(mousePosition);

            if (hit == null || hit.SubItem == null)
            {
                return;
            }


            if (e.Button == MouseButtons.Middle)
            {
                Utils.SetCopyText(hit.SubItem.Text);
            }

            //MessageBox.Show(rowIndex + "/" + columnindex + " " + hit.SubItem.Text);
        }

        
        private void listViewErrors_DoubleClick(object sender, EventArgs e)
        {
            Point mousePosition = listViewErrors.PointToClient(Control.MousePosition);
            ListViewHitTestInfo hit = listViewErrors.HitTest(mousePosition);

            if (hit == null || hit.SubItem == null)
            {
                return;
            }

            int columnindex = hit.Item.SubItems.IndexOf(hit.SubItem);
            int rowIndex = Convert.ToInt32(hit.Item.Text);


            if (columnindex == 4)
            {
                SelectEntry(rowIndex);
            }

            // MessageBox.Show(rowIndex + "/" + columnindex + " " + hit.SubItem.Text);
        }
    }
}
