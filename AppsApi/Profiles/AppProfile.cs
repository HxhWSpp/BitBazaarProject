using AppsApi.Data.Entities;
using AppsApi.DTOs.AppDTOs;
using AppsApi.Profiles.Abstractions;

namespace AppsApi.Profiles
{
    public class AppProfile : BaseProfile
    {
        public AppProfile()
        {
            CreateMap<App, AppResponseDTO>();
            CreateMap<AppRequestDTO, App>();
           
            CreateMap<AppCreateDTO, App>();

            CreateMap<App, AppDetailResponseDTO>();

            CreateMap<AppDetailResponseDTO, App>();
        }
    }
}
