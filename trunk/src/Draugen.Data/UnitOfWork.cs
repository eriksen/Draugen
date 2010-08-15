using System;
using NHibernate;

namespace Draugen.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private static readonly ISessionFactory SessionFactory;
        private readonly ISession _session;

        static UnitOfWork()
        {
            SessionFactory = new DraugenConfiguration().GetSessionFactory();
        }

        public UnitOfWork()
        {
            _session = SessionFactory.OpenSession();
            _session.BeginTransaction();
        }

        public ISession Session
        {
            get { return _session; }
        }

        public void Dispose()
        {
            if (_session == null) return;
            try
            {
                _session.Transaction.Commit();
            }
            catch (Exception)
            {
                _session.Transaction.Rollback();
            }
            finally
            {
                _session.Close();
                _session.Dispose();
            }
        }
    }
}
