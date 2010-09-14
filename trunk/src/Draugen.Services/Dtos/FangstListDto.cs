using System.Collections.Generic;

namespace Draugen.Services.Dtos
{
    public class FangstListDto : List<FangstDto>
    {
        public FangstListDto(IEnumerable<FangstDto> fangster)
        {
            AddRange(fangster);
        }
        public int CurrentPage { get; set; }
        public int Pages { get; set; }
    }
}
