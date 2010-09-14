using System.Diagnostics.Contracts;
using System.Linq;
using Draugen.Data.QueryObjects;

namespace Draugen.Data.Paging
{
    [ContractClass(typeof(PageBuilderContracts<>))]
    public interface IPageBuilder<T> where T : DomainObject
    {
        IPage<T> Build(IQueryManager<T> queryManager, IQueryable<T> queryable);
    }

    [ContractClassFor(typeof(IPageBuilder<>))]
    public abstract class PageBuilderContracts<T> : IPageBuilder<T> where T : DomainObject
    {
        public IPage<T> Build(IQueryManager<T> queryManager, IQueryable<T> queryable)
        {
            Contract.Requires(queryManager != null);
            Contract.Requires(queryable != null);
            Contract.Ensures(Contract.Result<IPage<T>>() != null);
            return default(IPage<T>);
        }
    }
}