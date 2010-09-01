using Draugen.Data.QueryObjects;

namespace Draugen.Services.Builders.Queries
{
    public class FangstQueryBuilder : QueryBuilder<Fangst>
    {
        public FangstQueryBuilder()
        {
            Sort = new Sort("Dato", SortDirection.Descending);
            Page = new Page(1, 25);
        }
    }
}
