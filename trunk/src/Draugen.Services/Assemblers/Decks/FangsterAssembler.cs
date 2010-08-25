using System;
using System.Collections.Generic;
using System.Linq;
using Draugen.Services.ViewData.Shared.Cards;
using Draugen.Services.ViewData.Shared.Decks;

namespace Draugen.Services.Assemblers.Decks
{
    public class FangsterAssembler : IAssembler<FangstDeck, IEnumerable<Fangst>>
    {
        private readonly IAssembler<FangstCard, Fangst> _fangstAssembler;

        public FangsterAssembler(IAssembler<FangstCard, Fangst> fangstAssembler)
        {
            _fangstAssembler = fangstAssembler;
        }

        public FangstDeck Create(IEnumerable<Fangst> domain)
        {
            var fangstDeck = new FangstDeck();
            fangstDeck.AddRange(domain.Select(d => _fangstAssembler.Create(d)));    
            return fangstDeck;
        }

        public IEnumerable<Fangst> Create(FangstDeck model)
        {
            throw new NotImplementedException();
        }
    }
}
