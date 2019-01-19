using MessageLibrary;
using System;
using System.Text;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class SelectDefaultForm : Form
    {
        NotifiesClass localNotify = null;
        public SelectDefaultForm(Form parent, NotifiesClass locNotify)
        {
            InitializeComponent();
            this.MdiParent = parent;
            localNotify = locNotify;
            cbDefaults.Items.Clear();
            cbDefaults.Items.Add("CURRENT_USER");
            cbDefaults.Items.Add("CURRENT_DATE");
            cbDefaults.Items.Add("CURRENT_TIMESTAMP");
            cbDefaults.Items.Add("CURRENT_TIME");
            cbDefaults.Items.Add("CURRENT_ROLE");
            cbDefaults.Items.Add("CURRENT_PATH");

            cbDefaults.SelectedIndex = 0;
        }

       

        private void hsOK_Click(object sender, EventArgs e)
        {
            localNotify.Notify.RaiseInfo("SelectDefaultForm->hsOK", "SELECT_DEFAULTS",cbDefaults.Text);
            Close();
        }

        private void hsABORT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
