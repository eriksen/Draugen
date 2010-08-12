using System.Collections.Generic;

namespace Draugen
{
    public abstract class Kommenterbar : DomainObject
    {
        protected Kommenterbar()
        {
            Kommentarer = new List<Kommentar>();
        }

        public virtual IList<Kommentar> Kommentarer { get; set; }
    }
}
