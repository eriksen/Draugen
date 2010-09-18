using Draugen.Model.Home;
using Draugen.Services;
using Draugen.Services.Dtos.Requests;

namespace Draugen.Model.Factories
{
    public class IndexFactory : IModelFactory<IndexModel>
    {
        private readonly IFangstService _fangstService;
        public IndexFactory(IFangstService fangstService)
        {
            _fangstService = fangstService;
        }

        public IndexModel Create()
        {
            var request = new GetFangsterRequest()
            {
                Header = new ServiceHeader() { Culture = "no" },
                Body = new GetFangsterRequestBody()
            };
            var response = _fangstService.GetFangster(request);
            return new IndexModel
            {
                Fangster = response.Body.FangstList
            };
        }

    }
}