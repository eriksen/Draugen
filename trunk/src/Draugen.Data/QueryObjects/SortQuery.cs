using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Dynamic;


namespace Draugen.Data.QueryObjects
{
    internal class SortQuery<T> : PropertyQuery<T>, IQueryObject<T> where T : DomainObject
    {
        private readonly SortDirection _direction;
        internal SortDirection Direction
        {
            get { return _direction; }
        }

        internal SortQuery(string propertyName, SortDirection direction)
            : base(propertyName)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(propertyName));
            _direction = direction;
        }

        public IQueryable<T> Query(IQueryable<T> queryable)
        {
            Validate();
            return queryable.OrderBy(PropertyName + ParseDirection());
        }

        public void Validate()
        {
            ValidateProperties();
        }

        private string ParseDirection()
        {
            return Direction == SortDirection.Descending ? " descending" : "";
        }
    }
}