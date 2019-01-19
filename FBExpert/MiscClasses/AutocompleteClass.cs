using FastColoredTextBoxNS;
using FBExpert;
using FBExpert.DataClasses;
using System.Collections.Generic;
using FBXpert.Globals;

namespace FBXpert.MiscClasses
{
    class AutocompleteClass
    {
        private AutocompleteMenu _popupMenu;
        private FastColoredTextBox _txtBox;
        private DBRegistrationClass _dbReg;
        public AutocompleteClass(FastColoredTextBox txt, DBRegistrationClass dbReg)
        {
            _txtBox = txt;
            _dbReg = dbReg;
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
            var actTable = StaticTreeClass.GetTableObjectFromName(_dbReg, table);            
            foreach (var tcf in actTable.Fields.Values)
            {
                words.Add(tcf.Name);
            }                
            return words.ToArray();
        }

        public string[] DatabaseViewFields(string view)
        {
            var words = new List<string>();
            var actViewFields = StaticTreeClass.GetViewFieldObjects(_dbReg, view);
            foreach (var tcf in actViewFields.Values)
            {
                words.Add(tcf.Name);
            }
            return words.ToArray();
        }

        public string[] DatabaseTableFields()
        {            
            var actTables = StaticTreeClass.GetAllTableObjects(_dbReg);
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
            var actViews = StaticTreeClass.GetViewObjects(_dbReg);
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
            var actTables = StaticTreeClass.GetAllTableObjects(_dbReg);
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
            var actTables = StaticTreeClass.GetSystemTableObjects(_dbReg);
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
            var actSystemTables = StaticTreeClass.GetSystemTableObjects(_dbReg);
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
            var actViews = StaticTreeClass.GetViewObjects(_dbReg);
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

        public void RefreshAutocompleteForDatabase()
        {
            //create autocomplete popup menu

            var actTables = StaticTreeClass.GetAllTableObjects(_dbReg);
            var actSystemTables = StaticTreeClass.GetSystemTableObjects(_dbReg);
            var actViews = StaticTreeClass.GetViewObjects(_dbReg);

            _popupMenu = new AutocompleteMenu(_txtBox)
            {
                MinFragmentLength = 1
            };

            var words = new List<string>();
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

        public void RefreshAutocompleteForTable(string tablename)
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

        public void RefreshAutocompleteForView(string viewname)
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
