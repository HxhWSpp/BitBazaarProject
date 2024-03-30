using AppsApi.Data.Entities;
using AppsApi.DTOs.Abstractions;
using AppsApi.DTOs.AppDTOs;

namespace AppsApi.DTOs.DeveloperDTOs
{
    public class DeveloperDetailResponseDTO : BaseResponseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProfilePath { get; set; }

        public virtual ICollection<AppResponseDTO>? Apps { get; set; }
    }
}
