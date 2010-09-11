using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Draugen.Data.QueryObjects;

namespace Draugen.Data
{
    public class PagedList<T> : IPagedList<T> where T : DomainObject
    {
        private readonly IEnumerable<T> _list;

        public PagedList(IQueryable<T> queryable, IQueryManager<T> queryManager)
        {
            TotalItemCount = queryManager.CountTotalItems(queryable);
            _list = queryManager.Query(queryable).ToList();
        }

        public int TotalItemCount { get; private set; }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}