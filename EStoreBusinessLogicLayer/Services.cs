using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;
using EStoreDataAccessLayer.Mapper.Models;
using EStoreDataAccessLayer.Mapper.Utils;

namespace EStoreBusinessLogicLayer
{
    public class Services<T>
    {
        public readonly object _dbSet;


        public Services()
        {
            _dbSet = Common.GetDbSet(typeof(T).Name);
        }
        
        public int Create(T item)
        {
            
            
            return (int) Common.InvokeMethod(_dbSet, "Create", item);
            

        }

        public List<T> Read()
        {
            return (List<T>)Common.InvokeMethod(_dbSet, "Read", null);
        }

        public T Read(int id)
        {
            return (T) Common.InvokeMethod(_dbSet, "Read", id);
        }

        public void Delete(int id)
        {
            Common.InvokeMethod(_dbSet, "Delete", id);
        }

        public void Update(int id)
        {
            Common.InvokeMethod(_dbSet, "Update", id);
        }

        public DataTable ToDataTable()
        {
            return (DataTable)Common.InvokeMethod(_dbSet, "ToDataTable", null);
        }
     
        
        
        
 
    }
}