using FBExpert;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using FBXpert.Globals;
using System.Diagnostics;
using System.IO;

namespace FBXpert
{
    public partial class DatabaseStatisticsForm : Form
    {
        string pre = @"{\rtf1\ansi\deff0{\fonttbl{\f0\fnil\fcharset0 Consolas;}}\viewkind4\uc1\pard\lang1031\f0\fs18 ";
        string post = @"\par}";

        StringBuilder info = new StringBuilder();
        DBRegistrationClass dbReg = null;
        public DatabaseStatisticsForm(Form parent, DBRegistrationClass drc)
        {
            InitializeComponent();
            rtbInfo.Rtf = "";
            dbReg = drc;
            if(parent != null)
            {
                this.MdiParent = parent;
            }
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

        public void SetTitle(string title)
        {
            this.Text = title;
        }
        private void DatabaseStatisticsForm_Load(object sender, EventArgs e)
        {
            RefreshStatistics();
            TableStatistics();
        }
        private void RefreshStatistics()
        {
            List<string> data = StaticTreeClass.Instance().GetDatabaseStatistics(dbReg);
            rtbInfo.Clear();
            info.Clear();
            info.Append(pre);
            foreach (string str in data)
            {
                 this.AddLine(str);
            }
            this.Set();
            this.SetTitle("Statistics for " + dbReg.Alias);
        }

        private void hsRefreshDatabases_Click(object sender, EventArgs e)
        {
            RefreshStatistics();
        }

        private void hotSpot1_Click(object sender, EventArgs e)
        {
            TableStatistics();
        }

        private void TableStatistics()
        {
            fctTableStatistics.Clear();
            string args = $"-u SYSDBA -p masterkey -r -d {dbReg.DatabasePath}";
            ProcessStartInfo psi = new ProcessStartInfo($@"{Application.StartupPath}\FB302\Firebird\gstat.exe",args);            
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            
            Process ps = new Process();
            ps.StartInfo = psi;
            ps.Start();
            StreamReader reader = ps.StandardOutput;
            string output = reader.ReadToEnd();       
            fctTableStatistics.AppendText(output);

            ps.WaitForExit();
            ps.Close();

        }
    }
}
