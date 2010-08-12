using Draugen.Data.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Draugen.System.Tests.Data
{
    public class Persistance
    {
        private static FluentConfiguration CreateFluentConfiguration()
        {
            return Fluently.Configure()
                .Database(
                    MsSqlConfiguration.MsSql2008.ConnectionString(
                        "Data Source=KANE;Initial Catalog=Catchbase2;Integrated Security=True"))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<FangstMap>());
        }

        protected static ISessionFactory CreateSessionFactory()
        {
            return CreateFluentConfiguration().BuildSessionFactory();
        }

        protected static Configuration CreateConfiguration()
        {
            return CreateFluentConfiguration().BuildConfiguration();
        }

        protected static void BuildSchema()
        {
            var config = CreateConfiguration();
            new SchemaExport(config).Create(false, true);
        }


    }
}