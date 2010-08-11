using FluentNHibernate.Mapping;

namespace Draugen.Data.Mappings
{
    public abstract class DomainObjectMap<T> : ClassMap<T> where T : DomainObject
    {
        protected DomainObjectMap()
        {
            Id(x => x.Id);
        }
    }
}
