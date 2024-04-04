using AppsApi.Data.Entities;
using AppsApi.DTOs.Abstractions;
using AppsApi.DTOs.DeveloperDTOs;
using AppsApi.DTOs.GenreDTOs;
using AppsApi.DTOs.ImageDTOs;
using AppsApi.DTOs.ReviewDTOs;

namespace AppsApi.DTOs.AppDTOs
{
    public class AppDetailResponseDTO : AppResponseDTO
    {     
        public virtual DeveloperResponseDTO? Developer { get; set; }
        public virtual ICollection<GenreResponseDTO>? Genres { get; set; }
        public virtual ICollection<ReviewResponseDTO>? Reviews { get; set; }


    }
}
