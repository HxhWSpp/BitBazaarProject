using AppsApi.DTOs.Abstractions;

namespace AppsApi.DTOs.DeveloperDTOs
{
    public class DeveloperResponseDTO : BaseResponseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProfilePath { get; set; }
    }
}
