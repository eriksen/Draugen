﻿using System.Diagnostics.Contracts;
using Draugen.Model.Hjem;
using Draugen.ModelFactories;
using Draugen.ModelFactories.Home;
using Draugen.Services;
using Draugen.Services.Configuration;
using Microsoft.Practices.Unity;
using NHibernate;

namespace Draugen.Configuration
{
    public class GlobalContainer : UnityContainer
    {
        public GlobalContainer(ISessionFactory sessionFactory)
        {
            Contract.Requires(sessionFactory != null);
            this.RegisterInstance(sessionFactory);
            this.RegisterInstance<IUnityContainer>(this);
            this.RegisterType<IUnityContainer, ServiceContainer>("Service");
            this.RegisterType<IFangstService, FangstService>();
            this.RegisterType<IFangsterFactory<HjemModel>, FangsterFactory>();
        }
    }
}