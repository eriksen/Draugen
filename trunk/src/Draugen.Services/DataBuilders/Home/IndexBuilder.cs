using System.Collections.Generic;
using System.Linq;
using Draugen.Data.Repositories;
using Draugen.Services.Assemblers;
using Draugen.Services.ViewData.Home;
using Draugen.Services.ViewData.Shared.Decks;

namespace Draugen.Services.DataBuilders.Home
{
    public class IndexBuilder : IBuilder<IndexData>
    {
        private readonly IRepository<Fangst> _fangstRepository;
        private readonly IAssembler<FangstDeck, IEnumerable<Fangst>> _fangsterAssembler;
        private readonly IMasterBuilder _masterBuilder;

        public IndexBuilder(IMasterBuilder masterBuilder, IRepository<Fangst> fangstRepository, IAssembler<FangstDeck, IEnumerable<Fangst>> fangsterAssembler)
        {
            _masterBuilder = masterBuilder;
            _fangstRepository = fangstRepository;
            _fangsterAssembler = fangsterAssembler;
        }

        public IndexData Build()
        {
            var data = _masterBuilder.Create<IndexData>();
            data.Fangster = _fangsterAssembler.Create(_fangstRepository.FindAll());
            return data;
        }

    }
}
