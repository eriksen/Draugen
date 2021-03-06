﻿using System.Diagnostics.Contracts;
using System.Web.Mvc;
using Draugen.Model.Hjem;
using Draugen.Model.Sted;
using Draugen.ModelFactories;

namespace Draugen.Controllers
{
    public class StedController : Controller
    {
        private readonly IFangsterFactory<HjemModel> _fangsterFactory;

        public StedController(IFangsterFactory<HjemModel> fangsterFactory)
        {
            Contract.Requires(fangsterFactory != null);
            _fangsterFactory = fangsterFactory;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_fangsterFactory != null);
        }

        public ActionResult Detaljer (int page)
        {
            Contract.Ensures(Contract.Result<ActionResult>() != null);
            return View(new DetaljerModel());
        }

    }
}
