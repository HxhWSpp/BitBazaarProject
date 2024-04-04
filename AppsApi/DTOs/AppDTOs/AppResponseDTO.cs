using AppsApi.DTOs.Abstractions;
using AppsApi.DTOs.DeveloperDTOs;
using AppsApi.DTOs.ImageDTOs;

namespace AppsApi.DTOs.AppDTOs
{
    public class AppResponseDTO : BaseResponseDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public virtual string TitleCardPath { get; set; }

        public virtual ICollection<ImageResponseDTO>? Images { get; set; }

    }
}
