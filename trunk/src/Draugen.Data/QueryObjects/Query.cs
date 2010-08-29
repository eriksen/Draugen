using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Draugen.Data.QueryObjects
{
    public class Query : IQuery
    {
        private readonly List<Filter> _filters;

        public Query()
        {
            _filters = new List<Filter>();
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_filters != null);
        }
        
        public Order Order { get; set; }
        public Page Page { get; set; }

        public void AddFilter(Filter filter)
        {
            Contract.Requires(filter != null);
            _filters.Add(filter);
        }

        public IQueryable<T> Refine<T>(IQueryable<T> queryable) where T : class
        {
            queryable = _filters.Aggregate(queryable, (current, filter) => filter.Refine<T>(current));
            if (Order != null) { queryable = Order.Refine(queryable); }
            if (Page != null) { queryable = Page.Refine(queryable); }
            return queryable;

        }
    }
}
