using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using EStoreDataAccessLayer.Mapper.Utils;

namespace EStoreDataAccessLayer.Mapper.Models
{
    public class DbSet<T>
    {
        private static SqlConnection _sqlConnection;

        public DbSet(string connString = "EStore-Client")
        {
            _sqlConnection ??= Connection.GetSqlConnection(connString);
        }

        public List<T> Read(string procName)
        {
            try
            {
                _sqlConnection.Open();

                SqlCommand cmd = Connection.GetSqlCommand(procName);
                SqlDataReader dataReader = cmd.ExecuteReader();



                List<T> items = Read(dataReader);


                _sqlConnection.Close();

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

        public List<T> Read()
        {
            return Read($"usp_{typeof(T).Name}_Read");
        }

        public T Read(int id)
        {
            return Read($"usp_{typeof(T).Name}_Read", id);
        }


        public T Read(string procName, int? id)
        {
            T item;
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = Connection.GetSqlCommand( procName);

                cmd.Parameters.AddWithValue($"Id", id);

                SqlDataReader dataReader = cmd.ExecuteReader();

                item = ((List<T>)Read(dataReader))[0];

                return item;

            }
            catch (Exception)
            {
                return default(T);
            }
            finally
            {
                _sqlConnection.Close();
            }

        }

        public List<T> Read(SqlDataReader dataReader)
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

        public int Delete(string procName, int? id)
        {
            try
            {
                _sqlConnection.Open();

                var cmd = Connection.GetSqlCommand(procName);

                cmd.Parameters.AddWithValue($"{typeof(T).Name}Id", id);

                int rez = cmd.ExecuteNonQuery();

                _sqlConnection.Close();

                return rez;
            } catch(Exception)
            {
                return -1;
            }finally
            {
                _sqlConnection.Close();
            }
        }

        public void Update(T item)
        {
            Update($"usp_{typeof(T).Name}_Update", item);
        }

        public void Update(string procName, T item)
        {
            try
            {
                _sqlConnection.Open();
                ObjectProperties objectProperties = new ObjectProperties(typeof(T));
                objectProperties.ActualObject = Convert.ChangeType(item, objectProperties.ObjectType);

                var cmd = Connection.GetSqlCommand(procName);


                objectProperties.ToParametersWithId(cmd.Parameters);

                int rez = cmd.ExecuteNonQuery();
            } catch(Exception)
            {
                
            } finally
            {
                _sqlConnection.Close();
            }
        }
        

        public int Create(string procName, T item)
        {
            try
            {
                _sqlConnection.Open();
                ObjectProperties objectProperties = new ObjectProperties(typeof(T));
                objectProperties.ActualObject = Convert.ChangeType(item, objectProperties.ObjectType);

                var cmd = Connection.GetSqlCommand(procName);

                objectProperties.ToParametersWithId(cmd.Parameters);
                objectProperties.ToOtherParametersWithId(cmd.Parameters);

                cmd.Parameters.RemoveAt("@Id");
              //  cmd.Parameters.AddWithValue("insertBy", 1);



                int rez = cmd.ExecuteNonQuery();
                _sqlConnection.Close();

                return rez;
            }
            catch (Exception e)
            {
                var s = e.Message;
                return 0;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }

        public int Create(T item)
        {
            return Create($"usp_{typeof(T).Name}_Insert", item);
        }

        public static T LoadObject(SqlDataReader data)
        {
            ObjectProperties model = InitialiseObject(data, typeof(T));

            List<ObjectProperties> others = model.GetOtherProperties();

            for (int i = 0; i < others.Count; i++)
            {
                model.InitialiseProp(others[i].ObjectType.Name, InitialiseObject(data, others[i].ObjectType, others[i].ObjectType.Name).ActualObject);
            }

            return (T)(model.ActualObject);
        }


        private static ObjectProperties InitialiseObject(SqlDataReader data, Type type, string subObject = "")
        {
            ObjectProperties model = new ObjectProperties(type);

            List<string> primitiveProps = model.GetPrimitivePropertiesNames();

            
            

            for (int i = 0; i < primitiveProps.Count; i++)
            {
                
              
                try
                {
                    model.InitialiseProp(primitiveProps[i], data[subObject + primitiveProps[i]]);
                }
                catch (IndexOutOfRangeException)
                {

                }
            }

            return model;
        }

    }
}