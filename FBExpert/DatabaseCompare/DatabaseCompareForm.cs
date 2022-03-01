using BasicClassLibrary;
using FastColoredTextBoxNS;
using FBXpert.Globals;
using FBXpertLib;
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
        private List<int> _findlstForward;
        private List<int> _findlstReverse;
        private int _aktSelectedLineForward;
        private int _aktSelectedLineReverse;
        private AutocompleteMenu _popupMenu;

        public DatabaseCompareFrom(Form parent, DBRegistrationClass reg)
        {
            InitializeComponent();
            MdiParent = parent;
            LanguageClass.Instance.RegisterChangeNotifiy(LanguageChanged);
        }

        private void LanguageChanged(object sender, LanguageChangedEventArgs k)
        {
            LanguageChanged();
        }

        private void LanguageChanged()
        {
            gbFoundLinesForward.Text = LanguageClass.Instance.GetString("FoundLines");
            gbSearchCodeForward.Text = LanguageClass.Instance.GetString("SEARCH");
            tabPageObjects.Text = LanguageClass.Instance.GetString("OBJECTS");
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
            var databases = DatabaseDefinitions.Instance.Databases;
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
                Tables = StaticDatabaseObjects.Instance().GetAllNonSystemTableObjectsComplete(db),
                Views = StaticDatabaseObjects.Instance().GetViewObjects(db)
            };
            var generators = StaticDatabaseObjects.Instance().GetGeneratorObjects(db);
            var procedures = StaticDatabaseObjects.Instance().GetProcedureObjects(db);
            var functions = StaticDatabaseObjects.Instance().GetFunctionObjects(db);

            slbDbObjects1.ClearItems();
            if (ddc.Tables != null)
            {
                foreach (var tc in ddc.Tables.Values)
                {
                    slbDbObjects1.Add($@"TABLE.{tc.Name}", CheckState.Checked, tc);
                }
            }
            if (ddc.Views != null)
            {
                foreach (var tc in ddc.Views.Values)
                {
                    slbDbObjects1.Add($@"VIEW.{tc.Name}", CheckState.Checked, tc);
                }
            }
            if (generators != null)
            {
                foreach (var tc in generators.Values)
                {
                    slbDbObjects1.Add($@"GEN.{tc.Name}", CheckState.Checked, tc);
                }
            }
            if (procedures != null)
            {
                foreach (var tc in procedures.Values)
                {
                    slbDbObjects1.Add($@"PROC.{tc.Name}", CheckState.Checked, tc);
                }
            }
            if (functions != null)
            {
                foreach (var tc in functions.Values)
                {
                    slbDbObjects1.Add($@"FUNC.{tc.Name}", CheckState.Checked, tc);
                }
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
                Tables = StaticDatabaseObjects.Instance().GetAllNonSystemTableObjectsComplete(db),
                Views = StaticDatabaseObjects.Instance().GetViewObjects(db)
            };

            var generators = StaticDatabaseObjects.Instance().GetGeneratorObjects(db);
            var procedures = StaticDatabaseObjects.Instance().GetProcedureObjects(db);
            var functions = StaticDatabaseObjects.Instance().GetFunctionObjects(db);

            slbDbObjects2.ClearItems();
            if (ddc.Tables != null)
            {
                foreach (var tc in ddc.Tables.Values)
                {
                    slbDbObjects2.Add($@"TABLE.{tc.Name}", CheckState.Checked, tc);
                }
            }
            if (ddc.Views != null)
            {
                foreach (var tc in ddc.Views.Values)
                {
                    slbDbObjects2.Add($@"VIEW.{tc.Name}", CheckState.Checked, tc);
                }
            }
            if (generators != null)
            {
                foreach (var tc in generators.Values)
                {
                    slbDbObjects2.Add($@"GEN.{tc.Name}", CheckState.Checked, tc);
                }
            }
            if (procedures != null)
            {
                foreach (var tc in procedures.Values)
                {
                    slbDbObjects2.Add($@"PROC.{tc.Name}", CheckState.Checked, tc);
                }
            }
            if (functions != null)
            {
                foreach (var tc in functions.Values)
                {
                    slbDbObjects2.Add($@"FUNC.{tc.Name}", CheckState.Checked, tc);
                }
            }
            this.Cursor = Cursors.Default;
        }

        public void SetControlSizes()
        {
            pnlFormUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlMessagesUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlXMLUpper.Height = AppSizeConstants.UpperFormBandHeight;
        }
        private void DatabaseCompareFrom_Load(object sender, EventArgs e)
        {
            SetControlSizes();
            FormDesign.SetFormLeft(this);
            LanguageChanged();
            hsSearchDownForward.Enabled = false;
            hsSearchUpForward.Enabled = false;
            hsSeachForward.Enabled = txtSearchCodeForward.TextLength > 0;
            ShowCaptions();
            if (DbExplorerForm.Instance().Visible)
            {
                Left = DbExplorerForm.Instance().Width + 16;
            }
            GetAllDatabases();
            RepaintDatabases();
        }

        public void ShowCaptions()
        {
            lblCaption.Text = $@"Database compare";
            Text = "Database compare";
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

        private void TestTableFields(ItemDataClass itm1, ItemDataClass itm2, string db1, string db2, FastColoredTextBox fct)
        {
            var tc1 = (TableClass)itm1.Object;
            var tc2 = (TableClass)itm2.Object;
            foreach (TableFieldClass tcf1 in tc1.Fields.Values)
            {
                if (tc2.Fields.TryGetValue(tcf1.Name, out TableFieldClass tcf2))
                {
                    if (!cbOnlyFailures.Checked) fct.AppendText($"{"OK",-12}object {itm1.Text} ->field {tcf1.Name} exists{Environment.NewLine}");
                    if (TableFieldsEqual(tcf1, tcf2))
                    {
                        if (!cbOnlyFailures.Checked) fct.AppendText($"{"OK",-12}object {itm1.Text} ->field {tcf1.Name} ->type {tcf1.Domain.FieldType} length {tcf1.Domain.Length} charset {tcf1.Domain.CharSet} equals{Environment.NewLine}");
                    }
                    else
                    {
                        fct.AppendText($"{"FAILURE",-12}object {itm1.Text} field {tcf1.Name} ->type {tcf1.Domain.FieldType} length {tcf1.Domain.Length} is not equal field->type {tcf2.Domain.FieldType} length {tcf2.Domain.Length}{Environment.NewLine}");
                    }
                }
                else
                {
                    fct.AppendText($"{"FAILURE",-12}object {itm1.Text} ->field {tcf1.Name} ->type {tcf1.Domain.FieldType} length {tcf1.Domain.Length} field not exists{Environment.NewLine}");
                }
            }
        }

        private void TestTableDepent(ItemDataClass itm1, ItemDataClass itm2, string db1, string db2, FastColoredTextBox fct)
        {
            var tc1 = (TableClass)itm1.Object;
            var tc2 = (TableClass)itm2.Object;
            if ((tc1.DependenciesTO_Views != null) && (tc2.DependenciesTO_Views != null))
            {
                if (tc1.DependenciesTO_Views.Values.Count != tc2.DependenciesTO_Views.Values.Count)
                {
                    fct.AppendText($"{"FAILURE",-12}object {itm1.Text} dependencies length {tc1.DependenciesTO_Views.Values.Count} is not equal {itm2.Text} {tc2.DependenciesTO_Views.Values.Count}{Environment.NewLine}");
                }
            }
            else if (tc1.DependenciesTO_Views != null)
            {
                fct.AppendText($"{"FAILURE",-12}object {itm1.Text} dependencies length {tc1.DependenciesTO_Views.Values.Count} is not equal {itm2.Text} 0{Environment.NewLine}");
            }
            else if (tc2.DependenciesTO_Views != null)
            {
                fct.AppendText($"{"FAILURE",-12}object {itm1.Text} dependencies length 0 is not equal {itm2.Text} {tc2.DependenciesTO_Views.Values.Count}{Environment.NewLine}");
            }
        }

        private void TestTableFK(ItemDataClass itm1, ItemDataClass itm2, string db1, string db2, FastColoredTextBox fct)
        {
            var tc1 = (TableClass)itm1.Object;
            var tc2 = (TableClass)itm2.Object;
            if ((tc1.ForeignKeys != null) && (tc2.ForeignKeys != null))
            {
                if (tc1.ForeignKeys.Count != tc2.ForeignKeys.Count)
                {
                    fct.AppendText($"{"FAILURE",-12}object {itm1.Text} foreign keys length {tc1.ForeignKeys.Count} is not equal {itm2.Text} {tc2.ForeignKeys.Count}{Environment.NewLine}");
                }
            }
            else if (tc1.ForeignKeys != null)
            {
                fct.AppendText($"{"FAILURE",-12}object {itm1.Text} foreign keys length {tc1.ForeignKeys.Count} is not equal {itm2.Text} 0{Environment.NewLine}");
            }
            else if (tc2.ForeignKeys != null)
            {
                fct.AppendText($"{"FAILURE",-12}object {itm1.Text} foreign keys length 0 is not equal {itm2.Text} {tc2.ForeignKeys.Count}{Environment.NewLine}");
            }
        }
        private void TestTablePK(ItemDataClass itm1, ItemDataClass itm2, string db1, string db2, FastColoredTextBox fct)
        {
            var tc1 = (TableClass)itm1.Object;
            var tc2 = (TableClass)itm2.Object;
            if ((tc1.primary_constraint != null) && (tc2.primary_constraint != null))
            {

            }
            else if (tc1.primary_constraint != null)
            {
                fct.AppendText($"{"FAILURE",-12}object {itm1.Text} primary keys length 1 is not equal {itm2.Text} 0{Environment.NewLine}");
            }
            else if (tc2.primary_constraint != null)
            {
                fct.AppendText($"{"FAILURE",-12}object {itm1.Text} primary keys length 0 is not equal {itm2.Text} 1{Environment.NewLine}");
            }

            string pk1 = string.Empty;
            string pk2 = string.Empty;
            if (tc1.Indices != null)
            {
                foreach (IndexClass fld in tc1.Indices.Values)
                {
                    if (fld.HasPrimaryConstraint)
                    {
                        foreach (FieldClass fc in fld.RelationFields.Values)
                        {
                            pk1 = (string.IsNullOrEmpty(pk1)) ? pk1 + fc.Name : "|" + pk1 + fc.Name;
                        }
                    }
                }
            }
            if (tc2.Indices != null)
            {
                foreach (IndexClass fld in tc2.Indices.Values)
                {
                    if (fld.HasPrimaryConstraint)
                    {
                        foreach (FieldClass fc in fld.RelationFields.Values)
                        {
                            pk2 = (string.IsNullOrEmpty(pk2)) ? pk2 + fc.Name : "|" + pk2 + fc.Name;
                        }
                    }
                }
            }
            /*
            foreach (TableFieldClass fld in tc2.Fields.Values)
            {
                if (fld.IsPrimary) pk2 = fld.Name;
            }
            */
            if (pk1 == pk2)
            {
                if (string.IsNullOrEmpty(pk1))
                {
                    fct.AppendText($"{"WARNING",-12}both objects {itm1.Text} and {itm2.Text} has no primary key.{Environment.NewLine}");
                }
            }
            else if (string.IsNullOrEmpty(pk1))
            {
                fct.AppendText($"{"FAILURE",-12}object {itm1.Text} has no primary key, and {itm2.Text} primary key is {pk2}{Environment.NewLine}");
            }
            else if (string.IsNullOrEmpty(pk2))
            {
                fct.AppendText($"{"FAILURE",-12}object {itm1.Text} primary key is {pk2}, and {itm2.Text} has no primary key.{Environment.NewLine}");
            }
            else
            {
                fct.AppendText($"{"FAILURE",-12}object {itm1.Text} primary key {pk1}  and {itm2.Text} primary key {pk2} are not equal.{Environment.NewLine}");
            }
        }

        private void TestViewFields(ItemDataClass itm1, ItemDataClass itm2, string db1, string db2, FastColoredTextBox fct)
        {
            var tc1 = (ViewClass)itm1.Object;
            var tc2 = (ViewClass)itm2.Object;
            foreach (ViewFieldClass tcf1 in tc1.Fields.Values)
            {
                if (tc2.Fields.ContainsKey(tcf1.Name))
                {
                    ViewFieldClass tcf2;
                    tc2.Fields.TryGetValue(tcf1.Name, out tcf2);
                    if (!cbOnlyFailures.Checked) fct.AppendText($"{"OK",-12}view {itm1.Text} ->field {tcf1.Name} exists{Environment.NewLine}");

                    if (ViewFieldsEqual(tcf1, tcf2))
                    {
                        if (!cbOnlyFailures.Checked) fct.AppendText($"{"OK",-12}view {itm1.Text} ->field {tcf1.Name} ->type {tcf1.Domain.FieldType} length {tcf1.Domain.Length} charset {tcf1.Domain.CharSet} equals{Environment.NewLine}");
                    }
                    else
                    {
                        fct.AppendText($"{"FAILURE",-12}view {itm1.Text} field {tcf1.Name} ->type {tcf1.Domain.FieldType} length {tcf1.Domain.Length} is not equal field->type {tcf2.Domain.FieldType} length {tcf2.Domain.Length}{Environment.NewLine}");
                    }
                }
                else
                {
                    fct.AppendText($"{"FAILURE",-12}view {itm1.Text} ->field {tcf1.Name} ->type {tcf1.Domain.FieldType} length {tcf1.Domain.Length} field not exists{Environment.NewLine}");
                }
            }
        }
        private string RemoveUnneccessaryCharacters(string str1)
        {
            str1 = StringsFunctionsClass.Reduce(str1, " ,", ",");
            str1 = StringsFunctionsClass.Reduce(str1, " ;", ";");
            str1 = str1.Replace(",", ", ");
            str1 = StringsFunctionsClass.Reduce(str1, "  ", " ");
            str1 = StringsFunctionsClass.Reduce(str1, "\r\n\r\n", "\r\n");
            str1 = StringsFunctionsClass.Reduce(str1, "( ", "(");

            while (str1.EndsWith("\n") || str1.EndsWith("\r") || str1.EndsWith(";") || str1.EndsWith(" "))
            {
                string rm = str1.Substring(str1.Length - 1, 1);
                str1 = str1.Remove(str1.Length - 1, 1);
            }
            return cbChangeToUppercase.Checked ? str1.ToUpper() : str1;
        }

        private void TestTable(ItemDataClass itm1, ItemDataClass itm2, string db1, string db2, bool second, FastColoredTextBox fct)
        {
            string str = (second) ? "<<--<<--<<--<<--<<" : ">>-->>-->>-->>-->>";
            if (itm1.Object.GetType() == typeof(TableClass))
            {
                fct.AppendText($"{str} Testing DB {db1} table {itm1.Text} -> {db2}{Environment.NewLine}{Environment.NewLine}");
                if (itm2 != null)
                {
                    if (!cbOnlyFailures.Checked) fct.AppendText($"{"OK",-8} DB {db1}->Table {itm1.Text} exists in DB {itm2.Text}{db2}");
                    TestTableFields(itm1, itm2, db1, db2, fct);
                    if (ckDepent.Checked) TestTableDepent(itm1, itm2, db1, db2, fct);
                    if (ckFK.Checked) TestTableFK(itm1, itm2, db1, db2, fct);
                    if (ckPK.Checked) TestTablePK(itm1, itm2, db1, db2, fct);
                }
                else
                {
                    fct.AppendText($"{"FAILURE",-8}DB {db1}->table {itm1.Text} has no table in DB {db2}{Environment.NewLine}");
                }
                fct.AppendText(Environment.NewLine);
            }
            fct.AppendText(Environment.NewLine);
        }

        private void TestView(ItemDataClass itm1, ItemDataClass itm2, string db1, string db2, bool second, FastColoredTextBox fct)
        {
            string str = (second) ? "<<--<<--<<--<<--<<" : ">>-->>-->>-->>-->>";
            if (itm1.Object.GetType() == typeof(ViewClass))
            {
                fct.AppendText($"{str} Testing DB {db1} view {itm1.Text} -> {db2}{Environment.NewLine}{Environment.NewLine}");
                if (itm2 != null)
                {
                    var tc1 = (ViewClass)itm1.Object;
                    var tc2 = (ViewClass)itm2.Object;
                    if (!cbOnlyFailures.Checked) fct.AppendText($"{"OK",-8}DB {db1}->view {itm1.Text} exists in DB {itm1.Text}{db2}");
                    TestViewFields(itm1, itm2, db1, db2, fct);

                    int inx1 = tc1.CREATEINSERT_SQL.IndexOf("CREATE ");
                    int inx2 = tc2.CREATEINSERT_SQL.IndexOf("CREATE ");

                    //Entfernen Kommentare
                    if (inx1 > 0) tc1.CREATEINSERT_SQL = tc1.CREATEINSERT_SQL.Substring(inx1);
                    if (inx2 > 0) tc2.CREATEINSERT_SQL = tc2.CREATEINSERT_SQL.Substring(inx1);


                    tc1.CREATEINSERT_SQL = $@"<START>{RemoveUnneccessaryCharacters(tc1.CREATEINSERT_SQL)}<END>";
                    tc2.CREATEINSERT_SQL = $@"<START>{RemoveUnneccessaryCharacters(tc2.CREATEINSERT_SQL)}<END>";
                    if (tc1.CREATEINSERT_SQL != tc2.CREATEINSERT_SQL)
                    {
                        fct.AppendText(Environment.NewLine);
                        string str1 = tc1.CREATEINSERT_SQL.Trim().ToUpper();
                        string str2 = tc2.CREATEINSERT_SQL.Trim().ToUpper();
                        string resultstr = string.Empty;
                        if (str1 == str2)
                        {
                            resultstr = "case sensitivity";
                        }
                        else
                        {
                            str1 = str1.Replace("\r", " ");
                            str2 = str2.Replace("\r", " ");
                            str1 = str1.Replace("\n", " ");
                            str2 = str2.Replace("\n", " ");
                            if (str1 == str2)
                            {
                                resultstr += (resultstr.Length > 0) ? ", differences in newlines" : "differences in newlines";
                            }
                            else
                            {
                                str1 = StringsFunctionsClass.Reduce(str1, "  ", " ");
                                str2 = StringsFunctionsClass.Reduce(str2, "  ", " ");

                                if (str1 == str2)
                                {
                                    resultstr += (resultstr.Length > 0) ? ", differences in spaces" : "differences in spaces";
                                }
                            }
                        }
                        int nw1 = str1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
                        int nw2 = str2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

                        if (resultstr.Length <= 0)
                        {
                            fct.AppendText($"{"FAILURE SQL differs ",-8} for {tc1.Name} words:{nw1}<->{nw2}, length:{tc1.CREATEINSERT_SQL.Length}<->{tc2.CREATEINSERT_SQL.Length}{Environment.NewLine}{Environment.NewLine}");
                        }
                        else if (nw1 != nw2)
                        {
                            fct.AppendText($"{"FAILURE SQL differs ",-8} for {tc1.Name} in words:{nw1}<->{nw2}, length:{tc1.CREATEINSERT_SQL.Length}<->{tc2.CREATEINSERT_SQL.Length}{Environment.NewLine}{Environment.NewLine}");
                        }
                        else
                        {
                            fct.AppendText($"{"WARNING SQL differs by",-8}  ({resultstr}), may not a problem, for {tc1.Name} words:{nw1}<->{nw2},  length:{tc1.CREATEINSERT_SQL.Trim().ToUpper().Length}<->{tc2.CREATEINSERT_SQL.Trim().ToUpper().Length}{Environment.NewLine}{Environment.NewLine}");
                        }

                        fct.AppendText($"{Environment.NewLine}SQL1 -------------------------------------------{Environment.NewLine}{tc1.CREATEINSERT_SQL}{Environment.NewLine}");
                        fct.AppendText($"{Environment.NewLine}SQL2 -------------------------------------------{Environment.NewLine}{tc2.CREATEINSERT_SQL}{Environment.NewLine}");
                    }
                }
                else
                {
                    fct.AppendText($"{"FAILURE",-8} DB {db1}->view {itm1.Text} has no view in DB {db2}{Environment.NewLine}");
                }
            }
            fct.AppendText(Environment.NewLine);
        }

        private void TestGenerators(ItemDataClass itm1, ItemDataClass itm2, string db1, string db2, bool second, FastColoredTextBox fct)
        {
            string str = (second) ? "<<--<<--<<--<<--<<" : ">>-->>-->>-->>-->>";
            fct.AppendText($"{str} Testing DB {db1} generator {itm1.Text} -> {db2}{Environment.NewLine}{Environment.NewLine}");
            if (itm2 != null)
            {
                var tcf1 = (GeneratorClass)itm1.Object;
                var tcf2 = (GeneratorClass)itm2.Object;

                if (tcf1.Name == tcf2.Name)
                {
                    if (!cbOnlyFailures.Checked) fct.AppendText($"{"OK",-8}generator {tcf1.Name} exists{Environment.NewLine}");
                }
                else
                {
                    fct.AppendText($"{"FAILURE",-8}generator {tcf1.Name} field not exists{Environment.NewLine}");
                }
            }
            else
            {
                var tcf1 = (GeneratorClass)itm1.Object;
                fct.AppendText($"{"FAILURE",-8}DB {db1}->has no generator {tcf1} in DB {db2}{Environment.NewLine}");
            }

            fct.AppendText(Environment.NewLine);
        }

        private void TestProcedures(ItemDataClass itm1, ItemDataClass itm2, string db1, string db2, bool second, FastColoredTextBox fct)
        {
            string str = (second) ? "<<--<<--<<--<<--<<" : ">>-->>-->>-->>-->>";
            fct.AppendText($"{str} Testing DB {db1} procedure {itm1.Text} -> {db2}{Environment.NewLine}{Environment.NewLine}");
            if (itm2 != null)
            {
                var tcf1 = (ProcedureClass)itm1.Object;
                var tcf2 = (ProcedureClass)itm2.Object;

                if (tcf1.Name == tcf2.Name)
                {
                    string txt1 = tcf1.GetSourceText();
                    string txt2 = tcf2.GetSourceText();

                    if (txt1 == txt2)
                    {
                        if (!cbOnlyFailures.Checked) fct.AppendText($"{"OK",-8}procedure {tcf1.Name} exists and source is equal{Environment.NewLine}");
                    }
                    else
                    {
                        fct.AppendText($"{"FAILURE",-8}procedure {tcf1.Name} exists but source is not equal{Environment.NewLine}");

                        fct.AppendText($"----------------- Source {db1}->{tcf1.Name} Length:{txt1.Length} ---------------------{Environment.NewLine}{Environment.NewLine}");
                        fct.AppendText(txt1);
                        fct.AppendText($"{Environment.NewLine}{Environment.NewLine}");
                        fct.AppendText($"----------------- Source {db2}->{tcf2.Name} Length:{txt2.Length} ---------------------{Environment.NewLine}{Environment.NewLine}");
                        fct.AppendText(txt2);
                    }
                }
                else
                {

                    fct.AppendText($"{"FAILURE",-8}procedure {tcf1.Name} not exists in {db2}{Environment.NewLine}");
                }
            }
            else
            {
                var tcf1 = (ProcedureClass)itm1.Object;
                fct.AppendText($"{"FAILURE",-8}DB {db1}->has no procedure {tcf1} in DB {db2}{Environment.NewLine}");
            }

            fct.AppendText(Environment.NewLine);
        }

        private void TestFunctions(ItemDataClass itm1, ItemDataClass itm2, string db1, string db2, bool second, FastColoredTextBox fct)
        {
            string str = (second) ? "<<--<<--<<--<<--<<" : ">>-->>-->>-->>-->>";
            fct.AppendText($"{str} Testing DB {db1} function {itm1.Text} -> {db2}{Environment.NewLine}{Environment.NewLine}");
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
                        if (!cbOnlyFailures.Checked) fct.AppendText($"{"OK",-8}function {tcf1.Name} exists and source is equal{Environment.NewLine}");
                    }
                    else
                    {
                        fct.AppendText($"{"FAILURE",-8}function {tcf1.Name} exists but source is not equal{Environment.NewLine}");
                        fct.AppendText($"----------------- Source {db1}->{tcf1.Name} Length:{txt1.Length} -----------{Environment.NewLine}{Environment.NewLine}");
                        fct.AppendText(txt1);
                        fct.AppendText($"{Environment.NewLine}{Environment.NewLine}");
                        fct.AppendText($"----------------- Source {db2}->{tcf2.Name} Length:{txt2.Length} -----------{Environment.NewLine}{Environment.NewLine}");
                        fct.AppendText(txt2);
                    }
                }
                else
                {

                    fct.AppendText($"{"FAILURE",-8}function {tcf1.Name} not exists in {db2}{Environment.NewLine}");
                }
            }
            else
            {
                var tcf1 = (FunctionClass)itm1.Object;
                fct.AppendText($"{"FAILURE",-8}DB {db1}->has no function {tcf1} in DB {db2}{Environment.NewLine}");
            }
            fct.AppendText(Environment.NewLine);
        }

        public bool GetDatabaseObjects()
        {
            var dbi1 = (ItemDataClass)slbDatabase1?.LastSelectedObject;
            var dbR1 = (DBRegistrationClass)dbi1?.Object;
            var dbi2 = (ItemDataClass)slbDatabase2?.LastSelectedObject;
            var dbR2 = (DBRegistrationClass)dbi2?.Object;

            if ((dbR2 == null) || (dbR1 == null)) return false;

            GetDatabaseObjects1(dbR1);
            GetDatabaseObjects2(dbR2);
            return true;
        }

        private void hsCreateClasses_Click(object sender, EventArgs e)
        {
            fctSourceForward.Clear();
            fctSourceReverse.Clear();
            cbFoundLinesForward.Text = string.Empty;
            cbFoundLinesForward.Items.Clear();
            cbFoundLinesReverse.Text = string.Empty;
            cbFoundLinesReverse.Items.Clear();

            Application.DoEvents();

            if (!GetDatabaseObjects()) return;
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
                        TestTable(itm1, itm2, slbDatabase1.LastSelectedText, slbDatabase2.LastSelectedText, false, fctSourceForward);
                    }
                }
                if (ckViews.Checked)
                {
                    if (cbForwardRun.Checked && (itm1.Object.GetType() == typeof(ViewClass)))
                    {
                        TestView(itm1, itm2, slbDatabase1.LastSelectedText, slbDatabase2.LastSelectedText, false, fctSourceForward);
                    }
                }
                if (ckGenerators.Checked)
                {
                    if (cbForwardRun.Checked && (itm1.Object.GetType() == typeof(GeneratorClass)))
                    {
                        TestGenerators(itm1, itm2, slbDatabase1.LastSelectedText, slbDatabase2.LastSelectedText, false, fctSourceForward);
                    }
                }
                if (ckProcedures.Checked)
                {
                    if (cbForwardRun.Checked && (itm1.Object.GetType() == typeof(ProcedureClass)))
                    {
                        TestProcedures(itm1, itm2, slbDatabase1.LastSelectedText, slbDatabase2.LastSelectedText, false, fctSourceForward);
                    }
                }
                if (ckFuntions.Checked)
                {
                    if (cbForwardRun.Checked && (itm1.Object.GetType() == typeof(FunctionClass)))
                    {
                        TestFunctions(itm1, itm2, slbDatabase1.LastSelectedText, slbDatabase2.LastSelectedText, false, fctSourceForward);
                    }
                }
            }

            //Reverserun

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
                    if (ckReverseRun.Checked && (itm1.Object.GetType() == typeof(TableClass)))
                    {
                        TestTable(itm1, itm2, slbDatabase2.LastSelectedText, slbDatabase1.LastSelectedText, true, fctSourceReverse);
                    }
                }
                if (ckViews.Checked)
                {
                    if (ckReverseRun.Checked && (itm1.Object.GetType() == typeof(ViewClass)))
                    {
                        TestView(itm1, itm2, slbDatabase2.LastSelectedText, slbDatabase1.LastSelectedText, true, fctSourceReverse);
                    }
                }

                if (ckGenerators.Checked)
                {
                    if (ckReverseRun.Checked && (itm1.Object.GetType() == typeof(GeneratorClass)))
                    {
                        TestGenerators(itm1, itm2, slbDatabase2.LastSelectedText, slbDatabase1.LastSelectedText, true, fctSourceReverse);
                    }
                }
                if (ckProcedures.Checked)
                {
                    if (ckReverseRun.Checked && (itm1.Object.GetType() == typeof(ProcedureClass)))
                    {
                        TestProcedures(itm1, itm2, slbDatabase2.LastSelectedText, slbDatabase1.LastSelectedText, true, fctSourceReverse);
                    }
                }

                if (ckFuntions.Checked)
                {
                    if (ckReverseRun.Checked && (itm1.Object.GetType() == typeof(FunctionClass)))
                    {
                        TestFunctions(itm1, itm2, slbDatabase1.LastSelectedText, slbDatabase2.LastSelectedText, false, fctSourceReverse);
                    }
                }
            }
            SearchForwardResults();
            SearchReverseResults();
            this.Cursor = Cursors.Default;
        }


        private void cmsSourceCode_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsmiCopyToClipboard)
            {
                if (string.IsNullOrEmpty(fctSourceForward.SelectedText)) return;
                Clipboard.Clear();
                Clipboard.SetText(fctSourceForward.SelectedText);
            }
            else if (e.ClickedItem == tsmiSearchFirst)
            {
                SearchForwardResults();
            }
            else if (e.ClickedItem == tsmiSearchPrevious)
            {
                SearchUpForward();
            }
            else if (e.ClickedItem == tsmiSearchNext)
            {
                SearchDownForward();
            }
        }

        private void SelectLineForward(int i)
        {
            var pl = new Place(0, _findlstForward[i]);
            var ple = new Place(0, _findlstForward[i] + 1);
            fctSourceForward.Navigate(pl.iLine);
            fctSourceForward.Selection.Start = pl;
            fctSourceForward.Selection.End = ple;
            fctSourceForward.Invalidate();
        }
        private void SelectLineReverse(int i)
        {
            var pl = new Place(0, _findlstReverse[i]);
            var ple = new Place(0, _findlstReverse[i] + 1);
            fctSourceReverse.Navigate(pl.iLine);
            fctSourceReverse.Selection.Start = pl;
            fctSourceReverse.Selection.End = ple;
            fctSourceReverse.Invalidate();
        }

        public void RefreshAutocomplete(DataObjectClass obj)
        {
            //create autocomplete popup menu
            if (obj == null) return;
            _popupMenu = new AutocompleteMenu(fctSourceForward)
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
                var tc = (TableClass)obj;
                foreach (var tcf in tc.Fields.Values)
                {
                    words.Add(tcf.Name);
                    words.Add($"{tc.Name}.{tcf.Name}");
                }
            }
            else if (obj.GetType() == typeof(ViewClass))
            {
                var tc = (ViewClass)obj;
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
            _popupMenu = new AutocompleteMenu(fctSourceForward)
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
            SearchForwardResults();
        }

        private void SearchForwardResults()
        {
            AutocompleteSample();
            var srch = @"^.*\b(" + txtSearchCodeForward.Text + @")\b.*$";
            _findlstForward = fctSourceForward.FindLines(srch, RegexOptions.Multiline);
            _aktSelectedLineForward = 0;
            cbFoundLinesForward.Items.Clear();
            if (_findlstForward.Count <= 0) return;

            var n = 0;
            foreach (var ln in _findlstForward)
            {
                var so = new CbSearchObject
                {
                    LineIndex = n++,
                    Line = ln + 1,
                    Text = fctSourceForward.Lines[ln].Trim()
                };
                cbFoundLinesForward.Items.Add(so);
            }

            cbFoundLinesForward.SelectedIndex = cbFoundLinesForward.Items.Count > 0 ? 0 : -1;
            hsSearchDownForward.Enabled = true;
            hsSearchUpForward.Enabled = true;
            _aktSelectedLineForward = 0;
            SelectLineForward(_aktSelectedLineForward);
        }

        private void SearchReverseResults()
        {
            AutocompleteSample();
            var srch = @"^.*\b(" + txtSearchCodeReverse.Text + @")\b.*$";
            _findlstReverse = fctSourceReverse.FindLines(srch, RegexOptions.Multiline);
            _aktSelectedLineReverse = 0;
            cbFoundLinesReverse.Items.Clear();
            if (_findlstReverse.Count <= 0) return;

            var n = 0;
            foreach (var ln in _findlstReverse)
            {
                var so = new CbSearchObject
                {
                    LineIndex = n++,
                    Line = ln + 1,
                    Text = fctSourceReverse.Lines[ln].Trim()
                };
                cbFoundLinesReverse.Items.Add(so);
            }

            cbFoundLinesReverse.SelectedIndex = cbFoundLinesReverse.Items.Count > 0 ? 0 : -1;
            hsSearchDownReverse.Enabled = true;
            hsSearchUpReverse.Enabled = true;
            _aktSelectedLineReverse = 0;
            SelectLineReverse(_aktSelectedLineReverse);
        }

        private void hsSearchDownForward_Click(object sender, EventArgs e)
        {
            SearchDownForward();
        }

        private void SearchDownForward()
        {
            if (_findlstForward.Count <= 0) return;
            _aktSelectedLineForward++;
            if (_aktSelectedLineForward >= _findlstForward.Count) _aktSelectedLineForward = 0;
            SelectLineForward(_aktSelectedLineForward);
        }

        private void SearchUpForward()
        {
            if (_findlstForward.Count <= 0) return;
            _aktSelectedLineForward--;
            if (_aktSelectedLineForward < 0) _aktSelectedLineForward = _findlstForward.Count - 1;
            SelectLineForward(_aktSelectedLineForward);
        }

        private void SearchDownReverse()
        {
            if (_findlstReverse.Count <= 0) return;
            _aktSelectedLineReverse++;
            if (_aktSelectedLineReverse >= _findlstReverse.Count) _aktSelectedLineReverse = 0;
            SelectLineReverse(_aktSelectedLineReverse);
        }

        private void SearchUpReverse()
        {
            if (_findlstReverse.Count <= 0) return;
            _aktSelectedLineReverse--;
            if (_aktSelectedLineReverse < 0) _aktSelectedLineReverse = _findlstReverse.Count - 1;
            SelectLineReverse(_aktSelectedLineReverse);
        }

        private void hsSearchUpForward_Click(object sender, EventArgs e)
        {
            SearchUpForward();
        }

        private void txtSearchCodeForward_TextChanged(object sender, EventArgs e)
        {
            hsSeachForward.Enabled = txtSearchCodeForward.TextLength > 0;
            hsSearchDownForward.Enabled = false;
            hsSearchUpForward.Enabled = false;
        }

        private void cbFoundLinesForeward_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFoundLinesForward.SelectedIndex < 0) return;
            var ob = (CbSearchObject)cbFoundLinesForward.Items[cbFoundLinesForward.SelectedIndex];
            SelectLineForward(ob.LineIndex);
            _aktSelectedLineForward = ob.LineIndex;
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
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fctSourceForward.SaveToFile(saveFileDialog1.FileName, System.Text.Encoding.UTF8);
            }
        }

        private void hsSeachReverse_Click(object sender, EventArgs e)
        {
            SearchReverseResults();
        }

        private void hsSearchDownReverse_Click(object sender, EventArgs e)
        {
            SearchDownReverse();
        }

        private void hsSearchUpReverse_Click(object sender, EventArgs e)
        {
            SearchUpReverse();
        }

        private void cbFoundLinesReverse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFoundLinesReverse.SelectedIndex < 0) return;
            var ob = (CbSearchObject)cbFoundLinesReverse.Items[cbFoundLinesReverse.SelectedIndex];
            SelectLineReverse(ob.LineIndex);
            _aktSelectedLineReverse = ob.LineIndex;
        }

        private void txtSearchCodeReverse_TextChanged(object sender, EventArgs e)
        {
            hsSeachReverse.Enabled = txtSearchCodeReverse.TextLength > 0;
            hsSearchDownReverse.Enabled = false;
            hsSearchUpReverse.Enabled = false;
        }

        private void RepaintDatabases()
        {
            gbDatabase2.Width = gbDatabase1.Width = pnlDatabases.Width / 2 - 2;
            slbDatabase2.TextWith = slbDatabase1.TextWith = slbDatabase1.Width - 8;
        }
        private void scCenter_SplitterMoved(object sender, SplitterEventArgs e)
        {
            RepaintDatabases();
        }

        private void DatabaseCompareFrom_Resize(object sender, EventArgs e)
        {
            RepaintDatabases();
        }

        
        private void hsRefreshObjects_Click(object sender, EventArgs e)
        {
            GetDatabaseObjects();
        }
    }
    }
