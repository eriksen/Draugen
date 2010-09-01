using System.Collections.Generic;
using Draugen.Data.QueryObjects;

namespace Draugen.Services.Builders.Queries
{
    public interface IQueryBuilder<T>
    {
        IQueryObject[] Build();
        Sort Sort { get; }
        Page Page { get; }
        ICollection<Filter> Filter { get; }
    }
}