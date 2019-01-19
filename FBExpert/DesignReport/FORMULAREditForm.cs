using BasicForms;
using FBExpert;
using FBXpert.KonfigurationForms;
using FormInterfaces;
using Initialization;
using MessageLibrary.SendMessages;
using SharedStorages;
using System;
using System.IO;
using System.Windows.Forms;
using FBXpert.Globals;


namespace FBXpert
{
    /// <summary>
    /// Zusammenfassende Beschreibung für WinForm
    /// </summary>
    partial class FORMULAREditForm : IEditForm
	{

	    [Serializable]
	    class MerkeWerte
	    {
	        public string ReportFileName;
	        public string XmlDataFileName;
	        public string XsdSchemaFileName;            
	    };
	   
	    private MerkeWerte _mw = new MerkeWerte();
	    private SharedStorage _ss = new SharedStorage();


        private void LoadUserDesign()
        {
            
            
            _ss.SharedFolder = ApplicationPathClass.GetFullPath(Application.UserAppDataPath);
            _ss.StorageName = this.Name;
            _ss.DestroyWhenDisposed = false;
            try
            {
                MerkeWerte mw2 = (MerkeWerte)_ss[this.Name.ToString()];
                if (mw2 != null)
                {
                    _mw = mw2;                    
                    txtXMLDataFile.Text = _mw.XmlDataFileName;
                    txtXSDSchemaFile.Text = _mw.XsdSchemaFileName;
                    txtREPORTFILE.Text = _mw.ReportFileName;
                }
            }
            catch (Exception ex)
            {
                SendMessageClass.Instance().SendAllErrors(this.Name.ToString() + " -> LoadUserDesign() ->" + ex.Message);
            }
        }

        private void SaveUserDesign()
        {
            if ((_mw != null) && (_ss != null))
            {
                _mw.ReportFileName = txtREPORTFILE.Text;
                _mw.XmlDataFileName = txtXMLDataFile.Text;
                _mw.XsdSchemaFileName = txtXSDSchemaFile.Text;
                
                _ss.SharedFolder = ApplicationPathClass.GetFullPath(Application.UserAppDataPath);
                _ss.StorageName = this.Name;
                _ss.AddOrUpdate(this.Name.ToString(), _mw);
            }
        }
       

        public override void FormLoadFirst()
        {
            base.FormLoadFirst(eWindowList.cms);
            
        }
        public override void FormLoadAgain()
        {
            base.FormLoadAgain(eWindowList.cms);
        }
       
        public override bool DataOK()
        {            
            
            return (true);
        }

	    private DBRegistrationClass _drc;
        public FORMULAREditForm(Form parent, DBRegistrationClass drc)
        {

            _drc = drc;
            MdiParent = parent;
            Init();
           
        }

        public void Init()
		{
			//
			// Erforderlich für die Unterstützung des Windows Forms-Designer
			//
			InitializeComponent();
			

          
           
        }
        


        private void HelpRequest()
        {
          //  UserHelpClass.Instance().ShowHelp("",url_type.dokuwiki_url,"start");
        }

        private void FORMULAREditForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            HelpRequest();
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void FORMULAREditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.DoFormClosing(e);
            SaveUserDesign();            
            CMSWindowsClass.Instance().RemoveWindow(this);   
        }

        private void hsFastReport_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtREPORTFILE.Text) && (txtREPORTFILE.Text.Length > 0))
            {
                FastReport.Report rpt = new FastReport.Report();
               
                rpt.Load(txtREPORTFILE.Text);
                rpt.AutoFillDataSet = false;

                FastReport.Data.XmlDataConnection dorg = (FastReport.Data.XmlDataConnection)rpt.Dictionary.Connections[0];

                dorg.XmlFile = txtXMLDataFile.Text;
                dorg.XsdFile = txtXSDSchemaFile.Text;
                dorg.ConnectionString = string.Format("XsdFile={1};XmlFile={0}", txtXMLDataFile.Text, txtXSDSchemaFile.Text);
                rpt.Dictionary.Connections[0] = dorg;                                           
                rpt.AutoFillDataSet = true;
                rpt.Design(true);
                txtREPORTFILE.Text = rpt.FileName;
            }
        }

        private void hotSpot1_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtREPORTFILE.Text) && (txtREPORTFILE.Text.Length > 0))
            {
                FastReport.Report rpt = new FastReport.Report();                
                rpt.Load(txtREPORTFILE.Text);
                rpt.AutoFillDataSet = false;
                rpt.Dictionary.Connections[0].ConnectionString = string.Format(@"XSDFile={1};XmlFile={0}", txtXMLDataFile.Text, txtXSDSchemaFile.Text);
                rpt.AutoFillDataSet = true;
                rpt.Show();
            }
        }
       
        private void hsReportFileWahl_Click(object sender, EventArgs e)
        {
           // ofdReportFile.InitialDirectory = PfadClass.Instance().EDVPfad;
            if (ofdReportFile.ShowDialog() == DialogResult.OK)
            {
                txtREPORTFILE.Text = ofdReportFile.FileName;
            }
        }

        private void hsDesignNew_Click(object sender, EventArgs e)
        {            
                FastReport.Report rpt = new FastReport.Report();                
                rpt.Design(true);            
        }

        private void hsLoadXMLDataFile_Click(object sender, EventArgs e)
        {
           // ofdXMLDataFile.InitialDirectory = PfadClass.Instance().ReportDataPfad;
            if (ofdXMLDataFile.ShowDialog() == DialogResult.OK)
            {
                txtXMLDataFile.Text = ofdXMLDataFile.FileName;
                if (txtXSDSchemaFile.Text.Length < 1)
                {
                    txtXSDSchemaFile.Text = txtXMLDataFile.Text.ToUpper().Replace(@".XML", @".XSD");
                }
            }
        }

        private void hsLoadSchemaFile_Click(object sender, EventArgs e)
        {
            /*
            ofdXSDSchemaFile.InitialDirectory = PfadClass.Instance().ReportDefinitionPfad;
            if (ofdXSDSchemaFile.ShowDialog() == DialogResult.OK)
            {
                txtXSDSchemaFile.Text =  ofdXSDSchemaFile.FileName;
            }
            */
        }

        private void FORMULAREditForm_Load(object sender, EventArgs e)
        {
            LoadUserDesign();
        }

        private void hsXMLReport_Click(object sender, EventArgs e)
        {
            XMLTreeForm tf = new XMLTreeForm(txtREPORTFILE.Text);
            tf.Show();
        }

        private void hsEditXMLData_Click(object sender, EventArgs e)
        {
            XMLTreeForm tf = new XMLTreeForm(txtXMLDataFile.Text);
            tf.Show();
        }

        private void hsEditXSDData_Click(object sender, EventArgs e)
        {
            XMLTreeForm tf = new XMLTreeForm(txtXSDSchemaFile.Text);
            tf.Show();
        }
    }
}
