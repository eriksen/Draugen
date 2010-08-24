using System.Diagnostics.Contracts;
using Draugen.Services.Builders.Pages;
using Draugen.Services.ViewModels.Pages;
using Microsoft.Practices.Unity;

namespace Draugen.Services
{
    public class PageService : ServiceBase, IPageService
    {
        public PageService(IUnityContainer container) : base(container){}

        public HomePageData GetHomePageData()
        {
            Contract.Ensures(Contract.Result<HomePageData>() != null);
            using(UnitOfWorkFactory.Create())
            {
                return Container.Resolve<IBuilder<HomePageData>>().Build();
            }
        }

    }
}