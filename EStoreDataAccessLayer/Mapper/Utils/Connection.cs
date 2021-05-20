using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EStoreDataAccessLayer.Mapper.Utils
{
    public static class Connection
    {

        private static SqlConnection _sqlConnection;
        public static SqlConnection GetSqlConnection(string connectionString = "conStringEStore-Client")
        {
            return _sqlConnection ??= new SqlConnection(GetConnectionString(connectionString));
        }

        public static SqlCommand GetSqlCommand(string procName)
        { 
            var command = GetSqlConnection().CreateCommand();
            command.CommandText = procName;
            command.CommandType = CommandType.StoredProcedure;

            return command;
        }

        public static SqlDataReader GetSqlDataReader(SqlCommand sqlCommand)
        {
            try
            {
                GetSqlConnection().Open();
                return sqlCommand.ExecuteReader();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                GetSqlConnection().Close();
            }
        }

        public static SqlDataAdapter GetSqlDataAdapter(string procName)
        { 
            return new (procName, GetSqlConnection());
        }
        
        public static DataTable FillDataTable(string procName)
        {
            
            try
            {
                GetSqlConnection().Open();
                
                var adapter = GetSqlDataAdapter(procName);
                var datatable = new DataTable();
                
                adapter.Fill(datatable);

                return datatable;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                GetSqlConnection().Close();
            }
            
        }

        public static  string GetConnectionString(string connectionString)
        {
            return ConfigurationManager.ConnectionStrings[connectionString].ToString();
        }
    }
}
