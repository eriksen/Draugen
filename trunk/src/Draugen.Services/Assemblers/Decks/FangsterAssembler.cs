using System;
using System.Collections.Generic;
using System.Linq;
using Draugen.Services.Assemblers.Cards;
using Draugen.Services.ViewModels.Decks;

namespace Draugen.Services.Assemblers.Decks
{
    public class FangsterAssembler : IAssembler<FangstDeck, IEnumerable<Fangst>>
    {
        private readonly FangstAssembler _fangstAssembler;

        public FangsterAssembler(FangstAssembler fangstAssembler)
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
