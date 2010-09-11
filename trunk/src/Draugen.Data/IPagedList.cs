using System.Collections.Generic;

namespace Draugen.Data
{
    public interface IPagedList<out T> : IEnumerable<T>
    {
        int TotalItemCount { get; }
    }
}