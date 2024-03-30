using AppsApi.DTOs.Abstractions;

namespace AppsApi.DTOs.DeveloperDTOs
{
    public class DeveloperCreateDTO : BaseRequestDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string? ProfilePath { get; set; }

        public IFormFile? ProfileFile { get; set; }
    }
}
