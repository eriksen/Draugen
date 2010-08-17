using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web.Mvc;
using Draugen.Services;

namespace Draugen.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly FangsterAssembler _fangsterAssembler;
        private readonly FangstService _fangstService;

        public HomeController(FangstService fangstService, FangsterAssembler fangsterAssembler)
        {
            _fangstService = fangstService;
            _fangsterAssembler = fangsterAssembler;
        }

        public ActionResult Index()
        {
            var fangster = _fangstService.GetFangster();
            var fangsterModel = _fangsterAssembler.WriteModel(fangster);
            return View(fangsterModel);
        }

    }

    public class FangsterAssembler
    {
        private readonly FangstAssembler _fangstAssembler;

        public FangsterAssembler(FangstAssembler fangstAssembler)
        {
            Contract.Requires(fangstAssembler != null);
            _fangstAssembler = fangstAssembler;
        }

        public Models.Fangster WriteModel(IEnumerable<Fangst> fangster)
        {
            return new Models.Fangster
                                    {
                                        List = fangster.Select(f => _fangstAssembler.WriteModel(f))
                                    };
        }
    }

    public class FangstAssembler
    {
        public Models.Fangst WriteModel(Fangst fangst)
        {
            return new Models.Fangst()
                       {
                           Vekt = fangst.Vekt.ToString()
                       };
        }
    }
}
