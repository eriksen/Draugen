using Draugen.Services.Dtos.Requests;

namespace Draugen.Services.Builders
{
    public interface IListBuilder<out T>    
    {
        T BuildFangstList(ServiceHeader header);
    }
}