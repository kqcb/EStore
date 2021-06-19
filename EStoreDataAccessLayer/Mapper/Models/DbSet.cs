using System;
using System.Collections.Generic;
using System.Data;
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



                List<T> items = LoadObjects(dataReader);


                _sqlConnection.Close();

                return items;
            }
            catch (Exception e)
            {
                var s = e.Message;
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
            return Read($"usp_{typeof(T).Name}_Read_By_Id", id);
        }


        public T Read(string procName, int? id)
        {
            T item;
            try
            {
                _sqlConnection.Open();
                SqlCommand cmd = Connection.GetSqlCommand( procName);

                cmd.Parameters.AddWithValue($"id", id);

                SqlDataReader dataReader = cmd.ExecuteReader();

                item = ((List<T>)LoadObjects(dataReader))[0];

                return item;

            }
            catch (Exception e)
            {
                return default(T);
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

        public bool Delete(int id)
        {
            return Delete($"usp_{typeof(T).Name}_Delete", id);
        }

        public bool Delete(string procName, int? id)
        {
            try
            {
                _sqlConnection.Open();

                var cmd = Connection.GetSqlCommand(procName);

                cmd.Parameters.AddWithValue($"Id", id);

                int rez = cmd.ExecuteNonQuery();

                _sqlConnection.Close();

                return rez != -1;
            } catch(Exception e)
            {
                return false;
            }finally
            {
                _sqlConnection.Close();
            }
        }

        public bool Update(T item)
        {
           return Update($"usp_{typeof(T).Name}_Update", item);
        }

        public bool Update(string procName, T item)
        {
            try
            {
                _sqlConnection.Open();
                ObjectProperties objectProperties = new ObjectProperties(typeof(T));
                objectProperties.ActualObject = Convert.ChangeType(item, objectProperties.ObjectType);

                var cmd = Connection.GetSqlCommand(procName);


                objectProperties.ToParametersWithId(cmd.Parameters);
                objectProperties.ToOtherParametersWithId(cmd.Parameters);
                cmd.Parameters.AddWithValue("lud", DateTime.Now.ToShortDateString());
                cmd.Parameters.AddWithValue("lub", 1);

                return cmd.ExecuteNonQuery() > -1;
            } catch(Exception e)
            {
                var s = e.Message;
                return false;
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
                cmd.Parameters.AddWithValue("@insertBy", 1);


                var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                int rez = cmd.ExecuteNonQuery();
                _sqlConnection.Close();

                return (int)returnParameter.Value;
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

        public DataTable ToDataTable()
        {
            return ToDataTable($"usp_{typeof(T).Name}_Read");
        }
         public DataTable ToDataTable(string procName)
         {
                    
                try
                {
                    Connection.GetSqlConnection().Open();
                    
                    var adapter = Connection.GetSqlDataAdapter(procName);
                    var datatable = new DataTable();
                    
                    adapter.Fill(datatable);
    
                    return datatable;
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
         
     
         
         
         
        public DataTable ToDataTable(string procName, int id)
        {

            try
            {
                Connection.GetSqlConnection().Open();
                var cmd = Connection.GetSqlCommand(procName);


                cmd.Parameters.AddWithValue("Id", id);
                var adapter = Connection.GetSqlDataAdapter(cmd);

                var datatable = new DataTable();

                adapter.Fill(datatable);

                return datatable;
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