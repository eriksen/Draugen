using System;

namespace Draugen
{
    public class Kommentar : DomainObject
    {
        private string _innhold;
        public virtual string Innhold
        {
            get { return _innhold; }
            set {
                _innhold = string.IsNullOrWhiteSpace(value) ? "..." : value;
            }
        }

        public virtual Fisker Forfatter { get; set; }
        public virtual DateTime Opprettet { get; set; }
    }
}
