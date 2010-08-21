namespace Draugen.Data.Mappings
{
    public class FangstMap : KommenterbarMap<Fangst>
    {
        public FangstMap()
        {
            References(x => x.Art);
            References(x => x.Sted);
            References(x => x.Fisker);
            Map(x => x.Lengde);
            Map(x => x.Vekt);
        }
    }
}
