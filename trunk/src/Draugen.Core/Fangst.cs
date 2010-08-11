namespace Draugen
{ 
    public class Fangst : Kommenterbar
    {
        public Art Art { get; set; }
        public Sted Sted { get; set; }
        public Fisker Fisker { get; set; }
        public double Vekt { get; set; }
        public double Lengde { get; set; }
        public double Poeng()
        {
            return Vekt*100/Art.Rekord;
        }
    }
}
