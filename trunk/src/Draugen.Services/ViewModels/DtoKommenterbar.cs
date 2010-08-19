using Draugen.Services.ViewModels.Dtos;

namespace Draugen.Services.ViewModels
{
    public class DtoKommenterbar : DtoBase
    {
        public KommentarDto[] Kommentarer { get; set; }
    }
}