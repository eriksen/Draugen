using System.Diagnostics.Contracts;
using System.Linq;
using NHibernate;
using NHibernate.Linq;


namespace Draugen.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : Kommenterbar
    {
        private readonly ISession _session;

        public Repository(ISession session)
        {
            Contract.Requires(session.Transaction.IsActive == true);
            _session = session;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_session.Transaction.IsActive == true);
        }

        public virtual IQueryable<T> FindAll()
        {
            Contract.Ensures(Contract.Result<IQueryable<T>>() != null);
            return _session.Linq<T>();
        }

        public virtual void Add(T item)
        {
            //Contract.Requires<T>(item != null);
            //Contract.Requires(item.Kommentarer != null);
            foreach (var kommentar in item.Kommentarer)
            {
                _session.SaveOrUpdate(kommentar);
            }
            _session.SaveOrUpdate(item);
        }

        public virtual void Delete(T item)
        {
            //Contract.Requires(item != null);
            _session.Delete(item);
        }
    }
}
