using SpacerUnion.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpacerUnion.Windows
{
   
    public partial class MaterialFilterForm : Form
    {
        public List<MatFilter> filters;

        public Dictionary<string, uint> matAddr;

        public ConfirmForm formConf;

        public MaterialFilterForm()
        {
            InitializeComponent();
            filters = new List<MatFilter>();
            matAddr = new Dictionary<string, uint>();

            formConf = new ConfirmForm(null);
        }

        public void OnClose()
        {
            Imports.Extern_FilterMat_SaveFilters();
        }
        private void MaterialFilterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            OnClose();
        }

        public void OnFilterIndexChange(int index)
        {
            if (index == 0)
            {
                buttonFltRename.Enabled = false;
                buttonSavePML_File.Enabled = false;
            }
            else if (index != -1)
            {
                buttonFltRename.Enabled = true;
                buttonSavePML_File.Enabled = true;
            }
            else
            {
                //buttonFltRename.Enabled = false;
            }
        }

        private void listBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = sender as ListBox;

            if (listBox != null)
            {
                int index = listBox.SelectedIndex;


                OnFilterIndexChange(index);

                if (index != -1)
                {
                    listBoxMatList.BeginUpdate();
                    listBoxMatList.Items.Clear();
                    listBoxMatFilSearch.Items.Clear();
                    matAddr.Clear();

                    Imports.Stack_PushString(listBox.SelectedItem.ToString());
                    Imports.Extern_FillMatListByFilterName();

                    listBoxMatList.Sorted = true;
                    listBoxMatList.EndUpdate();

                    if (listBoxMatList.SelectedItem == null && listBoxMatList.Items.Count > 0)
                    {
                        listBoxMatList.SelectedIndex = 0;
                        groupBoxMatSettings.Enabled = true;
                    }
                    else
                    {
                        groupBoxMatSettings.Enabled = false;
                    }
                    labelMatCount.Text = "Список материалов: " + listBoxMatList.Items.Count.ToString();
                }
                
            }
        }

        private void ProcessUsingLockbitsAndUnsafeAndParallel(Bitmap processedBitmap)
        {
            unsafe
            {
                BitmapData bitmapData = processedBitmap.LockBits(new Rectangle(0, 0, processedBitmap.Width, processedBitmap.Height), ImageLockMode.ReadWrite, processedBitmap.PixelFormat);

                int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(processedBitmap.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;
                byte* PtrFirstPixel = (byte*)bitmapData.Scan0;

                Parallel.For(0, heightInPixels, y =>
                {
                    byte* currentLine = PtrFirstPixel + (y * bitmapData.Stride);
                    for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                    {
                        int oldBlue = currentLine[x];
                        int oldGreen = currentLine[x + 1];
                        int oldRed = currentLine[x + 2];

                        currentLine[x] = (byte)oldBlue;
                        currentLine[x + 1] = (byte)oldGreen;
                        currentLine[x + 2] = (byte)oldRed;
                    }
                });
                processedBitmap.UnlockBits(bitmapData);
            }
        }

        private void listBoxMatList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMatList.SelectedItem != null)
            {
                string text = listBoxMatList.GetItemText(listBoxMatList.SelectedItem);

                if (matAddr.ContainsKey(text))
                {
                    uint addr = matAddr[text];
                    Imports.Extern_SelectMat(addr);


                    comboBoxApplyFilter.BeginUpdate();
                    comboBoxApplyFilter.Items.Clear();

                    for (int i = 0; i < listBoxFilter.Items.Count; i++)
                    {
                        comboBoxApplyFilter.Items.Add(listBoxFilter.Items[i]);
                    }

                    //ConsoleEx.WriteLineYellow("listBoxMatList_SelectedIndexChanged");

                    UpdateMatGroupAndFilter();



                    comboBoxApplyFilter.EndUpdate();

                    groupBoxMatSettings.Enabled = true;




                }
            }
            else
            {
                groupBoxMatSettings.Enabled = false;
            }
            
        }

        private void comboBoxApplyFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxApplyGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void UpdateMatGroupAndFilter()
        {
            comboBoxApplyFilter.SelectedIndex = Imports.Extern_FillMat_GetCurrentMat_FilterIndex();
            comboBoxApplyGroup.SelectedIndex = Imports.Extern_FillMat_GetCurrentMat_GroupIndex();
        }

        private void buttonApplyMatSettings_Click(object sender, EventArgs e)
        {
            int libFlag = comboBoxApplyFilter.SelectedIndex;
            int group = comboBoxApplyGroup.SelectedIndex;

            Imports.Extern_FillMat_ApplyFilterAndGroup(libFlag, group);

            UpdateMatGroupAndFilter();
        }

        private void buttonMatFilterSaveAll_Click(object sender, EventArgs e)
        {
            Imports.Extern_FilterMat_SaveFilters();

        }

        
        public void OnRenameFilter(string name)
        {

            if (name.Length == 0)
            {
                MessageBox.Show("Имя не может быть пустым!");
                return;
            }

            if (listBoxFilter.Items.Contains(name))
            {
                MessageBox.Show("Такое имя уже есть!");
                return;
            }

            if (!Utils.IsOnlyLatin(name) && Utils.IsOptionActive("checkBoxOnlyLatinInInput"))
            {
                MessageBox.Show(Localizator.Get("FORM_ENTER_BAD_STRING_INPUT"));
                return;
            }

            listBoxFilter.Items[listBoxFilter.SelectedIndex] = name;

            Imports.Stack_PushString(name);
            Imports.Stack_PushInt(listBoxFilter.SelectedIndex);
            Imports.Extern_MatFilter_RenameFilter();



            Imports.Extern_FilterMat_SaveFilters();

            Imports.Stack_PushInt(listBoxFilter.SelectedIndex);
            Imports.Extern_MatFilter_SaveCurrentFilter();


            listBoxFilter_SelectedIndexChanged(listBoxFilter, null);


        }
        public void OnCreateNewFilter(string name)
        {

            if (name.Length == 0)
            {
                MessageBox.Show("Имя не может быть пустым!");
                return;
            }

            if (listBoxFilter.Items.Contains(name))
            {
                MessageBox.Show("Такое имя уже есть!");
                return;
            }

            if (!Utils.IsOnlyLatin(name) && Utils.IsOptionActive("checkBoxOnlyLatinInInput"))
            {
                MessageBox.Show(Localizator.Get("FORM_ENTER_BAD_STRING_INPUT"));
                return;
            }

            listBoxFilter.Items.Add(name);

            listBoxFilter.SelectedItem = name;

            Imports.Stack_PushString(name);
            Imports.Extern_FillMat_AddNewFilter();

            comboBoxApplyFilter.BeginUpdate();
            comboBoxApplyFilter.Items.Clear();

            for (int i = 0; i < listBoxFilter.Items.Count; i++)
            {
                comboBoxApplyFilter.Items.Add(listBoxFilter.Items[i]);
            }

            ConsoleEx.WriteLineYellow("OnCreateNewFilter");

            UpdateMatGroupAndFilter();



            comboBoxApplyFilter.EndUpdate();

            listBoxFilter.Focus();

        }

        private void buttonFilterNew_Click(object sender, EventArgs e)
        {
          formConf.buttonConfirmNo.Text = Localizator.Get("WIN_COMPLIGHT_CLOSEBUTTON");
          formConf.buttonConfirmYes.Text = Localizator.Get("WIN_BTN_CONFIRM");
          formConf.labelTextShow.Text = Localizator.Get("MSG_MATFILTER_NEW_NAME");
          formConf.confType = "MATFILTER_NEWFILTER";

          formConf.ShowDialog();
        }

        private void buttonSavePML_File_Click(object sender, EventArgs e)
        {
            if (listBoxFilter.SelectedItem != null)
            {
                Imports.Stack_PushInt(listBoxFilter.SelectedIndex);
                Imports.Extern_MatFilter_SaveCurrentFilter();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxFilter.SelectedIndex != -1)
            {
                formConf.buttonConfirmNo.Text = Localizator.Get("WIN_COMPLIGHT_CLOSEBUTTON");
                formConf.buttonConfirmYes.Text = Localizator.Get("WIN_BTN_CONFIRM");
                formConf.labelTextShow.Text = Localizator.Get("MSG_MATFILTER_RENAME");
                formConf.confType = "MATFILTER_RENAME_FILTER";

                formConf.ShowDialog();
            }
        }

        private void textBoxFilterSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                string text = textBoxFilterSearch.Text.Trim().ToUpper();

                if (text.Length > 0)
                {
                    listBoxMatFilSearch.BeginUpdate();
                    listBoxMatFilSearch.Items.Clear();

                    for (int i = 0; i < matAddr.Count; i++)
                    {
                        var entry = matAddr.ElementAt(i);

                        if (entry.Key == text || entry.Key.Contains(text))
                        {
                            listBoxMatFilSearch.Items.Add(entry.Key);
                        }

                    }

                    listBoxMatFilSearch.EndUpdate();
                }
            }
        }

        private void listBoxMatFilSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMatFilSearch.SelectedIndex != -1)
            {
                string text = listBoxMatFilSearch.GetItemText(listBoxMatFilSearch.SelectedItem);

                if (listBoxMatList.Items.Contains(text))
                {
                    listBoxMatList.SelectedItem = text;
                }
            }
        }
    }

    public class MatFilter
    {
        public string name;
        public int id;
    }

}
