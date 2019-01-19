using FBExpert;
using FormInterfaces;
using System;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class XDefaultForm : IEditForm
    {
        
        DBRegistrationClass DRC = null;
       
        public XDefaultForm(Form parent, DBRegistrationClass drc)
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
    }
}
