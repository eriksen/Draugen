using System.Diagnostics.Contracts;
using Draugen.Data;
using Draugen.Data.Repositories;
using Draugen.Services;
using Microsoft.Practices.Unity;
using NHibernate;

namespace Draugen.Web.Setup
{
    public class DraugenUnityContainer : UnityContainer
    {
        public DraugenUnityContainer(ISessionFactory sessionFactory)
        {
            Contract.Requires(sessionFactory != null);
            this.RegisterInstance(this);
            this.RegisterInstance(sessionFactory);
            this.RegisterType<IUnitOfWork, UnitOfWork>();
            this.RegisterType<IUnitOfWorkFactory, UnitOfWorkFactory>();
            this.RegisterType<IRepository<Fangst>, Repository<Fangst>>();
            this.RegisterType<IFangstService, FangstService>();
        }
    }
}