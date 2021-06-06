using System;
using System.Collections.Generic;
using System.Linq;
using EStoreDataAccessLayer.Mapper.Models;

namespace EStoreDataAccessLayer.Mapper.Utils
{
    public class Common
    { 
        public static List<ParameterProperties> ToParametersProperties(object[] parameters)
        {
            var parameterProperties = new List<ParameterProperties>();
            foreach (var parameter in parameters)
            {
                parameterProperties.Add(new ParameterProperties(parameter));
            }

            return parameterProperties;
        }

        public static ParameterProperties ToParameterProperties(object parameter)
        {
            return new (parameter);
        }
        
           public static object LoadObject(Type type, List<ParameterProperties> props)
           {
               int count = 0;
                ObjectProperties model = InitialiseObject(props, type, ref count);
    
                List<ObjectProperties> others = model.GetOtherProperties();
    
                for (int i = 0; i < others.Count; i++)
                {
                    model.InitialiseProp(others[i].ObjectType.Name, InitialiseObject(props, others[i].ObjectType,ref count, others[i].ObjectType.Name ).ActualObject);
                }
    
                return (model.ActualObject);
            }
        
    
            private static ObjectProperties InitialiseObject(List<ParameterProperties> data, Type type, ref int count, string subObject = "")
            {
                ObjectProperties model = new ObjectProperties(type);
    
                var primitiveProps = model.GetPrimitiveProperties();



                int j = 0;
                for (; count < data.Count && j <primitiveProps.Count; j++)
                {
                    
                    try
                    {
                        if (primitiveProps[j].PropertyType.Name.Equals(data[count].Name))
                        {
                             model.InitialiseProp(primitiveProps[j].Name, data[count].Value);
                             count++;
                        }
                  
                    }
                    catch (IndexOutOfRangeException)
                    {
    
                    }
                }
    
                return model;
            }
        public static object GetDbSet(string name)
            {
                var type = typeof(DbSet<>).Assembly.GetTypes()
                    .FirstOrDefault(a => a.Name.StartsWith(name) && a.Name.EndsWith("DbSet"));
    
                var name1 = type.Name;
    
                return Activator.CreateInstance(type);
    
            }

        public static object InvokeMethod(object obj, string name, object parameters)
        {
            var paramsArray = parameters is not null ? (parameters.GetType().IsArray ? (object[])parameters : ToArrayObject(parameters) ) : null;
            var method = obj.GetType().GetMethods().FirstOrDefault(m => m.Name.Equals(name) && m.GetParameters().Length == (paramsArray?.Length ?? 0));

            return method.Invoke(obj, paramsArray);

        }

        public static object[] ToArrayObject(object obj)
        {
            return new[] {obj};
        }
    }
}