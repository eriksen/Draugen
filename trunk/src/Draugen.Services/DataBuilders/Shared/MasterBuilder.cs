using Draugen.Services.ViewData.Shared;

namespace Draugen.Services.DataBuilders.Shared
{
    public class MasterBuilder : IMasterBuilder
    {
        public T Create<T>() where T : MasterData, new()
        {
            return new T {Tittel = "Draugen en to tre..."};
        }
    }
}
