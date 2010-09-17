using System.Collections.Generic;

namespace Draugen.Services.Dtos
{
    public class FangstListDto : List<FangstDto>
    {
        public FangstListDto(IEnumerable<FangstDto> fangster)
        {
            AddRange(fangster);
        }

        public PageInfoDto PageInfo { get; set; }
    }
}
