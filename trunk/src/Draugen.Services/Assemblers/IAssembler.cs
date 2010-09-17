using System;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace Draugen.Services.Assemblers
{
    [ContractClass(typeof(AssemblerContract<,>))]
    public interface IAssembler<TDto, TDomain>
        where TDomain : class
        where TDto : class
    {
        TDto WriteDto(TDomain domain, CultureInfo culture);
        TDomain Create(TDto dto);
    }

    [ContractClassFor(typeof(IAssembler<,>))]
    public abstract class AssemblerContract<TDto, TDomain> : IAssembler<TDto, TDomain> 
        where TDomain : class
        where TDto : class
    {
        public TDto WriteDto(TDomain domain, CultureInfo culture)
        {
            Contract.Requires(domain != null);
            Contract.Requires(culture != null);
            Contract.Ensures(Contract.Result<TDto>() != null);
            return default(TDto);
        }

        public TDomain Create(TDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
