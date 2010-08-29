using System.Diagnostics.Contracts;
using System.Linq;
using Draugen.Data.QueryObjects.DynamicLinq;

namespace Draugen.Data.QueryObjects
{
    public class Order : IQuery
    {
        public Order(string propertyName, SortDirection direction)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(propertyName));
            PropertyName = propertyName;
            Direction = direction;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(!string.IsNullOrWhiteSpace(PropertyName));
        }

        public string PropertyName { get; private set; }
        public SortDirection Direction { get; private set; }

        public IQueryable<T> Refine<T>(IQueryable<T> query) where T : class
        {
            if (Direction == SortDirection.Ascending) { return query.OrderBy(PropertyName); }
            return query.OrderBy(PropertyName + " descending");
        }

        
    }
}