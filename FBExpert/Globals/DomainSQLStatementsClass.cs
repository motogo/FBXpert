﻿using FBXpert.DataClasses;
using System;
using System.Collections.Generic;

namespace FBXpert.SQLStatements
{

    public class DomainSQLStatementsClass : SQLStatementsBase
    {


        private DomainSQLStatementsClass()
        {

        }

        private static readonly Lazy<DomainSQLStatementsClass> lazy = new Lazy<DomainSQLStatementsClass>(() => new DomainSQLStatementsClass());
        public static DomainSQLStatementsClass Instance
        {
            get
            {
                return lazy.Value;
            }

        }



        public string RefreshNonSystemDomains()
        {
            return RefreshNonSystemDomains(Version);
        }
        
        public string RefreshNonSystemDomains(eDBVersion version)
        {
            string cmd = string.Empty;

            string cmd0 = "SELECT RDB$FIELDS.RDB$FIELD_NAME,RDB$FIELDS.RDB$CHARACTER_LENGTH,RDB$FIELDS.RDB$FIELD_TYPE,RDB$TYPES.rdb$type_name,RDB$CHARACTER_SETS.RDB$CHARACTER_SET_NAME,RDB$COLLATIONS.RDB$COLLATION_NAME,RDB$FIELDS.RDB$DEFAULT_SOURCE,RDB$FIELDS.RDB$DESCRIPTION FROM RDB$FIELDS";                                    
            string cmd1 = "LEFT JOIN RDB$TYPES ON RDB$TYPES.RDB$TYPE = RDB$FIELDS.RDB$FIELD_TYPE";
            string cmd7 = "LEFT JOIN RDB$CHARACTER_SETS ON RDB$FIELDS.RDB$CHARACTER_SET_ID = RDB$CHARACTER_SETS.RDB$CHARACTER_SET_ID";
            string cmd8 = "LEFT JOIN RDB$COLLATIONS ON RDB$FIELDS.RDB$COLLATION_ID = RDB$COLLATIONS.RDB$COLLATION_ID  AND RDB$CHARACTER_SETS.RDB$CHARACTER_SET_ID = RDB$COLLATIONS.RDB$CHARACTER_SET_ID";
            string wherestr = "WHERE RDB$TYPES.RDB$FIELD_NAME = 'RDB$FIELD_TYPE' AND RDB$FIELDS.RDB$FIELD_NAME NOT LIKE '%$%'";
                       
            cmd = cmd0 + " " + cmd1 + " " + cmd7 + " " + cmd8 + " " + wherestr + ";";

            return cmd;
        }
        

        public string RefreshSystemDomains(eDBVersion version)
        {
            string cmd = string.Empty;

            string cmd0 = "SELECT RDB$FIELDS.RDB$FIELD_NAME,RDB$FIELDS.RDB$CHARACTER_LENGTH,RDB$FIELDS.RDB$FIELD_TYPE,RDB$TYPES.rdb$type_name,RDB$CHARACTER_SETS.RDB$CHARACTER_SET_NAME,RDB$COLLATIONS.RDB$COLLATION_NAME FROM RDB$FIELDS";
            string cmd1 = "LEFT JOIN RDB$TYPES ON RDB$TYPES.RDB$TYPE = RDB$FIELDS.RDB$FIELD_TYPE";
            string cmd7 = "LEFT JOIN RDB$CHARACTER_SETS ON RDB$FIELDS.RDB$CHARACTER_SET_ID = RDB$CHARACTER_SETS.RDB$CHARACTER_SET_ID";
            string cmd8 = "LEFT JOIN RDB$COLLATIONS ON RDB$FIELDS.RDB$COLLATION_ID = RDB$COLLATIONS.RDB$COLLATION_ID  AND RDB$CHARACTER_SETS.RDB$CHARACTER_SET_ID = RDB$COLLATIONS.RDB$CHARACTER_SET_ID";
            string wherestr = "WHERE RDB$TYPES.RDB$FIELD_NAME = 'RDB$FIELD_TYPE' AND RDB$FIELDS.RDB$FIELD_NAME LIKE '%$%'";
            // string orderstr = "ORDER BY RDB$RELATIONS.RDB$RELATION_NAME";
            //string cmd = cmd0 + " " + wherestr + " " + orderstr + ";";
            cmd = cmd0 + " " + cmd1 + " " + cmd7 + " " + cmd8 + " " + wherestr + ";";

            return cmd;
        }

    }
}
