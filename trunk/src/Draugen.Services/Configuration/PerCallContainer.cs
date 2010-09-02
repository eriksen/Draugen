using Draugen.Data;
using Draugen.Data.QueryObjects;
using Draugen.Data.Repositories;
using Draugen.Services.Assemblers;
using Draugen.Services.Builders;
using Draugen.Services.Builders.Queries;
using Draugen.Services.Dtos;
using Draugen.Services.Dtos.Requests;
using Draugen.Services.Dtos.Responses;
using Microsoft.Practices.Unity;
    
namespace Draugen.Services.Configuration
{
    public class PerCallContainer : UnityContainer
    {
        private readonly IUnitOfWork _unitOfWork;

        public PerCallContainer(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            this.RegisterInstance(_unitOfWork.Session);

            this.RegisterType<IRepository<Fangst>,FangstRepository>();
            this.RegisterType<IAssembler<FangstDto, Fangst>, FangstAssembler>();
            this.RegisterType<IListBuilder<FangstListDto>, FangstListBuilder>();
            this.RegisterType<IQueryBuilder<Fangst>, FangstQueryBuilder>();
            this.RegisterType<IResponseBuilder<GetFangsterResponse, GetFangsterRequest>, GetFangsterResponseBuilder>();
            
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