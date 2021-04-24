using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore_BO
{
    class Order
    {
        public int OrderId { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Paid { get; set; }
        public City City { get; set; }
        public string Street { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
    }
}
