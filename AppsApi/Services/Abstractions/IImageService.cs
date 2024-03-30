using AppsApi.DTOs.GenreDTOs;
using AppsApi.DTOs.ImageDTOs;

namespace AppsApi.Services.Abstractions
{
    public interface IImageService
    {        
        Task AddImageToAppAsync(ImageRequestDTO image);
        Task AddMultipleImagesToAppAsync(ImagesRequestDTO image);
        Task<ICollection<ImageResponseDTO>> GetImagesOfAppAsync(int appId);
        Task<string> DeleteImageByIdAsync(int id);
        Task<ICollection<string>> DeleteMultipleImagesByIdAsync(int[] ids);
        Task UpdateImageAsync(ImageRequestDTO genre);
        
    }
}
