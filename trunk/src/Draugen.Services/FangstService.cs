using System.Diagnostics.Contracts;
using System.Linq;
using Draugen.Data.QueryObjects;
using Draugen.Data.Repositories;
using Draugen.Services.Configuration;
using Microsoft.Practices.Unity;

namespace Draugen.Services
{
    public class FangstService : ServiceBase, IFangstService
    {
        public FangstService(IUnityContainer globalContainer) : base(globalContainer){}

        public Fangst[] GetFangster(SortBy[] sortBy)
        {
            Contract.Requires(sortBy != null);
            Contract.Ensures(Contract.Result<Fangst[]>() != null);
            using (var localContainer = GlobalContainer.Resolve<ILocalContainer>())
            {
                var query = new Query
                                {
                                    Order = new Order("Vekt", SortDirection.Descending)
                                };
                return localContainer.Resolve<IRepository<Fangst>>().FindAll(query).ToArray();
            }
        }
    }

    
}