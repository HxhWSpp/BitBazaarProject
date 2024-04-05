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
        Task<bool> AddGenreAsync(GenreRequestDTO genre);
        Task<bool> DeleteGenreByIdAsync(int id);
        Task<bool> UpdateGenreAsync(GenreRequestDTO genre);

        Task<GenreDetailResponseDTO> GetGenreDetailsByIdAsync(int genreId);

    }
}
