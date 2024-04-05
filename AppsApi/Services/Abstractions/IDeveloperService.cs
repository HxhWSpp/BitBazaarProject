using AppsApi.DTOs.DeveloperDTOs;

namespace AppsApi.Services.Abstractions
{
    public interface IDeveloperService
    {
        Task<ICollection<DeveloperDetailResponseDTO>> GetDevelopersAsync();
        Task<DeveloperDetailResponseDTO> GetDeveloperDetailsByIdAsync(int id);
        Task<DeveloperDetailResponseDTO> GetDeveloperDetailsByNameAsync(string name);
        Task<bool> AddDeveloperAsync(DeveloperRequestDTO dev);
        Task<bool> DeleteDeveloperByIdAsync(int id);
        Task<bool> UpdateDeveloperAsync(DeveloperRequestDTO dev);

       
        
    }
}
