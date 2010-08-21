using System.Linq;
using NHibernate;
using NHibernate.Linq;


namespace Draugen.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : Kommenterbar
    {
        private readonly ISession _session;

        public Repository(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _session = unitOfWorkFactory.Create().Session;
        }

        public virtual IQueryable<T> FindAll()
        {

            return _session.Linq<T>();
        }

        public virtual void Add(T item)
        {
            foreach (var kommentar in item.Kommentarer)
            {
                _session.SaveOrUpdate(kommentar);
            }
            _session.SaveOrUpdate(item);
        }

        public virtual void Delete(T item)
        {
            _session.Delete(item);
        }
    }
}
