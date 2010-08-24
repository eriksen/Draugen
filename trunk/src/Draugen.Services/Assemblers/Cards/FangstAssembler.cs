using System;
using System.Diagnostics.Contracts;
using Draugen.Services.ViewData.Shared.Cards;

namespace Draugen.Services.Assemblers.Cards
{
    public class FangstAssembler : IAssembler<FangstCard, Fangst>
    {
        public FangstCard Create(Fangst domain)
        {
            Contract.Requires(domain != null);
            Contract.Requires(domain.Art != null);
            Contract.Requires(domain.Art.Navn != null);
            Contract.Requires(domain.Fisker != null);
            Contract.Requires(domain.Fisker.Navn != null);
            Contract.Requires(domain.Fisker.Team != null);
            Contract.Requires(domain.Fisker.Team.Navn != null);
            Contract.Requires(domain.Sted != null);
            Contract.Requires(domain.Sted.Navn != null);
            Contract.Requires(domain.Bilde != null);
            Contract.Requires(domain.Bilde.Thumb != null);
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
                           Bilde = new BildeCard{ Alt = domain.Art.Navn, Src = domain.Bilde.Thumb }                     
                       };
        }

        public Fangst Create(FangstCard model)
        {
            throw new NotImplementedException();
        }
    }
}
