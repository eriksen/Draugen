using System.Linq;
using NHibernate;

namespace Draugen.Data.Repositories
{
    public interface IRepository<T> where T : DomainObject
    {
        ISession Session { get; set; }
        IQueryable<T> FindAll();
        void Add(T item);
        void Delete(T item);
    }
}
