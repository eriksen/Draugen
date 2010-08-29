using System;
using Draugen.Services.Dtos;

namespace Draugen.Services.Assemblers
{
    public class FangstAssembler : IAssembler<FangstDto, Fangst>
    {
        public FangstDto WriteDto(Fangst domain)
        {
            return new FangstDto()
                       {
                           Art = domain.Art.Navn,
                           Dato = domain.Dato.ToString(),
                           Fisker = domain.Fisker.Navn,
                           Lengde = domain.Lengde.ToString(),
                           Poeng = domain.Poeng.ToString(),
                           Sted = domain.Sted.Navn,
                           Vekt = domain.Vekt.ToString()
                       };
        }

        public Fangst Create(FangstDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
