using System.Collections.Generic;
using EStoreBusinessObjects;
using EStoreDataAccessLayer.Mapper.Models;
using EStoreDataAccessLayer.Mapper.Utils;

namespace EStoreDataAccessLayer
{
    public class OrderDbSet : DbSet<Order>
    {
        public List<Order> ReadByUserId(int userId)
        {
            Connection.GetSqlConnection().Open();

            var cmd = Connection.GetSqlCommand("usp_Order_Read_By_UserId");

            cmd.Parameters.AddWithValue("Id", userId);

            return LoadObjects(cmd.ExecuteReader());

        }
         public System.Data.DataTable ToDataTableByUserId(int userId)
         {
            return ToDataTable("usp_Order_Read_By_UserId", userId);
         }   
    }
}