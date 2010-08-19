namespace Draugen.Services.ViewModels
{
    public abstract class DtoFangstLeverandør : Kommenterbar
    {
        public string Navn { get; set; }
        public Fangst[] Fangster { get; set; }
    }
}