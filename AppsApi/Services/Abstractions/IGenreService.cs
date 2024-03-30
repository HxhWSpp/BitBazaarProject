using AppsApi.Data.Entities;
using AppsApi.DTOs.AppDTOs;
using AppsApi.DTOs.GenreDTOs;
using System.Reflection.Metadata;

namespace AppsApi.Services.Abstractions
{
    public interface IGenreService
    {
        Task<ICollection<GenreResponseDTO>> GetGenresAsync();
        Task<GenreResponseDTO> GetGenreByIdAsync(int id);
        Task<GenreResponseDTO> GetGenreByNameAsync(string name);       
        Task AddGenreAsync(GenreRequestDTO genre);
        Task DeleteGenreByIdAsync(int id);
        Task UpdateGenreAsync(GenreRequestDTO genre);

        Task<GenreDetailResponseDTO> GetAppsByGenreId(int genreId);

    }
}
