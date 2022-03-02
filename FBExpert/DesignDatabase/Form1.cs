using BasicClassLibrary;
using FBXDesigns;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SEDiagramms
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point lpPoint);
        public static Point GetCursorPosition()
        {
            Point lpPoint;
            GetCursorPos(out lpPoint);
            return lpPoint;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        ActionClass Action = ActionClass.Instance();

        private void ssTable_MouseDown(object sender, MouseEventArgs e)
        {
            /*   
               if (e.Button == MouseButtons.Right)
               {
                   //Move Table
                   Control c = (Control)sender;
                   diffx = c.Width - e.X;
                   diffy = c.Height - e.Y;
                   cwidth = c.Width + 16;
                   cheight = c.Parent.Parent.Height-c.Height;
                   if ((diffx > 0) && (diffx < 32))
                   {
                       Action.crtl = (Control)sender;
                       Action.mainctrl = Action.crtl.Parent.Parent;
                       Action.parent = this;
                       Action.action = eAction.OnMove;
                       Action.crtl.BackColor = Color.AliceBlue;
                   }
               }
               else if(e.Button == MouseButtons.Left)
               {
                   //Resize Table
                   Control c = (Control)sender;
                   diffx = c.Width - e.X;
                   diffy = c.Height - e.Y;
                   cwidth = c.Width + 16;
                   cheight = c.Parent.Parent.Height - c.Height;
                   if ((diffx > 0) && (diffx < 32))
                   {
                       Action.crtl = (Control)sender;
                       Action.mainctrl = Action.crtl.Parent.Parent;
                       Action.parent = this;
                       Action.action = eAction.OnResize;
                       Action.crtl.BackColor = Color.AliceBlue;
                   }
               }
               */
        }



        private void ssTable_MouseMove(object sender, MouseEventArgs e)
        {



            /*
            ActSender = sender;
            if (Action.crtl == sender)
            {
                if(Action.action == eAction.OnMove)
                {
                    Point pt = GetCursorPosition();
                    Action.DrawMove(pt);
                }
                else if (Action.action == eAction.OnResize)
                {
                    Point pt = GetCursorPosition();
                    Action.DrawResize(pt);
                }
            }
            */
        }

        private void ssTable_MouseUp(object sender, MouseEventArgs e)
        {
            Action.action = eAction.None;
            Action.crtl.BackColor = SystemColors.ButtonFace;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            /*
            if (Action.crtl == ActSender)
            {
                if (Action.action == eAction.OnMove)
                {
                    Point pt = GetCursorPosition();
                    Action.DrawMove(pt);
                }

                else if (Action.action == eAction.OnResize)
                {
                    Point pt = GetCursorPosition();
                    Action.DrawResize(pt);
                }
            }
            */
            Point pt = GetCursorPosition();
            pt = this.PointToScreen(Point.Empty);
            Point pt2 = button1.PointToScreen(Point.Empty);
            label4.Text = "abs:" + pt.X.ToString() + "/" + pt.Y.ToString() + "btn:" + pt2.X.ToString() + "/" + pt2.Y.ToString() + " loc:" + e.X.ToString() + "/" + e.Y.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseDesignForm.Instance.Show();
        }

        private void gbTable_MouseHover(object sender, EventArgs e)
        {
            Point pt = GetCursorPosition();
            //  int xmin = pt.X - gbTable = pt.X - this.Left -  + 8;
            //gbTable.Top = pt.Y - this.Top - gbTable.Top - 20;
        }

        private void hsPickTable_Click(object sender, EventArgs e)
        {

        }

        private void hsPickTable_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UIDesignTableClass tb = listBox1.SelectedItem as UIDesignTableClass;
            tb.Show();
        }

        private void gbTable_Enter(object sender, EventArgs e)
        {

        }

        private void cmsTable_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lvTableAttributes_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }
        double fakt = 1;
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            //1-10

            fakt = trackBar3.Value / 10.0;
            label1.Text = fakt.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float z = (float)StaticFunctionsClass.ToDoubleDef(textBox1.Text, 1.0);

            DatabaseDesignForm.Instance.SetZoom(z);
        }
    }
}
