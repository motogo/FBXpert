using FBExpert;
using FBExpert.DataClasses;
using FBXpert.Globals;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FBXpert.SonstForms
{
    public partial class ExportProceduresScriptForm : Form
    {
        public DBRegistrationClass dbReg;

        public Dictionary<string, ProcedureClass> procedures;

        public ExportProceduresScriptForm(Form parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
        }

        public void ExportAllViewsSQL()
        {
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            int n = 0;
            if (ckCreateProcedure.Checked) n++;
            if (ckAlterProcedure.Checked) n++;
            progressBar1.Maximum = procedures.Count*n;
            string path = Path.Combine(txtSQLExportPath.Text);
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            if (!Directory.Exists(path)) return;
            if (ckDeleteAllFiles.Checked)
            {
                string[] fls = Directory.GetFiles(path,"*.sql");
                foreach (string fn in fls)
                {
                    try
                    {
                        File.Delete(fn);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            foreach (var procedure in procedures.Values)
            {
                try
                {
                    if (ckAlterProcedure.Checked)
                    {
                        string fna = Path.Combine(path, $@"{procedure.Name}_alter.sql");
                        List<string> txt = StaticTreeClass.Instance().MakeSQLAlterProcedure(procedure,procedure, true);
                        File.WriteAllLines(fna, txt);
                        progressBar1.Value++;
                    }
                    if (ckCreateProcedure.Checked)
                    {
                        string fnc = Path.Combine(path, $@"{procedure.Name}_create.sql");
                        List<string> txt = StaticTreeClass.Instance().MakeSQLCreateProcedure(procedure, true);
                        File.WriteAllLines(fnc, txt);
                        progressBar1.Value++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hsExportViews_Click(object sender, EventArgs e)
        {
            ExportAllViewsSQL();
        }

        private void ExportProceduresScriptForm_Load(object sender, EventArgs e)
        {
            FormDesign.SetFormLeft(this);
            txtSQLExportPath.Text = Path.Combine(dbReg.InitialSQLExportPath,"Procedures");
        }

        private void hsInitialSQLExportPath_Click(object sender, EventArgs e)
        {
            fbdPath.SelectedPath = txtSQLExportPath.Text;
            if (fbdPath.ShowDialog() != DialogResult.OK) return;
            txtSQLExportPath.Text = fbdPath.SelectedPath;
        }
    }
}
