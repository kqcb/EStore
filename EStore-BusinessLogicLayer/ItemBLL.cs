using EStore_DataAccessLayer;
using System.Data;

namespace EStore_BLL
{
    public class ItemBLL
    {
        ItemAccess itemDAL;

        public ItemBLL()
        {
            itemDAL = new ItemAccess();
        }

        public DataTable GetAllItems()
        {
            return itemDAL.GetAllItems();
        }
    }
}
