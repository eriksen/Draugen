using Draugen.Model.Shared;
using Draugen.Services.Dtos;

namespace Draugen.Model.Hjem
{
    public class HjemModel : MasterModel
    {
        public FangstListDto Fangster { get; set; }
    }
}