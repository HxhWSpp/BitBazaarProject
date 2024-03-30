using AppsApi.DTOs.Abstractions;

namespace AppsApi.DTOs.AppDTOs
{
    public class AppCreateDTO : BaseRequestDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public virtual ICollection<int>? GenreIds { get; set; }
        public int DeveloperId { get; set; }

        public string? TitleCardPath { get; set; }

        public IFormFile TitleCardFile { get; set; }


    }
}
