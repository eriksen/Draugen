using System.Diagnostics.Contracts;
using System.Linq;
using Draugen.Data.QueryObjects;
using Draugen.Data.Repositories;
using Draugen.Services.Assemblers;
using Draugen.Services.Builders;
using Draugen.Services.Configuration;
using Draugen.Services.Dtos;
using Microsoft.Practices.Unity;

namespace Draugen.Services
{
    public interface IFangstService
    {
        FangstDto[] GetFangster();
    }

    public class FangstService : ServiceBase, IFangstService
    {
        public FangstService(IUnityContainer globalContainer) : base(globalContainer){}

        public FangstDto[] GetFangster()
        {
            Contract.Ensures(Contract.Result<FangstDto[]>() != null);
            using (var localContainer = GlobalContainer.Resolve<ILocalContainer>())
            {
                return localContainer.Resolve<FangstListBuilder>().Build();
            }
        }


    }

    
}