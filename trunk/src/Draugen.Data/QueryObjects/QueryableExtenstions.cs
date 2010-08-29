using System.Linq;

namespace Draugen.Data.QueryObjects
{
    public static class QueryableExtenstions
    {
        public static IQueryable<T> Query<T>(this IQueryable<T> queryable, IQuery query) where T : class

        {
            return query.Refine(queryable);
        }
    }
}
