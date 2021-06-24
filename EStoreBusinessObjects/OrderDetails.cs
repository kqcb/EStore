namespace EStoreBusinessObjects
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public Item Item { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
    }
}
