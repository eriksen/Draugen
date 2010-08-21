namespace Draugen.Services.Assemblers
{
    public interface IAssembler<TModel, TDomain>
    {
        TModel Create(TDomain domain);
        TDomain Create(TModel model);
    }
}