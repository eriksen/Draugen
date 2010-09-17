using System.Diagnostics.Contracts;
using Draugen.Data.QueryObjects;

namespace Draugen.Services.Builders.Queries
{
    [ContractClass(typeof(QueryBuilderContract<>))]
    public interface IQueryBuilder<T> where T : DomainObject
    {
        IQueryManager<T> Build();
    }

    [ContractClassFor(typeof(IQueryBuilder<>))]
    public abstract class QueryBuilderContract<T> : IQueryBuilder<T> where T : DomainObject
    {
        public IQueryManager<T> Build()
        {
            Contract.Ensures(Contract.Result<IQueryManager<T>>() != null);
            return default(IQueryManager<T>);
        }
    }
}