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
        }

        public ISession Session { get; private set; }

        public void BeginTransaction()
        {
            Session.BeginTransaction();
        }

        public bool CommitTransaction()
        {
            try
            {
                Session.Transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                Session.Transaction.Rollback();
                return false;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            Contract.Ensures(Session == null);
            if (!disposing) return;
            Session.Dispose();
            Session = null;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(Session.IsOpen == true);
        }

    }
}
