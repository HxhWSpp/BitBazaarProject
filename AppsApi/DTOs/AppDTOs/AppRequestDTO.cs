using AppsApi.DTOs.Abstractions;

namespace AppsApi.DTOs.AppDTOs
{
    public class AppRequestDTO : BaseRequestDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int DeveloperId { get; set; }

        public ICollection<int>? GenresIdsToAdd { get; set; }

        public string? TitleCardPath { get; set; }

        public IFormFile TitleCardFile { get; set; }

        public ICollection<string>? ImagePaths { get; set; }

        public ICollection<IFormFile>? ImageFiles { get; set; }
    }
}
