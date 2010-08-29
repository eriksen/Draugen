using System.Diagnostics.Contracts;
using System.Linq;
using Draugen.Data.Repositories;

namespace Draugen.Data.QueryObjects
{
    [ContractClass(typeof(QueryContracts))]
    public interface IQuery
    {
        IQueryable<T> Refine<T>(IQueryable<T> queryable) where T : class;
    }

    [ContractClassFor(typeof(IQuery))]
    internal sealed class QueryContracts : IQuery 
    {
        public IQueryable<T> Refine<T>(IQueryable<T> queryable) where T : class
        {
            Contract.Requires(queryable != null);
            Contract.Ensures(Contract.Result<IQueryable<T>>() != null);
            return default(IQueryable<T>);
        }
    }
}