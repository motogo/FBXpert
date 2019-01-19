using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class DesignForm : Form
    {
        public DesignForm()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        bool moveon = false;
        int pos;
        int diff;
        int frm;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            moveon = true;
            pos = e.X;
            diff = panel2.Left + panel1.Left + pos;
            frm = this.Left;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = Cursor.Position.X.ToString();
            int px = Cursor.Position.X;
            if (moveon)
            {
               
               
                
                int neu = px - diff - frm;
                groupBox1.Text = (neu - 8).ToString();
                groupBox1.Left = neu-8;
                groupBox1.Invalidate();
            //    Application.DoEvents();
            }
        }

        private void DesignForm_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = Cursor.Position.X.ToString();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = Cursor.Position.X.ToString();
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            moveon = false;
        }
    }
}
