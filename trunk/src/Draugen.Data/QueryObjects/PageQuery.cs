﻿using System.Diagnostics.Contracts;
using System.Linq;

namespace Draugen.Data.QueryObjects
{
    internal class PageQuery<T> : IQueryObject<T> where T : DomainObject
    {
        private readonly int _index;
        internal int Index
        {
            get { return _index; }
        }

        private readonly int _size;
        internal int Size
        {
            get { return _size; }
        }

        internal PageQuery(int index, int size)
        {
            Contract.Requires(index > 0);
            Contract.Requires(size > 0);
            _index = index;
            _size = size;
        }

        public IQueryable<T> Query(IQueryable<T> queryable)
        {
            return queryable.Skip((Index - 1) * Size).Take(Size);
        }

        public void Validate()
        {

        }
    }
}