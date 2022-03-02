using System;
using System.Drawing;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class FBXInfo : Form
    {
        private static readonly Lazy<FBXInfo> lazy = new Lazy<FBXInfo>(() => new FBXInfo());
        public static FBXInfo Instance
        {
            get
            {
                return lazy.Value;
            }
        }


        protected FBXInfo()
        {
            InitializeComponent();
            this.Text = "Copyright";
            MoveRandom();
        }

        private void CopyrightForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        int hdirection = 0;
        int vdirection = 0;
        int duration = 1;
        int aktduro = 0;

        private void MoveRandom()
        {
            Random rd = new Random();
            hdirection = rd.Next(3);
            vdirection = rd.Next(3);
            duration = rd.Next((FbXpertMainForm.Instance().Width + FbXpertMainForm.Instance().Height) / 4);
            aktduro = 0;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            aktduro++;
            if ((this.Left > 280) && ((this.Left + this.Width) < FbXpertMainForm.Instance().Width))
            {
                this.Left += hdirection - 1;
            }

            if ((this.Top > 0) && ((this.Top + this.Height) < FbXpertMainForm.Instance().Height))
            {
                this.Top += vdirection - 1;
            }

            if (aktduro > duration)
            {
                MoveRandom();
            }
        }

        private void Occ(ref Bitmap pic, int occ)
        {

            for (int w = 0; w < pic.Width; w++)
            {
                for (int h = 0; h < pic.Height; h++)
                {
                    Color c = pic.GetPixel(w, h);
                    if (c != Color.Transparent)
                    {
                        Color newC = Color.FromArgb(c.A * (occ / 100), c.R * (occ / 100), c.G * (occ / 100), c.B * (occ / 100));
                        pic.SetPixel(w, h, newC);
                    }
                }
            }
            //pictureBox1.Image = pic;
        }

        private void CopyrightForm_Load(object sender, EventArgs e)
        {
            //  timer1.Start();
            // int occ = 100;

            Bitmap pic = new Bitmap(global::FBXpert.Properties.Resources.fbxpert1);
            pictureBox1.Image = pic;
            this.Left += 100;
            this.Top -= 100;
            /*
            for(int i = 50; i < 100; i++)
            {
                Occ(ref pic, i);
               
            }
            pictureBox1.Image = pic;
            */
            /*
            pictureBox1.Opacity = 0.01;
            while (Opacity < 1)
            {
                this.Opacity+=0.01;
                Thread.Sleep(50);
                Application.DoEvents();
            }
            */
        }

        private void CopyrightForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            e.Cancel = false;
            //instance = null;

        }

        private void pictureBox1_Validated(object sender, EventArgs e)
        {

        }

        private void FBXInfo_Paint(object sender, PaintEventArgs e)
        {
            this.SendToBack();
        }

        private void FBXInfo_MdiChildActivate(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
