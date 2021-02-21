using FBXpert.Globals;
using System;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class SaveFileForm : Form
    {

        public SaveFileForm()
        {
            InitializeComponent();
          
         
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        
       

        DialogResult dres = DialogResult.None;
        private void hsSelectFolder_Click(object sender, EventArgs e)
        {
            dres = sfdFile.ShowDialog();
            if(dres == DialogResult.OK)
            {
                fname = sfdFile.FileName;
                txtFileName.Text = fname;
            }
            else
            {
                fname = string.Empty;
                txtFileName.Text = fname;
            }
        }

        public string Filter
        {
            set
            {
                sfdFile.Filter = value;
            }
        }

        public string InitialDirectory
        {
            set
            {
                sfdFile.InitialDirectory = value;
            }
        }
        public string Info
        {
            set
            {
               gbFileName.Text = value;
            }
        }

      

        string fname = string.Empty;
        public string FileName
        {
            get
            {                
                return fname;
            }
            set
            {
                fname = value;
            }
        }

        private void SaveFileForm_Load(object sender, EventArgs e)
        {
            FormDesign.SetFormLeft(this);
            fname = string.Empty;
            
        }

        private void hsClose_Click_1(object sender, EventArgs e)
        {
            fname = txtFileName.Text;
            Close();
        }

        private void hsAbort_Click(object sender, EventArgs e)
        {
            fname = string.Empty;
            Close();
        }
    }
}
