using System.Windows.Forms;

namespace FBXpert.Globals
{
    public static class FormDesign
    {
        public static void SetFormLeft(Form frm)
        {
            if (DbExplorerForm.Instance().Visible)
            {
                int left = DbExplorerForm.Instance().Width + DbExplorerForm.Instance().Left;
                if (frm.Left < left) frm.Left = left + 2;
                return;
            }
            if (frm.Left < 0) frm.Left = 0;
        }
    }
}
