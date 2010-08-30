using Draugen.Data;
using Microsoft.Practices.Unity;
using NHibernate;

namespace Draugen.Services.Configuration
{
    public class ServiceContainer : UnityContainer
    {
        public ServiceContainer(ISessionFactory sessionFactory)
        {
            this.RegisterInstance(sessionFactory);
            this.RegisterType<IUnityContainer, PerCallContainer>();
            this.RegisterType<IUnitOfWork, UnitOfWork>();
        }
    }
}
