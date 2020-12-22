using FBExpert.DataClasses;
using FBXpert.DataClasses;
using FBXpert.Globals;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FBXpert.SonstForms
{
    public partial class ExportTablesDLLForm : Form
    {
        public DBRegistrationClass dbReg;

        public List<TableClass> Tables;

        public ExportTablesDLLForm(Form parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
        }

        public void ExportAllTablesDLL()
        {
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            int n = 0;
            if (ckCreateAlterTable.Checked) n++;
            if (ckCreateTableDLL.Checked) n++;
            progressBar1.Maximum = Tables.Count*n;
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
            foreach (var table in Tables)
            {
                try
                {
                    if (ckCreateTableDLL.Checked)
                    {
                        string fna = Path.Combine(path, $@"{table.Name}_createDLL.sql");
                        string dll = AppStaticFunctionsClass.CreateComment() + CreateDLLClass.CreateTabelDLL(table, eCreateMode.create);
                        File.WriteAllText(fna, dll);
                        progressBar1.Value++;
                    }
                    /*
                    if (ckCreateView.Checked)
                    {
                        string fnc = Path.Combine(path, $@"{table.Name}_create.sql");
                        string dll = AppStaticFunctionsClass.CreateComment() + CreateDLLClass.CreateTabelDLL(table, eCreateMode.create);
                        File.WriteAllText(fnc, dll);
                        progressBar1.Value++;
                    }
                    */
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
            ExportAllTablesDLL();
        }

        private void ExportTablesDLLForm_Load(object sender, EventArgs e)
        {
            txtSQLExportPath.Text = Path.Combine(dbReg.InitialSQLExportPath,"Tables");
        }

        private void hsInitialSQLExportPath_Click(object sender, EventArgs e)
        {
            fbdPath.SelectedPath = txtSQLExportPath.Text;
            if (fbdPath.ShowDialog() != DialogResult.OK) return;
            txtSQLExportPath.Text = fbdPath.SelectedPath;
        }
    }
}
