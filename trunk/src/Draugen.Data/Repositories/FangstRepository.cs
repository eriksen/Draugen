using System.Collections.Generic;
using Draugen.Data.QueryObjects;
using NHibernate;

namespace Draugen.Data.Repositories 
{
    public class FangstRepository : Repository<Fangst>
    {
        private readonly Filter _hack;

        public FangstRepository(ISession session) : base(session)
        {
            _hack = new Filter("Art.Id", FilterOperator.GreaterThan, 0);
        }

        public override IEnumerable<Fangst> FindAll(IQueryObject[] queryObjects)
        {
            queryObjects = new List<IQueryObject>(queryObjects) { _hack }.ToArray();
            return base.FindAll(queryObjects);
        }
    }
}
