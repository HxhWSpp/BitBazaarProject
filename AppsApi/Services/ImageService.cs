using AppsApi.Data.Entities;
using AppsApi.Data.Repositories.Abstractions;
using AppsApi.DTOs.ImageDTOs;
using AppsApi.Services.Abstractions;
using AutoMapper;

namespace AppsApi.Services
{
    public class ImageService : IImageService
    {
        private readonly IAppRepository _appRepository;
        private readonly IImageRepository _imageRepository;
        private readonly IMapper _mapper;



        public ImageService(IAppRepository appRepository, IImageRepository imageRepository, IMapper mapper)
        {
            _appRepository = appRepository;
            _imageRepository = imageRepository;
            _mapper = mapper;
        }
        public async Task AddImageToAppAsync(ImageRequestDTO image)
        {
            var appEntity = await _appRepository.GetByIdAsync(image.AppId);
            var imageEntity = _mapper.Map<Image>(image);
            if (appEntity != null)
            {
                appEntity.Images.Add(imageEntity);
                await _appRepository.UpdateAsync(appEntity);
            }            
        }

        public async Task AddMultipleImagesToAppAsync(ImagesRequestDTO image)
        {
            var appEntity = await _appRepository.GetByIdAsync(image.AppId);
            List<Image> imageList = new List<Image>();
            foreach (var itemPath in image.ImagePaths)
            {
                var mapedImage = _mapper.Map<Image>(itemPath);
                mapedImage.CreatedAt = image.CreatedAt;
                imageList.Add(mapedImage);
            }

            if (appEntity != null)
            {
                foreach (var imageEntity in imageList)
                {
                    appEntity.Images.Add(imageEntity);
                }
                await _appRepository.UpdateAsync(appEntity);
            }

        }

        public async Task<string> DeleteImageByIdAsync(int id)
        {
            var path = await _imageRepository.DeleteByIdAsync(id);
            return path;
        }

        public async Task<ICollection<string>> DeleteMultipleImagesByIdAsync(int[] ids)
        {
            List<string> paths = new List<string>();
            foreach (var id in ids)
            {
                paths.Add(await _imageRepository.DeleteByIdAsync(id));
            }           
            return paths;
        }

        public async Task<ICollection<ImageResponseDTO>> GetImagesOfAppAsync(int appId)
        {
            var imageEntities = await _imageRepository.GetAsync(a => a.App.Id == appId);
            return _mapper.Map<ICollection<ImageResponseDTO>>(imageEntities);
        }

        public Task UpdateImageAsync(ImageRequestDTO genre)
        {
            throw new NotImplementedException();
        }
    }
}
