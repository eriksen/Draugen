using System.Diagnostics.Contracts;
using NHibernate;

namespace Draugen.Data
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        private readonly ISessionFactory _sessionFactory;
        private IUnitOfWork _current;

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_sessionFactory != null);
        }

        public UnitOfWorkFactory(ISessionFactory sessionFactory)
        {
            Contract.Requires(sessionFactory != null);
            _sessionFactory = sessionFactory;
        }

        public IUnitOfWork Create()
        {
            Contract.Ensures(Contract.Result<IUnitOfWork>() != null);
            return _current ?? (_current = new UnitOfWork(this, _sessionFactory));
        }

        public void Destroy()
        {
            _current = null;
        }

        public void Dispose()
        {
            _sessionFactory.Dispose();
        }
    }
}
