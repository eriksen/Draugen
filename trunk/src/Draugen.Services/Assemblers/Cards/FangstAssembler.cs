using System;
using System.Diagnostics.Contracts;
using Draugen.Services.ViewData.Shared.Cards;

namespace Draugen.Services.Assemblers.Cards
{
    public class FangstAssembler : IAssembler<FangstCard, Fangst>
    {
        public FangstCard Create(Fangst domain)
        {
            Contract.Ensures(Contract.Result<FangstCard>() != null);
            return new FangstCard()
                       {
                           Art = domain.Art.Navn,
                           Dato = domain.Dato.ToString("dd.MM.yyyy"),
                           Fisker = domain.Fisker.Navn,
                           Lengde = domain.Lengde.ToString(),
                           Poeng = domain.Poeng().ToString(),
                           Sted = domain.Sted.Navn,
                           Vekt = domain.Vekt.ToString(),
                           Team = domain.Fisker.Team.Navn,
                           Bilde = new BildeCard{ Alt = domain.Art.Navn, Navn = domain.Bilde.Navn }                     
                       };
        }
    }
}
