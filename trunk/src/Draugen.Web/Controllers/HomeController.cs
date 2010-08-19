using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web.Mvc;
using Draugen.Services;

namespace Draugen.Web.Controllers
{
    public class HomeController : Controller
    {
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_pageDataService != null);
        }
        private readonly PageDataService _pageDataService;

        public HomeController(PageDataService pageDataService)
        {
            Contract.Requires(pageDataService != null);
            _pageDataService = pageDataService;
        }

        public ActionResult Index()
        {
            var pageModel = _pageDataService.HomePage();
            return View(pageModel);
        }

    }

   
}
