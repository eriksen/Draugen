namespace Draugen
{
    public class Bilde
    {
        private readonly Fangst _fangst;

        public Bilde(Fangst fangst)
        {
            _fangst = fangst;
        }
        
        public string Navn
        {
            get
            {
                return string.Format("draug{0}.jpg", _fangst.LegacyId);
            }
        }
    }
}
