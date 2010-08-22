namespace Draugen.Data.Mappings
{
    public class TeamMap : FangstLeverandørMap<Team>
    {
        public TeamMap()
        {
            Map(x => x.Grunnlagt);
            HasMany(x => x.Medlemmer);
        }
    }
}
