namespace Draugen
{
    public class Bilde
    {
        private const string Root = "http://www.draugen.org/img/";
        private readonly Fangst _fangst;

        public Bilde(Fangst fangst)
        {
            _fangst = fangst;
        }
        
        public string Thumb
        {
            get
            {
                return string.Format("{0}fangstbilder_thumb/{1}", Root, Name);
            }
        }

        public string Web
        {
            get
            {
                return string.Format("{0}fangstbilder/{1}", Root, Name);
            }
        }

        public string Orginal
        {
            get
            {
                return string.Format("{0}fangstbilder_orginaler/{1}", Root, Name);
            }
        }

        public string Name
        {
            get
            {
                return string.Format("draug{0}.jpg", _fangst.LegacyId);
            }
        }
    }
}
