using System.Diagnostics.Contracts;
using System.Linq;
using Draugen.Data.QueryObjects.DynamicLinq;

namespace Draugen.Data.QueryObjects
{
    public class Sort : IQueryObject
    {
        private readonly string _propertyName;
        private readonly SortDirection _direction;

        public Sort(string propertyName, SortDirection direction)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(propertyName));
            _propertyName = propertyName;
            _direction = direction;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(!string.IsNullOrWhiteSpace(_propertyName));
        }

        public IQueryable<T> Refine<T>(IQueryable<T> query) where T : class
        {
            return query.OrderBy(_propertyName + ParseDirection());
        }

        private string ParseDirection()
        {
            return _direction == SortDirection.Descending ? " descending" : "";
        }
    }
}