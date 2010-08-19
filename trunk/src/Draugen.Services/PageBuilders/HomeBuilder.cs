using System.Collections.Generic;
using System.Linq;
using Draugen.Services.Assemblers;
using Draugen.Services.ViewModels.Pages;

namespace Draugen.Services.PageBuilders
{
    public class HomeBuilder
    {
        private readonly FangstAssembler _fangstAssembler;

        public HomeBuilder(FangstAssembler fangstAssembler)
        {
            _fangstAssembler = fangstAssembler;
        }

        public HomeData Build(IEnumerable<Fangst> fangster)
        {
            IEnumerable<ViewModels.Dtos.Fangst> fangsterDto = fangster.Select(f => _fangstAssembler.CreateDto(f));
            return new HomeData
                       {
                           Fangster = fangsterDto.ToArray()
                       };
        }
    }
}