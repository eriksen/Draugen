using System.Globalization;
using System.Linq;
using Draugen.Data.QueryObjects;
using Draugen.Data.Repositories;
using Draugen.Services.Assemblers;
using Draugen.Services.Dtos;
using Draugen.Services.Dtos.Requests;

namespace Draugen.Services.Builders
{
    public class FangstListBuilder : IListBuilder<FangstDto>
    {
        private readonly IAssembler<FangstDto, Fangst> _fangstAssembler;
        private readonly IRepository<Fangst> _fangstRepository;
        private readonly IListBuilder<IQueryObject> _queryObjectListBuilder;

        public FangstListBuilder(IRepository<Fangst> fangstRepository, IAssembler<FangstDto, Fangst> fangstAssembler, IListBuilder<IQueryObject> queryObjectListBuilder)
        {
            _queryObjectListBuilder = queryObjectListBuilder;
            _fangstRepository = fangstRepository;
            _fangstAssembler = fangstAssembler;
        }

        public FangstDto[] Build(ServiceHeader header)
        {
            var fangster = _fangstRepository.FindAll(_queryObjectListBuilder.Build(header));
            var culture = new CultureInfo(header.Culture);
            return fangster.Select(f => _fangstAssembler.WriteDto(f, culture)).ToArray();
        }

        
    }
}
