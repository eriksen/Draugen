using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Draugen.Data.QueryObjects;
using NHibernate;

namespace Draugen.Data.Repositories 
{
    public class FangstRepository : Repository<Fangst>
    {

        public FangstRepository(ISession session) : base(session)
        {
            Contract.Requires(session.IsOpen == true);
        }

        public override IEnumerable<Fangst> FindAll(IQueryObject<Fangst> queryObject)
        {
            if(queryObject.GetType() == typeof(QueryContainer<Fangst>))
            {
                ((QueryContainer<Fangst>)queryObject).AddFilter("Art.Id", FilterOperator.GreaterThan, 0);    
            }
            return base.FindAll(queryObject);
        }
    }
}
