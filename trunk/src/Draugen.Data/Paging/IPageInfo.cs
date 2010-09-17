using System.Diagnostics.Contracts;

namespace Draugen.Data.Paging
{
    [ContractClass(typeof(PageInfoContract))]
    public interface IPageInfo
    {
        int TotalItems { get; }
        int TotalPages { get; }
        int Index { get; }
        int Size { get; }
    }

    [ContractClassFor(typeof(IPageInfo))]
    internal abstract class PageInfoContract : IPageInfo
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
    }

}