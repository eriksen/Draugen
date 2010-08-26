using System.Diagnostics.Contracts;
using Draugen.Services.Configuration;
using Draugen.Services.DataBuilders;
using Draugen.Services.ViewData.Home;
using Microsoft.Practices.Unity;

namespace Draugen.Services
{
    public class ViewDataService : ServiceBase, IViewDataService
    {
        public ViewDataService(IUnityContainer container) : base(container){}

        public IndexData GetHomePageData()
        {
            Contract.Ensures(Contract.Result<IndexData>() != null);
            using(var localContainer = Container.Resolve<ILocalContainer>())
            {
                return localContainer.Resolve<IBuilder<IndexData>>().Build();
            }
        }

    }
}