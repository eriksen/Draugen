namespace Draugen.Services.ViewModels.Dtos
{
    public class Fangst : DtoKommenterbar
    {
        public ArtDto Art { get; set; }
        public StedDto Sted { get; set; }
        public FiskerDto Fisker { get; set; }
        public TeamDto Team { get; set; }
        public string Lengde { get; set; }
        public string Vekt { get; set; }
        public string Poeng { get; set; }
        public string Dato { get; set; }
    }
}