using LiteDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FBXpertLib
{
    // Basic example
    public class History
    {
        public int Id { get; set; }

        public DateTime Stamp { get; set; }
        public string DBName { get; set; }
        public string SQL { get; set; }
        public eSQLHistoryType SuccessType { get; set; }
        public bool IsActive { get; set; }
    }

    public class SQLHistoryClass
    {
        string schemaName = "history";
        string DatabaseName = string.Empty;
        string DatabaseLocation = string.Empty;
        bool asc = true;
        public SQLHistoryClass(string dbName, string dbLocation)
        {
            DatabaseName = dbName.Replace(" ", "_");
            DatabaseLocation = dbLocation;
        }
        private List<History> GetAll(string dbn, bool success, bool failed)
        {
            var list = new List<History>();
            using (var db = new LiteDatabase(DatabaseLocation))
            {
                var col = db.GetCollection<History>(schemaName);
                if (string.IsNullOrEmpty(dbn))
                {
                    if (success && failed)
                    {
                        foreach (History _id in col.FindAll())
                        {
                            list.Add(_id);
                        }
                    }
                    else if (success)
                    {
                        foreach (History _id in col.Find(x => x.SuccessType == eSQLHistoryType.succeeded))
                        {
                            list.Add(_id);
                        }
                    }
                    else if (failed)
                    {
                        foreach (History _id in col.Find(x => x.SuccessType == eSQLHistoryType.failed))
                        {
                            list.Add(_id);
                            //list.Insert(0, _id);
                        }
                    }
                    else
                    {
                        foreach (History _id in col.FindAll())
                        {
                            list.Add(_id);
                        }
                    }
                }
                else
                {
                    if (success && failed)
                    {
                        foreach (History _id in col.Find(x => x.DBName == dbn))
                        {
                            list.Add(_id);
                        }
                    }
                    else if (success)
                    {
                        foreach (History _id in col.Find(x => x.DBName == dbn && x.SuccessType == eSQLHistoryType.succeeded))
                        {
                            list.Add(_id);
                        }
                    }
                    else if (failed)
                    {
                        foreach (History _id in col.Find(x => x.DBName == dbn && x.SuccessType == eSQLHistoryType.failed))
                        {
                            list.Add(_id);
                        }
                    }
                    else
                    {
                        foreach (History _id in col.Find(x => x.DBName == dbn))
                        {
                            list.Add(_id);
                        }
                    }
                }
            }
            return list;
        }

        public List<History> DisplayPresetData(string dbn, bool success, bool failed)
        {
            return GetAll(dbn, success, failed);
        }

        public List<T> Sort_List<T>(string sortDirection, string sortExpression, List<T> data)
        {
            List<T> data_sorted = new List<T>();
            if (sortDirection == "Ascending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) ascending
                               select n).ToList();
            }
            else if (sortDirection == "Descending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) descending
                               select n).ToList();

            }
            return data_sorted;
        }

        public void HistoryRefresh(DataGridView dgv, bool succeeded, bool failed, bool all)
        {
            string dbn = all ? string.Empty : DatabaseName;
            dgv.DataSource = DisplayPresetData(dbn, succeeded, failed);
            dgv.Columns[0].Visible = false;
        }
        public object GetDynamicSortProperty(object item, string propName)
        {
            //Use reflection to get order type
            return item.GetType().GetProperty(propName).GetValue(item, null);
        }

        public void SwapSortGrid(DataGridView grid, int ColumnIndex)
        {
            List<History> list = grid.DataSource as List<History>;
            List<History> SortedList = list;
            string cnn = grid.Columns[ColumnIndex].Name;
            string direction = asc ? "Ascending" : "Descending";
            asc = !asc;

            SortedList = Sort_List(direction, cnn, list);
            grid.DataSource = null;
            grid.DataSource = SortedList;
            grid.Columns[0].Visible = false;
            grid.Refresh();
        }

        public void SortGrid(DataGridView grid, int ColumnIndex)
        {

            List<History> list = grid.DataSource as List<History>;
            List<History> SortedList = list;
            string cnn = grid.Columns[ColumnIndex].Name;
            string direction = asc ? "Ascending" : "Descending";


            SortedList = Sort_List(direction, cnn, list);
            grid.DataSource = null;
            grid.DataSource = SortedList;
            grid.Columns[0].Visible = false;
            grid.Refresh();
        }

        public void SortGrid(DataGridView grid, int ColumnIndex, bool _asc)
        {
            asc = _asc;
            List<History> list = grid.DataSource as List<History>;
            List<History> SortedList = list;
            string cnn = grid.Columns[ColumnIndex].Name;
            string direction = asc ? "Ascending" : "Descending";


            SortedList = Sort_List(direction, cnn, list);
            grid.DataSource = null;
            grid.DataSource = SortedList;
            grid.Columns[0].Visible = false;
            grid.Refresh();
        }

        public int FindCountHistoryEntry(string sql, eSQLHistoryType historyType)
        {
            int count = 0;
            using (var db = new LiteDatabase(DatabaseLocation))
            {
                // Get customer collection
                var historys = db.GetCollection<History>(schemaName);
                historys.EnsureIndex(x => x.DBName);
                historys.EnsureIndex(x => x.Stamp);
                historys.EnsureIndex(x => x.SuccessType);

                var r = historys.Find(x => x.DBName == DatabaseName && x.SQL == sql && x.SuccessType == historyType);
                count = r.Count();
            }
            return count;
        }
        public bool DeleteHistoryEntry(int id)
        {
            using (var db = new LiteDatabase(DatabaseLocation))
            {
                // Get customer collection
                var historys = db.GetCollection<History>(schemaName);
                /*
                historys.EnsureIndex(x => x.DBName);
                historys.EnsureIndex(x => x.SQL);

                var r = historys.Find(x => x.Id == id);
                */
                return historys.Delete(id);
            }
        }
        public bool InsertHistory(string sql, eSQLHistoryType historyType)
        {
            // Open database (or create if not exits)
            if (FindCountHistoryEntry(sql, historyType) <= 0)
            {
                using (var db = new LiteDatabase(DatabaseLocation))
                {
                    // Get customer collection
                    var historys = db.GetCollection<History>(schemaName);

                    // Create your new customer instance
                    var history = new History
                    {
                        DBName = DatabaseName,
                        Stamp = DateTime.Now,
                        SQL = sql,
                        SuccessType = historyType,
                        IsActive = true
                    };

                    historys.EnsureIndex(x => x.DBName);
                    historys.EnsureIndex(x => x.Stamp);
                    historys.EnsureIndex(x => x.SuccessType);

                    // Insert (Id will be auto-incremented)
                    historys.Insert(history);
                    return true;
                }
            }
            return false;
        }
    }
}
