using System.Configuration;
using System.Data.SqlClient;

namespace EStore_DataAccessLayer
{
    class DatabaseConn
    {
        public static string conString = ConfigurationManager.ConnectionStrings["conStringEStore-Client"].ToString();
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
    }
}
