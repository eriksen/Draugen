using Draugen.Data.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace Draugen.Data
{
    public static class SessionFactory
    {
        private static readonly ISessionFactory Factory;

        static SessionFactory()
        {
            Factory = Configuration().BuildSessionFactory();
        }

        public static ISession Session
        {
            get { return Factory.OpenSession(); }
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
                "Data Source=KANE;Initial Catalog=Catchbase2;Integrated Security=True");
        }
    }
}