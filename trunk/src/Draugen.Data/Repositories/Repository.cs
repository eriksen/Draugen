using System.Diagnostics.Contracts;
using System.Linq;
using Draugen.Data.QueryObjects;
using NHibernate;
using NHibernate.Linq;


namespace Draugen.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : Kommenterbar
    {
        protected readonly ISession Session;

        public Repository(ISession session)
        {
            Contract.Requires(session != null);
            Contract.Requires(session.IsOpen == true);
            Session = session;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(Session != null);
            Contract.Invariant(Session.IsOpen == true);
        }

        public virtual IPagedList<T> FindAll(IQueryManager<T> queryManager)
        {
            var queryable = Session.Linq<T>();
            return new PagedList<T>(queryable, queryManager);
        }

        public virtual void Add(T item)
        {
            foreach (var kommentar in item.Kommentarer)
            {
                Session.SaveOrUpdate(kommentar);
            }
            Session.SaveOrUpdate(item);
        }

        public virtual void Delete(T item)
        {
            Session.Delete(item);
        }
    }
}

