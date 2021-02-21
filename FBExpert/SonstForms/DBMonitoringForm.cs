using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Windows.Forms;

namespace FBXpert
{
    public partial class DBMonitoringForm : Form
    {
       
       
        DBRegistrationClass DBReg = null;
        public DBMonitoringForm(Form parent, DBRegistrationClass drc)
        {
            InitializeComponent();
            DBReg = drc;
            this.MdiParent = parent;                       
        }

        public void GetConnections()
        {
            lvConnections.Items.Clear();
            foreach (ConnectionClass c in ConnectionPoolClass.Instance().Connections)
            {
                string[] cn = new string[3];
                cn[0] = c.ConnName;
                cn[1] = "open";
                if(c.ConnectionIsClosed())
                {
                    cn[1] = "closed";
                }
                cn[2] = "";
                ListViewItem lvi = new ListViewItem(cn);
                lvi.Tag = c;
                lvConnections.Items.Add(lvi);
            }
        }

        public int RefreshMonitorConnections()
        {
            GetConnections();
            try
            { 
                string cmd_index = SQLStatementsClass.Instance().GetMonitorConnections(DBReg.Version,cbAllConnections.Checked );
                dsMonConnections.Clear();
                dgvMonConnections.AutoGenerateColumns = true;
                
                var con = new FbConnection(ConnectionStrings.Instance().MakeConnectionString(DBReg));
                var ds = new FbDataAdapter(cmd_index, con);
                ds.Fill(dsMonConnections);
                con.Close();
                bsMonConnections.DataMember = "Table";
                return dsMonConnections.Tables[0].Rows.Count;

            }
            catch(Exception ex)
            {
                 NotifiesClass.Instance().AddToERROR(AppStaticFunctionsClass.GetFormattedError($@"{Name}-> RefreshMonitorConnections()", ex));                      
            }
            bsMonConnections.DataMember = "Table";
            return dsMonConnections.Tables[0].Rows.Count;
        }


        public void ShowCaptions()
        {
            lblTableName.Text = "Database Monitoring";
            this.Text = DevelopmentClass.Instance().GetDBInfo(DBReg, "Database Monitoring");
        }

        private void DBMonitoringForm_Load(object sender, EventArgs e)
        {
            FormDesign.SetFormLeft(this);
            ShowCaptions();
            RefreshMonitorConnections();
        }

        private void hsRefreshDependenciesTo_Click(object sender, EventArgs e)
        {
            RefreshMonitorConnections();
        }

        private void DBMonitoringForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void txtTick_TextChanged(object sender, EventArgs e)
        {
            cbTick.Checked = false;
        }

        private void cbTick_CheckedChanged(object sender, EventArgs e)
        {
            if(cbTick.Checked)
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
            if(cbRefreshActiveConnections.Checked)
            {
                RefreshMonitorConnections();
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
            RefreshMonitorConnections();
        }

        private void hotSpot1_Click(object sender, EventArgs e)
        {
            ConnectionPoolClass.Instance().CloseAllConnections();
        }

        private void hsRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
