namespace Draugen.Data.Mappings
{
    public class KommenterbarMap<T> : DomainObjectMap<T> where T : Kommenterbar
    {
        protected KommenterbarMap(string entitetKommentarTabellNavn)
        {
            HasManyToMany(x => x.Kommentarer).Table(entitetKommentarTabellNavn);
        }
    }
}
