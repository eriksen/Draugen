using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Draugen.Data;
using Draugen.Data.Repositories;
using Draugen.Services;
using Draugen.Services.Assemblers;
using Draugen.Services.Assemblers.Cards;
using Draugen.Services.Assemblers.Decks;
using Draugen.Services.Builders.Pages;
using Draugen.Services.ViewModels.Cards;
using Draugen.Services.ViewModels.Decks;
using Draugen.Services.ViewModels.Pages;
using Microsoft.Practices.Unity;
using NHibernate;

namespace Draugen.Setup
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
            this.RegisterType<IBuilder<HomePageData>, HomePageDataBuilder>();
            this.RegisterType<IPageService, PageService>();

            this.RegisterType<IAssembler<FangstCard, Fangst>, FangstCardAssembler>();
            this.RegisterType<IAssembler<FangstDeck, IEnumerable<Fangst>>, FangstDeckAssembler>();
        }
    }
}