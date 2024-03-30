using AppsApi.Data.Entities;
using AppsApi.DTOs.Abstractions;

namespace AppsApi.DTOs.ImageDTOs
{
    public class ImageRequestDTO : BaseRequestDTO
    {
        public string? ImagePath { get; set; }

        public IFormFile ImageFile { get; set; }

        public int AppId { get; set; }
    }
}
