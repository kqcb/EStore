using EStoreBusinessObjects;
using EStoreDataAccessLayer.Mapper.Models;

namespace EStoreDataAccessLayer
{
    public class EStoreDbSetContext
    {
        public static DbSet<Brand> Brands { get; set; }
        public static DbSet<Item> Items { get; set; }
        public static DbSet<City> Cities { get; set; }
        public static DbSet<OrderDetails> OrderDetails { get; set; }
        public static DbSet<Order> Orders { get; set; }
        public static DbSet<User> Users { get; set; }
        public static DbSet<Role> Roles { get; set; }
    }
}