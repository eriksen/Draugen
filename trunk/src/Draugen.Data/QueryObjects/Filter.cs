using System;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Dynamic;


namespace Draugen.Data.QueryObjects
{
    public class Filter : PropertyQueryObject, IQueryObject
    {
        public FilterOperator FilterOperator { get; private set; }
        public object Value{ get; private set; }

        public Filter(string propertyName, FilterOperator filterOperator, object value) : base(propertyName)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(propertyName));
            FilterOperator = filterOperator;
            Value = value;
        }

        public IQueryable<T> Refine<T>(IQueryable<T> queryable) where T : class
        {
            ValidateProperties<T>();
            var result = queryable.Where(Clause(), Value);
            if (result != null)
                return result;
            return null;
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