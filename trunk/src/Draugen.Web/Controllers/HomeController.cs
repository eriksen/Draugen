using System.Web.Mvc;
using Draugen.Services;

namespace Draugen.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPageService _pageService;

        public HomeController(IPageService pageService)
        {
            _pageService = pageService;
        }

        public ActionResult Index()
        {
            return View("", _pageService.GetHomePageData());
        }

    }
}
