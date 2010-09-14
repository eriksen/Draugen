using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Draugen.Data.Paging
{
    [ContractClass(typeof(PageContracts<>))]
    public interface IPage<out T> : IEnumerable<T>
    {
        int TotalItems { get; }
        int TotalPages { get; }
        int Index { get; }
        int Size { get; }
    }

    [ContractClassFor(typeof(IPage<>))]
    internal abstract class PageContracts<T> : IPage<T>
    {

        public int TotalItems
        {
            get { Contract.Ensures(Contract.Result<int>() >= 0); return default(int); }
        }

        public int TotalPages
        {
            get { Contract.Ensures(Contract.Result<int>() > 0); return default(int); }
        }

        public int Index
        {
            get { Contract.Ensures(Contract.Result<int>() > 0); return default(int); }
        }

        public int Size
        {
            get { Contract.Ensures(Contract.Result<int>() > 0); return default(int); }
        }

        public abstract IEnumerator<T> GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
        {
            return default(IEnumerator);
        }
    }
}