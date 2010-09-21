using System.Diagnostics.Contracts;
using System.Web.Mvc;
using Draugen.Model.Hjem;
using Draugen.ModelFactories;

namespace Draugen.Controllers
{
    public class HjemController : Controller
    {
        private readonly IFangsterFactory<HjemModel> _fangsterFactory;

        public HjemController(IFangsterFactory<HjemModel> fangsterFactory)
        {
            Contract.Requires(fangsterFactory != null);
            _fangsterFactory = fangsterFactory;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_fangsterFactory != null);
        }

        public ActionResult Fangster(int page)
        {
            Contract.Ensures(Contract.Result<ActionResult>() != null);
            return View(_fangsterFactory.Create(page));
        }

    }
}
