using EStoreBusinessObjects;
using EStoreDataAccessLayer;
using EStoreDataAccessLayer.Mapper.Models;
using EStoreDataAccessLayer.Mapper.Utils;
using System;
using System.Collections.Generic;
using System.Data;

namespace EStoreBusinessLogicLayer
{
    public class OrderDetailsServices : Services<OrderDetails>
    {
       
        public List<OrderDetails> ReadByOrderId(int orderId)
        {
            return ((OrderDetailsDbSet)_dbSet).ReadByOrderId(orderId);
        }
    }
}