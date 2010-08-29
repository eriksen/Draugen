namespace Draugen.Services.Assemblers
{
    public interface IAssembler<TDto, TDomain>
    {
        TDto WriteDto(TDomain domain);
        TDomain Create(TDto dto);
    }
}
