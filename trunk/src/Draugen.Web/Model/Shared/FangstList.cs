using System.Collections;
using System.Collections.Generic;
using Draugen.Services.Dtos;

namespace Draugen.Model.Shared
{
    public class FangstList : IEnumerable<FangstDto>
    {
        private readonly IEnumerable<FangstDto> _fangster;

        public FangstList(IEnumerable<FangstDto> fangster)
        {
            _fangster = fangster;
        }

        public IEnumerator<FangstDto> GetEnumerator()
        {
            return _fangster.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}