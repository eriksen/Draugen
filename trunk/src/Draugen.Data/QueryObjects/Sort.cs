using System;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Dynamic;


namespace Draugen.Data.QueryObjects
{
    public class Sort : PropertyQueryObject, IQueryObject
    {
        public SortDirection Direction { get; private set; }

        public Sort(string propertyName, SortDirection direction) : base(propertyName)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(propertyName));
            Direction = direction;
        }

        public IQueryable<T> Refine<T>(IQueryable<T> queryable) where T : class
        {
            ValidateProperties<T>();
            return queryable.OrderBy(PropertyName + ParseDirection());
        }

        private string ParseDirection()
        {
            return Direction == SortDirection.Descending ? " descending" : "";
        }
    }
}