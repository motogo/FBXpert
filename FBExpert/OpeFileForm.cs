using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace SQLView
{
    public partial class OpenFileForm : Form
    {
        public OpenFileForm()
        {
            InitializeComponent();
        }
        public OpenFileForm(string pattern)
        {
            InitializeComponent();
            Pattern = pattern;
        }

        private void dirListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileListBox1.BeginUpdate();
           // fileListBox1.Path = "C:\\";
            fileListBox1.Path = dirListBox1.Path;
            fileListBox1.EndUpdate();
            fileListBox1.Update();
            gbFiles.Text = fileListBox1.Path;
            gbPath.Text = dirListBox1.Path;
        }

        public string Path
        {
            set
            {
                if (value != null)
                {
                    DirectoryInfo di = new DirectoryInfo(value);
                    if (di.Exists)
                        dirListBox1.Path = value;
                    else
                        dirListBox1.Path = Application.StartupPath;
                }
            }
            get
            {
                return(dirListBox1.Path);
            }
        }
        public string Pattern
        {
            set
            {
                fileListBox1.Pattern = value;
            }
            get
            {
                return fileListBox1.Pattern;
            }
        }
        public string FileName
        {
            set
            {
                fileListBox1.FileName = value;

            }
            get
            {
                return fileListBox1.FileName;
            }
        }
        public string FullName
        {
            get
            {
                return (Path + "\\" + FileName);
            }
        }
        public string Title
        {
            set
            {
                this.Text = value;
            }
            get
            {
                return (this.Text);
            }
        }
        enum contentType {text=0,binaer=1 };
        contentType ContentType;

        private void Bin()
        {
            if (cbBin.Checked)
                ContentType = contentType.binaer;
            else
                ContentType = contentType.text;
        }

        private bool Sonderzeichen(byte c)
        {
            if(c == 0)
            {
                return(true);
            }
            return(false);
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            CurrSeekPos = 0;
            NextPreview(0,SeekOrigin.Begin);
        }
        StreamReader file;
        private void Preview()
        {
            WordWrap();
            Bin();
            
            object[] ob;
            string fullName = fileListBox1.Path + "\\" + fileListBox1.FileName;

  using (file = new StreamReader(fullName, Encoding.Default))
            //    file = new StreamReader(fullName, Encoding.Default);
            {
          
                rtfPreview.Clear();
                rtfPreview.Enabled = false;
                if(ContentType == contentType.text)
                {
                ob = leseNextLines(file, 200);
                

                int cnt = ob.Length;
                if (cnt > 0)
                {
                    
                        foreach (string st in ob)
                        {
                            rtfPreview.AppendText(st + "\r\n");
                        }
                    
                    
                    }


                }
                else
                {
                    string c = "";
                    string txt = "";
                    int n = 0;
                    char[] carr = leseNextBinBlock(file, 200,0);
                    //foreach (string st in ob)
                    {
                        foreach (byte chr in carr)
                        {

                            c = chr.ToString();

                            if (!Sonderzeichen(chr))
                                txt = txt + (char)chr;
                            else
                                txt = txt + ".";
                            while (c.Length < 3) c = "0" + c;

                            rtfPreview.AppendText(c + " ");
                            n++;
                            if ((n % 8) == 0)
                            {
                                rtfPreview.AppendText("    " + txt);
                                rtfPreview.AppendText("\r\n");
                                txt = "";
                            }
                        }
                    }
                }
                rtfPreview.Enabled = true;
                Application.DoEvents();
            }
        }
        int ReadBytes = 500;
        private void NextPreview(int off, SeekOrigin so)
        {
            WordWrap();
            Bin();

            
            string fullName = fileListBox1.Path + "\\" + fileListBox1.FileName;

            using (file = new StreamReader(fullName, Encoding.Default))
            {
                rtfPreview.Clear();
                rtfPreview.Enabled = false;
                /*
                if (ContentType == contentType.text)
                {
                    ob = leseNextLines(file, off);


                    int cnt = ob.Length;
                    if (cnt > 0)
                    {

                        foreach (string st in ob)
                        {
                            rtfPreview.AppendText(st + "\r\n");
                        }


                    }


                }
                else
                    */
                {
                    string c = "";
                    string txt = "";
                    int n = 0;
                    if ((CurrSeekPos + off) >= 0)
                    {
                        CurrSeekPos += off;
                        file.BaseStream.Seek(CurrSeekPos, so);
                        char[] carr = leseNextBinBlock(file, ReadBytes, off);
                        string ln = new string(carr);
                        if (ContentType == contentType.text)
                        { 
                            rtfPreview.AppendText(ln); 
                        }
                        else
                        {
                            //carr.CopyTo(ln, 0);
                            foreach (byte chr in carr)
                            {

                                c = chr.ToString();

                                if (!Sonderzeichen(chr))
                                    txt = txt + (char)chr;
                                else
                                    txt = txt + ".";
                                while (c.Length < 3) c = "0" + c;

                                rtfPreview.AppendText(c + " ");
                                n++;
                                if ((n % 8) == 0)
                                {
                                    rtfPreview.AppendText("    " + txt);
                                    rtfPreview.AppendText("\r\n");
                                    txt = "";
                                }
                            }
                        }
                    }
                }
                rtfPreview.Enabled = true;
                Application.DoEvents();
            }
        }

        private object[] leseNextLines(System.IO.StreamReader file, int cnt)
        {
            int counter = 0;
            string line;
            ArrayList al = new ArrayList(cnt);
            al.Clear();
            
            while (((line = file.ReadLine()) != null) && (counter < cnt))
            {
                al.Add(line);
                counter++;
            }
            if (al != null)
            {
                return (al.ToArray());
            }
            else
            {
                return (null);
            }
        }

        int StartBinCnt = 0;
        long CurrSeekPos = 0;
        private char[] leseNextBinBlock(System.IO.StreamReader file, int cnt, int offset)
        {
            int counter = 0;

            char[] buf = new char[cnt];
            int readcnt;

            
            
            while((!file.EndOfStream)&&(counter < cnt))
            {
                readcnt = file.Read(buf,0,cnt);
                
                counter+=readcnt;
            }

            StartBinCnt += counter;
            return (buf);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void OpenFileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void dirListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            WordWrap();
        }
        private void WordWrap()
        {
            rtfPreview.WordWrap = cbWordWrap.Checked;
        }

        private void OpenFileForm_Load(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            BinChecked();
            WordWrap();
        }

        private void btnNextPreview_Click(object sender, EventArgs e)
        {
            NextPreview(ReadBytes, SeekOrigin.Begin);
        }

        private void btnPrevPreview_Click(object sender, EventArgs e)
        {
            NextPreview(-1*ReadBytes, SeekOrigin.Begin);
        }

        private void btnLastPreview_Click(object sender, EventArgs e)
        {
            string fullName = fileListBox1.Path + "\\" + fileListBox1.FileName;
            using (file = new StreamReader(fullName, Encoding.Default))
            {
                CurrSeekPos = file.BaseStream.Length;
            }
            NextPreview(-1 * ReadBytes, SeekOrigin.End);
        }

        private void cbBin_CheckedChanged(object sender, EventArgs e)
        {
            BinChecked();
        }

        private void BinChecked()
        {
            if (cbBin.Checked) ReadBytes = 500;
            else ReadBytes = 5000;
        }
        
       
          
    }
}
