using AppsApi.Data.Entities;
using AppsApi.DTOs.Abstractions;

namespace AppsApi.DTOs.DeveloperDTOs
{
    public class DeveloperRequestDTO : BaseRequestDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string? ProfilePath { get; set; }

        public IFormFile? ProfileFile { get; set; }

    }
}
