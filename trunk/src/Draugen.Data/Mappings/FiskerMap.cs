namespace Draugen.Data.Mappings
{
    public class FiskerMap : FangstLeverandørMap<Fisker>
    {
        public FiskerMap()
        {
            Map(x => x.EPost);
            Map(x => x.Tittel);
            References(x => x.Team);
        }
    }
}
