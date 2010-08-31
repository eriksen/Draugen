using Draugen.Services.Dtos;
using Draugen.Services.Dtos.Requests;
using Draugen.Services.Dtos.Responses;

namespace Draugen.Services.Builders
{
    public class GetFangsterResponseBuilder : IResponseBuilder<GetFangsterResponse, GetFangsterRequest>
    {
        private readonly IListBuilder<FangstDto[]> _fangstBuilder;

        public GetFangsterResponseBuilder(IListBuilder<FangstDto[]> fangstBuilder)
        {
            _fangstBuilder = fangstBuilder;
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
                           FangstList = _fangstBuilder.BuildFangstList(request.Header)
                       };
        }

    }
}
