using System;

namespace Draugen
{
    public class Kommentar : DomainObject
    {
        public virtual string Innhold { get; set; }
        public virtual Fisker Forfatter { get; set; }
        public virtual DateTime Opprettet { get; set; }
    }
}
