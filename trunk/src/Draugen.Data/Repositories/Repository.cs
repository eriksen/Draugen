using System.Linq;
using NHibernate;
using NHibernate.Linq;


namespace Draugen.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : DomainObject
    {

        public virtual ISession Session { get; set; }
        
        public virtual IQueryable<T> FindAll()
        {
            
            return Session.Linq<T>();
        }

        public virtual void Add(T item)
        {
            Session.SaveOrUpdate(item);
        }

        public virtual void Delete(T item)
        {
            Session.Delete(item);
        }
    }
}
