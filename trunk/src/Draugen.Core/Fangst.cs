using System;
using System.Diagnostics.Contracts;
using System.Linq;

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
        public virtual double Poeng { get; set; }

        public virtual Bilde Bilde { get; private set; }

        public virtual Kommentar Kommentar
        {
            get
            {
                Contract.Ensures(Contract.Result<Kommentar>() != null);
                var kommentar = Kommentarer.Where(k => k.Forfatter == Fisker).OrderBy(k => k.Opprettet).FirstOrDefault();
                return kommentar ?? new Kommentar {Forfatter = Fisker, Innhold = "...", Opprettet = Dato};
            }
        }
    }
}
