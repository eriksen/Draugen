using System.Collections.Generic;

namespace Draugen.Services
{
    public interface IFangstService
    {
        IEnumerable<Fangst> GetFangster();
    }
}