using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Draugen.Data.QueryObjects
{
    public class QueryContainer<T> : IQueryObject<T> where T : DomainObject
    {
        private readonly ICollection<Filter<T>> _filterQueries;
        private Page _pageQuery;
        private Sort<T> _sortQuery;

        public QueryContainer()
        {
            _pageQuery = new Page(1, 25);
            _sortQuery = new Sort<T>("Id", SortDirection.Descending);
            _filterQueries = new Collection<Filter<T>>();
        }

        public int Count { get; private set; }

        public void AddFilter(string property, FilterOperator filterOperator, object value)
        {
            _filterQueries.Add(new Filter<T>(property, filterOperator, value));
        }

        public void SetPage(int pageIndex, int pageSize)
        {
            _pageQuery = new Page(pageIndex, pageSize);
        }

        public void SetSort(string property, SortDirection direction)
        {
            _sortQuery = new Sort<T>(property, direction);
        }

        private IQueryable<T> Filter(IQueryable<T> queryable)
        {
            return _filterQueries.Aggregate(queryable, (current, filter) => filter.Refine(current));
        }

        private IQueryable<T> Page(IQueryable<T> queryable)
        {
            return _pageQuery.Refine(queryable);
        }

        private IQueryable<T> Sort(IQueryable<T> queryable)
        {
            return _sortQuery.Refine(queryable);
        }

        public IQueryable<T> Query(IQueryable<T> queryable)
        {
            queryable = Filter(queryable);
            queryable = Sort(queryable);
            Count = queryable.Count();
            return Page(queryable);
        }
    }
}