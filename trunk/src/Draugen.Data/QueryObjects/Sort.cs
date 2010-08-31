using System;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Dynamic;


namespace Draugen.Data.QueryObjects
{
    public class Sort : PropertyQueryObject, IQueryObject
    {
        private readonly SortDirection _direction;

        public Sort(string propertyName, SortDirection direction) : base(propertyName)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(propertyName));
            _direction = direction;
        }

        public IQueryable<T> Refine<T>(IQueryable<T> queryable) where T : class
        {
            ValidateProperties<T>();
            return queryable.OrderBy(PropertyName + ParseDirection());
        }

        private string ParseDirection()
        {
            return _direction == SortDirection.Descending ? " descending" : "";
        }
    }
}