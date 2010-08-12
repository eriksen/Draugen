namespace Draugen
{ 
    public class Fangst : Kommenterbar
    {
        public virtual Art Art { get; set; }
        public virtual Sted Sted { get; set; }
        public virtual Fisker Fisker { get; set; }
        public virtual double Vekt { get; set; }
        public virtual double Lengde { get; set; }
        public virtual double Poeng()
        {
            return Vekt*100/Art.Rekord;
        }
    }
}
