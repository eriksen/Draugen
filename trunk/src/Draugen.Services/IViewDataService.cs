using Draugen.Services.ViewData.Home;

namespace Draugen.Services
{
    public interface IViewDataService
    {
        IndexData GetHomePageData();
    }
}