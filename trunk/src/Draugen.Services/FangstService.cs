using System.Diagnostics.Contracts;
using System.Linq;
using Draugen.Data.QueryObjects;
using Draugen.Data.Repositories;
using Draugen.Services.Assemblers;
using Draugen.Services.Configuration;
using Draugen.Services.Dtos;
using Microsoft.Practices.Unity;

namespace Draugen.Services
{
    public interface IFangstService
    {
        FangstDto[] GetFangster();
    }

    public class FangstService : ServiceBase, IFangstService
    {
        public FangstService(IUnityContainer globalContainer) : base(globalContainer){}

        public FangstDto[] GetFangster()
        {
            Contract.Ensures(Contract.Result<Fangst[]>() != null);
            using (var localContainer = GlobalContainer.Resolve<ILocalContainer>())
            {
                var queryObject = new IQueryObject[]
                                      {
                                          new Sort("Poeng", SortDirection.Descending),
                                          new Page(1, 25)
                                      };
                var fangster = localContainer.Resolve<IRepository<Fangst>>().FindAll(queryObject).ToArray();
                var assembler = localContainer.Resolve<IAssembler<FangstDto, Fangst>>();
                return fangster.Select(assembler.WriteDto).ToArray();
            }
        }
    }

    
}