using System.Collections.Generic;

namespace Draugen
{
    public abstract class Kommenterbar : DomainObject
    {
        public virtual IList<Kommentar> Kommentarer { get; set; }
    }
}
