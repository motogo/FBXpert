using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert;
using FBXpert.Globals;
using FormInterfaces;
using SEListBox;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FBExpert
{
    public partial class IMPORTDataForm : INormalForm
    {
        TableClass TableObject = null;

        DBRegistrationClass DBReg = null;

        NotifiesClass localNotify = null;


        bool firsttab = false;

        public IMPORTDataForm(Form parent, DBRegistrationClass drc)
        {
            InitializeComponent();
            this.MdiParent = parent;

            localNotify = new NotifiesClass()
            {
                ErrorGranularity = eMessageGranularity.never
            };
            localNotify.Register4Info(InfoRaised);
            localNotify.Register4Error(ErrorRaised);

            DBReg = drc;

            var tableObjects = StaticTreeClass.Instance().GetAllNonSystemTableObjectsComplete(DBReg);

            if (tableObjects.Count <= 0) return;

            foreach (var tc in tableObjects.Values)
            {
                selTables.Add(tc.ToString(), CheckState.Unchecked, tc);
            }

            selTables.CheckChecks();
            SelectAllTableFields();

        }

        private void ErrorRaised(object sender, MessageEventArgs k)
        {
            throw new NotImplementedException();
        }

        private void InfoRaised(object sender, MessageEventArgs k)
        {
            throw new NotImplementedException();
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        public void ShowCaptions()
        {
            lblTableName.Text = (TableObject != null) ? $@"Import into Table: {TableObject.Name}" : "Import into Table";
            this.Text = DevelopmentClass.Instance().GetDBInfo(DBReg, "Database import into Table");
        }

        private void IMPORTDataForm_Load(object sender, EventArgs e)
        {
            FormDesign.SetFormLeft(this);
            ShowCaptions();
            if (DbExplorerForm.Instance().Visible)
            {
                this.Left = DbExplorerForm.Instance().Width + 16;
            }
            FillCHarsets();
            cbEncodingCSV.Text = ToDBCharsetName(Encoding.Default);
            cbEncoding.Text = DBReg.CharSet;

            ClearDevelopDesign(FbXpertMainForm.Instance().DevelopDesign);
            SetDesign(FbXpertMainForm.Instance().AppDesign);

        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            firsttab = StaticPaintClass.TabControl_DrawItem(this, e, sender, firsttab);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void IMPORTDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            if (localNotify == null) return;

            localNotify.Notify.OnRaiseInfoHandler -= new NotifyInfos.RaiseNotifyHandler(InfoRaised);
            localNotify.Notify.OnRaiseErrorHandler -= new NotifyInfos.RaiseNotifyHandler(ErrorRaised);
            localNotify = null;
        }


        private void hsCheckAllTables_Click(object sender, EventArgs e)
        {
            Thread.Sleep(20);
            Application.DoEvents();

            selTables.CheckChecks();
            for (int i = 0; i < selTables.ItemDatas.Count; i++)
            {
                var itm = selTables.ItemDatas[i] as ItemDataClass;
                var tc = itm.Object as TableClass;
                selFields.ClearItems();
                foreach (var fld in tc.Fields.Values)
                {
                    selFields.Add(fld.ToString(), fld.State, fld);
                }
                selFields.CheckChecks();
            }

        }

        private void hsUncheckAlltables_Click(object sender, EventArgs e)
        {
            Thread.Sleep(20);
            Application.DoEvents();
            //int pos = selTables.SelectedIndex;
            selTables.ClearChecks();
            for (int i = 0; i < selTables.ItemDatas.Count; i++)
            {
                var itm = selTables.ItemDatas[i] as ItemDataClass;
                var tc = itm.Object as TableClass;
                selFields.ClearItems();
                foreach (var fld in tc.Fields.Values)
                {
                    selFields.Add(fld.ToString(), fld.State, fld);
                }
                selFields.ClearChecks();
            }
            //selTables.SelectedIndex = pos;            
        }

        private void hsCheckAllTableFields_Click(object sender, EventArgs e)
        {
            selFields.CheckChecks();
        }

        private void hsUncheckAllTableFields_Click(object sender, EventArgs e)
        {
            selFields.ClearChecks();
        }

        private void SelectAllTableFields()
        {
            int n = selTables.ItemDatas.Count;
            for (int i = 0; i < n; i++)
            {
                var itm = selTables.ItemDatas[i] as ItemDataClass;
                var tc = itm.Object as TableClass;
                selFields.ClearItems();
                foreach (var fld in tc.Fields.Values)
                {
                    selFields.Add(fld.ToString(), fld.State, fld);
                }
                selFields.CheckChecks();
            }
        }
        private void selTables_SelectItem(object sender, SEListBox.SelectItemEventArgs e)
        {
            var itm = selTables.ItemDatas[e.RowIndex] as ItemDataClass;
            var tc = itm.Object as TableClass;
            tableName = tc.Name;
            selFields.ClearItems();
            foreach (var fld in tc.Fields.Values)
            {
                selFields.Add(fld.ToString(), fld.State, fld);
            }
        }

        string tableName = string.Empty;

        private void selFields_SelectItem(object sender, SEListBox.SelectItemEventArgs e)
        {
            var itm = selFields.ItemDatas[e.RowIndex] as ItemDataClass;
            var ob = itm.Object as TableFieldClass;

            if (itm.Check == CheckState.Checked) ob.State = CheckState.Unchecked;
            else ob.State = CheckState.Checked;
        }


        private void selFields_ItemCheckChanged(object sender, CheckItemEventArgs e)
        {
            var itm = selFields.ItemDatas[e.RowIndex] as ItemDataClass;
            var tc = itm.Object as TableFieldClass;
            tc.State = itm.Check;
        }

        DataSet ds = new DataSet();
        private void hsImport_Click(object sender, EventArgs e)
        {
            txtSQLAll.Text = string.Empty;
            EmptyLists();
            if (rbInsert.Checked)
            {
                doImport = true;
                InsertImport();
            }
        }

        string valnames = string.Empty;
        string val = string.Empty;
        bool first = true;


        public void GetValnames(DataRow rw)
        {
            foreach (string ln in rtbColDef.Lines)
            {
                string line = ln.Trim();
                if(line.StartsWith("//")) continue;

                if (line.Contains(">"))
                {
                    foreach (DataColumn cl in rw.Table.Columns)
                    {
                        string cn = cl.ColumnName;
                        Type dt = cl.DataType;
                        string DBCol = string.Empty; // findMapping(cn);
                        bool SplitEnd = false;
                        bool r = false;
                        bool l = false;
                        bool SplitStart = false;
                        string[] larr = line.Split(new char[] { '>' }, StringSplitOptions.RemoveEmptyEntries);
                        if (larr.Length == 2)
                        {
                            string defcol = larr[0].Trim();
                            int inx = defcol.IndexOf(".RSplitEnd(");
                            if (inx >= 0)
                            {
                                int len = inx;
                                defcol = defcol.Substring(0,defcol.Length-15);
                                SplitEnd = true;
                                r = true;
                            }
                            inx = defcol.IndexOf(".LSplitEnd(");
                            if (inx >= 0)
                            {
                                int len = inx;
                                defcol = defcol.Substring(0, defcol.Length - 15);
                                SplitEnd = true;
                                l = true;
                            }
                            inx = defcol.IndexOf(".RSplitStart(");
                            if(inx >= 0)
                            {
                                int len = defcol.Length - inx;
                                defcol = defcol.Substring(0, defcol.Length - 17);
                                SplitStart = true;
                                r = true;
                            }
                            inx = defcol.IndexOf(".LSplitStart(");
                            if (inx >= 0)
                            {
                                int len = defcol.Length - inx;
                                defcol = defcol.Substring(0, defcol.Length - 17);
                                SplitStart = true;
                                l = true;
                            }
                            if (defcol == cn)
                            {
                                DBCol = larr[1].Trim();
                            }
                        }

                        if (string.IsNullOrEmpty(DBCol)) continue;

                        if (dt == typeof(String))
                        {
                            var wert = rw.Field<string>(cn);
                            if (!string.IsNullOrEmpty(wert))
                            {
                                
                                if (l)
                                {
                                    if (SplitEnd && wert.Contains(" "))
                                    {
                                        int inx = wert.LastIndexOf(" ");
                                        wert = wert.Substring(0, inx);
                                    }
                                    else if (SplitStart && wert.Contains(" "))
                                    {
                                        int inx = wert.IndexOf(" ");
                                        wert = wert.Substring(0, inx);
                                    }
                                    else
                                    {
                                        //wert = wert;
                                        Console.WriteLine();
                                    }
                                }
                                else if (r)
                                {
                                    if (SplitEnd && wert.Contains(" "))
                                    {
                                        int inx = wert.LastIndexOf(" ");
                                        wert = wert.Substring(inx);
                                    }
                                    else if (SplitStart && wert.Contains(" "))
                                    {
                                        int inx = wert.IndexOf(" ");
                                        wert = wert.Substring(inx);
                                    }
                                    else
                                    {
                                        wert = string.Empty;
                                    }
                                }
                            }

                            if (first)
                            {
                                valnames += $@"{DBCol}";
                                val += $@"'{wert}'";
                                first = false;
                            }
                            else
                            {
                                valnames += $@",{DBCol}";
                                val += $@",'{wert}'";
                            }
                        }
                        else if (dt == typeof(Int32))
                        {
                            var wert = rw.Field<int>(cn);
                            if (first)
                            {
                                valnames += $@"{DBCol}";
                                val += $@"{wert}";
                                first = false;
                            }
                            else
                            {
                                valnames += $@",{DBCol}";
                                val += $@",{wert}";
                            }
                        }
                        else if (dt == typeof(Double))
                        {
                            var wert = rw.Field<double>(cn);
                            if (first)
                            {
                                valnames += $@"{DBCol}";
                                val += $@"{wert}";
                                first = false;
                            }
                            else
                            {
                                valnames += $@",{DBCol}";
                                val += $@",{wert}";
                            }
                        }
                        else if (dt == typeof(DateTime))
                        {
                            DateTime wert = rw.Field<DateTime>(cn);
                            if (first)
                            {
                                valnames += $@"{DBCol}";
                                val += $@"{wert.ToString("G")}";
                                first = false;
                            }
                            else
                            {
                                valnames += $@",{DBCol}";
                                val += $@",{wert.ToString("G")}";
                            }
                        }
                        else
                        {
                            Console.WriteLine($@"TypeNotUsed:{dt}");
                        }
                    }
                }
                else if (line.Contains("#"))
                {
                    string[] larr = line.Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries);
                    if (larr.Length == 2)
                    {
                        string wertstr = larr[1].Trim().ToUpper();
                        string DBCol = larr[0].Trim();
                        if (wertstr == "DATETIME.NOW")
                        {
                            string wert = DateTime.Now.ToString("G");
                            if (first)
                            {
                                valnames += $@"{DBCol}";
                                val += $@"'{wert}'";
                                first = false;
                            }
                            else
                            {
                                valnames += $@",{DBCol}";
                                val += $@",'{wert}'";
                            }
                        }
                        else if (wertstr == "DATETIME.TODAY")
                        {
                            string wert = DateTime.Today.ToString("G");
                            if (first)
                            {
                                valnames += $@"{DBCol}";
                                val += $@"'{wert}'";
                                first = false;
                            }
                            else
                            {
                                valnames += $@",{DBCol}";
                                val += $@",'{wert}'";
                            }
                        }
                        else if (wertstr.StartsWith("INT("))
                        {
                            string wert = wertstr.Substring(4, wertstr.Length - 5);
                            if (first)
                            {
                                valnames += $@"{DBCol}";
                                val += $@"{wert}";
                                first = false;
                            }
                            else
                            {
                                valnames += $@",{DBCol}";
                                val += $@",{wert}";
                            }
                        }
                        else if (wertstr.StartsWith("DOUBLE("))
                        {
                            string wert = wertstr.Substring(7, wertstr.Length - 8);
                            if (first)
                            {
                                valnames += $@"{DBCol}";
                                val += $@"{wert}";
                                first = false;
                            }
                            else
                            {
                                valnames += $@",{DBCol}";
                                val += $@",{wert}";
                            }
                        }
                    }
                }

            }
        }

        private void InsertImport()
        {
            done = 0;
            notdone = 0;
            pbSQL.Minimum = 0;
            pbSQL.Maximum = ds.Tables[0].Rows.Count;
            pbSQL.Value = 0;
            var rws = ds.Tables[0].Rows;
            int i = 0;
            foreach (DataRow rw in rws)
            {
                if (!doImport) break;
                Guid gd = Guid.NewGuid();
                bool newguid = true;
                first = true;
                valnames = string.Empty;
                val = string.Empty;
                string cmd = $@"INSERT INTO {tableName} ";

                if (newguid)
                {
                    valnames += "ID";
                    val += $@"'{gd}'";
                    first = false;
                }

                GetValnames(rw);
                i++;
                gbProcessBar.Text = $@"Process {i}({pbSQL.Maximum})";
                pbSQL.Value++;
                // ExecuteSQL($@"{cmd} ({valnames}) VALUES ({val})");
                txtSQLAll.Text += $@"{cmd} ({valnames}) VALUES ({val}){Environment.NewLine}";
                Application.DoEvents();
                if (!ckTestmode.Checked) ExecSql($@"{cmd} ({valnames}) VALUES ({val})");
            }
        }


        bool doImport = false;
        int done = 0;
        int notdone = 0;

        private SQLCommandsReturnInfoClass ExecSql(string command)
        {
            var _sqLcommand = new SQLCommandsClass(DBReg);

            _sqLcommand.SetEncoding(cbEncoding.Text);

            var ri = _sqLcommand.ExecuteCommandWithGlobalConnection(command, true);
            if (ri.commandDone)
            {
                done++;
                txtSQLdone.Text += $@"{command}{Environment.NewLine}";
                tabPageSQLdone.Text = $@"SQL done {done}";
            }
            else
            {
                notdone++;
                txtSQLfail.Text += $@"{command}{Environment.NewLine}";
                tabPageSQLfail.Text = $@"SQL fail {notdone}";
            }

            return ri;
        }


        private void hsImportXML_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML|*.xml|ALL|*.*";
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Title = "Reading XML file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbSource.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                ds.Clear();
                //ds.ReadXml(openFileDialog1.FileName);

                System.Net.WebRequest request = System.Net.WebRequest.Create(openFileDialog1.FileName);

                using (System.Net.WebResponse response = (System.Net.FileWebResponse)request.GetResponse())
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(response.GetResponseStream(), Encoding.Default))
                    {
                        ds.ReadXml(sr);
                    }
                }


                gbImport.Text = $@"Read {ds.Tables[0].Rows.Count} datarows from XML";
            }
            dataGridView1.DataSource = ds;
        }

        private string ToDBCharsetName(Encoding enc)
        {
            if (enc == Encoding.UTF8) return "UTF8";
            if (enc == Encoding.ASCII) return "ASCII";
            if (enc.HeaderName == "Windows-1250") return "WIN1250";
            if (enc.HeaderName == "Windows-1251") return "WIN1251";
            if (enc.HeaderName == "Windows-1252") return "WIN1252";
            if (enc.HeaderName == "ISO8859-1") return "ISO8859_1";
            if (enc.HeaderName == "ISO8859-2") return "ISO8859_2";
            return enc.HeaderName;
        }
        private Encoding GetCharsetEncodingFromName(string enc)
        {
            //var  es = Encoding.GetEncodings();
            if (enc == "UTF8") return Encoding.UTF8;
            if (enc == "ASCII") return Encoding.ASCII;
            return Encoding.Default;
        }

            public void FillCHarsets()
        {
            cbEncodingCSV.Items.Clear();
            cbEncoding.Items.Clear();
            cbEncodingCSV.Items.Add("NONE");
            cbEncodingCSV.Items.Add("ASCII");
            cbEncodingCSV.Items.Add("UTF8");
            cbEncodingCSV.Items.Add("ISO8859_1");
            cbEncodingCSV.Items.Add("ISO8859_2");
            cbEncodingCSV.Items.Add("WIN1250");
            cbEncodingCSV.Items.Add("WIN1251");
            cbEncodingCSV.Items.Add("WIN1252");

            cbEncoding.Items.Add("NONE");
            cbEncoding.Items.Add("ASCII");
            cbEncoding.Items.Add("UTF8");
            cbEncoding.Items.Add("ISO8859_1");
            cbEncoding.Items.Add("ISO8859_2");
            cbEncoding.Items.Add("WIN1250");
            cbEncoding.Items.Add("WIN1251");
            cbEncoding.Items.Add("WIN1252");

        }

        private void hsImportCSV_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV|*.csv|ALL|*.*";
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Title = "Reading CSV file, converting to XML";
            Encoding enc = GetCharsetEncodingFromName(cbEncodingCSV.Text);
           
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog1.FileName, Encoding.Default);
                ds.Clear();
                XElement cust = new XElement("CSVImports");

                bool first = true;
                foreach (string line in lines)
                {
                    if (string.IsNullOrEmpty(line)) continue;
                    if (first)
                    {
                        csvCols = line.Split(new char[] { colSep }, StringSplitOptions.RemoveEmptyEntries);
                        first = false;
                    }
                    else
                    {
                        XElement cust2 = new XElement("Table");
                        cust.Add(cust2);
                        string[] csvValues = line.Split(new char[] { colSep }, StringSplitOptions.None);
                        for (int i = 0; i < csvCols.Length; i++)
                        {
                            XElement cust3 = new XElement(csvCols[i], csvValues[i].ToString());
                            cust2.Add(cust3);
                        }
                    }
                }
                string xmlfn = $@"{openFileDialog1.FileName.Replace(".", "_")}.xml";
                string sout = "<?xml version=\"1.0\" encoding=\"ASCII\" standalone=\"yes\"?>";
                sout = sout + Environment.NewLine + cust.ToString();

                File.WriteAllText(xmlfn, sout, Encoding.Default);
                rtbSource.LoadFile(xmlfn, RichTextBoxStreamType.PlainText);

                System.Net.WebRequest request = System.Net.WebRequest.Create(xmlfn);

                using (System.Net.WebResponse response = (System.Net.FileWebResponse)request.GetResponse())
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(response.GetResponseStream(), Encoding.Default))
                    {
                        ds.ReadXml(sr);
                    }
                }
                gbImport.Text = $@"Read {ds.Tables[0].Rows.Count} datarows from XML (CSV)";
                dataGridView1.DataSource = ds;
            }
        }
        private char colSep = ';';
        private string[] csvCols;
        private string ColDefFileName = string.Empty;

        private void hsLoadDefinition_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "ColDef|*.cdf|ALL|*.*";
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Title = "Reading col definitions";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ColDefFileName = openFileDialog1.FileName;
                rtbColDef.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void hsSaveDefinition_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "ColDef|*.cdf|ALL|*.*";
            saveFileDialog1.FileName = ColDefFileName;
            saveFileDialog1.Title = "Save col definitions";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbColDef.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                ColDefFileName = saveFileDialog1.FileName;
            }
        }

        private void hotSpot1_Click(object sender, EventArgs e)
        {
            doImport = false;
        }

        private void EmptyLists()
        {
            if (ckEmptyLists.Checked)
            {
                txtSQLdone.Text = string.Empty;
                txtSQLfail.Text = string.Empty;
                tabPageSQLfail.Text = $@"SQL fail";
                tabPageSQLdone.Text = $@"SQL done";
                done = 0;
                notdone = 0;
                pbSQL.Minimum = 0;
                pbSQL.Maximum = ds.Tables[0].Rows.Count;
                pbSQL.Value = 0;
            }
        }

        private void hsDoSQL_Click(object sender, EventArgs e)
        {
            int i = 0;

            EmptyLists();
            pbSQL.Minimum = 0;
            pbSQL.Maximum = txtSQLAll.Lines.Length;
            pbSQL.Value = 0;
            foreach (string lnb in txtSQLAll.Lines)
            {
                if (string.IsNullOrEmpty(lnb)) continue;
                i++;
                gbProcessBar.Text = $@"Process {i}({pbSQL.Maximum})";
                pbSQL.Value++;
                if (!ckTestmode.Checked) ExecSql($@"{lnb}");
            }
        }

        private void cmsColDefData_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsmiDateTimeNow)
            {
                rtbColDef.Text = rtbColDef.Text.Insert(rtbColDef.SelectionStart, "#DateTime.Now");
            }
            else if (e.ClickedItem == tsmiDateTimeToday)
            {
                rtbColDef.Text = rtbColDef.Text.Insert(rtbColDef.SelectionStart, "#DateTime.Today");
            }
            else if (e.ClickedItem == tsmiINT)
            {
                rtbColDef.Text = rtbColDef.Text.Insert(rtbColDef.SelectionStart, "#Int(0)");
            }
            else if (e.ClickedItem == tsmiDOUBLE)
            {
                rtbColDef.Text = rtbColDef.Text.Insert(rtbColDef.SelectionStart, "#Double(0)");
            }
            else if (e.ClickedItem == tsmiEXPORTDataCopyToCLipboard)
            {
                Clipboard.SetText(rtbColDef.SelectedText);
            }
            else if (e.ClickedItem == tsmiEXPORTDataPasteFromClipboard)
            {
                rtbColDef.Text = rtbColDef.Text.Insert(rtbColDef.SelectionStart, Clipboard.GetText());
            }
        }
    }
}


