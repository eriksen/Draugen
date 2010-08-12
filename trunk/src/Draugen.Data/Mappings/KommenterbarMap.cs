namespace Draugen.Data.Mappings
{
    public class KommenterbarMap<T> : DomainObjectMap<T> where T : Kommenterbar
    {
        protected KommenterbarMap()
        {
            HasManyToMany(x => x.Kommentarer).Table(typeof(T).Name + "_Kommentar");
        }
    }
}
