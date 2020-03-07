using FBExpert;
using FBXpert.DataClasses;
using FBXpert.Globals;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FBXpert.SonstForms
{
    public partial class ExportFunctionsScriptForm : Form
    {
        public DBRegistrationClass dbReg;

        public Dictionary<string, FunctionClass> Functions;

        public ExportFunctionsScriptForm(Form parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
        }

        public void ExportAllViewsSQL()
        {
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            int n = 0;
            if (ckCreateFunction.Checked) n++;
            if (ckAlterFunction.Checked) n++;
            progressBar1.Maximum = Functions.Count*n;
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

                    }
                }
            }
            foreach (var Function in Functions.Values)
            {
                try
                {
                    if (ckAlterFunction.Checked)
                    {
                        string fna = Path.Combine(path, $@"{Function.Name}_alter.sql");
                        List<string> txt = StaticTreeClass.Instance().MakeSQLAlterFunction(Function,Function, true);
                        File.WriteAllLines(fna, txt);
                        progressBar1.Value++;
                    }
                    if (ckCreateFunction.Checked)
                    {
                        string fnc = Path.Combine(path, $@"{Function.Name}_create.sql");
                        List<string> txt = StaticTreeClass.Instance().MakeSQLCreateFunction(Function, true);
                        File.WriteAllLines(fnc, txt);
                        progressBar1.Value++;
                    }
                }
                catch (Exception ex)
                {
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

        private void ExportFunctionsScriptForm_Load(object sender, EventArgs e)
        {
            txtSQLExportPath.Text = Path.Combine(dbReg.InitialSQLExportPath,"Functions");
        }

        private void hsInitialSQLExportPath_Click(object sender, EventArgs e)
        {
            fbdPath.SelectedPath = txtSQLExportPath.Text;
            if (fbdPath.ShowDialog() != DialogResult.OK) return;
            txtSQLExportPath.Text = fbdPath.SelectedPath;
        }
    }
}
