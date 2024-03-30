using AppsApi.Data.Entities;
using AppsApi.DTOs.AppDTOs;
using AppsApi.DTOs.GenreDTOs;

namespace AppsApi.Services.Abstractions
{
    public interface IAppService
    {
        Task<ICollection<AppDetailResponseDTO>> GetAppsAsync();
        Task<AppDetailResponseDTO> GetAppByIdAsync(int id);
        Task<AppDetailResponseDTO> GetAppByNameAsync(string name);       
        Task AddAppAsync(AppCreateDTO app);
        Task DeleteAppByIdAsync(int id);
        Task UpdateAppAsync(AppRequestDTO app);

        Task RemoveGenreFromApp(int appId , int genreId);
        Task AddGenreToApp(int appId, int genreId);       
    }
}
