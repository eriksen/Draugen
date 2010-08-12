using System.Collections.Generic;

namespace Draugen
{
    public abstract class FangstLeverandør : Kommenterbar
    {
        protected FangstLeverandør()
        {
            Fangster = new List<Fangst>();    
        }

        public virtual IList<Fangst> Fangster { get; set; }

        public virtual string Navn { get; set; }
    }
}
