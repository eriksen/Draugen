using System;
using System.Diagnostics.Contracts;
using System.Linq;
using Draugen.Data.QueryObjects;

namespace Draugen.Data.Repositories
{
    [ContractClass(typeof(RepositoryContracts<>))]
    public interface IRepository<T> where T : Kommenterbar
    {
        IQueryable<T> FindAll(IQuery query);
        void Add(T item);
        void Delete(T item);
    }

    [ContractClassFor(typeof(IRepository<>))]
    internal sealed class RepositoryContracts<T> : IRepository<T> where T : Kommenterbar
    {
        public IQueryable<T> FindAll(IQuery query)
        {

            Contract.Requires(query != null);
            Contract.Ensures(Contract.Result<IQueryable<T>>() != null);
            return default(IQueryable<T>);
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Delete(T item)
        {
            throw new NotImplementedException();
        }
    }

}
