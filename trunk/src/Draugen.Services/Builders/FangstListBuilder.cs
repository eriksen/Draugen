using System.Globalization;
using System.Linq;
using Draugen.Data.QueryObjects;
using Draugen.Data.Repositories;
using Draugen.Services.Assemblers;
using Draugen.Services.Dtos;
using Draugen.Services.Dtos.Requests;

namespace Draugen.Services.Builders
{
    public class FangstListBuilder : IListBuilder<FangstDto[]>
    {
        private readonly IAssembler<FangstDto, Fangst> _fangstAssembler;
        private readonly IRepository<Fangst> _fangstRepository;

        public FangstListBuilder(IRepository<Fangst> fangstRepository, IAssembler<FangstDto, Fangst> fangstAssembler)
        {
            _fangstRepository = fangstRepository;
            _fangstAssembler = fangstAssembler;
        }

        public FangstDto[] BuildFangstList(ServiceHeader header)
        {
            var queryObjects = new IQueryObject[]
                                   {
                                       new Sort("Poeng", SortDirection.Descending),
                                       new Page(10, 25)
                                   };
            var fangster = _fangstRepository.FindAll(queryObjects);
            var culture = new CultureInfo(header.Culture);

            return fangster.Select(f => _fangstAssembler.WriteDto(f, culture)).ToArray();
        }

    }
}
