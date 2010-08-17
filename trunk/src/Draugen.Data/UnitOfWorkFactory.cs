using System.Diagnostics.Contracts;
using NHibernate;

namespace Draugen.Data
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_sessionFactory != null);
        }

        private readonly ISessionFactory _sessionFactory;
        
        public UnitOfWorkFactory(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        public virtual IUnitOfWork Create()
        {
            Contract.Ensures(Contract.Result<IUnitOfWork>() != null);
            return new UnitOfWork(_sessionFactory);
        }

        public virtual void Dispose()
        {
            _sessionFactory.Dispose();
        }
    }
}
