using System.Diagnostics.Contracts;
using System.Linq;

namespace Draugen.Data.QueryObjects
{
    [ContractClass(typeof(QueryObjectContracts<>))]
    public interface IQueryObject<T> where T : DomainObject
    {
        IQueryable<T> Query(IQueryable<T> queryable);
        void Validate();
    }

    [ContractClassFor(typeof(IQueryObject<>))]
    internal abstract class QueryObjectContracts<T> : IQueryObject<T> where T : DomainObject
    {
        public IQueryable<T> Query(IQueryable<T> queryable)
        {
            Contract.Requires(queryable != null);
            Contract.Ensures(Contract.Result<IQueryable<T>>() != null);
            return default(IQueryable<T>);
        }

        public void Validate()
        {
            
        }
    }
}