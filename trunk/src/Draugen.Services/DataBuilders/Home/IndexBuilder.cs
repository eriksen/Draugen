using System.Collections.Generic;
using Draugen.Data.Repositories;
using Draugen.Services.Assemblers;
using Draugen.Services.DataBuilders.Shared;
using Draugen.Services.ViewModels.Decks;
using Draugen.Services.ViewModels.Pages;

namespace Draugen.Services.DataBuilders.Home
{
    public class IndexBuilder : IBuilder<IndexData>
    {
        private readonly IRepository<Fangst> _fangstRepository;
        private readonly IAssembler<FangstDeck, IEnumerable<Fangst>> _fangstDeckAssembler;
        private readonly IMasterBuilder _masterBuilder;

        public IndexBuilder(IMasterBuilder masterBuilder, IRepository<Fangst> fangstRepository, IAssembler<FangstDeck, IEnumerable<Fangst>> fangstDeckAssembler)
        {
            _masterBuilder = masterBuilder;
            _fangstRepository = fangstRepository;
            _fangstDeckAssembler = fangstDeckAssembler;
        }

        public IndexData Build()
        {
            var page = _masterBuilder.Create<IndexData>();
            page.Fangster = _fangstDeckAssembler.Create(_fangstRepository.FindAll());
            return page;
        }

    }
}
