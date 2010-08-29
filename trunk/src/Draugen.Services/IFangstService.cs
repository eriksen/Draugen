using System;
using System.Diagnostics.Contracts;

namespace Draugen.Services
{
    [ContractClass(typeof(FangstServiceContracts))]
    public interface IFangstService
    {
        Fangst[] GetFangster(SortBy[] sortBy);
    }

    

    [ContractClassFor(typeof(IFangstService))]
    internal sealed class FangstServiceContracts : IFangstService
    {
        public Fangst[] GetFangster(SortBy[] sortBy)
        {
            throw new NotImplementedException();
        }
    }

}