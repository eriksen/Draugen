using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Draugen.Data.QueryObjects
{
    public class QueryManager<T> : IQueryManager<T> where T : DomainObject
    {
        private readonly ICollection<Filter<T>> _filterQueries;
        private Page<T> _pageQuery;
        private Sort<T> _sortQuery;

        public QueryManager()
        {
            _pageQuery = new Page<T>(1, int.MaxValue);
            _sortQuery = new Sort<T>("Id", SortDirection.Descending);
            _filterQueries = new Collection<Filter<T>>();
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_filterQueries != null);
            Contract.Invariant(_pageQuery != null);
            Contract.Invariant(_sortQuery != null);
        }

        public int CountTotalItems(IQueryable<T> queryable) 
        {
            return Filter(queryable).Count();
        }

        public void AddFilter(string property, FilterOperator filterOperator, object value)
        {
            _filterQueries.Add(new Filter<T>(property, filterOperator, value));
        }

        public void SetPage(int pageIndex, int pageSize)
        {
            _pageQuery = new Page<T>(pageIndex, pageSize);
        }

        public void SetSort(string property, SortDirection direction)
        {
            _sortQuery = new Sort<T>(property, direction);
        }

        private IQueryable<T> Filter(IQueryable<T> queryable)
        {
            return _filterQueries.Aggregate(queryable, (current, filter) => filter.Query(current));
        }

        private IQueryable<T> Page(IQueryable<T> queryable)
        {
            return _pageQuery.Query(queryable);
        }

        private IQueryable<T> Sort(IQueryable<T> queryable)
        {
            return _sortQuery.Query(queryable);
        }

        public IQueryable<T> Query(IQueryable<T> queryable)
        {
            queryable = Filter(queryable);
            queryable = Sort(queryable);
            return Page(queryable);
        }

        public void Validate()
        {
            _pageQuery.Validate();
            _sortQuery.Validate();
            foreach(var filter in _filterQueries)
            {
                filter.Validate();
            }
        }
    }
}