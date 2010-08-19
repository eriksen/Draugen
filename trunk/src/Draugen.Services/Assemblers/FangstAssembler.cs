using System;
using System.Linq;
using Draugen.Services.ViewModels.Dtos;

namespace Draugen.Services.Assemblers
{
    public class FangstAssembler : IAssembler<ViewModels.Dtos.Fangst, Fangst>
    {
        private readonly KommentarAssembler _kommentarAssembler;

        public FangstAssembler(KommentarAssembler kommentarAssembler)
        {
            _kommentarAssembler = kommentarAssembler;
        }

        #region IAssembler<Fangst,Fangst> Members

        public ViewModels.Dtos.Fangst CreateDto(Fangst domain)
        {
            return new ViewModels.Dtos.Fangst
                       {
                           Art = new ArtDto {Id = domain.Art.Id, Navn = domain.Art.Navn},
                           Dato = domain.Dato.Date.ToString(),
                           Fisker = new FiskerDto {Id = domain.Fisker.Id, Navn = domain.Fisker.Navn},
                           Id = domain.Id.ToString(),
                           Kommentarer = domain.Kommentarer.Select(k => _kommentarAssembler.CreateDto(k)).ToArray(),
                           Lengde = domain.Lengde.ToString(),
                           Poeng = domain.Poeng().ToString(),
                           Sted = new StedDto {Navn = domain.Sted.Navn},
                           Team = new TeamDto {Navn = domain.Fisker.Team.Navn},
                           Vekt = domain.Vekt.ToString()
                       };
        }

        public Fangst Create(ViewModels.Dtos.Fangst dto)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}