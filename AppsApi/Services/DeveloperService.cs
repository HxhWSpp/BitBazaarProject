using AppsApi.Data.Entities;
using AppsApi.Data.Repositories;
using AppsApi.Data.Repositories.Abstractions;
using AppsApi.DTOs.DeveloperDTOs;
using AppsApi.DTOs.GenreDTOs;
using AppsApi.Services.Abstractions;
using AppsApi.Utils;
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
        public async Task<bool> AddDeveloperAsync(DeveloperRequestDTO dev)
        {
            var devEntity = _mapper.Map<Developer>(dev);
            if(await _developerRepository.AddAsync(devEntity) == true)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteDeveloperByIdAsync(int id)
        {
            var image = ((await _developerRepository.GetByIdAsync(id)).ProfilePath).Substring(37);
            if (await _developerRepository.DeleteByIdAsync(id) == true)
            {
                Helper.DeleteImageLocally(image, "ImageProfiles");
                return true;
            }
            return false;
        }

        public async Task<DeveloperDetailResponseDTO> GetDeveloperDetailsByIdAsync(int id)
        {
            var devEntity = await _developerRepository.GetDeveloperDetailsByIdAsync(id);
            return _mapper.Map<DeveloperDetailResponseDTO>(devEntity);
        }

        public async Task<DeveloperDetailResponseDTO> GetDeveloperDetailsByNameAsync(string name)
        {
            var devEntity = (await _developerRepository.GetAsync(item => item.Name == name)).FirstOrDefault();
            return _mapper.Map<DeveloperDetailResponseDTO>(devEntity);
        }

        public async Task<ICollection<DeveloperDetailResponseDTO>> GetDevelopersAsync()
        {
            var devList = (await _developerRepository.GetAllAsync()).ToList();
            return _mapper.Map<ICollection<DeveloperDetailResponseDTO>>(devList);
        }

        public async Task<bool> UpdateDeveloperAsync(DeveloperRequestDTO dev)
        {
            var devEntity = _mapper.Map<Developer>(dev);
            if (await _developerRepository.UpdateAsync(devEntity) == true)
            {
                return true;
            }
            return false;
           
        }

        
    }
}
