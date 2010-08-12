namespace Draugen.Data.Mappings
{
    public class ArtMap : FangstLeverandørMap<Art>
    {
        public ArtMap()
        {
            Map(x => x.Rekord);
            Map(x => x.Latin);
        }
    }
}
