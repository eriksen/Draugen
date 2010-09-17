using System.Collections;
using System.Collections.Generic;

namespace Draugen.Data.Paging
{
    public interface IPage<out T> : IPageInfo, IEnumerable<T>
    {
    }
}