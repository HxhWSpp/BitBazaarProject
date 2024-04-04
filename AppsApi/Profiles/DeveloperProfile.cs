using AppsApi.Data.Entities;
using AppsApi.DTOs.DeveloperDTOs;
using AppsApi.Profiles.Abstractions;

namespace AppsApi.Profiles
{
    public class DeveloperProfile : BaseProfile
    {
        public DeveloperProfile()
        {
            CreateMap<DeveloperRequestDTO , Developer>();
            CreateMap<Developer, DeveloperDetailResponseDTO>();
            CreateMap<Developer, DeveloperResponseDTO>();
            CreateMap<DeveloperResponseDTO, Developer>();
           
        }
    }
}
