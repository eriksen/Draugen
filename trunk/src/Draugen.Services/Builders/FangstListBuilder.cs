using System;
using System.Globalization;
using System.Linq;
using Draugen.Data.Repositories;
using Draugen.Services.Assemblers;
using Draugen.Services.Builders.Queries;
using Draugen.Services.Dtos;
using Draugen.Services.Dtos.Requests;

namespace Draugen.Services.Builders
{
    public class FangstListBuilder : IListBuilder<FangstListDto>
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

        public FangstListDto Build(ServiceHeader header)
        {
            var queryObject = _fangstQueryBuilder.Build();
            var fangster = _fangstRepository.FindAll(queryObject);
            var culture = new CultureInfo(header.Culture);
            var fanstList = new FangstListDto();
            throw new NotImplementedException();
            //return fangster.Select(f => _fangstAssembler.WriteDto(f, culture)).ToList();
        }

    }
}
