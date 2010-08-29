using System.Collections.Generic;
using Draugen.Data;
using Draugen.Data.Repositories;
using Draugen.Services.Assemblers;
using Draugen.Services.Dtos;
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
            this.RegisterType<IAssembler<FangstDto, Fangst>, FangstAssembler>();
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