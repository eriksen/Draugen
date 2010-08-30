using System.Runtime.Serialization;

namespace Draugen.Services.Dtos.Requests
{
    [DataContract]
    public class ServiceHeader
    {
        [DataMember]
        public string Culture { get; set; }
    }
}