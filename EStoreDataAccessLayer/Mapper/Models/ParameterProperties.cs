using System;

namespace EStoreDataAccessLayer.Mapper.Models
{
    public class ParameterProperties
    {
        public string Name { get; set; }
        public object Value { get; set; }

        public ParameterProperties(object value)
        {
            
            this.Name = value.GetType().Name;
            this.Value = value;

        }

        public ParameterProperties(string name, object value)
        {
            this.Name = name;
            this.Value = value;
        }
        
        
    }
}