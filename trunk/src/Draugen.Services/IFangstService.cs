using System;
using System.Diagnostics.Contracts;
using Draugen.Services.Dtos.Requests;
using Draugen.Services.Dtos.Responses;

namespace Draugen.Services
{
    [ContractClass(typeof(FangstServiceContract))]
    public interface IFangstService
    {
        GetFangsterResponse GetFangster(GetFangsterRequest request);
    }

    [ContractClassFor(typeof(IFangstService))]
    public abstract class FangstServiceContract : IFangstService
    {
        public GetFangsterResponse GetFangster(GetFangsterRequest request)
        {
            Contract.Requires(request != null);
            Contract.Requires(request.Header != null);
            Contract.Requires(request.Header.Culture != null);
            Contract.Requires(request.Body != null);
            
            Contract.Ensures(Contract.Result<GetFangsterResponse>() != null);
            Contract.Ensures(Contract.Result<GetFangsterResponse>().Body != null);
            Contract.Ensures(Contract.Result<GetFangsterResponse>().Body.FangstList != null);

            return default(GetFangsterResponse);
        }
    }
}