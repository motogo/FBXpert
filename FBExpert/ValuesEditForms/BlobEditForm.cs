using FBXpert.Globals;
using System;
using System.Windows.Forms;

namespace FBXpert.ValuesEditForms
{
    public partial class BlobEditForm : Form
    {
        public BlobEditForm(string datatype, string info)
        {
            InitializeComponent();        
            this.Text = $@"Binary Editor, Data = {info}";   
            this.label3.Text = $@"HEX ->{datatype}";
        }

        public void SetControlSizes()
        {
          
            pnlFormUpper.Height = AppSizeConstants.UpperFormBandHeight;
           
        }
        public void SetBytes(Byte[] values)
        {
            bv.SetBytes(values);
        }
        public void SetFileBytes(string fn)
        {
             bv.SetFile(fn); 
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenInAnotherApp(byte[] data, string filename)
        {
            var tempFolder = System.IO.Path.GetTempPath();
            filename = System.IO.Path.Combine(tempFolder, filename);
            System.IO.File.WriteAllBytes(filename, data);
            System.Diagnostics.Process.Start(filename);
        }

        private void hsPDF_Click(object sender, EventArgs e)
        {         
            OpenInAnotherApp(bv.GetBytes(), "somename.pdf");
        }       

        private void hsText_Click(object sender, EventArgs e)
        {
            OpenInAnotherApp(bv.GetBytes(), "somename.txt");
        }

        private void hsExcel_Click(object sender, EventArgs e)
        {
            OpenInAnotherApp(bv.GetBytes(), "somename.xls");
        }

        private void pnlCenter_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void hsShowAsImage_Click(object sender, EventArgs e)
        {
            OpenInAnotherApp(bv.GetBytes(), "somename.tif");
        }

        private void hotSpot1_Click(object sender, EventArgs e)
        {
             OpenInAnotherApp(bv.GetBytes(), "somename.doc");
        }

        private void BlobEditForm_Load(object sender, EventArgs e)
        {
            SetControlSizes();
        }
    }
}
