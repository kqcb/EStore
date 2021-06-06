using EStoreBusinessObjects;
using EStoreDataAccessLayer;
using EStoreDataAccessLayer.Mapper.Models;
using EStoreDataAccessLayer.Mapper.Utils;
using System;

namespace EStoreBusinessLogicLayer
{
    public class UserServices : Services<User>
    {
        public User Read(string email, string password)
        {
            return ((UserDbSet)_dbSet).Read(email, password);
        }
    } 
}
