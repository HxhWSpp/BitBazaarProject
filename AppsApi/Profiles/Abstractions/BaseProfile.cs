using AppsApi.Data.Entities.Abstractions;
using AppsApi.DTOs.Abstractions;
using AutoMapper;

namespace AppsApi.Profiles.Abstractions
{
    public class BaseProfile : Profile
    {
        public BaseProfile()
        {
            CreateMap<BaseEntity, BaseResponseDTO>();
            CreateMap<BaseRequestDTO, BaseEntity>();
        }
    }
}
