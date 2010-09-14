using System;
using System.Linq;
using Draugen.Data.QueryObjects;

namespace Draugen.Data.Paging
{
    public class PageBuilder<T> : IPageBuilder<T> where T : DomainObject
    {
        public IPage<T> Build(IQueryManager<T> queryManager, IQueryable<T> queryable)
        {
            var page = new Page<T>();
            page.AddRange(queryManager.Query(queryable));

            if(queryManager.GetType() == typeof(QueryManager<T>))
            {
                page.TotalItems = ((QueryManager<T>) queryManager).TotalItemsCount(queryable);
                page.Size = ((QueryManager<T>) queryManager).PageSize;
                page.Index = ((QueryManager<T>) queryManager).PageIndex;
            }
            else
            {
                page.TotalItems = page.Count;
                page.Size = page.Count == 0 ? 1 : page.Count;
                page.Index = 1; 
            }
            return page;
        }
    }
}
