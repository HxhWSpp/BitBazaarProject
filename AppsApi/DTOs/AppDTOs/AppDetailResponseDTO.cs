using AppsApi.Data.Entities;
using AppsApi.DTOs.Abstractions;
using AppsApi.DTOs.DeveloperDTOs;
using AppsApi.DTOs.GenreDTOs;
using AppsApi.DTOs.ImageDTOs;
using AppsApi.DTOs.ReviewDTOs;

namespace AppsApi.DTOs.AppDTOs
{
    public class AppDetailResponseDTO : BaseResponseDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public virtual string TitleCardPath { get; set; }

        public virtual DeveloperResponseDTO? Developer { get; set; }
        public virtual ICollection<GenreResponseDTO>? Genres { get; set; }
        public virtual ICollection<ImageResponseDTO>? Images { get; set; }
        public virtual ICollection<ReviewResponseDTO>? Reviews { get; set; }
    }
}
