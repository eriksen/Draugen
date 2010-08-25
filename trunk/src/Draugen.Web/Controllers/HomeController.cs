using System.Diagnostics.Contracts;
using System.Web.Mvc;
using Draugen.Services;

namespace Draugen.Controllers
{
    public class HomeController : Controller
    {
        private readonly IViewDataService _viewDataService;

        public HomeController(IViewDataService viewDataService)
        {
            Contract.Requires(viewDataService != null);
            _viewDataService = viewDataService;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_viewDataService != null);
        }


        public ActionResult Index()
        {
            Contract.Ensures(Contract.Result<ActionResult>() != null);
            return View(_viewDataService.GetHomePageData());
        }
    }
}
