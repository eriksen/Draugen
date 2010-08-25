using System;
using System.Diagnostics.Contracts;

namespace Draugen.Services.Assemblers
{
    [ContractClass(typeof(AssemblerContract<,>))]
    public interface IAssembler<TModel, TDomain>
        where TDomain : class
        where TModel : class 
    {
        TModel Create(TDomain domain);
    }

    [ContractClassFor(typeof(IAssembler<,>))]
    internal abstract class AssemblerContract<TModel, TDomain> : IAssembler<TModel, TDomain>
        where TDomain : class
        where TModel : class 
    {
        public TModel Create(TDomain domain) 
        {
            Contract.Requires(domain != null);
            throw new NotImplementedException();
        }
    }
}