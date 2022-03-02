using BasicForms;
using FBXpert;
using System.Drawing;
using System.Windows.Forms;

namespace FBExpert
{
    public static class StaticPaintClass
    {
        public static bool TabControl_DrawItem(BasicNormalFormClass frm, DrawItemEventArgs e, object control, bool firsttab)
        {
            TabControl tabControl1 = control as TabControl;
            frm.SetDesign(FbXpertMainForm.Instance().AppDesign);
            TabPage tabPages = tabControl1.TabPages[e.Index];
            Graphics graphics = e.Graphics;

            SolidBrush darkBrush = new SolidBrush(frm.GetDesignColor(SystemColors.ControlDark));
            SolidBrush controlBrush = new SolidBrush(frm.GetDesignColor(SystemColors.Control));

            SolidBrush darkText = new SolidBrush(Color.Black);
            SolidBrush lightText = new SolidBrush(Color.White);

            Rectangle tabBounds = tabControl1.GetTabRect(e.Index);
            Font tabFont = frm.Font;
            StringFormat strFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            if (!firsttab)
            {
                e.Graphics.FillRectangle(controlBrush, frm.ClientRectangle);
                firsttab = true;
            }

            if (e.State != DrawItemState.Selected)
            {

                graphics.FillRectangle(controlBrush, e.Bounds);
                graphics.DrawString(tabPages.Text, tabFont, darkText, tabBounds, new StringFormat(strFormat));
            }
            else
            {
                graphics.FillRectangle(darkBrush, e.Bounds); //fill background color                
                graphics.DrawString(tabPages.Text, tabFont, lightText, tabBounds, new StringFormat(strFormat));
            }
            darkText.Dispose();
            lightText.Dispose();
            darkBrush.Dispose();
            controlBrush.Dispose();
            graphics.Dispose();
            return firsttab;
        }
    }
}
