using BasicClassLibrary;
using System;
using System.Windows.Forms;

namespace FBXpert.SonstForms
{
    public partial class CopyrightForm : Form
    {
        private static CopyrightForm _instance;       
        public static CopyrightForm Instance(Form parent)
        {
            if (_instance != null) return (_instance);
            _instance = new CopyrightForm
            {
                MdiParent = parent
            };
            LanguageClass.Instance().RegisterChangeNotifiy(CopyrightForm_OnRaiseLanguageChangedHandler);            
            return (_instance);
        }

        private static void CopyrightForm_OnRaiseLanguageChangedHandler(object sender, LanguageChangedEventArgs k)
        {
           
        }

        protected CopyrightForm()
        {
            InitializeComponent();
            this.Text = "Copyright";
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CopyrightForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instance = null;
          //  this.Hide();
           // e.Cancel = true;
        }
    }
}
