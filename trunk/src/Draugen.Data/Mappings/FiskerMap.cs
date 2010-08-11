namespace Draugen.Data.Mappings
{
    public class FiskerMap : FangstLeverandørMap<Fisker>
    {
        public FiskerMap() : base("Fisker_Kommentarer")
        {
            Map(x => x.EPost);
        }
    }
}
