using System.Collections.Generic;

namespace Draugen
{
    public abstract class Kommenterbar : DomainObject
    {
        protected Kommenterbar()
        {
            Kommentarer = new List<Kommentar>();
        }

        public virtual List<Kommentar> Kommentarer { get; set; }

        public virtual int LegacyId { get; set; }
    }
}
