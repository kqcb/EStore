using EStoreBusinessObjects;
using EStoreDataAccessLayer;
using EStoreDataAccessLayer.Mapper.Models;
using EStoreDataAccessLayer.Mapper.Utils;
using System.Collections.Generic;

namespace EStoreBusinessLogicLayer
{
    public class OrderServices : Services<Order>
    {
      
        public List<Order> ReadByUserId(int id)
        {
            return ((OrderDbSet)_dbSet).ReadByUserId(id);
        }
    }
}
