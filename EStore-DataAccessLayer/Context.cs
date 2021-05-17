using EStore_BusinessObjects;
using EStore_DataAccessLayer.Mapper.Models;

namespace EStore_DataAccessLayer
{
    public class EStoreContext 
    {

        public DbSet<City> Cities { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

     

        
    }
}
