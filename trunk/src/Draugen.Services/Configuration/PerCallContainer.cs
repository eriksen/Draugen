using Draugen.Data;
using Draugen.Data.Paging;
using Draugen.Data.Repositories;
using Draugen.Services.Assemblers;
using Draugen.Services.Builders;
using Draugen.Services.Builders.Queries;
using Draugen.Services.Builders.Responses;
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
            
            RegisterDraugenData();
            RegisterDraugenServices();
        }

        private void RegisterDraugenServices()
        {
            this.RegisterType<IResponseBuilder<GetFangsterResponse, GetFangsterRequest>, GetFangsterResponseBuilder>();
            this.RegisterType<IListBuilder<FangstListDto>, FangstListBuilder>();
            this.RegisterType<IAssembler<FangstDto, Fangst>, FangstAssembler>();
            this.RegisterType<IAssembler<PageInfoDto, IPageInfo>, PageInfoAssembler>();
            this.RegisterType<IQueryBuilder<Fangst>, FangstQueryBuilder>();
        }

        private void RegisterDraugenData()
        {
            this.RegisterType<IRepository<Fangst>,FangstRepository>();
            this.RegisterType<IPageBuilder<Fangst>, PageBuilder<Fangst>>();
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