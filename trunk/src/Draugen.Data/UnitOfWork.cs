using System;
using System.Diagnostics.Contracts;
using NHibernate;

namespace Draugen.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ISessionFactory sessionFactory)
        {
            Contract.Requires(sessionFactory != null);
            Session = sessionFactory.OpenSession();
            Session.BeginTransaction();
        }

        public ISession Session { get; private set; }

        public void Dispose()
        {
            Contract.Ensures(Session == null);
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if(!disposing){ return; }
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
                Session = null;
            }
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(Session.Transaction.IsActive == true);
        }

    }
}
