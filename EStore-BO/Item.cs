using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore_BO
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
