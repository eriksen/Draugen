namespace Draugen.Data.Mappings
{
    public class KommenterbarMap<T> : DomainObjectMap<T> where T : Kommenterbar
    {
        protected KommenterbarMap()
        {
            Map(x => x.LegacyId);
            HasManyToMany(x => x.Kommentarer).Table(typeof(T).Name + "_Kommentar");
        }
    }
}
