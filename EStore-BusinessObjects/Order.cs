using System;
using System.Collections.Generic;

namespace EStore_BusinessObjects
{
    class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsPaid { get; set; }
        public City City { get; set; }
        public string Street { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
    }
}
