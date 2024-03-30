using AppsApi.DTOs.Abstractions;

namespace AppsApi.DTOs.ImageDTOs
{
    public class ImageResponseDTO : BaseResponseDTO
    {
        public string ImagePath { get; set; }
    }
}
