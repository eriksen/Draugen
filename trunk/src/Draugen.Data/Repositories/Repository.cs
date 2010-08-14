using System.Linq;
using NHibernate;
using NHibernate.Linq;


namespace Draugen.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : DomainObject
    {
        public Repository(ISession session)
        {
            Session = session;
        }

        protected ISession Session { get; set; }
        
        public IQueryable<T> FindAll()
        {
            return Session.Linq<T>();
        }

        public void Add(T item)
        {
            Session.SaveOrUpdate(item);
        }

        public void Delete(T item)
        {
            Session.Delete(item);
        }
    }
}
