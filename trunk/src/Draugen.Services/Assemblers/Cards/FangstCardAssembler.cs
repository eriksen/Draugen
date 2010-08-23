using System;
using Draugen.Services.ViewModels.Cards;

namespace Draugen.Services.Assemblers.Cards
{
    public class FangstCardAssembler : IAssembler<FangstCard, Fangst>
    {
        public FangstCard Create(Fangst domain)
        {
            return new FangstCard()
                       {
                           Art = domain.Art.Navn,
                           Dato = domain.Dato.Date.ToString(),
                           Fisker = domain.Fisker.Navn,
                           Lengde = domain.Lengde.ToString(),
                           Poeng = domain.Poeng().ToString(),
                           Sted = domain.Sted.Navn,
                           Vekt = domain.Vekt.ToString(),
                           Team = domain.Fisker.Team.Navn,
                           Image = domain.Thumbnail()
                      };
        }

        public Fangst Create(FangstCard model)
        {
            throw new NotImplementedException();
        }
    }
}
