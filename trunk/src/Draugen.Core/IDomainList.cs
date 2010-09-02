using System.Collections;

namespace Draugen.Data.Repositories
{
    public interface IDomainList : IEnumerable
    {
        int Count { get; set; }
    }
}