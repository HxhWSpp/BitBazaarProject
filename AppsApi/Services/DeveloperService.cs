using AppsApi.Data.Entities;
using AppsApi.Data.Repositories;
using AppsApi.Data.Repositories.Abstractions;
using AppsApi.DTOs.DeveloperDTOs;
using AppsApi.DTOs.GenreDTOs;
using AppsApi.Services.Abstractions;
using AutoMapper;
using Humanizer.Localisation;

namespace AppsApi.Services
{
    public class DeveloperService : IDeveloperService
    {
        private readonly IDeveloperRepository _developerRepository;
        private readonly IMapper _mapper;

        public DeveloperService(IDeveloperRepository repository, IMapper mapper)
        {
            _developerRepository = repository;
            _mapper = mapper;
        }
        public Task AddDeveloperAsync(DeveloperCreateDTO dev)
        {
            var devEntity = _mapper.Map<Developer>(dev);
            return _developerRepository.AddAsync(devEntity);
        }

        public Task DeleteDeveloperByIdAsync(int id)
        {
            return _developerRepository.DeleteByIdAsync(id);
        }

        public async Task<DeveloperDetailResponseDTO> GetDeveloperByIdAsync(int id)
        {
            var devEntity = await _developerRepository.GetByIdAsync(id);
            return _mapper.Map<DeveloperDetailResponseDTO>(devEntity);
        }

        public async Task<DeveloperDetailResponseDTO> GetDeveloperByNameAsync(string name)
        {
            var devEntity = (await _developerRepository.GetAsync(item => item.Name == name)).FirstOrDefault();
            return _mapper.Map<DeveloperDetailResponseDTO>(devEntity);
        }

        public async Task<ICollection<DeveloperDetailResponseDTO>> GetDevelopersAsync()
        {
            var devList = (await _developerRepository.GetAllAsync()).ToList();
            return _mapper.Map<ICollection<DeveloperDetailResponseDTO>>(devList);
        }

        public Task UpdateDeveloperAsync(DeveloperRequestDTO dev)
        {
            var devEntity = _mapper.Map<Developer>(dev);
            return _developerRepository.UpdateAsync(devEntity);
        }

        
    }
}
