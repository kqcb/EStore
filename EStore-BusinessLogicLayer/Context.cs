using EStore_BusinessObjects;

namespace EStore_BusinessLogicLayer
{
    public static class Context
    {
        public static CityServices Cities { get; set; } = new();
        public static BrandServices Brands { get; set; } = new();
        public static CategoryServices Categories { get; set; } = new();
        public static ItemServices Items { get; set; } = new();
        public static OrderServices Orders { get; set; } = new();
        public static UserServices Users { get; set; } = new();
        public static OrderDetails OrderDetails { get; set; } = new();
    }
}