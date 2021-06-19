using System.Collections.Generic;

namespace EStoreBusinessObjects
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
        public Brand Brand { get; set; }
        public List<Category> Categories { get; set; }
        public bool IsActive { get; set; }
    }
}
