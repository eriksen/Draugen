using System;
using Draugen.Data.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Context;

namespace Draugen.Data
{
    public class SessionManager
    {
        private static readonly ISessionFactory SessionFactory;
        static SessionManager()
        {
            SessionFactory = Configuration().BuildSessionFactory();
        }

        public SessionManager()
        {
            var session = SessionFactory.OpenSession();
            session.BeginTransaction();
            CurrentSessionContext.Bind(session);
        }

        public static ISession GetCurrentSession()
        {
            return SessionFactory.GetCurrentSession();
        }

        private static FluentConfiguration Configuration()
        {
            var config = Fluently.Configure();
            config.Database(MsSqlConfiguration());
            config.Mappings(m => m.FluentMappings.AddFromAssemblyOf<FangstMap>());
            return config;
        }

        private static MsSqlConfiguration MsSqlConfiguration()
        {
            return FluentNHibernate.Cfg.Db.MsSqlConfiguration.MsSql2008.ConnectionString(
                "Data Source=KANE;Initial Catalog=Catchbase;Integrated Security=True");
        }

        public void Dispose()
        {
            var session = CurrentSessionContext.Unbind(SessionFactory);
            if (session == null) return;
            try
            {
                session.Transaction.Commit();
            }
            catch (Exception)
            {
                session.Transaction.Rollback();
            }
            finally
            {
                session.Close();
                session.Dispose();
            }
        }
    }
}
