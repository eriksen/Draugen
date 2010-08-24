using System.Collections.Generic;
using Draugen.Data.Repositories;
using Draugen.Services.Assemblers;
using Draugen.Services.ViewModels.Decks;
using Draugen.Services.ViewModels.Pages;

namespace Draugen.Services.Builders.Pages
{
    public interface IBuilder<out T> 
    {
        T Build();
    }

    public class HomePageDataBuilder : MasterPageDataBuilder, IBuilder<HomePageData>
    {
        private readonly IRepository<Fangst> _fangstRepository;
        private readonly IAssembler<FangstDeck, IEnumerable<Fangst>> _fangstDeckAssembler;

        public HomePageDataBuilder(IRepository<Fangst> fangstRepository, IAssembler<FangstDeck, IEnumerable<Fangst>> fangstDeckAssembler)
        {
            _fangstRepository = fangstRepository;
            _fangstDeckAssembler = fangstDeckAssembler;
        }

        public HomePageData Build()
        {
            var page = Create<HomePageData>();
            page.Fangster = _fangstDeckAssembler.Create(_fangstRepository.FindAll());
            return page;
        }

    }
}
