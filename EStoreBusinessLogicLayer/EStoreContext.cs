
namespace EStoreBusinessLogicLayer
{
    public class EStoreContext 
    {

        public static CityServices Cities { get; } = new();
        public static BrandServices Brands { get; }=  new();
        public static CategoryServices Categories { get; } = new();
        public static UserServices Users { get; } = new();
        public static ItemServices Items { get; } = new();
        public static OrderServices Orders { get; } = new();
        public static OrderDetailsServices OrderDetails { get; } = new();
        public static RoleServices RoleDbSet { get; set; } = new();



    }
}
