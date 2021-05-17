using System.Configuration;
using System.Data.SqlClient;

namespace EStore_DataAccessLayer
{
    class DatabaseConn
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["conStringEStore-Client"].ToString();
        public static SqlConnection Connection;
        public static SqlCommand Command;
        public static SqlDataAdapter DataAdapter;

    }
}
