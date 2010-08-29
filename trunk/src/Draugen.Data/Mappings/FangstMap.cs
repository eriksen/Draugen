using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Criterion;

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
            //Major hack by Simen Eriksen
            Map(x => x.Poeng).ReadOnly().Formula("Vekt*100/art1_.Rekord");
           
        }
        
    }
}
