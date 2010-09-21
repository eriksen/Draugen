using Draugen.Model.Hjem;
using Draugen.Services;
using Draugen.Services.Dtos.Requests;

namespace Draugen.ModelFactories.Home
{
    public class FangsterFactory : IFangsterFactory<HjemModel>
    {
        private readonly IFangstService _fangstService;
        public FangsterFactory(IFangstService fangstService)
        {
            _fangstService = fangstService;
        }

        public HjemModel Create(int page)
        {
            var request = new GetFangsterRequest()
                              {
                                  Header = new ServiceHeader() {Culture = "no"},
                                  Body = new GetFangsterRequestBody()
                           
            };
            var response = _fangstService.GetFangster(request);
            return new HjemModel
            {
                Fangster = response.Body.FangstList
            };
        }

    }
}