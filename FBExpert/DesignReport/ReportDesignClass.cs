using DBBasicClassLibrary;
using FastReport.Data;
using FBXpertLib;
using FirebirdSql.Data.FirebirdClient;
using SEMessageBoxLibrary;
using System;
using System.Collections.Generic;
using System.Data;

namespace FBXpert.DesignReport
{
    public class ReportDesignClass
    {

        private List<DBBasicClassLibrary.ReportSqlCommands> _dataObjects = new List<DBBasicClassLibrary.ReportSqlCommands>();
        private List<DBBasicClassLibrary.ReportValuesGroups> _valueObjects = new List<DBBasicClassLibrary.ReportValuesGroups>();
        private string _datafile;
        private string _schemafile;
        private string _title;
        private string _datasetname;
        private string _reportfile;

        public List<DBBasicClassLibrary.ReportSqlCommands> DataObjects { get => _dataObjects; set => _dataObjects = value; }
        public List<DBBasicClassLibrary.ReportValuesGroups> ValueObjects { get => _valueObjects; set => _valueObjects = value; }
        public string Datafile { get => _datafile; set => _datafile = value; }
        public string Schemafile { get => _schemafile; set => _schemafile = value; }
        public string Title { get => _title; set => _title = value; }
        public string Datasetname { get => _datasetname; set => _datasetname = value; }
        public string Reportfile { get => _reportfile; set => _reportfile = value; }


        public void CreateReportDatas(DBRegistrationClass dbReg)
        {
            if (_dataObjects.Count > 0)
            {
                var dataConnection = new FbConnection();

                if (dataConnection.State != ConnectionState.Closed) dataConnection.Close();

                dataConnection = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(dbReg));
                dataConnection.Open();
                var ds = new DataSet();
                var adapter = new FbDataAdapter("", dataConnection);
                var ds2 = new DataSet
                {
                    DataSetName = "Tables"
                };
                foreach (var rsql in _dataObjects)
                {
                    
                        var sql = rsql.cmd;
                        adapter.SelectCommand = new FbCommand(sql, dataConnection);

                        adapter.Fill(ds);
                        ds2.Tables.Add(ds.Tables[0].Clone());
                        ds2.Tables[ds2.Tables.Count - 1].TableName = rsql.caption;

                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            object[] arr = dr.ItemArray;
                            ds2.Tables[ds2.Tables.Count - 1].Rows.Add(arr);
                        }
                }

                foreach (ReportValuesGroups vob in _valueObjects)
                {
                    DataTable dt = new DataTable();
                    dt.TableName = vob.group;
                    foreach (ReportValues rv in vob.vals)
                    {
                        DataColumn col = new DataColumn();
                        col.ColumnName = rv.caption;
                        col.DataType = rv.valtype;

                        dt.Columns.Add(col);//.AddRange(new System.Data.DataColumn[] { col });
                        DataRow dr = dt.NewRow();
                        dt.Rows.Add(rv.val);
                    }
                    ds2.Tables.Add(dt);
                }

                ds2.WriteXml(_datafile);
                ds2.WriteXmlSchema(_schemafile);

                dataConnection.Close();
            }
            else
            {                
                SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(),"NoSqlDatasForReportCaption", "NoSqlDatasForReport",  SEMessageBoxButtons.OK,SEMessageBoxIcon.Exclamation);                
            }
        }        
        
        public string CreateDesignFp(FastReport.Report rpt)
        {

            try
            {                
                    var dorg = new XmlDataConnection();
                    var ddict = new Dictionary();
                
                    dorg.Alias = "Tables";
                    dorg.Name = "Tables";
                    dorg.Parent = ddict;
                    dorg.XmlFile = _datafile;
                    dorg.XsdFile = _schemafile;
                    dorg.ConnectionString = string.Format("XsdFile={1};XmlFile={0}", _datafile, _schemafile);

                    rpt.UseFileCache = false;
                    rpt.AutoFillDataSet = false;
                    rpt.Dictionary.Connections.Clear();
                    rpt.Dictionary.Connections.Add(dorg);
                
            
                rpt.NeedRefresh = true;
                rpt.DoublePass = true;
                rpt.AutoFillDataSet = true;
                rpt.FileName = this.Reportfile;
                rpt.Design(FbXpertMainForm.Instance());     
                return rpt.FileName;
            }
            catch (Exception ex)
            {
                object[] param = {ex.Source,ex.Message,Environment.NewLine };
                SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(),"ExceptionCaption", "ExceptionMessage",  SEMessageBoxButtons.OK,SEMessageBoxIcon.Exclamation,null,param);                   
            }   
            return null;
        }

        public void EditDesignFp(FastReport.Report rpt)
        {       
            try
            {
                rpt.UseFileCache = false;

                rpt.Report.Load(_reportfile);
                rpt.AutoFillDataSet = false;
                
                rpt.Dictionary.Connections[0].ConnectionString = string.Format("XsdFile={1};XmlFile={0}", _datafile, _schemafile);
                
                rpt.NeedRefresh = true;
                rpt.DoublePass = true;
                rpt.AutoFillDataSet = true;
                rpt.Design(FbXpertMainForm.Instance());
                _reportfile = rpt.FileName;
                _datafile = ((XmlDataConnection) rpt.Dictionary.Connections[0]).XmlFile;
                _schemafile = ((XmlDataConnection)rpt.Dictionary.Connections[0]).XsdFile;

            }
            catch (Exception ex)
            {
                object[] param = {ex.Source,ex.Message,Environment.NewLine };
                SEMessageBox.ShowMDIDialog(FbXpertMainForm.Instance(),"ExceptionCaption", "ExceptionMessage",  SEMessageBoxButtons.OK,SEMessageBoxIcon.Exclamation,null,param);
            }
        }

    }
}
