using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore_BO
{
    class OrderDetails
    {
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
    }
}
