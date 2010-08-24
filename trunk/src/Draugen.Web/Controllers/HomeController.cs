using System.Web.Mvc;
using Draugen.Services;

namespace Draugen.Controllers
{
    public class HomeController : Controller
    {
        private readonly IViewDataService _viewDataService;

        public HomeController(IViewDataService viewDataService)
        {
            _viewDataService = viewDataService;
        }

        public ActionResult Index()
        {
            return View(_viewDataService.GetHomePageData());
        }

    }
}
