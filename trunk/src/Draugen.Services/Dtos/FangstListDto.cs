using System.Collections.Generic;

namespace Draugen.Services.Dtos
{
    public class FangstListDto : List<Fangst>
    {
        public int CurrentPage { get; set; }
        public int Pages { get; set; }
    }
}
