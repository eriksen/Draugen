using System.Diagnostics.Contracts;
using System.Linq;

namespace Draugen.Data.QueryObjects
{
    internal class Page<T> : IQueryObject<T> where T : DomainObject
    {
        private readonly int _number;
        internal int Number
        {
            get { return _number; }
        }

        private readonly int _size;
        internal int Size
        {
            get { return _size; }
        }

        internal Page(int number, int size)
        {
            Contract.Requires(number > 0);
            Contract.Requires(size > 0);
            _number = number;
            _size = size;
        }

        public IQueryable<T> Query(IQueryable<T> queryable)
        {
            return queryable.Skip((Number - 1) * Size).Take(Size);
        }

        public void Validate()
        {
            
        }
    }
}