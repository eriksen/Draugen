using System.Collections.Generic;
using Draugen.Data;
using Draugen.Data.Repositories;
using Draugen.Services.Assemblers;
using Draugen.Services.Assemblers.Cards;
using Draugen.Services.Assemblers.Decks;
using Draugen.Services.DataBuilders;
using Draugen.Services.DataBuilders.Home;
using Draugen.Services.DataBuilders.Shared;
using Draugen.Services.ViewData.Home;
using Draugen.Services.ViewData.Shared.Cards;
using Draugen.Services.ViewData.Shared.Decks;
using Microsoft.Practices.Unity;
    
namespace Draugen.Services.Configuration
{
    public class LocalContainer : UnityContainer, ILocalContainer
    {
        private readonly IUnitOfWork _unitOfWork;

        public LocalContainer(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            this.RegisterInstance(_unitOfWork.Session);

            this.RegisterType<IViewDataService,ViewDataService>();
            this.RegisterType<IMasterBuilder,MasterBuilder>();
            this.RegisterType<IBuilder<IndexData>,IndexBuilder>();
            this.RegisterType<IAssembler<FangstCard, Fangst>,FangstAssembler>();
            this.RegisterType<IAssembler<FangstDeck, IEnumerable<Fangst>>,FangsterAssembler>();
            this.RegisterType<IRepository<Fangst>,Repository<Fangst>>();

        }

        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}