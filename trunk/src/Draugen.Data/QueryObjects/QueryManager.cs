using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Draugen.Data.QueryObjects
{
    public class QueryManager<T> : IQueryManager<T> where T : DomainObject
    {
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_filterQueries != null);
            Contract.Invariant(_pageQueryQuery != null);
            Contract.Invariant(_sortQueryQuery != null);
        }
        private readonly ICollection<FilterQuery<T>> _filterQueries;
        private PageQuery<T> _pageQueryQuery;
        private SortQuery<T> _sortQueryQuery;

        public QueryManager()
        {
            _pageQueryQuery = new PageQuery<T>(1, int.MaxValue);
            _sortQueryQuery = new SortQuery<T>("Id", SortDirection.Descending);
            _filterQueries = new Collection<FilterQuery<T>>();
        }

        internal virtual int PageIndex { get { return _pageQueryQuery.Index; } }
        internal virtual int PageSize { get { return _pageQueryQuery.Size; } }
        internal virtual int TotalItemsCount(IQueryable<T> queryable) 
        {
            return Filter(queryable).Count();
        }

        public virtual void AddFilter(string property, FilterOperator filterOperator, object value)
        {
            _filterQueries.Add(new FilterQuery<T>(property, filterOperator, value));
        }

        public virtual void SetPage(int pageIndex, int pageSize)
        {
            _pageQueryQuery = new PageQuery<T>(pageIndex, pageSize);
        }

        public virtual void SetSort(string property, SortDirection direction)
        {
            _sortQueryQuery = new SortQuery<T>(property, direction);
        }

        private IQueryable<T> Filter(IQueryable<T> queryable)
        {
            return _filterQueries.Aggregate(queryable, (current, filter) => filter.Query(current));
        }

        private IQueryable<T> Page(IQueryable<T> queryable)
        {
            return _pageQueryQuery.Query(queryable);
        }

        private IQueryable<T> Sort(IQueryable<T> queryable)
        {
            return _sortQueryQuery.Query(queryable);
        }

        public virtual IQueryable<T> Query(IQueryable<T> queryable)
        {
            queryable = Filter(queryable);
            queryable = Sort(queryable);
            return Page(queryable);
        }

        public virtual void Validate()
        {
            _pageQueryQuery.Validate();
            _sortQueryQuery.Validate();
            foreach(var filter in _filterQueries)
            {
                filter.Validate();
            }
        }
    }
}