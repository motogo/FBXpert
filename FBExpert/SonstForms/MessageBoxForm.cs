using SeControlsLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FBXpert
{
    enum eButtonAction {close, nothing};
    public partial class MessageBoxForm : Form
    {
        MessageBoxIcon mbi = MessageBoxIcon.None;

        List<SeControlsLib.HotSpot> _buttons = new List<SeControlsLib.HotSpot>();

        public MessageBoxForm()
        {
            InitializeComponent();
          
         
        }

        DialogResult _dialog_result = DialogResult.None;

        public DialogResult Result
        {
            get
            {
                return _dialog_result;
            }
        }

        public void AddButton(string txt, string name, Image img, Image imghover, DialogResult _dialog_result)
        {
            HotSpot hs = new HotSpot();
            hs.Name = name;
            hs.Text = txt;
            hs.Image = img.Clone() as Image;
            hs.Parent = pnlButtons;
            hs.Width = 64;
            hs.Height = 32;
            hs.ImageAlign = ContentAlignment.TopCenter;
            hs.TextAlign = ContentAlignment.BottomCenter;

            switch(_dialog_result)
            {
                case DialogResult.OK: hs.Click += hsCloseOKClick; break;
                case DialogResult.Yes: hs.Click += hsCloseYESClick; break;
                case DialogResult.No: hs.Click += hsCloseNOClick; break;
                case DialogResult.Abort: hs.Click += hsCloseAbortClick; break;
                case DialogResult.Cancel: hs.Click += hsCloseCANCELClick; break;
            }

            _buttons.Add(hs);
        }

        private void Hs_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public MessageBoxIcon InfoImage
        {
            set
            {
                mbi = value;
            }
        }

        
        public string Info
        {
            set
            {
                this.Text = value;
            }
        }
        public string DialogText
        {
            set
            {
                rtbText.Clear();
                rtbText.AppendText(value);
            }
        }

        public void AppendDialogText(string txt)
        {
            rtbText.AppendText(txt);
        }


        private void MessageBoxForm_Load(object sender, EventArgs e)
        {
            pbInfo.Visible = (mbi != MessageBoxIcon.None);            
            switch(mbi)
            {
                case MessageBoxIcon.Information: pbInfo.Image = global::FBXpert.Properties.Resources.ok_gn32x; break;
                case MessageBoxIcon.None: pbInfo.Image = null; break;
            }
        }

        private void hsClose_Click_1(object sender, EventArgs e)
        {
            
            Close();
        }

        private void hsAbort_Click(object sender, EventArgs e)
        {
          
            Close();
        }

        private void hsCloseOKClick(object sender, EventArgs e)
        {
            _dialog_result = DialogResult.OK;
            Close();
        }
        private void hsCloseAbortClick(object sender, EventArgs e)
        {
            _dialog_result = DialogResult.Abort;
            Close();
        }
        private void hsCloseYESClick(object sender, EventArgs e)
        {
            _dialog_result = DialogResult.Yes;
            Close();
        }
        private void hsCloseNOClick(object sender, EventArgs e)
        {
            _dialog_result = DialogResult.No;
            Close();
        }
        private void hsCloseCANCELClick(object sender, EventArgs e)
        {
            _dialog_result = DialogResult.Cancel;
            Close();
        }
    }
}
