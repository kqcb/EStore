
using EStoreBusinessObjects;

namespace EStoreBusinessLogicLayer
{
    public class EStoreContext 
    {

        public static CityServices Cities { get; set; } = new();
        public static BrandServices Brands { get; set; }=  new();
        public static CategoryServices Categories { get; set; } = new();
        public static UserServices Users { get; set; } = new UserServices();
        public static ItemServices Items { get; set; } = new();
        public static OrderServices Orders { get; set; } = new();
        public OrderDetailsServices OrderDetails { get; set; } = new();
        public RoleServices RoleServices { get; set; } = new();



    }
}
