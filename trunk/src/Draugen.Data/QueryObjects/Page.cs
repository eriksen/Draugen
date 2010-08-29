using System.Diagnostics.Contracts;
using System.Linq;

namespace Draugen.Data.QueryObjects
{
    public class Page : IQuery
    {
        public Page(int number, int size)
        {
            Contract.Requires(number > 0);
            Contract.Requires(size > 0);
            Number = number;
            Size = size;
        }

        public int Number { get; private set; }
        public int Size { get; private set; }

        public IQueryable<T> Refine<T>(IQueryable<T> query) where T : class
        {
            Contract.Requires(query != null);
            return query.Skip((Number - 1) * Size).Take(Size);
        }

    }
}