﻿using Draugen.Services.Dtos;
using Draugen.Services.Dtos.Requests;
using Draugen.Services.Dtos.Responses;

namespace Draugen.Services.Builders.Responses
{
    public class GetFangsterResponseBuilder : IResponseBuilder<GetFangsterResponse, GetFangsterRequest>
    {
        private readonly IListBuilder<FangstListDto> _fangstListBuilder;

        public GetFangsterResponseBuilder(IListBuilder<FangstListDto> fangstListBuilder)
        {
            _fangstListBuilder = fangstListBuilder;
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
            return new GetFangsterResponseBody
                       {
                           FangstList = _fangstListBuilder.Build(request.Header.Culture, request.Body.Page)
                       };
        }

    }
}
