using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Dynamic;


namespace Draugen.Data.QueryObjects
{
    internal class FilterQuery<T> : PropertyQuery<T>, IQueryObject<T> where T : DomainObject
    {
        private readonly FilterOperator _filterOperator;
        internal FilterOperator FilterOperator
        {
            get { return _filterOperator; }
        }

        private readonly object _value;
        internal object Value
        {
            get { return _value; }
        }

        internal FilterQuery(string propertyName, FilterOperator filterOperator, object value)
            : base(propertyName)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(propertyName));
            Contract.Requires(value != null);
            _filterOperator = filterOperator;
            _value = value;
        }

        public IQueryable<T> Query(IQueryable<T> queryable)
        {
            Validate();
            return queryable.Where(Clause(), Value);
        }

        public void Validate()
        {
            ValidateProperties();
        }

        private string ParseOperator()
        {
            if (FilterOperator == FilterOperator.Equals) { return "=="; }
            return FilterOperator == FilterOperator.GreaterThan ? ">" : "<";
        }

        private string Clause()
        {
            return string.Format("{0} {1} @0", PropertyName, ParseOperator());
        }
    }
}