using Draugen.Data.QueryObjects;

namespace Draugen.Services.Builders.Queries
{
    public class FangstQueryBuilder : IQueryBuilder<Fangst>
    {
        public IQueryManager<Fangst> Build()
        {
            var queryContainer = new QueryManager<Fangst>();
            queryContainer.SetPage(1, 25);
            queryContainer.SetSort("Dato", SortDirection.Descending);
            return queryContainer;
        }
    }
}