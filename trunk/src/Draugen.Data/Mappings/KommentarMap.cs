namespace Draugen.Data.Mappings
{
    public class KommentarMap : DomainObjectMap<Kommentar>
    {
        public KommentarMap()
        {
            Map(x => x.Innhold).Length(4000);
            References(x => x.Forfatter).ForeignKey();
        }
    }
}
