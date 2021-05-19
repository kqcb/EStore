using System.Collections.Generic;
using EStore_BusinessObjects;
using EStore_DataAccessLayer.Mapper.Models;

namespace EStore_BusinessLogicLayer
{
    public class OrderDetailsServices : DbSet<OrderDetails>
    {
        public List<OrderDetails> ReadByOrderId(int id)
        {
            return Read("usp_Read_OrderDetails_By_Order_Id", id);
        }
    }
}