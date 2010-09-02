using System.Diagnostics.Contracts;
using System.Web.Mvc;
using Draugen.Model.Home;
using Draugen.Model.Shared;
using Draugen.Services;
using Draugen.Services.Dtos.Requests;

namespace Draugen.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFangstService _fangstService;

        public HomeController(IFangstService fangstService)
        {
            Contract.Requires(fangstService != null);
            _fangstService = fangstService;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_fangstService != null);
        }


        public ActionResult Index()
        {
            Contract.Ensures(Contract.Result<ActionResult>() != null);
            var request = new GetFangsterRequest()
                              {
                                  Header = new ServiceHeader() {Culture = "no"}
                              };
            var response = _fangstService.GetFangster(request);
            var model = new IndexModel
                            {
                                //Fangster = new FangstList(response.Body.FangstList)
                            };
            return View(model);
        }
    }
}
