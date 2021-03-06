﻿using System;
using System.Collections.Generic;

namespace Draugen
{
    public class Team : FangstLeverandør
    {
        public Team()
        {
            Medlemmer = new List<Fisker>();
        }

        public virtual IList<Fisker> Medlemmer { get; set; }
        public virtual DateTime Grunnlagt { get; set; }
    }
}
