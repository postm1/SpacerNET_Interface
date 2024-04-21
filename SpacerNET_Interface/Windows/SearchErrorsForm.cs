﻿using SpacerUnion.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

            comboBoxErrFilter.SelectedIndex = 0;
        }

        public void UpdateLang()
        {
            this.Text = Localizator.Get("ERROR_REPORT_TITLE");
            listViewErrors.Columns[1].Text = Localizator.Get("ERROR_REPORT_COLUMN_PROBLEM_TYPE");
            listViewErrors.Columns[2].Text = Localizator.Get("ERROR_REPORT_COLUMN_PROBLEM_LEVEL");
            listViewErrors.Columns[3].Text = Localizator.Get("ERROR_REPORT_COLUMN_PROBLEM_DESC");
            listViewErrors.Columns[4].Text = Localizator.Get("ERROR_REPORT_COLUMN_PROBLEM_ACTION");

        }

        private void SearchErrorsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        public void ToggleInterface(bool toggle)
        {

            if (!toggle)
            {
                //listViewErrors.Clear();
            }

            listViewErrors.Enabled = toggle;
            buttonErrorsSearch.Enabled = toggle;
        }


        [DllExport]
        public static void Report_AddReport()
        {
            var form = SpacerNET.errorForm;


            ErrorReportEntry entry = null;

            entry = new ErrorReportEntry();

            entry.SetErrorType((ErrorReportType)Imports.Stack_PeekInt());
            entry.SetProblemType((ErrorReportProblemType)Imports.Stack_PeekInt());
            entry.ObjectAddr = Imports.Stack_PeekUInt();
            entry.vobName = Imports.Stack_PeekString();
            entry.materialName = Imports.Stack_PeekString();
            entry.textureName = Imports.Stack_PeekString();

            form.entriesList.Add(entry);

        }

        public void SelectEntry(int row)
        {
            //row index starts from 1, not 0
            row -= 1;

            if (entriesList.Count - 1 >= row)
            {
                var entry = entriesList[row];

                MessageBox.Show(entry.GetProblemTypeText());
            }
        }

        public void UpdateListFilter(int index)
        {
            listViewErrors.Items.Clear();

            listViewErrors.BeginUpdate();

            foreach (var entry in entriesList)
            {
                if (index == 0)
                {
                    AddNewRow(entry);
                }
                else
                {

                }
                if (entry.ErrorType == (ErrorReportType)index)
                {
                    AddNewRow(entry);
                }
            }



            listViewErrors.EndUpdate();
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

            
            //ConsoleEx.WriteLineGreen(entry.GetDescriptionText());
        }

        private void buttonErrorsSearch_Click(object sender, EventArgs e)
        {
            listViewErrors.Items.Clear();
            entriesList.Clear();

            listViewErrors.BeginUpdate();

            Imports.Extern_ReportCreateAll();

            UpdateListFilter(comboBoxErrFilter.SelectedIndex);
            listViewErrors.EndUpdate();


            listViewErrors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
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


            SelectEntry(rowIndex);

            // MessageBox.Show(rowIndex + "/" + columnindex + " " + hit.SubItem.Text);
        }

        private void comboBoxErrFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListFilter(comboBoxErrFilter.SelectedIndex);
        }
    }
}
