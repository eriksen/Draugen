using System.Globalization;
using System.Linq;
using Draugen.Data.QueryObjects;
using Draugen.Data.Repositories;
using Draugen.Services.Assemblers;
using Draugen.Services.Dtos;
using Draugen.Services.Dtos.Requests;
using Draugen.Services.Dtos.Responses;

namespace Draugen.Services.Builders
{
    public class GetFangsterResponseBuilder : IResponseBuilder<GetFangsterResponse, GetFangsterRequest>
    {
        private readonly IRepository<Fangst> _fangstRepository;
        private readonly IAssembler<FangstDto, Fangst> _fangstAssembler;

        public GetFangsterResponseBuilder(IRepository<Fangst> fangstRepository, IAssembler<FangstDto, Fangst> fangstAssembler)
        {
            _fangstAssembler = fangstAssembler;
            _fangstRepository = fangstRepository;
        }

        public GetFangsterResponse Build(GetFangsterRequest request)
        {
            return new GetFangsterResponse
                       {
                           Body = BuildBody(request)
                       };
        }

        private GetFangsterResponseBody BuildBody(GetFangsterRequest request)
        {
            return new GetFangsterResponseBody()
                       {
                           FangstList = BuildFangstList(request)
                       };
        }

        private FangstDto[] BuildFangstList(GetFangsterRequest request)
        {
            var queryObjects = new IQueryObject[]
                                   {
                                       new Sort("Poeng", SortDirection.Descending),
                                       new Page(2, 25)
                                   };
            var fangster = _fangstRepository.FindAll(queryObjects);
            var culture = new CultureInfo(request.Header.Culture);
            
            return fangster.Select(f => _fangstAssembler.WriteDto(f, culture)).ToArray();
        }
    }
}
