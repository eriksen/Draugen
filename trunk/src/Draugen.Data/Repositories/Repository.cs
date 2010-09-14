using System.Diagnostics.Contracts;
using System.Linq;
using Draugen.Data.Paging;
using Draugen.Data.QueryObjects;
using NHibernate;
using NHibernate.Linq;


namespace Draugen.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : Kommenterbar
    {
        protected readonly ISession Session;
        private readonly IPageBuilder<T> _pageBuilder;

        public Repository(ISession session, IPageBuilder<T> pageBuilder)
        {
            Contract.Requires(pageBuilder != null);
            Contract.Requires(session != null);
            Contract.Requires(session.IsOpen == true);
            _pageBuilder = pageBuilder;
            Session = session;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(Session != null);
            Contract.Invariant(Session.IsOpen == true);
        }

        public virtual IPage<T> FindAll(IQueryManager<T> queryManager)
        {
            var queryable = Session.Linq<T>();

            return _pageBuilder.Build(queryManager, queryable);
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

