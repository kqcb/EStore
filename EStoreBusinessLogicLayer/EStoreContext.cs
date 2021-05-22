
namespace EStoreBusinessLogicLayer
{
    public class EStoreContext 
    {

        public static CityServices Cities { get; set; }
        public static BrandServices Brands { get; set; }
        public static CategoryServices Categories { get; set; }
        public static UserServices Users { get; set; }
        public static ItemServices Items { get; set; }
        public static OrderServices Orders { get; set; }
       // public OrderDetailsServices OrderDetails { get; set; }
       // public Role Roles { get; set; }



    }
}
