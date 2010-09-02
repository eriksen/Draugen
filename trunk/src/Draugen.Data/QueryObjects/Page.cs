using System;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Draugen.Data.QueryObjects
{
    internal class Page
    {
        internal int Number { get; private set; }
        internal int Size { get; private set; }

        internal Page(int number, int size)
        {
            Contract.Requires(number > 0);
            Contract.Requires(size > 0);
            Number = number;
            Size = size;
        }

        internal IQueryable<T> Refine<T>(IQueryable<T> queryable)
        {
            return queryable.Skip((Number - 1) * Size).Take(Size);
        }

        internal int Count
        {
            get { return 0; }
        }
    }
}