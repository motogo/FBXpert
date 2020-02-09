using BasicClassLibrary;
using FastColoredTextBoxNS;
using FBExpert;
using FBExpert.DataClasses;
using FBXpert.DataClasses;
using FBXpert.Globals;
using MessageLibrary;
using SEListBox;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace FBXpert.SonstForms
{
    public partial class DatabaseCompareFrom : Form
    {
        private readonly NotifiesClass _localNotify = new NotifiesClass();
        private readonly DBRegistrationClass _dbReg;
        private readonly DatabaseDesignClass _ddc = new DatabaseDesignClass();        
        private List<int> _findlst;
        private int _aktSelectedLine;
        private AutocompleteMenu _popupMenu;

        public DatabaseCompareFrom(Form parent, DBRegistrationClass reg)
        {
            InitializeComponent();
            MdiParent = parent;
            _dbReg = reg;
           
            LanguageClass.Instance().RegisterChangeNotifiy(LanguageChanged);
        }
        
        private void LanguageChanged(object sender, LanguageChangedEventArgs k)
        {
            LanguageChanged();
        }

        private void LanguageChanged()
        {                      
            gbFoundLines.Text = LanguageClass.Instance().GetString("FoundLines");
            gbSearchCode.Text = LanguageClass.Instance().GetString("SEARCH");
           
            tabPageObjects.Text = LanguageClass.Instance().GetString("OBJECTS");
            tabPageOptions.Text = LanguageClass.Instance().GetString("SETTINGS");          
        }
       
        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hsRefresh_Click(object sender, EventArgs e)
        {
            GetAllDatabases();
        }

        private void GetAllDatabases()
        {
            this.Cursor = Cursors.WaitCursor;
            var databases = DatabaseDefinitions.Instance().Databases;
            slbDatabase1.ClearItems();
            slbDatabase2.ClearItems();
            foreach (var dbReg in databases)
            {
                slbDatabase1.Add(dbReg.Alias, CheckState.Checked, dbReg);
                slbDatabase2.Add(dbReg.Alias, CheckState.Checked, dbReg);
            }

            if (slbDatabase1.ItemDatas.Count > 0)
            {
                slbDatabase1.SelectedIndex = 0;
            }
            if (slbDatabase2.ItemDatas.Count > 0)
            {
                slbDatabase2.SelectedIndex = 0;
            }   
            this.Cursor = Cursors.Default;
        }

        private void GetDatabaseObjects1(DBRegistrationClass dbR)
        {
            
            if (dbR == null) return;
            this.Cursor = Cursors.WaitCursor;
            var db = dbR.Clone();
            var ddc = new DatabaseDesignClass
            {
                Tables = StaticTreeClass.Instance().GetAllTableObjectsComplete(db),
                Views  = StaticTreeClass.Instance().GetViewObjects(db)
            };
            var generators = StaticTreeClass.Instance().GetGeneratorObjects(db);
            var procedures = StaticTreeClass.Instance().GetProcedureObjects(db);
            var functions  = StaticTreeClass.Instance().GetFunctionObjects(db);


            slbDbObjects1.ClearItems();
            foreach (var tc in ddc.Tables.Values)
            {                
                slbDbObjects1.Add($@"TABLE.{tc.Name}", CheckState.Checked, tc);
            }

            foreach (var tc in ddc.Views.Values)
            {             
                slbDbObjects1.Add($@"VIEW.{tc.Name}", CheckState.Checked, tc);
            }  
            
            foreach (var tc in generators.Values)
            {             
                slbDbObjects1.Add($@"GEN.{tc.Name}", CheckState.Checked, tc);
            } 
            foreach (var tc in procedures.Values)
            {             
                slbDbObjects1.Add($@"PROC.{tc.Name}", CheckState.Checked, tc);
            }
            foreach (var tc in functions.Values)
            {
                slbDbObjects1.Add($@"FUNC.{tc.Name}", CheckState.Checked, tc);
            }
            this.Cursor = Cursors.Default;
        }

        private void GetDatabaseObjects2(DBRegistrationClass dbR)
        {
            if (dbR == null) return;
            this.Cursor = Cursors.WaitCursor;
            var db = dbR.Clone();
            var ddc = new DatabaseDesignClass
            {
                Tables = StaticTreeClass.Instance().GetAllTableObjectsComplete(db),
                Views  = StaticTreeClass.Instance().GetViewObjects(db)                
            };

            var generators = StaticTreeClass.Instance().GetGeneratorObjects(db);
            var procedures = StaticTreeClass.Instance().GetProcedureObjects(db);
            var functions = StaticTreeClass.Instance().GetFunctionObjects(db);

            slbDbObjects2.ClearItems();
            foreach (var tc in ddc.Tables.Values)
            {                
                slbDbObjects2.Add($@"TABLE.{tc.Name}", CheckState.Checked, tc);
            }

            foreach (var tc in ddc.Views.Values)
            {             
                slbDbObjects2.Add($@"VIEW.{tc.Name}", CheckState.Checked, tc);
            }                        

            foreach (var tc in generators.Values)
            {             
                slbDbObjects2.Add($@"GEN.{tc.Name}", CheckState.Checked, tc);
            } 

            foreach (var tc in procedures.Values)
            {             
                slbDbObjects2.Add($@"PROC.{tc.Name}", CheckState.Checked, tc);
            }
            foreach (var tc in functions.Values)
            {
                slbDbObjects2.Add($@"FUNC.{tc.Name}", CheckState.Checked, tc);
            }
            this.Cursor = Cursors.Default;
        }
      
        private void DatabaseCompareFrom_Load(object sender, EventArgs e)
        {
            LanguageChanged();
            hsSearchDown.Enabled = false;
            hsSearchUp.Enabled = false;
            hsSeach.Enabled = txtSearchCode.TextLength > 0;
            
          //  fbdSourcePath.SelectedPath = AppSettingsClass.Instance().PathSettings.DesignClassesOutputPath;
            ShowCaptions();
            if (DbExplorerForm.Instance().Visible)
            {
                Left = DbExplorerForm.Instance().Width + 16;
            }
            GetAllDatabases();        
        }

        public void ShowCaptions()
        {
            lblCaption.Text = @"Database Designer:" + _dbReg.Alias;
            Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, "Database Designer");
        }
                
        private bool TableFieldsEqual(TableFieldClass tcf1, TableFieldClass tcf2)
        {
            return ((tcf1.Domain.FieldType == tcf2.Domain.FieldType) && (tcf1.Domain.Length == tcf2.Domain.Length) &&
                    (tcf1.Domain.CharSet == tcf2.Domain.CharSet));
        }

        private bool ViewFieldsEqual(ViewFieldClass tcf1, ViewFieldClass tcf2)
        {
            return ((tcf1.Domain.FieldType == tcf2.Domain.FieldType) && (tcf1.Domain.Length == tcf2.Domain.Length) && (tcf1.Domain.CharSet == tcf2.Domain.CharSet));
        }
       
        private void TestTableFields(ItemDataClass itm1, ItemDataClass itm2, string db1, string db2)
        {            
            var tc1 = (TableClass) itm1.Object;
            var tc2 = (TableClass) itm2.Object;
            foreach (TableFieldClass tcf1 in tc1.Fields.Values)
            {
                if (tc2.Fields.TryGetValue(tcf1.Name, out TableFieldClass tcf2))
                {
                    if(!cbOnlyFailures.Checked) fctSource.AppendText($"{"OK",-12}object {itm1.Text} ->field {tcf1.Name} exists{Environment.NewLine}");
                    if ( TableFieldsEqual(tcf1, tcf2))
                    {
                        if(!cbOnlyFailures.Checked) fctSource.AppendText($"{"OK",-12}object {itm1.Text} ->field {tcf1.Name} ->type {tcf1.Domain.FieldType} length {tcf1.Domain.Length} charset {tcf1.Domain.CharSet} equals{Environment.NewLine}");
                    }
                    else
                    {
                        fctSource.AppendText($"{"FAILURE",-12}object {itm1.Text} field {tcf1.Name} ->type {tcf1.Domain.FieldType} length {tcf1.Domain.Length} is not equal field->type {tcf2.Domain.FieldType} length {tcf2.Domain.Length}{Environment.NewLine}");
                    }
                }
                else
                {
                    fctSource.AppendText($"{"FAILURE",-12}object {itm1.Text} ->field {tcf1.Name} ->type {tcf1.Domain.FieldType} length {tcf1.Domain.Length} field not exists{Environment.NewLine}");                        
                }
            }                   
        }

        private void TestViewFields(ItemDataClass itm1, ItemDataClass itm2, string db1, string db2)
        {            
            var tc1 = (ViewClass) itm1.Object;
            var tc2 = (ViewClass) itm2.Object;
            foreach(ViewFieldClass tcf1 in tc1.Fields.Values)
            {                              
                if (tc2.Fields.ContainsKey(tcf1.Name))
                {
                    ViewFieldClass tcf2; 
                    tc2.Fields.TryGetValue(tcf1.Name,out tcf2);
                    if(!cbOnlyFailures.Checked) fctSource.AppendText($"{"OK",-12}view {itm1.Text} ->field {tcf1.Name} exists{Environment.NewLine}");
                    
                    if ( ViewFieldsEqual(tcf1, tcf2))
                    {
                        if(!cbOnlyFailures.Checked) fctSource.AppendText($"{"OK",-12}view {itm1.Text} ->field {tcf1.Name} ->type {tcf1.Domain.FieldType} length {tcf1.Domain.Length} charset {tcf1.Domain.CharSet} equals{Environment.NewLine}");
                    }
                    else
                    {
                        fctSource.AppendText($"{"FAILURE",-12}view {itm1.Text} field {tcf1.Name} ->type {tcf1.Domain.FieldType} length {tcf1.Domain.Length} is not equal field->type {tcf2.Domain.FieldType} length {tcf2.Domain.Length}{Environment.NewLine}");
                    }
                }
                else
                {
                    fctSource.AppendText($"{"FAILURE",-12}view {itm1.Text} ->field {tcf1.Name} ->type {tcf1.Domain.FieldType} length {tcf1.Domain.Length} field not exists{Environment.NewLine}");                        
                }
            }                
        }

        private string RemoveUnneccessaryCharacters(string str1)
        {
            while(str1.Contains(" ,"))
            {
                str1 = str1.Replace(" ,", ",");
            }

            while(str1.Contains(" ;"))
            {
                str1 = str1.Replace(" ;", ";");
            }
            
            str1 = str1.Replace(",",", ");
            

            while(str1.Contains("  "))
            {
                str1 = str1.Replace("  ", " ");
            }
            
            while(str1.Contains("\r\n\r\n"))
            {
                str1 = str1.Replace("\r\n\r\n", "\r\n");
            }

            while(str1.Contains("( "))
            {
                str1 = str1.Replace("( ", "(");
            }
            
            while(str1.EndsWith("\n")||str1.EndsWith("\r")||str1.EndsWith(";")||str1.EndsWith(" ") ) 
            {
                string rm = str1.Substring(str1.Length-1,1);
                str1 = str1.Remove(str1.Length-1,1);                    
            }
            
            return cbChangeToUppercase.Checked ? str1.ToUpper() : str1;
        }

        private void TestTable(ItemDataClass itm1, ItemDataClass itm2, string db1,string db2, bool second)
        {
            string str = (second) ? "<<--<<--<<--<<--<<" : ">>-->>-->>-->>-->>" ;
            if (itm1.Object.GetType() == typeof(TableClass))
            {      
                fctSource.AppendText($"{str} Testing DB {db1} table {itm1.Text} -> {db2}{Environment.NewLine}{Environment.NewLine}");
                if (itm2 != null)
                {           
                    var tc1 = (TableClass) itm1.Object;
                    var tc2 = (TableClass) itm2.Object;
                    
                    if(!cbOnlyFailures.Checked)  fctSource.AppendText($"{"OK",-8} DB {db1}->Table {itm1.Text} exists in DB {itm2.Text}{db2}");
                    TestTableFields(itm1,itm2,db1,db2);                    
                }
                else
                {
                    fctSource.AppendText($"{"FAILURE",-8}DB {db1}->table {itm1.Text} has no table in DB {db2}{Environment.NewLine}");
                }

                fctSource.AppendText(Environment.NewLine);
               
            }
                     
            fctSource.AppendText(Environment.NewLine);
        }

        private void TestView(ItemDataClass itm1, ItemDataClass itm2, string db1, string db2, bool second)
        {
            string str = (second) ? "<<--<<--<<--<<--<<" : ">>-->>-->>-->>-->>";
            if (itm1.Object.GetType() == typeof(ViewClass))
            {
                fctSource.AppendText($"{str} Testing DB {db1} view {itm1.Text} -> {db2}{Environment.NewLine}{Environment.NewLine}");
                if (itm2 != null)
                {
                    var tc1 = (ViewClass)itm1.Object;
                    var tc2 = (ViewClass)itm2.Object;
                    if (!cbOnlyFailures.Checked) fctSource.AppendText($"{"OK",-8}DB {db1}->view {itm1.Text} exists in DB {itm1.Text}{db2}");
                    TestViewFields(itm1, itm2, db1, db2);
                    tc1.CREATEINSERT_SQL = $@"<START>{RemoveUnneccessaryCharacters(tc1.CREATEINSERT_SQL)}<END>";
                    tc2.CREATEINSERT_SQL = $@"<START>{RemoveUnneccessaryCharacters(tc2.CREATEINSERT_SQL)}<END>";
                    if (tc1.CREATEINSERT_SQL != tc2.CREATEINSERT_SQL)
                    {
                        fctSource.AppendText(Environment.NewLine);
                        string str1 = tc1.CREATEINSERT_SQL.Trim().ToUpper();
                        string str2 = tc2.CREATEINSERT_SQL.Trim().ToUpper();
                        string resultstr = string.Empty;
                        if (str1 == str2)
                        {
                            resultstr = "case sensitivity";
                        }

                        str1 = str1.Replace("\r", " ");
                        str2 = str2.Replace("\r", " ");
                        str1 = str1.Replace("\n", " ");
                        str2 = str2.Replace("\n", " ");
                        if (str1 == str2)
                        {
                            resultstr += (resultstr.Length > 0) ? ", differences in newlines" : "differences in newlines";
                        }

                        while (str1.Contains("  "))
                        {
                            str1 = str1.Replace("  ", " ");
                        }
                        while (str2.Contains("  "))
                        {
                            str2 = str2.Replace("  ", " ");
                        }

                        if (str1 == str2)
                        {
                            resultstr += (resultstr.Length > 0) ? ", differences in spaces" : "differences in spaces";
                        }

                        int nw1 = str1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
                        int nw2 = str2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
                        if (nw1 != nw2)
                        {
                            Console.WriteLine();
                        }
                        if (resultstr.Length <= 0)
                        {
                            fctSource.AppendText($"{"FAILURE SQL differs ",-8} for {tc1.Name} words:{nw1}<->{nw2}, length:{tc1.CREATEINSERT_SQL.Length}<->{tc2.CREATEINSERT_SQL.Length}{Environment.NewLine}{Environment.NewLine}");
                        }
                        else if (nw1 != nw2)
                        {
                            fctSource.AppendText($"{"FAILURE SQL differs ",-8} for {tc1.Name} in words:{nw1}<->{nw2}, length:{tc1.CREATEINSERT_SQL.Length}<->{tc2.CREATEINSERT_SQL.Length}{Environment.NewLine}{Environment.NewLine}");
                        }

                        else
                        {
                            fctSource.AppendText($"{"WARNING SQL differs by",-8}  ({resultstr}), may not a problem, for {tc1.Name} words:{nw1}<->{nw2},  length:{tc1.CREATEINSERT_SQL.Trim().ToUpper().Length}<->{tc2.CREATEINSERT_SQL.Trim().ToUpper().Length}{Environment.NewLine}{Environment.NewLine}");
                        }

                        fctSource.AppendText($"{Environment.NewLine}SQL1 -------------------------------------------{Environment.NewLine}{tc1.CREATEINSERT_SQL}{Environment.NewLine}");
                        fctSource.AppendText($"{Environment.NewLine}SQL2 -------------------------------------------{Environment.NewLine}{tc2.CREATEINSERT_SQL}{Environment.NewLine}");
                    }
                }
                else
                {
                    fctSource.AppendText($"{"FAILURE",-8} DB {db1}->view {itm1.Text} has no view in DB {db2}{Environment.NewLine}");
                }
            }
            fctSource.AppendText(Environment.NewLine);
        }

        private void TestGenerators(ItemDataClass itm1, ItemDataClass itm2, string db1,string db2, bool second)
        {
            string str = (second) ? "<<--<<--<<--<<--<<" : ">>-->>-->>-->>-->>" ;
            fctSource.AppendText($"{str} Testing DB {db1} generator {itm1.Text} -> {db2}{Environment.NewLine}{Environment.NewLine}");
            if (itm2 != null)
            {                
                var tcf1 = (GeneratorClass) itm1.Object;
                var tcf2 = (GeneratorClass) itm2.Object;
                                    
                if (tcf1.Name == tcf2.Name)
                {                        
                    if(!cbOnlyFailures.Checked) fctSource.AppendText($"{"OK",-8}generator {tcf1.Name} exists{Environment.NewLine}");                                                
                }
                else
                {                    
                    fctSource.AppendText($"{"FAILURE",-8}generator {tcf1.Name} field not exists{Environment.NewLine}");                        
                }                
            }
            else
            {
                var tcf1 = (GeneratorClass) itm1.Object;
                fctSource.AppendText($"{"FAILURE",-8}DB {db1}->has no generator {tcf1} in DB {db2}{Environment.NewLine}");
            }

            fctSource.AppendText(Environment.NewLine);
        }

        private void TestProcedures(ItemDataClass itm1, ItemDataClass itm2, string db1,string db2, bool second)
        {
            string str = (second) ? "<<--<<--<<--<<--<<" : ">>-->>-->>-->>-->>" ;
            fctSource.AppendText($"{str} Testing DB {db1} procedure {itm1.Text} -> {db2}{Environment.NewLine}{Environment.NewLine}");
            if (itm2 != null)
            {                
                var tcf1 = (ProcedureClass) itm1.Object;
                var tcf2 = (ProcedureClass) itm2.Object;
                                    
                if (tcf1.Name == tcf2.Name)
                {
                    string txt1 = tcf1.GetSourceText();
                    string txt2 = tcf2.GetSourceText();
                    
                    if (txt1 == txt2)
                    {
                        if(!cbOnlyFailures.Checked) fctSource.AppendText($"{"OK",-8}procedure {tcf1.Name} exists and source is equal{Environment.NewLine}");  
                    }
                    else
                    {
                        fctSource.AppendText($"{"FAILURE",-8}procedure {tcf1.Name} exists but source is not equal{Environment.NewLine}");  

                        fctSource.AppendText($"----------------- Source {db1}->{tcf1.Name} Length:{txt1.Length} ---------------------{Environment.NewLine}{Environment.NewLine}");
                        fctSource.AppendText(txt1);
                        fctSource.AppendText($"{Environment.NewLine}{Environment.NewLine}");
                        fctSource.AppendText($"----------------- Source {db2}->{tcf2.Name} Length:{txt2.Length} ---------------------{Environment.NewLine}{Environment.NewLine}");
                        fctSource.AppendText(txt2);
                    }
                }
                else
                {
                    
                    fctSource.AppendText($"{"FAILURE",-8}procedure {tcf1.Name} not exists in {db2}{Environment.NewLine}");                        
                }                
            }
            else
            {
                var tcf1 = (ProcedureClass) itm1.Object;
                fctSource.AppendText($"{"FAILURE",-8}DB {db1}->has no procedure {tcf1} in DB {db2}{Environment.NewLine}");
            }

            fctSource.AppendText(Environment.NewLine);
        }

        private void TestFunctions(ItemDataClass itm1, ItemDataClass itm2, string db1, string db2, bool second)
        {
            string str = (second) ? "<<--<<--<<--<<--<<" : ">>-->>-->>-->>-->>";
            fctSource.AppendText($"{str} Testing DB {db1} function {itm1.Text} -> {db2}{Environment.NewLine}{Environment.NewLine}");
            if (itm2 != null)
            {
                var tcf1 = (FunctionClass)itm1.Object;
                var tcf2 = (FunctionClass)itm2.Object;

                if (tcf1.Name == tcf2.Name)
                {
                    string txt1 = tcf1.GetSourceText();
                    string txt2 = tcf2.GetSourceText();
                    if (txt1 == txt2)
                    {
                        if (!cbOnlyFailures.Checked) fctSource.AppendText($"{"OK",-8}function {tcf1.Name} exists and source is equal{Environment.NewLine}");
                    }
                    else
                    {
                        fctSource.AppendText($"{"FAILURE",-8}function {tcf1.Name} exists but source is not equal{Environment.NewLine}");
                        fctSource.AppendText($"----------------- Source {db1}->{tcf1.Name} Length:{txt1.Length} -----------{Environment.NewLine}{Environment.NewLine}");
                        fctSource.AppendText(txt1);
                        fctSource.AppendText($"{Environment.NewLine}{Environment.NewLine}");
                        fctSource.AppendText($"----------------- Source {db2}->{tcf2.Name} Length:{txt2.Length} -----------{Environment.NewLine}{Environment.NewLine}");
                        fctSource.AppendText(txt2);
                    }
                }
                else
                {

                    fctSource.AppendText($"{"FAILURE",-8}function {tcf1.Name} not exists in {db2}{Environment.NewLine}");
                }
            }
            else
            {
                var tcf1 = (FunctionClass)itm1.Object;
                fctSource.AppendText($"{"FAILURE",-8}DB {db1}->has no function {tcf1} in DB {db2}{Environment.NewLine}");
            }

            fctSource.AppendText(Environment.NewLine);
        }

        public bool GetDatabaseObjects()
        {
            var dbi1 = (ItemDataClass)  slbDatabase1?.LastSelectedObject;            
            var dbR1 = (DBRegistrationClass) dbi1?.Object;
            var dbi2 = (ItemDataClass)  slbDatabase2?.LastSelectedObject;            
            var dbR2 = (DBRegistrationClass) dbi2?.Object;

            if ((dbR2 == null)|| (dbR1 == null)) return false;
            
            GetDatabaseObjects1(dbR1);            
            GetDatabaseObjects2(dbR2);
            return true;
        }

        private void hsCreateClasses_Click(object sender, EventArgs e)
        {
            fctSource.Clear();
            cbFoundLines.Text = string.Empty;
            cbFoundLines.Items.Clear();        
            Application.DoEvents();

            if(!GetDatabaseObjects()) return;
            this.Cursor = Cursors.WaitCursor;
            for (int i = 0; i < slbDbObjects1.CheckedItemDatasNotNulls.Count; i++)
            {               
                var itm1 = slbDbObjects1.CheckedItemDatasNotNulls[i];
                int inx2 = slbDbObjects2.ItemDatas.FindIndex(x => x.Text == itm1.Text);
                
                ItemDataClass itm2 = null;
                if (inx2 >= 0)
                {
                    itm2 = slbDbObjects2.ItemDatas[inx2];
                    string it = itm2.GetType().ToString();
                }
                if (ckTables.Checked)
                {
                    if (cbForwardRun.Checked && (itm1.Object.GetType() == typeof(TableClass)))
                    {
                        TestTable(itm1, itm2, slbDatabase1.LastSelectedText, slbDatabase2.LastSelectedText, false);
                    }
                }
                if (ckViews.Checked)
                {
                    if (cbForwardRun.Checked && (itm1.Object.GetType() == typeof(ViewClass)))
                    {
                        TestView(itm1, itm2, slbDatabase1.LastSelectedText, slbDatabase2.LastSelectedText, false);
                    }
                }
                if (ckGenerators.Checked)
                {
                    if (cbForwardRun.Checked && (itm1.Object.GetType() == typeof(GeneratorClass)))
                    {
                        TestGenerators(itm1, itm2, slbDatabase1.LastSelectedText, slbDatabase2.LastSelectedText, false);
                    }
                }
                if (ckProcedures.Checked)
                {
                    if (cbForwardRun.Checked && (itm1.Object.GetType() == typeof(ProcedureClass)))
                    {
                        TestProcedures(itm1, itm2, slbDatabase1.LastSelectedText, slbDatabase2.LastSelectedText, false);
                    }
                }
                if (ckFuntions.Checked)
                {
                    if (cbForwardRun.Checked && (itm1.Object.GetType() == typeof(FunctionClass)))
                    {
                        TestFunctions(itm1, itm2, slbDatabase1.LastSelectedText, slbDatabase2.LastSelectedText, false);
                    }
                }
            }

            for (int i = 0; i < slbDbObjects2.CheckedItemDatasNotNulls.Count; i++)
            {               
                var itm1 = slbDbObjects2.CheckedItemDatasNotNulls[i];
                int inx2 = slbDbObjects1.ItemDatas.FindIndex(x => x.Text == itm1.Text);
                
                ItemDataClass itm2 = null;
                if (inx2 >= 0)
                {
                    itm2 = slbDbObjects1.ItemDatas[inx2];
                    string it = itm2.GetType().ToString();
                }
                if (ckTables.Checked)
                {
                    if (cbReverseRun.Checked && (itm1.Object.GetType() == typeof(TableClass)))
                    {
                        TestTable(itm1, itm2, slbDatabase2.LastSelectedText, slbDatabase1.LastSelectedText, true);
                    }
                }
                if (ckViews.Checked)
                {
                    if (cbReverseRun.Checked && (itm1.Object.GetType() == typeof(ViewClass)))
                    {
                        TestView(itm1, itm2, slbDatabase2.LastSelectedText, slbDatabase1.LastSelectedText, true);
                    }
                }

                if (ckGenerators.Checked)
                {
                    if (cbReverseRun.Checked && (itm1.Object.GetType() == typeof(GeneratorClass)))
                    {
                        TestGenerators(itm1, itm2, slbDatabase2.LastSelectedText, slbDatabase1.LastSelectedText, true);
                    }
                }
                if (ckProcedures.Checked)
                {
                    if (cbReverse.Checked && (itm1.Object.GetType() == typeof(ProcedureClass)))
                    {
                        TestProcedures(itm1, itm2, slbDatabase2.LastSelectedText, slbDatabase1.LastSelectedText, true);
                    }
                }

                if (ckFuntions.Checked)
                {
                    if (cbReverseRun.Checked && (itm1.Object.GetType() == typeof(FunctionClass)))
                    {
                        TestFunctions(itm1, itm2, slbDatabase1.LastSelectedText, slbDatabase2.LastSelectedText, false);
                    }
                }
            }
            Search();
            this.Cursor = Cursors.Default;
        }

      
        private void cmsSourceCode_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsmiCopyToClipboard)
            {
                if (string.IsNullOrEmpty(fctSource.SelectedText)) return;
                Clipboard.Clear();
                Clipboard.SetText(fctSource.SelectedText);
            }
            else if (e.ClickedItem == tsmiSearchFirst)
            {
                Search();
            }
            else if (e.ClickedItem == tsmiSearchPrevious)
            {
                SearchUp();
            }
            else if (e.ClickedItem == tsmiSearchNext)
            {
                SearchDown();
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
                $"{obj.Name}Class",
                $"{obj.Name}Class.TDataClass",
                $"{obj.Name}Class.TDataClass.TColumns"
            };

            if (obj.GetType() == typeof(TableClass))
            {
                var tc = (TableClass) obj;                            
                foreach (var tcf in tc.Fields.Values)
                {
                    words.Add(tcf.Name);
                    words.Add($"{tc.Name}.{tcf.Name}");
                }
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var tc = (ViewClass) obj;                
                foreach (var tcf in tc.Fields.Values)
                {
                    words.Add(tcf.Name);
                    words.Add($"{tc.Name}.{tcf.Name}");
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
            Search();
        }

        private void Search()
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
            SearchDown();
        }

        private void SearchDown()
        {
            if (_findlst.Count <= 0) return;
            _aktSelectedLine++;
            if (_aktSelectedLine >= _findlst.Count) _aktSelectedLine = 0;
            SelectLine(_aktSelectedLine);
        }

        private void hsSearchUp_Click(object sender, EventArgs e)
        {
            SearchUp();
        }

        private void SearchUp()
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

        private void slbDatabase1_ItemSelect(object sender, SelectItemEventArgs e)
        {            
            /*
            var dbi1 = (ItemDataClass)  slbDatabase1?.LastSelectedObject;            
            var dbR1 = (DBRegistrationClass) dbi1?.Object;

            if (dbR1 == null) return;
            GetDatabaseObjects1(dbR1);
            */
        }

        private void slbDatabase2_ItemSelect(object sender, SelectItemEventArgs e)
        {
            /*
            var dbi1 = (ItemDataClass)  slbDatabase2?.LastSelectedObject;            
            var dbR1 = (DBRegistrationClass) dbi1?.Object;

            if (dbR1 == null) return;
            GetDatabaseObjects2(dbR1);
            */
        }
        
        private void hsSelObjects1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(20);
            Application.DoEvents();
            slbDbObjects1.CheckChecks();
        }

        private void hsUnselObjects1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(20);
            Application.DoEvents();
            slbDbObjects1.ClearChecks();
        }

        private void hsSelObjects2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(20);
            Application.DoEvents();
            slbDbObjects2.CheckChecks();
        }

        private void hsUnselObjects2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(20);
            Application.DoEvents();
            slbDbObjects2.ClearChecks();
        }

        private void hsSaveResults_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fctSource.SaveToFile(saveFileDialog1.FileName, System.Text.Encoding.UTF8);
            }
        }
    }    
}
