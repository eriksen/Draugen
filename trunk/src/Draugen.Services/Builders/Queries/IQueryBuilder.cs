using System.Collections.Generic;
using Draugen.Data.QueryObjects;

namespace Draugen.Services.Builders.Queries
{
    public interface IQueryBuilder<T> where T : DomainObject
    {
        IQueryObject<T> Build();
    }
}