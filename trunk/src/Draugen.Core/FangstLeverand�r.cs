﻿using System.Collections.Generic;

namespace Draugen
{
    public class FangstLeverandør : Kommenterbar
    {
        public virtual IList<Fangst> Fangster { get; set; }

        public virtual string Navn { get; set; }
    }
}
