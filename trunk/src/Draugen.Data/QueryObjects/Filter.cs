using System.Diagnostics.Contracts;
using System.Linq;
using Draugen.Data.QueryObjects.DynamicLinq;

namespace Draugen.Data.QueryObjects
{
    public class Filter : IQuery
    {
        public Filter(string propertyName, FilterOperator filterOperator, object value)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(propertyName));
            PropertyName = propertyName;
            FilterOperator = filterOperator;
            Value = value;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(!string.IsNullOrWhiteSpace(PropertyName));
        }

        public string PropertyName { get; private set; }
        public object Value { get; private set; }
        public FilterOperator FilterOperator { get; private set; }

        public IQueryable<T> Refine<T>(IQueryable<T> query) where T : class
        {
            Contract.Requires(query != null);
            return query.Where(string.Format("{0} {1} @0", PropertyName, ParseOperator()), Value);
        }

        private string ParseOperator()
        {
            if (FilterOperator == FilterOperator.Equals) { return "=="; }
            return FilterOperator == FilterOperator.GreaterThan ? ">" : "<";
        }
    }
}