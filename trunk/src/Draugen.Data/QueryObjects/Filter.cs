using System;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Dynamic;


namespace Draugen.Data.QueryObjects
{
    public class Filter : PropertyQueryObject, IQueryObject
    {
        private readonly FilterOperator _filterOperator;
        private readonly object _value;

        public Filter(string propertyName, FilterOperator filterOperator, object value) : base(propertyName)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(propertyName));
            _filterOperator = filterOperator;
            _value = value;
        }

        public IQueryable<T> Refine<T>(IQueryable<T> queryable) where T : class
        {
            ValidateProperties<T>();
            var result = queryable.Where(Clause(), _value);
            if (result != null)
                return result;
            return null;
        }

        private string ParseOperator()
        {
            if (_filterOperator == FilterOperator.Equals) { return "=="; }
            return _filterOperator == FilterOperator.GreaterThan ? ">" : "<";
        }

        private string Clause()
        {
            return string.Format("{0} {1} @0", PropertyName, ParseOperator());
        }
    }
}