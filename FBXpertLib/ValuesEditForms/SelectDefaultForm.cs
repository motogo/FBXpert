using BasicClassLibrary;
using System;
using System.Windows.Forms;

namespace FBXpertLib
{
    public partial class SelectDefaultForm : Form
    {
        NotifiesClass localNotify = null;
        string _key = string.Empty;
        public SelectDefaultForm(Form parent, NotifiesClass locNotify, string key, string[] items)
        {
            InitializeComponent();
            this.MdiParent = parent;
            localNotify = locNotify;
            _key = key;
            cbDefaults.Items.Clear();
            foreach (string s in items)
            {
                cbDefaults.Items.Add(s);
            }


            cbDefaults.SelectedIndex = 0;
        }



        private void hsOK_Click(object sender, EventArgs e)
        {
            localNotify.Notify.RaiseInfo("SelectDefaultForm->hsOK", _key, cbDefaults.Text);
            Close();
        }

        private void hsABORT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
