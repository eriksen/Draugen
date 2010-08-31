using System.Linq;

namespace Draugen.Data.QueryObjects
{
    public static class QueryableExtenstions
    {
        public static IQueryable<T> Query<T>(this IQueryable<T> queryable, IQueryObject[] queryObjects) where T : class
        {
            return queryObjects.Aggregate(queryable, (current, queryObject) => queryObject.Refine(current));
        }
    }
}
