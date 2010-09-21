using System.Runtime.Serialization;

namespace Draugen.Services.Dtos.Requests
{
    [DataContract]
    public class GetFangsterRequestBody
    {
        public int Page { get; set; }
    }
}