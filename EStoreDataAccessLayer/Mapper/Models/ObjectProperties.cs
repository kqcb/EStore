using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace EStoreDataAccessLayer.Mapper.Models
{
    public class ObjectProperties
    {
        public Type ObjectType { get; set; }
        public object ActualObject { get; set; }

        public ObjectProperties(Type objectType)
        {
            ObjectType = objectType;
            Initialise();
        }

        public object Initialise()
        {
            return ActualObject = Activator.CreateInstance(ObjectType);
        }

        public List<PropertyInfo> GetPrimitiveProperties()
        {
            return ObjectType
                .GetProperties()
                .Where(prop => (prop.PropertyType.IsValueType || prop.PropertyType.Name == "String") && !prop.PropertyType.Name.Contains("^"))
                .ToList();
        }

        public void InitialiseProp(string propName, object value)
        {
            PropertyInfo prop = ObjectType.GetProperties().FirstOrDefault(prop => prop.Name == propName);


            prop.SetValue(ActualObject, Convert.ChangeType(value, prop.PropertyType));
        }

        public List<ObjectProperties> GetOtherProperties()
        {
            return ObjectType
                .GetProperties()
                .Where(prop => !prop.PropertyType.IsValueType && prop.PropertyType.Name != "String" && !prop.PropertyType.Name.Contains("`"))
                .Select(pr => new ObjectProperties(pr.PropertyType))
                .ToList();
        }


        public List<string> GetPrimitivePropertiesNames()
        {
            return GetPrimitiveProperties().Select(prop => prop.Name).ToList();
        }

        public void ToParametersWithId(SqlParameterCollection sqlParameters)
        {
            var props = GetPrimitiveProperties();

            for (int i = 0; i < props.Count; i++)
            {

                sqlParameters.AddWithValue("@" + props[i].Name, props[i].GetValue(ActualObject));
            }
        }

        public void ToOtherParametersWithId(SqlParameterCollection sqlParameters)
        {
            var props = GetOtherProperties();
            for (int i = 0; i < props.Count; i++)
            {
                string propName = ObjectType.GetProperties().First(pro => pro.PropertyType.Name.Equals(props[i].ObjectType.Name)).Name;


                PropertyInfo prop = props[i].ObjectType.GetProperties().FirstOrDefault(pro => pro.Name.Equals("Id")); //returns id

                if (prop != null)
                {
                    var obj = ActualObject
                        .GetType()
                        .GetProperties()
                        .FirstOrDefault(prop => prop.PropertyType.Name.Equals(props[i].ObjectType.Name)).GetValue(ActualObject); //returns subobject p.sh User.City

                    if (obj != null)
                    {

                        sqlParameters
                            .AddWithValue($"@{propName}Id", prop.GetValue(obj));
                    }
                }

            }
        }

    }
}