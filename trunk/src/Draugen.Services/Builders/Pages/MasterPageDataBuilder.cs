using Draugen.Services.ViewModels.Pages;

namespace Draugen.Services.Builders.Pages
{
    public abstract class MasterPageDataBuilder
    {
        public T Create<T>() where T : MasterPageData, new()
        {
            return new T {Tittel = "Draugen en to tre..."};
        }
    }
}
