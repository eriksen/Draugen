using System.Diagnostics.Contracts;
using System.Web.Mvc;
using Draugen.Services;

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
            var fangster = _fangstService.GetFangster();
            return View(fangster);
        }
    }
}
