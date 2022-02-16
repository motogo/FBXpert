using BasicForms;
using FBXpertLib.Globals;
using SQLView;
using System;
using System.Windows.Forms;

namespace FBXpertLib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hotSpot1_Click(object sender, EventArgs e)
        {
          
            eColorDesigns AppDesign = eColorDesigns.Gray;
            eColorDesigns DevelopDesign = eColorDesigns.Gray;
            DBRegistrationClass drc = new DBRegistrationClass();
            var sf = new SQLViewForm2(drc, this, AppDesign, DevelopDesign);
            sf.Show();
        }
    }
}
