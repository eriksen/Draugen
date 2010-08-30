using System.Runtime.Serialization;

namespace Draugen.Services.Dtos.Responses
{
    [DataContract]
    public class GetFangsterResponseBody
    {
        [DataMember]
        public FangstDto[] FangstList { get; set; }
    }
}