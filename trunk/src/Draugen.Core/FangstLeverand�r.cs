using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

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
