using System;

namespace Draugen
{ 
    public class Fangst : Kommenterbar
    {
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
        public virtual string Thumbnail()
        {
            return string.Format("http://www.draugen.org/img/fangstbilder_thumb/draug{0}.jpg", LegacyId);
        }
    }
}
