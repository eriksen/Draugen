namespace Draugen.Services.ViewModels.Dtos
{
    public class KommentarDto : DtoBase
    {
        public string Innhold { get; set; }
        public Fisker Forfatter { get; set; }
    }
}