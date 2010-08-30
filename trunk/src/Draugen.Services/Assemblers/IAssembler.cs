using System.Globalization;

namespace Draugen.Services.Assemblers
{
    public interface IAssembler<TDto, TDomain>
    {
        TDto WriteDto(TDomain domain, CultureInfo culture);
        TDomain Create(TDto dto);
    }
}
