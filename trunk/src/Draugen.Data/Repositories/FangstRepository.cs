using System.Diagnostics.Contracts;
using Draugen.Data.Paging;
using Draugen.Data.QueryObjects;
using NHibernate;

namespace Draugen.Data.Repositories 
{
    public class FangstRepository : Repository<Fangst>
    {
        public FangstRepository(ISession session, IPageBuilder<Fangst> pageBuilder)
            : base(session, pageBuilder)
        {
            Contract.Requires(session.IsOpen == true);
        }

        public override IPage<Fangst> FindAll(IQueryManager<Fangst> queryManager)
        {
            queryManager.AddFilter("Art.Id", FilterOperator.GreaterThan, 0);    
            return base.FindAll(queryManager);
        }
    }
}
