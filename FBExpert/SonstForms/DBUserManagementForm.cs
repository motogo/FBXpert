using BasicClassLibrary;
using BasicForms;
using DBBasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert.Globals;
using FBXpertLib;
using FirebirdSql.Data.FirebirdClient;
using MessageLibrary.SendMessages;
using System;
using System.Data;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class DBUserManagementForm : Form
    {

        private NotifiesClass _localNotify = new NotifiesClass();
        private DBRegistrationClass DBReg = null;
        public DBUserManagementForm(Form parent, DBRegistrationClass drc)
        {
            InitializeComponent();
            DBReg = drc;
            this.MdiParent = parent;
            _localNotify.Register4Error(ErrorRaised);
            _localNotify.Register4Info(InfoRaised);
        }

        private void ErrorRaised(object sender, MessageEventArgs k)
        {

        }

        private void InfoRaised(object sender, MessageEventArgs k)
        {

        }

        public void GetConnections()
        {


        }
        public bool DataOK()
        {
            int ok = 0;

            SetDefaultColor();
            ok += FormularUtilsClass.Instance.MarkTextBoxWhenTextEmpty(txtPassword);
            ok += FormularUtilsClass.Instance.MarkTextBoxWhenTextEmpty(txtUserName);

            return (ok == 0);
        }
        public int RefreshUsers()
        {
            GetConnections();
            try
            {
                string cmd = SQLStatementsClass.Instance.GetUsers(DBReg.Version);
                dsMonConnections.Clear();
                dgvMonConnections.AutoGenerateColumns = true;

                var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(DBReg));
                var ds = new FbDataAdapter(cmd, con);
                ds.Fill(dsMonConnections);
                con.Close();
                bsUsers.DataMember = "Table";
                return dsMonConnections.Tables[0].Rows.Count;

            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{Name}-> RefreshMonitorConnections()", ex));
            }
            bsUsers.DataMember = "Table";
            return dsMonConnections.Tables[0].Rows.Count;
        }


        public void ShowCaptions()
        {
            lblTableName.Text = "User Management";
            this.Text = DevelopmentClass.Instance().GetDBInfo(DBReg, "Database Monitoring");
        }

        public void SetControlSizes()
        {
            pnlFormUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlUsersUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlSQLUpper.Height = AppSizeConstants.UpperFormBandHeight;
        }
        private void DBUserManagementForm_Load(object sender, EventArgs e)
        {
            SetControlSizes();
            FormDesign.SetFormLeft(this);
            ShowCaptions();
            RefreshUsers();
        }

        private void hsRefreshDependenciesTo_Click(object sender, EventArgs e)
        {
            RefreshUsers();
        }

        private void DBUserManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void txtTick_TextChanged(object sender, EventArgs e)
        {
            cbTick.Checked = false;
        }

        private void cbTick_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTick.Checked)
            {
                int tk = StaticFunctionsClass.ToIntDef(txtTick.Text, 0);
                if (tk > 0)
                {
                    timer1.Interval = tk * 1000;
                    timer1.Start();
                }
                else
                {
                    timer1.Stop();
                }
            }
            else
            {
                timer1.Stop();
            }
        }

        public void AutoRefresh()
        {
            if (cbRefreshActiveConnections.Checked)
            {
                RefreshUsers();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AutoRefresh();
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbAllConnections_CheckedChanged(object sender, EventArgs e)
        {
            RefreshUsers();
        }

        private void hotSpot1_Click(object sender, EventArgs e)
        {
            ConnectionPoolClass.Instance.CloseAllConnections();
        }

        private void hsRefresh_Click(object sender, EventArgs e)
        {
            RefreshUsers();
        }

        enum ePlugin { Srp = 0, Legacy_UserManager = 1 }
        class UserData
        {
            public string username { set; get; }
            public string firstname { set; get; }
            public string middlename { set; get; }
            public string lastname { set; get; }

            public bool active { set; get; }
            public bool admin { set; get; }

            public ePlugin plugin { set; get; }
        }

        private UserData userData = new UserData();

        private void SelectData()
        {
            try
            {
                DataRowView ob = (DataRowView)bsUsers.Current;
                if (ob != null)
                {
                    userData.username = ob.Row["SEC$USER_NAME"].ToString().Trim();
                    userData.firstname = ob.Row["SEC$FIRST_NAME"].ToString().Trim();
                    userData.middlename = ob.Row["SEC$MIDDLE_NAME"].ToString().Trim();
                    userData.lastname = ob.Row["SEC$LAST_NAME"].ToString().Trim();

                    var oba = ob.Row["SEC$ACTIVE"];
                    Type ts = oba.GetType();
                    userData.active = ts == typeof(System.DBNull) ? false : (bool)oba;

                    oba = ob.Row["SEC$ADMIN"];
                    ts = oba.GetType();
                    userData.admin = ts == typeof(System.DBNull) ? false : (bool)oba;

                    string pluginStr = ob.Row["SEC$PLUGIN"].ToString().Trim();
                    if (pluginStr == ePlugin.Srp.ToString())
                    {
                        userData.plugin = ePlugin.Srp;
                    }
                    else
                    {
                        userData.plugin = ePlugin.Legacy_UserManager;
                    }
                }

            }
            catch (Exception ex)
            {
                SendMessageClass.Instance.SendAllMessages($@"{ex.Message}", $@"{this.Name}->SelectID()", eLevel.error);
            }
        }
        private void DataToEdit()
        {
            SetDefaultColor();
            txtUserName.Text = userData.username;
            txtFirstName.Text = userData.firstname;
            txtMiddleName.Text = userData.middlename;
            txtLastName.Text = userData.lastname;
            rbLegacy.Checked = userData.plugin == ePlugin.Legacy_UserManager;
            rbSrp.Checked = userData.plugin == ePlugin.Srp;
            rbIsAdmin.Checked = userData.admin;
            rbUserActive.Checked = userData.active;
        }

        private void bsMonConnections_CurrentChanged(object sender, EventArgs e)
        {
            SelectData();
            DataToEdit();
        }

        private void hsAddUser_Click(object sender, EventArgs e)
        {
            hsExecute.Enabled = false;
            hsSaveSQL.Enabled = false;
            if (DataOK())
            {
                AddUserSQL();
                hsExecute.Enabled = true;
                hsSaveSQL.Enabled = true;
            }
            else
            {
                fctSQL.Text = string.Empty;
            }
        }
        private void AddUserSQL()
        {
            fctSQL.Text = string.Empty;
            ePlugin pl = (rbLegacy.Checked) ? ePlugin.Legacy_UserManager : ePlugin.Srp;
            string cmd = $@"CREATE USER {txtUserName.Text} ";
            if (txtFirstName.Text.Length > 0)
            {
                cmd += $@"FIRSTNAME '{txtFirstName.Text}' ";
            }
            if (txtMiddleName.Text.Length > 0)
            {
                cmd += $@"MIDDLENAME '{txtMiddleName.Text}' ";
            }
            if (txtLastName.Text.Length > 0)
            {
                cmd += $@"LASTNAME '{txtLastName.Text}' ";
            }
            cmd += $@"PASSWORD '{txtPassword.Text}' ";
            if (rbUserActive.Checked)
            {
                cmd += "ACTIVE ";
            }
            else
            {
                cmd += "INACTIVE ";
            }
            cmd += $@"USING PLUGIN {pl.ToString()} ";
            if (rbIsAdmin.Checked)
            {
                cmd += "GRANT ADMIN ROLE";
            }
            cmd += ";";
            cmd += Environment.NewLine;
            cmd += Environment.NewLine;
            cmd += "COMMIT;";
            fctSQL.Text = cmd;
        }

        private void hsSave_Click(object sender, EventArgs e)
        {
            ExecueteSQL();
        }

        private void ExecueteSQL()
        {
            string _connstr = ConnectionStrings.Instance.MakeConnectionString(DBReg);
            var _sql = new DBBasicClassLibrary.SQLScriptingClass(_connstr, AppSettingsClass.Instance.SQLVariables.GetNewLine(), AppSettingsClass.Instance.SQLVariables.CommentStart, AppSettingsClass.Instance.SQLVariables.CommentEnd, AppSettingsClass.Instance.SQLVariables.SingleLineComment, "SCRIPT");
            //_sql.ScriptNotify.Register4Info(InfoRaised);
            _sql.ScriptNotify.Register4Error(ErrorRaised);

            var riList = _sql.ExecuteCommands(fctSQL.Lines);
            var riFailure = riList.Find(x => x.commandDone == false);

            AppStaticFunctionsClass.SendResultNotify(riList, _localNotify);

            _localNotify.Notify.RaiseInfo("info", StaticVariablesClass.ReloadFields);
            RefreshUsers();
        }

        /*
        ALTER USER username
           [PASSWORD 'password']
           [FIRSTNAME 'firstname']
           [MIDDLENAME 'middlename']
           [LASTNAME 'lastname']
           [{GRANT|REVOKE
            }
            ADMIN ROLE]
        */

        private void hsDropUser_Click(object sender, EventArgs e)
        {
            hsExecute.Enabled = false;
            hsSaveSQL.Enabled = false;
            if (DataOK())
            {
                DropUserSQL();
                hsExecute.Enabled = true;
                hsSaveSQL.Enabled = true;
            }
            else
            {
                fctSQL.Text = string.Empty;
            }
        }
        private void DropUserSQL()
        {
            fctSQL.Text = string.Empty;
            ePlugin pl = (rbLegacy.Checked) ? ePlugin.Legacy_UserManager : ePlugin.Srp;
            string cmd = $@"DROP USER {txtUserName.Text} ";
            cmd += $@"USING PLUGIN {pl};";

            cmd += Environment.NewLine;
            cmd += Environment.NewLine;
            cmd += "COMMIT;";
            fctSQL.Text = cmd;
        }

        private void hsUpdateUser_Click(object sender, EventArgs e)
        {

            hsExecute.Enabled = false;
            hsSaveSQL.Enabled = false;
            if (DataOK())
            {
                UpdateUserSQL();
                hsExecute.Enabled = true;
                hsSaveSQL.Enabled = true;
            }
            else
            {
                fctSQL.Text = string.Empty;
            }
        }
        private void UpdateUserSQL()
        {
            fctSQL.Text = string.Empty;
            ePlugin pl = (rbLegacy.Checked) ? ePlugin.Legacy_UserManager : ePlugin.Srp;
            string cmd = $@"ALTER USER {txtUserName.Text} ";
            if (txtFirstName.Text.Length > 0)
            {
                cmd += $@"FIRSTNAME '{txtFirstName.Text}' ";
            }
            if (txtMiddleName.Text.Length > 0)
            {
                cmd += $@"MIDDLENAME '{txtMiddleName.Text}' ";
            }
            if (txtLastName.Text.Length > 0)
            {
                cmd += $@"LASTNAME '{txtLastName.Text}' ";
            }
            cmd += $@"PASSWORD '{txtPassword.Text}' ";
            if (rbUserActive.Checked)
            {
                cmd += "ACTIVE ";
            }
            else
            {
                cmd += "INACTIVE ";
            }
            cmd += $@"USING PLUGIN {pl.ToString()} ";

            if (rbIsAdmin.Checked)
            {
                cmd += "GRANT ADMIN ROLE";
            }
            else
            {
                cmd += "REVOKE ADMIN ROLE";
            }

            cmd += ";";
            cmd += Environment.NewLine;
            cmd += "COMMIT;";
            fctSQL.Text = cmd;
        }
        public void SetDefaultColor()
        {
            FormularUtilsClass.Instance.SetTextToDefaultColor(txtPassword);
            FormularUtilsClass.Instance.SetTextToDefaultColor(txtUserName);

        }

        private void hsClearData_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Empty;
            txtUserName.Text = "NEW_USER";
            txtMiddleName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            rbUserActive.Checked = true;
            rbIsAdmin.Checked = false;
            rbSrp.Checked = true;
            SetDefaultColor();
        }

        private void hotSpot1_Click_1(object sender, EventArgs e)
        {
            txtOpenResult.Text = String.Empty;
            pnlConnectState.BackColor = System.Drawing.Color.Yellow;
            DBRegistrationClass dbr = new DBRegistrationClass();
            dbr = DBReg.Clone();
            dbr.User = txtUserName.Text;
            dbr.Password = txtPassword.Text;
            var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(dbr));
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                if (con.State != ConnectionState.Open) con.Close();
                con.Open();
                Thread.Sleep(100);
                if (con.State == ConnectionState.Open)
                {
                    pnlConnectState.BackColor = System.Drawing.Color.Green;
                    Application.DoEvents();
                    con.Close();
                    txtOpenResult.Text = "succeeded";
                }

            }
            catch (Exception ex)
            {
                pnlConnectState.BackColor = System.Drawing.Color.Red;
                txtOpenResult.Text = ex.Message;
                Application.DoEvents();
            }
        }
    }
}
