using System;
using NHibernate;

namespace Draugen.Data
{
    public class SessionManager : ISessionManager
    {
        private static readonly ISessionFactory SessionFactory;
        private readonly ISession _session;

        static SessionManager()
        {
            SessionFactory = DraugenConfiguration.GetSessionFactory();
        }

        public SessionManager()
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
