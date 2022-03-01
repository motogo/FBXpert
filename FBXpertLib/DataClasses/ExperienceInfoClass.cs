

using LiteDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FBXpertLib
{
    // Basic example
    public class ExperienceInfo
    {
        public int Id { get; set; }

        public DateTime Stamp { get; set; }
        public string KeyCode { get; set; }
        public string Info { get; set; }
        public bool IsActive { get; set; }
    }

    public enum ExperienceInfoInx {Id=0, Stamp=1,KeyCode =2, Info =3, IsActive =4};

    public class ExperienceInfoClass
    {
        public static int SelColInx = 1;
        public static bool SortAsc = true;
        private string schemaName = "ExperienceInfo";
        private string DatabaseLocation = string.Empty;
        private bool asc = true;
        
        public ExperienceInfoClass(string dbLocation)
        {
            DatabaseLocation = dbLocation;
        }
        
        public ExperienceInfoClass()
        {

        }
        private List<ExperienceInfo> GetAll(string keycode)
        {
            var list = new List<ExperienceInfo>();
            using (var db = new LiteDatabase(DatabaseLocation))
            {
                var col = db.GetCollection<ExperienceInfo>(schemaName);
                if (string.IsNullOrEmpty(keycode))
                {
                    foreach (ExperienceInfo _id in col.FindAll())
                    {
                        list.Add(_id);
                    }
                }
                else
                {
                    foreach (ExperienceInfo _id in col.Find(x => x.KeyCode == keycode))
                    {
                        list.Add(_id);
                    }
                }
            }
            return list;
        }

        public List<ExperienceInfo> DisplayPresetData(string keycode)
        {
            return GetAll(keycode);
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

        public void ExperienceInfoRefresh(DataGridView dgv, string keycode)
        {
         
            dgv.DataSource = DisplayPresetData(keycode);
         //   dgv.Columns[0].Visible = false;
        }
        public object GetDynamicSortProperty(object item, string propName)
        {
            //Use reflection to get order type
            return item.GetType().GetProperty(propName).GetValue(item, null);
        }

        public void SwapSortGrid(DataGridView grid, int ColumnIndex)
        {
            List<ExperienceInfo> list = grid.DataSource as List<ExperienceInfo>;
            List<ExperienceInfo> SortedList = list;
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

            List<ExperienceInfo> list = grid.DataSource as List<ExperienceInfo>;
            //List<ExperienceInfo> SortedList = list;
            string cnn = grid.Columns[ColumnIndex].Name;
            string direction = asc ? "Ascending" : "Descending";


            List<ExperienceInfo> SortedList = Sort_List(direction, cnn, list);
            grid.DataSource = null;
            grid.DataSource = SortedList;
            grid.Columns[(int)ExperienceInfoInx.Id].Visible = false;
            grid.Refresh();
        }

        public void SortGrid(DataGridView grid, int ColumnIndex, bool _asc)
        {
            asc = _asc;
            List<ExperienceInfo> list = grid.DataSource as List<ExperienceInfo>;
            //List<ExperienceInfo> SortedList = list;
            string cnn = grid.Columns[ColumnIndex].Name;
            string direction = asc ? "Ascending" : "Descending";


            List<ExperienceInfo> SortedList = Sort_List(direction, cnn, list);
            grid.DataSource = null;
            grid.DataSource = SortedList;
            grid.Columns[(int)ExperienceInfoInx.Id].Visible = false;
            grid.Refresh();
        }

        public int FindCountExperienceInfoEntry(string keycode)
        {
            int count = 0;
            using (var db = new LiteDatabase(DatabaseLocation))
            {
                // Get customer collection
                var ExperienceInfos = db.GetCollection<ExperienceInfo>(schemaName);
                ExperienceInfos.EnsureIndex(x => x.KeyCode);
                ExperienceInfos.EnsureIndex(x => x.Stamp);
               

                var r = ExperienceInfos.Find(x => x.KeyCode == keycode);
                count = r.Count();
            }
            return count;
        }
        public bool DeleteExperienceInfoEntry(int id)
        {
            using (var db = new LiteDatabase(DatabaseLocation))
            {
                // Get customer collection
                var ExperienceInfos = db.GetCollection<ExperienceInfo>(schemaName);
                /*
                ExperienceInfos.EnsureIndex(x => x.DBName);
                ExperienceInfos.EnsureIndex(x => x.SQL);

                var r = ExperienceInfos.Find(x => x.Id == id);
                */
                return ExperienceInfos.Delete(id);
            }
        }
        public ExperienceInfo InsertExperienceInfo(string keycode, string sql)
        {
            // Open database (or create if not exits)
            ExperienceInfo ExperienceInfo = null;
            if (FindCountExperienceInfoEntry(keycode) <= 0)
            {
                using (var db = new LiteDatabase(DatabaseLocation))
                {
                    // Get customer collection
                    var ExperienceInfos = db.GetCollection<ExperienceInfo>(schemaName);

                    // Create your new customer instance
                    ExperienceInfo = new ExperienceInfo
                    {
                        KeyCode = keycode,
                        Stamp = DateTime.Now,
                        Info = sql,
                       
                        IsActive = true
                    };

                    ExperienceInfos.EnsureIndex(x => x.KeyCode);
                    ExperienceInfos.EnsureIndex(x => x.Stamp);

                    ExperienceInfos.Insert(ExperienceInfo);
                    return ExperienceInfo;
                }
            }
            return ExperienceInfo;
        }

        public bool UpdateExperienceInfo(ExperienceInfo data)
        {
            // Open database (or create if not exits)
            
            using (var db = new LiteDatabase(DatabaseLocation))
            {
                var ExperienceInfos = db.GetCollection<ExperienceInfo>(schemaName);
                return ExperienceInfos.Update(data);
            }
        }
    }
}

