using FBExpert.DataClasses;
using FBXpert.DataClasses;
using FBXpert.Globals;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FBXpert.SonstForms
{
    public partial class ExportViewsSQLForm : Form
    {
        public DBRegistrationClass dbReg;

        public Dictionary<string, ViewClass> views;

        public ExportViewsSQLForm(Form parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
        }

        public void ExportAllViewsSQL()
        {
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            int n = 0;
            if (ckCreateView.Checked) n++;
            if (ckAlterView.Checked) n++;
            progressBar1.Maximum = views.Count*n;
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
            foreach (var view in views.Values)
            {
                try
                {
                    if (ckAlterView.Checked)
                    {
                        string fna = Path.Combine(path, $@"{view.Name}_alter.sql");
                        File.WriteAllText(fna, view.CREATEINSERT_SQL);
                        progressBar1.Value++;
                    }
                    if (ckCreateView.Checked)
                    {
                        string fnc = Path.Combine(path, $@"{view.Name}_create.sql");
                        File.WriteAllText(fnc, view.CREATE_SQL);
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

        public void SetControlSizes()
        {
            pnlFormUpper.Height = AppSizeConstants.UpperFormBandHeight;

        }
        private void ExportViewsSQLForm_Load(object sender, EventArgs e)
        {
            SetControlSizes();
            FormDesign.SetFormLeft(this);
            txtSQLExportPath.Text = Path.Combine(AppSettingsClass.Instance.PathSettings.SQLExportPath,"Views");
        }

        private void hsInitialSQLExportPath_Click(object sender, EventArgs e)
        {
            fbdPath.SelectedPath = txtSQLExportPath.Text;
            if (fbdPath.ShowDialog() != DialogResult.OK) return;
            txtSQLExportPath.Text = fbdPath.SelectedPath;
        }
    }
}
