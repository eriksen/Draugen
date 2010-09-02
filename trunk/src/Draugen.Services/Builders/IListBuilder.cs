using Draugen.Services.Dtos.Requests;

namespace Draugen.Services.Builders
{
    public interface IListBuilder<out T>    
    {
        T Build(ServiceHeader header);
    }
}