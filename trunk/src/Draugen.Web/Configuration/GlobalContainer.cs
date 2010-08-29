using System.Diagnostics.Contracts;
using Draugen.Data;
using Draugen.Services;
using Draugen.Services.Assemblers;
using Draugen.Services.Configuration;
using Draugen.Services.Dtos;
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
            this.RegisterType<IAssembler<FangstDto, Fangst>>();
        }
    }
}