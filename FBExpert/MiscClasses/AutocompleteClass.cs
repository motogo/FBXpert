using FastColoredTextBoxNS;
using FBExpert;
using FBExpert.DataClasses;
using System.Collections.Generic;
using FBXpert.Globals;

namespace FBXpert.MiscClasses
{
    public class AutocompleteClass
    {
        private AutocompleteMenu _popupMenu;
        private FastColoredTextBox _txtBox;
        private DBRegistrationClass _dbReg;
        public AutocompleteClass(FastColoredTextBox txt, DBRegistrationClass dbReg)
        {
            _txtBox = txt;
            _dbReg = dbReg;
        }

        public AutocompleteClass(DBRegistrationClass dbReg)
        {            
            _dbReg = dbReg;
        }

        public void SetTextObject(FastColoredTextBox txt)
        {
            _txtBox = txt;
        }

        public void Show()
        {
            _popupMenu.Show(false);
        }

        public string[] SqlCommands()
        {
            var words = new List<string>
            {
                "SELECT ",
                "SELECT FROM ",
                "SELECT * FROM ",
                "SELECT FIRST ",
                "SELECT SKIP ",
                "MIST ",
                "FROM ",
                "LEFT ",
                "RIGHT ",
                "OUTER ",
                "NATURAL ",
                "WHEN ",
                "BEGIN ",
                "END ",
                "INTO ",
                "DECLARE ",
                "CURSOR ",
                "RETURNS ",
                "JOIN ",
                "NATURAL JOIN ",
                "LEFT JOIN ",
                "LEFT OUTER JOIN ",
                "RIGHT JOIN ",
                "RIGHT OUTER JOIN ",
                "DECLARE VARIABLE ",
                "ELSE IF ",
                "CONSTRAINT ",
                "ADD CONSTRAINT ",
                "AS SELECT ",
                "WHERE ",
                "IF ",
                "THEN ",
                "ELSE ",
                "WHEN ",
                "ORDER ",
                "ORDER BY ",
                "UPDATE ",
                "INSERT ",
                "INSERT INTO ",
                "CREATE PROCEDURE ",
                "CREATE TABLE ",
                "CREATE VIEW ",
                "RECREATE VIEW ",
                "CREATE TABLE ",
                "ALTER TABLE ",
                "CREATE GLOBAL TEMPORARY TABLE ",
                "RECREATE TABLE",
                "CREATE OR ALTER VIEW ",
                "EXECUTE PROCEDURE ",
                "DELETE FROM ",
                "FOR SELECT ",
                "CASE ",
                "SET TERM ^ ; ",
                "SET TERM ; ^ "
            };
            return words.ToArray();
        }

        public string[] TableSqlCommands()
        {
            var words = new List<string> {"CREATE TABLE ", "RECREATE TABLE ", "CREATE GLOBAL TEMPORARY TABLE"};
            return words.ToArray();
        }

        public string[] TriggerSqlCommands()
        {
            var words = new List<string>
            {
                "CREATE TRIGGER ",
                "CREATE OR ALTER TRIGGER ",
                "RECREATE TRIGGER ",
                "ALTER TRIGGER ",
                "AS ",
                "BEGIN ",
                "AS BEGIN ",
                "END ",
                "RETURNS ",
                "DROP TRIGGER "
            };
            return words.ToArray();
        }

        public string[] FunctionSqlCommands()
        {
            var words = new List<string>
            {
                "CREATE FUNCTION ",
                "CREATE OR ALTER FUNCTION ",
                "RECREATE FUNCTION ",
                "ALTER FUNCTION ",
                "AS ",
                "BEGIN ",
                "AS BEGIN ",
                "END ",
                "RETURNS ",
                "DROP FUNCTION "
            };
            return words.ToArray();
        }

        public string[] ProcedureSqlCommands()
        {
            var words = new List<string>
            {
                "CREATE PROCEDURE ",
                "CREATE OR ALTER PROCEDURE ",
                "RECREATE PROCEDURE ",
                "ALTER PROCEDURE ",
                "AS ",
                "BEGIN ",
                "AS BEGIN ",
                "END ",
                "RETURNS ",
                "DROP PROCEDURE "
            };


            return words.ToArray();
        }
        public string[] ViewSqlCommands()
        {
            var words = new List<string> {"CREATE VIEW ", "CREATE OR ALTER VIEW "};
            return words.ToArray();
        }

        public string[] DatabaseTableFields(string table)
        {
            var words = new List<string>();
            var actTable = StaticTreeClass.Instance().GetTableObjectFromName(_dbReg, table);            
            foreach (var tcf in actTable.Fields.Values)
            {
                words.Add(tcf.Name);
            }                
            return words.ToArray();
        }

        public string[] DatabaseViewFields(string view)
        {
            var words = new List<string>();
            var actViewFields = StaticTreeClass.Instance().GetViewFieldObjects(_dbReg, view);
            foreach (var tcf in actViewFields.Values)
            {
                words.Add(tcf.Name);
            }
            return words.ToArray();
        }

        public string[] DatabaseTableFields()
        {            
            var actTables = StaticTreeClass.Instance().GetAllTableObjects(_dbReg);
            return (DatabaseTableFields(actTables));
        }
        public string[] DatabaseTableFields(Dictionary<string,TableClass> actTables)
        {
            var words = new List<string>();           
            foreach (var obj in actTables.Values)
            {                
                foreach (var tcf in obj.Fields.Values)
                {
                    words.Add($@"{obj.Name}.{tcf.Name}");
                }
            }
            return words.ToArray();
        }

        public string[] DatabaseViewFields()
        {
            var actViews = StaticTreeClass.Instance().GetViewObjects(_dbReg);
            return DatabaseViewFields(actViews);
        }

        public string[] DatabaseViewFields(Dictionary<string,ViewClass> actViews)
        {
            var words = new List<string>();
            foreach (var obj in actViews.Values)
            {                
                foreach (ViewFieldClass tcf in obj.Fields.Values)
                {
                    words.Add($@"{obj.Name}.{tcf.Name}");
                }
            }
            return words.ToArray();
        }
        
        public string[] DatabaseTables()
        {           
            var actTables = StaticTreeClass.Instance().GetAllTableObjects(_dbReg);
            return DatabaseTables(actTables);
        }

        public string[] DatabaseTables(Dictionary<string,TableClass> actTables)
        {
            var words = new List<string>();
           
            foreach (TableClass obj in actTables.Values)
            {
                words.Add(obj.Name);
            }
            return words.ToArray();
        }

        public string[] DatabaseSystemTables()
        {           
            var actTables = StaticTreeClass.Instance().GetSystemTableObjects(_dbReg);
            return DatabaseSystemTables(actTables);
        }

        public string[] DatabaseSystemTables(Dictionary<string,SystemTableClass> actTables)
        {
            var words = new List<string>();
            
            foreach (TableClass obj in actTables.Values)
            {
                words.Add(obj.Name);
            }
            return words.ToArray();
        }

        public string[] DatabaseSystemTableFields()
        {
            var actSystemTables = StaticTreeClass.Instance().GetSystemTableObjects(_dbReg);
            return DatabaseSystemTableFields(actSystemTables);
        }

        public string[] DatabaseSystemTableFields(Dictionary<string,SystemTableClass> actSystemTables)
        {
            var words = new List<string>();
            foreach (var obj in actSystemTables.Values)
            {                
                foreach (var tcf in obj.Fields.Values)
                {
                    words.Add($@"{obj.Name}.{tcf.Name}");
                }
            }
            return words.ToArray();
        }
        public string[] DatabaseViews()
        {            
            var actViews = StaticTreeClass.Instance().GetViewObjects(_dbReg);
            return DatabaseViews(actViews);
        }

        public string[] DatabaseViews(Dictionary<string,ViewClass> actViews)
        {
            var words = new List<string>();            
            foreach (var obj in actViews.Values)
            {
                words.Add(obj.Name);
            }
            return words.ToArray();
        }
        public void RefreshAutocompleteWords()
        {
            words = new List<string>();
            words.AddRange(SqlCommands());
            words.AddRange(DatabaseTables(actTables));
            words.AddRange(DatabaseViews(actViews));
            words.AddRange(DatabaseSystemTables(actSystemTables));

            if(actTables != null) words.AddRange(DatabaseTableFields(actTables));
            if(actViews != null) words.AddRange(DatabaseViewFields(actViews));
            if(actSystemTables != null) words.AddRange(DatabaseSystemTableFields(actSystemTables));
            _popupMenu = new AutocompleteMenu(_txtBox)
            {
                    MinFragmentLength = 1
            };
            _popupMenu.SearchPattern = @"[\w\.$]";
            _popupMenu.Items.SetAutocompleteItems(words);
            _popupMenu.AllowTabKey = true;

            //size of popupmenu
            _popupMenu.Items.MaximumSize = new System.Drawing.Size(400, 500);
            _popupMenu.Items.Width = 400;
        }

        List<string> words = new List<string>();
        Dictionary<string,TableClass> actTables;             
        Dictionary<string,SystemTableClass> actSystemTables;
        Dictionary<string,ViewClass> actViews;

        public void RefreshAutocompleteForDatabase()
        {
            //create autocomplete popup menu

            actTables             = StaticTreeClass.Instance().GetAllTableObjects(_dbReg);
            actSystemTables = StaticTreeClass.Instance().GetSystemTableObjects(_dbReg);
            actViews               = StaticTreeClass.Instance().GetViewObjects(_dbReg);

            _popupMenu = new AutocompleteMenu(_txtBox)
            {
                MinFragmentLength = 1
            };

            words = new List<string>();
            words.AddRange(SqlCommands());
            words.AddRange(DatabaseTables(actTables));
            words.AddRange(DatabaseViews(actViews));
            words.AddRange(DatabaseSystemTables(actSystemTables));

            if(actTables != null) words.AddRange(DatabaseTableFields(actTables));
            if(actViews != null) words.AddRange(DatabaseViewFields(actViews));
            if(actSystemTables != null) words.AddRange(DatabaseSystemTableFields(actSystemTables));
           
            _popupMenu.SearchPattern = @"[\w\.$]";
            _popupMenu.Items.SetAutocompleteItems(words);
            _popupMenu.AllowTabKey = true;

            //size of popupmenu
            _popupMenu.Items.MaximumSize = new System.Drawing.Size(400, 500);
            _popupMenu.Items.Width = 400;
        }
        public void SetTextBox()
        {
            _popupMenu = new AutocompleteMenu(_txtBox)            
            {
                MinFragmentLength = 1
            };
        }


        public void AddProcedureCommands()
        {
            words.AddRange(ProcedureSqlCommands());
        }

        public void RefreshAutocompleteForDatabase(List<TableClass> tables, Dictionary<string,SystemTableClass> systemtables, Dictionary<string,ViewClass> views)
        {
            //create autocomplete popup menu

            if(tables != null)
            {
                actTables = new Dictionary<string, TableClass>();
                foreach(var table in tables)
                {
                    actTables.Add(table.Name,table);
                }
            }
            actSystemTables = systemtables; // StaticTreeClass.Instance().GetSystemTableObjects(_dbReg);
            actViews               = views; // StaticTreeClass.Instance().GetViewObjects(_dbReg);
            
            _popupMenu = new AutocompleteMenu(_txtBox)            
            {
                MinFragmentLength = 1
            };
            
            words = new List<string>();
            words.AddRange(SqlCommands());
            if(actTables != null)  words.AddRange(DatabaseTables(actTables));
            if(actViews != null) words.AddRange(DatabaseViews(actViews));
            if(actSystemTables != null) words.AddRange(DatabaseSystemTables(actSystemTables));

            if(actTables != null) words.AddRange(DatabaseTableFields(actTables));
            if(actViews != null) words.AddRange(DatabaseViewFields(actViews));
            if(actSystemTables != null) words.AddRange(DatabaseSystemTableFields(actSystemTables));
           
            _popupMenu.SearchPattern = @"[\w\.$]";
            _popupMenu.Items.SetAutocompleteItems(words);
            _popupMenu.AllowTabKey = true;

            //size of popupmenu
            _popupMenu.Items.MaximumSize = new System.Drawing.Size(400, 500);
            _popupMenu.Items.Width = 400;
        }

        public void CreateAutocompleteForDatabase(FastColoredTextBox txt, DBRegistrationClass dbReg)
        {
            //create autocomplete popup menu            
            _dbReg = dbReg;
            _txtBox = txt;
            _popupMenu = new AutocompleteMenu(_txtBox)            
            {
                MinFragmentLength = 1
            };
            
            words = new List<string>();
                                   
            _popupMenu.SearchPattern = @"[\w\.$]";
            _popupMenu.Items.SetAutocompleteItems(words);
            _popupMenu.AllowTabKey = true;

            //size of popupmenu
            _popupMenu.Items.MaximumSize = new System.Drawing.Size(400, 500);
            _popupMenu.Items.Width = 400;
        }
        public void CreateAutocompleteForDatabase()
        {
            //create autocomplete popup menu            
            
            _popupMenu = new AutocompleteMenu(_txtBox)            
            {
                MinFragmentLength = 1
            };
            
            words = new List<string>();
                                   
            _popupMenu.SearchPattern = @"[\w\.$]";
            _popupMenu.Items.SetAutocompleteItems(words);
            _popupMenu.AllowTabKey = true;

            //size of popupmenu
            _popupMenu.Items.MaximumSize = new System.Drawing.Size(400, 500);
            _popupMenu.Items.Width = 400;
        }

        public void Activate()
        {
              _popupMenu.Items.SetAutocompleteItems(words);
        }

        public void AddAutocompleteForSQL()
        { 
             words.AddRange(SqlCommands());
        }

        public void AddAutocompleteForSystemtables(Dictionary<string,SystemTableClass> systemtables)
        {           
            if(systemtables != null) words.AddRange(DatabaseSystemTables(systemtables));                      
        }

        public void AddAutocompleteForViews(Dictionary<string,ViewClass> views)
        {                        
            if(views != null)
            {
                words.AddRange(DatabaseViews(views));            
                words.AddRange(DatabaseViewFields(views));
            }            
        }

        public void AddAutocompleteForTables(List<TableClass> tables)
        {            
            if(tables != null)
            {
                actTables = new Dictionary<string, TableClass>();
                foreach(var table in tables)
                {
                    actTables.Add(table.Name,table);
                }
            }
                       
            if(actTables != null) 
            {
                words.AddRange(DatabaseTables(actTables));            
                words.AddRange(DatabaseTableFields(actTables));
            }
                                   
        }
        public void RefreshNewAutocompleteForTable(string tablename)
        {
            //create autocomplete popup menu
          
            _popupMenu = new AutocompleteMenu(_txtBox);
            _popupMenu.MinFragmentLength = 1;

            var words = new List<string>();
            words.AddRange(TableSqlCommands());
            words.AddRange(DatabaseTableFields(tablename));
                            
            _popupMenu.SearchPattern = @"[\w\.$]";
            _popupMenu.Items.SetAutocompleteItems(words);
            _popupMenu.AllowTabKey = true;
            //size of popupmenu
            _popupMenu.Items.MaximumSize = new System.Drawing.Size(400, 500);
            _popupMenu.Items.Width = 400;
        }

        public void AddTables(string tablename)
        {
            TableClass actTable = null;
            actTables.TryGetValue(tablename,out actTable);
            if(actTable != null)
            {
                foreach (var tcf in actTable.Fields.Values)
                {
                    words.Add(tcf.Name);
                }                
            }   
        }

        public void RefreshAutocompleteForTable(string tablename)
        {
            //create autocomplete popup menu
            
            
            _popupMenu = new AutocompleteMenu(_txtBox);
            _popupMenu.MinFragmentLength = 1;

            var words = new List<string>();
            words.AddRange(TableSqlCommands());

            AddTables(tablename);
            
            _popupMenu.SearchPattern = @"[\w\.$]";
            _popupMenu.Items.SetAutocompleteItems(words);
            _popupMenu.AllowTabKey = true;
            //size of popupmenu
            _popupMenu.Items.MaximumSize = new System.Drawing.Size(400, 500);
            _popupMenu.Items.Width = 400;
            
        }

        public void RefreshNewAutocompleteForView(string viewname)
        {
            //create autocomplete popup menu

            _popupMenu = new AutocompleteMenu(_txtBox);
            _popupMenu.MinFragmentLength = 1;

            var words = new List<string>();
            words.AddRange(ViewSqlCommands());
            words.AddRange(DatabaseViewFields(viewname));
            
            _popupMenu.SearchPattern = @"[\w\.$]";
            _popupMenu.Items.SetAutocompleteItems(words);
            _popupMenu.AllowTabKey = true;
            //size of popupmenu
            _popupMenu.Items.MaximumSize = new System.Drawing.Size(400, 500);
            _popupMenu.Items.Width = 400;
        }

        public void RefreshAutocompleteForView(string viewname)
        {
            //create autocomplete popup menu

            _popupMenu = new AutocompleteMenu(_txtBox);
            _popupMenu.MinFragmentLength = 1;

            var words = new List<string>();
            words.AddRange(ViewSqlCommands());

            ViewClass actView = null;
            actViews.TryGetValue(viewname, out actView);
            if(actView != null)
            {
                foreach (var tcf in actView.Fields.Values)
                {
                    words.Add(tcf.Name);
                }
            }
            _popupMenu.SearchPattern = @"[\w\.$]";
            _popupMenu.Items.SetAutocompleteItems(words);
            _popupMenu.AllowTabKey = true;
            //size of popupmenu
            _popupMenu.Items.MaximumSize = new System.Drawing.Size(400, 500);
            _popupMenu.Items.Width = 400;
        }

        public void RefreshAutocompleteForFunction()
        {
            //create autocomplete popup menu

            _popupMenu = new AutocompleteMenu(_txtBox);
            _popupMenu.MinFragmentLength = 1;

            var words = new List<string>();
            words.AddRange(FunctionSqlCommands());
                       
            _popupMenu.SearchPattern = @"[\w\.$]";
            _popupMenu.Items.SetAutocompleteItems(words);
            _popupMenu.AllowTabKey = true;
            //size of popupmenu
            _popupMenu.Items.MaximumSize = new System.Drawing.Size(400, 500);
            _popupMenu.Items.Width = 400;
        }

        public void RefreshAutocompleteForUserDefinedFunction()
        {
            //create autocomplete popup menu

            _popupMenu = new AutocompleteMenu(_txtBox);
            _popupMenu.MinFragmentLength = 1;

            var words = new List<string>();
            words.AddRange(FunctionSqlCommands());
                       
            _popupMenu.SearchPattern = @"[\w\.$]";
            _popupMenu.Items.SetAutocompleteItems(words);
            _popupMenu.AllowTabKey = true;
            //size of popupmenu
            _popupMenu.Items.MaximumSize = new System.Drawing.Size(400, 500);
            _popupMenu.Items.Width = 400;
        }

        public void RefreshAutocompleteForProcedure()
        {
            //create autocomplete popup menu

            _popupMenu = new AutocompleteMenu(_txtBox);
            _popupMenu.MinFragmentLength = 1;

            var words = new List<string>();
            words.AddRange(ProcedureSqlCommands());
            
            _popupMenu.SearchPattern = @"[\w\.$]";
            _popupMenu.Items.SetAutocompleteItems(words);
            _popupMenu.AllowTabKey = true;
            //size of popupmenu
            _popupMenu.Items.MaximumSize = new System.Drawing.Size(400, 500);
            _popupMenu.Items.Width = 400;
        }

        public void RefreshAutocompleteForTriggers()
        {
            //create autocomplete popup menu

            _popupMenu = new AutocompleteMenu(_txtBox);
            _popupMenu.MinFragmentLength = 1;

            var words = new List<string>();
            words.AddRange(TriggerSqlCommands());
            
            _popupMenu.SearchPattern = @"[\w\.$]";
            _popupMenu.Items.SetAutocompleteItems(words);
            _popupMenu.AllowTabKey = true;
            //size of popupmenu
            _popupMenu.Items.MaximumSize = new System.Drawing.Size(400, 500);
            _popupMenu.Items.Width = 400;
        }
    }
}
