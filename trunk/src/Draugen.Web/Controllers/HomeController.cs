using System.Diagnostics.Contracts;
using System.Web.Mvc;
using Draugen.Model.Home;
using Draugen.Model.Shared;
using Draugen.ModelFactories;
using Draugen.Services;
using Draugen.Services.Dtos.Requests;

namespace Draugen.Controllers
{
    public class HomeController : Controller
    {
        private readonly IModelFactory<IndexModel> _modelFactory;

        public HomeController(IModelFactory<IndexModel> modelFactory)
        {
            Contract.Requires(modelFactory != null);
            _modelFactory = modelFactory;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_modelFactory != null);
        }

        public ActionResult Index()
        {
            Contract.Ensures(Contract.Result<ActionResult>() != null);
            return View(_modelFactory.Create());
        }

    }
}
