using System;
using EStoreBusinessObjects;
using EStoreDataAccessLayer.Mapper.Models;
using EStoreDataAccessLayer.Mapper.Utils;

namespace EStoreDataAccessLayer
{
    public class UserDbSet : DbSet<User>
    {
         public User Read(string email, string password)
                {
                    try
                    {
                        Connection.GetSqlConnection().Open();
        
                        var cmd = Connection.GetSqlCommand("usp_User_Read_By_Email_Password");
        
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("password", password);
        
                        var reader = cmd.ExecuteReader();
        
        
                        while (reader.Read())
                        {
        
                            return LoadObject(reader);
                        }
        
                        return null;
                    } catch(Exception e)
                    {
                        return null;
                    } finally
                    {
                        Connection.GetSqlConnection().Close();
                    }
                }
    }
}