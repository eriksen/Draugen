using System.Collections.Generic;
using Draugen.Data;
using Draugen.Data.Repositories;
using Microsoft.Practices.Unity;
    
namespace Draugen.Services.Configuration
{
    public class LocalContainer : UnityContainer, ILocalContainer
    {
        private readonly IUnitOfWork _unitOfWork;

        public LocalContainer(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            this.RegisterInstance(_unitOfWork.Session);

            this.RegisterType<IRepository<Fangst>,FangstRepository>();
        }

        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}