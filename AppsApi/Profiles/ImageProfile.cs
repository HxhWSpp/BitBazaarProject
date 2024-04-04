using AppsApi.Data.Entities;
using AppsApi.DTOs.ImageDTOs;
using AppsApi.Profiles.Abstractions;

namespace AppsApi.Profiles
{
    public class ImageProfile : BaseProfile
    {
        public ImageProfile()
        {
            CreateMap<Image, ImageResponseDTO>();
            CreateMap<ImageRequestDTO, Image>();


            CreateMap<string, Image>().ForMember(dest => dest.ImagePath, opt => opt.MapFrom(src => src))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.Now)); ;
        }
    }
}
