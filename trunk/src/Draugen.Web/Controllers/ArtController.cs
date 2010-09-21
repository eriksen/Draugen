using System.Web.Mvc;
using Draugen.Model.Art;

namespace Draugen.Controllers
{
    public class ArtController : Controller
    {
        //
        // GET: /Art/

        public ActionResult Detaljer()
        {
            return View(new DetaljerModel());
        }

    }
}
