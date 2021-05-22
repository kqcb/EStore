using EStoreBusinessObjects;
using EStoreDataAccessLayer.Mapper.Models;

namespace EStoreBusinessLogicLayer
{
    public class UserServices : DbSet<User>
    {
        public User Read(string email, string password)
        {
            return null;
        }
    }
}
