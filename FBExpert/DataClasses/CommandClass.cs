using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace FBXpert.DataClasses
{
    class CommandClass
    {
        public void SetCommand(string sql, FbConnection con)
        {
            FbDataAdapter adapter = new FbDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            FbCommandBuilder cb = new FbCommandBuilder(adapter);
            FbCommand cmd = cb.GetUpdateCommand();
            adapter.Update(ds);
        }


    }
}
