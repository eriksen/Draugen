namespace Draugen.Services.Assemblers
{
    public interface IAssembler<TDto, TDomain>
    {
        TDto CreateDto(TDomain domain);
        TDomain Create(TDto dto);
    }
}