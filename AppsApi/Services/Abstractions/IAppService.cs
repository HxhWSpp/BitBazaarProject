using AppsApi.Data.Entities;
using AppsApi.DTOs.AppDTOs;
using AppsApi.DTOs.GenreDTOs;

namespace AppsApi.Services.Abstractions
{
    public interface IAppService
    {
        Task<ICollection<AppResponseDTO>> GetAppsAsync();
        Task<AppDetailResponseDTO> GetAppByIdAsync(int id);
        Task<AppDetailResponseDTO> GetAppByNameAsync(string name);       
        Task<bool> AddAppAsync(AppCreateDTO app);
        Task<bool> DeleteAppByIdAsync(int id);
        Task<bool> UpdateAppAsync(AppEditDTO app);      
    }
}
