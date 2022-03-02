using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpertLib;
using FormInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class ProcedureForm : IEditForm
    {
        private ProcedureClass _procedureObject = null;
        private ProcedureClass _procedureObjectOld = null;
        private DBRegistrationClass _dbReg = null;
        private TreeNode _tn = null;
        private ContextMenuStrip _cm = null;
        private NotifiesClass _localNotify = new NotifiesClass();

        private AutocompleteClass _ac = null;
        private int _messagesCount = 0;
        private int _errorCount = 0;
        private bool _doEvents = false;
        List<TableClass> _tables = null;

        public ProcedureForm(Form parent, DBRegistrationClass dbReg, List<TableClass> tables, TreeNode tn, ContextMenuStrip cm, StateClasses.EditStateClass.eBearbeiten mode)
        {
            InitializeComponent();
            this.MdiParent = parent;
            _tn = tn;
            _cm = cm;
            _tables = tables;
            try
            {
                BearbeitenMode = mode;
                if (BearbeitenMode == StateClasses.EditStateClass.eBearbeiten.eInsert)
                {
                    _procedureObject = new ProcedureClass();
                    _procedureObject.Name = "NEW_PROCEDURE";
                }
                else
                {
                    _procedureObject = (ProcedureClass)tn.Tag;
                }
            }
            catch
            {

            }
            _procedureObjectOld = (ProcedureClass)_procedureObject.Clone();

            _dbReg = dbReg;
            _localNotify.Register4Error(Notify_OnRaiseErrorHandler);
            _localNotify.Register4Info(Notify_OnRaiseInfoHandler);
            cbDatatype.Items.Clear();

            DBTypeList dbList = new DBTypeList();
            foreach (DBDataTypes dt in dbList.Values)
            {
                cbDatatype.Items.Add(dt);
            }
            _doEvents = true;
        }

        private void Notify_OnRaiseInfoHandler(object sender, MessageEventArgs k)
        {
            var sb = new StringBuilder();
            _messagesCount++;
            if (_messagesCount > 0) sb.Append($@"Messages ({_messagesCount}) ");
            if (_errorCount > 0) sb.Append($@"Errors ({_errorCount})");

            fctMessages.AppendText($@"{StaticFunctionsClass.DateTimeNowStr()} INFO  {k.Meldung}");
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }

        private void Notify_OnRaiseErrorHandler(object sender, MessageEventArgs k)
        {
            var sb = new StringBuilder();
            _errorCount++;
            if (_messagesCount > 0) sb.Append($@"{StaticFunctionsClass.DateTimeNowStr()} Messages ({_messagesCount}) ");
            if (_errorCount > 0) sb.Append($@"{StaticFunctionsClass.DateTimeNowStr()} Errors ({_errorCount})");

            fctMessages.AppendText($@"ERROR {k.Meldung}");
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }

        private void MakeSQL()
        {
            if (BearbeitenMode == StateClasses.EditStateClass.eBearbeiten.eEdit) MakeSQLAlter(); else MakeSQLNew();

            ShowCaptions();
            hsCreate.Enabled = (_procedureObject.Name.Length > 0);
        }

        private int MakeSQLNew()
        {
            var SQLScript = new List<string>();
            SQLScript.Clear();
            SQLScript = StaticDatabaseObjects.Instance().MakeSQLCreateProcedure(_procedureObject, true);
            SQLToUI(SQLScript);
            return SQLScript.Count;
        }

        private void SQLToUI(List<string> SQLScript)
        {
            fctSQL.Clear();
            foreach (string str in SQLScript)
            {
                fctSQL.AppendText($@"{str}{Environment.NewLine}");
            }
        }

        private int MakeSQLAlter()
        {
            var SQLScript = new List<string>();
            SQLScript.Clear();
            SQLScript = StaticDatabaseObjects.Instance().MakeSQLAlterProcedure(_procedureObject, _procedureObjectOld, true);
            SQLToUI(SQLScript);
            return SQLScript.Count;
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetEnables()
        {
            txtProcName.Enabled = true;
        }

        public void DataToEdit()
        {
            _doEvents = false;
            txtProcName.Text = _procedureObject.Name;
            fctGenDescription.Text = _procedureObject.Description;

            lvFields.Items.Clear();
            for (int i = 0; i < _procedureObject.ParameterIn.Count; i++)
            {
                var pc = _procedureObject.ParameterIn[i];
                string[] columns = { "IN", pc.Name, pc.RawType };
                var lvi = new ListViewItem(columns);

                var pci = new ParameterListItem();
                pci.pc = pc;
                pci.direction = eParameterTypDirection.din;
                lvi.Tag = pci;
                lvFields.Items.Add(lvi);
            }

            for (int i = 0; i < _procedureObject.ParameterOut.Count; i++)
            {
                var pc = _procedureObject.ParameterOut[i];
                string[] columns = { "OUT", pc.Name, pc.RawType };
                var lvi = new ListViewItem(columns);
                var pci = new ParameterListItem();
                pci.pc = pc;
                pci.direction = eParameterTypDirection.dout;
                lvi.Tag = pci;
                lvFields.Items.Add(lvi);
            }

            for (int i = 0; i < _procedureObject.Source.Count; i++)
            {
                fcbProcedureDefinitionSQL.AppendText($@"{_procedureObject.Source[i]}{Environment.NewLine}");
            }
            _doEvents = true;
        }

        public void EditToData()
        {

        }
        public void SetControlSizes()
        {
            pnlFieldUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlMessagesUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlProcedureAttributesUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlFormUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlSQLUpper.Height = AppSizeConstants.UpperFormBandHeight;
        }
        private void ProcedureForm_Load(object sender, EventArgs e)
        {
            SetControlSizes();
            FormDesign.SetFormLeft(this);
            DataToEdit();
            SetEnables();
            MakeSQL();
            SetAutocompeteObjects(_tables);
        }
        AutocompleteClass ac = null;
        public void SetAutocompeteObjects(List<TableClass> tables)
        {
            ac = new AutocompleteClass(fctSQL, _dbReg);
            ac.CreateAutocompleteForDatabase();
            ac.AddProcedureCommands();
            ac.AddAutocompleteForSQL();
            ac.AddAutocompleteForTables(tables);
            ac.Activate();
        }

        public void ShowCaptions()
        {
            lblProcedureName.Text = $@"Procedure: {_procedureObject.Name}";
            this.Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, "Edit Procedure");
        }

        private void txtGenName_TextChanged(object sender, EventArgs e)
        {
            if (!_doEvents) return;
            _procedureObject.Name = txtProcName.Text.Trim();
            if (BearbeitenMode != StateClasses.EditStateClass.eBearbeiten.eInsert) BearbeitenMode = StateClasses.EditStateClass.eBearbeiten.eEdit;
            MakeSQL();
        }

        private void fctGenDescription_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if (!_doEvents) return;
            _procedureObject.Description = fctGenDescription.Text;
            MakeSQL();
        }

        private void Create()
        {
            string _connstr = ConnectionStrings.Instance.MakeConnectionString(_dbReg);
            var _sql = new DBBasicClassLibrary.SQLScriptingClass(_connstr, AppSettingsClass.Instance.SQLVariables.GetNewLine(), AppSettingsClass.Instance.SQLVariables.CommentStart, AppSettingsClass.Instance.SQLVariables.CommentEnd, AppSettingsClass.Instance.SQLVariables.SingleLineComment, "SCRIPT");

            var riList = _sql.ExecuteCommands(fctSQL.Lines);

            AppStaticFunctionsClass.SendResultNotify(riList, _localNotify);
            var riFailure = riList.Find(x => x.commandDone == false);
            string info = (riFailure == null)
                ? $@"Procedure {_dbReg.Alias}->{_procedureObject.Name} updated."
                : $@"Procedure {_dbReg.Alias}->{_procedureObject.Name} not updated !!!{Environment.NewLine}{riFailure.nErrors} errors, last error:{riFailure.lastError}{Environment.NewLine}{riFailure.nErrors} errors, last error:{riFailure.lastError}";

            DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo(info, StaticVariablesClass.ReloadProcedures, $@"->Proc:{Name}->Create");
            _localNotify.Notify.RaiseInfo(info);
        }

        private void hsCreate_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void hsClearMessages_Click(object sender, EventArgs e)
        {
            fctMessages.Clear();
        }

        private void cmsParameters_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsmiAddInputParameter)
            {

            }
            else if (e.ClickedItem == tsmiAddOutputParameter)
            {

            }
            else if (e.ClickedItem == tsmiDropParameter)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbDatatype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFields.SelectedItems.Count <= 0) return;
            var lvi = lvFields.SelectedItems[0];
            if (lvi == null) return;

            var pc = lvi.Tag as ParameterListItem;
            txtDatatypeLength.Text = pc.pc.Length.ToString();
            txtParameter.Text = pc.pc.Name;
            if (pc.direction == eParameterTypDirection.dout)
            {
                rbIN.Checked = true;
            }
            else if (pc.direction == eParameterTypDirection.dout)
            {
                rbOUT.Checked = true;
            }
            else
            {
                rbVAR.Checked = true;
            }
        }

        private void hsSaveSQL_Click(object sender, EventArgs e)
        {
            if (saveSQLFile.ShowDialog() != DialogResult.OK) return;
            fctSQL.SaveToFile(saveSQLFile.FileName, Encoding.UTF8);
        }

        private void hsLoadSQL_Click(object sender, EventArgs e)
        {
            if (ofdSQL.ShowDialog() != DialogResult.OK) return;
            fctSQL.OpenFile(ofdSQL.FileName);
        }

        private void hsNew_Click(object sender, EventArgs e)
        {
            _procedureObject = new ProcedureClass();
            _procedureObject.Name = "NEW_PROCEDURE";
            _procedureObject.Description = "";

            var pc = new ParameterClass();
            pc.Name = "X";
            pc.RawType = "INTEGER";
            pc.FieldType = "LONG";
            pc.TypeNumber = 8;
            pc.Length = 4;
            pc.Precision = 0;
            _procedureObject.ParameterOut.Add(pc);

            pc = new ParameterClass();
            pc.Name = "XX";
            pc.RawType = "INTEGER";
            pc.FieldType = "LONG";
            pc.TypeNumber = 8;
            pc.Length = 4;
            pc.Precision = 0;
            _procedureObject.ParameterIn.Add(pc);

            _procedureObjectOld = (ProcedureClass)_procedureObject.Clone();
            BearbeitenMode = StateClasses.EditStateClass.eBearbeiten.eInsert;
            DataToEdit();
            MakeSQL();
        }

        private void fctSQL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.K | Keys.Control))
            {
                if (_ac != null)
                {
                    _ac.Show();
                }
                e.Handled = true;
            }
        }
    }
}
