namespace Draugen.Services.Dtos
{
    public class PageInfoDto
    {
        public int Size { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
        public int Index { get; set; }
    }
}
