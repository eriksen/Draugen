using System.Diagnostics.Contracts;
using System.Linq;

namespace Draugen.Data.QueryObjects
{
    public class Page : IQueryObject
    {
        private readonly int _number;
        private readonly int _size;

        public Page(int number, int size)
        {
            Contract.Requires(number > 0);
            Contract.Requires(size > 0);
            _number = number;
            _size = size;
        }

        public IQueryable<T> Refine<T>(IQueryable<T> query) where T : class
        {
            return query.Skip((_number - 1) * _size).Take(_size);
        }

    }
}