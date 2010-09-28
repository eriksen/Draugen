using System;
using System.Globalization;
using System.Linq;
using Draugen.Data.Paging;
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
        private readonly IAssembler<PageInfoDto, IPageInfo> _pageInfoAssembler;

        public FangstListBuilder(
            IQueryBuilder<Fangst> fangstQueryBuilder, 
            IRepository<Fangst> fangstRepository, 
            IAssembler<FangstDto, Fangst> fangstAssembler, 
            IAssembler<PageInfoDto, IPageInfo> pageInfoAssembler)
        {
            _pageInfoAssembler = pageInfoAssembler;
            _fangstQueryBuilder = fangstQueryBuilder;
            _fangstRepository = fangstRepository;
            _fangstAssembler = fangstAssembler;
        }

        public FangstListDto Build(string culture1, int page)
        {
            var queryObject = _fangstQueryBuilder.Build();
            var fangstPage = _fangstRepository.FindAll(queryObject);
            var culture = new CultureInfo(culture1.Culture);
            return new FangstListDto(fangstPage.Select(f => _fangstAssembler.WriteDto(f, culture)).ToList())
                                {
                                    PageInfo = _pageInfoAssembler.WriteDto(fangstPage, culture)
                                };
        }

    }
}
