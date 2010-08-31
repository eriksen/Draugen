using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Draugen.Data.QueryObjects
{
    public abstract class PropertyQueryObject
    {
        protected string PropertyName;

        protected PropertyQueryObject(string propertyName)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(propertyName));
            PropertyName = propertyName;
        }

        protected void ValidateProperties<T>()
        {
            var properites = PropertyName.Split(new[] {'.'}).ToList();
            ValidateProperties<T>(properites);
        }

        private static void ValidateProperties<T>(IList<string> properties)
        {
            Contract.Requires(properties != null);
            ValidateProperties(typeof(T), properties);
        }

        private static void ValidateProperties(Type type, IList<string> properties)
        {
            if (properties.Count == 0) { return; }
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

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(!string.IsNullOrWhiteSpace(PropertyName));
        }

    }
}