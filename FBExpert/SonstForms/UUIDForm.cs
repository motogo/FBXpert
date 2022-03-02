using FBXpert.Globals;
using System;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class UUIDForm : Form
    {
        public UUIDForm(Form mdiparent)
        {
            InitializeComponent();
            this.MdiParent = mdiparent;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void UUIDForm_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void UUIDForm_Load(object sender, EventArgs e)
        {
            FormDesign.SetFormLeft(this);
            Guid g = Guid.NewGuid();
            txtUUID.Text = g.ToString();
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hsCreate_Click(object sender, EventArgs e)
        {
            Guid g = Guid.NewGuid();
            txtUUID.Text = g.ToString();
        }
    }
}
