
using EStoreBusinessObjects;
using EStoreDataAccessLayer;

namespace EStoreBusinessLogicLayer
{
    public class EStoreContext 
    {

        public static CityDbSet Cities { get; set; } = new();
        public static BrandDbSet Brands { get; set; }=  new();
        public static CategoryDbSet Categories { get; set; } = new();
        public static UserDbSet Users { get; set; } = new UserDbSet();
        public static ItemDbSet Items { get; set; } = new();
        public static OrderDbSet Orders { get; set; } = new();
        public static OrderDetailsDbSet OrderDetails { get; set; } = new();
        public static RoleDbSet RoleDbSet { get; set; } = new();



    }
}
