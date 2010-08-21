using System;
using System.Collections.Generic;
using System.Linq;
using Draugen.Services.Assemblers.Cards;
using Draugen.Services.ViewModels.Cards;
using Draugen.Services.ViewModels.Decks;

namespace Draugen.Services.Assemblers.Decks
{
    public class FangstDeckAssembler : IAssembler<FangstDeck, IEnumerable<Fangst>>
    {
        private readonly FangstCardAssembler _fangstCardAssembler;

        public FangstDeckAssembler(FangstCardAssembler fangstCardAssembler)
        {
            _fangstCardAssembler = fangstCardAssembler;
        }

        public FangstDeck Create(IEnumerable<Fangst> domain)
        {
            var fangstDeck = new FangstDeck();
            fangstDeck.AddRange(domain.Select(d => _fangstCardAssembler.Create(d)));
            return fangstDeck;
        }

        public IEnumerable<Fangst> Create(FangstDeck model)
        {
            throw new NotImplementedException();
        }
    }
}
