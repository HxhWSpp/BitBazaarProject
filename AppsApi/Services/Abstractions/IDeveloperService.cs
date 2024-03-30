using AppsApi.DTOs.DeveloperDTOs;

namespace AppsApi.Services.Abstractions
{
    public interface IDeveloperService
    {
        Task<ICollection<DeveloperDetailResponseDTO>> GetDevelopersAsync();
        Task<DeveloperDetailResponseDTO> GetDeveloperByIdAsync(int id);
        Task<DeveloperDetailResponseDTO> GetDeveloperByNameAsync(string name);
        Task AddDeveloperAsync(DeveloperCreateDTO dev);
        Task DeleteDeveloperByIdAsync(int id);
        Task UpdateDeveloperAsync(DeveloperRequestDTO dev);

       
        
    }
}
