namespace Draugen.Services.Builders
{
    public interface IResponseBuilder<out TResponse, in TRequest>
    {
        TResponse Build(TRequest request);
    }
}