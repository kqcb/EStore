using EStoreBusinessObjects;
using EStoreDataAccessLayer.Mapper.Models;

namespace EStoreDataAccessLayer
{
    public class OrderDbSet : DbSet<Order>
    {
         public System.Data.DataTable FilldataTableByUser(int userId)
                {
                    return FillDataTable("usp_Order_Read_By_User", userId);
                }
    }
}