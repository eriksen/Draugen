using System;
using System.Diagnostics.Contracts;
using Draugen.Data.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Draugen.Data
{
    public class DraugenConfiguration : IDraugenConfiguration
    {
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_sessionFactory != null);
            Contract.Invariant(_configuration != null);
        }
        private static ISessionFactory _sessionFactory;
        private static FluentConfiguration _configuration;

        public DraugenConfiguration(string connectionString)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(connectionString));
            _configuration = Fluently.Configure();
            _configuration.Database(MsSqlConfiguration(connectionString));
            _configuration.Mappings(m => m.FluentMappings.AddFromAssemblyOf<FangstMap>());
            _sessionFactory = _configuration.BuildSessionFactory();
        }

        public ISessionFactory GetSessionFactory()
        {
            Contract.Ensures(Contract.Result<ISessionFactory>() != null);
            return _sessionFactory;
        }

        public void BuildSchema()
        {
            var config = _configuration.BuildConfiguration();
            new SchemaExport(config).Create(false, true);
        }

        private static MsSqlConfiguration MsSqlConfiguration(string connectionString)
        {
            return FluentNHibernate.Cfg.Db.MsSqlConfiguration.MsSql2008.ConnectionString(connectionString);
        }

        public void Dispose()
        {
            _sessionFactory.Dispose();
            _sessionFactory = null;
            _configuration = null;
        }
    }
}
