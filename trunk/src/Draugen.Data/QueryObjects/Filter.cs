using System.Diagnostics.Contracts;
using System.Linq;
using Draugen.Data.QueryObjects.DynamicLinq;

namespace Draugen.Data.QueryObjects
{
    public class Filter : IQueryObject
    {
        private readonly string _propertyName;
        private readonly FilterOperator _filterOperator;
        private readonly object _value;

        public Filter(string propertyName, FilterOperator filterOperator, object value)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(propertyName));
            _propertyName = propertyName;
            _filterOperator = filterOperator;
            _value = value;
        }

        public IQueryable<T> Refine<T>(IQueryable<T> query) where T : class
        {
            return query.Where(Clause(), _value);
        }

        private string ParseOperator()
        {
            if (_filterOperator == FilterOperator.Equals) { return "=="; }
            return _filterOperator == FilterOperator.GreaterThan ? ">" : "<";
        }

        public string Clause()
        {
            return string.Format("{0} {1} @0", _propertyName, ParseOperator());
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(!string.IsNullOrWhiteSpace(_propertyName));
        }
    }
}