using System.ServiceModel;
using Draugen.Services.Dtos.Requests;

namespace Draugen.Services.Dtos.Responses
{
    [MessageContract]
    public class GetFangsterResponse
    {
        [MessageBodyMember]
        public GetFangsterResponseBody Body { get; set; }
    }
}