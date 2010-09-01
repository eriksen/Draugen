using System.Globalization;
using System.Linq;
using Draugen.Data.Repositories;
using Draugen.Services.Assemblers;
using Draugen.Services.Builders.Queries;
using Draugen.Services.Dtos;
using Draugen.Services.Dtos.Requests;

namespace Draugen.Services.Builders
{
    public class FangstListBuilder : IListBuilder<FangstDto>
    {
        private readonly IAssembler<FangstDto, Fangst> _fangstAssembler;
        private readonly IRepository<Fangst> _fangstRepository;
        private readonly IQueryBuilder<Fangst> _fangstQueryBuilder;

        public FangstListBuilder(IQueryBuilder<Fangst> fangstQueryBuilder, IRepository<Fangst> fangstRepository, IAssembler<FangstDto, Fangst> fangstAssembler)
        {
            _fangstQueryBuilder = fangstQueryBuilder;
            _fangstRepository = fangstRepository;
            _fangstAssembler = fangstAssembler;
        }

        public FangstDto[] Build(ServiceHeader header)
        {

            var fangster = _fangstRepository.FindAll(_fangstQueryBuilder.Build());
            var culture = new CultureInfo(header.Culture);
            return fangster.Select(f => _fangstAssembler.WriteDto(f, culture)).ToArray();
        }

    }
}
