using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Dynamic;


namespace Draugen.Data.QueryObjects
{
    internal class Sort<T> : PropertyQueryObject<T> where T : DomainObject
    {
        internal SortDirection Direction { get; private set; }

        internal Sort(string propertyName, SortDirection direction)
            : base(propertyName)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(propertyName));
            Direction = direction;
        }

        internal IQueryable<T> Refine(IQueryable<T> queryable)
        {
            ValidateProperties();
            return queryable.OrderBy(PropertyName + ParseDirection());
        }

        private string ParseDirection()
        {
            return Direction == SortDirection.Descending ? " descending" : "";
        }
    }
}