using FBXpert.DataClasses;
using FBXpert.MiscClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class TextInfoForm : Form
    {
        public TextInfoForm(Form parent)
        {
            InitializeComponent();
            fctInfo.Text = "";
            this.MdiParent = parent;
            SearchFCT = new SearchFastColorTextboxClass(fctInfo);
        }

        SearchFastColorTextboxClass SearchFCT;

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public  string SearchPattern
        {
            set => txtSearchPattern.Text = value;
            get => txtSearchPattern.Text;
        }

        public void Set(string txt)
        {
            fctInfo.Text = txt; 
        }
        public void Append(string txt)
        {
            fctInfo.AppendText(txt);
        }

        public void SetTitle(string title)
        {
            this.Text = title;
        }

        public bool IgnoreCase
        {
            set => ckCaseSensitive.Checked = !value;
            get => !ckCaseSensitive.Checked;
        }

        

        private void hsFindPattern_Click(object sender, EventArgs e)
        {
            FindPattern();
        }

            private void hsFindNext_Click(object sender, EventArgs e)
        {
            SearchFCT.GoToNext();
            label1.Text = $@"Found:{SearchFCT.FoundCount}";
        }

        private void hsPrev_Click(object sender, EventArgs e)
        {
            SearchFCT.GoToPrev();
            label1.Text = $@"Found:{SearchFCT.FoundCount}";
        }

        private void hsSearchNextFromStart_Click(object sender, EventArgs e)
        {
            SearchFCT.GoToFirst();
            label1.Text = $@"Found:{SearchFCT.FoundCount}";
        }
       

        private void hsSearchLast_Click(object sender, EventArgs e)
        {
            
        }

        private void hsSaveText_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = AppSettingsClass.Instance.PathSettings.SQLExportPath;
            saveFileDialog1.Title = "Save SQL search results";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fctInfo.SaveToFile(saveFileDialog1.FileName, System.Text.Encoding.UTF8);
            }
        }

        private void txtSearchPattern_TextChanged(object sender, EventArgs e)
        {
            SearchFCT.NewSearchPattern(txtSearchPattern.Text);
            gbNavigate.Enabled = false;
        }

        private void TextInfoForm_Load(object sender, EventArgs e)
        {
            
            FindPattern();
            
        }
        private void FindPattern()
        {
            if (txtSearchPattern.Text.Length <= 0) return;
            SearchFCT.NewSearchPattern(txtSearchPattern.Text);
            SearchFCT.CaseSensitivity = ckCaseSensitive.Checked;
            SearchFCT.WholeWord = ckWholeWords.Checked;
            SearchFCT.GoToFirst();
            label1.Text = $@"Found:{SearchFCT.FoundCount}";
            gbNavigate.Enabled = SearchFCT.FoundCount > 0;
        }


        private void ckCaseSensitive_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSearchPattern.Text.Length <= 0) return;
            SearchFCT.NewSearchPattern(txtSearchPattern.Text);
            SearchFCT.CaseSensitivity = ckCaseSensitive.Checked;
            SearchFCT.GoToFirst();
            label1.Text = $@"Found:{SearchFCT.FoundCount}";
        }

        private void ckWholeWords_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSearchPattern.Text.Length <= 0) return;
            SearchFCT.NewSearchPattern(txtSearchPattern.Text);
            SearchFCT.WholeWord =  ckWholeWords.Checked;
            SearchFCT.GoToFirst();
            label1.Text = $@"Found:{SearchFCT.FoundCount}";
        }

        private void txtSearchPattern_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                FindPattern();
            }
        }
    }
}
