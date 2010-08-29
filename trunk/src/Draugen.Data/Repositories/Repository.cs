using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
            Contract.Requires(session.Transaction.IsActive == true);
            Session = session;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(Session.Transaction.IsActive == true);
        }

        public virtual IEnumerable<T> FindAll(IQueryObject[] queryObjects)
        {
            return Session.Linq<T>().Query<T>(queryObjects);
        }

        public virtual void Add(T item)
        {
            //Contract.Requires<T>(item != null);
            //Contract.Requires(item.Kommentarer != null);
            foreach (var kommentar in item.Kommentarer)
            {
                Session.SaveOrUpdate(kommentar);
            }
            Session.SaveOrUpdate(item);
        }

        public virtual void Delete(T item)
        {
            //Contract.Requires(item != null);
            Session.Delete(item);
        }
    }
}
