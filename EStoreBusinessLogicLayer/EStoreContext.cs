
namespace EStoreBusinessLogicLayer
{
    public class EStoreContext 
    {

        public CityServices Cities { get; set; }
        public BrandServices Brands { get; set; }
        public CategoryServices Categories { get; set; }
        public UserServices Users { get; set; }
        public ItemServices Items { get; set; }
        public OrderServices Orders { get; set; }
       // public OrderDetailsServices OrderDetails { get; set; }
       // public Role Roles { get; set; }



    }
}
