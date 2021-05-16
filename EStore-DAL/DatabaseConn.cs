using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore_DAL
{
    class DatabaseConn
    {
        public static string conString = ConfigurationManager.ConnectionStrings["conStringEStore-Client"].ToString();
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
    }
}
