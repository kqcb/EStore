using System.Data.SqlClient;

namespace EStoreDataAccess.Utils
{
    public class Connection

    {


        public static SqlConnection GetSqlConnection(string name = "SEMSDefault")
        {
            return new SqlConnection(GetConnectionString(name));
        }

        public static string GetConnectionString(string name = "SEMSDefault")
        {
            //ConfigurationManager.ConnectionStrings[""].ConnectionString.ToString();
            return "Data Source=LENOVO-Y700; Database=SEMS; Initial Catalog=SEMS; User ID=sa; Password=hejhej";
        }


        public static SqlCommand GetSqlCommand(SqlConnection conn, string procName)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = procName;

            return cmd;
        }
    }
}
