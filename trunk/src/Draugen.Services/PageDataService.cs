using System.Diagnostics.Contracts;
using Draugen.Data;
using Draugen.Data.Repositories;
using Draugen.Services.PageBuilders;
using Draugen.Services.ViewModels.Pages;

namespace Draugen.Services
{
    public class PageDataService : IPageDataService
    {
        private readonly IRepository<Fangst> _fangstRepository;
        private readonly HomeBuilder _homeBuilder;
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public PageDataService(IUnitOfWorkFactory unitOfWorkFactory, IRepository<Fangst> fangstRepository,
                               HomeBuilder homeBuilder)
        {
            Contract.Requires(fangstRepository != null);
            Contract.Requires(unitOfWorkFactory != null);
            _unitOfWorkFactory = unitOfWorkFactory;
            _fangstRepository = fangstRepository;
            _homeBuilder = homeBuilder;
        }

        #region IPageDataService Members

        public HomeData HomePage()
        {
            Contract.Ensures(Contract.Result<HomeData>() != null);
            using (IUnitOfWork unitOfWork = _unitOfWorkFactory.Create())
            {
                _fangstRepository.Session = unitOfWork.Session;
                return _homeBuilder.Build(_fangstRepository.FindAll());
            }
        }

        #endregion

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_fangstRepository != null);
            Contract.Invariant(_unitOfWorkFactory != null);
        }
    }
}