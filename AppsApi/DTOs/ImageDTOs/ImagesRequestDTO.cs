using AppsApi.DTOs.Abstractions;

namespace AppsApi.DTOs.ImageDTOs
{
    public class ImagesRequestDTO : BaseRequestDTO
    {
        public ICollection<string>? ImagePaths { get; set; }

        public ICollection<IFormFile> ImageFiles { get; set; }

        public int AppId { get; set; }
    }
}
