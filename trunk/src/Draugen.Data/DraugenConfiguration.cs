using Draugen.Data.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Draugen.Data
{
    public class DraugenConfiguration
    {
        public static ISessionFactory GetSessionFactory()
        {
            return Configuration(GetConnectionString()).BuildSessionFactory();
        }

        public static void BuildSchema(string connectionString)
        {
            var config = Configuration(connectionString).BuildConfiguration();
            new SchemaExport(config).Create(false, true);
        }

        private static string GetConnectionString()
        {
            return "Data Source=KANE;Initial Catalog=Catchbase;Integrated Security=True";
        }

        private static FluentConfiguration Configuration(string connectionString)
        {
            var config = Fluently.Configure();
            config.Database(MsSqlConfiguration(connectionString));
            config.Mappings(m => m.FluentMappings.AddFromAssemblyOf<FangstMap>());
            return config;
        }

        private static MsSqlConfiguration MsSqlConfiguration(string connectionString)
        {
            return FluentNHibernate.Cfg.Db.MsSqlConfiguration.MsSql2008.ConnectionString(connectionString);
        }

    }
}
