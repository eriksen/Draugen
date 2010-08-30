using Draugen.Services.Builders;
using Draugen.Services.Dtos.Requests;
using Draugen.Services.Dtos.Responses;
using Microsoft.Practices.Unity;

namespace Draugen.Services
{
    public class FangstService : ServiceBase, IFangstService
    {
        public FangstService(IUnityContainer globalContainer) : base(globalContainer){}

        public GetFangsterResponse GetFangster(GetFangsterRequest request)
        {
            using (var container = Container.Resolve<IUnityContainer>())
            {
                return container.Resolve<IResponseBuilder<GetFangsterResponse, GetFangsterRequest>>().Build(request);
            }
        }
    }

    
}