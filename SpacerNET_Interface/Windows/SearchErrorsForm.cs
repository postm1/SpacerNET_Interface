using SpacerUnion.Common;
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

            buttonErrorsSearch.Text = Localizator.Get("ERROR_REPORT_BUTTON_FIND_ALL");

            comboBoxErrFilter.Items.Clear();

            comboBoxErrFilter.Items.Add(Localizator.Get("ERROR_REPORT_TYPE_ALL"));
            comboBoxErrFilter.Items.Add(Localizator.Get("ERROR_REPORT_TYPE_INFO"));
            comboBoxErrFilter.Items.Add(Localizator.Get("ERROR_REPORT_TYPE_WARNING"));
            comboBoxErrFilter.Items.Add(Localizator.Get("ERROR_REPORT_TYPE_CRITICAL"));

            comboBoxErrFilter.SelectedIndex = 0;
        }

        private void SearchErrorsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //wtf why? Only this windows has this bug
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
                listViewErrors.Items.Clear();
            }

            listViewErrors.Enabled = toggle;
            buttonErrorsSearch.Enabled = toggle;
            comboBoxErrFilter.Enabled = toggle;
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
            entry.id = form.entriesList.Count;
            form.entriesList.Add(entry);

        }


        public void OnRemoveVob(uint addr)
        {
            if (addr == 0) return;

            var foundEntry = entriesList.FirstOrDefault(entry => entry.objectAddr == addr);

            if (foundEntry == null)
            {
                return;
            }

            entriesList.Remove(foundEntry);

            //changing indexes after removing vob
            for (int i = 0; i < entriesList.Count; i++)
            {
                //Console.WriteLine("{0} -> {1}", entriesList[i].id, i);
                entriesList[i].id = i;
            }


            UpdateListFilter(comboBoxErrFilter.SelectedIndex);
        }

        public void SelectEntry(int row)
        {

            if (entriesList.Count - 1 >= row)
            {
                var entry = entriesList[row];

                if (entry.ObjectAddr > 0)
                {

                    if (ObjTree.globalEntries.ContainsKey(entry.ObjectAddr))
                    {
                        SpacerNET.objTreeWin.globalTree.SelectedNode =
                       ObjTree.globalEntries[entry.ObjectAddr].node;

                        Imports.Extern_SelectVobSync(entry.ObjectAddr);
                    }
                    else
                    {
                        ConsoleEx.WriteLineGreen("ErrReportWin can't select object with addr: " + Utils.ToHex(entry.ObjectAddr));
                    }


                    Imports.Extern_SelectVob(entry.ObjectAddr);

                }

               
            }
        }

        public void UpdateListFilter(int index)
        {
            listViewErrors.BeginUpdate();
            listViewErrors.Items.Clear();

            foreach (var entry in entriesList)
            {
                if (index == 0)
                {
                    AddNewRow(entry);
                }
                else if (entry.ErrorType == (ErrorReportType)index)
                {
                    AddNewRow(entry);
                }
            }



            listViewErrors.EndUpdate();

            if (listViewErrors.Items.Count == 0)
            {
                listViewErrors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                listViewErrors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
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

            //save real id of element
            newItem.Tag = entry.id;
            listViewErrors.Items.Add(newItem);

            
            //ConsoleEx.WriteLineGreen(entry.GetDescriptionText());
        }

        private void buttonErrorsSearch_Click(object sender, EventArgs e)
        {
            entriesList.Clear();
            Imports.Extern_ReportCreateAll();

            UpdateListFilter(comboBoxErrFilter.SelectedIndex);


            if (listViewErrors.Items.Count == 0)
            {
                MessageBox.Show(Localizator.Get("ERROR_REPORT_NO_ERRORS"));
            }
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

            int rowIndex = Convert.ToInt32(hit.Item.Tag);


            SelectEntry(rowIndex);

            // MessageBox.Show(rowIndex + "/" + columnindex + " " + hit.SubItem.Text);
        }

        private void comboBoxErrFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListFilter(comboBoxErrFilter.SelectedIndex);
        }

        private void SearchErrorsForm_VisibleChanged(object sender, EventArgs e)
        {
            SpacerNET.form.toolStripButtonErrorReport.Checked = this.Visible;
        }

        private void SearchErrorsForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ErrorWinLocation != null)
            {
                this.Location = Properties.Settings.Default.ErrorWinLocation;
            }
        }
    }
}
