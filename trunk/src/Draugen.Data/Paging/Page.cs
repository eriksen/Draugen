using System;
using System.Collections.Generic;

namespace Draugen.Data.Paging
{
    public class Page<T> : List<T>, IPage<T>
    {
        public int TotalItems { get; internal set; }
        public int TotalPages 
        {
            get
            {
                return (int) Math.Ceiling((double)TotalItems / (double)Size);
            }
        }
        public int Index { get; internal set; }
        private int _size1 = 1;
        public int Size
        {
            get { return _size1; }
            internal set { _size1 = value; }
        }
    }
}