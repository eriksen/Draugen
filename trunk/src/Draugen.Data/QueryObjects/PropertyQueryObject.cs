using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Draugen.Data.QueryObjects
{
    internal abstract class PropertyQueryObject<T> where T : class
    {
        private readonly string _propertyName;
        internal string PropertyName
        {
            get { return _propertyName; }
        }

        protected PropertyQueryObject(string propertyName)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(propertyName));
            _propertyName = propertyName;
        }

        protected void ValidateProperties()
        {
            var properites = PropertyName.Split(new[] {'.'}).ToList();
            ValidateProperties(properites);
        }

        private static void ValidateProperties(IList<string> properties)
        {
            Contract.Requires(properties != null);
            ValidateProperties(typeof(T), properties);
        }

        private static void ValidateProperties(Type type, IList<string> properties)
        {
            var propertyInfo = type.GetProperty(properties[0]);
            if (propertyInfo == null)
            {
                throw new ArgumentException(
                    string.Format("Property {0} in relation to {1} does not exist", properties[0], type.Name));
            }
            if (properties.Count < 2) { return; }

            properties.RemoveAt(0);
            var childType = propertyInfo.PropertyType;
            ValidateProperties(childType, properties);
        }
    }
}