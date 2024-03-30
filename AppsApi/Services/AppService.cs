using AppsApi.Data.Entities;
using AppsApi.Data.Repositories.Abstractions;
using AppsApi.DTOs.AppDTOs;
using AppsApi.DTOs.GenreDTOs;

using AppsApi.Services.Abstractions;
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

        private readonly IMapper _mapper;
        


        public AppService(IAppRepository appRepository , IGenreRepository genreRepository , IMapper mapper , IDeveloperRepository developerRepository)
        {
            _appRepository = appRepository;
            _genreRepository = genreRepository;
            _developerRepository = developerRepository;
            _mapper = mapper;           
        }

        public async Task AddAppAsync(AppCreateDTO app)
        {            
            var appEntity = _mapper.Map<App>(app);                               
            if (app.GenreIds != null)
            {
                var genres = app.GenreIds.Select(item => _genreRepository.GetByIdAsync(item).Result).ToList();              
                appEntity.Genres = genres;
            }
            var dev = await _developerRepository.GetByIdAsync(app.DeveloperId);
            appEntity.Developer = dev;

            await _appRepository.AddAsync(appEntity);
        }

        public async Task AddGenreToApp(int appId, int genreId)
        {
            var appEntity = await _appRepository.GetByIdAsync(appId);
            var genreEntity = await _genreRepository.GetByIdAsync(genreId);
            if (appEntity.Genres != null)
            {
                appEntity.Genres.Add(genreEntity);
            }           
            await _appRepository.UpdateAsync(appEntity);
        }

        public async Task DeleteAppByIdAsync(int id)
        {
            await _appRepository.DeleteByIdAsync(id);
        }

        public async Task<AppDetailResponseDTO> GetAppByIdAsync(int id)
        {
            var appEntity = await _appRepository.GetByIdAsync(id);
            return _mapper.Map<AppDetailResponseDTO>(appEntity);
        }

        public async Task<AppDetailResponseDTO> GetAppByNameAsync(string name)
        {
            var appEntity = (await _appRepository.GetAsync(item => item.Title == name)).FirstOrDefault();
            return _mapper.Map<AppDetailResponseDTO>(appEntity);
        }

        public async Task<ICollection<AppDetailResponseDTO>> GetAppsAsync()
        {
            var appList = (await _appRepository.GetAllAsync()).ToList();
            return _mapper.Map<ICollection<AppDetailResponseDTO>>(appList);
        }

        public async Task RemoveGenreFromApp(int appId, int genreId)
        {
            var appEntity = await _appRepository.GetByIdAsync(appId);
            var genreEntity = await _genreRepository.GetByIdAsync(genreId);
            if (appEntity != null)
            {
                appEntity.Genres.Remove(genreEntity);
                await _appRepository.UpdateAsync(appEntity);
            }                       
        }

        public Task UpdateAppAsync(AppRequestDTO app)
        {
            var appEntity = _mapper.Map<App>(app);
            return _appRepository.UpdateAsync(appEntity);
        }
       
    }
}
