using System;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Draugen.Data.QueryObjects
{
    [ContractClass(typeof(QueryObjectContracts))]
    public interface IQueryObject
    {
        IQueryable<T> Refine<T>(IQueryable<T> queryable) where T : class;
    }

    [ContractClassFor(typeof(IQueryObject))]
    internal abstract class QueryObjectContracts : IQueryObject 
    {
        public IQueryable<T> Refine<T>(IQueryable<T> queryable) where T : class
        {
            Contract.Requires(queryable != null);
            Contract.Ensures(Contract.Result<IQueryable<T>>() != null);
            return default(IQueryable<T>);
        }
    }
}