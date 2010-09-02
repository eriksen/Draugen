using Draugen.Data.QueryObjects;

namespace Draugen.Services.Builders.Queries
{
    public class FangstQueryBuilder : IQueryBuilder<Fangst>
    {
        public IQueryObject<Fangst> Build()
        {
            var queryContainer = new QueryContainer<Fangst>();
            queryContainer.SetPage(1, 25);
            queryContainer.SetSort("Dato", SortDirection.Descending);
            return queryContainer;
        }
    }
}