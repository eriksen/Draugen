namespace Draugen
{
    public class Fisker : FangstLeverandør
    {
        public virtual string EPost { get; set; }
        public virtual Team Team { get; set; }
        public virtual string Tittel { get; set; }
    }
}
