using AppsApi.Data.Entities;
using AppsApi.Data.Repositories.Abstractions;
using AppsApi.DTOs.AppDTOs;
using AppsApi.DTOs.GenreDTOs;

using AppsApi.Services.Abstractions;
using AppsApi.Utils;
using AutoMapper;
using Humanizer.Localisation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppsApi.Services
{
    public class AppService : IAppService
    {
        private readonly IAppRepository _appRepository;
        private readonly IGenreRepository _genreRepository;
        private readonly IDeveloperRepository _developerRepository;
        private readonly IImageRepository _imageRepository;


        private readonly IMapper _mapper;
        


        public AppService(IAppRepository appRepository , IGenreRepository genreRepository , IMapper mapper , IDeveloperRepository developerRepository, IImageRepository imageRepository)
        {
            _appRepository = appRepository;
            _genreRepository = genreRepository;
            _developerRepository = developerRepository;
            _imageRepository = imageRepository;
           _mapper = mapper;           
        }

        public async Task<bool> AddAppAsync(AppCreateDTO app)
        {            
            var appEntity = _mapper.Map<App>(app);                               
            if (app.GenresIdsToAdd != null)
            {
                var genres = app.GenresIdsToAdd.Select(item => _genreRepository.GetByIdAsync(item).Result).ToList();              
                appEntity.Genres = genres;
            }     
            
            appEntity.Developer = await _developerRepository.GetByIdAsync(app.DeveloperId);
                   
            await _appRepository.AddAsync(appEntity);

            if (app.ImagePaths != null)
            {
                foreach (var imagePath in app.ImagePaths)
                {
                    var imageEntity = _mapper.Map<Image>(imagePath);
                    appEntity.Images.Add(imageEntity);
                }
            }

            if (await _appRepository.UpdateAsync(appEntity) == true)
            {
                return true;
            }
            return false;
            
        }
        
        public async Task<bool> DeleteAppByIdAsync(int id)
        {
            var titleCardPath = ((await _appRepository.GetByIdAsync(id)).TitleCardPath).Substring(34);
            var images = (await _imageRepository.GetAsync(a => a.App.Id == id)).Select(p => p.ImagePath.Substring(37)).ToList();

            if (await _appRepository.DeleteByIdAsync(id) == true)
            {
                Helper.DeleteImageLocally(titleCardPath , "TitleCards");
                Helper.DeleteMultipleImagesLocally(images , "ImagesForApps");
                return true;
            }
            return false;

        }

        public async Task<AppDetailResponseDTO> GetAppByIdAsync(int id)
        {
            var appEntity = await _appRepository.GetAppDetailsById(id);           
            return _mapper.Map<AppDetailResponseDTO>(appEntity);
        }

        public async Task<AppDetailResponseDTO> GetAppByNameAsync(string name)
        {
            var appEntity = (await _appRepository.GetAsync(item => item.Title == name)).FirstOrDefault();
            return _mapper.Map<AppDetailResponseDTO>(appEntity);
        }

        public async Task<ICollection<AppResponseDTO>> GetAppsAsync()
        {
            var appList = (await _appRepository.GetAllAsync()).ToList();
            return _mapper.Map<ICollection<AppResponseDTO>>(appList);
        }
      

        public async Task<bool> UpdateAppAsync(AppEditDTO app)
        {
            var appEntity = await _appRepository.GetAppDetailsById(app.Id);
            
                appEntity.Title = app.Title;
                appEntity.Description = app.Description;
                appEntity.Price = app.Price;
                appEntity.ReleaseDate = app.ReleaseDate;                
            string titleCardPathToDelete = "";
            if (appEntity.TitleCardPath != app.TitleCardPath)
            {
                titleCardPathToDelete = appEntity.TitleCardPath.Substring(34);
                appEntity.TitleCardPath = app.TitleCardPath;
            }
                if (appEntity.Developer.Id != app.DeveloperId)
                {
                    appEntity.Developer = await _developerRepository.GetByIdAsync(app.DeveloperId);
                }
                
                if (app.GenresIdsToAdd != null)
                {
                    foreach (var genreId in app.GenresIdsToAdd)
                    {
                        var genre = await _genreRepository.GetByIdAsync(genreId);
                        appEntity.Genres.Add(genre);
                    }
                }

                if (app.GenresIdsToRemove != null)
                {
                    foreach (var genreId in app.GenresIdsToRemove)
                    {
                        var genre = await _genreRepository.GetByIdAsync(genreId);
                        appEntity.Genres.Remove(genre);
                    }
                }

                List<string> paths = new List<string>();
                if (app.ImageIdsToRemove != null)
                {
                    foreach (var imageId in app.ImageIdsToRemove)
                    {
                        var image = await _imageRepository.GetByIdAsync(imageId);
                        paths.Add(image.ImagePath.Substring(37));
                        appEntity.Images.Remove(image);
                    }
                }

                if (app.ImagePaths != null)
                {
                    foreach (var imagePath in app.ImagePaths)
                    {
                        var imageEntity = _mapper.Map<Image>(imagePath);
                        appEntity.Images.Add(imageEntity);
                    }
                }

               
            if (await _appRepository.UpdateAsync(appEntity) == true)
            {
                Helper.DeleteMultipleImagesLocally(paths , "ImagesForApps");
                Helper.DeleteImageLocally(titleCardPathToDelete , "TitleCards");
                return true;
            }
            return false;
                               
                
        }       
    }
}
