using EStoreBusinessObjects;
using EStoreDataAccessLayer.Mapper.Models;
using EStoreDataAccessLayer.Mapper.Utils;

namespace EStoreBusinessLogicLayer
{
    public class OrderServices : DbSet<Order>
    {
        public System.Data.DataTable FilldataTableByUser(int userId)
        {
            return FillDataTable("usp_Order_Read_By_User", userId);
        }
    }
}
