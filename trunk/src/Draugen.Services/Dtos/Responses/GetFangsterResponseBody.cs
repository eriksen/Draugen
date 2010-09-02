using System.Runtime.Serialization;

namespace Draugen.Services.Dtos.Responses
{
    [DataContract]
    public class GetFangsterResponseBody
    {
        [DataMember]
        public FangstListDto FangstList { get; set; }
    }
}