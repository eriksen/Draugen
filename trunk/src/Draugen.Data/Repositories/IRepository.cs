using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Draugen.Data.Paging;
using Draugen.Data.QueryObjects;

namespace Draugen.Data.Repositories
{
    [ContractClass(typeof(RepositoryContracts<>))]
    public interface IRepository<T> where T : Kommenterbar
    {
        IPage<T> FindAll(IQueryManager<T> queryManager);
        void Add(T item);
        void Delete(T item);
    }

    [ContractClassFor(typeof(IRepository<>))]
    internal abstract class RepositoryContracts<T> : IRepository<T> where T : Kommenterbar
    {
        public IPage<T> FindAll(IQueryManager<T> queryManager)
        {
            Contract.Requires(queryManager != null);
            Contract.Ensures(Contract.Result<IEnumerable<T>>() != null);
            return default(IPage<T>);
        }

        public void Add(T item)
        {
            Contract.Requires(item.Kommentarer != null);
        }

        public void Delete(T item)
        {
            Contract.Requires(item != null);
        }


    }

}
