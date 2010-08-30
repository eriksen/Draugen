using System.ServiceModel;

namespace Draugen.Services.Dtos.Requests
{
    [MessageContract]
    public class GetFangsterRequest
    {
        [MessageHeader]
        public ServiceHeader Header { get; set; }

        [MessageBodyMember]
        public GetFangsterRequestBody Body { get; set; }
    }
}
