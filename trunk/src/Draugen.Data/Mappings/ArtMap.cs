namespace Draugen.Data.Mappings
{
    public class ArtMap : FangstLeverandørMap<Art>
    {
        public ArtMap() : base("Art_Kommentar")
        {
            Map(x => x.Rekord);
            Map(x => x.Latin);
        }
    }
}
