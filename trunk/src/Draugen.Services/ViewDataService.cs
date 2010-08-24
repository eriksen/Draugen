using System.Diagnostics.Contracts;
using Draugen.Services.DataBuilders;
using Draugen.Services.DataBuilders.Home;
using Draugen.Services.DataBuilders.Shared;
using Draugen.Services.ViewModels.Pages;
using Microsoft.Practices.Unity;

namespace Draugen.Services
{
    public class ViewDataService : ServiceBase, IViewDataService
    {
        public ViewDataService(IUnityContainer container) : base(container){}

        public IndexData GetHomePageData()
        {
            Contract.Ensures(Contract.Result<IndexData>() != null);
            using(UnitOfWorkFactory.Create())
            {
                return Container.Resolve<IBuilder<IndexData>>().Build();
            }
        }

    }
}