using EStore_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore_BLL
{
    public class ItemBLL
    {
        ItemDAL itemDAL;

        public ItemBLL()
        {
            itemDAL = new ItemDAL();
        }

        public DataTable GetAllItems()
        {
            return itemDAL.GetAllItems();
        }
    }
}
