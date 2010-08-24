using System;

namespace Draugen
{ 
    public class Fangst : Kommenterbar
    {
        public Fangst()
        {
            Bilde = new Bilde(this);   
        }

        public virtual DateTime Dato { get; set; }
        public virtual Art Art { get; set; }
        public virtual Sted Sted { get; set; }
        public virtual Fisker Fisker { get; set; }
        public virtual double Vekt { get; set; }
        public virtual double Lengde { get; set; }
        public virtual double Poeng()
        {
            return Vekt*100/Art.Rekord;
        }

        public virtual Bilde Bilde { get; set; }
    }
}
