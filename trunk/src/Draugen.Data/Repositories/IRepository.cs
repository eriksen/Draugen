using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using Draugen.Data.QueryObjects;

namespace Draugen.Data.Repositories
{
    [ContractClass(typeof(RepositoryContracts<>))]
    public interface IRepository<T> where T : Kommenterbar
    {
        IEnumerable<T> FindAll(IQueryObject[] queryObjects);
        void Add(T item);
        void Delete(T item);
    }

    [ContractClassFor(typeof(IRepository<>))]
    internal abstract class RepositoryContracts<T> : IRepository<T> where T : Kommenterbar
    {
        public IEnumerable<T> FindAll(IQueryObject[] queryObjects)
        {
            Contract.Requires(queryObjects != null);
            Contract.Ensures(Contract.Result<IEnumerable<T>>() != null);
            return default(IQueryable<T>);
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
