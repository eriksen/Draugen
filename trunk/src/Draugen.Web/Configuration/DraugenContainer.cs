using System.Diagnostics.Contracts;
using Draugen.Data;
using Draugen.Services;
using Draugen.Services.Configuration;
using Microsoft.Practices.Unity;
using NHibernate;

namespace Draugen.Configuration
{
    public class DraugenContainer : UnityContainer
    {
        public DraugenContainer(ISessionFactory sessionFactory)
        {
            Contract.Requires(sessionFactory != null);
            this.RegisterInstance(sessionFactory);
            this.RegisterInstance<IUnityContainer>(this);
            this.RegisterType<ILocalContainer, LocalContainer>();
            this.RegisterType<IViewDataService, ViewDataService>();
            this.RegisterType<IUnitOfWork, UnitOfWork>();
        }

        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                this.Resolve<ISessionFactory>().Dispose();
            }
            base.Dispose(disposing);
        }
    }
}