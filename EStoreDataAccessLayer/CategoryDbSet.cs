using System;
using System.Collections.Generic;
using System.Data;
using EStoreBusinessObjects;
using EStoreDataAccessLayer.Mapper.Models;
using EStoreDataAccessLayer.Mapper.Utils;

namespace EStoreDataAccessLayer
{
    public class CategoryDbSet : DbSet<Category>
    {

        public List<Category> ReadByParentCategoryId(int categoryId)
        {
            try
            {
                Connection.GetSqlConnection().Open();

                var cmd = Connection.GetSqlCommand("usp_Category_Id");

                cmd.Parameters.AddWithValue("Id", categoryId);

                var reader = cmd.ExecuteReader();

                return LoadObjects(reader);

            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Connection.GetSqlConnection().Close();
            }
        }

        public DataTable ToDataTableByParentCategoryId(int categoryId)
        {
            return ToDataTable("usp_Category_Read", categoryId);
        }
        
    }
}