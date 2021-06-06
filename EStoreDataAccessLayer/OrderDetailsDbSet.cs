using System;
using System.Collections.Generic;
using System.Data;
using EStoreBusinessObjects;
using EStoreDataAccessLayer.Mapper.Models;
using EStoreDataAccessLayer.Mapper.Utils;

namespace EStoreDataAccessLayer
{
    public class OrderDetailsDbSet : DbSet<OrderDetails>
    {
        public List<OrderDetails> ReadByOrderId(int orderId)
        {
            try
            {
                Connection.GetSqlConnection().Open();

                var cmd = Connection.GetSqlCommand("usp_OrderDetails_Read_By_Order_Id");

                cmd.Parameters.AddWithValue("id", orderId);

                var reader = cmd.ExecuteReader();


                return LoadObjects(reader);
            } catch(Exception)
            {
                return null;
            }finally
            {
                Connection.GetSqlConnection().Close();
            }
        }
        public DataTable FillDataTableByOrderId(int orderId)
        {
            return ToDataTable("usp_OrderDetails_Read_By_Order_Id", orderId);
        }
    }
}