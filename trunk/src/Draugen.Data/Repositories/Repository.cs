using System;
using System.Linq;
using NHibernate;

namespace Draugen.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : Kommenterbar
    {
        private readonly ISessionProvider _sessionProvider;

        public Repository(ISessionProvider sessionProvider)
        {
            _sessionProvider = sessionProvider;
        }

        private ISession Session
        {
            get { return _sessionProvider.Session; }
        }
 
        public IQueryable<T> FindAll()
        {
            using(var session = Session)
            {
                throw new NotImplementedException();
            }
        }

        public void Add(T item)
        {
            using(var session = Session)
            {
                session.SaveOrUpdate(item);
            }
        }
    }
}
