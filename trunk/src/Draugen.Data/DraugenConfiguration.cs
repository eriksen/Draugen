using Draugen.Data.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Draugen.Data
{
    public class DraugenConfiguration
    {
        private static ISessionFactory _sessionFactory;
        private static FluentConfiguration _configuration;

        public ISessionFactory GetSessionFactory()
        {
            if(_sessionFactory == null)
            {
                _sessionFactory = Configuration(GetConnectionString()).BuildSessionFactory();
            }
            return _sessionFactory;
        }

        public void BuildSchema(string connectionString)
        {
            var config = Configuration(connectionString).BuildConfiguration();
            new SchemaExport(config).Create(false, true);
        }

        private string GetConnectionString()
        {
            return "Data Source=KANE;Initial Catalog=Catchbase;Integrated Security=True";
        }

        private FluentConfiguration Configuration(string connectionString)
        {
            if(_configuration == null)
            {
                _configuration = Fluently.Configure();
                _configuration.Database(MsSqlConfiguration(connectionString));
                _configuration.Mappings(m => m.FluentMappings.AddFromAssemblyOf<FangstMap>());
            }
            return _configuration;
        }

        private MsSqlConfiguration MsSqlConfiguration(string connectionString)
        {
            return FluentNHibernate.Cfg.Db.MsSqlConfiguration.MsSql2008.ConnectionString(connectionString);
        }

    }
}
