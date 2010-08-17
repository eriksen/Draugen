using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using Draugen.Data;
using Draugen.Data.Repositories;

namespace Draugen.Services
{
    public class FangstService : IFangstService
    {
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(_fangstRepository != null);
            Contract.Invariant(_unitOfWorkFactory != null);
        }

        private readonly IRepository<Fangst> _fangstRepository;
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public FangstService(IUnitOfWorkFactory unitOfWorkFactory, IRepository<Fangst> fangstRepository)
        {
            Contract.Requires(fangstRepository != null);
            Contract.Requires(unitOfWorkFactory != null);
            _unitOfWorkFactory = unitOfWorkFactory;
            _fangstRepository = fangstRepository;
        }


        public IEnumerable<Fangst> GetFangster()
        {
            Contract.Ensures(Contract.Result<IEnumerable<Fangst>>() != null);
            using(var unitOfWork = _unitOfWorkFactory.Create())
            {
                _fangstRepository.Session = unitOfWork.Session;
                return _fangstRepository.FindAll().ToList();
            }
        }
    }
}
