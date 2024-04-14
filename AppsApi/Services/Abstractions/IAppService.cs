using AppsApi.Data.Entities;
using AppsApi.DTOs.AppDTOs;
using AppsApi.DTOs.GenreDTOs;
using AppsApi.DTOs.Paginaton;

namespace AppsApi.Services.Abstractions
{
    public interface IAppService
    {
        Task<ICollection<AppResponseDTO>> GetAppsAsync(PaginationQuery paginationQuery);
        Task<AppDetailResponseDTO> GetAppDetailsByIdAsync(int id);
        Task<AppDetailResponseDTO> GetAppDetailsByNameAsync(string name);       
        Task<bool> AddAppAsync(AppCreateDTO app);
        Task<bool> DeleteAppByIdAsync(int id);
        Task<bool> UpdateAppAsync(AppEditDTO app);      
    }
}
