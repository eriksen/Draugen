using System.Collections.Generic;
using System.Linq;

namespace Draugen.Data.Repositories
{
    public interface IRepository<T> where T : DomainObject
    {
        IQueryable<T> FindAll();
        void Add(T item);
        void Delete(T item);
    }
}
