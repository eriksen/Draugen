using Draugen.Services.ViewData.Shared;

namespace Draugen.Services.DataBuilders
{
    public interface IMasterBuilder 
    {
        T Create<T>() where T : MasterData, new();
    }
}