using AppsApi.Data.Entities;
using AppsApi.DTOs.Abstractions;
using AppsApi.DTOs.AppDTOs;

namespace AppsApi.DTOs.GenreDTOs
{
    public class GenreDetailResponseDTO : BaseResponseDTO
    {
        public string Name { get; set; }

        public virtual ICollection<AppResponseDTO>? Apps { get; set; }
    }
}
