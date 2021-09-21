using BasicClassLibrary;
using DBBasicClassLibrary;
using FBXpert.DesignReport;
using FBXpert.Globals;
using FBXpert.KonfigurationForms;
using Initialization;
using MessageFormLibrary;

using SharedStorages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FBXpert.SonstForms
{
    public partial class ReportDesignForm : Form
    {
        private readonly DBRegistrationClass _dbReg;

        NotifiesClass _notifies=null;
        public ReportDesignForm(Form parent, DBRegistrationClass dbReg, NotifiesClass notifies)
        {
            InitializeComponent();
            _notifies = notifies;
            _dbReg = dbReg;
            SetMdiParent(parent);
        }

        public void SetMdiParent(Form parent)
        {
            MdiParent = parent;
        }

        [Serializable]
        class MerkeWerte
        {
            public string ReportFileName;
            public string XmlDataFileName;
            public string XsdSchemaFileName;
            public List<ReportSqlCommands> SqlCommands = new List<ReportSqlCommands>();
        };

        private MerkeWerte _mw = new MerkeWerte();
        private readonly SharedStorage _ss = new SharedStorage();

        private void AddCbReportFileText(string txt)
        {
            int inx = cbReportFile.FindStringExact(txt);
            if(inx < 0)
            {
                cbReportFile.Items.Add(txt);
            }            
            cbReportFile.Text = txt;
        }
        private void AddCbXSDFileText(string txt)
        {
            int inx = cbXSDFile.FindStringExact(txt);
            if(inx < 0)
            {
                cbXSDFile.Items.Add(txt);
            }            
            cbXSDFile.Text = txt;
        }
        private void AddCbXMLFileText(string txt)
        {
            int inx = cbXMLFile.FindStringExact(txt);
            if(inx < 0)
            {
                cbXMLFile.Items.Add(txt);
            }            
            cbXMLFile.Text = txt;
        }

        private void LoadUserDesign()
        {
            _ss.SharedFolder = ApplicationPathClass.Instance.GetFullPath(Application.UserAppDataPath);
            _ss.StorageName = Name;
            _ss.DestroyWhenDisposed = false;
            try
            {
                var mw2 = (MerkeWerte)_ss[Name];
                if (mw2 == null) return;
                _mw = mw2;
                
                AddCbXMLFileText(_mw.XmlDataFileName);
                if(!string.IsNullOrEmpty(_mw.XmlDataFileName)) fctXML.OpenFile(_mw.XmlDataFileName);
                AddCbXSDFileText(_mw.XsdSchemaFileName);
                if(!string.IsNullOrEmpty(_mw.XsdSchemaFileName)) fctXSD.OpenFile(_mw.XsdSchemaFileName);
                AddCbReportFileText(_mw.ReportFileName);
                if(!string.IsNullOrEmpty(_mw.ReportFileName)) fctFRX.OpenFile(_mw.ReportFileName);

                foreach (ReportSqlCommands scmd in _mw.SqlCommands)
                {
                    AddItem(scmd.cmd,scmd.caption);
                }

                if (lvCreateStatements.Items.Count > 0)
                {
                    lvCreateStatements.Items[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                _notifies?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{Name}-> LoadUserDesign()", ex));                                                                                                                  
            }
        }

        private void SaveUserDesign()
        {
            if ((_mw != null) && (_ss != null))
            {
                _mw.ReportFileName = cbReportFile.Text;
                _mw.XmlDataFileName = cbXMLFile.Text;
                _mw.XsdSchemaFileName = cbXSDFile.Text;
                _mw.SqlCommands = new List<ReportSqlCommands>();
                foreach (ListViewItem lvi in lvCreateStatements.Items)
                {
                    ReportSqlCommands rcmd = lvi.Tag as ReportSqlCommands;
                    _mw.SqlCommands.Add(rcmd);
                }
                _ss.SharedFolder = ApplicationPathClass.Instance.GetFullPath(Application.UserAppDataPath);
                _ss.StorageName = Name;
                _ss.AddOrUpdate(Name, _mw);                
            }
        }
       
        private void AddItem(string statement, string dataname)
        {
            string[] itm = {"",statement, dataname};
            var lvi = new ListViewItem(itm)
            {
                Tag = new ReportSqlCommands()
                {
                    caption = dataname,
                    cmd = statement
                },
                Checked = true
            };
            lvCreateStatements.Items.Add(lvi);            
        }

        private void ItemToEdit(ListViewItem lvi)
        {
            var oitm = (ReportSqlCommands) lvi?.Tag;
            txtDataName.Text = oitm?.caption;
            txtStatement.Text = oitm?.cmd;
        }

        private void hsAddStatement_Click(object sender, EventArgs e)
        {
            AddItem(txtStatement.Text, txtDataName.Text);
        }

        private void lvCreateStatements_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem lvi=null;
            if (lvCreateStatements.SelectedItems.Count > 0)
            {
                lvi = lvCreateStatements.SelectedItems[0];
            }
            ItemToEdit(lvi);
        }

        private void hsRemoveStatement_Click(object sender, EventArgs e)
        {
            if (lvCreateStatements.SelectedItems.Count > 0)
            {
                lvCreateStatements.SelectedItems[0].Remove();
            }
        }
       
        private void hsCreateReportFiles_Click(object sender, EventArgs e)
        {
            var rpt = new ReportDesignClass
            {
                Datafile = txtXMLDataFileNew.Text,
                Schemafile = txtXSDSchemaFileNew.Text,
                Reportfile = cbReportFile.Text
            };

            bool createFiles = true;
            if (File.Exists(rpt.Datafile) || File.Exists(rpt.Schemafile))
            {
                object[] param = { rpt.Datafile,rpt.Schemafile,Environment.NewLine };                    
                var dResult = SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "FileExistsCaption", "ReportDataFilesExisits",SEMessageBoxButtons.YesNoCancel, SEMessageBoxIcon.Exclamation, null, param);
                if (dResult == SEDialogResult.Cancel) return;
                createFiles =  (dResult == SEDialogResult.Yes);
            }

            if (createFiles)
            {
                foreach (ListViewItem lvi in lvCreateStatements.Items)
                {
                    if (!lvi.Checked) continue;
                    rpt.DataObjects.Add(lvi.Tag as ReportSqlCommands);
                }
                rpt.CreateReportDatas(_dbReg);
            }                            
            txtReportFileNameNew.Text = rpt.CreateDesignFp(new FastReport.Report());
        }

        private void hsXMLEditReport_Click(object sender, EventArgs e)
        {
            var tf = new XMLTreeForm(cbReportFile.Text);
            tf.Show();
        }

        private void hsEditXMLData_Click(object sender, EventArgs e)
        {
            var tf = new XMLTreeForm(FbXpertMainForm.Instance(), cbXMLFile.Text);
            tf.Show();
        }

        private void hsEditXSDData_Click(object sender, EventArgs e)
        {
            var tf = new XMLTreeForm(FbXpertMainForm.Instance(), cbXSDFile.Text);
            tf.Show();
        }

        private void hsReportFileWahl_Click(object sender, EventArgs e)
        {
            // ofdReportFile.InitialDirectory = PfadClass.Instance().EDVPfad;
            if (ofdReportFile.ShowDialog() != DialogResult.OK) return;
            
            AddCbReportFileText(ofdReportFile.FileName); 
            fctFRX.OpenFile(ofdReportFile.FileName);
            tabControlEditDesign.SelectedTab =  tabPageFRX;            
        }

        private void hsLoadXMLDataFile_Click(object sender, EventArgs e)
        {
            // ofdXMLDataFile.InitialDirectory = PfadClass.Instance().ReportDataPfad;
            if (ofdXMLDataFile.ShowDialog() != DialogResult.OK) return;
            
            AddCbXMLFileText(ofdXMLDataFile.FileName);
            fctXML.OpenFile(ofdXMLDataFile.FileName);
            tabControlEditDesign.SelectedTab =  tabPageXML;
            if (cbXSDFile.Text.Length >= 1) return;
            
            AddCbXSDFileText(cbXMLFile.Text.ToUpper().Replace(@".XML", @".XSD"));
            fctXSD.OpenFile(cbXMLFile.Text);                      
        }

        private void hsLoadSchemaFile_Click(object sender, EventArgs e)
        {           
            if (ofdXSDSchemaFile.ShowDialog() != DialogResult.OK) return;
            
            AddCbXSDFileText(ofdXSDSchemaFile.FileName);
            fctXSD.OpenFile(ofdXSDSchemaFile.FileName);
            tabControlEditDesign.SelectedTab =  tabPageXSD;                     
        }

        private void ReportDesignForm_Load(object sender, EventArgs e)
        {
            FormDesign.SetFormLeft(this);
            LoadUserDesign();         
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }
              
        private bool DataFilesExisting => (!string.IsNullOrEmpty(cbXMLFile.Text)) && (!string.IsNullOrEmpty(cbXSDFile.Text)) &&
                                      (File.Exists(cbXMLFile.Text)) && (File.Exists(cbXSDFile.Text));
       
        private void ReportDesignForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveUserDesign();
        }      

        private void hsCreateDatas_Click(object sender, EventArgs e)
        {
            var rpt = new ReportDesignClass
            {
                Datafile   = txtXMLDataFileNew.Text,
                Schemafile = txtXSDSchemaFileNew.Text,
                Reportfile = cbReportFile.Text
            };

            bool createFiles = true;
            if (File.Exists(rpt.Datafile) || File.Exists(rpt.Schemafile))
            {
                object[] param = { rpt.Datafile, rpt.Schemafile, Environment.NewLine };
            
                createFiles =

                (SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "FileExistsCaption", "ReportDataFilesExists",
                     SEMessageBoxButtons.NoYes, SEMessageBoxIcon.Exclamation, null, param) == SEDialogResult.Yes);

            }

            if (createFiles)
            {
                foreach (ListViewItem lvi in lvCreateStatements.Items)
                {
                    if (!lvi.Checked) continue;
                    rpt.DataObjects.Add(lvi.Tag as ReportSqlCommands);
                }
                rpt.CreateReportDatas(_dbReg);
            }            
            rpt.EditDesignFp(report1);
        }

        private void hsDesignEdit_Click_1(object sender, EventArgs e)
        {            
            if (DataFilesExisting && !string.IsNullOrEmpty(cbReportFile.Text) && File.Exists(cbReportFile.Text))
            {
                var rpt = report1; // new FastReport.Report();
                rpt.Load(cbReportFile.Text);
                //rpt.FileName = txtREPORTFILE.Text;
                var dorg = new FastReport.Data.XmlDataConnection
                {
                    XmlFile = cbXMLFile.Text,
                    XsdFile = cbXSDFile.Text,
                    ConnectionString = string.Format("XsdFile={1};XmlFile={0}", cbXMLFile.Text,cbXSDFile.Text)
                };

                rpt.Dictionary.AddChild(dorg);
                rpt.Design(false);
                
                if (File.Exists(cbReportFile.Text)) return;
                rpt.Save(cbReportFile.Text);
            }
            else
            {
                object[] param = { cbReportFile.Text, Environment.NewLine };
                SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "FileNotExistsCaption", "ReportFilesNotExists",SEMessageBoxButtons.OK, SEMessageBoxIcon.Exclamation, null, param);
            }            
        }

        private void hsNewReportFile_Click(object sender, EventArgs e)
        {
            if (ofdReportFile.ShowDialog() != DialogResult.OK) return;
            
            txtReportFileNameNew.Text = ofdReportFile.FileName;            
        }

        private void hsXmlFileNew_Click(object sender, EventArgs e)
        {
            if (ofdXMLDataFile.ShowDialog() != DialogResult.OK) return;
            
            txtXMLDataFileNew.Text = ofdXMLDataFile.FileName;
            if (txtXSDSchemaFileNew.Text.Length >= 1) return;
            
            txtXSDSchemaFileNew.Text = cbXMLFile.Text.ToUpper().Replace(@".XML", @".XSD");                        
        }

        private void hsSchemaFileNew_Click(object sender, EventArgs e)
        {
            if (ofdXSDSchemaFile.ShowDialog() != DialogResult.OK) return;
            
            txtXSDSchemaFileNew.Text =  ofdXSDSchemaFile.FileName;              
        }

        private void hsDataFileNew_Click(object sender, EventArgs e)
        {             
             new XMLTreeForm(txtXMLDataFileNew.Text).Show();            
        }

        private void hsReportSchemaFileNew_Click(object sender, EventArgs e)
        {            
             new XMLTreeForm(txtXSDSchemaFileNew.Text).Show();            
        }

        private void hsReportFileNewEdit_Click(object sender, EventArgs e)
        {
            new XMLTreeForm(txtReportFileNameNew.Text).Show();            
        }

        private void hsBlankReport_Click(object sender, EventArgs e)
        {
            new FastReport.Report().Design(this.MdiParent);            
        }

        private void hsSaveFRX_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = "Save FastReport definition file";
            saveFileDialog.Filter = "*.frx|FastReport";
            saveFileDialog.DefaultExt = "*.frx";
            if(saveFileDialog.ShowDialog() != DialogResult.OK) return;
            
            fctFRX.SaveToFile(saveFileDialog.FileName,Encoding.UTF8);            
        }

        private void hsSaveXSD_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = "Save FastReport scheme file";
            saveFileDialog.Filter = "*.xsd|FastReportScheme";
            saveFileDialog.DefaultExt = "*.xsd";
            if(saveFileDialog.ShowDialog() != DialogResult.OK) return;
            
            fctFRX.SaveToFile(saveFileDialog.FileName,Encoding.UTF8);            
        }

        private void hsSaveXML_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = "Save FastReport data file";
            saveFileDialog.Filter = "*.xml|FastReportData";
            saveFileDialog.DefaultExt = "*.xml";
            if(saveFileDialog.ShowDialog() != DialogResult.OK) return;
            
            fctFRX.SaveToFile(saveFileDialog.FileName,Encoding.UTF8);            
        }
    }
}
