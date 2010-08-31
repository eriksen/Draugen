using Draugen.Data.QueryObjects;
using Draugen.Services.Dtos.Requests;

namespace Draugen.Services.Builders
{
    public class QueryObjectListBuilder : IListBuilder<IQueryObject>
    {
        public IQueryObject[] Build(ServiceHeader header)
        {
            return new IQueryObject[]
                       {
                           new Sort("Dato", SortDirection.Descending),
                           new Page(1, 25)
                       };
        }
    }
}
