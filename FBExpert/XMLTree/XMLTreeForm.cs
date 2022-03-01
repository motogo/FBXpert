using FBXpert.Globals;
using FBXpertLib;
using System;
using System.IO;
using System.Windows.Forms;

namespace FBXpert.KonfigurationForms
{
    /// <summary>
    /// Zusammenfassende Beschreibung für WinForm
    /// </summary>
    partial class XMLTreeForm : System.Windows.Forms.Form
	{
        public bool TreeChanged = false;
		public XMLTreeForm(string XMLfile)
		{
			InitializeComponent();
            xmlFile = XMLfile;
        }

	    public XMLTreeForm(Form mdiParent, string XMLfile)
	    {
	        InitializeComponent();
	        MdiParent = mdiParent;
	        xmlFile = XMLfile;
	    }

        private string xmlFile = String.Empty;
        public void SetControlSizes()
        {
            pnlFormUpper.Height = AppSizeConstants.UpperFormBandHeight;
        }
        private void XMLTreeForm_Load(object sender, EventArgs e)
        {
            SetControlSizes();
            FormDesign.SetFormLeft(this);
            if (string.IsNullOrEmpty(xmlFile)) return;
            FileInfo fi = new FileInfo(xmlFile);
            if (fi.Exists)
            {
                xmlEdit.LoadXmlFromFile(fi.FullName);
            }
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hsReload_Click(object sender, EventArgs e)
        {
           /* 
            FileInfo fi = new FileInfo(PfadClass.Instance().XMLName);
            if (fi.Exists)
            {
                PfadClass.Instance().Deserialize(fi.FullName);
                xmlEdit.LoadXmlFromFile(fi.FullName);
            }
            */
        }
    }
}
