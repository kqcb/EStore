using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore_DataAccessLayer
{
    public class ItemAccess
    {
        public DataTable GetAllItems()
        {
            try
            {
                using (DatabaseConn.Connection = new SqlConnection(DatabaseConn.ConnectionString))
                {
                    DatabaseConn.DataAdapter = new SqlDataAdapter("usp_GetAllItems", DatabaseConn.Connection);
                    DataTable dTable = new DataTable();
                    DatabaseConn.DataAdapter.Fill(dTable);

                    return dTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
