using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Draugen.Data;
using Draugen.Data.Repositories;
using Draugen.Services;
using Draugen.Services.Assemblers;
using Draugen.Services.Assemblers.Cards;
using Draugen.Services.Assemblers.Decks;
using Draugen.Services.DataBuilders;
using Draugen.Services.DataBuilders.Home;
using Draugen.Services.DataBuilders.Shared;
using Draugen.Services.ViewData.Shared.Cards;
using Draugen.Services.ViewModels.Decks;
using Draugen.Services.ViewModels.Pages;
using Microsoft.Practices.Unity;
using NHibernate;

namespace Draugen.Initialize
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

            this.RegisterType<IViewDataService, ViewDataService>();
            this.RegisterType<IMasterBuilder, MasterBuilder>();
            this.RegisterType<IBuilder<IndexData>, IndexBuilder>();
            this.RegisterType<IAssembler<FangstCard, Fangst>, FangstAssembler>();
            this.RegisterType<IAssembler<FangstDeck, IEnumerable<Fangst>>, FangsterAssembler>();
        }
    }
}