using Draugen.Services.Dtos.Requests;
using Draugen.Services.Dtos.Responses;

namespace Draugen.Services
{
    public interface IFangstService
    {
        GetFangsterResponse GetFangster(GetFangsterRequest request);
    }
}