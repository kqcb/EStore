using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Xml.Linq;
using EStore_DataAccessLayer.Mapper.Utils;

namespace EStore_DataAccessLayer.Mapper.Models
{
    public class DbSet<T>
    {
        private SqlConnection _sqlConnection;

        public DbSet(string connString = "EStore-Client")
        {
            _sqlConnection ??= Connection.GetSqlConnection(connString);
        }


        public List<T> Read(string procName)
        {
            _sqlConnection.Close();
            _sqlConnection.Open();

            SqlCommand cmd = Connection.GetSqlCommand(procName);
            SqlDataReader dataReader = Connection.GetSqlDataReader(cmd);

            List<T> items = LoadObjects(dataReader);

            return items;

        }

     
        public List<T> Read()
        {
            return Read($"usp_{typeof(T).Name}_Read");
        }

        public List<T> Read(int id)
        {
            return Read($"usp_{typeof(T).Name}_Read_By_Id", id);
        }

        public List<T> Read(string procName, int id)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = Connection.GetSqlCommand(procName); 

                cmd.Parameters.AddWithValue($"Id", id);

                SqlDataReader dataReader = cmd.ExecuteReader();


                List<T> items = (List<T>)LoadObjects(dataReader);

                if (items.Count < 1)
                {
                    return null;
                }

                return items;

            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }


        public List<T> LoadObjects(SqlDataReader dataReader)
        {
            List<T> items = new List<T>();

            while (dataReader.Read())
            {
                items.Add(LoadObject(dataReader));

            }

            return items;
        }


        public int Delete(int id)
        {
            return Delete($"usp_{typeof(T).Name}_Delete", id);
        }

        public int Delete(string? procName, int? id)
        {
            _sqlConnection.Open();

            var cmd = Connection.GetSqlCommand(procName ?? $"usp_{typeof(T)}_Delete");

            cmd.Parameters.AddWithValue($"{typeof(T).Name}Id", id);

            int rez = cmd.ExecuteNonQuery();

            _sqlConnection.Close();

            return rez;

        }
        
        public void Update(T item)
        {
            Update($"usp_{typeof(T).Name}_Update_", item);
        } 

        public void Update(string? procName, T item)
        {
            ObjectProperties objectProperties = new (typeof(T));
            
            objectProperties.ActualObject = Convert.ChangeType(item, objectProperties.ObjectType);

            var cmd = Connection.GetSqlCommand(procName ?? $"usp_{typeof(T)}_Update");


            objectProperties.ToParametersWithId(cmd.Parameters);

            int rez = cmd.ExecuteNonQuery();
        }
        public int Create(T item)
        {
            return Create($"usp_Create_{typeof(T).Name}", item);
        }
        public int Create(string? procName, T item)
        {
            _sqlConnection.Open();
            ObjectProperties objectProperties = new ObjectProperties(typeof(T));
            objectProperties.ActualObject = Convert.ChangeType(item, objectProperties.ObjectType);

            var cmd = Connection.GetSqlCommand(procName ?? $"usp_{typeof(T)}_Create");

            objectProperties.ToParametersWithId(cmd.Parameters);
            objectProperties.ToOtherParametersWithId(cmd.Parameters);



            var rez = cmd.ExecuteNonQuery();
            _sqlConnection.Close();

            return rez;
        }





        public static T LoadObject(SqlDataReader data)
        {
            ObjectProperties model = InitialiseObject(data, typeof(T));

            List<ObjectProperties> others = model.GetOtherProperties();

            foreach (var objectProperties in others)
            {
                model.InitialiseProp(objectProperties.ObjectType.Name, InitialiseObject(data, objectProperties.ObjectType, objectProperties.ObjectType.Name).ActualObject);
            }

            return (T)(model.ActualObject);
        }


        private static ObjectProperties InitialiseObject(SqlDataReader data, Type type, string subObject = "")
        {
            ObjectProperties model = new ObjectProperties(type);

            List<string> primitiveProps = model.GetPrimitivePropertiesNames();

            

            foreach (var item in primitiveProps)
            {
                try
                {
                    model.InitialiseProp(item, data[subObject + item]);
                }
                catch (IndexOutOfRangeException)
                {

                }
            }

            return model;
        }

    }
}