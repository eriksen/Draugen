using System;
using System.Diagnostics.Contracts;
using NHibernate;

namespace Draugen.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(Session != null);
        }

        public UnitOfWork(ISessionFactory sessionFactory)
        {
            Session = sessionFactory.OpenSession();
            Session.BeginTransaction();
        }

        public ISession Session { get; private set; }

        public void Dispose()
        {
            try
            {
                Session.Transaction.Commit();
            }
            catch (Exception)
            {
                Session.Transaction.Rollback();
            }
            finally
            {
                Session.Dispose();
            }
        }
    }
}
