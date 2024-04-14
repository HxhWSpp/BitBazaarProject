using AppsApi.Data.Entities;
using AppsApi.Data.Repositories.Abstractions;
using AppsApi.DTOs.AppDTOs;
using AppsApi.DTOs.GenreDTOs;
using AppsApi.Services.Abstractions;
using AutoMapper;
using Humanizer.Localisation;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace AppsApi.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;

        public GenreService(IGenreRepository repository , IMapper mapper)
        {
            _genreRepository = repository;
            _mapper = mapper;
        }
        public Task<bool> AddGenreAsync(GenreRequestDTO genre)
        {
            var genreEntity = _mapper.Map<Genre>(genre);
            return _genreRepository.AddAsync(genreEntity);
        }

        public Task<bool> DeleteGenreByIdAsync(int id)
        {
            return _genreRepository.DeleteByIdAsync(id);
        }

        public async Task<GenreDetailResponseDTO> GetGenreDetailsByIdAsync(int genreId)
        {
            var genreEntity = await _genreRepository.GetGenreDetailsByIdAsync(genreId);
            return _mapper.Map<GenreDetailResponseDTO>(genreEntity);
        }

        public async Task<GenreResponseDTO> GetGenreByIdAsync(int id)
        {
            var genreEntity = await _genreRepository.GetByIdAsync(id);
            return _mapper.Map<GenreResponseDTO>(genreEntity);
        }

        public async Task<GenreResponseDTO> GetGenreByNameAsync(string name)
        {
            var genreEntity = (await _genreRepository.GetAsync(item => item.Name == name)).FirstOrDefault();
            return _mapper.Map<GenreResponseDTO>(genreEntity);
        }

        public async Task<ICollection<GenreResponseDTO>> GetGenresAsync()
        {
            var genreList = (await _genreRepository.GetAllAsync(null)).ToList();
            return _mapper.Map<ICollection<GenreResponseDTO>>(genreList);
        }

        public Task<bool> UpdateGenreAsync(GenreRequestDTO genre)
        {
            var genreEntity = _mapper.Map<Genre>(genre);
            return _genreRepository.UpdateAsync(genreEntity);
        }
    }
}
