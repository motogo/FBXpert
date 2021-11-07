using BasicClassLibrary;
using DBBasicClassLibrary;
using FBExpert.DataClasses;
using FBXpert;
using FBXpert.DataClasses;
using FBXpert.Globals;
using FBXpert.SQLStatements;
using FirebirdSql.Data.FirebirdClient;
using FormInterfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FBExpert
{
    public partial class FieldForm : IEditForm
    {
        TableClass TableObject = null;
        TableFieldClass FieldObject = null;
        TableFieldClass OrgFieldObject = null;
        DBRegistrationClass _dbReg = null;
        NotifiesClass localNotify = new NotifiesClass();
        NotifiesClass _localTableNotify = null;
        int error_count = 0;
        int messages_count = 0;
               
        bool DataFilled = false;
              
        TreeNode TableNode = null;
        public FieldForm(DBRegistrationClass dbReg, Form parent, TreeNode tableNode, TableFieldClass fieldObject, NotifiesClass lnotify, StateClasses.EditStateClass.eBearbeiten bearbeitenMode)
        {
            InitializeComponent();

            DataFilled=false;
            this.MdiParent = parent;
            _dbReg = dbReg;
            TableNode = tableNode;
            var tc = (TableClass)tableNode.Tag;
            TableObject = tc.Clone() as TableClass;
            BearbeitenMode = bearbeitenMode;
            FillCombos();
            if(BearbeitenMode == StateClasses.EditStateClass.eBearbeiten.eInsert)
            {
                NewFieldObject();
            }
            else
            {
                FieldObject = fieldObject;
                FieldObject.IsPrimary = TableObject.IsPrimary(FieldObject.Name); 
                FieldObject.Domain.NotNull = TableObject.IsNotNull(FieldObject.Name);
                FieldObject.TableName = TableObject.Name;
            }

            OrgFieldObject = FieldObject.DeepClone();
            ObjectToEdit(FieldObject);
            
            _localTableNotify = (lnotify == null) ? new NotifiesClass() : lnotify;            
                       
            DataFilled = false;
            _localTableNotify.Register4Info(TableInfoRaised);
            localNotify.Register4Info(InfoRaised);
            localNotify.Register4Error(ErrorRaised);
        }

        private void ErrorRaised(object sender, MessageEventArgs k)
        {           
            var sb = new StringBuilder();
            error_count++;
            if (messages_count > 0) sb.Append($@"Messages ({messages_count}) ");
            if (error_count > 0)    sb.Append($@"Errors ({error_count})");
            string errStr = AppStaticFunctionsClass.GetErrorCodeString(k.Meldung,_dbReg);
            fctMessages.AppendText($@"ERROR {errStr}");            
            
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }

        private void InfoRaised(object sender, MessageEventArgs k)
        {
            var sb = new StringBuilder();
            messages_count++;
            if (messages_count > 0) sb.Append($@"Messages ({messages_count}) ");
            if (error_count > 0)    sb.Append($@"Errors ({error_count})");

            fctMessages.AppendText($@"INFO  {k.Meldung}");
            tabPageMessages.Text = sb.ToString();
            fctMessages.ScrollLeft();
        }
        private void TableInfoRaised(object sender, MessageEventArgs k)
        {
            if(k.Key.ToString() == "SELECT_DEFAULTS")          
                txtDefault.Text = (string) k.Data;
            else if (k.Key.ToString() == "SELECT_DEFAULTS_NULLDATA")
                txtNULLDefault.Text = (string)k.Data;
        }

        public void SetVisible()
        {            
            bool varchar = (cbFieldTypes.Text == "VARCHAR");
            bool numeric = ((cbFieldTypes.SelectedItem.GetType() == typeof (DBNumeric)) || (cbFieldTypes.SelectedItem.GetType() == typeof (DBDoublePrecision)));
            bool zahl    = ((cbFieldTypes.SelectedItem.GetType() == typeof (DBInteger)) || (cbFieldTypes.SelectedItem.GetType() == typeof (DBSmallInt)));
            bool blob    = cbFieldTypes.SelectedItem.GetType() == typeof (DBBlob);
            
            gbTextProperties.Dock       = DockStyle.Top;
            gbPrecisionProperties.Dock  = DockStyle.Top;
            gbBlobProperties.Dock       = DockStyle.Top;

            cbNotNull.Visible               = tabControlFieldTypes.SelectedTab == tabPageFieldType;

            gbTextProperties.Visible        =  varchar;            
            gbPrecisionProperties.Visible   =  numeric;
            gbBlobProperties.Visible        =  blob;

            if (!numeric && !varchar && !blob && !zahl)
            {
                // DATE, TIMESTAMP, INTEGER, SMALLINT
                gbPrecisionProperties.Visible = false;
                gbTextProperties.Visible      = false;
                gbBlobProperties.Visible      = false;
            }
        }

        public void SetFormNew()
        {
            cbPrimaryKey.Enabled = true;
        }
        public void SetFormAlter()
        {
            cbPrimaryKey.Enabled = true;
        }

        public void MakeSQL()
        {
            EditToData();
            if(BearbeitenMode == StateClasses.EditStateClass.eBearbeiten.eEdit)
            {
                SetFormAlter();
                MakeSQOAlter();
            }
            else
            {
                SetFormNew();
                MakeSQLNew();
            }
            ShowCaptions();
        }
        
        public string GetTypeString(DBDataTypes type, string fieldlength, string fieldprec, string fieldscale )
        {            
            if (type.GetType() == typeof (DBVarchar))
            {
                int length = StaticFunctionsClass.ToIntDef(fieldlength, 0);
                if (length <= 0)
                {
                    length = StaticFunctionsClass.ToIntDef(fieldlength, 0);
                }
                return $@"VARCHAR({length})";
            }
            else if (type.GetType() == typeof (DBNumeric))
            {
                // NUMERIC(8, 3)
                int prec = StaticFunctionsClass.ToIntDef(fieldprec, 0);
                int digits = StaticFunctionsClass.ToIntDef(fieldscale, 0);
                if (digits >= prec)                
                {
                    txtPrecisionLength.Text = "1";
                    txtScale.Text = "0";
                    prec = 1;
                    digits = 0;
                }
                return $@"NUMERIC({prec},{digits})";
            }            
            
            return type.ToString();
        }

        public void MakeSQLNew()
        {
            fctSQL.BackColor = Color.Bisque;
            SQLScript.Clear();
            gbCollate.Enabled = true;
            gbNULLDefault.Enabled = false;
            if(string.IsNullOrEmpty(txtFieldName.Text))
            {
                SQLScript.Add("/*  FieldName is undefined */");
                SQLToUI();
                return;
            }

            var sb = new StringBuilder();
            string FieldName = txtFieldName.Text;
            
            sb.Append($@"ALTER TABLE {TableObject.Name} ADD {FieldName} ");

            if (tabControlFieldTypes.SelectedTab == tabPageFieldType)
            {
                var FieldType = GetTypeString((DBDataTypes) cbFieldTypes.SelectedItem, txtLength.Text, txtPrecisionLength.Text, txtScale.Text);
                sb.Append($@" {FieldType}");
                Type tp = cbFieldTypes.SelectedItem.GetType();
                if (tp == typeof (DBVarchar))
                {                                        
                    //Lege Column mit Datentyp an                
                    if (cbCharSet.Text.Length > 0)
                    {
                        sb.Append($@" CHARACTER SET {cbCharSet.Text}");
                    }
                    if (cbCollate.Text.Length > 0)
                    {
                        sb.Append($@" COLLATE {cbCollate.Text}");
                    }                                       
                }
                else if (cbFieldTypes.Text == "BLOB")
                {
                    // BLOB SUB_TYPE 0 SEGMENT SIZE 80
                    int st = (int)eBlobSubType.BINARY;
                    if (cbBlobType.Text == "TEXT") st = (int) eBlobSubType.TEXT;
                    if(cbBlobType.Text == "BLR") st = (int)eBlobSubType.BLR; 

                    sb.Append($@" SUB_TYPE {st}");
                    int len = StaticFunctionsClass.ToIntDef(txtBlobSize.Text, 0);
                    if(len > 0)
                    {
                        sb.Append($@" SEGMENT SIZE {len}");
                    }                    
                }
            }
            else //Domain
            {
                var Domain = ((cbDOMAIN.SelectedItem != null)&&(cbDOMAIN.Text.Length > 0)) 
                    ? cbDOMAIN.SelectedItem as DomainClass : null;         
                
                FieldName = (Domain != null) ? Domain.Name : cbDOMAIN.Text;

                string cmd = (Domain != null) 
                        ? $@" {FieldName}  /* raw:{Domain.RawType} intern:[{Domain.FieldType}] */"
                        : $@" {FieldName} /* {GetTypeString((DBDataTypes) cbFieldTypes.SelectedItem, txtLength.Text, txtPrecisionLength.Text, txtScale.Text)} */";
                        sb.Append(cmd);

                if(Domain != null)
                {                    
                    if (Domain.FieldType == "VARYING")
                    {
                        sb.Append(" /* domain */ ");
                    }
                }                
            }
           
            if (txtDefault.Text.Length > 0)
            {
                sb.Append($@" DEFAULT '{txtDefault.Text.Trim()}'");
            }

            if (cbNotNull.Checked)
            {
                sb.Append(" NOT NULL");
            }
        
            sb.Append(";");
            SQLScript.Add(sb.ToString());

            SQLScript.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}"); 
            if (cbPrimaryKey.Checked)
            {                
                SQLScript.Add($@"{Environment.NewLine}");
                string cmd = SQLPatterns.AlterTableAddPK.Replace(SQLPatterns.TableKey,TableObject.Name).Replace(SQLPatterns.ColumnKey,FieldName).Replace(SQLPatterns.PrimaryKey,txtPK.Text);
                //SQLScript.Add($@"ALTER TABLE INVOICE ADD CONSTRAINT {txtPK.Text} PRIMARY KEY ({FieldName})"); 
                SQLScript.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");                 
            }
           
            //COMMENT ON COLUMN TADRESSEN.TTT IS '  rrrrrrrrrrrrrrrr'
            if(fctDescription.Text.Length > 0)
            {                
                SQLScript.Add($@"{Environment.NewLine}");
                SQLScript.Add(SQLPatterns.AlterTableColumnComment.Replace(SQLPatterns.TableKey,TableObject.Name).Replace(SQLPatterns.ColumnKey,FieldName).Replace(SQLPatterns.DescriptionKey,fctDescription.Text));
                SQLScript.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");               
            }

            int pos = StaticFunctionsClass.ToIntDef(txtPosition.Text, 0);
            if(pos > 0)
            {
                string sql = SQLPatterns.PositionSchablone.Replace(SQLPatterns.TableKey,TableObject.Name).Replace(SQLPatterns.ColumnKey,FieldName).Replace(SQLPatterns.PositionKey,$@"{pos-1}");
                SQLScript.Add($@"{Environment.NewLine}");
                SQLScript.Add(sql);
                SQLScript.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");
            }
            SQLToUI();
        }

        public void MakeSQOAlter()
        {
            // ALTER TABLE TADRESSEN ALTER POSTFACH TO POSTFACHX
            // COMMENT ON COLUMN TADRESSEN.POSTFACHX IS '123'

            // ALTER TABLE Customer CHANGE Address Addr char(50); feldnamen ändern
            // ALTER TABLE t1 ALTER c_temp TO c1;
            // ALTER TABLE t1 ALTER c1 TYPE char(90);
            fctSQL.BackColor = SystemColors.Info;
            SQLScript.Clear();  
            gbCollate.Enabled = false;
            gbNULLDefault.Enabled = true;
            
            bool FieldNameChanged   = (OrgFieldObject.Name != FieldObject.Name);
            bool FieldTypeChanged   = ((OrgFieldObject.Domain.FieldType != FieldObject.Domain.FieldType)
                ||(OrgFieldObject.Domain.SubTypeNumber != FieldObject.Domain.SubTypeNumber)
                ||(OrgFieldObject.Domain.SegmentLength != FieldObject.Domain.SegmentLength)
                ||(OrgFieldObject.Domain.Precision != FieldObject.Domain.Precision)
                ||(OrgFieldObject.Domain.Scale != FieldObject.Domain.Scale)
                ||(OrgFieldObject.Domain.Length != FieldObject.Domain.Length)
                ||(OrgFieldObject.Domain.CharSet != FieldObject.Domain.CharSet)
                ||(OrgFieldObject.Domain.Collate != FieldObject.Domain.Collate));

            bool PrimaryKeyChanged  = (OrgFieldObject.IsPrimary != FieldObject.IsPrimary);    
            bool IsNUllChanged      = (OrgFieldObject.Domain.NotNull != FieldObject.Domain.NotNull);
            bool PositionChanged    = ((OrgFieldObject.Position != FieldObject.Position)&&(FieldObject.Position > 0));
            bool DefaultChanged     = (OrgFieldObject.Domain.DefaultValue != FieldObject.Domain.DefaultValue);
            bool DescriptionChanged = (OrgFieldObject.Description != FieldObject.Description);
            
            if (FieldNameChanged)            
            {                              
                SQLScript.Add(SQLPatterns.AlterTableRenameField.Replace(SQLPatterns.TableKey,TableObject.Name).Replace(SQLPatterns.ColumnKey,OrgFieldObject.Name).Replace(SQLPatterns.ColumnKey2,FieldObject.Name));
                SQLScript.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}");
            }

            if(FieldTypeChanged)
            {
                var sb = new StringBuilder($@"ALTER TABLE {TableObject.Name} ALTER {FieldObject.Name}");
                if (tabControlFieldTypes.SelectedTab == tabPageFieldType)
                {
                    var FieldType = GetTypeString( (DBDataTypes) cbFieldTypes.SelectedItem, txtLength.Text, txtPrecisionLength.Text, txtScale.Text);
                    sb.Append($@" TYPE {FieldType}");
                    
                    //Fieldinfo for domain
                    Type tp = cbFieldTypes.SelectedItem.GetType();
                    if (tp == typeof (DBVarchar)) 
                    {                        
                        int len = StaticFunctionsClass.ToIntDef(txtLength.Text, 0);                        
                        string btstr =  (len > 0) ? $@" CHARACTER SET {cbCharSet.Text}" : $@" COLLATE {cbCollate.Text}";                        
                        sb.Append(btstr);                        
                    }
                    else if (tp == typeof (DBBlob)) 
                    {
                        int len = StaticFunctionsClass.ToIntDef(txtBlobSize.Text, 0);
                        string btstr = $@" SUB_TYPE 0"; //binary
                        if (cbBlobType.Text == "BLR")
                        {
                            btstr = $@" SUB_TYPE 2";
                        }
                        else if (cbBlobType.Text == "TEXT")
                        {
                            btstr = $@" SUB_TYPE 1";
                        }

                        sb.Append(btstr);
                        if (len > 0)
                        {
                            sb.Append($@" SEGMENT SIZE {len}");
                        }
                    }

                    if(!sb.ToString().EndsWith(";")) sb.Append(";");
                    SQLScript.Add(sb.ToString());
                    
                    SQLScript.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");
                }
                else
                {                    
                    var Domain = ((cbDOMAIN.SelectedItem != null)&&(cbDOMAIN.Text.Length > 0))  ? cbDOMAIN.SelectedItem as DomainClass : null; 
                   
                    if (Domain != null)
                    {
                        var FieldType = (Domain != null) ? Domain.Name : cbDOMAIN.Text;

                        string cmd = (Domain != null) 
                            ? $@" {FieldType}  /* raw:{Domain.RawType} intern:[{Domain.FieldType}] */"
                            : $@" {FieldType} /* {GetTypeString((DBDataTypes) cbFieldTypes.SelectedItem, txtLength.Text, txtPrecisionLength.Text, txtScale.Text)} */";
                        sb.Append(cmd);

                        //Fieldinfo for domain
                        if (Domain.FieldType == "VARYING")
                        {
                            if ((Domain.CharSet.Length > 0)||(Domain.Collate.Length > 0)) sb.Append(" /*");
                            if (Domain.CharSet.Length > 0)
                            {
                                sb.Append($@" CHARACTER SET {Domain.CharSet}");
                            }
                            
                            if (Domain.Collate.Length > 0)
                            {
                                sb.Append($@" COLLATE {Domain.Collate}");
                            }
                            if ((Domain.CharSet.Length > 0)||(Domain.Collate.Length > 0)) sb.Append(" */");
                        }
                        SQLScript.Add(sb.ToString());
                        SQLScript.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");
                    }
                }     
            }

            if(!string.IsNullOrEmpty(txtNULLDefault.Text))
            {
                SQLScript.Add(Environment.NewLine);
                SQLScript.Add(SQLPatterns.UpdateFieldData.Replace(SQLPatterns.TableKey, TableObject.Name).Replace(SQLPatterns.ColumnKey, FieldObject.Name).Replace(SQLPatterns.ValueKey, txtNULLDefault.Text));
                SQLScript.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");
            }

            if (IsNUllChanged && (tabControlFieldTypes.SelectedTab == tabPageFieldType)) // && (TableObject.IsNotNull(FieldObject.Name) != cbNotNull.Checked))
            {
                // alter table tartikel alter datum set not null;   
                SQLScript.Add(Environment.NewLine);
                string cmd = (FieldObject.Domain.NotNull)
                    ? SQLPatterns.AlterTableFieldSetNotNull.Replace(SQLPatterns.TableKey, TableObject.Name).Replace(SQLPatterns.ColumnKey, FieldObject.Name)
                    : SQLPatterns.AlterTableFieldSetNull.Replace(SQLPatterns.TableKey, TableObject.Name).Replace(SQLPatterns.ColumnKey, FieldObject.Name);

                SQLScript.Add(cmd);
                SQLScript.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");
            }

            //  ALTER TABLE EMPLOYEE ADD PRIMARY KEY(SSN)
            if (PrimaryKeyChanged)                
            {
                if(FieldObject.IsPrimary)
                {
                    SQLScript.Add(Environment.NewLine);
                    string cmd = SQLPatterns.AlterTableAddPK.Replace(SQLPatterns.TableKey,TableObject.Name).Replace(SQLPatterns.ColumnKey,FieldObject.Name).Replace(SQLPatterns.PrimaryKey,FieldObject.PK_ConstraintName);                                
                    SQLScript.Add(cmd);                                    
                    SQLScript.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");
                
                }
                else if (!string.IsNullOrEmpty(FieldObject.PK_ConstraintName))
                {
                    SQLScript.Add(Environment.NewLine);
                    string cmd = SQLPatterns.AlterTableDropPK.Replace(SQLPatterns.TableKey,TableObject.Name).Replace(SQLPatterns.PrimaryKey,FieldObject.PK_ConstraintName);      
                    SQLScript.Add(cmd);                                    
                    SQLScript.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");
                }
            }

            
            if(PositionChanged)
            {
                string sql = SQLPatterns.PositionSchablone.Replace(SQLPatterns.TableKey,TableObject.Name).Replace(SQLPatterns.ColumnKey,FieldObject.Name).Replace(SQLPatterns.PositionKey,$@"{FieldObject.Position}");
                
                SQLScript.Add(Environment.NewLine);
                SQLScript.Add(sql);
                SQLScript.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");
            }
            
            if (DefaultChanged)
            {
                // alter table tartikel alter id set default 1;                
                string cmd = (txtDefault.Text.Length > 0) 
                    ? $@"{SQLPatterns.AlterTableSetDefault.Replace(SQLPatterns.TableKey,TableObject.Name).Replace(SQLPatterns.ColumnKey,FieldObject.Name).Replace(SQLPatterns.DefaultKey,txtDefault.Text)}" 
                    : $@"{SQLPatterns.AlterTableDropDefault.Replace(SQLPatterns.TableKey,TableObject.Name).Replace(SQLPatterns.ColumnKey,FieldObject.Name)}";

                SQLScript.Add(Environment.NewLine);
                SQLScript.Add(cmd);
                SQLScript.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");
            }

            if((DescriptionChanged)&&(fctDescription.Text != FieldObject.Description))
            {               
                SQLScript.Add(Environment.NewLine);
                SQLScript.Add($@"COMMENT ON COLUMN {TableObject.Name}.{txtFieldName.Text.Trim()} IS '{fctDescription.Text}';");
                SQLScript.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");
            }
            SQLToUI();
        }

        public void MakeNotNullAlter(bool isPrimary)
        {
            // ALTER TABLE TADRESSEN ALTER POSTFACH TO POSTFACHX
            // COMMENT ON COLUMN TADRESSEN.POSTFACHX IS '123'

            // ALTER TABLE Customer CHANGE Address Addr char(50); feldnamen ändern
            // ALTER TABLE t1 ALTER c_temp TO c1;
            // ALTER TABLE t1 ALTER c1 TYPE char(90);
            fctSQL.BackColor = SystemColors.Info;
            SQLScript.Clear();
            gbCollate.Enabled = false;
            gbNULLDefault.Enabled = true;

           
            if (!string.IsNullOrEmpty(txtNULLDefault.Text))
            {
                SQLScript.Add(Environment.NewLine);
                SQLScript.Add(SQLPatterns.UpdateFieldData.Replace(SQLPatterns.TableKey, TableObject.Name).Replace(SQLPatterns.ColumnKey, FieldObject.Name).Replace(SQLPatterns.ValueKey, txtNULLDefault.Text));
                SQLScript.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");
            }

//            if (IsNUllChanged && (tabControlFieldTypes.SelectedTab == tabPageFieldType)) // && (TableObject.IsNotNull(FieldObject.Name) != cbNotNull.Checked))
            {
                // alter table tartikel alter datum set not null;   
                SQLScript.Add(Environment.NewLine);
                if (!isPrimary)
                {
                    string cmd1 = SQLPatterns.AlterTableFieldSetNull.Replace(SQLPatterns.TableKey, TableObject.Name).Replace(SQLPatterns.ColumnKey, FieldObject.Name);
                    SQLScript.Add(cmd1);
                    SQLScript.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");
                }
                string cmd2 = SQLPatterns.AlterTableFieldSetNotNull.Replace(SQLPatterns.TableKey, TableObject.Name).Replace(SQLPatterns.ColumnKey, FieldObject.Name);                
                SQLScript.Add(cmd2);
                SQLScript.Add($@"{Environment.NewLine}{SQLPatterns.Commit}{Environment.NewLine}");
            }

            


            SQLToUI();
        }

        public List<string> SQLScript = new List<string>();

        public void SQLToUI()
        {
            fctSQL.Clear();
            foreach(string str in SQLScript)
            {
               fctSQL.AppendText($@"{str}");
            }
        }               
        
        public void FillCombos()
        {
            var domains = StaticTreeClass.Instance().GetDomainObjects(_dbReg);
            cbDOMAIN.Items.Clear();
            foreach(DomainClass domain in domains.Values)
            {
              cbDOMAIN.Items.Add(domain);
            }
            cbDOMAIN.Text = "";
            cbFieldTypes.Items.Clear();
            
            DBTypeList dbList = new DBTypeList();
            foreach(DBDataTypes dt in dbList.Values)
            {
                cbFieldTypes.Items.Add(dt);
            }
        }

        public void NewFieldObject()
        {
            FieldObject = new TableFieldClass()
            {
                Name = "NEW_FIELD",
            };
            FieldObject.Domain.Name         = "";
            FieldObject.Domain.Length       = 8;
            FieldObject.Domain.FieldType    = "VARCHAR";
            FieldObject.Domain.CharSet      = _dbReg.CharSet;
            FieldObject.Domain.Collate      = _dbReg.Collation;
            FieldObject.Domain.RawType      = "VARCHAR(8)";
            FieldObject.Domain.Scale        = 8;
            FieldObject.Domain.Precision    = 3;
            FieldObject.Domain.NotNull      = false;
            FieldObject.IsPrimary           = false;
            FieldObject.PK_ConstraintName   = TableObject.primary_constraint?.Name;
            FieldObject.Position            = 0;
            FieldObject.Description         = string.Empty;
            FieldObject.DefaultValue        = string.Empty;
            FieldObject.Domain.Check        = string.Empty;
            FieldObject.Domain.DefaultValue = string.Empty;
            FieldObject.TableName           = TableObject.Name;
        }

        public void EditToData()
        {
            var TempFieldobject = FieldObject;
            FieldObject = new TableFieldClass();
            FieldObject.Name                = txtFieldName.Text.Trim();
            FieldObject.Position            = StaticFunctionsClass.ToIntDef(txtPosition.Text,OrgFieldObject.Position);
            FieldObject.Domain.Precision    = StaticFunctionsClass.ToIntDef(txtPrecisionLength.Text,OrgFieldObject.Domain.Precision);
            FieldObject.Domain.Scale        = StaticFunctionsClass.ToIntDef(txtScale.Text,OrgFieldObject.Domain.Scale);
            FieldObject.Description         = fctDescription.Text;
            FieldObject.IsPrimary           = cbPrimaryKey.Checked;
            FieldObject.PK_ConstraintName   = txtPK.Text;
            FieldObject.Domain.FieldType    = StaticVariablesClass.ConvertRawNameToRawType(cbFieldTypes.Text);

            if(cbBlobType.Text == "TEXT")
            {
                FieldObject.Domain.SubTypeNumber = (int)eBlobSubType.TEXT;
            }
            else if (cbBlobType.Text == "BINARY")
            {
                FieldObject.Domain.SubTypeNumber = (int)eBlobSubType.BINARY;
            }
            else if (cbBlobType.Text == "BLR")
            {
                FieldObject.Domain.SubTypeNumber = (int)eBlobSubType.BLR;
            }
            FieldObject.Domain.SegmentLength = StaticFunctionsClass.ToIntDef(txtBlobSize.Text, 0);
            FieldObject.Domain.CharSet      = cbCharSet.Text.Trim();
            FieldObject.Domain.NotNull      = cbNotNull.Checked;
            FieldObject.Domain.Length       = StaticFunctionsClass.ToIntDef(txtLength.Text,OrgFieldObject.Domain.Length);
            FieldObject.Domain.DefaultValue = txtDefault.Text;
            FieldObject.Domain.Collate      = cbCollate.Text;
            FieldObject.TableName           = TempFieldobject?.TableName;
        }

        public void DataToEdit()
        {

        }
        public void ObjectToEdit(TableFieldClass FieldObject)
        {
            txtFieldName.Text       = FieldObject.Name;
            fctDescription.Text     = FieldObject.Description;
            cbPrimaryKey.Checked    = FieldObject.IsPrimary;
            txtDefault.Text         = FieldObject.Domain.DefaultValue;
            cbNotNull.Checked       = FieldObject.Domain.NotNull;
            txtLength.Text          = FieldObject.Domain.Length.ToString();
            txtScale.Text           = FieldObject.Domain.Scale.ToString();
            txtPrecisionLength.Text = FieldObject.Domain.Precision.ToString();
            txtPK.Text              = string.IsNullOrEmpty(FieldObject.PK_ConstraintName) ? TableObject.primary_constraint?.Name : FieldObject.PK_ConstraintName;
            cbDOMAIN.Text           = FieldObject.Domain.Name;
            cbFieldTypes.Text       = StaticVariablesClass.ConvertRawTypeToRawName(FieldObject.Domain.FieldType);
            if(FieldObject.Domain.FieldType ==  "BLOB")
            {
                if((FieldObject.Domain.SubTypeNumber == (int)eBlobSubType.BLR))
                {
                    cbBlobType.Text = "BLR";
                }
                else if ((FieldObject.Domain.SubTypeNumber == (int)eBlobSubType.TEXT))
                {
                    cbBlobType.Text = "TEXT";
                }
                else
                {
                    cbBlobType.Text = "BINARY";
                }
            }
            fctDescription.Text     = FieldObject.Description;
            cbCharSet.Text          = (FieldObject.Domain.CharSet == null) ? "NONE" : FieldObject.Domain.CharSet;
            cbCollate.Text          = (FieldObject.Domain.Collate == null) ? "NONE" : FieldObject.Domain.Collate;
            txtPosition.Text        = FieldObject.Position.ToString();
            txtBlobSize.Text = FieldObject.Domain.SegmentLength.ToString();
        }

        private void FieldForm_Load(object sender, EventArgs e)
        {
            SetControlSizes();
            FormDesign.SetFormLeft(this);
            DataFilled = false;
            
            if (BearbeitenMode == StateClasses.EditStateClass.eBearbeiten.eInsert)
            {
                dsDependencies.Clear();
            }
            else
            {
                RefreshAll();
            }

            tabControlFieldTypes.SelectedTab = tabPageFieldType;
            SetVisible();
            DataFilled = true;
            MakeSQL();
        }


        public void ShowCaptions()
        {
            lblCaption.Text =  (BearbeitenMode == StateClasses.EditStateClass.eBearbeiten.eInsert) 
                ? (FieldObject != null) ? $"Edit Table Field:{FieldObject.Name}" : "Edit Table Field"         
                : (FieldObject != null) ? $"New Table Field:{FieldObject.Name}"  : "New Table Field"; 
            
            this.Text = DevelopmentClass.Instance().GetDBInfo(_dbReg, "Edit Table Field");
        }

        public int RefreshDependencies()
        {                       
            dsDependencies.Clear();
            dgvDependenciesTo.AutoGenerateColumns = true;

            string cmd_index = SQLStatementsClass.Instance.GetFieldDependencies(_dbReg.Version, TableObject.Name, FieldObject.Name);
            try
            {
                var con = new FbConnection(ConnectionStrings.Instance.MakeConnectionString(_dbReg));
                FbDataAdapter ds = new FbDataAdapter(cmd_index, con);
                ds.Fill(dsDependencies);
                con.Close();
                bsDependencies.DataMember = "Table";
                bsDependencies.DataSource = dsDependencies;

                return dsDependencies.Tables[0].Rows.Count;
            }
            catch (Exception ex)
            {
                NotifiesClass.Instance.AddToERROR($"{StaticFunctionsClass.DateTimeNowStr()}->{Name}->RefreshDependencies->{ex.Message}");
            }
            return 0;
        }

        public void RefreshAll()
        {
            DataFilled = false;
            int rd = RefreshDependencies();
            tabPageDependencies.Text = $@"Dependencies ({rd})";
            DataFilled = true;
        }
                
        private void cbFieldTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((!DataFilled)||(tabControlFieldTypes.SelectedTab != tabPageFieldType)) return;                                     
            SetVisible();
            MakeSQL();
        }

        private void hsCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void txtFieldName_TextChanged(object sender, EventArgs e)
        {
            if (!DataFilled) return;
            MakeSQL();
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            if (!DataFilled || (tabControlFieldTypes.SelectedTab != tabPageFieldType)) return;
            MakeSQL();
        }

        private void cbCharSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DataFilled || (tabControlFieldTypes.SelectedTab != tabPageFieldType)) return;                        
            MakeSQL();            
        }

        private void cbCollate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DataFilled || (tabControlFieldTypes.SelectedTab != tabPageFieldType)) return;                        
            MakeSQL();            
        }

        private void txtPrecisionLength_TextChanged(object sender, EventArgs e)
        {
            if (!DataFilled || (tabControlFieldTypes.SelectedTab != tabPageFieldType)) return;                        
            MakeSQL();            
        }

        private void txtScale_TextChanged(object sender, EventArgs e)
        {
            if (!DataFilled || (tabControlFieldTypes.SelectedTab != tabPageFieldType)) return;                        
            MakeSQL();            
        }
              
        private void hsRefreshDependencies_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void hsSave_Click(object sender, EventArgs e)
        {
            ExecueteSQL();
        }
        private void ExecueteSQL()
        {           
            string _connstr = ConnectionStrings.Instance.MakeConnectionString(_dbReg);
            var _sql = new DBBasicClassLibrary.SQLScriptingClass(_connstr, AppSettingsClass.Instance.SQLVariables.GetNewLine(), AppSettingsClass.Instance.SQLVariables.CommentStart, AppSettingsClass.Instance.SQLVariables.CommentEnd, AppSettingsClass.Instance.SQLVariables.SingleLineComment, "SCRIPT");
            //_sql.ScriptNotify.Register4Info(InfoRaised);
            _sql.ScriptNotify.Register4Error(ErrorRaised);

            var riList =_sql.ExecuteCommands(fctSQL.Lines);
            var riFailure = riList.Find(x=>x.commandDone == false); 
            EditToData();
            if(riFailure == null)
            {
                OrgFieldObject = FieldObject.DeepClone();
                BearbeitenMode = StateClasses.EditStateClass.eBearbeiten.eEdit;
                ObjectToEdit(FieldObject);
                MakeSQL();
            }
            AppStaticFunctionsClass.SendResultNotify(riList, localNotify);
            
            string info = (riFailure==null) 
                ? $@"Fields for {_dbReg.Alias}->{FieldObject.TableName} updated." 
                : $@"Fields for {_dbReg.Alias}->{FieldObject.TableName} not updated !!!{Environment.NewLine}{riFailure.nErrors} errors";
            DbExplorerForm.Instance().DbExlorerNotify.Notify.RaiseInfo(info,StaticVariablesClass.ReloadFields,$@"->Proc:{Name}->ExecueteSQL()");
            _localTableNotify.Notify.RaiseInfo(info, StaticVariablesClass.ReloadFields);
        }

        public void SetControlSizes()
        {
            pnlFormUpper.Height         = AppSizeConstants.UpperFormBandHeight;
            pnlFieldUpper.Height        = AppSizeConstants.UpperFormBandHeight;
            pnlDependenciesUpper.Height = AppSizeConstants.UpperFormBandHeight;
            pnlMessageUpper.Height      = AppSizeConstants.UpperFormBandHeight;
            pnlSQLUpper.Height          = AppSizeConstants.UpperFormBandHeight;
        }

        private void hsClearMessages_Click(object sender, EventArgs e)
        {
            fctMessages.Clear();
            messages_count = 0;
            error_count = 0;
        }

        private void hsEditDomain_Click(object sender, EventArgs e)
        {
            var df = new DomainForm(this.MdiParent, _dbReg, FieldObject.Domain);
            df.Show();
        }
       
        private void cbNotNull_CheckedChanged(object sender, EventArgs e)
        {
            if (!DataFilled) return;            
            
            if((!cbNotNull.Checked)&&(cbPrimaryKey.Checked))
            {
                cbPrimaryKey.Checked = false;
            }
            else
            {
                MakeSQL();
            }
        }

        private void cbPrimaryKey_CheckedChanged(object sender, EventArgs e)
        {
            txtPK.Visible = false;
            if (!DataFilled) return;
            
            if((cbPrimaryKey.Checked)&&(!cbNotNull.Checked))
            {
                cbNotNull.Checked = true;
            }

            if(cbPrimaryKey.Checked)
            {
               txtPK.Visible = true;
               if(string.IsNullOrEmpty(txtPK.Text))
               {
                    txtPK.Text = string.IsNullOrEmpty(FieldObject.PK_ConstraintName) ? $@"PK_{FieldObject.TableName}" : FieldObject.PK_ConstraintName;                    
               }
               MakeSQL();            
            }
        }

        private void hotSpot1_Click(object sender, EventArgs e)
        {
            int n = RefreshDependencies();
            tabPageDependencies.Text = $@"Dependencies ({n})";
        }

        private void hsSelectDefault_Click(object sender, EventArgs e)
        {            
            SelectDefaultForm sd = new SelectDefaultForm(this.MdiParent,_localTableNotify, "SELECT_DEFAULTS", StaticVariablesClass.DefaultVariables);
            sd.Show();
        }

        private void txtDefault_TextChanged(object sender, EventArgs e)
        {
            if(!DataFilled) return;                        
            MakeSQL();            
        }
       
        private void fctDescription_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if (!DataFilled) return;                        
            MakeSQL();            
        }
        
        private void cbDOMAIN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DataFilled || (tabControlFieldTypes.SelectedTab != tabPageDomain)) return;                                                                       
            SetVisible();
            MakeSQL();            
        }

        private void hsNewDomain_Click(object sender, EventArgs e)
        {
            var df = new DomainForm(this.MdiParent, _dbReg, FieldObject.Domain);
            df.SetNew();
            df.Show();
        }

        private void hsSaveSQL_Click(object sender, EventArgs e)
        {
            if(saveSQLFile.ShowDialog() != DialogResult.OK) return;            
               fctSQL.SaveToFile(saveSQLFile.FileName,Encoding.UTF8);       
        }

        private void hsLoadSQL_Click(object sender, EventArgs e)
        {
            if(ofdSQL.ShowDialog() != DialogResult.OK) return;            
            fctSQL.OpenFile(ofdSQL.FileName); 
        }
        
        private void txtBlobSize_TextChanged(object sender, EventArgs e)
        {
            if (!DataFilled || (tabControlFieldTypes.SelectedTab != tabPageFieldType)) return;                        
            MakeSQL(); 
        }

        private void cbBlobType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DataFilled || (tabControlFieldTypes.SelectedTab != tabPageFieldType)) return;
            
            MakeSQL(); 
        }
                
        private void txtPosition_TextChanged(object sender, EventArgs e)
        {
            if (!DataFilled) return;
            MakeSQL(); 
        }

        private void hsOrg_Click(object sender, EventArgs e)
        {
            DataFilled = false;
            FieldObject = OrgFieldObject.DeepClone();
            ObjectToEdit(FieldObject);
            DataFilled = true;
            MakeSQL();
        }

        private void hsNew_Click(object sender, EventArgs e)
        {
            DataFilled = false;
            BearbeitenMode = StateClasses.EditStateClass.eBearbeiten.eInsert;
            NewFieldObject();
            ObjectToEdit(FieldObject);
            DataFilled = true;
            MakeSQL();
        }

        private void txtPK_TextChanged(object sender, EventArgs e)
        {
            if (!DataFilled) return;
            MakeSQL();    
        }
        
        private void txtNULLDefault_TextChanged(object sender, EventArgs e)
        {
            if (!DataFilled) return;
            MakeSQL();
        }

        private void hsGetNullDatasDefaults_Click(object sender, EventArgs e)
        {
            SelectDefaultForm sd = new SelectDefaultForm(this.MdiParent, _localTableNotify, "SELECT_DEFAULTS_NULLDATA", StaticVariablesClass.DefaultVariables);
            sd.Show();
        }

        private void tabControlFieldTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DataFilled) return;
            SetVisible();
            MakeSQL();
        }

        private void hsToggleNotNull_Click(object sender, EventArgs e)
        {
            MakeNotNullAlter(cbPrimaryKey.Checked);
            ExecueteSQL();
        }
    }
}
