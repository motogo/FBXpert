using APPHelpLibrary;
using BasicClassLibrary;
using DBBasicClassLibrary;
using FBXpert.DesignReport;
using FBXpert.Globals;
using FBXpert.KonfigurationForms;
using FBXpertLib;
using Initialization;
using SEMessageBoxLibrary;
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

        NotifiesClass _notifies = null;
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
            if (inx < 0)
            {
                cbReportFile.Items.Add(txt);
            }
            cbReportFile.Text = txt;
        }
        private void AddCbXSDFileText(string txt)
        {
            int inx = cbXSDFile.FindStringExact(txt);
            if (inx < 0)
            {
                cbXSDFile.Items.Add(txt);
            }
            cbXSDFile.Text = txt;
        }
        private void AddCbXMLFileText(string txt)
        {
            int inx = cbXMLFile.FindStringExact(txt);
            if (inx < 0)
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
                if (!string.IsNullOrEmpty(_mw.XmlDataFileName)) fctXML.OpenFile(_mw.XmlDataFileName);
                AddCbXSDFileText(_mw.XsdSchemaFileName);
                if (!string.IsNullOrEmpty(_mw.XsdSchemaFileName)) fctXSD.OpenFile(_mw.XsdSchemaFileName);
                AddCbReportFileText(_mw.ReportFileName);
                if (!string.IsNullOrEmpty(_mw.ReportFileName)) fctFRX.OpenFile(_mw.ReportFileName);

                foreach (ReportSqlCommands scmd in _mw.SqlCommands)
                {
                    AddSQLItem(scmd.cmd, scmd.caption);
                }

                if (folSQL.Items.Count > 0)
                {
                    folSQL.Items[0].Selected = true;
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
                foreach (ReportSqlCommands rcmd in folSQL.Objects)
                {
                    _mw.SqlCommands.Add(rcmd);
                }
                _ss.SharedFolder = ApplicationPathClass.Instance.GetFullPath(Application.UserAppDataPath);
                _ss.StorageName = Name;
                _ss.AddOrUpdate(Name, _mw);
            }
        }

        private BrightIdeasSoftware.OLVColumn colFieldname;
        private BrightIdeasSoftware.OLVColumn colFieldType;
        private BrightIdeasSoftware.OLVColumn colFieldValue;
        private BrightIdeasSoftware.OLVColumn colValuesGroupName;

        private BrightIdeasSoftware.OLVColumn colSQLCaption;
        private BrightIdeasSoftware.OLVColumn colSQLCommand;
        private BrightIdeasSoftware.OLVColumn colSQLDone;
        // private BrightIdeasSoftware.OLVColumn colSQLGroupName;

        public void MakeSQLFieldGrid()
        {
            colSQLCommand = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            colSQLDone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            //colSQLGroupName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            colSQLCaption = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));

            colSQLDone.Text = "chk";
            colSQLDone.TextAlign = HorizontalAlignment.Center;
            colSQLDone.CheckBoxes = true;

            colSQLCommand.Text = "SQL";
            //  colSQLGroupName.Text = "Group";

            colSQLCommand.Width = 250;
            colSQLDone.Width = 100;

            //  colSQLGroupName.Width = 120;
            colSQLCaption.Text = "Caption";
            colSQLCaption.Width = 120;

            folSQL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            colSQLDone,
            colSQLCommand,
            colSQLCaption
     //       colSQLGroupName
            });

            folSQL.CellEditUseWholeCell = false;
            folSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            folSQL.HideSelection = false;
            folSQL.Location = new System.Drawing.Point(0, 0);
            folSQL.Name = "fastObjectListView1";
            folSQL.ShowGroups = false;
            folSQL.TabIndex = 4;
            folSQL.UseCompatibleStateImageBehavior = false;
            folSQL.View = System.Windows.Forms.View.Details;
            folSQL.VirtualMode = true;
        }


        public void MakeFieldGrid()
        {
            colFieldname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            colFieldType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            colValuesGroupName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            colFieldValue = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));

            colFieldType.Text = "Type";
            colFieldType.TextAlign = HorizontalAlignment.Center;

            colFieldname.Text = "Bezeichnung";
            colValuesGroupName.Text = "Group";
            colFieldValue.Text = "Value";

            colFieldname.Width = 250;
            colFieldType.Width = 100;
            colValuesGroupName.Width = 250;
            colFieldValue.Width = 120;


            folValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            colFieldname,
            colFieldType,
            colFieldValue,
            colValuesGroupName
            });

            folValues.CellEditUseWholeCell = false;
            folValues.Dock = System.Windows.Forms.DockStyle.Fill;
            folValues.HideSelection = false;
            folValues.Location = new System.Drawing.Point(0, 0);
            folValues.Name = "fastObjectListView1";
            folValues.ShowGroups = false;
            folValues.TabIndex = 4;
            folValues.UseCompatibleStateImageBehavior = false;
            folValues.View = System.Windows.Forms.View.Details;
            folValues.VirtualMode = true;
        }

        //Getters (Formatierungen, Zuweisungen der Objektvariablen zu dem ObjektListView
        private void SetupColumns()
        {
            colFieldname.AspectGetter = delegate (object x) { return ((ReportValues)x).caption; };
            colValuesGroupName.AspectGetter = delegate (object x) { return ((ReportValues)x).group; };
            colFieldType.AspectGetter = delegate (object x) { return ((ReportValues)x).valtype; };
            colFieldValue.AspectGetter = delegate (object x) { return ((ReportValues)x).val; };
        }
        private void SetupSQLColumns()
        {
            colSQLCommand.AspectGetter = delegate (object x) { return ((ReportSqlCommands)x).caption; };
            colSQLCaption.AspectGetter = delegate (object x) { return ((ReportSqlCommands)x).cmd; };
            //colSQLDone.AspectGetter = delegate (object x) { return ((ReportSqlCommands)x)..valtype; };
            //colSQLGroupName.AspectGetter = delegate (object x) { return ((ReportSqlCommands)x).group; };

        }

        private void AddSQLItem(string statement, string dataname)
        {

            var obj = new ReportSqlCommands()
            {
                caption = dataname,
                cmd = statement

            };

            folSQL.AddObject(obj);
        }

        private void ItemToEdit(ReportSqlCommands oitm)
        {
            txtDataName.Text = oitm?.caption;
            txtStatement.Text = oitm?.cmd;
        }
        private void ValuesItemToEdit(ReportValues oitm)
        {
            txtValueCaption.Text = oitm.caption;
            txtValueGroup.Text = oitm.group;
            txtValueWert.Text = oitm.val;
            cbValuesTypes.SelectedItem = oitm.valtype;
        }

        private void hsAddStatement_Click(object sender, EventArgs e)
        {
            AddSQLItem(txtStatement.Text, txtDataName.Text);
        }

        private void hsRemoveStatement_Click(object sender, EventArgs e)
        {


            if (folSQL.SelectedObject == null) return;
            var tfc = (ReportSqlCommands)folSQL.SelectedObject;
            folSQL.RemoveObject(tfc);

        }

        private void hsCreateReportFiles_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtXMLDataFileNew.Text))
            {
                long ticksnow = DateTimeFunctions.GetSecFromTicksNow();
                txtXMLDataFileNew.Text = $@"{ApplicationPathClass.Instance.ApplicationReportPath}\ReportDataFile_{DateTimeFunctions.GetSecFromTicksNow()}.xml";
                txtXSDSchemaFileNew.Text = $@"{ApplicationPathClass.Instance.ApplicationReportPath}\ReportSchemaFile_{DateTimeFunctions.GetSecFromTicksNow()}.xml";
                txtReportFileNameNew.Text = $@"{ApplicationPathClass.Instance.ApplicationReportPath}\Report_{DateTimeFunctions.GetSecFromTicksNow()}.frx";
                cbReportFile.Text = $@"{ApplicationPathClass.Instance.ApplicationReportPath}\Report_{DateTimeFunctions.GetSecFromTicksNow()}.frx";
            }
            var rpt = new ReportDesignClass
            {
                Datafile = txtXMLDataFileNew.Text,
                Schemafile = txtXSDSchemaFileNew.Text,
                Reportfile = txtReportFileNameNew.Text
            };

            bool createFiles = true;
            if (File.Exists(rpt.Datafile) || File.Exists(rpt.Schemafile))
            {
                object[] param = { rpt.Datafile, rpt.Schemafile, Environment.NewLine };
                var dResult = SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "FileExistsCaption", "ReportDataFilesExisits", SEMessageBoxButtons.YesNoCancel, SEMessageBoxIcon.Exclamation, null, param);
                if (dResult == SEDialogResult.Cancel) return;
                createFiles = (dResult == SEDialogResult.Yes);
            }

            if (createFiles)
            {
                foreach (var ob in folSQL.Objects)
                {
                    ReportSqlCommands rv = (ReportSqlCommands)ob;
                    rpt.DataObjects.Add(rv);
                }
                foreach (var ob in folValues.Objects)
                {
                    ReportValues rv = (ReportValues)ob;
                    var rvg = rpt.ValueObjects.Find(x => x.group == rv.group);
                    if (rvg == null)
                    {
                        rvg = new ReportValuesGroups();
                        rvg.group = rv.group;
                        rpt.ValueObjects.Add(rvg);
                    }
                    rvg.vals.Add(rv);
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
            tabControlEditDesign.SelectedTab = tabPageFRX;
        }

        private void hsLoadXMLDataFile_Click(object sender, EventArgs e)
        {
            // ofdXMLDataFile.InitialDirectory = PfadClass.Instance().ReportDataPfad;
            if (ofdXMLDataFile.ShowDialog() != DialogResult.OK) return;

            AddCbXMLFileText(ofdXMLDataFile.FileName);
            fctXML.OpenFile(ofdXMLDataFile.FileName);
            tabControlEditDesign.SelectedTab = tabPageXML;
            if (cbXSDFile.Text.Length >= 1) return;

            AddCbXSDFileText(cbXMLFile.Text.ToUpper().Replace(@".XML", @".XSD"));
            fctXSD.OpenFile(cbXMLFile.Text);
        }

        private void hsLoadSchemaFile_Click(object sender, EventArgs e)
        {
            if (ofdXSDSchemaFile.ShowDialog() != DialogResult.OK) return;

            AddCbXSDFileText(ofdXSDSchemaFile.FileName);
            fctXSD.OpenFile(ofdXSDSchemaFile.FileName);
            tabControlEditDesign.SelectedTab = tabPageXSD;
        }

        public void SetControlSizes()
        {
            MakeFieldGrid();
            MakeSQLFieldGrid();
            SetupColumns();
            SetupSQLColumns();
            pnlFormUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlFRXUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlXMLUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlXSDUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlAllDesignUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlCreateStatementsUpper.Height = 172;
        }
        private void ReportDesignForm_Load(object sender, EventArgs e)
        {
            SetValuesTypes();
            SetControlSizes();
            FormDesign.SetFormLeft(this);
            LoadUserDesign();
        }

        private void SetValuesTypes()
        {
            cbValuesTypes.Items.Clear();
            cbValuesTypes.Items.Add(typeof(string));
            cbValuesTypes.Items.Add(typeof(int));
            cbValuesTypes.Items.Add(typeof(double));
            cbValuesTypes.Items.Add(typeof(DateTime));
            cbValuesTypes.Items.Add(typeof(bool));
            cbValuesTypes.SelectedIndex = 0;
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
                Datafile = txtXMLDataFileNew.Text,
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
                foreach (ReportSqlCommands lvi in folSQL.Objects)
                {
                    //if (!lvi.Checked) continue;

                    rpt.DataObjects.Add(lvi);
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
                    ConnectionString = string.Format("XsdFile={1};XmlFile={0}", cbXMLFile.Text, cbXSDFile.Text)
                };

                rpt.Dictionary.AddChild(dorg);
                rpt.Design(false);

                if (File.Exists(cbReportFile.Text)) return;
                rpt.Save(cbReportFile.Text);
            }
            else
            {
                object[] param = { cbReportFile.Text, Environment.NewLine };
                SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "FileNotExistsCaption", "ReportFilesNotExists", SEMessageBoxButtons.OK, SEMessageBoxIcon.Exclamation, null, param);
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

            txtXSDSchemaFileNew.Text = ofdXSDSchemaFile.FileName;
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
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            fctFRX.SaveToFile(saveFileDialog.FileName, Encoding.UTF8);
        }

        private void hsSaveXSD_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = "Save FastReport scheme file";
            saveFileDialog.Filter = "*.xsd|FastReportScheme";
            saveFileDialog.DefaultExt = "*.xsd";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            fctFRX.SaveToFile(saveFileDialog.FileName, Encoding.UTF8);
        }

        private void hsSaveXML_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = "Save FastReport data file";
            saveFileDialog.Filter = "*.xml|FastReportData";
            saveFileDialog.DefaultExt = "*.xml";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            fctFRX.SaveToFile(saveFileDialog.FileName, Encoding.UTF8);
        }

        private void hsAddValueObject_Click(object sender, EventArgs e)
        {
            ReportValues reportValues = new ReportValues();
            reportValues.group = txtValueGroup.Text;
            reportValues.caption = txtValueCaption.Text;

            reportValues.valtype = (Type)cbValuesTypes.SelectedItem;
            if (reportValues.valtype == typeof(int))
            {
                int? val = StaticFunctionsClass.ToIntDef(txtValueWert.Text, null);
                if (val == null)
                {
                    SEMessageBox.ShowDialog("FormatError", $@"IsNotAValidFormat", SEMessageBoxButtons.OK, SEMessageBoxIcon.Exclamation, null, new object[] { txtValueWert.Text.Trim(), typeof(int) });
                    return;
                }
                reportValues.val = val.ToString();

            }
            else if (reportValues.valtype == typeof(double))
            {
                double? val = StaticFunctionsClass.ToDoubleDef(txtValueWert.Text, null);
                if (val == null)
                {
                    SEMessageBox.ShowDialog("FormatError", $@"IsNotAValidFormat", SEMessageBoxButtons.OK, SEMessageBoxIcon.Exclamation, null, new object[] { txtValueWert.Text.Trim(), typeof(double) });
                    return;
                }
                reportValues.val = val.ToString();
            }
            else if (reportValues.valtype == typeof(DateTime))
            {
                try
                {
                    var dateTime = DateTime.Parse(txtValueWert.Text.Trim());
                }
                catch (FormatException)
                {
                    SEMessageBox.ShowDialog("FormatError", $@"IsNotAValidFormat", SEMessageBoxButtons.OK, SEMessageBoxIcon.Exclamation, null, new object[] { txtValueWert.Text.Trim(), typeof(DateTime) });
                    return;
                }
                reportValues.val = txtValueWert.Text;
            }
            else
            {
                reportValues.val = txtValueWert.Text;
            }
            bool objectExists = false;
            foreach (var itm in folValues.Objects)
            {
                var rv = (ReportValues)itm;
                if ((rv.caption == reportValues.caption) && (rv.group == reportValues.group))
                {
                    objectExists = true;
                    break;
                }
            }
            if (objectExists)
            {
                SEMessageBox.ShowDialog("ItemsExists", $@"ListAlreadyContainsGroupName", SEMessageBoxButtons.OK, SEMessageBoxIcon.Exclamation, null, new object[] { reportValues.group, reportValues.caption });
                return;
            }
            folValues.AddObject(reportValues);
        }

        private void hsRemovevALUEoBJECT_Click(object sender, EventArgs e)
        {
            if (folValues.SelectedObject == null) return;
            var tfc = (ReportValues)folValues.SelectedObject;
            folValues.RemoveObject(tfc);
        }

        private void hsCLearValues_Click(object sender, EventArgs e)
        {
            folValues.SetObjects(null, false);
        }


        private void hsHelp_Click(object sender, EventArgs e)
        {
            ApplicationHelp.Instance.ShowHelp(HelpIDS.ReportDesigner);
        }

        private void hsClearSQLList_Click(object sender, EventArgs e)
        {
            folSQL.SetObjects(null, false);
        }

        private void folSQL_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportSqlCommands obj = folSQL.SelectedObject as ReportSqlCommands;
            ItemToEdit(obj);
        }

        private void folValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportValues obj = (ReportValues)folValues.SelectedObject;
            ValuesItemToEdit(obj);
        }
    }
}
