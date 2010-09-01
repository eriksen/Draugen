using System;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Draugen.Data.QueryObjects
{
    public class Page : IQueryObject
    {
        public int Number { get; private set; }
        public int Size { get; private set; }

        public Page(int number, int size)
        {
            Contract.Requires(number > 0);
            Contract.Requires(size > 0);
            Number = number;
            Size = size;
        }

        public IQueryable<T> Refine<T>(IQueryable<T> queryable) where T : class
        {
            return queryable.Skip((Number - 1) * Size).Take(Size);
        }

    }
}