using System.Diagnostics.Contracts;
using Draugen.Data;
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
            this.RegisterType<ILocalContainer, LocalContainer>();
            this.RegisterType<IFangstService, FangstService>();
            this.RegisterType<IUnitOfWork, UnitOfWork>();
        }
    }
}