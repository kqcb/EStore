using System.Collections.Generic;

namespace EStore_BusinessObjects
{
    class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public string Description { get; set; }
        public List<Category> Categories { get; set; }
        public bool IsActive { get; set; }
    }
}
