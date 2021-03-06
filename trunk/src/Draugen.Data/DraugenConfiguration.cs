﻿using System.Diagnostics.Contracts;
using Draugen.Data.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace Draugen.Data
{
    public sealed class DraugenConfiguration : IDraugenConfiguration
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

        private static MsSqlConfiguration MsSqlConfiguration(string connectionString)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(connectionString));
            return FluentNHibernate.Cfg.Db.MsSqlConfiguration.MsSql2008.ConnectionString(connectionString);
        }

        public void Dispose()
        {
            Contract.Ensures(_sessionFactory == null);
            Contract.Ensures(_configuration == null);
            _sessionFactory.Dispose();
            _sessionFactory = null;
            _configuration = null;
        }
    }
}
