using System;
using System.Text;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class HelpInfoForm : Form
    {
        string pre = @"{\rtf1\ansi\deff0{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}\viewkind4\uc1\pard\lang1031\f0\fs21 ";
        string post = @"\par}";

        StringBuilder info = new StringBuilder();
        public HelpInfoForm()
        {
            InitializeComponent();
            rtbInfo.Rtf = "";
            info.Append(pre);
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void AddLine(string line)
        {
            info.Append(line);
            AddNewLine();
        }

        public void Add(string line)
        {
            info.Append(line);
        }

        public void AddTab()
        {
            info.Append(@"\tab ");
        }

        public void AddBold(string line)
        {
            info.Append(@" \b " + line + @" \b0 ");            
        }

        public void AddNewLine()
        {
            info.Append(@"\line ");
        }

        public void BoldOn()
        {
            info.Append(@"\b ");
        }

        public void BoldOff()
        {
            info.Append(@"\b0 ");
        }

        public void AddBoldLine(string line)
        {
            info.Append(@"\b " + line + @" \b0 ");
            AddNewLine();
        }

        public void SetFontSize(int sz)
        {
            info.Append(@"\fs "+sz.ToString()+" ");
        }

        public void Set()
        {
            
            if (info.Length > 0)
                rtbInfo.Rtf = info.ToString() + post;
            else rtbInfo.Rtf = "";
        }

    }
}
