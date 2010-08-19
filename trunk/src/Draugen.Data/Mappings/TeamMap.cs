namespace Draugen.Data.Mappings
{
    public class TeamMap : KommenterbarMap<Team>
    {
        public TeamMap()
        {
            Map(t => t.Grunnlagt);
            HasMany(t => t.Medlemmer).Inverse();
        }
    }
}
