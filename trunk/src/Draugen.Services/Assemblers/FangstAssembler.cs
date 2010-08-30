using System;
using System.Globalization;
using Draugen.Services.Dtos;

namespace Draugen.Services.Assemblers
{
    public class FangstAssembler : IAssembler<FangstDto, Fangst>
    {
        public FangstDto WriteDto(Fangst domain, CultureInfo culture)
        {
            return new FangstDto()
                       {
                           Art = domain.Art.Navn,
                           Dato =  domain.Dato.Date.ToString(culture).Substring(0, 10),
                           Fisker = domain.Fisker.Navn,
                           Lengde = domain.Lengde.ToString(culture),
                           Poeng = Math.Floor(domain.Poeng).ToString(culture),
                           Sted = domain.Sted.Navn,
                           Vekt = domain.Vekt.ToString("0.000", culture)
                       };
        }

        public Fangst Create(FangstDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
