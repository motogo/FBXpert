using BasicClassLibrary;
using ExtendedXmlSerializer.Configuration;
using ExtendedXmlSerializer.ExtensionModel.Xml;
using FastColoredTextBoxNS;
using FBExpert;
using FBExpert.DataClasses;
using FBXpert.DataClasses;
using FBXpert.Globals;
using MessageFormLibrary;
using SEListBox;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.String;

namespace FBXpert.SonstForms
{
    public partial class XmlDesignForm : Form
    {
        private readonly NotifiesClass _localNotify = new NotifiesClass();
        private readonly DBRegistrationClass _dbReg;
        private readonly DatabaseDesignClass _ddc = new DatabaseDesignClass();
        private int _errorCount;
        private int _messagesCount;
        private bool _codeAttributesChanged;
        private List<int> _findlst;
        private int _aktSelectedLine;
        private AutocompleteMenu _popupMenu;

        public XmlDesignForm(Form parent, DBRegistrationClass reg)
        {
            InitializeComponent();
            MdiParent = parent;
            _dbReg = reg;
            _localNotify.Register4Info(InfoRaised);
            _localNotify.Register4Error(ErrorRaised);
            LanguageClass.Instance().RegisterChangeNotifiy(LanguageChanged);
        }
        
        private void LanguageChanged(object sender, LanguageChangedEventArgs k)
        {
            LanguageChanged();
        }

        private void LanguageChanged()
        {
            gbExportProgress.Text   = LanguageClass.Instance().GetString("PROGRESS");
            hsSaveSourceCodes.Text  = LanguageClass.Instance().GetString("CreateSourcecode");
            gbSourceCode.Text       = LanguageClass.Instance().GetString("SourcecodePath");
            gbFoundLines.Text       = LanguageClass.Instance().GetString("FoundLines");
            gbSearchCode.Text       = LanguageClass.Instance().GetString("SEARCH");
            object[] param = {_messagesCount, _errorCount};
            tabPageMessages.Text            = LanguageClass.Instance().GetString("MESSAGES_INFO_ERROR", param);
            tabPageCreateAttributes.Text    = LanguageClass.Instance().GetString("SETTINGS");
            hsClearMessages.Text            = LanguageClass.Instance().GetString("CLEAR_ENTRIES");
        }

        private void ErrorRaised(object sender, MessageEventArgs k)
        {
            fctMessages.CurrentLineColor = Color.Red;
            fctMessages.AppendText(k.Meldung);         
            _errorCount++;            
            fctMessages.ScrollLeft();
            
            object[] param = {_messagesCount, _errorCount};
            tabPageMessages.Text = LanguageClass.Instance().GetString("MESSAGES_INFO_ERROR", param);
        }

        private void InfoRaised(object sender, MessageEventArgs k)
        {
            fctMessages.CurrentLineColor = Color.Blue;
            fctMessages.AppendText(k.Meldung);            
            _messagesCount++;            
            fctMessages.ScrollLeft();
            tabPageMessages.Text = Format(LanguageClass.Instance().GetString("MESSAGES_INFO_ERROR"),_messagesCount,_errorCount);
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hsRefresh_Click(object sender, EventArgs e)
        {
            RefreshXml();
        }
        
        public void RefreshXml()
        {
            _ddc.Tables = StaticTreeClass.Instance().GetAllTableObjectsComplete(_dbReg);
            _ddc.Views  = StaticTreeClass.Instance().GetViewObjects(_dbReg);
            StaticTreeClass.Instance().GetAllTablePrimaryKeyObjects(_dbReg, _ddc.Tables);
            _ddc.Database = _dbReg;
            var fs = new FileStream(Application.StartupPath + "\\temp\\tmp.xml", FileMode.Create);
            var serializer = new ConfigurationContainer().Create();
            var xml = serializer.Serialize(fs,_ddc);

           

//            var serializer = new XmlSerializer(typeof(DatabaseDesignClass));
          //  var fs = new FileStream(Application.StartupPath + "\\temp\\tmp.xml", FileMode.Create);
            //serializer.Serialize(_ddc,Application.StartupPath + "\\temp\\tmp.xml");
            fs.Close();
            xmlEditStruktur.LoadXmlFromFile(Application.StartupPath + "\\temp\\tmp.xml");
        }
        /*
        public void RefreshXml2()
        {
            string cmd = SQLStatementsClass.Instance().GetForRefreshXML(_dbReg.Version);
            try
            {
                var con2 = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(_dbReg));
                con2.Open();

                var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(_dbReg));
                con.Open();

                var fcmd = new FbCommand(cmd, con);
                var dread = fcmd.ExecuteReader();
                if (!dread.HasRows) return;


                var strl = new StringBuilder();
                strl.AppendLine("<SCHEMA Name='NewProfile'>");

                var n = 0;
                while (dread.Read())
                {
                    var ob = dread.GetValue(0);
                    int tp = StaticFunctionsClass.ToIntDef(dread.GetValue(1).ToString().Trim(), -1);

                    var enc = System.Text.Encoding.Default;
                    var vn = ob.ToString().Trim();

                    if (tp == (int)FBRelationTypeIndex.Table)
                    {
                        strl.AppendLine("<TABLE Name='" + vn + "'>");
                    }
                    else if (tp == (int)FBRelationTypeIndex.View)
                    {
                        strl.AppendLine("<VIEW Name='" + vn + "'>");
                    }

                    string fcmd3 = SQLStatementsClass.Instance().GetFieldsForRefreshXML(_dbReg.Version, vn);

                    var fcmd2 = new FbCommand(fcmd3, con2);
                    var dread2 = fcmd2.ExecuteReader();
                    if (dread2.HasRows)
                    {
                        var strl2 = new StringBuilder();
                        while (dread2.Read())
                        {
                            var fieldname = dread2.GetValue(1);
                            int length = StaticFunctionsClass.ToIntDef(dread2.GetValue(5).ToString().Trim(), 0);
                            string type = dread2.GetValue(4).ToString().Trim();
                            string virtualType = StaticVariablesClass.ConvertDesignType(type, length);
                            int nullflag = StaticFunctionsClass.ToIntDef(dread2.GetValue(11).ToString().Trim(), 0);
                            strl.AppendLine("    <FIELD Name='" + fieldname.ToString().Trim() + "'>");
                            strl.AppendLine("        <TYP>" + virtualType + "</TYP>");
                            strl.AppendLine("        <LENGTH>" + length.ToString() + "</LENGTH>");
                            strl.AppendLine(nullflag <= 0 ? "        <NULLABLE>YES</NULLABLE>" : "        <NULLABLE>NO</NULLABLE>");
                            strl.AppendLine("    </FIELD>");
                        }
                    }
                    switch (tp)
                    {
                        case (int)FBRelationTypeIndex.Table:
                            strl.AppendLine("</TABLE>");
                            break;
                        case (int)FBRelationTypeIndex.View:
                            strl.AppendLine("</VIEW>");
                            break;
                    }
                }
                strl.AppendLine("</SCHEMA>");                    
                n++;
            }
            catch (Exception ex)
            {
                _localNotify?.AddToERROR(StaticFunctionsClass.DateTimeNowStr() + "->RefreshXML->" + ex.Message);
            }
        }
        */
        private void hsSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"XML|*.xml|All|*.*";
            saveFileDialog1.DefaultExt = @"*.xml";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            xmlEditStruktur.SaveXmlToFile(saveFileDialog1.FileName);
        }

        private void XMLDesignForm_Load(object sender, EventArgs e)
        {
            LanguageChanged();
            hsSearchDown.Enabled = false;
            hsSearchUp.Enabled   = false;
            hsSeach.Enabled = txtSearchCode.TextLength > 0;           
            fbdSourcePath.SelectedPath         = _dbReg.CodeSettings.SourceCodeOutputPath;
            txtSourceCodePath.Text             = _dbReg.CodeSettings.SourceCodeOutputPath;
            
            rbGenerateInrWithGenerator.Checked = _dbReg.CodeSettings.SourceCodePrimaryKeyType == eSourceCodePrimaryKeyType.GeneratorInteger;
            rbGenerateGUID.Checked             = _dbReg.CodeSettings.SourceCodePrimaryKeyType == eSourceCodePrimaryKeyType.GUID;
            rbGenerateOID.Checked              = _dbReg.CodeSettings.SourceCodePrimaryKeyType == eSourceCodePrimaryKeyType.UUID;
            rbGUIDHEXGeneration.Checked        = _dbReg.CodeSettings.SourceCodePrimaryKeyType == eSourceCodePrimaryKeyType.HEXGUID;

            txtDBNamespace.Text                = _dbReg.CodeSettings.SourceCodeNamespace;
            ShowCaptions();
            if (DbExplorerForm.Instance().Visible)
            {
                Left = DbExplorerForm.Instance().Width + 16;
            }
            RefreshXml();
            FillDBObjects();
        }

        public void ShowCaptions()
        {
            lblCaption.Text = $@"Database Designer:{_dbReg.Alias}";
            Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, "Database Designer");
        }
        
        private void hsClearMessages_Click(object sender, EventArgs e)
        {
            fctMessages.Clear();
        }

        private void hsCreateClasses_Click(object sender, EventArgs e)
        {            
            FillDBObjects();
        }

        private void FillDBObjects()
        {                    
            var fs = new FileStream(xmlEditStruktur.originalXmlFile, FileMode.Open);                     
            var serializer = new ConfigurationContainer().Create();
            var ddc = (DatabaseDesignClass) serializer.Deserialize<DatabaseDesignClass>(fs);
            fs.Close();           
            fctSource.Clear();
            /*
            CodeFactory.Instance().Init(_localNotify);
            CodeFactory.Instance().CodeCreateAttribute.PrimaryFieldType = rbGenerateInrWithGenerator.Checked ? eCodePrimaryFieldType.GenID : eCodePrimaryFieldType.GenUUID;
            */
            selDBObjects.ClearItems();

            foreach (var tc in ddc.Tables.Values)
            {
                foreach(var fld in tc.Fields)
                {
                    if (fld.Value.Domain.RawType.Length > 0) continue;                    
                }
            }

            foreach (var tc in ddc.Views.Values)
            {
                foreach (var fld in tc.Fields.Values)
                {
                    if (fld.Domain.RawType.Length > 0) continue;                    
                }
            }

            foreach (var tc in ddc.Tables.Values)
            {                
                selDBObjects.Add(tc.Name, CheckState.Checked, tc);
            }

            foreach (var tc in ddc.Views.Values)
            {             
                selDBObjects.Add(tc.Name, CheckState.Checked, tc);
            }

            foreach (var tc in ddc.Tables.Values)
            {             
                selDBObjects.Add($@"Cb{tc.Name}", CheckState.Checked, tc);
            }

            foreach (var tc in ddc.Views.Values)
            {             
                selDBObjects.Add($@"Cb{tc.Name}", CheckState.Checked, tc);
            }
            if(selDBObjects.ItemDatas.Count > 0)
            selDBObjects.SelectedIndex = 0;
        }

        private void UpdateCodeAttributes()
        {
            CodeFactory.Instance().Init(_localNotify, _dbReg.Alias);
            if (rbGenerateInrWithGenerator.Checked)
            {
                CodeFactory.Instance().CodeCreateAttribute.PrimaryFieldType = eCodePrimaryFieldType.GenID;
            }
            else if (rbGenerateGUID.Checked)
            {
                CodeFactory.Instance().CodeCreateAttribute.PrimaryFieldType = eCodePrimaryFieldType.GenGUID;
            }
            else if (rbGenerateOID.Checked)
            {
                CodeFactory.Instance().CodeCreateAttribute.PrimaryFieldType = eCodePrimaryFieldType.GenOID;
            }
            else if (rbGUIDHEXGeneration.Checked)
            {
                CodeFactory.Instance().CodeCreateAttribute.PrimaryFieldType = eCodePrimaryFieldType.GenGUIDHEX;
            }
            CodeFactory.Instance().CodeCreateAttribute.CodeNamespace = txtDBNamespace.Text.Trim();                        
        }

        private string MakeGlobalCode()
        {
            var items = selDBObjects.CheckedItemDatas;
            return CodeFactory.Instance().MakeGlobalCode(items,0);            
        }

        private string MakeSourceCode(object ob)
        {
            var st = Empty;
            UpdateCodeAttributes();
            
            if (ob.GetType() == typeof(TableClass))
            {
                var tc = ob as TableClass;
                st = CodeFactory.Instance().CreateDesignForTable(0, tc);
            }
            else if (ob.GetType() == typeof(ViewClass))
            {
                var tc = ob as ViewClass;
                st = CodeFactory.Instance().CreateDesignForView(0, tc);
            }
            return st;
        }

        private string MakeCbSourceCode(object ob)
        {
            string st = Empty;
            UpdateCodeAttributes();
            if (ob.GetType() == typeof(TableClass))
            {
                var tc = ob as TableClass;                
                st = CodeFactory.Instance().CreateDesignForCbTable(0, tc);               
            }
            else if (ob.GetType() == typeof(ViewClass))
            {
                var tc = ob as ViewClass;                
                st = CodeFactory.Instance().CreateDesignForCbTable(0, tc);                
            }
            return st;
        }

        private void selDBObjects_ItemSelect(object sender, SelectItemEventArgs e)
        {
            fctSource.Clear();
            if (selDBObjects.SelectedIndex < 0) return;
            var itm = selDBObjects.ItemDatas[selDBObjects.SelectedIndex];
                        
            var source = itm.Text.StartsWith("Cb") ? MakeCbSourceCode(itm.Object) : MakeSourceCode(itm.Object);

            if (source.Length > 0)
            {
                fctSource.AppendText(source);
            }
            RefreshAutocomplete(itm.Object as DataObjectClass);
        }

        private void hsSelectPath_Click(object sender, EventArgs e)
        {
            if (fbdSourcePath.ShowDialog() != DialogResult.OK) return;
            txtSourceCodePath.Text = fbdSourcePath.SelectedPath;
        }

        private void hsSaveSourceCodes_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists(txtSourceCodePath.Text))
            {
                object[] p = { txtSourceCodePath.Text, Environment.NewLine };               
                SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(), "DirectoryNotExists", "DirectoryNotExistsParam", FormStartPosition.CenterScreen, SEMessageBoxButtons.OK, SEMessageBoxIcon.Exclamation, null, p);
                return;
            }
            var items = selDBObjects.CheckedItemDatas;
            pbExport.Minimum = 0;
            pbExport.Value = 0;
            pbExport.Maximum = items.Count;
            if(ckDeleteOldSourceFiles.Checked)
            {
                string[] files = Directory.GetFiles(txtSourceCodePath.Text);
                foreach(string file in files)
                {
                    try
                    {
                        File.Delete($@"{file}");
                    }
                    catch //(Exception ex)
                    {

                    }
                }
            }
            var gsource = MakeGlobalCode();

            try
            {
                var fi = new FileInfo(txtSourceCodePath.Text + "\\DBGlobalFunctionsClass.cs");
                if (fi.Directory != null && fi.Directory.Exists)
                {
                    File.WriteAllText(txtSourceCodePath.Text + "\\DBGlobalFunctionsClass.cs", gsource);
                }
            }
            catch(Exception ex)
            {
                 _localNotify?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"hsSaveSourceCodes_Click", ex));                          
            }


            foreach(var itm in items)
            {                
                var source = itm.Text.StartsWith("Cb") ? MakeCbSourceCode(itm.Object) : MakeSourceCode(itm.Object);

                try
                {
                    var fi = new FileInfo(txtSourceCodePath.Text + "\\" + itm.Text + "Class.cs");
                    if (fi.Directory != null && fi.Directory.Exists)
                    {
                        File.WriteAllText(txtSourceCodePath.Text + "\\" + itm.Text + "Class.cs", source);
                    }
                }
                catch(Exception ex)
                {
                     _localNotify?.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"hsSaveSourceCodes_Click", ex));                          
                }
                
                pbExport.Value++;
                gbExportProgress.Text = LanguageClass.Instance().GetString("PROGRESS")+$@" ({pbExport.Value}/{pbExport.Maximum})";               
                Application.DoEvents();
            }           
        }

        private void XMLDesignForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dbReg.CodeSettings.SourceCodeOutputPath = txtSourceCodePath.Text;
            if(rbGenerateInrWithGenerator.Checked)      _dbReg.CodeSettings.SourceCodePrimaryKeyType = eSourceCodePrimaryKeyType.GeneratorInteger;
            else if(rbGenerateGUID.Checked)             _dbReg.CodeSettings.SourceCodePrimaryKeyType = eSourceCodePrimaryKeyType.GUID;
            else if(rbGUIDHEXGeneration.Checked)        _dbReg.CodeSettings.SourceCodePrimaryKeyType = eSourceCodePrimaryKeyType.HEXGUID;
            _dbReg.CodeSettings.SourceCodeNamespace = txtDBNamespace.Text;
        }

        private void codeAttributes_Changed(object sender, EventArgs e)
        {
            _codeAttributesChanged = true;
        }
        
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (!_codeAttributesChanged) return;

            object[] param = { Environment.NewLine };
            _codeAttributesChanged = false;
            
        }
        
        private void cmsSourceCode_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {            
            if (e.ClickedItem == tsmiSearchFirst)
            {
                string srch = @"^.*\b(get|#endregion|three)\b.*$";
                _findlst = fctSource.FindLines(srch, RegexOptions.Multiline);
                if (_findlst.Count <= 0) return;

                var pl = new Place(0, _findlst[0]);
                var ple = new Place(0, _findlst[0] + 1);
                fctSource.Navigate(pl.iLine);
                fctSource.Selection.Start = pl;
                fctSource.Selection.End = ple;
                fctSource.Invalidate();
                  
                _aktSelectedLine = 0;
            }
            else if (e.ClickedItem == tsmiSearchNext)
            {
                if (_aktSelectedLine >= _findlst.Count) return;

                var pl = new Place(0, _findlst[++_aktSelectedLine]);
                var ple = new Place(0, _findlst[_aktSelectedLine] + 1);
                fctSource.Navigate(pl.iLine);
                fctSource.Selection.Start = pl;
                fctSource.Selection.End = ple;
                fctSource.Invalidate();
            }
        }

        private void SelectLine(int i)
        {
            var pl = new Place(0, _findlst[i]);
            var ple = new Place(0, _findlst[i] + 1);
            fctSource.Navigate(pl.iLine);
            fctSource.Selection.Start = pl;
            fctSource.Selection.End = ple;
            fctSource.Invalidate();
        }
        
        public void RefreshAutocomplete(DataObjectClass obj)
        {
            //create autocomplete popup menu
            if (obj == null) return;
            _popupMenu = new AutocompleteMenu(fctSource)
            {
                MinFragmentLength = 2
            };

            var words = new List<string>
            {
                obj.Name,
                obj.Name + "Class",
                obj.Name + "Class.TDataClass",
                obj.Name + "Class.TDataClass.TColumns"
            };

            if (obj.GetType() == typeof(TableClass))
            {
                var tc = (TableClass) obj;                            
                foreach (var tcf in tc.Fields)
                {
                    words.Add(tcf.Value.Name);
                    words.Add(tc.Name+"."+tcf.Value.Name);
                }
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var tc = (ViewClass) obj;                
                foreach (var tcf in tc.Fields.Values)
                {
                    words.Add(tcf.Name);
                    words.Add(tc.Name + "." + tcf.Name);
                }
            }

            _popupMenu.Items.SetAutocompleteItems(words);
            //size of popupmenu
            _popupMenu.Items.MaximumSize = new Size(200, 300);
            _popupMenu.Items.Width = 200;
        }

        public void AutocompleteSample()
        {           
            //create autocomplete popup menu
            _popupMenu = new AutocompleteMenu(fctSource)
            {
                MinFragmentLength = 1
            };

            //generate 456976 words
            var randomWords = new List<string>();            
            //set words as autocomplete source
            _popupMenu.Items.SetAutocompleteItems(randomWords);
            //size of popupmenu
            _popupMenu.Items.MaximumSize = new Size(200, 300);
            _popupMenu.Items.Width = 200;
        }

        private void fctb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != (Keys.K | Keys.Control)) return;
           
            _popupMenu.Show(true);
            e.Handled = true;
        }

        private void hsSeach_Click(object sender, EventArgs e)
        {
            AutocompleteSample();
            var srch = @"^.*\b("+txtSearchCode.Text+@")\b.*$";
            _findlst = fctSource.FindLines(srch, RegexOptions.Multiline);
            _aktSelectedLine = 0;
            cbFoundLines.Items.Clear();
            if (_findlst.Count <= 0) return;

            var n = 0;
            foreach (var ln in _findlst)
            {
                var so = new CbSearchObject
                {
                    LineIndex = n++,
                    Line = ln + 1,
                    Text = fctSource.Lines[ln].Trim()
                };
                cbFoundLines.Items.Add(so); 
            }

            cbFoundLines.SelectedIndex = cbFoundLines.Items.Count > 0 ? 0 : -1;
            hsSearchDown.Enabled = true;
            hsSearchUp.Enabled = true;
            _aktSelectedLine = 0;
            SelectLine(_aktSelectedLine);
        }

        private void hsSearchDown_Click(object sender, EventArgs e)
        {
            if (_findlst.Count <= 0) return;
            _aktSelectedLine++;
            if (_aktSelectedLine >= _findlst.Count) _aktSelectedLine = 0;
            SelectLine(_aktSelectedLine);
        }

        private void hsSearchUp_Click(object sender, EventArgs e)
        {
            if (_findlst.Count <= 0) return;
            _aktSelectedLine--;
            if (_aktSelectedLine < 0) _aktSelectedLine = _findlst.Count - 1;
            SelectLine(_aktSelectedLine);
        }

        private void txtSearchCode_TextChanged(object sender, EventArgs e)
        {
            hsSeach.Enabled = txtSearchCode.TextLength > 0;
            hsSearchDown.Enabled = false;
            hsSearchUp.Enabled = false;
        }

        private void cbFoundLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFoundLines.SelectedIndex < 0) return;
            var ob = (CbSearchObject)cbFoundLines.Items[cbFoundLines.SelectedIndex]; 
            SelectLine(ob.LineIndex);
            _aktSelectedLine = ob.LineIndex;
        }

        private void hsCreateCVS_Click(object sender, EventArgs e)
        {
            var items = selDBObjects.CheckedItemDatas;
            pbExport.Minimum = 0;
            pbExport.Value = 0;
            pbExport.Maximum = items.Count;
            var sb = new StringBuilder();
            sb.Append($@"DBNAME;LINKTYPE;LINKART;OBJTYPE_A;OBJ_A;OBJ_A_FIELD;OBJTYPE_B;OBJ_B;OBJ_B_FIELD;STAT;NR{Environment.NewLine}");
            int n = 0;
            string dbname = _dbReg.Alias.Replace(" ","_");
            foreach(var itm in items)
            {                               
                if(itm.Object.GetType() == typeof(TableClass)&&(!itm.Text.StartsWith("Cb")))
                {
                    var obj = (TableClass) itm.Object;
                    foreach(var field in obj.Fields)
                    {
                        if(field.Value.Name.EndsWith("_ID"))
                        {
                            string tabname = field.Value.Name.Substring(0,field.Value.Name.Length-3);
                            sb.Append($@"{dbname};LOGICAL;TT;TABLE;{tabname};ID;TABLE;{obj.Name};{field.Value.Name};1;{n++}{Environment.NewLine}");
                        }
                    }
                }
                else if(itm.Object.GetType() == typeof(ViewClass)&&(!itm.Text.StartsWith("Cb")))
                {
                    var obj = (ViewClass) itm.Object;
                    foreach(var field in obj.Fields)
                    {
                        if(field.Value.Name.EndsWith("__ID"))
                        {
                            string tabname = field.Value.Name.Substring(0,field.Value.Name.Length-4);
                            sb.Append($@"{dbname};LOGICAL;TV;TABLE;{tabname};ID;VIEW;{obj.Name};{field.Value.Name};2;{n++}{Environment.NewLine}");
                        }
                    }
                }
                
                
                pbExport.Value++;
                gbExportProgress.Text = LanguageClass.Instance().GetString("PROGRESS")+$@" ({pbExport.Value}/{pbExport.Maximum})";               
                Application.DoEvents();
            } 
            fctSource.Text = sb.ToString();
        }

        private void hsSave_Click_1(object sender, EventArgs e)
        {
            if(saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                fctSource.SaveToFile(saveFileDialog2.FileName,Encoding.UTF8);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPageCreateAttributes_Leave(object sender, EventArgs e)
        {
            if(_codeAttributesChanged) FillDBObjects();
        }
        
        private void tabPageCreateAttributes_Enter(object sender, EventArgs e)
        {
            _codeAttributesChanged = false;
        }
    }

    class CbSearchObject
    {
        public int Line;
        public int LineIndex;
        public string Text;
        public override string ToString()
        {
            return $"{Line,-6}->{Text}";
        }
    }

}
