using System.Collections.Generic;
using System.Collections.ObjectModel;
using Draugen.Data.QueryObjects;

namespace Draugen.Services.Builders.Queries
{
    public class QueryBuilder<T> : IQueryBuilder<T>
    {
        public QueryBuilder()
        {
            Filter = new Collection<Filter>();
        }

        public IQueryObject[] Build()
        {
            return new IQueryObject[]
                       {
                           Sort,
                           Page
                       };
        }

        public Sort Sort { get; protected set; }
        public Page Page { get; protected set; }
        public ICollection<Filter> Filter { get; private set; }
    }
}