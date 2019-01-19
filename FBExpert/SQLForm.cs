using FBExpert;
using FormInterfaces;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class SQLForm : IEditForm
    {
        
        DBRegistrationClass DRC = null;
       
        public SQLForm(Form parent, DBRegistrationClass drc)
        {
            InitializeComponent();
            this.MdiParent = parent;
            DRC = drc;
        }        
       
        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetEnables()
        {
            if(BearbeitenMode == StateClasses.EditStateClass.eBearbeiten.eEdit)
            {
                
            }
            else
            {
                
            }
        }

        public void DataToEdit()
        {
                                  
        }
        
        private void DefaultForm_Load(object sender, EventArgs e)
        {
            DataToEdit();
            SetEnables();            
        }
        
        private void Save()
        {
                   
        }

        private void hsSave_Click(object sender, EventArgs e)
        {
            //
            Save();
        }

        private void hsLoadScript_Click(object sender, EventArgs e)
        {
            if (ofdSQL.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;
                string line;
                FileInfo fi = new FileInfo(ofdSQL.FileName);


                fcbSQL.BeginUpdate();
                fcbSQL.Clear();

                fcbSQL.OpenFile(ofdSQL.FileName, Encoding.UTF8);
                fcbSQL.EndUpdate();

                this.Cursor = Cursors.Default;
            }
        }

        private void hsExecuteDB_Click(object sender, EventArgs e)
        {

        }
    }
}
