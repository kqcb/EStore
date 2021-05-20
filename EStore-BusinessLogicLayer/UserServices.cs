
using System;
using EStore_BusinessObjects;
using EStore_DataAccessLayer.Mapper.Models;
using EStore_DataAccessLayer.Mapper.Utils;


namespace EStore_BusinessLogicLayer
{
    public class UserServices : DbSet<User>
    {



        public User Read(string userName, string password)
        {

            try
            {
                Connection.GetSqlConnection().Open();
                var command = Connection.GetSqlCommand("usp_User_Read_By_Email_Password");
                

                command.Parameters.AddWithValue("email", userName);
                command.Parameters.AddWithValue("password", password);

                var reader = command.ExecuteReader();

                return LoadObjects(reader)[0];

            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                
                Connection.GetSqlConnection().Close();
                
            }


            
        }
    }
}
