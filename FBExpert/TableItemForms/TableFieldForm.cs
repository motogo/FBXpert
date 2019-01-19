using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert;
using StateClasses;
using System;
using System.Data.Common;
using System.Windows.Forms;
using FBXpert.Globals;

namespace FBExpert
{
    public partial class TableFieldForm : Form
    {
        TableFieldClass FieldObject = null;
        string TabName = string.Empty;
        DBRegistrationClass DBReg = null;
        public TableFieldForm(DBRegistrationClass dbReg, Form parent,  TableFieldClass fieldsObject, string tabName)
        {
            InitializeComponent();
            DBReg = dbReg;
            FieldObject = fieldsObject;
            TabName = tabName;
            RefreshDomain();
            DataToEdit();
        }

        public void ShowCaptions()
        {
            if (FieldObject != null)
            {
                lblTableName.Text = "Edit Table Field: " + FieldObject.Name;
            }
            else
            {
                lblTableName.Text = "Edit Table Field";
            }
            this.Text = DevelopmentClass.Instance().GetDBInfo(DBReg, "Edit Table Field");            
        }

        public void DataToEdit()
        {
            txtFieldName.Text       = FieldObject.Name;
            txtFieldLength.Text     = FieldObject.Domain.Length.ToString();
            txtFieldType.Text       = FieldObject.Domain.FieldType.ToString();
            txtFieldRawType.Text    = FieldObject.Domain.RawType.ToString();
            txtDomain.Text          = FieldObject.Domain.Name;
            txtFieldScale.Text      = FieldObject.Domain.Scale.ToString();
            fctDescription.Text     = FieldObject.Domain.Description;
            txtFieldCharSet.Text    = FieldObject.Domain.CharSet;
            txtFieldCollate.Text    = FieldObject.Domain.Collate;
            cbNotNull.Checked = FieldObject.Domain.NotNull;            
        }

        private void hsClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        DomainClass DomainObject = null;

        public void RefreshDomain()
        {
            string cmd0 = "SELECT RDB$FIELDS.RDB$FIELD_NAME,RDB$FIELDS.RDB$CHARACTER_LENGTH,RDB$FIELDS.RDB$FIELD_SCALE,RDB$FIELD_PRECISION,RDB$FIELDS.RDB$FIELD_TYPE,RDB$FIELDS.RDB$DESCRIPTION,RDB$TYPES.RDB$TYPE_NAME FROM RDB$FIELDS";
            string cmd1 = "LEFT JOIN RDB$TYPES ON RDB$TYPES.RDB$TYPE = RDB$FIELDS.RDB$FIELD_TYPE";
            string where = "WHERE RDB$FIELDS.RDB$FIELD_NAME = '" + FieldObject.Domain+ "' AND RDB$TYPES.RDB$FIELD_NAME = 'RDB$FIELD_TYPE'";
            string cmd = cmd0 + " " + cmd1 + " " +where+";";

            ConnectionClass cc = ConnectionPoolClass.Instance().GetConnection("C1");
            cc.ShowExceptionMode = MessageLibrary.ShowError.no;
            DbDataReader dr = cc.ExecuteQuery(cmd, false);
            
            if (dr != null)
            {
                if (cc.HasRows())
                {
                    int n = 0;
                    while (cc.Read())
                    {

                        DomainObject = DataClassFactory.GetDataClass(StaticVariablesClass.DomainsKeyStr) as DomainClass;
                        DomainObject.Name = cc.GetValue(0).ToString().Trim();
                        DomainObject.Length = StaticFunctionsClass.ToIntDef(cc.GetValue(1).ToString().Trim(), 0);
                        DomainObject.Scale = StaticFunctionsClass.ToIntDef(cc.GetValue(2).ToString().Trim(), 0);
                        DomainObject.Precision = StaticFunctionsClass.ToIntDef(cc.GetValue(3).ToString().Trim(), 0);
                        DomainObject.TypeNumber = StaticFunctionsClass.ToIntDef(cc.GetValue(4).ToString().Trim(), 0);
                        DomainObject.FieldType = cc.GetValue(6).ToString().Trim();
                        DomainObject.RawType = StaticVariablesClass.ConvertINTERNALType_TO_SQLType(DomainObject.FieldType, DomainObject.Length);
                        
                        object ob = cc.GetValue(5);
                        DomainObject.Description = cc.GetValue(5).ToString().Trim();
                        /*                                              
                        if (!string.IsNullOrEmpty(ob.ToString()))
                        {
                            byte[] bytetext = (byte[])cc.DBProvider.DataReader[3];
                            DomainObject.Description = System.Text.Encoding.UTF8.GetString(bytetext);
                        }
                        */
                        n++;
                    }
                 
                }
                cc.CloseConnection();
            }
        }

        private void hsEditDomain_Click(object sender, EventArgs e)
        {
            RefreshDomain();
            DomainForm df = new DomainForm(FbXpertMainForm.Instance(), DBReg,  DomainObject);
            df.SetBearbeitenMode(EditStateClass.eBearbeiten.eEdit);
            df.Show();
        }

        public void GetConstraints()
        {
            ConnectionClass cc = ConnectionPoolClass.Instance().GetConnection("TABLE1");
            cc.ShowExceptionMode = MessageLibrary.ShowError.no;

            string cmd_index0 = "SELECT RDB$INDICES.RDB$INDEX_NAME as Name,RDB$RELATION_CONSTRAINTS.RDB$CONSTRAINT_TYPE as FieldType";
            string cmd_index1 = "FROM RDB$INDICES";
            string cmd_index2 = "LEFT JOIN RDB$RELATION_CONSTRAINTS ON RDB$RELATION_CONSTRAINTS.RDB$INDEX_NAME = RDB$INDICES.RDB$INDEX_NAME";
            string cmd_index_where = "WHERE RDB$INDICES.RDB$RELATION_NAME = '" +TabName + "'";

            string cmd_index = cmd_index0 + " " + cmd_index1 + " " + cmd_index2 + " " + cmd_index_where + ";";



            dataSet1.Clear();
            dataGridView1.AutoGenerateColumns = true;
            //string cmd = "SELECT * FROM " + TableObject.Name + ";";

            /*
            spezialfilterBox1.SQLKonjunktion = "WHERE";
            string SCmd = spezialfilterBox1.SQLCmd;
            if (SCmd.Length > 0)
            {
                sb.Append(SCmd);
            }
            
            sb.Append(";");
            */
           

            cc.FillDataset(cmd_index, dataSet1);
            cc.CloseReader();

            bindingSource1.DataMember = "Table";




            /*
            n++;
            if (cc.ExecuteQuery(cmd_index, false) != null)
            {

                while (cc.Read())
                {
                    string index_name = cc.GetValue(0).ToString().Trim();
                    string constraint_type = cc.GetValue(1).ToString().Trim();
                    int indexid = StaticFunctionsClass.ToIntDef(cc_index.GetValue(2).ToString().Trim(), -1);
                    if ((constraint_type == "PRIMARY KEY") && (n == indexid))
                    {
                        tfc.IS_PRIMARY = true;
                        tfc.IS_UNIQUE = true;
                    }
                }
            }

            tfc.Domain.Length = StaticFunctionsClass.ToIntDef(cc.GetValue(5).ToString().Trim(), 0);
            tfc.Domain.FieldType = cc.GetValue(4).ToString().Trim();
            tfc.Domain.RawType = StaticVariablesClass.ConvertType(tfc.Domain.FieldType, tfc.Domain.Length);
            tfc.Position = StaticFunctionsClass.ToIntDef(cc.GetValue(2).ToString().Trim(), 0);
            tfc.Domain.Name = cc.GetValue(6).ToString().Trim();
            tfc.Domain.Scale = StaticFunctionsClass.ToIntDef(cc.GetValue(7).ToString().Trim(), 0) * -1;
            */
        }
        private void hsNewDomain_Click(object sender, EventArgs e)
        {
            RefreshDomain();
            DomainForm df = new DomainForm(FbXpertMainForm.Instance(), DBReg,  DomainObject);
            df.SetNew();
            df.Show();
        }

        private void hsInfo_Click(object sender, EventArgs e)
        {
            HelpInfoForm hi = new HelpInfoForm();
            hi.AddBold("Character set:");
            hi.AddTab();
            hi.AddLine("A character set is a set of symbols and encodings");
            hi.AddNewLine();
            hi.AddBold("Collation:");
            hi.AddTab();
            hi.AddLine("A collation is a set of rules for comparing characters in a character set.");
            hi.AddNewLine();
            hi.AddBold("Domain:");
            hi.AddTab();
            hi.AddLine("A global user defined Datatype.");
            hi.AddNewLine();
            hi.AddBold("Constraints:");
            hi.AddTab();
            hi.AddLine("Database constraints are rules that define interrelations between tables and can check and modify the data in a database.");

            



            hi.Set();
            hi.ShowDialog();
        }

        private void TableFieldForm_Load(object sender, EventArgs e)
        {
            
            ShowCaptions();
            GetConstraints();
        }

        
           

   
}
}
