namespace Draugen.Data.Mappings
{
    public class KommentarMap : DomainObjectMap<Kommentar>
    {
        public KommentarMap()
        {
            Map(x => x.Innhold);
        }
    }
}
