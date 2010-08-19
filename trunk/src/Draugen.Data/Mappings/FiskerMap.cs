namespace Draugen.Data.Mappings
{
    public class FiskerMap : FangstLeverandørMap<Fisker>
    {
        public FiskerMap()
        {
            Map(x => x.EPost);
            HasOne(f => f.Team);
        }
    }
}
