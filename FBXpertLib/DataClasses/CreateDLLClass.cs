using System;
using System.Collections.Generic;
using System.Text;

namespace FBXpertLib
{
    public static class CreateDLLClass
    {
        // ALTER TABLE TADRESSEN ADD CONSTRAINT FK_TADRESSEN FOREIGN KEY(TPLZ_ID) REFERENCES TPLZ(ID) ON UPDATE CASCADE;


        public static string CreateAlterTabelForeignKeyConstraintDLL(ForeignKeyClass constraint, eCreateMode cmode)
        {
            StringBuilder sb = new StringBuilder();
            // ALTER TABLE TADRESSEN ADD CONSTRAINT FK_TADRESSEN FOREIGN KEY(TPLZ_ID) REFERENCES TPLZ(ID) ON UPDATE CASCADE;
            // ->
            //ALTER TABLE #REPLACE_TABLE ADD CONSTRAINT #REPLACE_CONSTRAINTNAME FOREIGN KEY(#REPLACE_COLUMNS) REFERENCES #REPLACE_REFERENCES_TABLE (#REPLACE_REFERENCES_COLUMNS) ON UPDATE #UPDATE_TYPE;";
            if (constraint != null)
            {
                if ((cmode == eCreateMode.drop) || (cmode == eCreateMode.recreate))
                {
                    sb.Append(CreateDROPTableFKConstraintDLL(constraint));
                    sb.Append($@"{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}");
                }
                if ((cmode == eCreateMode.create) || (cmode == eCreateMode.recreate))
                {
                    string cmd = SQLPatterns.AddForeignKeyConstraintPattern.Replace(SQLPatterns.ConstraintKey, constraint.Name).Replace(SQLPatterns.ColumnKey, MakeConcatedStr(constraint.SourceFields, ",")).Replace(SQLPatterns.TableKey, constraint.SourceTableName);
                    cmd = cmd.Replace(SQLPatterns.ReferenceTableKey, constraint.DestTableName).Replace(SQLPatterns.ReferenceColumnKey, MakeConcatedStr(constraint.DestFields, ","));
                    sb.Append(cmd);
                }
            }
            return sb.ToString();
        }

        public static string CreateAlterIndecesDLL(IndexClass index, eCreateMode cmode)
        {
            StringBuilder sb = new StringBuilder();
            // ALTER TABLE TADRESSEN ADD CONSTRAINT FK_TADRESSEN FOREIGN KEY(TPLZ_ID) REFERENCES TPLZ(ID) ON UPDATE CASCADE;
            // ->
            //ALTER TABLE #REPLACE_TABLE ADD CONSTRAINT #REPLACE_CONSTRAINTNAME FOREIGN KEY(#REPLACE_COLUMNS) REFERENCES #REPLACE_REFERENCES_TABLE (#REPLACE_REFERENCES_COLUMNS) ON UPDATE #UPDATE_TYPE;";
            if (index != null)
            {
                if ((cmode == eCreateMode.drop) || (cmode == eCreateMode.recreate))
                {
                    string cmd = SQLPatterns.DropIndexPattern.Replace(SQLPatterns.IndexKey, index.Name);

                    sb.Append(cmd);
                }
                if ((cmode == eCreateMode.create) || (cmode == eCreateMode.recreate))
                {
                    //"CREATE INDEX #REPLACE_INDEXNAME ON #REPLACE_TABLENAME(#REPLACE_COLUMNS);";
                    string cmd = SQLPatterns.AddIndexPattern.Replace(SQLPatterns.IndexKey, index.Name).Replace(SQLPatterns.TableKey, index.RelationName).Replace(SQLPatterns.ColumnKey, MakeConcatedStr(index.RelationFields, ","));
                    sb.Append(cmd);
                }
            }
            return sb.ToString();
        }


        public static string CreateAlterDomainDLL(DomainClass constraint, eCreateMode cmode)
        {
            StringBuilder sb = new StringBuilder();
            // ALTER TABLE TADRESSEN ADD CONSTRAINT FK_TADRESSEN FOREIGN KEY(TPLZ_ID) REFERENCES TPLZ(ID) ON UPDATE CASCADE;
            // ->
            //ALTER TABLE #REPLACE_TABLE ADD CONSTRAINT #REPLACE_CONSTRAINTNAME FOREIGN KEY(#REPLACE_COLUMNS) REFERENCES #REPLACE_REFERENCES_TABLE (#REPLACE_REFERENCES_COLUMNS) ON UPDATE #UPDATE_TYPE;";
            if (constraint != null)
            {
                if ((cmode == eCreateMode.drop) || (cmode == eCreateMode.recreate))
                {
                    string cmd = SQLPatterns.DropDomainPattern.Replace(SQLPatterns.DomainKey, constraint.Name);
                    sb.Append(cmd);
                    sb.Append($@"{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}");
                }
                if ((cmode == eCreateMode.create) || (cmode == eCreateMode.recreate))
                {
                    // CREATE #DOMAIN_NAME ID AS #DATA_TYPE                    
                    string cmd = SQLPatterns.AddDomainPattern.Replace(SQLPatterns.DomainKey, constraint.Name).Replace(SQLPatterns.DataTypeKey, constraint.RawType);
                    sb.Append(cmd);
                }
            }
            return sb.ToString();
        }

        public static string CreateAlterGeneratorDLL(GeneratorClass generator, eCreateMode cmode)
        {
            var sb = new StringBuilder();
            //CREATE GENERATOR TABRUFE4905_ID;
            //SET GENERATOR TABRUFE4905_ID TO 1;

            if (generator != null)
            {
                if ((cmode == eCreateMode.drop) || (cmode == eCreateMode.recreate))
                {
                    string cmd = SQLPatterns.DropGeneratorPattern.Replace(SQLPatterns.GeneratorKey, generator.Name);
                    sb.Append(cmd);
                    sb.Append($@"{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}");
                }
                if ((cmode == eCreateMode.create) || (cmode == eCreateMode.recreate))
                {
                    string cmd = SQLPatterns.AddGeneratorPattern.Replace(SQLPatterns.GeneratorKey, generator.Name).Replace(SQLPatterns.ValueKey, generator.InitValue.ToString());
                    sb.Append(cmd);
                }
            }
            return sb.ToString();
        }


        public static string CreateAlterTriggerDLL(TriggerClass trigger, eCreateMode cmode)
        {
            var sb = new StringBuilder();
            //CREATE GENERATOR TABRUFE4905_ID;
            //SET GENERATOR TABRUFE4905_ID TO 1;

            if (trigger != null)
            {
                if ((cmode == eCreateMode.drop) || (cmode == eCreateMode.recreate))
                {
                    string cmd = SQLPatterns.DropTriggerPattern.Replace(SQLPatterns.TriggerKey, trigger.Name);
                    sb.Append(cmd);
                    sb.Append($@"{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}");
                }
                if ((cmode == eCreateMode.create) || (cmode == eCreateMode.recreate))
                {
                    string cmd = SQLPatterns.AddTriggerPattern.Replace(SQLPatterns.RelationKey, trigger.RelationName).Replace(SQLPatterns.TriggerKey, trigger.Name).Replace(SQLPatterns.SequenceKey, trigger.Sequence.ToString()).Replace(SQLPatterns.SourceKey, trigger.Source);
                    string activeStr = trigger.Active ? "ACTIVE" : "DEACTIVE";
                    cmd = cmd.Replace(SQLPatterns.ActiveKey, activeStr).Replace(SQLPatterns.SequenceKey, trigger.Sequence.ToString());
                    sb.Append(cmd);
                }
            }
            return sb.ToString();
        }

        public static string CreateAlterTabelPrimaryKeyConstraintDLL(PrimaryKeyClass constraint, eCreateMode cmode)
        {
            var sb = new StringBuilder();
            if (constraint == null) return string.Empty;

            if ((cmode == eCreateMode.drop) || (cmode == eCreateMode.recreate))
            {
                sb.Append(CreateDropPKConstraintDLL(constraint));
                sb.Append($@"{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}");
            }

            if ((cmode == eCreateMode.create) || (cmode == eCreateMode.recreate))
            {
                //ALTER TABLE TADRESSEN ADD CONSTRAINT PK_TADRESSEN PRIMARY KEY(TPLZ_ID);
                //ALTER TABLE #REPLACE_TABLE ADD CONSTRAINT #REPLACE_CONSTRAINT PRIMARY KEY(#REPLACE_COLUMNS);";
                string cmd = SQLPatterns.AlterTableAddPK.Replace(SQLPatterns.PrimaryKey, constraint.Name).Replace(SQLPatterns.ColumnKey, MakeConcatedStr(constraint.FieldNames, ",")).Replace(SQLPatterns.TableKey, constraint.TableName); ;


                sb.Append(cmd);
                cmd = (!(constraint.Sorting == eSort.ASC))
                    ? $@"){Environment.NewLine}USING {constraint.Sorting} INDEX {constraint.IndexName};{Environment.NewLine}"
                    : $@"){Environment.NewLine}USING INDEX {constraint.IndexName};{Environment.NewLine}";
                sb.Append(cmd);
            }

            return sb.ToString();
        }

        public static string MakeConcatedStr(List<string> items, string concatepattern)
        {
            bool first = true;
            var sb = new StringBuilder();
            foreach (string itm in items)
            {
                if (!first)
                {
                    sb.Append(concatepattern);
                }
                sb.Append(itm);
            }
            return sb.ToString();
        }
        public static string MakeConcatedStr(Dictionary<string, string> items, string concatepattern)
        {
            bool first = true;
            var sb = new StringBuilder();
            foreach (string itm in items.Values)
            {
                if (!first)
                {
                    sb.Append(concatepattern);
                }
                sb.Append(itm);
            }
            return sb.ToString();
        }

        public static string MakeConcatedStr(Dictionary<string, FieldClass> items, string concatepattern)
        {
            bool first = true;
            var sb = new StringBuilder();
            foreach (FieldClass itm in items.Values)
            {
                if (!first)
                {
                    sb.Append(concatepattern);
                }
                sb.Append(itm.Name);
            }
            return sb.ToString();
        }

        private static string CreateDropPKConstraintDLL(PrimaryKeyClass constraint)
        {
            var sb = new StringBuilder();
            if (constraint.TableName != null)
            {
                sb.Append($@"ALTER TABLE {constraint.TableName} DROP CONSTRAINT {constraint.Name};{Environment.NewLine}");
                sb.Append($@"{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}");
            }
            return sb.ToString();
        }

        private static string CreateDROPTableFKConstraintDLL(ForeignKeyClass constraint)
        {
            var sb = new StringBuilder();
            if (constraint.SourceTableName != null)
            {
                sb.Append("ALTER TABLE ");
                sb.Append(constraint.SourceTableName);
                sb.Append(" DROP CONSTRAINT " + constraint.Name + ";" + Environment.NewLine);
                sb.Append($@"{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}");
            }
            return sb.ToString();
        }

        private static string CreateDROPDomainDLL(DomainClass constraint)
        {
            var sb = new StringBuilder();
            if (constraint.Name != null)
            {
                sb.Append($@"ALTER TABLE {constraint.Name} DROP CONSTRAINT {constraint.Name};{Environment.NewLine}");
                sb.Append($@"{SQLPatterns.Commit}{Environment.NewLine}{Environment.NewLine}");
            }
            return sb.ToString();
        }

        public static string CreateTabelDLL(TableClass tableObject, eCreateMode cmode)
        {
            //
            //    CREATE TABLE TACT_TANT(
            //    ID TABLE_ID NOT NULL /* TABLE_ID = VARCHAR(64) NOT NULL */,
            //    BEZ VAR10 /* VAR10 = VARCHAR(10) */,
            //    TANTWORT_ID REF_ID /* REF_ID = VARCHAR(64) */,
            //    TACTION_ID REF_ID /* REF_ID = VARCHAR(64) */,
            //    GUELTIG      "SMALLINT" DEFAULT 1 NOT NULL /* "SMALLINT" = SMALLINT */,
            //    STATUS       "SMALLINT" DEFAULT 0 NOT NULL /* "SMALLINT" = SMALLINT */,
            //    TUSERID REF_ID /* REF_ID = VARCHAR(64) */,
            //    STAMP        "TIMESTAMP" DEFAULT CURRENT_TIMESTAMP /* "TIMESTAMP" = TIMESTAMP */
            //    );

            var sb = new StringBuilder();
            if (cmode == eCreateMode.recreate)
                sb.AppendLine($@"RECREATE TABLE {tableObject.Name}");
            else
                sb.AppendLine($@"CREATE TABLE {tableObject.Name}");

            sb.AppendLine("(");
            int fc = 0;
            foreach (TableFieldClass tfc in tableObject.Fields.Values)
            {
                fc++;
                bool systemdomain = false;
                if (tfc.Domain.Name.IndexOf("$") >= 0)
                {
                    systemdomain = true;
                }

                if (systemdomain)
                {
                    string FType = (tfc.Domain.Length > 0) ? $@"{StaticVariablesClass.ConvertRawTypeToRawName(tfc.Domain.FieldType)}({tfc.Domain.Length})" : $@"{StaticVariablesClass.ConvertRawTypeToRawName(tfc.Domain.FieldType)}";
                    sb.Append($@"    {tfc.Name} {FType} ");
                }
                else
                {
                    sb.Append($@"    {tfc.Name} {tfc.Domain.Name}  ");
                }

                if ((systemdomain) || ((tfc.Domain.FieldType != "VARYING") && ((!tableObject.IsPrimary(tfc.Name)) /*tfc.IS_PRIMARY*/)))
                {
                    if (tfc.Domain.FieldType == "VARYING")
                    {
                        if ((tfc.Domain.CharSet != "NONE") && (tfc.Domain.Collate.Length > 0))
                        {
                            sb.Append($@" CHARACTER SET {tfc.Domain.CharSet}");
                        }
                        //Not NULL
                        if (tfc.Domain.NotNull)
                        {
                            sb.Append(" NOT NULL");
                        }
                        if ((tfc.Domain.Collate != "NONE") && (tfc.Domain.Collate.Length > 0))
                        {
                            sb.Append($@" COLLATE {tfc.Domain.CharSet}");
                        }
                    }

                    if (tableObject.IsPrimary(tfc.Name))
                    {
                        sb.Append(" PRIMARY KEY");
                    }
                }

                if (fc < tableObject.Fields.Count)
                {
                    sb.Append(",");
                }

                //

                if (systemdomain)
                {
                    sb.Append($@" /* intern:[{tfc.Domain.FieldType}]   domain:{tfc.Domain.Name} */");
                }
                else
                {
                    sb.Append($@" /* raw:{tfc.Domain.RawType} intern:[{tfc.Domain.FieldType}] */");
                }

                if ((!systemdomain) && ((tfc.Domain.FieldType == "VARYING") || ((tableObject.IsPrimary(tfc.Name)))))
                {
                    sb.Append(" /*");
                    if (tfc.Domain.FieldType == "VARYING")
                    {
                        if ((tfc.Domain.CharSet != "NONE") && (tfc.Domain.Collate.Length > 0))
                        {
                            sb.Append($@" CHARACTER SET {tfc.Domain.CharSet}");
                        }
                        if (tfc.Domain.NotNull)
                        {
                            sb.Append(" NOT NULL");
                        }
                        if ((tfc.Domain.Collate != "NONE") && (tfc.Domain.Collate.Length > 0))
                        {
                            sb.Append($@" COLLATE {tfc.Domain.CharSet}");
                        }
                    }
                    sb.Append(" */");
                }
                sb.Append(Environment.NewLine);
            }
            sb.AppendLine("");
            sb.AppendLine(");");
            return sb.ToString();
        }
    }
}
