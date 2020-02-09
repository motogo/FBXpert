using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBXpert
{
    class HistoryClass
    {
        private BindingSource bsHistorySuccess;
        private BindingSource bsHistoryFailed;
        private System.Data.DataSet dsHistory;
        private System.Data.DataTable dtSUCCESS;
        private System.Data.DataTable dtFAILED;
        private System.Data.DataColumn colSUCC_RUNDATE;
        private System.Data.DataColumn colSUCC_SQL;
        private System.Data.DataColumn colSUCC_DBREG;

        private System.Data.DataColumn colFAIL_RUNDATE;
        private System.Data.DataColumn colFAIL_SQL;
        private System.Data.DataColumn colFAIL_DBREG;

        public HistoryClass()
        {
            this.dsHistory = new System.Data.DataSet();
            this.dtSUCCESS = new System.Data.DataTable();
            this.dtFAILED  = new System.Data.DataTable();

            


            // 
            // bsHistorySuccess
            // 
            this.bsHistorySuccess.DataMember = "dtSUCCESS";
            this.bsHistorySuccess.DataSource = this.dsHistory;
            // 
            // dsHistory
            // 
            this.dsHistory.DataSetName = "NewDataSet";
            this.dsHistory.EnforceConstraints = false;
            this.dsHistory.Tables.AddRange(new System.Data.DataTable[] {
            this.dtSUCCESS,
            this.dtFAILED});


            this.colSUCC_RUNDATE = new System.Data.DataColumn();
            this.colSUCC_SQL = new System.Data.DataColumn();
            this.colSUCC_DBREG = new System.Data.DataColumn();
            this.dtFAILED = new System.Data.DataTable();
            this.colFAIL_RUNDATE = new System.Data.DataColumn();
            this.colFAIL_SQL = new System.Data.DataColumn();
            this.colFAIL_DBREG = new System.Data.DataColumn();
            this.bsHistoryFailed = new System.Windows.Forms.BindingSource();
            this.bsHistorySuccess = new System.Windows.Forms.BindingSource();



            // 
            // dtSUCCESS
            // 
            this.dtSUCCESS.Columns.AddRange(new System.Data.DataColumn[] {
            this.colSUCC_RUNDATE,
            this.colSUCC_SQL,
            this.colSUCC_DBREG});
            this.dtSUCCESS.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "SQL"}, true)});
            this.dtSUCCESS.PrimaryKey = new System.Data.DataColumn[] {
        this.colSUCC_SQL};
            this.dtSUCCESS.TableName = "dtSUCCESS";

            // 
            // dtFAILED
            // 
            this.dtFAILED.Columns.AddRange(new System.Data.DataColumn[] {
            this.colFAIL_RUNDATE,
            this.colFAIL_SQL,
            this.colFAIL_DBREG});
            this.dtFAILED.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "SQL"}, true)});
            this.dtFAILED.PrimaryKey = new System.Data.DataColumn[] {
        this.colFAIL_SQL};
            this.dtFAILED.TableName = "dtFAILED";
            // 
            // colFAIL_RUNDATE
            // 
            this.colFAIL_RUNDATE.ColumnName = "RUNDATE";
            this.colFAIL_RUNDATE.DataType = typeof(System.DateTime);
            // 
            // colFAIL_SQL
            // 
            this.colFAIL_SQL.AllowDBNull = false;
            this.colFAIL_SQL.ColumnName = "SQL";
            // 
            // colFAIL_DBREG
            // 
            this.colFAIL_DBREG.ColumnName = "DBREG";
            // 
            // bsHistoryFailed
            // 
            this.bsHistoryFailed.DataMember = "dtFAILED";
            this.bsHistoryFailed.DataSource = this.dsHistory;


        }

    }
}
